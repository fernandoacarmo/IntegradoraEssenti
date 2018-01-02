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
    public class AlimentaProdutoXML
    {
        [DataMember(Name = "AlimentaProduto")]
        [XmlElement(ElementName = "AlimentaProduto", Namespace = "vx")]
        public AlimentaProduto AlimentaProduto { get; set; }
    }

    [DataContract(Name = "alimentaProduto", Namespace = "vx")]
    [XmlRoot(ElementName = "AlimentaProduto", Namespace = "vx")]
    public class AlimentaProduto : IBaseAjuri
    {
        public AlimentaProduto()
        {
            Ticket = new Ticket();
            Produtos = new Produtos();
        }
        [DataMember(Name = "ticket")]
        [XmlElement(ElementName = "ticket", Namespace = "vx")]
        public Ticket Ticket { get; set; }
        [DataMember(Name = "produtos")]
        [XmlElement(ElementName = "produtos", Namespace = "vx")]
        public Produtos Produtos { get; set; }
    }
}
