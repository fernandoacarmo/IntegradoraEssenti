using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityWinthor
{
    /// <summary>
    /// Classe referente a tabela PCPedcecf
    /// </summary>
    [XmlType("PCPEDCECF")]
    public class PCPedcecf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTENFCE
        /// Comentário: Produção(P) Homologação(H)
        /// </summary>
        private string ambientenfce;
        [XmlElement(ElementName = "AMBIENTENFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambientenfce
        {
            get { return  ambientenfce; }
            set {  ambientenfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Comentário: Código MD-5 
        /// </summary>
        private string assinatura;
        [XmlElement(ElementName = "ASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Assinatura
        {
            get { return  assinatura; }
            set {  assinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAOCRM
        /// Comentário: Número cartão CRM
        /// </summary>
        private string cartaocrm;
        [XmlElement(ElementName = "CARTAOCRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public string Cartaocrm
        {
            get { return  cartaocrm; }
            set {  cartaocrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFCE
        /// Comentário: Chave de acesso NFC-e.
        /// </summary>
        private string chavenfce;
        [XmlElement(ElementName = "CHAVENFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Chavenfce
        {
            get { return  chavenfce; }
            set {  chavenfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITENTE
        /// Comentário: 
        /// </summary>
        private decimal codemitente;
        [XmlElement(ElementName = "CODEMITENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemitente
        {
            get { return  codemitente; }
            set {  codemitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCX
        /// Comentário: 
        /// </summary>
        private decimal codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Comentário: Código do Profissional
        /// </summary>
        private decimal codprofissional;
        [XmlElement(ElementName = "CODPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprofissional
        {
            get { return  codprofissional; }
            set {  codprofissional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Comentário: 
        /// </summary>
        private decimal condvenda;
        [XmlElement(ElementName = "CONDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Condvenda
        {
            get { return  condvenda; }
            set {  condvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINEST
        /// Comentário: Campo para registrar o custo financeiro original do produto.
        /// </summary>
        private decimal custofinest;
        [XmlElement(ElementName = "CUSTOFINEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinest
        {
            get { return  custofinest; }
            set {  custofinest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCEMISSAO
        /// Comentário: Tipo de documento de emissão da venda.
        /// </summary>
        private string docemissao;
        [XmlElement(ElementName = "DOCEMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Docemissao
        {
            get { return  docemissao; }
            set {  docemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAHORAENTRADACONTIGENCIA
        /// Comentário: Data e hora da contingência
        /// </summary>
        private DateTime? dtahoraentradacontigencia;
        [XmlElement(ElementName = "DTAHORAENTRADACONTIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtahoraentradacontigencia
        {
            get { return  dtahoraentradacontigencia; }
            set {  dtahoraentradacontigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: 
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Comentário: 
        /// </summary>
        private DateTime? dtentrega;
        [XmlElement(ElementName = "DTENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentrega
        {
            get { return  dtentrega; }
            set {  dtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Comentário: Data em que a exportação do BD local ocorreu.
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFAT
        /// Comentário: 
        /// </summary>
        private DateTime? dtfat;
        [XmlElement(ElementName = "DTFAT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfat
        {
            get { return  dtfat; }
            set {  dtfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORAAUTORIZACAOSEFAZ
        /// Comentário: Data da aprovação da nota.
        /// </summary>
        private DateTime? dthoraautorizacaosefaz;
        [XmlElement(ElementName = "DTHORAAUTORIZACAOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoraautorizacaosefaz
        {
            get { return  dthoraautorizacaosefaz; }
            set {  dthoraautorizacaosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENTREGA
        /// Comentário: Indica se o item será entregue ao invés de ser retirando em venda balcão.
        /// </summary>
        private string entrega;
        [XmlElement(ElementName = "ENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Entrega
        {
            get { return  entrega; }
            set {  entrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Comentário: 
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATURANOTASERVFAT
        /// Comentário: Fatura nota pelo servidor de faturamento.
        /// </summary>
        private string faturanotaservfat;
        [XmlElement(ElementName = "FATURANOTASERVFAT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Faturanotaservfat
        {
            get { return  faturanotaservfat; }
            set {  faturanotaservfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARDADOSNFPAULISTA
        /// Comentário: Opção para identificar ou não o cliente que está realizando venda no processo da nota fiscal paulista.
        /// </summary>
        private string gerardadosnfpaulista;
        [XmlElement(ElementName = "GERARDADOSNFPAULISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerardadosnfpaulista
        {
            get { return  gerardadosnfpaulista; }
            set {  gerardadosnfpaulista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Comentário: 
        /// </summary>
        private decimal hora;
        [XmlElement(ElementName = "HORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORACONTINGENCIA
        /// Comentário: Hora que ocorreu a contingência.
        /// </summary>
        private string horacontingencia;
        [XmlElement(ElementName = "HORACONTINGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Horacontingencia
        {
            get { return  horacontingencia; }
            set {  horacontingencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORACUPOM
        /// Comentário: Hora do Cupom
        /// </summary>
        private string horacupom;
        [XmlElement(ElementName = "HORACUPOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Horacupom
        {
            get { return  horacupom; }
            set {  horacupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFAT
        /// Comentário: 
        /// </summary>
        private decimal horafat;
        [XmlElement(ElementName = "HORAFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafat
        {
            get { return  horafat; }
            set {  horafat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTIPOPRESENCA
        /// Comentário: Indica o tipo de presença do comprador no estabelecimento no momento da operação
        /// </summary>
        private string idtipopresenca;
        [XmlElement(ElementName = "IDTIPOPRESENCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Idtipopresenca
        {
            get { return  idtipopresenca; }
            set {  idtipopresenca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Comentário: 
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: JUSTIFICATIVACONTIGENCIA
        /// Comentário: Motivo da contingência
        /// </summary>
        private string justificativacontigencia;
        [XmlElement(ElementName = "JUSTIFICATIVACONTIGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,256)]
        public string Justificativacontigencia
        {
            get { return  justificativacontigencia; }
            set {  justificativacontigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGERRO
        /// Comentário: Dados do log de erros.
        /// </summary>
        private string logerro;
        [XmlElement(ElementName = "LOGERRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Logerro
        {
            get { return  logerro; }
            set {  logerro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Comentário: 
        /// </summary>
        private decimal minuto;
        [XmlElement(ElementName = "MINUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minuto
        {
            get { return  minuto; }
            set {  minuto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFAT
        /// Comentário: 
        /// </summary>
        private decimal minutofat;
        [XmlElement(ElementName = "MINUTOFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutofat
        {
            get { return  minutofat; }
            set {  minutofat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZANFCE
        /// Comentário: Descrição CFOP tabela PCCFO.
        /// </summary>
        private string naturezanfce;
        [XmlElement(ElementName = "NATUREZANFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Naturezanfce
        {
            get { return  naturezanfce; }
            set {  naturezanfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUSOCIOTORCEDOR
        /// Comentário: Número de Transação Sitef
        /// </summary>
        private string nsusociotorcedor;
        [XmlElement(ElementName = "NSUSOCIOTORCEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsusociotorcedor
        {
            get { return  nsusociotorcedor; }
            set {  nsusociotorcedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: 
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXAFISCAL
        /// Comentário: 
        /// </summary>
        private decimal numcaixafiscal;
        [XmlElement(ElementName = "NUMCAIXAFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixafiscal
        {
            get { return  numcaixafiscal; }
            set {  numcaixafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCF
        /// Comentário: Indica o número do CCF.
        /// </summary>
        private decimal numccf;
        [XmlElement(ElementName = "NUMCCF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numccf
        {
            get { return  numccf; }
            set {  numccf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Comentário: 
        /// </summary>
        private decimal numcupom;
        [XmlElement(ElementName = "NUMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcupom
        {
            get { return  numcupom; }
            set {  numcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMECF
        /// Comentário: 
        /// </summary>
        private decimal numecf;
        [XmlElement(ElementName = "NUMECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numecf
        {
            get { return  numecf; }
            set {  numecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEXECUCAO
        /// Comentário: Gravação da seqëncia de execução integracaoautoservico.
        /// </summary>
        private decimal numexecucao;
        [XmlElement(ElementName = "NUMEXECUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numexecucao
        {
            get { return  numexecucao; }
            set {  numexecucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITENS
        /// Comentário: 
        /// </summary>
        private decimal numitens;
        [XmlElement(ElementName = "NUMITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numitens
        {
            get { return  numitens; }
            set {  numitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLISTA
        /// Comentário: Número da Lista de Presente
        /// </summary>
        private decimal numlista;
        [XmlElement(ElementName = "NUMLISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numlista
        {
            get { return  numlista; }
            set {  numlista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Comentário: 
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Comentário: 
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: Data de cancelamento.
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Comentário: 
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASMAPASEP
        /// Comentário: 
        /// </summary>
        private decimal numviasmapasep;
        [XmlElement(ElementName = "NUMVIASMAPASEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviasmapasep
        {
            get { return  numviasmapasep; }
            set {  numviasmapasep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLUME
        /// Comentário: Núm. De volumes do pedido de venda.
        /// </summary>
        private decimal numvolume;
        [XmlElement(ElementName = "NUMVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvolume
        {
            get { return  numvolume; }
            set {  numvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: 
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Comentário: Número da região.
        /// </summary>
        private decimal percicm;
        [XmlElement(ElementName = "PERCICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicm
        {
            get { return  percicm; }
            set {  percicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVENDA
        /// Comentário: 
        /// </summary>
        private decimal percvenda;
        [XmlElement(ElementName = "PERCVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percvenda
        {
            get { return  percvenda; }
            set {  percvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC
        /// Comentário: Percentual de desconto
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAORETORNO
        /// Comentário: 
        /// </summary>
        private string posicaoretorno;
        [XmlElement(ElementName = "POSICAORETORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Posicaoretorno
        {
            get { return  posicaoretorno; }
            set {  posicaoretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIO
        /// Comentário: 
        /// </summary>
        private decimal prazomedio;
        [XmlElement(ElementName = "PRAZOMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomedio
        {
            get { return  prazomedio; }
            set {  prazomedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO1
        /// Comentário: 
        /// </summary>
        private decimal prazo1;
        [XmlElement(ElementName = "PRAZO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo1
        {
            get { return  prazo1; }
            set {  prazo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO10
        /// Comentário: 
        /// </summary>
        private decimal prazo10;
        [XmlElement(ElementName = "PRAZO10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo10
        {
            get { return  prazo10; }
            set {  prazo10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO11
        /// Comentário: 
        /// </summary>
        private decimal prazo11;
        [XmlElement(ElementName = "PRAZO11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo11
        {
            get { return  prazo11; }
            set {  prazo11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO12
        /// Comentário: 
        /// </summary>
        private decimal prazo12;
        [XmlElement(ElementName = "PRAZO12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo12
        {
            get { return  prazo12; }
            set {  prazo12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO2
        /// Comentário: 
        /// </summary>
        private decimal prazo2;
        [XmlElement(ElementName = "PRAZO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo2
        {
            get { return  prazo2; }
            set {  prazo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO3
        /// Comentário: 
        /// </summary>
        private decimal prazo3;
        [XmlElement(ElementName = "PRAZO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo3
        {
            get { return  prazo3; }
            set {  prazo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO4
        /// Comentário: 
        /// </summary>
        private decimal prazo4;
        [XmlElement(ElementName = "PRAZO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo4
        {
            get { return  prazo4; }
            set {  prazo4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO5
        /// Comentário: 
        /// </summary>
        private decimal prazo5;
        [XmlElement(ElementName = "PRAZO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo5
        {
            get { return  prazo5; }
            set {  prazo5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO6
        /// Comentário: 
        /// </summary>
        private decimal prazo6;
        [XmlElement(ElementName = "PRAZO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo6
        {
            get { return  prazo6; }
            set {  prazo6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO7
        /// Comentário: 
        /// </summary>
        private decimal prazo7;
        [XmlElement(ElementName = "PRAZO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo7
        {
            get { return  prazo7; }
            set {  prazo7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO8
        /// Comentário: 
        /// </summary>
        private decimal prazo8;
        [XmlElement(ElementName = "PRAZO8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo8
        {
            get { return  prazo8; }
            set {  prazo8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO9
        /// Comentário: 
        /// </summary>
        private decimal prazo9;
        [XmlElement(ElementName = "PRAZO9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo9
        {
            get { return  prazo9; }
            set {  prazo9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFCE
        /// Comentário: Protocolo de recebimento
        /// </summary>
        private string protocolonfce;
        [XmlElement(ElementName = "PROTOCOLONFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolonfce
        {
            get { return  protocolonfce; }
            set {  protocolonfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QRCODENFCE
        /// Comentário: 
        /// </summary>
        private string qrcodenfce;
        [XmlElement(ElementName = "QRCODENFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Qrcodenfce
        {
            get { return  qrcodenfce; }
            set {  qrcodenfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEECF
        /// Comentário: 
        /// </summary>
        private string serieecf;
        [XmlElement(ElementName = "SERIEECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Serieecf
        {
            get { return  serieecf; }
            set {  serieecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAONFCE
        /// Comentário: Status da nota enviada a SEFAZ.
        /// </summary>
        private decimal situacaonfce;
        [XmlElement(ElementName = "SITUACAONFCE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Situacaonfce
        {
            get { return  situacaonfce; }
            set {  situacaonfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXAENTREGA
        /// Comentário: Valor cobrado para realizar a entrega da compra.
        /// </summary>
        private decimal taxaentrega;
        [XmlElement(ElementName = "TAXAENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Taxaentrega
        {
            get { return  taxaentrega; }
            set {  taxaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMISSAO
        /// Comentário: Identificador da situação da nota na SEFAZ.
        /// </summary>
        private decimal tipoemissao;
        [XmlElement(ElementName = "TIPOEMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoemissao
        {
            get { return  tipoemissao; }
            set {  tipoemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOVCCRCA
        /// Comentário: Tipo de movimentação do RCA.
        /// </summary>
        private string tipomovccrca;
        [XmlElement(ElementName = "TIPOMOVCCRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomovccrca
        {
            get { return  tipomovccrca; }
            set {  tipomovccrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Comentário: 
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOPPESO
        /// Comentário: Número da região.
        /// </summary>
        private decimal toppeso;
        [XmlElement(ElementName = "TOPPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Toppeso
        {
            get { return  toppeso; }
            set {  toppeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESO
        /// Comentário: 
        /// </summary>
        private decimal totpeso;
        [XmlElement(ElementName = "TOTPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Totpeso
        {
            get { return  totpeso; }
            set {  totpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVOLUME
        /// Comentário: 
        /// </summary>
        private decimal totvolume;
        [XmlElement(ElementName = "TOTVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Totvolume
        {
            get { return  totvolume; }
            set {  totvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACREDRCA
        /// Comentário: Indica se será é para aplicar crédito para o RCA, relacionado a venda varejo.
        /// </summary>
        private string usacredrca;
        [XmlElement(ElementName = "USACREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacredrca
        {
            get { return  usacredrca; }
            set {  usacredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADEBCREDRCA
        /// Comentário: Indica se será é para aplicar crédito/débito para o RCA, relacionado a venda varejo.
        /// </summary>
        private string usadebcredrca;
        [XmlElement(ElementName = "USADEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadebcredrca
        {
            get { return  usadebcredrca; }
            set {  usadebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDAASSISTIDA
        /// Comentário: Indica se o pedido é de venda assistida.
        /// </summary>
        private string vendaassistida;
        [XmlElement(ElementName = "VENDAASSISTIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendaassistida
        {
            get { return  vendaassistida; }
            set {  vendaassistida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOFATURAMENTO
        /// Comentário: Versão do servidor de faturamento autosserviço.
        /// </summary>
        private string versaofaturamento;
        [XmlElement(ElementName = "VERSAOFATURAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Versaofaturamento
        {
            get { return  versaofaturamento; }
            set {  versaofaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOROTINA
        /// Comentário: Indica a versão da rotina de venda corrente.
        /// </summary>
        private string versaorotina;
        [XmlElement(ElementName = "VERSAOROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Versaorotina
        {
            get { return  versaorotina; }
            set {  versaorotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLATEND
        /// Comentário: 
        /// </summary>
        private decimal vlatend;
        [XmlElement(ElementName = "VLATEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlatend
        {
            get { return  vlatend; }
            set {  vlatend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOCONT
        /// Comentário: 
        /// </summary>
        private decimal vlcustocont;
        [XmlElement(ElementName = "VLCUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustocont
        {
            get { return  vlcustocont; }
            set {  vlcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal vlcustofin;
        [XmlElement(ElementName = "VLCUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofin
        {
            get { return  vlcustofin; }
            set {  vlcustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal vlcustoreal;
        [XmlElement(ElementName = "VLCUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustoreal
        {
            get { return  vlcustoreal; }
            set {  vlcustoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREP
        /// Comentário: 
        /// </summary>
        private decimal vlcustorep;
        [XmlElement(ElementName = "VLCUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorep
        {
            get { return  vlcustorep; }
            set {  vlcustorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCSOCIOTORCEDOR
        /// Comentário: Desconto Sócio Torcedor
        /// </summary>
        private decimal vldescsociotorcedor;
        [XmlElement(ElementName = "VLDESCSOCIOTORCEDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescsociotorcedor
        {
            get { return  vldescsociotorcedor; }
            set {  vldescsociotorcedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal vloutrasdesp;
        [XmlElement(ElementName = "VLOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vloutrasdesp
        {
            get { return  vloutrasdesp; }
            set {  vloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUBTOTAL
        /// Comentário: Valor do subtotal dos itens
        /// </summary>
        private decimal vlsubtotal;
        [XmlElement(ElementName = "VLSUBTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsubtotal
        {
            get { return  vlsubtotal; }
            set {  vlsubtotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTABELA
        /// Comentário: 
        /// </summary>
        private decimal vltabela;
        [XmlElement(ElementName = "VLTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vltabela
        {
            get { return  vltabela; }
            set {  vltabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTRIBUTOS
        /// Comentário: Somatório do tributos dos itens.
        /// </summary>
        private decimal vltributos;
        [XmlElement(ElementName = "VLTRIBUTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltributos
        {
            get { return  vltributos; }
            set {  vltributos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLNFCE
        /// Comentário: XML de retorno da aprovação.
        /// </summary>
        private string xmlnfce;
        [XmlElement(ElementName = "XMLNFCE", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Xmlnfce
        {
            get { return  xmlnfce; }
            set {  xmlnfce = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPedcecf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDCECF";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPedcecf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedcecf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPedcecf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedcecf>(where);
        }

        #endregion
    }
}
