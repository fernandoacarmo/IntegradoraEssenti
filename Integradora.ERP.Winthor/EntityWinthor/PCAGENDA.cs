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
    /// Classe referente a tabela PCAgenda
    /// </summary>
    [XmlType("PCAGENDA")]
    public class PCAgenda : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAGENDA
        /// Comentário: Código da agenda originado da sequence DFSEQ_PCAGENDA.
        /// </summary>
        private decimal codagenda;
        [XmlElement(ElementName = "CODAGENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codagenda
        {
            get { return  codagenda; }
            set {  codagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do cliente que será atendido.
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
        /// Propriedade referente ao campo: CODFUNCAB
        /// Comentário: Código do Operador que abriu a agenda.
        /// </summary>
        private decimal codfuncab;
        [XmlElement(ElementName = "CODFUNCAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncab
        {
            get { return  codfuncab; }
            set {  codfuncab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Comentário: Código Motivo Agenda
        /// </summary>
        private decimal codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERADORA
        /// Comentário: Código do Operador que deverá cumprir a agenda.
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
        /// Propriedade referente ao campo: CODPESQUISA
        /// Comentário: Indica o código da pesquisa.
        /// </summary>
        private decimal codpesquisa;
        [XmlElement(ElementName = "CODPESQUISA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codpesquisa
        {
            get { return  codpesquisa; }
            set {  codpesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATO
        /// Comentário: Indica o nome do contato.
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
        /// Comentário: Data a qual a agenda deverá ser cumprida.
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
        /// Comentário: Dia da semana que a agenda será cumprida.
        /// </summary>
        private decimal diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAB
        /// Comentário: Data de abertura.
        /// </summary>
        private DateTime? dtab;
        [XmlElement(ElementName = "DTAB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtab
        {
            get { return  dtab; }
            set {  dtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTO
        /// Comentário: Indica a data de fechamento da agenda.
        /// </summary>
        private DateTime? dtfechamento;
        [XmlElement(ElementName = "DTFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamento
        {
            get { return  dtfechamento; }
            set {  dtfechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Comentário: Hora do dia para cumprimento da agenda.
        /// </summary>
        private DateTime? hora;
        [XmlElement(ElementName = "HORA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Texto do agendamento.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESPOSTA
        /// Comentário: Resposta do cliente.
        /// </summary>
        private string resposta;
        [XmlElement(ElementName = "RESPOSTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Resposta
        {
            get { return  resposta; }
            set {  resposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Campo que define se a agenda esta aberta ou encerrada.
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Indica o tipo Agenda.
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAgenda()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAGENDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAgenda> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAgenda>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAgenda> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAgenda>(where);
        }

        #endregion
    }
}
