using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.IShopping.Retornos
{
    public class Dimensions
    {
        public int width { get; set; }
        public int height { get; set; }
        public int length { get; set; }
    }

    public class Shipping
    {
        public string method { get; set; }
        public string title { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public double cost { get; set; }
        public string track_id { get; set; }
        public Address address { get; set; }
    }

    public class Payment
    {
        public string method { get; set; }
        public string title { get; set; }
        public int installments { get; set; }
    }
    public class Nfe
    {
        public string number { get; set; }
        public string key { get; set; }
        public string series { get; set; }
        public string date { get; set; }
    }

    public class Customer
    {
        public int id { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string company { get; set; }
        public string cpf_cnpj { get; set; }
        public string rg { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string dob { get; set; }
        public Address2 address { get; set; }
        public Phones phones { get; set; }
    }


    public class Order
    {
        public int statusId { get; set; }

        public double orderTotal { get; set; }
        public string statusDescription { get; set; }
        public string datePurchased { get; set; }
        public string lastModified { get; set; }
        public string currency { get; set; }
        public int currencyValue { get; set; }
        public int affiliateId { get; set; }
        public int orderId { get; set; }
        public string note { get; set; }
        public Shipping shipping { get; set; }
        public Payment payment { get; set; }
        public Nfe nfe { get; set; }
        public Customer customer { get; set; }
        public List<Total> totals { get; set; }
        public List<Product> products { get; set; }
    }


}
