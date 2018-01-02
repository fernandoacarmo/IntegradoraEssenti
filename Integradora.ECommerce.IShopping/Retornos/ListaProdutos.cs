using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.IShopping.Retornos
{
    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string parent_id { get; set; }
    }

    public class Option
    {
        public string title { get; set; }
        public string value { get; set; }
    }

    public class Attribute
    {
        public string id { get; set; }
        public string isDefault { get; set; }
        public string status { get; set; }
        public string cod_ref { get; set; }
        public string stock { get; set; }
        public bool image { get; set; }
        public List<Option> options { get; set; }
    }

    public class Produto
    {
        public int id { get; set; }
        public string date_added { get; set; }
        public string last_modified { get; set; }
        public string status { get; set; }
        public string cod_ref { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
        public Dimensions dimensions { get; set; }
        public string stock_check_method { get; set; }
        public int quantity { get; set; }
        public int quantity_max_buy { get; set; }
        public int quantity_min_buy { get; set; }
        public int quantity_critical { get; set; }
        public string description_small { get; set; }
        public string description_full { get; set; }
        public int orders { get; set; }
        public int views { get; set; }
        public string availability { get; set; }
        public string allow_buy { get; set; }
        public int points { get; set; }
        public string image_default { get; set; }
        public List<string> images { get; set; }
        public string categories_path { get; set; }
        public List<Category> categories { get; set; }
        public List<Attribute> attributes { get; set; }
    }

    public class Produtos
    {
        public int status { get; set; }
        public int totalFound { get; set; }
        public int totalCount { get; set; }
        public string limit { get; set; }
        public List<Produto> result { get; set; }
    }
}
