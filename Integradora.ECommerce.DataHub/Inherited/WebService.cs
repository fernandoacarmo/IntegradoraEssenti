using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.Inherited
{
    public class WebService
    {
        public string assinatura { get; set; }
        public Int32 sistema { get; set; }

        public string MontarUrl(string objeto)
        {
            string texto = Biblioteca.Dictionaries.Settings.DataHub_UrlAPI();
            texto = texto + "{0}/Enviar";
            texto = string.Format(texto, objeto);

            return texto;
        }

        public virtual string GetUrl()
        {
            return string.Empty;
        }

        public string Echo()
        {
            string url = Biblioteca.Dictionaries.Settings.DataHub_UrlAPI();
            url = url + "Test/Echo";

            return GetRequest(url, "GET", false);
        }

        private static bool CustomValidation(object sender,
        X509Certificate cert,
        X509Chain chain, System.Net.Security.SslPolicyErrors error)
        {
            return true;
        }

        public string GetRequest(bool enviarObjeto)
        {
            return GetRequest( GetUrl()
                             , "POST"
                             , enviarObjeto);
        }

        public string GetRequest(string url, string metodo, bool enviarObjeto)
        {
            //Dados de conexão - Basic
            string login = Integradora.Biblioteca.Dictionaries.Settings.DataHub_Username();
            string password = Integradora.Biblioteca.Dictionaries.Settings.DataHub_Password();

            // Criando conexão 
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(url);
            //Metodo de aplicação
            Request.Method = metodo;
            Request.Timeout = 1000000;
            Request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(new ASCIIEncoding().GetBytes(login + ":" + password)));

            //Para burlar o certificado
            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(CustomValidation);

            if (enviarObjeto)
            {
                //// JSON
                string serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(this);
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
