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
    /// Classe referente a tabela PCLicencahash
    /// </summary>
    [XmlType("PCLICENCAHASH")]
    public class PCLicencahash : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: HASH
        /// Coment�rio: Hash da tabela PCLICENCAHASH
        /// </summary>
        private string hash;
        [XmlElement(ElementName = "HASH", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Hash
        {
            get { return  hash; }
            set {  hash = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LICENCA
        /// Coment�rio: Hash da tabela PCLICENCA
        /// </summary>
        private string licenca;
        [XmlElement(ElementName = "LICENCA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Licenca
        {
            get { return  licenca; }
            set {  licenca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LICENCAPERFIL
        /// Coment�rio: Hash da tabela PCLICENCAROTINA
        /// </summary>
        private string licencaperfil;
        [XmlElement(ElementName = "LICENCAPERFIL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Licencaperfil
        {
            get { return  licencaperfil; }
            set {  licencaperfil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUTO
        /// Coment�rio: Hash da tabela PCLICENCAPRODUTO
        /// </summary>
        private string produto;
        [XmlElement(ElementName = "PRODUTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Produto
        {
            get { return  produto; }
            set {  produto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SESSAO
        /// Coment�rio: Hash da tabela PCUSUARIOSESSAO
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
        /// Propriedade referente ao campo: USUARIO
        /// Coment�rio: Hash da tabela PCUSUARIOLICENCA
        /// </summary>
        private string usuario;
        [XmlElement(ElementName = "USUARIO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Usuario
        {
            get { return  usuario; }
            set {  usuario = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLicencahash()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLICENCAHASH";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLicencahash> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLicencahash>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLicencahash> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLicencahash>(where);
        }

        #endregion
    }
}
