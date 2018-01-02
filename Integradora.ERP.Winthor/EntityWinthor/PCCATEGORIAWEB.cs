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
    /// Classe referente a tabela PCCategoriaweb
    /// </summary>
    [XmlType("PCCATEGORIAWEB")]
    public class PCCategoriaweb : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Coment�rio: Codigo da Categoria
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSECAO
        /// Coment�rio: Codigo da Se��o
        /// </summary>
        private decimal codsecao;
        [XmlElement(ElementName = "CODSECAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codsecao
        {
            get { return  codsecao; }
            set {  codsecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o da Categoria
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
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
        public PCCategoriaweb()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCATEGORIAWEB";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCategoriaweb> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCategoriaweb>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCategoriaweb> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCategoriaweb>(where);
        }

        #endregion
    }
}
