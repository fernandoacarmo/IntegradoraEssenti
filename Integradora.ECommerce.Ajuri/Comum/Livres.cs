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
    [DataContract(Name = "livres", Namespace = "vx")]
    [XmlRoot(ElementName = "livres", Namespace = "vx")]
    public class Livres
    {
        public Livres()
        {
            Livre = new List<Livre>();
        }
        [DataMember(Name = "livre")]
        [XmlElement(ElementName = "livre", Namespace = "vx")]
        public List<Livre> Livre { get; set; }
   }
}

