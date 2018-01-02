using Integradora.ECommerce.IShopping.Retornos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.IShopping
{
    class API
    {
        #region Funções auxiliares
        public static string Base64Encode()
        {
            string plainText = Biblioteca.Dictionaries.Settings.IShoppingCliente() + ":" + Biblioteca.Dictionaries.Settings.IShoppingChaveAcesso();

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public HttpClient WebService()
        {
            var baseAddress = new Uri(Biblioteca.Dictionaries.Settings.IShoppingURL());

            return new HttpClient { BaseAddress = baseAddress };
        }

        public void AguardarPreencher(Task processo)
        {   //Aguarda o preenchimento da classe
            while (processo.Status != TaskStatus.RanToCompletion)
            {
                Task.Delay(100).Wait();
            }
        }

        private void CarregarToken(HttpClient httpClient)
        {
            var token = Autenticar();
            //Aguardando a resposta
            AguardarPreencher(token);
            //Repassando o token 
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("access-token", token.Result.token);
        }
        #endregion

        public async Task<Autenticacao> Autenticar()
        {
            using (var httpClient = WebService())
            {
                string dadosAutenticacao = Base64Encode();
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authorization", "Basic " + dadosAutenticacao);
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                using (var content = new StringContent(""))
                {
                    using (var response = await httpClient.PostAsync("oauth", content))
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        Autenticacao jsonObject = JsonConvert.DeserializeObject<Autenticacao>(responseData);

                        return jsonObject;
                    }
                }
            }
        }

        public async Task<string> GetRegistros(string metodo)
        {
            using (var httpClient = WebService())
            {
                //Obtendo o token de conexão
                CarregarToken(httpClient);
                //Executando o método
                using (var response = await httpClient.GetAsync(metodo))
                {   //Obtendo a resposta
                    string responseData = await response.Content.ReadAsStringAsync();

                    return responseData.ToString();
                }
            }
        }

        public async Task<string> PostRegistros(string metodo, HttpContent contexto)
        {
            using (var httpClient = WebService())
            {
                //Obtendo o token de conexão
                CarregarToken(httpClient);
                //Executando o método
                using (var response = await httpClient.PostAsync(metodo, contexto))
                {   //Obtendo a resposta
                    string responseData = await response.Content.ReadAsStringAsync();

                    return responseData.ToString();
                }
            }
        }
        public async Task<string> PostRegistros(string metodo, object data)
        {
            var myContent = JsonConvert.SerializeObject(data);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var httpClient = WebService())
            {
                //Obtendo o token de conexão
                CarregarToken(httpClient);
                //Executando o método
                using (var response = await httpClient.PostAsync(metodo, byteContent))
                {   //Obtendo a resposta
                    string responseData = await response.Content.ReadAsStringAsync();

                    return responseData.ToString();
                }
            }
        }

        public async Task<string> PutRegistros(string metodo, HttpContent contexto)
        {
            using (var httpClient = WebService())
            {
                //Obtendo o token de conexão
                CarregarToken(httpClient);
                //Executando o método
                using (var response = await httpClient.PutAsync(metodo, contexto))
                {   //Obtendo a resposta
                    string responseData = await response.Content.ReadAsStringAsync();

                    return responseData.ToString();
                }
            }
        }
    }
}
