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
    /// Classe referente a tabela PCParamrotulo
    /// </summary>
    [XmlType("PCPARAMROTULO")]
    public class PCParamrotulo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: Identificador do rótulo.
        /// </summary>
        private string id;
        [XmlElement(ElementName = "ID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEEDITOR
        /// Comentário: Como o rótulo será apresentado: RADIOBUTTON, COMBOBOX ou CHECKBOX.
        /// </summary>
        private string nomeeditor;
        [XmlElement(ElementName = "NOMEEDITOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,30)]
        public string Nomeeditor
        {
            get { return  nomeeditor; }
            set {  nomeeditor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCHECKED
        /// Comentário: Se o NOMEEDITOR for "CHECKBOX", qual valor do rótulo será o Checked.
        /// </summary>
        private string valorchecked;
        [XmlElement(ElementName = "VALORCHECKED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Valorchecked
        {
            get { return  valorchecked; }
            set {  valorchecked = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDEFAULT
        /// Comentário: Valor padrão se o usuário não selecionar nenhum dos valores do rótulo.
        /// </summary>
        private string valordefault;
        [XmlElement(ElementName = "VALORDEFAULT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Valordefault
        {
            get { return  valordefault; }
            set {  valordefault = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCParamrotulo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARAMROTULO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCParamrotulo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParamrotulo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCParamrotulo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParamrotulo>(where);
        }

        #endregion
    }
}
