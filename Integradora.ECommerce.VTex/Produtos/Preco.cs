using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex.Produtos
{
    [Serializable]
    public class VTexPreco
    {
        public string Id { get; set; }
        public int itemId { get; set; }
        public int salesChannel { get; set; }
        public decimal price { get; set; }
        public decimal listPrice { get; set; }
        public string validFrom { get; set; }
        public string validTo { get; set; }
    }
}
