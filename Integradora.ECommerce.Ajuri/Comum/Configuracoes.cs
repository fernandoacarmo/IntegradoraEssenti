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
    [DataContract(Name = "configura-embalagens", Namespace = "vx")]
    [XmlRoot(ElementName = "configura-embalagens", Namespace = "vx")]
    public class Configuracoes
    {
        public Configuracoes()
        {
            Configuracao = new List<Configuracao>();
        }
        [DataMember(Name = "configuracao")]
        [XmlElement(ElementName = "configuracao", Namespace = "vx")]
        public List<Configuracao> Configuracao { get; set; }
    }
}

