using Integradora.Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Norma.Winthor.DataHub
{
    class Receber : IProcessIntegration
    {
        public Integradora.ECommerce.DataHub.Integracao LojaECommerce { get; set; }
        public Receber()
        {
            LojaECommerce = new ECommerce.DataHub.Integracao();
        }
        public void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc)
        {

        }
    }
}
