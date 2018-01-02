using Integradora.Biblioteca.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integradora.ECommerce.OnLine.Inherited;
using RestSharp;
using Newtonsoft.Json;

namespace Integradora.ECommerce.OnLine.Orders
{
    public class AtualizarPedido : RestObject
    {
        public Cabecalho Notificar(object jsonFormatado)
        {
            string requestRoute = "/api/pedido-ws/enviar/";

            string json = "";
            try
            {
                json = GetRequest(requestRoute, Method.PUT, jsonFormatado);
                Cabecalho jsonObject = JsonConvert.DeserializeObject<Cabecalho>(json);

                return jsonObject;
            }
            catch (Exception ex)
            {
                Biblioteca.Tools.Logs.GerarLog("Integradora.ECommerce.OnLine"
                                              , "Notificar"
                                              , string.Format("Erro ao enviar dados" + Environment.NewLine + "Json retornado: {0}" + Environment.NewLine + "Erro: {1}"
                                                             , json, ex.ToString()));

                return null;
            }
        }

        public string Receber(string idPedido, string CNPJCPF)
        {
             //climariopagamentos.com.br/api/pedido-ws/pedidos?idCliente=<9999999999999999>
            string requestRoute = string.Format("/api/pedido-ws/{0}?idCliente={1}", idPedido, CNPJCPF);

            string passo = GetRequest(requestRoute, Method.PUT, null);

            return passo;
        }
    }
}
