using Integradora.Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.Virtuemart
{
    class Receber: IProcessIntegration
    {
        public Integradora.ECommerce.Virtuemart.Integracao LojaECommerce { get; set; }
        public Receber()
        {
            LojaECommerce = new ECommerce.Virtuemart.Integracao();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {

        }
    
    }
}
