using Integradora.ECommerce.VTex.Inherited;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex.Orders
{
    public class Pedido : RestObject
    {

        public RootPedido Consultar(string numeroPedido)
        {
            string requestRoute = "/oms/pvt/orders/" + numeroPedido;

            var json = GetRequest(requestRoute, Method.GET, null);
            RootPedido jsonObject = JsonConvert.DeserializeObject<RootPedido>(json);

            return jsonObject;
        }

        public RootPagamentos ObterPagamento(string idTransacao, string idLancamento)
        {
            //Obtendo o pagamento
            string requestRoute = string.Format("https://{0}.vtexpayments.com.br/api/pvt/transactions/{1}/payments/{2}"
                                               , Biblioteca.Dictionaries.Settings.VTex_Empresa()
                                               , idTransacao
                                               , idLancamento
                                               );

            try
            {
                var json = GetRequest(requestRoute, "GET", false, null);
                RootPagamentos jsonObject = JsonConvert.DeserializeObject<RootPagamentos>(json);
                return jsonObject;
            }
            catch
            {
                return null;
            }
        }

        public string ObterPagamentoNSU(string idTransacao, Integradora.ECommerce.VTex.Orders.Payment parcela)
        {
            string NSU = "";
            var Pgtos = ObterPagamento(idTransacao, parcela.id);
            if (Pgtos != null)
            {
                if (Pgtos.fields.Count() > 0)
                { //Obter NSU via seqnumber
                    try
                    {
                        NSU = Pgtos.fields.Where(c => c.name.ToUpper() == "SEQNUMBER").FirstOrDefault().value;
                    }
                    catch
                    {
                        NSU = "";
                    }
                }
                if (string.IsNullOrEmpty(NSU))
                { //Caso não tenha obter do campo padrão
                    if (Pgtos.ConnectorResponses != null)
                    {
                        NSU = Biblioteca.Tools.Numbers.OnlyNumbers(Pgtos.ConnectorResponses.nsu);
                    }
                }
                if (string.IsNullOrEmpty(NSU))
                {
                    NSU = Biblioteca.Tools.Numbers.OnlyNumbers(parcela.connectorResponses.Nsu);
                }
                if (!string.IsNullOrEmpty(NSU))
                { //Somente números
                    NSU = Biblioteca.Tools.Numbers.OnlyNumbers(NSU);
                }
            }
            else
            {
                NSU = Biblioteca.Tools.Numbers.OnlyNumbers(parcela.connectorResponses.Nsu);
            }
            return NSU;
        }
        public string Cancelar(string numeroPedido)
        {
            string requestRoute = "/oms/pvt/orders/" + numeroPedido + "/cancel";

            requestRoute = GetRequest(requestRoute, Method.POST, null);

            return requestRoute;
        }

        public string EmailDescriptografado(string email)
        {
            string requestRoute = string.Format("http://conversationtracker.vtex.com.br/api/pvt/emailMapping?an={0}&alias={1}",
                                                 Biblioteca.Dictionaries.Settings.VTex_Empresa(),
                                                 email);
                        var json = GetRequest(requestRoute, "GET", false, null);
                        RootEmail jsonObject = JsonConvert.DeserializeObject<RootEmail>(json);
            
                        return jsonObject.email;
        }

        public string NotificarInicioManuseio(string numeroPedido)
        {
            return Notificar(numeroPedido, Tips.StatusPedido.Iniciar_Manuseio, null);
        }

        public string Faturado(string numeroPedido, object jsonFormatado)
        {
            return Notificar(numeroPedido, Tips.StatusPedido.Faturado_2, jsonFormatado);
        }

        public string MontarCarregamento(string numeroPedido)
        {
            return Notificar(numeroPedido, Tips.StatusPedido.Preparando_Entrega_1, null);
        }

        private string Notificar(string numeroPedido, Tips.StatusPedido statusPedido, object jsonFormatado)
        {
            string passo = Ferramentas.statusPedido_REST(statusPedido);
            string requestRoute = string.Format("/oms/pvt/orders/{0}/{1}", numeroPedido, passo);

            passo = GetRequest(requestRoute, Method.POST, jsonFormatado);

            return passo;
        }
    }
}
