using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Interfaces
{
    public interface ISGDB
    {
        DataTable ExecutaComando(string comando);
        void ExecuteNonQuery(string comando);
        void ExecutarProcedure(string StoredProcedure, string parametros, string valores);
    }
}
