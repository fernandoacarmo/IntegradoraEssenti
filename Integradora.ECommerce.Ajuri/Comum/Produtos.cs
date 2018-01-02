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
    [DataContract(Name = "produtos", Namespace = "vx")]
    [XmlRoot(ElementName = "produtos", Namespace = "vx")]
    public class Produtos
    {
        public Produtos()
        {
            Produto = new List<Produto>();
        }
        [DataMember(Name = "produto")]
        [XmlElement(ElementName = "produto", Namespace = "vx")]
        public List<Produto> Produto { get; set; }
    }
}

