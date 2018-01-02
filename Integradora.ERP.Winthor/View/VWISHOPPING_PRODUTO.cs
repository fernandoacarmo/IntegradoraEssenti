using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Vwishopping_Produto
    /// </summary>
    [XmlType("VWISHOPPING_PRODUTO")]
    public class Vwishopping_Produto : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALLOW_BUY
        /// Comentário: 
        /// </summary>
        private string allow_buy;
        [XmlElement(ElementName = "ALLOW_BUY", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Allow_Buy
        {
            get { return allow_buy; }
            set { allow_buy = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Comentário: 
        /// </summary>
        private decimal altura;
        [XmlElement(ElementName = "ALTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AVAILABILITY
        /// Comentário: 
        /// </summary>
        private string availability;
        [XmlElement(ElementName = "AVAILABILITY", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 0)]
        public string Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHECK_STOCK
        /// Comentário: 
        /// </summary>
        private string check_stock;
        [XmlElement(ElementName = "CHECK_STOCK", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Check_Stock
        {
            get { return check_stock; }
            set { check_stock = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 20)]
        public decimal Codauxiliar
        {
            get { return codauxiliar; }
            set { codauxiliar = value; }
        }

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
        /// Propriedade referente ao campo: COD_REF
        /// Comentário: 
        /// </summary>
        private decimal cod_ref;
        [XmlElement(ElementName = "COD_REF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Cod_Ref
        {
            get { return cod_ref; }
            set { cod_ref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTO
        /// Comentário: 
        /// </summary>
        private decimal comprimento;
        [XmlElement(ElementName = "COMPRIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Comprimento
        {
            get { return comprimento; }
            set { comprimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRIPTION_FULL
        /// Comentário: 
        /// </summary>
        private string description_full;
        [XmlElement(ElementName = "DESCRIPTION_FULL", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false, false, true, 0)]
        public string Description_Full
        {
            get { return description_full; }
            set { description_full = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRIPTION_SMALL
        /// Comentário: 
        /// </summary>
        private string description_small;
        [XmlElement(ElementName = "DESCRIPTION_SMALL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Description_Small
        {
            get { return description_small; }
            set { description_small = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXCLUSIVO
        /// Comentário: 
        /// </summary>
        private string exclusivo;
        [XmlElement(ElementName = "EXCLUSIVO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Exclusivo
        {
            get { return exclusivo; }
            set { exclusivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HIGHLIGHT
        /// Comentário: 
        /// </summary>
        private string highlight;
        [XmlElement(ElementName = "HIGHLIGHT", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Highlight
        {
            get { return highlight; }
            set { highlight = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOTDEAL
        /// Comentário: 
        /// </summary>
        private string hotdeal;
        [XmlElement(ElementName = "HOTDEAL", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Hotdeal
        {
            get { return hotdeal; }
            set { hotdeal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: 
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISFREESHIPPING
        /// Comentário: 
        /// </summary>
        private string isfreeshipping;
        [XmlElement(ElementName = "ISFREESHIPPING", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Isfreeshipping
        {
            get { return isfreeshipping; }
            set { isfreeshipping = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURA
        /// Comentário: 
        /// </summary>
        private decimal largura;
        [XmlElement(ElementName = "LARGURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MANUFACTURER_ID
        /// Comentário: 
        /// </summary>
        private string manufacturer_id;
        [XmlElement(ElementName = "MANUFACTURER_ID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Manufacturer_Id
        {
            get { return manufacturer_id; }
            set { manufacturer_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODEL
        /// Comentário: 
        /// </summary>
        private string model;
        [XmlElement(ElementName = "MODEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 40)]
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAME
        /// Comentário: 
        /// </summary>
        private string name;
        [XmlElement(ElementName = "NAME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NEWRELEASE
        /// Comentário: 
        /// </summary>
        private string newrelease;
        [XmlElement(ElementName = "NEWRELEASE", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Newrelease
        {
            get { return newrelease; }
            set { newrelease = value; }
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
        /// Propriedade referente ao campo: PRICE
        /// Comentário: 
        /// </summary>
        private decimal price;
        [XmlElement(ElementName = "PRICE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTITY
        /// Comentário: 
        /// </summary>
        private decimal quantity;
        [XmlElement(ElementName = "QUANTITY", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTITY_CRITICAL
        /// Comentário: 
        /// </summary>
        private decimal quantity_critical;
        [XmlElement(ElementName = "QUANTITY_CRITICAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Quantity_Critical
        {
            get { return quantity_critical; }
            set { quantity_critical = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTITY_MAX_BUY
        /// Comentário: 
        /// </summary>
        private decimal quantity_max_buy;
        [XmlElement(ElementName = "QUANTITY_MAX_BUY", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Quantity_Max_Buy
        {
            get { return quantity_max_buy; }
            set { quantity_max_buy = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTITY_MIN_BUY
        /// Comentário: 
        /// </summary>
        private decimal quantity_min_buy;
        [XmlElement(ElementName = "QUANTITY_MIN_BUY", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Quantity_Min_Buy
        {
            get { return quantity_min_buy; }
            set { quantity_min_buy = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: WEIGHT
        /// Comentário: 
        /// </summary>
        private decimal weight;
        [XmlElement(ElementName = "WEIGHT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Vwishopping_Produto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "VWISHOPPING_PRODUTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Vwishopping_Produto> Listar(string where)
        {
            Persistencia ba = new Persistencia(Vwishopping_Produto.GetStringConnection());
            return ba.Listar<Vwishopping_Produto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Vwishopping_Produto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Vwishopping_Produto.GetStringConnection());
            return ba.Existe<Vwishopping_Produto>(where);
        }

        #endregion
    }
}
