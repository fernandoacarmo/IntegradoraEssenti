using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Shoppub
{
    public sealed class Integracao : Integradora.ECommerce.Lojavirtual
    {

        private string MontarURL(string prefixo)
        {
            string url = Biblioteca.Dictionaries.Settings.ShoppubURL();
            url = url + prefixo;

            return url;
        }

        private string ExecutarJson(string Metodo, string Url)
        {
            HttpWebRequest request = WebRequest.Create(Url) as HttpWebRequest;
            request.Method = Metodo;
            request.ContentType = "application/json";
            string token = "Token " + Biblioteca.Dictionaries.Settings.ShoppubToken();
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
                string token = "Token " + Biblioteca.Dictionaries.Settings.ShoppubToken();
                request.Headers.Add("Authorization", token);

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
            return Biblioteca.Dictionaries.Tips.ECommerce.Shoppub;
        }
        public override void Initialize()
        {
            CriarCreditoParaCliente = false;
        }

        public List<Resultado> EnviarProduto(string conteudo)
        {
            try
            {
                string Url = MontarURL("/api/v1/produtos/");
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
                List<Resultado> jsonObject = null;
                try
                {
                    jsonObject = JsonConvert.DeserializeObject<List<Resultado>>(responseData);

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
                Biblioteca.Tools.Logs.GerarLog("Erro ao enviar o produto","teste", erro);
            }
            return null;
        }

        public RetornoFabricante EnviarMarca(string conteudo)
        {
            string Url = MontarURL("/api/v1/produto-fabricantes/");
            string pathLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogTesteFabricante.txt");
            StringBuilder sb = new StringBuilder();
            string responseData = string.Empty;
            try
            {
                responseData = ExecutarJson2("POST", Url, conteudo);
                sb.AppendLine(string.Format("Retorno fabricante:"));
                sb.AppendLine(string.Format("Resposta: {0}", responseData));
            }
            catch (Exception erro)
            {
                sb.AppendLine(string.Format("Erro: {0}", erro.Message));
            }
            RetornoFabricante jsonObject = null;
            try
            {
                jsonObject = JsonConvert.DeserializeObject<RetornoFabricante>(responseData);

                Biblioteca.Tools.JSON.Export(jsonObject, "Fabricante");
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


        /// <summary>
        /// Retornando a lista de produtos cadatrados do site
        /// </summary>
        /// <returns></returns>
        public ListaProdutos ObterProdutos()
        {
            string Url = MontarURL("/api/v1/produtos/");

            string responseData = ExecutarJson("GET", Url);
            ListaProdutos jsonObject = JsonConvert.DeserializeObject<ListaProdutos>(responseData);

            return jsonObject;
        }

        public ShoppubListaPedidos ObterPedidos(Tips.Status_resumido status)
        {
            string Url = ((Int16)status).ToString();
            Url = MontarURL("/api/v1/pedidos/?status_resumido=" + Url);

            string responseData = ExecutarJson("GET", Url);
            ShoppubListaPedidos jsonObject = JsonConvert.DeserializeObject<ShoppubListaPedidos>(responseData);

            return jsonObject;
        }

        /// <summary>
        /// Retornando a lista de pedidos pagos no site
        /// </summary>
        /// <returns></returns>
        public ShoppubListaPedidos ObterPedidosPagos()
        {
            return ObterPedidos(Tips.Status_resumido.Pago);
        }

        /// <summary>
        /// Retornando a lista de pedidos cancelados no site
        /// </summary>
        /// <returns></returns>

        public ShoppubListaPedidos ObterPedidosAbertos()
        {
            return ObterPedidos(Tips.Status_resumido.Aberto);
        }
        /// <summary>
        /// Retornando a lista de pedidos cancelados no site
        /// </summary>
        /// <returns></returns>
        public ShoppubListaPedidos ObterPedidosCancelados()
        {
            return ObterPedidos(Tips.Status_resumido.Cancelado);
        }
    }
}
