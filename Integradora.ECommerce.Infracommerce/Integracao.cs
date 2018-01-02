using Integradora.Biblioteca.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Infracommerce
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.Infracommerce;
        }
        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }

        #region Configuração local
        public int TempoEspera()
        {
            return 5000;
        }
        public System.Net.NetworkCredential ChaveAcesso()
        {
            return new System.Net.NetworkCredential( Biblioteca.Dictionaries.Settings.Infracommerce_Username() //"novaamazonas" 
                                                   , Biblioteca.Dictionaries.Settings.Infracommerce_Password() //"VeN&hUiV#"
                                                   );
        }
        #endregion

        #region Chamadas aos webservices
        private WebServiceEstoque.StockServices WebServiceExecutaEstoque()
        {
            //Classe do webservice
            WebServiceEstoque.StockServices webservice = null;
            try
            {
                webservice = new WebServiceEstoque.StockServices();
                webservice.Timeout = TempoEspera();
                webservice.UseDefaultCredentials = false;
                webservice.Credentials = ChaveAcesso();
                webservice.Url = Biblioteca.Dictionaries.Settings.InfracommerceURL_Stock(); // "https://ws-unilever-hcp.infracommerce.com.br/b2b/stock";
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.Infracommerce", "WebServiceExecutaEstoque", ex);
            }
            return webservice;
        }

        private WebServiceClientes.CustomerServices WebServiceExecutaCliente()
        {
            //Classe do webservice
            WebServiceClientes.CustomerServices webservice = null;
            try
            {
                webservice = new WebServiceClientes.CustomerServices();
                webservice.Timeout = TempoEspera();
                webservice.UseDefaultCredentials = false;
                webservice.Credentials = ChaveAcesso();
                webservice.Url = Biblioteca.Dictionaries.Settings.InfracommerceURL_Customer(); // "https://ws-unilever-hcp.infracommerce.com.br/b2b/stock";
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.Infracommerce", "WebServiceExecutaCliente", ex);
            }
            return webservice;
        }

        private WebServiceLimiteCredito.VoucherServices WebServiceExecutaLimiteCredito()
        {
            //Classe do webservice
            WebServiceLimiteCredito.VoucherServices webservice = null;
            try
            {
                webservice = new WebServiceLimiteCredito.VoucherServices();
                webservice.Timeout = TempoEspera();
                webservice.UseDefaultCredentials = false;
                webservice.Credentials = ChaveAcesso();
                webservice.Url = Biblioteca.Dictionaries.Settings.InfracommerceURL_Voucher(); // "https://ws-unilever-hcp.infracommerce.com.br/b2b/stock";
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.Infracommerce", "WebServiceExecutaLimiteCredito", ex);
            }
            return webservice;
        }

//        private WebServicePreco.PriceService WebServiceExecutaPrecos()
//        {
//            //Classe do webservice
//            WebServicePreco.PriceService webservice = null;
//            try
//            {
//                webservice = new WebServicePreco.PriceService();
//                webservice.Timeout = TempoEspera();
//                webservice.UseDefaultCredentials = false;
//                webservice.Credentials = ChaveAcesso();
//                webservice.Url = Biblioteca.Dictionaries.Settings.InfracommerceURL_Price(); // "https://ws-unilever-hcp.infracommerce.com.br/b2b/stock";
//            }
//            catch (Exception ex)
//            {
//                Logs.GerarLog("Integradora.ECommerce.Infracommerce", "WebServiceExecutaPrecos", ex);
//            }
//            return webservice;
//        }

        private WebServicePosicaoPedido.TrackingServicesMediator_ep WebServiceExecutaPosicaoPedido()
        {
            //Classe do webservice
            WebServicePosicaoPedido.TrackingServicesMediator_ep webservice = null;
            try
            {
                webservice = new WebServicePosicaoPedido.TrackingServicesMediator_ep();
                    webservice.Timeout = TempoEspera();
                    webservice.UseDefaultCredentials = false;
                    webservice.Credentials = ChaveAcesso();
                    webservice.Url = Biblioteca.Dictionaries.Settings.InfracommerceURL_Tracking(); // "https://ws-unilever-hcp.infracommerce.com.br/b2b/stock";
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.Infracommerce", "WebServiceExecutaPosicaoPedido", ex);
            }
            return webservice;
        }
        #endregion

        public string Estoque(string codigoFilial, decimal codigoBarra, decimal quantidade)
        {

            WebServiceEstoque.stock registro = new WebServiceEstoque.stock();
            registro.skuId = codigoBarra.ToString();
            registro.stockType = quantidade > 0 ? 1 : 0;

            WebServiceEstoque.stock[] dados = new WebServiceEstoque.stock[1];
            dados[0] = registro;

            WebServiceEstoque.setStockRequest coletanea = new WebServiceEstoque.setStockRequest();
            coletanea.storeId = codigoFilial;
            coletanea.stockList = dados;
            coletanea.orderAccountingFlag = true;

            var resposta = WebServiceExecutaEstoque().setStock(coletanea);

            return resposta.result;
        }

        public void Preco(decimal codigoBarra, decimal valorPreco1, decimal valorPreco2, decimal valorPreco3,
                          decimal valorPreco4, decimal valorPreco5, decimal valorPreco6)
        { 
           
        }

        public void Cliente()
        {

        }
    }
}
