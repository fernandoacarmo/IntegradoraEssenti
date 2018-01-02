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
    [DataContract(Name = "gerador", Namespace = "vx")]
    [XmlRoot(ElementName = "gerador", Namespace = "vx")]
    public class Gerador
    {
        public Gerador()
        { 
        }
        [DataMember(Name = "login")]
        [XmlElement(ElementName = "login", Namespace = "vx")]
        public string Login { get; set; }
        [DataMember(Name = "nome")]
        [XmlElement(ElementName = "nome", Namespace = "vx")]
        public string Nome { get; set; }
        [DataMember(Name = "atribuicao")]
        [XmlElement(ElementName = "atribuicao", Namespace = "vx")]
        public string Atribuicao { get; set; }
        [DataMember(Name = "host")]
        [XmlElement(ElementName = "host", Namespace = "vx")]
        public string Host { get; set; }
        [DataMember(Name = "data")]
        [XmlElement(ElementName = "data", Namespace = "vx")]
        public string Data { get; set; }
        [DataMember(Name = "operacao")]
        [XmlElement(ElementName = "operacao", Namespace = "vx")]
        public string Operacao { get; set; }
        [DataMember(Name = "pid")]
        [XmlElement(ElementName = "pid", Namespace = "vx")]
        public string Pid { get; set; }
    }
}
