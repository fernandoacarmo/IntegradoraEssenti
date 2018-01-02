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
    /// Classe referente a tabela PCLocalinventario
    /// </summary>
    [XmlType("PCLOCALINVENTARIO")]
    public class PCLocalinventario : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODLOCAL
        /// Comentário: Indica o código do local .
        /// </summary>
        private string codlocal;
        [XmlElement(ElementName = "CODLOCAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codlocal
        {
            get { return  codlocal; }
            set {  codlocal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCAL
        /// Comentário: Indica o descrição do local.
        /// </summary>
        private string local;
        [XmlElement(ElementName = "LOCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Local
        {
            get { return  local; }
            set {  local = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLocalinventario()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLOCALINVENTARIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLocalinventario> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLocalinventario>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLocalinventario> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLocalinventario>(where);
        }

        #endregion
    }
}
