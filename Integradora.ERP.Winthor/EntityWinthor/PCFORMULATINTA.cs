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
    /// Classe referente a tabela PCFormulatinta
    /// </summary>
    [XmlType("PCFORMULATINTA")]
    public class PCFormulatinta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTERNATIVA
        /// Comentário: 
        /// </summary>
        private string alternativa;
        [XmlElement(ElementName = "ALTERNATIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Alternativa
        {
            get { return  alternativa; }
            set {  alternativa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: 
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANOFINAL
        /// Comentário: Determina o ano final dos carros que a cor da tinta atende. 
        /// </summary>
        private decimal anofinal;
        [XmlElement(ElementName = "ANOFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Anofinal
        {
            get { return  anofinal; }
            set {  anofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANOINICIAL
        /// Comentário: Determina o ano inicial dos carros que a cor da tinta atende. 
        /// </summary>
        private decimal anoinicial;
        [XmlElement(ElementName = "ANOINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Anoinicial
        {
            get { return  anoinicial; }
            set {  anoinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVEPRINCIPAL
        /// Comentário: 
        /// </summary>
        private string chaveprincipal;
        [XmlElement(ElementName = "CHAVEPRINCIPAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Chaveprincipal
        {
            get { return  chaveprincipal; }
            set {  chaveprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBASE
        /// Comentário: 
        /// </summary>
        private string codbase;
        [XmlElement(ElementName = "CODBASE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codbase
        {
            get { return  codbase; }
            set {  codbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORMULA
        /// Comentário: 
        /// </summary>
        private string codformula;
        [XmlElement(ElementName = "CODFORMULA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Codformula
        {
            get { return  codformula; }
            set {  codformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Comentário: CÓD. DO GRUPO DA TINTA
        /// </summary>
        private string codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOOEM_FABRICANTE
        /// Comentário: 
        /// </summary>
        private string codigooem_fabricante;
        [XmlElement(ElementName = "CODIGOOEM_FABRICANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Codigooem_Fabricante
        {
            get { return  codigooem_fabricante; }
            set {  codigooem_fabricante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHA
        /// Comentário: 
        /// </summary>
        private string codlinha;
        [XmlElement(ElementName = "CODLINHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codlinha
        {
            get { return  codlinha; }
            set {  codlinha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Comentário: 
        /// </summary>
        private decimal codmaquina;
        [XmlElement(ElementName = "CODMAQUINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmaquina
        {
            get { return  codmaquina; }
            set {  codmaquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMONTADORA
        /// Comentário: 
        /// </summary>
        private string codmontadora;
        [XmlElement(ElementName = "CODMONTADORA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codmontadora
        {
            get { return  codmontadora; }
            set {  codmontadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODQUALIDADE
        /// Comentário: 
        /// </summary>
        private string codqualidade;
        [XmlElement(ElementName = "CODQUALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codqualidade
        {
            get { return  codqualidade; }
            set {  codqualidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSIGLAPAIS
        /// Comentário: 
        /// </summary>
        private string codsiglapais;
        [XmlElement(ElementName = "CODSIGLAPAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codsiglapais
        {
            get { return  codsiglapais; }
            set {  codsiglapais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCFORMULA
        /// Comentário: 
        /// </summary>
        private string descformula;
        [XmlElement(ElementName = "DESCFORMULA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,70)]
        public string Descformula
        {
            get { return  descformula; }
            set {  descformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPRODUTO
        /// Comentário: Identifica o nome do produto do qual a formula de tinta pertence. 
        /// </summary>
        private string nomeproduto;
        [XmlElement(ElementName = "NOMEPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomeproduto
        {
            get { return  nomeproduto; }
            set {  nomeproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMESUBPRODUTO
        /// Comentário: Identifica o nome do subproduto do qual a formula de tinta pertence. 
        /// </summary>
        private string nomesubproduto;
        [XmlElement(ElementName = "NOMESUBPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomesubproduto
        {
            get { return  nomesubproduto; }
            set {  nomesubproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOESPECIFICOFORMULA
        /// Comentário: 
        /// </summary>
        private decimal pesoespecificoformula;
        [XmlElement(ElementName = "PESOESPECIFICOFORMULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Pesoespecificoformula
        {
            get { return  pesoespecificoformula; }
            set {  pesoespecificoformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: situação da formula de tinta
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFormulatinta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORMULATINTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFormulatinta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFormulatinta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFormulatinta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFormulatinta>(where);
        }

        #endregion
    }
}
