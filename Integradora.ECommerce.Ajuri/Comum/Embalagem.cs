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
    [DataContract(Name = "embalagem", Namespace = "vx")]
    [XmlRoot(ElementName = "embalagem", Namespace = "vx")]
    public class Embalagem
    {
        public Embalagem()
        { 
        }
        [DataMember(Name = "codigo")]
        [XmlElement(ElementName = "codigo", Namespace = "vx")]
        public string Codigo { get; set; }
        [DataMember(Name = "comprimento-metros")]
        [XmlElement(ElementName = "comprimento-metros", Namespace = "vx")]
        public string Comprimentometros { get; set; }
        [DataMember(Name = "largura-metros")]
        [XmlElement(ElementName = "largura-metros", Namespace = "vx")]
        public string Largurametros { get; set; }
        [DataMember(Name = "altura-metros")]
        [XmlElement(ElementName = "altura-metros", Namespace = "vx")]
        public string Alturametros { get; set; }
        [DataMember(Name = "tara-kilos")]
        [XmlElement(ElementName = "tara-kilos", Namespace = "vx")]
        public string Tarakilos { get; set; }
    }
}
