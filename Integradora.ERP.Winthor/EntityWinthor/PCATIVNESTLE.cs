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
    /// Classe referente a tabela PCAtivnestle
    /// </summary>
    [XmlType("PCATIVNESTLE")]
    public class PCAtivnestle : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODATIVI
        /// Comentário: 
        /// </summary>
        private decimal codativi;
        [XmlElement(ElementName = "CODATIVI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codativi
        {
            get { return  codativi; }
            set {  codativi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAMO
        /// Comentário: 
        /// </summary>
        private string ramo;
        [XmlElement(ElementName = "RAMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Ramo
        {
            get { return  ramo; }
            set {  ramo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAtivnestle()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCATIVNESTLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAtivnestle> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAtivnestle>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAtivnestle> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAtivnestle>(where);
        }

        #endregion
    }
}
