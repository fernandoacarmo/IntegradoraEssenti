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
    /// Classe referente a tabela PCTipoordemservico
    /// </summary>
    [XmlType("PCTIPOORDEMSERVICO")]
    public class PCTipoordemservico : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTERASTATUSOS
        /// Coment�rio: Alterar automaticamente o status da OS no faturamento
        /// </summary>
        private string alterastatusos;
        [XmlElement(ElementName = "ALTERASTATUSOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alterastatusos
        {
            get { return  alterastatusos; }
            set {  alterastatusos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPO
        /// Coment�rio: Indica o c�digo do t�po da ordem de servi�o.
        /// </summary>
        private decimal codtipo;
        [XmlElement(ElementName = "CODTIPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codtipo
        {
            get { return  codtipo; }
            set {  codtipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Indica a descri��o da ordem de servi�o.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARCONTRECEBERPRODUTO
        /// Coment�rio: Gerar contas a receber produtos utilizados.
        /// </summary>
        private string gerarcontreceberproduto;
        [XmlElement(ElementName = "GERARCONTRECEBERPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarcontreceberproduto
        {
            get { return  gerarcontreceberproduto; }
            set {  gerarcontreceberproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARCONTRECEBERSERVICO
        /// Coment�rio: Gerar contas a receber Servi�os prestados.
        /// </summary>
        private string gerarcontreceberservico;
        [XmlElement(ElementName = "GERARCONTRECEBERSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarcontreceberservico
        {
            get { return  gerarcontreceberservico; }
            set {  gerarcontreceberservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAREMESSCOMODATO
        /// Coment�rio: Campo para definir que ao faturar a Ordem de servi�o deve ser gerada uma nota de remessa de comodato
        /// </summary>
        private string geraremesscomodato;
        [XmlElement(ElementName = "GERAREMESSCOMODATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraremesscomodato
        {
            get { return  geraremesscomodato; }
            set {  geraremesscomodato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARNOTATV1
        /// Coment�rio: Gerar nota fiscal TV1
        /// </summary>
        private string gerarnotatv1;
        [XmlElement(ElementName = "GERARNOTATV1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarnotatv1
        {
            get { return  gerarnotatv1; }
            set {  gerarnotatv1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OSCOMODATO
        /// Coment�rio: Campo para definir se o tipo de servi�o � de uma ordem de servi�o de comodato
        /// </summary>
        private string oscomodato;
        [XmlElement(ElementName = "OSCOMODATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Oscomodato
        {
            get { return  oscomodato; }
            set {  oscomodato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPANTECLIENTE
        /// Coment�rio: Participante cliente.
        /// </summary>
        private string participantecliente;
        [XmlElement(ElementName = "PARTICIPANTECLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Participantecliente
        {
            get { return  participantecliente; }
            set {  participantecliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPANTEFUNC
        /// Coment�rio: Participante de funcionario
        /// </summary>
        private string participantefunc;
        [XmlElement(ElementName = "PARTICIPANTEFUNC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Participantefunc
        {
            get { return  participantefunc; }
            set {  participantefunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPANTERCA
        /// Coment�rio: Participante RCA.
        /// </summary>
        private string participanterca;
        [XmlElement(ElementName = "PARTICIPANTERCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Participanterca
        {
            get { return  participanterca; }
            set {  participanterca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPANTESUPERVISOR
        /// Coment�rio: Participante supervisor.
        /// </summary>
        private string participantesupervisor;
        [XmlElement(ElementName = "PARTICIPANTESUPERVISOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Participantesupervisor
        {
            get { return  participantesupervisor; }
            set {  participantesupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEFATOSABERTA
        /// Coment�rio: Campo para definir se � permitido Faturar Ordens de servi�os que est�o com o status �Aberta�
        /// </summary>
        private string permitefatosaberta;
        [XmlElement(ElementName = "PERMITEFATOSABERTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitefatosaberta
        {
            get { return  permitefatosaberta; }
            set {  permitefatosaberta = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTipoordemservico()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOORDEMSERVICO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTipoordemservico> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipoordemservico>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTipoordemservico> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipoordemservico>(where);
        }

        #endregion
    }
}
