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
    /// Classe referente a tabela PCAgendafuncionario
    /// </summary>
    [XmlType("PCAGENDAFUNCIONARIO")]
    public class PCAgendafuncionario : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODSERVICO
        /// Comentário: Código do Serviço.
        /// </summary>
        private decimal codservico;
        [XmlElement(ElementName = "CODSERVICO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codservico
        {
            get { return  codservico; }
            set {  codservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data de execução do serviço.
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFIM
        /// Comentário: Hora final da execução do serviço.
        /// </summary>
        private decimal horafim;
        [XmlElement(ElementName = "HORAFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafim
        {
            get { return  horafim; }
            set {  horafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIO
        /// Comentário: Hora de inicio da execução do serviço.
        /// </summary>
        private decimal horainicio;
        [XmlElement(ElementName = "HORAINICIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Horainicio
        {
            get { return  horainicio; }
            set {  horainicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: Matrícula do Funcionário.
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFIM
        /// Comentário: Minuto final da execução do serviço.
        /// </summary>
        private decimal minutofim;
        [XmlElement(ElementName = "MINUTOFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutofim
        {
            get { return  minutofim; }
            set {  minutofim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOINICIO
        /// Comentário: Minuto de inicio da execução do serviço.
        /// </summary>
        private decimal minutoinicio;
        [XmlElement(ElementName = "MINUTOINICIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Minutoinicio
        {
            get { return  minutoinicio; }
            set {  minutoinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Comentário: Ordem de Serviço para execução do serviço.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOSSERVICO
        /// Comentário: 
        /// </summary>
        private decimal numosservico;
        [XmlElement(ElementName = "NUMOSSERVICO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numosservico
        {
            get { return  numosservico; }
            set {  numosservico = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAgendafuncionario()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDAFUNCIONARIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAgendafuncionario> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgendafuncionario>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAgendafuncionario> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgendafuncionario>(where);
        }

        #endregion
    }
}
