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
    /// Classe referente a tabela PCNfentpiscofins
    /// </summary>
    [XmlType("PCNFENTPISCOFINS")]
    public class PCNfentpiscofins : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Comentário: Código situação tributária PIS/COFINS
        /// </summary>
        private decimal codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATCREDITO
        /// Comentário: Natureza de Crédito de PIS/COFINS das notas fiscais de serviços adquiridos.
        /// </summary>
        private string natcredito;
        [XmlElement(ElementName = "NATCREDITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Natcredito
        {
            get { return  natcredito; }
            set {  natcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: Número transação de entrada
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSPISCOFINS
        /// Comentário: Número de transação de PIS/COFINS.
        /// </summary>
        private decimal numtranspiscofins;
        [XmlElement(ElementName = "NUMTRANSPISCOFINS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtranspiscofins
        {
            get { return  numtranspiscofins; }
            set {  numtranspiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Comentário: Valor do percentual do COFINS
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Comentário: Valor do percentual do PIS
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASECOFINS
        /// Comentário: Valor da base COFINS
        /// </summary>
        private decimal vlbasecofins;
        [XmlElement(ElementName = "VLBASECOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasecofins
        {
            get { return  vlbasecofins; }
            set {  vlbasecofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEPIS
        /// Comentário: Valor da base PIS
        /// </summary>
        private decimal vlbasepis;
        [XmlElement(ElementName = "VLBASEPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbasepis
        {
            get { return  vlbasepis; }
            set {  vlbasepis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Comentário: Valor do Cofins
        /// </summary>
        private decimal vlcofins;
        [XmlElement(ElementName = "VLCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofins
        {
            get { return  vlcofins; }
            set {  vlcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Comentário: Valor do Pis
        /// </summary>
        private decimal vlpis;
        [XmlElement(ElementName = "VLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpis
        {
            get { return  vlpis; }
            set {  vlpis = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNfentpiscofins()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFENTPISCOFINS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNfentpiscofins> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfentpiscofins>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNfentpiscofins> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfentpiscofins>(where);
        }

        #endregion
    }
}
