using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityAjuri
{
    /// <summary>
    /// Classe referente a tabela ESTProduto
    /// </summary>
    [XmlType("ESTPRODUTO")]
    public class ESTProduto : BaseAjuri
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Coment�rio: 
        /// </summary>
        private decimal altura;
        [XmlElement(ElementName = "ALTURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Altura
        {
            get { return  altura; }
            set {  altura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Coment�rio: 
        /// </summary>
        private decimal codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFABRICA
        /// Coment�rio: 
        /// </summary>
        private string codfabrica;
        [XmlElement(ElementName = "CODFABRICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Codfabrica
        {
            get { return  codfabrica; }
            set {  codfabrica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIAL
        /// Coment�rio: 
        /// </summary>
        private string serial;
        [XmlElement(ElementName = "SERIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINCIPAL
        /// Coment�rio: 
        /// </summary>
        private decimal codprodprincipal;
        [XmlElement(ElementName = "CODPRODPRINCIPAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodprincipal
        {
            get { return codprodprincipal; }
            set { codprodprincipal = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Coment�rio: 
        /// </summary>
        private decimal codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmarca
        {
            get { return  codmarca; }
            set {  codmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNCM
        /// Coment�rio: 
        /// </summary>
        private string codncm;
        [XmlElement(ElementName = "CODNCM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Codncm
        {
            get { return  codncm; }
            set {  codncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSECAO
        /// Coment�rio: 
        /// </summary>
        private decimal codsecao;
        [XmlElement(ElementName = "CODSECAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codsecao
        {
            get { return  codsecao; }
            set {  codsecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTO
        /// Coment�rio: 
        /// </summary>
        private decimal comprimento;
        [XmlElement(ElementName = "COMPRIMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Comprimento
        {
            get { return  comprimento; }
            set {  comprimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOCOMPLETA
        /// Coment�rio: 
        /// </summary>
        private string descricaocompleta;
        [XmlElement(ElementName = "DESCRICAOCOMPLETA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 500)]
        public string Descricaocompleta
        {
            get { return descricaocompleta; }
            set { descricaocompleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURA
        /// Coment�rio: 
        /// </summary>
        private decimal largura;
        [XmlElement(ElementName = "LARGURA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Largura
        {
            get { return  largura; }
            set {  largura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NCM
        /// Coment�rio: 
        /// </summary>
        private string ncm;
        [XmlElement(ElementName = "NCM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ncm
        {
            get { return  ncm; }
            set {  ncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Coment�rio: 
        /// </summary>
        private decimal pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQUIDO
        /// Coment�rio: 
        /// </summary>
        private decimal pesoliquido;
        [XmlElement(ElementName = "PESOLIQUIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Pesoliquido
        {
            get { return  pesoliquido; }
            set {  pesoliquido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal qtembalagem;
        [XmlElement(ElementName = "QTEMBALAGEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtembalagem
        {
            get { return  qtembalagem; }
            set {  qtembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITARIA
        /// Coment�rio: 
        /// </summary>
        private decimal qtunitaria;
        [XmlElement(ElementName = "QTUNITARIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtunitaria
        {
            get { return  qtunitaria; }
            set {  qtunitaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Coment�rio: 
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Coment�rio: 
        /// </summary>
        private decimal volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTProduto()
        {
            Inicializar();
            Volume = 1;
            Pesobruto = 1;
            Pesoliquido = 1;
            Qtembalagem = 1;
            Qtunitaria = 1;
            Largura = 1;
            Comprimento = 1;
            Altura = 1;
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPRODUTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTProduto> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTProduto.GetStringConnection());
            return ba.Listar<ESTProduto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTProduto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTProduto.GetStringConnection());
            return ba.Existe<ESTProduto>(where);
        }

        #endregion
    }
}
