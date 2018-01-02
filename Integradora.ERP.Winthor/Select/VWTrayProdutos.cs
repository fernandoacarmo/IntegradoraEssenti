using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.Select
{
    /// <summary>
    /// Classe referente ao select VWTrayProdutos
    /// </summary>
    [XmlType("VWTRAYPRODUTOS")]
    public class VWTrayProdutos : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWTrayProdutos()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWTrayProdutos> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWTrayProdutos.GetStringConnection());
            return ba.Listar<VWTrayProdutos>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWTrayProdutos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWTrayProdutos.GetStringConnection());
            return ba.Existe<VWTrayProdutos>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            string script = "";

            script = string.Format(@"SELECT B.* 
                                       FROM VWTRAYPRODUTOS B
                                      WHERE 1=1 ");

            return script;
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public string Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Codauxiliar
        {
            get { return codauxiliar; }
            set { codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRICE
        /// Comentário: 
        /// </summary>
        private decimal price;
        [XmlElement(ElementName = "PRICE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COST_PRICE
        /// Comentário: 
        /// </summary>
        private decimal cost_price;
        [XmlElement(ElementName = "COST_PRICE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Cost_price
        {
            get { return cost_price; }
            set { cost_price = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROMOTIONAL_PRICE
        /// Comentário: 
        /// </summary>
        private decimal promotional_price;
        [XmlElement(ElementName = "PROMOTIONAL_PRICE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Promotional_price
        {
            get { return promotional_price; }
            set { promotional_price = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codprod
        {
            get { return codprod; }
            set { codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SKU
        /// Comentário: 
        /// </summary>
        private decimal sku;
        [XmlElement(ElementName = "SKU", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal SKU
        {
            get { return sku; }
            set { sku = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARCA
        /// Comentário: 
        /// </summary>
        private string marca;
        [XmlElement(ElementName = "MARCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: 
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 12)]
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRIPTION
        /// Comentário: 
        /// </summary>
        private string description;
        [XmlElement(ElementName = "DESCRIPTION", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRIPTION_SMALL
        /// Comentário: 
        /// </summary>
        private string description_small;
        [XmlElement(ElementName = "DESCRIPTION_SMALL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Description_small
        {
            get { return description_small; }
            set { description_small = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Pvenda
        {
            get { return pvenda; }
            set { pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal qtestoque;
        [XmlElement(ElementName = "QTESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Qtestoque
        {
            get { return qtestoque; }
            set { qtestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RID
        /// Comentário: 
        /// </summary>
        private string rid;
        [XmlElement(ElementName = "RID", DataType = "ROWID", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public string Rid
        {
            get { return rid; }
            set { rid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: START_PROMOTION
        /// Comentário: 
        /// </summary>
        private DateTime? start_promotion;
        [XmlElement(ElementName = "START_PROMOTION", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public DateTime? Start_promotion
        {
            get { return start_promotion; }
            set { start_promotion = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: END_PROMOTION
        /// Comentário: 
        /// </summary>
        private DateTime? end_promotion;
        [XmlElement(ElementName = "END_PROMOTION", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public DateTime? End_promotion
        {
            get { return end_promotion; }
            set { end_promotion = value; }
        }
        #endregion
    }

}

