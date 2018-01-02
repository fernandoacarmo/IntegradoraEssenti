using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.OnLine.Inherited
{
    public class RestObject
    {
        protected WebHeaderCollection HeaderCollection
        {
            get
            {
                WebHeaderCollection objWebHeaderCollection = new System.Net.WebHeaderCollection();
                objWebHeaderCollection.Add("Connection", "Keep-Alive");
                objWebHeaderCollection.Add("Cache-Control", "no-cache");
                objWebHeaderCollection.Add("Content-Type", "application/json");
                return objWebHeaderCollection;
            }
        }

        protected WebClient ServiceWebClient
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
                string endereco = Biblioteca.Dictionaries.Settings.OnLineUrl();
                return new RestClient(endereco);
            }
        }

        protected string GetRequest(string requestRoute, Method metodo, object complemento)
        {
            var request = new RestRequest(requestRoute, metodo);
            request.AddHeader("Cache-Control", "no-cache");

            if (complemento != null)
            {
                request.AddJsonBody(complemento);
            }

            //Utilizando RestSharp (http://restsharp.org/)
            var response = vtexServiceRestClient.Execute(request);

            return response.Content.ToString(); 
        }

    }
}
