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
    [DataContract(Name = "predio", Namespace = "vx")]
    [XmlRoot(ElementName = "predio", Namespace = "vx")]
    public class Predio
    {
        public Predio()
        { 
        }
        [DataMember(Name = "codigo")]
        [XmlElement(ElementName = "codigo", Namespace = "vx")]
        public string Codigo { get; set; }
        [DataMember(Name = "descricao")]
        [XmlElement(ElementName = "descricao", Namespace = "vx")]
        public string Descricao { get; set; }
    }
}
