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
    /// Classe referente a tabela PCItem
    /// </summary>
    [XmlType("PCITEM")]
    public class PCItem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APLICPERCIVAPAUTA
        /// Comentário: Determina se o valor de IVA será agregado no valor da paula (rotina 209).
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
        /// Propriedade referente ao campo: APROVEITACREDICMS
        /// Comentário: Aproveita credito ICMS na impotação rotina 30023.
        /// </summary>
        private string aproveitacredicms;
        [XmlElement(ElementName = "APROVEITACREDICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredicms
        {
            get { return  aproveitacredicms; }
            set {  aproveitacredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDICMSCONT
        /// Comentário: Aproveita crédito ICMS custo contabil na importação
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
        /// Propriedade referente ao campo: APROVEITACREDPISCOFINS
        /// Comentário: Aproveita credito de PIS/COFINS na importação rotina 3002.
        /// </summary>
        private string aproveitacredpiscofins;
        [XmlElement(ElementName = "APROVEITACREDPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredpiscofins
        {
            get { return  aproveitacredpiscofins; }
            set {  aproveitacredpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDPISCOFINSCONT
        /// Comentário: Aproveita crédito PIS/COFINS custo contabil na importação
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
        /// Propriedade referente ao campo: BASECREDPRESUMIDO
        /// Comentário: Base do Crédito Presumido
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
        /// Propriedade referente ao campo: BASEDIFALIQUOTAS
        /// Comentário: Indica o valor base da diferença de alíquota.
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
        /// Comentário: Base de icms item a item do ped. compra. 
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
        /// Propriedade referente ao campo: BASEICMSANTECIPADO
        /// Comentário: Base do ICMS Antecipado
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
        /// Propriedade referente ao campo: BASEICST
        /// Comentário: Base de subst. tributaria item a item do ped. compra. 
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
        /// Comentário: Calcular Custo com Crédito de IPI (Compra).
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
        /// Propriedade referente ao campo: CODFUNCALTER
        /// Comentário: Código do funcionário que fez a alteração no pedido de compra, cadastro pela rotina 528
        /// </summary>
        private decimal codfuncalter;
        [XmlElement(ElementName = "CODFUNCALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncalter
        {
            get { return  codfuncalter; }
            set {  codfuncalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAUTORIZA
        /// Comentário: Funcionário que autorizou incluir item no pedido
        /// </summary>
        private decimal codfuncautoriza;
        [XmlElement(ElementName = "CODFUNCAUTORIZA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncautoriza
        {
            get { return  codfuncautoriza; }
            set {  codfuncautoriza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Codigo do produto.
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
        /// Propriedade referente ao campo: CODPRODORIGEM
        /// Comentário: Código produto origem na Importação.
        /// </summary>
        private decimal codprodorigem;
        [XmlElement(ElementName = "CODPRODORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodorigem
        {
            get { return  codprodorigem; }
            set {  codprodorigem = value; }
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
        /// Propriedade referente ao campo: CODSITTRIBPISCONFINS
        /// Comentário: Indica o Código da Situação Tributária Referente ao PIS/COFINS
        /// </summary>
        private decimal codsittribpisconfins;
        [XmlElement(ElementName = "CODSITTRIBPISCONFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribpisconfins
        {
            get { return  codsittribpisconfins; }
            set {  codsittribpisconfins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBST
        /// Comentário: Gravar o código da situação tributária st
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
        /// Propriedade referente ao campo: CONSIDERASTGUIACUSTO
        /// Comentário: Considera ST Guia no Custo.
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
        /// Comentário: Considera ST Guia no Custo Contábil.
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
        /// Comentário: Considera ST NF  no Custo.
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
        /// Comentário: Considera ST NF no Custo Contábil.
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
        /// Propriedade referente ao campo: CONTROLARFCI
        /// Comentário: Controla Ficha de Conteúdo de Importação.
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
        /// Propriedade referente ao campo: CUSTOULTENT
        /// Comentário: Custo da ultima entrada.
        /// </summary>
        private decimal custoultent;
        [XmlElement(ElementName = "CUSTOULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultent
        {
            get { return  custoultent; }
            set {  custoultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTPEDCOMPRA
        /// Comentário: Custo da última entrada pedido de compra.
        /// </summary>
        private decimal custoultpedcompra;
        [XmlElement(ElementName = "CUSTOULTPEDCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultpedcompra
        {
            get { return  custoultpedcompra; }
            set {  custoultpedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTPEDCOMPRASEMST
        /// Comentário: Custo Ult.Pedido de Compra sem ST.
        /// </summary>
        private decimal custoultpedcomprasemst;
        [XmlElement(ElementName = "CUSTOULTPEDCOMPRASEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultpedcomprasemst
        {
            get { return  custoultpedcomprasemst; }
            set {  custoultpedcomprasemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENTREGA
        /// Comentário: Previsão da Data de Entrega do item do Pedido de Compra. 
        /// </summary>
        private DateTime? dataentrega;
        [XmlElement(ElementName = "DATAENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataentrega
        {
            get { return  dataentrega; }
            set {  dataentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAUTORIZACAO
        /// Comentário: Data da autorização para incluir item no pedido
        /// </summary>
        private DateTime? dtautorizacao;
        [XmlElement(ElementName = "DTAUTORIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtautorizacao
        {
            get { return  dtautorizacao; }
            set {  dtautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDOLAR
        /// Comentário: Data de cotacao da moeda (rotina 3001).
        /// </summary>
        private string dtdolar;
        [XmlElement(ElementName = "DTDOLAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dtdolar
        {
            get { return  dtdolar; }
            set {  dtdolar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOLICENCAIMP
        /// Comentário: Data de emissão da licença de importação
        /// </summary>
        private DateTime? dtemissaolicencaimp;
        [XmlElement(ElementName = "DTEMISSAOLICENCAIMP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaolicencaimp
        {
            get { return  dtemissaolicencaimp; }
            set {  dtemissaolicencaimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLEMISSAOLICENCAIMPORT
        /// Comentário: Data de emissão da licença de importação
        /// </summary>
        private DateTime? dtlemissaolicencaimport;
        [XmlElement(ElementName = "DTLEMISSAOLICENCAIMPORT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlemissaolicencaimport
        {
            get { return  dtlemissaolicencaimport; }
            set {  dtlemissaolicencaimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCOMPRA
        /// Comentário: Data da ultima compra.
        /// </summary>
        private DateTime? dtultcompra;
        [XmlElement(ElementName = "DTULTCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcompra
        {
            get { return  dtultcompra; }
            set {  dtultcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTENT
        /// Comentário: Data da ultima entrada.
        /// </summary>
        private DateTime? dtultent;
        [XmlElement(ElementName = "DTULTENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultent
        {
            get { return  dtultent; }
            set {  dtultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADELICENCAIMP
        /// Comentário: Data de validade da licença de importação
        /// </summary>
        private DateTime? dtvalidadelicencaimp;
        [XmlElement(ElementName = "DTVALIDADELICENCAIMP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadelicencaimp
        {
            get { return  dtvalidadelicencaimp; }
            set {  dtvalidadelicencaimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCLICENCAIMPORT
        /// Comentário: Data de vencimento da licença de importação
        /// </summary>
        private DateTime? dtvenclicencaimport;
        [XmlElement(ElementName = "DTVENCLICENCAIMPORT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenclicencaimport
        {
            get { return  dtvenclicencaimport; }
            set {  dtvenclicencaimport = value; }
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
        /// Propriedade referente ao campo: IPIPORVALOR
        /// Comentário: IPI fixo por valor.
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
        /// Propriedade referente ao campo: LOTELICIT
        /// Comentário: Lote da licitação
        /// </summary>
        private string lotelicit;
        [XmlElement(ElementName = "LOTELICIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Lotelicit
        {
            get { return  lotelicit; }
            set {  lotelicit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDA
        /// Comentário: Moeda (rotina 3001).
        /// </summary>
        private string moeda;
        [XmlElement(ElementName = "MOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Moeda
        {
            get { return  moeda; }
            set {  moeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: Motivo cancelamento
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPLOCOMPRAS
        /// Comentário: Quantidade multipla de compra calculo da sugestão de compra
        /// </summary>
        private decimal multiplocompras;
        [XmlElement(ElementName = "MULTIPLOCOMPRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Multiplocompras
        {
            get { return  multiplocompras; }
            set {  multiplocompras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMADICAO
        /// Comentário: Número de adição
        /// </summary>
        private decimal numadicao;
        [XmlElement(ElementName = "NUMADICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numadicao
        {
            get { return  numadicao; }
            set {  numadicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDRAWBACK
        /// Comentário: Número do ato concessório do regime DRAWBACK.
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
        /// Propriedade referente ao campo: NUMEROITEMLICIT
        /// Comentário: Número item licitação
        /// </summary>
        private decimal numeroitemlicit;
        [XmlElement(ElementName = "NUMEROITEMLICIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Numeroitemlicit
        {
            get { return  numeroitemlicit; }
            set {  numeroitemlicit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFCI
        /// Comentário: Ficha de Conteúdo de Importação.
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
        /// Propriedade referente ao campo: NUMLICENCAIMP
        /// Comentário: Número da licença de importação.
        /// </summary>
        private decimal numlicencaimp;
        [XmlElement(ElementName = "NUMLICENCAIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numlicencaimp
        {
            get { return  numlicencaimp; }
            set {  numlicencaimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLICENCAIMPORT
        /// Comentário: Número da licença de importação
        /// </summary>
        private string numlicencaimport;
        [XmlElement(ElementName = "NUMLICENCAIMPORT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlicencaimport
        {
            get { return  numlicencaimport; }
            set {  numlicencaimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Numero do pedido.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Número de sequencia digitação do mesmo item.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQADICAO
        /// Comentário: Número sequencial de controle de adição
        /// </summary>
        private decimal numseqadicao;
        [XmlElement(ElementName = "NUMSEQADICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numseqadicao
        {
            get { return  numseqadicao; }
            set {  numseqadicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSITEM
        /// Comentário: Quantidade multipla de compra calculo da sugestão de compra
        /// </summary>
        private string obsitem;
        [XmlElement(ElementName = "OBSITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obsitem
        {
            get { return  obsitem; }
            set {  obsitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMPRA
        /// Comentário: Preco de compra.
        /// </summary>
        private decimal pcompra;
        [XmlElement(ElementName = "PCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pcompra
        {
            get { return  pcompra; }
            set {  pcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMPRAANT
        /// Comentário: Preco de compra anterior.
        /// </summary>
        private decimal pcompraant;
        [XmlElement(ElementName = "PCOMPRAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pcompraant
        {
            get { return  pcompraant; }
            set {  pcompraant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMPRAMED
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal pcompramed;
        [XmlElement(ElementName = "PCOMPRAMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pcompramed
        {
            get { return  pcompramed; }
            set {  pcompramed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCADUANEIRA
        /// Comentário: Percentual despesa aduaneira
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
        /// Comentário: Percentual Despesa Aduaneira Custo
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
        /// Comentário: Percentual de Adicional de Frete para a Renovação da Marinha Mercante
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
        /// Comentário: Percentual de Adicional de Frete para a Renovação da Marinha Mercante
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
        /// Propriedade referente ao campo: PERCALIQEXT
        /// Comentário: Percentual da aliquota externa ST.
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
        /// Propriedade referente ao campo: PERCALIQEXTGUIA
        /// Comentário: Percentual da alíquota externa para calculo do ST Guia.
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
        /// Propriedade referente ao campo: PERCALIQEXT2
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal percaliqext2;
        [XmlElement(ElementName = "PERCALIQEXT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqext2
        {
            get { return  percaliqext2; }
            set {  percaliqext2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINT
        /// Comentário: Percentual da aliquota interna ST.
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
        /// Propriedade referente ao campo: PERCALIQINT2
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal percaliqint2;
        [XmlElement(ElementName = "PERCALIQINT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqint2
        {
            get { return  percaliqint2; }
            set {  percaliqint2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALTERCUSTOENT
        /// Comentário: Percentual de acréscimo no custo do produto por não reembolso da avaria.
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
        /// Comentário: Percentual Antidumping DI
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
        /// Comentário: Percentual Antidumping Custo
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
        /// Propriedade referente ao campo: PERCBASEREDST
        /// Comentário: Será utilizado para o cálculo de redução de base de ST (rotina 209).
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
        /// Propriedade referente ao campo: PERCBON
        /// Comentário: Percentual de bonificacao.
        /// </summary>
        private decimal percbon;
        [XmlElement(ElementName = "PERCBON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percbon
        {
            get { return  percbon; }
            set {  percbon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFIC
        /// Comentário: % Bonificação Dinheiro
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
        /// Propriedade referente ao campo: PERCBONNF
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal percbonnf;
        [XmlElement(ElementName = "PERCBONNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percbonnf
        {
            get { return  percbonnf; }
            set {  percbonnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONOUTRAS
        /// Comentário: Percentual de outras bonificacoes.
        /// </summary>
        private decimal percbonoutras;
        [XmlElement(ElementName = "PERCBONOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbonoutras
        {
            get { return  percbonoutras; }
            set {  percbonoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCAPATAZIA
        /// Comentário: Percentual da capatazia rateado entre os itens de importação.
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
        /// Comentário: Percentual de capatazia NF custo
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
        /// Propriedade referente ao campo: PERCCONTEUDOIMPFCI
        /// Comentário: Conteúdo de Importação.
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
        /// Propriedade referente ao campo: PERCCREDICMPRESUMIDO
        /// Comentário: Percentual crédito ICMS presumido.
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
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: Percentual de desconto comercial.
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCCONTRATO
        /// Comentário: 
        /// </summary>
        private decimal percdesccontrato;
        [XmlElement(ElementName = "PERCDESCCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesccontrato
        {
            get { return  percdesccontrato; }
            set {  percdesccontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFIN
        /// Comentário: Percentual de desconto financeiro.
        /// </summary>
        private decimal percdescfin;
        [XmlElement(ElementName = "PERCDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescfin
        {
            get { return  percdescfin; }
            set {  percdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFINREAL
        /// Comentário: 
        /// </summary>
        private decimal percdescfinreal;
        [XmlElement(ElementName = "PERCDESCFINREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescfinreal
        {
            get { return  percdescfinreal; }
            set {  percdescfinreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCICMSDIF
        /// Comentário: Percentual do desconto de ICMS Difererido.
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
        /// Propriedade referente ao campo: PERCDESCLOGISTICO
        /// Comentário: 
        /// </summary>
        private decimal percdesclogistico;
        [XmlElement(ElementName = "PERCDESCLOGISTICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesclogistico
        {
            get { return  percdesclogistico; }
            set {  percdesclogistico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC1
        /// Comentário: Percentual de desconto comercial 1.
        /// </summary>
        private decimal percdesc1;
        [XmlElement(ElementName = "PERCDESC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc1
        {
            get { return  percdesc1; }
            set {  percdesc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC10
        /// Comentário: Percentual de desconto comercial 10.
        /// </summary>
        private decimal percdesc10;
        [XmlElement(ElementName = "PERCDESC10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc10
        {
            get { return  percdesc10; }
            set {  percdesc10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC2
        /// Comentário: Percentual de desconto comercial 2.
        /// </summary>
        private decimal percdesc2;
        [XmlElement(ElementName = "PERCDESC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc2
        {
            get { return  percdesc2; }
            set {  percdesc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC3
        /// Comentário: Percentual de desconto comercial 3.
        /// </summary>
        private decimal percdesc3;
        [XmlElement(ElementName = "PERCDESC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc3
        {
            get { return  percdesc3; }
            set {  percdesc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC4
        /// Comentário: Percentual de desconto comercial 4.
        /// </summary>
        private decimal percdesc4;
        [XmlElement(ElementName = "PERCDESC4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc4
        {
            get { return  percdesc4; }
            set {  percdesc4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC5
        /// Comentário: Percentual de desconto comercial 5.
        /// </summary>
        private decimal percdesc5;
        [XmlElement(ElementName = "PERCDESC5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc5
        {
            get { return  percdesc5; }
            set {  percdesc5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC6
        /// Comentário: Percentual de desconto comercial 6.
        /// </summary>
        private decimal percdesc6;
        [XmlElement(ElementName = "PERCDESC6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc6
        {
            get { return  percdesc6; }
            set {  percdesc6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC7
        /// Comentário: Percentual de desconto comercial 7.
        /// </summary>
        private decimal percdesc7;
        [XmlElement(ElementName = "PERCDESC7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc7
        {
            get { return  percdesc7; }
            set {  percdesc7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC8
        /// Comentário: Percentual de desconto comercial 8.
        /// </summary>
        private decimal percdesc8;
        [XmlElement(ElementName = "PERCDESC8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc8
        {
            get { return  percdesc8; }
            set {  percdesc8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC9
        /// Comentário: Percentual de desconto comercial 9.
        /// </summary>
        private decimal percdesc9;
        [XmlElement(ElementName = "PERCDESC9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc9
        {
            get { return  percdesc9; }
            set {  percdesc9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPADICIONAL
        /// Comentário: Percentual ST GUIA.
        /// </summary>
        private decimal percdespadicional;
        [XmlElement(ElementName = "PERCDESPADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespadicional
        {
            get { return  percdespadicional; }
            set {  percdespadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPDENTRONF
        /// Comentário: Indica o percentual outras despesa na NF.
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
        /// Propriedade referente ao campo: PERCDESPDENTRONFCUSTO
        /// Comentário: INC	Percentual de acréscimo NF custo
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
        /// Propriedade referente ao campo: PERCDESPFIN
        /// Comentário: Percentual de despesa financeira(Vendor).
        /// </summary>
        private decimal percdespfin;
        [XmlElement(ElementName = "PERCDESPFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespfin
        {
            get { return  percdespfin; }
            set {  percdespfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFORANF
        /// Comentário: Indica o percentual de despesa fora da nota.
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
        /// Comentário: Indica o percentual de diferença de alíquota.
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
        /// Propriedade referente ao campo: PERCDIREITOSADUANEIROS
        /// Comentário: Direitos aduaneiros.
        /// </summary>
        private decimal percdireitosaduaneiros;
        [XmlElement(ElementName = "PERCDIREITOSADUANEIROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdireitosaduaneiros
        {
            get { return  percdireitosaduaneiros; }
            set {  percdireitosaduaneiros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE
        /// Comentário: Percentual de frete CIF.
        /// </summary>
        private decimal percfrete;
        [XmlElement(ElementName = "PERCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete
        {
            get { return  percfrete; }
            set {  percfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETEFOB
        /// Comentário: Percentual do frete FOB.
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
        /// Propriedade referente ao campo: PERCFRETENFCUSTO
        /// Comentário: Percentual de frete NF custo
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
        /// Propriedade referente ao campo: PERCICMRED
        /// Comentário: Percentual de reducao do ICMS ST.
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
        /// Comentário: Indica o percentual do ICMS diferido.
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
        /// Comentário: Percentual de crédito de ICMS sobre o valor Frete FOB, utilizado no calculo do ST
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
        /// Propriedade referente ao campo: PERCIISUSPENSO
        /// Comentário: Percenctual de imposto de importação suspenso para cáculo do PIS, COFINS, ICMS e IPI.
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
        /// Comentário: Percentual de Importação
        /// </summary>
        private decimal percimportacao;
        [XmlElement(ElementName = "PERCIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percimportacao
        {
            get { return  percimportacao; }
            set {  percimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPOSTOCONSUMO
        /// Comentário: Imposto de consumo.
        /// </summary>
        private decimal percimpostoconsumo;
        [XmlElement(ElementName = "PERCIMPOSTOCONSUMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percimpostoconsumo
        {
            get { return  percimpostoconsumo; }
            set {  percimpostoconsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPOSTOSELO
        /// Comentário: Imposto selo.
        /// </summary>
        private decimal percimpostoselo;
        [XmlElement(ElementName = "PERCIMPOSTOSELO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percimpostoselo
        {
            get { return  percimpostoselo; }
            set {  percimpostoselo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPPRODUTORURAL
        /// Comentário: Indica o percentual do imposto do produtor rural.
        /// </summary>
        private decimal percimpprodutorural;
        [XmlElement(ElementName = "PERCIMPPRODUTORURAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percimpprodutorural
        {
            get { return  percimpprodutorural; }
            set {  percimpprodutorural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPUREZA
        /// Comentário: Classificação arroz rotina 1330.
        /// </summary>
        private decimal percimpureza;
        [XmlElement(ElementName = "PERCIMPUREZA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percimpureza
        {
            get { return  percimpureza; }
            set {  percimpureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINTEIRO
        /// Comentário: Classificação arroz rotina 1330.
        /// </summary>
        private decimal percinteiro;
        [XmlElement(ElementName = "PERCINTEIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percinteiro
        {
            get { return  percinteiro; }
            set {  percinteiro = value; }
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
        /// Comentário: Percentual do IVA ST.
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
        /// Propriedade referente ao campo: PERCIVA2
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal perciva2;
        [XmlElement(ElementName = "PERCIVA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perciva2
        {
            get { return  perciva2; }
            set {  perciva2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMEXFPGC
        /// Comentário: Campo usado no Winthor Mexico.
        /// </summary>
        private decimal percmexfpgc;
        [XmlElement(ElementName = "PERCMEXFPGC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmexfpgc
        {
            get { return  percmexfpgc; }
            set {  percmexfpgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMEXIEPS
        /// Comentário: Campo usado no Winthor Mexico.
        /// </summary>
        private decimal percmexieps;
        [XmlElement(ElementName = "PERCMEXIEPS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmexieps
        {
            get { return  percmexieps; }
            set {  percmexieps = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMEXIVA
        /// Comentário: Campo usado no Winthor Mexico.
        /// </summary>
        private decimal percmexiva;
        [XmlElement(ElementName = "PERCMEXIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmexiva
        {
            get { return  percmexiva; }
            set {  percmexiva = value; }
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
        /// Comentário: Indica o valor do percentual de cofins.
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
        /// Comentário: Percentual de COFINS calculo da D.I.
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
        /// Propriedade referente ao campo: PERCOUTRASDESP
        /// Comentário: Percentual de outras despesas dentro da NF.
        /// </summary>
        private decimal percoutrasdesp;
        [XmlElement(ElementName = "PERCOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percoutrasdesp
        {
            get { return  percoutrasdesp; }
            set {  percoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTRASDESPIMP
        /// Comentário: Percentual outras depesas importação
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
        /// Comentário: Percentual Outras Despesas Importação Custo
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
        /// Propriedade referente ao campo: PERCOUTROSCUSTOS
        /// Comentário: Percentual de outros custos do item de importação.
        /// </summary>
        private decimal percoutroscustos;
        [XmlElement(ElementName = "PERCOUTROSCUSTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percoutroscustos
        {
            get { return  percoutroscustos; }
            set {  percoutroscustos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTROSCUSTOSCUSTO
        /// Comentário: Percentual Outros Custos Importação Custo
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
        /// Propriedade referente ao campo: PERCQUEBRADO
        /// Comentário: Classificação arroz rotina 1330.
        /// </summary>
        private decimal percquebrado;
        [XmlElement(ElementName = "PERCQUEBRADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percquebrado
        {
            get { return  percquebrado; }
            set {  percquebrado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDICMS
        /// Comentário: Indica o percentual de crédito ICMS.
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
        /// Propriedade referente ao campo: PERCREDPMC
        /// Comentário: Perc.redução PMC
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
        /// Propriedade referente ao campo: PERCSEGURO
        /// Comentário: Indica o percentual de seguro.
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
        /// Propriedade referente ao campo: PERCSEGUROCUSTO
        /// Comentário: Percentual de seguro NF custo
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
        /// Comentário: Percentual despesa SISCOMEX
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
        /// Comentário: Percentual Siscomex Custo
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
        /// Propriedade referente ao campo: PERCST
        /// Comentário: Percentual ST.
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
        /// Propriedade referente ao campo: PERCSTBCR
        /// Comentário: Indica o percentual ST BCR.
        /// </summary>
        private decimal percstbcr;
        [XmlElement(ElementName = "PERCSTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percstbcr
        {
            get { return  percstbcr; }
            set {  percstbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSUFRAMA
        /// Comentário: Percentual do SUFRAMA.
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
        /// Propriedade referente ao campo: PERCUMIDADE
        /// Comentário: Classificação arroz rotina 1330.
        /// </summary>
        private decimal percumidade;
        [XmlElement(ElementName = "PERCUMIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percumidade
        {
            get { return  percumidade; }
            set {  percumidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVERMELHO
        /// Comentário: Classificação arroz rotina 1330.
        /// </summary>
        private decimal percvermelho;
        [XmlElement(ElementName = "PERCVERMELHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percvermelho
        {
            get { return  percvermelho; }
            set {  percvermelho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVLBONIFIC
        /// Comentário: Percentua bonificação em dinheiro.
        /// </summary>
        private decimal percvlbonific;
        [XmlElement(ElementName = "PERCVLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percvlbonific
        {
            get { return  percvlbonific; }
            set {  percvlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICM
        /// Comentário: Percentual do ICMS.
        /// </summary>
        private decimal pericm;
        [XmlElement(ElementName = "PERICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pericm
        {
            get { return  pericm; }
            set {  pericm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICMFRETE
        /// Comentário: Percentual ICMS frete CIF.
        /// </summary>
        private decimal pericmfrete;
        [XmlElement(ElementName = "PERICMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pericmfrete
        {
            get { return  pericmfrete; }
            set {  pericmfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICMSANTECIPADO
        /// Comentário: Percentual do ICMS antecipado.
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
        /// Comentário: Percentual do IPI.
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
        /// Comentário: Percentual de credito do PIS.
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
        /// Comentário: Percentual de PIS calculo da D.I.
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
        /// Propriedade referente ao campo: PISCOFINSRETIDO
        /// Comentário: Considerar a informação de PIS/COFINS retido na figura tributária.
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
        /// Propriedade referente ao campo: PLIQUIDO
        /// Comentário: Preco liquido.
        /// </summary>
        private decimal pliquido;
        [XmlElement(ElementName = "PLIQUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pliquido
        {
            get { return  pliquido; }
            set {  pliquido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLIQUIDOMED
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal pliquidomed;
        [XmlElement(ElementName = "PLIQUIDOMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pliquidomed
        {
            get { return  pliquidomed; }
            set {  pliquidomed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODBONIFICADO
        /// Comentário: Identificador produto bonificado.
        /// </summary>
        private string prodbonificado;
        [XmlElement(ElementName = "PRODBONIFICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prodbonificado
        {
            get { return  prodbonificado; }
            set {  prodbonificado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUTOGRADE
        /// Comentário: Produto de grade.
        /// </summary>
        private string produtograde;
        [XmlElement(ElementName = "PRODUTOGRADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Produtograde
        {
            get { return  produtograde; }
            set {  produtograde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: Campo para indicar se o produto sera aproveitado credito de icms na entrada
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBONIFICMERCOUTRAS
        /// Comentário: Quantidade de mercadoria bonificação outras
        /// </summary>
        private decimal qtbonificmercoutras;
        [XmlElement(ElementName = "QTBONIFICMERCOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbonificmercoutras
        {
            get { return  qtbonificmercoutras; }
            set {  qtbonificmercoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBONIFMERC
        /// Comentário: Indica a quantidade de bonificação em mercadoria.
        /// </summary>
        private decimal qtbonifmerc;
        [XmlElement(ElementName = "QTBONIFMERC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtbonifmerc
        {
            get { return  qtbonifmerc; }
            set {  qtbonifmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIGITADA
        /// Comentário: Quantidade digitada pelo usúario.
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
        /// Propriedade referente ao campo: QTENTREGUE
        /// Comentário: Quantidade entregue.
        /// </summary>
        private decimal qtentregue;
        [XmlElement(ElementName = "QTENTREGUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtentregue
        {
            get { return  qtentregue; }
            set {  qtentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTREGUEMED
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal qtentreguemed;
        [XmlElement(ElementName = "QTENTREGUEMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentreguemed
        {
            get { return  qtentreguemed; }
            set {  qtentreguemed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTDISP
        /// Comentário: Quantidade do estoque disponivel.
        /// </summary>
        private decimal qtestdisp;
        [XmlElement(ElementName = "QTESTDISP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestdisp
        {
            get { return  qtestdisp; }
            set {  qtestdisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTIDEAL
        /// Comentário: Quantidade do estoque ideal.
        /// </summary>
        private decimal qtestideal;
        [XmlElement(ElementName = "QTESTIDEAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestideal
        {
            get { return  qtestideal; }
            set {  qtestideal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFATORCONVERSAO
        /// Comentário: Permite alterar fator de conversão da importação xml.
        /// </summary>
        private decimal qtfatorconversao;
        [XmlElement(ElementName = "QTFATORCONVERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtfatorconversao
        {
            get { return  qtfatorconversao; }
            set {  qtfatorconversao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINSUGCOMPRA
        /// Comentário: Quantidade mínima de compra calculo da sugestão de compra
        /// </summary>
        private decimal qtminsugcompra;
        [XmlElement(ElementName = "QTMINSUGCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtminsugcompra
        {
            get { return  qtminsugcompra; }
            set {  qtminsugcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDA
        /// Comentário: Quantidade pedida.
        /// </summary>
        private decimal qtpedida;
        [XmlElement(ElementName = "QTPEDIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpedida
        {
            get { return  qtpedida; }
            set {  qtpedida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDAMED
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal qtpedidamed;
        [XmlElement(ElementName = "QTPEDIDAMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtpedidamed
        {
            get { return  qtpedidamed; }
            set {  qtpedidamed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPREENTREGUE
        /// Comentário: 
        /// </summary>
        private decimal qtpreentregue;
        [XmlElement(ElementName = "QTPREENTREGUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtpreentregue
        {
            get { return  qtpreentregue; }
            set {  qtpreentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSUGESTAO
        /// Comentário: Quantidade de sugestao de compra.
        /// </summary>
        private decimal qtsugestao;
        [XmlElement(ElementName = "QTSUGESTAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtsugestao
        {
            get { return  qtsugestao; }
            set {  qtsugestao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXT
        /// Comentário: Será utilizado para Redução da Base de Cálculo da Aliquota Externa ref a substituição Tributária na Entrada.
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
        /// Comentário: Será utilizado para Redução da Base de Cálculo de Substituição Tributária na Entrada.
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
        /// Propriedade referente ao campo: ROTINALANC
        /// Comentário: Indica o número da rotina que alterou o registro.
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
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Status da movimentação do item: Gerencial ou Fiscal
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCST
        /// Comentário: Tipo de ST: NF, Guia, Ambos, BCR.
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
        /// Propriedade referente ao campo: USAPMCBASEST
        /// Comentário: Usa PMC base ST
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
        /// Propriedade referente ao campo: UTILIZABASEPISCOFINSSUSP
        /// Comentário: Utiliza Base PIS/COFINS Suspenso.
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
        /// Comentário: Alíquota crédito reduzido PIS/COFINS
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
        /// Propriedade referente ao campo: VERBADINPORPERC
        /// Comentário: Calcular verba dinheiro por percentual
        /// </summary>
        private string verbadinporperc;
        [XmlElement(ElementName = "VERBADINPORPERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verbadinporperc
        {
            get { return  verbadinporperc; }
            set {  verbadinporperc = value; }
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
        /// Comentário: Valor adicional base de calculo ST.
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
        /// Propriedade referente ao campo: VLADUANEIRA
        /// Comentário: Valor referente a despesas aduaneiras
        /// </summary>
        private decimal vladuaneira;
        [XmlElement(ElementName = "VLADUANEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vladuaneira
        {
            get { return  vladuaneira; }
            set {  vladuaneira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADUANEIRACUSTO
        /// Comentário: Valor Despesa Aduaneira Custo
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
        /// Comentário: Valor do Adicional de Frete para a Renovação da Marinha Mercante
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
        /// Comentário: Valor do Adicional de Frete para a Renovação da Marinha Mercante
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
        /// Comentário: Acréscmo no Custo da Última Entrada.
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
        /// Comentário: Valor Antidumping DI
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
        /// Comentário: Valor Antidumping Custo
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
        /// Propriedade referente ao campo: VLBASEIPISUSPENSO
        /// Comentário: Base do IPI suspenso
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
        /// Propriedade referente ao campo: VLBASESTBCR
        /// Comentário: Indica o valor Base ST BCR.
        /// </summary>
        private decimal vlbasestbcr;
        [XmlElement(ElementName = "VLBASESTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasestbcr
        {
            get { return  vlbasestbcr; }
            set {  vlbasestbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASESTGUIA
        /// Comentário: Indica o valor base ST guia.
        /// </summary>
        private decimal vlbasestguia;
        [XmlElement(ElementName = "VLBASESTGUIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasestguia
        {
            get { return  vlbasestguia; }
            set {  vlbasestguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: Valor da bonificacao dinheiro.
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
        /// Propriedade referente ao campo: VLBONIFICOUTRAS
        /// Comentário: Valor de outras bonificacoes.
        /// </summary>
        private decimal vlbonificoutras;
        [XmlElement(ElementName = "VLBONIFICOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbonificoutras
        {
            get { return  vlbonificoutras; }
            set {  vlbonificoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCAPATAZIA
        /// Comentário: Valor da capatazia rateado entre os itens de importação.
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
        /// Comentário: Valor da capatazia NF custo
        /// </summary>
        private decimal vlcapataziacusto;
        [XmlElement(ElementName = "VLCAPATAZIACUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcapataziacusto
        {
            get { return  vlcapataziacusto; }
            set {  vlcapataziacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINSCALCDI
        /// Comentário: Valor do COFINS suspenso
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
        /// Propriedade referente ao campo: VLCREDCOFINS
        /// Comentário: Indica valor crédito COFINS.
        /// </summary>
        private decimal vlcredcofins;
        [XmlElement(ElementName = "VLCREDCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredcofins
        {
            get { return  vlcredcofins; }
            set {  vlcredcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDICMS
        /// Comentário: Valor do credito do ICMS.
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
        /// Propriedade referente ao campo: VLCREDICMSFRETE
        /// Comentário: Valor do ICMS frete CIF.
        /// </summary>
        private decimal vlcredicmsfrete;
        [XmlElement(ElementName = "VLCREDICMSFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredicmsfrete
        {
            get { return  vlcredicmsfrete; }
            set {  vlcredicmsfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPIS
        /// Comentário: Valor do credito do PIS.
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
        /// Comentário: Valor do credito presumido.
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
        /// Propriedade referente ao campo: VLDESPADICIONAL
        /// Comentário: Valor do ST GUIA.
        /// </summary>
        private decimal vldespadicional;
        [XmlElement(ElementName = "VLDESPADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespadicional
        {
            get { return  vldespadicional; }
            set {  vldespadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPDENTRONF
        /// Comentário: Indica o Valor outras despesas na NF.
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
        /// Propriedade referente ao campo: VLDESPDENTRONFCUSTO
        /// Comentário: INC	Valor do acréscimo NF custo
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
        /// Propriedade referente ao campo: VLDESPFIN
        /// Comentário: Valor da despesa financeira(Vendor)
        /// </summary>
        private decimal vldespfin;
        [XmlElement(ElementName = "VLDESPFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespfin
        {
            get { return  vldespfin; }
            set {  vldespfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPFORANF
        /// Comentário: Indica o valor da despesa fora da nota.
        /// </summary>
        private decimal vldespforanf;
        [XmlElement(ElementName = "VLDESPFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespforanf
        {
            get { return  vldespforanf; }
            set {  vldespforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFALIQUOTAS
        /// Comentário: Indica o valor da diferença de alíquota.
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
        /// Comentário: Valor do frete CIF.
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
        /// Propriedade referente ao campo: VLFRETECONHEC
        /// Comentário: Valor frete FOB.
        /// </summary>
        private decimal vlfreteconhec;
        [XmlElement(ElementName = "VLFRETECONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfreteconhec
        {
            get { return  vlfreteconhec; }
            set {  vlfreteconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETENFCUSTO
        /// Comentário: Valor do frete NF custo
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
        /// Propriedade referente ao campo: VLFRETEPORKG
        /// Comentário: Valor do frete por quilo.
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
        /// Propriedade referente ao campo: VLICMS
        /// Comentário: Valor de icms item a item do ped. compra. 
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
        /// Comentário: Valor do ICMS antecipado.
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
        /// Propriedade referente ao campo: VLIISUSPENSO
        /// Comentário: Valor do II Suspenso.
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
        /// Propriedade referente ao campo: VLIMPORTACAO
        /// Comentário: Percentual imposto importação
        /// </summary>
        private decimal vlimportacao;
        [XmlElement(ElementName = "VLIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlimportacao
        {
            get { return  vlimportacao; }
            set {  vlimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIMPORTACAOFCI
        /// Comentário: Valor de Importação.
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
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: Valor do IPI.
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
        /// Propriedade referente ao campo: VLIPIPORKG
        /// Comentário: Valor do IPI por quilo.
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
        /// Propriedade referente ao campo: VLMEXFPGC
        /// Comentário: Campo usado no Winthor Mexico.
        /// </summary>
        private decimal vlmexfpgc;
        [XmlElement(ElementName = "VLMEXFPGC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmexfpgc
        {
            get { return  vlmexfpgc; }
            set {  vlmexfpgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEXIEPS
        /// Comentário: Campo usado no Winthor Mexico.
        /// </summary>
        private decimal vlmexieps;
        [XmlElement(ElementName = "VLMEXIEPS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmexieps
        {
            get { return  vlmexieps; }
            set {  vlmexieps = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEXIVA
        /// Comentário: Campo usado no Winthor Mexico.
        /// </summary>
        private decimal vlmexiva;
        [XmlElement(ElementName = "VLMEXIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmexiva
        {
            get { return  vlmexiva; }
            set {  vlmexiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Comentário: Valor de outras despesas dentro da NF.
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
        /// Propriedade referente ao campo: VLOUTRASDESPIMP
        /// Comentário: Valor referente a outras despesas de importação
        /// </summary>
        private decimal vloutrasdespimp;
        [XmlElement(ElementName = "VLOUTRASDESPIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutrasdespimp
        {
            get { return  vloutrasdespimp; }
            set {  vloutrasdespimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESPIMPCUSTO
        /// Comentário: Valor Outras Despesas Importação Custo
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
        /// Comentário: Valor de outros custos do item de importação.
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
        /// Comentário: Valor Outros Custos Importação Custo
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
        /// Comentário: Valor da Parcela Importada.
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
        /// Propriedade referente ao campo: VLPAUTA
        /// Comentário: Valor da pauta ST.
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
        /// Propriedade referente ao campo: VLPAUTAICM
        /// Comentário: 
        /// </summary>
        private decimal vlpautaicm;
        [XmlElement(ElementName = "VLPAUTAICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpautaicm
        {
            get { return  vlpautaicm; }
            set {  vlpautaicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMS
        /// Comentário: Indica o valor de pauta ICMS.
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
        /// Comentário: Valor pauta ICMS antecipado.
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
        /// Comentário: Informar valor da pauta do IPI na tabela PCMOVCOMPLE.
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
        /// Propriedade referente ao campo: VLPAUTA2
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal vlpauta2;
        [XmlElement(ElementName = "VLPAUTA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpauta2
        {
            get { return  vlpauta2; }
            set {  vlpauta2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPERCBON
        /// Comentário: Valor bonificação em mercadoria.
        /// </summary>
        private decimal vlpercbon;
        [XmlElement(ElementName = "VLPERCBON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpercbon
        {
            get { return  vlpercbon; }
            set {  vlpercbon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPERCBONNF
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal vlpercbonnf;
        [XmlElement(ElementName = "VLPERCBONNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpercbonnf
        {
            get { return  vlpercbonnf; }
            set {  vlpercbonnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPISCALCDI
        /// Comentário: Valor do PIS suspenso
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
        /// Comentário: Indica o valor do seguro.
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
        /// Propriedade referente ao campo: VLSEGUROCUSTO
        /// Comentário: Valor do seguro NF custo
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
        /// Propriedade referente ao campo: VLSISCOMEX
        /// Comentário: Valor referente a despesas com SISCOMEX
        /// </summary>
        private decimal vlsiscomex;
        [XmlElement(ElementName = "VLSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsiscomex
        {
            get { return  vlsiscomex; }
            set {  vlsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSISCOMEXCUSTO
        /// Comentário: Valor Siscomex Custo
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
        /// Propriedade referente ao campo: VLST
        /// Comentário: Valor do ST NF.
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
        /// Propriedade referente ao campo: VLSTBCR
        /// Comentário: Indica o valor ST BCR.
        /// </summary>
        private decimal vlstbcr;
        [XmlElement(ElementName = "VLSTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstbcr
        {
            get { return  vlstbcr; }
            set {  vlstbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTBONIFIC
        /// Comentário: Não utilizado.
        /// </summary>
        private decimal vlstbonific;
        [XmlElement(ElementName = "VLSTBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstbonific
        {
            get { return  vlstbonific; }
            set {  vlstbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUFRAMA
        /// Comentário: Valor do SUFRAMA.
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
        public PCItem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCITEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCItem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCItem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCItem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCItem>(where);
        }

        #endregion
    }
}
