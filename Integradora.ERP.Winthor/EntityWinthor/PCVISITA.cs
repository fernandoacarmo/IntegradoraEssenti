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
    /// Classe referente a tabela PCVisita
    /// </summary>
    [XmlType("PCVISITA")]
    public class PCVisita : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ASSUNTO
        /// Coment�rio: O assunto tratado no atendimento.
        /// </summary>
        private string assunto;
        [XmlElement(ElementName = "ASSUNTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Assunto
        {
            get { return  assunto; }
            set {  assunto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CANCELADO
        /// Coment�rio: Informa est� cancelado
        /// </summary>
        private string cancelado;
        [XmlElement(ElementName = "CANCELADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cancelado
        {
            get { return  cancelado; }
            set {  cancelado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do Cliente visitado.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTAGENDA
        /// Coment�rio: Armazena o Motivo de Agendamento informado na Rotina 1912 quando o atendimento, proveniente de uma agenda
        /// </summary>
        private decimal codmotagenda;
        [XmlElement(ElementName = "CODMOTAGENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotagenda
        {
            get { return  codmotagenda; }
            set {  codmotagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Coment�rio: C�digo do motivo da visita, originado da tabela PCMOTVISITA (rotina PCINF592).
        /// </summary>
        private decimal codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERADORA
        /// Coment�rio: C�digo do Operador que atendeu o cliente.
        /// </summary>
        private decimal codoperadora;
        [XmlElement(ElementName = "CODOPERADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codoperadora
        {
            get { return  codoperadora; }
            set {  codoperadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVISITA
        /// Coment�rio: C�digo da visita.
        /// </summary>
        private decimal codvisita;
        [XmlElement(ElementName = "CODVISITA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codvisita
        {
            get { return  codvisita; }
            set {  codvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATO
        /// Coment�rio: Nome do contato no Cliente.
        /// </summary>
        private string contato;
        [XmlElement(ElementName = "CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contato
        {
            get { return  contato; }
            set {  contato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data da visita.
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
        /// Propriedade referente ao campo: DIASEMANA
        /// Coment�rio: 
        /// </summary>
        private string diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRFINAL
        /// Coment�rio: 
        /// </summary>
        private decimal hrfinal;
        [XmlElement(ElementName = "HRFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Hrfinal
        {
            get { return  hrfinal; }
            set {  hrfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRINICIAL
        /// Coment�rio: 
        /// </summary>
        private decimal hrinicial;
        [XmlElement(ElementName = "HRINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Hrinicial
        {
            get { return  hrinicial; }
            set {  hrinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFINAL
        /// Coment�rio: 
        /// </summary>
        private decimal minutofinal;
        [XmlElement(ElementName = "MINUTOFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutofinal
        {
            get { return  minutofinal; }
            set {  minutofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOINICIAL
        /// Coment�rio: 
        /// </summary>
        private decimal minutoinicial;
        [XmlElement(ElementName = "MINUTOINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoinicial
        {
            get { return  minutoinicial; }
            set {  minutoinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: Observa��o de cancelamento
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQVISITA
        /// Coment�rio: Sequ�ncia para visita��o de clientes.
        /// </summary>
        private decimal seqvisita;
        [XmlElement(ElementName = "SEQVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Seqvisita
        {
            get { return  seqvisita; }
            set {  seqvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: Informar m�dulo que originou a visita.
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPERACAO
        /// Coment�rio: Tipo de opera��o do atendimento (Telemarketing Ativo, Telemarketing Passivo (Receptivo), Balconista, Telepedido, Balc�o Reserva).
        /// </summary>
        private string tipooperacao;
        [XmlElement(ElementName = "TIPOOPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipooperacao
        {
            get { return  tipooperacao; }
            set {  tipooperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VISITADO
        /// Coment�rio: 
        /// </summary>
        private string visitado;
        [XmlElement(ElementName = "VISITADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Visitado
        {
            get { return  visitado; }
            set {  visitado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCVisita()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVISITA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCVisita> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVisita>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCVisita> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVisita>(where);
        }

        #endregion
    }
}
