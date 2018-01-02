using Integradora.Biblioteca.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Magento001
{
    public class Comum
    {
        static internal void MarcarPosicaoPedido(Integradora.ECommerce.Magento001.Integracao LojaECommerce
                                        , string numeroPedidoEcommerce
                                        , string retorno
                                        , string statusPedido
                                        , string email
                                        , string numperoPedidoERP)
        {
            try
            {
                LojaECommerce.PedidosAtualizarStatus(numeroPedidoEcommerce                                  //string numeroPedidoECommerce     
                                                    , statusPedido                                          //string novoStatus
                                                    , retorno                                               //string comentario
                                                    , Integradora.Biblioteca.Dictionaries.Tips.SimNao.Sim   //Integradora.Biblioteca.Dictionaries.Tips.SimNao enviarMsg
                                                    , numperoPedidoERP                                      //string numeroPedidoERP
                                                    , ""                                                    //string numeroPedidoMarketPlace
                                                    , email                                                 //string eMailCliente
                                                    , ""                                                    //string chaveNFe
                                                    , ""                                                    //string serieNF
                                                    , ""                                                    //string numeroNF)
                                                    );
            }
            catch (Exception erro)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Comum"
                                                  , "MarcarPosicaoPedido"
                                                  , "Pedido: " + numeroPedidoEcommerce + " erro: " + erro);
            }
        }

        static internal bool ExecutarIntegradora(decimal numPedido, decimal codRCA, Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Logs.GerarLog( "Integradora.Norma.Winthor.Magento001.Comum"
                             , "ExecutarIntegradora"
                             , "Executando integradora do Winthor no pedido: " + numPedido.ToString());
            }
            bool importado = false;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    PedidoForcaVenda.IntegrarPedido_Modelo_01(numPedido, codRCA);
                    transaction.Commit();
                    importado = true;
                    if (Biblioteca.Dictionaries.Settings.Debugando())
                    {
                        Logs.GerarLog( "Integradora.Norma.Winthor.Magento001.Comum"
                                     , "ExecutarIntegradora"
                                     , "Concluido a integradora do Winthor no pedido: " + numPedido.ToString());
                    }
                }
                catch (Exception erro)
                {
                    transaction.Rollback();
                    importado = false;
                    Logs.GerarLog("Integradora.Norma.Winthor.Magento001.Comum"
                                                      , "ExecutarIntegradora"
                                                      , "Pedido: " + numPedido.ToString() + " erro: " + erro);
                }
            }
            return importado;
        }
    }
}
