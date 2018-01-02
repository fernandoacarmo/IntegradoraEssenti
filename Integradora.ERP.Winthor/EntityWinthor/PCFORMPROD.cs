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
    /// Classe referente a tabela PCFormprod
    /// </summary>
    [XmlType("PCFORMPROD")]
    public class PCFormprod : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAFRACAO
        /// Coment�rio: 
        /// </summary>
        private string aceitafracao;
        [XmlElement(ElementName = "ACEITAFRACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Aceitafracao
        {
            get { return  aceitafracao; }
            set {  aceitafracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXAESTOQUE
        /// Coment�rio: 
        /// </summary>
        private string baixaestoque;
        [XmlElement(ElementName = "BAIXAESTOQUE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Baixaestoque
        {
            get { return  baixaestoque; }
            set {  baixaestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIARMP
        /// Coment�rio: C�digo auxiliar da embalagem que comp�e a f�rmula de uma cesta ou kit
        /// </summary>
        private decimal codauxiliarmp;
        [XmlElement(ElementName = "CODAUXILIARMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliarmp
        {
            get { return  codauxiliarmp; }
            set {  codauxiliarmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODOPER
        /// Coment�rio: 
        /// </summary>
        private string codoper;
        [XmlElement(ElementName = "CODOPER", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Codoper
        {
            get { return  codoper; }
            set {  codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODACAB
        /// Coment�rio: 
        /// </summary>
        private decimal codprodacab;
        [XmlElement(ElementName = "CODPRODACAB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodacab
        {
            get { return  codprodacab; }
            set {  codprodacab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODMP
        /// Coment�rio: 
        /// </summary>
        private decimal codprodmp;
        [XmlElement(ElementName = "CODPRODMP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodmp
        {
            get { return  codprodmp; }
            set {  codprodmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOKG
        /// Coment�rio: 
        /// </summary>
        private decimal custokg;
        [XmlElement(ElementName = "CUSTOKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Custokg
        {
            get { return  custokg; }
            set {  custokg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOMP
        /// Coment�rio: 
        /// </summary>
        private decimal customp;
        [XmlElement(ElementName = "CUSTOMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Customp
        {
            get { return  customp; }
            set {  customp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPORKG
        /// Coment�rio: 
        /// </summary>
        private decimal custoporkg;
        [XmlElement(ElementName = "CUSTOPORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Custoporkg
        {
            get { return  custoporkg; }
            set {  custoporkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPRODUTO
        /// Coment�rio: 
        /// </summary>
        private decimal custoproduto;
        [XmlElement(ElementName = "CUSTOPRODUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Custoproduto
        {
            get { return  custoproduto; }
            set {  custoproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAETIQUETA
        /// Coment�rio: 
        /// </summary>
        private string geraetiqueta;
        [XmlElement(ElementName = "GERAETIQUETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraetiqueta
        {
            get { return  geraetiqueta; }
            set {  geraetiqueta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPRODACABADO
        /// Coment�rio: Percentual representativo do produto na formula��o.
        /// </summary>
        private decimal percprodacabado;
        [XmlElement(ElementName = "PERCPRODACABADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percprodacabado
        {
            get { return  percprodacabado; }
            set {  percprodacabado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVALORPRODACABADO
        /// Coment�rio: Percentual financeiro do PA.
        /// </summary>
        private decimal percvalorprodacabado;
        [XmlElement(ElementName = "PERCVALORPRODACABADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percvalorprodacabado
        {
            get { return  percvalorprodacabado; }
            set {  percvalorprodacabado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMPPORKG
        /// Coment�rio: 
        /// </summary>
        private decimal qtdempporkg;
        [XmlElement(ElementName = "QTDEMPPORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtdempporkg
        {
            get { return  qtdempporkg; }
            set {  qtdempporkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMPBAIXAR
        /// Coment�rio: 
        /// </summary>
        private decimal qtmpbaixar;
        [XmlElement(ElementName = "QTMPBAIXAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtmpbaixar
        {
            get { return  qtmpbaixar; }
            set {  qtmpbaixar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODACAB
        /// Coment�rio: 
        /// </summary>
        private decimal qtprodacab;
        [XmlElement(ElementName = "QTPRODACAB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Qtprodacab
        {
            get { return  qtprodacab; }
            set {  qtprodacab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODMP
        /// Coment�rio: 
        /// </summary>
        private decimal qtprodmp;
        [XmlElement(ElementName = "QTPRODMP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Qtprodmp
        {
            get { return  qtprodmp; }
            set {  qtprodmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUCAO
        /// Coment�rio: 
        /// </summary>
        private decimal qtproducao;
        [XmlElement(ElementName = "QTPRODUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtproducao
        {
            get { return  qtproducao; }
            set {  qtproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRENDA
        /// Coment�rio: 
        /// </summary>
        private decimal qtrenda;
        [XmlElement(ElementName = "QTRENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtrenda
        {
            get { return  qtrenda; }
            set {  qtrenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMONTAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustomontagem;
        [XmlElement(ElementName = "VLCUSTOMONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcustomontagem
        {
            get { return  vlcustomontagem; }
            set {  vlcustomontagem = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFormprod()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORMPROD";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFormprod> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFormprod>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFormprod> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFormprod>(where);
        }

        #endregion
    }
}
