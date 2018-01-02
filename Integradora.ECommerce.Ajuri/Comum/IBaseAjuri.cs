using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;


namespace Integradora.ECommerce.Ajuri.Comum
{
    public interface IBaseAjuri
    {
        Ticket Ticket { get; set; }
    }
}
