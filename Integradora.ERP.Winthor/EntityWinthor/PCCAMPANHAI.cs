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
    /// Classe referente a tabela PCCampanhai
    /// </summary>
    [XmlType("PCCAMPANHAI")]
    public class PCCampanhai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCAMPANHA
        /// Coment�rio: Indica o c�digo da campanha de venda.
        /// </summary>
        private decimal codcampanha;
        [XmlElement(ElementName = "CODCAMPANHA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcampanha
        {
            get { return  codcampanha; }
            set {  codcampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: Indica o c�digo do fornecedor do produto.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Indica o c�digo do produto pertencente � campanha de vendas.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGATORIO
        /// Coment�rio: Indica se este produto ser� ou n�o obrigat�rio a venda para considerar como cliente positivado.
        /// </summary>
        private string obrigatorio;
        [XmlElement(ElementName = "OBRIGATORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigatorio
        {
            get { return  obrigatorio; }
            set {  obrigatorio = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCampanhai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCAMPANHAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCampanhai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCampanhai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCampanhai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCampanhai>(where);
        }

        #endregion
    }
}
