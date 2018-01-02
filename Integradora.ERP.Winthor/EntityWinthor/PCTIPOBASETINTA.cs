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
    /// Classe referente a tabela PCTipobasetinta
    /// </summary>
    [XmlType("PCTIPOBASETINTA")]
    public class PCTipobasetinta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBASETIPO
        /// Comentário: CÓD. DO TIPO DE BASE DA TINTA
        /// </summary>
        private string codbasetipo;
        [XmlElement(ElementName = "CODBASETIPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Codbasetipo
        {
            get { return  codbasetipo; }
            set {  codbasetipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Comentário: MÁQUINA DO TIPO DE BASE DA TINTA
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
        /// Propriedade referente ao campo: DESBASETIPO
        /// Comentário: DESCRIÇÃO DO TIPO DE BASE DA TINTA
        /// </summary>
        private string desbasetipo;
        [XmlElement(ElementName = "DESBASETIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Desbasetipo
        {
            get { return  desbasetipo; }
            set {  desbasetipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTipobasetinta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOBASETINTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTipobasetinta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipobasetinta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTipobasetinta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipobasetinta>(where);
        }

        #endregion
    }
}
