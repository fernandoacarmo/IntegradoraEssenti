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
    /// Classe referente a tabela PCRedcomissaoi
    /// </summary>
    [XmlType("PCREDCOMISSAOI")]
    public class PCRedcomissaoi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO1
        /// Coment�rio: 
        /// </summary>
        private decimal codigo1;
        [XmlElement(ElementName = "CODIGO1", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo1
        {
            get { return  codigo1; }
            set {  codigo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO2
        /// Coment�rio: 
        /// </summary>
        private decimal codigo2;
        [XmlElement(ElementName = "CODIGO2", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo2
        {
            get { return  codigo2; }
            set {  codigo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDCOMISS
        /// Coment�rio: 
        /// </summary>
        private decimal codredcomiss;
        [XmlElement(ElementName = "CODREDCOMISS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codredcomiss
        {
            get { return  codredcomiss; }
            set {  codredcomiss = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRedcomissaoi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREDCOMISSAOI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRedcomissaoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRedcomissaoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRedcomissaoi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRedcomissaoi>(where);
        }

        #endregion
    }
}
