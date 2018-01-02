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
    /// Classe referente a tabela PCPedclogparametrospresidencia
    /// </summary>
    [XmlType("PCPEDCLOGPARAMETROSPRESIDENCIA")]
    public class PCPedclogparametrospresidencia : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: Identificador do Registro.
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPARAMETRO
        /// Comentário: Nome do parâmetro.
        /// </summary>
        private string nomeparametro;
        [XmlElement(ElementName = "NOMEPARAMETRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Nomeparametro
        {
            get { return  nomeparametro; }
            set {  nomeparametro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPARAMETRO
        /// Comentário: Valor parâmetro.
        /// </summary>
        private string valorparametro;
        [XmlElement(ElementName = "VALORPARAMETRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Valorparametro
        {
            get { return  valorparametro; }
            set {  valorparametro = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPedclogparametrospresidencia()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDCLOGPARAMETROSPRESIDENCIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPedclogparametrospresidencia> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedclogparametrospresidencia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPedclogparametrospresidencia> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedclogparametrospresidencia>(where);
        }

        #endregion
    }
}
