/* 
 Licensed under the Apache License, Version 2.0
    
 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Integradora.Biblioteca.Tools;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Integradora.ECommerce.Ajuri.Retornos
{
    [XmlRoot(ElementName = "filial")]
    public class FilialRetornaAtuarEstoque
    {
        [XmlElement(ElementName = "codigo")]
        public string Codigo { get; set; }
        [XmlElement(ElementName = "documento-federal")]
        public string Documentofederal { get; set; }
        [XmlElement(ElementName = "razao-social")]
        public string Razaosocial { get; set; }
    }

    [XmlRoot(ElementName = "ticket")]
    public class TicketRetornaAtuarEstoque
    {
        public TicketRetornaAtuarEstoque()
        {
            Filial = new FilialRetornaAtuarEstoque();
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
        public FilialRetornaAtuarEstoque Filial { get; set; }
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

    [XmlRoot(ElementName = "target")]
    public class TargetRetornaAtuarEstoque
    {
        public TargetRetornaAtuarEstoque()
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

    [XmlRoot(ElementName = "cliente")]
    public class ClienteRetornaAtuarEstoque
    {
        public ClienteRetornaAtuarEstoque()
        {
        }

        [XmlElement(ElementName = "documento-federal")]
        public string Documentofederal { get; set; }
        [XmlElement(ElementName = "razao-social")]
        public string Razaosocial { get; set; }
    }

    [XmlRoot(ElementName = "motivo")]
    public class MotivoRetornaAtuarEstoque
    {
        [XmlElement(ElementName = "codigo")]
        public string Codigo { get; set; }
    }

    [XmlRoot(ElementName = "produto")]
    public class ProdutoRetornaAtuarEstoque
    {
        [XmlElement(ElementName = "partnumber")]
        public string Partnumber { get; set; }
        [XmlElement(ElementName = "descricao")]
        public string Descricao { get; set; }
    }

    [XmlRoot(ElementName = "predio")]
    public class PredioRetornaAtuarEstoque
    {
        [XmlElement(ElementName = "codigo")]
        public string Codigo { get; set; }
        [XmlElement(ElementName = "descricao")]
        public string Descricao { get; set; }
    }

    [XmlRoot(ElementName = "almoxarifado")]
    public class AlmoxarifadoRetornaAtuarEstoque
    {
        [XmlElement(ElementName = "codigo")]
        public string Codigo { get; set; }
        [XmlElement(ElementName = "descricao")]
        public string Descricao { get; set; }
    }

    [XmlRoot(ElementName = "posicao")]
    public class PosicaoRetornaAtuarEstoque
    {
        [XmlElement(ElementName = "rua")]
        public string Rua { get; set; }
        [XmlElement(ElementName = "coluna")]
        public string Coluna { get; set; }
        [XmlElement(ElementName = "nivel")]
        public string Nivel { get; set; }
    }

    [XmlRoot(ElementName = "fornecedor")]
    public class FornecedorRetornaAtuarEstoque
    {
        [XmlElement(ElementName = "documento-federal")]
        public string Documentofederal { get; set; }
        [XmlElement(ElementName = "razao-social")]
        public string Razaosocial { get; set; }
    }

    [XmlRoot(ElementName = "livre")]
    public class LivreRetornaAtuarEstoque
    {
        [XmlElement(ElementName = "indice")]
        public string Indice { get; set; }
        [XmlElement(ElementName = "nome")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "valor")]
        public string Valor { get; set; }
    }

    [XmlRoot(ElementName = "livres")]
    public class LivresRetornaAtuarEstoque
    {
        public LivresRetornaAtuarEstoque()
        {
            Livre = new List<LivreRetornaAtuarEstoque>();
        }

        [XmlElement(ElementName = "livre")]
        public List<LivreRetornaAtuarEstoque> Livre { get; set; }
    }

    [XmlRoot(ElementName = "atuacao")]
    public class AtuacaoRetornaAtuarEstoque
    {
        public AtuacaoRetornaAtuarEstoque()
        {
            Livres = new LivresRetornaAtuarEstoque();
            Cliente = new ClienteRetornaAtuarEstoque();
            Motivo = new MotivoRetornaAtuarEstoque();
            Produto = new ProdutoRetornaAtuarEstoque();
            Predio = new PredioRetornaAtuarEstoque();
            Almoxarifado = new AlmoxarifadoRetornaAtuarEstoque();
            Posicao = new PosicaoRetornaAtuarEstoque();
            Fornecedor = new FornecedorRetornaAtuarEstoque();
        }

        [XmlElement(ElementName = "descricao")]
        public string Descricao { get; set; }
        [XmlElement(ElementName = "cliente")]
        public ClienteRetornaAtuarEstoque Cliente { get; set; }
        [XmlElement(ElementName = "motivo")]
        public MotivoRetornaAtuarEstoque Motivo { get; set; }
        [XmlElement(ElementName = "produto")]
        public ProdutoRetornaAtuarEstoque Produto { get; set; }
        [XmlElement(ElementName = "lote")]
        public string Lote { get; set; }
        [XmlElement(ElementName = "serial")]
        public string Serial { get; set; }
        [XmlElement(ElementName = "modelo")]
        public string Modelo { get; set; }
        [XmlElement(ElementName = "data-fabricacao")]
        public string Datafabricacao { get; set; }
        [XmlElement(ElementName = "data-vencimento")]
        public string Datavencimento { get; set; }
        [XmlElement(ElementName = "predio")]
        public PredioRetornaAtuarEstoque Predio { get; set; }
        [XmlElement(ElementName = "almoxarifado")]
        public AlmoxarifadoRetornaAtuarEstoque Almoxarifado { get; set; }
        [XmlElement(ElementName = "posicao")]
        public PosicaoRetornaAtuarEstoque Posicao { get; set; }
        [XmlElement(ElementName = "fornecedor")]
        public FornecedorRetornaAtuarEstoque Fornecedor { get; set; }
        [XmlElement(ElementName = "livres")]
        public LivresRetornaAtuarEstoque Livres { get; set; }
        [XmlElement(ElementName = "quantidade-unidades")]
        public string Quantidadeunidades { get; set; }
        [XmlAttribute(AttributeName = "tipo")]
        public string Tipo { get; set; }
    }

    [XmlRoot(ElementName = "atuacoes")]
    public class AtuacoesRetornaAtuarEstoque
    {
        public AtuacoesRetornaAtuarEstoque()
        {
            Atuacao = new List<AtuacaoRetornaAtuarEstoque>();
        }
        [XmlElement(ElementName = "atuacao")]
        public List<AtuacaoRetornaAtuarEstoque> Atuacao { get; set; }
    }

    public class RetornaAtuarEstoque
    {
        public RetornaAtuarEstoque()
        {
            Ticket = new TicketRetornaAtuarEstoque();
            Target = new TargetRetornaAtuarEstoque();
            Atuacoes = new AtuacoesRetornaAtuarEstoque();
        }
        [XmlElement(ElementName = "ticket")]
        public TicketRetornaAtuarEstoque Ticket { get; set; }
        [XmlElement(ElementName = "target")]
        public TargetRetornaAtuarEstoque Target { get; set; }
        [XmlElement(ElementName = "atuacoes")]
        public AtuacoesRetornaAtuarEstoque Atuacoes { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
        [XmlAttribute(AttributeName = "vx", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Vx { get; set; }
        public void ObterDados()
        {
            Ticket.ObterDados();
            Target.ObterDados();
        }
    }

}