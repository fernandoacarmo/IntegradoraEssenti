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
    /// Classe referente a tabela PCPedcfv
    /// </summary>
    [XmlType("PCPEDCFV")]
    public class PCPedcfv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGRUPAMENTO
        /// Coment�rio: Informa de pedido ser� agrupado ou n�o
        /// </summary>
        private string agrupamento;
        [XmlElement(ElementName = "AGRUPAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agrupamento
        {
            get { return  agrupamento; }
            set {  agrupamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATENDIDO
        /// Coment�rio: Informa se o pedido foi atendido Total ou Parcial
        /// </summary>
        private string atendido;
        [XmlElement(ElementName = "ATENDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atendido
        {
            get { return  atendido; }
            set {  atendido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCLI
        /// Coment�rio: 
        /// </summary>
        private string cgccli;
        [XmlElement(ElementName = "CGCCLI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public string Cgccli
        {
            get { return  cgccli; }
            set {  cgccli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBNF
        /// Coment�rio: codigo da bonificacao
        /// </summary>
        private decimal codbnf;
        [XmlElement(ElementName = "CODBNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbnf
        {
            get { return  codbnf; }
            set {  codbnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: Codigo do cliente que ser� usado em conjunto com o campo cnpj para identificar o cliente no caso de ter no cadastro mais de um cliente com mesmo cnpj
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
        /// Propriedade referente ao campo: CODCLINF
        /// Coment�rio: Neste campo ser� inserido o c�digo do cliente para grava��o nos dados fiscais/impress�o de cupons e notas fiscais.
        /// </summary>
        private decimal codclinf;
        [XmlElement(ElementName = "CODCLINF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclinf
        {
            get { return  codclinf; }
            set {  codclinf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIRECEBEDOR
        /// Coment�rio: Codigo do cliente recebedor.
        /// </summary>
        private decimal codclirecebedor;
        [XmlElement(ElementName = "CODCLIRECEBEDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclirecebedor
        {
            get { return  codclirecebedor; }
            set {  codclirecebedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLITV8
        /// Coment�rio: C�digo do cliente que ser� usado para o pedido TV8
        /// </summary>
        private decimal codclitv8;
        [XmlElement(ElementName = "CODCLITV8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclitv8
        {
            get { return  codclitv8; }
            set {  codclitv8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDENT
        /// Coment�rio: C�digo do Endere�o de entrega
        /// </summary>
        private decimal codendent;
        [XmlElement(ElementName = "CODENDENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codendent
        {
            get { return  codendent; }
            set {  codendent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDENTCLI
        /// Coment�rio: C�digo de endere�o do cliente.
        /// </summary>
        private decimal codendentcli;
        [XmlElement(ElementName = "CODENDENTCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codendentcli
        {
            get { return  codendentcli; }
            set {  codendentcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFILIALNF
        /// Coment�rio: 
        /// </summary>
        private string codfilialnf;
        [XmlElement(ElementName = "CODFILIALNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialnf
        {
            get { return  codfilialnf; }
            set {  codfilialnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Coment�rio: 
        /// </summary>
        private string codfilialretira;
        [XmlElement(ElementName = "CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira
        {
            get { return  codfilialretira; }
            set {  codfilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECBONIFIC
        /// Coment�rio: Codigo do fornecedor da bonificacao
        /// </summary>
        private decimal codfornecbonific;
        [XmlElement(ElementName = "CODFORNECBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecbonific
        {
            get { return  codfornecbonific; }
            set {  codfornecbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal codfornecfrete;
        [XmlElement(ElementName = "CODFORNECFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecfrete
        {
            get { return  codfornecfrete; }
            set {  codfornecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVONAOATEND
        /// Coment�rio: C�digo do Motivo de N�o Atendimento
        /// </summary>
        private decimal codmotivonaoatend;
        [XmlElement(ElementName = "CODMOTIVONAOATEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codmotivonaoatend
        {
            get { return  codmotivonaoatend; }
            set {  codmotivonaoatend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: � gravado por uma trigger quando o pedido � montado.
        /// </summary>
        private decimal codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODPLPAGETICO
        /// Coment�rio: Plano de pagamento para medicamentos eticos
        /// </summary>
        private decimal codplpagetico;
        [XmlElement(ElementName = "CODPLPAGETICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpagetico
        {
            get { return  codplpagetico; }
            set {  codplpagetico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGGENERICO
        /// Coment�rio: Plano de pagamento para medicamentos genericos
        /// </summary>
        private decimal codplpaggenerico;
        [XmlElement(ElementName = "CODPLPAGGENERICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpaggenerico
        {
            get { return  codplpaggenerico; }
            set {  codplpaggenerico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTA
        /// Coment�rio: Codigo da Rota
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR2
        /// Coment�rio: Codigo do rca profissional 2
        /// </summary>
        private decimal codusur2;
        [XmlElement(ElementName = "CODUSUR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur2
        {
            get { return  codusur2; }
            set {  codusur2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR3
        /// Coment�rio: Codigo do rca profissional 3
        /// </summary>
        private decimal codusur3;
        [XmlElement(ElementName = "CODUSUR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur3
        {
            get { return  codusur3; }
            set {  codusur3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR4
        /// Coment�rio: Codigo do rca profissional 4
        /// </summary>
        private decimal codusur4;
        [XmlElement(ElementName = "CODUSUR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur4
        {
            get { return  codusur4; }
            set {  codusur4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Coment�rio: 
        /// </summary>
        private string codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal condvenda;
        [XmlElement(ElementName = "CONDVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Condvenda
        {
            get { return  condvenda; }
            set {  condvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAORDEM
        /// Coment�rio: Este campo determina se a Integradora validar� o processo de Conta Ordem da Venda Futura
        /// </summary>
        private string contaordem;
        [XmlElement(ElementName = "CONTAORDEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contaordem
        {
            get { return  contaordem; }
            set {  contaordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOBONIFICACAO
        /// Coment�rio: Tipo de custo da bonificacao
        /// </summary>
        private string custobonificacao;
        [XmlElement(ElementName = "CUSTOBONIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Custobonificacao
        {
            get { return  custobonificacao; }
            set {  custobonificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURAPEDPALM
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtaberturapedpalm;
        [XmlElement(ElementName = "DTABERTURAPEDPALM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtaberturapedpalm
        {
            get { return  dtaberturapedpalm; }
            set {  dtaberturapedpalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: Data de Altera��o no registro
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTFECHAMENTOPEDPALM
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfechamentopedpalm;
        [XmlElement(ElementName = "DTFECHAMENTOPEDPALM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtfechamentopedpalm
        {
            get { return  dtfechamentopedpalm; }
            set {  dtfechamentopedpalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: Grava Data e Hora da �ltima Importa��o.
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEDESPACHO
        /// Coment�rio: 
        /// </summary>
        private string fretedespacho;
        [XmlElement(ElementName = "FRETEDESPACHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fretedespacho
        {
            get { return  fretedespacho; }
            set {  fretedespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEREDESPACHO
        /// Coment�rio: 
        /// </summary>
        private string freteredespacho;
        [XmlElement(ElementName = "FRETEREDESPACHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Freteredespacho
        {
            get { return  freteredespacho; }
            set {  freteredespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACP
        /// Coment�rio: 
        /// </summary>
        private string geracp;
        [XmlElement(ElementName = "GERACP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracp
        {
            get { return  geracp; }
            set {  geracp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GEROUBRINDE
        /// Coment�rio: Informa se o pedido gerou brinde
        /// </summary>
        private string geroubrinde;
        [XmlElement(ElementName = "GEROUBRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geroubrinde
        {
            get { return  geroubrinde; }
            set {  geroubrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: 
        /// </summary>
        private decimal importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALDESEMBARACO
        /// Coment�rio: Local Desembara�o
        /// </summary>
        private string localdesembaraco;
        [XmlElement(ElementName = "LOCALDESEMBARACO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Localdesembaraco
        {
            get { return  localdesembaraco; }
            set {  localdesembaraco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: N�mero do pedido gravado na pcpedc. Ser� retornado pela package
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
        /// Propriedade referente ao campo: NUMPEDCLI
        /// Coment�rio: 
        /// </summary>
        private string numpedcli;
        [XmlElement(ElementName = "NUMPEDCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Numpedcli
        {
            get { return  numpedcli; }
            set {  numpedcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDCOMP
        /// Coment�rio: 
        /// </summary>
        private decimal numpedcomp;
        [XmlElement(ElementName = "NUMPEDCOMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedcomp
        {
            get { return  numpedcomp; }
            set {  numpedcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDORIGEM
        /// Coment�rio: Indica se o pedido � complementar.
        /// </summary>
        private decimal numpedorigem;
        [XmlElement(ElementName = "NUMPEDORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedorigem
        {
            get { return  numpedorigem; }
            set {  numpedorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Coment�rio: 
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedrca
        {
            get { return  numpedrca; }
            set {  numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDTV1
        /// Coment�rio: N�mero do pedido TV1
        /// </summary>
        private decimal numpedtv1;
        [XmlElement(ElementName = "NUMPEDTV1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedtv1
        {
            get { return  numpedtv1; }
            set {  numpedtv1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDVANXML
        /// Coment�rio: Num. Pedido VAN para gravar no XML da NF-e.
        /// </summary>
        private string numpedvanxml;
        [XmlElement(ElementName = "NUMPEDVANXML", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numpedvanxml
        {
            get { return  numpedvanxml; }
            set {  numpedvanxml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAOBROKER
        /// Coment�rio: N�mero da regi�o utilizada para esta venda.
        /// </summary>
        private decimal numregiaobroker;
        [XmlElement(ElementName = "NUMREGIAOBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiaobroker
        {
            get { return  numregiaobroker; }
            set {  numregiaobroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTREGA
        /// Coment�rio: 
        /// </summary>
        private decimal numseqentrega;
        [XmlElement(ElementName = "NUMSEQENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numseqentrega
        {
            get { return  numseqentrega; }
            set {  numseqentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA1
        /// Coment�rio: 
        /// </summary>
        private string obsentrega1;
        [XmlElement(ElementName = "OBSENTREGA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega1
        {
            get { return  obsentrega1; }
            set {  obsentrega1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA2
        /// Coment�rio: 
        /// </summary>
        private string obsentrega2;
        [XmlElement(ElementName = "OBSENTREGA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega2
        {
            get { return  obsentrega2; }
            set {  obsentrega2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA3
        /// Coment�rio: 
        /// </summary>
        private string obsentrega3;
        [XmlElement(ElementName = "OBSENTREGA3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega3
        {
            get { return  obsentrega3; }
            set {  obsentrega3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA4
        /// Coment�rio: 
        /// </summary>
        private string obsentrega4;
        [XmlElement(ElementName = "OBSENTREGA4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega4
        {
            get { return  obsentrega4; }
            set {  obsentrega4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Coment�rio: 
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS1
        /// Coment�rio: 
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORCAMENTO
        /// Coment�rio: Indica se � or�amento.
        /// </summary>
        private string orcamento;
        [XmlElement(ElementName = "ORCAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orcamento
        {
            get { return  orcamento; }
            set {  orcamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Coment�rio: 
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCABATIMENTO
        /// Coment�rio: Per centual de abatimento
        /// </summary>
        private decimal percdescabatimento;
        [XmlElement(ElementName = "PERCDESCABATIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdescabatimento
        {
            get { return  percdescabatimento; }
            set {  percdescabatimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO_ATUAL
        /// Coment�rio: 
        /// </summary>
        private string posicao_atual;
        [XmlElement(ElementName = "POSICAO_ATUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Posicao_Atual
        {
            get { return  posicao_atual; }
            set {  posicao_atual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO1
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PVENDASEMIMPOSTO
        /// Coment�rio: Indica se pre�o enviado est� sem imposto.
        /// </summary>
        private string pvendasemimposto;
        [XmlElement(ElementName = "PVENDASEMIMPOSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pvendasemimposto
        {
            get { return  pvendasemimposto; }
            set {  pvendasemimposto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETORNO
        /// Coment�rio: 
        /// </summary>
        private decimal retorno;
        [XmlElement(ElementName = "RETORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Retorno
        {
            get { return  retorno; }
            set {  retorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOATUALRCA
        /// Coment�rio: 
        /// </summary>
        private decimal saldoatualrca;
        [XmlElement(ElementName = "SALDOATUALRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Saldoatualrca
        {
            get { return  saldoatualrca; }
            set {  saldoatualrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOCUMENTO
        /// Coment�rio: Este campo pode ser: C - cupom fiscal, N - Nota Fiscal, A - ambos. Determina como o pedido poder� ser faturado.
        /// </summary>
        private string tipodocumento;
        [XmlElement(ElementName = "TIPODOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodocumento
        {
            get { return  tipodocumento; }
            set {  tipodocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENTREGA
        /// Coment�rio: Tipo de entrega do item para venda 7
        /// </summary>
        private string tipoentrega;
        [XmlElement(ElementName = "TIPOENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoentrega
        {
            get { return  tipoentrega; }
            set {  tipoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFV
        /// Coment�rio: Tipo de For�a de Vendas
        /// </summary>
        private string tipofv;
        [XmlElement(ElementName = "TIPOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofv
        {
            get { return  tipofv; }
            set {  tipofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRIORIDADEENTREGA
        /// Coment�rio: Tipo de Prioridade de entrega
        /// </summary>
        private string tipoprioridadeentrega;
        [XmlElement(ElementName = "TIPOPRIORIDADEENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprioridadeentrega
        {
            get { return  tipoprioridadeentrega; }
            set {  tipoprioridadeentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TURNOENTREGA
        /// Coment�rio: Turno de entrega do pedido
        /// </summary>
        private string turnoentrega;
        [XmlElement(ElementName = "TURNOENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Turnoentrega
        {
            get { return  turnoentrega; }
            set {  turnoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDESEMBARACO
        /// Coment�rio: UF Desembara�o
        /// </summary>
        private string ufdesembaraco;
        [XmlElement(ElementName = "UFDESEMBARACO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufdesembaraco
        {
            get { return  ufdesembaraco; }
            set {  ufdesembaraco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACFOPVENDANATV10
        /// Coment�rio: 
        /// </summary>
        private string usacfopvendanatv10;
        [XmlElement(ElementName = "USACFOPVENDANATV10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacfopvendanatv10
        {
            get { return  usacfopvendanatv10; }
            set {  usacfopvendanatv10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCABATIMENTO
        /// Coment�rio: Valor de desconto de abatimento.
        /// </summary>
        private decimal vldescabatimento;
        [XmlElement(ElementName = "VLDESCABATIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescabatimento
        {
            get { return  vldescabatimento; }
            set {  vldescabatimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENTRADA
        /// Coment�rio: Valor de entrada.
        /// </summary>
        private decimal vlentrada;
        [XmlElement(ElementName = "VLENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlentrada
        {
            get { return  vlentrada; }
            set {  vlentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPedcfv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDCFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPedcfv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedcfv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPedcfv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedcfv>(where);
        }

        #endregion
    }
}
