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
    /// Classe referente a tabela PCWmsbalancaleitura
    /// </summary>
    [XmlType("PCWMSBALANCALEITURA")]
    public class PCWmsbalancaleitura : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APELIDO
        /// Comentário: Apelido
        /// </summary>
        private string apelido;
        [XmlElement(ElementName = "APELIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Apelido
        {
            get { return  apelido; }
            set {  apelido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data
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
        /// Propriedade referente ao campo: ID_SESSAO
        /// Comentário: ID da Seção
        /// </summary>
        private decimal id_sessao;
        [XmlElement(ElementName = "ID_SESSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Id_Sessao
        {
            get { return  id_sessao; }
            set {  id_sessao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LEITURA
        /// Comentário: Leitura
        /// </summary>
        private decimal leitura;
        [XmlElement(ElementName = "LEITURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Leitura
        {
            get { return  leitura; }
            set {  leitura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: Matricula
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
        /// Propriedade referente ao campo: RETORNO
        /// Comentário: Retorno
        /// </summary>
        private string retorno;
        [XmlElement(ElementName = "RETORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Retorno
        {
            get { return  retorno; }
            set {  retorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Comentário: Rotina
        /// </summary>
        private decimal rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOLICITACAO
        /// Comentário: Solicitação
        /// </summary>
        private string solicitacao;
        [XmlElement(ElementName = "SOLICITACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Solicitacao
        {
            get { return  solicitacao; }
            set {  solicitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Status
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
        /// Propriedade referente ao campo: TERMINAL
        /// Comentário: Terminal
        /// </summary>
        private string terminal;
        [XmlElement(ElementName = "TERMINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Terminal
        {
            get { return  terminal; }
            set {  terminal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TERMINALCLI
        /// Comentário: Terminalcli
        /// </summary>
        private string terminalcli;
        [XmlElement(ElementName = "TERMINALCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Terminalcli
        {
            get { return  terminalcli; }
            set {  terminalcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo
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
        public PCWmsbalancaleitura()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSBALANCALEITURA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmsbalancaleitura> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsbalancaleitura.GetStringConnection());
            return ba.Listar<PCWmsbalancaleitura>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmsbalancaleitura> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsbalancaleitura.GetStringConnection());
            return ba.Existe<PCWmsbalancaleitura>(where);
        }

        #endregion
    }
}
