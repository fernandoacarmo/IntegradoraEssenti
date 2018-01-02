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
    public class InventarioXML
    {
        [DataMember(Name = "Inventario")]
        [XmlElement(ElementName = "Inventario", Namespace = "")]
        public Inventario Inventario { get; set; }
    }

    [DataContract(Name = "inventario", Namespace = "")]
    [XmlRoot(ElementName = "Inventario")]
    public class Inventario
    {
        public Inventario()
        {
            Material = new MaterialLocal();
            Livres = new LivresLocal();
        }
        [DataMember(Name = "inventario_id")]
        [XmlElement(ElementName = "inventario_id", Namespace = "")]
        public string Inventario_id { get; set; }
        [DataMember(Name = "data_origem")]
        [XmlElement(ElementName = "data_origem", Namespace = "")]
        public string Data_origem { get; set; }
        [DataMember(Name = "material")]
        [XmlElement(ElementName = "material", Namespace = "")]
        public MaterialLocal Material { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres", Namespace = "")]
        public LivresLocal Livres { get; set; }

        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }
    }

    [DataContract(Name = "livres", Namespace = "")]
    [XmlRoot(ElementName = "livres", Namespace = "")]
    public class LivresLocal
    {
        public LivresLocal()
        {
            Livre = new List<LivreLocal>();
        }
        [DataMember(Name = "livre")]
        [XmlElement(ElementName = "livre", Namespace = "")]
        public List<LivreLocal> Livre { get; set; }
    }

    [DataContract(Name = "livre", Namespace = "")]
    [XmlRoot(ElementName = "livre", Namespace = "")]
    public class LivreLocal
    {
        public LivreLocal()
        {
        }
        [DataMember(Name = "indice")]
        [XmlElement(ElementName = "indice", Namespace = "")]
        public string Indice { get; set; }
        [DataMember(Name = "nome")]
        [XmlElement(ElementName = "nome", Namespace = "")]
        public string Nome { get; set; }
        [DataMember(Name = "valor")]
        [XmlElement(ElementName = "valor", Namespace = "")]
        public string Valor { get; set; }
    }

    [DataContract(Name = "itens", Namespace = "")]
    [XmlRoot(ElementName = "itens", Namespace = "")]
    public class MaterialLocal
    {
        public MaterialLocal()
        {
            Item = new List<ItemLocal>();
        }
        [DataMember(Name = "item")]
        [XmlElement(ElementName = "item", Namespace = "")]
        public List<ItemLocal> Item { get; set; }
    }

    [DataContract(Name = "item", Namespace = "")]
    [XmlRoot(ElementName = "item", Namespace = "")]
    public class ItemLocal
    {
        public ItemLocal()
        {
            Produto = new ProdutoLocal();
        }
        [DataMember(Name = "resultado")]
        [XmlElement(ElementName = "resultado", Namespace = "")]
        public string Resultado { get; set; }
        [DataMember(Name = "produto")]
        [XmlElement(ElementName = "produto", Namespace = "")]
        public ProdutoLocal Produto { get; set; }
        [DataMember(Name = "quantidade")]
        [XmlElement(ElementName = "quantidade", Namespace = "")]
        public string Quantidade { get; set; }
        [DataMember(Name = "quantidade-processada")]
        [XmlElement(ElementName = "quantidade-processada", Namespace = "")]
        public string Quantidadeprocessada { get; set; }
        [DataMember(Name = "quantidade-unidades")]
        [XmlElement(ElementName = "quantidade-unidades", Namespace = "")]
        public string quantidadeunidades { get; set; }
        [DataMember(Name = "valor-unitario")]
        [XmlElement(ElementName = "valor-unitario", Namespace = "")]
        public string Valorunitario { get; set; }
        [DataMember(Name = "lote")]
        [XmlElement(ElementName = "lote", Namespace = "")]
        public string Lote { get; set; }
        [DataMember(Name = "serial")]
        [XmlElement(ElementName = "serial", Namespace = "")]
        public string Serial { get; set; }
        [DataMember(Name = "modelo")]
        [XmlElement(ElementName = "modelo", Namespace = "")]
        public string Modelo { get; set; }
        [DataMember(Name = "data-fabricacao")]
        [XmlElement(ElementName = "data-fabricacao", Namespace = "")]
        public string Datafabricacao { get; set; }
        [DataMember(Name = "data-vencimento")]
        [XmlElement(ElementName = "data-vencimento", Namespace = "")]
        public string Datavencimento { get; set; }
        [DataMember(Name = "localizacao")]
        [XmlElement(ElementName = "localizacao", Namespace = "")]
        public string Localizacao { get; set; }
        [DataMember(Name = "sem-lote")]
        [XmlElement(ElementName = "sem-lote", Namespace = "")]
        public string Semlote { get; set; }
        [DataMember(Name = "tipo-estoque")]
        [XmlElement(ElementName = "tipo-estoque", Namespace = "")]
        public string Tipoestoque { get; set; }
    }

    [DataContract(Name = "produto", Namespace = "")]
    [XmlRoot(ElementName = "produto", Namespace = "")]
    public class ProdutoLocal
    {
        public ProdutoLocal()
        {
        }

        [DataMember(Name = "partnumber")]
        [XmlElement(ElementName = "partnumber", Namespace = "")]
        public string Partnumber { get; set; }
    }
}
