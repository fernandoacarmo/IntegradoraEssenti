using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Tray
{

//    public class Paging
//    {
//        public int total { get; set; }
//        public int page { get; set; }
//        public int offset { get; set; }
//        public int limit { get; set; }
//        public int maxLimit { get; set; }
//    }
//
//    public class Sort
//    {
//        public string id { get; set; }
//    }

//    public class Products
//    {
//        public string id { get; set; }
//    }
//
//    public class Payment
//    {
//        public string id { get; set; }
//    }
//
//    public class OrderInvoice
//    {
//        public string id { get; set; }
//    }

    public class Order
    {
        public string status { get; set; }
        public string id { get; set; }
        public string date { get; set; }
        public string customer_id { get; set; }
        public string partial_total { get; set; }
        public string taxes { get; set; }
        public string discount { get; set; }
        public string shipment_value { get; set; }
        public string shipment_date { get; set; }
        public string discount_coupon { get; set; }
        public string payment_method_rate { get; set; }
        public string session_id { get; set; }
        public string total { get; set; }
        public string access_code { get; set; }
//        public List<Products> ProductsSold { get; set; }
//        public List<Payment> Payment { get; set; }
//        public List<OrderInvoice> OrderInvoice { get; set; }
    }

    public class ListaOrder
    {
        public Order Order { get; set; }
    }

    public class TrayListaPedidos
    {
//        public Paging paging { get; set; }
//        public List<Sort> sort { get; set; }
//        public List<string> availableFilters { get; set; }
//        public List<object> appliedFilters { get; set; }
        public List<ListaOrder> Orders { get; set; }
    }
    
}
