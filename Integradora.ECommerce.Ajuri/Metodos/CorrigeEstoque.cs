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
    public class CorrigeEstoqueXML
    {
        [DataMember(Name = "CorrigeEstoque")]
        [XmlElement(ElementName = "CorrigeEstoque", Namespace = "vx")]
        public CorrigeEstoque CorrigeEstoque { get; set; }
    }

    [DataContract(Name = "corrigeEstoque", Namespace = "vx")]
    [XmlRoot(ElementName = "CorrigeEstoque", Namespace = "vx")]
    public class CorrigeEstoque
    {
        public CorrigeEstoque()
        {
            Ticket = new Ticket();
            Gerador = new Gerador();
            Correcoes = new Correcoes();
        }
        [DataMember(Name = "ticket")]
        [XmlElement(ElementName = "ticket", Namespace = "vx")]
        public Ticket Ticket { get; set; }
        [DataMember(Name = "gerador")]
        [XmlElement(ElementName = "gerador", Namespace = "vx")]
        public Gerador Gerador { get; set; }
        [DataMember(Name = "correcoes")]
        [XmlElement(ElementName = "correcoes", Namespace = "vx")]
        public Correcoes Correcoes { get; set; }
    }
}
