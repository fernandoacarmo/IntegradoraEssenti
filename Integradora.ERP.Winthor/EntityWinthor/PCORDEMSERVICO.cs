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
    /// Classe referente a tabela PCOrdemservico
    /// </summary>
    [XmlType("PCORDEMSERVICO")]
    public class PCOrdemservico : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: Indica o c�digo do cliente.
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
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: Indica o c�digo de cobran�a.
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITENTE
        /// Coment�rio: Indica o c�digo emitente.
        /// </summary>
        private decimal codemitente;
        [XmlElement(ElementName = "CODEMITENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemitente
        {
            get { return  codemitente; }
            set {  codemitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo filial .
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
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: Indica o c�digo plano de pagamento.
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINC
        /// Coment�rio: Indica o c�digo do produto principal.
        /// </summary>
        private decimal codprodprinc;
        [XmlElement(ElementName = "CODPRODPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodprinc
        {
            get { return  codprodprinc; }
            set {  codprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRCA
        /// Coment�rio: Indica o c�digo RCA.
        /// </summary>
        private decimal codrca;
        [XmlElement(ElementName = "CODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrca
        {
            get { return  codrca; }
            set {  codrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAEXPORTACAO
        /// Coment�rio: Armazena a data de exporta��o da ordem de servi�o.
        /// </summary>
        private DateTime? dataexportacao;
        [XmlElement(ElementName = "DATAEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataexportacao
        {
            get { return  dataexportacao; }
            set {  dataexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Indica a data de cadastro.
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
        /// Propriedade referente ao campo: DTCANCEL
        /// Coment�rio: Indica a data de cancelamento.
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
        /// Propriedade referente ao campo: DTFECHA
        /// Coment�rio: Indica a data de fechamento.
        /// </summary>
        private DateTime? dtfecha;
        [XmlElement(ElementName = "DTFECHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecha
        {
            get { return  dtfecha; }
            set {  dtfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVTERM
        /// Coment�rio: Indica a data previs�o t�rmino. .
        /// </summary>
        private DateTime? dtprevterm;
        [XmlElement(ElementName = "DTPREVTERM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevterm
        {
            get { return  dtprevterm; }
            set {  dtprevterm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERADAAUTOMATIC
        /// Coment�rio: Campo para armazenar se a ordem de servi�o foi gerada automaticamente.
        /// </summary>
        private string geradaautomatic;
        [XmlElement(ElementName = "GERADAAUTOMATIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geradaautomatic
        {
            get { return  geradaautomatic; }
            set {  geradaautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOCANCEL
        /// Coment�rio: Indica o motivo cancelamento.
        /// </summary>
        private string motivocancel;
        [XmlElement(ElementName = "MOTIVOCANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Motivocancel
        {
            get { return  motivocancel; }
            set {  motivocancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATOCOMODATO
        /// Coment�rio: Campo para armazenar o n�mero de transa��o da remessa de devolu��o de comodato.
        /// </summary>
        private decimal numcontratocomodato;
        [XmlElement(ElementName = "NUMCONTRATOCOMODATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcontratocomodato
        {
            get { return  numcontratocomodato; }
            set {  numcontratocomodato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: Indica o n�mero ordem de servi�o.
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
        /// Propriedade referente ao campo: NUMOSPRIMARIA
        /// Coment�rio: Indica o n�mero da ordem de servi�o pai.
        /// </summary>
        private decimal numosprimaria;
        [XmlElement(ElementName = "NUMOSPRIMARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numosprimaria
        {
            get { return  numosprimaria; }
            set {  numosprimaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: Indica o n�mero do pedido de venda.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIE
        /// Coment�rio: Indica o c�digo do produto principal.
        /// </summary>
        private string numserie;
        [XmlElement(ElementName = "NUMSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserie
        {
            get { return  numserie; }
            set {  numserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSDEVCOMODATO
        /// Coment�rio: Campo para armazenar o n�mero de transa��o da remessa de devolu��o de comodato.
        /// </summary>
        private decimal numtransdevcomodato;
        [XmlElement(ElementName = "NUMTRANSDEVCOMODATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransdevcomodato
        {
            get { return  numtransdevcomodato; }
            set {  numtransdevcomodato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAPROD
        /// Coment�rio: Indica o n�mero da transa��o de venda produtos.
        /// </summary>
        private decimal numtransvendaprod;
        [XmlElement(ElementName = "NUMTRANSVENDAPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaprod
        {
            get { return  numtransvendaprod; }
            set {  numtransvendaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDASERV
        /// Coment�rio: Indica o n�mero da transa��o de venda servi�os.
        /// </summary>
        private decimal numtransvendaserv;
        [XmlElement(ElementName = "NUMTRANSVENDASERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaserv
        {
            get { return  numtransvendaserv; }
            set {  numtransvendaserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANVENDACOMODATO
        /// Coment�rio: Campo para armazenar o n�mero de transa��o da remessa de comodato que � gerada ao faturar a ordem de servi�o.
        /// </summary>
        private decimal numtranvendacomodato;
        [XmlElement(ElementName = "NUMTRANVENDACOMODATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranvendacomodato
        {
            get { return  numtranvendacomodato; }
            set {  numtranvendacomodato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Indica a observa��o da orderm de servi�o.
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
        /// Propriedade referente ao campo: REMESSACOMODATO
        /// Coment�rio: Campo para armazenar o n�mero da remessa de comodato que o funcion�rio ir� instalar no cliente.
        /// </summary>
        private decimal remessacomodato;
        [XmlElement(ElementName = "REMESSACOMODATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Remessacomodato
        {
            get { return  remessacomodato; }
            set {  remessacomodato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Indica a situa��o OS.
        /// </summary>
        private decimal situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOS
        /// Coment�rio: Indica o tipo OS.
        /// </summary>
        private decimal tipoos;
        [XmlElement(ElementName = "TIPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Tipoos
        {
            get { return  tipoos; }
            set {  tipoos = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOrdemservico()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORDEMSERVICO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOrdemservico> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrdemservico>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOrdemservico> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrdemservico>(where);
        }

        #endregion
    }
}
