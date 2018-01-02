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
using System.Web.Services.Protocols;


namespace Integradora.ECommerce.Ajuri.Retornos
{
   
//    [DataContract(Name = "responseOf", Namespace = "")]
//    [XmlRoot(ElementName = "ResponseOf", Namespace = "")]
    public class ResponseOf
    {
        public ResponseOf()
        {
        }
        [DataMember(Name = "request-ticket")]
        [XmlElement(ElementName = "request-ticket")]
        public string Requestticket { get; set; }
        [DataMember(Name = "request-date")]
        [XmlElement(ElementName = "request-date")]
        public string Requestdate { get; set; }
        [DataMember(Name = "response-ticket")]
        [XmlElement(ElementName = "response-ticket")]
        public string Responseticket { get; set; }
        [DataMember(Name = "pid")]
        [XmlElement(ElementName = "pid")]
        public string Pid { get; set; }
        [DataMember(Name = "message")]
        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
        [DataMember(Name = "detail")]
        [XmlElement(ElementName = "detail")]
        public string Detail { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
    }
}
