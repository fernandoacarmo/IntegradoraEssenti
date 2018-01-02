using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor
{
    public class Integracao : Integradora.ERP.Integracao
    {

        public override string ConnectionString { get; set; }

        public override Biblioteca.Dictionaries.Tips.ERP ERP()
        {
            return Biblioteca.Dictionaries.Tips.ERP.Winthor;
        }

        public override void Initialize()
        {

        }
    }
}
