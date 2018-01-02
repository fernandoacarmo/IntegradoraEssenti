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
    /// Classe referente a tabela PCPedc
    /// </summary>
    [XmlType("PCPEDC")]
    public class PCPedc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGRUPAMENTO
        /// Coment�rio: Agrupamento
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
        /// Propriedade referente ao campo: ALIQICMSFRETENF
        /// Coment�rio: 
        /// </summary>
        private decimal? aliqicmsfretenf;
        [XmlElement(ElementName = "ALIQICMSFRETENF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Aliqicmsfretenf
        {
            get { return  aliqicmsfretenf; }
            set {  aliqicmsfretenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTAPOSMAPASEP
        /// Coment�rio: Altera��o Ap�s Emiss�o do Mapa Separa��o.
        /// </summary>
        private string altaposmapasep;
        [XmlElement(ElementName = "ALTAPOSMAPASEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Altaposmapasep
        {
            get { return  altaposmapasep; }
            set {  altaposmapasep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTENFCE
        /// Coment�rio: Produ��o(P) Homologa��o(H)
        /// </summary>
        private string ambientenfce;
        [XmlElement(ElementName = "AMBIENTENFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambientenfce
        {
            get { return  ambientenfce; }
            set {  ambientenfce = value; }
        }

         /// Coment�rio: 
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
        /// Propriedade referente ao campo: BASEICMSFRETENF
        /// Coment�rio: 
        /// </summary>
        private decimal? baseicmsfretenf;
        [XmlElement(ElementName = "BASEICMSFRETENF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Baseicmsfretenf
        {
            get { return  baseicmsfretenf; }
            set {  baseicmsfretenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQCOMERCIAL
        /// Coment�rio: Bloqueio comercial.
        /// </summary>
        private string bloqcomercial;
        [XmlElement(ElementName = "BLOQCOMERCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqcomercial
        {
            get { return  bloqcomercial; }
            set {  bloqcomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQFINANCEIRO
        /// Coment�rio: Bloqueio financeiro.
        /// </summary>
        private string bloqfinanceiro;
        [XmlElement(ElementName = "BLOQFINANCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqfinanceiro
        {
            get { return  bloqfinanceiro; }
            set {  bloqfinanceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIOEDICAO
        /// Coment�rio: Campo para controlar status de edi��o do pedido, se bloqueado ("S") ele n�o poder� ser alterado.
        /// </summary>
        private string bloqueioedicao;
        [XmlElement(ElementName = "BLOQUEIOEDICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueioedicao
        {
            get { return  bloqueioedicao; }
            set {  bloqueioedicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIOSALDOCCDESCFIN
        /// Coment�rio: Bloqueio por saldo insuficiente na conta corrente do RCA.
        /// </summary>
        private string bloqueiosaldoccdescfin;
        [XmlElement(ElementName = "BLOQUEIOSALDOCCDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiosaldoccdescfin
        {
            get { return  bloqueiosaldoccdescfin; }
            set {  bloqueiosaldoccdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BONIFICALTDEBCREDRCA
        /// Coment�rio: Log de PCCONSUM.BONIFICALTDEBCREDRCA.
        /// </summary>
        private string bonificaltdebcredrca;
        [XmlElement(ElementName = "BONIFICALTDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bonificaltdebcredrca
        {
            get { return  bonificaltdebcredrca; }
            set {  bonificaltdebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BRINDE
        /// Coment�rio: Indica se pedido bonificado � de brindes.
        /// </summary>
        private string brinde;
        [XmlElement(ElementName = "BRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Brinde
        {
            get { return  brinde; }
            set {  brinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BROKER
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: BROKERALTDEBCREDRCA
        /// Coment�rio: Log de PCCONSUM.BROKERALTDEBCREDRCA
        /// </summary>
        private string brokeraltdebcredrca;
        [XmlElement(ElementName = "BROKERALTDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Brokeraltdebcredrca
        {
            get { return  brokeraltdebcredrca; }
            set {  brokeraltdebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPANHA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CARTAODOTZ
        /// Coment�rio: N�mero do CPF ou CNPJ do cliente ou N�mero do cart�o de fidelidade DOTZ.
        /// </summary>
        private string cartaodotz;
        [XmlElement(ElementName = "CARTAODOTZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cartaodotz
        {
            get { return  cartaodotz; }
            set {  cartaodotz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CFOPBNFDEGUSTA
        /// Coment�rio: CFOP de bonifica��o degusta��o.
        /// </summary>
        private decimal? cfopbnfdegusta;
        [XmlElement(ElementName = "CFOPBNFDEGUSTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Cfopbnfdegusta
        {
            get { return  cfopbnfdegusta; }
            set {  cfopbnfdegusta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFCE
        /// Coment�rio: Chave NFCe
        /// </summary>
        private string chavenfce;
        [XmlElement(ElementName = "CHAVENFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Chavenfce
        {
            get { return  chavenfce; }
            set {  chavenfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFE
        /// Coment�rio: Chave NFE
        /// </summary>
        private string chavenfe;
        [XmlElement(ElementName = "CHAVENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavenfe
        {
            get { return  chavenfe; }
            set {  chavenfe = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: CODADMCARTAO
        /// Coment�rio: Indica o c�digo de administradora do cart�o de cr�dito.
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
        /// Coment�rio: 
        /// </summary>
        private decimal? codatendimento;
        [XmlElement(ElementName = "CODATENDIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal? Codatendimento
        {
            get { return  codatendimento; }
            set {  codatendimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAOTEF
        /// Coment�rio: Indica o c�digo da autoriza��o TEF.
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
        /// Coment�rio: C�digo de Autoriza��o para compra via web
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
        /// Propriedade referente ao campo: CODBNF
        /// Coment�rio: C�digo do tipo de bonifica��o TV5.
        /// </summary>
        private decimal? codbnf;
        [XmlElement(ElementName = "CODBNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codbnf
        {
            get { return  codbnf; }
            set {  codbnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o cliente recebedor da mercadoria em pedidos feitos para redes de clientes. Pedido, NF e CR ficar�o no nome do cliente do pedido PCPEDC.CODCLI. 
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
        /// Coment�rio: C�digo do cliente pedido tipo 8
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODCONTATO
        /// Coment�rio: C�digo do contato no pedido de venda
        /// </summary>
        private decimal? codcontato;
        [XmlElement(ElementName = "CODCONTATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codcontato
        {
            get { return  codcontato; }
            set {  codcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTRATO
        /// Coment�rio: 
        /// </summary>
        private decimal? codcontrato;
        [XmlElement(ElementName = "CODCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codcontrato
        {
            get { return  codcontrato; }
            set {  codcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDISTRIB
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo endere�o de entrega.
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
        /// Coment�rio: C�digo de Endere�o de entrega do cliente.
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
        /// Propriedade referente ao campo: CODEPTO
        /// Coment�rio: 
        /// </summary>
        private decimal? codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTABELECIMENTO
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFORNECBONIFIC
        /// Coment�rio: C�digo do Fornecedor da Bonifica��o TV5.
        /// </summary>
        private decimal? codfornecbonific;
        [XmlElement(ElementName = "CODFORNECBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codfornecbonific
        {
            get { return  codfornecbonific; }
            set {  codfornecbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFORNECREDESPACHO
        /// Coment�rio: Indica o c�digo transportadora de redespacho.
        /// </summary>
        private decimal? codfornecredespacho;
        [XmlElement(ElementName = "CODFORNECREDESPACHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codfornecredespacho
        {
            get { return  codfornecredespacho; }
            set {  codfornecredespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECVDIRETO
        /// Coment�rio: 
        /// </summary>
        private decimal? codfornecvdireto;
        [XmlElement(ElementName = "CODFORNECVDIRETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codfornecvdireto
        {
            get { return  codfornecvdireto; }
            set {  codfornecvdireto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFRETE
        /// Coment�rio: C�DIGO DO FRETE
        /// </summary>
        private decimal? codfrete;
        [XmlElement(ElementName = "CODFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codfrete
        {
            get { return  codfrete; }
            set {  codfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCALCFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal? codfunccalcfrete;
        [XmlElement(ElementName = "CODFUNCCALCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunccalcfrete
        {
            get { return  codfunccalcfrete; }
            set {  codfunccalcfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCANCEL
        /// Coment�rio: 
        /// </summary>
        private decimal? codfunccancel;
        [XmlElement(ElementName = "CODFUNCCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunccancel
        {
            get { return  codfunccancel; }
            set {  codfunccancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncconf;
        [XmlElement(ElementName = "CODFUNCCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncconf
        {
            get { return  codfuncconf; }
            set {  codfuncconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONFGARANTIA
        /// Coment�rio: Indica o c�digo do funcion�rio confer�ncia do pedido para termo de garantia.
        /// </summary>
        private decimal? codfuncconfgarantia;
        [XmlElement(ElementName = "CODFUNCCONFGARANTIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncconfgarantia
        {
            get { return  codfuncconfgarantia; }
            set {  codfuncconfgarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCX
        /// Coment�rio: C�digo do funcionario caixa(Check-out).
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
        /// Propriedade referente ao campo: CODFUNCEMBALADOR
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncembalador;
        [XmlElement(ElementName = "CODFUNCEMBALADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncembalador
        {
            get { return  codfuncembalador; }
            set {  codfuncembalador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEMISSAOMAPA
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncemissaomapa;
        [XmlElement(ElementName = "CODFUNCEMISSAOMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncemissaomapa
        {
            get { return  codfuncemissaomapa; }
            set {  codfuncemissaomapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXPARQOL
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncexparqol;
        [XmlElement(ElementName = "CODFUNCEXPARQOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncexparqol
        {
            get { return  codfuncexparqol; }
            set {  codfuncexparqol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXPINTWMS
        /// Coment�rio: Campo para indicar c�digo do funcion�rio que exportou arquivos para a Integra��o WMS.
        /// </summary>
        private decimal? codfuncexpintwms;
        [XmlElement(ElementName = "CODFUNCEXPINTWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncexpintwms
        {
            get { return  codfuncexpintwms; }
            set {  codfuncexpintwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCIMPINTWMS
        /// Coment�rio: Campo para indicar c�digo do funcion�rio que importou arquivos para a Integra��o WMS.
        /// </summary>
        private decimal? codfuncimpintwms;
        [XmlElement(ElementName = "CODFUNCIMPINTWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncimpintwms
        {
            get { return  codfuncimpintwms; }
            set {  codfuncimpintwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBDESC
        /// Coment�rio: C�d.Libera��o Desc.
        /// </summary>
        private decimal? codfunclibdesc;
        [XmlElement(ElementName = "CODFUNCLIBDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunclibdesc
        {
            get { return  codfunclibdesc; }
            set {  codfunclibdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBERA
        /// Coment�rio: 
        /// </summary>
        private decimal? codfunclibera;
        [XmlElement(ElementName = "CODFUNCLIBERA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunclibera
        {
            get { return  codfunclibera; }
            set {  codfunclibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBERA2
        /// Coment�rio: C�digo funcion�rio liberou pedido ref. segundo motivo pedido bloqueado.
        /// </summary>
        private decimal? codfunclibera2;
        [XmlElement(ElementName = "CODFUNCLIBERA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunclibera2
        {
            get { return  codfunclibera2; }
            set {  codfunclibera2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBEROURET
        /// Coment�rio: Funcionario que liberou a retaguarda
        /// </summary>
        private decimal? codfuncliberouret;
        [XmlElement(ElementName = "CODFUNCLIBEROURET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncliberouret
        {
            get { return  codfuncliberouret; }
            set {  codfuncliberouret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCPROTOCOLO
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncprotocolo;
        [XmlElement(ElementName = "CODFUNCPROTOCOLO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncprotocolo
        {
            get { return  codfuncprotocolo; }
            set {  codfuncprotocolo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSEP
        /// Coment�rio: Indica o c�digo funcion�rio separador do pedido.
        /// </summary>
        private decimal? codfuncsep;
        [XmlElement(ElementName = "CODFUNCSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncsep
        {
            get { return  codfuncsep; }
            set {  codfuncsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOSAZONALIDADE
        /// Coment�rio: Indica o c�digo da sazonalidade.
        /// </summary>
        private decimal? codigosazonalidade;
        [XmlElement(ElementName = "CODIGOSAZONALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codigosazonalidade
        {
            get { return  codigosazonalidade; }
            set {  codigosazonalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDAESTRANGEIRA
        /// Coment�rio: Guarda c�digo da moeda estrageira no momento da venda
        /// </summary>
        private decimal? codmoedaestrangeira;
        [XmlElement(ElementName = "CODMOEDAESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codmoedaestrangeira
        {
            get { return  codmoedaestrangeira; }
            set {  codmoedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDAESTRANGEIRAORIGINAL
        /// Coment�rio: C�digo da moeda estrangeira usado originalmente no pedido de venda
        /// </summary>
        private decimal? codmoedaestrangeiraoriginal;
        [XmlElement(ElementName = "CODMOEDAESTRANGEIRAORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codmoedaestrangeiraoriginal
        {
            get { return  codmoedaestrangeiraoriginal; }
            set {  codmoedaestrangeiraoriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTBLOQUEIO
        /// Coment�rio: 
        /// </summary>
        private decimal? codmotbloqueio;
        [XmlElement(ElementName = "CODMOTBLOQUEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codmotbloqueio
        {
            get { return  codmotbloqueio; }
            set {  codmotbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTCANCEL
        /// Coment�rio: 
        /// </summary>
        private decimal? codmotcancel;
        [XmlElement(ElementName = "CODMOTCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codmotcancel
        {
            get { return  codmotcancel; }
            set {  codmotcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Coment�rio: Indica o c�digo do motivo do bloqueio do pedido.
        /// </summary>
        private decimal? codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO2
        /// Coment�rio: C�digo de motivo de bloqueio.
        /// </summary>
        private decimal? codmotivo2;
        [XmlElement(ElementName = "CODMOTIVO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codmotivo2
        {
            get { return  codmotivo2; }
            set {  codmotivo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: 
        /// </summary>
        private decimal? codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
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
        /// Coment�rio: Este campo determina o plano de pagamento a ser utilizado para itens tipo medicamentos eticos do pedido.
        /// </summary>
        private decimal? codplpagetico;
        [XmlElement(ElementName = "CODPLPAGETICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codplpagetico
        {
            get { return  codplpagetico; }
            set {  codplpagetico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGGENERICO
        /// Coment�rio: Este campo determina o plano de pagamento a ser utilizado para itens tipo medicamentos genericos do pedido
        /// </summary>
        private decimal? codplpaggenerico;
        [XmlElement(ElementName = "CODPLPAGGENERICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codplpaggenerico
        {
            get { return  codplpaggenerico; }
            set {  codplpaggenerico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPOSTAGEM
        /// Coment�rio: C�digo de postagem de correspond�ncias.
        /// </summary>
        private string codpostagem;
        [XmlElement(ElementName = "CODPOSTAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Codpostagem
        {
            get { return  codpostagem; }
            set {  codpostagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Coment�rio: 
        /// </summary>
        private decimal? codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal? Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACADESTINO
        /// Coment�rio: Indica o c�digo da pra�a do local da entrega.
        /// </summary>
        private decimal? codpracadestino;
        [XmlElement(ElementName = "CODPRACADESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codpracadestino
        {
            get { return  codpracadestino; }
            set {  codpracadestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Coment�rio: 
        /// </summary>
        private decimal? codprofissional;
        [XmlElement(ElementName = "CODPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprofissional
        {
            get { return  codprofissional; }
            set {  codprofissional = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Coment�rio: 
        /// </summary>
        private decimal? codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal? Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR2
        /// Coment�rio: 
        /// </summary>
        private decimal? codsupervisor2;
        [XmlElement(ElementName = "CODSUPERVISOR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codsupervisor2
        {
            get { return  codsupervisor2; }
            set {  codsupervisor2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR3
        /// Coment�rio: 
        /// </summary>
        private decimal? codsupervisor3;
        [XmlElement(ElementName = "CODSUPERVISOR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codsupervisor3
        {
            get { return  codsupervisor3; }
            set {  codsupervisor3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSP
        /// Coment�rio: Indica o c�digo da transportadora.
        /// </summary>
        private decimal? codtransp;
        [XmlElement(ElementName = "CODTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codtransp
        {
            get { return  codtransp; }
            set {  codtransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUNIDADEEXECUTORA
        /// Coment�rio: C�digo da unidade executora.
        /// </summary>
        private string codunidadeexecutora;
        [XmlElement(ElementName = "CODUNIDADEEXECUTORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codunidadeexecutora
        {
            get { return  codunidadeexecutora; }
            set {  codunidadeexecutora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo do primeiro profissional.
        /// </summary>
        private decimal? codusur2;
        [XmlElement(ElementName = "CODUSUR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codusur2
        {
            get { return  codusur2; }
            set {  codusur2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR3
        /// Coment�rio: Indica o c�digo do segundo profissional.
        /// </summary>
        private decimal? codusur3;
        [XmlElement(ElementName = "CODUSUR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codusur3
        {
            get { return  codusur3; }
            set {  codusur3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR4
        /// Coment�rio: Indica o c�digo do terceiro profissional.
        /// </summary>
        private decimal? codusur4;
        [XmlElement(ElementName = "CODUSUR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codusur4
        {
            get { return  codusur4; }
            set {  codusur4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Coment�rio: C�digo do Ve�culo. Usado no WMS, na integra��o WinThor X ALCIS. 
        /// </summary>
        private string codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVISITA
        /// Coment�rio: C�digo da visita.
        /// </summary>
        private decimal? codvisita;
        [XmlElement(ElementName = "CODVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codvisita
        {
            get { return  codvisita; }
            set {  codvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAFRETE
        /// Coment�rio: COLUNA DO FRETE
        /// </summary>
        private decimal? colunafrete;
        [XmlElement(ElementName = "COLUNAFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Colunafrete
        {
            get { return  colunafrete; }
            set {  colunafrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCILIAIMPORTACAO
        /// Coment�rio: 
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
        /// Coment�rio: Indica a condi��o de venda. 
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
        /// Propriedade referente ao campo: CONFERINDOPEDIDO
        /// Coment�rio: 
        /// </summary>
        private string conferindopedido;
        [XmlElement(ElementName = "CONFERINDOPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferindopedido
        {
            get { return  conferindopedido; }
            set {  conferindopedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSUMIUNUMNFE
        /// Coment�rio: Flag que indica se mantem ou n�o a numera��o original do n�mero da Nota Fiscal
        /// </summary>
        private string consumiunumnfe;
        [XmlElement(ElementName = "CONSUMIUNUMNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consumiunumnfe
        {
            get { return  consumiunumnfe; }
            set {  consumiunumnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAORDEM
        /// Coment�rio: Indica que a venda TV7 � do tipo conta e ordem.
        /// </summary>
        private string contaordem;
        [XmlElement(ElementName = "CONTAORDEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contaordem
        {
            get { return  contaordem; }
            set {  contaordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTINGENCIATV14
        /// Coment�rio: Indica conting�ncia
        /// </summary>
        private string contingenciatv14;
        [XmlElement(ElementName = "CONTINGENCIATV14", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contingenciatv14
        {
            get { return  contingenciatv14; }
            set {  contingenciatv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRMALTDEBCREDRCA
        /// Coment�rio: Log de PCCONSUM.CRMALTDEBCREDRCA.
        /// </summary>
        private string crmaltdebcredrca;
        [XmlElement(ElementName = "CRMALTDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Crmaltdebcredrca
        {
            get { return  crmaltdebcredrca; }
            set {  crmaltdebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOBONIFICACAO
        /// Coment�rio: Custo da bonifica��o TV5.
        /// </summary>
        private string custobonificacao;
        [XmlElement(ElementName = "CUSTOBONIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Custobonificacao
        {
            get { return  custobonificacao; }
            set {  custobonificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOENTREGA
        /// Coment�rio: 
        /// </summary>
        private decimal? custoentrega;
        [XmlElement(ElementName = "CUSTOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Custoentrega
        {
            get { return  custoentrega; }
            set {  custoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DATAEMPENHO
        /// Coment�rio: Data de Empenho.
        /// </summary>
        private DateTime? dataempenho;
        [XmlElement(ElementName = "DATAEMPENHO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataempenho
        {
            get { return  dataempenho; }
            set {  dataempenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAEXPARQOL
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataexparqol;
        [XmlElement(ElementName = "DATAEXPARQOL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataexparqol
        {
            get { return  dataexparqol; }
            set {  dataexparqol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALIBEROURET
        /// Coment�rio: Data que liberou retaguarda
        /// </summary>
        private DateTime? dataliberouret;
        [XmlElement(ElementName = "DATALIBEROURET", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataliberouret
        {
            get { return  dataliberouret; }
            set {  dataliberouret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAPEDCLI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DATAPROTOCOLO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataprotocolo;
        [XmlElement(ElementName = "DATAPROTOCOLO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataprotocolo
        {
            get { return  dataprotocolo; }
            set {  dataprotocolo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEVSIMBOLICA
        /// Coment�rio: Esse atributo serve para identificar se a opera��o, � uma devolu��o simb�lica ou n�o.
        /// </summary>
        private string devsimbolica;
        [XmlElement(ElementName = "DEVSIMBOLICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Devsimbolica
        {
            get { return  devsimbolica; }
            set {  devsimbolica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCEMISSAO
        /// Coment�rio: Tipo de documento de emiss�o da venda.
        /// </summary>
        private string docemissao;
        [XmlElement(ElementName = "DOCEMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Docemissao
        {
            get { return  docemissao; }
            set {  docemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURAPEDPALM
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTAHORAENTRADACONTIGENCIA
        /// Coment�rio: Data que o for�a de vendas precisou emitir a DANFE em conting�ncia.
        /// </summary>
        private DateTime? dtahoraentradacontigencia;
        [XmlElement(ElementName = "DTAHORAENTRADACONTIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtahoraentradacontigencia
        {
            get { return  dtahoraentradacontigencia; }
            set {  dtahoraentradacontigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCALCFRETE
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTCHEGADACLIENTE
        /// Coment�rio: Data/hora chegada do cliente
        /// </summary>
        private DateTime? dtchegadacliente;
        [XmlElement(ElementName = "DTCHEGADACLIENTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtchegadacliente
        {
            get { return  dtchegadacliente; }
            set {  dtchegadacliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONFGARANTIA
        /// Coment�rio: Indica a data confer�ncia para garantia.
        /// </summary>
        private DateTime? dtconfgarantia;
        [XmlElement(ElementName = "DTCONFGARANTIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtconfgarantia
        {
            get { return  dtconfgarantia; }
            set {  dtconfgarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOMAPA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtemissaomapa;
        [XmlElement(ElementName = "DTEMISSAOMAPA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaomapa
        {
            get { return  dtemissaomapa; }
            set {  dtemissaomapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Coment�rio: 
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
        /// Coment�rio: Campo para gravar a data, hora e minutos que o pedido de venda foi exportado.
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
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexportacaoservint;
        [XmlElement(ElementName = "DTEXPORTACAOSERVINT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaoservint
        {
            get { return  dtexportacaoservint; }
            set {  dtexportacaoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAOWMS
        /// Coment�rio: Data  e hora de exporta��o
        /// </summary>
        private DateTime? dtexportacaowms;
        [XmlElement(ElementName = "DTEXPORTACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaowms
        {
            get { return  dtexportacaowms; }
            set {  dtexportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTADO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexportado;
        [XmlElement(ElementName = "DTEXPORTADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportado
        {
            get { return  dtexportado; }
            set {  dtexportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFAT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfat;
        [XmlElement(ElementName = "DTFAT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfat
        {
            get { return  dtfat; }
            set {  dtfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTOPEDPALM
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTFIMDIGITACAOPEDIDO
        /// Coment�rio: Data Fim Digita��o Pedido
        /// </summary>
        private DateTime? dtfimdigitacaopedido;
        [XmlElement(ElementName = "DTFIMDIGITACAOPEDIDO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimdigitacaopedido
        {
            get { return  dtfimdigitacaopedido; }
            set {  dtfimdigitacaopedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfinalcheckout;
        [XmlElement(ElementName = "DTFINALCHECKOUT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalcheckout
        {
            get { return  dtfinalcheckout; }
            set {  dtfinalcheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRASTREAMENTO
        /// Coment�rio: 
        /// </summary>
        private string codrastreamento;
        [XmlElement(ElementName = "CODRASTREAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Codrastreamento
        {
            get { return codrastreamento; }
            set { codrastreamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: URLRASTREAMENTO
        /// Coment�rio: 
        /// </summary>
        private string urlrastreamento;
        [XmlElement(ElementName = "URLRASTREAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 200)]
        public string URLrastreamento
        {
            get { return urlrastreamento; }
            set { urlrastreamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALPEND
        /// Coment�rio: Indica a data de fim da pend�ncia do carregamento.
        /// </summary>
        private DateTime? dtfinalpend;
        [XmlElement(ElementName = "DTFINALPEND", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalpend
        {
            get { return  dtfinalpend; }
            set {  dtfinalpend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALSEP
        /// Coment�rio: Data/hora final para controle de produtividade de separa��o de pedidos. 
        /// </summary>
        private DateTime? dtfinalsep;
        [XmlElement(ElementName = "DTFINALSEP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalsep
        {
            get { return  dtfinalsep; }
            set {  dtfinalsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAO
        /// Coment�rio: Campo para gravar a data, hora e minutos que foi importado e processado os arquivos de retorno dos pedidos de venda.
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
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtimportacaoservprinc;
        [XmlElement(ElementName = "DTIMPORTACAOSERVPRINC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaoservprinc
        {
            get { return  dtimportacaoservprinc; }
            set {  dtimportacaoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOWMS
        /// Coment�rio: Data  e hora de importa��o
        /// </summary>
        private DateTime? dtimportacaowms;
        [XmlElement(ElementName = "DTIMPORTACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaowms
        {
            get { return  dtimportacaowms; }
            set {  dtimportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTADO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtimportado;
        [XmlElement(ElementName = "DTIMPORTADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportado
        {
            get { return  dtimportado; }
            set {  dtimportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIALCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinicialcheckout;
        [XmlElement(ElementName = "DTINICIALCHECKOUT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicialcheckout
        {
            get { return  dtinicialcheckout; }
            set {  dtinicialcheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIALPEND
        /// Coment�rio: Indica a data de inicio da pend�ncia do carregamento.
        /// </summary>
        private DateTime? dtinicialpend;
        [XmlElement(ElementName = "DTINICIALPEND", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicialpend
        {
            get { return  dtinicialpend; }
            set {  dtinicialpend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIALSEP
        /// Coment�rio: Data/hora inicial para controle de produtividade de separa��o de pedidos. 
        /// </summary>
        private DateTime? dtinicialsep;
        [XmlElement(ElementName = "DTINICIALSEP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicialsep
        {
            get { return  dtinicialsep; }
            set {  dtinicialsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIODIGITACAOPEDIDO
        /// Coment�rio: Data in�cio Digita��o Pedido
        /// </summary>
        private DateTime? dtiniciodigitacaopedido;
        [XmlElement(ElementName = "DTINICIODIGITACAOPEDIDO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciodigitacaopedido
        {
            get { return  dtiniciodigitacaopedido; }
            set {  dtiniciodigitacaopedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBERA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTLIBERA2
        /// Coment�rio: Data de libera��o pedido ref. segundo motivo do pedido bloqueio.
        /// </summary>
        private DateTime? dtlibera2;
        [XmlElement(ElementName = "DTLIBERA2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlibera2
        {
            get { return  dtlibera2; }
            set {  dtlibera2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIMITEFAT
        /// Coment�rio: Data Limite para Faturamento.
        /// </summary>
        private DateTime? dtlimitefat;
        [XmlElement(ElementName = "DTLIMITEFAT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlimitefat
        {
            get { return  dtlimitefat; }
            set {  dtlimitefat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNFTRANSF
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtnftransf;
        [XmlElement(ElementName = "DTNFTRANSF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnftransf
        {
            get { return  dtnftransf; }
            set {  dtnftransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTWMS
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtwms;
        [XmlElement(ElementName = "DTWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtwms
        {
            get { return  dtwms; }
            set {  dtwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCOBRANCA
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ENVIADOCOMPRA
        /// Coment�rio: Verificar se pedido j� foi enviado para setor de compras
        /// </summary>
        private string enviadocompra;
        [XmlElement(ElementName = "ENVIADOCOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadocompra
        {
            get { return  enviadocompra; }
            set {  enviadocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADOVENDA
        /// Coment�rio: Verificar se pedido j� foi enviado para setor de vendas
        /// </summary>
        private string enviadovenda;
        [XmlElement(ElementName = "ENVIADOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadovenda
        {
            get { return  enviadovenda; }
            set {  enviadovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIEMANIF
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ESPECIEVOLUME
        /// Coment�rio: Indica a especie dos volumes da nota fiscal.
        /// </summary>
        private string especievolume;
        [XmlElement(ElementName = "ESPECIEVOLUME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Especievolume
        {
            get { return  especievolume; }
            set {  especievolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Coment�rio: 
        /// </summary>
        private string exportadoservint;
        [XmlElement(ElementName = "EXPORTADOSERVINT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadoservint
        {
            get { return  exportadoservint; }
            set {  exportadoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORNECENTREGA
        /// Coment�rio: Campo que grava o pedido do cliente como venda com entrega pelo fornecedor.
        /// </summary>
        private string fornecentrega;
        [XmlElement(ElementName = "FORNECENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fornecentrega
        {
            get { return  fornecentrega; }
            set {  fornecentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEDESPACHO
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se o pedido de transferencia de mercadoria gera contas a pagar.
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
        /// Coment�rio: Gera controle de entrega.
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
        /// Propriedade referente ao campo: GERARDADOSNFPAULISTA
        /// Coment�rio: Op��o para identificar ou n�o o cliente que est� realizando venda no processo da nota fiscal paulista.
        /// </summary>
        private string gerardadosnfpaulista;
        [XmlElement(ElementName = "GERARDADOSNFPAULISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerardadosnfpaulista
        {
            get { return  gerardadosnfpaulista; }
            set {  gerardadosnfpaulista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: HORAEMISSAO
        /// Coment�rio: Hora do faturamento do pedido.
        /// </summary>
        private string horaemissao;
        [XmlElement(ElementName = "HORAEMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Horaemissao
        {
            get { return  horaemissao; }
            set {  horaemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAEMISSAOMAPA
        /// Coment�rio: 
        /// </summary>
        private decimal horaemissaomapa;
        [XmlElement(ElementName = "HORAEMISSAOMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horaemissaomapa
        {
            get { return  horaemissaomapa; }
            set {  horaemissaomapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFAT
        /// Coment�rio: 
        /// </summary>
        private decimal horafat;
        [XmlElement(ElementName = "HORAFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafat
        {
            get { return  horafat; }
            set {  horafat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFINALSEP
        /// Coment�rio: 
        /// </summary>
        private decimal horafinalsep;
        [XmlElement(ElementName = "HORAFINALSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafinalsep
        {
            get { return  horafinalsep; }
            set {  horafinalsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIALSEP
        /// Coment�rio: 
        /// </summary>
        private decimal horainicialsep;
        [XmlElement(ElementName = "HORAINICIALSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horainicialsep
        {
            get { return  horainicialsep; }
            set {  horainicialsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORALIBERA
        /// Coment�rio: 
        /// </summary>
        private decimal horalibera;
        [XmlElement(ElementName = "HORALIBERA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horalibera
        {
            get { return  horalibera; }
            set {  horalibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAPROTOCOLO
        /// Coment�rio: 
        /// </summary>
        private decimal horaprotocolo;
        [XmlElement(ElementName = "HORAPROTOCOLO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horaprotocolo
        {
            get { return  horaprotocolo; }
            set {  horaprotocolo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDAGRUPAMENTO
        /// Coment�rio: Identifica��o de Agrupamento
        /// </summary>
        private string idagrupamento;
        [XmlElement(ElementName = "IDAGRUPAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Idagrupamento
        {
            get { return  idagrupamento; }
            set {  idagrupamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTIPOPRESENCA
        /// Coment�rio: Indica o tipo de presen�a do comprador no estabelecimento no momento da opera��o
        /// </summary>
        private string idtipopresenca;
        [XmlElement(ElementName = "IDTIPOPRESENCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Idtipopresenca
        {
            get { return  idtipopresenca; }
            set {  idtipopresenca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTACUPOM
        /// Coment�rio: 
        /// </summary>
        private decimal importacupom;
        [XmlElement(ElementName = "IMPORTACUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Importacupom
        {
            get { return  importacupom; }
            set {  importacupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private string importadoservprinc;
        [XmlElement(ElementName = "IMPORTADOSERVPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoservprinc
        {
            get { return  importadoservprinc; }
            set {  importadoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Coment�rio: Recebe o c�digo da integradora de dados.
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
        /// Propriedade referente ao campo: JUSTIFICATIVACONTIGENCIA
        /// Coment�rio: Informa para a Sefaz o motivo da n�o emiss�o da NFE em modo normal.
        /// </summary>
        private string justificativacontigencia;
        [XmlElement(ElementName = "JUSTIFICATIVACONTIGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,256)]
        public string Justificativacontigencia
        {
            get { return  justificativacontigencia; }
            set {  justificativacontigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBERA_RETAGUARDA
        /// Coment�rio: Parametro para liberar ou n�o retaguarda
        /// </summary>
        private string libera_retaguarda;
        [XmlElement(ElementName = "LIBERA_RETAGUARDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Libera_Retaguarda
        {
            get { return  libera_retaguarda; }
            set {  libera_retaguarda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALDESEMBARACO
        /// Coment�rio: Observa��o de embarque.
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
        /// Propriedade referente ao campo: LOCALIZACAOPEDIDO
        /// Coment�rio: Indica a localiza��o do pedido.
        /// </summary>
        private string localizacaopedido;
        [XmlElement(ElementName = "LOCALIZACAOPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Localizacaopedido
        {
            get { return  localizacaopedido; }
            set {  localizacaopedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOG
        /// Coment�rio: Indica o log do motivo de bloqueio.|Campo do tipo caracter, de tamanho 4000. 
        /// </summary>
        private string log;
        [XmlElement(ElementName = "LOG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Log
        {
            get { return  log; }
            set {  log = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOG1
        /// Coment�rio: Log do Bloqueio do Pedido.
        /// </summary>
        private string log1;
        [XmlElement(ElementName = "LOG1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Log1
        {
            get { return  log1; }
            set {  log1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOG2
        /// Coment�rio: Complemento do Log do Bloqueio do Pedido.
        /// </summary>
        private string log2;
        [XmlElement(ElementName = "LOG2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Log2
        {
            get { return  log2; }
            set {  log2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOG3
        /// Coment�rio: Complemento do Log do Bloqueio do Pedido.
        /// </summary>
        private string log3;
        [XmlElement(ElementName = "LOG3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Log3
        {
            get { return  log3; }
            set {  log3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOG4
        /// Coment�rio: Complemento do Log do Bloqueio do Pedido.
        /// </summary>
        private string log4;
        [XmlElement(ElementName = "LOG4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Log4
        {
            get { return  log4; }
            set {  log4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARCAVOLUME
        /// Coment�rio: Indica a marca dos produtos da nota fiscal.
        /// </summary>
        private string marcavolume;
        [XmlElement(ElementName = "MARCAVOLUME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Marcavolume
        {
            get { return  marcavolume; }
            set {  marcavolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: MINUTOEMISSAOMAPA
        /// Coment�rio: 
        /// </summary>
        private decimal minutoemissaomapa;
        [XmlElement(ElementName = "MINUTOEMISSAOMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoemissaomapa
        {
            get { return  minutoemissaomapa; }
            set {  minutoemissaomapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFAT
        /// Coment�rio: 
        /// </summary>
        private decimal minutofat;
        [XmlElement(ElementName = "MINUTOFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutofat
        {
            get { return  minutofat; }
            set {  minutofat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFINALSEP
        /// Coment�rio: 
        /// </summary>
        private decimal minutofinalsep;
        [XmlElement(ElementName = "MINUTOFINALSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutofinalsep
        {
            get { return  minutofinalsep; }
            set {  minutofinalsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOINICIALSEP
        /// Coment�rio: 
        /// </summary>
        private decimal minutoinicialsep;
        [XmlElement(ElementName = "MINUTOINICIALSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoinicialsep
        {
            get { return  minutoinicialsep; }
            set {  minutoinicialsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOLIBERA
        /// Coment�rio: 
        /// </summary>
        private decimal minutolibera;
        [XmlElement(ElementName = "MINUTOLIBERA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutolibera
        {
            get { return  minutolibera; }
            set {  minutolibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOPROTOCOLO
        /// Coment�rio: 
        /// </summary>
        private decimal minutoprotocolo;
        [XmlElement(ElementName = "MINUTOPROTOCOLO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoprotocolo
        {
            get { return  minutoprotocolo; }
            set {  minutoprotocolo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MONTANDO
        /// Coment�rio: 
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
        /// Coment�rio: Indica o motivo da posi��o do pedido.
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
        /// Propriedade referente ao campo: MOTORISTAVEICULO
        /// Coment�rio: Motorista do ve�culo
        /// </summary>
        private string motoristaveiculo;
        [XmlElement(ElementName = "MOTORISTAVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Motoristaveiculo
        {
            get { return  motoristaveiculo; }
            set {  motoristaveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NEGOCIADO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NOMEARQUIVOFV
        /// Coment�rio: Usado para auxiliar na busca de pedidos referentes ao arquivo. 
        /// </summary>
        private string nomearquivofv;
        [XmlElement(ElementName = "NOMEARQUIVOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomearquivofv
        {
            get { return  nomearquivofv; }
            set {  nomearquivofv = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: NSUSOCIOTORCEDOR
        /// Coment�rio: N�mero de Transa��o Sitef
        /// </summary>
        private string nsusociotorcedor;
        [XmlElement(ElementName = "NSUSOCIOTORCEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsusociotorcedor
        {
            get { return  nsusociotorcedor; }
            set {  nsusociotorcedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUTEF
        /// Coment�rio: Indica o n�mero de transa��o no TEF.
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
        /// Coment�rio: N�mero do caixa (check-out).
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
        /// Propriedade referente ao campo: NUMCAIXAFISCAL
        /// Coment�rio: 
        /// </summary>
        private decimal numcaixafiscal;
        [XmlElement(ElementName = "NUMCAIXAFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixafiscal
        {
            get { return  numcaixafiscal; }
            set {  numcaixafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }     

        /// <summary>
        /// Propriedade referente ao campo: NUMCARANTERIOR
        /// Coment�rio: Indica o numero do carregamento anterior.
        /// </summary>
        private decimal numcaranterior;
        [XmlElement(ElementName = "NUMCARANTERIOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcaranterior
        {
            get { return  numcaranterior; }
            set {  numcaranterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARAUX
        /// Coment�rio: 
        /// </summary>
        private decimal numcaraux;
        [XmlElement(ElementName = "NUMCARAUX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcaraux
        {
            get { return  numcaraux; }
            set {  numcaraux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARFAB
        /// Coment�rio: 
        /// </summary>
        private decimal numcarfab;
        [XmlElement(ElementName = "NUMCARFAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcarfab
        {
            get { return  numcarfab; }
            set {  numcarfab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARMANIF
        /// Coment�rio: 
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
        /// Coment�rio: Contador de Cupom Fiscal.
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
        /// Propriedade referente ao campo: NUMCHAVEEXP
        /// Coment�rio: N�mero da Chave de Acesso da Nfe recebida para exporta��o
        /// </summary>
        private string numchaveexp;
        [XmlElement(ElementName = "NUMCHAVEEXP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Numchaveexp
        {
            get { return  numchaveexp; }
            set {  numchaveexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCIRURGIA
        /// Coment�rio: N�mero Cirurgia
        /// </summary>
        private decimal? numcirurgia;
        [XmlElement(ElementName = "NUMCIRURGIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numcirurgia
        {
            get { return  numcirurgia; }
            set {  numcirurgia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOLETA
        /// Coment�rio: Indica o n�mero da coleta transportadora.|Campo do tipo caracter, de tamanho 10. 
        /// </summary>
        private string numcoleta;
        [XmlElement(ElementName = "NUMCOLETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numcoleta
        {
            get { return  numcoleta; }
            set {  numcoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATOCORREIO
        /// Coment�rio: 
        /// </summary>
        private decimal numcontratocorreio;
        [XmlElement(ElementName = "NUMCONTRATOCORREIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcontratocorreio
        {
            get { return  numcontratocorreio; }
            set {  numcontratocorreio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Coment�rio: 
        /// </summary>
        private decimal? numcupom;
        [XmlElement(ElementName = "NUMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numcupom
        {
            get { return  numcupom; }
            set {  numcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDRAWBACK
        /// Coment�rio: N�mero do ato concess�rio do Drawback
        /// </summary>
        private decimal numdrawback;
        [XmlElement(ElementName = "NUMDRAWBACK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public decimal Numdrawback
        {
            get { return  numdrawback; }
            set {  numdrawback = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMECF
        /// Coment�rio: 
        /// </summary>
        private decimal numecf;
        [XmlElement(ElementName = "NUMECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numecf
        {
            get { return  numecf; }
            set {  numecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEMPENHO
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMFORMULARIO
        /// Coment�rio: N�mero do formul�rio da nota fiscal
        /// </summary>
        private decimal? numformulario;
        [XmlElement(ElementName = "NUMFORMULARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numformulario
        {
            get { return  numformulario; }
            set {  numformulario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITENS
        /// Coment�rio: 
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
        /// Coment�rio: N�mero da Lista de Presente
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
        /// Propriedade referente ao campo: NUMLOTEINTWMS
        /// Coment�rio: Campo para gravar o c�digo do lote de retorno da integra��o WMS.
        /// </summary>
        private decimal numloteintwms;
        [XmlElement(ElementName = "NUMLOTEINTWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Numloteintwms
        {
            get { return  numloteintwms; }
            set {  numloteintwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNFTRANSF
        /// Coment�rio: 
        /// </summary>
        private decimal numnftransf;
        [XmlElement(ElementName = "NUMNFTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnftransf
        {
            get { return  numnftransf; }
            set {  numnftransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMNOTACONSIG
        /// Coment�rio: 
        /// </summary>
        private decimal? numnotaconsig;
        [XmlElement(ElementName = "NUMNOTACONSIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numnotaconsig
        {
            get { return  numnotaconsig; }
            set {  numnotaconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAMANIF
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMNOTATRANSFDEP
        /// Coment�rio: 
        /// </summary>
        private decimal numnotatransfdep;
        [XmlElement(ElementName = "NUMNOTATRANSFDEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotatransfdep
        {
            get { return  numnotatransfdep; }
            set {  numnotatransfdep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMORCAFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMORCAPRINC
        /// Coment�rio: Indica o n�mero de or�amento principal.
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
        /// Propriedade referente ao campo: NUMORDEMCARGA
        /// Coment�rio: 
        /// </summary>
        private decimal numordemcarga;
        [XmlElement(ElementName = "NUMORDEMCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numordemcarga
        {
            get { return  numordemcarga; }
            set {  numordemcarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDAGRUPADO
        /// Coment�rio: Numero do agrupamento pedido
        /// </summary>
        private decimal numpedagrupado;
        [XmlElement(ElementName = "NUMPEDAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedagrupado
        {
            get { return  numpedagrupado; }
            set {  numpedagrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDBNF
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMPEDORIGEMFRETE
        /// Coment�rio: Indica o numero origem do pedido de frete.
        /// </summary>
        private decimal numpedorigemfrete;
        [XmlElement(ElementName = "NUMPEDORIGEMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedorigemfrete
        {
            get { return  numpedorigemfrete; }
            set {  numpedorigemfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Coment�rio: 
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
        /// Coment�rio: Indica o n�mero do pedido que originou a bonifica��o.
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
        /// Propriedade referente ao campo: NUMPEDTV14
        /// Coment�rio: N�mero do pedido original que gerou a bonifica��o
        /// </summary>
        private decimal numpedtv14;
        [XmlElement(ElementName = "NUMPEDTV14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedtv14
        {
            get { return  numpedtv14; }
            set {  numpedtv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDTV3
        /// Coment�rio: N�mero do pedido de venda broker terceirizado.
        /// </summary>
        private decimal numpedtv3;
        [XmlElement(ElementName = "NUMPEDTV3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedtv3
        {
            get { return  numpedtv3; }
            set {  numpedtv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDVALE
        /// Coment�rio: 
        /// </summary>
        private decimal numpedvale;
        [XmlElement(ElementName = "NUMPEDVALE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedvale
        {
            get { return  numpedvale; }
            set {  numpedvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDVANXML
        /// Coment�rio: Num. Pedido VAN para gravar no XML da NF-e.
        /// </summary>
        private string numpedvanxml;
        [XmlElement(ElementName = "NUMPEDVANXML", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numpedvanxml
        {
            get { return  numpedvanxml; }
            set {  numpedvanxml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDWEB
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMPESO
        /// Coment�rio: Indica o peso total da carga informado pelo usu�rio.
        /// </summary>
        private decimal numpeso;
        [XmlElement(ElementName = "NUMPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Numpeso
        {
            get { return  numpeso; }
            set {  numpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPREVENDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMPROCESSO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMREGEXP
        /// Coment�rio: N�mero do Registro de Exporta��o�
        /// </summary>
        private decimal numregexp;
        [XmlElement(ElementName = "NUMREGEXP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numregexp
        {
            get { return  numregexp; }
            set {  numregexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: Regi�o de pre�o usada no pedido. 
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
        /// Propriedade referente ao campo: NUMSELO
        /// Coment�rio: N�mero do Selo da Sefaz
        /// </summary>
        private string numselo;
        [XmlElement(ElementName = "NUMSELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numselo
        {
            get { return  numselo; }
            set {  numselo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQCORREIO
        /// Coment�rio: 
        /// </summary>
        private decimal numseqcorreio;
        [XmlElement(ElementName = "NUMSEQCORREIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numseqcorreio
        {
            get { return  numseqcorreio; }
            set {  numseqcorreio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTR
        /// Coment�rio: 
        /// </summary>
        private decimal numseqentr;
        [XmlElement(ElementName = "NUMSEQENTR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseqentr
        {
            get { return  numseqentr; }
            set {  numseqentr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTREGA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMSEQENVIO
        /// Coment�rio: Campo para gravar o n�mero de seq��ncia dos arquivos enviado..
        /// </summary>
        private decimal numseqenvio;
        [XmlElement(ElementName = "NUMSEQENVIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numseqenvio
        {
            get { return  numseqenvio; }
            set {  numseqenvio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQMONTAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal numseqmontagem;
        [XmlElement(ElementName = "NUMSEQMONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseqmontagem
        {
            get { return  numseqmontagem; }
            set {  numseqmontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQRETORNO1
        /// Coment�rio: Campo para indicar que o pedido foi processado e gravado o numero de retornado do WMS de integra��o.
        /// </summary>
        private decimal numseqretorno1;
        [XmlElement(ElementName = "NUMSEQRETORNO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqretorno1
        {
            get { return  numseqretorno1; }
            set {  numseqretorno1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQRETORNO2
        /// Coment�rio: Campo para indicar que o pedido foi processado e gravado o numero de retornado do WMS de integra��o.
        /// </summary>
        private decimal numseqretorno2;
        [XmlElement(ElementName = "NUMSEQRETORNO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqretorno2
        {
            get { return  numseqretorno2; }
            set {  numseqretorno2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQROTA
        /// Coment�rio: 
        /// </summary>
        private decimal numseqrota;
        [XmlElement(ElementName = "NUMSEQROTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseqrota
        {
            get { return  numseqrota; }
            set {  numseqrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMTRANSACAOTRANSF
        /// Coment�rio: N�mero de transa��o de transfer�ncia.
        /// </summary>
        private decimal numtransacaotransf;
        [XmlElement(ElementName = "NUMTRANSACAOTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransacaotransf
        {
            get { return  numtransacaotransf; }
            set {  numtransacaotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMTRANSVENDATV13
        /// Coment�rio: N�mero de transa��o da nota fiscal tipo 13.
        /// </summary>
        private decimal numtransvendatv13;
        [XmlElement(ElementName = "NUMTRANSVENDATV13", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendatv13
        {
            get { return  numtransvendatv13; }
            set {  numtransvendatv13 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Coment�rio: 
        /// </summary>
        private decimal numtranswms;
        [XmlElement(ElementName = "NUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranswms
        {
            get { return  numtranswms; }
            set {  numtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASETIQUETA
        /// Coment�rio: Numero de vias da emiss�o etiquetas do pedido.
        /// </summary>
        private decimal numviasetiqueta;
        [XmlElement(ElementName = "NUMVIASETIQUETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviasetiqueta
        {
            get { return  numviasetiqueta; }
            set {  numviasetiqueta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASMAPASEP
        /// Coment�rio: 
        /// </summary>
        private decimal numviasmapasep;
        [XmlElement(ElementName = "NUMVIASMAPASEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviasmapasep
        {
            get { return  numviasmapasep; }
            set {  numviasmapasep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASPEDAGRUPADO
        /// Coment�rio: Vias do mapa pedido agrupado
        /// </summary>
        private decimal numviaspedagrupado;
        [XmlElement(ElementName = "NUMVIASPEDAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviaspedagrupado
        {
            get { return  numviaspedagrupado; }
            set {  numviaspedagrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASPEDIDO
        /// Coment�rio: 
        /// </summary>
        private decimal numviaspedido;
        [XmlElement(ElementName = "NUMVIASPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviaspedido
        {
            get { return  numviaspedido; }
            set {  numviaspedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLUME
        /// Coment�rio: N�mero do volume
        /// </summary>
        private decimal numvolume;
        [XmlElement(ElementName = "NUMVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numvolume
        {
            get { return  numvolume; }
            set {  numvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLUMEAGRUPADO
        /// Coment�rio: Campo receber� o somat�rio do n�mero do volumes (NUMVOLUME) dos pedidos selecionados na rotina 1406.
        /// </summary>
        private decimal numvolumeagrupado;
        [XmlElement(ElementName = "NUMVOLUMEAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvolumeagrupado
        {
            get { return  numvolumeagrupado; }
            set {  numvolumeagrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero do lan�amento do SoftM�vel.
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
        /// Propriedade referente ao campo: OBSFRETENF1
        /// Coment�rio: 
        /// </summary>
        private string obsfretenf1;
        [XmlElement(ElementName = "OBSFRETENF1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsfretenf1
        {
            get { return  obsfretenf1; }
            set {  obsfretenf1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSFRETENF2
        /// Coment�rio: 
        /// </summary>
        private string obsfretenf2;
        [XmlElement(ElementName = "OBSFRETENF2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsfretenf2
        {
            get { return  obsfretenf2; }
            set {  obsfretenf2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSFRETENF3
        /// Coment�rio: 
        /// </summary>
        private string obsfretenf3;
        [XmlElement(ElementName = "OBSFRETENF3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obsfretenf3
        {
            get { return  obsfretenf3; }
            set {  obsfretenf3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS1
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ORIGEMPED
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PAGTOANTECIPADO
        /// Coment�rio: 
        /// </summary>
        private string pagtoantecipado;
        [XmlElement(ElementName = "PAGTOANTECIPADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtoantecipado
        {
            get { return  pagtoantecipado; }
            set {  pagtoantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDDUPLICADO
        /// Coment�rio: Indica se o pedido foi duplicado.
        /// </summary>
        private string pedduplicado;
        [XmlElement(ElementName = "PEDDUPLICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pedduplicado
        {
            get { return  pedduplicado; }
            set {  pedduplicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOAVARIA
        /// Coment�rio: Pedido de Avaria
        /// </summary>
        private string pedidoavaria;
        [XmlElement(ElementName = "PEDIDOAVARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pedidoavaria
        {
            get { return  pedidoavaria; }
            set {  pedidoavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOEMBALADO
        /// Coment�rio: 
        /// </summary>
        private string pedidoembalado;
        [XmlElement(ElementName = "PEDIDOEMBALADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Pedidoembalado
        {
            get { return  pedidoembalado; }
            set {  pedidoembalado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOPAGOECOMMERCE
        /// Coment�rio: Pedido pago pelo e-commerce
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
        /// Propriedade referente ao campo: PERCCOMPROFISSIONAL
        /// Coment�rio: Indica o percentual de comissao do profissional cadastrado na rotina 340. 
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
        /// Propriedade referente ao campo: PERCDESCABC
        /// Coment�rio: 
        /// </summary>
        private decimal percdescabc;
        [XmlElement(ElementName = "PERCDESCABC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescabc
        {
            get { return  percdescabc; }
            set {  percdescabc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCCANAL
        /// Coment�rio: 
        /// </summary>
        private decimal percdesccanal;
        [XmlElement(ElementName = "PERCDESCCANAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdesccanal
        {
            get { return  percdesccanal; }
            set {  percdesccanal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCCLI
        /// Coment�rio: 
        /// </summary>
        private decimal percdesccli;
        [XmlElement(ElementName = "PERCDESCCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdesccli
        {
            get { return  percdesccli; }
            set {  percdesccli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCNEG
        /// Coment�rio: 
        /// </summary>
        private decimal percdescneg;
        [XmlElement(ElementName = "PERCDESCNEG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescneg
        {
            get { return  percdescneg; }
            set {  percdescneg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE
        /// Coment�rio: Indica o percentual de frete do pedido.
        /// </summary>
        private decimal percfrete;
        [XmlElement(ElementName = "PERCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percfrete
        {
            get { return  percfrete; }
            set {  percfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETERETIDO
        /// Coment�rio: Percentual de frete retido.
        /// </summary>
        private decimal percfreteretido;
        [XmlElement(ElementName = "PERCFRETERETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percfreteretido
        {
            get { return  percfreteretido; }
            set {  percfreteretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSALDORESERVARCA
        /// Coment�rio: Percentual de Reserva da Conta-Corrente do RCA.
        /// </summary>
        private decimal percsaldoreservarca;
        [XmlElement(ElementName = "PERCSALDORESERVARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percsaldoreservarca
        {
            get { return  percsaldoreservarca; }
            set {  percsaldoreservarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSTFRETERETIDO
        /// Coment�rio: Percentual de ST do frete retido.
        /// </summary>
        private decimal percstfreteretido;
        [XmlElement(ElementName = "PERCSTFRETERETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percstfreteretido
        {
            get { return  percstfreteretido; }
            set {  percstfreteretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVENDA
        /// Coment�rio: Indica o percentual do pedido atendido.
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
        /// Coment�rio: Indica o percentual desconto negociado na venda.
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
        /// Coment�rio: Percentual de desconta � vista
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
        /// Coment�rio: Percentual de desconto financeiro informado no pedido, somente ser� preenchido, caso o par�metro "Utiliza Saldo C.Corrente como Desc.Fin." 
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
        /// Propriedade referente ao campo: PERDESCLIB
        /// Coment�rio: Perc. Desc. Liberado
        /// </summary>
        private decimal perdesclib;
        [XmlElement(ElementName = "PERDESCLIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdesclib
        {
            get { return  perdesclib; }
            set {  perdesclib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACAVEICULO
        /// Coment�rio: Placa do Veiculo Transporte.
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
        /// Propriedade referente ao campo: PLPAGAVISTA
        /// Coment�rio: Plano de pagamento � vista
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PRAZOADICIONAL
        /// Coment�rio: 
        /// </summary>
        private decimal prazoadicional;
        [XmlElement(ElementName = "PRAZOADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional
        {
            get { return  prazoadicional; }
            set {  prazoadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PRAZOMEDIOPLPAG
        /// Coment�rio: Percentual de ST do frete retido.
        /// </summary>
        private decimal prazomedioplpag;
        [XmlElement(ElementName = "PRAZOMEDIOPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomedioplpag
        {
            get { return  prazomedioplpag; }
            set {  prazomedioplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOPONDERADO
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PRONTAENTREGA
        /// Coment�rio: 
        /// </summary>
        private string prontaentrega;
        [XmlElement(ElementName = "PRONTAENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prontaentrega
        {
            get { return  prontaentrega; }
            set {  prontaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFP
        /// Coment�rio: Indica o n�mero do protocolo de recebimento.
        /// </summary>
        private string protocolonfp;
        [XmlElement(ElementName = "PROTOCOLONFP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocolonfp
        {
            get { return  protocolonfp; }
            set {  protocolonfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QRCODENFCE
        /// Coment�rio: Link QrCode NFCe.
        /// </summary>
        private string qrcodenfce;
        [XmlElement(ElementName = "QRCODENFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Qrcodenfce
        {
            get { return  qrcodenfce; }
            set {  qrcodenfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECARGA
        /// Coment�rio: Indica pedido de recarga.
        /// </summary>
        private string recarga;
        [XmlElement(ElementName = "RECARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Recarga
        {
            get { return  recarga; }
            set {  recarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESERVAESTOQUETV7
        /// Coment�rio: Reserva estoque na venda tipo 7
        /// </summary>
        private string reservaestoquetv7;
        [XmlElement(ElementName = "RESERVAESTOQUETV7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reservaestoquetv7
        {
            get { return  reservaestoquetv7; }
            set {  reservaestoquetv7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESERVARITENSTV7
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: RESTRICAOTRANSPORTE
        /// Coment�rio: Indica o pedido de venda com restri��o de transporte.
        /// </summary>
        private string restricaotransporte;
        [XmlElement(ElementName = "RESTRICAOTRANSPORTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restricaotransporte
        {
            get { return  restricaotransporte; }
            set {  restricaotransporte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Coment�rio: Indica o nome da rotina.
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: Rotina que gravou o registro
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
        /// Propriedade referente ao campo: ROTINALANCULTALT
        /// Coment�rio: Rotina que gravou o registro
        /// </summary>
        private string rotinalancultalt;
        [XmlElement(ElementName = "ROTINALANCULTALT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinalancultalt
        {
            get { return  rotinalancultalt; }
            set {  rotinalancultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEECF
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private string seriemanif;
        [XmlElement(ElementName = "SERIEMANIF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Seriemanif
        {
            get { return  seriemanif; }
            set {  seriemanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOFTNUMLANC
        /// Coment�rio: N�mero do lan�amento do SoftM�vel.
        /// </summary>
        private string softnumlanc;
        [XmlElement(ElementName = "SOFTNUMLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Softnumlanc
        {
            get { return  softnumlanc; }
            set {  softnumlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBSERIE
        /// Coment�rio: Indica a subserie da nota fiscal.
        /// </summary>
        private string subserie;
        [XmlElement(ElementName = "SUBSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Subserie
        {
            get { return  subserie; }
            set {  subserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXACASOMOEDAREAL
        /// Coment�rio: Taxa caso a moeda escolhida seja o real.
        /// </summary>
        private decimal? taxacasomoedareal;
        [XmlElement(ElementName = "TAXACASOMOEDAREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Taxacasomoedareal
        {
            get { return  taxacasomoedareal; }
            set {  taxacasomoedareal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCARGA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOCFOPTV4
        /// Coment�rio: 
        /// </summary>
        private string tipocfoptv4;
        [XmlElement(ElementName = "TIPOCFOPTV4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocfoptv4
        {
            get { return  tipocfoptv4; }
            set {  tipocfoptv4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOCUMENTO
        /// Coment�rio: Tipo do documento para impress�o da NF.
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOEMISSAO
        /// Coment�rio: Tipo de emiss�o
        /// </summary>
        private string tipoemissao;
        [XmlElement(ElementName = "TIPOEMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoemissao
        {
            get { return  tipoemissao; }
            set {  tipoemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFORMULARIONF
        /// Coment�rio: 
        /// </summary>
        private string tipoformularionf;
        [XmlElement(ElementName = "TIPOFORMULARIONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoformularionf
        {
            get { return  tipoformularionf; }
            set {  tipoformularionf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFV
        /// Coment�rio: Tipo de For�a de Vendas
        /// </summary>
        private string tipofv;
        [XmlElement(ElementName = "TIPOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofv
        {
            get { return  tipofv; }
            set {  tipofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOVCCRCA
        /// Coment�rio: Tipo de movimenta��o de contacorrente de RCA.
        /// </summary>
        private string tipomovccrca;
        [XmlElement(ElementName = "TIPOMOVCCRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomovccrca
        {
            get { return  tipomovccrca; }
            set {  tipomovccrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPER
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOPRIORIDADEENTREGA
        /// Coment�rio: Indica a prioridade de entrega.
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
        /// Coment�rio: Indica o Tipo de Retirada deste Or�amento/Pedida, Retira, Entrega. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal totpeso;
        [XmlElement(ElementName = "TOTPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totpeso
        {
            get { return  totpeso; }
            set {  totpeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESOAGRUPADO
        /// Coment�rio: Campo receber� o somat�rio dos pesos (TOTPESO) dos pedidos selecionados na rotina 1406.
        /// </summary>
        private decimal totpesoagrupado;
        [XmlElement(ElementName = "TOTPESOAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totpesoagrupado
        {
            get { return  totpesoagrupado; }
            set {  totpesoagrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESOLIQ
        /// Coment�rio: Indica o peso total l�quido de um pedido de venda.
        /// </summary>
        private decimal totpesoliq;
        [XmlElement(ElementName = "TOTPESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totpesoliq
        {
            get { return  totpesoliq; }
            set {  totpesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESOLIQAGRUPADO
        /// Coment�rio: Indica o peso total liquido agrupado.
        /// </summary>
        private decimal totpesoliqagrupado;
        [XmlElement(ElementName = "TOTPESOLIQAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totpesoliqagrupado
        {
            get { return  totpesoliqagrupado; }
            set {  totpesoliqagrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVLBONIFIC
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal totvolume;
        [XmlElement(ElementName = "TOTVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totvolume
        {
            get { return  totvolume; }
            set {  totvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVOLUMEAGRUPADO
        /// Coment�rio: Indica o total do volume agrupado.
        /// </summary>
        private decimal totvolumeagrupado;
        [XmlElement(ElementName = "TOTVOLUMEAGRUPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totvolumeagrupado
        {
            get { return  totvolumeagrupado; }
            set {  totvolumeagrupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRIBUTAPORREGIAOFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TROCAALTDEBCREDRCA
        /// Coment�rio: Log de PCCONSUM.TROCAALTDEBCREDRCA.
        /// </summary>
        private string trocaaltdebcredrca;
        [XmlElement(ElementName = "TROCAALTDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Trocaaltdebcredrca
        {
            get { return  trocaaltdebcredrca; }
            set {  trocaaltdebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TURNOENTREGA
        /// Coment�rio: Turno de Entrega
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
        /// Propriedade referente ao campo: UFDESEMBARACO
        /// Coment�rio: Unidade da federa��o de embarque.
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
        /// Propriedade referente ao campo: UFVEICULO
        /// Coment�rio: Uf Ve�culo
        /// </summary>
        private string ufveiculo;
        [XmlElement(ElementName = "UFVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufveiculo
        {
            get { return  ufveiculo; }
            set {  ufveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACFOPVENDANATV10
        /// Coment�rio: Utiliza CFOP de venda na transfer�ncia
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
        /// Propriedade referente ao campo: USACREDRCA
        /// Coment�rio: Log de PCCONSUM. USACREDRCA.
        /// </summary>
        private string usacredrca;
        [XmlElement(ElementName = "USACREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacredrca
        {
            get { return  usacredrca; }
            set {  usacredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADEBCREDRCA
        /// Coment�rio: Log de PCUSUARI.USADEBCREDRCA.
        /// </summary>
        private string usadebcredrca;
        [XmlElement(ElementName = "USADEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadebcredrca
        {
            get { return  usadebcredrca; }
            set {  usadebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAINTEGRACAOWMS
        /// Coment�rio: Campo para indicar se a filial do pedido trabalha com integra��o WMS, se sim ele ser� marcado para tratamento diferenciado.
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
        /// Propriedade referente ao campo: USASALDOCONTACORRENTEDESCFIN
        /// Coment�rio: Usa saldo de conta corrente associado ao desconto financeiro.
        /// </summary>
        private string usasaldocontacorrentedescfin;
        [XmlElement(ElementName = "USASALDOCONTACORRENTEDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usasaldocontacorrentedescfin
        {
            get { return  usasaldocontacorrentedescfin; }
            set {  usasaldocontacorrentedescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAVENDAPOREMBALAGEM
        /// Coment�rio: Utiliza Venda por Embalagem.
        /// </summary>
        private string utilizavendaporembalagem;
        [XmlElement(ElementName = "UTILIZAVENDAPOREMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizavendaporembalagem
        {
            get { return  utilizavendaporembalagem; }
            set {  utilizavendaporembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDESCFIN
        /// Coment�rio: Valor do desconto financeiro.
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
        /// Coment�rio: Indica o pedido � de venda assistida. |Campo do tipo caracter, de tamanho 1. 
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
        /// Propriedade referente ao campo: VENDAASSISTIVA
        /// Coment�rio: Indica o pedido � de venda assistida. 
        /// </summary>
        private string vendaassistiva;
        [XmlElement(ElementName = "VENDAASSISTIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendaassistiva
        {
            get { return  vendaassistiva; }
            set {  vendaassistiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDAEXPORTACAO
        /// Coment�rio: Venda de exporta��o
        /// </summary>
        private string vendaexportacao;
        [XmlElement(ElementName = "VENDAEXPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendaexportacao
        {
            get { return  vendaexportacao; }
            set {  vendaexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDATRIANGULAR
        /// Coment�rio: Venda Triangular.
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
        /// Propriedade referente ao campo: VERSAOFATURAMENTO
        /// Coment�rio: Vers�o do servidor de faturamento autosservi�o.
        /// </summary>
        private string versaofaturamento;
        [XmlElement(ElementName = "VERSAOFATURAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Versaofaturamento
        {
            get { return  versaofaturamento; }
            set {  versaofaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOROTINA
        /// Coment�rio: Indica a vers�o da rotina de venda corrente.|Campo do tipo caracter, de tamanho 40. 
        /// </summary>
        private string versaorotina;
        [XmlElement(ElementName = "VERSAOROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Versaorotina
        {
            get { return  versaorotina; }
            set {  versaorotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLATEND
        /// Coment�rio: Valor atendido do pedido.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustocont;
        [XmlElement(ElementName = "VLCUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustocont
        {
            get { return  vlcustocont; }
            set {  vlcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFIN
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustorep;
        [XmlElement(ElementName = "VLCUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorep
        {
            get { return  vlcustorep; }
            set {  vlcustorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCABATIMENTO
        /// Coment�rio: Valor do desconto referente ao abatimento.
        /// </summary>
        private decimal vldescabatimento;
        [XmlElement(ElementName = "VLDESCABATIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescabatimento
        {
            get { return  vldescabatimento; }
            set {  vldescabatimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCNEG
        /// Coment�rio: 
        /// </summary>
        private decimal vldescneg;
        [XmlElement(ElementName = "VLDESCNEG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldescneg
        {
            get { return  vldescneg; }
            set {  vldescneg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Coment�rio: 
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTOCUPOM
        /// Coment�rio: Desconto que ser� aplicado no cupom.
        /// </summary>
        private decimal vldescontocupom;
        [XmlElement(ElementName = "VLDESCONTOCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vldescontocupom
        {
            get { return  vldescontocupom; }
            set {  vldescontocupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCSOCIOTORCEDOR
        /// Coment�rio: Desconto S�cio Torcedor
        /// </summary>
        private decimal vldescsociotorcedor;
        [XmlElement(ElementName = "VLDESCSOCIOTORCEDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescsociotorcedor
        {
            get { return  vldescsociotorcedor; }
            set {  vldescsociotorcedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENTRADA
        /// Coment�rio: Valor da entrada.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLFRETERETIDO
        /// Coment�rio: Valor de frete retido.
        /// </summary>
        private decimal vlfreteretido;
        [XmlElement(ElementName = "VLFRETERETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlfreteretido
        {
            get { return  vlfreteretido; }
            set {  vlfreteretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSFRETENF
        /// Coment�rio: 
        /// </summary>
        private decimal vlicmsfretenf;
        [XmlElement(ElementName = "VLICMSFRETENF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicmsfretenf
        {
            get { return  vlicmsfretenf; }
            set {  vlicmsfretenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLRMOEDAESTRANGEIRA
        /// Coment�rio: Guarda valor da convers�o do real para moeda extrangeira
        /// </summary>
        private decimal? vlrmoedaestrangeira;
        [XmlElement(ElementName = "VLRMOEDAESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlrmoedaestrangeira
        {
            get { return  vlrmoedaestrangeira; }
            set {  vlrmoedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTFRETERETIDO
        /// Coment�rio: Valor ST de frete retido.
        /// </summary>
        private decimal vlstfreteretido;
        [XmlElement(ElementName = "VLSTFRETERETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlstfreteretido
        {
            get { return  vlstfreteretido; }
            set {  vlstfreteretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUBTOTAL
        /// Coment�rio: Valor do subtotal dos itens
        /// </summary>
        private decimal vlsubtotal;
        [XmlElement(ElementName = "VLSUBTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsubtotal
        {
            get { return  vlsubtotal; }
            set {  vlsubtotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal vltabela;
        [XmlElement(ElementName = "VLTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vltabela
        {
            get { return  vltabela; }
            set {  vltabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Coment�rio: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTRIBUTOS
        /// Coment�rio: Somat�rio dos tributos do item.
        /// </summary>
        private decimal vltributos;
        [XmlElement(ElementName = "VLTRIBUTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltributos
        {
            get { return  vltributos; }
            set {  vltributos = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPedc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPedc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPedc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedc>(where);
        }

        #endregion
    }
}
