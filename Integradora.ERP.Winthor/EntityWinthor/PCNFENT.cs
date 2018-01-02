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
    /// Classe referente a tabela PCNfent
    /// </summary>
    [XmlType("PCNFENT")]
    public class PCNfent : OracleTable
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
        /// Propriedade referente ao campo: AGREGASTVLMERC
        /// Comentário: Agregar valor de ST ao valor da mercadoria.
        /// </summary>
        private string agregastvlmerc;
        [XmlElement(ElementName = "AGREGASTVLMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregastvlmerc
        {
            get { return  agregastvlmerc; }
            set {  agregastvlmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMOUTRASDESP
        /// Comentário: Indica a aliquota do ICMS das despesas.
        /// </summary>
        private decimal? aliqicmoutrasdesp;
        [XmlElement(ElementName = "ALIQICMOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Aliqicmoutrasdesp
        {
            get { return  aliqicmoutrasdesp; }
            set {  aliqicmoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTA
        /// Comentário: 
        /// </summary>
        private decimal? aliquota;
        [XmlElement(ElementName = "ALIQUOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Aliquota
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
        /// Propriedade referente ao campo: AMBIENTE
        /// Comentário: Indica o ambiente em que foi enviada a nota.
        /// </summary>
        private string ambiente;
        [XmlElement(ElementName = "AMBIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambiente
        {
            get { return  ambiente; }
            set {  ambiente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTENFE
        /// Comentário: Ambiente nfe.
        /// </summary>
        private string ambientenfe;
        [XmlElement(ElementName = "AMBIENTENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambientenfe
        {
            get { return  ambientenfe; }
            set {  ambientenfe = value; }
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
        private decimal? baseicst;
        [XmlElement(ElementName = "BASEICST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Baseicst
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
        /// Propriedade referente ao campo: CHAVECTE
        /// Comentário: Chave CTE
        /// </summary>
        private string chavecte;
        [XmlElement(ElementName = "CHAVECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Chavecte
        {
            get { return  chavecte; }
            set {  chavecte = value; }
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
        /// Propriedade referente ao campo: CODCONT
        /// Comentário: 
        /// </summary>
        private decimal? codcont;
        [XmlElement(ElementName = "CODCONT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal? Codcont
        {
            get { return  codcont; }
            set {  codcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTABFORNEC
        /// Comentário: Indica o código contabil.
        /// </summary>
        private decimal? codcontabfornec;
        [XmlElement(ElementName = "CODCONTABFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Codcontabfornec
        {
            get { return  codcontabfornec; }
            set {  codcontabfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTFOR
        /// Comentário: Cod.Conta para fornecedor.
        /// </summary>
        private decimal? codcontfor;
        [XmlElement(ElementName = "CODCONTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codcontfor
        {
            get { return  codcontfor; }
            set {  codcontfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTFRE
        /// Comentário: Cod.Conta para frete.
        /// </summary>
        private decimal? codcontfre;
        [XmlElement(ElementName = "CODCONTFRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codcontfre
        {
            get { return  codcontfre; }
            set {  codcontfre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEVOL
        /// Comentário: 
        /// </summary>
        private decimal? coddevol;
        [XmlElement(ElementName = "CODDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Coddevol
        {
            get { return  coddevol; }
            set {  coddevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENTVEICULO
        /// Comentário: Código de entrada do veículo. 
        /// </summary>
        private decimal? codentveiculo;
        [XmlElement(ElementName = "CODENTVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codentveiculo
        {
            get { return  codentveiculo; }
            set {  codentveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEXPORTADOR
        /// Comentário: 
        /// </summary>
        private decimal? codexportador;
        [XmlElement(ElementName = "CODEXPORTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codexportador
        {
            get { return  codexportador; }
            set {  codexportador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        private decimal? codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal? Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETE
        /// Comentário: Indica o CFOP do frete.
        /// </summary>
        private decimal? codfiscalfrete;
        [XmlElement(ElementName = "CODFISCALFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codfiscalfrete
        {
            get { return  codfiscalfrete; }
            set {  codfiscalfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOUTRASDESP
        /// Comentário: Indica o CFOP das despesas.
        /// </summary>
        private decimal? codfiscaloutrasdesp;
        [XmlElement(ElementName = "CODFISCALOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codfiscaloutrasdesp
        {
            get { return  codfiscaloutrasdesp; }
            set {  codfiscaloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORFILIAL
        /// Comentário: Cód. Fornecedor para a filial.
        /// </summary>
        private decimal? codforfilial;
        [XmlElement(ElementName = "CODFORFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codforfilial
        {
            get { return  codforfilial; }
            set {  codforfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal? codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal? Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Comentário: Indica o código da transportadora.
        /// </summary>
        private decimal? codfornecfrete;
        [XmlElement(ElementName = "CODFORNECFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfornecfrete
        {
            get { return  codfornecfrete; }
            set {  codfornecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECNF
        /// Comentário: Indica o código do fornecedor da NF.
        /// </summary>
        private decimal? codfornecnf;
        [XmlElement(ElementName = "CODFORNECNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codfornecnf
        {
            get { return  codfornecnf; }
            set {  codfornecnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCENVIO
        /// Comentário: Campo para indicar código do funcionário que exportou arquivos para a Integração MWS. |Campo do tipo numérico, de tamanho 8, sem casas decimais. 
        /// </summary>
        private decimal? codfuncenvio;
        [XmlElement(ElementName = "CODFUNCENVIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncenvio
        {
            get { return  codfuncenvio; }
            set {  codfuncenvio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCENVIOWMS
        /// Comentário: Campo para indicar código do funcionário que exportou arquivos para a Integração MWS. 
        /// </summary>
        private decimal? codfuncenviowms;
        [XmlElement(ElementName = "CODFUNCENVIOWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncenviowms
        {
            get { return  codfuncenviowms; }
            set {  codfuncenviowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXPARQOL
        /// Comentário: 
        /// </summary>
        private decimal? codfuncexparqol;
        [XmlElement(ElementName = "CODFUNCEXPARQOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncexparqol
        {
            get { return  codfuncexparqol; }
            set {  codfuncexparqol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXPINTWMS
        /// Comentário: Campo para indicar código do funcionário que exportou arquivos para a Integração MWS. |Campo do tipo numérico, de tamanho 8, sem casas decimais. 
        /// </summary>
        private decimal? codfuncexpintwms;
        [XmlElement(ElementName = "CODFUNCEXPINTWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncexpintwms
        {
            get { return  codfuncexpintwms; }
            set {  codfuncexpintwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: 
        /// </summary>
        private decimal? codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIBGE
        /// Comentário: Indica o código IBGE.
        /// </summary>
        private decimal? codibge;
        [XmlElement(ElementName = "CODIBGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codibge
        {
            get { return  codibge; }
            set {  codibge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOCLASSECONSUMOENERGIA
        /// Comentário: Código da Classe de Consumo de Energia.
        /// </summary>
        private string codigoclasseconsumoenergia;
        [XmlElement(ElementName = "CODIGOCLASSECONSUMOENERGIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codigoclasseconsumoenergia
        {
            get { return  codigoclasseconsumoenergia; }
            set {  codigoclasseconsumoenergia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOGRUPOTENSAOENERGIA
        /// Comentário: Código do Grupo de Tensão de Energia.
        /// </summary>
        private string codigogrupotensaoenergia;
        [XmlElement(ElementName = "CODIGOGRUPOTENSAOENERGIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codigogrupotensaoenergia
        {
            get { return  codigogrupotensaoenergia; }
            set {  codigogrupotensaoenergia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTADEVOL
        /// Comentário: 
        /// </summary>
        private decimal? codmotoristadevol;
        [XmlElement(ElementName = "CODMOTORISTADEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codmotoristadevol
        {
            get { return  codmotoristadevol; }
            set {  codmotoristadevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNICIPIO
        /// Comentário: Indica o código municipio.
        /// </summary>
        private decimal? codmunicipio;
        [XmlElement(ElementName = "CODMUNICIPIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codmunicipio
        {
            get { return  codmunicipio; }
            set {  codmunicipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Comentário: Código do País.
        /// </summary>
        private decimal? codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODNFAJUSTE
        /// Comentário: Código de produto para NF-e de ajuste
        /// </summary>
        private string codprodnfajuste;
        [XmlElement(ElementName = "CODPRODNFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Codprodnfajuste
        {
            get { return  codprodnfajuste; }
            set {  codprodnfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Comentário: Indica o código do profissional que a mencadoria esta sendo entregue.
        /// </summary>
        private decimal? codprofissional;
        [XmlElement(ElementName = "CODPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprofissional
        {
            get { return  codprofissional; }
            set {  codprofissional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROJETO
        /// Comentário: Código do Projeto. Cadastrado na 607 e usado na 631,749 e 3402.
        /// </summary>
        private decimal? codprojeto;
        [XmlElement(ElementName = "CODPROJETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprojeto
        {
            get { return  codprojeto; }
            set {  codprojeto = value; }
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
        private decimal? codrotinadesbloqueio;
        [XmlElement(ElementName = "CODROTINADESBLOQUEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codrotinadesbloqueio
        {
            get { return  codrotinadesbloqueio; }
            set {  codrotinadesbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Comentário: Código da Situação Tributária do PIS/COFINS.
        /// </summary>
        private decimal? codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURDEVOL
        /// Comentário: 
        /// </summary>
        private decimal? codusurdevol;
        [XmlElement(ElementName = "CODUSURDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codusurdevol
        {
            get { return  codusurdevol; }
            set {  codusurdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVIA
        /// Comentário: Código da via de transporte
        /// </summary>
        private decimal? codvia;
        [XmlElement(ElementName = "CODVIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codvia
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
        /// Propriedade referente ao campo: CONFERIDO
        /// Comentário: Nota Fiscal Conferida.
        /// </summary>
        private string conferido;
        [XmlElement(ElementName = "CONFERIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferido
        {
            get { return  conferido; }
            set {  conferido = value; }
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
        /// Comentário: Se já tem um número de Nfe para o registro.
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
        /// Propriedade referente ao campo: DESCRICAOPRODNFAJUSTE
        /// Comentário: Descrição do produto paa NF ajuste
        /// </summary>
        private string descricaoprodnfajuste;
        [XmlElement(ElementName = "DESCRICAOPRODNFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,120)]
        public string Descricaoprodnfajuste
        {
            get { return  descricaoprodnfajuste; }
            set {  descricaoprodnfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESPESASRATEADA
        /// Comentário: Informar se o frete e outras despesas foram rateados nos itens
        /// </summary>
        private string despesasrateada;
        [XmlElement(ElementName = "DESPESASRATEADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Despesasrateada
        {
            get { return  despesasrateada; }
            set {  despesasrateada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEVSIMBOLICA
        /// Comentário: Devolução simbólica
        /// </summary>
        private string devsimbolica;
        [XmlElement(ElementName = "DEVSIMBOLICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Devsimbolica
        {
            get { return  devsimbolica; }
            set {  devsimbolica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAHORAENTRADACONTIGENCIA
        /// Comentário: Data e Hora da entrada de contigência.
        /// </summary>
        private DateTime? dtahoraentradacontigencia;
        [XmlElement(ElementName = "DTAHORAENTRADACONTIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtahoraentradacontigencia
        {
            get { return  dtahoraentradacontigencia; }
            set {  dtahoraentradacontigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTA_HORAENVIOSEFAZ
        /// Comentário: Data e hora do envio do cte ao sefaz.
        /// </summary>
        private DateTime? dta_horaenviosefaz;
        [XmlElement(ElementName = "DTA_HORAENVIOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dta_Horaenviosefaz
        {
            get { return  dta_horaenviosefaz; }
            set {  dta_horaenviosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data de Cancelamento
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
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAODECLARACAO
        /// Comentário: Data de emissão da declaração emitida pelo tomador do Ct-e, quando este não for contribuinte
        /// </summary>
        private DateTime? dtemissaodeclaracao;
        [XmlElement(ElementName = "DTEMISSAODECLARACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaodeclaracao
        {
            get { return  dtemissaodeclaracao; }
            set {  dtemissaodeclaracao = value; }
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
        [XmlElement(ElementName = "DTENT", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
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
        /// Propriedade referente ao campo: DTEXPORTACAOWMS
        /// Comentário: Data  e hora de exportação
        /// </summary>
        private DateTime? dtexportacaowms;
        [XmlElement(ElementName = "DTEXPORTACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaowms
        {
            get { return  dtexportacaowms; }
            set {  dtexportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORAAUTORIZACAOSEFAZ
        /// Comentário: Indica a hora que foi autorizado no sefaz.
        /// </summary>
        private DateTime? dthoraautorizacaosefaz;
        [XmlElement(ElementName = "DTHORAAUTORIZACAOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoraautorizacaosefaz
        {
            get { return  dthoraautorizacaosefaz; }
            set {  dthoraautorizacaosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORACANCELAMENTOSEFAZ
        /// Comentário: Indica a data e hora em que foi cancelada no sefaz.
        /// </summary>
        private DateTime? dthoracancelamentosefaz;
        [XmlElement(ElementName = "DTHORACANCELAMENTOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoracancelamentosefaz
        {
            get { return  dthoracancelamentosefaz; }
            set {  dthoracancelamentosefaz = value; }
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
        /// Propriedade referente ao campo: DTHORARECIBODPEC
        /// Comentário: Data e hora do recibo DPEC.
        /// </summary>
        private DateTime? dthorarecibodpec;
        [XmlElement(ElementName = "DTHORARECIBODPEC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthorarecibodpec
        {
            get { return  dthorarecibodpec; }
            set {  dthorarecibodpec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOWMS
        /// Comentário: Data  e hora de importação
        /// </summary>
        private DateTime? dtimportacaowms;
        [XmlElement(ElementName = "DTIMPORTACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaowms
        {
            get { return  dtimportacaowms; }
            set {  dtimportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANCTO
        /// Comentário: Indica a data da inclusão do lançamento.
        /// </summary>
        private DateTime? dtlancto;
        [XmlElement(ElementName = "DTLANCTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlancto
        {
            get { return  dtlancto; }
            set {  dtlancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNSU
        /// Comentário: Data e hora de geração do NSU, que deve ser impresso em todas as notas fiscais (entrada e saída). 
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
        /// Propriedade referente ao campo: DTVENCSTGUIA
        /// Comentário: Data vencimento ST GUIA
        /// </summary>
        private DateTime? dtvencstguia;
        [XmlElement(ElementName = "DTVENCSTGUIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencstguia
        {
            get { return  dtvencstguia; }
            set {  dtvencstguia = value; }
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
        /// Propriedade referente ao campo: EMAILDEST
        /// Comentário: E-mail do destinatário
        /// </summary>
        private string emaildest;
        [XmlElement(ElementName = "EMAILDEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Emaildest
        {
            get { return  emaildest; }
            set {  emaildest = value; }
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
        /// Propriedade referente ao campo: ENVIADOEMAILCANCELADO
        /// Comentário: ENVIADO EMAIL CANCELADO
        /// </summary>
        private string enviadoemailcancelado;
        [XmlElement(ElementName = "ENVIADOEMAILCANCELADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadoemailcancelado
        {
            get { return  enviadoemailcancelado; }
            set {  enviadoemailcancelado = value; }
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
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
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
        /// Propriedade referente ao campo: EXPORTADO
        /// Comentário: Marcação se o registro foi exportado
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
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
        /// Propriedade referente ao campo: FOLHALIVRO_ENTRADA
        /// Comentário: Folha do livro de entrada do registro da nota.
        /// </summary>
        private decimal? folhalivro_entrada;
        [XmlElement(ElementName = "FOLHALIVRO_ENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Folhalivro_Entrada
        {
            get { return  folhalivro_entrada; }
            set {  folhalivro_entrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORNECEDOR
        /// Comentário: Razão social do fornecedor.
        /// </summary>
        private string fornecedor;
        [XmlElement(ElementName = "FORNECEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
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
        /// Propriedade referente ao campo: GERARBCRNFE
        /// Comentário: Gerar ICMS ST BCR
        /// </summary>
        private string gerarbcrnfe;
        [XmlElement(ElementName = "GERARBCRNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarbcrnfe
        {
            get { return  gerarbcrnfe; }
            set {  gerarbcrnfe = value; }
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
        /// Propriedade referente ao campo: IDTIPOPRESENCA
        /// Comentário: Identificação do tipo de presença
        /// </summary>
        private string idtipopresenca;
        [XmlElement(ElementName = "IDTIPOPRESENCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Idtipopresenca
        {
            get { return  idtipopresenca; }
            set {  idtipopresenca = value; }
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
        /// Comentário: Informa se a entrada é importada de xml
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
        /// Propriedade referente ao campo: JUSTIFICATIVACONTIGENCIA
        /// Comentário: Motivo da entrada de contigência.
        /// </summary>
        private string justificativacontigencia;
        [XmlElement(ElementName = "JUSTIFICATIVACONTIGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,256)]
        public string Justificativacontigencia
        {
            get { return  justificativacontigencia; }
            set {  justificativacontigencia = value; }
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
        /// Propriedade referente ao campo: LOTEDPEC
        /// Comentário: Indica o número do lote dpec.
        /// </summary>
        private string lotedpec;
        [XmlElement(ElementName = "LOTEDPEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Lotedpec
        {
            get { return  lotedpec; }
            set {  lotedpec = value; }
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
        /// Propriedade referente ao campo: MOTESTORNONFE
        /// Comentário: Observação do motivo da geração da NF-e de estorno.
        /// </summary>
        private string motestornonfe;
        [XmlElement(ElementName = "MOTESTORNONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Motestornonfe
        {
            get { return  motestornonfe; }
            set {  motestornonfe = value; }
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
        [DataObjectField(false,false,true,30)]
        public string Municipio
        {
            get { return  municipio; }
            set {  municipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATOPERNFE
        /// Comentário: Natureza de operação da NF-e do estorno.
        /// </summary>
        private string natopernfe;
        [XmlElement(ElementName = "NATOPERNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Natopernfe
        {
            get { return  natopernfe; }
            set {  natopernfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NCMNFAJUSTE
        /// Comentário: NCM para item de NF de ajuste
        /// </summary>
        private string ncmnfajuste;
        [XmlElement(ElementName = "NCMNFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Ncmnfajuste
        {
            get { return  ncmnfajuste; }
            set {  ncmnfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NFEEMIAVUSEF
        /// Comentário: Nfe de Emissão Avulsa SEFAZ
        /// </summary>
        private string nfeemiavusef;
        [XmlElement(ElementName = "NFEEMIAVUSEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Nfeemiavusef
        {
            get { return  nfeemiavusef; }
            set {  nfeemiavusef = value; }
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
        /// Propriedade referente ao campo: NFEXTEMPORANEA
        /// Comentário: Informar se a nota fiscal é extemporanea ou não
        /// </summary>
        private string nfextemporanea;
        [XmlElement(ElementName = "NFEXTEMPORANEA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Nfextemporanea
        {
            get { return  nfextemporanea; }
            set {  nfextemporanea = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMESEGURADORA
        /// Comentário: Nome da Seguradora.
        /// </summary>
        private string nomeseguradora;
        [XmlElement(ElementName = "NOMESEGURADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomeseguradora
        {
            get { return  nomeseguradora; }
            set {  nomeseguradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NORMAREGESPECIAL
        /// Comentário: Norma Especifica (Regime Especial)
        /// </summary>
        private string normaregespecial;
        [XmlElement(ElementName = "NORMAREGESPECIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Normaregespecial
        {
            get { return  normaregespecial; }
            set {  normaregespecial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Comentário: NSU (número sequencial único) que deve ser gerado e impresso em todas as notas fiscais (entrada e saída). Esta informação é referente a legislação de Santa Catarina. 
        /// </summary>
        private decimal? nsu;
        [XmlElement(ElementName = "NSU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAPLIC
        /// Comentário: 
        /// </summary>
        private decimal? numaplic;
        [XmlElement(ElementName = "NUMAPLIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numaplic
        {
            get { return  numaplic; }
            set {  numaplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal? numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATO
        /// Comentário: NÚmero do contrato de comodato
        /// </summary>
        private decimal? numcontrato;
        [XmlElement(ElementName = "NUMCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numcontrato
        {
            get { return  numcontrato; }
            set {  numcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIIMPORTACAO
        /// Comentário: Campo utilizado para armazenar o número do documento de importação.
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
        /// Comentário: Campo de sequencia fiscal voltada para entradas de mercadoria no México.
        /// </summary>
        private decimal? numentmex;
        [XmlElement(ElementName = "NUMENTMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numentmex
        {
            get { return  numentmex; }
            set {  numentmex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROAPOLICE
        /// Comentário: Número da Apolice do Seguro
        /// </summary>
        private string numeroapolice;
        [XmlElement(ElementName = "NUMEROAPOLICE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numeroapolice
        {
            get { return  numeroapolice; }
            set {  numeroapolice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROAVERBACAO
        /// Comentário: Número da Averbação do Seguro.
        /// </summary>
        private string numeroaverbacao;
        [XmlElement(ElementName = "NUMEROAVERBACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numeroaverbacao
        {
            get { return  numeroaverbacao; }
            set {  numeroaverbacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROEND
        /// Comentário: Número do Logradouro do Fornecedor.
        /// </summary>
        private string numeroend;
        [XmlElement(ElementName = "NUMEROEND", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numeroend
        {
            get { return  numeroend; }
            set {  numeroend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMULARIO
        /// Comentário: 
        /// </summary>
        private decimal? numformulario;
        [XmlElement(ElementName = "NUMFORMULARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numformulario
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
        /// Propriedade referente ao campo: NUMLIVRO_ENTRADA
        /// Comentário: Número do livro de entrada do registro da nota.
        /// </summary>
        private string numlivro_entrada;
        [XmlElement(ElementName = "NUMLIVRO_ENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numlivro_Entrada
        {
            get { return  numlivro_entrada; }
            set {  numlivro_entrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTECTE
        /// Comentário: Número do lote do Cte
        /// </summary>
        private string numlotecte;
        [XmlElement(ElementName = "NUMLOTECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlotecte
        {
            get { return  numlotecte; }
            set {  numlotecte = value; }
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
        private decimal? numnegociacao;
        [XmlElement(ElementName = "NUMNEGOCIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numnegociacao
        {
            get { return  numnegociacao; }
            set {  numnegociacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal? numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal? Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAENTFUTURA
        /// Comentário: 
        /// </summary>
        private decimal? numnotaentfutura;
        [XmlElement(ElementName = "NUMNOTAENTFUTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numnotaentfutura
        {
            get { return  numnotaentfutura; }
            set {  numnotaentfutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAPRODRURAL
        /// Comentário: Numero da NF produtor rural
        /// </summary>
        private decimal? numnotaprodrural;
        [XmlElement(ElementName = "NUMNOTAPRODRURAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numnotaprodrural
        {
            get { return  numnotaprodrural; }
            set {  numnotaprodrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAVENDA
        /// Comentário: Indica o número da NF de venda.
        /// </summary>
        private decimal? numnotavenda;
        [XmlElement(ElementName = "NUMNOTAVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numnotavenda
        {
            get { return  numnotavenda; }
            set {  numnotavenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Comentário: Indica o numero da ordem de produção.
        /// </summary>
        private decimal? numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numop
        {
            get { return  numop; }
            set {  numop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Comentário: Campo para armazenar o número da ordem de serviço que gerou a NF.
        /// </summary>
        private decimal? numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPARCDEVOL
        /// Comentário: Indica a quantidade de parcelas da devolução.
        /// </summary>
        private decimal? numparcdevol;
        [XmlElement(ElementName = "NUMPARCDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numparcdevol
        {
            get { return  numparcdevol; }
            set {  numparcdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDPRINC
        /// Comentário: Número do pedido de compra principal
        /// </summary>
        private decimal? numpedprinc;
        [XmlElement(ElementName = "NUMPEDPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numpedprinc
        {
            get { return  numpedprinc; }
            set {  numpedprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSELONF
        /// Comentário: 
        /// </summary>
        private decimal? numselonf;
        [XmlElement(ElementName = "NUMSELONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numselonf
        {
            get { return  numselonf; }
            set {  numselonf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENVIO
        /// Comentário: Campo para gravar o número de seqüência dos arquivos enviado. 
        /// </summary>
        private decimal? numseqenvio;
        [XmlElement(ElementName = "NUMSEQENVIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numseqenvio
        {
            get { return  numseqenvio; }
            set {  numseqenvio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTAB
        /// Comentário: 
        /// </summary>
        private decimal? numtab;
        [XmlElement(ElementName = "NUMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numtab
        {
            get { return  numtab; }
            set {  numtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSBENEFIC
        /// Comentário: Indica número da transação de entrada de beneficiamento no registro da nota de devolução de remessa para beneficiamento. 
        /// </summary>
        private decimal? numtransbenefic;
        [XmlElement(ElementName = "NUMTRANSBENEFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransbenefic
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
        /// Propriedade referente ao campo: NUMTRANSINTEGRACAO
        /// Comentário: Número de transação de integração
        /// </summary>
        private string numtransintegracao;
        [XmlElement(ElementName = "NUMTRANSINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Numtransintegracao
        {
            get { return  numtransintegracao; }
            set {  numtransintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSORIGEM
        /// Comentário: 
        /// </summary>
        private decimal? numtransorigem;
        [XmlElement(ElementName = "NUMTRANSORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransorigem
        {
            get { return  numtransorigem; }
            set {  numtransorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAORIG
        /// Comentário: Indica a transação original de entrada consignação.
        /// </summary>
        private decimal? numtransvendaorig;
        [XmlElement(ElementName = "NUMTRANSVENDAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransvendaorig
        {
            get { return  numtransvendaorig; }
            set {  numtransvendaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDATROCA
        /// Comentário: Indica o numero da transação a qual ocorreu a troca.
        /// </summary>
        private decimal? numtransvendatroca;
        [XmlElement(ElementName = "NUMTRANSVENDATROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransvendatroca
        {
            get { return  numtransvendatroca; }
            set {  numtransvendatroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: Indica o numero de vias impressas.
        /// </summary>
        private decimal? numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOL
        /// Comentário: 
        /// </summary>
        private decimal? numvol;
        [XmlElement(ElementName = "NUMVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Numvol
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
        /// Propriedade referente ao campo: OBSAUTORIDEVOL
        /// Comentário: Observação de Autorização de Devolução.
        /// </summary>
        private string obsautoridevol;
        [XmlElement(ElementName = "OBSAUTORIDEVOL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obsautoridevol
        {
            get { return  obsautoridevol; }
            set {  obsautoridevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSLIVROFISCAL
        /// Comentário: Observação
        /// </summary>
        private string obslivrofiscal;
        [XmlElement(ElementName = "OBSLIVROFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obslivrofiscal
        {
            get { return  obslivrofiscal; }
            set {  obslivrofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSNFAJUSTE
        /// Comentário: Observação complementar para NF de ajuste
        /// </summary>
        private string obsnfajuste;
        [XmlElement(ElementName = "OBSNFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Obsnfajuste
        {
            get { return  obsnfajuste; }
            set {  obsnfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSNFE
        /// Comentário: Observações da NF-e.
        /// </summary>
        private string obsnfe;
        [XmlElement(ElementName = "OBSNFE", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Obsnfe
        {
            get { return  obsnfe; }
            set {  obsnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSPISCOFINS
        /// Comentário: Observação da tributação de PIS/COFINS
        /// </summary>
        private string obspiscofins;
        [XmlElement(ElementName = "OBSPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obspiscofins
        {
            get { return  obspiscofins; }
            set {  obspiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS1
        /// Comentário: Indica observação com relação ao recebimento de mercadoria.
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
        /// Comentário: Indica observação com relação ao recebimento de mercadoria.
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
        /// Propriedade referente ao campo: ORIGEMFRETE
        /// Comentário: Origem do percentual de Frete
        /// </summary>
        private string origemfrete;
        [XmlElement(ElementName = "ORIGEMFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemfrete
        {
            get { return  origemfrete; }
            set {  origemfrete = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDOUTRASDESP
        /// Comentário: Contém o percentual de redução para despesas acessórias (se houver).
        /// </summary>
        private decimal? perbaseredoutrasdesp;
        [XmlElement(ElementName = "PERBASEREDOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Perbaseredoutrasdesp
        {
            get { return  perbaseredoutrasdesp; }
            set {  perbaseredoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALTERCUSTOENT
        /// Comentário: Percentual para alterar o custo da mercadoria na entrada.
        /// </summary>
        private decimal? percaltercustoent;
        [XmlElement(ElementName = "PERCALTERCUSTOENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Percaltercustoent
        {
            get { return  percaltercustoent; }
            set {  percaltercustoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMFRETE
        /// Comentário: Indica a aliquota do ICMS frete.
        /// </summary>
        private decimal? percicmfrete;
        [XmlElement(ElementName = "PERCICMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Percicmfrete
        {
            get { return  percicmfrete; }
            set {  percicmfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBST
        /// Comentário: Idinca o percentual de icms frete fob a ser utilizado como crédito no calculo do ST fora da nf ou BCR.
        /// </summary>
        private decimal? percicmsfretefobst;
        [XmlElement(ElementName = "PERCICMSFRETEFOBST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percicmsfretefobst
        {
            get { return  percicmsfretefobst; }
            set {  percicmsfretefobst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Comentário: Alíquota do COFINS
        /// </summary>
        private decimal? percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPISRED
        /// Comentário: % Redução PIS.
        /// </summary>
        private decimal? percpisred;
        [XmlElement(ElementName = "PERCPISRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Percpisred
        {
            get { return  percpisred; }
            set {  percpisred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFIN
        /// Comentário: Mesmo campo gravado no pedido, que é replicado durante a devolução do cliente. 
        /// </summary>
        private decimal? perdescfin;
        [XmlElement(ElementName = "PERDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Perdescfin
        {
            get { return  perdescfin; }
            set {  perdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Comentário: Alíquota do PIS
        /// </summary>
        private decimal? perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOFRETEFOB
        /// Comentário: Indica o peso do frete FOB. 
        /// </summary>
        private decimal? pesofretefob;
        [XmlElement(ElementName = "PESOFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Pesofretefob
        {
            get { return  pesofretefob; }
            set {  pesofretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACAVEICULO
        /// Comentário: Placa do veículo
        /// </summary>
        private string placaveiculo;
        [XmlElement(ElementName = "PLACAVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Placaveiculo
        {
            get { return  placaveiculo; }
            set {  placaveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSSECODFORNEC
        /// Comentário: Código Fornecedor da empresa que está de posse da mercadoria.
        /// </summary>
        private decimal? possecodfornec;
        [XmlElement(ElementName = "POSSECODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Possecodfornec
        {
            get { return  possecodfornec; }
            set {  possecodfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO
        /// Comentário: Prazo medio
        /// </summary>
        private decimal? prazo;
        [XmlElement(ElementName = "PRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Prazo
        {
            get { return  prazo; }
            set {  prazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOCANCELAMENTO
        /// Comentário: Indica o número do protocolo de cancelamento.
        /// </summary>
        private string protocolocancelamento;
        [XmlElement(ElementName = "PROTOCOLOCANCELAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocolocancelamento
        {
            get { return  protocolocancelamento; }
            set {  protocolocancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOCTE
        /// Comentário: Protocolo Cte
        /// </summary>
        private string protocolocte;
        [XmlElement(ElementName = "PROTOCOLOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolocte
        {
            get { return  protocolocte; }
            set {  protocolocte = value; }
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
        /// Propriedade referente ao campo: RATEIOPESOLIQ
        /// Comentário: Informa que o rateio vai ser por peso líquido
        /// </summary>
        private string rateiopesoliq;
        [XmlElement(ElementName = "RATEIOPESOLIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rateiopesoliq
        {
            get { return  rateiopesoliq; }
            set {  rateiopesoliq = value; }
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
        /// Propriedade referente ao campo: RECIBOCTE
        /// Comentário: Recibo Cte
        /// </summary>
        private string recibocte;
        [XmlElement(ElementName = "RECIBOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibocte
        {
            get { return  recibocte; }
            set {  recibocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECIBODPEC
        /// Comentário: Indica o recibo de envio de lote dpec.
        /// </summary>
        private string recibodpec;
        [XmlElement(ElementName = "RECIBODPEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibodpec
        {
            get { return  recibodpec; }
            set {  recibodpec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECIBONFE
        /// Comentário: Indica o recibo de envio de lote.
        /// </summary>
        private string recibonfe;
        [XmlElement(ElementName = "RECIBONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibonfe
        {
            get { return  recibonfe; }
            set {  recibonfe = value; }
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
        /// Propriedade referente ao campo: RESPSEGURO
        /// Comentário: Responsável pelo seguro.
        /// </summary>
        private decimal? respseguro;
        [XmlElement(ElementName = "RESPSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal? Respseguro
        {
            get { return  respseguro; }
            set {  respseguro = value; }
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
        /// Comentário: Indica a serie.|Campo do tipo caracter, de tamanho 3. 
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
        /// Propriedade referente ao campo: SERIEORIGINAL
        /// Comentário: SERIE ORIGINAL DA NOTA FISCAL ELETRONICA
        /// </summary>
        private string serieoriginal;
        [XmlElement(ElementName = "SERIEORIGINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serieoriginal
        {
            get { return  serieoriginal; }
            set {  serieoriginal = value; }
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
        /// Comentário: Indica optante pelo simples nacional.
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
        /// Propriedade referente ao campo: SITDOCPISCOFINS
        /// Comentário: Situação do Documento do PIS/COFINS
        /// </summary>
        private string sitdocpiscofins;
        [XmlElement(ElementName = "SITDOCPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Sitdocpiscofins
        {
            get { return  sitdocpiscofins; }
            set {  sitdocpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOCTE
        /// Comentário: Situação Cte
        /// </summary>
        private decimal? situacaocte;
        [XmlElement(ElementName = "SITUACAOCTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Situacaocte
        {
            get { return  situacaocte; }
            set {  situacaocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAONFE
        /// Comentário: 
        /// </summary>
        private decimal? situacaonfe;
        [XmlElement(ElementName = "SITUACAONFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Situacaonfe
        {
            get { return  situacaonfe; }
            set {  situacaonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAONFEORIG
        /// Comentário: Situação NFe Original.
        /// </summary>
        private decimal? situacaonfeorig;
        [XmlElement(ElementName = "SITUACAONFEORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Situacaonfeorig
        {
            get { return  situacaonfeorig; }
            set {  situacaonfeorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMARPISCOFINSVLOUTRASDESPIMP
        /// Comentário: Incluir PIS/COFINS no valor de Outras Despesas DANFe Importação
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
        /// Comentário: Somar valor outras despesas e despesas aduaneiras no DANFE.
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
        /// Propriedade referente ao campo: TELEFONE
        /// Comentário: Telefone do destinatário
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOAPRO
        /// Comentário: 
        /// </summary>
        private decimal? tempoapro;
        [XmlElement(ElementName = "TEMPOAPRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Tempoapro
        {
            get { return  tempoapro; }
            set {  tempoapro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPODESCARGA
        /// Comentário: 
        /// </summary>
        private decimal? tempodescarga;
        [XmlElement(ElementName = "TEMPODESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Tempodescarga
        {
            get { return  tempodescarga; }
            set {  tempodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TENTATIVAENVIONFE
        /// Comentário: Indica a quantidade de tentativas de envio da nota fiscal a SEFAZ.
        /// </summary>
        private decimal? tentativaenvionfe;
        [XmlElement(ElementName = "TENTATIVAENVIONFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Tentativaenvionfe
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
        /// Propriedade referente ao campo: TIPOEMISSAOCTE
        /// Comentário: Tipo Emissão Ct-e
        /// </summary>
        private string tipoemissaocte;
        [XmlElement(ElementName = "TIPOEMISSAOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoemissaocte
        {
            get { return  tipoemissaocte; }
            set {  tipoemissaocte = value; }
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
        /// Propriedade referente ao campo: TIPOFRETECIFFOB
        /// Comentário: Tipo de frete (CIF/FOB).
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
        /// Propriedade referente ao campo: TIPOLIGACAOENERGIA
        /// Comentário: Tipo de Ligação de Energia.
        /// </summary>
        private string tipoligacaoenergia;
        [XmlElement(ElementName = "TIPOLIGACAOENERGIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoligacaoenergia
        {
            get { return  tipoligacaoenergia; }
            set {  tipoligacaoenergia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOVGARANTIA
        /// Comentário: Define qual tipo de movimentação de garantia a nota representa.
        /// </summary>
        private decimal? tipomovgarantia;
        [XmlElement(ElementName = "TIPOMOVGARANTIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Tipomovgarantia
        {
            get { return  tipomovgarantia; }
            set {  tipomovgarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPONOTAFISCALBRINDE
        /// Comentário: Campo que indica se os itens da nota é brinde.
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
        /// Propriedade referente ao campo: TIPOOPERCIAP
        /// Comentário: Tipo de operação referente documento fiscal do CIAP
        /// </summary>
        private string tipooperciap;
        [XmlElement(ElementName = "TIPOOPERCIAP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipooperciap
        {
            get { return  tipooperciap; }
            set {  tipooperciap = value; }
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
        private decimal? totalpesoliqdi;
        [XmlElement(ElementName = "TOTALPESOLIQDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Totalpesoliqdi
        {
            get { return  totalpesoliqdi; }
            set {  totalpesoliqdi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTDIFALIQUOTAS
        /// Comentário: Total do diferencial de alíquotas.
        /// </summary>
        private decimal? totdifaliquotas;
        [XmlElement(ElementName = "TOTDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Totdifaliquotas
        {
            get { return  totdifaliquotas; }
            set {  totdifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESO
        /// Comentário: 
        /// </summary>
        private decimal? totpeso;
        [XmlElement(ElementName = "TOTPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Totpeso
        {
            get { return  totpeso; }
            set {  totpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESOLIQ
        /// Comentário: Total do peso líquido dos proudtos  informados na nota fiscal.
        /// </summary>
        private decimal? totpesoliq;
        [XmlElement(ElementName = "TOTPESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Totpesoliq
        {
            get { return  totpesoliq; }
            set {  totpesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: UF do fornecedor.
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
        /// Propriedade referente ao campo: UFVEICULO
        /// Comentário: UF do veículo
        /// </summary>
        private string ufveiculo;
        [XmlElement(ElementName = "UFVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufveiculo
        {
            get { return  ufveiculo; }
            set {  ufveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADENFAJUSTE
        /// Comentário: Unidade de medida para NF de ajuste
        /// </summary>
        private string unidadenfajuste;
        [XmlElement(ElementName = "UNIDADENFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Unidadenfajuste
        {
            get { return  unidadenfajuste; }
            set {  unidadenfajuste = value; }
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
        /// Comentário: Usa regime DrawBack Suspensão
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
        /// Comentário: Usa integração WMS
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
        /// Propriedade referente ao campo: VERSAOROTINA
        /// Comentário: Versão da rotina gerarou os dados
        /// </summary>
        private string versaorotina;
        [XmlElement(ElementName = "VERSAOROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Versaorotina
        {
            get { return  versaorotina; }
            set {  versaorotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADUANEIRA
        /// Comentário: 
        /// </summary>
        private decimal? vladuaneira;
        [XmlElement(ElementName = "VLADUANEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vladuaneira
        {
            get { return  vladuaneira; }
            set {  vladuaneira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASE
        /// Comentário: 
        /// </summary>
        private decimal? vlbase;
        [XmlElement(ElementName = "VLBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlbase
        {
            get { return  vlbase; }
            set {  vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASECOFINS
        /// Comentário: Valor da Base do COFINS
        /// </summary>
        private decimal? vlbasecofins;
        [XmlElement(ElementName = "VLBASECOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlbasecofins
        {
            get { return  vlbasecofins; }
            set {  vlbasecofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPI
        /// Comentário: 
        /// </summary>
        private decimal? vlbaseipi;
        [XmlElement(ElementName = "VLBASEIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Vlbaseipi
        {
            get { return  vlbaseipi; }
            set {  vlbaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEPIS
        /// Comentário: Valor da Base do PIS
        /// </summary>
        private decimal? vlbasepis;
        [XmlElement(ElementName = "VLBASEPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlbasepis
        {
            get { return  vlbasepis; }
            set {  vlbasepis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal? vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Comentário: Valor do COFINS na Nota Fiscal.
        /// </summary>
        private decimal? vlcofins;
        [XmlElement(ElementName = "VLCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlcofins
        {
            get { return  vlcofins; }
            set {  vlcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDCOFINS
        /// Comentário: Indica o valor total de crédito de COFINS na NF.
        /// </summary>
        private decimal? vlcredcofins;
        [XmlElement(ElementName = "VLCREDCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlcredcofins
        {
            get { return  vlcredcofins; }
            set {  vlcredcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPIS
        /// Comentário: Indica o valor total de crédito de PIS na NF.
        /// </summary>
        private decimal? vlcredpis;
        [XmlElement(ElementName = "VLCREDPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlcredpis
        {
            get { return  vlcredpis; }
            set {  vlcredpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCSRF
        /// Comentário: INC	Valor de VLCSRF	Valor de VLCSRF
        /// </summary>
        private decimal? vlcsrf;
        [XmlElement(ElementName = "VLCSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlcsrf
        {
            get { return  vlcsrf; }
            set {  vlcsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal? vldescfin;
        [XmlElement(ElementName = "VLDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Vldescfin
        {
            get { return  vldescfin; }
            set {  vldescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal? vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPDENTRONF
        /// Comentário: Indica o Valor outras despesas na NF.
        /// </summary>
        private decimal? vldespdentronf;
        [XmlElement(ElementName = "VLDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vldespdentronf
        {
            get { return  vldespdentronf; }
            set {  vldespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: 
        /// </summary>
        private decimal? vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Comentário: 
        /// </summary>
        private decimal? vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLINSS
        /// Comentário: INC	Valor de VLINSS	Valor de VLINSS
        /// </summary>
        private decimal? vlinss;
        [XmlElement(ElementName = "VLINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlinss
        {
            get { return  vlinss; }
            set {  vlinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: 
        /// </summary>
        private decimal? vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIRRF
        /// Comentário: Valor de IRRF	Valor de IRRF
        /// </summary>
        private decimal? vlirrf;
        [XmlElement(ElementName = "VLIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlirrf
        {
            get { return  vlirrf; }
            set {  vlirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISENTAS
        /// Comentário: 
        /// </summary>
        private decimal? vlisentas;
        [XmlElement(ElementName = "VLISENTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlisentas
        {
            get { return  vlisentas; }
            set {  vlisentas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISS
        /// Comentário: INC	Valor de VLISS	Valor de VLISS
        /// </summary>
        private decimal? vliss;
        [XmlElement(ElementName = "VLISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vliss
        {
            get { return  vliss; }
            set {  vliss = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: VLOUTRAS
        /// Comentário: 
        /// </summary>
        private decimal? vloutras;
        [XmlElement(ElementName = "VLOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vloutras
        {
            get { return  vloutras; }
            set {  vloutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESPIMP
        /// Comentário: 
        /// </summary>
        private decimal? vloutrasdespimp;
        [XmlElement(ElementName = "VLOUTRASDESPIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vloutrasdespimp
        {
            get { return  vloutrasdespimp; }
            set {  vloutrasdespimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPEDAGIO
        /// Comentário: Valor total do pedágio.
        /// </summary>
        private decimal? vlpedagio;
        [XmlElement(ElementName = "VLPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlpedagio
        {
            get { return  vlpedagio; }
            set {  vlpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Comentário: Valor do PIS na Nota Fiscal.
        /// </summary>
        private decimal? vlpis;
        [XmlElement(ElementName = "VLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpis
        {
            get { return  vlpis; }
            set {  vlpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Comentário: Indica o valor do seguro.
        /// </summary>
        private decimal? vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSESTSENAT
        /// Comentário: Valor de VLSESTSENAT	Valor de VLSESTSENAT
        /// </summary>
        private decimal? vlsestsenat;
        [XmlElement(ElementName = "VLSESTSENAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlsestsenat
        {
            get { return  vlsestsenat; }
            set {  vlsestsenat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSISCOMEX
        /// Comentário: 
        /// </summary>
        private decimal? vlsiscomex;
        [XmlElement(ElementName = "VLSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlsiscomex
        {
            get { return  vlsiscomex; }
            set {  vlsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLST
        /// Comentário: 
        /// </summary>
        private decimal? vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlst
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
        /// Propriedade referente ao campo: VLTOTALFRETEFOB
        /// Comentário: Indica o valor total do frete FOB. 
        /// </summary>
        private decimal? vltotalfretefob;
        [XmlElement(ElementName = "VLTOTALFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vltotalfretefob
        {
            get { return  vltotalfretefob; }
            set {  vltotalfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALIPI
        /// Comentário: Indica o valor do IPI na nota fiscal.
        /// </summary>
        private decimal? vltotalipi;
        [XmlElement(ElementName = "VLTOTALIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vltotalipi
        {
            get { return  vltotalipi; }
            set {  vltotalipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTBRUTOPRODAJUSTE
        /// Comentário: Valor total bruto para NF de ajuste
        /// </summary>
        private decimal? vltotbrutoprodajuste;
        [XmlElement(ElementName = "VLTOTBRUTOPRODAJUSTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vltotbrutoprodajuste
        {
            get { return  vltotbrutoprodajuste; }
            set {  vltotbrutoprodajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTGER
        /// Comentário: 
        /// </summary>
        private decimal? vltotger;
        [XmlElement(ElementName = "VLTOTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vltotger
        {
            get { return  vltotger; }
            set {  vltotger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMV
        /// Comentário: Indica o valor total da verba CMV registrado na nota fiscal de saída. |Campo do tipo numérico, de tamanho 18, com 6 casas decimais.
        /// </summary>
        private decimal? vlverbacmv;
        [XmlElement(ElementName = "VLVERBACMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlverbacmv
        {
            get { return  vlverbacmv; }
            set {  vlverbacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMVCLI
        /// Comentário: Indica o valor total da verba CMV registrado na nota fiscal de saída. 
        /// </summary>
        private decimal? vlverbacmvcli;
        [XmlElement(ElementName = "VLVERBACMVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlverbacmvcli
        {
            get { return  vlverbacmvcli; }
            set {  vlverbacmvcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: WMSCODFUNCIGNORA
        /// Comentário: Funcionário que ignorou WMS
        /// </summary>
        private decimal? wmscodfuncignora;
        [XmlElement(ElementName = "WMSCODFUNCIGNORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Wmscodfuncignora
        {
            get { return  wmscodfuncignora; }
            set {  wmscodfuncignora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: WMSIGNORADO
        /// Comentário: WMS Ignorado
        /// </summary>
        private string wmsignorado;
        [XmlElement(ElementName = "WMSIGNORADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Wmsignorado
        {
            get { return  wmsignorado; }
            set {  wmsignorado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNfent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNfent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNfent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfent>(where);
        }

        #endregion
    }
}
