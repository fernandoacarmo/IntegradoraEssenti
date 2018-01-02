using Integradora.Biblioteca.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.GsGroup
{
    public class Integracao : Integradora.ECommerce.Lojavirtual
    {
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.GsGroup;
        }

        public override void Initialize()
        {
        }

        private ZoOmBox.WSSoapClient WebServiceMatriz()
        {
            //Classe do webservice
            ZoOmBox.WSSoapClient webservice = null;
            try
            {
                //Configuração do serviço
                BasicHttpBinding binding = new BasicHttpBinding();
     //           binding.Name = "BasicHttpBinding_IServiceTrafego";
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                //Endereço do webservice
                EndpointAddress remoteAddress = new EndpointAddress(Biblioteca.Dictionaries.Settings.ZoOmBox_URLVendas());
                //Carregando o webservice
                webservice = new ZoOmBox.WSSoapClient(binding, remoteAddress);
                //Abrindo a conexão
                //                webservice.Open();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.GsGroup", "WebServiceMatriz", ex);
            }
            return webservice;
        }

        private ZoOmBoxFilial.WSSoapClient WebServiceFilial()
        {
            //Classe do webservice
            ZoOmBoxFilial.WSSoapClient webservice = null;
            try
            {
                //Configuração do serviço
                BasicHttpBinding binding = new BasicHttpBinding();
       //         binding.Name = "BasicHttpBinding_IServiceTrafego";
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                //Endereço do webservice
                EndpointAddress remoteAddress = new EndpointAddress(Biblioteca.Dictionaries.Settings.ZoOmBox_URLFilial());
                //Carregando o webservice
                webservice = new ZoOmBoxFilial.WSSoapClient(binding, remoteAddress);
                //Abrindo a conexão
                //webservice.Open();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.GsGroup", "WebServiceFilial", ex);
            }
            return webservice;
        }

        private GerenciaVendaWS.GerenciaVendaWSClient WebServiceGerenciaVenda()
        {
            //Classe do webservice
            GerenciaVendaWS.GerenciaVendaWSClient webservice = null;
            try
            {
                //Configuração do serviço
                BasicHttpBinding binding = new BasicHttpBinding();
                //         binding.Name = "BasicHttpBinding_IServiceTrafego";
                binding.MaxReceivedMessageSize = 2147483647;
                binding.MaxBufferSize = 2147483647;
                //Endereço do webservice
                EndpointAddress remoteAddress = new EndpointAddress(Biblioteca.Dictionaries.Settings.ZoOmBox_URLGerenciaVenda());
                //Carregando o webservice
                webservice = new GerenciaVendaWS.GerenciaVendaWSClient(binding, remoteAddress);
                //Abrindo a conexão
                //webservice.Open();
            }
            catch (Exception ex)
            {
                Logs.GerarLog("Integradora.ECommerce.GsGroup", "WebServiceGerenciaVenda", ex);
            }
            return webservice;
 
        }
        public string NotificarVendaMatriz(string documento
                                          , decimal numeroCupom
                                          , System.DateTime dataHora
                                          , int loja
                                          , string pdv
                                          , int categoriaProduto
                                          , decimal valor
                                          , string hash)
        {
            string retorno = "";
            try
            {
                WebServiceMatriz().Open();
                try
                {
                    retorno = WebServiceMatriz().setNotificaVenda(documento
                                                , Convert.ToDecimal(numeroCupom)
                                                , dataHora
                                                , loja
                                                , string.IsNullOrEmpty(pdv) ? "-" : pdv
                                                , categoriaProduto
                                                , valor
                                                , hash);

                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.ECommerce.GsGroup", "NotificarVendaMatriz", ex);
                }
            }
            finally
            {
                WebServiceMatriz().Close();
            }
            return retorno;
        }

        public string EnviarCliente(string cnpj_cpf)
        {
            string retorno = "";
            GerenciaVendaWS.GerenciaVendaWSClient webservice = WebServiceGerenciaVenda();
            try
            {
                webservice.Open();

                try
                {
                    var hash = string.Format("{0} - {1}", cnpj_cpf, DateTime.Now.ToShortDateString());
                    hash = Biblioteca.Tools.MD5.HashMD5(hash);
                    retorno = webservice.setIdentificaCliente(cnpj_cpf, hash).msgretorno;
                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.ECommerce.GsGroup", "EnviarCliente", ex);
                }
            }
            finally
            {
                webservice.Close();
            }

            return retorno;
        }

        public string NotificarVenda( GerenciaVendaWS.wsVenda Venda
                                    ,  GerenciaVendaWS.wsItemVenda[] IVenda
                                    ,  GerenciaVendaWS.wsPagamento[] IPagamentos)
        {
            string retorno = "";
            GerenciaVendaWS.GerenciaVendaWSClient webservice = WebServiceGerenciaVenda();
            try
            {
                webservice.Open();

                try
                {
                    var hash = string.Format("{0} - {1}", Venda.cpf, DateTime.Now.ToShortDateString());
                    hash = Biblioteca.Tools.MD5.HashMD5(hash);


                    retorno = webservice.setNotificaVenda(Venda, IVenda, IPagamentos, hash).msgretorno;
                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.ECommerce.GsGroup", "EnviarCliente", ex);
                }
            }
            finally
            {
                webservice.Close();
            }

            return retorno;        
        }

        public string NotificarVendaFilial(string documento
                                          , decimal numeroCupom
                                          , System.DateTime dataHora
                                          , int loja
                                          , string pdv
                                          , int categoriaProduto
                                          , decimal valor
                                          , string hash)
        {
            string retorno = "";
            try
            {
                WebServiceFilial().Open();
                try
                {
                    retorno = WebServiceFilial().setNotificaVenda(documento
                                                , Convert.ToDecimal(numeroCupom)
                                                , dataHora
                                                , loja
                                                , string.IsNullOrEmpty(pdv) ? "-" : pdv
                                                , categoriaProduto
                                                , valor
                                                , hash);

                }
                catch (Exception ex)
                {
                    Logs.GerarLog("Integradora.ECommerce.GsGroup", "NotificarVendaFilial", ex);
                }
            }
            finally
            {
                WebServiceFilial().Close();
            }
            return retorno;
        }
    }
}
