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
    /// Classe referente a tabela PCRateiopadraocc
    /// </summary>
    [XmlType("PCRATEIOPADRAOCC")]
    public class PCRateiopadraocc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Coment�rio: Define se o rateio padr�o de Centro de Custo est� ativo ou n�o
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRATEIOCC
        /// Coment�rio: C�digo do rateio padr�o de Centro de Custo
        /// </summary>
        private decimal codrateiocc;
        [XmlElement(ElementName = "CODRATEIOCC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codrateiocc
        {
            get { return  codrateiocc; }
            set {  codrateiocc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o do rateio padr�o de Centro de Custo
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,80)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o do rateio padr�o de Centro de Custo
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRateiopadraocc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRATEIOPADRAOCC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRateiopadraocc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRateiopadraocc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRateiopadraocc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRateiopadraocc>(where);
        }

        #endregion
    }
}
