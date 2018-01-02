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
    /// Classe referente a tabela PCSaldocr
    /// </summary>
    [XmlType("PCSALDOCR")]
    public class PCSaldocr : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: 
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
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
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: Indica o código do funcionário responsável pelo fechamento do caixa.
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURA
        /// Comentário: Indica a data e hora de abertura do caixa.
        /// </summary>
        private DateTime? dtabertura;
        [XmlElement(ElementName = "DTABERTURA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtabertura
        {
            get { return  dtabertura; }
            set {  dtabertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCONCILIA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultconcilia;
        [XmlElement(ElementName = "DTULTCONCILIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultconcilia
        {
            get { return  dtultconcilia; }
            set {  dtultconcilia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALDOCONCILID
        /// Comentário: 
        /// </summary>
        private decimal vlsaldoconcilid;
        [XmlElement(ElementName = "VLSALDOCONCILID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlsaldoconcilid
        {
            get { return  vlsaldoconcilid; }
            set {  vlsaldoconcilid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALDOFINAL
        /// Comentário: Indica o valor saldo final após fechar o caixa.
        /// </summary>
        private decimal vlsaldofinal;
        [XmlElement(ElementName = "VLSALDOFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsaldofinal
        {
            get { return  vlsaldofinal; }
            set {  vlsaldofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALDOINICIAL
        /// Comentário: 
        /// </summary>
        private decimal vlsaldoinicial;
        [XmlElement(ElementName = "VLSALDOINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlsaldoinicial
        {
            get { return  vlsaldoinicial; }
            set {  vlsaldoinicial = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSaldocr()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSALDOCR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSaldocr> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSaldocr>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSaldocr> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSaldocr>(where);
        }

        #endregion
    }
}
