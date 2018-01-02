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
    /// Classe referente a tabela PCContabil
    /// </summary>
    [XmlType("PCCONTABIL")]
    public class PCContabil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACRED
        /// Comentário: 
        /// </summary>
        private string codcontacred;
        [XmlElement(ElementName = "CODCONTACRED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Codcontacred
        {
            get { return  codcontacred; }
            set {  codcontacred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADEB
        /// Comentário: 
        /// </summary>
        private string codcontadeb;
        [XmlElement(ElementName = "CODCONTADEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Codcontadeb
        {
            get { return  codcontadeb; }
            set {  codcontadeb = value; }
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
        /// Propriedade referente ao campo: CODFILIALORIG
        /// Comentário: 
        /// </summary>
        private string codfilialorig;
        [XmlElement(ElementName = "CODFILIALORIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialorig
        {
            get { return  codfilialorig; }
            set {  codfilialorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHIST
        /// Comentário: 
        /// </summary>
        private decimal codhist;
        [XmlElement(ElementName = "CODHIST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codhist
        {
            get { return  codhist; }
            set {  codhist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLOTE
        /// Comentário: 
        /// </summary>
        private decimal codlote;
        [XmlElement(ElementName = "CODLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlote
        {
            get { return  codlote; }
            set {  codlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: 
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCUMENTO
        /// Comentário: 
        /// </summary>
        private string documento;
        [XmlElement(ElementName = "DOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Documento
        {
            get { return  documento; }
            set {  documento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANC
        /// Comentário: 
        /// </summary>
        private decimal numlanc;
        [XmlElement(ElementName = "NUMLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numlanc
        {
            get { return  numlanc; }
            set {  numlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIA
        /// Comentário: 
        /// </summary>
        private string referencia;
        [XmlElement(ElementName = "REFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Referencia
        {
            get { return  referencia; }
            set {  referencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCContabil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTABIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCContabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCContabil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContabil>(where);
        }

        #endregion
    }
}
