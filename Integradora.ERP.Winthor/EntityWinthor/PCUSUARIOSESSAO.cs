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
    /// Classe referente a tabela PCUsuariosessao
    /// </summary>
    [XmlType("PCUSUARIOSESSAO")]
    public class PCUsuariosessao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Coment�rio: Ordem das sess�es
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SESSAO
        /// Coment�rio: Identificador da Sess�o
        /// </summary>
        private string sessao;
        [XmlElement(ElementName = "SESSAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Sessao
        {
            get { return  sessao; }
            set {  sessao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOID
        /// Coment�rio: Identificador do usu�rio
        /// </summary>
        private string usuarioid;
        [XmlElement(ElementName = "USUARIOID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Usuarioid
        {
            get { return  usuarioid; }
            set {  usuarioid = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCUsuariosessao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCUSUARIOSESSAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCUsuariosessao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCUsuariosessao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCUsuariosessao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCUsuariosessao>(where);
        }

        #endregion
    }
}
