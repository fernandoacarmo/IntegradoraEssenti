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
    [DataContract(Name = "filial", Namespace = "vx")]
    [XmlRoot(ElementName = "filial", Namespace = "vx")]
    public class Filial
    {
        public Filial()
        { 
        }
        [DataMember(Name = "codigo")]
        [XmlElement(ElementName = "codigo", Namespace = "vx")]
        public string Codigo { get; set; }
        [DataMember(Name = "documento-federal")]
        [XmlElement(ElementName = "documento-federal", Namespace = "vx")]
        public string Documentofederal { get; set; }
        [DataMember(Name = "razao-social")]
        [XmlElement(ElementName = "razao-social", Namespace = "vx")]
        public string Razaosocial { get; set; }
    }
}
