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
    [DataContract(Name = "documentos", Namespace = "vx")]
    [XmlRoot(ElementName = "documentos", Namespace = "vx")]
    public class Documentos
    {
        public Documentos()
        {
            Documento = new List<Documento>();
        }
        [DataMember(Name = "documento")]
        [XmlElement(ElementName = "documento", Namespace = "vx")]
        public List<Documento> Documento { get; set; }
    }
}

