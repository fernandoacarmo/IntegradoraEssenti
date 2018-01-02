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
    /// Classe referente a tabela PCAlienafornec
    /// </summary>
    [XmlType("PCALIENAFORNEC")]
    public class PCAlienafornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIENACAO
        /// Coment�rio: C�digo de aliena��o com o fornecedor.
        /// </summary>
        private string alienacao;
        [XmlElement(ElementName = "ALIENACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Alienacao
        {
            get { return  alienacao; }
            set {  alienacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CATEGORIA
        /// Coment�rio: C�digo da categoria: ramo atividade, pra�a, produto, etc.
        /// </summary>
        private decimal categoria;
        [XmlElement(ElementName = "CATEGORIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Categoria
        {
            get { return  categoria; }
            set {  categoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFWINTHOR
        /// Coment�rio: C�digo do Whinthor: ramo atividade, pra�a, produto,etc.
        /// </summary>
        private string refwinthor;
        [XmlElement(ElementName = "REFWINTHOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Refwinthor
        {
            get { return  refwinthor; }
            set {  refwinthor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAlienafornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCALIENAFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAlienafornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAlienafornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAlienafornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAlienafornec>(where);
        }

        #endregion
    }
}
