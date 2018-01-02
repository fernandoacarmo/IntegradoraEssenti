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
    /// Classe referente a tabela PCNfentpreent
    /// </summary>
    [XmlType("PCNFENTPREENT")]
    public class PCNfentpreent : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGREGARSTPRODSINTEGRA
        /// Comentário: Indica se agrega o ST no produto (Sintegra).
        /// </summary>
        private string agregarstprodsintegra;
        [XmlElement(ElementName = "AGREGARSTPRODSINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregarstprodsintegra
        {
            get { return  agregarstprodsintegra; }
            set {  agregarstprodsintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMOUTRASDESP
        /// Comentário: Indica a aliquota do ICMS das despesas.
        /// </summary>
        private decimal aliqicmoutrasdesp;
        [XmlElement(ElementName = "ALIQICMOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmoutrasdesp
        {
            get { return  aliqicmoutrasdesp; }
            set {  aliqicmoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTA
        /// Comentário: 
        /// </summary>
        private decimal aliquota;
        [XmlElement(ElementName = "ALIQUOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliquota
        {
            get { return  aliquota; }
            set {  aliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTCUSTOENTREMESSA
        /// Comentário: Calcula Custo na entrada tipo R (Remessa)
        /// </summary>
        private string altcustoentremessa;
        [XmlElement(ElementName = "ALTCUSTOENTREMESSA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Altcustoentremessa
        {
            get { return  altcustoentremessa; }
            set {  altcustoentremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATACADISTA
        /// Comentário: Indica se e atacadista.
        /// </summary>
        private string atacadista;
        [XmlElement(ElementName = "ATACADISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atacadista
        {
            get { return  atacadista; }
            set {  atacadista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: Indica o bairro do fornecedor.
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
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
        /// Propriedade referente ao campo: BLOQUEIOEDICAO
        /// Comentário: Bloquear pedido para edição. 
        /// </summary>
        private string bloqueioedicao;
        [XmlElement(ElementName = "BLOQUEIOEDICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueioedicao
        {
            get { return  bloqueioedicao; }
            set {  bloqueioedicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCBASEICMSALIQREDENTIMP
        /// Comentário: Calcular base de ICMS com alíquota reduzida na entrada de importação
        /// </summary>
        private string calcbaseicmsaliqredentimp;
        [XmlElement(ElementName = "CALCBASEICMSALIQREDENTIMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcbaseicmsaliqredentimp
        {
            get { return  calcbaseicmsaliqredentimp; }
            set {  calcbaseicmsaliqredentimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDICMCUSTOCONT
        /// Comentário: Calcular crédito de ICMS no custo contábil
        /// </summary>
        private string calccredicmcustocont;
        [XmlElement(ElementName = "CALCCREDICMCUSTOCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredicmcustocont
        {
            get { return  calccredicmcustocont; }
            set {  calccredicmcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDICMS
        /// Comentário: Calcular custo com crédito de ICMS
        /// </summary>
        private string calccredicms;
        [XmlElement(ElementName = "CALCCREDICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredicms
        {
            get { return  calccredicms; }
            set {  calccredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDPISCOFINS
        /// Comentário: Calcular custo com crédito de PIS/COFINS
        /// </summary>
        private string calccredpiscofins;
        [XmlElement(ElementName = "CALCCREDPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredpiscofins
        {
            get { return  calccredpiscofins; }
            set {  calccredpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDPISCUSTOCONT
        /// Comentário: Calcular crédito de PIS/COFINS no custo contábil
        /// </summary>
        private string calccredpiscustocont;
        [XmlElement(ElementName = "CALCCREDPISCUSTOCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredpiscustocont
        {
            get { return  calccredpiscustocont; }
            set {  calccredpiscustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCDESCARGA
        /// Comentário: 
        /// </summary>
        private string calcdescarga;
        [XmlElement(ElementName = "CALCDESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcdescarga
        {
            get { return  calcdescarga; }
            set {  calcdescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCDESPFINPRAZOPGTO
        /// Comentário: Calcular vendor por prazo de pagamento
        /// </summary>
        private string calcdespfinprazopgto;
        [XmlElement(ElementName = "CALCDESPFINPRAZOPGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcdespfinprazopgto
        {
            get { return  calcdespfinprazopgto; }
            set {  calcdespfinprazopgto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCICMSFRETEFOBCSTPROD
        /// Comentário: Define Tributação de ICMS do Frete FOB pelo CST do produto.
        /// </summary>
        private string calcicmsfretefobcstprod;
        [XmlElement(ElementName = "CALCICMSFRETEFOBCSTPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcicmsfretefobcstprod
        {
            get { return  calcicmsfretefobcstprod; }
            set {  calcicmsfretefobcstprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMDESC
        /// Comentário: 
        /// </summary>
        private string calcipicomdesc;
        [XmlElement(ElementName = "CALCIPICOMDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipicomdesc
        {
            get { return  calcipicomdesc; }
            set {  calcipicomdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMFRETEFOB
        /// Comentário: 
        /// </summary>
        private string calcipicomfretefob;
        [XmlElement(ElementName = "CALCIPICOMFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Calcipicomfretefob
        {
            get { return  calcipicomfretefob; }
            set {  calcipicomfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMFRETENF
        /// Comentário: 
        /// </summary>
        private string calcipicomfretenf;
        [XmlElement(ElementName = "CALCIPICOMFRETENF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipicomfretenf
        {
            get { return  calcipicomfretenf; }
            set {  calcipicomfretenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCPISCOFINSFRETEFOBCSTPROD
        /// Comentário: Define Tributação de PIS/COFINS do Frete FOB pelo CST do produto.
        /// </summary>
        private string calcpiscofinsfretefobcstprod;
        [XmlElement(ElementName = "CALCPISCOFINSFRETEFOBCSTPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcpiscofinsfretefobcstprod
        {
            get { return  calcpiscofinsfretefobcstprod; }
            set {  calcpiscofinsfretefobcstprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSTGUIAALIQEXT
        /// Comentário: Calcula ST guia alíquota externa.
        /// </summary>
        private string calcstguiaaliqext;
        [XmlElement(ElementName = "CALCSTGUIAALIQEXT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcstguiaaliqext
        {
            get { return  calcstguiaaliqext; }
            set {  calcstguiaaliqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSUFRAMASOBREPLIQUIDO
        /// Comentário: 
        /// </summary>
        private string calcsuframasobrepliquido;
        [XmlElement(ElementName = "CALCSUFRAMASOBREPLIQUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcsuframasobrepliquido
        {
            get { return  calcsuframasobrepliquido; }
            set {  calcsuframasobrepliquido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULAPISCOFINSCOMIPI
        /// Comentário: 
        /// </summary>
        private string calculapiscofinscomipi;
        [XmlElement(ElementName = "CALCULAPISCOFINSCOMIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calculapiscofinscomipi
        {
            get { return  calculapiscofinscomipi; }
            set {  calculapiscofinscomipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULARIPIPESOLIQ
        /// Comentário: Calcula IPI com base no peso líquido.
        /// </summary>
        private string calcularipipesoliq;
        [XmlElement(ElementName = "CALCULARIPIPESOLIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcularipipesoliq
        {
            get { return  calcularipipesoliq; }
            set {  calcularipipesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: Indica o CEP do fornecedor.
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGC
        /// Comentário: CNPJ do fornecedor.
        /// </summary>
        private string cgc;
        [XmlElement(ElementName = "CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgc
        {
            get { return  cgc; }
            set {  cgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCFILIAL
        /// Comentário: CNPJ da filial.
        /// </summary>
        private string cgcfilial;
        [XmlElement(ElementName = "CGCFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cgcfilial
        {
            get { return  cgcfilial; }
            set {  cgcfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFE
        /// Comentário: 
        /// </summary>
        private string chavenfe;
        [XmlElement(ElementName = "CHAVENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavenfe
        {
            get { return  chavenfe; }
            set {  chavenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFEPRODRURAL
        /// Comentário: Chave da Nfe produtor rural
        /// </summary>
        private string chavenfeprodrural;
        [XmlElement(ElementName = "CHAVENFEPRODRURAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavenfeprodrural
        {
            get { return  chavenfeprodrural; }
            set {  chavenfeprodrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIMCODPROFISSIONALDEVOL
        /// Comentário: 
        /// </summary>
        private decimal cimcodprofissionaldevol;
        [XmlElement(ElementName = "CIMCODPROFISSIONALDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Cimcodprofissionaldevol
        {
            get { return  cimcodprofissionaldevol; }
            set {  cimcodprofissionaldevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIMDIFALIQUOTA
        /// Comentário: 
        /// </summary>
        private decimal cimdifaliquota;
        [XmlElement(ElementName = "CIMDIFALIQUOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Cimdifaliquota
        {
            get { return  cimdifaliquota; }
            set {  cimdifaliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIMPRAZOMEDIO
        /// Comentário: 
        /// </summary>
        private decimal cimprazomedio;
        [XmlElement(ElementName = "CIMPRAZOMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cimprazomedio
        {
            get { return  cimprazomedio; }
            set {  cimprazomedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIMVLICMSDEVIDOST
        /// Comentário: 
        /// </summary>
        private decimal cimvlicmsdevidost;
        [XmlElement(ElementName = "CIMVLICMSDEVIDOST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Cimvlicmsdevidost
        {
            get { return  cimvlicmsdevidost; }
            set {  cimvlicmsdevidost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIMVLICMSNAOAPROV
        /// Comentário: 
        /// </summary>
        private decimal cimvlicmsnaoaprov;
        [XmlElement(ElementName = "CIMVLICMSNAOAPROV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Cimvlicmsnaoaprov
        {
            get { return  cimvlicmsnaoaprov; }
            set {  cimvlicmsnaoaprov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONT
        /// Comentário: 
        /// </summary>
        private decimal codcont;
        [XmlElement(ElementName = "CODCONT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcont
        {
            get { return  codcont; }
            set {  codcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTABFORNEC
        /// Comentário: Indica o código contabil.
        /// </summary>
        private decimal codcontabfornec;
        [XmlElement(ElementName = "CODCONTABFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public decimal Codcontabfornec
        {
            get { return  codcontabfornec; }
            set {  codcontabfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTFOR
        /// Comentário: Cod.Conta para fornecedor.
        /// </summary>
        private decimal codcontfor;
        [XmlElement(ElementName = "CODCONTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontfor
        {
            get { return  codcontfor; }
            set {  codcontfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTFRE
        /// Comentário: Cod.Conta para frete.
        /// </summary>
        private decimal codcontfre;
        [XmlElement(ElementName = "CODCONTFRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontfre
        {
            get { return  codcontfre; }
            set {  codcontfre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEVOL
        /// Comentário: 
        /// </summary>
        private decimal coddevol;
        [XmlElement(ElementName = "CODDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Coddevol
        {
            get { return  coddevol; }
            set {  coddevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENTVEICULO
        /// Comentário: 
        /// </summary>
        private decimal codentveiculo;
        [XmlElement(ElementName = "CODENTVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codentveiculo
        {
            get { return  codentveiculo; }
            set {  codentveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEXPORTADOR
        /// Comentário: 
        /// </summary>
        private decimal codexportador;
        [XmlElement(ElementName = "CODEXPORTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codexportador
        {
            get { return  codexportador; }
            set {  codexportador = value; }
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
        /// Propriedade referente ao campo: CODFILIALNF
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFISCALFRETE
        /// Comentário: Indica o CFOP do frete.
        /// </summary>
        private decimal codfiscalfrete;
        [XmlElement(ElementName = "CODFISCALFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalfrete
        {
            get { return  codfiscalfrete; }
            set {  codfiscalfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOUTRASDESP
        /// Comentário: Indica o CFOP das despesas.
        /// </summary>
        private decimal codfiscaloutrasdesp;
        [XmlElement(ElementName = "CODFISCALOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscaloutrasdesp
        {
            get { return  codfiscaloutrasdesp; }
            set {  codfiscaloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORFILIAL
        /// Comentário: Cód. Fornecedor para a filial.
        /// </summary>
        private decimal codforfilial;
        [XmlElement(ElementName = "CODFORFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codforfilial
        {
            get { return  codforfilial; }
            set {  codforfilial = value; }
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
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Comentário: Indica o código da transportadora.
        /// </summary>
        private decimal codfornecfrete;
        [XmlElement(ElementName = "CODFORNECFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfornecfrete
        {
            get { return  codfornecfrete; }
            set {  codfornecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECNF
        /// Comentário: Indica o código do fornecedor da NF.
        /// </summary>
        private decimal codfornecnf;
        [XmlElement(ElementName = "CODFORNECNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecnf
        {
            get { return  codfornecnf; }
            set {  codfornecnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCANCEL
        /// Comentário: Código do Funcionário
        /// </summary>
        private decimal codfunccancel;
        [XmlElement(ElementName = "CODFUNCCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccancel
        {
            get { return  codfunccancel; }
            set {  codfunccancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCOMERCIAL
        /// Comentário: Código usuário Liberação Comercial
        /// </summary>
        private decimal codfunccomercial;
        [XmlElement(ElementName = "CODFUNCCOMERCIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccomercial
        {
            get { return  codfunccomercial; }
            set {  codfunccomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCENVIO
        /// Comentário: Campo para indicar código do funcionário que exportou arquivos para a Integração MWS.
        /// </summary>
        private decimal codfuncenvio;
        [XmlElement(ElementName = "CODFUNCENVIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncenvio
        {
            get { return  codfuncenvio; }
            set {  codfuncenvio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCENVIOWMS
        /// Comentário: Campo para indicar código do funcionário que exportou arquivos para a Integração MWS. 
        /// </summary>
        private decimal codfuncenviowms;
        [XmlElement(ElementName = "CODFUNCENVIOWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncenviowms
        {
            get { return  codfuncenviowms; }
            set {  codfuncenviowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXPARQOL
        /// Comentário: 
        /// </summary>
        private decimal codfuncexparqol;
        [XmlElement(ElementName = "CODFUNCEXPARQOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexparqol
        {
            get { return  codfuncexparqol; }
            set {  codfuncexparqol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXPINTWMS
        /// Comentário: Campo para indicar código do funcionário que exportou arquivos para a Integração MWS.
        /// </summary>
        private decimal codfuncexpintwms;
        [XmlElement(ElementName = "CODFUNCEXPINTWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexpintwms
        {
            get { return  codfuncexpintwms; }
            set {  codfuncexpintwms = value; }
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
        /// Propriedade referente ao campo: CODFUNCLIBER
        /// Comentário: Campo para armazenar o código do funcionário responsável pela liberação da pré-entrada. 
        /// </summary>
        private decimal codfuncliber;
        [XmlElement(ElementName = "CODFUNCLIBER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncliber
        {
            get { return  codfuncliber; }
            set {  codfuncliber = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIBGE
        /// Comentário: Indica o código IBGE.
        /// </summary>
        private decimal codibge;
        [XmlElement(ElementName = "CODIBGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codibge
        {
            get { return  codibge; }
            set {  codibge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTADEVOL
        /// Comentário: 
        /// </summary>
        private decimal codmotoristadevol;
        [XmlElement(ElementName = "CODMOTORISTADEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotoristadevol
        {
            get { return  codmotoristadevol; }
            set {  codmotoristadevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNICIPIO
        /// Comentário: Indica o código municipio.
        /// </summary>
        private decimal codmunicipio;
        [XmlElement(ElementName = "CODMUNICIPIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codmunicipio
        {
            get { return  codmunicipio; }
            set {  codmunicipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Comentário: Código do País.
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Comentário: Indica o código do profissional que a mencadoria esta sendo entregue.
        /// </summary>
        private decimal codprofissional;
        [XmlElement(ElementName = "CODPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprofissional
        {
            get { return  codprofissional; }
            set {  codprofissional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRECEITARECOLHIM
        /// Comentário: Código da receita.
        /// </summary>
        private string codreceitarecolhim;
        [XmlElement(ElementName = "CODRECEITARECOLHIM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codreceitarecolhim
        {
            get { return  codreceitarecolhim; }
            set {  codreceitarecolhim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINADESBLOQUEIO
        /// Comentário: 
        /// </summary>
        private decimal codrotinadesbloqueio;
        [XmlElement(ElementName = "CODROTINADESBLOQUEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotinadesbloqueio
        {
            get { return  codrotinadesbloqueio; }
            set {  codrotinadesbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSP
        /// Comentário: 
        /// </summary>
        private decimal codtransp;
        [XmlElement(ElementName = "CODTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtransp
        {
            get { return  codtransp; }
            set {  codtransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURDEVOL
        /// Comentário: 
        /// </summary>
        private decimal codusurdevol;
        [XmlElement(ElementName = "CODUSURDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusurdevol
        {
            get { return  codusurdevol; }
            set {  codusurdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVIA
        /// Comentário: Código da via de transporte
        /// </summary>
        private decimal codvia;
        [XmlElement(ElementName = "CODVIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codvia
        {
            get { return  codvia; }
            set {  codvia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCILIACAO
        /// Comentário: 
        /// </summary>
        private string conciliacao;
        [XmlElement(ElementName = "CONCILIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Conciliacao
        {
            get { return  conciliacao; }
            set {  conciliacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSFRETEFOBBASESTNF
        /// Comentário: Considera Frete FOB base ST NF
        /// </summary>
        private string consfretefobbasestnf;
        [XmlElement(ElementName = "CONSFRETEFOBBASESTNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consfretefobbasestnf
        {
            get { return  consfretefobbasestnf; }
            set {  consfretefobbasestnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSFRETEFOBCALCICMSANTECIP
        /// Comentário: Considera frete FOB para o calculo do ICMS antecipado.
        /// </summary>
        private string consfretefobcalcicmsantecip;
        [XmlElement(ElementName = "CONSFRETEFOBCALCICMSANTECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consfretefobcalcicmsantecip
        {
            get { return  consfretefobcalcicmsantecip; }
            set {  consfretefobcalcicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAIPINOFRETEFOB
        /// Comentário: Verifica se o valor do IPI entrar ou não na base do Frete FOB para distribuição entre os itens
        /// </summary>
        private string consideraipinofretefob;
        [XmlElement(ElementName = "CONSIDERAIPINOFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideraipinofretefob
        {
            get { return  consideraipinofretefob; }
            set {  consideraipinofretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERARIIPUNIT
        /// Comentário: Considerar o imposto de importação no preço unitário do produto DANFE
        /// </summary>
        private string considerariipunit;
        [XmlElement(ElementName = "CONSIDERARIIPUNIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerariipunit
        {
            get { return  considerariipunit; }
            set {  considerariipunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIPICALCBASECREPRES
        /// Comentário: 
        /// </summary>
        private string consipicalcbasecrepres;
        [XmlElement(ElementName = "CONSIPICALCBASECREPRES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consipicalcbasecrepres
        {
            get { return  consipicalcbasecrepres; }
            set {  consipicalcbasecrepres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIPICALCBASEST
        /// Comentário: 
        /// </summary>
        private string consipicalcbasest;
        [XmlElement(ElementName = "CONSIPICALCBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consipicalcbasest
        {
            get { return  consipicalcbasest; }
            set {  consipicalcbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSSTGUIAPISCOFINS
        /// Comentário: Considera ST Guia Base do PISCOFINS.
        /// </summary>
        private string consstguiapiscofins;
        [XmlElement(ElementName = "CONSSTGUIAPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consstguiapiscofins
        {
            get { return  consstguiapiscofins; }
            set {  consstguiapiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSSTNFPISCOFINS
        /// Comentário: Considerar o ST Nota fiscal no PIS/COFINS.
        /// </summary>
        private string consstnfpiscofins;
        [XmlElement(ElementName = "CONSSTNFPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consstnfpiscofins
        {
            get { return  consstnfpiscofins; }
            set {  consstnfpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSUMIDORFINAL
        /// Comentário: Indica consumidor final.
        /// </summary>
        private string consumidorfinal;
        [XmlElement(ElementName = "CONSUMIDORFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consumidorfinal
        {
            get { return  consumidorfinal; }
            set {  consumidorfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSUMIUNUMNFE
        /// Comentário: Informa se o número da NFE foi gerado no SEFAZ
        /// </summary>
        private string consumiunumnfe;
        [XmlElement(ElementName = "CONSUMIUNUMNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consumiunumnfe
        {
            get { return  consumiunumnfe; }
            set {  consumiunumnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATADIIMPORTACAO
        /// Comentário: Indica a data de importação.
        /// </summary>
        private DateTime? datadiimportacao;
        [XmlElement(ElementName = "DATADIIMPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datadiimportacao
        {
            get { return  datadiimportacao; }
            set {  datadiimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAEXPARQOL
        /// Comentário: 
        /// </summary>
        private DateTime? dataexparqol;
        [XmlElement(ElementName = "DATAEXPARQOL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataexparqol
        {
            get { return  dataexparqol; }
            set {  dataexparqol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDFRETECIFCREDPRESICMS
        /// Comentário: Considera frete FOB no calculo da base PIS/COFINS
        /// </summary>
        private string dedfretecifcredpresicms;
        [XmlElement(ElementName = "DEDFRETECIFCREDPRESICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dedfretecifcredpresicms
        {
            get { return  dedfretecifcredpresicms; }
            set {  dedfretecifcredpresicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMABCSTALIQ1
        /// Comentário: 
        /// </summary>
        private string deduzirsuframabcstaliq1;
        [XmlElement(ElementName = "DEDUZIRSUFRAMABCSTALIQ1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframabcstaliq1
        {
            get { return  deduzirsuframabcstaliq1; }
            set {  deduzirsuframabcstaliq1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMACALCCREDICM
        /// Comentário: 
        /// </summary>
        private string deduzirsuframacalccredicm;
        [XmlElement(ElementName = "DEDUZIRSUFRAMACALCCREDICM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframacalccredicm
        {
            get { return  deduzirsuframacalccredicm; }
            set {  deduzirsuframacalccredicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMACALCCREDPIS
        /// Comentário: 
        /// </summary>
        private string deduzirsuframacalccredpis;
        [XmlElement(ElementName = "DEDUZIRSUFRAMACALCCREDPIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframacalccredpis
        {
            get { return  deduzirsuframacalccredpis; }
            set {  deduzirsuframacalccredpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCPAIS
        /// Comentário: Descrição do País.
        /// </summary>
        private string descpais;
        [XmlElement(ElementName = "DESCPAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descpais
        {
            get { return  descpais; }
            set {  descpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data de Cancelamento do Bônus
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONCIL
        /// Comentário: 
        /// </summary>
        private DateTime? dtconcil;
        [XmlElement(ElementName = "DTCONCIL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtconcil
        {
            get { return  dtconcil; }
            set {  dtconcil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDESCARGA
        /// Comentário: 
        /// </summary>
        private DateTime? dtdescarga;
        [XmlElement(ElementName = "DTDESCARGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdescarga
        {
            get { return  dtdescarga; }
            set {  dtdescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAONFVENDA
        /// Comentário: Indica a data da emissão da NF.
        /// </summary>
        private DateTime? dtemissaonfvenda;
        [XmlElement(ElementName = "DTEMISSAONFVENDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaonfvenda
        {
            get { return  dtemissaonfvenda; }
            set {  dtemissaonfvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOPRODRURAL
        /// Comentário: Data de emissão NF produtor rural
        /// </summary>
        private DateTime? dtemissaoprodrural;
        [XmlElement(ElementName = "DTEMISSAOPRODRURAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoprodrural
        {
            get { return  dtemissaoprodrural; }
            set {  dtemissaoprodrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENT
        /// Comentário: 
        /// </summary>
        private DateTime? dtent;
        [XmlElement(ElementName = "DTENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtent
        {
            get { return  dtent; }
            set {  dtent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENVIOWMS
        /// Comentário: Campo para gravar a data, hora e minutos que a nota fiscal foi enviada ao WMS.
        /// </summary>
        private DateTime? dtenviowms;
        [XmlElement(ElementName = "DTENVIOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtenviowms
        {
            get { return  dtenviowms; }
            set {  dtenviowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORANFE
        /// Comentário: 
        /// </summary>
        private DateTime? dthoranfe;
        [XmlElement(ElementName = "DTHORANFE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoranfe
        {
            get { return  dthoranfe; }
            set {  dthoranfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBER
        /// Comentário: Campo para armazenar a data e hora da liberação da pré-entrada. 
        /// </summary>
        private DateTime? dtliber;
        [XmlElement(ElementName = "DTLIBER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtliber
        {
            get { return  dtliber; }
            set {  dtliber = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBERACOMERCIAL
        /// Comentário: Data Liberação Comercial
        /// </summary>
        private DateTime? dtliberacomercial;
        [XmlElement(ElementName = "DTLIBERACOMERCIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtliberacomercial
        {
            get { return  dtliberacomercial; }
            set {  dtliberacomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNSU
        /// Comentário: 
        /// </summary>
        private DateTime? dtnsu;
        [XmlElement(ElementName = "DTNSU", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnsu
        {
            get { return  dtnsu; }
            set {  dtnsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREENTRADA
        /// Comentário: Campo para armazenar a data e hora de registro da pré-entrada. 
        /// </summary>
        private DateTime? dtpreentrada;
        [XmlElement(ElementName = "DTPREENTRADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpreentrada
        {
            get { return  dtpreentrada; }
            set {  dtpreentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXATU
        /// Comentário: Data para a proxima atualização do custo financeiro
        /// </summary>
        private DateTime? dtproxatu;
        [XmlElement(ElementName = "DTPROXATU", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxatu
        {
            get { return  dtproxatu; }
            set {  dtproxatu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDA
        /// Comentário: 
        /// </summary>
        private DateTime? dtsaida;
        [XmlElement(ElementName = "DTSAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsaida
        {
            get { return  dtsaida; }
            set {  dtsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSELOFISCAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtselofiscal;
        [XmlElement(ElementName = "DTSELOFISCAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtselofiscal
        {
            get { return  dtselofiscal; }
            set {  dtselofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTTERMINOCIAP
        /// Comentário: Data do termino do CIAP.
        /// </summary>
        private DateTime? dtterminociap;
        [XmlElement(ElementName = "DTTERMINOCIAP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtterminociap
        {
            get { return  dtterminociap; }
            set {  dtterminociap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCSTFORANF
        /// Comentário: Indica a data vencimento.
        /// </summary>
        private DateTime? dtvencstforanf;
        [XmlElement(ElementName = "DTVENCSTFORANF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencstforanf
        {
            get { return  dtvencstforanf; }
            set {  dtvencstforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTWMS
        /// Comentário: 
        /// </summary>
        private DateTime? dtwms;
        [XmlElement(ElementName = "DTWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtwms
        {
            get { return  dtwms; }
            set {  dtwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMISSAOPROPRIA
        /// Comentário: Indica se a emissão da nota de entrada é propria ou de terceiros.
        /// </summary>
        private string emissaopropria;
        [XmlElement(ElementName = "EMISSAOPROPRIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emissaopropria
        {
            get { return  emissaopropria; }
            set {  emissaopropria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITENFSIMBOLICACONSIG
        /// Comentário: Emite Nota Fiscal Devolução Simbólica de Consignação
        /// </summary>
        private string emitenfsimbolicaconsig;
        [XmlElement(ElementName = "EMITENFSIMBOLICACONSIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitenfsimbolicaconsig
        {
            get { return  emitenfsimbolicaconsig; }
            set {  emitenfsimbolicaconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: Indica o endereço do fornecedor.
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENTRADATIPOI
        /// Comentário: 
        /// </summary>
        private string entradatipoi;
        [XmlElement(ElementName = "ENTRADATIPOI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Entradatipoi
        {
            get { return  entradatipoi; }
            set {  entradatipoi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADA
        /// Comentário: Indica se em caso de contingência, já enviou para o SEFAZ.
        /// </summary>
        private string enviada;
        [XmlElement(ElementName = "ENVIADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviada
        {
            get { return  enviada; }
            set {  enviada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADANFE
        /// Comentário: NF-e já enviada ao cliente.
        /// </summary>
        private string enviadanfe;
        [XmlElement(ElementName = "ENVIADANFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadanfe
        {
            get { return  enviadanfe; }
            set {  enviadanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EQUIPLANC
        /// Comentário: 
        /// </summary>
        private string equiplanc;
        [XmlElement(ElementName = "EQUIPLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,64)]
        public string Equiplanc
        {
            get { return  equiplanc; }
            set {  equiplanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIE
        /// Comentário: 
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIEVOLUME
        /// Comentário: Indica a espécie do volume.
        /// </summary>
        private string especievolume;
        [XmlElement(ElementName = "ESPECIEVOLUME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Especievolume
        {
            get { return  especievolume; }
            set {  especievolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTCOMISSAORCA
        /// Comentário: 
        /// </summary>
        private string estcomissaorca;
        [XmlElement(ElementName = "ESTCOMISSAORCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estcomissaorca
        {
            get { return  estcomissaorca; }
            set {  estcomissaorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FECHAMENTOCEAUTOMATICO
        /// Comentário: Fechamento automático do controle de embarque
        /// </summary>
        private string fechamentoceautomatico;
        [XmlElement(ElementName = "FECHAMENTOCEAUTOMATICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fechamentoceautomatico
        {
            get { return  fechamentoceautomatico; }
            set {  fechamentoceautomatico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FINALIDADENFE
        /// Comentário: Finalidade NF-e
        /// </summary>
        private string finalidadenfe;
        [XmlElement(ElementName = "FINALIDADENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Finalidadenfe
        {
            get { return  finalidadenfe; }
            set {  finalidadenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORNECEDOR
        /// Comentário: Razão social do fornecedor.
        /// </summary>
        private string fornecedor;
        [XmlElement(ElementName = "FORNECEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Fornecedor
        {
            get { return  fornecedor; }
            set {  fornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCLANC
        /// Comentário: 
        /// </summary>
        private string funclanc;
        [XmlElement(ElementName = "FUNCLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Funclanc
        {
            get { return  funclanc; }
            set {  funclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERANFDEVCLI
        /// Comentário: 
        /// </summary>
        private string geranfdevcli;
        [XmlElement(ElementName = "GERANFDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geranfdevcli
        {
            get { return  geranfdevcli; }
            set {  geranfdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERANFVENDA
        /// Comentário: 
        /// </summary>
        private string geranfvenda;
        [XmlElement(ElementName = "GERANFVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geranfvenda
        {
            get { return  geranfvenda; }
            set {  geranfvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GPVTROCA
        /// Comentário: 
        /// </summary>
        private string gpvtroca;
        [XmlElement(ElementName = "GPVTROCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gpvtroca
        {
            get { return  gpvtroca; }
            set {  gpvtroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: Se gerou ou não histórico.
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORALANC
        /// Comentário: 
        /// </summary>
        private string horalanc;
        [XmlElement(ElementName = "HORALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Horalanc
        {
            get { return  horalanc; }
            set {  horalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IE
        /// Comentário: IE do fornecedor.
        /// </summary>
        private string ie;
        [XmlElement(ElementName = "IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ie
        {
            get { return  ie; }
            set {  ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEFILIAL
        /// Comentário: IE da filial.
        /// </summary>
        private string iefilial;
        [XmlElement(ElementName = "IEFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Iefilial
        {
            get { return  iefilial; }
            set {  iefilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IESUBSTTRIBUT
        /// Comentário: IE como substituto tributário na UF.
        /// </summary>
        private string iesubsttribut;
        [XmlElement(ElementName = "IESUBSTTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Iesubsttribut
        {
            get { return  iesubsttribut; }
            set {  iesubsttribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOXML
        /// Comentário: Informa se a pre-entrada é importada de xml
        /// </summary>
        private string importadoxml;
        [XmlElement(ElementName = "IMPORTADOXML", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoxml
        {
            get { return  importadoxml; }
            set {  importadoxml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCLUIRIMPOSTOSNFTRANSPIMP
        /// Comentário: Incluir impostos no preço da mercadoria NF de transporte importação
        /// </summary>
        private string incluirimpostosnftranspimp;
        [XmlElement(ElementName = "INCLUIRIMPOSTOSNFTRANSPIMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incluirimpostosnftranspimp
        {
            get { return  incluirimpostosnftranspimp; }
            set {  incluirimpostosnftranspimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDUSTRIALOCAL
        /// Comentário: Se fornecedor tem industria local.
        /// </summary>
        private string industrialocal;
        [XmlElement(ElementName = "INDUSTRIALOCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Industrialocal
        {
            get { return  industrialocal; }
            set {  industrialocal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTOST
        /// Comentário: Indica o fornecedor isento de ST.
        /// </summary>
        private string isentost;
        [XmlElement(ElementName = "ISENTOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentost
        {
            get { return  isentost; }
            set {  isentost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALDESEMBARACO
        /// Comentário: 
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
        /// Propriedade referente ao campo: LOTEDIGITADO
        /// Comentário: 
        /// </summary>
        private string lotedigitado;
        [XmlElement(ElementName = "LOTEDIGITADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lotedigitado
        {
            get { return  lotedigitado; }
            set {  lotedigitado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARCAVOLUME
        /// Comentário: Marca do container
        /// </summary>
        private string marcavolume;
        [XmlElement(ElementName = "MARCAVOLUME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Marcavolume
        {
            get { return  marcavolume; }
            set {  marcavolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOLANC
        /// Comentário: 
        /// </summary>
        private string minutolanc;
        [XmlElement(ElementName = "MINUTOLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Minutolanc
        {
            get { return  minutolanc; }
            set {  minutolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: Identifica o modelo do documento fiscal.
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Modelo
        {
            get { return  modelo; }
            set {  modelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELOPRODRURAL
        /// Comentário: Modelo da NF produtor rural
        /// </summary>
        private string modeloprodrural;
        [XmlElement(ElementName = "MODELOPRODRURAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Modeloprodrural
        {
            get { return  modeloprodrural; }
            set {  modeloprodrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOCANCEL
        /// Comentário: Motivo do Cancelamento.
        /// </summary>
        private string motivocancel;
        [XmlElement(ElementName = "MOTIVOCANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Motivocancel
        {
            get { return  motivocancel; }
            set {  motivocancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOLIBER
        /// Comentário: Campo para armazenar o motivo da liberação da pré-entrada. 
        /// </summary>
        private string motivoliber;
        [XmlElement(ElementName = "MOTIVOLIBER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Motivoliber
        {
            get { return  motivoliber; }
            set {  motivoliber = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVESTOQUEIMPORT
        /// Comentário: Utiliza estoque em Trânsito na entrada Importação
        /// </summary>
        private string movestoqueimport;
        [XmlElement(ElementName = "MOVESTOQUEIMPORT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Movestoqueimport
        {
            get { return  movestoqueimport; }
            set {  movestoqueimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICIPIO
        /// Comentário: Indica a cidade do fornecedor.
        /// </summary>
        private string municipio;
        [XmlElement(ElementName = "MUNICIPIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municipio
        {
            get { return  municipio; }
            set {  municipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NFENTREGAFUTURA
        /// Comentário: 
        /// </summary>
        private string nfentregafutura;
        [XmlElement(ElementName = "NFENTREGAFUTURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Nfentregafutura
        {
            get { return  nfentregafutura; }
            set {  nfentregafutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Comentário: 
        /// </summary>
        private decimal nsu;
        [XmlElement(ElementName = "NSU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
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
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIIMPORTACAO
        /// Comentário: 
        /// </summary>
        private string numdiimportacao;
        [XmlElement(ElementName = "NUMDIIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Numdiimportacao
        {
            get { return  numdiimportacao; }
            set {  numdiimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMENTMEX
        /// Comentário: 
        /// </summary>
        private decimal numentmex;
        [XmlElement(ElementName = "NUMENTMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numentmex
        {
            get { return  numentmex; }
            set {  numentmex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMULARIO
        /// Comentário: 
        /// </summary>
        private decimal numformulario;
        [XmlElement(ElementName = "NUMFORMULARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numformulario
        {
            get { return  numformulario; }
            set {  numformulario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMIDF
        /// Comentário: 
        /// </summary>
        private string numidf;
        [XmlElement(ElementName = "NUMIDF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numidf
        {
            get { return  numidf; }
            set {  numidf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTENFE
        /// Comentário: Número de Lote da Nota Fiscal Eletrônica.
        /// </summary>
        private string numlotenfe;
        [XmlElement(ElementName = "NUMLOTENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlotenfe
        {
            get { return  numlotenfe; }
            set {  numlotenfe = value; }
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
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAENTFUTURA
        /// Comentário: 
        /// </summary>
        private decimal numnotaentfutura;
        [XmlElement(ElementName = "NUMNOTAENTFUTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotaentfutura
        {
            get { return  numnotaentfutura; }
            set {  numnotaentfutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAPRODRURAL
        /// Comentário: Numero da NF produtor rural
        /// </summary>
        private decimal numnotaprodrural;
        [XmlElement(ElementName = "NUMNOTAPRODRURAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotaprodrural
        {
            get { return  numnotaprodrural; }
            set {  numnotaprodrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAVENDA
        /// Comentário: Indica o número da NF de venda.
        /// </summary>
        private decimal numnotavenda;
        [XmlElement(ElementName = "NUMNOTAVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotavenda
        {
            get { return  numnotavenda; }
            set {  numnotavenda = value; }
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
        /// Propriedade referente ao campo: NUMPARCDEVOL
        /// Comentário: 
        /// </summary>
        private decimal numparcdevol;
        [XmlElement(ElementName = "NUMPARCDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numparcdevol
        {
            get { return  numparcdevol; }
            set {  numparcdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDPREENT
        /// Comentário: 
        /// </summary>
        private decimal numpedpreent;
        [XmlElement(ElementName = "NUMPEDPREENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedpreent
        {
            get { return  numpedpreent; }
            set {  numpedpreent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDPRINC
        /// Comentário: Número do pedido de compra principal
        /// </summary>
        private decimal numpedprinc;
        [XmlElement(ElementName = "NUMPEDPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numpedprinc
        {
            get { return  numpedprinc; }
            set {  numpedprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSELONF
        /// Comentário: 
        /// </summary>
        private decimal numselonf;
        [XmlElement(ElementName = "NUMSELONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numselonf
        {
            get { return  numselonf; }
            set {  numselonf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENVIO
        /// Comentário: Campo para gravar o número de seqüência dos arquivos enviado.
        /// </summary>
        private decimal numseqenvio;
        [XmlElement(ElementName = "NUMSEQENVIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseqenvio
        {
            get { return  numseqenvio; }
            set {  numseqenvio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTAB
        /// Comentário: 
        /// </summary>
        private decimal numtab;
        [XmlElement(ElementName = "NUMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numtab
        {
            get { return  numtab; }
            set {  numtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSBENEFIC
        /// Comentário: 
        /// </summary>
        private decimal numtransbenefic;
        [XmlElement(ElementName = "NUMTRANSBENEFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransbenefic
        {
            get { return  numtransbenefic; }
            set {  numtransbenefic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSORIGEM
        /// Comentário: 
        /// </summary>
        private decimal numtransorigem;
        [XmlElement(ElementName = "NUMTRANSORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransorigem
        {
            get { return  numtransorigem; }
            set {  numtransorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAORIG
        /// Comentário: Indica a transação original de entrada consignação.
        /// </summary>
        private decimal numtransvendaorig;
        [XmlElement(ElementName = "NUMTRANSVENDAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaorig
        {
            get { return  numtransvendaorig; }
            set {  numtransvendaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDATROCA
        /// Comentário: Indica o numero da transação a qual ocorreu a troca.
        /// </summary>
        private decimal numtransvendatroca;
        [XmlElement(ElementName = "NUMTRANSVENDATROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendatroca
        {
            get { return  numtransvendatroca; }
            set {  numtransvendatroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: Indica o numero de vias impressas.
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOL
        /// Comentário: 
        /// </summary>
        private decimal numvol;
        [XmlElement(ElementName = "NUMVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numvol
        {
            get { return  numvol; }
            set {  numvol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLUME
        /// Comentário: Numeração do container
        /// </summary>
        private string numvolume;
        [XmlElement(ElementName = "NUMVOLUME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numvolume
        {
            get { return  numvolume; }
            set {  numvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS1
        /// Comentário: Indica a observação com  relação ao recebimento de mercadoria.
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,120)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: Indica a observação com  relação ao recebimento de mercadoria.
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,120)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OTHPERCREDDEV
        /// Comentário: 
        /// </summary>
        private decimal othpercreddev;
        [XmlElement(ElementName = "OTHPERCREDDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Othpercreddev
        {
            get { return  othpercreddev; }
            set {  othpercreddev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal perbaseredoutrasdesp;
        [XmlElement(ElementName = "PERBASEREDOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredoutrasdesp
        {
            get { return  perbaseredoutrasdesp; }
            set {  perbaseredoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALTERCUSTOENT
        /// Comentário: 
        /// </summary>
        private decimal percaltercustoent;
        [XmlElement(ElementName = "PERCALTERCUSTOENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percaltercustoent
        {
            get { return  percaltercustoent; }
            set {  percaltercustoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMFRETE
        /// Comentário: Indica a aliquota do ICMS frete.
        /// </summary>
        private decimal percicmfrete;
        [XmlElement(ElementName = "PERCICMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percicmfrete
        {
            get { return  percicmfrete; }
            set {  percicmfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBST
        /// Comentário: Idinca o percentual de icms frete fob a ser utilizado como crédito no calculo do ST fora da nf ou BCR.
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
        /// Propriedade referente ao campo: PERCPISRED
        /// Comentário: % Redução PIS.
        /// </summary>
        private decimal percpisred;
        [XmlElement(ElementName = "PERCPISRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percpisred
        {
            get { return  percpisred; }
            set {  percpisred = value; }
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
        /// Propriedade referente ao campo: PESOFRETEFOB
        /// Comentário: 
        /// </summary>
        private decimal pesofretefob;
        [XmlElement(ElementName = "PESOFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesofretefob
        {
            get { return  pesofretefob; }
            set {  pesofretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSSECODFORNEC
        /// Comentário: Código Fornecedor da empresa que está de posse da mercadoria.
        /// </summary>
        private decimal possecodfornec;
        [XmlElement(ElementName = "POSSECODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Possecodfornec
        {
            get { return  possecodfornec; }
            set {  possecodfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO
        /// Comentário: Prazo medio
        /// </summary>
        private decimal prazo;
        [XmlElement(ElementName = "PRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Prazo
        {
            get { return  prazo; }
            set {  prazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFE
        /// Comentário: 
        /// </summary>
        private string protocolonfe;
        [XmlElement(ElementName = "PROTOCOLONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolonfe
        {
            get { return  protocolonfe; }
            set {  protocolonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFEAUTO
        /// Comentário: Indica o protocolo de autorizaçãoda NF-e.
        /// </summary>
        private string protocolonfeauto;
        [XmlElement(ElementName = "PROTOCOLONFEAUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolonfeauto
        {
            get { return  protocolonfeauto; }
            set {  protocolonfeauto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFECAN
        /// Comentário: Indica o protocolo de cancelamento da NF-e.
        /// </summary>
        private string protocolonfecan;
        [XmlElement(ElementName = "PROTOCOLONFECAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolonfecan
        {
            get { return  protocolonfecan; }
            set {  protocolonfecan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAFA
        /// Comentário: 
        /// </summary>
        private string rafa;
        [XmlElement(ElementName = "RAFA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Rafa
        {
            get { return  rafa; }
            set {  rafa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REBAIXACUSTOCOMDESCFIN
        /// Comentário: Calcular custo com descontofinanceiro
        /// </summary>
        private string rebaixacustocomdescfin;
        [XmlElement(ElementName = "REBAIXACUSTOCOMDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rebaixacustocomdescfin
        {
            get { return  rebaixacustocomdescfin; }
            set {  rebaixacustocomdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REMESSAUNICA
        /// Comentário: Remessa única
        /// </summary>
        private string remessaunica;
        [XmlElement(ElementName = "REMESSAUNICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Remessaunica
        {
            get { return  remessaunica; }
            set {  remessaunica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESULTADOLAUDO
        /// Comentário: Resultado Laudo
        /// </summary>
        private string resultadolaudo;
        [XmlElement(ElementName = "RESULTADOLAUDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Resultadolaudo
        {
            get { return  resultadolaudo; }
            set {  resultadolaudo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REVENDA
        /// Comentário: Se fornecedor revende, sim ou não.
        /// </summary>
        private string revenda;
        [XmlElement(ElementName = "REVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Revenda
        {
            get { return  revenda; }
            set {  revenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Comentário: 
        /// </summary>
        private string rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFVENDA
        /// Comentário: Indica a serie da NF de venda.
        /// </summary>
        private string serienfvenda;
        [XmlElement(ElementName = "SERIENFVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfvenda
        {
            get { return  serienfvenda; }
            set {  serienfvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEPRODRURAL
        /// Comentário: Serie da NF produtor rural
        /// </summary>
        private string serieprodrural;
        [XmlElement(ElementName = "SERIEPRODRURAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serieprodrural
        {
            get { return  serieprodrural; }
            set {  serieprodrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPLESNACIONAL
        /// Comentário: Indica o simples nacional.
        /// </summary>
        private string simplesnacional;
        [XmlElement(ElementName = "SIMPLESNACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Simplesnacional
        {
            get { return  simplesnacional; }
            set {  simplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: Campo para armazenar a situação da préentrada (L-Liberada, LD-Liberada com Divergência, D-Divergente, E-Entrada e ED-Entrada Divergente. 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAONFE
        /// Comentário: 
        /// </summary>
        private decimal situacaonfe;
        [XmlElement(ElementName = "SITUACAONFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Situacaonfe
        {
            get { return  situacaonfe; }
            set {  situacaonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMAFRETEFOBNOSTFORANF
        /// Comentário: 
        /// </summary>
        private string somafretefobnostforanf;
        [XmlElement(ElementName = "SOMAFRETEFOBNOSTFORANF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somafretefobnostforanf
        {
            get { return  somafretefobnostforanf; }
            set {  somafretefobnostforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMARPISCOFINSVLOUTRASDESPIMP
        /// Comentário: Somar valor outras despesas e despesas aduaneiras no DANFE.
        /// </summary>
        private string somarpiscofinsvloutrasdespimp;
        [XmlElement(ElementName = "SOMARPISCOFINSVLOUTRASDESPIMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somarpiscofinsvloutrasdespimp
        {
            get { return  somarpiscofinsvloutrasdespimp; }
            set {  somarpiscofinsvloutrasdespimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMARVLOUTRASDESPADUANEIRAS
        /// Comentário: Incluir PIS/COFINS no valor de Outras Despesas DANFe Importação
        /// </summary>
        private string somarvloutrasdespaduaneiras;
        [XmlElement(ElementName = "SOMARVLOUTRASDESPADUANEIRAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somarvloutrasdespaduaneiras
        {
            get { return  somarvloutrasdespaduaneiras; }
            set {  somarvloutrasdespaduaneiras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSCOMERCIAL
        /// Comentário: Status liberação Valores Comerciais
        /// </summary>
        private string statuscomercial;
        [XmlElement(ElementName = "STATUSCOMERCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Statuscomercial
        {
            get { return  statuscomercial; }
            set {  statuscomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOAPRO
        /// Comentário: 
        /// </summary>
        private decimal tempoapro;
        [XmlElement(ElementName = "TEMPOAPRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Tempoapro
        {
            get { return  tempoapro; }
            set {  tempoapro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPODESCARGA
        /// Comentário: 
        /// </summary>
        private decimal tempodescarga;
        [XmlElement(ElementName = "TEMPODESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Tempodescarga
        {
            get { return  tempodescarga; }
            set {  tempodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TENTATIVAENVIONFE
        /// Comentário: Indica a quantidade de tentativas de envio da nota fiscal a SEFAZ.
        /// </summary>
        private decimal tentativaenvionfe;
        [XmlElement(ElementName = "TENTATIVAENVIONFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tentativaenvionfe
        {
            get { return  tentativaenvionfe; }
            set {  tentativaenvionfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOALIQOUTRASDESP
        /// Comentário: Tipo de tributação do frete e despesas.
        /// </summary>
        private string tipoaliqoutrasdesp;
        [XmlElement(ElementName = "TIPOALIQOUTRASDESP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoaliqoutrasdesp
        {
            get { return  tipoaliqoutrasdesp; }
            set {  tipoaliqoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCARGA
        /// Comentário: 
        /// </summary>
        private string tipodescarga;
        [XmlElement(ElementName = "TIPODESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodescarga
        {
            get { return  tipodescarga; }
            set {  tipodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMPEDIDO
        /// Comentário: Tipo de embalagem V = Venda, M = Master
        /// </summary>
        private string tipoembalagempedido;
        [XmlElement(ElementName = "TIPOEMBALAGEMPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagempedido
        {
            get { return  tipoembalagempedido; }
            set {  tipoembalagempedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMVENDA
        /// Comentário: Tipo da Embalagem de Venda
        /// </summary>
        private string tipoembalagemvenda;
        [XmlElement(ElementName = "TIPOEMBALAGEMVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagemvenda
        {
            get { return  tipoembalagemvenda; }
            set {  tipoembalagemvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMISSAO
        /// Comentário: Tipo de emissão da NFE (Normal, Contingência, SCAN).
        /// </summary>
        private string tipoemissao;
        [XmlElement(ElementName = "TIPOEMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoemissao
        {
            get { return  tipoemissao; }
            set {  tipoemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFJ
        /// Comentário: Tipo pessoa do cliente (quando devolucao).
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
        /// Propriedade referente ao campo: TIPOFORNEC
        /// Comentário: Tipo do fornecedor (industria / comercio).
        /// </summary>
        private string tipofornec;
        [XmlElement(ElementName = "TIPOFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofornec
        {
            get { return  tipofornec; }
            set {  tipofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Comentário: 
        /// </summary>
        private string tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETECIFFOB
        /// Comentário: Indica o tipo frete (CIF/FOB).
        /// </summary>
        private string tipofreteciffob;
        [XmlElement(ElementName = "TIPOFRETECIFFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofreteciffob
        {
            get { return  tipofreteciffob; }
            set {  tipofreteciffob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETEFOB
        /// Comentário: 
        /// </summary>
        private string tipofretefob;
        [XmlElement(ElementName = "TIPOFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofretefob
        {
            get { return  tipofretefob; }
            set {  tipofretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOVGARANTIA
        /// Comentário: Tipo movimentação grantia
        /// </summary>
        private decimal tipomovgarantia;
        [XmlElement(ElementName = "TIPOMOVGARANTIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tipomovgarantia
        {
            get { return  tipomovgarantia; }
            set {  tipomovgarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPONOTAFISCALBRINDE
        /// Comentário: Indica se os itens da nota e brinde.
        /// </summary>
        private string tiponotafiscalbrinde;
        [XmlElement(ElementName = "TIPONOTAFISCALBRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiponotafiscalbrinde
        {
            get { return  tiponotafiscalbrinde; }
            set {  tiponotafiscalbrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPREENT
        /// Comentário: 
        /// </summary>
        private string tipopreent;
        [XmlElement(ElementName = "TIPOPREENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopreent
        {
            get { return  tipopreent; }
            set {  tipopreent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRIBENTIMP
        /// Comentário: Tipo de tributação na entrada de importação
        /// </summary>
        private string tipotribentimp;
        [XmlElement(ElementName = "TIPOTRIBENTIMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotribentimp
        {
            get { return  tipotribentimp; }
            set {  tipotribentimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALPESOLIQDI
        /// Comentário: Peso líquido total da DI
        /// </summary>
        private decimal totalpesoliqdi;
        [XmlElement(ElementName = "TOTALPESOLIQDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Totalpesoliqdi
        {
            get { return  totalpesoliqdi; }
            set {  totalpesoliqdi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESO
        /// Comentário: 
        /// </summary>
        private decimal totpeso;
        [XmlElement(ElementName = "TOTPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totpeso
        {
            get { return  totpeso; }
            set {  totpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESOLIQ
        /// Comentário: Total do peso líquido da nota fiscal.
        /// </summary>
        private decimal totpesoliq;
        [XmlElement(ElementName = "TOTPESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totpesoliq
        {
            get { return  totpesoliq; }
            set {  totpesoliq = value; }
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
        /// Propriedade referente ao campo: UFCODIGO
        /// Comentário: Código da UF.
        /// </summary>
        private string ufcodigo;
        [XmlElement(ElementName = "UFCODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufcodigo
        {
            get { return  ufcodigo; }
            set {  ufcodigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDESEMBARACO
        /// Comentário: Indica o local desembaraço.
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
        /// Propriedade referente ao campo: UFFILIAL
        /// Comentário: UF da filial.
        /// </summary>
        private string uffilial;
        [XmlElement(ElementName = "UFFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uffilial
        {
            get { return  uffilial; }
            set {  uffilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACREDPISCOFINSENTBONIFIC
        /// Comentário: Utiliza crédito PIS/COFINS na entrada bonificada
        /// </summary>
        private string usacredpiscofinsentbonific;
        [XmlElement(ElementName = "USACREDPISCOFINSENTBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacredpiscofinsentbonific
        {
            get { return  usacredpiscofinsentbonific; }
            set {  usacredpiscofinsentbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADRAWBACK
        /// Comentário: PIS/COFINS DrawBack
        /// </summary>
        private string usadrawback;
        [XmlElement(ElementName = "USADRAWBACK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadrawback
        {
            get { return  usadrawback; }
            set {  usadrawback = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAINTEGRACAOWMS
        /// Comentário: 
        /// </summary>
        private string usaintegracaowms;
        [XmlElement(ElementName = "USAINTEGRACAOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaintegracaowms
        {
            get { return  usaintegracaowms; }
            set {  usaintegracaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAOUTRASDESPSEGUROPISCOFINS
        /// Comentário: Somar outras despesas e seguros na base PIS/COFINS
        /// </summary>
        private string usaoutrasdespseguropiscofins;
        [XmlElement(ElementName = "USAOUTRASDESPSEGUROPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaoutrasdespseguropiscofins
        {
            get { return  usaoutrasdespseguropiscofins; }
            set {  usaoutrasdespseguropiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCICMSNAALIQEXTST
        /// Comentário: Considera frete FOB para o calculo do ICMS antecipado.
        /// </summary>
        private string usapercicmsnaaliqextst;
        [XmlElement(ElementName = "USAPERCICMSNAALIQEXTST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercicmsnaaliqextst
        {
            get { return  usapercicmsnaaliqextst; }
            set {  usapercicmsnaaliqextst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZADESCCALCICMS
        /// Comentário: 
        /// </summary>
        private string utilizadesccalcicms;
        [XmlElement(ElementName = "UTILIZADESCCALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadesccalcicms
        {
            get { return  utilizadesccalcicms; }
            set {  utilizadesccalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZADESCCALCST
        /// Comentário: 
        /// </summary>
        private string utilizadesccalcst;
        [XmlElement(ElementName = "UTILIZADESCCALCST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadesccalcst
        {
            get { return  utilizadesccalcst; }
            set {  utilizadesccalcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAFRETECALCICMS
        /// Comentário: 
        /// </summary>
        private string utilizafretecalcicms;
        [XmlElement(ElementName = "UTILIZAFRETECALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizafretecalcicms
        {
            get { return  utilizafretecalcicms; }
            set {  utilizafretecalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAIPICALCICMS
        /// Comentário: Utiliza IPI no calculo de ICMS
        /// </summary>
        private string utilizaipicalcicms;
        [XmlElement(ElementName = "UTILIZAIPICALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaipicalcicms
        {
            get { return  utilizaipicalcicms; }
            set {  utilizaipicalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTDESPCALCSUFRAMA
        /// Comentário: Utiliza outras despesa para calculo do desconto SUFRAMA.
        /// </summary>
        private string utilizaoutdespcalcsuframa;
        [XmlElement(ElementName = "UTILIZAOUTDESPCALCSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutdespcalcsuframa
        {
            get { return  utilizaoutdespcalcsuframa; }
            set {  utilizaoutdespcalcsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTDESPNFBASEST
        /// Comentário: Considerar o valor Outras Despesas NF + Seguro na base de calculo ST
        /// </summary>
        private string utilizaoutdespnfbasest;
        [XmlElement(ElementName = "UTILIZAOUTDESPNFBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutdespnfbasest
        {
            get { return  utilizaoutdespnfbasest; }
            set {  utilizaoutdespnfbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTRASDESPCALCICMS
        /// Comentário: 
        /// </summary>
        private string utilizaoutrasdespcalcicms;
        [XmlElement(ElementName = "UTILIZAOUTRASDESPCALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutrasdespcalcicms
        {
            get { return  utilizaoutrasdespcalcicms; }
            set {  utilizaoutrasdespcalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTRASDESPCALCIPI
        /// Comentário: 
        /// </summary>
        private string utilizaoutrasdespcalcipi;
        [XmlElement(ElementName = "UTILIZAOUTRASDESPCALCIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutrasdespcalcipi
        {
            get { return  utilizaoutrasdespcalcipi; }
            set {  utilizaoutrasdespcalcipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADUANEIRA
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLBASE
        /// Comentário: 
        /// </summary>
        private decimal vlbase;
        [XmlElement(ElementName = "VLBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbase
        {
            get { return  vlbase; }
            set {  vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPI
        /// Comentário: 
        /// </summary>
        private decimal vlbaseipi;
        [XmlElement(ElementName = "VLBASEIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlbaseipi
        {
            get { return  vlbaseipi; }
            set {  vlbaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Comentário: Valor do COFINS na Nota Fiscal.
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
        /// Propriedade referente ao campo: VLCREDCOFINS
        /// Comentário: Indica o valor total de crédito de COFINS na NF.
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
        /// Propriedade referente ao campo: VLCREDPIS
        /// Comentário: Indica o valor total de crédito de PIS na NF.
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
        /// Propriedade referente ao campo: VLDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal vldescfin;
        [XmlElement(ElementName = "VLDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldescfin
        {
            get { return  vldescfin; }
            set {  vldescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPACESSORIO
        /// Comentário: 
        /// </summary>
        private decimal vldespacessorio;
        [XmlElement(ElementName = "VLDESPACESSORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldespacessorio
        {
            get { return  vldespacessorio; }
            set {  vldespacessorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPDENTRONF
        /// Comentário: Indica o Valor outras despesas na NF.
        /// </summary>
        private decimal vldespdentronf;
        [XmlElement(ElementName = "VLDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldespdentronf
        {
            get { return  vldespdentronf; }
            set {  vldespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPFINANCEIRA
        /// Comentário: 
        /// </summary>
        private decimal vldespfinanceira;
        [XmlElement(ElementName = "VLDESPFINANCEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldespfinanceira
        {
            get { return  vldespfinanceira; }
            set {  vldespfinanceira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLICMS
        /// Comentário: 
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSANTECIPADO
        /// Comentário: 
        /// </summary>
        private decimal vlicmsantecipado;
        [XmlElement(ElementName = "VLICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicmsantecipado
        {
            get { return  vlicmsantecipado; }
            set {  vlicmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: 
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISENTAS
        /// Comentário: 
        /// </summary>
        private decimal vlisentas;
        [XmlElement(ElementName = "VLISENTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlisentas
        {
            get { return  vlisentas; }
            set {  vlisentas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEXIVA
        /// Comentário: Valor do IVA
        /// </summary>
        private decimal vlmexiva;
        [XmlElement(ElementName = "VLMEXIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmexiva
        {
            get { return  vlmexiva; }
            set {  vlmexiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRAS
        /// Comentário: 
        /// </summary>
        private decimal vloutras;
        [XmlElement(ElementName = "VLOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vloutras
        {
            get { return  vloutras; }
            set {  vloutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESPIMP
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLOUTROSDESP
        /// Comentário: 
        /// </summary>
        private decimal vloutrosdesp;
        [XmlElement(ElementName = "VLOUTROSDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vloutrosdesp
        {
            get { return  vloutrosdesp; }
            set {  vloutrosdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Comentário: Valor do PIS na Nota Fiscal.
        /// </summary>
        private decimal vlpis;
        [XmlElement(ElementName = "VLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpis
        {
            get { return  vlpis; }
            set {  vlpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Comentário: Indica o valor do seguro.
        /// </summary>
        private decimal vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSISCOMEX
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLST
        /// Comentário: 
        /// </summary>
        private decimal vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlst
        {
            get { return  vlst; }
            set {  vlst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALBASEICMS
        /// Comentário: Indica o valor total da base de ICMS.
        /// </summary>
        private decimal vltotalbaseicms;
        [XmlElement(ElementName = "VLTOTALBASEICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalbaseicms
        {
            get { return  vltotalbaseicms; }
            set {  vltotalbaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALBASEIPI
        /// Comentário: Vlr.Total da base IPI - Conferência.
        /// </summary>
        private decimal vltotalbaseipi;
        [XmlElement(ElementName = "VLTOTALBASEIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotalbaseipi
        {
            get { return  vltotalbaseipi; }
            set {  vltotalbaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALBASESTNF
        /// Comentário: Vlr total da base st NF - Conferência.
        /// </summary>
        private decimal vltotalbasestnf;
        [XmlElement(ElementName = "VLTOTALBASESTNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotalbasestnf
        {
            get { return  vltotalbasestnf; }
            set {  vltotalbasestnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal vltotaldesconto;
        [XmlElement(ElementName = "VLTOTALDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotaldesconto
        {
            get { return  vltotaldesconto; }
            set {  vltotaldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALFRETECIF
        /// Comentário: 
        /// </summary>
        private decimal vltotalfretecif;
        [XmlElement(ElementName = "VLTOTALFRETECIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalfretecif
        {
            get { return  vltotalfretecif; }
            set {  vltotalfretecif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALFRETEFOB
        /// Comentário: 
        /// </summary>
        private decimal vltotalfretefob;
        [XmlElement(ElementName = "VLTOTALFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalfretefob
        {
            get { return  vltotalfretefob; }
            set {  vltotalfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALICMS
        /// Comentário: 
        /// </summary>
        private decimal vltotalicms;
        [XmlElement(ElementName = "VLTOTALICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalicms
        {
            get { return  vltotalicms; }
            set {  vltotalicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALIPI
        /// Comentário: 
        /// </summary>
        private decimal vltotalipi;
        [XmlElement(ElementName = "VLTOTALIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalipi
        {
            get { return  vltotalipi; }
            set {  vltotalipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALITENS
        /// Comentário: 
        /// </summary>
        private decimal vltotalitens;
        [XmlElement(ElementName = "VLTOTALITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalitens
        {
            get { return  vltotalitens; }
            set {  vltotalitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALNOTA
        /// Comentário: 
        /// </summary>
        private decimal vltotalnota;
        [XmlElement(ElementName = "VLTOTALNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalnota
        {
            get { return  vltotalnota; }
            set {  vltotalnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALSTFORANF
        /// Comentário: 
        /// </summary>
        private decimal vltotalstforanf;
        [XmlElement(ElementName = "VLTOTALSTFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalstforanf
        {
            get { return  vltotalstforanf; }
            set {  vltotalstforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALSTNF
        /// Comentário: 
        /// </summary>
        private decimal vltotalstnf;
        [XmlElement(ElementName = "VLTOTALSTNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalstnf
        {
            get { return  vltotalstnf; }
            set {  vltotalstnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTGER
        /// Comentário: 
        /// </summary>
        private decimal vltotger;
        [XmlElement(ElementName = "VLTOTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotger
        {
            get { return  vltotger; }
            set {  vltotger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMV
        /// Comentário: 
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
        /// Comentário: Indica o valor total da verba CMV registrado na nota fiscal de saída.
        /// </summary>
        private decimal vlverbacmvcli;
        [XmlElement(ElementName = "VLVERBACMVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlverbacmvcli
        {
            get { return  vlverbacmvcli; }
            set {  vlverbacmvcli = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNfentpreent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFENTPREENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNfentpreent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfentpreent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNfentpreent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfentpreent>(where);
        }

        #endregion
    }
}
