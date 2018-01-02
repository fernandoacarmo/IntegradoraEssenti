using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.UseAll.Entity
{
    public class Cobranca : Entity
    {
        public long anidzona { get; set; }
        public long anidconta { get; set; }
        public long aniditem { get; set; }
        public long anmesfatura { get; set; }
        public long ananofatura { get; set; }
        public string addatalancto { get; set; }
        public decimal anvalor { get; set; }
        public string asideverest { get; set; }
        public string ashistorico { get; set; }
    }
}
