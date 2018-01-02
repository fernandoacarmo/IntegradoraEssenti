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
    /// Classe referente a tabela PCRegcobi
    /// </summary>
    [XmlType("PCREGCOBI")]
    public class PCRegcobi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CNPJTITCHEQUE
        /// Comentário: 
        /// </summary>
        private string cnpjtitcheque;
        [XmlElement(ElementName = "CNPJTITCHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cnpjtitcheque
        {
            get { return  cnpjtitcheque; }
            set {  cnpjtitcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIPAG
        /// Comentário: 
        /// </summary>
        private decimal codclipag;
        [XmlElement(ElementName = "CODCLIPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclipag
        {
            get { return  codclipag; }
            set {  codclipag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: COMPENSACAOCH
        /// Comentário: 
        /// </summary>
        private decimal compensacaoch;
        [XmlElement(ElementName = "COMPENSACAOCH", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Compensacaoch
        {
            get { return  compensacaoch; }
            set {  compensacaoch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTA
        /// Comentário: 
        /// </summary>
        private string conta;
        [XmlElement(ElementName = "CONTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Conta
        {
            get { return  conta; }
            set {  conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANCCH
        /// Comentário: 
        /// </summary>
        private DateTime? dtlancch;
        [XmlElement(ElementName = "DTLANCCH", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlancch
        {
            get { return  dtlancch; }
            set {  dtlancch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIA
        /// Comentário: 
        /// </summary>
        private decimal numagencia;
        [XmlElement(ElementName = "NUMAGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numagencia
        {
            get { return  numagencia; }
            set {  numagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Comentário: 
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Comentário: 
        /// </summary>
        private decimal numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPAG
        /// Comentário: 
        /// </summary>
        private decimal numpag;
        [XmlElement(ElementName = "NUMPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpag
        {
            get { return  numpag; }
            set {  numpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPARCELA
        /// Comentário: 
        /// </summary>
        private decimal numparcela;
        [XmlElement(ElementName = "NUMPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numparcela
        {
            get { return  numparcela; }
            set {  numparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOPARCELA
        /// Comentário: 
        /// </summary>
        private decimal prazoparcela;
        [XmlElement(ElementName = "PRAZOPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Prazoparcela
        {
            get { return  prazoparcela; }
            set {  prazoparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: 
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIECH01
        /// Comentário: 
        /// </summary>
        private string seriech01;
        [XmlElement(ElementName = "SERIECH01", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Seriech01
        {
            get { return  seriech01; }
            set {  seriech01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIECH02
        /// Comentário: 
        /// </summary>
        private string seriech02;
        [XmlElement(ElementName = "SERIECH02", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Seriech02
        {
            get { return  seriech02; }
            set {  seriech02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIECH03
        /// Comentário: 
        /// </summary>
        private string seriech03;
        [XmlElement(ElementName = "SERIECH03", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Seriech03
        {
            get { return  seriech03; }
            set {  seriech03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOCHEQUE
        /// Comentário: 
        /// </summary>
        private string situacaocheque;
        [XmlElement(ElementName = "SITUACAOCHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacaocheque
        {
            get { return  situacaocheque; }
            set {  situacaocheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARJAMAGNETICA
        /// Comentário: 
        /// </summary>
        private string tarjamagnetica;
        [XmlElement(ElementName = "TARJAMAGNETICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Tarjamagnetica
        {
            get { return  tarjamagnetica; }
            set {  tarjamagnetica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULARCHEQUE
        /// Comentário: 
        /// </summary>
        private string titularcheque;
        [XmlElement(ElementName = "TITULARCHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Titularcheque
        {
            get { return  titularcheque; }
            set {  titularcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALJUROS
        /// Comentário: 
        /// </summary>
        private decimal valjuros;
        [XmlElement(ElementName = "VALJUROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valjuros
        {
            get { return  valjuros; }
            set {  valjuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRegcobi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREGCOBI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRegcobi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRegcobi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRegcobi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRegcobi>(where);
        }

        #endregion
    }
}
