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
    [DataContract(Name = "xml", Namespace="")]
    [XmlRoot(ElementName = "xml", Namespace = "")]
    public class AlimentaEntidadeMestraXML
    {
        public AlimentaEntidadeMestraXML()
        {
            AlimentaEntidadeMestra = new AlimentaEntidadeMestra();
        }
        [DataMember(Name = "AlimentaEntidadeMestra")]
        [XmlElement(ElementName = "AlimentaEntidadeMestra", Namespace = "vx")]
        public AlimentaEntidadeMestra AlimentaEntidadeMestra { get; set; }
    }

    [DataContract(Name = "AlimentaEntidadeMestra", Namespace = "vx")]
    [XmlRoot(ElementName = "AlimentaEntidadeMestra", Namespace = "vx")]
    public class AlimentaEntidadeMestra: IBaseAjuri
    {
        public AlimentaEntidadeMestra()
        {
            Entidades = new Entidades();
            Ticket = new Ticket();
        }
        [DataMember(Name = "ticket")]
        [XmlElement(ElementName = "ticket", Namespace = "vx")]
        public Ticket Ticket { get; set; }
        [DataMember(Name = "entidades")]
        [XmlElement(ElementName = "entidades", Namespace = "vx")]
        public Entidades Entidades { get; set; }
    }
}
