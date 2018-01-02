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
    /// Classe referente a tabela PCWmsclient
    /// </summary>
    [XmlType("PCWMSCLIENT")]
    public class PCWmsclient : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRROENT
        /// Comentário: 
        /// </summary>
        private string bairroent;
        [XmlElement(ElementName = "BAIRROENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairroent
        {
            get { return  bairroent; }
            set {  bairroent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPENT
        /// Comentário: 
        /// </summary>
        private string cepent;
        [XmlElement(ElementName = "CEPENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepent
        {
            get { return  cepent; }
            set {  cepent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCENT
        /// Comentário: 
        /// </summary>
        private string cgcent;
        [XmlElement(ElementName = "CGCENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgcent
        {
            get { return  cgcent; }
            set {  cgcent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE
        /// Comentário: 
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Cliente
        {
            get { return  cliente; }
            set {  cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODCLIPRINC
        /// Comentário: 
        /// </summary>
        private decimal codcliprinc;
        [XmlElement(ElementName = "CODCLIPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcliprinc
        {
            get { return  codcliprinc; }
            set {  codcliprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLISAP
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROCESSAMENTO
        /// Comentário: 
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
        /// Propriedade referente ao campo: ENDERENT
        /// Comentário: 
        /// </summary>
        private string enderent;
        [XmlElement(ElementName = "ENDERENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Enderent
        {
            get { return  enderent; }
            set {  enderent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTENT
        /// Comentário: 
        /// </summary>
        private string estent;
        [XmlElement(ElementName = "ESTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estent
        {
            get { return  estent; }
            set {  estent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FANTASIA
        /// Comentário: 
        /// </summary>
        private string fantasia;
        [XmlElement(ElementName = "FANTASIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Fantasia
        {
            get { return  fantasia; }
            set {  fantasia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEENT
        /// Comentário: 
        /// </summary>
        private string ieent;
        [XmlElement(ElementName = "IEENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ieent
        {
            get { return  ieent; }
            set {  ieent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICENT
        /// Comentário: 
        /// </summary>
        private string municent;
        [XmlElement(ElementName = "MUNICENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municent
        {
            get { return  municent; }
            set {  municent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGER
        /// Comentário: 
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
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: 
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
        /// Propriedade referente ao campo: TELENT
        /// Comentário: 
        /// </summary>
        private string telent;
        [XmlElement(ElementName = "TELENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telent
        {
            get { return  telent; }
            set {  telent = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmsclient()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSCLIENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmsclient> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsclient.GetStringConnection());
            return ba.Listar<PCWmsclient>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmsclient> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsclient.GetStringConnection());
            return ba.Existe<PCWmsclient>(where);
        }

        #endregion
    }
}
