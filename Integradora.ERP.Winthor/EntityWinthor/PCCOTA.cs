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
    /// Classe referente a tabela PCCota
    /// </summary>
    [XmlType("PCCOTA")]
    public class PCCota : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONC
        /// Coment�rio: 
        /// </summary>
        private string codconc;
        [XmlElement(ElementName = "CODCONC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public string Codconc
        {
            get { return  codconc; }
            set {  codconc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOTACAO
        /// Coment�rio: 
        /// </summary>
        private decimal codcotacao;
        [XmlElement(ElementName = "CODCOTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codcotacao
        {
            get { return  codcotacao; }
            set {  codcotacao = value; }
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
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODCONC
        /// Coment�rio: Gravar o produto concorrente
        /// </summary>
        private decimal codprodconc;
        [XmlElement(ElementName = "CODPRODCONC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodconc
        {
            get { return  codprodconc; }
            set {  codprodconc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Coment�rio: 
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Coment�rio: 
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATADOC
        /// Coment�rio: 
        /// </summary>
        private DateTime? datadoc;
        [XmlElement(ElementName = "DATADOC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datadoc
        {
            get { return  datadoc; }
            set {  datadoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUE
        /// Coment�rio: 
        /// </summary>
        private string estoque;
        [XmlElement(ElementName = "ESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estoque
        {
            get { return  estoque; }
            set {  estoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FONTE
        /// Coment�rio: 
        /// </summary>
        private string fonte;
        [XmlElement(ElementName = "FONTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fonte
        {
            get { return  fonte; }
            set {  fonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LISTA
        /// Coment�rio: 
        /// </summary>
        private decimal lista;
        [XmlElement(ElementName = "LISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Lista
        {
            get { return  lista; }
            set {  lista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPESQUISA
        /// Coment�rio: N�mero da pesquisa
        /// </summary>
        private decimal numpesquisa;
        [XmlElement(ElementName = "NUMPESQUISA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpesquisa
        {
            get { return  numpesquisa; }
            set {  numpesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: OBSEVA��O 2.
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXDESCMERCADO
        /// Coment�rio: Percentual m�ximo desconto mercado
        /// </summary>
        private decimal percmaxdescmercado;
        [XmlElement(ElementName = "PERCMAXDESCMERCADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percmaxdescmercado
        {
            get { return  percmaxdescmercado; }
            set {  percmaxdescmercado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO
        /// Coment�rio: 
        /// </summary>
        private decimal prazo;
        [XmlElement(ElementName = "PRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo
        {
            get { return  prazo; }
            set {  prazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOCON1
        /// Coment�rio: 
        /// </summary>
        private decimal precocon1;
        [XmlElement(ElementName = "PRECOCON1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Precocon1
        {
            get { return  precocon1; }
            set {  precocon1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOCON2
        /// Coment�rio: 
        /// </summary>
        private decimal precocon2;
        [XmlElement(ElementName = "PRECOCON2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Precocon2
        {
            get { return  precocon2; }
            set {  precocon2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOCON3
        /// Coment�rio: 
        /// </summary>
        private decimal precocon3;
        [XmlElement(ElementName = "PRECOCON3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Precocon3
        {
            get { return  precocon3; }
            set {  precocon3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOCON4
        /// Coment�rio: 
        /// </summary>
        private decimal precocon4;
        [XmlElement(ElementName = "PRECOCON4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Precocon4
        {
            get { return  precocon4; }
            set {  precocon4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOCON5
        /// Coment�rio: 
        /// </summary>
        private decimal precocon5;
        [XmlElement(ElementName = "PRECOCON5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Precocon5
        {
            get { return  precocon5; }
            set {  precocon5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNIT
        /// Coment�rio: 
        /// </summary>
        private decimal punit;
        [XmlElement(ElementName = "PUNIT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Punit
        {
            get { return  punit; }
            set {  punit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNITATAC
        /// Coment�rio: Pre�o de atacado na cota��o
        /// </summary>
        private decimal punitatac;
        [XmlElement(ElementName = "PUNITATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punitatac
        {
            get { return  punitatac; }
            set {  punitatac = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCota()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCota> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCota>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCota> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCota>(where);
        }

        #endregion
    }
}
