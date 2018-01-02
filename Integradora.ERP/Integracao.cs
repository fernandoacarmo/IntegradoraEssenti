using Integradora.Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP
{
    public abstract class Integracao : IERP
    {
        public abstract string ConnectionString { get; set; }
        public abstract Biblioteca.Dictionaries.Tips.ERP ERP();
        public abstract void Initialize();
    }
}
