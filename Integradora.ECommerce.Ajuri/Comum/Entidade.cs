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
    [DataContract(Name = "entidade", Namespace = "vx")]
    [XmlRoot(ElementName = "entidade", Namespace = "vx")]
    public class Entidade
    {
        public Entidade()
        {
            Livres = new Livres();
            Endereco = new Endereco();
        }
        [DataMember(Name = "tipo")]
        [XmlElement(ElementName = "tipo", Namespace = "vx")]
        public string Tipo { get; set; }
        [DataMember(Name = "documento-federal")]
        [XmlElement(ElementName = "documento-federal", Namespace = "vx")]
        public string Documentofederal { get; set; }
        [DataMember(Name = "documento-estadual")]
        [XmlElement(ElementName = "documento-estadual", Namespace = "vx")]
        public string Documentoestadual { get; set; }
        [DataMember(Name = "documento-municipal")]
        [XmlElement(ElementName = "documento-municipal", Namespace = "vx")]
        public string Documentomunicipal { get; set; }
        [DataMember(Name = "razao")]
        [XmlElement(ElementName = "razao", Namespace = "vx")]
        public string Razao { get; set; }
        [DataMember(Name = "fantasia")]
        [XmlElement(ElementName = "fantasia", Namespace = "vx")]
        public string Fantasia { get; set; }
        [DataMember(Name = "endereco")]
        [XmlElement(ElementName = "endereco", Namespace = "vx")]
        public Endereco Endereco { get; set; }
        [DataMember(Name = "is-cliente")]
        [XmlElement(ElementName = "is-cliente", Namespace = "vx")]
        public string Iscliente { get; set; }
        [DataMember(Name = "is-fornecedor")]
        [XmlElement(ElementName = "is-fornecedor", Namespace = "vx")]
        public string Isfornecedor { get; set; }
        [DataMember(Name = "fabricante")]
        [XmlElement(ElementName = "is-fabricante", Namespace = "vx")]
        public string Isfabricante { get; set; }
        [DataMember(Name = "destinatario")]
        [XmlElement(ElementName = "is-destinatario", Namespace = "vx")]
        public string Isdestinatario { get; set; }
        [DataMember(Name = "observacoes")]
        [XmlElement(ElementName = "observacoes", Namespace = "vx")]
        public string Observacoes { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres", Namespace = "vx")]
        public Livres Livres { get; set; }
    }
}
