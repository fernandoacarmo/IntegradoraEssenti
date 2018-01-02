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
    [DataContract(Name = "grupo", Namespace = "vx")]
    [XmlRoot(ElementName = "grupo", Namespace = "vx")]
    public class Grupo
    {
        public Grupo()
        { 
        }
        [DataMember(Name = "descricao")]
        [XmlElement(ElementName = "descricao", Namespace = "vx")]
        public string Descricao { get; set; }
    }
}
