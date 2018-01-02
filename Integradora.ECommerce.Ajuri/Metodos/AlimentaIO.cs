using Integradora.ECommerce.Ajuri.Comum;
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

namespace Integradora.ECommerce.Ajuri.Metodos
{
    [DataContract(Name = "xml")]
    [XmlRoot(ElementName = "xml")]
    public class AlimentaIOXML
    {
        [DataMember(Name = "AlimentaIO")]
        [XmlElement(ElementName = "AlimentaIO", Namespace = "vx")]
        public AlimentaIO AlimentaIO { get; set; }
    }

    [DataContract(Name = "alimentaIO", Namespace = "vx")]
    [XmlRoot(ElementName = "alimentaIO", Namespace = "vx")]
    public class AlimentaIO : IBaseAjuri
    {
        public AlimentaIO()
        {
            Documentos = new Documentos();
            Ticket = new Ticket();
        }

        [DataMember(Name = "ticket")]
        [XmlElement(ElementName = "ticket", Namespace = "vx")]
        public Ticket Ticket { get; set; }
        [DataMember(Name = "documentos")]
        [XmlElement(ElementName = "documentos", Namespace = "vx")]
        public Documentos Documentos { get; set; }
    }

}
