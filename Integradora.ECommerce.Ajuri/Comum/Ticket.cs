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
using System.Net;


namespace Integradora.ECommerce.Ajuri.Comum
{
    [DataContract(Name = "ticket", Namespace = "vx")]
    [XmlRoot(ElementName = "ticket", Namespace = "vx")]
    public class Ticket
    {
        public Ticket()
        {
            Filial = new Filial();
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
        [DataMember(Name = "versao")]
        [XmlElement(ElementName = "versao", Namespace = "vx")]
        public string Versao { get; set; }
        [DataMember(Name = "observacoes")]
        [XmlElement(ElementName = "observacoes", Namespace = "vx")]
        public string Observacoes { get; set; }
        [DataMember(Name = "id")]
        [XmlElement(ElementName = "id", Namespace = "vx")]
        public string Id { get; set; }
        [DataMember(Name = "filial")]
        [XmlElement(ElementName = "filial", Namespace = "vx")]
        public Filial Filial { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }


        public void ObterDados()
        {
            Version = "v1";
            Pid = "IntegracaoOMBoat";
            Nome = "IntegracaoOMBoat";
            Empresa = "OMBoat";
            Fornecedor = Empresa;
            Versao = "v1build1948";

            string nome = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(nome);
            Host = ip[1].ToString();

            Dataorigem = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss+HH:mm");
            Id = "IntegracaoOMBoat" + Dataorigem;

            Filial.Codigo = Empresa;
            Filial.Documentofederal = "17.026.052/0001-30";
            Filial.Razaosocial = "OM BOAT LOCACAO DE EMBARCACOES LTDA.";
        }
    }
}
