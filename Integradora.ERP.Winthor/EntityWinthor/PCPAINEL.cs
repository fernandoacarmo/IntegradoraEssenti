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
    /// Classe referente a tabela PCPainel
    /// </summary>
    [XmlType("PCPAINEL")]
    public class PCPainel : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO_PAINEL
        /// Coment�rio: C�digo do Painel.
        /// </summary>
        private string codigo_painel;
        [XmlElement(ElementName = "CODIGO_PAINEL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,45)]
        public string Codigo_Painel
        {
            get { return  codigo_painel; }
            set {  codigo_painel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO_PORTAL
        /// Coment�rio: C�digo Portal.
        /// </summary>
        private string codigo_portal;
        [XmlElement(ElementName = "CODIGO_PORTAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,45)]
        public string Codigo_Portal
        {
            get { return  codigo_portal; }
            set {  codigo_portal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_WIDGET
        /// Coment�rio: Id_widget.
        /// </summary>
        private decimal id_widget;
        [XmlElement(ElementName = "ID_WIDGET", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,22)]
        public decimal Id_Widget
        {
            get { return  id_widget; }
            set {  id_widget = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Coment�rio: Matricula.
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPainel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPAINEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPainel> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPainel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPainel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPainel>(where);
        }

        #endregion
    }
}
