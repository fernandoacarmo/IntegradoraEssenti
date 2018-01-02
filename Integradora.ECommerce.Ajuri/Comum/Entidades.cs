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
    [DataContract(Name = "entidades", Namespace = "vx")]
    [XmlRoot(ElementName = "entidades", Namespace = "vx")]
    public class Entidades
    {
        public Entidades()
        {
            Entidade = new List<Entidade>();
        }
        [DataMember(Name = "entidade")]
        [XmlElement(ElementName = "entidade", Namespace = "vx")]
        public List<Entidade> Entidade { get; set; }
    }
}

