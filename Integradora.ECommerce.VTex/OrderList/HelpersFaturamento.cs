using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex.OrderList
{
    /// <summary>
    /// Itens do pedido que foi faturado
    /// </summary>
    public class ItemFaturamento
    {
        public string id { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
    }

    /// <summary>
    /// Pedido faturado
    /// </summary>
    public class RootObjectFaturamento
    {
        public string type { get; set; }
        public string invoiceNumber { get; set; }
        public string invoiceKey { get; set; }
        public string courier { get; set; }
        public string trackingNumber { get; set; }
        public string trackingUrl { get; set; }
        public List<ItemFaturamento> items { get; set; }
        public string issuanceDate { get; set; }
        public int invoiceValue { get; set; }

//        public string type { get; set; }
//        public string invoiceNumber { get; set; }
//        public string courier { get; set; }
//        public string trackingNumber { get; set; }
//        public string trackingUrl { get; set; }
//        public List<ItemFaturamento> items { get; set; }
//        public string issuanceDate { get; set; }
//        public int invoiceValue { get; set; }
    }
}
