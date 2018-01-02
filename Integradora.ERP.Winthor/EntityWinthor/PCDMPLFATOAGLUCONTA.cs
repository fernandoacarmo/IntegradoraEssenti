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
    /// Classe referente a tabela PCDmplfatoagluconta
    /// </summary>
    [XmlType("PCDMPLFATOAGLUCONTA")]
    public class PCDmplfatoagluconta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Coment�rio: C�digo Conta
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Coment�rio: M�s onde ocorreu o lan�amento.
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZALANC
        /// Coment�rio: Natureza Lan�amento
        /// </summary>
        private string naturezalanc;
        [XmlElement(ElementName = "NATUREZALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naturezalanc
        {
            get { return  naturezalanc; }
            set {  naturezalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFATOAGLUTINACAO
        /// Coment�rio: Sequencial Combina��o Fato Cont�bil x Aglutina��o
        /// </summary>
        private decimal numfatoaglutinacao;
        [XmlElement(ElementName = "NUMFATOAGLUTINACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Numfatoaglutinacao
        {
            get { return  numfatoaglutinacao; }
            set {  numfatoaglutinacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor do lan�amento
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDmplfatoagluconta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDMPLFATOAGLUCONTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDmplfatoagluconta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDmplfatoagluconta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDmplfatoagluconta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDmplfatoagluconta>(where);
        }

        #endregion
    }
}
