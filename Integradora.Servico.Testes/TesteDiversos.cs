using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Canducci.Zip;
using Integradora.ECommerce.Shoppub;

namespace Integradora.Servico.Testes
{
    [TestClass]
    public class TesteDiversos
    {
        /// <summary>
        /// Cancelamento de pedido
        /// </summary>
        [TestMethod]
        public void TesteExecucaoCancelarPedido()
        {
            string retorno;
            retorno = Integradora.ERP.Winthor.Domain.CancelarPedido.Cancelar(5000734, "Teste de cancelamento de pedido");


            Assert.IsTrue(retorno == "OK");
        }

        /// <summary>
        /// Enviar e-mail
        /// </summary>
        [TestMethod]
        public void TesteExecucaoEmail()
        {
            bool retorno;
            retorno = Integradora.Mensageiro.Correspondencia.EnviarNotificacao("Teste", "Testes de envio via c#");

            Assert.IsTrue(true);
        }

        /// <summary>
        /// Execução da pesquisa de CEP
        /// </summary>
        [TestMethod]
        public void TesteExecucaoCEP()
        {
            ZipCodeInfo CEP = Integradora.CEP.Consultar.ObterEndereco("52041330");

            Assert.IsNotNull(CEP.Ibge);
        }

        /// <summary>
        /// Execução da solicitação de etiqueta
        /// </summary>
        [TestMethod]
        public void TesteExecucaoObterEtiquetaCorreio()
        {
            string Etiqueta = Integradora.CEP.Consultar.ObterEtiqueta("09316105000129"); //09316105000714");

            Assert.IsNotNull(Etiqueta);
        }

        /// <summary>
        /// Execução da pesquisa de CEP
        /// </summary>
        [TestMethod]
        public void TesteMD5()
        {
            string resultado = Integradora.Biblioteca.Tools.MD5.HashMD5("96396760479 - 28/10/2015");

            Assert.IsTrue(resultado == "53ceb6a4240fe1642cc00dfd77c3fda8");
        }

        /// <summary>
        /// Execução da pesquisa de CEP
        /// </summary>
        [TestMethod]
        public void TesteShoppub_ListarProdutos()
        {
            Integradora.ECommerce.Shoppub.Integracao Shoppub = new Integradora.ECommerce.Shoppub.Integracao();
            //ListaPedidos lista = Shoppub.ObterPedidosPagos();

            //Assert.IsTrue(lista != null);
        }
    }
}
