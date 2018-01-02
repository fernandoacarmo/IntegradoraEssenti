using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityAjuri
{
    /// <summary>
    /// Classe referente a tabela ESTCancelamento
    /// </summary>
    [XmlType("ESTCANCELAMENTO")]
    public class ESTCancelamento : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CFOP
        /// Comentário: 
        /// </summary>
        private string cfop;
        [XmlElement(ElementName = "CFOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public string Cfop
        {
            get { return cfop; }
            set { cfop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 10)]
        public decimal Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtalteracao
        {
            get { return dtalteracao; }
            set { dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtinclusao
        {
            get { return dtinclusao; }
            set { dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORARIO
        /// Comentário: 
        /// </summary>
        private string horario;
        [XmlElement(ElementName = "HORARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAJURI
        /// Comentário: 
        /// </summary>
        private string numajuri;
        [XmlElement(ElementName = "NUMAJURI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Numajuri
        {
            get { return numajuri; }
            set { numajuri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Comentário: 
        /// </summary>
        private decimal numero;
        [XmlElement(ElementName = "NUMERO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 10)]
        public decimal Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO
        /// Comentário: 
        /// </summary>
        private string obsintegracao;
        [XmlElement(ElementName = "OBSINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 4000)]
        public string Obsintegracao
        {
            get { return obsintegracao; }
            set { obsintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: 
        /// </summary>
        private decimal semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal Semaforo
        {
            get { return semaforo; }
            set { semaforo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 3)]
        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 10)]
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSACAOCLIENTE
        /// Comentário: 
        /// </summary>
        private string transacaocliente;
        [XmlElement(ElementName = "TRANSACAOCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Transacaocliente
        {
            get { return transacaocliente; }
            set { transacaocliente = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTCancelamento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTCANCELAMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTCancelamento> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTCancelamento.GetStringConnection());
            return ba.Listar<ESTCancelamento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTCancelamento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTCancelamento.GetStringConnection());
            return ba.Existe<ESTCancelamento>(where);
        }

        #endregion
    }
}
