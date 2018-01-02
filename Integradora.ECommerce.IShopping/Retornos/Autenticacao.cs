using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.IShopping.Retornos
{
    public class Autenticacao
    {
        public int status { get; set; }
        public string token { get; set; }
        public int expires_in { get; set; }

    }
}
