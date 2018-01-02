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
    /// Classe referente a tabela PCCentrocustoproducao
    /// </summary>
    [XmlType("PCCENTROCUSTOPRODUCAO")]
    public class PCCentrocustoproducao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCENTROCUSTO
        /// Coment�rio: C�digo do Centro de Custo
        /// </summary>
        private decimal codcentrocusto;
        [XmlElement(ElementName = "CODCENTROCUSTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcentrocusto
        {
            get { return  codcentrocusto; }
            set {  codcentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCCTCUSTO
        /// Coment�rio: Descri��o do Centro de Custo
        /// </summary>
        private string descctcusto;
        [XmlElement(ElementName = "DESCCTCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descctcusto
        {
            get { return  descctcusto; }
            set {  descctcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Situa��o do Centro de Custo
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCentrocustoproducao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCENTROCUSTOPRODUCAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCentrocustoproducao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCentrocustoproducao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCentrocustoproducao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCentrocustoproducao>(where);
        }

        #endregion
    }
}
