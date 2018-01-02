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
    /// Classe referente a tabela PCEquifaxconf
    /// </summary>
    [XmlType("PCEQUIFAXCONF")]
    public class PCEquifaxconf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: SENHA
        /// Comentário: Senha do usuário de acesso ao equifax
        /// </summary>
        private string senha;
        [XmlElement(ElementName = "SENHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Senha
        {
            get { return  senha; }
            set {  senha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO
        /// Comentário: Nome do usuário de acesso ao equifax
        /// </summary>
        private string usuario;
        [XmlElement(ElementName = "USUARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Usuario
        {
            get { return  usuario; }
            set {  usuario = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEquifaxconf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEQUIFAXCONF";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEquifaxconf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEquifaxconf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEquifaxconf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEquifaxconf>(where);
        }

        #endregion
    }
}
