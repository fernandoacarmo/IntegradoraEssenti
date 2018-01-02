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
    /// Classe referente a tabela PCReltranspimp
    /// </summary>
    [XmlType("PCRELTRANSPIMP")]
    public class PCReltranspimp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDESPESA
        /// Comentário: Código da despesa.
        /// </summary>
        private decimal coddespesa;
        [XmlElement(ElementName = "CODDESPESA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Coddespesa
        {
            get { return  coddespesa; }
            set {  coddespesa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVIA
        /// Comentário: Tipo de transporte.
        /// </summary>
        private decimal codvia;
        [XmlElement(ElementName = "CODVIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codvia
        {
            get { return  codvia; }
            set {  codvia = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCReltranspimp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRELTRANSPIMP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCReltranspimp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCReltranspimp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCReltranspimp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCReltranspimp>(where);
        }

        #endregion
    }
}
