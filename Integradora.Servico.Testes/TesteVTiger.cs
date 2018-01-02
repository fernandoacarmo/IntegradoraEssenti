using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using Integradora.Biblioteca.Tools;

namespace Integradora.Servico.Testes
{
    [TestClass]
    public class TesteVTiger
    {
        private TesteWebServiceVTiger.WebServiceVTigerClient Webservice()
        {
            TesteWebServiceVTiger.WebServiceVTigerClient webservice = null;
            try
            {
                //Configuração do serviço
                BasicHttpBinding binding = new BasicHttpBinding();
                binding.Name = "BasicHttpBinding_IWebServiceVTiger";
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                //Endereço do webservice
                //EndpointAddress remoteAddress = new EndpointAddress("http://wsvtiger.friopecas.com.br:88/WebServiceVTiger.svc");
                EndpointAddress remoteAddress = new EndpointAddress("http://localhost:37842/WebServiceVTiger.svc");
                //Carregando o webservice
                webservice = new TesteWebServiceVTiger.WebServiceVTigerClient(binding, remoteAddress);
                //Abrindo a conexão
                webservice.Open();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.VTiger", "WebService", ex);
            }
            return webservice;
        }

        [TestMethod]
        public void TesteVTigerGetData()
        {
            string retorno = Webservice().GetData(10);

            Assert.IsNotNull(retorno);
        }

        [TestMethod]
        public void TesteVTigerCadastroCliente()
        {
            TesteWebServiceVTiger.Cliente cliente = new TesteWebServiceVTiger.Cliente();

            cliente.Bairro = "Cidade Vera Cruz II";
            cliente.Celular = "62 8130-7777";
            cliente.CEP = "74936-250";
            cliente.Cidade = "Aparecida de Goiânia";
            cliente.CNPJCPF = "";
            cliente.Codcliente = 0;
            cliente.Complemento = "Próximo a praça do sol";
            cliente.Email = "fernandoarantes@msn.com";
            cliente.Endereco = "Rua H-73, Quadra 215, Lote 05";
            cliente.Estado = "GO";
            cliente.FAX = "";
            cliente.Inscricaoestadual = "ISENTO";
            cliente.Nomefantasia = "Fernando Arantes do Carmo";
            cliente.Numero = "S/N";
            cliente.Obsintegracao = "Teste de integração";
            cliente.Razaosocial = "EU MESMO";
            cliente.Telefone = "62 3085-3735";

            string retorno = Webservice().EnviarCliente(cliente);

            Assert.IsTrue(retorno == "OK");
        }

