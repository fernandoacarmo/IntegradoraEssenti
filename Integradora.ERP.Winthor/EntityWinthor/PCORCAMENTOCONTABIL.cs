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
    /// Classe referente a tabela PCOrcamentocontabil
    /// </summary>
    [XmlType("PCORCAMENTOCONTABIL")]
    public class PCOrcamentocontabil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: Ano do or�amento
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
        /// Coment�rio: C�digo da filial do or�amento
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
        /// Coment�rio: C�digo da conta contabil
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
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Coment�rio: C�digo reduzido da conta contabil
        /// </summary>
        private string codreduzido_pc;
        [XmlElement(ElementName = "CODREDUZIDO_PC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public string Codreduzido_Pc
        {
            get { return  codreduzido_pc; }
            set {  codreduzido_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES01
        /// Coment�rio: Valor or�ado m�s de Janeiro
        /// </summary>
        private decimal vlrorcmes01;
        [XmlElement(ElementName = "VLRORCMES01", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes01
        {
            get { return  vlrorcmes01; }
            set {  vlrorcmes01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES02
        /// Coment�rio: Valor or�ado m�s de Fevereiro
        /// </summary>
        private decimal vlrorcmes02;
        [XmlElement(ElementName = "VLRORCMES02", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes02
        {
            get { return  vlrorcmes02; }
            set {  vlrorcmes02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES03
        /// Coment�rio: Valor or�ado m�s de Mar�o
        /// </summary>
        private decimal vlrorcmes03;
        [XmlElement(ElementName = "VLRORCMES03", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes03
        {
            get { return  vlrorcmes03; }
            set {  vlrorcmes03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES04
        /// Coment�rio: Valor or�ado m�s de Abril
        /// </summary>
        private decimal vlrorcmes04;
        [XmlElement(ElementName = "VLRORCMES04", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes04
        {
            get { return  vlrorcmes04; }
            set {  vlrorcmes04 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES05
        /// Coment�rio: Valor or�ado m�s de Maio
        /// </summary>
        private decimal vlrorcmes05;
        [XmlElement(ElementName = "VLRORCMES05", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes05
        {
            get { return  vlrorcmes05; }
            set {  vlrorcmes05 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES06
        /// Coment�rio: Valor or�ado m�s de Junho
        /// </summary>
        private decimal vlrorcmes06;
        [XmlElement(ElementName = "VLRORCMES06", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes06
        {
            get { return  vlrorcmes06; }
            set {  vlrorcmes06 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES07
        /// Coment�rio: Valor or�ado m�s de Julho
        /// </summary>
        private decimal vlrorcmes07;
        [XmlElement(ElementName = "VLRORCMES07", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes07
        {
            get { return  vlrorcmes07; }
            set {  vlrorcmes07 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES08
        /// Coment�rio: Valor or�ado m�s de Agosto
        /// </summary>
        private decimal vlrorcmes08;
        [XmlElement(ElementName = "VLRORCMES08", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes08
        {
            get { return  vlrorcmes08; }
            set {  vlrorcmes08 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES09
        /// Coment�rio: Valor or�ado m�s de Setembro
        /// </summary>
        private decimal vlrorcmes09;
        [XmlElement(ElementName = "VLRORCMES09", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes09
        {
            get { return  vlrorcmes09; }
            set {  vlrorcmes09 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES10
        /// Coment�rio: Valor or�ado m�s de Outubro
        /// </summary>
        private decimal vlrorcmes10;
        [XmlElement(ElementName = "VLRORCMES10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes10
        {
            get { return  vlrorcmes10; }
            set {  vlrorcmes10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES11
        /// Coment�rio: Valor or�ado m�s de Novembro
        /// </summary>
        private decimal vlrorcmes11;
        [XmlElement(ElementName = "VLRORCMES11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes11
        {
            get { return  vlrorcmes11; }
            set {  vlrorcmes11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRORCMES12
        /// Coment�rio: Valor or�ado m�s de Dezembro
        /// </summary>
        private decimal vlrorcmes12;
        [XmlElement(ElementName = "VLRORCMES12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrorcmes12
        {
            get { return  vlrorcmes12; }
            set {  vlrorcmes12 = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOrcamentocontabil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORCAMENTOCONTABIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOrcamentocontabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrcamentocontabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOrcamentocontabil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrcamentocontabil>(where);
        }

        #endregion
    }
}
