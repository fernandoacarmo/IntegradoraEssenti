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
    /// Classe referente a tabela PCPedi
    /// </summary>
    [XmlType("PCPEDI")]
    public class PCPedi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ABASTECIDO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ALIQICMS1
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ALTERNATIVO
        /// Coment�rio: Alternativa da formula de tinta.
        /// </summary>
        private string alternativo;
        [XmlElement(ElementName = "ALTERNATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Alternativo
        {
            get { return  alternativo; }
            set {  alternativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTE
        /// Coment�rio: Nome do Ambiente
        /// </summary>
        private string ambiente;
        [XmlElement(ElementName = "AMBIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Ambiente
        {
            get { return  ambiente; }
            set {  ambiente = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: BASEDIFALIQUOTAS
        /// Coment�rio: Base da diferen�a entre al�quotas.
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
        /// Propriedade referente ao campo: BASEICST
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: BASEICST_ANT_RATEIO
        /// Coment�rio: Indica o valor da base de ST antes do rateio de frete e outras despesas.
        /// </summary>
        private decimal baseicst_ant_rateio;
        [XmlElement(ElementName = "BASEICST_ANT_RATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicst_Ant_Rateio
        {
            get { return  baseicst_ant_rateio; }
            set {  baseicst_ant_rateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEIPIECF
        /// Coment�rio: Base de c�lculo do IPI
        /// </summary>
        private decimal baseipiecf;
        [XmlElement(ElementName = "BASEIPIECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseipiecf
        {
            get { return  baseipiecf; }
            set {  baseipiecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BONIFIC
        /// Coment�rio: INFORMAR SE O PRODUTO � BONIFICA��O OU N�O
        /// </summary>
        private string bonific;
        [XmlElement(ElementName = "BONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bonific
        {
            get { return  bonific; }
            set {  bonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BRINDE
        /// Coment�rio: 
        /// </summary>
        private string brinde;
        [XmlElement(ElementName = "BRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Brinde
        {
            get { return  brinde; }
            set {  brinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBASE
        /// Coment�rio: C�digo da base vendida.
        /// </summary>
        private string codbase;
        [XmlElement(ElementName = "CODBASE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codbase
        {
            get { return  codbase; }
            set {  codbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCERTIFIC
        /// Coment�rio: C�digo do certificado.
        /// </summary>
        private decimal codcertific;
        [XmlElement(ElementName = "CODCERTIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcertific
        {
            get { return  codcertific; }
            set {  codcertific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODCOMBO
        /// Coment�rio: C�digo da pol�tica de combo.
        /// </summary>
        private decimal codcombo;
        [XmlElement(ElementName = "CODCOMBO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcombo
        {
            get { return  codcombo; }
            set {  codcombo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTRATO
        /// Coment�rio: Descri��o produto Danfe
        /// </summary>
        private decimal codcontrato;
        [XmlElement(ElementName = "CODCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcontrato
        {
            get { return  codcontrato; }
            set {  codcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEGUSTACAO
        /// Coment�rio: 
        /// </summary>
        private decimal coddegustacao;
        [XmlElement(ElementName = "CODDEGUSTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Coddegustacao
        {
            get { return  coddegustacao; }
            set {  coddegustacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCONTO
        /// Coment�rio: C�digo da pol�tica de desconto.
        /// </summary>
        private decimal coddesconto;
        [XmlElement(ElementName = "CODDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddesconto
        {
            get { return  coddesconto; }
            set {  coddesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODECF
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODEMITENTEITEMPEDIDO
        /// Coment�rio: C�digo emite item pedido
        /// </summary>
        private decimal codemitenteitempedido;
        [XmlElement(ElementName = "CODEMITENTEITEMPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemitenteitempedido
        {
            get { return  codemitenteitempedido; }
            set {  codemitenteitempedido = value; }
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
        /// Propriedade referente ao campo: CODFORMULA
        /// Coment�rio: C�digo da formula vendida.
        /// </summary>
        private string codformula;
        [XmlElement(ElementName = "CODFORMULA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codformula
        {
            get { return  codformula; }
            set {  codformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAJUSTEOS
        /// Coment�rio: Indica o c�digo do funcion�rio que efetuou ajuste de O.S.
        /// </summary>
        private decimal codfuncajusteos;
        [XmlElement(ElementName = "CODFUNCAJUSTEOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncajusteos
        {
            get { return  codfuncajusteos; }
            set {  codfuncajusteos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTERACAOOS
        /// Coment�rio: C�digo do funcion�rio que alterou a OS.
        /// </summary>
        private decimal codfuncalteracaoos;
        [XmlElement(ElementName = "CODFUNCALTERACAOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncalteracaoos
        {
            get { return  codfuncalteracaoos; }
            set {  codfuncalteracaoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTLOTE
        /// Coment�rio: Indica o funcion�rio respons�vel por alterar o lote do item do pedido
        /// </summary>
        private decimal codfuncaltlote;
        [XmlElement(ElementName = "CODFUNCALTLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncaltlote
        {
            get { return  codfuncaltlote; }
            set {  codfuncaltlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCCONF2
        /// Coment�rio: Indica o c�digo funcion�rio conferente 2.
        /// </summary>
        private decimal codfuncconf2;
        [XmlElement(ElementName = "CODFUNCCONF2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconf2
        {
            get { return  codfuncconf2; }
            set {  codfuncconf2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: C�digo do Funcion�rio que Incluiu o Item.
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
        /// Propriedade referente ao campo: CODFUNCLIBOS
        /// Coment�rio: Respons�vel por liberar O.S.
        /// </summary>
        private decimal codfunclibos;
        [XmlElement(ElementName = "CODFUNCLIBOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclibos
        {
            get { return  codfunclibos; }
            set {  codfunclibos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCPEND
        /// Coment�rio: Conferente de pend�ncia da O.S.
        /// </summary>
        private decimal codfuncpend;
        [XmlElement(ElementName = "CODFUNCPEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncpend
        {
            get { return  codfuncpend; }
            set {  codfuncpend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSEP
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncsep;
        [XmlElement(ElementName = "CODFUNCSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncsep
        {
            get { return  codfuncsep; }
            set {  codfuncsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Coment�rio: C�digo do Funcion�rio que Alterou o Item.
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
        /// Propriedade referente ao campo: CODICMTAB
        /// Coment�rio: C�digo ICM tributa��o tabela.
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
        /// Propriedade referente ao campo: CODIGOBRINDE
        /// Coment�rio: Indica o c�digo do brinde.
        /// </summary>
        private decimal codigobrinde;
        [XmlElement(ElementName = "CODIGOBRINDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codigobrinde
        {
            get { return  codigobrinde; }
            set {  codigobrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHAPRAZO
        /// Coment�rio: C�digo Linha Prazo
        /// </summary>
        private decimal codlinhaprazo;
        [XmlElement(ElementName = "CODLINHAPRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlinhaprazo
        {
            get { return  codlinhaprazo; }
            set {  codlinhaprazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDAESTRAGEIRA
        /// Coment�rio: Guarda c�digo da moeda estrageira no momento da venda
        /// </summary>
        private decimal codmoedaestrageira;
        [XmlElement(ElementName = "CODMOEDAESTRAGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmoedaestrageira
        {
            get { return  codmoedaestrageira; }
            set {  codmoedaestrageira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTNAOCOMPRA
        /// Coment�rio: C�digo do motivo de n�o compra.
        /// </summary>
        private decimal codmotnaocompra;
        [XmlElement(ElementName = "CODMOTNAOCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotnaocompra
        {
            get { return  codmotnaocompra; }
            set {  codmotnaocompra = value; }
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
        /// Propriedade referente ao campo: CODPRECOFIXO
        /// Coment�rio: C�digo pre�o fixo
        /// </summary>
        private decimal codprecofixo;
        [XmlElement(ElementName = "CODPRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Codprecofixo
        {
            get { return  codprecofixo; }
            set {  codprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODPRODCESTA
        /// Coment�rio: 
        /// </summary>
        private decimal codprodcesta;
        [XmlElement(ElementName = "CODPRODCESTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codprodcesta
        {
            get { return codprodcesta; }
            set { codprodcesta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAO
        /// Coment�rio: 
        /// </summary>
        private string codpromocao;
        [XmlElement(ElementName = "CODPROMOCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codpromocao
        {
            get { return  codpromocao; }
            set {  codpromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODVASILHAME
        /// Coment�rio: C�digo do Vasilhame associado ao Produto. 
        /// </summary>
        private decimal codvasilhame;
        [XmlElement(ElementName = "CODVASILHAME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codvasilhame
        {
            get { return  codvasilhame; }
            set {  codvasilhame = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Coment�rio: 
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCEDERMAIORCOMISSREG
        /// Coment�rio: Conceder maior Comiss�o das Faixas.
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
        /// Propriedade referente ao campo: CONDVENDA
        /// Coment�rio: Indica a condi��o de venda. 
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
        /// Coment�rio: Valor custo financeiro estoque.
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DATACONF
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataconf;
        [XmlElement(ElementName = "DATACONF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataconf
        {
            get { return  dataconf; }
            set {  dataconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACONFFIM
        /// Coment�rio: Fim de confer�ncia de O.S.
        /// </summary>
        private DateTime? dataconffim;
        [XmlElement(ElementName = "DATACONFFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataconffim
        {
            get { return  dataconffim; }
            set {  dataconffim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCPRECOFAB
        /// Coment�rio: Desconto Pre�o de F�brica
        /// </summary>
        private decimal descprecofab;
        [XmlElement(ElementName = "DESCPRECOFAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Descprecofab
        {
            get { return  descprecofab; }
            set {  descprecofab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAJUSTEOS
        /// Coment�rio: Indica a data de ajuste de O.S.
        /// </summary>
        private DateTime? dtajusteos;
        [XmlElement(ElementName = "DTAJUSTEOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtajusteos
        {
            get { return  dtajusteos; }
            set {  dtajusteos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAOOS
        /// Coment�rio: Data/Hora de altera��o da OS .
        /// </summary>
        private DateTime? dtalteracaoos;
        [XmlElement(ElementName = "DTALTERACAOOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracaoos
        {
            get { return  dtalteracaoos; }
            set {  dtalteracaoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Coment�rio: Data Entrega Futura - Encomenda.
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
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexportacaoservint;
        [XmlElement(ElementName = "DTEXPORTACAOSERVINT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaoservint
        {
            get { return  dtexportacaoservint; }
            set {  dtexportacaoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMPROMOLOTE
        /// Coment�rio: Data Fim da promo��o
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
        /// Propriedade referente ao campo: DTFINALPEND
        /// Coment�rio: Fim de pend�ncia de O.S.
        /// </summary>
        private DateTime? dtfinalpend;
        [XmlElement(ElementName = "DTFINALPEND", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalpend
        {
            get { return  dtfinalpend; }
            set {  dtfinalpend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALSEP
        /// Coment�rio: Fim de separa��o de O.S.
        /// </summary>
        private DateTime? dtfinalsep;
        [XmlElement(ElementName = "DTFINALSEP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalsep
        {
            get { return  dtfinalsep; }
            set {  dtfinalsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERACAOOS
        /// Coment�rio: Indica a data de gera��o da OS.
        /// </summary>
        private DateTime? dtgeracaoos;
        [XmlElement(ElementName = "DTGERACAOOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgeracaoos
        {
            get { return  dtgeracaoos; }
            set {  dtgeracaoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtimportacaoservprinc;
        [XmlElement(ElementName = "DTIMPORTACAOSERVPRINC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaoservprinc
        {
            get { return  dtimportacaoservprinc; }
            set {  dtimportacaoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIALPEND
        /// Coment�rio: Inicio de pend�ncia de O.S.
        /// </summary>
        private DateTime? dtinicialpend;
        [XmlElement(ElementName = "DTINICIALPEND", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicialpend
        {
            get { return  dtinicialpend; }
            set {  dtinicialpend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIALSEP
        /// Coment�rio: Inicio de separa��o de O.S.
        /// </summary>
        private DateTime? dtinicialsep;
        [XmlElement(ElementName = "DTINICIALSEP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicialsep
        {
            get { return  dtinicialsep; }
            set {  dtinicialsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOPROMOLOTE
        /// Coment�rio: Data Inicio da promo��o
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
        /// Propriedade referente ao campo: DTLANC
        /// Coment�rio: Data da inclus�o do Item no Pedido.
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBOS
        /// Coment�rio: Libera��o da O.S.
        /// </summary>
        private DateTime? dtlibos;
        [XmlElement(ElementName = "DTLIBOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlibos
        {
            get { return  dtlibos; }
            set {  dtlibos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTLALTER
        /// Coment�rio: Data daAltera��o do Item no Pedido.
        /// </summary>
        private DateTime? dtultlalter;
        [XmlElement(ElementName = "DTULTLALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultlalter
        {
            get { return  dtultlalter; }
            set {  dtultlalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal eancodprod;
        [XmlElement(ElementName = "EANCODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eancodprod
        {
            get { return  eancodprod; }
            set {  eancodprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Coment�rio: 
        /// </summary>
        private string exportadoservint;
        [XmlElement(ElementName = "EXPORTADOSERVINT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadoservint
        {
            get { return  exportadoservint; }
            set {  exportadoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMANEGOCIACAO
        /// Coment�rio: Forma de negocia��o
        /// </summary>
        private string formanegociacao;
        [XmlElement(ElementName = "FORMANEGOCIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Formanegociacao
        {
            get { return  formanegociacao; }
            set {  formanegociacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAGNRE_CNPJCLIENTE
        /// Coment�rio: Campo para definir se a GNRE ser� paga pelo cliente.
        /// </summary>
        private string geragnre_cnpjcliente;
        [XmlElement(ElementName = "GERAGNRE_CNPJCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geragnre_Cnpjcliente
        {
            get { return  geragnre_cnpjcliente; }
            set {  geragnre_cnpjcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRPREGRABRINDE
        /// Coment�rio: Grade brinde.
        /// </summary>
        private decimal grpregrabrinde;
        [XmlElement(ElementName = "GRPREGRABRINDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Grpregrabrinde
        {
            get { return  grpregrabrinde; }
            set {  grpregrabrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOFATURAMENTO
        /// Coment�rio: GRUPO FATURAMENTO
        /// </summary>
        private string grupofaturamento;
        [XmlElement(ElementName = "GRUPOFATURAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Grupofaturamento
        {
            get { return  grupofaturamento; }
            set {  grupofaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDPATRIMONIO
        /// Coment�rio: Identifica��o patrimonial.
        /// </summary>
        private string idpatrimonio;
        [XmlElement(ElementName = "IDPATRIMONIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Idpatrimonio
        {
            get { return  idpatrimonio; }
            set {  idpatrimonio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDVENDA
        /// Coment�rio: Identifica��o de Venda
        /// </summary>
        private decimal idvenda;
        [XmlElement(ElementName = "IDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Idvenda
        {
            get { return  idvenda; }
            set {  idvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private string importadoservprinc;
        [XmlElement(ElementName = "IMPORTADOSERVPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoservprinc
        {
            get { return  importadoservprinc; }
            set {  importadoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRIME
        /// Coment�rio: Indica se imprime o item ou n�o.
        /// </summary>
        private string imprime;
        [XmlElement(ElementName = "IMPRIME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprime
        {
            get { return  imprime; }
            set {  imprime = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: LETRACOMISS
        /// Coment�rio: C�digo classifica��o tipo comiss�o.
        /// </summary>
        private string letracomiss;
        [XmlElement(ElementName = "LETRACOMISS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Letracomiss
        {
            get { return  letracomiss; }
            set {  letracomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Coment�rio: 
        /// </summary>
        private string localizacao;
        [XmlElement(ElementName = "LOCALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Localizacao
        {
            get { return  localizacao; }
            set {  localizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAOOS
        /// Coment�rio: Localiza��o de carrinhos da O.S.
        /// </summary>
        private string localizacaoos;
        [XmlElement(ElementName = "LOCALIZACAOOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Localizacaoos
        {
            get { return  localizacaoos; }
            set {  localizacaoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVIMENTACONTACORRENTERCA
        /// Coment�rio: Movimenta conta corrente RCA.
        /// </summary>
        private string movimentacontacorrenterca;
        [XmlElement(ElementName = "MOVIMENTACONTACORRENTERCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Movimentacontacorrenterca
        {
            get { return  movimentacontacorrenterca; }
            set {  movimentacontacorrenterca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NEGOCIACAOPOSTERIOR
        /// Coment�rio: Negocia��o Posterior
        /// </summary>
        private string negociacaoposterior;
        [XmlElement(ElementName = "NEGOCIACAOPOSTERIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Negociacaoposterior
        {
            get { return  negociacaoposterior; }
            set {  negociacaoposterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECONCORRENTE
        /// Coment�rio: Nome do concorrente.
        /// </summary>
        private string nomeconcorrente;
        [XmlElement(ElementName = "NOMECONCORRENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nomeconcorrente
        {
            get { return  nomeconcorrente; }
            set {  nomeconcorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAPLIC
        /// Coment�rio: 
        /// </summary>
        private decimal numaplic;
        [XmlElement(ElementName = "NUMAPLIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numaplic
        {
            get { return  numaplic; }
            set {  numaplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: Numero da caixa
        /// </summary>
        private string numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMCARAUX
        /// Coment�rio: 
        /// </summary>
        private decimal numcaraux;
        [XmlElement(ElementName = "NUMCARAUX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcaraux
        {
            get { return  numcaraux; }
            set {  numcaraux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONFERENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal numconferencia;
        [XmlElement(ElementName = "NUMCONFERENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numconferencia
        {
            get { return  numconferencia; }
            set {  numconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERORECOPI
        /// Coment�rio: N�mero sujeito ao controle de papel imune
        /// </summary>
        private string numerorecopi;
        [XmlElement(ElementName = "NUMERORECOPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numerorecopi
        {
            get { return  numerorecopi; }
            set {  numerorecopi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMETIQUETA
        /// Coment�rio: Indica o n�mero da etiqueta do produto quando definido como frios.
        /// </summary>
        private decimal numetiqueta;
        [XmlElement(ElementName = "NUMETIQUETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numetiqueta
        {
            get { return  numetiqueta; }
            set {  numetiqueta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITEMPED
        /// Coment�rio: N�MERO DO ITEM NO XML DA NOTA FISCAL.
        /// </summary>
        private decimal numitemped;
        [XmlElement(ElementName = "NUMITEMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numitemped
        {
            get { return  numitemped; }
            set {  numitemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLISTA
        /// Coment�rio: N�mero da Lista de Presente
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
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: Indica o n�mero do lote ao qual o produto pertence.
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Coment�rio: Indica o numero da ordem de produ��o.
        /// </summary>
        private decimal numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numop
        {
            get { return  numop; }
            set {  numop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: N�mero da O.S.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOSORIGEM
        /// Coment�rio: N�mero de OS Original.
        /// </summary>
        private decimal numosorigem;
        [XmlElement(ElementName = "NUMOSORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Numosorigem
        {
            get { return  numosorigem; }
            set {  numosorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMRECOPI
        /// Coment�rio: N�mero sujeito ao controle de papel imune
        /// </summary>
        private decimal numrecopi;
        [XmlElement(ElementName = "NUMRECOPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numrecopi
        {
            get { return  numrecopi; }
            set {  numrecopi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMSEQITEMCONTRATO
        /// Coment�rio: N�mero da Sequ�ncia do Item no Contrato
        /// </summary>
        private decimal numseqitemcontrato;
        [XmlElement(ElementName = "NUMSEQITEMCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqitemcontrato
        {
            get { return  numseqitemcontrato; }
            set {  numseqitemcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTIRA
        /// Coment�rio: Indica o o n�mero de tira.
        /// </summary>
        private decimal numtira;
        [XmlElement(ElementName = "NUMTIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtira
        {
            get { return  numtira; }
            set {  numtira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMVERBAREBCMV
        /// Coment�rio: 
        /// </summary>
        private decimal numverbarebcmv;
        [XmlElement(ElementName = "NUMVERBAREBCMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numverbarebcmv
        {
            get { return  numverbarebcmv; }
            set {  numverbarebcmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASOS
        /// Coment�rio: Vias emitidas da O.S.
        /// </summary>
        private decimal numviasos;
        [XmlElement(ElementName = "NUMVIASOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numviasos
        {
            get { return  numviasos; }
            set {  numviasos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLUMESCONFERENCIA
        /// Coment�rio: Indica a quantidade de volumes confereido de itens.
        /// </summary>
        private decimal numvolumesconferencia;
        [XmlElement(ElementName = "NUMVOLUMESCONFERENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvolumesconferencia
        {
            get { return  numvolumesconferencia; }
            set {  numvolumesconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMDEPRECO
        /// Coment�rio: 
        /// </summary>
        private string origemdepreco;
        [XmlElement(ElementName = "ORIGEMDEPRECO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Origemdepreco
        {
            get { return  origemdepreco; }
            set {  origemdepreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMST
        /// Coment�rio: Origem do c�lculo de ST
        /// </summary>
        private string origemst;
        [XmlElement(ElementName = "ORIGEMST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemst
        {
            get { return  origemst; }
            set {  origemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPAGIRO
        /// Coment�rio: Participa Giro
        /// </summary>
        private string participagiro;
        [XmlElement(ElementName = "PARTICIPAGIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Participagiro
        {
            get { return  participagiro; }
            set {  participagiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAUTA
        /// Coment�rio: Valor de pauta.
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
        /// Coment�rio: Pre�o base RCA.
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
        /// Propriedade referente ao campo: PBONIFIC
        /// Coment�rio: 
        /// </summary>
        private decimal pbonific;
        [XmlElement(ElementName = "PBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pbonific
        {
            get { return  pbonific; }
            set {  pbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBONIFIC
        /// Coment�rio: 
        /// </summary>
        private decimal perbonific;
        [XmlElement(ElementName = "PERBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perbonific
        {
            get { return  perbonific; }
            set {  perbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAGREGADORST
        /// Coment�rio: 
        /// </summary>
        private decimal percagregadorst;
        [XmlElement(ElementName = "PERCAGREGADORST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percagregadorst
        {
            get { return  percagregadorst; }
            set {  percagregadorst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERED
        /// Coment�rio: 
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
        /// Coment�rio: Percentual da base reduzida ST.
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
        /// Coment�rio: Percentual base reduzida ST cliente fonte.
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
        /// Propriedade referente ao campo: PERCDESCABATIMENTO
        /// Coment�rio: Percentual de desconto referente ao abatimento
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
        /// Propriedade referente ao campo: PERCDESCCOFINS
        /// Coment�rio: Indica o % de desconto COFINS aplicado na venda.
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
        /// Propriedade referente ao campo: PERCDESCINDUSTRIA
        /// Coment�rio: % desconto industria
        /// </summary>
        private decimal percdescindustria;
        [XmlElement(ElementName = "PERCDESCINDUSTRIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdescindustria
        {
            get { return  percdescindustria; }
            set {  percdescindustria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCPIS
        /// Coment�rio: Indica o % de desconto PIS aplicado na venda.
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
        /// Coment�rio: Percentual de diferen�a de tributa��o.
        /// </summary>
        private decimal percdifaliquotas;
        [XmlElement(ElementName = "PERCDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdifaliquotas
        {
            get { return  percdifaliquotas; }
            set {  percdifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Coment�rio: 
        /// </summary>
        private decimal percicm;
        [XmlElement(ElementName = "PERCICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicm
        {
            get { return  percicm; }
            set {  percicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PERCIPIECF
        /// Coment�rio: Percentual de IPI
        /// </summary>
        private decimal percipiecf;
        [XmlElement(ElementName = "PERCIPIECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percipiecf
        {
            get { return  percipiecf; }
            set {  percipiecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPIOUTRAS
        /// Coment�rio: Esse atributo serve para armazenar o valor do ipi para devolu��o simbolica.
        /// </summary>
        private decimal percipioutras;
        [XmlElement(ElementName = "PERCIPIOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percipioutras
        {
            get { return  percipioutras; }
            set {  percipioutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCISS
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PERCOM
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PERCOMPROF
        /// Coment�rio: Percentual comiss�o profissional.
        /// </summary>
        private decimal percomprof;
        [XmlElement(ElementName = "PERCOMPROF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percomprof
        {
            get { return  percomprof; }
            set {  percomprof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMSUP
        /// Coment�rio: 
        /// </summary>
        private decimal percomsup;
        [XmlElement(ElementName = "PERCOMSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomsup
        {
            get { return  percomsup; }
            set {  percomsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMTAB
        /// Coment�rio: 
        /// </summary>
        private decimal percomtab;
        [XmlElement(ElementName = "PERCOMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomtab
        {
            get { return  percomtab; }
            set {  percomtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM2
        /// Coment�rio: 
        /// </summary>
        private decimal percom2;
        [XmlElement(ElementName = "PERCOM2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom2
        {
            get { return  percom2; }
            set {  percom2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM3
        /// Coment�rio: 
        /// </summary>
        private decimal percom3;
        [XmlElement(ElementName = "PERCOM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom3
        {
            get { return  percom3; }
            set {  percom3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM4
        /// Coment�rio: Indica a comiss�o do terceiro profissional.
        /// </summary>
        private decimal percom4;
        [XmlElement(ElementName = "PERCOM4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom4
        {
            get { return  percom4; }
            set {  percom4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTRIBUTOS
        /// Coment�rio: Percentual a ser calculado sobre o item.
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
        /// Propriedade referente ao campo: PERCVENDA
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCAVISTA
        /// Coment�rio: Percentual de desconta � vista
        /// </summary>
        private decimal perdescavista;
        [XmlElement(ElementName = "PERDESCAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescavista
        {
            get { return  perdescavista; }
            set {  perdescavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCBOLETO
        /// Coment�rio: Percentual do Desconto do Produto que ser� concedido no Boleto
        /// </summary>
        private decimal perdescboleto;
        [XmlElement(ElementName = "PERDESCBOLETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescboleto
        {
            get { return  perdescboleto; }
            set {  perdescboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCOM
        /// Coment�rio: 
        /// </summary>
        private decimal perdesccom;
        [XmlElement(ElementName = "PERDESCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdesccom
        {
            get { return  perdesccom; }
            set {  perdesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCUSTO
        /// Coment�rio: Percentual desconto custo.
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
        /// Propriedade referente ao campo: PERDESCFIMCOMISS
        /// Coment�rio: Perc. Desc. Final Faixa Comiss�o.
        /// </summary>
        private decimal perdescfimcomiss;
        [XmlElement(ElementName = "PERDESCFIMCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdescfimcomiss
        {
            get { return  perdescfimcomiss; }
            set {  perdescfimcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFIN
        /// Coment�rio: 
        /// </summary>
        private decimal perdescfin;
        [XmlElement(ElementName = "PERDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdescfin
        {
            get { return  perdescfin; }
            set {  perdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFLEX
        /// Coment�rio: 
        /// </summary>
        private decimal perdescflex;
        [XmlElement(ElementName = "PERDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescflex
        {
            get { return  perdescflex; }
            set {  perdescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFOB
        /// Coment�rio: Percentual de Desconto FOB.
        /// </summary>
        private decimal perdescfob;
        [XmlElement(ElementName = "PERDESCFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescfob
        {
            get { return  perdescfob; }
            set {  perdescfob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCINICOMISS
        /// Coment�rio: Perc. Desc. Inicial Faixa Comiss�o.
        /// </summary>
        private decimal perdescinicomiss;
        [XmlElement(ElementName = "PERDESCINICOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdescinicomiss
        {
            get { return  perdescinicomiss; }
            set {  perdescinicomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCISENTOICMS
        /// Coment�rio: Percentual desconto isento ICMS.
        /// </summary>
        private decimal perdescisentoicms;
        [XmlElement(ElementName = "PERDESCISENTOICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perdescisentoicms
        {
            get { return  perdescisentoicms; }
            set {  perdescisentoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCNEGOCIADO
        /// Coment�rio: Percentudal de desconto negociado
        /// </summary>
        private decimal perdescnegociado;
        [XmlElement(ElementName = "PERDESCNEGOCIADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescnegociado
        {
            get { return  perdescnegociado; }
            set {  perdescnegociado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCPAUTA
        /// Coment�rio: PERCENTUAL DE DESCONTO UTILIZADO NA PAUTA
        /// </summary>
        private decimal perdescpauta;
        [XmlElement(ElementName = "PERDESCPAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescpauta
        {
            get { return  perdescpauta; }
            set {  perdescpauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCPOLITICA
        /// Coment�rio: Percentual de desconto aplicado em pol�tica de desconto por valor de pedido. 
        /// </summary>
        private decimal perdescpolitica;
        [XmlElement(ElementName = "PERDESCPOLITICA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdescpolitica
        {
            get { return  perdescpolitica; }
            set {  perdescpolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCTAB
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PERREDCOMISS
        /// Coment�rio: Percentual de redu��o comiss�o.
        /// </summary>
        private decimal perredcomiss;
        [XmlElement(ElementName = "PERREDCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perredcomiss
        {
            get { return  perredcomiss; }
            set {  perredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERREDCOMISSSUP
        /// Coment�rio: 
        /// </summary>
        private decimal perredcomisssup;
        [XmlElement(ElementName = "PERREDCOMISSSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perredcomisssup
        {
            get { return  perredcomisssup; }
            set {  perredcomisssup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Coment�rio: 
        /// </summary>
        private decimal pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POLITICAPRIORITARIA
        /// Coment�rio: Indica se a pol�tica priorit�ria foi utilizada por item.
        /// </summary>
        private string politicaprioritaria;
        [XmlElement(ElementName = "POLITICAPRIORITARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Politicaprioritaria
        {
            get { return  politicaprioritaria; }
            set {  politicaprioritaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORIGINAL
        /// Coment�rio: 
        /// </summary>
        private decimal poriginal;
        [XmlElement(ElementName = "PORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Poriginal
        {
            get { return  poriginal; }
            set {  poriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PRAZO
        /// Coment�rio: Prazo do concorrente.
        /// </summary>
        private string prazo;
        [XmlElement(ElementName = "PRAZO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Prazo
        {
            get { return  prazo; }
            set {  prazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PRECO
        /// Coment�rio: Pre�o do concorrente.
        /// </summary>
        private decimal preco;
        [XmlElement(ElementName = "PRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Preco
        {
            get { return  preco; }
            set {  preco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFVBRUTO
        /// Coment�rio: Pre�o bruto/Negociado FV.
        /// </summary>
        private decimal precofvbruto;
        [XmlElement(ElementName = "PRECOFVBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precofvbruto
        {
            get { return  precofvbruto; }
            set {  precofvbruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUM
        /// Coment�rio: Pre�o m�ximo consumidor
        /// </summary>
        private decimal precomaxconsum;
        [XmlElement(ElementName = "PRECOMAXCONSUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precomaxconsum
        {
            get { return  precomaxconsum; }
            set {  precomaxconsum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODDESCRICAOCONTRATO
        /// Coment�rio: Indica a descri��o do produto no contrato.
        /// </summary>
        private string proddescricaocontrato;
        [XmlElement(ElementName = "PRODDESCRICAOCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Proddescricaocontrato
        {
            get { return  proddescricaocontrato; }
            set {  proddescricaocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODDESCRICAODANFE
        /// Coment�rio: Descri��o produto Danfe
        /// </summary>
        private string proddescricaodanfe;
        [XmlElement(ElementName = "PRODDESCRICAODANFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Proddescricaodanfe
        {
            get { return  proddescricaodanfe; }
            set {  proddescricaodanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PTABELAAUTPECAS
        /// Coment�rio: Pre�o de tabela para auto pe�as.
        /// </summary>
        private decimal ptabelaautpecas;
        [XmlElement(ElementName = "PTABELAAUTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaautpecas
        {
            get { return  ptabelaautpecas; }
            set {  ptabelaautpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PVENDAANTERIOR
        /// Coment�rio: Pre�o anterior a aplica��o de pol�tica de desconto por valor de pedido. 
        /// </summary>
        private decimal pvendaanterior;
        [XmlElement(ElementName = "PVENDAANTERIOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaanterior
        {
            get { return  pvendaanterior; }
            set {  pvendaanterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDABASE
        /// Coment�rio: 
        /// </summary>
        private decimal pvendabase;
        [XmlElement(ElementName = "PVENDABASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendabase
        {
            get { return  pvendabase; }
            set {  pvendabase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAEMB
        /// Coment�rio: 
        /// </summary>
        private decimal pvendaemb;
        [XmlElement(ElementName = "PVENDAEMB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendaemb
        {
            get { return  pvendaemb; }
            set {  pvendaemb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAEMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal pvendaembalagem;
        [XmlElement(ElementName = "PVENDAEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaembalagem
        {
            get { return  pvendaembalagem; }
            set {  pvendaembalagem = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: PVENDA1
        /// Coment�rio: Valor do pre�o a vista, para realiza��o de c�lculo de comiss�o sobre pre�o a vista. 
        /// </summary>
        private decimal pvenda1;
        [XmlElement(ElementName = "PVENDA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda1
        {
            get { return  pvenda1; }
            set {  pvenda1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: QTAPANHA
        /// Coment�rio: Usado na separa��o via Coletor de Dados na rotina 947. 
        /// </summary>
        private decimal qtapanha;
        [XmlElement(ElementName = "QTAPANHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtapanha
        {
            get { return  qtapanha; }
            set {  qtapanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCX
        /// Coment�rio: 
        /// </summary>
        private decimal qtcx;
        [XmlElement(ElementName = "QTCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtcx
        {
            get { return  qtcx; }
            set {  qtcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIASENTREGAITEM
        /// Coment�rio: Qtde de dias para entregar o produto sem estoque
        /// </summary>
        private decimal qtdiasentregaitem;
        [XmlElement(ElementName = "QTDIASENTREGAITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtdiasentregaitem
        {
            get { return  qtdiasentregaitem; }
            set {  qtdiasentregaitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal qtembalagem;
        [XmlElement(ElementName = "QTEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtembalagem
        {
            get { return  qtembalagem; }
            set {  qtembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFALTA
        /// Coment�rio: 
        /// </summary>
        private decimal qtfalta;
        [XmlElement(ElementName = "QTFALTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtfalta
        {
            get { return  qtfalta; }
            set {  qtfalta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTIMEDIATA
        /// Coment�rio: Quantidade de Entrega Imediata.
        /// </summary>
        private decimal qtimediata;
        [XmlElement(ElementName = "QTIMEDIATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtimediata
        {
            get { return  qtimediata; }
            set {  qtimediata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLITRAGEM
        /// Coment�rio: Quantidade em litragem do produto
        /// </summary>
        private decimal qtlitragem;
        [XmlElement(ElementName = "QTLITRAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtlitragem
        {
            get { return  qtlitragem; }
            set {  qtlitragem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLOCALIZADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtlocalizada;
        [XmlElement(ElementName = "QTLOCALIZADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtlocalizada
        {
            get { return  qtlocalizada; }
            set {  qtlocalizada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNAOCOMPRA
        /// Coment�rio: Quantidade n�o comprada.
        /// </summary>
        private decimal qtnaocompra;
        [XmlElement(ElementName = "QTNAOCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtnaocompra
        {
            get { return  qtnaocompra; }
            set {  qtnaocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTORIG
        /// Coment�rio: 
        /// </summary>
        private decimal qtorig;
        [XmlElement(ElementName = "QTORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtorig
        {
            get { return  qtorig; }
            set {  qtorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTORIGINAL
        /// Coment�rio: 
        /// </summary>
        private decimal qtoriginal;
        [XmlElement(ElementName = "QTORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtoriginal
        {
            get { return  qtoriginal; }
            set {  qtoriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECAS
        /// Coment�rio: 
        /// </summary>
        private decimal qtpecas;
        [XmlElement(ElementName = "QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtpecas
        {
            get { return  qtpecas; }
            set {  qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDOS
        /// Coment�rio: Quantidade pendente de itens da O.S.
        /// </summary>
        private decimal qtpendos;
        [XmlElement(ElementName = "QTPENDOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtpendos
        {
            get { return  qtpendos; }
            set {  qtpendos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERVANT
        /// Coment�rio: Quantidade reservada do item
        /// </summary>
        private decimal qtreservant;
        [XmlElement(ElementName = "QTRESERVANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtreservant
        {
            get { return  qtreservant; }
            set {  qtreservant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEPARADA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: QT_SEPARADAMANIF
        /// Coment�rio: Quantidade separada
        /// </summary>
        private decimal qt_separadamanif;
        [XmlElement(ElementName = "QT_SEPARADAMANIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt_Separadamanif
        {
            get { return  qt_separadamanif; }
            set {  qt_separadamanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEPARARCX
        /// Coment�rio: 
        /// </summary>
        private decimal qtsepararcx;
        [XmlElement(ElementName = "QTSEPARARCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtsepararcx
        {
            get { return  qtsepararcx; }
            set {  qtsepararcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEPARARUN
        /// Coment�rio: 
        /// </summary>
        private decimal qtsepararun;
        [XmlElement(ElementName = "QTSEPARARUN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtsepararun
        {
            get { return  qtsepararun; }
            set {  qtsepararun = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUN
        /// Coment�rio: Quantidade em unidades de venda
        /// </summary>
        private decimal qtun;
        [XmlElement(ElementName = "QTUN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtun
        {
            get { return  qtun; }
            set {  qtun = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITCX
        /// Coment�rio: Quantidade unit�ria por caixa. Rotina 316. Quantidade, Unidade Master. 
        /// </summary>
        private decimal? qtunitcx;
        [XmlElement(ElementName = "QTUNITCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Qtunitcx
        {
            get { return  qtunitcx; }
            set {  qtunitcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITEMB
        /// Coment�rio: Indica a quantidade uitaria da embalagem.
        /// </summary>
        private decimal qtunitemb;
        [XmlElement(ElementName = "QTUNITEMB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtunitemb
        {
            get { return  qtunitemb; }
            set {  qtunitemb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAEMB
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendaemb;
        [XmlElement(ElementName = "QTVENDAEMB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtvendaemb
        {
            get { return  qtvendaemb; }
            set {  qtvendaemb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFCOR
        /// Coment�rio: Referencia cor do produto.
        /// </summary>
        private string refcor;
        [XmlElement(ElementName = "REFCOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Refcor
        {
            get { return  refcor; }
            set {  refcor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Coment�rio: Indica o nome da rotina.
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: C�digo da Rotina que sofreu altera��o.
        /// </summary>
        private decimal rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANCBRINDE
        /// Coment�rio: Rotina Lan�amento de Brinde
        /// </summary>
        private decimal rotinalancbrinde;
        [XmlElement(ElementName = "ROTINALANCBRINDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Rotinalancbrinde
        {
            get { return  rotinalancbrinde; }
            set {  rotinalancbrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANCULTALT
        /// Coment�rio: Rotina que gravou o registro
        /// </summary>
        private string rotinalancultalt;
        [XmlElement(ElementName = "ROTINALANCULTALT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinalancultalt
        {
            get { return  rotinalancultalt; }
            set {  rotinalancultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINAULTLALTER
        /// Coment�rio: C�digo da Rotina que sofreu altera��o.
        /// </summary>
        private decimal rotinaultlalter;
        [XmlElement(ElementName = "ROTINAULTLALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Rotinaultlalter
        {
            get { return  rotinaultlalter; }
            set {  rotinaultlalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RP_IMEDIATA
        /// Coment�rio: Retirada Posterior Imediata
        /// </summary>
        private string rp_imediata;
        [XmlElement(ElementName = "RP_IMEDIATA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rp_Imediata
        {
            get { return  rp_imediata; }
            set {  rp_imediata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLAQUALIDADE
        /// Coment�rio: Sigla da qualidade da tinta.
        /// </summary>
        private string siglaqualidade;
        [XmlElement(ElementName = "SIGLAQUALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Siglaqualidade
        {
            get { return  siglaqualidade; }
            set {  siglaqualidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOOS
        /// Coment�rio: Situa��o da O.S.
        /// </summary>
        private decimal situacaoos;
        [XmlElement(ElementName = "SITUACAOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Situacaoos
        {
            get { return  situacaoos; }
            set {  situacaoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Coment�rio: Valor do ST.
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
        /// Propriedade referente ao campo: ST_ANT_RATEIO
        /// Coment�rio: Indica o valor do ST antes do rateio de frete e outras despesas.
        /// </summary>
        private decimal st_ant_rateio;
        [XmlElement(ElementName = "ST_ANT_RATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal St_Ant_Rateio
        {
            get { return  st_ant_rateio; }
            set {  st_ant_rateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSSUCATA
        /// Coment�rio: Status Sucata
        /// </summary>
        private decimal statussucata;
        [XmlElement(ElementName = "STATUSSUCATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Statussucata
        {
            get { return  statussucata; }
            set {  statussucata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STCLIENTEGNRE
        /// Coment�rio: Valor ST para cliente com GNRE.
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
        /// Propriedade referente ao campo: ST_DIF_RATEIO
        /// Coment�rio: Indica o valor da diferen�a de ST antes do rateio de frete e outras despesas.
        /// </summary>
        private decimal st_dif_rateio;
        [XmlElement(ElementName = "ST_DIF_RATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal St_Dif_Rateio
        {
            get { return  st_dif_rateio; }
            set {  st_dif_rateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STPBASERCA
        /// Coment�rio: Valor do ST na base RCA
        /// </summary>
        private decimal stpbaserca;
        [XmlElement(ElementName = "STPBASERCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stpbaserca
        {
            get { return  stpbaserca; }
            set {  stpbaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STPTABELA
        /// Coment�rio: Valor do ST no pre�o de  Tabela
        /// </summary>
        private decimal stptabela;
        [XmlElement(ElementName = "STPTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stptabela
        {
            get { return  stptabela; }
            set {  stptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUGESTAO
        /// Coment�rio: Informa se o item foi sugest�o de venda
        /// </summary>
        private string sugestao;
        [XmlElement(ElementName = "SUGESTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sugestao
        {
            get { return  sugestao; }
            set {  sugestao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXACASOMOEDAREAL
        /// Coment�rio: Taxa caso a moeda escolhida seja o real.
        /// </summary>
        private decimal taxacasomoedareal;
        [XmlElement(ElementName = "TAXACASOMOEDAREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Taxacasomoedareal
        {
            get { return  taxacasomoedareal; }
            set {  taxacasomoedareal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCULOST
        /// Coment�rio: Indica a forma que o ST foi calculado.
        /// </summary>
        private string tipocalculost;
        [XmlElement(ElementName = "TIPOCALCULOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalculost
        {
            get { return  tipocalculost; }
            set {  tipocalculost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCAPLICADO
        /// Coment�rio: Tipo desconto aplicado.
        /// </summary>
        private string tipodescaplicado;
        [XmlElement(ElementName = "TIPODESCAPLICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipodescaplicado
        {
            get { return  tipodescaplicado; }
            set {  tipodescaplicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENTREGA
        /// Coment�rio: Tipo de entrega do produto. 
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
        /// Propriedade referente ao campo: TIPOPESO
        /// Coment�rio: 
        /// </summary>
        private string tipopeso;
        [XmlElement(ElementName = "TIPOPESO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopeso
        {
            get { return  tipopeso; }
            set {  tipopeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSEPARACAO
        /// Coment�rio: Indica o tipo de separa��o.
        /// </summary>
        private string tiposeparacao;
        [XmlElement(ElementName = "TIPOSEPARACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposeparacao
        {
            get { return  tiposeparacao; }
            set {  tiposeparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALIZADORALIQUOTA
        /// Coment�rio: Totalizador al�quotas.
        /// </summary>
        private string totalizadoraliquota;
        [XmlElement(ElementName = "TOTALIZADORALIQUOTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Totalizadoraliquota
        {
            get { return  totalizadoraliquota; }
            set {  totalizadoraliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRUNCARITEM
        /// Coment�rio: Para corre��o de diferen�as de truncamento/arredondamento no subtotal do item das impressoras fiscais. 
        /// </summary>
        private string truncaritem;
        [XmlElement(ElementName = "TRUNCARITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Truncaritem
        {
            get { return  truncaritem; }
            set {  truncaritem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TVBONIF
        /// Coment�rio: Indica que tipo de venda ser� o brinde.
        /// </summary>
        private decimal tvbonif;
        [XmlElement(ElementName = "TVBONIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tvbonif
        {
            get { return  tvbonif; }
            set {  tvbonif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: UNIDADE
        /// Coment�rio: Unidade da f�rmula de tinta
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADEBCREDRCABRIND
        /// Coment�rio: Gerar d�bito ou cr�dito para o RCA no pedido brinde.
        /// </summary>
        private string usadebcredrcabrind;
        [XmlElement(ElementName = "USADEBCREDRCABRIND", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadebcredrcabrind
        {
            get { return  usadebcredrcabrind; }
            set {  usadebcredrcabrind = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAUNIDADEMASTER
        /// Coment�rio: Indica se o produto foi gravado para respeitar a quantidade master ou n�o.
        /// </summary>
        private string usaunidademaster;
        [XmlElement(ElementName = "USAUNIDADEMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaunidademaster
        {
            get { return  usaunidademaster; }
            set {  usaunidademaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESCRODAPE
        /// Coment�rio: Valor acrescimo rodap�.
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
        /// Propriedade referente ao campo: VLACRESFRETEKG
        /// Coment�rio: Valor de acr�scimo Frete (kG)
        /// </summary>
        private decimal vlacresfretekg;
        [XmlElement(ElementName = "VLACRESFRETEKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlacresfretekg
        {
            get { return  vlacresfretekg; }
            set {  vlacresfretekg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Coment�rio: 
        /// </summary>
        private decimal vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOCONT
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLDESCABATIMENTO
        /// Coment�rio: Valor do desconto referente ao abatimento.
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
        /// Propriedade referente ao campo: VLDESCBOLETO
        /// Coment�rio: Valor do Desconto do Boleto
        /// </summary>
        private decimal vldescboleto;
        [XmlElement(ElementName = "VLDESCBOLETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescboleto
        {
            get { return  vldescboleto; }
            set {  vldescboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCCOM
        /// Coment�rio: 
        /// </summary>
        private decimal vldesccom;
        [XmlElement(ElementName = "VLDESCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldesccom
        {
            get { return  vldesccom; }
            set {  vldesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCCUSTOCMV
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLDESCFIN
        /// Coment�rio: 
        /// </summary>
        private decimal vldescfin;
        [XmlElement(ElementName = "VLDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescfin
        {
            get { return  vldescfin; }
            set {  vldescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCFLEX
        /// Coment�rio: 
        /// </summary>
        private decimal vldescflex;
        [XmlElement(ElementName = "VLDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescflex
        {
            get { return  vldescflex; }
            set {  vldescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCFORNEC
        /// Coment�rio: 
        /// </summary>
        private decimal vldescfornec;
        [XmlElement(ElementName = "VLDESCFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescfornec
        {
            get { return  vldescfornec; }
            set {  vldescfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCICMISENCAO
        /// Coment�rio: Valor descontro ICMS isento.
        /// </summary>
        private decimal vldescicmisencao;
        [XmlElement(ElementName = "VLDESCICMISENCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescicmisencao
        {
            get { return  vldescicmisencao; }
            set {  vldescicmisencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCPISSUFRAMA
        /// Coment�rio: 
        /// </summary>
        private decimal vldescpissuframa;
        [XmlElement(ElementName = "VLDESCPISSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescpissuframa
        {
            get { return  vldescpissuframa; }
            set {  vldescpissuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCREDUCAOCOFINS
        /// Coment�rio: Indica valor de desconto COFINS aplicado na venda.
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
        /// Coment�rio: Indica o valor de desconto PIS aplicado na venda..
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
        /// Propriedade referente ao campo: VLDESCREPASSE
        /// Coment�rio: Valor desconto repasse.
        /// </summary>
        private decimal vldescrepasse;
        [XmlElement(ElementName = "VLDESCREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldescrepasse
        {
            get { return  vldescrepasse; }
            set {  vldescrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCRODAPE
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLDESCSOCIOTORCEDOR
        /// Coment�rio: Desconto S�scio Torcedor
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
        /// Propriedade referente ao campo: VLDESCSUFRAMA
        /// Coment�rio: 
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
        /// Coment�rio: Valor da diferen�a de aliquotas.
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
        /// Propriedade referente ao campo: VLFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE_RATEIO
        /// Coment�rio: Indica o valor do frete no raterio.
        /// </summary>
        private decimal vlfrete_rateio;
        [XmlElement(ElementName = "VLFRETE_RATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete_Rateio
        {
            get { return  vlfrete_rateio; }
            set {  vlfrete_rateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLIPIECF
        /// Coment�rio: Valor do IPI
        /// </summary>
        private decimal vlipiecf;
        [XmlElement(ElementName = "VLIPIECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipiecf
        {
            get { return  vlipiecf; }
            set {  vlipiecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIOUTRAS
        /// Coment�rio: Esse atributo serve para armazenar o valor do ipi para devolu��o simbolica.
        /// </summary>
        private decimal vlipioutras;
        [XmlElement(ElementName = "VLIPIOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipioutras
        {
            get { return  vlipioutras; }
            set {  vlipioutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISS
        /// Coment�rio: 
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
        /// Coment�rio: Valor dos impostos do item.
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
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Coment�rio: Valor de Outras Despesas Rateadas no Item. 
        /// </summary>
        private decimal vloutrasdesp;
        [XmlElement(ElementName = "VLOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutrasdesp
        {
            get { return  vloutrasdesp; }
            set {  vloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRAS_RATEIO
        /// Coment�rio: Indica o valor de outras despesas no rateio.
        /// </summary>
        private decimal vloutras_rateio;
        [XmlElement(ElementName = "VLOUTRAS_RATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutras_Rateio
        {
            get { return  vloutras_rateio; }
            set {  vloutras_rateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTROS
        /// Coment�rio: 
        /// </summary>
        private decimal vloutros;
        [XmlElement(ElementName = "VLOUTROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vloutros
        {
            get { return  vloutros; }
            set {  vloutros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREBAIXACMV
        /// Coment�rio: Valor verba do fornecedor para rebaixa do CMV.
        /// </summary>
        private decimal vlrebaixacmv;
        [XmlElement(ElementName = "VLREBAIXACMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrebaixacmv
        {
            get { return  vlrebaixacmv; }
            set {  vlrebaixacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDCMVSIMPLESNAC
        /// Coment�rio: Valor red. cmv simples nacional.
        /// </summary>
        private decimal vlredcmvsimplesnac;
        [XmlElement(ElementName = "VLREDCMVSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredcmvsimplesnac
        {
            get { return  vlredcmvsimplesnac; }
            set {  vlredcmvsimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDCOMISS
        /// Coment�rio: Valor da redu��o comiss�o.
        /// </summary>
        private decimal vlredcomiss;
        [XmlElement(ElementName = "VLREDCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredcomiss
        {
            get { return  vlredcomiss; }
            set {  vlredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDCOMISSSUP
        /// Coment�rio: 
        /// </summary>
        private decimal vlredcomisssup;
        [XmlElement(ElementName = "VLREDCOMISSSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredcomisssup
        {
            get { return  vlredcomisssup; }
            set {  vlredcomisssup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDPVENDASIMPLESNA
        /// Coment�rio: Valor de redu��o no pre�o de venda para cliente Simples Nacional.
        /// </summary>
        private decimal vlredpvendasimplesna;
        [XmlElement(ElementName = "VLREDPVENDASIMPLESNA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredpvendasimplesna
        {
            get { return  vlredpvendasimplesna; }
            set {  vlredpvendasimplesna = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREPASSE
        /// Coment�rio: 
        /// </summary>
        private decimal vlrepasse;
        [XmlElement(ElementName = "VLREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrepasse
        {
            get { return  vlrepasse; }
            set {  vlrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRMOEDAESTRAGEIRA
        /// Coment�rio: Guarda valor da convers�o do real para moeda extrangeira
        /// </summary>
        private decimal vlrmoedaestrageira;
        [XmlElement(ElementName = "VLRMOEDAESTRAGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrmoedaestrageira
        {
            get { return  vlrmoedaestrageira; }
            set {  vlrmoedaestrageira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUBTOTITEM
        /// Coment�rio: Valor total do item do pedido.
        /// </summary>
        private decimal vlsubtotitem;
        [XmlElement(ElementName = "VLSUBTOTITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsubtotitem
        {
            get { return  vlsubtotitem; }
            set {  vlsubtotitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMV
        /// Coment�rio: Valor verba fornecedor para redu��o CMV.
        /// </summary>
        private decimal vlverbacmv;
        [XmlElement(ElementName = "VLVERBACMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlverbacmv
        {
            get { return  vlverbacmv; }
            set {  vlverbacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMVCLI
        /// Coment�rio: Indica o valor da verba CMV calculado a partir do % de verba e aplicado sobre o pre�o de venda do produto. Este valor ser� adicionado ao CMV.
        /// </summary>
        private decimal vlverbacmvcli;
        [XmlElement(ElementName = "VLVERBACMVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlverbacmvcli
        {
            get { return  vlverbacmvcli; }
            set {  vlverbacmvcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMEDESEJADO
        /// Coment�rio: Volume de tinta vendido.
        /// </summary>
        private decimal volumedesejado;
        [XmlElement(ElementName = "VOLUMEDESEJADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Volumedesejado
        {
            get { return  volumedesejado; }
            set {  volumedesejado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPedi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPedi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPedi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedi>(where);
        }

        #endregion
    }
}
