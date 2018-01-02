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
    /// Classe referente a tabela PCModulo
    /// </summary>
    [XmlType("PCMODULO")]
    public class PCModulo : OracleTable
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
        /// Propriedade referente ao campo: DTULTVERSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtultversao;
        [XmlElement(ElementName = "DTULTVERSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultversao
        {
            get { return  dtultversao; }
            set {  dtultversao = value; }
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
        /// Propriedade referente ao campo: MODULO
        /// Comentário: 
        /// </summary>
        private string modulo;
        [XmlElement(ElementName = "MODULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Modulo
        {
            get { return  modulo; }
            set {  modulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERSAO
        /// Comentário: 
        /// </summary>
        private decimal numversao;
        [XmlElement(ElementName = "NUMVERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numversao
        {
            get { return  numversao; }
            set {  numversao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCModulo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMODULO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCModulo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCModulo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCModulo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCModulo>(where);
        }

        #endregion
    }
}
