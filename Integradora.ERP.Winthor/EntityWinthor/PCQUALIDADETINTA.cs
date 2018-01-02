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
    /// Classe referente a tabela PCQualidadetinta
    /// </summary>
    [XmlType("PCQUALIDADETINTA")]
    public class PCQualidadetinta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODLINHA
        /// Comentário: 
        /// </summary>
        private string codlinha;
        [XmlElement(ElementName = "CODLINHA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codlinha
        {
            get { return  codlinha; }
            set {  codlinha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Comentário: 
        /// </summary>
        private decimal codmaquina;
        [XmlElement(ElementName = "CODMAQUINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmaquina
        {
            get { return  codmaquina; }
            set {  codmaquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODQUALIDADE
        /// Comentário: 
        /// </summary>
        private string codqualidade;
        [XmlElement(ElementName = "CODQUALIDADE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codqualidade
        {
            get { return  codqualidade; }
            set {  codqualidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCQUALIDADE
        /// Comentário: 
        /// </summary>
        private string descqualidade;
        [XmlElement(ElementName = "DESCQUALIDADE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,70)]
        public string Descqualidade
        {
            get { return  descqualidade; }
            set {  descqualidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLAQUALIDADE
        /// Comentário: 
        /// </summary>
        private string siglaqualidade;
        [XmlElement(ElementName = "SIGLAQUALIDADE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public string Siglaqualidade
        {
            get { return  siglaqualidade; }
            set {  siglaqualidade = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCQualidadetinta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCQUALIDADETINTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCQualidadetinta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCQualidadetinta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCQualidadetinta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCQualidadetinta>(where);
        }

        #endregion
    }
}
