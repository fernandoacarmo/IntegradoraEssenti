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
using Integradora.Biblioteca.Tools;
using System.Net;

namespace Integradora.ECommerce.Ajuri.Retornos
{
    [XmlRoot(ElementName = "target")]
    public class TargetRetornaCorrigeEstoque
    {
        public TargetRetornaCorrigeEstoque()
        {
        }

        [XmlElement(ElementName = "pid")]
        public string Pid { get; set; }
        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "empresa")]
        public string Empresa { get; set; }
        [XmlElement(ElementName = "fornecedor")]
        public string Fornecedor { get; set; }
        [XmlElement(ElementName = "host")]
        public string Host { get; set; }
        [XmlElement(ElementName = "data-origem")]
        public string Dataorigem { get; set; }
        [XmlElement(ElementName = "observacoes")]
        public string Observacoes { get; set; }

        public void ObterDados()
        {
            Pid = "AjuriWS";
            Nome = "Ajuri";
            Empresa = "CEMA";
            Fornecedor = "Prodam";
            Host = "unknow";
            Dataorigem = DateTime.Now.ToString(Calendars.GetMascaraDataHoraXML());
        }
    }

    [XmlRoot(ElementName = "ticket")]
    public class TicketRetornaCorrigeEstoque
    {
        public TicketRetornaCorrigeEstoque()
        {
            Filial = new FilialRetornaCorrigeEstoque();
        }

        [XmlElement(ElementName = "pid")]
        public string Pid { get; set; }
        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "empresa")]
        public string Empresa { get; set; }
        [XmlElement(ElementName = "fornecedor")]
        public string Fornecedor { get; set; }
        [XmlElement(ElementName = "host")]
        public string Host { get; set; }
        [XmlElement(ElementName = "data-origem")]
        public string Dataorigem { get; set; }
        [XmlElement(ElementName = "versao")]
        public string Versao { get; set; }
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "filial")]
        public FilialRetornaCorrigeEstoque Filial { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        public void ObterDados()
        {
            Version = "v1";
            Pid = "IntegracaoOMBoat";
            Nome = "IntegracaoOMBoat";
            Empresa = "OMBoat";
            Fornecedor = Empresa;
            Versao = "v1build1591";

            string nome = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostAddresses(nome);
            Host = ip[1].ToString();

            Dataorigem = DateTime.Now.ToString(Calendars.GetMascaraDataHoraXML());
            Id = "IntegracaoOMBoat" + Dataorigem;

            Filial.Codigo = Empresa;
            Filial.Documentofederal = "17.026.052/0001-30";
            Filial.Razaosocial = "OM BOAT LOCACAO DE EMBARCACOES LTDA.";
        }

    }

    [DataContract(Name = "produto")]
    [XmlRoot(ElementName = "produto")]
    public class ProdutoRetornaCorrigeEstoque
    {
        public ProdutoRetornaCorrigeEstoque()
        {
        }
        [DataMember(Name = "partnumber")]
        [XmlElement(ElementName = "partnumber")]
        public string Partnumber { get; set; }
    }

    [DataContract(Name = "origem")]
    [XmlRoot(ElementName = "origem")]
    public class OrigemRetornaCorrigeEstoque: MovimentoRetornaCorrigeEstoque
    {
        public OrigemRetornaCorrigeEstoque()
        {            
        }
    }

    [DataContract(Name = "destino")]
    [XmlRoot(ElementName = "destino")]
    public class DestinoRetornaCorrigeEstoque : MovimentoRetornaCorrigeEstoque
    {
        public DestinoRetornaCorrigeEstoque()
        {
        }
    }

    public class MovimentoRetornaCorrigeEstoque
    {
        public MovimentoRetornaCorrigeEstoque()
        {
            Produto = new ProdutoRetornaCorrigeEstoque();
        }
        [DataMember(Name = "produto")]
        [XmlElement(ElementName = "produto")]
        public ProdutoRetornaCorrigeEstoque Produto { get; set; }
        [DataMember(Name = "quantidade-unidades")]
        [XmlElement(ElementName = "quantidade-unidades")]
        public string Quantidadeunidades { get; set; }
        [DataMember(Name = "lote")]
        [XmlElement(ElementName = "lote")]
        public string Lote { get; set; }
        [DataMember(Name = "serial")]
        [XmlElement(ElementName = "serial")]
        public string Serial { get; set; }
        [DataMember(Name = "modelo")]
        [XmlElement(ElementName = "modelo")]
        public string Modelo { get; set; }
        [DataMember(Name = "fabricacao")]
        [XmlElement(ElementName = "fabricacao")]
        public string Fabricacao { get; set; }
        [DataMember(Name = "vencimento")]
        [XmlElement(ElementName = "vencimento")]
        public string Vencimento { get; set; }
    }

    [DataContract(Name = "cliente")]
    [XmlRoot(ElementName = "cliente")]
    public class ClienteRetornaCorrigeEstoque
    {
        public ClienteRetornaCorrigeEstoque()
        {
        }
        [DataMember(Name = "documento-federal")]
        [XmlElement(ElementName = "documento-federal")]
        public string Documentofederal { get; set; }
        [DataMember(Name = "razao-social")]
        [XmlElement(ElementName = "razao-social")]
        public string Razaosocial { get; set; }
    }


    [DataContract(Name = "filial")]
    [XmlRoot(ElementName = "filial")]
    public class FilialRetornaCorrigeEstoque
    {
        public FilialRetornaCorrigeEstoque()
        {
        }
        [DataMember(Name = "codigo")]
        [XmlElement(ElementName = "codigo")]
        public string Codigo { get; set; }
        [DataMember(Name = "documento-federal")]
        [XmlElement(ElementName = "documento-federal")]
        public string Documentofederal { get; set; }
        [DataMember(Name = "razao-social")]
        [XmlElement(ElementName = "razao-social")]
        public string Razaosocial { get; set; }
    }


    [DataContract(Name = "livre")]
    [XmlRoot(ElementName = "livre")]
    public class LivreRetornaCorrigeEstoque
    {
        public LivreRetornaCorrigeEstoque()
        {
        }
        [DataMember(Name = "indice")]
        [XmlElement(ElementName = "indice")]
        public string Indice { get; set; }
        [DataMember(Name = "nome")]
        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }
        [DataMember(Name = "valor")]
        [XmlElement(ElementName = "valor")]
        public string Valor { get; set; }
    }

    [DataContract(Name = "livres")]
    [XmlRoot(ElementName = "livres")]
    public class LivresRetornaCorrigeEstoque
    {
        public LivresRetornaCorrigeEstoque()
        {
            Livre = new List<LivreRetornaCorrigeEstoque>();
        }
        [DataMember(Name = "livre")]
        [XmlElement(ElementName = "livre")]
        public List<LivreRetornaCorrigeEstoque> Livre { get; set; }
    }

    [DataContract(Name = "correcao")]
    [XmlRoot(ElementName = "correcao")]
    public class CorrecaoRetornaCorrigeEstoque
    {
        public CorrecaoRetornaCorrigeEstoque()
        {
            Livres = new LivresRetornaCorrigeEstoque();
            Filial = new FilialRetornaCorrigeEstoque();
            Cliente = new ClienteRetornaCorrigeEstoque();
            Origem = new OrigemRetornaCorrigeEstoque();
            Destino = new DestinoRetornaCorrigeEstoque();
        }
        [DataMember(Name = "filial")]
        [XmlElement(ElementName = "filial")]
        public FilialRetornaCorrigeEstoque Filial { get; set; }
        [DataMember(Name = "cliente")]
        [XmlElement(ElementName = "cliente")]
        public ClienteRetornaCorrigeEstoque Cliente { get; set; }
        [DataMember(Name = "origem")]
        [XmlElement(ElementName = "origem")]
        public OrigemRetornaCorrigeEstoque Origem { get; set; }
        [DataMember(Name = "destino")]
        [XmlElement(ElementName = "destino")]
        public DestinoRetornaCorrigeEstoque Destino { get; set; }
        [DataMember(Name = "livres")]
        [XmlElement(ElementName = "livres")]
        public LivresRetornaCorrigeEstoque Livres { get; set; }
        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }
    }
    [DataContract(Name = "correcoes")]
    [XmlRoot(ElementName = "correcoes")]
    public class CorrecoesRetornaCorrigeEstoque
    {
        public CorrecoesRetornaCorrigeEstoque()
        {
            Correcao = new List<CorrecaoRetornaCorrigeEstoque>();
        }
        [DataMember(Name = "correcao")]
        [XmlElement(ElementName = "correcao")]
        public List<CorrecaoRetornaCorrigeEstoque> Correcao { get; set; }
    }

    [DataContract(Name = "retornaCorrigeEstoque")]
    [XmlRoot(ElementName = "RetornaCorrigeEstoque")]
    public class RetornaCorrigeEstoque
    {
        public RetornaCorrigeEstoque()
        {
            Ticket = new TicketRetornaCorrigeEstoque();
            Target = new TargetRetornaCorrigeEstoque();
            Correcoes = new CorrecoesRetornaCorrigeEstoque();
        }
        [DataMember(Name = "ticket")]
        [XmlElement(ElementName = "ticket")]
        public TicketRetornaCorrigeEstoque Ticket { get; set; }
        [DataMember(Name = "target")]
        [XmlElement(ElementName = "target")]
        public TargetRetornaCorrigeEstoque Target { get; set; }
        [DataMember(Name = "correcoes")]
        [XmlElement(ElementName = "correcoes")]
        public CorrecoesRetornaCorrigeEstoque Correcoes { get; set; }

        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
    }
}
