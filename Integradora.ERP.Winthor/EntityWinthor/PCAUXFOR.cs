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
    /// Classe referente a tabela PCAuxfor
    /// </summary>
    [XmlType("PCAUXFOR")]
    public class PCAuxfor : OracleTable
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES01
        /// Comentário: 
        /// </summary>
        private decimal vlmetames01;
        [XmlElement(ElementName = "VLMETAMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames01
        {
            get { return  vlmetames01; }
            set {  vlmetames01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES02
        /// Comentário: 
        /// </summary>
        private decimal vlmetames02;
        [XmlElement(ElementName = "VLMETAMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames02
        {
            get { return  vlmetames02; }
            set {  vlmetames02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES03
        /// Comentário: 
        /// </summary>
        private decimal vlmetames03;
        [XmlElement(ElementName = "VLMETAMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames03
        {
            get { return  vlmetames03; }
            set {  vlmetames03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES04
        /// Comentário: 
        /// </summary>
        private decimal vlmetames04;
        [XmlElement(ElementName = "VLMETAMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames04
        {
            get { return  vlmetames04; }
            set {  vlmetames04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES05
        /// Comentário: 
        /// </summary>
        private decimal vlmetames05;
        [XmlElement(ElementName = "VLMETAMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames05
        {
            get { return  vlmetames05; }
            set {  vlmetames05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES06
        /// Comentário: 
        /// </summary>
        private decimal vlmetames06;
        [XmlElement(ElementName = "VLMETAMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames06
        {
            get { return  vlmetames06; }
            set {  vlmetames06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES07
        /// Comentário: 
        /// </summary>
        private decimal vlmetames07;
        [XmlElement(ElementName = "VLMETAMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames07
        {
            get { return  vlmetames07; }
            set {  vlmetames07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES08
        /// Comentário: 
        /// </summary>
        private decimal vlmetames08;
        [XmlElement(ElementName = "VLMETAMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames08
        {
            get { return  vlmetames08; }
            set {  vlmetames08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES09
        /// Comentário: 
        /// </summary>
        private decimal vlmetames09;
        [XmlElement(ElementName = "VLMETAMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames09
        {
            get { return  vlmetames09; }
            set {  vlmetames09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES10
        /// Comentário: 
        /// </summary>
        private decimal vlmetames10;
        [XmlElement(ElementName = "VLMETAMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames10
        {
            get { return  vlmetames10; }
            set {  vlmetames10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES11
        /// Comentário: 
        /// </summary>
        private decimal vlmetames11;
        [XmlElement(ElementName = "VLMETAMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames11
        {
            get { return  vlmetames11; }
            set {  vlmetames11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMES12
        /// Comentário: 
        /// </summary>
        private decimal vlmetames12;
        [XmlElement(ElementName = "VLMETAMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetames12
        {
            get { return  vlmetames12; }
            set {  vlmetames12 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAuxfor()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUXFOR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAuxfor> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAuxfor>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAuxfor> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAuxfor>(where);
        }

        #endregion
    }
}
