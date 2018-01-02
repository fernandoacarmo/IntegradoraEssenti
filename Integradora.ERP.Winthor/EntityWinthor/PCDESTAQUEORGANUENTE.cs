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
    /// Classe referente a tabela PCDestaqueorganuente
    /// </summary>
    [XmlType("PCDESTAQUEORGANUENTE")]
    public class PCDestaqueorganuente : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODORGAOANUENTE
        /// Comentário: Descrição do Orgãos Anuentes
        /// </summary>
        private string codorgaoanuente;
        [XmlElement(ElementName = "CODORGAOANUENTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public string Codorgaoanuente
        {
            get { return  codorgaoanuente; }
            set {  codorgaoanuente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIO
        /// Comentário: Código do usuário que fez o finculo
        /// </summary>
        private decimal codusuario;
        [XmlElement(ElementName = "CODUSUARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuario
        {
            get { return  codusuario; }
            set {  codusuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data do Vinculo
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
        /// Propriedade referente ao campo: IDDESTAQUE
        /// Comentário: Código do Orgãos Anuentes
        /// </summary>
        private string iddestaque;
        [XmlElement(ElementName = "IDDESTAQUE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public string Iddestaque
        {
            get { return  iddestaque; }
            set {  iddestaque = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDestaqueorganuente()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESTAQUEORGANUENTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDestaqueorganuente> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDestaqueorganuente>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDestaqueorganuente> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDestaqueorganuente>(where);
        }

        #endregion
    }
}
