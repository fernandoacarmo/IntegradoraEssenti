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
    /// Classe referente a tabela PCDesconto
    /// </summary>
    [XmlType("PCDESCONTO")]
    public class PCDesconto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTERAPTABELA
        /// Coment�rio: "Alterar pre�o de tabela ?": Indica se o pre�o de tabela tamb�m ser� alterado. 
        /// </summary>
        private string alteraptabela;
        [XmlElement(ElementName = "ALTERAPTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alteraptabela
        {
            get { return  alteraptabela; }
            set {  alteraptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APENASPLPAGMAX
        /// Coment�rio: Desconto somente para o plano de pagamento.
        /// </summary>
        private string apenasplpagmax;
        [XmlElement(ElementName = "APENASPLPAGMAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Apenasplpagmax
        {
            get { return  apenasplpagmax; }
            set {  apenasplpagmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICADESCONTO
        /// Coment�rio: Indica se � aplicado o desconto. Op��es: S (Sim) e N (N�o)
        /// </summary>
        private string aplicadesconto;
        [XmlElement(ElementName = "APLICADESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicadesconto
        {
            get { return  aplicadesconto; }
            set {  aplicadesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICADESCSIMPLESNACIONAL
        /// Coment�rio: Aplica Desconto simples nacional.
        /// </summary>
        private string aplicadescsimplesnacional;
        [XmlElement(ElementName = "APLICADESCSIMPLESNACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicadescsimplesnacional
        {
            get { return  aplicadescsimplesnacional; }
            set {  aplicadescsimplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AREAATUACAO
        /// Coment�rio: Indica a �rea de atua��o do RCA.
        /// </summary>
        private string areaatuacao;
        [XmlElement(ElementName = "AREAATUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Areaatuacao
        {
            get { return  areaatuacao; }
            set {  areaatuacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASECREDDEBRCA
        /// Coment�rio: 
        /// </summary>
        private string basecreddebrca;
        [XmlElement(ElementName = "BASECREDDEBRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Basecreddebrca
        {
            get { return  basecreddebrca; }
            set {  basecreddebrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Coment�rio: 
        /// </summary>
        private string classevenda;
        [XmlElement(ElementName = "CLASSEVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classevenda
        {
            get { return  classevenda; }
            set {  classevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Coment�rio: 
        /// </summary>
        private decimal codativ;
        [XmlElement(ElementName = "CODATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codativ
        {
            get { return  codativ; }
            set {  codativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Coment�rio: 
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODCLICONV
        /// Coment�rio: C�DIGO DO CLIENTE CONVENIADO
        /// </summary>
        private decimal codcliconv;
        [XmlElement(ElementName = "CODCLICONV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcliconv
        {
            get { return  codcliconv; }
            set {  codcliconv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: C�DIGO COBRAN�A
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
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Coment�rio: Condi��o de venda
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCONTO
        /// Coment�rio: 
        /// </summary>
        private decimal coddesconto;
        [XmlElement(ElementName = "CODDESCONTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Coddesconto
        {
            get { return  coddesconto; }
            set {  coddesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Coment�rio: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial.
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: C�DIGO DO FUNCION�RIO
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Coment�rio: Indica o c�digo do grupo de desconto.
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOREST
        /// Coment�rio: C�digo do grupo de restri��o
        /// </summary>
        private decimal codgruporest;
        [XmlElement(ElementName = "CODGRUPOREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgruporest
        {
            get { return  codgruporest; }
            set {  codgruporest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIDENTIFICADOR
        /// Coment�rio: C�digo identificador de politicas
        /// </summary>
        private decimal codidentificador;
        [XmlElement(ElementName = "CODIDENTIFICADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codidentificador
        {
            get { return  codidentificador; }
            set {  codidentificador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHAPROD
        /// Coment�rio: C�d. Linha Produto
        /// </summary>
        private decimal codlinhaprod;
        [XmlElement(ElementName = "CODLINHAPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlinhaprod
        {
            get { return  codlinhaprod; }
            set {  codlinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Coment�rio: C�digo da Marca
        /// </summary>
        private decimal codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmarca
        {
            get { return  codmarca; }
            set {  codmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODCB
        /// Coment�rio: "Cesta B�sica": C�digo de produto cesta b�sica na qual determinado produto, que � item da cesta, ter� desconto. 
        /// </summary>
        private decimal codprodcb;
        [XmlElement(ElementName = "CODPRODCB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodcb
        {
            get { return  codprodcb; }
            set {  codprodcb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINC
        /// Coment�rio: 
        /// </summary>
        private decimal codprodprinc;
        [XmlElement(ElementName = "CODPRODPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodprinc
        {
            get { return  codprodprinc; }
            set {  codprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAOMED
        /// Coment�rio: C�d. Promo��o Med.
        /// </summary>
        private decimal codpromocaomed;
        [XmlElement(ElementName = "CODPROMOCAOMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Codpromocaomed
        {
            get { return  codpromocaomed; }
            set {  codpromocaomed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDE
        /// Coment�rio: C�digo da Rede
        /// </summary>
        private decimal codrede;
        [XmlElement(ElementName = "CODREDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrede
        {
            get { return  codrede; }
            set {  codrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Coment�rio: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Coment�rio: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCEDERMAIORCOMISSREG
        /// Coment�rio: Determina se ser� utilizado a maior comiss�o por regi�o
        /// </summary>
        private string concedermaiorcomissreg;
        [XmlElement(ElementName = "CONCEDERMAIORCOMISSREG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Concedermaiorcomissreg
        {
            get { return  concedermaiorcomissreg; }
            set {  concedermaiorcomissreg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERACALCGIROMEDIC
        /// Coment�rio: Considera politica no calculo do giro (medicamentos)
        /// </summary>
        private string consideracalcgiromedic;
        [XmlElement(ElementName = "CONSIDERACALCGIROMEDIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideracalcgiromedic
        {
            get { return  consideracalcgiromedic; }
            set {  consideracalcgiromedic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CREDITASOBREPOLITICA
        /// Coment�rio: Indica se credita RCA na venda com pre�o maior que pol�tica de desconto que altera base de c�lculo de d�bito/cr�dito.
        /// </summary>
        private string creditasobrepolitica;
        [XmlElement(ElementName = "CREDITASOBREPOLITICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Creditasobrepolitica
        {
            get { return  creditasobrepolitica; }
            set {  creditasobrepolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALANC
        /// Coment�rio: 
        /// </summary>
        private DateTime? datalanc;
        [XmlElement(ElementName = "DATALANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datalanc
        {
            get { return  datalanc; }
            set {  datalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAULTALTER
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataultalter;
        [XmlElement(ElementName = "DATAULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataultalter
        {
            get { return  dataultalter; }
            set {  dataultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FISCALCAIXA
        /// Coment�rio: Se o desconto � somente para o fiscal de caixa
        /// </summary>
        private string fiscalcaixa;
        [XmlElement(ElementName = "FISCALCAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fiscalcaixa
        {
            get { return  fiscalcaixa; }
            set {  fiscalcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Coment�rio: Indica pol�tica de desconto somente para certo or�amento. 
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
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMROLO
        /// Coment�rio: N�mero do Rolo
        /// </summary>
        private string numrolo;
        [XmlElement(ElementName = "NUMROLO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numrolo
        {
            get { return  numrolo; }
            set {  numrolo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSDESCONTO
        /// Coment�rio: Observa��es de desconto
        /// </summary>
        private string obsdesconto;
        [XmlElement(ElementName = "OBSDESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obsdesconto
        {
            get { return  obsdesconto; }
            set {  obsdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Coment�rio: 
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMPROFISSIONALMINIMO
        /// Coment�rio: Valor minino de percentual de comiss�o de profissional permitido para o or�amento. 
        /// </summary>
        private decimal perccomprofissionalminimo;
        [XmlElement(ElementName = "PERCCOMPROFISSIONALMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perccomprofissionalminimo
        {
            get { return  perccomprofissionalminimo; }
            set {  perccomprofissionalminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Coment�rio: 
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFIN
        /// Coment�rio: Indica o percentual de desconto a ser aplicado caso o tipo da pol�tica seja [F - Financeiro].
        /// </summary>
        private decimal percdescfin;
        [XmlElement(ElementName = "PERCDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescfin
        {
            get { return  percdescfin; }
            set {  percdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFORNEC
        /// Coment�rio: Indica o percentual de desconto concedido ao fornecedor. 
        /// </summary>
        private decimal percdescfornec;
        [XmlElement(ElementName = "PERCDESCFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescfornec
        {
            get { return  percdescfornec; }
            set {  percdescfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCMAX
        /// Coment�rio: Percentual m�ximo de desconto no pre�o � vista
        /// </summary>
        private decimal percdescmax;
        [XmlElement(ElementName = "PERCDESCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescmax
        {
            get { return  percdescmax; }
            set {  percdescmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMEXT
        /// Coment�rio: % Comissao vendedor externo.
        /// </summary>
        private decimal percomext;
        [XmlElement(ElementName = "PERCOMEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percomext
        {
            get { return  percomext; }
            set {  percomext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMINT
        /// Coment�rio: % Comissao vendedor interno.
        /// </summary>
        private decimal percommint;
        [XmlElement(ElementName = "PERCOMMINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percommint
        {
            get { return  percommint; }
            set {  percommint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMREP
        /// Coment�rio: % Comissao representante.
        /// </summary>
        private decimal percomrep;
        [XmlElement(ElementName = "PERCOMREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percomrep
        {
            get { return  percomrep; }
            set {  percomrep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFORNEC
        /// Coment�rio: Usado no PCVAR561, percentual de desconto fornecedor. 
        /// </summary>
        private decimal perdescfornec;
        [XmlElement(ElementName = "PERDESCFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescfornec
        {
            get { return  perdescfornec; }
            set {  perdescfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXIMOVENDA
        /// Coment�rio: PRAZO M�XIMO DE VENDA
        /// </summary>
        private decimal prazomaximovenda;
        [XmlElement(ElementName = "PRAZOMAXIMOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomaximovenda
        {
            get { return  prazomaximovenda; }
            set {  prazomaximovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFIXO
        /// Coment�rio: PRE�O DESCONTO
        /// </summary>
        private decimal precofixo;
        [XmlElement(ElementName = "PRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Precofixo
        {
            get { return  precofixo; }
            set {  precofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRIORITARIA
        /// Coment�rio: Indica se esta campanha � exclusiva e priorit�ria. Caso exista mais de uma priorit�ria ser� utilizada a que tiver o maior percentual de desconto.
        /// </summary>
        private string prioritaria;
        [XmlElement(ElementName = "PRIORITARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prioritaria
        {
            get { return  prioritaria; }
            set {  prioritaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRIORITARIAGERAL
        /// Coment�rio: For�ar Aplica��o desta Pol�tica sobre as Demais.
        /// </summary>
        private string prioritariageral;
        [XmlElement(ElementName = "PRIORITARIAGERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prioritariageral
        {
            get { return  prioritariageral; }
            set {  prioritariageral = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMAXIMAPEDIDO
        /// Coment�rio: Indica a quantidade m�xima do pedido.
        /// </summary>
        private decimal qtdemaximapedido;
        [XmlElement(ElementName = "QTDEMAXIMAPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdemaximapedido
        {
            get { return  qtdemaximapedido; }
            set {  qtdemaximapedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMAXIMAPOLITICA
        /// Coment�rio: Indica a quantidade m�xima da pol�tica.
        /// </summary>
        private decimal qtdemaximapolitica;
        [XmlElement(ElementName = "QTDEMAXIMAPOLITICA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdemaximapolitica
        {
            get { return  qtdemaximapolitica; }
            set {  qtdemaximapolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMINDESCONTO
        /// Coment�rio: QUANTIDADE MIN�MA PARA SER CONCEDIDO O DESCONTO
        /// </summary>
        private decimal qtdemindesconto;
        [XmlElement(ElementName = "QTDEMINDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtdemindesconto
        {
            get { return  qtdemindesconto; }
            set {  qtdemindesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFIM
        /// Coment�rio: Quantidade final para desconto
        /// </summary>
        private decimal qtfim;
        [XmlElement(ElementName = "QTFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtfim
        {
            get { return  qtfim; }
            set {  qtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTINI
        /// Coment�rio: Quantidade inicial para desconto
        /// </summary>
        private decimal qtini;
        [XmlElement(ElementName = "QTINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtini
        {
            get { return  qtini; }
            set {  qtini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUESTIONAUSOPRIORITARIA
        /// Coment�rio: Indica se ser� questionado o uso da pol�tica exclusiva e priorit�ria na inclus�o do pedido de venda.
        /// </summary>
        private string questionausoprioritaria;
        [XmlElement(ElementName = "QUESTIONAUSOPRIORITARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Questionausoprioritaria
        {
            get { return  questionausoprioritaria; }
            set {  questionausoprioritaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBCATEGORIA
        /// Coment�rio: SUBCATEGORIA DO PRODUTO
        /// </summary>
        private decimal subcategoria;
        [XmlElement(ElementName = "SUBCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Subcategoria
        {
            get { return  subcategoria; }
            set {  subcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: Indica se a pol�tica cadastrada utilizar� desconto [C - Comercial] ou [F - Financeiro].
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAPLICDESCONTOCB
        /// Coment�rio: "Tipo de aplica��o de desconto sobre Cesta B�sica/Kit": Indica se este desconto se aplica a itens vendidos em cesta b�sica/kit. 
        /// </summary>
        private string tipoaplicdescontocb;
        [XmlElement(ElementName = "TIPOAPLICDESCONTOCB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoaplicdescontocb
        {
            get { return  tipoaplicdescontocb; }
            set {  tipoaplicdescontocb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCARGA
        /// Coment�rio: Indica a restri��o de desconto por Tipo de Entrega de Pedidos Call Center.
        /// </summary>
        private string tipocarga;
        [XmlElement(ElementName = "TIPOCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocarga
        {
            get { return  tipocarga; }
            set {  tipocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFJ
        /// Coment�rio: Clientes (Pessoa F�sica, Pessoa Jur�dica, Ambas)
        /// </summary>
        private string tipofj;
        [XmlElement(ElementName = "TIPOFJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofj
        {
            get { return  tipofj; }
            set {  tipofj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFV
        /// Coment�rio: Tipo For�a de Venda
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
        /// Propriedade referente ao campo: TIPOGRUPOREST
        /// Coment�rio: Tipo do grupo de restri��o
        /// </summary>
        private string tipogruporest;
        [XmlElement(ElementName = "TIPOGRUPOREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipogruporest
        {
            get { return  tipogruporest; }
            set {  tipogruporest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: UF
        /// Coment�rio: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZADESCREDE
        /// Coment�rio: 
        /// </summary>
        private string utilizadescrede;
        [XmlElement(ElementName = "UTILIZADESCREDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadescrede
        {
            get { return  utilizadescrede; }
            set {  utilizadescrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRMAXIMO
        /// Coment�rio: Valor m�ximo para desconto
        /// </summary>
        private decimal vlrmaximo;
        [XmlElement(ElementName = "VLRMAXIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrmaximo
        {
            get { return  vlrmaximo; }
            set {  vlrmaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRMINIMO
        /// Coment�rio: Valor m�nimo para desconto
        /// </summary>
        private decimal vlrminimo;
        [XmlElement(ElementName = "VLRMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrminimo
        {
            get { return  vlrminimo; }
            set {  vlrminimo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDesconto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESCONTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDesconto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDesconto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDesconto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDesconto>(where);
        }

        #endregion
    }
}
