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
    [DataContract(Name = "posicao", Namespace = "vx")]
    [XmlRoot(ElementName = "posicao", Namespace = "vx")]
    public class Posicao
    {
        public Posicao()
        { 
        }
        [DataMember(Name = "rua")]
        [XmlElement(ElementName = "rua", Namespace = "vx")]
        public string Rua { get; set; }
        [DataMember(Name = "coluna")]
        [XmlElement(ElementName = "coluna", Namespace = "vx")]
        public string Coluna { get; set; }
        [DataMember(Name = "nivel")]
        [XmlElement(ElementName = "nivel", Namespace = "vx")]
        public string Nivel { get; set; }
    }
}
