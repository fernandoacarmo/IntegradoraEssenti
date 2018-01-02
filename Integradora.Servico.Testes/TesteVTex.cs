using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Integradora.Servico.Testes
{
    [TestClass]
    public class TesteVTex
    {
        /// <summary>
        /// Movimentação de caixa
        /// </summary>
        [TestMethod]
        public void TesteVTexMovimentarCaixa()
        {
            Integradora.ERP.Winthor.Domain.MovimentarCaixa Teste = new Integradora.ERP.Winthor.Domain.MovimentarCaixa();
            Teste.LancarMovimento(Integradora.Biblioteca.Dictionaries.Tips.OperacaoFinanceira.Debito,
                                  1000,
                                  1,
                                  1,
                                  "ZZZZ",
                                  "",
                                  "123");


            Assert.IsTrue(true);
        }

        /// <summary>
        /// Movimentação de caixa
        /// </summary>
        [TestMethod]
        public void TesteVTexImportarPedido()
        {
            Integradora.Norma.Winthor.VTex.Receber Teste = new Integradora.Norma.Winthor.VTex.Receber();
            Teste.VTex_Pedido_Winthor("MLB-1328972988"); 

            

            

            //631860036733-01");
            //Teste.VTex_enviar_pedidos();

            Assert.IsTrue(true);
        }


        /// <summary>
        /// Integração VTex
        /// </summary>
        [TestMethod]
        public void TesteVTexMudarStatus()
        {
            Integradora.ECommerce.VTex.Orders.Pedido Teste = new Integradora.ECommerce.VTex.Orders.Pedido();

            Teste.Faturado("565013175594-01", "");
            //Teste.Cancelar("530673554496-01");

            Assert.IsTrue(true);
        }
    }
}
