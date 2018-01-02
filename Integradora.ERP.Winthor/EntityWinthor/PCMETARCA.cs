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
    /// Classe referente a tabela PCMetarca
    /// </summary>
    [XmlType("PCMETARCA")]
    public class PCMetarca : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
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
        /// Propriedade referente ao campo: LMG_DESCBONIF
        /// Coment�rio: 
        /// </summary>
        private decimal lmg_descbonif;
        [XmlElement(ElementName = "LMG_DESCBONIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Lmg_Descbonif
        {
            get { return  lmg_descbonif; }
            set {  lmg_descbonif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LMG_PRAZOMEDIO
        /// Coment�rio: 
        /// </summary>
        private decimal lmg_prazomedio;
        [XmlElement(ElementName = "LMG_PRAZOMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Lmg_Prazomedio
        {
            get { return  lmg_prazomedio; }
            set {  lmg_prazomedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCLIPOS
        /// Coment�rio: Indica a meta de clientes para positiva��o.
        /// </summary>
        private decimal numclipos;
        [XmlElement(ElementName = "NUMCLIPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Numclipos
        {
            get { return  numclipos; }
            set {  numclipos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERADICVLMETA
        /// Coment�rio: 
        /// </summary>
        private decimal peradicvlmeta;
        [XmlElement(ElementName = "PERADICVLMETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Peradicvlmeta
        {
            get { return  peradicvlmeta; }
            set {  peradicvlmeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCLIPOSPREV
        /// Coment�rio: 
        /// </summary>
        private decimal percliposprev;
        [XmlElement(ElementName = "PERCLIPOSPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percliposprev
        {
            get { return  percliposprev; }
            set {  percliposprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERVENDAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal pervendaprev;
        [XmlElement(ElementName = "PERVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Pervendaprev
        {
            get { return  pervendaprev; }
            set {  pervendaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTITENSPEDPREV
        /// Coment�rio: 
        /// </summary>
        private decimal qtitenspedprev;
        [XmlElement(ElementName = "QTITENSPEDPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtitenspedprev
        {
            get { return  qtitenspedprev; }
            set {  qtitenspedprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMETROPREV
        /// Coment�rio: 
        /// </summary>
        private decimal qtmetroprev;
        [XmlElement(ElementName = "QTMETROPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtmetroprev
        {
            get { return  qtmetroprev; }
            set {  qtmetroprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDPREV
        /// Coment�rio: 
        /// </summary>
        private decimal qtpedprev;
        [XmlElement(ElementName = "QTPEDPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtpedprev
        {
            get { return  qtpedprev; }
            set {  qtpedprev = value; }
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
        /// Propriedade referente ao campo: VLTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal vltabela;
        [XmlElement(ElementName = "VLTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltabela
        {
            get { return  vltabela; }
            set {  vltabela = value; }
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

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal vlvendaprev;
        [XmlElement(ElementName = "VLVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendaprev
        {
            get { return  vlvendaprev; }
            set {  vlvendaprev = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMetarca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETARCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMetarca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetarca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMetarca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetarca>(where);
        }

        #endregion
    }
}
