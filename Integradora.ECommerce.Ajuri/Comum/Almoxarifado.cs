using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;


namespace Integradora.ECommerce.Ajuri.Comum
{
    [DataContract(Name = "almoxarifado", Namespace = "vx")]
    [XmlRoot(ElementName = "almoxarifado", Namespace = "vx")]
    public class Almoxarifado
    {
        public Almoxarifado()
        {
        }
        [DataMember(Name = "codigo")]
        [XmlElement(ElementName = "codigo", Namespace = "vx")]
        public string Codigo { get; set; }

        [DataMember(Name = "descricao")]
        [XmlElement(ElementName = "descricao", Namespace = "vx")]
        public string Descricao { get; set; }
    }
}
