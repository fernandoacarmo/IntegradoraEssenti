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
    [DataContract(Name = "motivo", Namespace = "vx")]
    [XmlRoot(ElementName = "motivo", Namespace = "vx")]
    public class Motivo
    {
        public Motivo()
        { 
        }
        [DataMember(Name = "codigo")]
        [XmlElement(ElementName = "codigo", Namespace = "vx")]
        public string Codigo { get; set; }
    }
}
