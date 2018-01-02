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
    /// Classe referente a tabela PCGrade
    /// </summary>
    [XmlType("PCGRADE")]
    public class PCGrade : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CLASSE
        /// Comentário: 
        /// </summary>
        private string classe;
        [XmlElement(ElementName = "CLASSE", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public string Classe
        {
            get { return  classe; }
            set {  classe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRADE
        /// Comentário: 
        /// </summary>
        private decimal codgrade;
        [XmlElement(ElementName = "CODGRADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codgrade
        {
            get { return  codgrade; }
            set {  codgrade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM01
        /// Comentário: 
        /// </summary>
        private string tam01;
        [XmlElement(ElementName = "TAM01", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam01
        {
            get { return  tam01; }
            set {  tam01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM02
        /// Comentário: 
        /// </summary>
        private string tam02;
        [XmlElement(ElementName = "TAM02", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam02
        {
            get { return  tam02; }
            set {  tam02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM03
        /// Comentário: 
        /// </summary>
        private string tam03;
        [XmlElement(ElementName = "TAM03", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam03
        {
            get { return  tam03; }
            set {  tam03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM04
        /// Comentário: 
        /// </summary>
        private string tam04;
        [XmlElement(ElementName = "TAM04", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam04
        {
            get { return  tam04; }
            set {  tam04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM05
        /// Comentário: 
        /// </summary>
        private string tam05;
        [XmlElement(ElementName = "TAM05", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam05
        {
            get { return  tam05; }
            set {  tam05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM06
        /// Comentário: 
        /// </summary>
        private string tam06;
        [XmlElement(ElementName = "TAM06", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam06
        {
            get { return  tam06; }
            set {  tam06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM07
        /// Comentário: 
        /// </summary>
        private string tam07;
        [XmlElement(ElementName = "TAM07", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam07
        {
            get { return  tam07; }
            set {  tam07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM08
        /// Comentário: 
        /// </summary>
        private string tam08;
        [XmlElement(ElementName = "TAM08", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam08
        {
            get { return  tam08; }
            set {  tam08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM09
        /// Comentário: 
        /// </summary>
        private string tam09;
        [XmlElement(ElementName = "TAM09", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam09
        {
            get { return  tam09; }
            set {  tam09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM10
        /// Comentário: 
        /// </summary>
        private string tam10;
        [XmlElement(ElementName = "TAM10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam10
        {
            get { return  tam10; }
            set {  tam10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM11
        /// Comentário: 
        /// </summary>
        private string tam11;
        [XmlElement(ElementName = "TAM11", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam11
        {
            get { return  tam11; }
            set {  tam11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM12
        /// Comentário: 
        /// </summary>
        private string tam12;
        [XmlElement(ElementName = "TAM12", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam12
        {
            get { return  tam12; }
            set {  tam12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM13
        /// Comentário: 
        /// </summary>
        private string tam13;
        [XmlElement(ElementName = "TAM13", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam13
        {
            get { return  tam13; }
            set {  tam13 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM14
        /// Comentário: 
        /// </summary>
        private string tam14;
        [XmlElement(ElementName = "TAM14", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam14
        {
            get { return  tam14; }
            set {  tam14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM15
        /// Comentário: 
        /// </summary>
        private string tam15;
        [XmlElement(ElementName = "TAM15", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam15
        {
            get { return  tam15; }
            set {  tam15 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM16
        /// Comentário: 
        /// </summary>
        private string tam16;
        [XmlElement(ElementName = "TAM16", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam16
        {
            get { return  tam16; }
            set {  tam16 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM17
        /// Comentário: 
        /// </summary>
        private string tam17;
        [XmlElement(ElementName = "TAM17", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam17
        {
            get { return  tam17; }
            set {  tam17 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM18
        /// Comentário: 
        /// </summary>
        private string tam18;
        [XmlElement(ElementName = "TAM18", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam18
        {
            get { return  tam18; }
            set {  tam18 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM19
        /// Comentário: 
        /// </summary>
        private string tam19;
        [XmlElement(ElementName = "TAM19", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam19
        {
            get { return  tam19; }
            set {  tam19 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAM20
        /// Comentário: 
        /// </summary>
        private string tam20;
        [XmlElement(ElementName = "TAM20", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tam20
        {
            get { return  tam20; }
            set {  tam20 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCGrade()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGRADE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCGrade> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGrade>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCGrade> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGrade>(where);
        }

        #endregion
    }
}
