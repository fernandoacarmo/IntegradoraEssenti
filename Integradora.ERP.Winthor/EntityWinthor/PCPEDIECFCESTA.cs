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
    /// Classe referente a tabela PCPediecfcesta
    /// </summary>
    [XmlType("PCPEDIECFCESTA")]
    public class PCPediecfcesta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1
        /// Comentário: 
        /// </summary>
        private decimal aliqicms1;
        [XmlElement(ElementName = "ALIQICMS1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1
        {
            get { return  aliqicms1; }
            set {  aliqicms1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2
        /// Comentário: 
        /// </summary>
        private decimal aliqicms2;
        [XmlElement(ElementName = "ALIQICMS2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms2
        {
            get { return  aliqicms2; }
            set {  aliqicms2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEDIFALIQUOTAS
        /// Comentário: Base de Diferencial de Alíquotas. 
        /// </summary>
        private decimal basedifaliquotas;
        [XmlElement(ElementName = "BASEDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basedifaliquotas
        {
            get { return  basedifaliquotas; }
            set {  basedifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMS
        /// Comentário: Base de ICMS. 
        /// </summary>
        private decimal baseicms;
        [XmlElement(ElementName = "BASEICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicms
        {
            get { return  baseicms; }
            set {  baseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICST
        /// Comentário: 
        /// </summary>
        private decimal baseicst;
        [XmlElement(ElementName = "BASEICST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicst
        {
            get { return  baseicst; }
            set {  baseicst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BCISS
        /// Comentário: Base de ISS. 
        /// </summary>
        private decimal bciss;
        [XmlElement(ElementName = "BCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Bciss
        {
            get { return  bciss; }
            set {  bciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODECF
        /// Comentário: 
        /// </summary>
        private string codecf;
        [XmlElement(ElementName = "CODECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codecf
        {
            get { return  codecf; }
            set {  codecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: Código Fiscal. 
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
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
        /// Propriedade referente ao campo: CODICMTAB
        /// Comentário: 
        /// </summary>
        private decimal codicmtab;
        [XmlElement(ElementName = "CODICMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtab
        {
            get { return  codicmtab; }
            set {  codicmtab = value; }
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
        /// Propriedade referente ao campo: CODPRODMP
        /// Comentário: 
        /// </summary>
        private decimal codprodmp;
        [XmlElement(ElementName = "CODPRODMP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodmp
        {
            get { return  codprodmp; }
            set {  codprodmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Comentário: 
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINEST
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Comentário: Indica a data de exportação do registro do caixa para o servidor.
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
        /// Propriedade referente ao campo: IVA
        /// Comentário: 
        /// </summary>
        private decimal iva;
        [XmlElement(ElementName = "IVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Iva
        {
            get { return  iva; }
            set {  iva = value; }
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
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIE
        /// Comentário: Número de série do produto.
        /// </summary>
        private string numserie;
        [XmlElement(ElementName = "NUMSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserie
        {
            get { return  numserie; }
            set {  numserie = value; }
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
        /// Propriedade referente ao campo: PAUTA
        /// Comentário: 
        /// </summary>
        private decimal pauta;
        [XmlElement(ElementName = "PAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pauta
        {
            get { return  pauta; }
            set {  pauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PBASERCA
        /// Comentário: Preço base RCA.
        /// </summary>
        private decimal pbaserca;
        [XmlElement(ElementName = "PBASERCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pbaserca
        {
            get { return  pbaserca; }
            set {  pbaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERED
        /// Comentário: 
        /// </summary>
        private decimal percbasered;
        [XmlElement(ElementName = "PERCBASERED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbasered
        {
            get { return  percbasered; }
            set {  percbasered = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDST
        /// Comentário: 
        /// </summary>
        private decimal percbaseredst;
        [XmlElement(ElementName = "PERCBASEREDST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredst
        {
            get { return  percbaseredst; }
            set {  percbaseredst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDSTFONTE
        /// Comentário: 
        /// </summary>
        private decimal percbaseredstfonte;
        [XmlElement(ElementName = "PERCBASEREDSTFONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredstfonte
        {
            get { return  percbaseredstfonte; }
            set {  percbaseredstfonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCCOFINS
        /// Comentário: % desc. COFINS. 
        /// </summary>
        private decimal percdesccofins;
        [XmlElement(ElementName = "PERCDESCCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesccofins
        {
            get { return  percdesccofins; }
            set {  percdesccofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCPIS
        /// Comentário: % desc. PIS. 
        /// </summary>
        private decimal percdescpis;
        [XmlElement(ElementName = "PERCDESCPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescpis
        {
            get { return  percdescpis; }
            set {  percdescpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFALIQUOTAS
        /// Comentário: % Diferencial de Alíquotas. 
        /// </summary>
        private decimal percdifaliquotas;
        [XmlElement(ElementName = "PERCDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdifaliquotas
        {
            get { return  percdifaliquotas; }
            set {  percdifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Comentário: Alíquota ICMS. 
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
        /// Propriedade referente ao campo: PERCICMS
        /// Comentário: Percentual do ICMS.
        /// </summary>
        private decimal percicms;
        [XmlElement(ElementName = "PERCICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicms
        {
            get { return  percicms; }
            set {  percicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI
        /// Comentário: 
        /// </summary>
        private decimal percipi;
        [XmlElement(ElementName = "PERCIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percipi
        {
            get { return  percipi; }
            set {  percipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCISS
        /// Comentário: Alíquota de ISS. 
        /// </summary>
        private decimal perciss;
        [XmlElement(ElementName = "PERCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perciss
        {
            get { return  perciss; }
            set {  perciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Comentário: % COFINS. 
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Comentário: 
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPIS
        /// Comentário: Percentual do PIS.
        /// </summary>
        private decimal percpis;
        [XmlElement(ElementName = "PERCPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percpis
        {
            get { return  percpis; }
            set {  percpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTRIBUTOS
        /// Comentário: Percentual a ser calculado sobre o item.
        /// </summary>
        private decimal perctributos;
        [XmlElement(ElementName = "PERCTRIBUTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perctributos
        {
            get { return  perctributos; }
            set {  perctributos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCUSTO
        /// Comentário: 
        /// </summary>
        private decimal perdesccusto;
        [XmlElement(ElementName = "PERDESCCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdesccusto
        {
            get { return  perdesccusto; }
            set {  perdesccusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCTAB
        /// Comentário: 
        /// </summary>
        private decimal perdesctab;
        [XmlElement(ElementName = "PERDESCTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdesctab
        {
            get { return  perdesctab; }
            set {  perdesctab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETECMV
        /// Comentário: 
        /// </summary>
        private decimal perfretecmv;
        [XmlElement(ElementName = "PERFRETECMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfretecmv
        {
            get { return  perfretecmv; }
            set {  perfretecmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Comentário: % PIS. 
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
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
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMP
        /// Comentário: 
        /// </summary>
        private decimal qtmp;
        [XmlElement(ElementName = "QTMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtmp
        {
            get { return  qtmp; }
            set {  qtmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Comentário: Situação Tributária. 
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Comentário: 
        /// </summary>
        private decimal st;
        [XmlElement(ElementName = "ST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal St
        {
            get { return  st; }
            set {  st = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STCLIENTEGNRE
        /// Comentário: 
        /// </summary>
        private decimal stclientegnre;
        [XmlElement(ElementName = "STCLIENTEGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stclientegnre
        {
            get { return  stclientegnre; }
            set {  stclientegnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDA
        /// Comentário: 
        /// </summary>
        private decimal txvenda;
        [XmlElement(ElementName = "TXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Txvenda
        {
            get { return  txvenda; }
            set {  txvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESCRODAPE
        /// Comentário: 
        /// </summary>
        private decimal vlacrescrodape;
        [XmlElement(ElementName = "VLACRESCRODAPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlacrescrodape
        {
            get { return  vlacrescrodape; }
            set {  vlacrescrodape = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPI
        /// Comentário: Base de IPI. 
        /// </summary>
        private decimal vlbaseipi;
        [XmlElement(ElementName = "VLBASEIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbaseipi
        {
            get { return  vlbaseipi; }
            set {  vlbaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Comentário: Valor de  COFINS. 
        /// </summary>
        private decimal vlcofins;
        [XmlElement(ElementName = "VLCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofins
        {
            get { return  vlcofins; }
            set {  vlcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOCONT
        /// Comentário: 
        /// </summary>
        private decimal vlcustocont;
        [XmlElement(ElementName = "VLCUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
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
        [XmlElement(ElementName = "VLCUSTOFIN", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
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
        [XmlElement(ElementName = "VLCUSTOREAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
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
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustorep
        {
            get { return  vlcustorep; }
            set {  vlcustorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCCUSTOCMV
        /// Comentário: 
        /// </summary>
        private decimal vldesccustocmv;
        [XmlElement(ElementName = "VLDESCCUSTOCMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldesccustocmv
        {
            get { return  vldesccustocmv; }
            set {  vldesccustocmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCREDUCAOCOFINS
        /// Comentário: VL.Redução COFINS. 
        /// </summary>
        private decimal vldescreducaocofins;
        [XmlElement(ElementName = "VLDESCREDUCAOCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vldescreducaocofins
        {
            get { return  vldescreducaocofins; }
            set {  vldescreducaocofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCREDUCAOPIS
        /// Comentário: VL.Redução PIS. 
        /// </summary>
        private decimal vldescreducaopis;
        [XmlElement(ElementName = "VLDESCREDUCAOPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vldescreducaopis
        {
            get { return  vldescreducaopis; }
            set {  vldescreducaopis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCRODAPE
        /// Comentário: 
        /// </summary>
        private decimal vldescrodape;
        [XmlElement(ElementName = "VLDESCRODAPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescrodape
        {
            get { return  vldescrodape; }
            set {  vldescrodape = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCSUFRAMA
        /// Comentário: 
        /// </summary>
        private decimal vldescsuframa;
        [XmlElement(ElementName = "VLDESCSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescsuframa
        {
            get { return  vldescsuframa; }
            set {  vldescsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFALIQUOTAS
        /// Comentário: Valor do Diferencial de Alíquotas. 
        /// </summary>
        private decimal vldifaliquotas;
        [XmlElement(ElementName = "VLDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldifaliquotas
        {
            get { return  vldifaliquotas; }
            set {  vldifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: 
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISS
        /// Comentário: Valor do ISS. 
        /// </summary>
        private decimal vliss;
        [XmlElement(ElementName = "VLISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vliss
        {
            get { return  vliss; }
            set {  vliss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLITEMTRIBUTOS
        /// Comentário: Valor dos impostos do item.
        /// </summary>
        private decimal vlitemtributos;
        [XmlElement(ElementName = "VLITEMTRIBUTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlitemtributos
        {
            get { return  vlitemtributos; }
            set {  vlitemtributos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Comentário: Valor de PIS. 
        /// </summary>
        private decimal vlpis;
        [XmlElement(ElementName = "VLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpis
        {
            get { return  vlpis; }
            set {  vlpis = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPediecfcesta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDIECFCESTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPediecfcesta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPediecfcesta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPediecfcesta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPediecfcesta>(where);
        }

        #endregion
    }
}
