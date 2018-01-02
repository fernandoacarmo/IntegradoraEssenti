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
    /// Classe referente a tabela PCParametros
    /// </summary>
    [XmlType("PCPARAMETROS")]
    public class PCParametros : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BUSCA
        /// Coment�rio: Utiliza na Consulta	Utiliza na Consulta
        /// </summary>
        private string busca;
        [XmlElement(ElementName = "BUSCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Busca
        {
            get { return  busca; }
            set {  busca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Coment�rio: C�digo do Relat�rio	C�digo do Relat�rio
        /// </summary>
        private decimal codrelatorio;
        [XmlElement(ElementName = "CODRELATORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrelatorio
        {
            get { return  codrelatorio; }
            set {  codrelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPONENTE
        /// Coment�rio: Tipo de Componente	Tipo de Componente
        /// </summary>
        private string componente;
        [XmlElement(ElementName = "COMPONENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Componente
        {
            get { return  componente; }
            set {  componente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSULTA
        /// Coment�rio: SQL Consulta	SQL Consulta
        /// </summary>
        private string consulta;
        [XmlElement(ElementName = "CONSULTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Consulta
        {
            get { return  consulta; }
            set {  consulta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS
        /// Coment�rio: Itens Contidos	Itens Contidos
        /// </summary>
        private string itens;
        [XmlElement(ElementName = "ITENS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Itens
        {
            get { return  itens; }
            set {  itens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LEGENDA
        /// Coment�rio: Legendo da Coluna	Legendo da Coluna
        /// </summary>
        private string legenda;
        [XmlElement(ElementName = "LEGENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Legenda
        {
            get { return  legenda; }
            set {  legenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Coment�rio: Nome da coluna	Nome da coluna
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGATORIO
        /// Coment�rio: Coluna Obrigatoria	Coluna Obrigatoria
        /// </summary>
        private string obrigatorio;
        [XmlElement(ElementName = "OBRIGATORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigatorio
        {
            get { return  obrigatorio; }
            set {  obrigatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Coment�rio: Ordem de apresenta��o	Ordem de apresenta��o
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSESQUERDA
        /// Coment�rio: Posi��o Esquerda	Posi��o Esquerda
        /// </summary>
        private decimal posesquerda;
        [XmlElement(ElementName = "POSESQUERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Posesquerda
        {
            get { return  posesquerda; }
            set {  posesquerda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHO
        /// Coment�rio: Tamanho da Coluna	Tamanho da Coluna
        /// </summary>
        private decimal tamanho;
        [XmlElement(ElementName = "TAMANHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tamanho
        {
            get { return  tamanho; }
            set {  tamanho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor da Coluna	Valor da Coluna
        /// </summary>
        private string valor;
        [XmlElement(ElementName = "VALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCParametros()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARAMETROS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCParametros> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParametros>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCParametros> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParametros>(where);
        }

        #endregion
    }
}
