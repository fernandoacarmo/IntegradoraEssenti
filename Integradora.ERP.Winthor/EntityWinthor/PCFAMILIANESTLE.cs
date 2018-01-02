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
    /// Classe referente a tabela PCFamilianestle
    /// </summary>
    [XmlType("PCFAMILIANESTLE")]
    public class PCFamilianestle : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFAMILIANESTLE
        /// Comentário: 
        /// </summary>
        private decimal codfamilianestle;
        [XmlElement(ElementName = "CODFAMILIANESTLE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codfamilianestle
        {
            get { return  codfamilianestle; }
            set {  codfamilianestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPONESTLE
        /// Comentário: 
        /// </summary>
        private decimal codgruponestle;
        [XmlElement(ElementName = "CODGRUPONESTLE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codgruponestle
        {
            get { return  codgruponestle; }
            set {  codgruponestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBGRUPONESTLE
        /// Comentário: 
        /// </summary>
        private decimal codsubgruponestle;
        [XmlElement(ElementName = "CODSUBGRUPONESTLE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codsubgruponestle
        {
            get { return  codsubgruponestle; }
            set {  codsubgruponestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFamilianestle()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFAMILIANESTLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFamilianestle> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFamilianestle>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFamilianestle> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFamilianestle>(where);
        }

        #endregion
    }
}
