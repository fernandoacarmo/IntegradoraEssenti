using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ERP.Winthor.EntityWinthor
{
    class IntegracaoFila : OracleTable
    {
        public IntegracaoFila()
        { 
        }
        public override string GetTableName()
        {
            return "INTEGRACAOFILA";
        }
    }
}
