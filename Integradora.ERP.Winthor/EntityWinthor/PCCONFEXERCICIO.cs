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
    /// Classe referente a tabela PCConfexercicio
    /// </summary>
    [XmlType("PCCONFEXERCICIO")]
    public class PCConfexercicio : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODCENTROCUSTO
        /// Coment�rio: 
        /// </summary>
        private decimal codcentrocusto;
        [XmlElement(ElementName = "CODCENTROCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codcentrocusto
        {
            get { return  codcentrocusto; }
            set {  codcentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADOR
        /// Coment�rio: 
        /// </summary>
        private decimal codcontador;
        [XmlElement(ElementName = "CODCONTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codcontador
        {
            get { return  codcontador; }
            set {  codcontador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOFILIAL
        /// Coment�rio: 
        /// </summary>
        private decimal codgrupofilial;
        [XmlElement(ElementName = "CODGRUPOFILIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codgrupofilial
        {
            get { return  codgrupofilial; }
            set {  codgrupofilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Coment�rio: 
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSOCIO
        /// Coment�rio: 
        /// </summary>
        private decimal codsocio;
        [XmlElement(ElementName = "CODSOCIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codsocio
        {
            get { return  codsocio; }
            set {  codsocio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMAEXIBIRSALDO
        /// Coment�rio: Indica a forma exibi��o saldos.
        /// </summary>
        private string formaexibirsaldo;
        [XmlElement(ElementName = "FORMAEXIBIRSALDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Formaexibirsaldo
        {
            get { return  formaexibirsaldo; }
            set {  formaexibirsaldo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQLANCPORFILIAL
        /// Coment�rio: Sequ�ncia de lan�amentos por filial
        /// </summary>
        private string seqlancporfilial;
        [XmlElement(ElementName = "SEQLANCPORFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Seqlancporfilial
        {
            get { return  seqlancporfilial; }
            set {  seqlancporfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTOBALANCO
        /// Coment�rio: Indica texto do balan�o.
        /// </summary>
        private string textobalanco;
        [XmlElement(ElementName = "TEXTOBALANCO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Textobalanco
        {
            get { return  textobalanco; }
            set {  textobalanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTOCONSFISCAL
        /// Coment�rio: Indica texto conselho fiscal.
        /// </summary>
        private string textoconsfiscal;
        [XmlElement(ElementName = "TEXTOCONSFISCAL", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Textoconsfiscal
        {
            get { return  textoconsfiscal; }
            set {  textoconsfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTOINFORMACOESSPED
        /// Coment�rio: Texto para outras informa��es do SPED
        /// </summary>
        private string textoinformacoessped;
        [XmlElement(ElementName = "TEXTOINFORMACOESSPED", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Textoinformacoessped
        {
            get { return  textoinformacoessped; }
            set {  textoinformacoessped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZA_CENTROCUSTO
        /// Coment�rio: 
        /// </summary>
        private string utiliza_centrocusto;
        [XmlElement(ElementName = "UTILIZA_CENTROCUSTO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Utiliza_Centrocusto
        {
            get { return  utiliza_centrocusto; }
            set {  utiliza_centrocusto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCConfexercicio()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFEXERCICIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConfexercicio> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConfexercicio>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCConfexercicio> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConfexercicio>(where);
        }

        #endregion
    }
}
