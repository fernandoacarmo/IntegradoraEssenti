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
    [DataContract(Name = "conferencias", Namespace = "vx")]
    [XmlRoot(ElementName = "conferencias", Namespace = "vx")]
    public class Conferencias
    {
        public Conferencias()
        {
            Conferencia = new List<Conferencia>();
        }
        [DataMember(Name = "conferencia")]
        [XmlElement(ElementName = "conferencia", Namespace = "vx")]
        public List<Conferencia> Conferencia { get; set; }
    }
}

