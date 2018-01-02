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
    /// Classe referente a tabela PCCotac
    /// </summary>
    [XmlType("PCCOTAC")]
    public class PCCotac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: C�digo auxiliar da embalagem a ser cotada
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
        /// Propriedade referente ao campo: CODFUNCGERA
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncgera;
        [XmlElement(ElementName = "CODFUNCGERA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncgera
        {
            get { return  codfuncgera; }
            set {  codfuncgera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
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
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAGERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? datageracao;
        [XmlElement(ElementName = "DATAGERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datageracao
        {
            get { return  datageracao; }
            set {  datageracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOPESQ
        /// Coment�rio: 
        /// </summary>
        private string descricaopesq;
        [XmlElement(ElementName = "DESCRICAOPESQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricaopesq
        {
            get { return  descricaopesq; }
            set {  descricaopesq = value; }
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
        /// Propriedade referente ao campo: NUMPESQUISA
        /// Coment�rio: 
        /// </summary>
        private decimal numpesquisa;
        [XmlElement(ElementName = "NUMPESQUISA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
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
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Este campo � para dizer qual a situa��o da cota��o que est� sendo feita, se � Em edi��o e conclu�da.
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCotac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCotac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCotac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotac>(where);
        }

        #endregion
    }
}
