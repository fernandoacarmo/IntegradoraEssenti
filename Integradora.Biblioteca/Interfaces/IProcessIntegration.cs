using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Interfaces
{
    public interface IProcessIntegration
    {
        void Process(Integradora.Biblioteca.Dictionaries.Tips.ClientePC codigoclientepc);
    }
}
