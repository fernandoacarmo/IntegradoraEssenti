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
    [DataContract(Name = "documento", Namespace = "vx")]
    [XmlRoot(ElementName = "documento", Namespace = "vx")]
    public class Documento
    {
        public Documento()
        {
            Livres = new Livres();
            Filial = new Filial();
            Cabecalho = new Cabecalho();
            Cabecalhochave = new Cabecalhochave();
            Itens = new Itens();
        }
        [DataMember(Name = "filial")]
        [XmlElement(ElementName = "filial", Namespace = "vx")]
        public Filial Filial { get; set; }
        [DataMember(Name = "cabecalho-chave")]
        [XmlElement(ElementName = "cabecalho-chave", Namespace = "vx")]
        public Cabecalhochave Cabecalhochave { get; set; }
        [DataMember(Name = "cabecalho")]
        [XmlElement(ElementName = "cabecalho", Namespace = "vx")]
        public Cabecalho Cabecalho { get; set; }
        [DataMember(Name = "observacoes")]
        [XmlElement(ElementName = "observacoes", Namespace = "vx")]
        public string Observacoes { get; set; }
        [DataMember(Name = "itens")]
        [XmlElement(ElementName = "itens", Namespace = "vx")]
        public Itens Itens { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres", Namespace = "vx")]
        public Livres Livres { get; set; }

        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }
        [XmlAttribute(AttributeName = "prioridade-processamento")]
        public string Prioridadeprocessamento { get; set; }
    }
}
