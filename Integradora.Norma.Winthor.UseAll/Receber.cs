using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ECommerce.UseAll.EntityOracle;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.UseAll
{
    class Receber : IProcessIntegration
    {
        public Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda { get; set; }
        public Integradora.ECommerce.UseAll.Integracao LojaEcommerce { get; set; }
        public decimal ContaGerencialContasPagar { get; set; }
        public string CobrancaTituloReceber { get; set; }
        public string CodigoFilial { get; set; }
        public decimal CodigoContaFaturaTerceiro { get; set; }
        public decimal CodigoContaFaturaAssociado { get; set; }
        public string CobrancaEnviadoUseAll { get; set; }

        public Receber()
        {
            PedidoForcaVenda = new Integradora.ERP.Winthor.Domain.PedidoWeb();
            LojaEcommerce = new Integradora.ECommerce.UseAll.Integracao();

            CarregarParametros();
        }

        private void CarregarParametros()
        {
            try
            {
                List<ESTPcpparametros> parametros = ESTPcpparametros.Listar(@"DESCRICAO IN ('USEALL_CODCOBRANCAFATURA'
                                                                                           ,'USEALL_CODCONTARECEITA'
                                                                                           ,'USEALL_CODFILIAL'
                                                                                           ,'CODCONTAFATURATERCEIRO'
                                                                                           ,'CODCONTAFATURAASSOCIADO'
                                                                                           ,'USEALL_COBRANCA'
                                                                                           )");

                foreach (var item in parametros)
                {
                    switch (item.Descricao)
                    {
                        case "USEALL_CODCOBRANCAFATURA":
                            CobrancaTituloReceber = item.Valor;
                            break;
                        case "USEALL_CODCONTARECEITA":
                            ContaGerencialContasPagar = Numbers.ToInt32(item.Valor);
                            break;
                        case "CODCONTAFATURATERCEIRO":
                            CodigoContaFaturaTerceiro = Numbers.ToInt32(item.Valor);
                            break;
                        case "CODCONTAFATURAASSOCIADO":
                            CodigoContaFaturaAssociado = Numbers.ToInt32(item.Valor);
                            break;
                        case "USEALL_CODFILIAL":
                            CodigoFilial = item.Valor;
                            break;
                        case "USEALL_COBRANCA":
                            CobrancaEnviadoUseAll = item.Valor;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "Receber", "Parâmetros não informado: " + ex.ToString());
            }
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ECommerce.UseAll.EntityOracle.ESVReplicacao.Load(" 1 =1  ORDER BY ACAO, REGISTRO");
            foreach (var item in lista)
            {
                //Criando a classe e carregando
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        switch (item.Tabela)
                        {
                            case "FATURA":
                                SendGerarFaturas(item);
                                break;
                            case "V_FATURAS_CANCELADAS":
                                SendEstornarFatura(item);
                                break;
                            case "OUTRASCOB_UC":
                                SendEstornarVenda(item);
                                break;
                        }
                        //Limpando a fila
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "Processs", ex);
                    }
                }
            }
        }

        private void SendEstornarVenda(ECommerce.UseAll.EntityOracle.ESVReplicacao item)
        {
            try
            {  //No estorno de venda, apenas retorna ao título o código de cobrança original
                {
                    //Listar título
                    Outrascob_Uc cobranca = null;
                    try
                    {
                        cobranca = Outrascob_Uc.Listar("idoutrascobuc = " + item.Registro.ToString()).Single();
                    }
                    catch(Exception ex)
                    {
                        string msg = "Dados da cobrança não encontrado no UseAll, registro: " + item.Registro.ToString() + " - Erro: " + ex.ToString();
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber"
                                          , "SendEstornarVenda"
                                          , msg);

                        Comum.GravarRegistro( item
                                            , "Estorna venda"
                                            , msg
                                            , "idoutrascobuc = " + item.Registro.ToString()
                                            , item.Titulo
                                            , false);

                        return;
                    }

                    PCClient cliente = ObterCliente(cobranca.Iduc);

                    if (cliente == null)
                    {
                        string msg = "Cliente não localizado, UC: " + cobranca.Iduc.ToString();
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber"
                                          , "SendEstornarVenda"
                                          , msg);
                        Comum.GravarRegistro( item
                                            , "Estorna venda"
                                            , msg
                                            , cobranca.Iduc.ToString()
                                            , item.Titulo
                                            , false);

                        return;
                    }

                    PCPrest titulo = ObterTituloPCPrest(item.Registro, cliente.Codcli, false);
                    if (titulo != null)
                    {
                        Persistencia ba = new Persistencia(PCPrest.GetStringConnection());
                        DateTime dataprocessamento = titulo.DataHoraServidor();

                        //Copia o título original
                        PCPrest contasaReceber = (PCPrest)titulo.Clone();
                        contasaReceber.Codcob = contasaReceber.Codcoborig;
                        contasaReceber.Dtcriacao = dataprocessamento.Date;
                        contasaReceber.Dtinclusao = dataprocessamento.Date;
                        contasaReceber.Rotinalanc = Biblioteca.Dictionaries.Settings.Rotina();
                        contasaReceber.Rotinalancultalt = contasaReceber.Rotinalanc.ToString();
                        contasaReceber.Codfuncinc = Biblioteca.Dictionaries.Settings.Matricula();
                        contasaReceber.Codfuncultalter = contasaReceber.Codfuncinc;
                        contasaReceber.Dtemissaoorig = titulo.Dtemissao.Date;
                        contasaReceber.Prest = GetProximoPrest(contasaReceber);
                        if (contasaReceber.Codsupervisor <= 0)
                            contasaReceber.Codsupervisor = Biblioteca.Dictionaries.Settings.CodSupervisor();
                        ba.Inserir(contasaReceber);

                        //Quita o titulo antigo
                        titulo.Dtpag = dataprocessamento.Date;
                        titulo.Vpago = titulo.Valor;
                        titulo.Dtbaixa = dataprocessamento.Date;
                        titulo.Codbaixa = contasaReceber.Codfuncultalter;
                        titulo.Codfuncdesd = contasaReceber.Codfuncultalter;
                        titulo.Dtfecha = dataprocessamento.Date;
                        titulo.Horafecha = contasaReceber.Horadesd;
                        titulo.Minutodesd = contasaReceber.Minutodesd;
                        titulo.Minutofecha = contasaReceber.Horadesd;
                        titulo.Minutodesd = contasaReceber.Minutodesd;
                        titulo.Codcob = "DESD";
                        titulo.Rotdesd = contasaReceber.Rotinalanc;
                        titulo.Rotinalancultalt = contasaReceber.Rotinalanc.ToString();
                        titulo.Dtdesd = dataprocessamento.Date;

                        ba.Alterar(titulo);

                        PCDesd desdobramento = new PCDesd();
                        desdobramento.Codclidest = contasaReceber.Codcli;
                        desdobramento.Codcliorig = contasaReceber.Codcli;
                        desdobramento.Codrotina = contasaReceber.Rotdesd;
                        desdobramento.Dtlanc = dataprocessamento.Date;
                        desdobramento.Dtultalt = desdobramento.Dtlanc;
                        desdobramento.Numtransvendaorig = titulo.Numtransvenda;
                        desdobramento.Prestorig = titulo.Prest;
                        desdobramento.Numtransvendadest = contasaReceber.Numtransvenda;
                        desdobramento.Prestdest = contasaReceber.Prest;

                        ba.Inserir(desdobramento);
                    }
                }
                Comum.GravarRegistro( item
                                    , "Estorna venda"
                                    , ""
                                    , ""
                                    , item.Titulo
                                    , true);
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarVenda", ex.ToString());
                Comum.GravarRegistro( item
                                    , "Estorna venda"
                                    , ex.ToString()
                                    , ""
                                    , item.Titulo
                                    , false);
            }
        }

        private void SendEstornarFatura(ECommerce.UseAll.EntityOracle.ESVReplicacao item)
        {
            string msgerro = "";
            double Numprest = 0;
            try
            {
                Fatura fatura = null;

                //Obtendo a lista de títulos relacionados na fatura
                try
                {
                    fatura = Fatura.Listar(string.Format("IDCODFATURA = {0}", item.Registro.ToString())).Single();
                }
                catch(Exception ex)
                {
                    msgerro = "Fatura não encontrada: " + item.Registro.ToString() + " - Erro: " + ex.ToString();
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", msgerro);
                    Comum.GravarRegistro( item
                                        , "Estorna fatura"
                                        , msgerro
                                        , ""
                                        , item.Titulo
                                        , false);

                    return;
                }

                PCClient cliente = ObterCliente(fatura.Iduc);
                if (cliente == null)
                {
                    string msg = "Não foi possível carregar cliente UC: " + fatura.Iduc.ToString();
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", msg);
                    Comum.GravarRegistro( item
                                        , "Estorna fatura"
                                        , msg
                                        , ""
                                        , item.Titulo
                                        , false
                                        );
                    return;
                }

                List<PCPrest> ListaDuplicataReferenteAVendas = null;
                try
                {
                    ListaDuplicataReferenteAVendas = ListarPCPrest(item, cliente.Codcli, true);
                }
                catch (Exception ex)
                {
                    string msg = "Não foi possível carregar vendas: " + item.Registro.ToString() + " - Erro: " + ex.ToString();
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", msg);
                    Comum.GravarRegistro( item
                                        , "Estorna fatura"
                                        , msg
                                        , ""
                                        , item.Titulo
                                        , false
                                        );
                    return;
                }

                //Cancelando o título da fatura
                PCPrest tituloFatura = null;
                try
                {
                    tituloFatura = PCPrest.Listar(string.Format("DUPLIC = {0} AND PREST = '1' AND CODCOB = '{1}' AND CODCLI = {2}  "
                                                                       , fatura.Numero_Fiscal
                                                                       , CobrancaTituloReceber
                                                                       , cliente.Codcli.ToString())).Single();
                }
                catch 
                {
                    string msg = "Titulo de energia não encontrado no Winthor: " + fatura.Numero_Fiscal + " cobrança: " + CobrancaTituloReceber + " cliente: " + cliente.Codcli.ToString();
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", msg);
                    Comum.GravarRegistro( item
                                        , "Estorna fatura"
                                        , msg
                                        , ""
                                        , item.Titulo
                                        , false
                                        );
                    return;
                }

                Persistencia ba = new Persistencia(PCPrest.GetStringConnection());
                DateTime dataprocessamento = fatura.DataHoraServidor();
                if (ListaDuplicataReferenteAVendas != null)
                {
                    if (ListaDuplicataReferenteAVendas.Count > 0)
                    {
                        string parcela = ListaDuplicataReferenteAVendas[0].Prest;
                        string Numtransvenda = ListaDuplicataReferenteAVendas[0].Numtransvenda.ToString();

                        foreach (var registro in ListaDuplicataReferenteAVendas)
                        {
                            if (registro.Valor > 0)
                            {
                                try
                                {
                                    //Iniciando o desdobramento
                                    PCDesd desdobramento = new PCDesd();
                                    desdobramento.Codclidest = registro.Codcli;
                                    desdobramento.Codcliorig = registro.Codcli;
                                    desdobramento.Codrotina = Biblioteca.Dictionaries.Settings.Rotina();
                                    desdobramento.Dtlanc = dataprocessamento.Date;
                                    desdobramento.Dtultalt = desdobramento.Dtlanc;
                                    desdobramento.Numtransvendaorig = registro.Numtransvenda;
                                    desdobramento.Prestorig = registro.Prest;

                                    //Reabrindo títulos
                                    registro.OID = "";

                                    registro.Prest = GetProximoPrest(registro);
                                    Numprest = Convert.ToDouble(registro.Prest);
                                    registro.Dtpag = null;
                                    registro.Vpago = 0;
                                    registro.Dtbaixa = null;
                                    registro.Codbaixa = null;
                                    registro.Codfuncdesd = Biblioteca.Dictionaries.Settings.Matricula();
                                    registro.Dtfecha = null;
                                    registro.Horafecha = null;
                                    registro.Horadesd = dataprocessamento.Hour;
                                    registro.Minutofecha = null;
                                    registro.Minutodesd = dataprocessamento.Minute;
                                    registro.Rotinalanc = desdobramento.Codrotina;
                                    registro.Rotinalancultalt = desdobramento.Codrotina.ToString();
                                    registro.Codcob = CobrancaEnviadoUseAll;
                                    registro.Codcoborig = CobrancaEnviadoUseAll;
                                    registro.Codfuncinc = Biblioteca.Dictionaries.Settings.Matricula();
                                    registro.Codfuncultalter = Biblioteca.Dictionaries.Settings.Matricula();
                                    registro.Dtdesd = dataprocessamento.Date;
                                    registro.Dtemissao = dataprocessamento.Date;
                                    registro.Dtinclusao = dataprocessamento.Date;
                                    registro.Dtultalter = dataprocessamento.Date;
                                    if (registro.Codsupervisor <= 0)
                                        registro.Codsupervisor = Biblioteca.Dictionaries.Settings.CodSupervisor();

                                    //Inserindo o novo título
                                    ba.Inserir(registro);

                                    //Complementando o desdobramento
                                    desdobramento.Numtransvendadest = registro.Numtransvenda;
                                    desdobramento.Prestdest = registro.Prest;
                                    //Inserindo desdobramento
                                    ba.Inserir(desdobramento);

                                    //Iniciando o desdobramento
                                    PCDesd desdobramentoFatura = new PCDesd();
                                    desdobramentoFatura.Codclidest = registro.Codcli;
                                    desdobramentoFatura.Codcliorig = registro.Codcli;
                                    desdobramentoFatura.Codrotina = Biblioteca.Dictionaries.Settings.Rotina();
                                    desdobramentoFatura.Dtlanc = dataprocessamento.Date;
                                    desdobramentoFatura.Dtultalt = desdobramento.Dtlanc;
                                    desdobramentoFatura.Numtransvendaorig = tituloFatura.Numtransvenda;
                                    desdobramentoFatura.Prestorig = tituloFatura.Prest;
                                    desdobramentoFatura.Numtransvendadest = registro.Numtransvenda;
                                    desdobramentoFatura.Prestdest = registro.Prest;
                                    //Inserindo desdobramento
                                    ba.Inserir(desdobramentoFatura);
                                }
                                catch (Exception ex)
                                {
                                    string msg = "Inserir titulo e desdobramento: " + ex.ToString();
                                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", msg);
                                    Comum.GravarRegistro( item
                                                        , "Estorna fatura"
                                                        , msg
                                                        , ""
                                                        , item.Titulo
                                                        , false
                                                        );
                                }

                            }
                            else
                            {
                                string msg = "Vendas não encontradas, menor que zero o valor";
                                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", msg);
                                Comum.GravarRegistro( item
                                                    , "Estorna fatura"
                                                    , msg
                                                    , ""
                                                    , item.Titulo
                                                    , false
                                                    );

                            }
                        }
                    }
                    else
                    {
                        string msg = "Vendas não encontradas";
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", "Vendas não encontradas");
                        Comum.GravarRegistro( item
                                            , "Estorna fatura"
                                            , msg
                                            , ""
                                            , item.Titulo
                                            , false
                                            );
                    }
                }
                else
                {
                    string msg = "Vendas não existe";
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", "Vendas não existe");
                    Comum.GravarRegistro( item
                                        , "Estorna fatura"
                                        , msg
                                        , ""
                                        , item.Titulo
                                        , false
                                        );
                }

                try
                {
                    //Quita o titulo da fatura
                    tituloFatura.Dtpag = tituloFatura.DataServidor();
                    tituloFatura.Vpago = tituloFatura.Valor;
                    tituloFatura.Dtbaixa = tituloFatura.Dtpag;
                    tituloFatura.Codbaixa = Biblioteca.Dictionaries.Settings.Matricula();

                    ba.Alterar(tituloFatura);

                    //Gera a contra partida
                    PCPrest estornoFatura = (PCPrest)tituloFatura.Clone();
                    {
                        estornoFatura.OID = "";
                        estornoFatura.Valor = estornoFatura.Valor * -1;
                        estornoFatura.Vpago = estornoFatura.Vpago * -1;
                        estornoFatura.Valororig = estornoFatura.Valororig * -1;
                        estornoFatura.Dtcancel = estornoFatura.Dtcancel;
                        estornoFatura.Codcob = "CANC";

                        estornoFatura.Prest = GetProximoPrest(estornoFatura);
                        if (Numprest == Convert.ToDouble(estornoFatura.Prest))
                        {
                            Numprest = Numprest + 1;
                            if (Numprest >= 100)
                            {
                                string msg = "O número de parcela excede 99 parcelas, verifique no banco! - Numtransvenda: " + estornoFatura.Numtransvenda.ToString();
                                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", msg);
                                Comum.GravarRegistro(item
                                                    , "Estorna fatura"
                                                    , "Número de parcela excede 99"
                                                    , ""
                                                    , item.Titulo
                                                    , false
                                                    );
                                return;
                            }
                            estornoFatura.Prest = Numprest.ToString();
                        }
                        ba.Inserir(estornoFatura);
                    }

                    try
                    {
                        PCLanc contasaPagar = PCLanc.Listar(string.Format("NUMNOTA = {0} AND DUPLIC = '1' AND PREST = '1' AND TIPOPARCEIRO = 'C' AND CODCONTA = {1} AND CODFORNEC = {2}"
                                                                         , tituloFatura.Duplic, ContaGerencialContasPagar, tituloFatura.Codcli)).FirstOrDefault();
                        if (contasaPagar != null)
                        {
                            contasaPagar.Valor = contasaPagar.Valor * -1;
                            contasaPagar.Recnum = contasaPagar.Proximo("PCCONSUM", "PROXNUMLANC");
                            contasaPagar.Numnota = fatura.Numero_Fiscal;
                            contasaPagar.Duplic = "1";
                            contasaPagar.Prest = "1";
                            contasaPagar.Dtlanc = dataprocessamento.Date;
                            contasaPagar.Tipoparceiro = "C";
                            contasaPagar.Codfuncultalter = Biblioteca.Dictionaries.Settings.Matricula();
                            contasaPagar.Codrotinacad = Biblioteca.Dictionaries.Settings.Rotina().ToString();
                            contasaPagar.Dtemissao = contasaPagar.Dtlanc;
                            contasaPagar.Dtultalter = contasaPagar.Dtlanc;
                            contasaPagar.Dtvenc = contasaPagar.Dtlanc;
                            contasaPagar.Dtcompetencia = fatura.Ano_Mes;
                            contasaPagar.Historico = "RECEITA REF FATURA ENERGIA ELETRICA";
                            contasaPagar.Parcela = "1";
                            contasaPagar.Dtpagto = contasaPagar.Dtlanc;
                            contasaPagar.Vpago = contasaPagar.Valor * -1;
                            contasaPagar.Codfuncbaixa = contasaPagar.Codfuncultalter;
                            contasaPagar.Codrotinabaixa = Biblioteca.Dictionaries.Settings.Rotina();

                            ba.Inserir(contasaPagar);
                        }
                    }
                    catch (Exception ex)
                    {
                        string msg = "Contas a pagar não encontrado - Erro: " +  ex.ToString();
                        Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", msg);
                        Comum.GravarRegistro( item
                                            , "Estorna fatura"
                                            , "Contas a pagar não encontrado"
                                            , ""
                                            , item.Titulo
                                            , false
                                            );
                    }
                }
                catch (Exception ex)
                {
                    string erro = "Duplicata da fatura não encontrado: " + ex.ToString();
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", erro);
                    Comum.GravarRegistro( item
                                        , "Estorna fatura"
                                        , ex.ToString()
                                        , ""
                                        , item.Titulo
                                        , false
                                        );
                }
                Comum.GravarRegistro( item
                                    , "Estorna fatura"
                                    , "Estorno de fatura realiado com sucesso!"
                                    , ""
                                    , item.Titulo
                                    , true
                                    );
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendEstornarFatura", ex);
                Comum.GravarRegistro( item
                                    , "Estorna fatura"
                                    , ex.ToString()
                                    , ""
                                    , item.Titulo
                                    , false
                                    );
            }
        }

        private string GetProximoPrest(PCPrest registro)
        {
            decimal novaParcela = registro.Maior("PCPREST", "(TO_NUMBER(LPAD(PREST,2,'0')))", "NUMTRANSVENDA = " + registro.Numtransvenda.ToString());
            if (novaParcela > 0)
            {
                novaParcela = novaParcela + 1;
            }
            return novaParcela.ToString();
        }

        private List<PCPrest> ListarPCPrest(ECommerce.UseAll.EntityOracle.ESVReplicacao item, decimal codigoCliente, bool baixado)
        {
            List<PCPrest> ListaDuplicatas = new List<PCPrest>();
            string Filtro = string.Format("(IDCODFATURA = {0}) AND (INSTR(HISTORICO, '-') > 0) AND (IDITEM = 7)"
                                                             , item.Registro.ToString());
            try
            {
                List<Outrascob_Uc> cobranca = Outrascob_Uc.Listar(Filtro);
                if (cobranca.Count() > 0)
                {
                    //Criando a lista de PCprest que será tratado

                    //Percorrer os titutlos dentro da fatura
                    foreach (var registro in cobranca)
                    {
                        //Obtendo a informação do título dentro da fatura
                        //Localizando o título na PCPrest
                        if (!string.IsNullOrEmpty(registro.Idoutrascobuc.ToString()))
                        {
                            PCPrest titulo = ObterTituloPCPrest(registro.Idoutrascobuc, codigoCliente, baixado);
                            if (titulo != null)
                            {   //Inserindo na lista de titulos a ser tratado
                                ListaDuplicatas.Add(titulo);
                            }
                        }
                    }
                }
                else
                {
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "ListarPCPrest", "Vendas não encontradas");
                    Comum.GravarRegistro( item
                                        , "Listar parcelas"
                                        , "Vendas não encontradas"
                                        , ""
                                        , item.Titulo
                                        , false
                                        );
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "ListarPCPrest", "Filtro: " + Filtro + "  Erro: " + ex.ToString());
                Comum.GravarRegistro( item
                                    , "Listar parcelas"
                                    , ex.ToString()
                                    , "Filtro: " + Filtro
                                    , item.Titulo
                                    , false
                                    );
            }


            return ListaDuplicatas;
        }

        private void SendGerarFaturas(ECommerce.UseAll.EntityOracle.ESVReplicacao item)
        {
            try
            {
                //Obtendo a lista de títulos relacionados na fatura
                Fatura fatura = Fatura.Listar(string.Format("IDCODFATURA = {0}", item.Registro.ToString())).FirstOrDefault();
                if (fatura == null)
                {
                    Comum.GravarRegistro(item, "Gerar faturas", "Fatura não encontrada no UseAll", "", item.Titulo, false);
                    return;
                }
                PCClient cliente = ObterCliente(fatura.Iduc);
                if (cliente == null)
                {
                    Comum.GravarRegistro(item, "Gerar faturas", "Cliente não encontrado para a UC", "", item.Titulo, false);
                    return;
                }

                PCPrest contasaReceber = null;
                try
                { //Verificando se a fatura já existe... caso já exita não importa de novo
                    contasaReceber = PCPrest.Listar(string.Format("DUPLIC = {0} AND PREST = '1' AND CODCOB = '{1}' AND CODCLI = {2}  "
                                                                      , fatura.Numero_Fiscal
                                                                      , CobrancaTituloReceber
                                                                      , cliente.Codcli.ToString())).FirstOrDefault();

                    if (contasaReceber != null)
                    {
                        if (contasaReceber.Codcli > 0)
                        {
                            Comum.GravarRegistro(item, "Gerar faturas", "Fatura já gerada", "", item.Titulo, true);
                            return;
                        }
                        else
                        {
                            contasaReceber = new PCPrest();
                        }
                    }
                    else
                    {
                        contasaReceber = new PCPrest();
                    }

                }
                catch
                {
                    contasaReceber = new PCPrest();
                }

                List<PCPrest> ListaPCPrest = ListarPCPrest(item, cliente.Codcli, false);
                Decimal ValorTitulo = 0;

                //Criando o novo titulo
                Persistencia ba = new Persistencia(PCPrest.GetStringConnection());
                DateTime dataprocessamento = contasaReceber.DataHoraServidor();
                bool GerarContasPagar = false;
                if (ListaPCPrest.Count > 0)
                {
                    //Copiando a estrutra de um dos título
                    contasaReceber.Codcli = ListaPCPrest[0].Codcli;

                    if (GerarNovoTituloFatura(fatura, contasaReceber, dataprocessamento, ba))
                    {
                        GerarContasPagar = true;
                        //Efetuar a baixa de todos os títulos
                        foreach (var registro in ListaPCPrest)
                        {
                            registro.Dtpag = contasaReceber.Dtcriacao;
                            registro.Vpago = registro.Valor;
                            registro.Dtbaixa = registro.Dtpag;
                            registro.Codbaixa = contasaReceber.Codfuncultalter;
                            registro.Codfuncdesd = contasaReceber.Codfuncultalter;
                            registro.Dtfecha = registro.Dtpag;
                            registro.Horafecha = contasaReceber.Horadesd;
                            registro.Minutodesd = contasaReceber.Minutodesd;
                            registro.Minutofecha = contasaReceber.Horadesd;
                            registro.Minutodesd = contasaReceber.Minutodesd;
                            registro.Codcob = "DESD";
                            registro.Rotdesd = Biblioteca.Dictionaries.Settings.Rotina();
                            registro.Dtdesd = dataprocessamento.Date;
                            if (registro.Codsupervisor <= 0)
                                registro.Codsupervisor = Biblioteca.Dictionaries.Settings.CodSupervisor();

                            ba.Alterar(registro);

                            PCDesd desdobramento = new PCDesd();
                            desdobramento.Codclidest = contasaReceber.Codcli;
                            desdobramento.Codcliorig = contasaReceber.Codcli;
                            desdobramento.Codrotina = contasaReceber.Rotdesd;
                            desdobramento.Dtlanc = dataprocessamento.Date;
                            desdobramento.Dtultalt = desdobramento.Dtlanc;
                            desdobramento.Numtransvendaorig = registro.Numtransvenda;
                            desdobramento.Prestorig = registro.Prest;

                            desdobramento.Numtransvendadest = contasaReceber.Numtransvenda;
                            desdobramento.Prestdest = contasaReceber.Prest;

                            ba.Inserir(desdobramento);
                            ValorTitulo = ValorTitulo + registro.Valor;
                        }
                    }
                }
                else
                {
                    if (GerarNovoTituloFatura(fatura, contasaReceber, dataprocessamento, ba))
                    {
                        ValorTitulo = contasaReceber.Valor * -1;
                        GerarContasPagar = true;
                    }

                }

                if (GerarContasPagar)
                {
                    string retorno = GerarContasPagar_NovoTitulo(fatura, contasaReceber, ValorTitulo, ba, dataprocessamento);
                    if (retorno != "OK")
                    {
                        Comum.GravarRegistro( item
                                            , "Gerar faturas"
                                            , "Erro ao gravar contas a pagar: " + retorno
                                            , ""
                                            , item.Titulo
                                            , false
                                            );
                    }
                    else
                    {
                        Comum.GravarRegistro( item
                                            , "Gerar faturas"
                                            , "Fatura gerada com sucesso!"
                                            , ""
                                            , item.Titulo
                                            , true
                                            );
                    }
                }
                else
                {
                    Comum.GravarRegistro( item
                                        , "Gerar faturas"
                                        , ""
                                        , ""
                                        , item.Titulo
                                        , true
                                        );
                }
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "SendGerarFaturas", ex);

                Comum.GravarRegistro( item
                                    , "Gerar faturas"
                                    , ex.ToString()
                                    , ""
                                    , item.Titulo
                                    , false
                                    );
            }
        }

        private string GerarContasPagar_NovoTitulo(Fatura fatura, PCPrest contasaReceber, Decimal ValorTitulo, Persistencia ba, DateTime dataprocessamento)
        {
            try
            {
                //Caso valor novo título seja maior que os escontrado no Winthor, gerar um PCLanc
                if ((ValorTitulo != 0) && (contasaReceber.Valor != ValorTitulo))
                {
                    if (contasaReceber.Codcli > 0)
                    {
                        PCLanc contasaPagar = new PCLanc();
                        contasaPagar.Recnum = contasaPagar.Proximo("PCCONSUM", "PROXNUMLANC");
                        contasaPagar.Numnota = fatura.Numero_Fiscal;
                        contasaPagar.Duplic = "1";
                        contasaPagar.Prest = "1";
                        contasaPagar.Dtlanc = dataprocessamento.Date;
                        contasaPagar.Tipoparceiro = "C";
                        contasaPagar.Codfornec = contasaReceber.Codcli;
                        contasaPagar.Codfilial = contasaReceber.Codfilial;
                        contasaPagar.Codfuncultalter = contasaReceber.Codfuncultalter;
                        contasaPagar.Codrotinacad = contasaReceber.Rotdesd.ToString();
                        contasaPagar.Dtemissao = contasaPagar.Dtlanc;
                        contasaPagar.Dtultalter = contasaPagar.Dtlanc;
                        contasaPagar.Dtvenc = contasaPagar.Dtlanc;
                        contasaPagar.Dtcompetencia = fatura.Ano_Mes;
                        contasaPagar.Historico = "RECEITA REF FATURA ENERGIA ELETRICA";
                        contasaPagar.Indice = "A";
                        contasaPagar.Moeda = "R";
                        contasaPagar.Parcela = "1";
                        contasaPagar.Valor = ValorTitulo - contasaReceber.Valor;
                        contasaPagar.Fornecedor = contasaReceber.Nomearquivo;
                        contasaPagar.Cotacao = 1;
                        contasaPagar.Dtpagto = contasaPagar.Dtlanc;
                        contasaPagar.Vpago = contasaPagar.Valor;
                        contasaPagar.Codfuncbaixa = contasaReceber.Codfuncultalter;
                        contasaPagar.Codrotinabaixa = Biblioteca.Dictionaries.Settings.Rotina();
                        contasaPagar.Codconta = contasaReceber.Obstitulo == "A" ? CodigoContaFaturaAssociado : CodigoContaFaturaTerceiro;

                        ba.Inserir(contasaPagar);
                    }
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        private bool GerarNovoTituloFatura(Fatura fatura, PCPrest contasaReceber, DateTime dataprocessamento, Persistencia ba)
        {
            bool retorno = false;
            PCClient cliente = null;
            try
            {
                if (contasaReceber.Codcli > 0)
                {
                    cliente = PCClient.Listar(string.Format("CODCLI = {0}", contasaReceber.Codcli.ToString())).FirstOrDefault();
                    if (cliente != null)
                    {
                        contasaReceber.Rotdesd = Biblioteca.Dictionaries.Settings.Rotina();
                        contasaReceber.Dtdesd = dataprocessamento.Date;
                    }
                }
                else
                {
                    cliente = ObterCliente(fatura.Iduc);
                    contasaReceber.Codcli = cliente.Codcli;
                }
                contasaReceber.Codusur = cliente.Codusur1;
                contasaReceber.Codplpag = cliente.Codplpag;
            }
            catch (Exception ex)
            {
                string msg = "Cliente não encontrado! UC: " + fatura.Iduc.ToString() + " - Erro: " + ex.ToString();
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "GerarNovoTituloFatura", msg);

                cliente = null;
            }

            if (cliente != null)
            {
                try
                {
                    contasaReceber.OID = "";
                    contasaReceber.Numtransvenda = contasaReceber.Proximo("PCCONSUM", "PROXNUMTRANSVENDA");
                    contasaReceber.Duplic = fatura.Numero_Fiscal;
                    contasaReceber.Prest = "1";
                    contasaReceber.Horadesd = dataprocessamento.Hour;
                    contasaReceber.Minutodesd = dataprocessamento.Minute;
                    contasaReceber.Codfuncultalter = Biblioteca.Dictionaries.Settings.Matricula();
                    contasaReceber.Dtcriacao = dataprocessamento.Date;
                    contasaReceber.Valor = fatura.Valor_Total;
                    contasaReceber.Dtvenc = Calendars.ToDateTime(fatura.Vcto);
                    contasaReceber.Codcob = CobrancaTituloReceber;
                    contasaReceber.Codcoborig = CobrancaTituloReceber;
                    contasaReceber.Agrupado = "N";
                    contasaReceber.Dtemissao = Biblioteca.Tools.Calendars.ToDateTime(fatura.Data_Emissao).Date;
                    contasaReceber.Dtemissaoorig = contasaReceber.Dtemissao;
                    contasaReceber.Dtinclusao = dataprocessamento.Date;
                    contasaReceber.Dtinclusaomanual = contasaReceber.Dtinclusao;
                    contasaReceber.Dtvencorig = fatura.Vcto;
                    contasaReceber.ESC_Dtreferencia = Calendars.ToDateTime(fatura.Ano_Mes);
                    contasaReceber.Obs = fatura.Idcodfatura.ToString();
                    contasaReceber.Valororig = fatura.Valor_Total;
                    contasaReceber.Nomearquivo = cliente.Cliente;
                    contasaReceber.Status = "A";
                    contasaReceber.Rotinalanc = Biblioteca.Dictionaries.Settings.Rotina();
                    contasaReceber.Obstitulo = string.IsNullOrEmpty(cliente.Esc_Tipocliente) ? "A" : cliente.Esc_Tipocliente;
                    if (contasaReceber.Codsupervisor <= 0)
                        contasaReceber.Codsupervisor = Biblioteca.Dictionaries.Settings.CodSupervisor();

                    if (fatura.Valor_Total == 0)
                    {
                        contasaReceber.Dtpag = dataprocessamento.Date;
                        contasaReceber.Vpago = 0;
                        contasaReceber.Dtbaixa = contasaReceber.Dtpag;
                    }
                    if (string.IsNullOrEmpty(contasaReceber.Codfilial))
                    {
                        contasaReceber.Codfilial = CodigoFilial;
                    }
                    if (string.IsNullOrEmpty(contasaReceber.Codfilialnf))
                    {
                        contasaReceber.Codfilialnf = CodigoFilial;
                    }
                }
                catch (Exception ex)
                {
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "GerarNovoTituloFatura", "Erro ao montar novo contas a pagar: " + fatura.Iduc.ToString() + " - Erro: " + ex.ToString() );
                    return false;
                }

                try
                {
                    V_Faturas_emitidas faturasemitidas = V_Faturas_emitidas.Listar(string.Format("nr_titulo = {0} and iduc = {1}"
                                                                                  , fatura.Numero_Fiscal.ToString()
                                                                                  , fatura.Iduc.ToString())).FirstOrDefault();
                    if (faturasemitidas != null)
                    {
                        contasaReceber.Codbarra = faturasemitidas.Barra;
                    }
                }
                catch (Exception ex)
                {
                    //Código de barra não localizado
                }

                try
                {
                    if (contasaReceber.Codcli > 0)
                    {
                        ba.Inserir(contasaReceber);
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                    }
                }
                catch (Exception ex)
                {
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "GerarNovoTituloFatura", ex);
                    retorno = false;
                }
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        private static PCClient ObterCliente(decimal Iduc)
        {
            PCClient cliente = null;
            try
            {
                cliente = PCClient.Listar(string.Format("TRIM(ESC_UC) = '{0}'", Iduc.ToString())).FirstOrDefault();
            }
            catch (Exception ex)
            {
                cliente = null;
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "ObterCliente", "Cliente não localizado com a UC: " + Iduc.ToString() + " - Erro: " + ex.ToString());
            }
            return cliente;
        }

        private PCPrest ObterTituloPCPrest(decimal registro, decimal codigoCliente, bool baixado)
        {
            Outrascob_Cergrand duplicata = null;
            string filtro = "";
            try
            {
                filtro = string.Format("IDOUTRASCOBUC = {0}", registro.ToString());
                duplicata = Outrascob_Cergrand.Listar(filtro).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber", "ObterTituloPCPrest", "Venda não encontrada em Outrascob_Cergrand:" + filtro + " - Erro: " + ex.ToString());
                duplicata = null;
            }

            PCPrest titulo = null;
            if (duplicata != null)
            {
                try
                {
                    string script = " (DUPLIC||PREST||NUMTRANSVENDA = '{0}') AND CODCLI = {1}  ";
                    script = script + (baixado ? " AND DTPAG IS NOT NULL " : " AND DTPAG IS NULL ");
                    script = script + " AND ROWNUM =1 ";
                    script = script + " FOR UPDATE ";

                    titulo = PCPrest.Listar(string.Format(script, duplicata.Ideverest.ToString(), codigoCliente.ToString())).Single();
                }
                catch (Exception ex)
                {
                    Processo.Notificar("Integradora.Norma.Winthor.UseAll.Receber"
                                 , "ObterTituloPCPrest"
                                 , string.Format("Titulo não encontrado (duplicata+parcela+transação): {0}. Será gerado somente a fatura de energia. - Erro: {1}"
                                               , duplicata.Ideverest.ToString(), ex.ToString()));
                    titulo = null;
                }
            }
            return titulo;
        }
    }
}
