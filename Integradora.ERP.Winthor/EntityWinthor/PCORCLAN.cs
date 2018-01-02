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
    /// Classe referente a tabela PCOrclan
    /// </summary>
    [XmlType("PCORCLAN")]
    public class PCOrclan : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: 
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Comentário: 
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES01
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes01;
        [XmlElement(ElementName = "VLORCMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes01
        {
            get { return  vlorcmes01; }
            set {  vlorcmes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES02
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes02;
        [XmlElement(ElementName = "VLORCMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes02
        {
            get { return  vlorcmes02; }
            set {  vlorcmes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES03
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes03;
        [XmlElement(ElementName = "VLORCMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes03
        {
            get { return  vlorcmes03; }
            set {  vlorcmes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES04
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes04;
        [XmlElement(ElementName = "VLORCMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes04
        {
            get { return  vlorcmes04; }
            set {  vlorcmes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES05
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes05;
        [XmlElement(ElementName = "VLORCMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes05
        {
            get { return  vlorcmes05; }
            set {  vlorcmes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES06
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes06;
        [XmlElement(ElementName = "VLORCMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes06
        {
            get { return  vlorcmes06; }
            set {  vlorcmes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES07
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes07;
        [XmlElement(ElementName = "VLORCMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes07
        {
            get { return  vlorcmes07; }
            set {  vlorcmes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES08
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes08;
        [XmlElement(ElementName = "VLORCMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes08
        {
            get { return  vlorcmes08; }
            set {  vlorcmes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES09
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes09;
        [XmlElement(ElementName = "VLORCMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes09
        {
            get { return  vlorcmes09; }
            set {  vlorcmes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES10
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes10;
        [XmlElement(ElementName = "VLORCMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes10
        {
            get { return  vlorcmes10; }
            set {  vlorcmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES11
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes11;
        [XmlElement(ElementName = "VLORCMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes11
        {
            get { return  vlorcmes11; }
            set {  vlorcmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORCMES12
        /// Comentário: 
        /// </summary>
        private decimal vlorcmes12;
        [XmlElement(ElementName = "VLORCMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlorcmes12
        {
            get { return  vlorcmes12; }
            set {  vlorcmes12 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOrclan()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORCLAN";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOrclan> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrclan>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOrclan> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrclan>(where);
        }

        #endregion
    }
}
