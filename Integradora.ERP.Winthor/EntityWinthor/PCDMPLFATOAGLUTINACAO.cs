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
        /// Comentário: Código Aglutinação
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
        /// Comentário: Código DMPL
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
        /// Comentário: Código Fato Contábil
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
        /// Comentário: Código Plano de Contas
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
        /// Comentário: Sequencial Combinação Fato Contábil x Aglutinação
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
        /// Comentário: Ordem Coluna
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
        /// Comentário: Ordem Linnha
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDmplfatoaglutinacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDmplfatoaglutinacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
