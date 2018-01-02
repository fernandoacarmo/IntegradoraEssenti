using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Adena
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {

        private string MontarURL(string prefixo)
        {
            string url = Biblioteca.Dictionaries.Settings.AdenaURL();
            url = url + prefixo;

            return url;
        }

        public List<Produto> EnviarProduto(string conteudo)
        {
            try
            {
                string Url = MontarURL("/v1/produtos.json");
                string pathLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogTeste.txt");
                StringBuilder sb = new StringBuilder();
                string responseData = string.Empty;
                try
                {
                    responseData = ExecutarJson2("POST", Url, conteudo);
                    Biblioteca.Tools.Logs.GerarLog(string.Format("Retorno do envio de produto: {0}", responseData));
                    sb.AppendLine(string.Format("Resposta: {0}", responseData));
                }
                catch (Exception erro)
                {
                    sb.AppendLine(string.Format("Erro: {0}", erro.Message));
                }
                List<Produto> jsonObject = null;
                try
                {
                    jsonObject = JsonConvert.DeserializeObject<List<Produto>>(responseData);

                    Biblioteca.Tools.JSON.Export(jsonObject, "Produto");
                }
                catch (Exception erro)
                {
                    sb.AppendLine(string.Format("Erro ao deserializar: {0}", erro.Message));
                }
                //try
                //{
                //    ListaProdutos jsonObject = JsonConvert.DeserializeObject<ListaProdutos>(responseData);

                //    Biblioteca.Tools.JSON.Export(jsonObject, "Produto");
                //}
                //catch (Exception erro)
                //{
                //    sb.AppendLine(string.Format("Erro ao deserializar: {0}", erro.Message));
                //}
                File.WriteAllText(pathLog, responseData);

                return jsonObject;
            }
            catch (Exception erro)
            {
                Biblioteca.Tools.Logs.GerarLog("Erro ao enviar o produto", "teste", erro);
            }
            return null;
        }

        private string ExecutarJson(string Metodo, string Url)
        {
            HttpWebRequest request = WebRequest.Create(Url) as HttpWebRequest;
            request.Method = Metodo;
            request.ContentType = "application/json";
            string token = "Token " + Biblioteca.Dictionaries.Settings.AdenaToken();
            request.Headers.Add("Authorization", token);

            // Get response  
            var myWebResponse = request.GetResponse() as HttpWebResponse;
            // Get the response stream  
            StreamReader reader = new StreamReader(myWebResponse.GetResponseStream());

            string responseData = reader.ReadToEnd();

            return responseData;
        }

        public string ExecutarJson2(string Metodo, string Url, string postString)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(Url) as HttpWebRequest;
                request.Method = Metodo;
                request.ContentType = "application/json";
               // string token = "Token " + Biblioteca.Dictionaries.Settings.AdenaToken();
                string token = Biblioteca.Dictionaries.Settings.AdenaToken();
                request.Headers.Add("ClientID", token);

                string _auth = string.Format("{0}:{1}", Biblioteca.Dictionaries.Settings.AdenaUsuario(), Biblioteca.Dictionaries.Settings.AdenaSenha());
                string _enc  = Convert.ToBase64String(Encoding.ASCII.GetBytes(_auth));
                string _cred = String.Format("{0} {1}", "Basic", _enc);
                request.Headers[HttpRequestHeader.Authorization] = _cred;

                StreamWriter requestWriter = new StreamWriter(request.GetRequestStream());
                requestWriter.Write(postString);
                requestWriter.Close();

                StreamReader responseReader = new StreamReader(request.GetResponse().GetResponseStream());
                string responseData = responseReader.ReadToEnd();

                responseReader.Close();
                request.GetResponse().Close();
                return responseData;
            }
            catch (Exception erro)
            {
                Biblioteca.Tools.Logs.GerarLog("Erro ao enviar json", "ExecutarJson2", erro);
                return string.Empty;
            }


        }

        public override Biblioteca.Dictionaries.Tips.ECommerce ECommerce()
        {
            return Biblioteca.Dictionaries.Tips.ECommerce.Adena;
        }
        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }



        /// <summary>
        /// Retornando a lista de produtos cadatrados do site
        /// </summary>
        /// <returns></returns>
        public void ObterProdutos()
        {
          //  string Url = MontarURL("/api/v1/produtos/");

           // string responseData = ExecutarJson("GET", Url);/
          //  ListaProdutos jsonObject = JsonConvert.DeserializeObject<ListaProdutos>(responseData);

           // return jsonObject;
        }

    //      public ListaPedidos ObterPedidos(Tips.Status_resumido status)
    //    {
    //        string Url = ((Int16)status).ToString();
    //        Url = MontarURL("/api/v1/pedidos/?status_resumido=" + Url);//

    //        string responseData = ExecutarJson("GET", Url);
    //        ListaPedidos jsonObject = JsonConvert.DeserializeObject<ListaPedidos>(responseData);

    //        return jsonObject;
    //    }

        /// <summary>
        /// Retornando a lista de pedidos pagos no site
        /// </summary>
        /// <returns></returns>
        //public ListaPedidos ObterPedidosPagos()
      //  {
      //      return ObterPedidos(Tips.Status_resumido.Pago);
      //  }

        /// <summary>
        /// Retornando a lista de pedidos cancelados no site
        /// </summary>
        /// <returns></returns>

        //public ListaPedidos ObterPedidosAbertos()
       // {
       //     return ObterPedidos(Tips.Status_resumido.Aberto);
      //  }
        /// <summary>
        /// Retornando a lista de pedidos cancelados no site
        /// </summary>
        /// <returns></returns>
        //public ListaPedidos ObterPedidosCancelados()
      //  {
      //      return ObterPedidos(Tips.Status_resumido.Cancelado);
      //  }
    }
}
