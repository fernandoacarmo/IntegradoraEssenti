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
    /// Classe referente a tabela PCSubmarca
    /// </summary>
    [XmlType("PCSUBMARCA")]
    public class PCSubmarca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Comentário: Marca do Produto
        /// </summary>
        private decimal codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmarca
        {
            get { return  codmarca; }
            set {  codmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBMARCA
        /// Comentário: Código da submarca do produto
        /// </summary>
        private decimal codsubmarca;
        [XmlElement(ElementName = "CODSUBMARCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codsubmarca
        {
            get { return  codsubmarca; }
            set {  codsubmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCSUBMARCA
        /// Comentário: Descrição da submarca do produto
        /// </summary>
        private string descsubmarca;
        [XmlElement(ElementName = "DESCSUBMARCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descsubmarca
        {
            get { return  descsubmarca; }
            set {  descsubmarca = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSubmarca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSUBMARCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSubmarca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSubmarca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSubmarca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSubmarca>(where);
        }

        #endregion
    }
}
