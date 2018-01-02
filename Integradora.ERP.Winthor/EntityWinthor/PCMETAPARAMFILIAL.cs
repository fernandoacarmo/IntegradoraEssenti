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
    /// Classe referente a tabela PCMetaparamfilial
    /// </summary>
    [XmlType("PCMETAPARAMFILIAL")]
    public class PCMetaparamfilial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ASSUNTOS
        /// Coment�rio: 
        /// </summary>
        private string assuntos;
        [XmlElement(ElementName = "ASSUNTOS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Assuntos
        {
            get { return  assuntos; }
            set {  assuntos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTULO
        /// Coment�rio: C�digo da tabela de r�tulos.
        /// </summary>
        private string codrotulo;
        [XmlElement(ElementName = "CODROTULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codrotulo
        {
            get { return  codrotulo; }
            set {  codrotulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTER
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtalter;
        [XmlElement(ElementName = "DTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalter
        {
            get { return  dtalter; }
            set {  dtalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EDITAVEL
        /// Coment�rio: 
        /// </summary>
        private string editavel;
        [XmlElement(ElementName = "EDITAVEL", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Editavel
        {
            get { return  editavel; }
            set {  editavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Coment�rio: 
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDNAFILIAL
        /// Coment�rio: 
        /// </summary>
        private decimal idnafilial;
        [XmlElement(ElementName = "IDNAFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Idnafilial
        {
            get { return  idnafilial; }
            set {  idnafilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDPARAMPAI
        /// Coment�rio: 
        /// </summary>
        private decimal idparampai;
        [XmlElement(ElementName = "IDPARAMPAI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Idparampai
        {
            get { return  idparampai; }
            set {  idparampai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Coment�rio: Nome do par�metro.
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,34)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEM
        /// Coment�rio: Informar NULL. Para os par�metros antigos, importados de outras tabelas, foram usados "CO" = gravar tamb�m na PCCONSUM, "FI" = gravar tamb�m na PCFILIAL.
        /// </summary>
        private string origem;
        [XmlElement(ElementName = "ORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Origem
        {
            get { return  origem; }
            set {  origem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQUISACAMPOCODIGO
        /// Coment�rio: 
        /// </summary>
        private string pesquisacampocodigo;
        [XmlElement(ElementName = "PESQUISACAMPOCODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Pesquisacampocodigo
        {
            get { return  pesquisacampocodigo; }
            set {  pesquisacampocodigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQUISACAMPODESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string pesquisacampodescricao;
        [XmlElement(ElementName = "PESQUISACAMPODESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Pesquisacampodescricao
        {
            get { return  pesquisacampodescricao; }
            set {  pesquisacampodescricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQUISACAMPOS
        /// Coment�rio: 
        /// </summary>
        private string pesquisacampos;
        [XmlElement(ElementName = "PESQUISACAMPOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Pesquisacampos
        {
            get { return  pesquisacampos; }
            set {  pesquisacampos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQUISACODROTINACADASTRO
        /// Coment�rio: 
        /// </summary>
        private decimal pesquisacodrotinacadastro;
        [XmlElement(ElementName = "PESQUISACODROTINACADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pesquisacodrotinacadastro
        {
            get { return  pesquisacodrotinacadastro; }
            set {  pesquisacodrotinacadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQUISAPARAMNOWHERE
        /// Coment�rio: 
        /// </summary>
        private string pesquisaparamnowhere;
        [XmlElement(ElementName = "PESQUISAPARAMNOWHERE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Pesquisaparamnowhere
        {
            get { return  pesquisaparamnowhere; }
            set {  pesquisaparamnowhere = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQUISASQLADICIONAL
        /// Coment�rio: Instru��o SQL a acrescentar na SQL usada na janela de pesquisa.
        /// </summary>
        private string pesquisasqladicional;
        [XmlElement(ElementName = "PESQUISASQLADICIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Pesquisasqladicional
        {
            get { return  pesquisasqladicional; }
            set {  pesquisasqladicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQUISATABELA
        /// Coment�rio: Nome da tabela usada na janela de pesquisa.
        /// </summary>
        private string pesquisatabela;
        [XmlElement(ElementName = "PESQUISATABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Pesquisatabela
        {
            get { return  pesquisatabela; }
            set {  pesquisatabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORFILIAL
        /// Coment�rio: Por filial.
        /// </summary>
        private string porfilial;
        [XmlElement(ElementName = "PORFILIAL", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Porfilial
        {
            get { return  porfilial; }
            set {  porfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMDADOS
        /// Coment�rio: Tamanho para o tipo de dados.
        /// </summary>
        private decimal tamdados;
        [XmlElement(ElementName = "TAMDADOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tamdados
        {
            get { return  tamdados; }
            set {  tamdados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTOAJUDA
        /// Coment�rio: Texto da ajuda.
        /// </summary>
        private string textoajuda;
        [XmlElement(ElementName = "TEXTOAJUDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Textoajuda
        {
            get { return  textoajuda; }
            set {  textoajuda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODADOS
        /// Coment�rio: 
        /// </summary>
        private string tipodados;
        [XmlElement(ElementName = "TIPODADOS", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipodados
        {
            get { return  tipodados; }
            set {  tipodados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULO
        /// Coment�rio: T�tulo do par�metro.
        /// </summary>
        private string titulo;
        [XmlElement(ElementName = "TITULO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,300)]
        public string Titulo
        {
            get { return  titulo; }
            set {  titulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDEFAULT
        /// Coment�rio: Valor padr�o para o par�metro.
        /// </summary>
        private string valordefault;
        [XmlElement(ElementName = "VALORDEFAULT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Valordefault
        {
            get { return  valordefault; }
            set {  valordefault = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFALSE
        /// Coment�rio: Valor do campo que representa "False" caso o tipo de dados seja boolean.
        /// </summary>
        private string valorfalse;
        [XmlElement(ElementName = "VALORFALSE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Valorfalse
        {
            get { return  valorfalse; }
            set {  valorfalse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTRUE
        /// Coment�rio: 
        /// </summary>
        private string valortrue;
        [XmlElement(ElementName = "VALORTRUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Valortrue
        {
            get { return  valortrue; }
            set {  valortrue = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMetaparamfilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETAPARAMFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMetaparamfilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetaparamfilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMetaparamfilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetaparamfilial>(where);
        }

        #endregion
    }
}
