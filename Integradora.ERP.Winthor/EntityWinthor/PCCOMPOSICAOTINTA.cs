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
    /// Classe referente a tabela PCComposicaotinta
    /// </summary>
    [XmlType("PCCOMPOSICAOTINTA")]
    public class PCComposicaotinta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Comentário: 
        /// </summary>
        private decimal codmaquina;
        [XmlElement(ElementName = "CODMAQUINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmaquina
        {
            get { return  codmaquina; }
            set {  codmaquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTCOMP
        /// Comentário: 
        /// </summary>
        private string codtcomp;
        [XmlElement(ElementName = "CODTCOMP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codtcomp
        {
            get { return  codtcomp; }
            set {  codtcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCTCOMP
        /// Comentário: 
        /// </summary>
        private string desctcomp;
        [XmlElement(ElementName = "DESCTCOMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,70)]
        public string Desctcomp
        {
            get { return  desctcomp; }
            set {  desctcomp = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCComposicaotinta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMPOSICAOTINTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCComposicaotinta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComposicaotinta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCComposicaotinta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComposicaotinta>(where);
        }

        #endregion
    }
}
