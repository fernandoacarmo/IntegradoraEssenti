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
    /// Classe referente a tabela PCWmscorte
    /// </summary>
    [XmlType("PCWMSCORTE")]
    public class PCWmscorte : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Coment�rio: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
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
        /// Propriedade referente ao campo: CODFUNCCORTE
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccorte;
        [XmlElement(ElementName = "CODFUNCCORTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccorte
        {
            get { return  codfunccorte; }
            set {  codfunccorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCOS
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncos;
        [XmlElement(ElementName = "CODFUNCOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncos
        {
            get { return  codfuncos; }
            set {  codfuncos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Coment�rio: 
        /// </summary>
        private decimal codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPER
        /// Coment�rio: Indica qual � a opera��o associada com o registro
        /// </summary>
        private string codoper;
        [XmlElement(ElementName = "CODOPER", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codoper
        {
            get { return  codoper; }
            set {  codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: 
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPALETE
        /// Coment�rio: 
        /// </summary>
        private decimal numpalete;
        [XmlElement(ElementName = "NUMPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numpalete
        {
            get { return  numpalete; }
            set {  numpalete = value; }
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
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Coment�rio: 
        /// </summary>
        private decimal numtranswms;
        [XmlElement(ElementName = "NUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranswms
        {
            get { return  numtranswms; }
            set {  numtranswms = value; }
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
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCORTADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtcortada;
        [XmlElement(ElementName = "QTCORTADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtcortada
        {
            get { return  qtcortada; }
            set {  qtcortada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCORTE
        /// Coment�rio: Tipo Corte
        /// </summary>
        private string tipocorte;
        [XmlElement(ElementName = "TIPOCORTE", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocorte
        {
            get { return  tipocorte; }
            set {  tipocorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOS
        /// Coment�rio: 
        /// </summary>
        private decimal tipoos;
        [XmlElement(ElementName = "TIPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tipoos
        {
            get { return  tipoos; }
            set {  tipoos = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCWmscorte()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSCORTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCWmscorte> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmscorte.GetStringConnection());
            return ba.Listar<PCWmscorte>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCWmscorte> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmscorte.GetStringConnection());
            return ba.Existe<PCWmscorte>(where);
        }

        #endregion
    }
}
