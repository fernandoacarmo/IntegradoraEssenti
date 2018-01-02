using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Tray
{
    public class Payment
    {
        public string id { get; set; }
        public string order_id { get; set; }
        public string payment_method_id { get; set; }
        public string method { get; set; }
        public string payment_place { get; set; }
        public string value { get; set; }
        public string date { get; set; }
        public string note { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
    }

    public class ProductsSold
    {
        public string id { get; set; }
        public string product_id { get; set; }
        public string order_id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string original_price { get; set; }
        public string quantity { get; set; }
        public string model { get; set; }
        public string reference { get; set; }
        public string variant_id { get; set; }
        public string additional_information { get; set; }
    }


    public class PedidoProductsSold
    {
        public string id { get; set; }
    }

    public class PedidoPayment
    {
        public string id { get; set; }
    }

    public class PedidoOrderInvoice
    {
        public string id { get; set; }
    }

    public class PedidoCustomerAddress
    {
        public string id { get; set; }
    }

    public class PedidoPaymentsNotification
    {
        public string notification { get; set; }
    }

    public class PedidoOrder
    {
        public string status { get; set; }
        public string id { get; set; }
        public string date { get; set; }
        public string hour { get; set; }
        public string customer_id { get; set; }
        public string partial_total { get; set; }
        public string taxes { get; set; }
        public string discount { get; set; }
        public string point_sale { get; set; }
        public string shipment { get; set; }
        public string shipment_value { get; set; }
        public string shipment_date { get; set; }
        public string delivered { get; set; }
        public string store_note { get; set; }
        public string customer_note { get; set; }
        public string partner_id { get; set; }
        public string discount_coupon { get; set; }
        public string payment_method_rate { get; set; }
        public string installment { get; set; }
        public string sending_code { get; set; }
        public string sending_date { get; set; }
        public string billing_address { get; set; }
        public string delivery_time { get; set; }
        public string payment_method_id { get; set; }
        public string session_id { get; set; }
        public string total { get; set; }
        public List<PedidoProductsSold> ProductsSold { get; set; }
        public List<PedidoPayment> Payment { get; set; }
        public List<PedidoOrderInvoice> OrderInvoice { get; set; }
        public PedidoCustomerAddress CustomerAddress { get; set; }
        public PedidoPaymentsNotification payments_notification { get; set; }
    }

    public class CustomerAddress2
    {
        public string id { get; set; }
    }

    public class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string phone { get; set; }
        public string cellphone { get; set; }
        public string birth_date { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string nickname { get; set; }
        public string token { get; set; }
        public string total_orders { get; set; }
        public string observation { get; set; }
        public string type { get; set; }
        public string cnpj { get; set; }
        public string company_name { get; set; }
        public string state_inscription { get; set; }
        public string reseller { get; set; }
        public string discount { get; set; }
        public string blocked { get; set; }
        public string credit_limit { get; set; }
        public string indicator_id { get; set; }
        public string profile_customer_id { get; set; }
        public string last_sending_newsletter { get; set; }
        public string last_purchase { get; set; }
        public string last_visit { get; set; }
        public string last_modification { get; set; }
        public string address { get; set; }
        public string zip_code { get; set; }
        public string number { get; set; }
        public string complement { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string newsletter { get; set; }
        public string created { get; set; }
        public string registration_date { get; set; }
        public string modified { get; set; }
        public List<CustomerAddress2> CustomerAddress { get; set; }
    }


    public class CustomerAddress
    {
        public string id { get; set; }
        public string customer_id { get; set; }
        public string recipient { get; set; }
        public string address { get; set; }
        public string number { get; set; }
        public string complement { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string country { get; set; }
        public string type { get; set; }
        public string active { get; set; }
        public string description { get; set; }
    }

    public class Partner
    {
        public string id { get; set; }
        public string name { get; set; }
        public string site { get; set; }
        public string commission { get; set; }
    }

    public class TrayMarketplace
    {
        public Partner Partner { get; set; }
    }
    public class TrayEndereco
    {
        public CustomerAddress CustomerAddress { get; set; }
    }
    public class TrayPedido
    {
        public PedidoOrder Order { get; set; }

    }

    public class TrayPedidoPagamento
    {
        public Payment Payment { get; set; }
    }

    public class TrayPedidoProduto
    {
        public ProductsSold ProductsSold { get; set; }
    }

    public class TrayCliente
    {
        public Customer Customer { get; set; }
    }
}
