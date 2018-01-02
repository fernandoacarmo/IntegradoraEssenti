using Integradora.ECommerce.VTex.Inherited;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex.OrderList
{
    public class ListaPedido : RestObject 
    {
        /// <summary>
        /// Busca pedidos pendentes
        /// </summary>
        public List<string> Pendentes()
        {
            int numeropedidos = 15;
            if (Biblioteca.Dictionaries.Settings.VTex_NumeroPedidos() > 0)
            {
                numeropedidos = Biblioteca.Dictionaries.Settings.VTex_NumeroPedidos();
            }
            string requestRoute = "/oms/pvt/orders/?f_status=ready-for-handling&per_page=" + numeropedidos.ToString(); 
            var json = GetRequest(requestRoute, Method.GET, null);
            RootObject jsonObject = JsonConvert.DeserializeObject<RootObject>(json);

            return GetListaPedidos(jsonObject);
        }

        /// <summary>
        /// Busca pedidos por status
        /// </summary>
        public List<string> ComStatus(Tips.StatusPedido statusPedido)
        {
            string strStatus = Ferramentas.statusPedido_REST(statusPedido);
            string requestRoute = "/oms/pvt/orders/?f_status=" + strStatus;
            var json = GetRequest(requestRoute, Method.GET, null);
            RootObject jsonObject = JsonConvert.DeserializeObject<RootObject>(json);

            return GetListaPedidos(jsonObject);
        }

        public string EmailDescriptografado(string email)
        {
            string requestRoute = string.Format("http://conversationtracker.vtex.com.br/api/pvt/emailMapping?an={0}&alias={1}",
                                                 Biblioteca.Dictionaries.Settings.VTex_Empresa(),
                                                 email);

            requestRoute = GetRequest(requestRoute, Method.POST, null);

            return requestRoute;

        }


        private static List<string> GetListaPedidos(RootObject jsonObject)
        {
            List<string> lista = new List<string>();

            if (jsonObject != null)
            {
                if (jsonObject.list != null)
                {
                    if (jsonObject.list.Count > 0)
                    {
                        foreach (var registro in jsonObject.list)
                        {
                            lista.Add(registro.orderId);
                        }
                    }
                }
            }

            return lista;
        }

    }
}
