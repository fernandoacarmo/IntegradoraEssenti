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
    /// Classe referente a tabela PCMetaoscomodc
    /// </summary>
    [XmlType("PCMETAOSCOMODC")]
    public class PCMetaoscomodc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Campo para armazenar o código da filial em que a meta será validada
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Campo para armazenar a descrição da meta.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Campo para armazenar a data do cancelamento da meta.
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Comentário: Campo para armazenar a data fim da meta.
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: Campo para armazenar a data de inicio da meta.
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMETA
        /// Comentário: Campo para armazenar o código da meta
        /// </summary>
        private decimal nummeta;
        [XmlElement(ElementName = "NUMMETA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Nummeta
        {
            get { return  nummeta; }
            set {  nummeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Campo para armazenar as observações da meta.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMETA
        /// Comentário: Campo para armazenar o tipo da meta
        /// </summary>
        private decimal tipometa;
        [XmlElement(ElementName = "TIPOMETA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public decimal Tipometa
        {
            get { return  tipometa; }
            set {  tipometa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TODASCONDICOES
        /// Comentário: Campo para armazenar se para na apuração da meta o participante deve alcançar todos os critérios da meta.
        /// </summary>
        private string todascondicoes;
        [XmlElement(ElementName = "TODASCONDICOES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Todascondicoes
        {
            get { return  todascondicoes; }
            set {  todascondicoes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TODOSFUNC
        /// Comentário: Campo para armazenar se todos os funcionários participam da meta.
        /// </summary>
        private string todosfunc;
        [XmlElement(ElementName = "TODOSFUNC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Todosfunc
        {
            get { return  todosfunc; }
            set {  todosfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TODOSRCA
        /// Comentário: Campo para armazenar se todos os RCAs participam da meta.
        /// </summary>
        private string todosrca;
        [XmlElement(ElementName = "TODOSRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Todosrca
        {
            get { return  todosrca; }
            set {  todosrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TODOSSUP
        /// Comentário: Campo para armazenar se todos os supervisores participam da meta.
        /// </summary>
        private string todossup;
        [XmlElement(ElementName = "TODOSSUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Todossup
        {
            get { return  todossup; }
            set {  todossup = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMetaoscomodc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETAOSCOMODC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMetaoscomodc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetaoscomodc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMetaoscomodc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetaoscomodc>(where);
        }

        #endregion
    }
}
