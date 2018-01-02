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
    /// Classe referente a tabela PCPrincipativo
    /// </summary>
    [XmlType("PCPRINCIPATIVO")]
    public class PCPrincipativo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPRINCIPATIVO
        /// Comentário: 
        /// </summary>
        private decimal codprincipativo;
        [XmlElement(ElementName = "CODPRINCIPATIVO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codprincipativo
        {
            get { return  codprincipativo; }
            set {  codprincipativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DCB
        /// Comentário: 
        /// </summary>
        private string dcb;
        [XmlElement(ElementName = "DCB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Dcb
        {
            get { return  dcb; }
            set {  dcb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO2
        /// Comentário: DESCRICAO2
        /// </summary>
        private string descricao2;
        [XmlElement(ElementName = "DESCRICAO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Descricao2
        {
            get { return  descricao2; }
            set {  descricao2 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPrincipativo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRINCIPATIVO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPrincipativo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrincipativo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPrincipativo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrincipativo>(where);
        }

        #endregion
    }
}
