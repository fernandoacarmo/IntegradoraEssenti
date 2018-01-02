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
    /// Classe referente a tabela PCAplicverbai
    /// </summary>
    [XmlType("PCAPLICVERBAI")]
    public class PCAplicverbai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: 
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CONDVENDA
        /// Coment�rio: Condi��o de Venda
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
        /// Propriedade referente ao campo: CUSTOFINANT
        /// Coment�rio: 
        /// </summary>
        private decimal custofinant;
        [XmlElement(ElementName = "CUSTOFINANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinant
        {
            get { return  custofinant; }
            set {  custofinant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFINATUAL
        /// Coment�rio: 
        /// </summary>
        private decimal custofinatual;
        [XmlElement(ElementName = "CUSTOFINATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinatual
        {
            get { return  custofinatual; }
            set {  custofinatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFORNECANT
        /// Coment�rio: Custo fornecedor ap�s a aplica��o da verba
        /// </summary>
        private decimal custofornecant;
        [XmlElement(ElementName = "CUSTOFORNECANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofornecant
        {
            get { return  custofornecant; }
            set {  custofornecant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFORNECATUAL
        /// Coment�rio: 
        /// </summary>
        private decimal custofornecatual;
        [XmlElement(ElementName = "CUSTOFORNECATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofornecatual
        {
            get { return  custofornecatual; }
            set {  custofornecatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRAANT
        /// Coment�rio: Custo da pr�xima compra antes da aplica��o de verba
        /// </summary>
        private decimal custoproximacompraant;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoproximacompraant
        {
            get { return  custoproximacompraant; }
            set {  custoproximacompraant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRAATUAL
        /// Coment�rio: Custo da pr�xima compra ap�s a aplica��o da verba
        /// </summary>
        private decimal custoproximacompraatual;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRAATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoproximacompraatual
        {
            get { return  custoproximacompraatual; }
            set {  custoproximacompraatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALANT
        /// Coment�rio: 
        /// </summary>
        private decimal custorealant;
        [XmlElement(ElementName = "CUSTOREALANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealant
        {
            get { return  custorealant; }
            set {  custorealant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALATUAL
        /// Coment�rio: 
        /// </summary>
        private decimal custorealatual;
        [XmlElement(ElementName = "CUSTOREALATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealatual
        {
            get { return  custorealatual; }
            set {  custorealatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALSEMSTANT
        /// Coment�rio: 
        /// </summary>
        private decimal custorealsemstant;
        [XmlElement(ElementName = "CUSTOREALSEMSTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealsemstant
        {
            get { return  custorealsemstant; }
            set {  custorealsemstant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALSEMSTATUAL
        /// Coment�rio: 
        /// </summary>
        private decimal custorealsemstatual;
        [XmlElement(ElementName = "CUSTOREALSEMSTATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealsemstatual
        {
            get { return  custorealsemstatual; }
            set {  custorealsemstatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPANT
        /// Coment�rio: 
        /// </summary>
        private decimal custorepant;
        [XmlElement(ElementName = "CUSTOREPANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorepant
        {
            get { return  custorepant; }
            set {  custorepant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPATUAL
        /// Coment�rio: 
        /// </summary>
        private decimal custorepatual;
        [XmlElement(ElementName = "CUSTOREPATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorepatual
        {
            get { return  custorepatual; }
            set {  custorepatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTANT
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CUSTOULTENTATUAL
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentatual;
        [XmlElement(ElementName = "CUSTOULTENTATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentatual
        {
            get { return  custoultentatual; }
            set {  custoultentatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAPLIC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtaplic;
        [XmlElement(ElementName = "DTAPLIC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaplic
        {
            get { return  dtaplic; }
            set {  dtaplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMVIGENCIA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfimvigencia;
        [XmlElement(ElementName = "DTFIMVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimvigencia
        {
            get { return  dtfimvigencia; }
            set {  dtfimvigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOVIGENCIA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtiniciovigencia;
        [XmlElement(ElementName = "DTINICIOVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciovigencia
        {
            get { return  dtiniciovigencia; }
            set {  dtiniciovigencia = value; }
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
        /// Propriedade referente ao campo: NUMVERBA
        /// Coment�rio: 
        /// </summary>
        private decimal numverba;
        [XmlElement(ElementName = "NUMVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numverba
        {
            get { return  numverba; }
            set {  numverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAPLIC
        /// Coment�rio: 
        /// </summary>
        private decimal percaplic;
        [XmlElement(ElementName = "PERCAPLIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percaplic
        {
            get { return  percaplic; }
            set {  percaplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGER
        /// Coment�rio: 
        /// </summary>
        private decimal qtestger;
        [XmlElement(ElementName = "QTESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestger
        {
            get { return  qtestger; }
            set {  qtestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal qtvenda;
        [XmlElement(ElementName = "QTVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtvenda
        {
            get { return  qtvenda; }
            set {  qtvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAPLIC
        /// Coment�rio: 
        /// </summary>
        private decimal vlaplic;
        [XmlElement(ElementName = "VLAPLIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlaplic
        {
            get { return  vlaplic; }
            set {  vlaplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAPLICUNITARIO
        /// Coment�rio: Indica o valor unit�rio rebaixa CMV.
        /// </summary>
        private decimal vlaplicunitario;
        [XmlElement(ElementName = "VLAPLICUNITARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlaplicunitario
        {
            get { return  vlaplicunitario; }
            set {  vlaplicunitario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFIN
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustofin;
        [XmlElement(ElementName = "VLCUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustofin
        {
            get { return  vlcustofin; }
            set {  vlcustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINANT
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustofinant;
        [XmlElement(ElementName = "VLCUSTOFINANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustofinant
        {
            get { return  vlcustofinant; }
            set {  vlcustofinant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREAL
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustoreal;
        [XmlElement(ElementName = "VLCUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustoreal
        {
            get { return  vlcustoreal; }
            set {  vlcustoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREALANT
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustorealant;
        [XmlElement(ElementName = "VLCUSTOREALANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustorealant
        {
            get { return  vlcustorealant; }
            set {  vlcustorealant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal vlvenda;
        [XmlElement(ElementName = "VLVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
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
        public PCAplicverbai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAPLICVERBAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAplicverbai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAplicverbai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAplicverbai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAplicverbai>(where);
        }

        #endregion
    }
}
