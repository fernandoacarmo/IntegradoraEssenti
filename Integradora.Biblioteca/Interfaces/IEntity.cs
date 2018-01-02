using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.Biblioteca.Interfaces
{
    public interface IEntity
    {
    }

    interface IEntity<T> : IEntity where T : IEntity
    {
        T LoadEntity(string oid);
    }
}
