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
    /// Classe referente a tabela PCWmsnfsaid
    /// </summary>
    [XmlType("PCWMSNFSAID")]
    public class PCWmsnfsaid : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLISAP
        /// Coment�rio: 
        /// </summary>
        private string codclisap;
        [XmlElement(ElementName = "CODCLISAP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codclisap
        {
            get { return  codclisap; }
            set {  codclisap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal condvenda;
        [XmlElement(ElementName = "CONDVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Condvenda
        {
            get { return  condvenda; }
            set {  condvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROCESSAMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtprocessamento;
        [XmlElement(ElementName = "DTPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprocessamento
        {
            get { return  dtprocessamento; }
            set {  dtprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ESPECIE
        /// Coment�rio: 
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGER
        /// Coment�rio: 
        /// </summary>
        private decimal numger;
        [XmlElement(ElementName = "NUMGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numger
        {
            get { return  numger; }
            set {  numger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFORO
        /// Coment�rio: 
        /// </summary>
        private decimal semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Semaforo
        {
            get { return  semaforo; }
            set {  semaforo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Coment�rio: 
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESO
        /// Coment�rio: 
        /// </summary>
        private decimal totpeso;
        [XmlElement(ElementName = "TOTPESO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Totpeso
        {
            get { return  totpeso; }
            set {  totpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVOLUME
        /// Coment�rio: 
        /// </summary>
        private decimal totvolume;
        [XmlElement(ElementName = "TOTVOLUME", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Totvolume
        {
            get { return  totvolume; }
            set {  totvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFIN
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustofin;
        [XmlElement(ElementName = "VLCUSTOFIN", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Vlcustofin
        {
            get { return  vlcustofin; }
            set {  vlcustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Coment�rio: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCWmsnfsaid()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSNFSAID";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCWmsnfsaid> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsnfsaid.GetStringConnection());
            return ba.Listar<PCWmsnfsaid>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCWmsnfsaid> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsnfsaid.GetStringConnection());
            return ba.Existe<PCWmsnfsaid>(where);
        }

        #endregion
    }
}
