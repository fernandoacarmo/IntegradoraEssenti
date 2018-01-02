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
    /// Classe referente a tabela PCLote
    /// </summary>
    [XmlType("PCLOTE")]
    public class PCLote : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANALISE
        /// Comentário: 
        /// </summary>
        private string analise;
        [XmlElement(ElementName = "ANALISE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Analise
        {
            get { return  analise; }
            set {  analise = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANALISEDESC
        /// Comentário: Descontos de Análise
        /// </summary>
        private string analisedesc;
        [XmlElement(ElementName = "ANALISEDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Analisedesc
        {
            get { return  analisedesc; }
            set {  analisedesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AN_IDENTIFICACAO
        /// Comentário: Pesquisa de Análise Identificação
        /// </summary>
        private string an_identificacao;
        [XmlElement(ElementName = "AN_IDENTIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string An_Identificacao
        {
            get { return  an_identificacao; }
            set {  an_identificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AN_IMPUREZA
        /// Comentário: Pesquisa Análises de Impurezas
        /// </summary>
        private string an_impureza;
        [XmlElement(ElementName = "AN_IMPUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string An_Impureza
        {
            get { return  an_impureza; }
            set {  an_impureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BOLORESLEVEDURAS
        /// Comentário: 
        /// </summary>
        private string boloresleveduras;
        [XmlElement(ElementName = "BOLORESLEVEDURAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Boloresleveduras
        {
            get { return  boloresleveduras; }
            set {  boloresleveduras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Comentário: 
        /// </summary>
        private string codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
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
        /// Propriedade referente ao campo: CODFUNCCONCILIACAO
        /// Comentário: 
        /// </summary>
        private decimal codfuncconciliacao;
        [XmlElement(ElementName = "CODFUNCCONCILIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncconciliacao
        {
            get { return  codfuncconciliacao; }
            set {  codfuncconciliacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCQ
        /// Comentário: 
        /// </summary>
        private decimal codfunccq;
        [XmlElement(ElementName = "CODFUNCCQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccq
        {
            get { return  codfunccq; }
            set {  codfunccq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Comentário: Código do funcionário que excluiu o lote.
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRM
        /// Comentário: 
        /// </summary>
        private decimal codfuncrm;
        [XmlElement(ElementName = "CODFUNCRM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncrm
        {
            get { return  codfuncrm; }
            set {  codfuncrm = value; }
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
        /// Propriedade referente ao campo: COL95
        /// Comentário: 
        /// </summary>
        private string col95;
        [XmlElement(ElementName = "COL95", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Col95
        {
            get { return  col95; }
            set {  col95 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTMICROBIANA
        /// Comentário: Contaminação Microbiana
        /// </summary>
        private string contmicrobiana;
        [XmlElement(ElementName = "CONTMICROBIANA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Contmicrobiana
        {
            get { return  contmicrobiana; }
            set {  contmicrobiana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONCILIACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dataconciliacao;
        [XmlElement(ElementName = "DATACONCILIACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataconciliacao
        {
            get { return  dataconciliacao; }
            set {  dataconciliacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFABRICACAO
        /// Comentário: 
        /// </summary>
        private DateTime? datafabricacao;
        [XmlElement(ElementName = "DATAFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafabricacao
        {
            get { return  datafabricacao; }
            set {  datafabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DENSIDADE
        /// Comentário: Pesquisa de Densidade
        /// </summary>
        private string densidade;
        [XmlElement(ElementName = "DENSIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Densidade
        {
            get { return  densidade; }
            set {  densidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESINTEGRACAO
        /// Comentário: Pesquisa de Desintegração
        /// </summary>
        private string desintegracao;
        [XmlElement(ElementName = "DESINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Desintegracao
        {
            get { return  desintegracao; }
            set {  desintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISSOLUCAO
        /// Comentário: Pesquisa de Dissolução
        /// </summary>
        private string dissolucao;
        [XmlElement(ElementName = "DISSOLUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Dissolucao
        {
            get { return  dissolucao; }
            set {  dissolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOSEAMENTO
        /// Comentário: Pesquisa de Doseamento
        /// </summary>
        private string doseamento;
        [XmlElement(ElementName = "DOSEAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Doseamento
        {
            get { return  doseamento; }
            set {  doseamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAREANALISE
        /// Comentário: 
        /// </summary>
        private DateTime? dtareanalise;
        [XmlElement(ElementName = "DTAREANALISE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtareanalise
        {
            get { return  dtareanalise; }
            set {  dtareanalise = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBLOQUEIO1
        /// Comentário: 
        /// </summary>
        private DateTime? dtbloqueio1;
        [XmlElement(ElementName = "DTBLOQUEIO1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbloqueio1
        {
            get { return  dtbloqueio1; }
            set {  dtbloqueio1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBLOQUEIO2
        /// Comentário: 
        /// </summary>
        private DateTime? dtbloqueio2;
        [XmlElement(ElementName = "DTBLOQUEIO2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbloqueio2
        {
            get { return  dtbloqueio2; }
            set {  dtbloqueio2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: Indica a data de exclusão do lote.
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINSPVISUAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtinspvisual;
        [XmlElement(ElementName = "DTINSPVISUAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinspvisual
        {
            get { return  dtinspvisual; }
            set {  dtinspvisual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLAUDO
        /// Comentário: Indica a data do laudo de análise do lote.
        /// </summary>
        private DateTime? dtlaudo;
        [XmlElement(ElementName = "DTLAUDO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlaudo
        {
            get { return  dtlaudo; }
            set {  dtlaudo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtliberacao;
        [XmlElement(ElementName = "DTLIBERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtliberacao
        {
            get { return  dtliberacao; }
            set {  dtliberacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVLIB
        /// Comentário: 
        /// </summary>
        private DateTime? dtprevlib;
        [XmlElement(ElementName = "DTPREVLIB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevlib
        {
            get { return  dtprevlib; }
            set {  dtprevlib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTMOVENT
        /// Comentário: 
        /// </summary>
        private DateTime? dtultmovent;
        [XmlElement(ElementName = "DTULTMOVENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultmovent
        {
            get { return  dtultmovent; }
            set {  dtultmovent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTMOVSAI
        /// Comentário: 
        /// </summary>
        private DateTime? dtultmovsai;
        [XmlElement(ElementName = "DTULTMOVSAI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultmovsai
        {
            get { return  dtultmovsai; }
            set {  dtultmovsai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Comentário: 
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTFAUREAUS
        /// Comentário: 
        /// </summary>
        private string estfaureaus;
        [XmlElement(ElementName = "ESTFAUREAUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Estfaureaus
        {
            get { return  estfaureaus; }
            set {  estfaureaus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FABRICANTE
        /// Comentário: 
        /// </summary>
        private string fabricante;
        [XmlElement(ElementName = "FABRICANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Fabricante
        {
            get { return  fabricante; }
            set {  fabricante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORPUREZA
        /// Comentário: 
        /// </summary>
        private decimal fatorpureza;
        [XmlElement(ElementName = "FATORPUREZA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Fatorpureza
        {
            get { return  fatorpureza; }
            set {  fatorpureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRIABILIDADE
        /// Comentário: Pesquisa de Friabilidade
        /// </summary>
        private string friabilidade;
        [XmlElement(ElementName = "FRIABILIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Friabilidade
        {
            get { return  friabilidade; }
            set {  friabilidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICACAO
        /// Comentário: Identificação da Análise
        /// </summary>
        private string identificacao;
        [XmlElement(ElementName = "IDENTIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Identificacao
        {
            get { return  identificacao; }
            set {  identificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPUREZA
        /// Comentário: Pesquisa de Impurezas
        /// </summary>
        private string impureza;
        [XmlElement(ElementName = "IMPUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impureza
        {
            get { return  impureza; }
            set {  impureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LAUDO
        /// Comentário: 
        /// </summary>
        private string laudo;
        [XmlElement(ElementName = "LAUDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Laudo
        {
            get { return  laudo; }
            set {  laudo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LAUDOFAB
        /// Comentário: 
        /// </summary>
        private string laudofab;
        [XmlElement(ElementName = "LAUDOFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Laudofab
        {
            get { return  laudofab; }
            set {  laudofab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIPIDEO
        /// Comentário: 
        /// </summary>
        private string lipideo;
        [XmlElement(ElementName = "LIPIDEO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Lipideo
        {
            get { return  lipideo; }
            set {  lipideo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOFADO
        /// Comentário: 
        /// </summary>
        private string mofado;
        [XmlElement(ElementName = "MOFADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Mofado
        {
            get { return  mofado; }
            set {  mofado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOBLOQESTOQUE
        /// Comentário: Indica o motivo do bloqueio do estoque por lote.
        /// </summary>
        private string motivobloqestoque;
        [XmlElement(ElementName = "MOTIVOBLOQESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Motivobloqestoque
        {
            get { return  motivobloqestoque; }
            set {  motivobloqestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCERTIFICADO
        /// Comentário: 
        /// </summary>
        private string numcertificado;
        [XmlElement(ElementName = "NUMCERTIFICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numcertificado
        {
            get { return  numcertificado; }
            set {  numcertificado = value; }
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
        /// Propriedade referente ao campo: NUMLOTEFAB
        /// Comentário: 
        /// </summary>
        private string numlotefab;
        [XmlElement(ElementName = "NUMLOTEFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlotefab
        {
            get { return  numlotefab; }
            set {  numlotefab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTEFORNEC
        /// Comentário: 
        /// </summary>
        private string numlotefornec;
        [XmlElement(ElementName = "NUMLOTEFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlotefornec
        {
            get { return  numlotefornec; }
            set {  numlotefornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNEGOCIACAO
        /// Comentário: 
        /// </summary>
        private decimal numnegociacao;
        [XmlElement(ElementName = "NUMNEGOCIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numnegociacao
        {
            get { return  numnegociacao; }
            set {  numnegociacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAENT
        /// Comentário: 
        /// </summary>
        private decimal numnotaent;
        [XmlElement(ElementName = "NUMNOTAENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotaent
        {
            get { return  numnotaent; }
            set {  numnotaent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREVISAO
        /// Comentário: Indica o número da revisão.
        /// </summary>
        private decimal numrevisao;
        [XmlElement(ElementName = "NUMREVISAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numrevisao
        {
            get { return  numrevisao; }
            set {  numrevisao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTDEVCLI
        /// Comentário: 
        /// </summary>
        private decimal numtransentdevcli;
        [XmlElement(ElementName = "NUMTRANSENTDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentdevcli
        {
            get { return  numtransentdevcli; }
            set {  numtransentdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTORIG
        /// Comentário: Número da transação de entrada original, que será alimentado através da rotina de manutenção de lotes (1183). 
        /// </summary>
        private decimal numtransentorig;
        [XmlElement(ElementName = "NUMTRANSENTORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentorig
        {
            get { return  numtransentorig; }
            set {  numtransentorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSANALISE
        /// Comentário: 
        /// </summary>
        private string obsanalise;
        [XmlElement(ElementName = "OBSANALISE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obsanalise
        {
            get { return  obsanalise; }
            set {  obsanalise = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSBLOQUEIO
        /// Comentário: 
        /// </summary>
        private string obsbloqueio;
        [XmlElement(ElementName = "OBSBLOQUEIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obsbloqueio
        {
            get { return  obsbloqueio; }
            set {  obsbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSBLOQUEIOMANUAL
        /// Comentário: 
        /// </summary>
        private string obsbloqueiomanual;
        [XmlElement(ElementName = "OBSBLOQUEIOMANUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Obsbloqueiomanual
        {
            get { return  obsbloqueiomanual; }
            set {  obsbloqueiomanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS1
        /// Comentário: 
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTOANTECIPADO
        /// Comentário: 
        /// </summary>
        private string pagtoantecipado;
        [XmlElement(ElementName = "PAGTOANTECIPADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtoantecipado
        {
            get { return  pagtoantecipado; }
            set {  pagtoantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTEOR
        /// Comentário: 
        /// </summary>
        private decimal percteor;
        [XmlElement(ElementName = "PERCTEOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percteor
        {
            get { return  percteor; }
            set {  percteor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQPATOGENOS
        /// Comentário: Pesquisa de Patógenos
        /// </summary>
        private string pesqpatogenos;
        [XmlElement(ElementName = "PESQPATOGENOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Pesqpatogenos
        {
            get { return  pesqpatogenos; }
            set {  pesqpatogenos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PH
        /// Comentário: Pesquisa de PH
        /// </summary>
        private string ph;
        [XmlElement(ElementName = "PH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Ph
        {
            get { return  ph; }
            set {  ph = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOCOMPRA
        /// Comentário: 
        /// </summary>
        private decimal precocompra;
        [XmlElement(ElementName = "PRECOCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precocompra
        {
            get { return  precocompra; }
            set {  precocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTEINA
        /// Comentário: 
        /// </summary>
        private string proteina;
        [XmlElement(ElementName = "PROTEINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Proteina
        {
            get { return  proteina; }
            set {  proteina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMSEQLOTE
        /// Comentário: Indica o próximo número da sequencia de lotes.
        /// </summary>
        private decimal proxnumseqlote;
        [XmlElement(ElementName = "PROXNUMSEQLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Proxnumseqlote
        {
            get { return  proxnumseqlote; }
            set {  proxnumseqlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEST
        /// Comentário: 
        /// </summary>
        private decimal qtest;
        [XmlElement(ElementName = "QTEST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtest
        {
            get { return  qtest; }
            set {  qtest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTINDENIZ
        /// Comentário: 
        /// </summary>
        private decimal qtindeniz;
        [XmlElement(ElementName = "QTINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtindeniz
        {
            get { return  qtindeniz; }
            set {  qtindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Comentário: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Qtreserv
        {
            get { return  qtreserv; }
            set {  qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALMONELA
        /// Comentário: 
        /// </summary>
        private string salmonela;
        [XmlElement(ElementName = "SALMONELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Salmonela
        {
            get { return  salmonela; }
            set {  salmonela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTDEFEITO
        /// Comentário: 
        /// </summary>
        private string totdefeito;
        [XmlElement(ElementName = "TOTDEFEITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Totdefeito
        {
            get { return  totdefeito; }
            set {  totdefeito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXCONVERSAO
        /// Comentário: 
        /// </summary>
        private decimal txconversao;
        [XmlElement(ElementName = "TXCONVERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Txconversao
        {
            get { return  txconversao; }
            set {  txconversao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UMIDADE
        /// Comentário: 
        /// </summary>
        private string umidade;
        [XmlElement(ElementName = "UMIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Umidade
        {
            get { return  umidade; }
            set {  umidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UMIDADEANALISE
        /// Comentário: 
        /// </summary>
        private string umidadeanalise;
        [XmlElement(ElementName = "UMIDADEANALISE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Umidadeanalise
        {
            get { return  umidadeanalise; }
            set {  umidadeanalise = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIFORMIDADE
        /// Comentário: Pesquisa de Uniformidade
        /// </summary>
        private string uniformidade;
        [XmlElement(ElementName = "UNIFORMIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Uniformidade
        {
            get { return  uniformidade; }
            set {  uniformidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCALORICO
        /// Comentário: 
        /// </summary>
        private string vlcalorico;
        [XmlElement(ElementName = "VLCALORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Vlcalorico
        {
            get { return  vlcalorico; }
            set {  vlcalorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLPESMED
        /// Comentário: Volume / Peso e Medida
        /// </summary>
        private string volpesmed;
        [XmlElement(ElementName = "VOLPESMED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Volpesmed
        {
            get { return  volpesmed; }
            set {  volpesmed = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLote()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLOTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLote> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLote>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLote> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLote>(where);
        }

        #endregion
    }
}
