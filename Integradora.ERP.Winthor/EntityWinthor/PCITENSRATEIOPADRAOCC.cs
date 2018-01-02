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
    /// Classe referente a tabela PCItensrateiopadraocc
    /// </summary>
    [XmlType("PCITENSRATEIOPADRAOCC")]
    public class PCItensrateiopadraocc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGOCENTROCUSTO
        /// Comentário: Código do centro de custo
        /// </summary>
        private string codigocentrocusto;
        [XmlElement(ElementName = "CODIGOCENTROCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codigocentrocusto
        {
            get { return  codigocentrocusto; }
            set {  codigocentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRATEIOCC
        /// Comentário: Código do rateio padrão de Centro de Custo
        /// </summary>
        private decimal codrateiocc;
        [XmlElement(ElementName = "CODRATEIOCC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codrateiocc
        {
            get { return  codrateiocc; }
            set {  codrateiocc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUAL
        /// Comentário: Percentual de rateio para centro de custo
        /// </summary>
        private decimal percentual;
        [XmlElement(ElementName = "PERCENTUAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Percentual
        {
            get { return  percentual; }
            set {  percentual = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCItensrateiopadraocc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCITENSRATEIOPADRAOCC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCItensrateiopadraocc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCItensrateiopadraocc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCItensrateiopadraocc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCItensrateiopadraocc>(where);
        }

        #endregion
    }
}
