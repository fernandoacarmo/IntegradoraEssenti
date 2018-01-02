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
    /// Classe referente a tabela PCTribfigura
    /// </summary>
    [XmlType("PCTRIBFIGURA")]
    public class PCTribfigura : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APLICPERCIVAPAUTA
        /// Comentário: Aplica %IVA sobre a Pauta ST.
        /// </summary>
        private string aplicpercivapauta;
        [XmlElement(ElementName = "APLICPERCIVAPAUTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicpercivapauta
        {
            get { return  aplicpercivapauta; }
            set {  aplicpercivapauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICPERCIVAPAUTAICMSANTECIP
        /// Comentário: Aplica IVA sobre valor de pauta ICMS antecipado
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
        /// Comentário: Aplicar redução base IVA preço liquido
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
        /// Comentário: Aplicar redução base IVA preço liquido BCR
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
        /// Propriedade referente ao campo: BASEPISCOFINSLIT
        /// Comentário: Base PIS/COFINS por litragem
        /// </summary>
        private decimal basepiscofinslit;
        [XmlElement(ElementName = "BASEPISCOFINSLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basepiscofinslit
        {
            get { return  basepiscofinslit; }
            set {  basepiscofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDIPI
        /// Comentário: Calcula crédito de IPI.
        /// </summary>
        private string calccredipi;
        [XmlElement(ElementName = "CALCCREDIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredipi
        {
            get { return  calccredipi; }
            set {  calccredipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDIPICONT
        /// Comentário: Calcula crédito IPI custo contabil na importação
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
        /// Propriedade referente ao campo: CODFIGURA
        /// Comentário: Código figura tributária.
        /// </summary>
        private decimal codfigura;
        [XmlElement(ElementName = "CODFIGURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfigura
        {
            get { return  codfigura; }
            set {  codfigura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCOCOMPRA
        /// Comentário: CFOP Compra e Ordem - Compra
        /// </summary>
        private decimal codfiscalcocompra;
        [XmlElement(ElementName = "CODFISCALCOCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalcocompra
        {
            get { return  codfiscalcocompra; }
            set {  codfiscalcocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONSIG
        /// Comentário: Cód.Fiscal - Entrada consignação.
        /// </summary>
        private decimal codfiscalconsig;
        [XmlElement(ElementName = "CODFISCALCONSIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalconsig
        {
            get { return  codfiscalconsig; }
            set {  codfiscalconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONSIGFAT
        /// Comentário: Cód.Fiscal - Entrada consig.fatura.
        /// </summary>
        private decimal codfiscalconsigfat;
        [XmlElement(ElementName = "CODFISCALCONSIGFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalconsigfat
        {
            get { return  codfiscalconsigfat; }
            set {  codfiscalconsigfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCOREMESSA
        /// Comentário: CFOP Compra e Ordem - Remessa
        /// </summary>
        private decimal codfiscalcoremessa;
        [XmlElement(ElementName = "CODFISCALCOREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalcoremessa
        {
            get { return  codfiscalcoremessa; }
            set {  codfiscalcoremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVFORNEC
        /// Comentário: CFOP DEVOLUÇÃO FORNECEDOR 
        /// </summary>
        private decimal codfiscaldevfornec;
        [XmlElement(ElementName = "CODFISCALDEVFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevfornec
        {
            get { return  codfiscaldevfornec; }
            set {  codfiscaldevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVOPLOG
        /// Comentário: Código Fiscal Devolução Transf. Operador Logístico
        /// </summary>
        private decimal codfiscaldevoplog;
        [XmlElement(ElementName = "CODFISCALDEVOPLOG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevoplog
        {
            get { return  codfiscaldevoplog; }
            set {  codfiscaldevoplog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENT
        /// Comentário: Cód.Fiscal - Entrada.
        /// </summary>
        private decimal codfiscalent;
        [XmlElement(ElementName = "CODFISCALENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalent
        {
            get { return  codfiscalent; }
            set {  codfiscalent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTBONIFIC
        /// Comentário: Cód.Fiscal - Entrada bonificação.
        /// </summary>
        private decimal codfiscalentbonific;
        [XmlElement(ElementName = "CODFISCALENTBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentbonific
        {
            get { return  codfiscalentbonific; }
            set {  codfiscalentbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTOPLOG
        /// Comentário: Código Fiscal Entrada Transf. Operador Logístico
        /// </summary>
        private decimal codfiscalentoplog;
        [XmlElement(ElementName = "CODFISCALENTOPLOG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentoplog
        {
            get { return  codfiscalentoplog; }
            set {  codfiscalentoplog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTSR
        /// Comentário: Cód.Fiscal - Entrada simples remessa.
        /// </summary>
        private decimal codfiscalentsr;
        [XmlElement(ElementName = "CODFISCALENTSR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentsr
        {
            get { return  codfiscalentsr; }
            set {  codfiscalentsr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTTRANSF
        /// Comentário: Cód.Fiscal - Entrada transferência.
        /// </summary>
        private decimal codfiscalenttransf;
        [XmlElement(ElementName = "CODFISCALENTTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalenttransf
        {
            get { return  codfiscalenttransf; }
            set {  codfiscalenttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTTV9
        /// Comentário: Apresenta o Código fiscal de entrada TV9
        /// </summary>
        private decimal codfiscalenttv9;
        [XmlElement(ElementName = "CODFISCALENTTV9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalenttv9
        {
            get { return  codfiscalenttv9; }
            set {  codfiscalenttv9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINS
        /// Comentário: Indica o Código da Situação Tributária Referente ao PIS/COFINS
        /// </summary>
        private decimal codsittribpiscofins;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribpiscofins
        {
            get { return  codsittribpiscofins; }
            set {  codsittribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINSDEV
        /// Comentário: Código Situação Tributaria PIS/COFINS devolução
        /// </summary>
        private decimal codsittribpiscofinsdev;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINSDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribpiscofinsdev
        {
            get { return  codsittribpiscofinsdev; }
            set {  codsittribpiscofinsdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBST
        /// Comentário: GRAVAR O CÓDIGO DA SITUAÇÃO TRIBUTÁRIA ST
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
        /// Propriedade referente ao campo: CONSIISUSPENSOBASEICMS
        /// Comentário: Considera II Suspenso base ICMS.
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
        /// Comentário: Considera IPI Suspenso base ICMS.
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição da figura.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data de cadastro.
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERABASEPISCOFINSSEMALIQ
        /// Comentário: Defina se deve gerar base de PIS/CONFINS mesmo quando não for informado aliquotas de PIS/CONFINS
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
        /// Propriedade referente ao campo: GERAICMSLIVROFISCALDEVFORNEC
        /// Comentário: Gerar icms livro fiscal na devolução fornecedor
        /// </summary>
        private string geraicmslivrofiscaldevfornec;
        [XmlElement(ElementName = "GERAICMSLIVROFISCALDEVFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraicmslivrofiscaldevfornec
        {
            get { return  geraicmslivrofiscaldevfornec; }
            set {  geraicmslivrofiscaldevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IPIPORVALOR
        /// Comentário: Define se o produto utiliza IPI com valor fixo
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
        /// Propriedade referente ao campo: PERCALIQEXT
        /// Comentário: %Alíquota Externa.
        /// </summary>
        private decimal percaliqext;
        [XmlElement(ElementName = "PERCALIQEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqext
        {
            get { return  percaliqext; }
            set {  percaliqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTBCR
        /// Comentário: %Alíquota Externa - BCR.
        /// </summary>
        private decimal percaliqextbcr;
        [XmlElement(ElementName = "PERCALIQEXTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percaliqextbcr
        {
            get { return  percaliqextbcr; }
            set {  percaliqextbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTGUIA
        /// Comentário: %Alíquota Externa ST Guia.
        /// </summary>
        private decimal percaliqextguia;
        [XmlElement(ElementName = "PERCALIQEXTGUIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqextguia
        {
            get { return  percaliqextguia; }
            set {  percaliqextguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTICMANTECIP
        /// Comentário: Percentual Aliquota Externa  ICMS Antecipado
        /// </summary>
        private decimal percaliqexticmantecip;
        [XmlElement(ElementName = "PERCALIQEXTICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqexticmantecip
        {
            get { return  percaliqexticmantecip; }
            set {  percaliqexticmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINT
        /// Comentário: %Alíquota Interna.
        /// </summary>
        private decimal percaliqint;
        [XmlElement(ElementName = "PERCALIQINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqint
        {
            get { return  percaliqint; }
            set {  percaliqint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINTBCR
        /// Comentário: %Alíquota Interna - BCR.
        /// </summary>
        private decimal percaliqintbcr;
        [XmlElement(ElementName = "PERCALIQINTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percaliqintbcr
        {
            get { return  percaliqintbcr; }
            set {  percaliqintbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINTICMANTECIP
        /// Comentário: Percentual Aliquota Interna ICMS Antecipado
        /// </summary>
        private decimal percaliqinticmantecip;
        [XmlElement(ElementName = "PERCALIQINTICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqinticmantecip
        {
            get { return  percaliqinticmantecip; }
            set {  percaliqinticmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDENT
        /// Comentário: .
        /// </summary>
        private decimal percbaseredent;
        [XmlElement(ElementName = "PERCBASEREDENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percbaseredent
        {
            get { return  percbaseredent; }
            set {  percbaseredent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDST
        /// Comentário: %Redução Base ST.
        /// </summary>
        private decimal percbaseredst;
        [XmlElement(ElementName = "PERCBASEREDST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbaseredst
        {
            get { return  percbaseredst; }
            set {  percbaseredst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCARGATRIBMEDIA
        /// Comentário: Percentual de carga tributária média, utilizado no SEFAZ MT para calculo da substituição tributária
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
        /// Comentário: % Carga Média tributária Icms Antecipado
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
        /// Propriedade referente ao campo: PERCCREDICMPRESUMIDO
        /// Comentário: %Créd.ICMS Presumido.
        /// </summary>
        private decimal perccredicmpresumido;
        [XmlElement(ElementName = "PERCCREDICMPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perccredicmpresumido
        {
            get { return  perccredicmpresumido; }
            set {  perccredicmpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCICMSDIF
        /// Comentário: Valor percentual do desconto do ICMS Diferido que incide sobre a mercadoria de importação.
        /// </summary>
        private decimal percdescicmsdif;
        [XmlElement(ElementName = "PERCDESCICMSDIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescicmsdif
        {
            get { return  percdescicmsdif; }
            set {  percdescicmsdif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPADICIONAL
        /// Comentário: %Desp. Adicional.
        /// </summary>
        private decimal percdespadicional;
        [XmlElement(ElementName = "PERCDESPADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdespadicional
        {
            get { return  percdespadicional; }
            set {  percdespadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPDENTRONF
        /// Comentário: %Desp.Dentro da NF.
        /// </summary>
        private decimal percdespdentronf;
        [XmlElement(ElementName = "PERCDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespdentronf
        {
            get { return  percdespdentronf; }
            set {  percdespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFIN
        /// Comentário: Vlr.Desp.Fora da NF.
        /// </summary>
        private decimal percdespfin;
        [XmlElement(ElementName = "PERCDESPFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdespfin
        {
            get { return  percdespfin; }
            set {  percdespfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFORANF
        /// Comentário: %Desp.Fora da NF.
        /// </summary>
        private decimal percdespforanf;
        [XmlElement(ElementName = "PERCDESPFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespforanf
        {
            get { return  percdespforanf; }
            set {  percdespforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFALIQUOTAS
        /// Comentário: %Diferença de alíquotas.
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
        /// Propriedade referente ao campo: PERCFRETE
        /// Comentário: %Frete CIF.
        /// </summary>
        private decimal percfrete;
        [XmlElement(ElementName = "PERCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percfrete
        {
            get { return  percfrete; }
            set {  percfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETEFOB
        /// Comentário: %Frete FOB.
        /// </summary>
        private decimal percfretefob;
        [XmlElement(ElementName = "PERCFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percfretefob
        {
            get { return  percfretefob; }
            set {  percfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Comentário: %ICMS.
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
        /// Propriedade referente ao campo: PERCICMRED
        /// Comentário: %Redução ICMS.
        /// </summary>
        private decimal percicmred;
        [XmlElement(ElementName = "PERCICMRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmred
        {
            get { return  percicmred; }
            set {  percicmred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSBASEICMSANTECIPADO
        /// Comentário: Aliq. Para base do ICMS antecipado
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
        /// Propriedade referente ao campo: PERCICMSDIFERIDO
        /// Comentário: Valor percentual do ICMS Diferido que incide sobre a mercadoria de importação.
        /// </summary>
        private decimal percicmsdiferido;
        [XmlElement(ElementName = "PERCICMSDIFERIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percicmsdiferido
        {
            get { return  percicmsdiferido; }
            set {  percicmsdiferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBICMSANTECIP
        /// Comentário: % ICMS Frete FOB p/ calc.Icms Antecipado
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
        /// Propriedade referente ao campo: PERCICMSFRETEFOBST
        /// Comentário: %ICMS Frete Fob sobre o ST.
        /// </summary>
        private decimal percicmsfretefobst;
        [XmlElement(ElementName = "PERCICMSFRETEFOBST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmsfretefobst
        {
            get { return  percicmsfretefobst; }
            set {  percicmsfretefobst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBSTBCR
        /// Comentário: %ICMS Frete Fob sobre o ST - BCR.
        /// </summary>
        private decimal percicmsfretefobstbcr;
        [XmlElement(ElementName = "PERCICMSFRETEFOBSTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmsfretefobstbcr
        {
            get { return  percicmsfretefobstbcr; }
            set {  percicmsfretefobstbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIISUSPENSO
        /// Comentário: Percentual II Suspenso
        /// </summary>
        private decimal perciisuspenso;
        [XmlElement(ElementName = "PERCIISUSPENSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perciisuspenso
        {
            get { return  perciisuspenso; }
            set {  perciisuspenso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPORTACAO
        /// Comentário: Valor percentual do Imposto de Importação (II) que incide sobre a mercadoria de importação.
        /// </summary>
        private decimal percimportacao;
        [XmlElement(ElementName = "PERCIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percimportacao
        {
            get { return  percimportacao; }
            set {  percimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPISUSPENSO
        /// Comentário: Percentual do IPI suspenso
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
        /// Propriedade referente ao campo: PERCIVA
        /// Comentário: %IVA.
        /// </summary>
        private decimal perciva;
        [XmlElement(ElementName = "PERCIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perciva
        {
            get { return  perciva; }
            set {  perciva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVABCR
        /// Comentário: %IVA - BCR.
        /// </summary>
        private decimal percivabcr;
        [XmlElement(ElementName = "PERCIVABCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percivabcr
        {
            get { return  percivabcr; }
            set {  percivabcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVAICMANTECIP
        /// Comentário: Percentual IVA ICMS Antecipado
        /// </summary>
        private decimal percivaicmantecip;
        [XmlElement(ElementName = "PERCIVAICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percivaicmantecip
        {
            get { return  percivaicmantecip; }
            set {  percivaicmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMVAORIG
        /// Comentário: Percentual de MVA Original para cálculo do MVA ajustado
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
        /// Comentário: % IVA Original ICMS Antecipado
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
        /// Propriedade referente ao campo: PERCOFINS
        /// Comentário: %COFINS.
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINSCALCDI
        /// Comentário: Percentual CODFINS Suspenso
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
        /// Propriedade referente ao campo: PERCOFINSIMP
        /// Comentário: Valor percentual do COFINS que incide sobre a mercadoria de importação.
        /// </summary>
        private decimal percofinsimp;
        [XmlElement(ElementName = "PERCOFINSIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percofinsimp
        {
            get { return  percofinsimp; }
            set {  percofinsimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDICMS
        /// Comentário: %Crédito ICMS.
        /// </summary>
        private decimal percredicms;
        [XmlElement(ElementName = "PERCREDICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percredicms
        {
            get { return  percredicms; }
            set {  percredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSEGURO
        /// Comentário: %Seguro.
        /// </summary>
        private decimal percseguro;
        [XmlElement(ElementName = "PERCSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percseguro
        {
            get { return  percseguro; }
            set {  percseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCST
        /// Comentário: %ST NF.
        /// </summary>
        private decimal percst;
        [XmlElement(ElementName = "PERCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percst
        {
            get { return  percst; }
            set {  percst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSUFRAMA
        /// Comentário: %SUFRAMA.
        /// </summary>
        private decimal percsuframa;
        [XmlElement(ElementName = "PERCSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percsuframa
        {
            get { return  percsuframa; }
            set {  percsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICMSANTECIPADO
        /// Comentário: %ICMS Antecipado.
        /// </summary>
        private decimal pericmsantecipado;
        [XmlElement(ElementName = "PERICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pericmsantecipado
        {
            get { return  pericmsantecipado; }
            set {  pericmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIPI
        /// Comentário: %IPI.
        /// </summary>
        private decimal peripi;
        [XmlElement(ElementName = "PERIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Peripi
        {
            get { return  peripi; }
            set {  peripi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Comentário: %PIS.
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPISCALCDI
        /// Comentário: Percentual PIS Suspenso
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
        /// Propriedade referente ao campo: PERPISIMP
        /// Comentário: Valor percentual do PIS que incide sobre a mercadoria de importação.
        /// </summary>
        private decimal perpisimp;
        [XmlElement(ElementName = "PERPISIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perpisimp
        {
            get { return  perpisimp; }
            set {  perpisimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISCOFINSRETIDO
        /// Comentário: PIS/COFINS Retido.
        /// </summary>
        private string piscofinsretido;
        [XmlElement(ElementName = "PISCOFINSRETIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Piscofinsretido
        {
            get { return  piscofinsretido; }
            set {  piscofinsretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXT
        /// Comentário: %Redução base Alíq. Externa.
        /// </summary>
        private decimal redbasealiqext;
        [XmlElement(ElementName = "REDBASEALIQEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbasealiqext
        {
            get { return  redbasealiqext; }
            set {  redbasealiqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXTBCR
        /// Comentário: %Redução base Alíq. Externa - BCR.
        /// </summary>
        private decimal redbasealiqextbcr;
        [XmlElement(ElementName = "REDBASEALIQEXTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbasealiqextbcr
        {
            get { return  redbasealiqextbcr; }
            set {  redbasealiqextbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXTICMSANTECIP
        /// Comentário: % Redução Aliquota externa ICMS Antecipado.
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
        /// Propriedade referente ao campo: REDBASEIVA
        /// Comentário: %Redução base IVA.
        /// </summary>
        private decimal redbaseiva;
        [XmlElement(ElementName = "REDBASEIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbaseiva
        {
            get { return  redbaseiva; }
            set {  redbaseiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVABCR
        /// Comentário: %Redução base IVA - BCR.
        /// </summary>
        private decimal redbaseivabcr;
        [XmlElement(ElementName = "REDBASEIVABCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbaseivabcr
        {
            get { return  redbaseivabcr; }
            set {  redbaseivabcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVAICMSANTECIP
        /// Comentário: % Redução IVA Icms Antecipado
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
        /// Propriedade referente ao campo: SITTRIBUT
        /// Comentário: Situação Tributária.
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTDEV
        /// Comentário: Código situação tributaria devolucao
        /// </summary>
        private string sittributdev;
        [XmlElement(ElementName = "SITTRIBUTDEV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributdev
        {
            get { return  sittributdev; }
            set {  sittributdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTDEVFORNEC
        /// Comentário: SITUAÇÃO TRIBUTARIA DEVOLUÇÃO FORNECEDOR
        /// </summary>
        private string sittributdevfornec;
        [XmlElement(ElementName = "SITTRIBUTDEVFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributdevfornec
        {
            get { return  sittributdevfornec; }
            set {  sittributdevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTENT
        /// Comentário: Código situação tributaria entrada
        /// </summary>
        private string sittributent;
        [XmlElement(ElementName = "SITTRIBUTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributent
        {
            get { return  sittributent; }
            set {  sittributent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCST
        /// Comentário: Tipo de calculo do ST.
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
        /// Propriedade referente ao campo: USAPISCOFINSLIT
        /// Comentário: Usa PIS/COFINS por litragem
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
        /// Propriedade referente ao campo: VLADICIONALBCICMSANTECIP
        /// Comentário: Valor adicional base Icms Antecipado
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
        /// Propriedade referente ao campo: VLADICIONALBCST
        /// Comentário: Vlr Adicional B.Calc. ST.
        /// </summary>
        private decimal vladicionalbcst;
        [XmlElement(ElementName = "VLADICIONALBCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vladicionalbcst
        {
            get { return  vladicionalbcst; }
            set {  vladicionalbcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONALBCSTBCR
        /// Comentário: Vlr Adicional B.Calc. ST. - BCR.
        /// </summary>
        private decimal vladicionalbcstbcr;
        [XmlElement(ElementName = "VLADICIONALBCSTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vladicionalbcstbcr
        {
            get { return  vladicionalbcstbcr; }
            set {  vladicionalbcstbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINSLIT
        /// Comentário: Valor COFINS por litragem
        /// </summary>
        private decimal vlcofinslit;
        [XmlElement(ElementName = "VLCOFINSLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofinslit
        {
            get { return  vlcofinslit; }
            set {  vlcofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDICMS
        /// Comentário: Vlr.Crédito COFINS.
        /// </summary>
        private decimal vlcredicms;
        [XmlElement(ElementName = "VLCREDICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredicms
        {
            get { return  vlcredicms; }
            set {  vlcredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPIS
        /// Comentário: Vlr.Crédito PIS.
        /// </summary>
        private decimal vlcredpis;
        [XmlElement(ElementName = "VLCREDPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpis
        {
            get { return  vlcredpis; }
            set {  vlcredpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPRESUMIDO
        /// Comentário: Vlr.Créd. ICMS Presumido.
        /// </summary>
        private decimal vlcredpresumido;
        [XmlElement(ElementName = "VLCREDPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpresumido
        {
            get { return  vlcredpresumido; }
            set {  vlcredpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPDENTRONF
        /// Comentário: Vlr.Desp.Dento da NF.
        /// </summary>
        private decimal vldespdentronf;
        [XmlElement(ElementName = "VLDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespdentronf
        {
            get { return  vldespdentronf; }
            set {  vldespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFALIQUOTAS
        /// Comentário: Vlr.Diferença de alíquotas.
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
        /// Comentário: Vlr.Frete CIF.
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEPORKG
        /// Comentário: Vlr.Frete FOB.
        /// </summary>
        private decimal vlfreteporkg;
        [XmlElement(ElementName = "VLFRETEPORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfreteporkg
        {
            get { return  vlfreteporkg; }
            set {  vlfreteporkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSANTECIPADO
        /// Comentário: Vlr.ICMS Antecipado.
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
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: Vlr.IPI.
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
        /// Propriedade referente ao campo: VLIPIIMP
        /// Comentário: Valor do IPI fixo por unidade de compra nas entradas de Importação
        /// </summary>
        private decimal vlipiimp;
        [XmlElement(ElementName = "VLIPIIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlipiimp
        {
            get { return  vlipiimp; }
            set {  vlipiimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPORKG
        /// Comentário: Vlr.IPI por KG.
        /// </summary>
        private decimal vlipiporkg;
        [XmlElement(ElementName = "VLIPIPORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipiporkg
        {
            get { return  vlipiporkg; }
            set {  vlipiporkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPISUSPENSO
        /// Comentário: Valor do IPI suspenso
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
        /// Propriedade referente ao campo: VLPAUTA
        /// Comentário: Vlr Pauta ST.
        /// </summary>
        private decimal vlpauta;
        [XmlElement(ElementName = "VLPAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpauta
        {
            get { return  vlpauta; }
            set {  vlpauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTABCR
        /// Comentário: Vlr Pauta ST - BCR.
        /// </summary>
        private decimal vlpautabcr;
        [XmlElement(ElementName = "VLPAUTABCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautabcr
        {
            get { return  vlpautabcr; }
            set {  vlpautabcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMS
        /// Comentário: Vlr.Pauta ICMS.
        /// </summary>
        private decimal vlpautaicms;
        [XmlElement(ElementName = "VLPAUTAICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautaicms
        {
            get { return  vlpautaicms; }
            set {  vlpautaicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMSANTEC
        /// Comentário: Vlr. Pauta ICMS Antecipado.
        /// </summary>
        private decimal vlpautaicmsantec;
        [XmlElement(ElementName = "VLPAUTAICMSANTEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautaicmsantec
        {
            get { return  vlpautaicmsantec; }
            set {  vlpautaicmsantec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAIPI
        /// Comentário: Valor da pauta do IPI na tabela PCTRIBFIGURA.
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
        /// Comentário: Valor pauta PIS/COFINS
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
        /// Propriedade referente ao campo: VLPISLIT
        /// Comentário: Valor PIS por litragem
        /// </summary>
        private decimal vlpislit;
        [XmlElement(ElementName = "VLPISLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpislit
        {
            get { return  vlpislit; }
            set {  vlpislit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Comentário: Vlr.Seguro.
        /// </summary>
        private decimal vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLST
        /// Comentário: Vlr. ST NF.
        /// </summary>
        private decimal vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlst
        {
            get { return  vlst; }
            set {  vlst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUFRAMA
        /// Comentário: Vlr.SUFRAMA.
        /// </summary>
        private decimal vlsuframa;
        [XmlElement(ElementName = "VLSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsuframa
        {
            get { return  vlsuframa; }
            set {  vlsuframa = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTribfigura()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBFIGURA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTribfigura> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribfigura>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTribfigura> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribfigura>(where);
        }

        #endregion
    }
}