        [TestMethod]
        public void TesteVTigerPedidoVenda()
        {
            //Instanciando a classe pedido
            TesteWebServiceVTiger.Pedido pedido = new TesteWebServiceVTiger.Pedido();

            //Criado a classe de cliente dentro do pedido
            pedido.Cliente = new TesteWebServiceVTiger.Cliente();
            pedido.Cliente.Bairro = "Cidade Vera Cruz II";
            pedido.Cliente.Celular = "62 8130-7777";
            pedido.Cliente.CEP = "74936-250";
            pedido.Cliente.Cidade = "Aparecida de Goiânia";
            pedido.Cliente.CNPJCPF = "78160510187";
            pedido.Cliente.Codcliente = 0;
            pedido.Cliente.Complemento = "Próximo a praça do sol";
            pedido.Cliente.Email = "fernandoarantes@msn.com";
            pedido.Cliente.Endereco = "Rua H-73, Quadra 215, Lote 05";
            pedido.Cliente.Estado = "GO";
            pedido.Cliente.FAX = "";
            pedido.Cliente.Inscricaoestadual = "ISENTO";
            pedido.Cliente.Nomefantasia = "Fernando Arantes do Carmo";
            pedido.Cliente.Numero = "S/N";
            pedido.Cliente.Obsintegracao = "Teste de integração";
            pedido.Cliente.Razaosocial = "EU MESMO";
            pedido.Cliente.Telefone = "62 3085-3735";

            pedido.Codvendedor = 0;
            pedido.Dtemissao = DateTime.Now;
            pedido.Dtentrega = DateTime.Now.AddDays(5);
            pedido.Dtinclusao = DateTime.Now;
            pedido.Numpedido = 1232156;
            pedido.Observacao = "Teste de integração VTiger";
            pedido.Valordesconto = 0;
            pedido.Valorfrete = 10;
            pedido.Valortotal = 1000; //Não e obrigatório

            //Tratamento para produtos
            int QuantidadeProdutosVendido = 2;
            pedido.Itens = new Integradora.Servico.Testes.TesteWebServiceVTiger.ItemPedido[QuantidadeProdutosVendido];

            //Inserindo pedido 1
            pedido.Itens[0] = new Integradora.Servico.Testes.TesteWebServiceVTiger.ItemPedido();
            pedido.Itens[0].Codproduto = 62380;
            pedido.Itens[0].Numitem = 1;
            pedido.Itens[0].Precotabela = Convert.ToDecimal(1244.36);
            pedido.Itens[0].Precovenda = Convert.ToDecimal(1240.00);
            pedido.Itens[0].Quantidade = 1;

            //Inserindo pedido 2
            pedido.Itens[1] = new Integradora.Servico.Testes.TesteWebServiceVTiger.ItemPedido();
            pedido.Itens[1].Codproduto = 62382;
            pedido.Itens[1].Numitem = 2;
            pedido.Itens[1].Precotabela = Convert.ToDecimal(3069.58);
            pedido.Itens[1].Precovenda = Convert.ToDecimal(3069.58);
            pedido.Itens[1].Quantidade = 1;

            int QuantidadeParcelas = 3;
            pedido.Parcelas = new Integradora.Servico.Testes.TesteWebServiceVTiger.ParcelaPedido[QuantidadeParcelas];
            pedido.Parcelas[0] = new Integradora.Servico.Testes.TesteWebServiceVTiger.ParcelaPedido();
            pedido.Parcelas[0].Dtvencimento = DateTime.Now.AddDays(30);
            pedido.Parcelas[0].NSU = ""; //Apenas para venda em cartão e obrigatório
            //pedido.Parcelas[0].CodAutorizacao = null; //Apenas para venda em cartão e obrigatório
            pedido.Parcelas[0].Numparcela = 1;
            pedido.Parcelas[0].Valor = Convert.ToDecimal(1436.53);

            pedido.Parcelas[1] = new Integradora.Servico.Testes.TesteWebServiceVTiger.ParcelaPedido();
            pedido.Parcelas[1].Dtvencimento = DateTime.Now.AddDays(60);
            pedido.Parcelas[1].NSU = ""; //Apenas para venda em cartão e obrigatório
            //pedido.Parcelas[1].CodAutorizacao = null; //Apenas para venda em cartão e obrigatório
            pedido.Parcelas[1].Numparcela = 1;
            pedido.Parcelas[1].Valor = Convert.ToDecimal(1436.53);

            pedido.Parcelas[2] = new Integradora.Servico.Testes.TesteWebServiceVTiger.ParcelaPedido();
            pedido.Parcelas[2].Dtvencimento = DateTime.Now.AddDays(90);
            pedido.Parcelas[2].NSU = ""; //Apenas para venda em cartão e obrigatório
            //pedido.Parcelas[2].CodAutorizacao = null; //Apenas para venda em cartão e obrigatório
            pedido.Parcelas[2].Numparcela = 1;
            pedido.Parcelas[2].Valor = Convert.ToDecimal(1436.52); //Observar que a diferença entre as parcelas fica na última

            string retorno = Webservice().EnviarPedidoVenda(pedido);

            Assert.IsTrue(retorno == "OK");
        }
        [TestMethod]
        public void TesteVTigerListarPedidos()
        {
            //Integradora.Norma.Winthor.
        }

        [TestMethod]
        public void TesteVTigerMarcarPedido()
        {
            Integradora.ECommerce.VTiger.Integracao teste = new ECommerce.VTiger.Integracao();
            Assert.IsTrue(teste.MarcarPedidoComoImportado("SO47", 233));
        }
    }
}
