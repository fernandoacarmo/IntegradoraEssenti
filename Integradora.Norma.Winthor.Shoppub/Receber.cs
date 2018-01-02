using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.ERP.Winthor.Domain;
using Integradora.ERP.Winthor.EntityEssenti;
using Integradora.ERP.Winthor.EntityWinthor;
using Integradora.ECommerce.Shoppub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Shoppub
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.Shoppub.Integracao LojaECommerce { get; set; }
        public PedidoWeb PedidoForcaVenda { get; set; }

        public Receber()
        {
            LojaECommerce = new ECommerce.Shoppub.Integracao();
            PedidoForcaVenda = new PedidoWeb();
        }
        public void Process(Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {
            ObterPedidosVenda();
        }

        private void ObterPedidosVenda()
        {
            //            TrayPedido pedido = LojaECommerce.ObterPedido("13770");
            //            Biblioteca.Tools.JSON.Export(pedido, "13770");
            //            string text = pedido.Order.id;
            //            
            //            TrayPedidoPagamento PagamentoPedido = LojaECommerce.ListarPedidosPagto("11914");
            //            text = PagamentoPedido.Payment.modified;
            try
            {
                ShoppubListaPedidos ListaPedidos = null;
                //Obtendo a lista de pedidos
                ListaPedidos = LojaECommerce.ObterPedidos(Tips.Status_resumido.Pago);
                //Exportar o resultado da lista de pedidos para arquivos json
                if (ListaPedidos != null)
                {
                    Biblioteca.Tools.JSON.Export(ListaPedidos, "listapedidos.json");
  
                  //  ProcessarListaPedidos(ListaPedidos);
                }

                //Obtendo a lista de pedidos
              //  ListaPedidos = LojaECommerce.ListarPedidos("A ENVIAR TRAYCHECKOUT");
                //Exportar o resultado da lista de pedidos para arquivos json
               // if (ListaPedidos != null)
               // {
               //     ProcessarListaPedidos(ListaPedidos);
              //  }
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Shoppub"
                                     , "ObterPedidosVenda"
                                     , "Erro ao listar pedidos: " + ex.ToString()
                                     );
            }

        }

        private static bool ExecutarIntegradora(Integradora.ERP.Winthor.Domain.PedidoWeb PedidoForcaVenda)
        {
            if (Biblioteca.Dictionaries.Settings.Debugando())
            {
                Logs.GerarLog("Integradora.Norma.Winthor.Shoppub"
                                , "ExecutarIntegradora"
                                , "Executando integradora do Winthor no pedido: " + PedidoForcaVenda.Cabecalho.Numpedrca.ToString());
            }
            bool importado = false;
            using (var transaction = new System.Transactions.CommittableTransaction())
            {
                try
                {
                    PedidoForcaVenda.IntegrarPedido_Modelo_01(PedidoForcaVenda.Cabecalho.Numpedrca, PedidoForcaVenda.Cabecalho.Codusur);
                    transaction.Commit();
                    importado = true;
                    if (Biblioteca.Dictionaries.Settings.Debugando())
                    {
                        Logs.GerarLog("Integradora.Norma.Winthor.Shoppub"
                                , "ExecutarIntegradora"
                                , "Concluido a integradora do Winthor no pedido: " + PedidoForcaVenda.Cabecalho.Numpedrca.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    importado = false;
                    Logs.GerarLog("Integradora.Norma.Winthor.Shoppub"
                                , "ExecutarIntegradora"
                                , string.Format("Erro ao executar integradora - pedido: {0} - Erro: {1} ", PedidoForcaVenda.Cabecalho.Numpedrca, ex.ToString())
                                );
                }
            }
            return importado;
        }
    }
}
