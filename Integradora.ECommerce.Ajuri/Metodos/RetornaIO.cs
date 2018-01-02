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
using System.Net;
using Integradora.Biblioteca.Tools;


namespace Integradora.ECommerce.Ajuri.Metodos
{
    [XmlRoot(ElementName = "filial", Namespace = "vx")]
    public class FilialRetornaIO
    {
        [XmlElement(ElementName = "codigo", Namespace = "vx")]
        public string Codigo { get; set; }
        [XmlElement(ElementName = "documento-federal", Namespace = "vx")]
        public string Documentofederal { get; set; }
        [XmlElement(ElementName = "razao-social", Namespace = "vx")]
        public string Razaosocial { get; set; }
    }

    [XmlRoot(ElementName = "ticket", Namespace = "vx")]
    public class TicketRetornaIO
    {
        public TicketRetornaIO()
        {
            Filial = new FilialRetornaIO();
        }

        [XmlElement(ElementName = "pid", Namespace = "vx")]
        public string Pid { get; set; }
        [XmlElement(ElementName = "nome", Namespace = "vx")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "empresa", Namespace = "vx")]
        public string Empresa { get; set; }
        [XmlElement(ElementName = "fornecedor", Namespace = "vx")]
        public string Fornecedor { get; set; }
        [XmlElement(ElementName = "host", Namespace = "vx")]
        public string Host { get; set; }
        [XmlElement(ElementName = "data-origem", Namespace = "vx")]
        public string Dataorigem { get; set; }
        [XmlElement(ElementName = "id", Namespace = "vx")]
        public string Id { get; set; }
        [XmlElement(ElementName = "filial", Namespace = "vx")]
        public FilialRetornaIO Filial { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        public void ObterDados()
        {
            Version = "v1";
            Pid = "IntegracaoOMBoat";
            Nome = "IntegracaoOMBoat";
            Empresa = "OMBoat";
            Fornecedor = Empresa;

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

    [XmlRoot(ElementName = "target", Namespace = "vx")]
    public class TargetRetornaIO
    {
        public TargetRetornaIO()
        {
        }

        [XmlElement(ElementName = "pid", Namespace = "vx")]
        public string Pid { get; set; }
        [XmlElement(ElementName = "nome", Namespace = "vx")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "empresa", Namespace = "vx")]
        public string Empresa { get; set; }
        [XmlElement(ElementName = "fornecedor", Namespace = "vx")]
        public string Fornecedor { get; set; }
        [XmlElement(ElementName = "host", Namespace = "vx")]
        public string Host { get; set; }
        [XmlElement(ElementName = "data-origem", Namespace = "vx")]
        public string Dataorigem { get; set; }
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

    [XmlRoot(ElementName = "cliente", Namespace = "vx")]
    public class ClienteRetornaIO
    {
        public ClienteRetornaIO()
        {
        }
        [XmlElement(ElementName = "documento-federal", Namespace = "vx")]
        public string Documentofederal { get; set; }
        [XmlElement(ElementName = "razao-social", Namespace = "vx")]
        public string Razaosocial { get; set; }
    }

    [XmlRoot(ElementName = "cfop", Namespace = "vx")]
    public class CfopRetornaIO
    {
        public CfopRetornaIO()
        {
        }

        [XmlElement(ElementName = "codigo", Namespace = "vx")]
        public string Codigo { get; set; }
        [XmlElement(ElementName = "descricao", Namespace = "vx")]
        public string Descricao { get; set; }
    }

    [XmlRoot(ElementName = "cabecalho-chave", Namespace = "vx")]
    public class CabecalhochaveRetornaIO
    {
        public CabecalhochaveRetornaIO()
        {
            Cliente = new ClienteRetornaIO();
            Cfop = new CfopRetornaIO();
        }

        [XmlElement(ElementName = "cliente", Namespace = "vx")]
        public ClienteRetornaIO Cliente { get; set; }
        [XmlElement(ElementName = "divisao-chave", Namespace = "vx")]
        public string Divisaochave { get; set; }
        [XmlElement(ElementName = "numero", Namespace = "vx")]
        public string Numero { get; set; }
        [XmlElement(ElementName = "data", Namespace = "vx")]
        public string Data { get; set; }
        [XmlElement(ElementName = "hora", Namespace = "vx")]
        public string Hora { get; set; }
        [XmlElement(ElementName = "serie", Namespace = "vx")]
        public string Serie { get; set; }
        [XmlElement(ElementName = "cfop", Namespace = "vx")]
        public CfopRetornaIO Cfop { get; set; }
    }

    [XmlRoot(ElementName = "entidade", Namespace = "vx")]
    public class EntidadeRetornaIO
    {
        [XmlElement(ElementName = "documento-federal", Namespace = "vx")]
        public string Documentofederal { get; set; }
        [XmlElement(ElementName = "razao-social", Namespace = "vx")]
        public string Razaosocial { get; set; }
    }

    [XmlRoot(ElementName = "produto", Namespace = "vx")]
    public class ProdutoRetornaIO
    {
        public ProdutoRetornaIO()
        {
        }
        [XmlElement(ElementName = "partnumber", Namespace = "vx")]
        public string Partnumber { get; set; }
        [XmlElement(ElementName = "descricao", Namespace = "vx")]
        public string Descricao { get; set; }
    }

    [XmlRoot(ElementName = "item", Namespace = "vx")]
    public class ItemRetornaIO
    {
        public ItemRetornaIO()
        {
            Produto = new ProdutoRetornaIO();
        }

        public object Clone()
        {
            var clone = this.MemberwiseClone();
            return clone;
        }

        [XmlElement(ElementName = "resultado", Namespace = "vx")]
        public string Resultado { get; set; }
        [XmlElement(ElementName = "produto", Namespace = "vx")]
        public ProdutoRetornaIO Produto { get; set; }
        [XmlElement(ElementName = "quantidade", Namespace = "vx")]
        public string Quantidade { get; set; }
        [XmlElement(ElementName = "quantidade-processada", Namespace = "vx")]
        public string Quantidadeprocessada { get; set; }
        [XmlElement(ElementName = "valor-unitario", Namespace = "vx")]
        public string Valorunitario { get; set; }
        [XmlElement(ElementName = "lote", Namespace = "vx")]
        public string Lote { get; set; }
        [XmlElement(ElementName = "serial", Namespace = "vx")]
        public string Serial { get; set; }
        [XmlElement(ElementName = "modelo", Namespace = "vx")]
        public string Modelo { get; set; }
        [XmlElement(ElementName = "data-fabricacao", Namespace = "vx")]
        public string Datafabricacao { get; set; }
        [XmlElement(ElementName = "data-vencimento", Namespace = "vx")]
        public string Datavencimento { get; set; }
    }

    [XmlRoot(ElementName = "itens", Namespace = "vx")]
    public class ItensRetornaIO
    {
        public ItensRetornaIO()
        {
            Item = new List<ItemRetornaIO>();
        }
        [XmlElement(ElementName = "item", Namespace = "vx")]
        public List<ItemRetornaIO> Item { get; set; }
    }

    [XmlRoot(ElementName = "livre", Namespace = "vx")]
    public class LivreRetornaIO
    {
        public LivreRetornaIO()
        {
        }
        [XmlElement(ElementName = "indice", Namespace = "vx")]
        public string Indice { get; set; }
        [XmlElement(ElementName = "nome", Namespace = "vx")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "valor", Namespace = "vx")]
        public string Valor { get; set; }
    }

    [XmlRoot(ElementName = "livres", Namespace = "vx")]
    public class LivresRetornaIO
    {
        public LivresRetornaIO()
        {
            Livre = new List<LivreRetornaIO>();
        }
        [XmlElement(ElementName = "livre", Namespace = "vx")]
        public List<LivreRetornaIO> Livre { get; set; }

        public void AdicionarItem(string Indice, string Nome, string Valor)
        {
            LivreRetornaIO item = new LivreRetornaIO();
            item.Indice = Indice;
            item.Nome = Nome;
            item.Valor = Valor;

            Livre.Add(item);
        }
    }

    [XmlRoot(ElementName = "conferencia", Namespace = "vx")]
    public class ConferenciaRetornaIO
    {
        public ConferenciaRetornaIO()
        {
            Cabecalhochave = new CabecalhochaveRetornaIO();
            Livres = new LivresRetornaIO();
            Entidade = new EntidadeRetornaIO();
            Itens = new ItensRetornaIO();
        }
        [XmlElement(ElementName = "data", Namespace = "vx")]
        public string Data { get; set; }
        [XmlElement(ElementName = "cabecalho-chave", Namespace = "vx")]
        public CabecalhochaveRetornaIO Cabecalhochave { get; set; }
        [XmlElement(ElementName = "entidade", Namespace = "vx")]
        public EntidadeRetornaIO Entidade { get; set; }
        [XmlElement(ElementName = "itens", Namespace = "vx")]
        public ItensRetornaIO Itens { get; set; }
        [XmlElement(ElementName = "livres", Namespace = "vx")]
        public LivresRetornaIO Livres { get; set; }
        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }

        public void ObterDados(string TipoMovimento)
        {
            Data = DateTime.Now.ToString(Calendars.GetMascaraDataHoraXML());
            Tipo = TipoMovimento;
            Cabecalhochave.Cliente.Documentofederal = "00.697.295/0001-05";
            Cabecalhochave.Cliente.Razaosocial = "CEMA - CENTRAL DE MEDICAMENTOS DO AMAZONAS";
            Cabecalhochave.Divisaochave = TipoMovimento == "ENTRADA"? "NF" : "PED";
            Cabecalhochave.Serie = ".";
        }
    }

