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
    /// Classe referente a tabela PCSqls
    /// </summary>
    [XmlType("PCSQLS")]
    public class PCSqls : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Comentário: 
        /// </summary>
        private decimal codrelatorio;
        [XmlElement(ElementName = "CODRELATORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrelatorio
        {
            get { return  codrelatorio; }
            set {  codrelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSQL
        /// Comentário: 
        /// </summary>
        private decimal codsql;
        [XmlElement(ElementName = "CODSQL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codsql
        {
            get { return  codsql; }
            set {  codsql = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCAB
        /// Comentário: 
        /// </summary>
        private string descab;
        [XmlElement(ElementName = "DESCAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Descab
        {
            get { return  descab; }
            set {  descab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESFROM
        /// Comentário: 
        /// </summary>
        private string desfrom;
        [XmlElement(ElementName = "DESFROM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Desfrom
        {
            get { return  desfrom; }
            set {  desfrom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESORDER
        /// Comentário: 
        /// </summary>
        private string desorder;
        [XmlElement(ElementName = "DESORDER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Desorder
        {
            get { return  desorder; }
            set {  desorder = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESSELECT
        /// Comentário: 
        /// </summary>
        private string desselect;
        [XmlElement(ElementName = "DESSELECT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Desselect
        {
            get { return  desselect; }
            set {  desselect = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESWHERE
        /// Comentário: 
        /// </summary>
        private string deswhere;
        [XmlElement(ElementName = "DESWHERE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Deswhere
        {
            get { return  deswhere; }
            set {  deswhere = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMSQL
        /// Comentário: 
        /// </summary>
        private string nomsql;
        [XmlElement(ElementName = "NOMSQL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomsql
        {
            get { return  nomsql; }
            set {  nomsql = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSqls()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSQLS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSqls> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSqls>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSqls> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSqls>(where);
        }

        #endregion
    }
}
