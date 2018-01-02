using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.IShopping.Retornos
{
    public class ResultStatusPedido
    {
        public int id { get; set; }
        public string title { get; set; }
        public string color { get; set; }
    }

    public class StatusPedido
    {
        public int status { get; set; }
        public List<ResultStatusPedido> result { get; set; }
    }

    public class StatusAlterado
    {
        public int status { get; set; }
        public int orderId { get; set; }
    }
}
