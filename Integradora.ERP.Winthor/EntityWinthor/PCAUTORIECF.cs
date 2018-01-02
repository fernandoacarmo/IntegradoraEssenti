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
    /// Classe referente a tabela PCAutoriecf
    /// </summary>
    [XmlType("PCAUTORIECF")]
    public class PCAutoriecf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial da empresa.
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
        /// Propriedade referente ao campo: CODFUNCCX
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCUTILIZ
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncutiliz;
        [XmlElement(ElementName = "CODFUNCUTILIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncutiliz
        {
            get { return  codfuncutiliz; }
            set {  codfuncutiliz = value; }
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
        [DataObjectField(false,false,false,10)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAAUTORIZACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataautorizacao;
        [XmlElement(ElementName = "DATAAUTORIZACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dataautorizacao
        {
            get { return  dataautorizacao; }
            set {  dataautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA_UTILIZACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? data_utilizacao;
        [XmlElement(ElementName = "DATA_UTILIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data_Utilizacao
        {
            get { return  data_utilizacao; }
            set {  data_utilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Coment�rio: Data em que a exporta��o do BD local ocorreu.
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: 
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NRAUTORIZACAO
        /// Coment�rio: 
        /// </summary>
        private decimal nrautorizacao;
        [XmlElement(ElementName = "NRAUTORIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Nrautorizacao
        {
            get { return  nrautorizacao; }
            set {  nrautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NRAUTORIZACAOECF
        /// Coment�rio: 
        /// </summary>
        private decimal nrautorizacaoecf;
        [XmlElement(ElementName = "NRAUTORIZACAOECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Nrautorizacaoecf
        {
            get { return  nrautorizacaoecf; }
            set {  nrautorizacaoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: 
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Coment�rio: 
        /// </summary>
        private decimal numcupom;
        [XmlElement(ElementName = "NUMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcupom
        {
            get { return  numcupom; }
            set {  numcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Coment�rio: 
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCAUTOR
        /// Coment�rio: 
        /// </summary>
        private decimal percdescautor;
        [XmlElement(ElementName = "PERCDESCAUTOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Percdescautor
        {
            get { return  percdescautor; }
            set {  percdescautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATUAL
        /// Coment�rio: 
        /// </summary>
        private decimal pvendaatual;
        [XmlElement(ElementName = "PVENDAATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pvendaatual
        {
            get { return  pvendaatual; }
            set {  pvendaatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDIDO
        /// Coment�rio: 
        /// </summary>
        private decimal pvendido;
        [XmlElement(ElementName = "PVENDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendido
        {
            get { return  pvendido; }
            set {  pvendido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEEQUIP
        /// Coment�rio: 
        /// </summary>
        private string serieequip;
        [XmlElement(ElementName = "SERIEEQUIP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,30)]
        public string Serieequip
        {
            get { return  serieequip; }
            set {  serieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSUTILIZ
        /// Coment�rio: 
        /// </summary>
        private string statusutiliz;
        [XmlElement(ElementName = "STATUSUTILIZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Statusutiliz
        {
            get { return  statusutiliz; }
            set {  statusutiliz = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAutoriecf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUTORIECF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAutoriecf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAutoriecf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAutoriecf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAutoriecf>(where);
        }

        #endregion
    }
}
