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
    /// Classe referente a tabela PCHistest
    /// </summary>
    [XmlType("PCHISTEST")]
    public class PCHistest : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSVIGENTE
        /// Coment�rio: Aliq. ICMS vigente para o produto na UF.
        /// </summary>
        private decimal aliqicmsvigente;
        [XmlElement(ElementName = "ALIQICMSVIGENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Aliqicmsvigente
        {
            get { return  aliqicmsvigente; }
            set {  aliqicmsvigente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASAQTAVARIAWMS
        /// Coment�rio: 
        /// </summary>
        private decimal asaqtavariawms;
        [XmlElement(ElementName = "ASAQTAVARIAWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Asaqtavariawms
        {
            get { return  asaqtavariawms; }
            set {  asaqtavariawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASAQTFALTAWMS
        /// Coment�rio: 
        /// </summary>
        private decimal asaqtfaltawms;
        [XmlElement(ElementName = "ASAQTFALTAWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Asaqtfaltawms
        {
            get { return  asaqtfaltawms; }
            set {  asaqtfaltawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASAQTSOBRAWMS
        /// Coment�rio: 
        /// </summary>
        private decimal asaqtsobrawms;
        [XmlElement(ElementName = "ASAQTSOBRAWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Asaqtsobrawms
        {
            get { return  asaqtsobrawms; }
            set {  asaqtsobrawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSIFICFISCAL
        /// Coment�rio: Classifica��o fiscal do produto.
        /// </summary>
        private string classificfiscal;
        [XmlElement(ElementName = "CLASSIFICFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Classificfiscal
        {
            get { return  classificfiscal; }
            set {  classificfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: C�d.Auxiliar do produto.
        /// </summary>
        private string codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGENEROFISCAL
        /// Coment�rio: Indica o c�digo do genero fiscal.
        /// </summary>
        private decimal codgenerofiscal;
        [XmlElement(ElementName = "CODGENEROFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgenerofiscal
        {
            get { return  codgenerofiscal; }
            set {  codgenerofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICM
        /// Coment�rio: Indica o percentual do ICMS do produto.
        /// </summary>
        private decimal codicm;
        [XmlElement(ElementName = "CODICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicm
        {
            get { return  codicm; }
            set {  codicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODINTERNO
        /// Coment�rio: C�digo interno do produto da empresa
        /// </summary>
        private string codinterno;
        [XmlElement(ElementName = "CODINTERNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codinterno
        {
            get { return  codinterno; }
            set {  codinterno = value; }
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
        /// Propriedade referente ao campo: CODPRODRELEV
        /// Coment�rio: C�digo de Produto Relevante.
        /// </summary>
        private decimal codprodrelev;
        [XmlElement(ElementName = "CODPRODRELEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codprodrelev
        {
            get { return  codprodrelev; }
            set {  codprodrelev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODSINTEGRA
        /// Coment�rio: C�d.Prod. para envio no arquivo Sintegra.
        /// </summary>
        private string codprodsintegra;
        [XmlElement(ElementName = "CODPRODSINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codprodsintegra
        {
            get { return  codprodsintegra; }
            set {  codprodsintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINS
        /// Coment�rio: C�digo da Situa��o tribut�ria do PIS/COFINS.
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
        /// Propriedade referente ao campo: CUSTOCONT
        /// Coment�rio: 
        /// </summary>
        private decimal custocont;
        [XmlElement(ElementName = "CUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocont
        {
            get { return  custocont; }
            set {  custocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTODOLAR
        /// Coment�rio: 
        /// </summary>
        private decimal custodolar;
        [XmlElement(ElementName = "CUSTODOLAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custodolar
        {
            get { return  custodolar; }
            set {  custodolar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Coment�rio: 
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINSEMST
        /// Coment�rio: Custo financeiro sem ST
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
        /// Propriedade referente ao campo: CUSTOFORNEC
        /// Coment�rio: Indica o custo do fornecedor.
        /// </summary>
        private decimal custofornec;
        [XmlElement(ElementName = "CUSTOFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Custofornec
        {
            get { return  custofornec; }
            set {  custofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFORNECSEMST
        /// Coment�rio: Custo fornece sem ST
        /// </summary>
        private decimal custofornecsemst;
        [XmlElement(ElementName = "CUSTOFORNECSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofornecsemst
        {
            get { return  custofornecsemst; }
            set {  custofornecsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMST
        /// Coment�rio: Custo da NF sem ST
        /// </summary>
        private decimal custonfsemst;
        [XmlElement(ElementName = "CUSTONFSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemst
        {
            get { return  custonfsemst; }
            set {  custonfsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMSTGUIAULTENT
        /// Coment�rio: Custo NF sem ST Guia da �ltima entrada
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
        /// Propriedade referente ao campo: CUSTONFSEMSTGUIAULTENTTAB
        /// Coment�rio: Custo NF sem ST Guia da �ltima entrada TAB
        /// </summary>
        private decimal custonfsemstguiaultenttab;
        [XmlElement(ElementName = "CUSTONFSEMSTGUIAULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemstguiaultenttab
        {
            get { return  custonfsemstguiaultenttab; }
            set {  custonfsemstguiaultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMSTTAB
        /// Coment�rio: Custo NF sem ST Tab
        /// </summary>
        private decimal custonfsemsttab;
        [XmlElement(ElementName = "CUSTONFSEMSTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemsttab
        {
            get { return  custonfsemsttab; }
            set {  custonfsemsttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRA
        /// Coment�rio: Custo pr�xima compra
        /// </summary>
        private decimal custoproximacompra;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoproximacompra
        {
            get { return  custoproximacompra; }
            set {  custoproximacompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRASEMST
        /// Coment�rio: Custo pr�xima compra sem ST
        /// </summary>
        private decimal custoproximacomprasemst;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRASEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoproximacomprasemst
        {
            get { return  custoproximacomprasemst; }
            set {  custoproximacomprasemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Coment�rio: 
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALLIQ
        /// Coment�rio: Custo real L�quido
        /// </summary>
        private decimal custorealliq;
        [XmlElement(ElementName = "CUSTOREALLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealliq
        {
            get { return  custorealliq; }
            set {  custorealliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALSEMST
        /// Coment�rio: 
        /// </summary>
        private decimal custorealsemst;
        [XmlElement(ElementName = "CUSTOREALSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealsemst
        {
            get { return  custorealsemst; }
            set {  custorealsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREP
        /// Coment�rio: 
        /// </summary>
        private decimal custorep;
        [XmlElement(ElementName = "CUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorep
        {
            get { return  custorep; }
            set {  custorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CUSTOULTENTANT
        /// Coment�rio: Custo �ltima entrada anterior
        /// </summary>
        private decimal custoultentant;
        [XmlElement(ElementName = "CUSTOULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentant
        {
            get { return  custoultentant; }
            set {  custoultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTCONT
        /// Coment�rio: Custo contabil da �ltima entrada
        /// </summary>
        private decimal custoultentcont;
        [XmlElement(ElementName = "CUSTOULTENTCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentcont
        {
            get { return  custoultentcont; }
            set {  custoultentcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTFIN
        /// Coment�rio: Custo Financeiro �ltima entrada
        /// </summary>
        private decimal custoultentfin;
        [XmlElement(ElementName = "CUSTOULTENTFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentfin
        {
            get { return  custoultentfin; }
            set {  custoultentfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTFINSEMST
        /// Coment�rio: Custo financeiro sem ST da �ltima entrada
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
        /// Propriedade referente ao campo: CUSTOULTENTLIQ
        /// Coment�rio: Custo L�quido da �ltima entrada
        /// </summary>
        private decimal custoultentliq;
        [XmlElement(ElementName = "CUSTOULTENTLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentliq
        {
            get { return  custoultentliq; }
            set {  custoultentliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTMED
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentmed;
        [XmlElement(ElementName = "CUSTOULTENTMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentmed
        {
            get { return  custoultentmed; }
            set {  custoultentmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTSEMST
        /// Coment�rio: Custo sem ST da ultima entrada
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
        /// Propriedade referente ao campo: CUSTOULTPEDCOMPRA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o do produto.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAOPROD
        /// Coment�rio: Data de exclus�o do produto.
        /// </summary>
        private DateTime? dtexclusaoprod;
        [XmlElement(ElementName = "DTEXCLUSAOPROD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusaoprod
        {
            get { return  dtexclusaoprod; }
            set {  dtexclusaoprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTGERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtgeracao;
        [XmlElement(ElementName = "DTGERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgeracao
        {
            get { return  dtgeracao; }
            set {  dtgeracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTENT
        /// Coment�rio: Data �ltima entrada
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
        /// Propriedade referente ao campo: DV
        /// Coment�rio: Digito verificador do c�digo do produto.
        /// </summary>
        private decimal dv;
        [XmlElement(ElementName = "DV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dv
        {
            get { return  dv; }
            set {  dv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Coment�rio: Embalagem do produto.
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNDAPIANO
        /// Coment�rio: Produto pertencente ao FUNDAP, legisla��o do Espirito Santo, para impress�o de livros fiscais.
        /// </summary>
        private string fundapiano;
        [XmlElement(ElementName = "FUNDAPIANO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fundapiano
        {
            get { return  fundapiano; }
            set {  fundapiano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Coment�rio: Gerou hist�rico para o registro, sim ou n�o.
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
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: Indica se o produto � Importado.
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NBM
        /// Coment�rio: NCM do produto.
        /// </summary>
        private string nbm;
        [XmlElement(ElementName = "NBM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nbm
        {
            get { return  nbm; }
            set {  nbm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Coment�rio: Indica o percentual COFINS do produto.
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCST
        /// Coment�rio: Indica o percentual de ST.
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
        /// Propriedade referente ao campo: PERICM
        /// Coment�rio: % ICMS produto.
        /// </summary>
        private decimal pericm;
        [XmlElement(ElementName = "PERICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pericm
        {
            get { return  pericm; }
            set {  pericm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Coment�rio: Indica o percentual do PIS do produto.
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISCOFINSRETIDO
        /// Coment�rio: Indica se o PIS/COFINS � retido.
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
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEST
        /// Coment�rio: 
        /// </summary>
        private decimal qtest;
        [XmlElement(ElementName = "QTEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtest
        {
            get { return  qtest; }
            set {  qtest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGER
        /// Coment�rio: 
        /// </summary>
        private decimal qtestger;
        [XmlElement(ElementName = "QTESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtestger
        {
            get { return  qtestger; }
            set {  qtestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFRENTELOJA
        /// Coment�rio: Quantidade no estoque da loja
        /// </summary>
        private decimal qtfrenteloja;
        [XmlElement(ElementName = "QTFRENTELOJA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtfrenteloja
        {
            get { return  qtfrenteloja; }
            set {  qtfrenteloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTINDENIZ
        /// Coment�rio: 
        /// </summary>
        private decimal qtindeniz;
        [XmlElement(ElementName = "QTINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtindeniz
        {
            get { return  qtindeniz; }
            set {  qtindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDENTE
        /// Coment�rio: 
        /// </summary>
        private decimal qtpendente;
        [XmlElement(ElementName = "QTPENDENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtpendente
        {
            get { return  qtpendente; }
            set {  qtpendente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Coment�rio: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtreserv
        {
            get { return  qtreserv; }
            set {  qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSITO
        /// Coment�rio: Quantidade em Tr�nsito
        /// </summary>
        private decimal qttransito;
        [XmlElement(ElementName = "QTTRANSITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qttransito
        {
            get { return  qttransito; }
            set {  qttransito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTULTENT
        /// Coment�rio: Indica a quantidade da ultima entrada.
        /// </summary>
        private decimal qtultent;
        [XmlElement(ElementName = "QTULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtultent
        {
            get { return  qtultent; }
            set {  qtultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Coment�rio: Indica a situa��o tribut�ria.
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
        /// Propriedade referente ao campo: TIPOMERC
        /// Coment�rio: Tipo Merc. do produto.
        /// </summary>
        private string tipomerc;
        [XmlElement(ElementName = "TIPOMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomerc
        {
            get { return  tipomerc; }
            set {  tipomerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMERCDEPTO
        /// Coment�rio: Tipo Merc. Do departamento do departamento.
        /// </summary>
        private string tipomercdepto;
        [XmlElement(ElementName = "TIPOMERCDEPTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomercdepto
        {
            get { return  tipomercdepto; }
            set {  tipomercdepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALVLBASEICMS
        /// Coment�rio: Valor Total da Base de ICMS
        /// </summary>
        private decimal totalvlbaseicms;
        [XmlElement(ElementName = "TOTALVLBASEICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Totalvlbaseicms
        {
            get { return  totalvlbaseicms; }
            set {  totalvlbaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALVLCOFINS
        /// Coment�rio: Total Valor COFINS.
        /// </summary>
        private decimal totalvlcofins;
        [XmlElement(ElementName = "TOTALVLCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Totalvlcofins
        {
            get { return  totalvlcofins; }
            set {  totalvlcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALVLICMS
        /// Coment�rio: Total de ICMS contido no estoque. 
        /// </summary>
        private decimal totalvlicms;
        [XmlElement(ElementName = "TOTALVLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Totalvlicms
        {
            get { return  totalvlicms; }
            set {  totalvlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALVLIPI
        /// Coment�rio: Total Valor IPI.
        /// </summary>
        private decimal totalvlipi;
        [XmlElement(ElementName = "TOTALVLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Totalvlipi
        {
            get { return  totalvlipi; }
            set {  totalvlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALVLPIS
        /// Coment�rio: Total Valor PIS.
        /// </summary>
        private decimal totalvlpis;
        [XmlElement(ElementName = "TOTALVLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Totalvlpis
        {
            get { return  totalvlpis; }
            set {  totalvlpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALVLST
        /// Coment�rio: Total de ST contido no estoque. 
        /// </summary>
        private decimal totalvlst;
        [XmlElement(ElementName = "TOTALVLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Totalvlst
        {
            get { return  totalvlst; }
            set {  totalvlst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Coment�rio: Unidade de medida do produto.
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
        /// Propriedade referente ao campo: VALORULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal valorultent;
        [XmlElement(ElementName = "VALORULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorultent
        {
            get { return  valorultent; }
            set {  valorultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENTMED
        /// Coment�rio: 
        /// </summary>
        private decimal valorultentmed;
        [XmlElement(ElementName = "VALORULTENTMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorultentmed
        {
            get { return  valorultentmed; }
            set {  valorultentmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTODIAFIN
        /// Coment�rio: Custo Financeiro dia
        /// </summary>
        private decimal vlcustodiafin;
        [XmlElement(ElementName = "VLCUSTODIAFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcustodiafin
        {
            get { return  vlcustodiafin; }
            set {  vlcustodiafin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTODIAREAL
        /// Coment�rio: Custo Real do dia
        /// </summary>
        private decimal vlcustodiareal;
        [XmlElement(ElementName = "VLCUSTODIAREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcustodiareal
        {
            get { return  vlcustodiareal; }
            set {  vlcustodiareal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFIN
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustofin;
        [XmlElement(ElementName = "VLCUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofin
        {
            get { return  vlcustofin; }
            set {  vlcustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMESFIN
        /// Coment�rio: Custo Financeiro do M�s
        /// </summary>
        private decimal vlcustomesfin;
        [XmlElement(ElementName = "VLCUSTOMESFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcustomesfin
        {
            get { return  vlcustomesfin; }
            set {  vlcustomesfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMESFINANT
        /// Coment�rio: Custo Financeiro do M�s anterior
        /// </summary>
        private decimal vlcustomesfinant;
        [XmlElement(ElementName = "VLCUSTOMESFINANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustomesfinant
        {
            get { return  vlcustomesfinant; }
            set {  vlcustomesfinant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMESREAL
        /// Coment�rio: Custo Real do M�s
        /// </summary>
        private decimal vlcustomesreal;
        [XmlElement(ElementName = "VLCUSTOMESREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcustomesreal
        {
            get { return  vlcustomesreal; }
            set {  vlcustomesreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMESREALANT
        /// Coment�rio: Custo Real do M�s anterior
        /// </summary>
        private decimal vlcustomesrealant;
        [XmlElement(ElementName = "VLCUSTOMESREALANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustomesrealant
        {
            get { return  vlcustomesrealant; }
            set {  vlcustomesrealant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREAL
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustoreal;
        [XmlElement(ElementName = "VLCUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustoreal
        {
            get { return  vlcustoreal; }
            set {  vlcustoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETECONHECULTENT
        /// Coment�rio: Valor conhecimento de frete �ltima entrada
        /// </summary>
        private decimal vlfreteconhecultent;
        [XmlElement(ElementName = "VLFRETECONHECULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfreteconhecultent
        {
            get { return  vlfreteconhecultent; }
            set {  vlfreteconhecultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETECONHECULTENTTAB
        /// Coment�rio: Valor conhecimento de frete �ltima entrada Futuro
        /// </summary>
        private decimal vlfreteconhecultenttab;
        [XmlElement(ElementName = "VLFRETECONHECULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfreteconhecultenttab
        {
            get { return  vlfreteconhecultenttab; }
            set {  vlfreteconhecultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIMPORTACAOFCI
        /// Coment�rio: Valor importa��o FCI
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
        /// Propriedade referente ao campo: VLPARCELAIMPFCI
        /// Coment�rio: Valor Parcela Importa��o FCI
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
        /// Propriedade referente ao campo: VLST
        /// Coment�rio: 
        /// </summary>
        private decimal vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlst
        {
            get { return  vlst; }
            set {  vlst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTGUIAULTENT
        /// Coment�rio: Valor do ST guia da �ltima entrada
        /// </summary>
        private decimal vlstguiaultent;
        [XmlElement(ElementName = "VLSTGUIAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstguiaultent
        {
            get { return  vlstguiaultent; }
            set {  vlstguiaultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTGUIAULTENTTAB
        /// Coment�rio: Valor Tab do ST guia da �ltima entrada
        /// </summary>
        private decimal vlstguiaultenttab;
        [XmlElement(ElementName = "VLSTGUIAULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstguiaultenttab
        {
            get { return  vlstguiaultenttab; }
            set {  vlstguiaultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTULTENT
        /// Coment�rio: Valor do ST da �ltima entrada
        /// </summary>
        private decimal vlstultent;
        [XmlElement(ElementName = "VLSTULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstultent
        {
            get { return  vlstultent; }
            set {  vlstultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTULTENTTAB
        /// Coment�rio: Valor do ST da �ltima entrada TAB
        /// </summary>
        private decimal vlstultenttab;
        [XmlElement(ElementName = "VLSTULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstultenttab
        {
            get { return  vlstultenttab; }
            set {  vlstultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTENTCONTSEMST
        /// Coment�rio: Valor contabil da �ltima entrada sem ST
        /// </summary>
        private decimal vlultentcontsemst;
        [XmlElement(ElementName = "VLULTENTCONTSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultentcontsemst
        {
            get { return  vlultentcontsemst; }
            set {  vlultentcontsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTPCOMPRA
        /// Coment�rio: Valor do �ltima pedido de compra
        /// </summary>
        private decimal vlultpcompra;
        [XmlElement(ElementName = "VLULTPCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultpcompra
        {
            get { return  vlultpcompra; }
            set {  vlultpcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal vlvenda;
        [XmlElement(ElementName = "VLVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvenda
        {
            get { return  vlvenda; }
            set {  vlvenda = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCHistest()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCHISTEST";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCHistest> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCHistest>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCHistest> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCHistest>(where);
        }

        #endregion
    }
}
