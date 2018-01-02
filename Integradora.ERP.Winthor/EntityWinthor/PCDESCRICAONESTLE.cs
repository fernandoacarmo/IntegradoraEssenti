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
    /// Classe referente a tabela PCDescricaonestle
    /// </summary>
    [XmlType("PCDESCRICAONESTLE")]
    public class PCDescricaonestle : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Coment�rio: C�digo da categoria.
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHANESTLE
        /// Coment�rio: C�digo da linha Nestl�.
        /// </summary>
        private decimal codlinhanestle;
        [XmlElement(ElementName = "CODLINHANESTLE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codlinhanestle
        {
            get { return  codlinhanestle; }
            set {  codlinhanestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNESTLE
        /// Coment�rio: C�digo de produtos terceiros, segmentos, etc.
        /// </summary>
        private string codnestle;
        [XmlElement(ElementName = "CODNESTLE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Codnestle
        {
            get { return  codnestle; }
            set {  codnestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o de produtos terceiros, segmentos, etc.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDescricaonestle()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESCRICAONESTLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDescricaonestle> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDescricaonestle>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDescricaonestle> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDescricaonestle>(where);
        }

        #endregion
    }
}
