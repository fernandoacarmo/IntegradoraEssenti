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
    /// Classe referente a tabela PCSubmodulo
    /// </summary>
    [XmlType("PCSUBMODULO")]
    public class PCSubmodulo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AUTMENU
        /// Comentário: 
        /// </summary>
        private decimal autmenu;
        [XmlElement(ElementName = "AUTMENU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Autmenu
        {
            get { return  autmenu; }
            set {  autmenu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMODULO
        /// Comentário: 
        /// </summary>
        private decimal codmodulo;
        [XmlElement(ElementName = "CODMODULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmodulo
        {
            get { return  codmodulo; }
            set {  codmodulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBMODULO
        /// Comentário: 
        /// </summary>
        private decimal codsubmodulo;
        [XmlElement(ElementName = "CODSUBMODULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codsubmodulo
        {
            get { return  codsubmodulo; }
            set {  codsubmodulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRMENU
        /// Comentário: 
        /// </summary>
        private string exibirmenu;
        [XmlElement(ElementName = "EXIBIRMENU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibirmenu
        {
            get { return  exibirmenu; }
            set {  exibirmenu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBMODULO
        /// Comentário: 
        /// </summary>
        private string submodulo;
        [XmlElement(ElementName = "SUBMODULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Submodulo
        {
            get { return  submodulo; }
            set {  submodulo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSubmodulo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSUBMODULO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSubmodulo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSubmodulo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSubmodulo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSubmodulo>(where);
        }

        #endregion
    }
}
