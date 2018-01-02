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
    /// Classe referente a tabela PCAgrupamentonivel
    /// </summary>
    [XmlType("PCAGRUPAMENTONIVEL")]
    public class PCAgrupamentonivel : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGRUPAMENTO
        /// Comentário: 
        /// </summary>
        private decimal agrupamento;
        [XmlElement(ElementName = "AGRUPAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Agrupamento
        {
            get { return  agrupamento; }
            set {  agrupamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL
        /// Comentário: 
        /// </summary>
        private decimal nivel;
        [XmlElement(ElementName = "NIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Nivel
        {
            get { return  nivel; }
            set {  nivel = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAgrupamentonivel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGRUPAMENTONIVEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAgrupamentonivel> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgrupamentonivel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAgrupamentonivel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgrupamentonivel>(where);
        }

        #endregion
    }
}
