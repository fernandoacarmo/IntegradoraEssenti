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
    /// Classe referente a tabela PCConhecitemp
    /// </summary>
    [XmlType("PCCONHECITEMP")]
    public class PCConhecitemp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CGCDESTINATARIO
        /// Comentário: CNPJ do destinatário
        /// </summary>
        private string cgcdestinatario;
        [XmlElement(ElementName = "CGCDESTINATARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgcdestinatario
        {
            get { return  cgcdestinatario; }
            set {  cgcdestinatario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCEMBARCADORA
        /// Comentário: CNPJ da empresa embardadora
        /// </summary>
        private string cgcembarcadora;
        [XmlElement(ElementName = "CGCEMBARCADORA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public string Cgcembarcadora
        {
            get { return  cgcembarcadora; }
            set {  cgcembarcadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADEEMBARCADORA
        /// Comentário: Cidade onde está localizada a empresa embarcadora
        /// </summary>
        private string cidadeembarcadora;
        [XmlElement(ElementName = "CIDADEEMBARCADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Cidadeembarcadora
        {
            get { return  cidadeembarcadora; }
            set {  cidadeembarcadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: Código fiscal / CFOP da nota de conhecimento
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIE
        /// Comentário: Espécia da nota de conhecimento
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZA
        /// Comentário: Naturaza da nota de conhecimento
        /// </summary>
        private string natureza;
        [XmlElement(ElementName = "NATUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Natureza
        {
            get { return  natureza; }
            set {  natureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEDESTINATARIO
        /// Comentário: Nome da empresa destinatário
        /// </summary>
        private string nomedestinatario;
        [XmlElement(ElementName = "NOMEDESTINATARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Nomedestinatario
        {
            get { return  nomedestinatario; }
            set {  nomedestinatario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEEMBARCADORA
        /// Comentário: Nome da empresa embarcadora
        /// </summary>
        private string nomeembarcadora;
        [XmlElement(ElementName = "NOMEEMBARCADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,70)]
        public string Nomeembarcadora
        {
            get { return  nomeembarcadora; }
            set {  nomeembarcadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Número da nota de conhecimento
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESO
        /// Comentário: Peso informado na nota de conhecimento
        /// </summary>
        private decimal peso;
        [XmlElement(ElementName = "PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Peso
        {
            get { return  peso; }
            set {  peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROCESSADO
        /// Comentário: Indica se na nota de conhecimento foi processada ou não
        /// </summary>
        private string processado;
        [XmlElement(ElementName = "PROCESSADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Processado
        {
            get { return  processado; }
            set {  processado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLO
        /// Comentário: Número do protocolo indentificador do conhecimento de frete
        /// </summary>
        private string protocolo;
        [XmlElement(ElementName = "PROTOCOLO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,50)]
        public string Protocolo
        {
            get { return  protocolo; }
            set {  protocolo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTITENS
        /// Comentário: Quantidade de itens da nota de conhecimento
        /// </summary>
        private decimal qtitens;
        [XmlElement(ElementName = "QTITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Qtitens
        {
            get { return  qtitens; }
            set {  qtitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: Série da nota de conhecimento
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Comentário: Tipo de frete CIF / FOB
        /// </summary>
        private string tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEICMS
        /// Comentário: Valor base de icms
        /// </summary>
        private decimal vlbaseicms;
        [XmlElement(ElementName = "VLBASEICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbaseicms
        {
            get { return  vlbaseicms; }
            set {  vlbaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: Valor do frete de cada conhecimento
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Comentário: Valor de ICMS
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Comentário: Valor do seguro
        /// </summary>
        private decimal vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: Valor total da nota de conhecimento
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTFRETE
        /// Comentário: Valor total do frete
        /// </summary>
        private decimal vltotfrete;
        [XmlElement(ElementName = "VLTOTFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotfrete
        {
            get { return  vltotfrete; }
            set {  vltotfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Comentário: Volume informado na nota de conhecimento
        /// </summary>
        private decimal volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConhecitemp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONHECITEMP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConhecitemp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConhecitemp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConhecitemp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConhecitemp>(where);
        }

        #endregion
    }
}
