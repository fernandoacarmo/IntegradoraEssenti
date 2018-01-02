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
    /// Classe referente a tabela PCEmpenho
    /// </summary>
    [XmlType("PCEMPENHO")]
    public class PCEmpenho : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTRATO
        /// Comentário: 
        /// </summary>
        private decimal codcontrato;
        [XmlElement(ElementName = "CODCONTRATO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcontrato
        {
            get { return  codcontrato; }
            set {  codcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEMPENHO
        /// Comentário: 
        /// </summary>
        private string numempenho;
        [XmlElement(ElementName = "NUMEMPENHO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Numempenho
        {
            get { return  numempenho; }
            set {  numempenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLEMPENHO
        /// Comentário: 
        /// </summary>
        private decimal vlempenho;
        [XmlElement(ElementName = "VLEMPENHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlempenho
        {
            get { return  vlempenho; }
            set {  vlempenho = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEmpenho()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEMPENHO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEmpenho> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEmpenho>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEmpenho> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEmpenho>(where);
        }

        #endregion
    }
}
