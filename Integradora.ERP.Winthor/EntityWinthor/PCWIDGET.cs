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
    /// Classe referente a tabela PCWidget
    /// </summary>
    [XmlType("PCWIDGET")]
    public class PCWidget : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODE_ROTINA
        /// Comentário: Código da rotina vinculada.
        /// </summary>
        private string code_rotina;
        [XmlElement(ElementName = "CODE_ROTINA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,45)]
        public string Code_Rotina
        {
            get { return  code_rotina; }
            set {  code_rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID_WIDGET
        /// Comentário: Identificador único.
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
        /// Propriedade referente ao campo: MODEL
        /// Comentário: Parâmetros default ou salvos pelo usuário.
        /// </summary>
        private string model;
        [XmlElement(ElementName = "MODEL", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Model
        {
            get { return  model; }
            set {  model = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: Nome do widget.
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWidget()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWIDGET";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWidget> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCWidget>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWidget> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCWidget>(where);
        }

        #endregion
    }
}
