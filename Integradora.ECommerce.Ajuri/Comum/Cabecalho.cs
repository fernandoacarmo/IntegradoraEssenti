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
    [DataContract(Name = "cabecalho", Namespace = "vx")]
    [XmlRoot(ElementName = "cabecalho", Namespace = "vx")]
    public class Cabecalho
    {
        public Cabecalho()
        {
            Cliente = new Cliente();
            Cfop = new Cfop();
            Entidade = new Entidade();
        }
        [DataMember(Name = "entidade")]
        [XmlElement(ElementName = "entidade", Namespace = "vx")]
        public Entidade Entidade{ get; set; }
        [DataMember(Name = "cliente")]
        [XmlElement(ElementName = "cliente", Namespace = "vx")]
        public Cliente Cliente { get; set; }
        [DataMember(Name = "divisao-chave")]
        [XmlElement(ElementName = "divisao-chave", Namespace = "vx")]
        public string Divisaochave { get; set; }
        [DataMember(Name = "numero")]
        [XmlElement(ElementName = "numero", Namespace = "vx")]
        public string Numero { get; set; }
        [DataMember(Name = "data")]
        [XmlElement(ElementName = "data", Namespace = "vx")]
        public string Data { get; set; }
        [DataMember(Name = "hora")]
        [XmlElement(ElementName = "hora", Namespace = "vx")]
        public string Hora { get; set; }
        [DataMember(Name = "serie")]
        [XmlElement(ElementName = "serie", Namespace = "vx")]
        public string Serie { get; set; }
        [DataMember(Name = "cfop")]
        [XmlElement(ElementName = "cfop", Namespace = "vx")]
        public Cfop Cfop { get; set; }
    }
}
