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
    [DataContract(Name = "target", Namespace = "vx")]
    [XmlRoot(ElementName = "target", Namespace = "vx")]
    public class Target
    {
        public Target()
        { 
        }
        [DataMember(Name = "pid")]
        [XmlElement(ElementName = "pid", Namespace = "vx")]
        public string Pid { get; set; }
        [DataMember(Name = "nome")]
        [XmlElement(ElementName = "nome", Namespace = "vx")]
        public string Nome { get; set; }
        [DataMember(Name = "empresa")]
        [XmlElement(ElementName = "empresa", Namespace = "vx")]
        public string Empresa { get; set; }
        [DataMember(Name = "fornecedor")]
        [XmlElement(ElementName = "fornecedor", Namespace = "vx")]
        public string Fornecedor { get; set; }
        [DataMember(Name = "host")]
        [XmlElement(ElementName = "host", Namespace = "vx")]
        public string Host { get; set; }
        [DataMember(Name = "data-origem")]
        [XmlElement(ElementName = "data-origem", Namespace = "vx")]
        public string Dataorigem { get; set; }
        [DataMember(Name = "observacoes")]
        [XmlElement(ElementName = "observacoes", Namespace = "vx")]
        public string Observacoes { get; set; }

        public void ObterDados()
        {
            Pid = "AjuriWS";
            Nome = "Ajuri";
            Empresa = "CEMA";
            Fornecedor = "Prodam";
            Host = "unknow";
            Dataorigem = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss+HH:mm");
        }
    }
}
