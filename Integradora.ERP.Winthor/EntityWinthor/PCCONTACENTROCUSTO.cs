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
    /// Classe referente a tabela PCContacentrocusto
    /// </summary>
    [XmlType("PCCONTACENTROCUSTO")]
    public class PCContacentrocusto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCENTROCUSTO
        /// Coment�rio: C�digo do Centro de Custo.
        /// </summary>
        private decimal codcentrocusto;
        [XmlElement(ElementName = "CODCENTROCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcentrocusto
        {
            get { return  codcentrocusto; }
            set {  codcentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: C�digo da Conta Gerencial.
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOCENTROCUSTO
        /// Coment�rio: C�digo do centro de custo
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
        /// Propriedade referente ao campo: PERCRATEIO
        /// Coment�rio: Percentual de Rateio do lan�amento.
        /// </summary>
        private decimal percrateio;
        [XmlElement(ElementName = "PERCRATEIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Percrateio
        {
            get { return  percrateio; }
            set {  percrateio = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCContacentrocusto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTACENTROCUSTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCContacentrocusto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContacentrocusto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCContacentrocusto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContacentrocusto>(where);
        }

        #endregion
    }
}
