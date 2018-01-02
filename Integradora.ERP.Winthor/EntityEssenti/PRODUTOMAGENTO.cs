using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela Produtomagento
    /// </summary>
    [XmlType("PRODUTOMAGENTO")]
    public class ProdutoMagento : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 200)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EAN
        /// Comentário: 
        /// </summary>
        private decimal ean;
        [XmlElement(ElementName = "EAN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 16)]
        public decimal Ean
        {
            get { return ean; }
            set { ean = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUCT_ID
        /// Comentário: 
        /// </summary>
        private decimal product_id;
        [XmlElement(ElementName = "PRODUCT_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Product_Id
        {
            get { return product_id; }
            set { product_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SKU
        /// Comentário: 
        /// </summary>
        private decimal sku;
        [XmlElement(ElementName = "SKU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Sku
        {
            get { return sku; }
            set { sku = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 1)]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ProdutoMagento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PRODUTOMAGENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ProdutoMagento> Listar(string where)
        {
            Persistencia ba = new Persistencia(ProdutoMagento.GetStringConnection());
            return ba.Listar<ProdutoMagento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ProdutoMagento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ProdutoMagento.GetStringConnection());
            return ba.Existe<ProdutoMagento>(where);
        }

        #endregion
    }
}
