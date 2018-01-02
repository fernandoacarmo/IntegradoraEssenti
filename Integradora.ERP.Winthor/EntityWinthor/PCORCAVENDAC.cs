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
    /// Classe referente a tabela PCOrcavendac
    /// </summary>
    [XmlType("PCORCAVENDAC")]
    public class PCOrcavendac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Comentário: Código MD-5.
        /// </summary>
        private string assinatura;
        [XmlElement(ElementName = "ASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Assinatura
        {
            get { return  assinatura; }
            set {  assinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BROKER
        /// Comentário: Pedido broker. 
        /// </summary>
        private string broker;
        [XmlElement(ElementName = "BROKER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Broker
        {
            get { return  broker; }
            set {  broker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPANHA
        /// Comentário: Indica a campanha. 
        /// </summary>
        private string campanha;
        [XmlElement(ElementName = "CAMPANHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Campanha
        {
            get { return  campanha; }
            set {  campanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAOCRM
        /// Comentário: Cartão CRM
        /// </summary>
        private string cartaocrm;
        [XmlElement(ElementName = "CARTAOCRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public string Cartaocrm
        {
            get { return  cartaocrm; }
            set {  cartaocrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAOFIDELIDADE
        /// Comentário: Utiliza cartão fidelidade
        /// </summary>
        private string cartaofidelidade;
        [XmlElement(ElementName = "CARTAOFIDELIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cartaofidelidade
        {
            get { return  cartaofidelidade; }
            set {  cartaofidelidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Cidade
        {
            get { return  cidade; }
            set {  cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE
        /// Comentário: 
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Cliente
        {
            get { return  cliente; }
            set {  cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ
        /// Comentário: 
        /// </summary>
        private string cnpj;
        [XmlElement(ElementName = "CNPJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpj
        {
            get { return  cnpj; }
            set {  cnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATV1
        /// Comentário: 
        /// </summary>
        private decimal codatv1;
        [XmlElement(ElementName = "CODATV1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codatv1
        {
            get { return  codatv1; }
            set {  codatv1 = value; }
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
        /// Propriedade referente ao campo: CODCLINF
        /// Comentário: Indica o código cliente autorizado.
        /// </summary>
        private decimal codclinf;
        [XmlElement(ElementName = "CODCLINF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclinf
        {
            get { return  codclinf; }
            set {  codclinf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIRECEBEDOR
        /// Comentário: Indica o cliente recebedor da mercadoria em pedidos feitos para redes de clientes. Pedido, NF e CR ficarão no nome do cliente do pedido (PCORCAVENDAC.CODCLI) que é cliente principal. 
        /// </summary>
        private decimal codclirecebedor;
        [XmlElement(ElementName = "CODCLIRECEBEDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclirecebedor
        {
            get { return  codclirecebedor; }
            set {  codclirecebedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Comentário: 
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTATO
        /// Comentário: Código do contato no pedido de venda
        /// </summary>
        private decimal codcontato;
        [XmlElement(ElementName = "CODCONTATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcontato
        {
            get { return  codcontato; }
            set {  codcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTRATO
        /// Comentário: Código do contrato. 
        /// </summary>
        private decimal codcontrato;
        [XmlElement(ElementName = "CODCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcontrato
        {
            get { return  codcontrato; }
            set {  codcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCRECLI
        /// Comentário: Código de crédito do cliente
        /// </summary>
        private decimal codcrecli;
        [XmlElement(ElementName = "CODCRECLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcrecli
        {
            get { return  codcrecli; }
            set {  codcrecli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCRED
        /// Comentário: Código de crédito
        /// </summary>
        private decimal codcred;
        [XmlElement(ElementName = "CODCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcred
        {
            get { return  codcred; }
            set {  codcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDISTRIB
        /// Comentário: Código distribuição. 
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
        private decimal codemitente;
        [XmlElement(ElementName = "CODEMITENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemitente
        {
            get { return  codemitente; }
            set {  codemitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDENT
        /// Comentário: Indica o código endereço de entrega.
        /// </summary>
        private decimal codendent;
        [XmlElement(ElementName = "CODENDENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codendent
        {
            get { return  codendent; }
            set {  codendent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTABELECIMENTO
        /// Comentário: Código do estabelecimento broker. 
        /// </summary>
        private string codestabelecimento;
        [XmlElement(ElementName = "CODESTABELECIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codestabelecimento
        {
            get { return  codestabelecimento; }
            set {  codestabelecimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFILIALRETIRA1
        /// Comentário: Código da filial de retirada produtos número 1.
        /// </summary>
        private string codfilialretira1;
        [XmlElement(ElementName = "CODFILIALRETIRA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira1
        {
            get { return  codfilialretira1; }
            set {  codfilialretira1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA2
        /// Comentário: Código da filial de retirada produtos número 2.
        /// </summary>
        private string codfilialretira2;
        [XmlElement(ElementName = "CODFILIALRETIRA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira2
        {
            get { return  codfilialretira2; }
            set {  codfilialretira2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA3
        /// Comentário: Código da filial de retirada produtos número 3.
        /// </summary>
        private string codfilialretira3;
        [XmlElement(ElementName = "CODFILIALRETIRA3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira3
        {
            get { return  codfilialretira3; }
            set {  codfilialretira3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Comentário: 
        /// </summary>
        private decimal codfornecfrete;
        [XmlElement(ElementName = "CODFORNECFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecfrete
        {
            get { return  codfornecfrete; }
            set {  codfornecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECREDESPACHO
        /// Comentário: Indica o código transportadora de redespacho.
        /// </summary>
        private decimal codfornecredespacho;
        [XmlElement(ElementName = "CODFORNECREDESPACHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecredespacho
        {
            get { return  codfornecredespacho; }
            set {  codfornecredespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCALCFRETE
        /// Comentário: Indica o funcionário que calculou o frete.
        /// </summary>
        private decimal codfunccalcfrete;
        [XmlElement(ElementName = "CODFUNCCALCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccalcfrete
        {
            get { return  codfunccalcfrete; }
            set {  codfunccalcfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCANCEL
        /// Comentário: 
        /// </summary>
        private decimal codfunccancel;
        [XmlElement(ElementName = "CODFUNCCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccancel
        {
            get { return  codfunccancel; }
            set {  codfunccancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTBLOQUEIO
        /// Comentário: Código do motivo de bloqueio. 
        /// </summary>
        private decimal codmotbloqueio;
        [XmlElement(ElementName = "CODMOTBLOQUEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotbloqueio
        {
            get { return  codmotbloqueio; }
            set {  codmotbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Comentário: Indica o código do motivo do bloqueio do pedido. 
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
        /// Propriedade referente ao campo: CODMOTIVONAOATENDORCA
        /// Comentário: Código do motivo de não faturamento do orçamento.
        /// </summary>
        private decimal codmotivonaoatendorca;
        [XmlElement(ElementName = "CODMOTIVONAOATENDORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codmotivonaoatendorca
        {
            get { return  codmotivonaoatendorca; }
            set {  codmotivonaoatendorca = value; }
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
        /// Propriedade referente ao campo: CODPLPAGETICO
        /// Comentário: Codigo Plano de pagamento etico
        /// </summary>
        private decimal codplpagetico;
        [XmlElement(ElementName = "CODPLPAGETICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpagetico
        {
            get { return  codplpagetico; }
            set {  codplpagetico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGGENERICO
        /// Comentário: Codigo Plano de pagamento Generico
        /// </summary>
        private decimal codplpaggenerico;
        [XmlElement(ElementName = "CODPLPAGGENERICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpaggenerico
        {
            get { return  codplpaggenerico; }
            set {  codplpaggenerico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACADESTINO
        /// Comentário: Indica o código da praça do local da entrega.
        /// </summary>
        private decimal codpracadestino;
        [XmlElement(ElementName = "CODPRACADESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpracadestino
        {
            get { return  codpracadestino; }
            set {  codpracadestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Comentário: 
        /// </summary>
        private decimal codprofissional;
        [XmlElement(ElementName = "CODPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprofissional
        {
            get { return  codprofissional; }
            set {  codprofissional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSP
        /// Comentário: Indica o código da transportadora.
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
        /// Comentário: Indica o código do primeiro profissional.
        /// </summary>
        private decimal codusur2;
        [XmlElement(ElementName = "CODUSUR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusur2
        {
            get { return  codusur2; }
            set {  codusur2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR3
        /// Comentário: Indica o código do segundo profissional.
        /// </summary>
        private decimal codusur3;
        [XmlElement(ElementName = "CODUSUR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusur3
        {
            get { return  codusur3; }
            set {  codusur3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR4
        /// Comentário: Indica o código do terceiro profissional.
        /// </summary>
        private decimal codusur4;
        [XmlElement(ElementName = "CODUSUR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusur4
        {
            get { return  codusur4; }
            set {  codusur4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVISITA
        /// Comentário: Código da visita.
        /// </summary>
        private decimal codvisita;
        [XmlElement(ElementName = "CODVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codvisita
        {
            get { return  codvisita; }
            set {  codvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCILIAIMPORTACAO
        /// Comentário: Concilia importacao. 
        /// </summary>
        private string conciliaimportacao;
        [XmlElement(ElementName = "CONCILIAIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conciliaimportacao
        {
            get { return  conciliaimportacao; }
            set {  conciliaimportacao = value; }
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
        /// Propriedade referente ao campo: CONDVENDADESTINO
        /// Comentário: Indica o tipo de venda destino
        /// </summary>
        private decimal condvendadestino;
        [XmlElement(ElementName = "CONDVENDADESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Condvendadestino
        {
            get { return  condvendadestino; }
            set {  condvendadestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONVERTIDOPEDIDO
        /// Comentário: Indica se o orçamento foi convertido em pedido. 
        /// </summary>
        private string convertidopedido;
        [XmlElement(ElementName = "CONVERTIDOPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Convertidopedido
        {
            get { return  convertidopedido; }
            set {  convertidopedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COOCONF
        /// Comentário: COO de conferência.
        /// </summary>
        private string cooconf;
        [XmlElement(ElementName = "COOCONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Cooconf
        {
            get { return  cooconf; }
            set {  cooconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOENTREGA
        /// Comentário: 
        /// </summary>
        private decimal custoentrega;
        [XmlElement(ElementName = "CUSTOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Custoentrega
        {
            get { return  custoentrega; }
            set {  custoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORA_PRIMEIRODOCUMENTO_ECF
        /// Comentário: Data Hora Primeiro DOc. ECF
        /// </summary>
        private string datahora_primeirodocumento_ecf;
        [XmlElement(ElementName = "DATAHORA_PRIMEIRODOCUMENTO_ECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public string Datahora_Primeirodocumento_Ecf
        {
            get { return  datahora_primeirodocumento_ecf; }
            set {  datahora_primeirodocumento_ecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAPEDCLI
        /// Comentário: Data do pedido do cliente. 
        /// </summary>
        private DateTime? datapedcli;
        [XmlElement(ElementName = "DATAPEDCLI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datapedcli
        {
            get { return  datapedcli; }
            set {  datapedcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURA
        /// Comentário: Data abertura.
        /// </summary>
        private DateTime? dtabertura;
        [XmlElement(ElementName = "DTABERTURA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtabertura
        {
            get { return  dtabertura; }
            set {  dtabertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAGENDAENTREGA
        /// Comentário: Data agendada de entrega. 
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
        /// Propriedade referente ao campo: DTCALCFRETE
        /// Comentário: Indica a data do cálculo do frete.
        /// </summary>
        private DateTime? dtcalcfrete;
        [XmlElement(ElementName = "DTCALCFRETE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcalcfrete
        {
            get { return  dtcalcfrete; }
            set {  dtcalcfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Indica a data de cancelamento.
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
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Comentário: DATA DE EXPORTAÇÃO DO ORÇAMENTO
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTO
        /// Comentário: Data fechamento.
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
        /// Propriedade referente ao campo: DTIMPORTACAO
        /// Comentário: Gravação da data de importação do orçamento.
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
        /// Propriedade referente ao campo: DTLIBERA
        /// Comentário: 
        /// </summary>
        private DateTime? dtlibera;
        [XmlElement(ElementName = "DTLIBERA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlibera
        {
            get { return  dtlibera; }
            set {  dtlibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC1
        /// Comentário: Indica a data de vencimento.
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
        /// Comentário: Indica a data de vencimento.
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
        /// Comentário: Indica a data de vencimento.
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
        /// Propriedade referente ao campo: DUPLICADO
        /// Comentário: Informa se um orçamento foi duplicado ou não.
        /// </summary>
        private string duplicado;
        [XmlElement(ElementName = "DUPLICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Duplicado
        {
            get { return  duplicado; }
            set {  duplicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCOBRANCA
        /// Comentário: Indica o código EAN da cobrança.
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
        /// Propriedade referente ao campo: EANENTREGA
        /// Comentário: Indica o código EAN da entrega.
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
        /// Propriedade referente ao campo: EDITANDOORCA
        /// Comentário: Flag que indica que a ficha está em edição.
        /// </summary>
        private string editandoorca;
        [XmlElement(ElementName = "EDITANDOORCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Editandoorca
        {
            get { return  editandoorca; }
            set {  editandoorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: 
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIEMANIF
        /// Comentário: Espécie da NF manifesto. 
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
        /// Propriedade referente ao campo: ESTOQUEVENDAVALERESERVADO
        /// Comentário: 
        /// </summary>
        private string estoquevendavalereservado;
        [XmlElement(ElementName = "ESTOQUEVENDAVALERESERVADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estoquevendavalereservado
        {
            get { return  estoquevendavalereservado; }
            set {  estoquevendavalereservado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Comentário: STATUS DO REGISTRO, INDICA SE O REGISTRO FOI EXPORTADO
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
        /// Propriedade referente ao campo: GERACP
        /// Comentário: Indica se o pedido de transferencia de mercadoria gera contas a pagar.
        /// </summary>
        private string geracp;
        [XmlElement(ElementName = "GERACP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracp
        {
            get { return  geracp; }
            set {  geracp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARCONTROLEDEENTREGA
        /// Comentário: Gera controle de entrega.
        /// </summary>
        private string gerarcontroledeentrega;
        [XmlElement(ElementName = "GERARCONTROLEDEENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarcontroledeentrega
        {
            get { return  gerarcontroledeentrega; }
            set {  gerarcontroledeentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GNFCONF
        /// Comentário: GNF de conferência.
        /// </summary>
        private string gnfconf;
        [XmlElement(ElementName = "GNFCONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Gnfconf
        {
            get { return  gnfconf; }
            set {  gnfconf = value; }
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
        /// Propriedade referente ao campo: IE
        /// Comentário: 
        /// </summary>
        private string ie;
        [XmlElement(ElementName = "IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Ie
        {
            get { return  ie; }
            set {  ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LISTA_MD5_2030MG
        /// Comentário: Lista MD5 DA 2030
        /// </summary>
        private string lista_md5_2030mg;
        [XmlElement(ElementName = "LISTA_MD5_2030MG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Lista_Md5_2030mg
        {
            get { return  lista_md5_2030mg; }
            set {  lista_md5_2030mg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALDESEMBARACO
        /// Comentário: Observação de embarque.
        /// </summary>
        private string localdesembaraco;
        [XmlElement(ElementName = "LOCALDESEMBARACO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Localdesembaraco
        {
            get { return  localdesembaraco; }
            set {  localdesembaraco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOG
        /// Comentário: Log de bloqueio.
        /// </summary>
        private string log;
        [XmlElement(ElementName = "LOG", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Log
        {
            get { return  log; }
            set {  log = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEM
        /// Comentário: 
        /// </summary>
        private decimal margem;
        [XmlElement(ElementName = "MARGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Margem
        {
            get { return  margem; }
            set {  margem = value; }
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
        /// Propriedade referente ao campo: MONTANDO
        /// Comentário: 
        /// </summary>
        private string montando;
        [XmlElement(ElementName = "MONTANDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Montando
        {
            get { return  montando; }
            set {  montando = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOPOSICAO
        /// Comentário: Motivo da posição do pedido. 
        /// </summary>
        private string motivoposicao;
        [XmlElement(ElementName = "MOTIVOPOSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motivoposicao
        {
            get { return  motivoposicao; }
            set {  motivoposicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NEGOCIADO
        /// Comentário: 
        /// </summary>
        private string negociado;
        [XmlElement(ElementName = "NEGOCIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Negociado
        {
            get { return  negociado; }
            set {  negociado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: NUMERO DO CAIXA
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
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARMANIF
        /// Comentário: Número do carregamento manifesto. 
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
        /// Propriedade referente ao campo: NUMCCF
        /// Comentário: Indica o número do CCF.
        /// </summary>
        private decimal numccf;
        [XmlElement(ElementName = "NUMCCF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numccf
        {
            get { return  numccf; }
            set {  numccf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Comentário: Número do cupom fiscal. 
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
        /// Propriedade referente ao campo: NUMDAV
        /// Comentário: Gravação de sequencial DAV.
        /// </summary>
        private decimal numdav;
        [XmlElement(ElementName = "NUMDAV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Numdav
        {
            get { return  numdav; }
            set {  numdav = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROORCAMENTO
        /// Comentário: 
        /// </summary>
        private decimal numeroorcamento;
        [XmlElement(ElementName = "NUMEROORCAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numeroorcamento
        {
            get { return  numeroorcamento; }
            set {  numeroorcamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFICHA
        /// Comentário: Número que identifica a ficha no processo de restaurante
        /// </summary>
        private decimal numficha;
        [XmlElement(ElementName = "NUMFICHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numficha
        {
            get { return  numficha; }
            set {  numficha = value; }
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
        /// Propriedade referente ao campo: NUMLISTA
        /// Comentário: Codigo da lista de presente
        /// </summary>
        private decimal numlista;
        [XmlElement(ElementName = "NUMLISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numlista
        {
            get { return  numlista; }
            set {  numlista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAMANIF
        /// Comentário: Número da NF manifesto. 
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
        /// Propriedade referente ao campo: NUMNOTATRANSF
        /// Comentário: Número nota de transferência
        /// </summary>
        private decimal numnotatransf;
        [XmlElement(ElementName = "NUMNOTATRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotatransf
        {
            get { return  numnotatransf; }
            set {  numnotatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Comentário: 
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCAENTFUT
        /// Comentário: 
        /// </summary>
        private decimal numorcaentfut;
        [XmlElement(ElementName = "NUMORCAENTFUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorcaentfut
        {
            get { return  numorcaentfut; }
            set {  numorcaentfut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCAFILIAL
        /// Comentário: Número Orçamento da Filial. 
        /// </summary>
        private decimal numorcafilial;
        [XmlElement(ElementName = "NUMORCAFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorcafilial
        {
            get { return  numorcafilial; }
            set {  numorcafilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCAORIGEM
        /// Comentário: 
        /// </summary>
        private decimal numorcaorigem;
        [XmlElement(ElementName = "NUMORCAORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorcaorigem
        {
            get { return  numorcaorigem; }
            set {  numorcaorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCAPRINC
        /// Comentário: Indica o número de orçamento principal
        /// </summary>
        private decimal numorcaprinc;
        [XmlElement(ElementName = "NUMORCAPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorcaprinc
        {
            get { return  numorcaprinc; }
            set {  numorcaprinc = value; }
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
        /// Comentário: Número do pedido bonificação. 
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
        /// Comentário: NUMERO DO PEDIDO
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
        /// Comentário: Número pedido entrega futura. 
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
        /// Propriedade referente ao campo: NUMPREVENDA
        /// Comentário: 
        /// </summary>
        private decimal numprevenda;
        [XmlElement(ElementName = "NUMPREVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numprevenda
        {
            get { return  numprevenda; }
            set {  numprevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: Região de preço usada no orçamento. 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAOAVULSA
        /// Comentário: 
        /// </summary>
        private decimal numregiaoavulsa;
        [XmlElement(ElementName = "NUMREGIAOAVULSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiaoavulsa
        {
            get { return  numregiaoavulsa; }
            set {  numregiaoavulsa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTREGA
        /// Comentário: 
        /// </summary>
        private decimal numseqentrega;
        [XmlElement(ElementName = "NUMSEQENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseqentrega
        {
            get { return  numseqentrega; }
            set {  numseqentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Comentário: NUMERO DE SERIE EQUIPAMENTO
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
        /// Propriedade referente ao campo: NUMTABELA
        /// Comentário: Número da tabela broker. 
        /// </summary>
        private string numtabela;
        [XmlElement(ElementName = "NUMTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numtabela
        {
            get { return  numtabela; }
            set {  numtabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTORIGEM
        /// Comentário: Número da entrada de origem
        /// </summary>
        private decimal numtransentorigem;
        [XmlElement(ElementName = "NUMTRANSENTORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentorigem
        {
            get { return  numtransentorigem; }
            set {  numtransentorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
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
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: 
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORCADOPOR
        /// Comentário: 
        /// </summary>
        private string orcadopor;
        [XmlElement(ElementName = "ORCADOPOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Orcadopor
        {
            get { return  orcadopor; }
            set {  orcadopor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORCAGERADODEVALES
        /// Comentário: 
        /// </summary>
        private string orcageradodevales;
        [XmlElement(ElementName = "ORCAGERADODEVALES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orcageradodevales
        {
            get { return  orcageradodevales; }
            set {  orcageradodevales = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORCAMENTOUTILIZADO
        /// Comentário: 
        /// </summary>
        private string orcamentoutilizado;
        [XmlElement(ElementName = "ORCAMENTOUTILIZADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orcamentoutilizado
        {
            get { return  orcamentoutilizado; }
            set {  orcamentoutilizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORCASALVO
        /// Comentário: 
        /// </summary>
        private string orcasalvo;
        [XmlElement(ElementName = "ORCASALVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orcasalvo
        {
            get { return  orcasalvo; }
            set {  orcasalvo = value; }
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
        /// Propriedade referente ao campo: PERCCOMPROFISSIONAL
        /// Comentário: Percentual de comissao do profissional cadastrado na rotina 340. 
        /// </summary>
        private decimal perccomprofissional;
        [XmlElement(ElementName = "PERCCOMPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perccomprofissional
        {
            get { return  perccomprofissional; }
            set {  perccomprofissional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCATIV
        /// Comentário: Percentual de desconto por ramo de atividade.
        /// </summary>
        private decimal percdescativ;
        [XmlElement(ElementName = "PERCDESCATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percdescativ
        {
            get { return  percdescativ; }
            set {  percdescativ = value; }
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
        /// Propriedade referente ao campo: PERDESC
        /// Comentário: 
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCAVISTA
        /// Comentário: Percentual de desconta à vista.
        /// </summary>
        private decimal perdescavista;
        [XmlElement(ElementName = "PERDESCAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescavista
        {
            get { return  perdescavista; }
            set {  perdescavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFIN
        /// Comentário: Valor do percentual do desconto financeiro. 
        /// </summary>
        private decimal perdescfin;
        [XmlElement(ElementName = "PERDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdescfin
        {
            get { return  perdescfin; }
            set {  perdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCTOTAL
        /// Comentário: 
        /// </summary>
        private decimal perdesctotal;
        [XmlElement(ElementName = "PERDESCTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdesctotal
        {
            get { return  perdesctotal; }
            set {  perdesctotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACAVEICULO
        /// Comentário: Placa do Veiculo de Transporte.
        /// </summary>
        private string placaveiculo;
        [XmlElement(ElementName = "PLACAVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Placaveiculo
        {
            get { return  placaveiculo; }
            set {  placaveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLPAGAAVISTA
        /// Comentário: Plano de pagamento à vista.
        /// </summary>
        private string plpagaavista;
        [XmlElement(ElementName = "PLPAGAAVISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Plpagaavista
        {
            get { return  plpagaavista; }
            set {  plpagaavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLPAGAVISTA
        /// Comentário: Indica se o plano de pagamento do orçamento é a vista
        /// </summary>
        private string plpagavista;
        [XmlElement(ElementName = "PLPAGAVISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Plpagavista
        {
            get { return  plpagavista; }
            set {  plpagavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIO
        /// Comentário: 
        /// </summary>
        private decimal prazomedio;
        [XmlElement(ElementName = "PRAZOMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomedio
        {
            get { return  prazomedio; }
            set {  prazomedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO1
        /// Comentário: 
        /// </summary>
        private decimal prazo1;
        [XmlElement(ElementName = "PRAZO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo1
        {
            get { return  prazo1; }
            set {  prazo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO10
        /// Comentário: 
        /// </summary>
        private decimal prazo10;
        [XmlElement(ElementName = "PRAZO10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo10
        {
            get { return  prazo10; }
            set {  prazo10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO11
        /// Comentário: 
        /// </summary>
        private decimal prazo11;
        [XmlElement(ElementName = "PRAZO11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo11
        {
            get { return  prazo11; }
            set {  prazo11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO12
        /// Comentário: 
        /// </summary>
        private decimal prazo12;
        [XmlElement(ElementName = "PRAZO12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo12
        {
            get { return  prazo12; }
            set {  prazo12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO2
        /// Comentário: 
        /// </summary>
        private decimal prazo2;
        [XmlElement(ElementName = "PRAZO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo2
        {
            get { return  prazo2; }
            set {  prazo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO3
        /// Comentário: 
        /// </summary>
        private decimal prazo3;
        [XmlElement(ElementName = "PRAZO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo3
        {
            get { return  prazo3; }
            set {  prazo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO4
        /// Comentário: 
        /// </summary>
        private decimal prazo4;
        [XmlElement(ElementName = "PRAZO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo4
        {
            get { return  prazo4; }
            set {  prazo4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO5
        /// Comentário: 
        /// </summary>
        private decimal prazo5;
        [XmlElement(ElementName = "PRAZO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo5
        {
            get { return  prazo5; }
            set {  prazo5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO6
        /// Comentário: 
        /// </summary>
        private decimal prazo6;
        [XmlElement(ElementName = "PRAZO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo6
        {
            get { return  prazo6; }
            set {  prazo6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO7
        /// Comentário: 
        /// </summary>
        private decimal prazo7;
        [XmlElement(ElementName = "PRAZO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo7
        {
            get { return  prazo7; }
            set {  prazo7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO8
        /// Comentário: 
        /// </summary>
        private decimal prazo8;
        [XmlElement(ElementName = "PRAZO8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo8
        {
            get { return  prazo8; }
            set {  prazo8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO9
        /// Comentário: 
        /// </summary>
        private decimal prazo9;
        [XmlElement(ElementName = "PRAZO9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo9
        {
            get { return  prazo9; }
            set {  prazo9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESERVARITENSTV7
        /// Comentário: 
        /// </summary>
        private string reservaritenstv7;
        [XmlElement(ElementName = "RESERVARITENSTV7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reservaritenstv7
        {
            get { return  reservaritenstv7; }
            set {  reservaritenstv7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOTRANSP
        /// Comentário: Pedido com restrição de transporte. 
        /// </summary>
        private string restricaotransp;
        [XmlElement(ElementName = "RESTRICAOTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restricaotransp
        {
            get { return  restricaotransp; }
            set {  restricaotransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Comentário: ROTINA QUE GRAVOU A INFORMACAO
        /// </summary>
        private string rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SELECIONAREGIAOAVULSA
        /// Comentário: 
        /// </summary>
        private string selecionaregiaoavulsa;
        [XmlElement(ElementName = "SELECIONAREGIAOAVULSA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Selecionaregiaoavulsa
        {
            get { return  selecionaregiaoavulsa; }
            set {  selecionaregiaoavulsa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEECF
        /// Comentário: Série ECF. 
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
        /// Comentário: Série NF manifesto. 
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
        /// Propriedade referente ao campo: TELEFONE
        /// Comentário: 
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCARGA
        /// Comentário: 
        /// </summary>
        private string tipocarga;
        [XmlElement(ElementName = "TIPOCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocarga
        {
            get { return  tipocarga; }
            set {  tipocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOC
        /// Comentário: Tipo de oraçamento.
        /// </summary>
        private string tipodoc;
        [XmlElement(ElementName = "TIPODOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodoc
        {
            get { return  tipodoc; }
            set {  tipodoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOCUMENTO
        /// Comentário: Tipo do documento para impressão da NF.
        /// </summary>
        private string tipodocumento;
        [XmlElement(ElementName = "TIPODOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodocumento
        {
            get { return  tipodocumento; }
            set {  tipodocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEM
        /// Comentário: 
        /// </summary>
        private string tipoembalagem;
        [XmlElement(ElementName = "TIPOEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagem
        {
            get { return  tipoembalagem; }
            set {  tipoembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOIMPR
        /// Comentário: Tipo impressão
        /// </summary>
        private string tipoimpr;
        [XmlElement(ElementName = "TIPOIMPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoimpr
        {
            get { return  tipoimpr; }
            set {  tipoimpr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPONFDESTINO
        /// Comentário: Tipo de Nota Fiscal Destino - NF ou Cupom.
        /// </summary>
        private string tiponfdestino;
        [XmlElement(ElementName = "TIPONFDESTINO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tiponfdestino
        {
            get { return  tiponfdestino; }
            set {  tiponfdestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPER
        /// Comentário: 
        /// </summary>
        private string tipooper;
        [XmlElement(ElementName = "TIPOOPER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipooper
        {
            get { return  tipooper; }
            set {  tipooper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOORCAMENTO
        /// Comentário: 
        /// </summary>
        private string tipoorcamento;
        [XmlElement(ElementName = "TIPOORCAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoorcamento
        {
            get { return  tipoorcamento; }
            set {  tipoorcamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRIORIDADEENTREGA
        /// Comentário: Indica o tipo de prioridade de entrega.
        /// </summary>
        private string tipoprioridadeentrega;
        [XmlElement(ElementName = "TIPOPRIORIDADEENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprioridadeentrega
        {
            get { return  tipoprioridadeentrega; }
            set {  tipoprioridadeentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORETIRADA
        /// Comentário: 
        /// </summary>
        private string tiporetirada;
        [XmlElement(ElementName = "TIPORETIRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiporetirada
        {
            get { return  tiporetirada; }
            set {  tiporetirada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Comentário: 
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESO
        /// Comentário: 
        /// </summary>
        private decimal totpeso;
        [XmlElement(ElementName = "TOTPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Totpeso
        {
            get { return  totpeso; }
            set {  totpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVLBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal totvlbonific;
        [XmlElement(ElementName = "TOTVLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totvlbonific
        {
            get { return  totvlbonific; }
            set {  totvlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVLDESCCOM
        /// Comentário: 
        /// </summary>
        private decimal totvldesccom;
        [XmlElement(ElementName = "TOTVLDESCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totvldesccom
        {
            get { return  totvldesccom; }
            set {  totvldesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVLDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal totvldescfin;
        [XmlElement(ElementName = "TOTVLDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totvldescfin
        {
            get { return  totvldescfin; }
            set {  totvldescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVLDESCFLEX
        /// Comentário: 
        /// </summary>
        private decimal totvldescflex;
        [XmlElement(ElementName = "TOTVLDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totvldescflex
        {
            get { return  totvldescflex; }
            set {  totvldescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVLREDCOMISS
        /// Comentário: 
        /// </summary>
        private decimal totvlredcomiss;
        [XmlElement(ElementName = "TOTVLREDCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totvlredcomiss
        {
            get { return  totvlredcomiss; }
            set {  totvlredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVLREDCOMISSSUP
        /// Comentário: 
        /// </summary>
        private decimal totvlredcomisssup;
        [XmlElement(ElementName = "TOTVLREDCOMISSSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totvlredcomisssup
        {
            get { return  totvlredcomisssup; }
            set {  totvlredcomisssup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVOLUME
        /// Comentário: 
        /// </summary>
        private decimal totvolume;
        [XmlElement(ElementName = "TOTVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Totvolume
        {
            get { return  totvolume; }
            set {  totvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRIBUTAPORREGIAOFILIAL
        /// Comentário: 
        /// </summary>
        private string tributaporregiaofilial;
        [XmlElement(ElementName = "TRIBUTAPORREGIAOFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tributaporregiaofilial
        {
            get { return  tributaporregiaofilial; }
            set {  tributaporregiaofilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDESEMBARACO
        /// Comentário: Unidade da federação de embarque.
        /// </summary>
        private string ufdesembaraco;
        [XmlElement(ElementName = "UFDESEMBARACO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufdesembaraco
        {
            get { return  ufdesembaraco; }
            set {  ufdesembaraco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACFOPVENDANATV10
        /// Comentário: Utiliza CFOP de venda na transferência
        /// </summary>
        private string usacfopvendanatv10;
        [XmlElement(ElementName = "USACFOPVENDANATV10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacfopvendanatv10
        {
            get { return  usacfopvendanatv10; }
            set {  usacfopvendanatv10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAINTEGRACAOWMS
        /// Comentário: Campo para indicar se a filial do pedido trabalha com integração WMS, se sim ele será marcado para tratamento diferenciado.
        /// </summary>
        private string usaintegracaowms;
        [XmlElement(ElementName = "USAINTEGRACAOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaintegracaowms
        {
            get { return  usaintegracaowms; }
            set {  usaintegracaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDESCFIN
        /// Comentário: Valor do desconto financeiro.
        /// </summary>
        private decimal valordescfin;
        [XmlElement(ElementName = "VALORDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valordescfin
        {
            get { return  valordescfin; }
            set {  valordescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDAASSISTIDA
        /// Comentário: Indicar se é venda assistida. 
        /// </summary>
        private string vendaassistida;
        [XmlElement(ElementName = "VENDAASSISTIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendaassistida
        {
            get { return  vendaassistida; }
            set {  vendaassistida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDATRIANGULAR
        /// Comentário: Venda Triangular.
        /// </summary>
        private string vendatriangular;
        [XmlElement(ElementName = "VENDATRIANGULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendatriangular
        {
            get { return  vendatriangular; }
            set {  vendatriangular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLATEND
        /// Comentário: 
        /// </summary>
        private decimal vlatend;
        [XmlElement(ElementName = "VLATEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlatend
        {
            get { return  vlatend; }
            set {  vlatend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: Valor em BNF do pedido
        /// </summary>
        private decimal vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOCONT
        /// Comentário: 
        /// </summary>
        private decimal vlcustocont;
        [XmlElement(ElementName = "VLCUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustocont
        {
            get { return  vlcustocont; }
            set {  vlcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal vlcustofin;
        [XmlElement(ElementName = "VLCUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustofin
        {
            get { return  vlcustofin; }
            set {  vlcustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal vlcustoreal;
        [XmlElement(ElementName = "VLCUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustoreal
        {
            get { return  vlcustoreal; }
            set {  vlcustoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREP
        /// Comentário: 
        /// </summary>
        private decimal vlcustorep;
        [XmlElement(ElementName = "VLCUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustorep
        {
            get { return  vlcustorep; }
            set {  vlcustorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Comentário: 
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTOTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vldescontototal;
        [XmlElement(ElementName = "VLDESCONTOTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldescontototal
        {
            get { return  vldescontototal; }
            set {  vldescontototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENTRADA
        /// Comentário: Valor da entrada.
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
        [DataObjectField(false,false,true,14)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal vloutrasdesp;
        [XmlElement(ElementName = "VLOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vloutrasdesp
        {
            get { return  vloutrasdesp; }
            set {  vloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTABELA
        /// Comentário: 
        /// </summary>
        private decimal vltabela;
        [XmlElement(ElementName = "VLTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public decimal Vltabela
        {
            get { return  vltabela; }
            set {  vltabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTROCO
        /// Comentário: Valor do troco no caso de entrega
        /// </summary>
        private decimal vltroco;
        [XmlElement(ElementName = "VLTROCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
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
        public PCOrcavendac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORCAVENDAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOrcavendac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrcavendac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOrcavendac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrcavendac>(where);
        }

        #endregion
    }
}