    [XmlRoot(ElementName = "conferencias", Namespace = "vx")]
    public class ConferenciasRetornaIO
    {
        public ConferenciasRetornaIO()
        {
            Conferencia = new List<ConferenciaRetornaIO>();
        }
        [XmlElement(ElementName = "conferencia", Namespace = "vx")]
        public List<ConferenciaRetornaIO> Conferencia { get; set; }
    }

    [ServiceContract(Namespace = "")]
    [XmlSerializerFormat]
    [DataContract(Name = "RetornaIO", Namespace = "vx")]
    [XmlRoot(ElementName = "RetornaIO", Namespace = "vx")]
    public class RetornaIO
    {
        public RetornaIO()
        {
            Conferencias = new ConferenciasRetornaIO();
            Ticket = new TicketRetornaIO();
            Target = new TargetRetornaIO();
        }
        [XmlElement(ElementName = "ticket", Namespace = "vx")]
        public TicketRetornaIO Ticket { get; set; }
        [XmlElement(ElementName = "target", Namespace = "vx")]
        public TargetRetornaIO Target { get; set; }
        [XmlElement(ElementName = "conferencias", Namespace = "vx")]
        public ConferenciasRetornaIO Conferencias { get; set; }
        [XmlAttribute(AttributeName = "vx", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Vx { get; set; }

        public void ObterDados()
        {
            Ticket.ObterDados();
            Target.ObterDados();
        }

    }
}


