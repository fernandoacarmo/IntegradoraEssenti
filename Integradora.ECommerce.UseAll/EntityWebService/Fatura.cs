using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.UseAll.EntityWebService
{
    public class Fatura : Entity
    {
        public string addata_pagto { get; set; }
        public long anidAgente { get; set; }
        public long annumero_fiscal { get; set; }
        public long aniduc { get; set; }
        public string adanomes { get; set; }
        public decimal anvalor_pagto { get; set; }
        public string ascobrar_multa { get; set; }
    }
}
