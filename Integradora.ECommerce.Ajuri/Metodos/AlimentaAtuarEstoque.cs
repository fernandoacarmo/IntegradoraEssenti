using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integradora.ECommerce.Ajuri.Comum;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace Integradora.ECommerce.Ajuri.Metodos
{

    [DataContract(Name = "xml")]
    [XmlRoot(ElementName = "xml")]
    public class AlimentaAtuarEstoqueXML
    {
        [DataMember(Name = "AlimentaAtuarEstoque")]
        [XmlElement(ElementName = "AlimentaAtuarEstoque", Namespace = "vx")]
        public AlimentaAtuarEstoque AlimentaAtuarEstoque { get; set; }
    }

    [DataContract(Name = "AlimentaAtuarEstoque", Namespace = "vx")]
    [XmlRoot(ElementName = "AlimentaAtuarEstoque", Namespace = "vx")]
    public class AlimentaAtuarEstoque: IBaseAjuri
    {
        public AlimentaAtuarEstoque()
        {
            Ticket = new Ticket();
            Atuacoes = new Atuacoes();
        }
        [DataMember(Name = "ticket")]
        [XmlElement(ElementName = "ticket", Namespace = "vx")]
        public Ticket Ticket { get; set; }
        [DataMember(Name = "atuacoes")]
        [XmlElement(ElementName = "atuacoes", Namespace = "vx")]
        public Atuacoes Atuacoes { get; set; }
        [DataMember(Name = "status")]
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
    }
}
