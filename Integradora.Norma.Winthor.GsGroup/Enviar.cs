using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.GsGroup.GerenciaVendaWS;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.Select;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.GsGroup
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.GsGroup.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.GsGroup.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("");
            foreach (var item in lista)
            {
                using (var transaction = new System.Transactions.CommittableTransaction())
                {
                    try
                    {
                        if (Biblioteca.Dictionaries.Settings.Debugando())
                        {
                            Logs.GerarLog("Integradora.Norma.Winthor.GsGroup", "Process", "Enviar: " + item.Tabela);
                        }

                        string filtro = "OID = '" + item.Id + "'";

                        //Criando a classe e carregando
                        if (item.Tabela.Substring(0, 2) == "VW")
                            filtro = "B." + filtro;

                        var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, filtro);

                        //Caso tenha encontrado processa
                        if (integracao != null)
                        {
                            switch (item.Tabela.ToString())
                            {
                                case "VWCUPOMFISCAL":
                                    //SendCupom((VWCupomFiscal)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                                    EnviarVendaNovoModelo((VWCupomFiscal)integracao);
                                    break;
                            }
                        }
                        else
                        {
                            if (Biblioteca.Dictionaries.Settings.Debugando())
                            {
                                Logs.GerarLog("Integradora.Norma.Winthor.GsGroup", "Process", string.Format("Nenhum registro encontrado para a tabela: {0} - Filtro: {1}", item.Tabela, filtro));
                            }
                        }

                        Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                        transaction.Commit();
                    }
                    catch (System.Exception ex)
                    {
                        transaction.Rollback();
                        Processo.Notificar("Integradora.Norma.Winthor.GsGroup", "Process", ex);
                    }
                }
            }
        }

        private void SendCupom(VWCupomFiscal registro, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string retorno = "";
            try
            {

                if (!Validacao.CPFCNPJ(registro.Documento, false))
                {
                    Processo.Notificar("Integradora.Norma.Winthor.GsGroup"
                                      , "SendCupom"
                                      , string.Format("CNPJ/CPF inválido! Nº transação: {0} - CPJ/CNPJ: {1},"
                                                     , registro.Numtransvenda.ToString()
                                                     , registro.Documento));
                    return;
                }

                string codigohash = string.Format("{0} - {1}", registro.Documento, DateTime.Now.ToString("dd/MM/yyyy"));
                codigohash = Biblioteca.Tools.MD5.HashMD5(codigohash);

                if (Biblioteca.Dictionaries.Settings.Debugando())
                {
                    Logs.GerarLog("Integradora.Norma.Winthor.GsGroup", "SendCupom", string.Format("Enviando documento: {0}, cupom: {1}, filial: {2}", registro.Documento, registro.Numcupom, registro.Codfilial));
                }

                if (registro.CodGSGroup.ToString() == "150")
                {

                    retorno = LojaECommerce.NotificarVendaMatriz(registro.Documento
                                                                , registro.Numcupom
                                                                , Convert.ToDateTime( registro.Datahora )
                                                                , Numbers.ToInt16(registro.CodGSGroup.ToString())
                                                                , registro.PDV
                                                                , Numbers.ToInt16(registro.Categoriaproduto.ToString())
                                                                , registro.Valor
                                                                , codigohash
                                                                );


                }
                else
                {
                    retorno = LojaECommerce.NotificarVendaFilial(registro.Documento
                                                                , registro.Numcupom
                                                                , Convert.ToDateTime(registro.Datahora)
                                                                , Numbers.ToInt16(registro.CodGSGroup.ToString())
                                                                , registro.PDV
                                                                , Numbers.ToInt16(registro.Categoriaproduto.ToString())
                                                                , registro.Valor
                                                                , codigohash
                                                                );
                }


                if (retorno != "Operação realizada com sucesso.")
                {
                    Processo.Notificar("Integradora.Norma.Winthor.GsGroup"
                                      , "SendCupom"
                                      , string.Format("Erro na importação! Nº transação: {0} - Mensagem: {1}", registro.Numtransvenda.ToString(), retorno));
                }
                else
                {
                    Processo.Notificar("Integradora.Norma.Winthor.GsGroup"
                                      , "SendCupom"
                                      , string.Format("Resultado Nº transação: {0} - Mensagem: {1}", registro.Numtransvenda.ToString(), retorno));
                }

            }
            catch (System.Exception ex)
            {
                Processo.Notificar("Integradora.Norma.Winthor.GsGroup"
                                  , "SendCupom"
                                  , string.Format("Cupom não enviado: {0}, retorno: {1}, erro: {2}"
                                                 , registro.Documento.ToString()
                                                 , retorno
                                                 , ex.ToString()));
            }
        }

        private void EnviarVendaNovoModelo(VWCupomFiscal registro)
        {
            string retorno = "";

            wsVenda cabecalho = new wsVenda();
            cabecalho.cpf = registro.Documento;
            if (string.IsNullOrEmpty(cabecalho.cpf))
                cabecalho.cpf = "00000000000";
            cabecalho.numerocupom = Numbers.ToInt32(registro.Numcupom.ToString());
            cabecalho.datahora = Convert.ToDateTime( registro.Datahora );
            cabecalho.datahoraSpecified = true;
            cabecalho.loja = Numbers.ToInt16(registro.CodGSGroup.ToString());
            cabecalho.pdv = registro.PDV;
            cabecalho.valor = Convert.ToDouble(registro.Valor);

            wsPagamento parcela = new wsPagamento();
            parcela.valor = cabecalho.valor;
            parcela.codigoformapagamento = 1;//Numbers.ToInt16(registro.Codplpag.ToString());
            wsPagamento[] listaparcelas = new wsPagamento[1];
            listaparcelas[0] = parcela;

            List<VWCupomFiscalItem> ListaitensNaVenda = VWCupomFiscalItem.Listar("NUMTRANSVENDA = " + registro.Numtransvenda.ToString());

            wsItemVenda[] listaitens = new wsItemVenda[ListaitensNaVenda.Count()];
            int i = 0;
            foreach (var itemNaVenda in ListaitensNaVenda)
            {
                wsItemVenda item = new wsItemVenda();
                item.codigobarraproduto = itemNaVenda.Codauxiliar.ToString();
                item.descricaoproduto = itemNaVenda.Descricao;
                item.quantidade = Convert.ToDouble(itemNaVenda.Quantidade);
                item.valorunitario = Convert.ToDouble(itemNaVenda.Valor);
                listaitens[i] = item;
                i++;
            }
            
            retorno = LojaECommerce.NotificarVenda(cabecalho, listaitens, listaparcelas);

            if (retorno != "Operação realizada com sucesso.")
            {
                Processo.Notificar("Integradora.Norma.Winthor.GsGroup"
                                  , "EnviarVendaNovoModelo"
                                  , string.Format("Erro na importação! Nº transação: {0} - Mensagem: {1}", registro.Numtransvenda.ToString(), retorno));
            }
            else
            {
                Processo.Notificar("Integradora.Norma.Winthor.GsGroup"
                                  , "EnviarVendaNovoModelo"
                                  , string.Format("Resultado Nº transação: {0} - Mensagem: {1}", registro.Numtransvenda.ToString(), retorno));
            }
        }
    }
}
