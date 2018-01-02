using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Interfaces
{
    public interface IDomain
    {

    }
    public interface IDomain<T> : IDomain where T : IEntity
    {
        T LoadEntity(long id);
        void ExportEntity(T value);
        bool Exist(T value);
    }
}
