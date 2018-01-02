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
    [DataContract(Name = "livre", Namespace = "vx")]
    [XmlRoot(ElementName = "livre", Namespace = "vx")]
    public class Livre
    {
        public Livre()
        { 
        }
        [DataMember(Name = "indice")]
        [XmlElement(ElementName = "indice", Namespace = "vx")]
        public string Indice { get; set; }
        [DataMember(Name = "nome")]
        [XmlElement(ElementName = "nome", Namespace = "vx")]
        public string Nome { get; set; }
        [DataMember(Name = "valor")]
        [XmlElement(ElementName = "valor", Namespace = "vx")]
        public string Valor { get; set; }
    }
}

