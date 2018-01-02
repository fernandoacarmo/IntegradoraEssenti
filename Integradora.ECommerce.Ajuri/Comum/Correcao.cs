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
    [DataContract(Name = "correcao", Namespace = "vx")]
    [XmlRoot(ElementName = "correcao", Namespace = "vx")]
    public class Correcao
    {
        public Correcao()
        {
            Livres = new Livres();
            Filial = new Filial();
            Cliente = new Cliente();
            Origem = new Origem();
            Destino = new Destino();
        }
        [DataMember(Name = "filial")]
        [XmlElement(ElementName = "filial", Namespace = "vx")]
        public Filial Filial { get; set; }
        [DataMember(Name = "cliente")]
        [XmlElement(ElementName = "cliente", Namespace = "vx")]
        public Cliente Cliente { get; set; }
        [DataMember(Name = "origem")]
        [XmlElement(ElementName = "origem", Namespace = "vx")]
        public Origem Origem { get; set; }
        [DataMember(Name = "destino")]
        [XmlElement(ElementName = "destino", Namespace = "vx")]
        public Destino Destino { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres", Namespace = "vx")]
        public Livres Livres { get; set; }
        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }
    }
}
