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
    /// Classe referente a tabela PCDicionariochecklist
    /// </summary>
    [XmlType("PCDICIONARIOCHECKLIST")]
    public class PCDicionariochecklist : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Comentário: Informar se o checklist esta ativo
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCHECKLIST
        /// Comentário: Código do checklist
        /// </summary>
        private decimal codchecklist;
        [XmlElement(ElementName = "CODCHECKLIST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codchecklist
        {
            get { return  codchecklist; }
            set {  codchecklist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINACAD
        /// Comentário: Código da rotina de necessário para complementar o checklist
        /// </summary>
        private decimal codrotinacad;
        [XmlElement(ElementName = "CODROTINACAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrotinacad
        {
            get { return  codrotinacad; }
            set {  codrotinacad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data de cadastro do checklist
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEOBJETO
        /// Comentário: Nome da tabela relacionada ao rótulo
        /// </summary>
        private string nomeobjeto;
        [XmlElement(ElementName = "NOMEOBJETO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomeobjeto
        {
            get { return  nomeobjeto; }
            set {  nomeobjeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROCESSAMENTO
        /// Comentário: Informar se o checklist e de processamento
        /// </summary>
        private string processamento;
        [XmlElement(ElementName = "PROCESSAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Processamento
        {
            get { return  processamento; }
            set {  processamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUENCIA
        /// Comentário: Sequência de execução do checklist
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SQLGERACAO
        /// Comentário: Script de geração de informação
        /// </summary>
        private string sqlgeracao;
        [XmlElement(ElementName = "SQLGERACAO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Sqlgeracao
        {
            get { return  sqlgeracao; }
            set {  sqlgeracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SQLVALIDACAO
        /// Comentário: Script de validação
        /// </summary>
        private string sqlvalidacao;
        [XmlElement(ElementName = "SQLVALIDACAO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Sqlvalidacao
        {
            get { return  sqlvalidacao; }
            set {  sqlvalidacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULO
        /// Comentário: Título do checklist
        /// </summary>
        private string titulo;
        [XmlElement(ElementName = "TITULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Titulo
        {
            get { return  titulo; }
            set {  titulo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDicionariochecklist()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDICIONARIOCHECKLIST";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDicionariochecklist> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDicionariochecklist>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDicionariochecklist> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDicionariochecklist>(where);
        }

        #endregion
    }
}
