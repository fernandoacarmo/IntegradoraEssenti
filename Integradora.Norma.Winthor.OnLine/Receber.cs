using Integradora.Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.OnLine
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.OnLine.Integracao LojaECommerce { get; set; }
        public Receber()
        {
            LojaECommerce = new ECommerce.OnLine.Integracao();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {

        }
    }
}
