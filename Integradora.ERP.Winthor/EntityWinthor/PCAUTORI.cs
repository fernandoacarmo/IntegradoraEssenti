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
    /// Classe referente a tabela PCAutori
    /// </summary>
    [XmlType("PCAUTORI")]
    public class PCAutori : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AFETAPERDESC
        /// Coment�rio: 
        /// </summary>
        private string afetaperdesc;
        [XmlElement(ElementName = "AFETAPERDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Afetaperdesc
        {
            get { return  afetaperdesc; }
            set {  afetaperdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APENASPLPAGMAX
        /// Coment�rio: Definir se esta autoriza��o ser� valida para outros planos.
        /// </summary>
        private string apenasplpagmax;
        [XmlElement(ElementName = "APENASPLPAGMAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Apenasplpagmax
        {
            get { return  apenasplpagmax; }
            set {  apenasplpagmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASECREDDEBRCA
        /// Coment�rio: 
        /// </summary>
        private string basecreddebrca;
        [XmlElement(ElementName = "BASECREDDEBRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Basecreddebrca
        {
            get { return  basecreddebrca; }
            set {  basecreddebrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: 
        /// </summary>
        private decimal? codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal? Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal? codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal? Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
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
        /// Propriedade referente ao campo: CODFUNCCADASTRO
        /// Coment�rio: 
        /// </summary>
        private decimal? codfunccadastro;
        [XmlElement(ElementName = "CODFUNCCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunccadastro
        {
            get { return  codfunccadastro; }
            set {  codfunccadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCX
        /// Coment�rio: Indica o c�digo do funcion�rio do caixa.
        /// </summary>
        private decimal? codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCUTILIZ
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncutiliz;
        [XmlElement(ElementName = "CODFUNCUTILIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncutiliz
        {
            get { return  codfuncutiliz; }
            set {  codfuncutiliz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
        /// </summary>
        private decimal? codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal? Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal? codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal? Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal? codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal? Codusur
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
        [DataObjectField(false,false,false,7)]
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
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexportacaoservint;
        [XmlElement(ElementName = "DTEXPORTACAOSERVINT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaoservint
        {
            get { return  dtexportacaoservint; }
            set {  dtexportacaoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtimportacaoservprinc;
        [XmlElement(ElementName = "DTIMPORTACAOSERVPRINC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaoservprinc
        {
            get { return  dtimportacaoservprinc; }
            set {  dtimportacaoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXCEDECOTA
        /// Coment�rio: 
        /// </summary>
        private string excedecota;
        [XmlElement(ElementName = "EXCEDECOTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Excedecota
        {
            get { return  excedecota; }
            set {  excedecota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Coment�rio: 
        /// </summary>
        private string exportadoservint;
        [XmlElement(ElementName = "EXPORTADOSERVINT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadoservint
        {
            get { return  exportadoservint; }
            set {  exportadoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIMINTERVALO
        /// Coment�rio: 
        /// </summary>
        private decimal? fimintervalo;
        [XmlElement(ElementName = "FIMINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Fimintervalo
        {
            get { return  fimintervalo; }
            set {  fimintervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERADEBRCA
        /// Coment�rio: 
        /// </summary>
        private string geradebrca;
        [XmlElement(ElementName = "GERADEBRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geradebrca
        {
            get { return  geradebrca; }
            set {  geradebrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private string importadoservprinc;
        [XmlElement(ElementName = "IMPORTADOSERVPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoservprinc
        {
            get { return  importadoservprinc; }
            set {  importadoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INICIOINTERVALO
        /// Coment�rio: 
        /// </summary>
        private decimal? iniciointervalo;
        [XmlElement(ElementName = "INICIOINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Iniciointervalo
        {
            get { return  iniciointervalo; }
            set {  iniciointervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NRAUTORIZACAO
        /// Coment�rio: 
        /// </summary>
        private decimal? nrautorizacao;
        [XmlElement(ElementName = "NRAUTORIZACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal? Nrautorizacao
        {
            get { return  nrautorizacao; }
            set {  nrautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NRAUTORIZACAOECF
        /// Coment�rio: Indica o n�mero de autoriza��o do caixa.
        /// </summary>
        private decimal? nrautorizacaoecf;
        [XmlElement(ElementName = "NRAUTORIZACAOECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Nrautorizacaoecf
        {
            get { return  nrautorizacaoecf; }
            set {  nrautorizacaoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: 
        /// </summary>
        private decimal? numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Coment�rio: 
        /// </summary>
        private decimal? numcupom;
        [XmlElement(ElementName = "NUMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numcupom
        {
            get { return  numcupom; }
            set {  numcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal? numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Coment�rio: Indica o c�digo do funcion�rio do caixa.
        /// </summary>
        private decimal? numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: 
        /// </summary>
        private decimal? numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numregiao
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
        [DataObjectField(false,false,true,80)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCAUTOR
        /// Coment�rio: 
        /// </summary>
        private decimal? percdescautor;
        [XmlElement(ElementName = "PERCDESCAUTOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal? Percdescautor
        {
            get { return  percdescautor; }
            set {  percdescautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Coment�rio: 
        /// </summary>
        private decimal? percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATUAL
        /// Coment�rio: 
        /// </summary>
        private decimal? pvendaatual;
        [XmlElement(ElementName = "PVENDAATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Pvendaatual
        {
            get { return  pvendaatual; }
            set {  pvendaatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDIDO
        /// Coment�rio: 
        /// </summary>
        private decimal? pvendido;
        [XmlElement(ElementName = "PVENDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Pvendido
        {
            get { return  pvendido; }
            set {  pvendido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAECF
        /// Coment�rio: 
        /// </summary>
        private decimal? qtvendaecf;
        [XmlElement(ElementName = "QTVENDAECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtvendaecf
        {
            get { return  qtvendaecf; }
            set {  qtvendaecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEEQUIP
        /// Coment�rio: 
        /// </summary>
        private string serieequip;
        [XmlElement(ElementName = "SERIEEQUIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
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
        public PCAutori()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUTORI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAutori> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAutori>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAutori> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAutori>(where);
        }

        #endregion
    }
}
