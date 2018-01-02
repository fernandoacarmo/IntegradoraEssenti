using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Ajuri.Comum;
using Integradora.ECommerce.Ajuri.Metodos;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ERP.Winthor.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Ajuri
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.Ajuri.Integracao LojaECommerce { get; set; }
        public Enviar()
        {
            LojaECommerce = new ECommerce.Ajuri.Integracao();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            EnviarWinthor();
            EnviarAjuri();
        }

        #region Winthor para Ajuri
        private void EnviarAjuri()
        {
            var lista = ESVConcluidoWMS.Listar("1=1");
            if ((lista != null) && (lista.Count > 0))
            {
                EnviarAjuri entregador = new EnviarAjuri();
                foreach (var item in lista)
                {
                    bool retorno = false;

                    List<PCWmsoutput> WMSOutput = PCWmsoutput.Listar(item.SQLClausulaWhere());
                    if (WMSOutput.Count > 0)
                    {
                        switch (item.Tabela)
                        {   //Enviar registros conforme o tipo de documento de origem
                            case "ESTNOTAENTRADA": retorno = entregador.SendWebserviceEntrada(LojaECommerce, item, WMSOutput);
                                break;
                            case "ESTPEDIDOSAIDA": retorno = entregador.SendWebServiceSaida(LojaECommerce, item, WMSOutput);
                                break;
                            case "INVENTARIO": retorno = entregador.SendWebServiceInventario(LojaECommerce, item, WMSOutput);
                                break;
                        }
                    }
                    else
                    {
                        retorno = true;
                    }

                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            item.Save(retorno ? "3" : "4");
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Processo.Notificar("Integradora.Norma.Winthor.Ajuri.Enviar"
                                              , "EnviarAjuri"
                                              , "Erro ao gravar na tabela PCWMSOutput os dados do semaforo. Erro: " + ex.ToString());
                        }
                    }
                }
            }
        }
        #endregion

        #region Essenti para Winthor
        private void EnviarWinthor()
        {
            var lista = Integradora.ERP.Winthor.View.Esvsemaforo.Listar("SEMAFORO = 2 ORDER BY DTALTERACAO, TABELA");
            if ((lista != null) && (lista.Count > 0))
            {
                EnviarWinthor entregador = new EnviarWinthor();
                foreach (var item in lista)
                {
                    //Criando a classe e carregando
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            var integracao = Integradora.ERP.Winthor.View.Esvsemaforo.CreateClasse(item.Tabela
                                                                                                  , string.Format("rowid = '{0}'", item.Id));
                            //Caso tenha encontrado processa
                            if (integracao != null)
                            {
                                switch (item.Tabela)
                                {
                                    case "ESTCLIENTE": entregador.SendCliente((ESTCliente)integracao);
                                        break;
                                    case "ESTDEPARTAMENTO": entregador.SendDepartamento((ESTDepartamento)integracao);
                                        break;
                                    case "ESTFORNECEDOR": entregador.SendFornecedor((ESTFornecedor)integracao);
                                        break;
                                    case "ESTNOTAENTRADA": entregador.SendNotaEntrada((ESTNotaentrada)integracao);
                                        break;
                                    case "ESTPEDIDOSAIDA": entregador.SendPedidoDefinir((ESTPedidosaida)integracao);
                                        break;
                                    case "ESTMOVESTOQUE": entregador.SendMovimentacaoEstoque((ESTMovestoque)integracao);
                                        break;
                                    case "ESTPRACA": entregador.SendPraca((ESTPraca)integracao);
                                        break;
                                    case "ESTPRODUTO": entregador.SendProduto((ESTProduto)integracao);
                                        break;
                                    case "ESTROTA": entregador.SendRota((ESTRota)integracao);
                                        break;
                                    case "ESTSECAO": entregador.SendSecao((ESTSecao)integracao);
                                        break;
                                    case "ESTCANCELAMENTO": entregador.SendCancelamento((ESTCancelamento)integracao);
                                        break;
                                }
                                //Apaga a fila de replicação
                                int Posicao = (int)Biblioteca.Dictionaries.Tips.SemaforoPosicaoOMBoat.RecebimentoNoWinthor;
                                Integradora.ERP.Winthor.View.Esvsemaforo.Save(item, Posicao.ToString());

                                transaction.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Processo.Notificar("Integradora.Norma.Winthor.Ajuri.Enviar"
                                              , "EnviarWinthor"
                                              , "Erro ao enviar tabelas intermediárias para o WMS: " + ex.ToString());
                        }
                    }
                }
            }
        }
        #endregion
    }
}
