using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ECommerce.Magento002.MagentoService;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Magento002
{
    class Enviar : IProcessIntegration
    {
        public Integradora.ECommerce.Magento002.Integracao LojaECommerce { get; set; }

        public Enviar()
        {
            LojaECommerce = new ECommerce.Magento002.Integracao();
        }

        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
             var lista = Integradora.ERP.Winthor.Domain.ProcessarFila.LoadECommerce("");
            foreach (var item in lista)
            {
                //Criando a classe e carregando
                var integracao = Integradora.ERP.Winthor.Domain.ProcessarFila.CreateClasse(item.Tabela, "rowid = '" + item.Id + "'");
                bool sucesso = false;
                //Caso tenha encontrado processa
                if (integracao != null)
                {
                    switch (item.Tabela)
                    {
                        case "PCPEDC":
                            sucesso = SendPedido((PCPedc)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                            break;
                        case "PRODUTOMAGENTO":
                            sucesso = SendAjusteProduto((ProdutoMagento)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                            break;
                        case "PCEMBALAGEM":
                            sucesso = SendEmbalagem((PCEmbalagem)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                            break;
                        case "PCEST":
                            sucesso = SendEstoque((PCEst)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                            break;
                        case "PCPEDCTEMP":
                            sucesso = SendPedidoWeb((PCPedctemp)integracao, (Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao)item.Acao);
                            break;
                    }
                }

                if (sucesso)
                {
                    using (var transaction = new System.Transactions.CommittableTransaction())
                    {
                        try
                        {
                            Integradora.ERP.Winthor.Domain.ProcessarFila.Remove(item);

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Processo.Notificar("Integradora.Norma.Winthor.Magento002", "Send", ex);
                        }
                    }
                }
            }
        }

        private bool SendEstoque(PCEst registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                decimal qtde = registros.Qtestger - registros.Qtreserv - registros.Qtbloqueada;
                qtde = Math.Truncate( qtde / 2 );
                if (qtde < 0)
                {
                    qtde = 0;
                }

                LojaECommerce.EnviarEstoque(registros.Codprod.ToString(), qtde);
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento002.Enviar"
                             , "SendEstoque"
                             , "Produto: " + registros.Codprod.ToString()+ " erro: " + ex);
                return false;
            }

            return true;
        }

        private bool SendPedidoWeb(PCPedctemp registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            string email = "";
            try
            {
                email = PCClient.Listar("CODCLI = " + registros.Codcli.ToString()).FirstOrDefault().Email;
            }
            catch
            {
                email = "";
            }

            //Acao igual a zero, segnifica que foi reprovado o pagamento
            bool PodeExecutarIntregradora = false;
            if (replicacaoAcao == Integradora.Biblioteca.Dictionaries.Tips.ReplicacaoAcao.Incluir)
            {//Pagamento rejeitado
                Comum.MarcarPosicaoPedido( LojaECommerce
                                         , registros.Numpedcli
                                         , "Pagamento do pedido rejeitado! " + registros.Obs2
                                         , Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPagamentoRejeitado()
                                         , email);

                PodeExecutarIntregradora = false;
            }
            else
            {
                //Gerar o pagamento na loja e-commerce;
                LojaECommerce.GerarPagamento(registros.Numpedcli);

                //Pagamento aceito
                Comum.MarcarPosicaoPedido( LojaECommerce
                                         , registros.Numpedcli
                                         , "Pagamento realizado com sucesso! " + registros.Obs2
                                         , Integradora.Biblioteca.Dictionaries.Settings.MagentoStatusPagamentoAprovado()
                                         , email);
                PodeExecutarIntregradora = true;
            }


            //Atualizar situação do pedido
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    registros.ESC_AjustarFinanceiro = "N";
                    if (!registros.Gravar())
                    {
                        PodeExecutarIntregradora = false;
                    }
                    transaction.Commit();
                }
                catch (Exception erro)
                {
                    transaction.Rollback();
                    PodeExecutarIntregradora = false;
                    Logs.GerarLog( "Integradora.Norma.Winthor.Magento002.Enviar"
                                 , "SendPedidoWeb"
                                 , "Pedido: " + registros.Numpedcli + " erro: " + erro);
                    PodeExecutarIntregradora = false;
                }
            }

            if (PodeExecutarIntregradora)
            {
                Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda = new Integradora.ERP.Winthor.Domain.PedidoWeb();

                PodeExecutarIntregradora = Comum.ExecutarIntegradora(registros.Numpedrca, registros.Codusur, PedidoForcaVenda);
            }
            else
            {
                PodeExecutarIntregradora = true;
            }


            return PodeExecutarIntregradora;
        }

        private bool SendEmbalagem(PCEmbalagem registros, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                LojaECommerce.EnviarPreco(registros.Codprod.ToString(), registros.Pvendaweb);
            }
            catch (Exception ex)
            {
                Logs.GerarLog( "Integradora.Norma.Winthor.Magento002.Enviar"
                             , "SendEmbalagem"
                             , "Produto: " + registros.Codprod.ToString() + " erro: " + ex);
                return false;
            }

            return true;
        }

        private bool SendAjusteProduto(ProdutoMagento registro, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            try
            {
                string Product_Id = registro.Product_Id.ToString();
                catalogProductCreateEntity entidadeMagento = new catalogProductCreateEntity();
                associativeEntity[] AtributosAdicionais = new associativeEntity[1];
                AtributosAdicionais[0] = LojaECommerce.ProdutoAtributoCriar("ean", registro.Ean.ToString());

                entidadeMagento.additional_attributes = AtributosAdicionais;

                LojaECommerce.ProdutoAlterar(entidadeMagento, Product_Id);

                registro.Status = "I";
                registro.Gravar();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento002", "SendAjusteProduto"
                            , "Não foi possível ajustar o produto: " + registro.Sku.ToString()
                            + " - Erro: " + ex.ToString());
                return false;
            }

            return true;
        }

        private bool SendPedido(PCPedc registro, Biblioteca.Dictionaries.Tips.ReplicacaoAcao replicacaoAcao)
        {
            if (!string.IsNullOrEmpty(registro.Numpedweb.ToString()))
            {//Cancelamento de pedido
                if (registro.Dtcancel != null)
                {
                    if (!LojaECommerce.PedidoCancelar(registro.Numpedweb.ToString()))
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Magento002", "SendPedido"
                                    , "Não foi possível cancelar o pedido: " + registro.Numped.ToString());
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
