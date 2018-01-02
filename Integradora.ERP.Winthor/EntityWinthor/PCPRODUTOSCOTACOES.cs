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
    /// Classe referente a tabela PCProdutoscotacoes
    /// </summary>
    [XmlType("PCPRODUTOSCOTACOES")]
    public class PCProdutoscotacoes : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEDITAL
        /// Coment�rio: C�digoedital.
        /// </summary>
        private decimal codedital;
        [XmlElement(ElementName = "CODEDITAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Codedital
        {
            get { return  codedital; }
            set {  codedital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digoProduto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,9)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTE
        /// Coment�rio: Lote.
        /// </summary>
        private string lote;
        [XmlElement(ElementName = "LOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Lote
        {
            get { return  lote; }
            set {  lote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIXPERCENTUAL_IMP
        /// Coment�rio: Mexpercentualimpostos.
        /// </summary>
        private decimal mixpercentual_imp;
        [XmlElement(ElementName = "MIXPERCENTUAL_IMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Mixpercentual_Imp
        {
            get { return  mixpercentual_imp; }
            set {  mixpercentual_imp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIXPRECO_VENDA_INIC
        /// Coment�rio: Mixpre�ovendainicial.
        /// </summary>
        private decimal mixpreco_venda_inic;
        [XmlElement(ElementName = "MIXPRECO_VENDA_INIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Mixpreco_Venda_Inic
        {
            get { return  mixpreco_venda_inic; }
            set {  mixpreco_venda_inic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIXPRECO_VENDA_MIN
        /// Coment�rio: Mixpre�ovendaminimo.
        /// </summary>
        private decimal mixpreco_venda_min;
        [XmlElement(ElementName = "MIXPRECO_VENDA_MIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Mixpreco_Venda_Min
        {
            get { return  mixpreco_venda_min; }
            set {  mixpreco_venda_min = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO_ITEM
        /// Coment�rio: Numerodoitem.
        /// </summary>
        private decimal numero_item;
        [XmlElement(ElementName = "NUMERO_ITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Numero_Item
        {
            get { return  numero_item; }
            set {  numero_item = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUALBONIFICACAO
        /// Coment�rio: Percentualbonifica��o.
        /// </summary>
        private decimal percentualbonificacao;
        [XmlElement(ElementName = "PERCENTUALBONIFICACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentualbonificacao
        {
            get { return  percentualbonificacao; }
            set {  percentualbonificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUALCAP
        /// Coment�rio: PercentualCAP.
        /// </summary>
        private decimal percentualcap;
        [XmlElement(ElementName = "PERCENTUALCAP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentualcap
        {
            get { return  percentualcap; }
            set {  percentualcap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUALCOMERCIAL
        /// Coment�rio: Percentualcomercial.
        /// </summary>
        private decimal percentualcomercial;
        [XmlElement(ElementName = "PERCENTUALCOMERCIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentualcomercial
        {
            get { return  percentualcomercial; }
            set {  percentualcomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUALICMS
        /// Coment�rio: PercentualICMS.
        /// </summary>
        private decimal percentualicms;
        [XmlElement(ElementName = "PERCENTUALICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentualicms
        {
            get { return  percentualicms; }
            set {  percentualicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUALREPASSE
        /// Coment�rio: Percentualrepasse.
        /// </summary>
        private decimal percentualrepasse;
        [XmlElement(ElementName = "PERCENTUALREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percentualrepasse
        {
            get { return  percentualrepasse; }
            set {  percentualrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOBRUTO
        /// Coment�rio: Pre�obruto.
        /// </summary>
        private decimal precobruto;
        [XmlElement(ElementName = "PRECOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precobruto
        {
            get { return  precobruto; }
            set {  precobruto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdutoscotacoes()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUTOSCOTACOES";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdutoscotacoes> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdutoscotacoes>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdutoscotacoes> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdutoscotacoes>(where);
        }

        #endregion
    }
}
