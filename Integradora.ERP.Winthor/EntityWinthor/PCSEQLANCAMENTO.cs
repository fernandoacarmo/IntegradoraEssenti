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
    /// Classe referente a tabela PCSeqlancamento
    /// </summary>
    [XmlType("PCSEQLANCAMENTO")]
    public class PCSeqlancamento : OracleTable
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
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Comentário: 
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES01
        /// Comentário: 
        /// </summary>
        private decimal mes01;
        [XmlElement(ElementName = "MES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes01
        {
            get { return  mes01; }
            set {  mes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES02
        /// Comentário: 
        /// </summary>
        private decimal mes02;
        [XmlElement(ElementName = "MES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes02
        {
            get { return  mes02; }
            set {  mes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES03
        /// Comentário: 
        /// </summary>
        private decimal mes03;
        [XmlElement(ElementName = "MES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes03
        {
            get { return  mes03; }
            set {  mes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES04
        /// Comentário: 
        /// </summary>
        private decimal mes04;
        [XmlElement(ElementName = "MES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes04
        {
            get { return  mes04; }
            set {  mes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES05
        /// Comentário: 
        /// </summary>
        private decimal mes05;
        [XmlElement(ElementName = "MES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes05
        {
            get { return  mes05; }
            set {  mes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES06
        /// Comentário: 
        /// </summary>
        private decimal mes06;
        [XmlElement(ElementName = "MES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes06
        {
            get { return  mes06; }
            set {  mes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES07
        /// Comentário: 
        /// </summary>
        private decimal mes07;
        [XmlElement(ElementName = "MES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes07
        {
            get { return  mes07; }
            set {  mes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES08
        /// Comentário: 
        /// </summary>
        private decimal mes08;
        [XmlElement(ElementName = "MES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes08
        {
            get { return  mes08; }
            set {  mes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES09
        /// Comentário: 
        /// </summary>
        private decimal mes09;
        [XmlElement(ElementName = "MES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes09
        {
            get { return  mes09; }
            set {  mes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES10
        /// Comentário: 
        /// </summary>
        private decimal mes10;
        [XmlElement(ElementName = "MES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes10
        {
            get { return  mes10; }
            set {  mes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES11
        /// Comentário: 
        /// </summary>
        private decimal mes11;
        [XmlElement(ElementName = "MES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes11
        {
            get { return  mes11; }
            set {  mes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES12
        /// Comentário: 
        /// </summary>
        private decimal mes12;
        [XmlElement(ElementName = "MES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Mes12
        {
            get { return  mes12; }
            set {  mes12 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSeqlancamento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSEQLANCAMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSeqlancamento> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSeqlancamento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSeqlancamento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSeqlancamento>(where);
        }

        #endregion
    }
}
