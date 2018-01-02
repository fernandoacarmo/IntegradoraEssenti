using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex.Inherited
{
    public class RestObject
    {
        protected WebHeaderCollection HeaderCollection
        {
            get
            {
                WebHeaderCollection objWebHeaderCollection = new System.Net.WebHeaderCollection();
                objWebHeaderCollection.Add("Accept", "application/json");
                objWebHeaderCollection.Add("Content-Type", "application/json");
                objWebHeaderCollection.Add("X-VTEX-API-AppToken", Integradora.Biblioteca.Dictionaries.Settings.VTex_AppToken());
                objWebHeaderCollection.Add("X-VTEX-API-AppKey", Integradora.Biblioteca.Dictionaries.Settings.VTex_AppKey());

                return objWebHeaderCollection;
            }
        }

        protected WebClient vtexServiceWebClient
        {
            get
            {
                WebClient objWebClient = new WebClient();
                objWebClient.Headers = this.HeaderCollection;
                return objWebClient;
            }
        }

        protected RestClient vtexServiceRestClient
        {
            get
            {
                string urlAPI = Integradora.Biblioteca.Dictionaries.Settings.VTex_UrlAPI();

                return new RestClient(urlAPI);
            }
        }

        protected string GetRequest(string requestRoute, Method metodo, object complemento) 
        {
            var request = new RestRequest(requestRoute, metodo);
            //request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-VTEX-API-AppKey", Integradora.Biblioteca.Dictionaries.Settings.VTex_AppKey());
            request.AddHeader("X-VTEX-API-AppToken", Integradora.Biblioteca.Dictionaries.Settings.VTex_AppToken());
            
            if (complemento != null)
            {
                request.AddJsonBody(complemento);

            }

            //Utilizando RestSharp (http://restsharp.org/)
            
            var response = vtexServiceRestClient.Execute(request);

            return response.Content.ToString(); 
        }

        private static bool CustomValidation(object sender,
        X509Certificate cert,
        X509Chain chain, System.Net.Security.SslPolicyErrors error)
        {
            return true;
        }

        public string GetRequest(string url, string metodo, bool enviarObjeto, object complemento)
        {
            // Criando conexão 
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(url);
            //Metodo de aplicação
            Request.Method = metodo;
            Request.Timeout = 1000000;
            Request.Headers.Add("X-VTEX-API-AppKey", Integradora.Biblioteca.Dictionaries.Settings.VTex_AppKey());
            Request.Headers.Add("X-VTEX-API-AppToken", Integradora.Biblioteca.Dictionaries.Settings.VTex_AppToken());

            //Para burlar o certificado
            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(CustomValidation);

            if (enviarObjeto)
            {
                //// JSON
                string serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(complemento);
                Request.AllowWriteStreamBuffering = false;
                Request.ContentType = "application/json";
                Request.Accept = "*/*";
                Request.SendChunked = true;
                Request.ContentLength = serializedObject.Length;

                using (var writer = new StreamWriter(Request.GetRequestStream()))
                {
                    writer.Write(serializedObject);
                    //writer.Flush();
                    // writer.Close();
                }
                //// JSON
            }
            //Retorno do webservice
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

            //Tratamento do retorno
            Stream receiveStream = Response.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);

            return reader.ReadToEnd();
        }

    }
}
