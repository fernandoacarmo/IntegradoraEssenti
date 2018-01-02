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
    /// Classe referente a tabela PCDmplhistorico
    /// </summary>
    [XmlType("PCDMPLHISTORICO")]
    public class PCDmplhistorico : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDMPL
        /// Comentário: Código DMPL
        /// </summary>
        private decimal coddmpl;
        [XmlElement(ElementName = "CODDMPL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Coddmpl
        {
            get { return  coddmpl; }
            set {  coddmpl = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHIST
        /// Comentário: Código Histórico
        /// </summary>
        private string codhist;
        [XmlElement(ElementName = "CODHIST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codhist
        {
            get { return  codhist; }
            set {  codhist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: Descrição
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDmplhistorico()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDMPLHISTORICO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDmplhistorico> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDmplhistorico>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDmplhistorico> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDmplhistorico>(where);
        }

        #endregion
    }
}
