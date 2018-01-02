using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using Integradora.Biblioteca.Tools;

namespace Integradora.Servico.Testes
{
    [TestClass]
    public class TesteAjuri
    {
        private TesteWebServiceOMBoat.ServiceTrafegoClient Webservice()
        {
            TesteWebServiceOMBoat.ServiceTrafegoClient webservice = null;
            try
            {
                //Configuração do serviço
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "BasicHttpBinding_IServiceTrafego";
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                //Endereço do webservice
                //EndpointAddress remoteAddress = new EndpointAddress("http://wsvtiger.friopecas.com.br:88/WebServiceVTiger.svc");
                EndpointAddress remoteAddress = new EndpointAddress("http://localhost/Integradora.WebServiceOMBoat/ServiceTrafego.svc");
                //Carregando o webservice
                webservice = new TesteWebServiceOMBoat.ServiceTrafegoClient(binding, remoteAddress);
                //Abrindo a conexão
                webservice.Open();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.Ajuri", "WebService", ex);
            }
            return webservice;
        }

        [TestMethod]

        public void TesteAjuriEntidade()
        {           
            TesteWebServiceOMBoat.AlimentaEntidadeMestraXML fornecedor = new TesteWebServiceOMBoat.AlimentaEntidadeMestraXML();

            TesteWebServiceOMBoat.Entidade entidade = new TesteWebServiceOMBoat.Entidade();
            entidade.isfornecedor = "SIM";

            TesteWebServiceOMBoat.Entidade[] ListaEntidade = new TesteWebServiceOMBoat.Entidade[1];
            ListaEntidade[0] = entidade;


            fornecedor.AlimentaEntidadeMestra.entidades = ListaEntidade;

            var retorno = Webservice().integrarEntidadeMestra(fornecedor);

            Assert.IsTrue(retorno.status == "SUCESS");
        }
    }
}
