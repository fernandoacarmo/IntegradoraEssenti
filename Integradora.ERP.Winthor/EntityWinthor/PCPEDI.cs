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
        /// Propriedade referente ao campo: ALTERNATIVO
        /// Comentário: Alternativa da formula de tinta.
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
        /// Comentário: Nome do Ambiente
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
        /// Comentário: Base da diferença entre alíquotas.
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
        /// Propriedade referente ao campo: BASEICST_ANT_RATEIO
        /// Comentário: Indica o valor da base de ST antes do rateio de frete e outras despesas.
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
        /// Comentário: Base de cálculo do IPI
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
        /// Comentário: INFORMAR SE O PRODUTO É BONIFICAÇÃO OU NÃO
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código da base vendida.
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
        /// Comentário: Código do certificado.
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
        /// Propriedade referente ao campo: CODCOMBO
        /// Comentário: Código da política de combo.
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
        /// Comentário: Descrição produto Danfe
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
        /// Comentário: 
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
        /// Comentário: Código da política de desconto.
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
        /// Propriedade referente ao campo: CODEMITENTEITEMPEDIDO
        /// Comentário: Código emite item pedido
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
        /// Comentário: 
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
        /// Comentário: Código da formula vendida.
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
        /// Comentário: Indica o código do funcionário que efetuou ajuste de O.S.
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
        /// Comentário: Código do funcionário que alterou a OS.
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
        /// Comentário: Indica o funcionário responsável por alterar o lote do item do pedido
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
        /// Propriedade referente ao campo: CODFUNCCONF2
        /// Comentário: Indica o código funcionário conferente 2.
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
        /// Comentário: Código do Funcionário que Incluiu o Item.
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
        /// Comentário: Responsável por liberar O.S.
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
        /// Comentário: Conferente de pendência da O.S.
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
        /// Comentário: 
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
        /// Comentário: Código do Funcionário que Alterou o Item.
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
        /// Comentário: Código ICM tributação tabela.
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
        /// Comentário: Indica o código do brinde.
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
        /// Comentário: Código Linha Prazo
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
        /// Comentário: Guarda código da moeda estrageira no momento da venda
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
        /// Comentário: Código do motivo de não compra.
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
        /// Propriedade referente ao campo: CODPRECOFIXO
        /// Comentário: Código preço fixo
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
        /// Propriedade referente ao campo: CODPRODCESTA
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODVASILHAME
        /// Comentário: Código do Vasilhame associado ao Produto. 
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
        /// Comentário: 
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
        /// Comentário: Conceder maior Comissão das Faixas.
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
        /// Comentário: Indica a condição de venda. 
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
        /// Comentário: Valor custo financeiro estoque.
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
        /// Propriedade referente ao campo: DATACONF
        /// Comentário: 
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
        /// Comentário: Fim de conferência de O.S.
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
        /// Comentário: Desconto Preço de Fábrica
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
        /// Comentário: Indica a data de ajuste de O.S.
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
        /// Comentário: Data/Hora de alteração da OS .
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
        /// Comentário: Data Entrega Futura - Encomenda.
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
        /// Comentário: 
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
        /// Comentário: Data Fim da promoção
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
        /// Comentário: Fim de pendência de O.S.
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
        /// Comentário: Fim de separação de O.S.
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
        /// Comentário: Indica a data de geração da OS.
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
        /// Comentário: 
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
        /// Comentário: Inicio de pendência de O.S.
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
        /// Comentário: Inicio de separação de O.S.
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
        /// Comentário: Data Inicio da promoção
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
        /// Comentário: Data da inclusão do Item no Pedido.
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
        /// Comentário: Liberação da O.S.
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
        /// Comentário: Data daAlteração do Item no Pedido.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Forma de negociação
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
        /// Comentário: Campo para definir se a GNRE será paga pelo cliente.
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
        /// Comentário: Grade brinde.
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
        /// Comentário: GRUPO FATURAMENTO
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
        /// Comentário: Identificação patrimonial.
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
        /// Comentário: Identificação de Venda
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
        /// Comentário: 
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
        /// Comentário: Indica se imprime o item ou não.
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
        /// Propriedade referente ao campo: LETRACOMISS
        /// Comentário: Código classificação tipo comissão.
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
        /// Comentário: 
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
        /// Comentário: Localização de carrinhos da O.S.
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
        /// Comentário: Movimenta conta corrente RCA.
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
        /// Comentário: Negociação Posterior
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
        /// Comentário: Nome do concorrente.
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
        /// Comentário: 
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
        /// Comentário: Numero da caixa
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
        /// Propriedade referente ao campo: NUMCARAUX
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Número sujeito ao controle de papel imune
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
        /// Comentário: Indica o número da etiqueta do produto quando definido como frios.
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
        /// Comentário: NÚMERO DO ITEM NO XML DA NOTA FISCAL.
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
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: Indica o número do lote ao qual o produto pertence.
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
        /// Comentário: Indica o numero da ordem de produção.
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
        /// Comentário: Número da O.S.
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
        /// Comentário: Número de OS Original.
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
        /// Propriedade referente ao campo: NUMRECOPI
        /// Comentário: Número sujeito ao controle de papel imune
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
        /// Propriedade referente ao campo: NUMSEQITEMCONTRATO
        /// Comentário: Número da Sequência do Item no Contrato
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
        /// Comentário: Indica o o número de tira.
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
        /// Propriedade referente ao campo: NUMVERBAREBCMV
        /// Comentário: 
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
        /// Comentário: Vias emitidas da O.S.
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
        /// Comentário: Indica a quantidade de volumes confereido de itens.
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
        /// Comentário: 
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
        /// Comentário: Origem do cálculo de ST
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
        /// Comentário: Participa Giro
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
        /// Comentário: Valor de pauta.
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
        /// Propriedade referente ao campo: PBONIFIC
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Percentual da base reduzida ST.
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
        /// Comentário: Percentual base reduzida ST cliente fonte.
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
        /// Comentário: Percentual de desconto referente ao abatimento
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
        /// Comentário: Indica o % de desconto COFINS aplicado na venda.
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
        /// Comentário: % desconto industria
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
        /// Comentário: Indica o % de desconto PIS aplicado na venda.
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
        /// Comentário: Percentual de diferença de tributação.
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: PERCIPIECF
        /// Comentário: Percentual de IPI
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
        /// Comentário: Esse atributo serve para armazenar o valor do ipi para devolução simbolica.
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: PERCOMPROF
        /// Comentário: Percentual comissão profissional.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica a comissão do terceiro profissional.
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconta à vista
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
        /// Comentário: Percentual do Desconto do Produto que será concedido no Boleto
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
        /// Comentário: 
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
        /// Comentário: Percentual desconto custo.
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
        /// Comentário: Perc. Desc. Final Faixa Comissão.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Percentual de Desconto FOB.
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
        /// Comentário: Perc. Desc. Inicial Faixa Comissão.
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
        /// Comentário: Percentual desconto isento ICMS.
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
        /// Comentário: Percentudal de desconto negociado
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
        /// Comentário: PERCENTUAL DE DESCONTO UTILIZADO NA PAUTA
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
        /// Comentário: Percentual de desconto aplicado em política de desconto por valor de pedido. 
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
        /// Propriedade referente ao campo: PERREDCOMISS
        /// Comentário: Percentual de redução comissão.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica se a política prioritária foi utilizada por item.
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: PRAZO
        /// Comentário: Prazo do concorrente.
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
        /// Propriedade referente ao campo: PRECO
        /// Comentário: Preço do concorrente.
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
        /// Comentário: Preço bruto/Negociado FV.
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
        /// Comentário: Preço máximo consumidor
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
        /// Comentário: Indica a descrição do produto no contrato.
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
        /// Comentário: Descrição produto Danfe
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
        /// Propriedade referente ao campo: PTABELAAUTPECAS
        /// Comentário: Preço de tabela para auto peças.
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
        /// Propriedade referente ao campo: PVENDAANTERIOR
        /// Comentário: Preço anterior a aplicação de política de desconto por valor de pedido. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Valor do preço a vista, para realização de cálculo de comissão sobre preço a vista. 
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
        /// Propriedade referente ao campo: QTAPANHA
        /// Comentário: Usado na separação via Coletor de Dados na rotina 947. 
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
        /// Comentário: 
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
        /// Comentário: Qtde de dias para entregar o produto sem estoque
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Quantidade de Entrega Imediata.
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
        /// Comentário: Quantidade em litragem do produto
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
        /// Comentário: 
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
        /// Comentário: Quantidade não comprada.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Quantidade pendente de itens da O.S.
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
        /// Comentário: Quantidade reservada do item
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
        /// Propriedade referente ao campo: QT_SEPARADAMANIF
        /// Comentário: Quantidade separada
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Quantidade em unidades de venda
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
        /// Comentário: Quantidade unitária por caixa. Rotina 316. Quantidade, Unidade Master. 
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
        /// Comentário: Indica a quantidade uitaria da embalagem.
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
        /// Comentário: 
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
        /// Comentário: Referencia cor do produto.
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
        /// Comentário: Indica o nome da rotina.
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
        /// Comentário: Código da Rotina que sofreu alteração.
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
        /// Comentário: Rotina Lançamento de Brinde
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
        /// Comentário: Rotina que gravou o registro
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
        /// Comentário: Código da Rotina que sofreu alteração.
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
        /// Comentário: Retirada Posterior Imediata
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
        /// Comentário: Sigla da qualidade da tinta.
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
        /// Comentário: Situação da O.S.
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
        /// Comentário: Valor do ST.
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
        /// Comentário: Indica o valor do ST antes do rateio de frete e outras despesas.
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
        /// Comentário: Status Sucata
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
        /// Comentário: Valor ST para cliente com GNRE.
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
        /// Comentário: Indica o valor da diferença de ST antes do rateio de frete e outras despesas.
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
        /// Comentário: Valor do ST na base RCA
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
        /// Comentário: Valor do ST no preço de  Tabela
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
        /// Comentário: Informa se o item foi sugestão de venda
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
        /// Comentário: Taxa caso a moeda escolhida seja o real.
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
        /// Comentário: Indica a forma que o ST foi calculado.
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
        /// Comentário: Tipo desconto aplicado.
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
        /// Comentário: Tipo de entrega do produto. 
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
        /// Comentário: 
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
        /// Comentário: Indica o tipo de separação.
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
        /// Comentário: Totalizador alíquotas.
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
        /// Comentário: Para correção de diferenças de truncamento/arredondamento no subtotal do item das impressoras fiscais. 
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
        /// Comentário: Indica que tipo de venda será o brinde.
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
        /// Propriedade referente ao campo: UNIDADE
        /// Comentário: Unidade da fórmula de tinta
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
        /// Comentário: Gerar débito ou crédito para o RCA no pedido brinde.
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
        /// Comentário: Indica se o produto foi gravado para respeitar a quantidade master ou não.
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
        /// Comentário: Valor acrescimo rodapé.
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
        /// Comentário: Valor de acréscimo Frete (kG)
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLDESCABATIMENTO
        /// Comentário: Valor do desconto referente ao abatimento.
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
        /// Comentário: Valor do Desconto do Boleto
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLDESCFIN
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Valor descontro ICMS isento.
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
        /// Comentário: 
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
        /// Comentário: Indica valor de desconto COFINS aplicado na venda.
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
        /// Comentário: Indica o valor de desconto PIS aplicado na venda..
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
        /// Comentário: Valor desconto repasse.
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
        /// Propriedade referente ao campo: VLDESCSOCIOTORCEDOR
        /// Comentário: Desconto Sóscio Torcedor
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
        /// Comentário: Valor da diferença de aliquotas.
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
        /// Comentário: 
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
        /// Comentário: Indica o valor do frete no raterio.
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
        /// Propriedade referente ao campo: VLIPIECF
        /// Comentário: Valor do IPI
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
        /// Comentário: Esse atributo serve para armazenar o valor do ipi para devolução simbolica.
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Comentário: Valor de Outras Despesas Rateadas no Item. 
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
        /// Comentário: Indica o valor de outras despesas no rateio.
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
        /// Comentário: 
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
        /// Comentário: Valor verba do fornecedor para rebaixa do CMV.
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
        /// Comentário: Valor red. cmv simples nacional.
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
        /// Comentário: Valor da redução comissão.
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
        /// Comentário: 
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
        /// Comentário: Valor de redução no preço de venda para cliente Simples Nacional.
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
        /// Comentário: 
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
        /// Comentário: Guarda valor da conversão do real para moeda extrangeira
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
        /// Comentário: Valor total do item do pedido.
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
        /// Comentário: Valor verba fornecedor para redução CMV.
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
        /// Comentário: Indica o valor da verba CMV calculado a partir do % de verba e aplicado sobre o preço de venda do produto. Este valor será adicionado ao CMV.
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
        /// Comentário: Volume de tinta vendido.
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPedi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
