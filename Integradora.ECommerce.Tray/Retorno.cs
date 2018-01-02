using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Tray
{
    public class RetornoChave
    {
        public int code { get; set; }
        public string message { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string date_expiration_access_token { get; set; }
        public string date_expiration_refresh_token { get; set; }
    }

    public class RetornoProduto
    {
        public string message { get; set; }
        public string id { get; set; }
        public int code { get; set; }
    }

    public class RetornoNotaFiscal
    {
        public string message { get; set; }
        public string id { get; set; }
        public int code { get; set; }
    }

}
