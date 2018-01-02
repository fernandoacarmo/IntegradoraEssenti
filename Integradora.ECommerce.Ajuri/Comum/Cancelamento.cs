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
    [DataContract(Name = "cancelamento", Namespace = "vx")]
    [XmlRoot(ElementName = "cancelamento", Namespace = "vx")]
    public class Cancelamento
    {
        public Cancelamento()
        {
            Livres = new Livres();
            Filial = new Filial();
            Produto = new Produto();
            Motivo = new Motivo();
        }
        [DataMember(Name = "filial")]
        [XmlElement(ElementName = "filial", Namespace = "vx")]
        public Filial Filial { get; set; }
        [DataMember(Name = "cabecalho")]
        [XmlElement(ElementName = "cabecalho", Namespace = "vx")]
        public Cabecalho Cabecalho { get; set; }
        [DataMember(Name = "produto")]
        [XmlElement(ElementName = "produto", Namespace = "vx")]
        public Produto Produto { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres", Namespace = "vx")]
        public Livres Livres { get; set; }
        [DataMember(Name = "motivo")]
        [XmlElement(ElementName = "motivo", Namespace = "vx")]
        public Motivo Motivo { get; set; }

        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }
    }

}
