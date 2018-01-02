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
    /// Classe referente a tabela Esvpermissoes
    /// </summary>
    [XmlType("ESVPERMISSOES")]
    public class Esvpermissoes : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACESSO
        /// Coment�rio: 
        /// </summary>
        private string acesso;
        [XmlElement(ElementName = "ACESSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Acesso
        {
            get { return  acesso; }
            set {  acesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPERMISSAO
        /// Coment�rio: 
        /// </summary>
        private decimal codpermissao;
        [XmlElement(ElementName = "CODPERMISSAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codpermissao
        {
            get { return  codpermissao; }
            set {  codpermissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMISSAO
        /// Coment�rio: 
        /// </summary>
        private string permissao;
        [XmlElement(ElementName = "PERMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Permissao
        {
            get { return  permissao; }
            set {  permissao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Esvpermissoes()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVPERMISSOES";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Esvpermissoes> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvpermissoes.GetStringConnection());
            return ba.Listar<Esvpermissoes>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Esvpermissoes> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvpermissoes.GetStringConnection());
            return ba.Existe<Esvpermissoes>(where);
        }

        #endregion
    }
}
