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
    /// Classe referente a tabela PCConsultarapida_filtro
    /// </summary>
    [XmlType("PCCONSULTARAPIDA_FILTRO")]
    public class PCConsultarapida_filtro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONSULTARAPIDA
        /// Comentário: 
        /// </summary>
        private decimal codconsultarapida;
        [XmlElement(ElementName = "CODCONSULTARAPIDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codconsultarapida
        {
            get { return  codconsultarapida; }
            set {  codconsultarapida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILTRO
        /// Comentário: 
        /// </summary>
        private string filtro;
        [XmlElement(ElementName = "FILTRO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Filtro
        {
            get { return  filtro; }
            set {  filtro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SCRIPTFILTRO
        /// Comentário: 
        /// </summary>
        private string scriptfiltro;
        [XmlElement(ElementName = "SCRIPTFILTRO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,500)]
        public string Scriptfiltro
        {
            get { return  scriptfiltro; }
            set {  scriptfiltro = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConsultarapida_filtro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONSULTARAPIDA_FILTRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConsultarapida_filtro> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConsultarapida_filtro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConsultarapida_filtro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConsultarapida_filtro>(where);
        }

        #endregion
    }
}
