using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex
{
    public class Ferramentas
    {
        public static string statusPedido_REST(Integradora.ECommerce.VTex.Tips.StatusPedido status)
        {
            switch (status)
            {
                case Tips.StatusPedido.Aguardando_confirmação_do_Seller: return "waiting-for-seller-confirmation";
                case Tips.StatusPedido.Pagamento_Pendente: return "payment-pending";
                case Tips.StatusPedido.Pagamento_Aprovado: return "payment-approved";
                case Tips.StatusPedido.Pagamento_Negado: return "payment-denied";
                case Tips.StatusPedido.Aguardando_decisao_do_Seller: return "waiting-for-seller-decision";
                case Tips.StatusPedido.Aguardando_autorizaçao_para_despachar_1: return "waiting-ffmt-authorization";
                case Tips.StatusPedido.Aguardando_autorizacao_para_despachar_2: return "authorize-fulfillment";
                case Tips.StatusPedido.Carencia_para_Cancelamento: return "window-to-cancel";
                case Tips.StatusPedido.Pronto_para_o_Manuseio: return "ready-for-handling";
                case Tips.StatusPedido.Iniciar_Manuseio: return "start-handling";
                case Tips.StatusPedido.Preparando_Entrega_1: return "ship";
                case Tips.StatusPedido.Preparando_Entrega_2: return "invoice";
                case Tips.StatusPedido.Cancelamento_Solicitado: return "request-cancel";
                case Tips.StatusPedido.Verificando_Envio: return "order-accepted";
                case Tips.StatusPedido.Faturado_1: return "shipped";
                case Tips.StatusPedido.Faturado_2: return "invoice";
                case Tips.StatusPedido.Cancelar: return "cancel";
                case Tips.StatusPedido.Cancelado: return "canceled";
                default: return "";
            }
        }

        public static  string statusPedido_SOAP(Integradora.ECommerce.VTex.Tips.StatusPedido status)
        {
            switch (status)
            {
                case Tips.StatusPedido.Aguardando_confirmação_do_Seller: return "AAP";
                case Tips.StatusPedido.Pagamento_Pendente: return "_NEAS";
                case Tips.StatusPedido.Pagamento_Aprovado: return "AAP";
                case Tips.StatusPedido.Pagamento_Negado: return "CAN";
                case Tips.StatusPedido.Aguardando_decisao_do_Seller: return "AAP";
                case Tips.StatusPedido.Aguardando_autorizaçao_para_despachar_1: return "ERP";
                case Tips.StatusPedido.Aguardando_autorizacao_para_despachar_2: return "ERP";
                case Tips.StatusPedido.Carencia_para_Cancelamento: return "ERP";
                case Tips.StatusPedido.Pronto_para_o_Manuseio: return "CAP";
                case Tips.StatusPedido.Iniciar_Manuseio: return "CAP";
                case Tips.StatusPedido.Preparando_Entrega_1: return "ERP";
                case Tips.StatusPedido.Preparando_Entrega_2: return "ERP";
                case Tips.StatusPedido.Cancelamento_Solicitado: return "CAN";
                case Tips.StatusPedido.Verificando_Envio: return "ERP";
                case Tips.StatusPedido.Faturado_1: return "ETR";
                case Tips.StatusPedido.Faturado_2: return "ETR";
                case Tips.StatusPedido.Cancelar: return "CAN";
                case Tips.StatusPedido.Cancelado: return "CAN";
                default: return "";
            }
        }
    }

}
