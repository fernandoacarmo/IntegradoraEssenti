using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.IShopping.Retornos
{
    public class Address
    {
        public string name { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string company { get; set; }
        public string street_address { get; set; }
        public int street_number { get; set; }
        public string street_complemento { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }
        public string state { get; set; }
        public string state_code { get; set; }
        public string country { get; set; }
        public string format_id { get; set; }
    }


    public class Address2
    {
        public string postcode { get; set; }
        public string street { get; set; }
        public int number { get; set; }
        public string complement { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public string state_code { get; set; }
        public string state { get; set; }
        public string country { get; set; }
    }

    public class Primary
    {
        public int ddd { get; set; }
        public string number { get; set; }
    }

    public class Cellphone
    {
        public int ddd { get; set; }
        public string number { get; set; }
    }

    public class Phones
    {
        public Primary primary { get; set; }
        public Cellphone cellphone { get; set; }
    }

    public class Total
    {
        public string code { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public double value { get; set; }
        public double value_action { get; set; }
        public string action { get; set; }
        public int sort_order { get; set; }
    }


    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string cod_ref { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public double price_unit { get; set; }
        public double price_final { get; set; }
        public double weight { get; set; }
        public Dimensions dimensions { get; set; }
        public string configuration { get; set; }
        public object attributes { get; set; }
        public string mercadolivre_id { get; set; }
        public List<int> related_categories { get; set; }
    }

    public class Pedido
    {
        public int status { get; set; }
        public int orderId { get; set; }
        public bool orderIsComplete { get; set; }
        public double totalValue { get; set; }
        public Order order { get; set; }
    }
}
