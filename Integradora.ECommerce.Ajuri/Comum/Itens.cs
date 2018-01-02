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
    [DataContract(Name = "itens", Namespace = "vx")]
    [XmlRoot(ElementName = "itens", Namespace = "vx")]
    public class Itens
    {
        public Itens()
        {
            Item = new List<Item>();
        }
        [DataMember(Name = "item")]
        [XmlElement(ElementName = "item", Namespace = "vx")]
        public List<Item> Item { get; set; }
    }
}

