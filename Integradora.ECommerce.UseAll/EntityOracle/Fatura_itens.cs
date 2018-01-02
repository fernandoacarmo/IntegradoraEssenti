using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.UseAll.EntityOracle
{
    /// <summary>
    /// Classe referente a tabela Fatura_Itens
    /// </summary>
    [XmlType("FATURA_ITENS")]
    public class Fatura_Itens : OracleObjeto
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACAO
        /// Comentário: 
        /// </summary>
        private string acao;
        [XmlElement(ElementName = "ACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Acao
        {
            get { return  acao; }
            set {  acao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTA_ICMS
        /// Comentário: 
        /// </summary>
        private decimal aliquota_icms;
        [XmlElement(ElementName = "ALIQUOTA_ICMS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Aliquota_Icms
        {
            get { return  aliquota_icms; }
            set {  aliquota_icms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASE_ICMS
        /// Comentário: 
        /// </summary>
        private string base_icms;
        [XmlElement(ElementName = "BASE_ICMS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Base_Icms
        {
            get { return  base_icms; }
            set {  base_icms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSIFICACAO
        /// Comentário: 
        /// </summary>
        private decimal classificacao;
        [XmlElement(ElementName = "CLASSIFICACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Classificacao
        {
            get { return  classificacao; }
            set {  classificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCODFATURA
        /// Comentário: 
        /// </summary>
        private decimal idcodfatura;
        [XmlElement(ElementName = "IDCODFATURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Idcodfatura
        {
            get { return  idcodfatura; }
            set {  idcodfatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDITEM
        /// Comentário: 
        /// </summary>
        private decimal iditem;
        [XmlElement(ElementName = "IDITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Iditem
        {
            get { return  iditem; }
            set {  iditem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDOUTRASCOBCONS
        /// Comentário: 
        /// </summary>
        private decimal idoutrascobcons;
        [XmlElement(ElementName = "IDOUTRASCOBCONS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Idoutrascobcons
        {
            get { return  idoutrascobcons; }
            set {  idoutrascobcons = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDOUTRASCOBUC
        /// Comentário: 
        /// </summary>
        private decimal idoutrascobuc;
        [XmlElement(ElementName = "IDOUTRASCOBUC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Idoutrascobuc
        {
            get { return  idoutrascobuc; }
            set {  idoutrascobuc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDE
        /// Comentário: 
        /// </summary>
        private decimal qtde;
        [XmlElement(ElementName = "QTDE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Qtde
        {
            get { return  qtde; }
            set {  qtde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDE_ABERTURA
        /// Comentário: 
        /// </summary>
        private decimal qtde_abertura;
        [XmlElement(ElementName = "QTDE_ABERTURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Qtde_Abertura
        {
            get { return  qtde_abertura; }
            set {  qtde_abertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIA
        /// Comentário: 
        /// </summary>
        private string referencia;
        [XmlElement(ElementName = "REFERENCIA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public string Referencia
        {
            get { return  referencia; }
            set {  referencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUENCIA
        /// Comentário: 
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARIFA_APLICADA
        /// Comentário: 
        /// </summary>
        private decimal tarifa_aplicada;
        [XmlElement(ElementName = "TARIFA_APLICADA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public decimal Tarifa_Aplicada
        {
            get { return  tarifa_aplicada; }
            set {  tarifa_aplicada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARIFA_ICMS
        /// Comentário: 
        /// </summary>
        private decimal tarifa_icms;
        [XmlElement(ElementName = "TARIFA_ICMS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Tarifa_Icms
        {
            get { return  tarifa_icms; }
            set {  tarifa_icms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARIFA_RES
        /// Comentário: 
        /// </summary>
        private decimal tarifa_res;
        [XmlElement(ElementName = "TARIFA_RES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Tarifa_Res
        {
            get { return  tarifa_res; }
            set {  tarifa_res = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARIFA_TE
        /// Comentário: 
        /// </summary>
        private decimal tarifa_te;
        [XmlElement(ElementName = "TARIFA_TE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Tarifa_Te
        {
            get { return  tarifa_te; }
            set {  tarifa_te = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARIFA_TUSD
        /// Comentário: 
        /// </summary>
        private decimal tarifa_tusd;
        [XmlElement(ElementName = "TARIFA_TUSD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Tarifa_Tusd
        {
            get { return  tarifa_tusd; }
            set {  tarifa_tusd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_ITEM
        /// Comentário: 
        /// </summary>
        private decimal tipo_item;
        [XmlElement(ElementName = "TIPO_ITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Tipo_Item
        {
            get { return  tipo_item; }
            set {  tipo_item = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_TUSD_TE
        /// Comentário: 
        /// </summary>
        private decimal tipo_tusd_te;
        [XmlElement(ElementName = "TIPO_TUSD_TE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Tipo_Tusd_Te
        {
            get { return  tipo_tusd_te; }
            set {  tipo_tusd_te = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_ICMS
        /// Comentário: 
        /// </summary>
        private decimal valor_icms;
        [XmlElement(ElementName = "VALOR_ICMS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public decimal Valor_Icms
        {
            get { return  valor_icms; }
            set {  valor_icms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_PISCOFINS
        /// Comentário: 
        /// </summary>
        private decimal valor_piscofins;
        [XmlElement(ElementName = "VALOR_PISCOFINS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public decimal Valor_Piscofins
        {
            get { return  valor_piscofins; }
            set {  valor_piscofins = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Fatura_Itens()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "FATURA_ITENS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Fatura_Itens> Listar(string where)
        {
            Persistencia ba = new Persistencia(Fatura_Itens.GetStringConnection());
            return ba.Listar<Fatura_Itens>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Fatura_Itens> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Fatura_Itens.GetStringConnection());
            return ba.Existe<Fatura_Itens>(where);
        }

        #endregion
    }
}
