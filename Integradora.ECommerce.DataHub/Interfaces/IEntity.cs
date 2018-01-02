using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integradora.ECommerce.DataHub.Interfaces
{
    public interface IEntity
    {
        string assinatura { get; set; }
        string sistema { get; set; }

    }
}
