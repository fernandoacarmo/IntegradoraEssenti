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
    /// Classe referente a tabela PCConfigentrada
    /// </summary>
    [XmlType("PCCONFIGENTRADA")]
    public class PCConfigentrada : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: USAACRESCIMOCUSTO
        /// Coment�rio: Usa acr�scimo custo
        /// </summary>
        private string usaacrescimocusto;
        [XmlElement(ElementName = "USAACRESCIMOCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaacrescimocusto
        {
            get { return  usaacrescimocusto; }
            set {  usaacrescimocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONSIGNADO
        /// Coment�rio: Usa compra de produtos consignados.
        /// </summary>
        private string usaconsignado;
        [XmlElement(ElementName = "USACONSIGNADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaconsignado
        {
            get { return  usaconsignado; }
            set {  usaconsignado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCONTOCOMERCIAL
        /// Coment�rio: Usa desconto comercial
        /// </summary>
        private string usadescontocomercial;
        [XmlElement(ElementName = "USADESCONTOCOMERCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescontocomercial
        {
            get { return  usadescontocomercial; }
            set {  usadescontocomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCONTOFINANCEIRO
        /// Coment�rio: Usa Desconto financeiro
        /// </summary>
        private string usadescontofinanceiro;
        [XmlElement(ElementName = "USADESCONTOFINANCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescontofinanceiro
        {
            get { return  usadescontofinanceiro; }
            set {  usadescontofinanceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCONTOPRODUTORRURAL
        /// Coment�rio: Usa desconto produtor rural
        /// </summary>
        private string usadescontoprodutorrural;
        [XmlElement(ElementName = "USADESCONTOPRODUTORRURAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescontoprodutorrural
        {
            get { return  usadescontoprodutorrural; }
            set {  usadescontoprodutorrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESPESAFINANCEIRA
        /// Coment�rio: Usa despesas financeira
        /// </summary>
        private string usadespesafinanceira;
        [XmlElement(ElementName = "USADESPESAFINANCEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadespesafinanceira
        {
            get { return  usadespesafinanceira; }
            set {  usadespesafinanceira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADIFERENCIALALIQUOTA
        /// Coment�rio: Usa diferencial de al�quota
        /// </summary>
        private string usadiferencialaliquota;
        [XmlElement(ElementName = "USADIFERENCIALALIQUOTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadiferencialaliquota
        {
            get { return  usadiferencialaliquota; }
            set {  usadiferencialaliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAFRETECIF
        /// Coment�rio: Usa Frete CIF
        /// </summary>
        private string usafretecif;
        [XmlElement(ElementName = "USAFRETECIF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usafretecif
        {
            get { return  usafretecif; }
            set {  usafretecif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAFRETEFOB
        /// Coment�rio: Usa Frete FOB
        /// </summary>
        private string usafretefob;
        [XmlElement(ElementName = "USAFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usafretefob
        {
            get { return  usafretefob; }
            set {  usafretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAICMS
        /// Coment�rio: Usa ICMS
        /// </summary>
        private string usaicms;
        [XmlElement(ElementName = "USAICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaicms
        {
            get { return  usaicms; }
            set {  usaicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAICMSANTECIPADO
        /// Coment�rio: Usa ICMS antecipado
        /// </summary>
        private string usaicmsantecipado;
        [XmlElement(ElementName = "USAICMSANTECIPADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaicmsantecipado
        {
            get { return  usaicmsantecipado; }
            set {  usaicmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAICMSPRESUMIDO
        /// Coment�rio: Usa ICMS cr�dito presumido
        /// </summary>
        private string usaicmspresumido;
        [XmlElement(ElementName = "USAICMSPRESUMIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaicmspresumido
        {
            get { return  usaicmspresumido; }
            set {  usaicmspresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAIMPORTACAO
        /// Coment�rio: Usa tributa��o de importa��o de mercadoria.
        /// </summary>
        private string usaimportacao;
        [XmlElement(ElementName = "USAIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaimportacao
        {
            get { return  usaimportacao; }
            set {  usaimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAIPI
        /// Coment�rio: Usa IPI
        /// </summary>
        private string usaipi;
        [XmlElement(ElementName = "USAIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaipi
        {
            get { return  usaipi; }
            set {  usaipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAMEDICAMENTO
        /// Coment�rio: Usa tributa��o de importa��o de mercadoria.
        /// </summary>
        private string usamedicamento;
        [XmlElement(ElementName = "USAMEDICAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usamedicamento
        {
            get { return  usamedicamento; }
            set {  usamedicamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAMOEDAESTRANGEIRA
        /// Coment�rio: Usa compra de produtos consignados.
        /// </summary>
        private string usamoedaestrangeira;
        [XmlElement(ElementName = "USAMOEDAESTRANGEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usamoedaestrangeira
        {
            get { return  usamoedaestrangeira; }
            set {  usamoedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAOUTRASDESPESAGUIA
        /// Coment�rio: Usa outras despesas - fora da NF / Guia
        /// </summary>
        private string usaoutrasdespesaguia;
        [XmlElement(ElementName = "USAOUTRASDESPESAGUIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaoutrasdespesaguia
        {
            get { return  usaoutrasdespesaguia; }
            set {  usaoutrasdespesaguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAOUTRASDESPESANF
        /// Coment�rio: Usa outras despesas - dentro da NF
        /// </summary>
        private string usaoutrasdespesanf;
        [XmlElement(ElementName = "USAOUTRASDESPESANF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaoutrasdespesanf
        {
            get { return  usaoutrasdespesanf; }
            set {  usaoutrasdespesanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPISCOFINS
        /// Coment�rio: Usa PIS/COFINS
        /// </summary>
        private string usapiscofins;
        [XmlElement(ElementName = "USAPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapiscofins
        {
            get { return  usapiscofins; }
            set {  usapiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPRAZOENTREGAITEM
        /// Coment�rio: Usa prazo de entrega por item
        /// </summary>
        private string usaprazoentregaitem;
        [XmlElement(ElementName = "USAPRAZOENTREGAITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaprazoentregaitem
        {
            get { return  usaprazoentregaitem; }
            set {  usaprazoentregaitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USASEGURO
        /// Coment�rio: Usa seguro
        /// </summary>
        private string usaseguro;
        [XmlElement(ElementName = "USASEGURO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaseguro
        {
            get { return  usaseguro; }
            set {  usaseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USASTGUIA
        /// Coment�rio: Usa ST - fora da NF / Guia
        /// </summary>
        private string usastguia;
        [XmlElement(ElementName = "USASTGUIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usastguia
        {
            get { return  usastguia; }
            set {  usastguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USASTNF
        /// Coment�rio: Usa ST - dentro da NF
        /// </summary>
        private string usastnf;
        [XmlElement(ElementName = "USASTNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usastnf
        {
            get { return  usastnf; }
            set {  usastnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USASUFRAMA
        /// Coment�rio: Usa SUFRAMA
        /// </summary>
        private string usasuframa;
        [XmlElement(ElementName = "USASUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usasuframa
        {
            get { return  usasuframa; }
            set {  usasuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVERBADINHEIRO
        /// Coment�rio: Usa verba - dinheiro
        /// </summary>
        private string usaverbadinheiro;
        [XmlElement(ElementName = "USAVERBADINHEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaverbadinheiro
        {
            get { return  usaverbadinheiro; }
            set {  usaverbadinheiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVERBAMERCADORIA
        /// Coment�rio: Usa verba - mercadoria
        /// </summary>
        private string usaverbamercadoria;
        [XmlElement(ElementName = "USAVERBAMERCADORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaverbamercadoria
        {
            get { return  usaverbamercadoria; }
            set {  usaverbamercadoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVERBAOUTRAS
        /// Coment�rio: Usa verba - outras
        /// </summary>
        private string usaverbaoutras;
        [XmlElement(ElementName = "USAVERBAOUTRAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaverbaoutras
        {
            get { return  usaverbaoutras; }
            set {  usaverbaoutras = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCConfigentrada()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFIGENTRADA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConfigentrada> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConfigentrada>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCConfigentrada> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConfigentrada>(where);
        }

        #endregion
    }
}
