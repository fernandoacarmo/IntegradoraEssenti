using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.VTex.Produtos
{
    [Serializable]
    public class VTexEstoque
    {
        public string wareHouseId { get; set; }
        public string itemId { get; set; }
        public bool unlimitedQuantity { get; set; }
        public string dateUtcOnBalanceSystem { get; set; }
        public int quantity { get; set; }
    }
}
