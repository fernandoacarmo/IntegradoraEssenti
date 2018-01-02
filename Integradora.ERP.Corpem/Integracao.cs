using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Corpem
{
    public sealed class Integracao : Integradora.ERP.Integracao
    {
        public override string ConnectionString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override Biblioteca.Dictionaries.Tips.ERP ERP()
        {
            return Biblioteca.Dictionaries.Tips.ERP.Corpem;
        }
    }
}
