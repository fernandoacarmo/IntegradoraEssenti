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
    /// Classe referente a tabela PCMovcomple
    /// </summary>
    [XmlType("PCMOVCOMPLE")]
    public class PCMovcomple : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSFECP
        /// Coment�rio: Al�quota de ICMS Fecp.
        /// </summary>
        private decimal aliqicmsfecp;
        [XmlElement(ElementName = "ALIQICMSFECP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicmsfecp
        {
            get { return  aliqicmsfecp; }
            set {  aliqicmsfecp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1ULTENTANT
        /// Coment�rio: Al�quota ICMS interna anterior.
        /// </summary>
        private decimal aliqicms1ultentant;
        [XmlElement(ElementName = "ALIQICMS1ULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms1ultentant
        {
            get { return  aliqicms1ultentant; }
            set {  aliqicms1ultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2ULTENTANT
        /// Coment�rio: Al�quota ICMS externa anterior.
        /// </summary>
        private decimal aliqicms2ultentant;
        [XmlElement(ElementName = "ALIQICMS2ULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms2ultentant
        {
            get { return  aliqicms2ultentant; }
            set {  aliqicms2ultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANP
        /// Coment�rio: C�digo ANP combust�vel.
        /// </summary>
        private decimal anp;
        [XmlElement(ElementName = "ANP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Anp
        {
            get { return  anp; }
            set {  anp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICPERCIVAPAUTAICMSANTECIP
        /// Coment�rio: Aplica IVA sobre valor de pauta ICMS antecipado
        /// </summary>
        private string aplicpercivapautaicmsantecip;
        [XmlElement(ElementName = "APLICPERCIVAPAUTAICMSANTECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicpercivapautaicmsantecip
        {
            get { return  aplicpercivapautaicmsantecip; }
            set {  aplicpercivapautaicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICREDBASEIVAPLIQ
        /// Coment�rio: Aplicar redu��o base IVA pre�o liquido
        /// </summary>
        private string aplicredbaseivapliq;
        [XmlElement(ElementName = "APLICREDBASEIVAPLIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicredbaseivapliq
        {
            get { return  aplicredbaseivapliq; }
            set {  aplicredbaseivapliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICREDBASEIVAPLIQBCR
        /// Coment�rio: Aplicar redu��o base IVA pre�o liquido BCR
        /// </summary>
        private string aplicredbaseivapliqbcr;
        [XmlElement(ElementName = "APLICREDBASEIVAPLIQBCR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicredbaseivapliqbcr
        {
            get { return  aplicredbaseivapliqbcr; }
            set {  aplicredbaseivapliqbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDICMSCONT
        /// Coment�rio: Aproveita cr�dito ICMS custo contabil na importa��o
        /// </summary>
        private string aproveitacredicmscont;
        [XmlElement(ElementName = "APROVEITACREDICMSCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredicmscont
        {
            get { return  aproveitacredicmscont; }
            set {  aproveitacredicmscont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDPISCOFINSCONT
        /// Coment�rio: Aproveita cr�dito PIS/COFINS custo contabil na importa��o
        /// </summary>
        private string aproveitacredpiscofinscont;
        [XmlElement(ElementName = "APROVEITACREDPISCOFINSCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredpiscofinscont
        {
            get { return  aproveitacredpiscofinscont; }
            set {  aproveitacredpiscofinscont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEBCRANT
        /// Coment�rio: Base ST BCR anterior.
        /// </summary>
        private decimal basebcrant;
        [XmlElement(ElementName = "BASEBCRANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basebcrant
        {
            get { return  basebcrant; }
            set {  basebcrant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASECREDPRESUMIDO
        /// Coment�rio: Base do Cr�dito Presumido
        /// </summary>
        private decimal basecredpresumido;
        [XmlElement(ElementName = "BASECREDPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basecredpresumido
        {
            get { return  basecredpresumido; }
            set {  basecredpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMSANTECIPADO
        /// Coment�rio: Base do ICMS Antecipado
        /// </summary>
        private decimal baseicmsantecipado;
        [XmlElement(ElementName = "BASEICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicmsantecipado
        {
            get { return  baseicmsantecipado; }
            set {  baseicmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEIPIOUTRAS
        /// Coment�rio: Base do IPI
        /// </summary>
        private decimal baseipioutras;
        [XmlElement(ElementName = "BASEIPIOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseipioutras
        {
            get { return  baseipioutras; }
            set {  baseipioutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASESTOUTRAS
        /// Coment�rio: Base do ST
        /// </summary>
        private decimal basestoutras;
        [XmlElement(ElementName = "BASESTOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basestoutras
        {
            get { return  basestoutras; }
            set {  basestoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BNFNAOCALCULAICMS
        /// Coment�rio: Flag da rotina 514
        /// </summary>
        private string bnfnaocalculaicms;
        [XmlElement(ElementName = "BNFNAOCALCULAICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bnfnaocalculaicms
        {
            get { return  bnfnaocalculaicms; }
            set {  bnfnaocalculaicms = value; }
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
        /// Propriedade referente ao campo: CALCCREDIPICONT
        /// Coment�rio: Calcula cr�dito IPI custo contabil na importa��o
        /// </summary>
        private string calccredipicont;
        [XmlElement(ElementName = "CALCCREDIPICONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredipicont
        {
            get { return  calccredipicont; }
            set {  calccredipicont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCTRIBMANUAL
        /// Coment�rio: Par�metro para informar se calculo da tributa��o vai ser manual ou autom�tica
        /// </summary>
        private string calctribmanual;
        [XmlElement(ElementName = "CALCTRIBMANUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calctribmanual
        {
            get { return  calctribmanual; }
            set {  calctribmanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNAEDESONERACAO
        /// Coment�rio: C�digo CNAE sera utilizado no rec�lculo desonera��o na rotina 1000
        /// </summary>
        private string cnaedesoneracao;
        [XmlElement(ElementName = "CNAEDESONERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Cnaedesoneracao
        {
            get { return  cnaedesoneracao; }
            set {  cnaedesoneracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITENTEITEMPEDIDO
        /// Coment�rio: Codigo emitente que incluiu o item no pedido
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
        /// Propriedade referente ao campo: CODFILIALDEST
        /// Coment�rio: C�digo da filial/dep�sito de destino para armazenagem
        /// </summary>
        private string codfilialdest;
        [XmlElement(ElementName = "CODFILIALDEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialdest
        {
            get { return  codfilialdest; }
            set {  codfilialdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do fornecedor que vai receber o pagamento.
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
        /// Propriedade referente ao campo: CODPRODACABCESTA
        /// Coment�rio: C�digo de produto acabado da cesta
        /// </summary>
        private decimal codprodacabcesta;
        [XmlElement(ElementName = "CODPRODACABCESTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodacabcesta
        {
            get { return  codprodacabcesta; }
            set {  codprodacabcesta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODGNRE
        /// Coment�rio: C�DIGO DO PRODUTO PARA GNRE.
        /// </summary>
        private decimal codprodgnre;
        [XmlElement(ElementName = "CODPRODGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodgnre
        {
            get { return  codprodgnre; }
            set {  codprodgnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBICMSFRETEFOB
        /// Coment�rio: C�digo Situa��o Tribut�ria ICMS Frete FOB
        /// </summary>
        private string codsittribicmsfretefob;
        [XmlElement(ElementName = "CODSITTRIBICMSFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codsittribicmsfretefob
        {
            get { return  codsittribicmsfretefob; }
            set {  codsittribicmsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBIPI
        /// Coment�rio: Situa��o Tribut�ria do IPI
        /// </summary>
        private decimal codsittribipi;
        [XmlElement(ElementName = "CODSITTRIBIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribipi
        {
            get { return  codsittribipi; }
            set {  codsittribipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINSFRETEFOB
        /// Coment�rio: C�digo Situa��o Tribut�ria PIS/COFINS Frete FOB
        /// </summary>
        private decimal codsittribpiscofinsfretefob;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINSFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribpiscofinsfretefob
        {
            get { return  codsittribpiscofinsfretefob; }
            set {  codsittribpiscofinsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBST
        /// Coment�rio: GRAVAR O C�DIGO DA SITUA��O TRIBUT�RIA ST
        /// </summary>
        private string codsittribst;
        [XmlElement(ElementName = "CODSITTRIBST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codsittribst
        {
            get { return  codsittribst; }
            set {  codsittribst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Coment�rio: C�digo da tributa��o de PIS/COFINS
        /// </summary>
        private decimal codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COFINSRETIDO
        /// Coment�rio: Percentual COFINS retido venda.
        /// </summary>
        private decimal cofinsretido;
        [XmlElement(ElementName = "COFINSRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Cofinsretido
        {
            get { return  cofinsretido; }
            set {  cofinsretido = value; }
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
        /// Propriedade referente ao campo: CONSIDERASTGUIACUSTO
        /// Coment�rio: Considera ST Guia no Custo.
        /// </summary>
        private string considerastguiacusto;
        [XmlElement(ElementName = "CONSIDERASTGUIACUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerastguiacusto
        {
            get { return  considerastguiacusto; }
            set {  considerastguiacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERASTGUIACUSTOCONT
        /// Coment�rio: Considera ST Guia no Custo Cont�bil.
        /// </summary>
        private string considerastguiacustocont;
        [XmlElement(ElementName = "CONSIDERASTGUIACUSTOCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerastguiacustocont
        {
            get { return  considerastguiacustocont; }
            set {  considerastguiacustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERASTNFCUSTO
        /// Coment�rio: Considera ST NF  no Custo.
        /// </summary>
        private string considerastnfcusto;
        [XmlElement(ElementName = "CONSIDERASTNFCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerastnfcusto
        {
            get { return  considerastnfcusto; }
            set {  considerastnfcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERASTNFCUSTOCONT
        /// Coment�rio: Considera ST NF no Custo Cont�bil.
        /// </summary>
        private string considerastnfcustocont;
        [XmlElement(ElementName = "CONSIDERASTNFCUSTOCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerastnfcustocont
        {
            get { return  considerastnfcustocont; }
            set {  considerastnfcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIISUSPENSOBASEICMS
        /// Coment�rio: Considera II Suspenso base ICMS.
        /// </summary>
        private string consiisuspensobaseicms;
        [XmlElement(ElementName = "CONSIISUSPENSOBASEICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consiisuspensobaseicms
        {
            get { return  consiisuspensobaseicms; }
            set {  consiisuspensobaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIPISUSPENSOBASEICMS
        /// Coment�rio: Considera IPI Suspenso base ICMS.
        /// </summary>
        private string consipisuspensobaseicms;
        [XmlElement(ElementName = "CONSIPISUSPENSOBASEICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consipisuspensobaseicms
        {
            get { return  consipisuspensobaseicms; }
            set {  consipisuspensobaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLARFCI
        /// Coment�rio: Controla Ficha de Conte�do de Importa��o.
        /// </summary>
        private string controlarfci;
        [XmlElement(ElementName = "CONTROLARFCI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlarfci
        {
            get { return  controlarfci; }
            set {  controlarfci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CSLLRETIDO
        /// Coment�rio: Percentual CSLL retido venda.
        /// </summary>
        private decimal csllretido;
        [XmlElement(ElementName = "CSLLRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Csllretido
        {
            get { return  csllretido; }
            set {  csllretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINSEMST
        /// Coment�rio: Valor do Custo m�dio Financeiro sem ST NF e GUIA.
        /// </summary>
        private decimal custofinsemst;
        [XmlElement(ElementName = "CUSTOFINSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinsemst
        {
            get { return  custofinsemst; }
            set {  custofinsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINSEMSTANT
        /// Coment�rio: Valor do Custo m�dio Financeiro sem ST NF e GUIA Anterior.
        /// </summary>
        private decimal custofinsemstant;
        [XmlElement(ElementName = "CUSTOFINSEMSTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinsemstant
        {
            get { return  custofinsemstant; }
            set {  custofinsemstant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMSTGUIAULTENT
        /// Coment�rio: Custo da NF sem ST Guia atual.
        /// </summary>
        private decimal custonfsemstguiaultent;
        [XmlElement(ElementName = "CUSTONFSEMSTGUIAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemstguiaultent
        {
            get { return  custonfsemstguiaultent; }
            set {  custonfsemstguiaultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMSTGUIAULTENTANT
        /// Coment�rio: Custo da NF sem ST Guia anterior.
        /// </summary>
        private decimal custonfsemstguiaultentant;
        [XmlElement(ElementName = "CUSTONFSEMSTGUIAULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemstguiaultentant
        {
            get { return  custonfsemstguiaultentant; }
            set {  custonfsemstguiaultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTCONT
        /// Coment�rio: Custo da �ltima entrada cont�bil - entrada
        /// </summary>
        private decimal custoultentcont;
        [XmlElement(ElementName = "CUSTOULTENTCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Custoultentcont
        {
            get { return  custoultentcont; }
            set {  custoultentcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTCONTANT
        /// Coment�rio: Custo da �ltima entrada cont�bil - anterior
        /// </summary>
        private decimal custoultentcontant;
        [XmlElement(ElementName = "CUSTOULTENTCONTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Custoultentcontant
        {
            get { return  custoultentcontant; }
            set {  custoultentcontant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTFINSEMST
        /// Coment�rio: Custo Ult.Entrada Financeira sem ST.
        /// </summary>
        private decimal custoultentfinsemst;
        [XmlElement(ElementName = "CUSTOULTENTFINSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentfinsemst
        {
            get { return  custoultentfinsemst; }
            set {  custoultentfinsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTFINSEMSTANT
        /// Coment�rio: Custo Ult.Entrada Financeira sem ST Anterior
        /// </summary>
        private decimal custoultentfinsemstant;
        [XmlElement(ElementName = "CUSTOULTENTFINSEMSTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentfinsemstant
        {
            get { return  custoultentfinsemstant; }
            set {  custoultentfinsemstant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTSEMST
        /// Coment�rio: Custo Ult.Entrada sem ST.
        /// </summary>
        private decimal custoultentsemst;
        [XmlElement(ElementName = "CUSTOULTENTSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentsemst
        {
            get { return  custoultentsemst; }
            set {  custoultentsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTSEMSTANT
        /// Coment�rio: Custo Ult.Entrada sem ST Anterior
        /// </summary>
        private decimal custoultentsemstant;
        [XmlElement(ElementName = "CUSTOULTENTSEMSTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentsemstant
        {
            get { return  custoultentsemstant; }
            set {  custoultentsemstant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRICMSIMPORTACAO
        /// Coment�rio: Somar ICMS ao custo unit�rio na primeira NF importa��o "N".
        /// </summary>
        private string deduziricmsimportacao;
        [XmlElement(ElementName = "DEDUZIRICMSIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduziricmsimportacao
        {
            get { return  deduziricmsimportacao; }
            set {  deduziricmsimportacao = value; }
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
        /// Propriedade referente ao campo: DTESTORNO
        /// Coment�rio: Data de Estorno da Movimenta��o.
        /// </summary>
        private DateTime? dtestorno;
        [XmlElement(ElementName = "DTESTORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestorno
        {
            get { return  dtestorno; }
            set {  dtestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREGISTRO
        /// Coment�rio: Data de cria��o do registro
        /// </summary>
        private DateTime? dtregistro;
        [XmlElement(ElementName = "DTREGISTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtregistro
        {
            get { return  dtregistro; }
            set {  dtregistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCODPROD
        /// Coment�rio: EAN C�d. Prod.
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
        /// Propriedade referente ao campo: ENDERECADO
        /// Coment�rio: Informa se o produto j� foi endere�ado.
        /// </summary>
        private string enderecado;
        [XmlElement(ElementName = "ENDERECADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enderecado
        {
            get { return  enderecado; }
            set {  enderecado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXTIPI
        /// Coment�rio: Exce��o da TIPI para gera��o do XML NFe
        /// </summary>
        private string extipi;
        [XmlElement(ElementName = "EXTIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Extipi
        {
            get { return  extipi; }
            set {  extipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCONVTRIB
        /// Coment�rio: Fator convers�o tribut�vel.
        /// </summary>
        private decimal fatorconvtrib;
        [XmlElement(ElementName = "FATORCONVTRIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Fatorconvtrib
        {
            get { return  fatorconvtrib; }
            set {  fatorconvtrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERABASEPISCOFINSSEMALIQ
        /// Coment�rio: Defina se deve gerar base de PIS/CONFINS mesmo quando n�o for informado aliquotas de PIS/CONFINS
        /// </summary>
        private string gerabasepiscofinssemaliq;
        [XmlElement(ElementName = "GERABASEPISCOFINSSEMALIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerabasepiscofinssemaliq
        {
            get { return  gerabasepiscofinssemaliq; }
            set {  gerabasepiscofinssemaliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IBANC
        /// Coment�rio: C�digo iBanc da banco destinado para deposito.
        /// </summary>
        private string ibanc;
        [XmlElement(ElementName = "IBANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ibanc
        {
            get { return  ibanc; }
            set {  ibanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ICMSPAUTA
        /// Coment�rio: Indica se a base de ICMS foi pauta.
        /// </summary>
        private string icmspauta;
        [XmlElement(ElementName = "ICMSPAUTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Icmspauta
        {
            get { return  icmspauta; }
            set {  icmspauta = value; }
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
        /// Propriedade referente ao campo: IPIPORVALOR
        /// Coment�rio: IPI com valor fixo
        /// </summary>
        private string ipiporvalor;
        [XmlElement(ElementName = "IPIPORVALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ipiporvalor
        {
            get { return  ipiporvalor; }
            set {  ipiporvalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IRRETIDO
        /// Coment�rio: Percentual IR retido venda.
        /// </summary>
        private decimal irretido;
        [XmlElement(ElementName = "IRRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Irretido
        {
            get { return  irretido; }
            set {  irretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVAULTENTANT
        /// Coment�rio: Valor do IVA anterior.
        /// </summary>
        private decimal ivaultentant;
        [XmlElement(ElementName = "IVAULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ivaultentant
        {
            get { return  ivaultentant; }
            set {  ivaultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDRAWBACK
        /// Coment�rio: N�mero do Ato Concess�rio do regime
        /// </summary>
        private string numdrawback;
        [XmlElement(ElementName = "NUMDRAWBACK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numdrawback
        {
            get { return  numdrawback; }
            set {  numdrawback = value; }
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
        /// Propriedade referente ao campo: NUMFCI
        /// Coment�rio: Ficha de Conte�do de Importa��o.
        /// </summary>
        private string numfci;
        [XmlElement(ElementName = "NUMFCI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,36)]
        public string Numfci
        {
            get { return  numfci; }
            set {  numfci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVENT
        /// Coment�rio: N�mero do Invent�rio
        /// </summary>
        private decimal numinvent;
        [XmlElement(ElementName = "NUMINVENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numinvent
        {
            get { return  numinvent; }
            set {  numinvent = value; }
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
        /// Propriedade referente ao campo: NUMTRANSITEM
        /// Coment�rio: N�mero do item relacionado a tabela PCMOV
        /// </summary>
        private decimal numtransitem;
        [XmlElement(ElementName = "NUMTRANSITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public decimal Numtransitem
        {
            get { return  numtransitem; }
            set {  numtransitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSITEMDEV
        /// Coment�rio: N�mero de transa��o do item de devolu��o. Permite rastrear o item da venda apartir do item devolvido.
        /// </summary>
        private decimal numtransitemdev;
        [XmlElement(ElementName = "NUMTRANSITEMDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransitemdev
        {
            get { return  numtransitemdev; }
            set {  numtransitemdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSNUMEROSERIE
        /// Coment�rio: N�mero da transa��o de movimenta��o
        /// </summary>
        private decimal numtransnumeroserie;
        [XmlElement(ElementName = "NUMTRANSNUMEROSERIE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransnumeroserie
        {
            get { return  numtransnumeroserie; }
            set {  numtransnumeroserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSTRANSFORIG
        /// Coment�rio: Transa��o da PCMOV das transferencias virtuais.
        /// </summary>
        private decimal numtranstransforig;
        [XmlElement(ElementName = "NUMTRANSTRANSFORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranstransforig
        {
            get { return  numtranstransforig; }
            set {  numtranstransforig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGMERCTRIB
        /// Coment�rio: C�digo de origem da mercadoria na situa��o tribut�ria
        /// </summary>
        private string origmerctrib;
        [XmlElement(ElementName = "ORIGMERCTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origmerctrib
        {
            get { return  origmerctrib; }
            set {  origmerctrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPAGIRO
        /// Coment�rio: Parcicipa Giro
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
        /// Propriedade referente ao campo: PERACRESCIMOFUNCEP
        /// Coment�rio: Percentual de Acr�scimo do Fundo de Combate e Erradica��o da Pobreza
        /// </summary>
        private decimal peracrescimofuncep;
        [XmlElement(ElementName = "PERACRESCIMOFUNCEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Peracrescimofuncep
        {
            get { return  peracrescimofuncep; }
            set {  peracrescimofuncep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCADUANEIRA
        /// Coment�rio: Percentual de despesas aduaneira
        /// </summary>
        private decimal percaduaneira;
        [XmlElement(ElementName = "PERCADUANEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaduaneira
        {
            get { return  percaduaneira; }
            set {  percaduaneira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCADUANEIRACUSTO
        /// Coment�rio: Percentual Despesa Aduaneira Custo
        /// </summary>
        private decimal percaduaneiracusto;
        [XmlElement(ElementName = "PERCADUANEIRACUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaduaneiracusto
        {
            get { return  percaduaneiracusto; }
            set {  percaduaneiracusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAFRMM
        /// Coment�rio: Percentual de Adicional de Frete para a Renova��o da Marinha Mercante
        /// </summary>
        private decimal percafrmm;
        [XmlElement(ElementName = "PERCAFRMM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percafrmm
        {
            get { return  percafrmm; }
            set {  percafrmm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAFRMMCUSTO
        /// Coment�rio: Percentual de Adicional de Frete para a Renova��o da Marinha Mercante
        /// </summary>
        private decimal percafrmmcusto;
        [XmlElement(ElementName = "PERCAFRMMCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percafrmmcusto
        {
            get { return  percafrmmcusto; }
            set {  percafrmmcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTGUIAULTENTANT
        /// Coment�rio: Percentual al�quota externa GUIA anterior.
        /// </summary>
        private decimal percaliqextguiaultentant;
        [XmlElement(ElementName = "PERCALIQEXTGUIAULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqextguiaultentant
        {
            get { return  percaliqextguiaultentant; }
            set {  percaliqextguiaultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALTERCUSTOENT
        /// Coment�rio: Percentual de acr�scimo no custo do produto por n�o reembolso da avaria.
        /// </summary>
        private decimal percaltercustoent;
        [XmlElement(ElementName = "PERCALTERCUSTOENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percaltercustoent
        {
            get { return  percaltercustoent; }
            set {  percaltercustoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCANTIDUMPING
        /// Coment�rio: Percentual Antidumping DI
        /// </summary>
        private decimal percantidumping;
        [XmlElement(ElementName = "PERCANTIDUMPING", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percantidumping
        {
            get { return  percantidumping; }
            set {  percantidumping = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCANTIDUMPINGCUSTO
        /// Coment�rio: Percentual Antidumping Custo
        /// </summary>
        private decimal percantidumpingcusto;
        [XmlElement(ElementName = "PERCANTIDUMPINGCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percantidumpingcusto
        {
            get { return  percantidumpingcusto; }
            set {  percantidumpingcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFIC
        /// Coment�rio: % Bonifica��o Dinheiro
        /// </summary>
        private decimal percbonific;
        [XmlElement(ElementName = "PERCBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbonific
        {
            get { return  percbonific; }
            set {  percbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCAPATAZIA
        /// Coment�rio: Percentual da capatazia rateado entre os itens de importa��o.
        /// </summary>
        private decimal perccapatazia;
        [XmlElement(ElementName = "PERCCAPATAZIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perccapatazia
        {
            get { return  perccapatazia; }
            set {  perccapatazia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCAPATAZIACUSTO
        /// Coment�rio: Percentual de capatazia NF custo
        /// </summary>
        private decimal perccapataziacusto;
        [XmlElement(ElementName = "PERCCAPATAZIACUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perccapataziacusto
        {
            get { return  perccapataziacusto; }
            set {  perccapataziacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCARGATRIBMEDIA
        /// Coment�rio: Percentual de carga tribut�ria m�dia, utilizado no SEFAZ MT para calculo da substitui��o tribut�ria
        /// </summary>
        private decimal perccargatribmedia;
        [XmlElement(ElementName = "PERCCARGATRIBMEDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perccargatribmedia
        {
            get { return  perccargatribmedia; }
            set {  perccargatribmedia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCARGATRIBMEDIAICMSANTECIP
        /// Coment�rio: % Carga M�dia tribut�ria Icms Antecipado
        /// </summary>
        private decimal perccargatribmediaicmsantecip;
        [XmlElement(ElementName = "PERCCARGATRIBMEDIAICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perccargatribmediaicmsantecip
        {
            get { return  perccargatribmediaicmsantecip; }
            set {  perccargatribmediaicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCONTEUDOIMPFCI
        /// Coment�rio: Conte�do de Importa��o.
        /// </summary>
        private decimal percconteudoimpfci;
        [XmlElement(ElementName = "PERCCONTEUDOIMPFCI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percconteudoimpfci
        {
            get { return  percconteudoimpfci; }
            set {  percconteudoimpfci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCABATIMENTO
        /// Coment�rio: Percentual de abatimento
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
        /// Propriedade referente ao campo: PERCDESONERACAO
        /// Coment�rio: Percentual de desonera��o ser� utilizado no rec�lculo de desonera��o na rotina 1000
        /// </summary>
        private decimal percdesoneracao;
        [XmlElement(ElementName = "PERCDESONERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdesoneracao
        {
            get { return  percdesoneracao; }
            set {  percdesoneracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPDENTRONFCUSTO
        /// Coment�rio: Percentual de acr�scimo NF custo
        /// </summary>
        private decimal percdespdentronfcusto;
        [XmlElement(ElementName = "PERCDESPDENTRONFCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespdentronfcusto
        {
            get { return  percdespdentronfcusto; }
            set {  percdespdentronfcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETENFCUSTO
        /// Coment�rio: Percentual de frete NF custo
        /// </summary>
        private decimal percfretenfcusto;
        [XmlElement(ElementName = "PERCFRETENFCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfretenfcusto
        {
            get { return  percfretenfcusto; }
            set {  percfretenfcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSBASEICMSANTECIPADO
        /// Coment�rio: Aliq. Para base do ICMS antecipado
        /// </summary>
        private decimal percicmsbaseicmsantecipado;
        [XmlElement(ElementName = "PERCICMSBASEICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmsbaseicmsantecipado
        {
            get { return  percicmsbaseicmsantecipado; }
            set {  percicmsbaseicmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSCUSTOFRETEFOB
        /// Coment�rio: Percentual ICMS p/ calculo do custo Frete FOB
        /// </summary>
        private decimal percicmscustofretefob;
        [XmlElement(ElementName = "PERCICMSCUSTOFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percicmscustofretefob
        {
            get { return  percicmscustofretefob; }
            set {  percicmscustofretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOB
        /// Coment�rio: Percentual ICMS Frete FOB
        /// </summary>
        private decimal percicmsfretefob;
        [XmlElement(ElementName = "PERCICMSFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percicmsfretefob
        {
            get { return  percicmsfretefob; }
            set {  percicmsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBICMSANTECIP
        /// Coment�rio: % ICMS Frete FOB p/ calc.Icms Antecipado
        /// </summary>
        private decimal percicmsfretefobicmsantecip;
        [XmlElement(ElementName = "PERCICMSFRETEFOBICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmsfretefobicmsantecip
        {
            get { return  percicmsfretefobicmsantecip; }
            set {  percicmsfretefobicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBSTULTENTANT
        /// Coment�rio: Percentual ICMS frete FOB ST anterior.
        /// </summary>
        private decimal percicmsfretefobstultentant;
        [XmlElement(ElementName = "PERCICMSFRETEFOBSTULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmsfretefobstultentant
        {
            get { return  percicmsfretefobstultentant; }
            set {  percicmsfretefobstultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSSIMPLESNAC
        /// Coment�rio: Percentual Simples Nacional
        /// </summary>
        private decimal percicmssimplesnac;
        [XmlElement(ElementName = "PERCICMSSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percicmssimplesnac
        {
            get { return  percicmssimplesnac; }
            set {  percicmssimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPIOUTRAS
        /// Coment�rio: Percentual de IPI
        /// </summary>
        private decimal percipioutras;
        [XmlElement(ElementName = "PERCIPIOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percipioutras
        {
            get { return  percipioutras; }
            set {  percipioutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPISUSPENSO
        /// Coment�rio: Percentual do IPI suspenso
        /// </summary>
        private decimal percipisuspenso;
        [XmlElement(ElementName = "PERCIPISUSPENSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percipisuspenso
        {
            get { return  percipisuspenso; }
            set {  percipisuspenso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMVAORIG
        /// Coment�rio: Percentual de MVA Original para c�lculo do MVA ajustado
        /// </summary>
        private decimal percmvaorig;
        [XmlElement(ElementName = "PERCMVAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percmvaorig
        {
            get { return  percmvaorig; }
            set {  percmvaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMVAORIGICMSANTECIP
        /// Coment�rio: % IVA Original ICMS Antecipado
        /// </summary>
        private decimal percmvaorigicmsantecip;
        [XmlElement(ElementName = "PERCMVAORIGICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percmvaorigicmsantecip
        {
            get { return  percmvaorigicmsantecip; }
            set {  percmvaorigicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINSBKP
        /// Coment�rio: Backup da al�quota de COFINS
        /// </summary>
        private decimal percofinsbkp;
        [XmlElement(ElementName = "PERCOFINSBKP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percofinsbkp
        {
            get { return  percofinsbkp; }
            set {  percofinsbkp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINSCALCDI
        /// Coment�rio: Percentual de COFINS calculo da D.I.
        /// </summary>
        private decimal percofinscalcdi;
        [XmlElement(ElementName = "PERCOFINSCALCDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percofinscalcdi
        {
            get { return  percofinscalcdi; }
            set {  percofinscalcdi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINSFRETEFOB
        /// Coment�rio: Percentual COFINS Frete FOB
        /// </summary>
        private decimal percofinsfretefob;
        [XmlElement(ElementName = "PERCOFINSFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percofinsfretefob
        {
            get { return  percofinsfretefob; }
            set {  percofinsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTRASDESPIMP
        /// Coment�rio: Percentual de outras despesas importa��o
        /// </summary>
        private decimal percoutrasdespimp;
        [XmlElement(ElementName = "PERCOUTRASDESPIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percoutrasdespimp
        {
            get { return  percoutrasdespimp; }
            set {  percoutrasdespimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTRASDESPIMPCUSTO
        /// Coment�rio: Percentual Outras Despesas Importa��o Custo
        /// </summary>
        private decimal percoutrasdespimpcusto;
        [XmlElement(ElementName = "PERCOUTRASDESPIMPCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percoutrasdespimpcusto
        {
            get { return  percoutrasdespimpcusto; }
            set {  percoutrasdespimpcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTROSCUSTOSCUSTO
        /// Coment�rio: Percentual Outros Custos Importa��o Custo
        /// </summary>
        private decimal percoutroscustoscusto;
        [XmlElement(ElementName = "PERCOUTROSCUSTOSCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percoutroscustoscusto
        {
            get { return  percoutroscustoscusto; }
            set {  percoutroscustoscusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPEDAGIO
        /// Coment�rio: Percentual do ped�gio sobre o item.
        /// </summary>
        private decimal percpedagio;
        [XmlElement(ElementName = "PERCPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percpedagio
        {
            get { return  percpedagio; }
            set {  percpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDPMC
        /// Coment�rio: Perc.redu��o PMC
        /// </summary>
        private decimal percredpmc;
        [XmlElement(ElementName = "PERCREDPMC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percredpmc
        {
            get { return  percredpmc; }
            set {  percredpmc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSEGUROCUSTO
        /// Coment�rio: Percentual de seguro NF custo
        /// </summary>
        private decimal percsegurocusto;
        [XmlElement(ElementName = "PERCSEGUROCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percsegurocusto
        {
            get { return  percsegurocusto; }
            set {  percsegurocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSISCOMEX
        /// Coment�rio: Percentual de taxas com siscomex
        /// </summary>
        private decimal percsiscomex;
        [XmlElement(ElementName = "PERCSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percsiscomex
        {
            get { return  percsiscomex; }
            set {  percsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSISCOMEXCUSTO
        /// Coment�rio: Percentual Siscomex Custo
        /// </summary>
        private decimal percsiscomexcusto;
        [XmlElement(ElementName = "PERCSISCOMEXCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percsiscomexcusto
        {
            get { return  percsiscomexcusto; }
            set {  percsiscomexcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSTOUTRAS
        /// Coment�rio: Percentual de ST
        /// </summary>
        private decimal percstoutras;
        [XmlElement(ElementName = "PERCSTOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percstoutras
        {
            get { return  percstoutras; }
            set {  percstoutras = value; }
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
        /// Propriedade referente ao campo: PERDIFEREIMENTOICMS
        /// Coment�rio: Percentual diferimento ICMS.
        /// </summary>
        private decimal perdifereimentoicms;
        [XmlElement(ElementName = "PERDIFEREIMENTOICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdifereimentoicms
        {
            get { return  perdifereimentoicms; }
            set {  perdifereimentoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPISBKP
        /// Coment�rio: Backup da al�quota de PIS
        /// </summary>
        private decimal perpisbkp;
        [XmlElement(ElementName = "PERPISBKP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perpisbkp
        {
            get { return  perpisbkp; }
            set {  perpisbkp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPISCALCDI
        /// Coment�rio: Percentual de PIS calculo da D.I.
        /// </summary>
        private decimal perpiscalcdi;
        [XmlElement(ElementName = "PERPISCALCDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perpiscalcdi
        {
            get { return  perpiscalcdi; }
            set {  perpiscalcdi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPISFRETEFOB
        /// Coment�rio: Percentual PIS Frete FOB
        /// </summary>
        private decimal perpisfretefob;
        [XmlElement(ElementName = "PERPISFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perpisfretefob
        {
            get { return  perpisfretefob; }
            set {  perpisfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISCOFINSDEDUZIDO
        /// Coment�rio: PIS/COFINS deduzido do valor do produto
        /// </summary>
        private string piscofinsdeduzido;
        [XmlElement(ElementName = "PISCOFINSDEDUZIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Piscofinsdeduzido
        {
            get { return  piscofinsdeduzido; }
            set {  piscofinsdeduzido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISRETIDO
        /// Coment�rio: Percentual PIS retido venda.
        /// </summary>
        private decimal pisretido;
        [XmlElement(ElementName = "PISRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Pisretido
        {
            get { return  pisretido; }
            set {  pisretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORIGINAL
        /// Coment�rio: Pre�o original
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
        /// Propriedade referente ao campo: PRACA
        /// Coment�rio: Identifica��o da pra�a
        /// </summary>
        private string praca;
        [XmlElement(ElementName = "PRACA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Praca
        {
            get { return  praca; }
            set {  praca = value; }
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
        /// Propriedade referente ao campo: PTABELACUSTO
        /// Coment�rio: Pre�o de Compra Custo
        /// </summary>
        private decimal ptabelacusto;
        [XmlElement(ElementName = "PTABELACUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelacusto
        {
            get { return  ptabelacusto; }
            set {  ptabelacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIGITADA
        /// Coment�rio: Quantidade digitada pelo us�ario.
        /// </summary>
        private decimal qtdigitada;
        [XmlElement(ElementName = "QTDIGITADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtdigitada
        {
            get { return  qtdigitada; }
            set {  qtdigitada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT_ENTRADAMANIF
        /// Coment�rio: Quantidade de entrada que ficou no caminh�o
        /// </summary>
        private decimal qt_entradamanif;
        [XmlElement(ElementName = "QT_ENTRADAMANIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt_Entradamanif
        {
            get { return  qt_entradamanif; }
            set {  qt_entradamanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLITRAGEM
        /// Coment�rio: Quantidade litragem
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
        /// Propriedade referente ao campo: QTPERDA
        /// Coment�rio: Campo para armazenar a quantidade de insumos que foram perdidas durante o processo de beneficiamento.
        /// </summary>
        private decimal qtperda;
        [XmlElement(ElementName = "QTPERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtperda
        {
            get { return  qtperda; }
            set {  qtperda = value; }
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
        /// Propriedade referente ao campo: REDBASEALIQEXTICMSANTECIP
        /// Coment�rio: % Redu��o Aliquota externa ICMS Antecipado.
        /// </summary>
        private decimal redbasealiqexticmsantecip;
        [XmlElement(ElementName = "REDBASEALIQEXTICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbasealiqexticmsantecip
        {
            get { return  redbasealiqexticmsantecip; }
            set {  redbasealiqexticmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVAICMSANTECIP
        /// Coment�rio: % Redu��o IVA Icms Antecipado
        /// </summary>
        private decimal redbaseivaicmsantecip;
        [XmlElement(ElementName = "REDBASEIVAICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbaseivaicmsantecip
        {
            get { return  redbaseivaicmsantecip; }
            set {  redbaseivaicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVAULTENTANT
        /// Coment�rio: Redu��o da base c�lculo ST anterior.
        /// </summary>
        private decimal redbaseivaultentant;
        [XmlElement(ElementName = "REDBASEIVAULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbaseivaultentant
        {
            get { return  redbaseivaultentant; }
            set {  redbaseivaultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGIMEESPECIAL
        /// Coment�rio: Regime Especial.
        /// </summary>
        private string regimeespecial;
        [XmlElement(ElementName = "REGIMEESPECIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Regimeespecial
        {
            get { return  regimeespecial; }
            set {  regimeespecial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STBCRANT
        /// Coment�rio: ST Bcr anterior.
        /// </summary>
        private decimal stbcrant;
        [XmlElement(ElementName = "STBCRANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stbcrant
        {
            get { return  stbcrant; }
            set {  stbcrant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STPBASERCA
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: SUBSTANCIA
        /// Coment�rio: Gravar a substancia do produto para obter um controle especial
        /// </summary>
        private string substancia;
        [XmlElement(ElementName = "SUBSTANCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Substancia
        {
            get { return  substancia; }
            set {  substancia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUJDESONERACAO
        /// Coment�rio: Este par�metro ira dizer se o produto esta ou n�o sujeito a desonera��o
        /// </summary>
        private string sujdesoneracao;
        [XmlElement(ElementName = "SUJDESONERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sujdesoneracao
        {
            get { return  sujdesoneracao; }
            set {  sujdesoneracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCST
        /// Coment�rio: Tipo do calculo do ST
        /// </summary>
        private string tipocalcst;
        [XmlElement(ElementName = "TIPOCALCST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalcst
        {
            get { return  tipocalcst; }
            set {  tipocalcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADETRIB
        /// Coment�rio: Unidade tribut�vel.
        /// </summary>
        private string unidadetrib;
        [XmlElement(ElementName = "UNIDADETRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Unidadetrib
        {
            get { return  unidadetrib; }
            set {  unidadetrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPISCOFINSLIT
        /// Coment�rio: Usa PIS/COFINS por litragem
        /// </summary>
        private string usapiscofinslit;
        [XmlElement(ElementName = "USAPISCOFINSLIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapiscofinslit
        {
            get { return  usapiscofinslit; }
            set {  usapiscofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPMCBASEST
        /// Coment�rio: Usa PMC base ST
        /// </summary>
        private string usapmcbasest;
        [XmlElement(ElementName = "USAPMCBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapmcbasest
        {
            get { return  usapmcbasest; }
            set {  usapmcbasest = value; }
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
        /// Propriedade referente ao campo: UTILIZABASEPISCOFINSSUSP
        /// Coment�rio: Utiliza Base PIS/COFINS Suspenso.
        /// </summary>
        private string utilizabasepiscofinssusp;
        [XmlElement(ElementName = "UTILIZABASEPISCOFINSSUSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizabasepiscofinssusp
        {
            get { return  utilizabasepiscofinssusp; }
            set {  utilizabasepiscofinssusp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACREDREDPISCOFINS
        /// Coment�rio: Al�quota cr�dito reduzido PIS/COFINS
        /// </summary>
        private string utilizacredredpiscofins;
        [XmlElement(ElementName = "UTILIZACREDREDPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacredredpiscofins
        {
            get { return  utilizacredredpiscofins; }
            set {  utilizacredredpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOREGISTRO
        /// Coment�rio: Define a vers�o do sistema que o registro foi gravado.
        /// </summary>
        private string versaoregistro;
        [XmlElement(ElementName = "VERSAOREGISTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Versaoregistro
        {
            get { return  versaoregistro; }
            set {  versaoregistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESCIMOFUNCEP
        /// Coment�rio: Valor de Acr�scimo do Fundo de Combate e Erradica��o da Pobreza
        /// </summary>
        private decimal vlacrescimofuncep;
        [XmlElement(ElementName = "VLACRESCIMOFUNCEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlacrescimofuncep
        {
            get { return  vlacrescimofuncep; }
            set {  vlacrescimofuncep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONALBCICMSANTECIP
        /// Coment�rio: Valor adicional base Icms Antecipado
        /// </summary>
        private decimal vladicionalbcicmsantecip;
        [XmlElement(ElementName = "VLADICIONALBCICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vladicionalbcicmsantecip
        {
            get { return  vladicionalbcicmsantecip; }
            set {  vladicionalbcicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADUANEIRACUSTO
        /// Coment�rio: Valor Despesa Aduaneira Custo
        /// </summary>
        private decimal vladuaneiracusto;
        [XmlElement(ElementName = "VLADUANEIRACUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vladuaneiracusto
        {
            get { return  vladuaneiracusto; }
            set {  vladuaneiracusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAFRMM
        /// Coment�rio: Valor do Adicional de Frete para a Renova��o da Marinha Mercante
        /// </summary>
        private decimal vlafrmm;
        [XmlElement(ElementName = "VLAFRMM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlafrmm
        {
            get { return  vlafrmm; }
            set {  vlafrmm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAFRMMCUSTO
        /// Coment�rio: Valor do Adicional de Frete para a Renova��o da Marinha Mercante
        /// </summary>
        private decimal vlafrmmcusto;
        [XmlElement(ElementName = "VLAFRMMCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlafrmmcusto
        {
            get { return  vlafrmmcusto; }
            set {  vlafrmmcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLALTERCUSTOENT
        /// Coment�rio: Acr�scmo no Custo da �ltima Entrada.
        /// </summary>
        private decimal vlaltercustoent;
        [XmlElement(ElementName = "VLALTERCUSTOENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlaltercustoent
        {
            get { return  vlaltercustoent; }
            set {  vlaltercustoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLANTIDUMPING
        /// Coment�rio: Valor Antidumping DI
        /// </summary>
        private decimal vlantidumping;
        [XmlElement(ElementName = "VLANTIDUMPING", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlantidumping
        {
            get { return  vlantidumping; }
            set {  vlantidumping = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLANTIDUMPINGCUSTO
        /// Coment�rio: Valor Antidumping Custo
        /// </summary>
        private decimal vlantidumpingcusto;
        [XmlElement(ElementName = "VLANTIDUMPINGCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlantidumpingcusto
        {
            get { return  vlantidumpingcusto; }
            set {  vlantidumpingcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEFRETE
        /// Coment�rio: Valor da base do frete do item
        /// </summary>
        private decimal vlbasefrete;
        [XmlElement(ElementName = "VLBASEFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasefrete
        {
            get { return  vlbasefrete; }
            set {  vlbasefrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEICMSFRETEFOB
        /// Coment�rio: Valor base ICMS Frete FOB
        /// </summary>
        private decimal vlbaseicmsfretefob;
        [XmlElement(ElementName = "VLBASEICMSFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbaseicmsfretefob
        {
            get { return  vlbaseicmsfretefob; }
            set {  vlbaseicmsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPISUSPENSO
        /// Coment�rio: Base do IPI suspenso
        /// </summary>
        private decimal vlbaseipisuspenso;
        [XmlElement(ElementName = "VLBASEIPISUSPENSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbaseipisuspenso
        {
            get { return  vlbaseipisuspenso; }
            set {  vlbaseipisuspenso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEOUTROS
        /// Coment�rio: Valor da base da outras despesas do item
        /// </summary>
        private decimal vlbaseoutros;
        [XmlElement(ElementName = "VLBASEOUTROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbaseoutros
        {
            get { return  vlbaseoutros; }
            set {  vlbaseoutros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEPISCOFINSBKP
        /// Coment�rio: Backup da base de PIS/COFINS
        /// </summary>
        private decimal vlbasepiscofinsbkp;
        [XmlElement(ElementName = "VLBASEPISCOFINSBKP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasepiscofinsbkp
        {
            get { return  vlbasepiscofinsbkp; }
            set {  vlbasepiscofinsbkp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEPISCOFINSFRETEFOB
        /// Coment�rio: Valor base PIS/COFINS Frete FOB
        /// </summary>
        private decimal vlbasepiscofinsfretefob;
        [XmlElement(ElementName = "VLBASEPISCOFINSFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasepiscofinsfretefob
        {
            get { return  vlbasepiscofinsfretefob; }
            set {  vlbasepiscofinsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCAPATAZIA
        /// Coment�rio: Valor da capatazia rateado entre os itens de importa��o.
        /// </summary>
        private decimal vlcapatazia;
        [XmlElement(ElementName = "VLCAPATAZIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcapatazia
        {
            get { return  vlcapatazia; }
            set {  vlcapatazia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCAPATAZIACUSTO
        /// Coment�rio: Valor da capatazia NF custo
        /// </summary>
        private decimal vlcapataziacusto;
        [XmlElement(ElementName = "VLCAPATAZIACUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcapataziacusto
        {
            get { return  vlcapataziacusto; }
            set {  vlcapataziacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINSCALCDI
        /// Coment�rio: Valor do COFINS suspenso
        /// </summary>
        private decimal vlcofinscalcdi;
        [XmlElement(ElementName = "VLCOFINSCALCDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofinscalcdi
        {
            get { return  vlcofinscalcdi; }
            set {  vlcofinscalcdi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINSRETIDO
        /// Coment�rio: Valor COFINS retido venda.
        /// </summary>
        private decimal vlcofinsretido;
        [XmlElement(ElementName = "VLCOFINSRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofinsretido
        {
            get { return  vlcofinsretido; }
            set {  vlcofinsretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDCOFINSBKP
        /// Coment�rio: Backup do valor do COFINS
        /// </summary>
        private decimal vlcredcofinsbkp;
        [XmlElement(ElementName = "VLCREDCOFINSBKP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredcofinsbkp
        {
            get { return  vlcredcofinsbkp; }
            set {  vlcredcofinsbkp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDCOFINSFRETEFOB
        /// Coment�rio: Valor COFINS Frete FOB
        /// </summary>
        private decimal vlcredcofinsfretefob;
        [XmlElement(ElementName = "VLCREDCOFINSFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredcofinsfretefob
        {
            get { return  vlcredcofinsfretefob; }
            set {  vlcredcofinsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPISBKP
        /// Coment�rio: Backup do valor do PIS
        /// </summary>
        private decimal vlcredpisbkp;
        [XmlElement(ElementName = "VLCREDPISBKP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpisbkp
        {
            get { return  vlcredpisbkp; }
            set {  vlcredpisbkp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPISFRETEFOB
        /// Coment�rio: Valor PIS Frete FOB
        /// </summary>
        private decimal vlcredpisfretefob;
        [XmlElement(ElementName = "VLCREDPISFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpisfretefob
        {
            get { return  vlcredpisfretefob; }
            set {  vlcredpisfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCSLLRETIDO
        /// Coment�rio: Valor CSLL retido venda.
        /// </summary>
        private decimal vlcsllretido;
        [XmlElement(ElementName = "VLCSLLRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcsllretido
        {
            get { return  vlcsllretido; }
            set {  vlcsllretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCABATIMENTO
        /// Coment�rio: GRAVAR O VALOR DO DESCONTO DO ABATIMENTO
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
        /// Propriedade referente ao campo: VLDESCONTOCUSTO
        /// Coment�rio: Valor das Dedu��es Custo
        /// </summary>
        private decimal vldescontocusto;
        [XmlElement(ElementName = "VLDESCONTOCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescontocusto
        {
            get { return  vldescontocusto; }
            set {  vldescontocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCORGAOPUB
        /// Coment�rio: Desconto para org�o p�blico.
        /// </summary>
        private decimal vldescorgaopub;
        [XmlElement(ElementName = "VLDESCORGAOPUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vldescorgaopub
        {
            get { return  vldescorgaopub; }
            set {  vldescorgaopub = value; }
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
        /// Propriedade referente ao campo: VLDESPDENTRONFCUSTO
        /// Coment�rio: Valor do acr�scimo NF custo
        /// </summary>
        private decimal vldespdentronfcusto;
        [XmlElement(ElementName = "VLDESPDENTRONFCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespdentronfcusto
        {
            get { return  vldespdentronfcusto; }
            set {  vldespdentronfcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFECP
        /// Coment�rio: Valor Fecp.
        /// </summary>
        private decimal vlfecp;
        [XmlElement(ElementName = "VLFECP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfecp
        {
            get { return  vlfecp; }
            set {  vlfecp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETECONHECULTENTANT
        /// Coment�rio: Valor frete FOB anterior.
        /// </summary>
        private decimal vlfreteconhecultentant;
        [XmlElement(ElementName = "VLFRETECONHECULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfreteconhecultentant
        {
            get { return  vlfreteconhecultentant; }
            set {  vlfreteconhecultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETENFCUSTO
        /// Coment�rio: Valor do frete NF custo
        /// </summary>
        private decimal vlfretenfcusto;
        [XmlElement(ElementName = "VLFRETENFCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfretenfcusto
        {
            get { return  vlfretenfcusto; }
            set {  vlfretenfcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Coment�rio: Valor do ICMS.
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSANTECIPADO
        /// Coment�rio: Valor do ICMS Antecipado
        /// </summary>
        private decimal vlicmsantecipado;
        [XmlElement(ElementName = "VLICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicmsantecipado
        {
            get { return  vlicmsantecipado; }
            set {  vlicmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSCUSTOFRETEFOB
        /// Coment�rio: Valor do ICMS p/ calculo do custo Frete FOB
        /// </summary>
        private decimal vlicmscustofretefob;
        [XmlElement(ElementName = "VLICMSCUSTOFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicmscustofretefob
        {
            get { return  vlicmscustofretefob; }
            set {  vlicmscustofretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSDIFERIDO
        /// Coment�rio: Valor ICMS diferido.
        /// </summary>
        private decimal vlicmsdiferido;
        [XmlElement(ElementName = "VLICMSDIFERIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicmsdiferido
        {
            get { return  vlicmsdiferido; }
            set {  vlicmsdiferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSFRETEFOB
        /// Coment�rio: Valor do ICMS Frete FOB
        /// </summary>
        private decimal vlicmsfretefob;
        [XmlElement(ElementName = "VLICMSFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicmsfretefob
        {
            get { return  vlicmsfretefob; }
            set {  vlicmsfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIISUSPENSO
        /// Coment�rio: Valor do II Suspenso.
        /// </summary>
        private decimal vliisuspenso;
        [XmlElement(ElementName = "VLIISUSPENSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vliisuspenso
        {
            get { return  vliisuspenso; }
            set {  vliisuspenso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIMPORTACAOFCI
        /// Coment�rio: Valor de Importa��o.
        /// </summary>
        private decimal vlimportacaofci;
        [XmlElement(ElementName = "VLIMPORTACAOFCI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlimportacaofci
        {
            get { return  vlimportacaofci; }
            set {  vlimportacaofci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIOUTRAS
        /// Coment�rio: Valor do IPI
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
        /// Propriedade referente ao campo: VLIPISUSPENSO
        /// Coment�rio: Valor do IPI suspenso
        /// </summary>
        private decimal vlipisuspenso;
        [XmlElement(ElementName = "VLIPISUSPENSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipisuspenso
        {
            get { return  vlipisuspenso; }
            set {  vlipisuspenso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIRRETIDO
        /// Coment�rio: Valor IR retido venda.
        /// </summary>
        private decimal vlirretido;
        [XmlElement(ElementName = "VLIRRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlirretido
        {
            get { return  vlirretido; }
            set {  vlirretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLITEMTRIBUTOS
        /// Coment�rio: VALOR DOS TRIBUTOS POR ITEM.
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
        /// Propriedade referente ao campo: VLOUTRASDESPIMPCUSTO
        /// Coment�rio: Valor Outras Despesas Importa��o Custo
        /// </summary>
        private decimal vloutrasdespimpcusto;
        [XmlElement(ElementName = "VLOUTRASDESPIMPCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutrasdespimpcusto
        {
            get { return  vloutrasdespimpcusto; }
            set {  vloutrasdespimpcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTROSCUSTOS
        /// Coment�rio: Valor de outros custos do item de importa��o.
        /// </summary>
        private decimal vloutroscustos;
        [XmlElement(ElementName = "VLOUTROSCUSTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutroscustos
        {
            get { return  vloutroscustos; }
            set {  vloutroscustos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTROSCUSTOSCUSTO
        /// Coment�rio: Valor Outros Custos Importa��o Custo
        /// </summary>
        private decimal vloutroscustoscusto;
        [XmlElement(ElementName = "VLOUTROSCUSTOSCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutroscustoscusto
        {
            get { return  vloutroscustoscusto; }
            set {  vloutroscustoscusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPARCELAIMPFCI
        /// Coment�rio: Valor da Parcela Importada.
        /// </summary>
        private decimal vlparcelaimpfci;
        [XmlElement(ElementName = "VLPARCELAIMPFCI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlparcelaimpfci
        {
            get { return  vlparcelaimpfci; }
            set {  vlparcelaimpfci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAIPI
        /// Coment�rio: Informar valor da pauta do IPI na tabela PCMOVCOMPLE.
        /// </summary>
        private decimal vlpautaipi;
        [XmlElement(ElementName = "VLPAUTAIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautaipi
        {
            get { return  vlpautaipi; }
            set {  vlpautaipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAPISCOFINS
        /// Coment�rio: Valor pauta PIS/COFINS
        /// </summary>
        private decimal vlpautapiscofins;
        [XmlElement(ElementName = "VLPAUTAPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautapiscofins
        {
            get { return  vlpautapiscofins; }
            set {  vlpautapiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPEDAGIO
        /// Coment�rio: Valor do ped�gio sobre o item.
        /// </summary>
        private decimal vlpedagio;
        [XmlElement(ElementName = "VLPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpedagio
        {
            get { return  vlpedagio; }
            set {  vlpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPISCALCDI
        /// Coment�rio: Valor do PIS suspenso
        /// </summary>
        private decimal vlpiscalcdi;
        [XmlElement(ElementName = "VLPISCALCDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpiscalcdi
        {
            get { return  vlpiscalcdi; }
            set {  vlpiscalcdi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPISRETIDO
        /// Coment�rio: Valor PIS retido venda.
        /// </summary>
        private decimal vlpisretido;
        [XmlElement(ElementName = "VLPISRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpisretido
        {
            get { return  vlpisretido; }
            set {  vlpisretido = value; }
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
        /// Propriedade referente ao campo: VLRICMSSIMPLESNAC
        /// Coment�rio: Valor de ICMS Simples Nacional
        /// </summary>
        private decimal vlricmssimplesnac;
        [XmlElement(ElementName = "VLRICMSSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlricmssimplesnac
        {
            get { return  vlricmssimplesnac; }
            set {  vlricmssimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGUROCUSTO
        /// Coment�rio: Valor do seguro NF custo
        /// </summary>
        private decimal vlsegurocusto;
        [XmlElement(ElementName = "VLSEGUROCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsegurocusto
        {
            get { return  vlsegurocusto; }
            set {  vlsegurocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSISCOMEXCUSTO
        /// Coment�rio: Valor Siscomex Custo
        /// </summary>
        private decimal vlsiscomexcusto;
        [XmlElement(ElementName = "VLSISCOMEXCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsiscomexcusto
        {
            get { return  vlsiscomexcusto; }
            set {  vlsiscomexcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTGUIAULTENTANT
        /// Coment�rio: Valor do ST GUIA anterior.
        /// </summary>
        private decimal vlstguiaultentant;
        [XmlElement(ElementName = "VLSTGUIAULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstguiaultentant
        {
            get { return  vlstguiaultentant; }
            set {  vlstguiaultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTOUTRAS
        /// Coment�rio: Valor do ST
        /// </summary>
        private decimal vlstoutras;
        [XmlElement(ElementName = "VLSTOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstoutras
        {
            get { return  vlstoutras; }
            set {  vlstoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTULTENTANT
        /// Coment�rio: Valor do ST anterior.
        /// </summary>
        private decimal vlstultentant;
        [XmlElement(ElementName = "VLSTULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstultentant
        {
            get { return  vlstultentant; }
            set {  vlstultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUBTOTDESCONTO
        /// Coment�rio: Valor do subtotal de desconto do item.
        /// </summary>
        private decimal vlsubtotdesconto;
        [XmlElement(ElementName = "VLSUBTOTDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlsubtotdesconto
        {
            get { return  vlsubtotdesconto; }
            set {  vlsubtotdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUBTOTITEM
        /// Coment�rio: Valor SubTotal do Item - ECF
        /// </summary>
        private decimal vlsubtotitem;
        [XmlElement(ElementName = "VLSUBTOTITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlsubtotitem
        {
            get { return  vlsubtotitem; }
            set {  vlsubtotitem = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMovcomple()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVCOMPLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovcomple> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovcomple>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMovcomple> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovcomple>(where);
        }

        #endregion
    }
}
