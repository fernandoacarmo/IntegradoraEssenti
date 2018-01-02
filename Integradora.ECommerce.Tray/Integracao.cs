using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Tray
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {
        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.Tray;
        }

        public override void Initialize()
        {
            //throw new NotImplementedException();
        }

        public string ExecutarJson(string Metodo, string URLAuth, string argsString, string postString)
        {
            HttpWebRequest webRequest = WebRequest.Create(URLAuth + "?" + argsString) as HttpWebRequest;
            webRequest.Method = Metodo;
            webRequest.ContentType = "application/json";

            StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
            requestWriter.Write(postString);
            requestWriter.Close();

            StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
            string responseData = responseReader.ReadToEnd();

            responseReader.Close();
            webRequest.GetResponse().Close();
            return responseData;
        }

        public void ListarFormaPagamento()
        {
            string URLAuth = MontarUrl("/payments/methods/settings/12/");

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            WebRequest request = WebRequest.Create(URLAuth + "?" + argsString);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseData = reader.ReadToEnd();

            Console.WriteLine(responseData);
            reader.Close();
            response.Close();
        }

        public string MontarUrl(string complemento)
        {
            var url = Biblioteca.Dictionaries.Settings.Tray_URL();
            url = url + complemento;

            return url;
        }

        public RetornoChave ObterChaveAcesso()
        {
            string URLAuth = MontarUrl("/auth/");

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("consumer_key", Biblioteca.Dictionaries.Settings.Tray_ConsumerKey());
            queryParameters.Add("consumer_secret", Biblioteca.Dictionaries.Settings.Tray_ConsumerSecret());
            queryParameters.Add("code", Biblioteca.Dictionaries.Settings.Tray_Code());

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string postString = String.Join("&", items.ToArray());

            HttpWebRequest webRequest = WebRequest.Create(URLAuth) as HttpWebRequest;
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
            requestWriter.Write(postString);
            requestWriter.Close();

            StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
            string responseData = responseReader.ReadToEnd();

            responseReader.Close();
            webRequest.GetResponse().Close();

            RetornoChave jsonObject = JsonConvert.DeserializeObject<RetornoChave>(responseData);

            return jsonObject;
        }

        public TrayListaPedidos ListarPedidos(string Status)
        {
            string URLAuth = MontarUrl("/orders/");

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);
            queryParameters.Add("sort", "id_desc");
            queryParameters.Add("status", Status);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            WebRequest request = WebRequest.Create(URLAuth + "?" + argsString);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseData = reader.ReadToEnd();

            Console.WriteLine(responseData);
            reader.Close();
            response.Close();

            TrayListaPedidos jsonObject = JsonConvert.DeserializeObject<TrayListaPedidos>(responseData);

            return jsonObject;

        }

        public TrayPedido ObterPedido(string numeroPedido)
        {
            string URLAuth = MontarUrl("/orders/" + numeroPedido);

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            WebRequest request = WebRequest.Create(URLAuth + "?" + argsString);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseData = reader.ReadToEnd();

            Console.WriteLine(responseData);
            reader.Close();
            response.Close();

            TrayPedido jsonObject = JsonConvert.DeserializeObject<TrayPedido>(responseData);

            return jsonObject;
        }

        public TrayPedidoProduto ListarPedidosItens(string idItemPedido)
        {
            string URLAuth = MontarUrl("/products_solds/" + idItemPedido);

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            WebRequest request = WebRequest.Create(URLAuth + "?" + argsString);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseData = reader.ReadToEnd();

            Console.WriteLine(responseData);
            reader.Close();
            response.Close();

            TrayPedidoProduto jsonObject = JsonConvert.DeserializeObject<TrayPedidoProduto>(responseData);

            return jsonObject;

        }

        public TrayPedidoPagamento ListarPedidosPagto(string idPagamentoPedido)
        {
            string URLAuth = MontarUrl("/payments/" + idPagamentoPedido);

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            WebRequest request = WebRequest.Create(URLAuth + "?" + argsString);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseData = reader.ReadToEnd();

            Console.WriteLine(responseData);
            reader.Close();
            response.Close();

            TrayPedidoPagamento jsonObject = JsonConvert.DeserializeObject<TrayPedidoPagamento>(responseData);

            return jsonObject;
        }

        public TrayCliente ObterCliente(string idCliente)
        {
            string URLAuth = MontarUrl("/customers/" + idCliente);

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            WebRequest request = WebRequest.Create(URLAuth + "?" + argsString);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseData = reader.ReadToEnd();

            Console.WriteLine(responseData);
            reader.Close();
            response.Close();

            TrayCliente jsonObject = JsonConvert.DeserializeObject<TrayCliente>(responseData);

            return jsonObject;
        }

        public TrayEndereco ObterEndereco(string idEndereco)
        {
            string URLAuth = MontarUrl("/customers/addresses/" + idEndereco);

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            WebRequest request = WebRequest.Create(URLAuth + "?" + argsString);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseData = reader.ReadToEnd();

            Console.WriteLine(responseData);
            reader.Close();
            response.Close();

            TrayEndereco jsonObject = JsonConvert.DeserializeObject<TrayEndereco>(responseData);

            return jsonObject;
        }

        public TrayMarketplace ObterMarketplace(string idMarketplace)
        {
            string URLAuth = MontarUrl("/partners/" + idMarketplace);

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            WebRequest request = WebRequest.Create(URLAuth + "?" + argsString);

            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseData = reader.ReadToEnd();

            Console.WriteLine(responseData);
            reader.Close();
            response.Close();


            TrayMarketplace jsonObject = JsonConvert.DeserializeObject<TrayMarketplace>(responseData);

            return jsonObject;

        }

        public void MudarStatus(string idItemPedido, string status)
        {

            string URLAuth = MontarUrl("/orders/statuses/" + idItemPedido);

            NameValueCollection queryParameters = new NameValueCollection();

            queryParameters.Add("access_token", ObterChaveAcesso().access_token);

            List<string> items = new List<string>();

            foreach (String name in queryParameters)
                items.Add(String.Concat(name, "=", System.Web.HttpUtility.UrlEncode(queryParameters[name])));

            string argsString = String.Join("&", items.ToArray());

            string putString = "{";
            putString += "  \"OrderStatus\": {";
            putString += "      \"status\": \"" + status + "\",";
            putString += "      \"default\": \"0\"";
            putString += "  }";
            putString += "}";

            HttpWebRequest webRequest = WebRequest.Create(URLAuth + "?" + argsString) as HttpWebRequest;
            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            StreamWriter requestWriter = new StreamWriter(webRequest.GetRequestStream());
            requestWriter.Write(putString);
            requestWriter.Close();

//            StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
            //string responseData = responseReader.ReadToEnd();

//            responseReader.Close();
//            webRequest.GetResponse().Close();
        }
    }
}
