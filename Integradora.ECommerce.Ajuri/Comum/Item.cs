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
    [DataContract(Name = "item", Namespace = "vx")]
    [XmlRoot(ElementName = "item", Namespace = "vx")]
    public class Item
    {
        public Item()
        {
            Produto = new Produto();
            Embalagem = new Embalagem();
        }
        [DataMember(Name = "resultado")]
        [XmlElement(ElementName = "resultado", Namespace = "vx")]
        public string Resultado { get; set; }
        [DataMember(Name = "produto")]
        [XmlElement(ElementName = "produto", Namespace = "vx")]
        public Produto Produto { get; set; }
        [DataMember(Name = "quantidade")]
        [XmlElement(ElementName = "quantidade", Namespace = "vx")]
        public string Quantidade { get; set; }
        [DataMember(Name = "quantidade-processada")]
        [XmlElement(ElementName = "quantidade-processada", Namespace = "vx")]
        public string Quantidadeprocessada { get; set; }
        [DataMember(Name = "quantidade-unidades")]
        [XmlElement(ElementName = "quantidade-unidades", Namespace = "vx")]
        public string quantidadeunidades{ get; set; }
        [DataMember(Name = "valor-unitario")]
        [XmlElement(ElementName = "valor-unitario", Namespace = "vx")]
        public string Valorunitario { get; set; }
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
        [DataMember(Name = "localizacao")]
        [XmlElement(ElementName = "localizacao", Namespace = "vx")]
        public string Localizacao { get; set; }
        [DataMember(Name = "embalagem")]
        [XmlElement(ElementName = "embalagem", Namespace = "vx")]
        public Embalagem Embalagem { get; set; }
        [DataMember(Name = "sem-lote")]
        [XmlElement(ElementName = "sem-lote", Namespace = "vx")]
        public string Semlote { get; set; }
        [DataMember(Name = "tipo-estoque")]
        [XmlElement(ElementName = "tipo-estoque", Namespace = "vx")]
        public string Tipoestoque{ get; set; }
    }
}
