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
    /// Classe referente a tabela PCProdutobs
    /// </summary>
    [XmlType("PCPRODUTOBS")]
    public class PCProdutobs : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDOBS
        /// Coment�rio: C�digo sequencial.
        /// </summary>
        private decimal idobs;
        [XmlElement(ElementName = "IDOBS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Idobs
        {
            get { return  idobs; }
            set {  idobs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTO
        /// Coment�rio: Observa��o.
        /// </summary>
        private string texto;
        [XmlElement(ElementName = "TEXTO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Texto
        {
            get { return  texto; }
            set {  texto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOBS
        /// Coment�rio: Tipo da observa��o.
        /// </summary>
        private string tipoobs;
        [XmlElement(ElementName = "TIPOOBS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipoobs
        {
            get { return  tipoobs; }
            set {  tipoobs = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdutobs()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUTOBS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdutobs> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdutobs>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdutobs> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdutobs>(where);
        }

        #endregion
    }
}
