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
    /// Classe referente a tabela PCVincularcstpiscofins
    /// </summary>
    [XmlType("PCVINCULARCSTPISCOFINS")]
    public class PCVincularcstpiscofins : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Codigo da Filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CSTTRANSPORTE
        /// Comentário: CST de transporte
        /// </summary>
        private decimal csttransporte;
        [XmlElement(ElementName = "CSTTRANSPORTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Csttransporte
        {
            get { return  csttransporte; }
            set {  csttransporte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CSTVENDA
        /// Comentário: CST de venda
        /// </summary>
        private decimal cstvenda;
        [XmlElement(ElementName = "CSTVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Cstvenda
        {
            get { return  cstvenda; }
            set {  cstvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOFINS
        /// Comentário: Percentual de cofins
        /// </summary>
        private decimal perccofins;
        [XmlElement(ElementName = "PERCCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perccofins
        {
            get { return  perccofins; }
            set {  perccofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPIS
        /// Comentário: Percentual de Pis
        /// </summary>
        private decimal percpis;
        [XmlElement(ElementName = "PERCPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percpis
        {
            get { return  percpis; }
            set {  percpis = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCVincularcstpiscofins()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVINCULARCSTPISCOFINS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCVincularcstpiscofins> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVincularcstpiscofins>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCVincularcstpiscofins> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVincularcstpiscofins>(where);
        }

        #endregion
    }
}
