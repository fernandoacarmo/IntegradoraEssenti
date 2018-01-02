using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.Shoppub
{
    public class Fabricante
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string slug { get; set; }
        public string seo_descricao { get; set; }
        public bool ativo { get; set; }
    }
}
