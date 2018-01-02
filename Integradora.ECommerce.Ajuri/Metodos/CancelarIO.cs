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
    public class CancelarIOXML
    {
        [DataMember(Name = "CancelarIO")]
        [XmlElement(ElementName = "CancelarIO", Namespace = "vx")]
        public CancelarIO CancelarIO { get; set; }
    }

    [DataContract(Name = "cancelarIO", Namespace = "vx")]
    [XmlRoot(ElementName = "CancelarIO", Namespace = "vx")]
    public class CancelarIO : IBaseAjuri
    {
        public CancelarIO()
        {
            Ticket = new Ticket();
            Gerador = new Gerador();
            Documentos = new Cancelamentos();
        }
        [DataMember(Name = "ticket")]
        [XmlElement(ElementName = "ticket", Namespace = "vx")]
        public Ticket Ticket { get; set; }
        [DataMember(Name = "gerador")]
        [XmlElement(ElementName = "gerador", Namespace = "vx")]
        public Gerador Gerador { get; set; }
        [DataMember(Name = "documentos")]
        [XmlElement(ElementName = "documentos", Namespace = "vx")]
        public Cancelamentos Documentos { get; set; }
    }
}
