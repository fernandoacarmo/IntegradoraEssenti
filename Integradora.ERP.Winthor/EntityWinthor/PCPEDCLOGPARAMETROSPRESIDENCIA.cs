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
        /// Coment�rio: Identificador do Registro.
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
        /// Coment�rio: Nome do par�metro.
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
        /// Coment�rio: Valor par�metro.
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPedclogparametrospresidencia> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedclogparametrospresidencia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
