using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.VTiger
{
    public class Integracao : Integradora.ECommerce.Lojavirtual
    {
        private VTigerApi.VTiger webservice;
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.VTiger;
        }

        public override void Initialize()
        {

        }

        private bool Conectar()
        {
            bool resultado = false;
            try
            {
                Desconectar();

                webservice = new VTigerApi.VTiger(Biblioteca.Dictionaries.Settings.VTiger_URL());

                webservice.Login(Biblioteca.Dictionaries.Settings.VTiger_Login()
                                , Biblioteca.Dictionaries.Settings.VTiger_Token()
                                );

                resultado = true;
            }
            catch (Exception ex)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.VTiger"
                                              , "Conectar"
                                              , "Erro: " + ex.Message);
                webservice = null;
            }

            return resultado;
        }

        private void Desconectar()
        {
            if (webservice != null)
            {
                try
                {
                    webservice.Logout();
                }
                catch { }
            }
        }
        private bool GravarRegistro(VTigerApi.VTigerEntity registro, string campoChave)
        {
            bool resultado = false;
            try
            {
                if (Conectar())
                {
                    if (registro != null)
                    {
                        try
                        {
                            if (ExisteRegistro(registro, campoChave))
                            {
                                webservice.Update(registro);
                            }
                            else
                            {
                                webservice.Create(registro);
                            }
                            resultado = true;
                        }
                        catch (Exception ex)
                        {
                            Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.VTiger"
                                                          , "GravarRegistro"
                                                          , "Erro: " + ex.Message);
                            resultado = false;
                        }
                    }
                }
            }
            finally
            {
                Desconectar();
            }

            return resultado;
        }

        private bool ExisteRegistro(VTigerApi.VTigerEntity registro, string campoChave)
        {
            try
            {
                registro.id = webservice.FindEntityID(registro.elementType, campoChave, registro.id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool exportarProduto(VTigerApi.VTigerProduct registro)
        {
            registro.assigned_user_id = Biblioteca.Dictionaries.Settings.VTiger_Login();
            registro.id = registro.productcode;

            return GravarRegistro(registro, "productcode");
        }

        public bool exportarCliente(VTigerCustomer registro)
        {
            StringBuilder parametros = new StringBuilder();
            if (!string.IsNullOrEmpty(registro.accountname)) { parametros.AppendLine("&accountname=" + registro.accountname); };
            if (!string.IsNullOrEmpty(registro.phone)) { parametros.AppendLine("&phone=" + registro.phone); };
            if (!string.IsNullOrEmpty(registro.website)) { parametros.AppendLine("&website=" + registro.website); };
            if (!string.IsNullOrEmpty(registro.fax)) { parametros.AppendLine("&fax=" + registro.fax); };
            if (!string.IsNullOrEmpty(registro.tickersymbol)) { parametros.AppendLine("&tickersymbol=" + registro.tickersymbol); };
            if (!string.IsNullOrEmpty(registro.otherphone)) { parametros.AppendLine("&otherphone=" + registro.otherphone); };
            if (!string.IsNullOrEmpty(registro.member_of)) { parametros.AppendLine("&member_of=" + registro.member_of); };
            if (!string.IsNullOrEmpty(registro.email1)) { parametros.AppendLine("&email1=" + registro.email1); };
            if (!string.IsNullOrEmpty(registro.email2)) { parametros.AppendLine("&email2=" + registro.email2); };
            if (!string.IsNullOrEmpty(registro.ownership)) { parametros.AppendLine("&ownership=" + registro.ownership); };
            if (!string.IsNullOrEmpty(registro.siccode)) { parametros.AppendLine("&siccode=" + registro.siccode); };
            if (!string.IsNullOrEmpty(registro.bill_street)) { parametros.AppendLine("&bill_street=" + registro.bill_street); };
            if (!string.IsNullOrEmpty(registro.ship_street)) { parametros.AppendLine("&ship_street=" + registro.ship_street); };
            if (!string.IsNullOrEmpty(registro.bill_city)) { parametros.AppendLine("&bill_city=" + registro.bill_city); };
            if (!string.IsNullOrEmpty(registro.ship_city)) { parametros.AppendLine("&ship_city=" + registro.ship_city); };
            if (!string.IsNullOrEmpty(registro.bill_state)) { parametros.AppendLine("&bill_state=" + registro.bill_state); };
            if (!string.IsNullOrEmpty(registro.ship_state)) { parametros.AppendLine("&ship_state=" + registro.ship_state); };
            if (!string.IsNullOrEmpty(registro.bill_code)) { parametros.AppendLine("&bill_code=" + registro.bill_code); };
            if (!string.IsNullOrEmpty(registro.ship_code)) { parametros.AppendLine("&ship_code=" + registro.ship_code); };
            if (!string.IsNullOrEmpty(registro.bill_country)) { parametros.AppendLine("&bill_country=" + registro.bill_country); };
            if (!string.IsNullOrEmpty(registro.ship_country)) { parametros.AppendLine("&ship_country=" + registro.ship_country); };
            if (!string.IsNullOrEmpty(registro.bill_pobox)) { parametros.AppendLine("&bill_pobox=" + registro.bill_pobox); };
            if (!string.IsNullOrEmpty(registro.ship_pobox)) { parametros.AppendLine("&ship_pobox=" + registro.ship_pobox); };
            if (!string.IsNullOrEmpty(registro.description)) { parametros.AppendLine("&description=" + registro.description); };
            if (!string.IsNullOrEmpty(registro.rca)) { parametros.AppendLine("&rca=" + registro.rca); };
            if (!string.IsNullOrEmpty(registro.rgie)) { parametros.AppendLine("&rgie=" + registro.rgie); };
            if (!string.IsNullOrEmpty(registro.cnpj)) { parametros.AppendLine("&cnpj=" + registro.cnpj); };

            parametros.AppendLine("&employees=" + registro.employees);
            parametros.AppendLine("&rating=" + registro.rating);
            parametros.AppendLine("&industry=" + registro.industry);
            parametros.AppendLine("&accounttype=" + registro.accounttype);
            parametros.AppendLine("&annual_revenue=" + registro.annual_revenue);
            parametros.AppendLine("&emailoptout=" + registro.emailoptout);
            parametros.AppendLine("&notify_owner=" + registro.notify_owner);

            return SendRegistrosPHP("ws/organization.php", parametros.ToString().Replace("\r\n", string.Empty).Trim());
        }

        public bool exportarPreco(VTigerApi.VTigerProduct registro)
        {
            return SendRegistrosPHP("ws/insertProductPrice.php"
                                   , string.Format("currency_id=1&priceBook=Padrao&price={0}&product_code={1}"
                                                  , registro.unit_price.ToString()
                                                  , registro.productcode.ToString()));
        }

        private bool SendRegistrosPHP(string metodo, string Parametros)
        {
            string retorno ="0";

            string urlCompleta = Biblioteca.Dictionaries.Settings.VTiger_URL() + metodo;

            urlCompleta +="?" + Parametros;
            try
            {
                retorno = SendRequest(urlCompleta);
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.VTiger"
                                              , "SendRegistrosPHP"
                                              , string.Format("Registro enviado: {0} " + Environment.NewLine + "Respostas: {1}", urlCompleta, retorno));
            }
            catch (WebException ex)
            {

                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.VTiger"
                                              , "SendRegistrosPHP"
                                              , string.Format("Método: {0} - Erro: {1}", urlCompleta, ex.Message));
                retorno ="0";
            }

            return retorno =="1" || string.IsNullOrEmpty(retorno);
        }

        private string SendRequest(string url)
        {
            try
            {
                Thread.Sleep(1000);
                using (WebClient client = new WebClient())
                {

                    return client.DownloadString(new Uri(url));
                }
            }
            catch (WebException ex)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.VTiger"
                                              , "SendRequest"
                                              , string.Format("Erro: {0}", ex.Message));
                return "0";
            }
        }

        public ListaPedido ObterPedidosPendentes()
        {
            string url = Biblioteca.Dictionaries.Settings.VTiger_URL();
            url = url + "MundipaggForm/xmlPedido.php";
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Timeout = 100000;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream retornoweb = response.GetResponseStream();

            XmlSerializer serializer = new XmlSerializer(typeof(ListaPedido));
            ListaPedido retorno;

            retorno = (ListaPedido)serializer.Deserialize(retornoweb);

            return retorno;
        }
        public bool MarcarPedidoComoImportado(string numPedidoVTiger, decimal numPedidoWinthor)
        {
            string url = Biblioteca.Dictionaries.Settings.VTiger_URL();
            url = url + string.Format("MundipaggForm/atualizarPedido.php?crm_num={0}&erp_num={1}", numPedidoVTiger, numPedidoWinthor);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Timeout = 100000;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            string retorno = response.StatusCode.ToString();
            return retorno =="OK";
        }
    }
}

