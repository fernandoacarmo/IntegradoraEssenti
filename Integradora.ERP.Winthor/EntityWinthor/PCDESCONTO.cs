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
        /// Comentário: "Alterar preço de tabela ?": Indica se o preço de tabela também será alterado. 
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
        /// Comentário: Desconto somente para o plano de pagamento.
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
        /// Comentário: Indica se é aplicado o desconto. Opções: S (Sim) e N (Não)
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
        /// Comentário: Aplica Desconto simples nacional.
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
        /// Comentário: Indica a área de atuação do RCA.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODCLICONV
        /// Comentário: CÓDIGO DO CLIENTE CONVENIADO
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
        /// Comentário: CÓDIGO COBRANÇA
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
        /// Comentário: Condição de venda
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o código da filial.
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
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: CÓDIGO DO FUNCIONÁRIO
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o código do grupo de desconto.
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
        /// Comentário: Código do grupo de restrição
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
        /// Comentário: Código identificador de politicas
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
        /// Comentário: Cód. Linha Produto
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
        /// Comentário: Código da Marca
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
        /// Comentário: 
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
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODCB
        /// Comentário: "Cesta Básica": Código de produto cesta básica na qual determinado produto, que é item da cesta, terá desconto. 
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
        /// Comentário: 
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
        /// Comentário: Cód. Promoção Med.
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
        /// Comentário: Código da Rede
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Determina se será utilizado a maior comissão por regiâo
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
        /// Comentário: Considera politica no calculo do giro (medicamentos)
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
        /// Comentário: Indica se credita RCA na venda com preço maior que política de desconto que altera base de cálculo de débito/crédito.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Se o desconto é somente para o fiscal de caixa
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
        /// Comentário: Indica política de desconto somente para certo orçamento. 
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
        /// Comentário: 
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
        /// Comentário: Número do Rolo
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
        /// Comentário: Observações de desconto
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
        /// Comentário: 
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
        /// Comentário: Valor minino de percentual de comissão de profissional permitido para o orçamento. 
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
        /// Comentário: 
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
        /// Comentário: Indica o percentual de desconto a ser aplicado caso o tipo da política seja [F - Financeiro].
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
        /// Comentário: Indica o percentual de desconto concedido ao fornecedor. 
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
        /// Comentário: Percentual máximo de desconto no preço à vista
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
        /// Comentário: % Comissao vendedor externo.
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
        /// Comentário: % Comissao vendedor interno.
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
        /// Comentário: % Comissao representante.
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
        /// Comentário: Usado no PCVAR561, percentual de desconto fornecedor. 
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
        /// Comentário: PRAZO MÁXIMO DE VENDA
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
        /// Comentário: PREÇO DESCONTO
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
        /// Comentário: Indica se esta campanha é exclusiva e prioritária. Caso exista mais de uma prioritária será utilizada a que tiver o maior percentual de desconto.
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
        /// Comentário: Forçar Aplicação desta Política sobre as Demais.
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
        /// Comentário: Indica a quantidade máxima do pedido.
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
        /// Comentário: Indica a quantidade máxima da política.
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
        /// Comentário: QUANTIDADE MINÍMA PARA SER CONCEDIDO O DESCONTO
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
        /// Comentário: Quantidade final para desconto
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
        /// Comentário: Quantidade inicial para desconto
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
        /// Comentário: Indica se será questionado o uso da política exclusiva e prioritária na inclusão do pedido de venda.
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
        /// Comentário: SUBCATEGORIA DO PRODUTO
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
        /// Comentário: Indica se a política cadastrada utilizará desconto [C - Comercial] ou [F - Financeiro].
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
        /// Comentário: "Tipo de aplicação de desconto sobre Cesta Básica/Kit": Indica se este desconto se aplica a itens vendidos em cesta básica/kit. 
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
        /// Comentário: Indica a restrição de desconto por Tipo de Entrega de Pedidos Call Center.
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
        /// Comentário: Clientes (Pessoa Física, Pessoa Jurídica, Ambas)
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
        /// Comentário: Tipo Força de Venda
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
        /// Comentário: Tipo do grupo de restrição
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
        /// Propriedade referente ao campo: UF
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Valor máximo para desconto
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
        /// Comentário: Valor mínimo para desconto
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDesconto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDesconto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
