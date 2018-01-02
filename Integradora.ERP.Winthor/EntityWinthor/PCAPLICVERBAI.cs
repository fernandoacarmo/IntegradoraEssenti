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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CONDVENDA
        /// Comentário: Condição de Venda
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Custo fornecedor após a aplicação da verba
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
        /// Comentário: 
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
        /// Comentário: Custo da próxima compra antes da aplicação de verba
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
        /// Comentário: Custo da próxima compra após a aplicação da verba
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMVERBA
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o valor unitário rebaixa CMV.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAplicverbai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAplicverbai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
