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
    /// Classe referente a tabela PCRelatorio
    /// </summary>
    [XmlType("PCRELATORIO")]
    public class PCRelatorio : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDIRETORIO
        /// Comentário: 
        /// </summary>
        private decimal coddiretorio;
        [XmlElement(ElementName = "CODDIRETORIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Coddiretorio
        {
            get { return  coddiretorio; }
            set {  coddiretorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Comentário: 
        /// </summary>
        private decimal codrelatorio;
        [XmlElement(ElementName = "CODRELATORIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codrelatorio
        {
            get { return  codrelatorio; }
            set {  codrelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSQL
        /// Comentário: 
        /// </summary>
        private decimal codsql;
        [XmlElement(ElementName = "CODSQL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsql
        {
            get { return  codsql; }
            set {  codsql = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMODIFICADO
        /// Comentário: 
        /// </summary>
        private DateTime? dtmodificado;
        [XmlElement(ElementName = "DTMODIFICADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmodificado
        {
            get { return  dtmodificado; }
            set {  dtmodificado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXCLUIDO
        /// Comentário: 
        /// </summary>
        private DateTime? excluido;
        [XmlElement(ElementName = "EXCLUIDO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Excluido
        {
            get { return  excluido; }
            set {  excluido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RELATORIO
        /// Comentário: 
        /// </summary>
        private string relatorio;
        [XmlElement(ElementName = "RELATORIO", DataType = "BLOB", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Relatorio
        {
            get { return  relatorio; }
            set {  relatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHO
        /// Comentário: 
        /// </summary>
        private decimal tamanho;
        [XmlElement(ElementName = "TAMANHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Tamanho
        {
            get { return  tamanho; }
            set {  tamanho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORELATORIO
        /// Comentário: 
        /// </summary>
        private decimal tiporelatorio;
        [XmlElement(ElementName = "TIPORELATORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Tiporelatorio
        {
            get { return  tiporelatorio; }
            set {  tiporelatorio = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRelatorio()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRELATORIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRelatorio> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRelatorio>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRelatorio> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRelatorio>(where);
        }

        #endregion
    }
}
