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
    /// Classe referente a tabela PCWms
    /// </summary>
    [XmlType("PCWMS")]
    public class PCWms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ABASTECIDO
        /// Comentário: 
        /// </summary>
        private string abastecido;
        [XmlElement(ElementName = "ABASTECIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abastecido
        {
            get { return  abastecido; }
            set {  abastecido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOCADO
        /// Comentário: 
        /// </summary>
        private string blocado;
        [XmlElement(ElementName = "BLOCADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Blocado
        {
            get { return  blocado; }
            set {  blocado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDISTRIB
        /// Comentário: 
        /// </summary>
        private string coddistrib;
        [XmlElement(ElementName = "CODDISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Coddistrib
        {
            get { return  coddistrib; }
            set {  coddistrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALORIGEM
        /// Comentário: Indica o código da filial de gestão que originou o registro no WMS.
        /// </summary>
        private string codfilialorigem;
        [XmlElement(ElementName = "CODFILIALORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialorigem
        {
            get { return  codfilialorigem; }
            set {  codfilialorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Comentário: 
        /// </summary>
        private decimal codfuncconf;
        [XmlElement(ElementName = "CODFUNCCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconf
        {
            get { return  codfuncconf; }
            set {  codfuncconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEMBALADOR
        /// Comentário: 
        /// </summary>
        private decimal codfuncembalador;
        [XmlElement(ElementName = "CODFUNCEMBALADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncembalador
        {
            get { return  codfuncembalador; }
            set {  codfuncembalador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCGERA
        /// Comentário: 
        /// </summary>
        private decimal codfuncgera;
        [XmlElement(ElementName = "CODFUNCGERA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncgera
        {
            get { return  codfuncgera; }
            set {  codfuncgera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPER
        /// Comentário: 
        /// </summary>
        private string codoper;
        [XmlElement(ElementName = "CODOPER", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codoper
        {
            get { return  codoper; }
            set {  codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Comentário: 
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAWMS
        /// Comentário: 
        /// </summary>
        private DateTime? datawms;
        [XmlElement(ElementName = "DATAWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datawms
        {
            get { return  datawms; }
            set {  datawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTINO
        /// Comentário: 
        /// </summary>
        private string destino;
        [XmlElement(ElementName = "DESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Destino
        {
            get { return  destino; }
            set {  destino = value; }
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
        /// Propriedade referente ao campo: DTENT
        /// Comentário: 
        /// </summary>
        private DateTime? dtent;
        [XmlElement(ElementName = "DTENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtent
        {
            get { return  dtent; }
            set {  dtent = value; }
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
        /// Propriedade referente ao campo: DTFIMPROMOLOTE
        /// Comentário: Data final da promoção
        /// </summary>
        private DateTime? dtfimpromolote;
        [XmlElement(ElementName = "DTFIMPROMOLOTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimpromolote
        {
            get { return  dtfimpromolote; }
            set {  dtfimpromolote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtgeracao;
        [XmlElement(ElementName = "DTGERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgeracao
        {
            get { return  dtgeracao; }
            set {  dtgeracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOPROMOLOTE
        /// Comentário: Data inicial da promoção
        /// </summary>
        private DateTime? dtiniciopromolote;
        [XmlElement(ElementName = "DTINICIOPROMOLOTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciopromolote
        {
            get { return  dtiniciopromolote; }
            set {  dtiniciopromolote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRACIONADO
        /// Comentário: 
        /// </summary>
        private string fracionado;
        [XmlElement(ElementName = "FRACIONADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fracionado
        {
            get { return  fracionado; }
            set {  fracionado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFINALSEP
        /// Comentário: 
        /// </summary>
        private decimal horafinalsep;
        [XmlElement(ElementName = "HORAFINALSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafinalsep
        {
            get { return  horafinalsep; }
            set {  horafinalsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIALSEP
        /// Comentário: 
        /// </summary>
        private decimal horainicialsep;
        [XmlElement(ElementName = "HORAINICIALSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horainicialsep
        {
            get { return  horainicialsep; }
            set {  horainicialsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LISTARPEDIDO
        /// Comentário: VALIDAR SE UM DETERMINADO PEDIDO JÁ FOI PROCESSADO.
        /// </summary>
        private string listarpedido;
        [XmlElement(ElementName = "LISTARPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Listarpedido
        {
            get { return  listarpedido; }
            set {  listarpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAPAGERADO
        /// Comentário: 
        /// </summary>
        private string mapagerado;
        [XmlElement(ElementName = "MAPAGERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mapagerado
        {
            get { return  mapagerado; }
            set {  mapagerado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFINALSEP
        /// Comentário: 
        /// </summary>
        private decimal minutofinalsep;
        [XmlElement(ElementName = "MINUTOFINALSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutofinalsep
        {
            get { return  minutofinalsep; }
            set {  minutofinalsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOINICIALSEP
        /// Comentário: 
        /// </summary>
        private decimal minutoinicialsep;
        [XmlElement(ElementName = "MINUTOINICIALSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoinicialsep
        {
            get { return  minutoinicialsep; }
            set {  minutoinicialsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Comentário: Numero da ordem de produção gerada no módulo 16.
        /// </summary>
        private string numop;
        [XmlElement(ElementName = "NUMOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numop
        {
            get { return  numop; }
            set {  numop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTREGA
        /// Comentário: 
        /// </summary>
        private decimal numseqentrega;
        [XmlElement(ElementName = "NUMSEQENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseqentrega
        {
            get { return  numseqentrega; }
            set {  numseqentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQMONTAGEM
        /// Comentário: 
        /// </summary>
        private decimal numseqmontagem;
        [XmlElement(ElementName = "NUMSEQMONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseqmontagem
        {
            get { return  numseqmontagem; }
            set {  numseqmontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSABASTECIMENTO
        /// Comentário: Número transação abastecimento
        /// </summary>
        private decimal numtransabastecimento;
        [XmlElement(ElementName = "NUMTRANSABASTECIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransabastecimento
        {
            get { return  numtransabastecimento; }
            set {  numtransabastecimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
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
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Comentário: 
        /// </summary>
        private decimal numtranswms;
        [XmlElement(ElementName = "NUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranswms
        {
            get { return  numtranswms; }
            set {  numtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASMAPA
        /// Comentário: 
        /// </summary>
        private decimal numviasmapa;
        [XmlElement(ElementName = "NUMVIASMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviasmapa
        {
            get { return  numviasmapa; }
            set {  numviasmapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDABASE
        /// Comentário: 
        /// </summary>
        private decimal pvendabase;
        [XmlElement(ElementName = "PVENDABASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pvendabase
        {
            get { return  pvendabase; }
            set {  pvendabase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTANT
        /// Comentário: 
        /// </summary>
        private decimal qtant;
        [XmlElement(ElementName = "QTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtant
        {
            get { return  qtant; }
            set {  qtant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIA
        /// Comentário: 
        /// </summary>
        private decimal qtavaria;
        [XmlElement(ElementName = "QTAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtavaria
        {
            get { return  qtavaria; }
            set {  qtavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Comentário: Indica a quantidade bloqueada.
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBOX
        /// Comentário: 
        /// </summary>
        private decimal qtbox;
        [XmlElement(ElementName = "QTBOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbox
        {
            get { return  qtbox; }
            set {  qtbox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCX
        /// Comentário: 
        /// </summary>
        private decimal qtcx;
        [XmlElement(ElementName = "QTCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtcx
        {
            get { return  qtcx; }
            set {  qtcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCXORIG
        /// Comentário: QUANTIDADE DE CAIXAS ORIGINAL
        /// </summary>
        private decimal qtcxorig;
        [XmlElement(ElementName = "QTCXORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtcxorig
        {
            get { return  qtcxorig; }
            set {  qtcxorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPALETE
        /// Comentário: 
        /// </summary>
        private decimal qtpalete;
        [XmlElement(ElementName = "QTPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpalete
        {
            get { return  qtpalete; }
            set {  qtpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECAS
        /// Comentário: Campo para peso variável.
        /// </summary>
        private decimal qtpecas;
        [XmlElement(ElementName = "QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpecas
        {
            get { return  qtpecas; }
            set {  qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECASORIG
        /// Comentário: QUANTIDADE DE PEÇAS ORIGINAL
        /// </summary>
        private decimal qtpecasorig;
        [XmlElement(ElementName = "QTPECASORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtpecasorig
        {
            get { return  qtpecasorig; }
            set {  qtpecasorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEPARADA
        /// Comentário: 
        /// </summary>
        private decimal qtseparada;
        [XmlElement(ElementName = "QTSEPARADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtseparada
        {
            get { return  qtseparada; }
            set {  qtseparada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTOTPALCX
        /// Comentário: 
        /// </summary>
        private decimal qttotpalcx;
        [XmlElement(ElementName = "QTTOTPALCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qttotpalcx
        {
            get { return  qttotpalcx; }
            set {  qttotpalcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUN
        /// Comentário: 
        /// </summary>
        private decimal qtun;
        [XmlElement(ElementName = "QTUN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtun
        {
            get { return  qtun; }
            set {  qtun = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITCX
        /// Comentário: 
        /// </summary>
        private decimal qtunitcx;
        [XmlElement(ElementName = "QTUNITCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtunitcx
        {
            get { return  qtunitcx; }
            set {  qtunitcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARACAOCONCLUIDA
        /// Comentário: 
        /// </summary>
        private string separacaoconcluida;
        [XmlElement(ElementName = "SEPARACAOCONCLUIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separacaoconcluida
        {
            get { return  separacaoconcluida; }
            set {  separacaoconcluida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMPEDIDO
        /// Comentário: 
        /// </summary>
        private string tipoembalagempedido;
        [XmlElement(ElementName = "TIPOEMBALAGEMPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagempedido
        {
            get { return  tipoembalagempedido; }
            set {  tipoembalagempedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMAPA
        /// Comentário: 
        /// </summary>
        private string tipomapa;
        [XmlElement(ElementName = "TIPOMAPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipomapa
        {
            get { return  tipomapa; }
            set {  tipomapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESO
        /// Comentário: 
        /// </summary>
        private decimal totpeso;
        [XmlElement(ElementName = "TOTPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
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
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCWms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCWms>(where);
        }

        #endregion
    }
}
