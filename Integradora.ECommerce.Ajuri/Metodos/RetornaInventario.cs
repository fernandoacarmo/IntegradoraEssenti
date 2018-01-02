using Integradora.ECommerce.Ajuri.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.Ajuri.Metodos
{
    [DataContract(Name = "xml")]
    [XmlRoot(ElementName = "xml")]
    public class RetornaInventarioXML
    {
        [DataMember(Name = "RetornaInventario")]
        [XmlElement(ElementName = "RetornaInventario", Namespace = "vx")]
        public RetornaInventario RetornaInventario { get; set; }
    }

    [XmlRoot(ElementName = "RetornaInventario", Namespace = "vx")]
    public class RetornaInventario
    {
        public RetornaInventario()
        {
            Itens = new Itens();
            Livres = new Livres();
        }
        [DataMember(Name = "inventario_id")]
        [XmlElement(ElementName = "inventario_id", Namespace = "vx")]
        public string Inventario_id { get; set; }
        [DataMember(Name = "data-origem")]
        [XmlElement(ElementName = "data-origem", Namespace = "vx")]
        public string Data_origem { get; set; }
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
