using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Interfaces
{
    public interface IERP
    {
        string ConnectionString { get; set; }
        Dictionaries.Tips.ERP ERP();
        void Initialize();
    }
}
