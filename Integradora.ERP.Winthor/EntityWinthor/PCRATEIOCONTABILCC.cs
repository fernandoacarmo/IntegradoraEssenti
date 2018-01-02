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
    /// Classe referente a tabela PCRateiocontabilcc
    /// </summary>
    [XmlType("PCRATEIOCONTABILCC")]
    public class PCRateiocontabilcc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código filial do rateio
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
        /// Propriedade referente ao campo: CODIGOCENTROCUSTO
        /// Comentário: Código do centro de custo
        /// </summary>
        private string codigocentrocusto;
        [XmlElement(ElementName = "CODIGOCENTROCUSTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codigocentrocusto
        {
            get { return  codigocentrocusto; }
            set {  codigocentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZA
        /// Comentário: Natureza do lançamento contábil
        /// </summary>
        private string natureza;
        [XmlElement(ElementName = "NATUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Natureza
        {
            get { return  natureza; }
            set {  natureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSLANCTO
        /// Comentário: Núm. Trans. Lancto contábil
        /// </summary>
        private decimal numtranslancto;
        [XmlElement(ElementName = "NUMTRANSLANCTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,38)]
        public decimal Numtranslancto
        {
            get { return  numtranslancto; }
            set {  numtranslancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCRATEIO
        /// Comentário: Percentual do rateio
        /// </summary>
        private decimal percrateio;
        [XmlElement(ElementName = "PERCRATEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percrateio
        {
            get { return  percrateio; }
            set {  percrateio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Valor do rateio
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRateiocontabilcc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRATEIOCONTABILCC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRateiocontabilcc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRateiocontabilcc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRateiocontabilcc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRateiocontabilcc>(where);
        }

        #endregion
    }
}
