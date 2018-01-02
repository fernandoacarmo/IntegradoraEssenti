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
    /// Classe referente a tabela PCTipotab
    /// </summary>
    [XmlType("PCTIPOTAB")]
    public class PCTipotab : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODTABELA
        /// Comentário: 
        /// </summary>
        private decimal codtabela;
        [XmlElement(ElementName = "CODTABELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codtabela
        {
            get { return  codtabela; }
            set {  codtabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMETABELA
        /// Comentário: 
        /// </summary>
        private string nometabela;
        [XmlElement(ElementName = "NOMETABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Nometabela
        {
            get { return  nometabela; }
            set {  nometabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SQLTABELA
        /// Comentário: 
        /// </summary>
        private string sqltabela;
        [XmlElement(ElementName = "SQLTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Sqltabela
        {
            get { return  sqltabela; }
            set {  sqltabela = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTipotab()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOTAB";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTipotab> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipotab>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTipotab> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipotab>(where);
        }

        #endregion
    }
}
