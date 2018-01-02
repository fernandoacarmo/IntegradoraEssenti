using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTFilialestado
    /// </summary>
    [XmlType("ESTFILIALESTADO")]
    public class ESTFilialestado : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALPRINCIPAL
        /// Coment�rio: 
        /// </summary>
        private string codfilialprincipal;
        [XmlElement(ElementName = "CODFILIALPRINCIPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialprincipal
        {
            get { return  codfilialprincipal; }
            set {  codfilialprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALSECUNDARIA
        /// Coment�rio: 
        /// </summary>
        private string codfilialsecundaria;
        [XmlElement(ElementName = "CODFILIALSECUNDARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialsecundaria
        {
            get { return  codfilialsecundaria; }
            set {  codfilialsecundaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRETIRAPRINCIPAL
        /// Coment�rio: 
        /// </summary>
        private string codretiraprincipal;
        [XmlElement(ElementName = "CODRETIRAPRINCIPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codretiraprincipal
        {
            get { return  codretiraprincipal; }
            set {  codretiraprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRETIRASECUNDARIA
        /// Coment�rio: 
        /// </summary>
        private string codretirasecundaria;
        [XmlElement(ElementName = "CODRETIRASECUNDARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codretirasecundaria
        {
            get { return  codretirasecundaria; }
            set {  codretirasecundaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Coment�rio: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Estado
        {
            get { return  estado; }
            set {  estado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTFilialestado()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTFILIALESTADO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTFilialestado> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTFilialestado.GetStringConnection());
            return ba.Listar<ESTFilialestado>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTFilialestado> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTFilialestado.GetStringConnection());
            return ba.Existe<ESTFilialestado>(where);
        }

        #endregion
    }
}
