using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.IShopping.Retornos
{
    public class Boleto
    {
        public string id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public bool status { get; set; }
    }

    public class Credito
    {
        public string id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public bool status { get; set; }
    }

    public class Outro
    {
        public string id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public bool status { get; set; }
    }

    public class Result
    {
        public List<Boleto> boleto { get; set; }
        public List<Credito> credito { get; set; }
        public List<Outro> outros { get; set; }
    }

    public class FormaPagamentos
    {
        public int status { get; set; }
        public Result result { get; set; }
    }
}
