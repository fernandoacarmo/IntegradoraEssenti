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
    [DataContract(Name = "endereco", Namespace = "vx")]
    [XmlRoot(ElementName = "endereco", Namespace = "vx")]
    public class Endereco
    {
        public Endereco()
        { 
        }
        [DataMember(Name = "tipo")]
        [XmlElement(ElementName = "tipo", Namespace = "vx")]
        public string Tipo { get; set; }
        [DataMember(Name = "cep")]
        [XmlElement(ElementName = "cep", Namespace = "vx")]
        public string Cep { get; set; }
        [DataMember(Name = "logradouro-tipo")]
        [XmlElement(ElementName = "logradouro-tipo", Namespace = "vx")]
        public string Logradourotipo { get; set; }
        [DataMember(Name = "logradouro")]
        [XmlElement(ElementName = "logradouro", Namespace = "vx")]
        public string Logradouro { get; set; }
        [DataMember(Name = "numero")]
        [XmlElement(ElementName = "numero", Namespace = "vx")]
        public string Numero { get; set; }
        [DataMember(Name = "bairro")]
        [XmlElement(ElementName = "bairro", Namespace = "vx")]
        public string Bairro { get; set; }
        [DataMember(Name = "cidade")]
        [XmlElement(ElementName = "cidade", Namespace = "vx")]
        public string Cidade { get; set; }
        [DataMember(Name = "uf")]
        [XmlElement(ElementName = "uf", Namespace = "vx")]
        public string Uf { get; set; }
    }

}
