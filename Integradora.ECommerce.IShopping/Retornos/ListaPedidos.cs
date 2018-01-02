using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.IShopping.Retornos
{
    public class ListaPedidos
    {
        public int status { get; set; }
        public string limit { get; set; }
        public int ordersFound { get; set; }
        public double ordersTotal { get; set; }
        public List<Order> orders { get; set; }
    }
}
