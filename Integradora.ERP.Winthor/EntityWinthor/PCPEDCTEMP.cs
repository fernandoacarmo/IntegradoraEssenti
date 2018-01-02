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
    /// Classe referente a tabela PCPedctemp
    /// </summary>
    [XmlType("PCPEDCTEMP")]
    public class PCPedctemp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGRUPAMENTO
        /// Comentário: Informa de pedido será agrupado ou não
        /// </summary>
        private string agrupamento;
        [XmlElement(ElementName = "AGRUPAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agrupamento
        {
            get { return  agrupamento; }
            set {  agrupamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARQUIVO
        /// Comentário: 
        /// </summary>
        private string arquivo;
        [XmlElement(ElementName = "ARQUIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Arquivo
        {
            get { return  arquivo; }
            set {  arquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXAESTCLI
        /// Comentário: 
        /// </summary>
        private string baixaestcli;
        [XmlElement(ElementName = "BAIXAESTCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixaestcli
        {
            get { return  baixaestcli; }
            set {  baixaestcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXAESTLOJA
        /// Comentário: 
        /// </summary>
        private string baixaestloja;
        [XmlElement(ElementName = "BAIXAESTLOJA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixaestloja
        {
            get { return  baixaestloja; }
            set {  baixaestloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRANCATENDENCIA
        /// Comentário: Campo para armazenar o código da cobrança gerado pelo sistema da Tendência (recarga virtual). 
        /// </summary>
        private decimal? cobrancatendencia;
        [XmlElement(ElementName = "COBRANCATENDENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Cobrancatendencia
        {
            get { return  cobrancatendencia; }
            set {  cobrancatendencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODADMCARTAO
        /// Comentário: Indica o código de administradora do cartão de crédito.
        /// </summary>
        private string codadmcartao;
        [XmlElement(ElementName = "CODADMCARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codadmcartao
        {
            get { return  codadmcartao; }
            set {  codadmcartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATENDIMENTO
        /// Comentário: 
        /// </summary>
        private decimal? codatendimento;
        [XmlElement(ElementName = "CODATENDIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codatendimento
        {
            get { return  codatendimento; }
            set {  codatendimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAOTEF
        /// Comentário: Indica o código da autorização TEF.
        /// </summary>
        private decimal? codautorizacaotef;
        [XmlElement(ElementName = "CODAUTORIZACAOTEF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codautorizacaotef
        {
            get { return  codautorizacaotef; }
            set {  codautorizacaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAOTEFWEB
        /// Comentário: 
        /// </summary>
        private string codautorizacaotefweb;
        [XmlElement(ElementName = "CODAUTORIZACAOTEFWEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,128)]
        public string Codautorizacaotefweb
        {
            get { return  codautorizacaotefweb; }
            set {  codautorizacaotefweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLICONSIGNACAO
        /// Comentário: 
        /// </summary>
        private decimal? codcliconsignacao;
        [XmlElement(ElementName = "CODCLICONSIGNACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codcliconsignacao
        {
            get { return  codcliconsignacao; }
            set {  codcliconsignacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLINF
        /// Comentário: Codigo do cliente autorizador.
        /// </summary>
        private decimal? codclinf;
        [XmlElement(ElementName = "CODCLINF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codclinf
        {
            get { return  codclinf; }
            set {  codclinf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIRECEBEDOR
        /// Comentário: Codigo do cliente recebedor.
        /// </summary>
        private decimal? codclirecebedor;
        [XmlElement(ElementName = "CODCLIRECEBEDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codclirecebedor
        {
            get { return  codclirecebedor; }
            set {  codclirecebedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLITV8
        /// Comentário: Codigo  do cliente para venda TV8
        /// </summary>
        private decimal? codclitv8;
        [XmlElement(ElementName = "CODCLITV8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codclitv8
        {
            get { return  codclitv8; }
            set {  codclitv8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_OBTERNSU
        /// Comentário: Recebe o código do tipo de integração.
        /// </summary>
        private string esc_obternsu;
        [XmlElement(ElementName = "ESC_OBTERNSU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Esc_obternsu
        {
            get { return esc_obternsu; }
            set { esc_obternsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Comentário: 
        /// </summary>
        private decimal? codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDISTRIB
        /// Comentário: 
        /// </summary>
        private string coddistrib;
        [XmlElement(ElementName = "CODDISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Coddistrib
        {
            get { return  coddistrib; }
            set {  coddistrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITENTE
        /// Comentário: 
        /// </summary>
        private decimal? codemitente;
        [XmlElement(ElementName = "CODEMITENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codemitente
        {
            get { return  codemitente; }
            set {  codemitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDENT
        /// Comentário: Codigo de endereco de entrega
        /// </summary>
        private decimal? codendent;
        [XmlElement(ElementName = "CODENDENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codendent
        {
            get { return  codendent; }
            set {  codendent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDENTCLI
        /// Comentário: Código de endereço do cliente.
        /// </summary>
        private decimal? codendentcli;
        [XmlElement(ElementName = "CODENDENTCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codendentcli
        {
            get { return  codendentcli; }
            set {  codendentcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALNF
        /// Comentário: 
        /// </summary>
        private string codfilialnf;
        [XmlElement(ElementName = "CODFILIALNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialnf
        {
            get { return  codfilialnf; }
            set {  codfilialnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_AJUSTARFINANCEIRO
        /// Comentário: Define se o pedido temporário irá sofrer ajuste no financeiro após o faturamento
        /// </summary>
        private string esc_ajustarfinanceiro;
        [XmlElement(ElementName = "ESC_AJUSTARFINANCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string ESC_AjustarFinanceiro
        {
            get { return esc_ajustarfinanceiro; }
            set { esc_ajustarfinanceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Comentário: 
        /// </summary>
        private decimal? codfornecfrete;
        [XmlElement(ElementName = "CODFORNECFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codfornecfrete
        {
            get { return  codfornecfrete; }
            set {  codfornecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCX
        /// Comentário: 
        /// </summary>
        private decimal? codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNAOATENDIMENTO
        /// Comentário: 
        /// </summary>
        private decimal? codnaoatendimento;
        [XmlElement(ElementName = "CODNAOATENDIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Codnaoatendimento
        {
            get { return  codnaoatendimento; }
            set {  codnaoatendimento = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal? codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRETORNO
        /// Comentário: Codigo de retorno da tabela pcretornoimportarvendas
        /// </summary>
        private decimal? codretorno;
        [XmlElement(ElementName = "CODRETORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Codretorno
        {
            get { return  codretorno; }
            set {  codretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRETORNOS
        /// Comentário: Códigos de retornos
        /// </summary>
        private string codretornos;
        [XmlElement(ElementName = "CODRETORNOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Codretornos
        {
            get { return  codretornos; }
            set {  codretornos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR2
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor2;
        [XmlElement(ElementName = "CODSUPERVISOR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsupervisor2
        {
            get { return  codsupervisor2; }
            set {  codsupervisor2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR3
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor3;
        [XmlElement(ElementName = "CODSUPERVISOR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsupervisor3
        {
            get { return  codsupervisor3; }
            set {  codsupervisor3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSP
        /// Comentário: Codigo da Transportadora
        /// </summary>
        private decimal codtransp;
        [XmlElement(ElementName = "CODTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtransp
        {
            get { return  codtransp; }
            set {  codtransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR2
        /// Comentário: 
        /// </summary>
        private decimal codusur2;
        [XmlElement(ElementName = "CODUSUR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur2
        {
            get { return  codusur2; }
            set {  codusur2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR3
        /// Comentário: 
        /// </summary>
        private decimal codusur3;
        [XmlElement(ElementName = "CODUSUR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur3
        {
            get { return  codusur3; }
            set {  codusur3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Comentário: 
        /// </summary>
        private decimal condvenda;
        [XmlElement(ElementName = "CONDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Condvenda
        {
            get { return  condvenda; }
            set {  condvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUPOMDESCONTO
        /// Comentário: Número do cupom
        /// </summary>
        private string cupomdesconto;
        [XmlElement(ElementName = "CUPOMDESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Cupomdesconto
        {
            get { return  cupomdesconto; }
            set {  cupomdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURAPEDPALM
        /// Comentário: 
        /// </summary>
        private DateTime? dtaberturapedpalm;
        [XmlElement(ElementName = "DTABERTURAPEDPALM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaberturapedpalm
        {
            get { return  dtaberturapedpalm; }
            set {  dtaberturapedpalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAGENDAENTREGA
        /// Comentário: 
        /// </summary>
        private DateTime? dtagendaentrega;
        [XmlElement(ElementName = "DTAGENDAENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtagendaentrega
        {
            get { return  dtagendaentrega; }
            set {  dtagendaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Comentário: 
        /// </summary>
        private DateTime? dtentrega;
        [XmlElement(ElementName = "DTENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentrega
        {
            get { return  dtentrega; }
            set {  dtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTOPEDPALM
        /// Comentário: 
        /// </summary>
        private DateTime? dtfechamentopedpalm;
        [XmlElement(ElementName = "DTFECHAMENTOPEDPALM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamentopedpalm
        {
            get { return  dtfechamentopedpalm; }
            set {  dtfechamentopedpalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtimportacao;
        [XmlElement(ElementName = "DTIMPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacao
        {
            get { return  dtimportacao; }
            set {  dtimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC1
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc1;
        [XmlElement(ElementName = "DTVENC1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc1
        {
            get { return  dtvenc1; }
            set {  dtvenc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC2
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc2;
        [XmlElement(ElementName = "DTVENC2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc2
        {
            get { return  dtvenc2; }
            set {  dtvenc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC3
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc3;
        [XmlElement(ElementName = "DTVENC3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc3
        {
            get { return  dtvenc3; }
            set {  dtvenc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCOBRANCA
        /// Comentário: 
        /// </summary>
        private decimal eancobranca;
        [XmlElement(ElementName = "EANCOBRANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eancobranca
        {
            get { return  eancobranca; }
            set {  eancobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCOMPRADOR
        /// Comentário: 
        /// </summary>
        private decimal eancomprador;
        [XmlElement(ElementName = "EANCOMPRADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eancomprador
        {
            get { return  eancomprador; }
            set {  eancomprador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANENTREGA
        /// Comentário: 
        /// </summary>
        private decimal eanentrega;
        [XmlElement(ElementName = "EANENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eanentrega
        {
            get { return  eanentrega; }
            set {  eanentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANLOCALENTREGA
        /// Comentário: 
        /// </summary>
        private decimal eanlocalentrega;
        [XmlElement(ElementName = "EANLOCALENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eanlocalentrega
        {
            get { return  eanlocalentrega; }
            set {  eanlocalentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIEMANIF
        /// Comentário: 
        /// </summary>
        private string especiemanif;
        [XmlElement(ElementName = "ESPECIEMANIF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Especiemanif
        {
            get { return  especiemanif; }
            set {  especiemanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Comentário: Indica se o pedido temporário foi exportado. 
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEDESPACHO
        /// Comentário: 
        /// </summary>
        private string fretedespacho;
        [XmlElement(ElementName = "FRETEDESPACHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fretedespacho
        {
            get { return  fretedespacho; }
            set {  fretedespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEREDESPACHO
        /// Comentário: 
        /// </summary>
        private string freteredespacho;
        [XmlElement(ElementName = "FRETEREDESPACHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Freteredespacho
        {
            get { return  freteredespacho; }
            set {  freteredespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Comentário: 
        /// </summary>
        private decimal hora;
        [XmlElement(ElementName = "HORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCOB
        /// Comentário: Recebe o identificador da cobrança.
        /// </summary>
        private decimal idcob;
        [XmlElement(ElementName = "IDCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Idcob
        {
            get { return  idcob; }
            set {  idcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Comentário: 
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Comentário: Recebe o código da integradora de dados.
        /// </summary>
        private decimal integradora;
        [XmlElement(ElementName = "INTEGRADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Integradora
        {
            get { return  integradora; }
            set {  integradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LAYOUTXML
        /// Comentário: 
        /// </summary>
        private string layoutxml;
        [XmlElement(ElementName = "LAYOUTXML", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Layoutxml
        {
            get { return  layoutxml; }
            set {  layoutxml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Comentário: 
        /// </summary>
        private decimal minuto;
        [XmlElement(ElementName = "MINUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minuto
        {
            get { return  minuto; }
            set {  minuto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUTEF
        /// Comentário: Indica o número de transação no TEF.
        /// </summary>
        private string nsutef;
        [XmlElement(ElementName = "NSUTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsutef
        {
            get { return  nsutef; }
            set {  nsutef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: 
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARMANIF
        /// Comentário: 
        /// </summary>
        private decimal numcarmanif;
        [XmlElement(ElementName = "NUMCARMANIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcarmanif
        {
            get { return  numcarmanif; }
            set {  numcarmanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Comentário: 
        /// </summary>
        private decimal numcupom;
        [XmlElement(ElementName = "NUMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcupom
        {
            get { return  numcupom; }
            set {  numcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEMPENHO
        /// Comentário: 
        /// </summary>
        private string numempenho;
        [XmlElement(ElementName = "NUMEMPENHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numempenho
        {
            get { return  numempenho; }
            set {  numempenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFONTERECURSO
        /// Comentário: 
        /// </summary>
        private string numfonterecurso;
        [XmlElement(ElementName = "NUMFONTERECURSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numfonterecurso
        {
            get { return  numfonterecurso; }
            set {  numfonterecurso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITENS
        /// Comentário: 
        /// </summary>
        private decimal numitens;
        [XmlElement(ElementName = "NUMITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numitens
        {
            get { return  numitens; }
            set {  numitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTACONSIG
        /// Comentário: 
        /// </summary>
        private decimal numnotaconsig;
        [XmlElement(ElementName = "NUMNOTACONSIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotaconsig
        {
            get { return  numnotaconsig; }
            set {  numnotaconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAMANIF
        /// Comentário: 
        /// </summary>
        private decimal numnotamanif;
        [XmlElement(ElementName = "NUMNOTAMANIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotamanif
        {
            get { return  numnotamanif; }
            set {  numnotamanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Comentário: 
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMPEDBNF
        /// Comentário: 
        /// </summary>
        private decimal numpedbnf;
        [XmlElement(ElementName = "NUMPEDBNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedbnf
        {
            get { return  numpedbnf; }
            set {  numpedbnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDCLI
        /// Comentário: 
        /// </summary>
        private string numpedcli;
        [XmlElement(ElementName = "NUMPEDCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Numpedcli
        {
            get { return  numpedcli; }
            set {  numpedcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Comentário: 
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDENTFUT
        /// Comentário: 
        /// </summary>
        private decimal numpedentfut;
        [XmlElement(ElementName = "NUMPEDENTFUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedentfut
        {
            get { return  numpedentfut; }
            set {  numpedentfut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDORIGEM
        /// Comentário: 
        /// </summary>
        private decimal numpedorigem;
        [XmlElement(ElementName = "NUMPEDORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedorigem
        {
            get { return  numpedorigem; }
            set {  numpedorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Comentário: 
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedrca
        {
            get { return  numpedrca; }
            set {  numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDTV1
        /// Comentário: Número do pedido TV1
        /// </summary>
        private decimal numpedtv1;
        [XmlElement(ElementName = "NUMPEDTV1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedtv1
        {
            get { return  numpedtv1; }
            set {  numpedtv1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDWEB
        /// Comentário: 
        /// </summary>
        private decimal numpedweb;
        [XmlElement(ElementName = "NUMPEDWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public decimal Numpedweb
        {
            get { return  numpedweb; }
            set {  numpedweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPROCESSO
        /// Comentário: 
        /// </summary>
        private string numprocesso;
        [XmlElement(ElementName = "NUMPROCESSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numprocesso
        {
            get { return  numprocesso; }
            set {  numprocesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAOBROKER
        /// Comentário: Número da região utilizada para esta venda.
        /// </summary>
        private decimal numregiaobroker;
        [XmlElement(ElementName = "NUMREGIAOBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiaobroker
        {
            get { return  numregiaobroker; }
            set {  numregiaobroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Comentário: 
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASMAPASEP
        /// Comentário: 
        /// </summary>
        private decimal? numviasmapasep;
        [XmlElement(ElementName = "NUMVIASMAPASEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Numviasmapasep
        {
            get { return  numviasmapasep; }
            set {  numviasmapasep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA1
        /// Comentário: 
        /// </summary>
        private string obsentrega1;
        [XmlElement(ElementName = "OBSENTREGA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega1
        {
            get { return  obsentrega1; }
            set {  obsentrega1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA2
        /// Comentário: 
        /// </summary>
        private string obsentrega2;
        [XmlElement(ElementName = "OBSENTREGA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega2
        {
            get { return  obsentrega2; }
            set {  obsentrega2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA3
        /// Comentário: 
        /// </summary>
        private string obsentrega3;
        [XmlElement(ElementName = "OBSENTREGA3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega3
        {
            get { return  obsentrega3; }
            set {  obsentrega3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA4
        /// Comentário: 
        /// </summary>
        private string obsentrega4;
        [XmlElement(ElementName = "OBSENTREGA4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsentrega4
        {
            get { return  obsentrega4; }
            set {  obsentrega4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Comentário: 
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO1
        /// Comentário: 
        /// </summary>
        private string obsintegracao1;
        [XmlElement(ElementName = "OBSINTEGRACAO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsintegracao1
        {
            get { return  obsintegracao1; }
            set {  obsintegracao1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO2
        /// Comentário: 
        /// </summary>
        private string obsintegracao2;
        [XmlElement(ElementName = "OBSINTEGRACAO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsintegracao2
        {
            get { return  obsintegracao2; }
            set {  obsintegracao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS1
        /// Comentário: 
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Comentário: 
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOPAGOECOMMERCE
        /// Comentário: Pedido pago pelo e-commerce
        /// </summary>
        private string pedidopagoecommerce;
        [XmlElement(ElementName = "PEDIDOPAGOECOMMERCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pedidopagoecommerce
        {
            get { return  pedidopagoecommerce; }
            set {  pedidopagoecommerce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVENDA
        /// Comentário: 
        /// </summary>
        private decimal percvenda;
        [XmlElement(ElementName = "PERCVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percvenda
        {
            get { return  percvenda; }
            set {  percvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: Posição do Pedido.
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL
        /// Comentário: 
        /// </summary>
        private decimal? prazoadicional;
        [XmlElement(ElementName = "PRAZOADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazoadicional
        {
            get { return  prazoadicional; }
            set {  prazoadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIO
        /// Comentário: 
        /// </summary>
        private decimal? prazomedio;
        [XmlElement(ElementName = "PRAZOMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazomedio
        {
            get { return  prazomedio; }
            set {  prazomedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOPONDERADO
        /// Comentário: 
        /// </summary>
        private string prazoponderado;
        [XmlElement(ElementName = "PRAZOPONDERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prazoponderado
        {
            get { return  prazoponderado; }
            set {  prazoponderado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO1
        /// Comentário: 
        /// </summary>
        private decimal? prazo1;
        [XmlElement(ElementName = "PRAZO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo1
        {
            get { return  prazo1; }
            set {  prazo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO10
        /// Comentário: 
        /// </summary>
        private decimal? prazo10;
        [XmlElement(ElementName = "PRAZO10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo10
        {
            get { return  prazo10; }
            set {  prazo10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO11
        /// Comentário: 
        /// </summary>
        private decimal? prazo11;
        [XmlElement(ElementName = "PRAZO11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo11
        {
            get { return  prazo11; }
            set {  prazo11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO12
        /// Comentário: 
        /// </summary>
        private decimal? prazo12;
        [XmlElement(ElementName = "PRAZO12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo12
        {
            get { return  prazo12; }
            set {  prazo12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO2
        /// Comentário: 
        /// </summary>
        private decimal? prazo2;
        [XmlElement(ElementName = "PRAZO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo2
        {
            get { return  prazo2; }
            set {  prazo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO3
        /// Comentário: 
        /// </summary>
        private decimal? prazo3;
        [XmlElement(ElementName = "PRAZO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo3
        {
            get { return  prazo3; }
            set {  prazo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO4
        /// Comentário: 
        /// </summary>
        private decimal? prazo4;
        [XmlElement(ElementName = "PRAZO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo4
        {
            get { return  prazo4; }
            set {  prazo4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO5
        /// Comentário: 
        /// </summary>
        private decimal? prazo5;
        [XmlElement(ElementName = "PRAZO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo5
        {
            get { return  prazo5; }
            set {  prazo5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO6
        /// Comentário: 
        /// </summary>
        private decimal? prazo6;
        [XmlElement(ElementName = "PRAZO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo6
        {
            get { return  prazo6; }
            set {  prazo6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO7
        /// Comentário: 
        /// </summary>
        private decimal? prazo7;
        [XmlElement(ElementName = "PRAZO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo7
        {
            get { return  prazo7; }
            set {  prazo7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO8
        /// Comentário: 
        /// </summary>
        private decimal? prazo8;
        [XmlElement(ElementName = "PRAZO8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo8
        {
            get { return  prazo8; }
            set {  prazo8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO9
        /// Comentário: 
        /// </summary>
        private decimal? prazo9;
        [XmlElement(ElementName = "PRAZO9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo9
        {
            get { return  prazo9; }
            set {  prazo9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEECF
        /// Comentário: 
        /// </summary>
        private string serieecf;
        [XmlElement(ElementName = "SERIEECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Serieecf
        {
            get { return  serieecf; }
            set {  serieecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEMANIF
        /// Comentário: 
        /// </summary>
        private string seriemanif;
        [XmlElement(ElementName = "SERIEMANIF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Seriemanif
        {
            get { return  seriemanif; }
            set {  seriemanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINTEGRACAO
        /// Comentário: 
        /// </summary>
        private string tipointegracao;
        [XmlElement(ElementName = "TIPOINTEGRACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipointegracao
        {
            get { return  tipointegracao; }
            set {  tipointegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSACAO
        /// Comentário: Indica o número da transação.
        /// </summary>
        private decimal transacao;
        [XmlElement(ElementName = "TRANSACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Transacao
        {
            get { return  transacao; }
            set {  transacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TURNOENTREGA
        /// Comentário: Turno de entrega do pedido
        /// </summary>
        private string turnoentrega;
        [XmlElement(ElementName = "TURNOENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Turnoentrega
        {
            get { return  turnoentrega; }
            set {  turnoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARNIVELVENDA
        /// Comentário: Validar nível de cobrança.
        /// </summary>
        private string validarnivelvenda;
        [XmlElement(ElementName = "VALIDARNIVELVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarnivelvenda
        {
            get { return  validarnivelvenda; }
            set {  validarnivelvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTOCUPOM
        /// Comentário: Desconto que será aplicado no cupom.
        /// </summary>
        private decimal? vldescontocupom;
        [XmlElement(ElementName = "VLDESCONTOCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal? Vldescontocupom
        {
            get { return vldescontocupom; }
            set {  vldescontocupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTOFINANCEIRO
        /// Comentário: Indica o valor do desconto financeiro.
        /// </summary>
        private decimal? vldescontofinanceiro;
        [XmlElement(ElementName = "VLDESCONTOFINANCEIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vldescontofinanceiro
        {
            get { return vldescontofinanceiro; }
            set {  vldescontofinanceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENTRADA
        /// Comentário: Valor de entrada.
        /// </summary>
        private decimal vlentrada;
        [XmlElement(ElementName = "VLENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlentrada
        {
            get { return  vlentrada; }
            set {  vlentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: 
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETENF
        /// Comentário: 
        /// </summary>
        private decimal vlfretenf;
        [XmlElement(ElementName = "VLFRETENF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfretenf
        {
            get { return  vlfretenf; }
            set {  vlfretenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal vloutrasdesp;
        [XmlElement(ElementName = "VLOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vloutrasdesp
        {
            get { return  vloutrasdesp; }
            set {  vloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_VLOUTRASDESPWEB
        /// Comentário: 
        /// </summary>
        private decimal ESC_vloutrasdespweb;
        [XmlElement(ElementName = "ESC_VLOUTRASDESPWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 16)]
        public decimal ESC_Vloutrasdespweb
        {
            get { return ESC_vloutrasdespweb; }
            set { ESC_vloutrasdespweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTROCO
        /// Comentário: O valor de troco do cliente.
        /// </summary>
        private decimal vltroco;
        [XmlElement(ElementName = "VLTROCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Vltroco
        {
            get { return  vltroco; }
            set {  vltroco = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPedctemp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDCTEMP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPedctemp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedctemp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPedctemp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedctemp>(where);
        }

        #endregion
    }
}
