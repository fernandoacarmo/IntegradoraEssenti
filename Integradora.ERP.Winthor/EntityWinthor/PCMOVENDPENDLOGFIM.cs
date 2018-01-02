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
    /// Classe referente a tabela PCMovendpendlogfim
    /// </summary>
    [XmlType("PCMOVENDPENDLOGFIM")]
    public class PCMovendpendlogfim : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Codigo da rotina que gerou o erro.
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data ocorrida.
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAULTIMA
        /// Comentário: Ultima da de ocorrência.
        /// </summary>
        private DateTime? dataultima;
        [XmlElement(ElementName = "DATAULTIMA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataultima
        {
            get { return  dataultima; }
            set {  dataultima = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrlção do Erro.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,300)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXESSAO
        /// Comentário: Tipo do Erro.
        /// </summary>
        private string exessao;
        [XmlElement(ElementName = "EXESSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Exessao
        {
            get { return  exessao; }
            set {  exessao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAQUINA
        /// Comentário: Maquina que gerou o log.
        /// </summary>
        private string maquina;
        [XmlElement(ElementName = "MAQUINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Maquina
        {
            get { return  maquina; }
            set {  maquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: matricula do usuário logado.
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Comentário: Número OS.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALOCORRENCIA
        /// Comentário: Total de ocorrência.
        /// </summary>
        private decimal totalocorrencia;
        [XmlElement(ElementName = "TOTALOCORRENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Totalocorrencia
        {
            get { return  totalocorrencia; }
            set {  totalocorrencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOSISTEMA
        /// Comentário: Usuário do sistema.
        /// </summary>
        private string usuariosistema;
        [XmlElement(ElementName = "USUARIOSISTEMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Usuariosistema
        {
            get { return  usuariosistema; }
            set {  usuariosistema = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMovendpendlogfim()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVENDPENDLOGFIM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovendpendlogfim> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovendpendlogfim>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMovendpendlogfim> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovendpendlogfim>(where);
        }

        #endregion
    }
}
