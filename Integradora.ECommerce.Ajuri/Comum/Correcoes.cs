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
    [DataContract(Name = "correcoes", Namespace = "vx")]
    [XmlRoot(ElementName = "correcoes", Namespace = "vx")]
    public class Correcoes
    {
        public Correcoes()
        {
            Correcao = new List<Correcao>();
        }
        [DataMember(Name = "correcao")]
        [XmlElement(ElementName = "correcao", Namespace = "vx")]
        public List<Correcao> Correcao { get; set; }
    }
}

