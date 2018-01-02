using Integradora.ECommerce.Ajuri.Metodos;
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
    [DataContract(Name = "atuacao", Namespace = "vx")]
    [XmlRoot(ElementName = "atuacao", Namespace = "vx")]
    public class Atuacao
    {
        public Atuacao()
        {
            Livres = new Livres();
            Cliente = new Cliente();
            Motivo = new Motivo();
            Produto = new Produto();
            Filial = new Filial();
        }
        [DataMember(Name = "filial")]
        [XmlElement(ElementName = "filial", Namespace = "vx")]
        public Filial Filial { get; set; }
        [DataMember(Name = "descricao")]
        [XmlElement(ElementName = "descricao", Namespace = "vx")]
        public string Descricao { get; set; }
        [DataMember(Name = "cliente")]
        [XmlElement(ElementName = "cliente", Namespace = "vx")]
        public Cliente Cliente { get; set; }
        [DataMember(Name = "motivo")]
        [XmlElement(ElementName = "motivo", Namespace = "vx")]
        public Motivo Motivo { get; set; }
        [DataMember(Name = "produto")]
        [XmlElement(ElementName = "produto", Namespace = "vx")]
        public Produto Produto { get; set; }
        [DataMember(Name = "lote")]
        [XmlElement(ElementName = "lote", Namespace = "vx")]
        public string Lote { get; set; }
        [DataMember(Name = "serial")]
        [XmlElement(ElementName = "serial", Namespace = "vx")]
        public string Serial { get; set; }
        [DataMember(Name = "modelo")]
        [XmlElement(ElementName = "modelo", Namespace = "vx")]
        public string Modelo { get; set; }
        [DataMember(Name = "data-fabricacao")]
        [XmlElement(ElementName = "data-fabricacao", Namespace = "vx")]
        public string Datafabricacao { get; set; }
        [DataMember(Name = "data-vencimento")]
        [XmlElement(ElementName = "data-vencimento", Namespace = "vx")]
        public string Datavencimento { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres", Namespace = "vx")]
        public Livres Livres { get; set; }
        [DataMember(Name = "quantidade")]
        [XmlElement(ElementName = "quantidade", Namespace = "vx")]
        public string Quantidade { get; set; }
        
        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }
    }
}
