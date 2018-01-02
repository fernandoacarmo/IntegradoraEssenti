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
    /// Classe referente a tabela PCDicionario
    /// </summary>
    [XmlType("PCDICIONARIO")]
    public class PCDicionario : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o da tabela
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data de cadastro
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEOBJETO
        /// Coment�rio: Nome da tabela
        /// </summary>
        private string nomeobjeto;
        [XmlElement(ElementName = "NOMEOBJETO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomeobjeto
        {
            get { return  nomeobjeto; }
            set {  nomeobjeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SQLEXCLUSAO
        /// Coment�rio: 
        /// </summary>
        private string sqlexclusao;
        [XmlElement(ElementName = "SQLEXCLUSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Sqlexclusao
        {
            get { return  sqlexclusao; }
            set {  sqlexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SQLOBTEMREGEXCLUIDO
        /// Coment�rio: SQL usado na pesquisa para obter os registros exclu�dos. Se vazio indica que os registros s�o exclu�dos fisicamente
        /// </summary>
        private string sqlobtemregexcluido;
        [XmlElement(ElementName = "SQLOBTEMREGEXCLUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Sqlobtemregexcluido
        {
            get { return  sqlobtemregexcluido; }
            set {  sqlobtemregexcluido = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDicionario()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDICIONARIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDicionario> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDicionario>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDicionario> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDicionario>(where);
        }

        #endregion
    }
}
