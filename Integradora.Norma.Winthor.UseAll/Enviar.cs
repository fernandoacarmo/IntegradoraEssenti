using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ECommerce.UseAll.EntityWebService;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.UseAll
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda { get; set; }
        public Integradora.ECommerce.UseAll.Integracao LojaEcommerce { get; set; }

        public Enviar()
        {
            PedidoForcaVenda = new Integradora.ERP.Winthor.Domain.PedidoWeb();
            LojaEcommerce = new Integradora.ECommerce.UseAll.Integracao();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("1=1 ORDER BY DTINCLUSAO, TABELA");
            foreach (var item in lista)
            {
                //Criando a classe e carregando
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        string filtro = string.Empty;
                        if (item.Tabela == "PCCLIENT")
                        {
                            filtro = string.Format("CODCLI = {0}", item.Id);
                        }
                        else
                        {
                            filtro = string.Format("rowid = '{0}'", item.Id);
                        }
                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);
                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela)
                            {
                                case "PCCLIENT": //Enviar clientes
                                    SendCliente((PCClient)integracao);
                                    break;
                                case "PCPREST": //Enviar títulos
                                    SendTitulo((PCPrest)integracao, item.Acao);
                                    break;
                            }
                            //Apaga a fila de replicação
                            Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar", "Processs", ex.ToString());
                    }
                }
            }
        }

        private void SendTitulo(PCPrest pcprest, decimal Acao)
        {
            switch (Convert.ToInt32(Acao))
            {
                case 0: InserirVenda(pcprest);
                    break;
                case 1: PagarCobranca(pcprest);
                    break;
                case 2: EstornarCobranca(pcprest);
                    break;
                default:
                    break;
            }
        }

        private void PagarCobranca(PCPrest pcprest)
        {
            if (GetUnidadeConsumidora(pcprest.Codcli) > 0)
            {
                string resultado;
                Fatura fatura = MontarFatura(pcprest);

                resultado = LojaEcommerce.PagarFatura(fatura);

                if (!string.IsNullOrEmpty(resultado))
                {
                    if (resultado.Substring(0, 1) != "1")
                    {
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar",
                                           "PagarCobranca",
                                            string.Format("Nº trans. venda: {0}, Prest: {1} - {2}", pcprest.Numtransvenda.ToString(), pcprest.Prest, resultado));
                    }
                    Comum.GravarRegistro( "PCPREST"  //string tabela, 
                                        , "NUMTRANSVENDA" //string coluna, 
                                        , pcprest.Numtransvenda //decimal registro, 
                                        , "Pagar Cobrança" //string metodo, 
                                        , resultado //string observacao, 
                                        , pcprest.Prest.ToString() //string complemento, 
                                        , pcprest.Duplic.ToString() //string documento, 
                                        , resultado.Substring(0, 1) == "1" //bool sucesso
                                        );
                }
            }
            else
            {
                string msg = string.Format("Nº trans. venda: {0}, Prest: {1} - Cliente {2} sem UC", pcprest.Numtransvenda.ToString(), pcprest.Prest, pcprest.Codcli.ToString());
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar",
                              "PagarCobranca",
                              msg);

                Comum.GravarRegistro( "PCPREST"  //string tabela, 
                                    , "NUMTRANSVENDA" //string coluna, 
                                    , pcprest.Numtransvenda //decimal registro, 
                                    , "Pagar Cobrança" //string metodo, 
                                    , msg //string observacao, 
                                    , pcprest.Prest.ToString() //string complemento, 
                                    , pcprest.Duplic.ToString() //string documento, 
                                    , false //bool sucesso
                                    );
            }
        }


        private Fatura MontarFatura(PCPrest pcprest)
        {
            Fatura fatura = new Fatura();
            const int NUMEDO_DE_DIAS_DE_CARENCIA_PARA_APOSENTADO = 10;

            fatura.addata_pagto = Integradora.Biblioteca.Tools.Calendars.ToDateTime(pcprest.Dtpag).ToString();
            fatura.anidAgente = 1;
            fatura.annumero_fiscal = Numbers.ToInt64(pcprest.Duplic.ToString());
            fatura.anvalor_pagto = pcprest.Valor;

            PCClient cliente = PCClient.Listar("CODCLI = " + pcprest.Codcli.ToString()).Single();
            fatura.aniduc = Numbers.ToInt32(cliente.Esc_UC);

            //Obtendo a data de vencimento real, desconsiderando sábado e domingo
            DateTime dataVencimento = pcprest.Dtvenc;
            switch (dataVencimento.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dataVencimento = dataVencimento.AddDays(1);
                    break;
                case DayOfWeek.Saturday:
                    dataVencimento.AddDays(2);
                    break;
                default:
                    break;
            }

            
            if (string.IsNullOrEmpty(pcprest.Esc_cobrajuros))
            {
                if (dataVencimento <= pcprest.Dtpag)
                {
                    if (cliente.Esc_Aposentado == "N")
                    {
                        fatura.ascobrar_multa = "S";
                    }
                    else
                    {
                        if (Calendars.GetDiffDays(pcprest.Dtvenc, pcprest.Dtpag, false) > NUMEDO_DE_DIAS_DE_CARENCIA_PARA_APOSENTADO)
                        {
                            fatura.ascobrar_multa = "S";
                        }
                        else
                        {
                            fatura.ascobrar_multa = "N";
                        }
                    }
                }
                else
                {
                    fatura.ascobrar_multa = "N";
                }

                if (fatura.ascobrar_multa == "S")
                {
                    if (pcprest.Esc_enviodebitoaut == "S")
                    {
                        fatura.ascobrar_multa = "N";
                    }
                }
            }
            else
            {   //Se esta marcado igual a Sim, e porque na baixa calculo o juros. Então não deve ser cobrado na próxima fatura 
                fatura.ascobrar_multa = pcprest.Esc_cobrajuros == "N" ? "S" : "N";
            }

            if (pcprest.ESC_Dtreferencia != null)
            {
                fatura.adanomes = pcprest.ESC_Dtreferencia.ToString();
            }
            else
            {
                try
                {
                    Integradora.ECommerce.UseAll.EntityOracle.Fatura faturaUseAll = Integradora.ECommerce.UseAll.EntityOracle.Fatura.Listar(string.Format("NUMERO_FISCAL = {0} AND IDUC = {1}", fatura.annumero_fiscal, fatura.aniduc)).Single();
                    fatura.adanomes = faturaUseAll.Ano_Mes.ToString();
                }
                catch
                {
                    fatura.adanomes = pcprest.Dtemissao.ToString();
                    try
                    {
                        if (pcprest.Prest != "1")
                        {
                            PCPrest duplicataorigional = PCPrest.Listar(string.Format("NUMTRANSVENDA = {0} AND PREST = '1'", pcprest.Numtransvenda.ToString())).Single();
                            if (duplicataorigional.ESC_Dtreferencia != null)
                            {
                                fatura.adanomes = duplicataorigional.ESC_Dtreferencia.ToString();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        fatura.adanomes = pcprest.Dtemissao.ToString();
                    }
                }

                pcprest.ESC_Dtreferencia = Convert.ToDateTime(fatura.adanomes);
                Persistencia ba = new Persistencia(PCPrest.GetStringConnection());
                ba.Alterar(pcprest);

            }

            return fatura;
        }

        private void EstornarCobranca(PCPrest pcprest)
        {
            //Somente envia se existir a conta 
            if (GetUnidadeConsumidora(pcprest.Codcli) > 0)
            {
                string resultado;
                Fatura fatura = MontarFatura(pcprest);

                resultado = LojaEcommerce.EstonarPagamento(fatura);

                if (!string.IsNullOrEmpty(resultado))
                {
                    if (resultado.Substring(0, 1) != "1")
                    {
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar",
                                      "EstornarCobranca",
                                      string.Format("Nº trans. venda: {0}, Prest: {1} - {2}", pcprest.Numtransvenda.ToString(), pcprest.Prest, resultado));
                    }

                    Comum.GravarRegistro( "PCPREST"
                                        , "NUMTRANSVENDA"
                                        , pcprest.Numtransvenda
                                        , "Estornar Cobrança"
                                        , resultado
                                        , pcprest.Prest.ToString()
                                        , pcprest.Duplic.ToString()
                                        , resultado.Substring(0, 1) == "1"
                                        );
                }
            }
            else
            {
                string msg = string.Format("Nº trans. venda: {0}, Prest: {1} - Cliente {2} sem UC", pcprest.Numtransvenda.ToString(), pcprest.Prest, pcprest.Codcli.ToString());
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar",
                              "EstornarCobranca", msg
                              );

                Comum.GravarRegistro( "PCPREST"
                                    , "NUMTRANSVENDA"
                                    , pcprest.Numtransvenda
                                    , "Estornar Cobrança"
                                    , msg
                                    , pcprest.Prest.ToString()
                                    , pcprest.Duplic.ToString()
                                    , false
                                    );
            }

        }

        private void InserirVenda(PCPrest pcprest)
        {
            Cobranca cobranca = new Cobranca();
            string resultado;

            cobranca.anidconta = GetUnidadeConsumidora(pcprest.Codcli);

            //Somente envia se existir a conta 
            if (cobranca.anidconta > 0)
            {
                switch (cobranca.anidconta.ToString().Length)
                {
                    case 9: cobranca.anidzona = Numbers.ToInt32(cobranca.anidconta.ToString().Substring(0, 2));
                        break;
                    case 8: cobranca.anidzona = Numbers.ToInt32('0' + cobranca.anidconta.ToString().Substring(0, 1));
                        break;
                    default: cobranca.anidzona = 0;
                        break;
                }
                cobranca.aniditem = 7; //Fixo

                //if (cobranca.anidconta.ToString().Length > 4)
                {
                    switch (cobranca.anidconta.ToString().Length)
                    {
                        case 9: cobranca.anidconta = Numbers.ToInt32(cobranca.anidconta.ToString().Substring(2, 7));
                            break;
                        case 8: cobranca.anidconta = Numbers.ToInt32(cobranca.anidconta.ToString().Substring(1, 7));
                            break;
                        default: cobranca.anidconta = 0;
                            break;
                    }
                }

                if (pcprest.ESC_Dtreferencia != null)
                {
                    cobranca.ananofatura = Calendars.ToDateTime(pcprest.ESC_Dtreferencia).Year;
                    cobranca.anmesfatura = Calendars.ToDateTime(pcprest.ESC_Dtreferencia).Month;
                }
                else
                {
                    cobranca.ananofatura = Calendars.ToDateTime(pcprest.Dtemissao).Year;
                    cobranca.anmesfatura = Calendars.ToDateTime(pcprest.Dtemissao).Month;
                    try
                    {
                        if (pcprest.Prest != "1")
                        {
                            PCPrest duplicataorigional = PCPrest.Listar(string.Format("NUMTRANSVENDA = {0} AND PREST = '1'", pcprest.Numtransvenda.ToString())).Single();
                            if (duplicataorigional.ESC_Dtreferencia != null)
                            {
                                cobranca.ananofatura = Calendars.ToDateTime(duplicataorigional.ESC_Dtreferencia).Year;
                                cobranca.anmesfatura = Calendars.ToDateTime(duplicataorigional.ESC_Dtreferencia).Month;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        cobranca.ananofatura = Calendars.ToDateTime(pcprest.Dtemissao).Year;
                        cobranca.anmesfatura = Calendars.ToDateTime(pcprest.Dtemissao).Month;
                    }
                }

                cobranca.addatalancto = DateTime.Now.ToShortDateString(); //Data da exportação
                cobranca.anvalor = pcprest.Valor;
                cobranca.asideverest = pcprest.Duplic.ToString() + pcprest.Prest + pcprest.Numtransvenda.ToString();

                cobranca.ashistorico = pcprest.Duplic.ToString() + "-" + pcprest.Prest;
                //cobranca.ashistorico = pcprest.Numtransvenda.ToString() + "-" + pcprest.Prest;
                if (cobranca.ashistorico.Length > 10)
                {
                    cobranca.ashistorico = cobranca.ashistorico.Substring(0, 10);
                }

                resultado = LojaEcommerce.InserirCobranca(cobranca);
                if (!string.IsNullOrEmpty(resultado))
                {
                    if (resultado.Substring(0, 1) != "1")
                    {
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar",
                                      "InserirCobranca",
                                      string.Format("Nº trans. venda: {0}, Prest: {1} - {2}", pcprest.Numtransvenda.ToString(), pcprest.Prest, resultado));
                    }

                    Comum.GravarRegistro( "PCPREST"
                                        , "NUMTRANSVENDA"
                                        , pcprest.Numtransvenda
                                        , "Inserir Cobrança"
                                        , resultado
                                        , pcprest.Prest.ToString()
                                        , pcprest.Duplic.ToString()
                                        , resultado.Substring(0, 1) == "1"
                                        );
                }
            }
            else
            {
                string msg = string.Format("Nº trans. venda: {0}, Prest: {1} - Cliente {2} sem UC", pcprest.Numtransvenda.ToString(), pcprest.Prest, pcprest.Codcli.ToString());
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar",
                              "InserirCobranca", msg
                              );

                Comum.GravarRegistro( "PCPREST"
                                    , "NUMTRANSVENDA"
                                    , pcprest.Numtransvenda
                                    , "Inserir Cobrança"
                                    , msg
                                    , pcprest.Prest.ToString()
                                    , pcprest.Duplic.ToString()
                                    , false
                                    );
            }
        }

        private long GetUnidadeConsumidora(decimal codigoCliente)
        {
            string retorno = "0";
            PCClient cliente = null;
            try
            {
                cliente = PCClient.Listar("CODCLI = " + codigoCliente.ToString()).Single();
            }
            catch
            {
                cliente = null;
            }

            if (cliente != null)
            {
                retorno = cliente.Esc_UC;
            }

            return Numbers.ToInt64(retorno);
        }


        private void SendCliente(PCClient cliente)
        {
            try
            {
                string resultado;
                Consumidor consumidor = new Consumidor();

                consumidor.anidconsumidor = Convert.ToInt64(cliente.Codcli.ToString());
                consumidor.anidassociado = Numbers.ToInt64(cliente.Esc_codassociado);
                consumidor.asnome = Formats.Cortar(cliente.Cliente, 60);
                consumidor.asnomeempresa = string.IsNullOrEmpty(cliente.Fantasia) ? consumidor.asnome : Formats.Cortar(cliente.Fantasia, 60);
                if (string.IsNullOrEmpty(cliente.Tipofj))
                {
                    consumidor.antipoinscricao = 2;
                }
                else
                {
                    consumidor.antipoinscricao = cliente.Tipofj.ToUpper() == "J" ? 1 : 2;
                }
                consumidor.asinscricao = Formats.Cortar(Numbers.OnlyNumbers(cliente.Cgcent), 18);

                consumidor.asinscricaoestadual = Formats.Cortar(Numbers.OnlyNumbers(cliente.Ieent, "ISENTO"), 22);
                consumidor.ascep = Formats.Cortar(Numbers.OnlyNumbers(cliente.Cepent, "-"), 8);
                consumidor.ascomplemento = string.IsNullOrEmpty(cliente.Complementoent) ? "-" : Formats.Cortar(cliente.Complementoent, 60);
                //Alterado para enviar 0 codigo 4163 a pedido da Renata (solicitação via email) - Eduardo Estevao - 20/09/2017
                consumidor.anidregiao = 4163; //  Numbers.ToInt64(cliente.Codpraca.ToString());
                consumidor.asfone1 = Formats.Cortar(Numbers.OnlyNumbers(cliente.Telent, "-"), 12);
                consumidor.asfone2 = Formats.Cortar(Numbers.OnlyNumbers(cliente.Telent1, "-"), 12);
                consumidor.asfone_celular = Formats.Cortar(Numbers.OnlyNumbers(cliente.Telcelent, "-"), 12);
                consumidor.addata_cadastro = cliente.Dtcadastro.ToString();
                consumidor.anidlocalentrega = 0;
                consumidor.asci = Formats.Cortar(Numbers.OnlyNumbers(cliente.Rg, "NI"), 14);
                consumidor.asci_orgao_emissor = string.IsNullOrEmpty(cliente.Orgaorg) ? "-" : Formats.Cortar(cliente.Orgaorg, 3);
                consumidor.asemail = string.IsNullOrEmpty(cliente.Email) ? "-" : Formats.Cortar(cliente.Email, 60);
                consumidor.asnomepai = string.IsNullOrEmpty(cliente.Filiacaopai) ? "-" : Formats.Cortar(cliente.Filiacaopai, 60);
                consumidor.asnomemae = string.IsNullOrEmpty(cliente.Filiacaomae) ? "-" : Formats.Cortar(cliente.Filiacaomae, 60);
                consumidor.asestadocivil = string.IsNullOrEmpty(cliente.Nomeconjuge) ? "S" : "C";
                consumidor.asnaturalidade = "-";
                consumidor.ancnae = Numbers.ToInt32(cliente.Codcnae);
                consumidor.andiavcto = Numbers.ToInt32(cliente.Esc_diavecto.ToString());
                if (consumidor.antipoinscricao == 1) //Pessoa Juridica
                {
                    try
                    {
                        PCAtivi ramoatividade = PCAtivi.Listar("CODATIV = " + cliente.Codatv1.ToString()).Single();
                        consumidor.asprofissao = Formats.Cortar(ramoatividade.Ramo, 30);
                    }
                    catch
                    {
                        consumidor.asprofissao = "-";
                    }
                    consumidor.asprofissao = string.IsNullOrEmpty(cliente.Cargo) ? "-" : Formats.Cortar(cliente.Cargo, 30);
                }
                else
                {
                    consumidor.asprofissao = string.IsNullOrEmpty(cliente.Cargo) ? "-" : Formats.Cortar(cliente.Cargo, 30);
                }

                resultado = LojaEcommerce.PersistirConsumidor(consumidor);


                if (!string.IsNullOrEmpty(resultado))
                {
                    if (resultado.Substring(0, 1) != "1")
                    {
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar",
                                      "SendCliente",
                                      string.Format("Cliente: {0} - {1}", cliente.Codcli.ToString(), resultado));
                    }
                    Comum.GravarRegistro( "PCCLIENT"
                                        , "CODCLI"
                                        , cliente.Codcli
                                        , "Inserir Cliente"
                                        , resultado
                                        , "UC: " + (string.IsNullOrEmpty(cliente.Esc_UC) ? "NI" : cliente.Esc_UC)
                                        , cliente.Codcli.ToString()
                                        , resultado.Substring(0, 1) == "1"
                                        );
                }

            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Enviar",
                              "SendCliente",
                              string.Format("Cliente: {0} - Erro: {1}", cliente.Codcli.ToString(), ex.ToString()));


                Comum.GravarRegistro( "PCCLIENT"
                                    , "CODCLI"
                                    , cliente.Codcli
                                    , "Inserir Cliente"
                                    , "Exceção: " + ex.ToString()
                                    , "UC: " + (string.IsNullOrEmpty(cliente.Esc_UC) ? "NI" : cliente.Esc_UC)
                                    , cliente.Codcli.ToString()
                                    , false
                                    );

            }
        }
    }
}
