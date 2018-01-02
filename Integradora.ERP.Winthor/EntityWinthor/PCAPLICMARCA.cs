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
    /// Classe referente a tabela PCAplicmarca
    /// </summary>
    [XmlType("PCAPLICMARCA")]
    public class PCAplicmarca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Indica a descri��o da marca
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDMARCA
        /// Coment�rio: Indica o identificador da marca.
        /// </summary>
        private decimal idmarca;
        [XmlElement(ElementName = "IDMARCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Idmarca
        {
            get { return  idmarca; }
            set {  idmarca = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAplicmarca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAPLICMARCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAplicmarca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAplicmarca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAplicmarca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAplicmarca>(where);
        }

        #endregion
    }
}
