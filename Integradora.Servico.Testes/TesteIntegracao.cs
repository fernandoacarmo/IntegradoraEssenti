using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integradora.Biblioteca.Dictionaries;

namespace Integradora.Servico.Testes
{
    [TestClass]
    public class TesteIntegracao
    {
        /// <summary>
        /// Executar a integradora enviada por parâmetro
        /// </summary>
        private bool Executar(Tips.Modelo modelo)
        {
            int quantidadeLoop = 1; // Número de vezes que vai rodar o teste;
            bool retorno = false;

            try
            {//Criando e executando a integradora selecionada
                Integradora.Servico.Executor Testador = new Integradora.Servico.Executor(quantidadeLoop, modelo);
                retorno = true;
            }
            catch
            {
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Integração UseAll
        /// </summary>
        [TestMethod]
        public void TesteExecucaoUseAll()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_UseAll));
        }

        /// <summary>
        /// Integração Magento 001
        /// </summary>
        [TestMethod]
        public void TesteExecucaoMagento001()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_Magento001));
        }

        /// <summary>
        /// Importar pedido magento
        /// </summary>
        [TestMethod]
        public void TesteExecucaoMagento001_PedidoVenda()
        {
            Integradora.Norma.Winthor.Magento001.Receber magento = new Integradora.Norma.Winthor.Magento001.Receber();

            var pedido = magento.LojaECommerce.PedidosCarregar("100000147");
            bool resultado = magento.PedidoImportar(pedido, false).sucesso;
            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// Importar pedido magento
        /// </summary>
        [TestMethod]
        public void TesteExecucaoMagento001_PedidoPagamento()
        {
            Integradora.Norma.Winthor.Magento001.Receber magento = new Integradora.Norma.Winthor.Magento001.Receber();

            var pedido = magento.LojaECommerce.PedidosCarregar("41000117");
            if (pedido != null)
            {
                string resultado = magento.PagamentoImportar(pedido, false);
                Assert.IsTrue(resultado == "OK");
            }
            else
            {
                Assert.IsTrue(false);
            }
        }


        /// <summary>
        /// Integração Magento 002
        /// </summary>
        [TestMethod]
        public void TesteExecucaoMagento002()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_Magento002));
        }

        /// <summary>
        /// Importar pedido magento
        /// </summary>
        [TestMethod]
        public void TesteExecucaoMagento002_Pedido()
        {
            Integradora.Norma.Winthor.Magento002.Receber magento = new Integradora.Norma.Winthor.Magento002.Receber();

            var pedido = magento.LojaECommerce.PedidosCarregar("100000032");
            string resultado = magento.PedidoImportar(pedido, false);
            Assert.IsTrue(resultado == "OK");
        }

        /// <summary>
        /// Pagamento do pedido magento
        /// </summary>
        [TestMethod]
        public void TesteExecucaoMagento002_Pagamento()
        {
            Integradora.Norma.Winthor.Magento002.Receber magento = new Integradora.Norma.Winthor.Magento002.Receber();

            var pedido = magento.LojaECommerce.PedidosCarregar("⁠⁠⁠100000091");
            string resultado = magento.PedidoReceber(pedido);
            Assert.IsTrue(resultado == "OK");
        }

        /// <summary>
        /// Integração FBits
        /// </summary>
        [TestMethod]
        public void TesteExecucaoFBits()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_FBits));
        }

        /// <summary>
        /// Integração DataHub
        /// </summary>
        [TestMethod]
        public void TesteExecucaoDataHub()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_DataHub));
        }

        /// <summary>
        /// Integração DataHub
        /// </summary>
        [TestMethod]
        public void TesteExecucaoTray()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_Tray));
        }

        /// <summary>
        /// Integração IShopping
        /// </summary>
        [TestMethod]
        public void TesteExecucaoIShopping()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_IShopping));
        }

        /// <summary>
        /// Integração Virtuemart
        /// </summary>
        [TestMethod]
        public void TesteExecucaoVirtuemart()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_Virtuemart));
        }

        /// <summary>
        /// Integração Corpem
        /// </summary>
        [TestMethod]
        public void TesteExecucaoCorpem()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_Corpem));
        }

        /// <summary>
        /// Integração Ajuri
        /// </summary>
        [TestMethod]
        public void TesteExecucaoAjuri()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_Ajuri));
        }

        /// <summary>
        /// Integração GsGroup
        /// </summary>
        [TestMethod]
        public void TesteExecucaoGsGroup()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_GsGroup));
        }

        /// <summary>
        /// Integração OnLineShop
        /// </summary>
        [TestMethod]
        public void TesteExecucaoOnLineShop()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_OnLineShop));
        }


        /// <summary>
        /// Integração OnLineShop
        /// </summary>
        [TestMethod]
        public void TesteExecucaoOnLineShopVTex()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_OnLineShopVTex));
        }

        /// <summary>
        /// Integração VTiger
        /// </summary>
        [TestMethod]
        public void TesteExecucaoVTiger()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_VTiger));
        }

        /// <summary>
        /// Integração VTex
        /// </summary>
        [TestMethod]
        public void TesteExecucaoVTex()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_VTex));
        }

        /// <summary>
        /// Integração Protheus
        /// </summary>
        [TestMethod]
        public void TesteExecucaoProtheus()
        {
            Assert.IsTrue(Executar(Tips.Modelo.Winthor_Protheus));
        }

        /// <summary>
        /// Integração VTex
        /// </summary>
        [TestMethod]
        public void TesteExecucaoDataHubEcho()
        {
            Integradora.ECommerce.DataHub.Inherited.WebService datahub = new Integradora.ECommerce.DataHub.Inherited.WebService();
            string resultado = datahub.Echo();
            Assert.IsTrue(Convert.ToDateTime(resultado) == DateTime.Today);
        }

    }
}
