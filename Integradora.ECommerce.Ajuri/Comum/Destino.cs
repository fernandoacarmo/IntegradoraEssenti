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
    [DataContract(Name = "destino", Namespace = "vx")]
    [XmlRoot(ElementName = "destino", Namespace = "vx")]
    public class Destino
    {
        public Destino()
        {
            Produto = new Produto();
        }
        [DataMember(Name = "produto")]
        [XmlElement(ElementName = "produto", Namespace = "vx")]
        public Produto Produto { get; set; }
        [DataMember(Name = "quantidade-unidades")]
        [XmlElement(ElementName = "quantidade-unidades", Namespace = "vx")]
        public string Quantidadeunidades { get; set; }
        [DataMember(Name = "lote")]
        [XmlElement(ElementName = "lote", Namespace = "vx")]
        public string Lote { get; set; }
        [DataMember(Name = "serial")]
        [XmlElement(ElementName = "serial", Namespace = "vx")]
        public string Serial { get; set; }
        [DataMember(Name = "modelo")]
        [XmlElement(ElementName = "modelo", Namespace = "vx")]
        public string Modelo { get; set; }
        [DataMember(Name = "fabricacao")]
        [XmlElement(ElementName = "fabricacao", Namespace = "vx")]
        public string Fabricacao { get; set; }
        [DataMember(Name = "vencimento")]
        [XmlElement(ElementName = "vencimento", Namespace = "vx")]
        public string Vencimento { get; set; }
    }
}
