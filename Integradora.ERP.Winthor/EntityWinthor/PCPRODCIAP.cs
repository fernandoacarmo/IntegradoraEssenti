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
    /// Classe referente a tabela PCProdciap
    /// </summary>
    [XmlType("PCPRODCIAP")]
    public class PCProdciap : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODANP
        /// Coment�rio: C�digo ANP
        /// </summary>
        private string codanp;
        [XmlElement(ElementName = "CODANP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Codanp
        {
            get { return  codanp; }
            set {  codanp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: N�mero do C�digo de Barras
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do produto
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
        /// Propriedade referente ao campo: CODGENPROCONIMO
        /// Coment�rio: C�digo G�nero Produtos Consumo/Imobilizado
        /// </summary>
        private decimal codgenproconimo;
        [XmlElement(ElementName = "CODGENPROCONIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codgenproconimo
        {
            get { return  codgenproconimo; }
            set {  codgenproconimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOBEM
        /// Coment�rio: Indica o grupo do bem.
        /// </summary>
        private decimal codgrupobem;
        [XmlElement(ElementName = "CODGRUPOBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgrupobem
        {
            get { return  codgrupobem; }
            set {  codgrupobem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLOCALBEM
        /// Coment�rio: Indica a localiza��o do bem.
        /// </summary>
        private decimal codlocalbem;
        [XmlElement(ElementName = "CODLOCALBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlocalbem
        {
            get { return  codlocalbem; }
            set {  codlocalbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNCM
        /// Coment�rio: C�digo NCM
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Informe o c�digo do produto.
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
        /// Propriedade referente ao campo: CODRESPONSAVELBEM
        /// Coment�rio: Indica o respons�vel pelo bem.
        /// </summary>
        private decimal codresponsavelbem;
        [XmlElement(ElementName = "CODRESPONSAVELBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codresponsavelbem
        {
            get { return  codresponsavelbem; }
            set {  codresponsavelbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSERVICO_LEICOMPLEM
        /// Coment�rio: Indica o c�digo servi�o lei complementar 116/03.
        /// </summary>
        private string codservico_leicomplem;
        [XmlElement(ElementName = "CODSERVICO_LEICOMPLEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codservico_Leicomplem
        {
            get { return  codservico_leicomplem; }
            set {  codservico_leicomplem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Informe a descri��o do produto.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Informe a data de exclus�o.
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Coment�rio: Informe a embalagem do produto.
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
        /// Propriedade referente ao campo: EXTIPI
        /// Coment�rio: C�digo de Exce��o do TIPI
        /// </summary>
        private string extipi;
        [XmlElement(ElementName = "EXTIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Extipi
        {
            get { return  extipi; }
            set {  extipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTINCODAUXILIAR
        /// Coment�rio: Tipo do C�digo de Barras
        /// </summary>
        private string gtincodauxiliar;
        [XmlElement(ElementName = "GTINCODAUXILIAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Gtincodauxiliar
        {
            get { return  gtincodauxiliar; }
            set {  gtincodauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: Origem da Mercadoria
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTIPI
        /// Coment�rio: Tributa��o IPI do Produto
        /// </summary>
        private string sittributipi;
        [XmlElement(ElementName = "SITTRIBUTIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Sittributipi
        {
            get { return  sittributipi; }
            set {  sittributipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMERC
        /// Coment�rio: Informe o tipo da mercadoria.
        /// </summary>
        private string tipomerc;
        [XmlElement(ElementName = "TIPOMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomerc
        {
            get { return  tipomerc; }
            set {  tipomerc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdciap()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODCIAP";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdciap> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdciap>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdciap> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdciap>(where);
        }

        #endregion
    }
}
