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
    /// Classe referente a tabela PCDmplfatoaglutinacao
    /// </summary>
    [XmlType("PCDMPLFATOAGLUTINACAO")]
    public class PCDmplfatoaglutinacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAGLUTINACAO
        /// Coment�rio: C�digo Aglutina��o
        /// </summary>
        private string codaglutinacao;
        [XmlElement(ElementName = "CODAGLUTINACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Codaglutinacao
        {
            get { return  codaglutinacao; }
            set {  codaglutinacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDMPL
        /// Coment�rio: C�digo DMPL
        /// </summary>
        private decimal coddmpl;
        [XmlElement(ElementName = "CODDMPL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Coddmpl
        {
            get { return  coddmpl; }
            set {  coddmpl = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFATOCONTABIL
        /// Coment�rio: C�digo Fato Cont�bil
        /// </summary>
        private string codfatocontabil;
        [XmlElement(ElementName = "CODFATOCONTABIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codfatocontabil
        {
            get { return  codfatocontabil; }
            set {  codfatocontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Coment�rio: C�digo Plano de Contas
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
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
        /// Propriedade referente ao campo: ORDEMCOLUNA
        /// Coment�rio: Ordem Coluna
        /// </summary>
        private decimal ordemcoluna;
        [XmlElement(ElementName = "ORDEMCOLUNA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Ordemcoluna
        {
            get { return  ordemcoluna; }
            set {  ordemcoluna = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMLINHA
        /// Coment�rio: Ordem Linnha
        /// </summary>
        private decimal ordemlinha;
        [XmlElement(ElementName = "ORDEMLINHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Ordemlinha
        {
            get { return  ordemlinha; }
            set {  ordemlinha = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDmplfatoaglutinacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDMPLFATOAGLUTINACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDmplfatoaglutinacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDmplfatoaglutinacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDmplfatoaglutinacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDmplfatoaglutinacao>(where);
        }

        #endregion
    }
}
