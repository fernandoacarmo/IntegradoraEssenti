using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.Ajuri.Comum
{
    [DataContract(Name = "conferencia", Namespace = "vx")]
    [XmlRoot(ElementName = "conferencia", Namespace = "vx")]
    public class Conferencia
    {
        public Conferencia()
        {
            Livres = new Livres();
            Entidade = new Entidade();
            Cabecalhochave = new Cabecalhochave();
            Itens = new Itens();
        }
        [DataMember(Name = "data")]
        [XmlElement(ElementName = "data", Namespace = "vx")]
        public string Data { get; set; }
        [DataMember(Name = "cabecalho-chave")]
        [XmlElement(ElementName = "cabecalho-chave", Namespace = "vx")]
        public Cabecalhochave Cabecalhochave { get; set; }
        [DataMember(Name = "entidade")]
        [XmlElement(ElementName = "entidade", Namespace = "vx")]
        public Entidade Entidade { get; set; }
        [DataMember(Name = "itens")]
        [XmlElement(ElementName = "itens", Namespace = "vx")]
        public Itens Itens { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres", Namespace = "vx")]
        public Livres Livres { get; set; }
        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }
    }
}
