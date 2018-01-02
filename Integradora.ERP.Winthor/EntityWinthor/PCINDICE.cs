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
    /// Classe referente a tabela PCIndice
    /// </summary>
    [XmlType("PCINDICE")]
    public class PCIndice : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQIR1
        /// Coment�rio: 
        /// </summary>
        private decimal aliqir1;
        [XmlElement(ElementName = "ALIQIR1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqir1
        {
            get { return  aliqir1; }
            set {  aliqir1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQIR2
        /// Coment�rio: 
        /// </summary>
        private decimal aliqir2;
        [XmlElement(ElementName = "ALIQIR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqir2
        {
            get { return  aliqir2; }
            set {  aliqir2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQIR3
        /// Coment�rio: 
        /// </summary>
        private decimal aliqir3;
        [XmlElement(ElementName = "ALIQIR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqir3
        {
            get { return  aliqir3; }
            set {  aliqir3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQIR4
        /// Coment�rio: 
        /// </summary>
        private decimal aliqir4;
        [XmlElement(ElementName = "ALIQIR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqir4
        {
            get { return  aliqir4; }
            set {  aliqir4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BOLIVIANO
        /// Coment�rio: 
        /// </summary>
        private decimal boliviano;
        [XmlElement(ElementName = "BOLIVIANO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Boliviano
        {
            get { return  boliviano; }
            set {  boliviano = value; }
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
        /// Propriedade referente ao campo: DEDUCAODEP
        /// Coment�rio: 
        /// </summary>
        private decimal deducaodep;
        [XmlElement(ElementName = "DEDUCAODEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Deducaodep
        {
            get { return  deducaodep; }
            set {  deducaodep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUCAOIR1
        /// Coment�rio: 
        /// </summary>
        private decimal deducaoir1;
        [XmlElement(ElementName = "DEDUCAOIR1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Deducaoir1
        {
            get { return  deducaoir1; }
            set {  deducaoir1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUCAOIR2
        /// Coment�rio: 
        /// </summary>
        private decimal deducaoir2;
        [XmlElement(ElementName = "DEDUCAOIR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Deducaoir2
        {
            get { return  deducaoir2; }
            set {  deducaoir2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUCAOIR3
        /// Coment�rio: 
        /// </summary>
        private decimal deducaoir3;
        [XmlElement(ElementName = "DEDUCAOIR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Deducaoir3
        {
            get { return  deducaoir3; }
            set {  deducaoir3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUCAOIR4
        /// Coment�rio: 
        /// </summary>
        private decimal deducaoir4;
        [XmlElement(ElementName = "DEDUCAOIR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Deducaoir4
        {
            get { return  deducaoir4; }
            set {  deducaoir4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOLARCOM
        /// Coment�rio: 
        /// </summary>
        private decimal dolarcom;
        [XmlElement(ElementName = "DOLARCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Dolarcom
        {
            get { return  dolarcom; }
            set {  dolarcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOLARPAR
        /// Coment�rio: 
        /// </summary>
        private decimal dolarpar;
        [XmlElement(ElementName = "DOLARPAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Dolarpar
        {
            get { return  dolarpar; }
            set {  dolarpar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EURO
        /// Coment�rio: 
        /// </summary>
        private decimal euro;
        [XmlElement(ElementName = "EURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Euro
        {
            get { return  euro; }
            set {  euro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IENE
        /// Coment�rio: 
        /// </summary>
        private decimal iene;
        [XmlElement(ElementName = "IENE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Iene
        {
            get { return  iene; }
            set {  iene = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OURO
        /// Coment�rio: 
        /// </summary>
        private decimal ouro;
        [XmlElement(ElementName = "OURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ouro
        {
            get { return  ouro; }
            set {  ouro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POUPANCA
        /// Coment�rio: 
        /// </summary>
        private decimal poupanca;
        [XmlElement(ElementName = "POUPANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Poupanca
        {
            get { return  poupanca; }
            set {  poupanca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRD
        /// Coment�rio: 
        /// </summary>
        private decimal trd;
        [XmlElement(ElementName = "TRD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Trd
        {
            get { return  trd; }
            set {  trd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFIR
        /// Coment�rio: 
        /// </summary>
        private decimal ufir;
        [XmlElement(ElementName = "UFIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ufir
        {
            get { return  ufir; }
            set {  ufir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORIR1
        /// Coment�rio: 
        /// </summary>
        private decimal valorir1;
        [XmlElement(ElementName = "VALORIR1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorir1
        {
            get { return  valorir1; }
            set {  valorir1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORIR2
        /// Coment�rio: 
        /// </summary>
        private decimal valorir2;
        [XmlElement(ElementName = "VALORIR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorir2
        {
            get { return  valorir2; }
            set {  valorir2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORIR3
        /// Coment�rio: 
        /// </summary>
        private decimal valorir3;
        [XmlElement(ElementName = "VALORIR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorir3
        {
            get { return  valorir3; }
            set {  valorir3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORIR4
        /// Coment�rio: 
        /// </summary>
        private decimal valorir4;
        [XmlElement(ElementName = "VALORIR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorir4
        {
            get { return  valorir4; }
            set {  valorir4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal vendaprev;
        [XmlElement(ElementName = "VENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vendaprev
        {
            get { return  vendaprev; }
            set {  vendaprev = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCIndice()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINDICE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCIndice> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIndice>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCIndice> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIndice>(where);
        }

        #endregion
    }
}
