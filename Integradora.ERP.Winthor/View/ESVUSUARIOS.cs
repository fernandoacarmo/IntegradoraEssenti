using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvusuarios
    /// </summary>
    [XmlType("ESVUSUARIOS")]
    public class Esvusuarios : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIO
        /// Comentário: 
        /// </summary>
        private decimal codusuario;
        [XmlElement(ElementName = "CODUSUARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codusuario
        {
            get { return  codusuario; }
            set {  codusuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVENDEDOR
        /// Comentário: 
        /// </summary>
        private decimal codvendedor;
        [XmlElement(ElementName = "CODVENDEDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codvendedor
        {
            get { return  codvendedor; }
            set {  codvendedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGIN
        /// Comentário: 
        /// </summary>
        private string login;
        [XmlElement(ElementName = "LOGIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Login
        {
            get { return  login; }
            set {  login = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHA
        /// Comentário: 
        /// </summary>
        private string senha;
        [XmlElement(ElementName = "SENHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO
        /// Comentário: 
        /// </summary>
        private string usuario;
        [XmlElement(ElementName = "USUARIO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
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
        public Esvusuarios()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVUSUARIOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvusuarios> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvusuarios.GetStringConnection());
            return ba.Listar<Esvusuarios>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvusuarios> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvusuarios.GetStringConnection());
            return ba.Existe<Esvusuarios>(where);
        }

        #endregion
    }
}
