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
    /// Classe referente a tabela PCNfsaid
    /// </summary>
    [XmlType("PCNFSAID")]
    public class PCNfsaid : OracleTable
    {
        #region Atributos
       
        /// <summary>
        /// Propriedade referente ao campo: AGENCIAPGTOGNRE
        /// Comentário: Agencia de pagto.
        /// </summary>
        private string agenciapgtognre;
        [XmlElement(ElementName = "AGENCIAPGTOGNRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Agenciapgtognre
        {
            get { return  agenciapgtognre; }
            set {  agenciapgtognre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGREGARSTPRODSINTEGRA
        /// Comentário: Agregar ou não o ST ao valor dos itens (Sintegra).
        /// </summary>
        private string agregarstprodsintegra;
        [XmlElement(ElementName = "AGREGARSTPRODSINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregarstprodsintegra
        {
            get { return  agregarstprodsintegra; }
            set {  agregarstprodsintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGREGASTVLMERC
        /// Comentário: Agregar valor de ST ao valor da mercadoria.
        /// </summary>
        private string agregastvlmerc;
        [XmlElement(ElementName = "AGREGASTVLMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregastvlmerc
        {
            get { return  agregastvlmerc; }
            set {  agregastvlmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMOUTRASDESP
        /// Comentário: Aliq.ICMS da despesa na nota fiscal.
        /// </summary>
        private decimal aliqicmoutrasdesp;
        [XmlElement(ElementName = "ALIQICMOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmoutrasdesp
        {
            get { return  aliqicmoutrasdesp; }
            set {  aliqicmoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTA
        /// Comentário: Indica a alíquota de ICMS.|Campo do tipo numérico, de tamanho 7, com 2 casas decimais. 
        /// </summary>
        private decimal aliquota;
        [XmlElement(ElementName = "ALIQUOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Aliquota
        {
            get { return  aliquota; }
            set {  aliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTE
        /// Comentário: Indica o ambiente em que foi enviada a nota.
        /// </summary>
        private string ambiente;
        [XmlElement(ElementName = "AMBIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambiente
        {
            get { return  ambiente; }
            set {  ambiente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTECTE
        /// Comentário: Ambiente do cte
        /// </summary>
        private string ambientecte;
        [XmlElement(ElementName = "AMBIENTECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambientecte
        {
            get { return  ambientecte; }
            set {  ambientecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTENFE
        /// Comentário: Ambiente da nfe
        /// </summary>
        private string ambientenfe;
        [XmlElement(ElementName = "AMBIENTENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambientenfe
        {
            get { return  ambientenfe; }
            set {  ambientenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APRESENTOUCUPOMPROMOCAO
        /// Comentário: 
        /// </summary>
        private string apresentoucupompromocao;
        [XmlElement(ElementName = "APRESENTOUCUPOMPROMOCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Apresentoucupompromocao
        {
            get { return  apresentoucupompromocao; }
            set {  apresentoucupompromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATACADISTA
        /// Comentário: Indica se o cliente é atacadista.
        /// </summary>
        private string atacadista;
        [XmlElement(ElementName = "ATACADISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atacadista
        {
            get { return  atacadista; }
            set {  atacadista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTENTPGTOGNRE
        /// Comentário: Autenticação bancaria.
        /// </summary>
        private string autentpgtognre;
        [XmlElement(ElementName = "AUTENTPGTOGNRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Autentpgtognre
        {
            get { return  autentpgtognre; }
            set {  autentpgtognre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: Bairro do cliente.
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
        /// Propriedade referente ao campo: BAIRROCOLETA
        /// Comentário: Bairro do local de Coleta do CTE
        /// </summary>
        private string bairrocoleta;
        [XmlElement(ElementName = "BAIRROCOLETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Bairrocoleta
        {
            get { return  bairrocoleta; }
            set {  bairrocoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BANCOPGTOGNRE
        /// Comentário: Banco de pagto.
        /// </summary>
        private string bancopgtognre;
        [XmlElement(ElementName = "BANCOPGTOGNRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Bancopgtognre
        {
            get { return  bancopgtognre; }
            set {  bancopgtognre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BCST
        /// Comentário: 
        /// </summary>
        private decimal bcst;
        [XmlElement(ElementName = "BCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Bcst
        {
            get { return  bcst; }
            set {  bcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BCSTGNRE
        /// Comentário: 
        /// </summary>
        private decimal bcstgnre;
        [XmlElement(ElementName = "BCSTGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Bcstgnre
        {
            get { return  bcstgnre; }
            set {  bcstgnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BROKER
        /// Comentário: 
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
        /// Propriedade referente ao campo: CAIXA
        /// Comentário: Caixa
        /// </summary>
        private decimal caixa;
        [XmlElement(ElementName = "CAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Caixa
        {
            get { return  caixa; }
            set {  caixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAODOTZ
        /// Comentário: Número do CPF do cliente ou Número do cartão de fidelidade DOTZ.
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
        /// Propriedade referente ao campo: CEP
        /// Comentário: CEP do cliente.
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGC
        /// Comentário: CNPJ do cliente.
        /// </summary>
        private string cgc;
        [XmlElement(ElementName = "CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgc
        {
            get { return  cgc; }
            set {  cgc = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CGCFILIAL
        /// Comentário: CNPJ da filial.
        /// </summary>
        private string cgcfilial;
        [XmlElement(ElementName = "CGCFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cgcfilial
        {
            get { return  cgcfilial; }
            set {  cgcfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCFRETE
        /// Comentário: CNPJ do transportador.
        /// </summary>
        private string cgcfrete;
        [XmlElement(ElementName = "CGCFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgcfrete
        {
            get { return  cgcfrete; }
            set {  cgcfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVECTE
        /// Comentário: Chave do cte
        /// </summary>
        private string chavecte;
        [XmlElement(ElementName = "CHAVECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Chavecte
        {
            get { return  chavecte; }
            set {  chavecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVECTEANULACAO
        /// Comentário: Chave de acesso do CT-e de Anulação
        /// </summary>
        private string chavecteanulacao;
        [XmlElement(ElementName = "CHAVECTEANULACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavecteanulacao
        {
            get { return  chavecteanulacao; }
            set {  chavecteanulacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVECTEREF
        /// Comentário: Chave do cte referenciado
        /// </summary>
        private string chavecteref;
        [XmlElement(ElementName = "CHAVECTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavecteref
        {
            get { return  chavecteref; }
            set {  chavecteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVECTESUBSTITUICAO
        /// Comentário: Chave de acesso do CT-e a ser substituido (original)
        /// </summary>
        private string chavectesubstituicao;
        [XmlElement(ElementName = "CHAVECTESUBSTITUICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavectesubstituicao
        {
            get { return  chavectesubstituicao; }
            set {  chavectesubstituicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVECTETOMADORSUB
        /// Comentário: Chave de acesso do CT-e emitido pelo Tomador
        /// </summary>
        private string chavectetomadorsub;
        [XmlElement(ElementName = "CHAVECTETOMADORSUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavectetomadorsub
        {
            get { return  chavectetomadorsub; }
            set {  chavectetomadorsub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFE
        /// Comentário: 
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
        /// Propriedade referente ao campo: CHAVENFETOMADORSUB
        /// Comentário: Chave de acesso da NF-e emitida pelo Tomador
        /// </summary>
        private string chavenfetomadorsub;
        [XmlElement(ElementName = "CHAVENFETOMADORSUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Chavenfetomadorsub
        {
            get { return  chavenfetomadorsub; }
            set {  chavenfetomadorsub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE
        /// Comentário: Razão social do cliente.
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Cliente
        {
            get { return  cliente; }
            set {  cliente = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CLIENTEFONTEST
        /// Comentário: Indica o cliente fonte ST.
        /// </summary>
        private string clientefontest;
        [XmlElement(ElementName = "CLIENTEFONTEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clientefontest
        {
            get { return  clientefontest; }
            set {  clientefontest = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CNPJCISP
        /// Comentário: CNPJ para CISP.
        /// </summary>
        private string cnpjcisp;
        [XmlElement(ElementName = "CNPJCISP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Cnpjcisp
        {
            get { return  cnpjcisp; }
            set {  cnpjcisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJCOLETA
        /// Comentário: CNPJ do local de Coleta do CTE
        /// </summary>
        private string cnpjcoleta;
        [XmlElement(ElementName = "CNPJCOLETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpjcoleta
        {
            get { return  cnpjcoleta; }
            set {  cnpjcoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJCPFCTEREF
        /// Comentário: CNPJ/CPF do cte referenciado
        /// </summary>
        private string cnpjcpfcteref;
        [XmlElement(ElementName = "CNPJCPFCTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpjcpfcteref
        {
            get { return  cnpjcpfcteref; }
            set {  cnpjcpfcteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJCPFEMITENTESUB
        /// Comentário: CNPJ ou CPF do emitente
        /// </summary>
        private string cnpjcpfemitentesub;
        [XmlElement(ElementName = "CNPJCPFEMITENTESUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cnpjcpfemitentesub
        {
            get { return  cnpjcpfemitentesub; }
            set {  cnpjcpfemitentesub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJFORNEC
        /// Comentário: CNPF do Fornecedor.
        /// </summary>
        private string cnpjfornec;
        [XmlElement(ElementName = "CNPJFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpjfornec
        {
            get { return  cnpjfornec; }
            set {  cnpjfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJFORNECPEDAGIO
        /// Comentário: CPNJ da empresa fornecedora do vale pedagio
        /// </summary>
        private string cnpjfornecpedagio;
        [XmlElement(ElementName = "CNPJFORNECPEDAGIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpjfornecpedagio
        {
            get { return  cnpjfornecpedagio; }
            set {  cnpjfornecpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJRESPONSAVEL
        /// Comentário: CNPF do Responsavel.
        /// </summary>
        private string cnpjresponsavel;
        [XmlElement(ElementName = "CNPJRESPONSAVEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpjresponsavel
        {
            get { return  cnpjresponsavel; }
            set {  cnpjresponsavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRANCA
        /// Comentário: Cobrança utilizada para a nota.
        /// </summary>
        private string cobranca;
        [XmlElement(ElementName = "COBRANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cobranca
        {
            get { return  cobranca; }
            set {  cobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATV1
        /// Comentário: Cód.Atividade do cliente.
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
        /// Propriedade referente ao campo: CODBNF
        /// Comentário: Código do tipo de bonificação TV5.
        /// </summary>
        private decimal codbnf;
        [XmlElement(ElementName = "CODBNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbnf
        {
            get { return  codbnf; }
            set {  codbnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADECOLETA
        /// Comentário: Código da Cidade do local de Coleta do CTE
        /// </summary>
        private decimal codcidadecoleta;
        [XmlElement(ElementName = "CODCIDADECOLETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidadecoleta
        {
            get { return  codcidadecoleta; }
            set {  codcidadecoleta = value; }
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
        /// Propriedade referente ao campo: CODCLIFILIAL
        /// Comentário: Indica o código do cliente para a filial.
        /// </summary>
        private decimal codclifilial;
        [XmlElement(ElementName = "CODCLIFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclifilial
        {
            get { return  codclifilial; }
            set {  codclifilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLINF
        /// Comentário: Código do cliente para o endereço de entraga da NF.
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
        /// Comentário: Indica o cliente recebedor da mercadoria em pedidos feitos para redes de clientes. 
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
        /// Comentário: Indica o código da condição de venda.
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
        /// Propriedade referente ao campo: CODCONSIGNATARIOFRETE
        /// Comentário: Indica o código do consignatário do conhecimento de frete.
        /// </summary>
        private decimal codconsignatariofrete;
        [XmlElement(ElementName = "CODCONSIGNATARIOFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codconsignatariofrete
        {
            get { return  codconsignatariofrete; }
            set {  codconsignatariofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONT
        /// Comentário: 
        /// </summary>
        private string codcont;
        [XmlElement(ElementName = "CODCONT", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,11)]
        public string Codcont
        {
            get { return  codcont; }
            set {  codcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTCLI
        /// Comentário: Código da conta de cliente.
        /// </summary>
        private decimal codcontcli;
        [XmlElement(ElementName = "CODCONTCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontcli
        {
            get { return  codcontcli; }
            set {  codcontcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTRATO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODDESTINATARIOFRETE
        /// Comentário: Indica o código do destinatário do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal coddestinatariofrete;
        [XmlElement(ElementName = "CODDESTINATARIOFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddestinatariofrete
        {
            get { return  coddestinatariofrete; }
            set {  coddestinatariofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEVOL
        /// Comentário: 
        /// </summary>
        private decimal coddevol;
        [XmlElement(ElementName = "CODDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Coddevol
        {
            get { return  coddevol; }
            set {  coddevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOC
        /// Comentário: 
        /// </summary>
        private string coddoc;
        [XmlElement(ElementName = "CODDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Coddoc
        {
            get { return  coddoc; }
            set {  coddoc = value; }
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
        /// Propriedade referente ao campo: CODEMITENTEPEDIDO
        /// Comentário: Código do emitente do pedido. 
        /// </summary>
        private decimal codemitentepedido;
        [XmlElement(ElementName = "CODEMITENTEPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemitentepedido
        {
            get { return  codemitentepedido; }
            set {  codemitentepedido = value; }
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
        /// Propriedade referente ao campo: CODEXPORTADOR
        /// Comentário: Indica o código de exportador.
        /// </summary>
        private decimal codexportador;
        [XmlElement(ElementName = "CODEXPORTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codexportador
        {
            get { return  codexportador; }
            set {  codexportador = value; }
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
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: 
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETE
        /// Comentário: CFOP do frete na nota fiscal.
        /// </summary>
        private decimal codfiscalfrete;
        [XmlElement(ElementName = "CODFISCALFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalfrete
        {
            get { return  codfiscalfrete; }
            set {  codfiscalfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALNF
        /// Comentário: Indica o código fiscal da NF.
        /// </summary>
        private decimal codfiscalnf;
        [XmlElement(ElementName = "CODFISCALNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalnf
        {
            get { return  codfiscalnf; }
            set {  codfiscalnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOUTRASDESP
        /// Comentário: CFOP da despesa na nota fiscal.
        /// </summary>
        private decimal codfiscaloutrasdesp;
        [XmlElement(ElementName = "CODFISCALOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscaloutrasdesp
        {
            get { return  codfiscaloutrasdesp; }
            set {  codfiscaloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECBONIFIC
        /// Comentário: Código do Fornecedor da Bonificação TV5.
        /// </summary>
        private decimal codfornecbonific;
        [XmlElement(ElementName = "CODFORNECBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecbonific
        {
            get { return  codfornecbonific; }
            set {  codfornecbonific = value; }
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
        /// Propriedade referente ao campo: CODFORNECFRETECTEREF
        /// Comentário: Código do fornecedor de frete referenciado (redespacho) informado na 1450
        /// </summary>
        private decimal codfornecfretecteref;
        [XmlElement(ElementName = "CODFORNECFRETECTEREF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecfretecteref
        {
            get { return  codfornecfretecteref; }
            set {  codfornecfretecteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECREDESPACHO
        /// Comentário: Código fornecedore frete redespacho.
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
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBENT
        /// Comentário: 
        /// </summary>
        private decimal codfunclibent;
        [XmlElement(ElementName = "CODFUNCLIBENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclibent
        {
            get { return  codfunclibent; }
            set {  codfunclibent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBERACAOENTREGA
        /// Comentário: Código do funcionário que efetuou liberação de entrega do pedido na expedição.
        /// </summary>
        private decimal codfuncliberacaoentrega;
        [XmlElement(ElementName = "CODFUNCLIBERACAOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncliberacaoentrega
        {
            get { return  codfuncliberacaoentrega; }
            set {  codfuncliberacaoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGERENTE
        /// Comentário: Código do Gerente do RCA
        /// </summary>
        private decimal codgerente;
        [XmlElement(ElementName = "CODGERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codgerente
        {
            get { return  codgerente; }
            set {  codgerente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIBGE
        /// Comentário: Código da cidade no IBGE.
        /// </summary>
        private decimal codibge;
        [XmlElement(ElementName = "CODIBGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codibge
        {
            get { return  codibge; }
            set {  codibge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMEDICOPRESCRIT
        /// Comentário: Código do Médico Prescritor.
        /// </summary>
        private decimal codmedicoprescrit;
        [XmlElement(ElementName = "CODMEDICOPRESCRIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmedicoprescrit
        {
            get { return  codmedicoprescrit; }
            set {  codmedicoprescrit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Comentário: Indica o código do motorista do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNICIPIO
        /// Comentário: Cód.Municipio do cliente.
        /// </summary>
        private decimal codmunicipio;
        [XmlElement(ElementName = "CODMUNICIPIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codmunicipio
        {
            get { return  codmunicipio; }
            set {  codmunicipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Comentário: Código do País.
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACADESTFRETE
        /// Comentário: Indica o código do frete (rota de entrega) do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal codpracadestfrete;
        [XmlElement(ElementName = "CODPRACADESTFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpracadestfrete
        {
            get { return  codpracadestfrete; }
            set {  codpracadestfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODNFAJUSTE
        /// Comentário: Código de produto para NF-e de ajuste
        /// </summary>
        private string codprodnfajuste;
        [XmlElement(ElementName = "CODPRODNFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Codprodnfajuste
        {
            get { return  codprodnfajuste; }
            set {  codprodnfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPREDOMINANTE
        /// Comentário: Código produto predominante conhecimento de frete eletrônico.
        /// </summary>
        private decimal codprodpredominante;
        [XmlElement(ElementName = "CODPRODPREDOMINANTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodpredominante
        {
            get { return  codprodpredominante; }
            set {  codprodpredominante = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: CODRECEBFRETECTEREF
        /// Comentário: Código do Recebedor de frete referenciado(redespacho) informado na 1450
        /// </summary>
        private decimal codrecebfretecteref;
        [XmlElement(ElementName = "CODRECEBFRETECTEREF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrecebfretecteref
        {
            get { return  codrecebfretecteref; }
            set {  codrecebfretecteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREMETENTEFRETE
        /// Comentário: Indica o código do remetente do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal codremetentefrete;
        [XmlElement(ElementName = "CODREMETENTEFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codremetentefrete
        {
            get { return  codremetentefrete; }
            set {  codremetentefrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINS
        /// Comentário: Código Situação Tributário PIS COFINS
        /// </summary>
        private decimal codsittribpiscofins;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribpiscofins
        {
            get { return  codsittribpiscofins; }
            set {  codsittribpiscofins = value; }
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
        /// Propriedade referente ao campo: CODUNIDADEEXECUTORA
        /// Comentário: Código da unidade executora.
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
        /// Propriedade referente ao campo: CODVEICULO
        /// Comentário: Indica o código do veículo do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO1
        /// Comentário: Veículo 1
        /// </summary>
        private decimal codveiculo1;
        [XmlElement(ElementName = "CODVEICULO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo1
        {
            get { return  codveiculo1; }
            set {  codveiculo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO2
        /// Comentário: Veículo 2
        /// </summary>
        private decimal codveiculo2;
        [XmlElement(ElementName = "CODVEICULO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo2
        {
            get { return  codveiculo2; }
            set {  codveiculo2 = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: COFINSRETIDO
        /// Comentário: Identificar se foi retido cofins na nota fiscal de saída
        /// </summary>
        private string cofinsretido;
        [XmlElement(ElementName = "COFINSRETIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cofinsretido
        {
            get { return  cofinsretido; }
            set {  cofinsretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAO
        /// Comentário: 
        /// </summary>
        private decimal comissao;
        [XmlElement(ElementName = "COMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Comissao
        {
            get { return  comissao; }
            set {  comissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOMOT
        /// Comentário: Indica o valor de comissão para o motorista.
        /// </summary>
        private decimal comissaomot;
        [XmlElement(ElementName = "COMISSAOMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Comissaomot
        {
            get { return  comissaomot; }
            set {  comissaomot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOSUP
        /// Comentário: 
        /// </summary>
        private decimal comissaosup;
        [XmlElement(ElementName = "COMISSAOSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Comissaosup
        {
            get { return  comissaosup; }
            set {  comissaosup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAO2
        /// Comentário: 
        /// </summary>
        private decimal comissao2;
        [XmlElement(ElementName = "COMISSAO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Comissao2
        {
            get { return  comissao2; }
            set {  comissao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAO3
        /// Comentário: 
        /// </summary>
        private decimal comissao3;
        [XmlElement(ElementName = "COMISSAO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Comissao3
        {
            get { return  comissao3; }
            set {  comissao3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAO4
        /// Comentário: Indica a comissão do terceiro profissional.
        /// </summary>
        private decimal comissao4;
        [XmlElement(ElementName = "COMISSAO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Comissao4
        {
            get { return  comissao4; }
            set {  comissao4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTOCOLETA
        /// Comentário: Complemento do local de Coleta do CTE
        /// </summary>
        private string complementocoleta;
        [XmlElement(ElementName = "COMPLEMENTOCOLETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Complementocoleta
        {
            get { return  complementocoleta; }
            set {  complementocoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA
        /// Comentário: Indica a condição da venda.
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
        /// Propriedade referente ao campo: CONFERIDO
        /// Comentário: Nota Fiscal Conferida.
        /// </summary>
        private string conferido;
        [XmlElement(ElementName = "CONFERIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferido
        {
            get { return  conferido; }
            set {  conferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSUMIDORFINAL
        /// Comentário: Indica se cliente é consumidor final.
        /// </summary>
        private string consumidorfinal;
        [XmlElement(ElementName = "CONSUMIDORFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consumidorfinal
        {
            get { return  consumidorfinal; }
            set {  consumidorfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSUMIUNUMCTE
        /// Comentário: Consumiu número de cte
        /// </summary>
        private string consumiunumcte;
        [XmlElement(ElementName = "CONSUMIUNUMCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consumiunumcte
        {
            get { return  consumiunumcte; }
            set {  consumiunumcte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSUMIUNUMNFE
        /// Comentário: Se já tem um número de Nfe para o registro.
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
        /// Propriedade referente ao campo: CONTADORCUPOMFISCAL
        /// Comentário: Contador cupom fiscal.
        /// </summary>
        private decimal contadorcupomfiscal;
        [XmlElement(ElementName = "CONTADORCUPOMFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Contadorcupomfiscal
        {
            get { return  contadorcupomfiscal; }
            set {  contadorcupomfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAORDEM
        /// Comentário: Indica que a venda TV7, TV8 é do tipo conta e ordem.
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
        /// Propriedade referente ao campo: CONTRIBUINTE
        /// Comentário: Indica se o e contribuinte ou não.
        /// </summary>
        private string contribuinte;
        [XmlElement(ElementName = "CONTRIBUINTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contribuinte
        {
            get { return  contribuinte; }
            set {  contribuinte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPNJRESPONSAVELPEDAGIO
        /// Comentário: CNPJ do responsável pelo pagamento do vale pedágio 
        /// </summary>
        private string cpnjresponsavelpedagio;
        [XmlElement(ElementName = "CPNJRESPONSAVELPEDAGIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cpnjresponsavelpedagio
        {
            get { return  cpnjresponsavelpedagio; }
            set {  cpnjresponsavelpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CSLLRETIDO
        /// Comentário: Identificar se foi retido csll na nota fiscal de saída 
        /// </summary>
        private string csllretido;
        [XmlElement(ElementName = "CSLLRETIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Csllretido
        {
            get { return  csllretido; }
            set {  csllretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CTECODTOMADORSERVICO
        /// Comentário: Código do tomador de serviço cte subcontratado
        /// </summary>
        private decimal ctecodtomadorservico;
        [XmlElement(ElementName = "CTECODTOMADORSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ctecodtomadorservico
        {
            get { return  ctecodtomadorservico; }
            set {  ctecodtomadorservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CTECODTRANSPSUBCONTRATADO
        /// Comentário: Código do veiculo cte subcontratado
        /// </summary>
        private decimal ctecodtranspsubcontratado;
        [XmlElement(ElementName = "CTECODTRANSPSUBCONTRATADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ctecodtranspsubcontratado
        {
            get { return  ctecodtranspsubcontratado; }
            set {  ctecodtranspsubcontratado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CTECODTRANSPSUBCONTRATANTE
        /// Comentário: Código da transportadora cte subcontratante
        /// </summary>
        private decimal ctecodtranspsubcontratante;
        [XmlElement(ElementName = "CTECODTRANSPSUBCONTRATANTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ctecodtranspsubcontratante
        {
            get { return  ctecodtranspsubcontratante; }
            set {  ctecodtranspsubcontratante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CTECODVEICULOSUBCONTRATANTE
        /// Comentário: Código do veiculo cte subcontratante
        /// </summary>
        private decimal ctecodveiculosubcontratante;
        [XmlElement(ElementName = "CTECODVEICULOSUBCONTRATANTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ctecodveiculosubcontratante
        {
            get { return  ctecodveiculosubcontratante; }
            set {  ctecodveiculosubcontratante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CTESUBCONTRATADOCHAVECTEREF
        /// Comentário: Chave do cte referenciado pelo tomador serviço
        /// </summary>
        private string ctesubcontratadochavecteref;
        [XmlElement(ElementName = "CTESUBCONTRATADOCHAVECTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Ctesubcontratadochavecteref
        {
            get { return  ctesubcontratadochavecteref; }
            set {  ctesubcontratadochavecteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOBONIFICACAO
        /// Comentário: Custo da bonificação TV5.
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
        /// Propriedade referente ao campo: DATAEMPENHO
        /// Comentário: Data de Empenho.
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
        /// Propriedade referente ao campo: DEPOSITOFECHADO
        /// Comentário: Identificação de deposito fechado
        /// </summary>
        private string depositofechado;
        [XmlElement(ElementName = "DEPOSITOFECHADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Depositofechado
        {
            get { return  depositofechado; }
            set {  depositofechado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCPAIS
        /// Comentário: Descrição do País.
        /// </summary>
        private string descpais;
        [XmlElement(ElementName = "DESCPAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descpais
        {
            get { return  descpais; }
            set {  descpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOPRODNFAJUSTE
        /// Comentário: Descrição do produto paa NF ajuste
        /// </summary>
        private string descricaoprodnfajuste;
        [XmlElement(ElementName = "DESCRICAOPRODNFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,120)]
        public string Descricaoprodnfajuste
        {
            get { return  descricaoprodnfajuste; }
            set {  descricaoprodnfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESPESASRATEADA
        /// Comentário: Informar se o frete e outras despesas foram rateados nos itens.
        /// </summary>
        private string despesasrateada;
        [XmlElement(ElementName = "DESPESASRATEADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Despesasrateada
        {
            get { return  despesasrateada; }
            set {  despesasrateada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEVSIMBOLICA
        /// Comentário: Esse atributo serve para identificar se a operação, é uma devolução simbólica ou não.
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
        /// Comentário: Tipo de documento de emissão da venda.
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
        /// Propriedade referente ao campo: DTAHORAENTRADACONTIGENCIA
        /// Comentário: Data e Hora da entrada de contigência.
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
        /// Propriedade referente ao campo: DTA_HORAENVIOSEFAZ
        /// Comentário: Data e hora do envio do cte ao sefaz
        /// </summary>
        private DateTime? dta_horaenviosefaz;
        [XmlElement(ElementName = "DTA_HORAENVIOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dta_Horaenviosefaz
        {
            get { return  dta_horaenviosefaz; }
            set {  dta_horaenviosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTCANCELWMS
        /// Comentário: Indica se o processo do WMS foi cancelado.
        /// </summary>
        private DateTime? dtcancelwms;
        [XmlElement(ElementName = "DTCANCELWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancelwms
        {
            get { return  dtcancelwms; }
            set {  dtcancelwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANHOTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcanhoto;
        [XmlElement(ElementName = "DTCANHOTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcanhoto
        {
            get { return  dtcanhoto; }
            set {  dtcanhoto = value; }
        }
                
        /// <summary>
        /// Propriedade referente ao campo: DTDENEGADA
        /// Comentário: Data denegada
        /// </summary>
        private DateTime? dtdenegada;
        [XmlElement(ElementName = "DTDENEGADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdenegada
        {
            get { return  dtdenegada; }
            set {  dtdenegada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDEVOL
        /// Comentário: 
        /// </summary>
        private DateTime? dtdevol;
        [XmlElement(ElementName = "DTDEVOL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdevol
        {
            get { return  dtdevol; }
            set {  dtdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOCTEREF
        /// Comentário: Data de emissão do cte referenciado
        /// </summary>
        private DateTime? dtemissaocteref;
        [XmlElement(ElementName = "DTEMISSAOCTEREF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaocteref
        {
            get { return  dtemissaocteref; }
            set {  dtemissaocteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAODECLARACAO
        /// Comentário: Data de emissão da declaração emitida pelo tomador do Ct-e, quando este não for contribuinte
        /// </summary>
        private DateTime? dtemissaodeclaracao;
        [XmlElement(ElementName = "DTEMISSAODECLARACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaodeclaracao
        {
            get { return  dtemissaodeclaracao; }
            set {  dtemissaodeclaracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAODOCSUB
        /// Comentário: Data da emissão do documento fiscal
        /// </summary>
        private DateTime? dtemissaodocsub;
        [XmlElement(ElementName = "DTEMISSAODOCSUB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaodocsub
        {
            get { return  dtemissaodocsub; }
            set {  dtemissaodocsub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAONFFORNEC
        /// Comentário: 
        /// </summary>
        private DateTime? dtemissaonffornec;
        [XmlElement(ElementName = "DTEMISSAONFFORNEC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaonffornec
        {
            get { return  dtemissaonffornec; }
            set {  dtemissaonffornec = value; }
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
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Comentário: 
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
        /// Comentário: Data  e hora de exportação
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
        /// Propriedade referente ao campo: DTFAT
        /// Comentário: Data de faturamento
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
        /// Propriedade referente ao campo: DTFECHA
        /// Comentário: Data de fechamento da carga.
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
        /// Propriedade referente ao campo: DTFECHACCRCA
        /// Comentário: Indica se foi lançado saldo no contacorrente do RCA para a NF.
        /// </summary>
        private DateTime? dtfechaccrca;
        [XmlElement(ElementName = "DTFECHACCRCA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechaccrca
        {
            get { return  dtfechaccrca; }
            set {  dtfechaccrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORAAUTORIZACAOSEFAZ
        /// Comentário: Indica a hora que foi autorizado no sefaz.
        /// </summary>
        private DateTime? dthoraautorizacaosefaz;
        [XmlElement(ElementName = "DTHORAAUTORIZACAOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoraautorizacaosefaz
        {
            get { return  dthoraautorizacaosefaz; }
            set {  dthoraautorizacaosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORACANCELAMENTOSEFAZ
        /// Comentário: Indica a data e hora em que foi cancelada no sefaz.
        /// </summary>
        private DateTime? dthoracancelamentosefaz;
        [XmlElement(ElementName = "DTHORACANCELAMENTOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoracancelamentosefaz
        {
            get { return  dthoracancelamentosefaz; }
            set {  dthoracancelamentosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORACHEGADA
        /// Comentário: 
        /// </summary>
        private DateTime? dthorachegada;
        [XmlElement(ElementName = "DTHORACHEGADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthorachegada
        {
            get { return  dthorachegada; }
            set {  dthorachegada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORACTE
        /// Comentário: Data e Hora do CTE.
        /// </summary>
        private DateTime? dthoracte;
        [XmlElement(ElementName = "DTHORACTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoracte
        {
            get { return  dthoracte; }
            set {  dthoracte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORANFE
        /// Comentário: 
        /// </summary>
        private DateTime? dthoranfe;
        [XmlElement(ElementName = "DTHORANFE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoranfe
        {
            get { return  dthoranfe; }
            set {  dthoranfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORARECIBODPEC
        /// Comentário: Data e hora do recibo DPEC.
        /// </summary>
        private DateTime? dthorarecibodpec;
        [XmlElement(ElementName = "DTHORARECIBODPEC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthorarecibodpec
        {
            get { return  dthorarecibodpec; }
            set {  dthorarecibodpec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORASAIDA
        /// Comentário: 
        /// </summary>
        private DateTime? dthorasaida;
        [XmlElement(ElementName = "DTHORASAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthorasaida
        {
            get { return  dthorasaida; }
            set {  dthorasaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Comentário: 
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
        /// Comentário: Data  e hora de importação
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
        /// Propriedade referente ao campo: DTLANCTO
        /// Comentário: Indica a data da inclusão do lançamento.
        /// </summary>
        private DateTime? dtlancto;
        [XmlElement(ElementName = "DTLANCTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlancto
        {
            get { return  dtlancto; }
            set {  dtlancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBENT
        /// Comentário: 
        /// </summary>
        private DateTime? dtlibent;
        [XmlElement(ElementName = "DTLIBENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlibent
        {
            get { return  dtlibent; }
            set {  dtlibent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBERACAOENTREGA
        /// Comentário: Data de liberação de entrega do pedido na expedição.
        /// </summary>
        private DateTime? dtliberacaoentrega;
        [XmlElement(ElementName = "DTLIBERACAOENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtliberacaoentrega
        {
            get { return  dtliberacaoentrega; }
            set {  dtliberacaoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNSU
        /// Comentário: Data e hora de geração do NSU (número sequencial único), que deve ser impresso em todas as notas fiscais (entrada e saída). 
        /// </summary>
        private DateTime? dtnsu;
        [XmlElement(ElementName = "DTNSU", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnsu
        {
            get { return  dtnsu; }
            set {  dtnsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGCOMISSAOPROF
        /// Comentário: Indica quando a comissão foi paga para o profissional.
        /// </summary>
        private DateTime? dtpagcomissaoprof;
        [XmlElement(ElementName = "DTPAGCOMISSAOPROF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagcomissaoprof
        {
            get { return  dtpagcomissaoprof; }
            set {  dtpagcomissaoprof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGDOTZ
        /// Comentário: Data do pagamento para Dotz.
        /// </summary>
        private DateTime? dtpagdotz;
        [XmlElement(ElementName = "DTPAGDOTZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagdotz
        {
            get { return  dtpagdotz; }
            set {  dtpagdotz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPGTOCAMPANHA
        /// Comentário: 
        /// </summary>
        private DateTime? dtpgtocampanha;
        [XmlElement(ElementName = "DTPGTOCAMPANHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpgtocampanha
        {
            get { return  dtpgtocampanha; }
            set {  dtpgtocampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDA
        /// Comentário: 
        /// </summary>
        private DateTime? dtsaida;
        [XmlElement(ElementName = "DTSAIDA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtsaida
        {
            get { return  dtsaida; }
            set {  dtsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDANF
        /// Comentário: Data de emissão da Nota Fiscal.
        /// </summary>
        private DateTime? dtsaidanf;
        [XmlElement(ElementName = "DTSAIDANF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsaidanf
        {
            get { return  dtsaidanf; }
            set {  dtsaidanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTWMS
        /// Comentário: 
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
        /// Propriedade referente ao campo: EMAILDEST
        /// Comentário: E-mail do destinatário
        /// </summary>
        private string emaildest;
        [XmlElement(ElementName = "EMAILDEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Emaildest
        {
            get { return  emaildest; }
            set {  emaildest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILFRETE
        /// Comentário: E-mail fornecedor frete.
        /// </summary>
        private string emailfrete;
        [XmlElement(ElementName = "EMAILFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Emailfrete
        {
            get { return  emailfrete; }
            set {  emailfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILFRETEREDESPACHO
        /// Comentário: E-mail fornecedor frete redespacho.
        /// </summary>
        private string emailfreteredespacho;
        [XmlElement(ElementName = "EMAILFRETEREDESPACHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Emailfreteredespacho
        {
            get { return  emailfreteredespacho; }
            set {  emailfreteredespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: Endereço do cliente.
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
        /// Propriedade referente ao campo: ENTREGA
        /// Comentário: Indica se o item será entregue ao invés de ser retirando em venda balcão.
        /// </summary>
        private string entrega;
        [XmlElement(ElementName = "ENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Entrega
        {
            get { return  entrega; }
            set {  entrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADA
        /// Comentário: Indica se em caso de contingência, já enviou para o SEFAZ. 
        /// </summary>
        private string enviada;
        [XmlElement(ElementName = "ENVIADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviada
        {
            get { return  enviada; }
            set {  enviada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADANFE
        /// Comentário: NF-e já enviada ao cliente. 
        /// </summary>
        private string enviadanfe;
        [XmlElement(ElementName = "ENVIADANFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadanfe
        {
            get { return  enviadanfe; }
            set {  enviadanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADOEMAILCANCELADO
        /// Comentário: ENVIADO EMAIL CANCELADO
        /// </summary>
        private string enviadoemailcancelado;
        [XmlElement(ElementName = "ENVIADOEMAILCANCELADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadoemailcancelado
        {
            get { return  enviadoemailcancelado; }
            set {  enviadoemailcancelado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EQUIPLANC
        /// Comentário: 
        /// </summary>
        private string equiplanc;
        [XmlElement(ElementName = "EQUIPLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,64)]
        public string Equiplanc
        {
            get { return  equiplanc; }
            set {  equiplanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIE
        /// Comentário: 
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIEVOLUME
        /// Comentário: Indica a especie dos volumes da nota fiscal.
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
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Comentário: 
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
        /// Propriedade referente ao campo: FINALIDADENFE
        /// Comentário: Finalidade NF-e
        /// </summary>
        private string finalidadenfe;
        [XmlElement(ElementName = "FINALIDADENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Finalidadenfe
        {
            get { return  finalidadenfe; }
            set {  finalidadenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMULARIO
        /// Comentário: Formulário da nota fiscal
        /// </summary>
        private decimal formulario;
        [XmlElement(ElementName = "FORMULARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Formulario
        {
            get { return  formulario; }
            set {  formulario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORNECENTREGA
        /// Comentário: Campo que grava a venda do cliente como venda com entrega pelo fornecedor.
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
        /// Propriedade referente ao campo: FUNCLANC
        /// Comentário: 
        /// </summary>
        private string funclanc;
        [XmlElement(ElementName = "FUNCLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Funclanc
        {
            get { return  funclanc; }
            set {  funclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACAORAZAOAUXILIAR
        /// Comentário: Indica que já foi importado na geração do Razão Auxiliar (rotina 1050). 
        /// </summary>
        private string geracaorazaoauxiliar;
        [XmlElement(ElementName = "GERACAORAZAOAUXILIAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracaorazaoauxiliar
        {
            get { return  geracaorazaoauxiliar; }
            set {  geracaorazaoauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACP
        /// Comentário: Indica se pedido TV10 irá gerar Contas a Pagar. |Campo do tipo caracter, de tamanho 1, com valor padrão "N 
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
        /// Propriedade referente ao campo: GERANFVENDA
        /// Comentário: Informa se o número da nota foi gerado automatico.
        /// </summary>
        private string geranfvenda;
        [XmlElement(ElementName = "GERANFVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geranfvenda
        {
            get { return  geranfvenda; }
            set {  geranfvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARBCRNFE
        /// Comentário: Inserir os valores Base e ST BCR no XML da NF-e
        /// </summary>
        private string gerarbcrnfe;
        [XmlElement(ElementName = "GERARBCRNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarbcrnfe
        {
            get { return  gerarbcrnfe; }
            set {  gerarbcrnfe = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: Gerou histórico para o registro, sim ou não.
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAEMISSAO
        /// Comentário: Hora da emissão da venda.
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
        /// Propriedade referente ao campo: HORALANC
        /// Comentário: 
        /// </summary>
        private string horalanc;
        [XmlElement(ElementName = "HORALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Horalanc
        {
            get { return  horalanc; }
            set {  horalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ICMSRETIDO
        /// Comentário: 
        /// </summary>
        private decimal icmsretido;
        [XmlElement(ElementName = "ICMSRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Icmsretido
        {
            get { return  icmsretido; }
            set {  icmsretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ICMSRETIDOGNRE
        /// Comentário: 
        /// </summary>
        private decimal icmsretidognre;
        [XmlElement(ElementName = "ICMSRETIDOGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Icmsretidognre
        {
            get { return  icmsretidognre; }
            set {  icmsretidognre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDLOCALDESTMERC
        /// Comentário: Identificação do local de destino da mercadoria
        /// </summary>
        private string idlocaldestmerc;
        [XmlElement(ElementName = "IDLOCALDESTMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Idlocaldestmerc
        {
            get { return  idlocaldestmerc; }
            set {  idlocaldestmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTIPOPRESENCA
        /// Comentário: Indica o tipo de presença do comprador no estabelecimento no momento da operação
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
        /// Propriedade referente ao campo: IE
        /// Comentário: IE do cliente.
        /// </summary>
        private string ie;
        [XmlElement(ElementName = "IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ie
        {
            get { return  ie; }
            set {  ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IECTEREF
        /// Comentário: Inscrição estadual do cte referenciado
        /// </summary>
        private string iecteref;
        [XmlElement(ElementName = "IECTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Iecteref
        {
            get { return  iecteref; }
            set {  iecteref = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: IEENT
        /// Comentário: 
        /// </summary>
        private string ieent;
        [XmlElement(ElementName = "IEENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ieent
        {
            get { return  ieent; }
            set {  ieent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEFILIAL
        /// Comentário: IE da filial.
        /// </summary>
        private string iefilial;
        [XmlElement(ElementName = "IEFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Iefilial
        {
            get { return  iefilial; }
            set {  iefilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEFRETE
        /// Comentário: IE do transportador.
        /// </summary>
        private string iefrete;
        [XmlElement(ElementName = "IEFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Iefrete
        {
            get { return  iefrete; }
            set {  iefrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IESUBSTTRIBUT
        /// Comentário: IE como substituto tributário.
        /// </summary>
        private string iesubsttribut;
        [XmlElement(ElementName = "IESUBSTTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Iesubsttribut
        {
            get { return  iesubsttribut; }
            set {  iesubsttribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Comentário: 
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
        /// Propriedade referente ao campo: INSSRETIDO
        /// Comentário: Identificar se foi retido INSS na nota fiscal de saída
        /// </summary>
        private string inssretido;
        [XmlElement(ElementName = "INSSRETIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inssretido
        {
            get { return  inssretido; }
            set {  inssretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INUTILIZADA
        /// Comentário: INFORMA SE FOI INUTILIZAÇÃO DE NUMERACAO.
        /// </summary>
        private string inutilizada;
        [XmlElement(ElementName = "INUTILIZADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inutilizada
        {
            get { return  inutilizada; }
            set {  inutilizada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IRRRETIDO
        /// Comentário: Identificar se foi retido IRR na nota fiscal de saída
        /// </summary>
        private string irrretido;
        [XmlElement(ElementName = "IRRRETIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Irrretido
        {
            get { return  irrretido; }
            set {  irrretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: JUSTIFICATIVACONTIGENCIA
        /// Comentário: Motivo da entrada de contigência.
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
        /// Propriedade referente ao campo: KMFINALENTREGA
        /// Comentário: 
        /// </summary>
        private decimal kmfinalentrega;
        [XmlElement(ElementName = "KMFINALENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Kmfinalentrega
        {
            get { return  kmfinalentrega; }
            set {  kmfinalentrega = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: LOCALDESEMBARACO
        /// Comentário: Indica o local desembaraço.
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
        /// Propriedade referente ao campo: LOGRADOUROCOLETA
        /// Comentário: Logradouro do local de Coleta do CTE
        /// </summary>
        private string logradourocoleta;
        [XmlElement(ElementName = "LOGRADOUROCOLETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Logradourocoleta
        {
            get { return  logradourocoleta; }
            set {  logradourocoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTEDPEC
        /// Comentário: Indica o número do lote dpec.
        /// </summary>
        private string lotedpec;
        [XmlElement(ElementName = "LOTEDPEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Lotedpec
        {
            get { return  lotedpec; }
            set {  lotedpec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARCARVOLUME
        /// Comentário: Indica a marca dos produtos da nota fiscal.
        /// </summary>
        private string marcarvolume;
        [XmlElement(ElementName = "MARCARVOLUME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Marcarvolume
        {
            get { return  marcarvolume; }
            set {  marcarvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEMPISCOFINS
        /// Comentário: Mensagens da tributação PIS/COFINS
        /// </summary>
        private string mensagempiscofins;
        [XmlElement(ElementName = "MENSAGEMPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Mensagempiscofins
        {
            get { return  mensagempiscofins; }
            set {  mensagempiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOLANC
        /// Comentário: 
        /// </summary>
        private string minutolanc;
        [XmlElement(ElementName = "MINUTOLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Minutolanc
        {
            get { return  minutolanc; }
            set {  minutolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELODOCSUB
        /// Comentário: Modelo do documento fiscal
        /// </summary>
        private string modelodocsub;
        [XmlElement(ElementName = "MODELODOCSUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Modelodocsub
        {
            get { return  modelodocsub; }
            set {  modelodocsub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTESTORNONFE
        /// Comentário: Motivo de estorno Nfe
        /// </summary>
        private string motestornonfe;
        [XmlElement(ElementName = "MOTESTORNONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Motestornonfe
        {
            get { return  motestornonfe; }
            set {  motestornonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTORISTAVEICULO
        /// Comentário: Motorista Veículo
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
        /// Propriedade referente ao campo: MUNICIPIO
        /// Comentário: Municpio do cliente.
        /// </summary>
        private string municipio;
        [XmlElement(ElementName = "MUNICIPIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Municipio
        {
            get { return  municipio; }
            set {  municipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATOPERNFE
        /// Comentário: Nat. Operação Nfe
        /// </summary>
        private string natopernfe;
        [XmlElement(ElementName = "NATOPERNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Natopernfe
        {
            get { return  natopernfe; }
            set {  natopernfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NCMNFAJUSTE
        /// Comentário: NCM para item de NF de ajuste
        /// </summary>
        private string ncmnfajuste;
        [XmlElement(ElementName = "NCMNFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Ncmnfajuste
        {
            get { return  ncmnfajuste; }
            set {  ncmnfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NFATUALWMS
        /// Comentário: Atualização Nota Fiscal no WMAS Store.
        /// </summary>
        private string nfatualwms;
        [XmlElement(ElementName = "NFATUALWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Nfatualwms
        {
            get { return  nfatualwms; }
            set {  nfatualwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NFFORNEC
        /// Comentário: 
        /// </summary>
        private decimal nffornec;
        [XmlElement(ElementName = "NFFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Nffornec
        {
            get { return  nffornec; }
            set {  nffornec = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: NOMESEGURADORA
        /// Comentário: NOME DA SEGURADORA
        /// </summary>
        private string nomeseguradora;
        [XmlElement(ElementName = "NOMESEGURADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomeseguradora
        {
            get { return  nomeseguradora; }
            set {  nomeseguradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NORMAREGESPECIAL
        /// Comentário: Norma Especifica (Regime Especial)
        /// </summary>
        private string normaregespecial;
        [XmlElement(ElementName = "NORMAREGESPECIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Normaregespecial
        {
            get { return  normaregespecial; }
            set {  normaregespecial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Comentário: NSU (número sequencial único) que deve ser gerado e impresso em todas as notas fiscais (entrada e saída).
        /// </summary>
        private decimal nsu;
        [XmlElement(ElementName = "NSU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUSOCIOTORCEDOR
        /// Comentário: Número de Transação Sitef
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
        /// Propriedade referente ao campo: NUMCAIXAFISCAL
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o numero do carregamento anterior.
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
        /// Propriedade referente ao campo: NUMCARGAEDI
        /// Comentário: Número Carga EDI
        /// </summary>
        private decimal numcargaedi;
        [XmlElement(ElementName = "NUMCARGAEDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcargaedi
        {
            get { return  numcargaedi; }
            set {  numcargaedi = value; }
        }
               
        /// <summary>
        /// Propriedade referente ao campo: NUMCHAVEEXP
        /// Comentário: Número da Chave de Acesso da Nfe recebida para exportação
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
        /// Comentário: Núm. Cirurgia
        /// </summary>
        private decimal numcirurgia;
        [XmlElement(ElementName = "NUMCIRURGIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcirurgia
        {
            get { return  numcirurgia; }
            set {  numcirurgia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOLETA
        /// Comentário: Indica o número da coleta transportadora.|Campo do tipo caracter, de tamanho 10. 
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
        /// Propriedade referente ao campo: NUMCOMPROVANTE
        /// Comentário: Número do comprovante do pagamento do pedagio.
        /// </summary>
        private decimal numcomprovante;
        [XmlElement(ElementName = "NUMCOMPROVANTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numcomprovante
        {
            get { return  numcomprovante; }
            set {  numcomprovante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATO
        /// Comentário: Indica o número do contrato.
        /// </summary>
        private decimal numcontrato;
        [XmlElement(ElementName = "NUMCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcontrato
        {
            get { return  numcontrato; }
            set {  numcontrato = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATOCARRETEIRO
        /// Comentário: Número do Contrato Carreteiro
        /// </summary>
        private string numcontratocarreteiro;
        [XmlElement(ElementName = "NUMCONTRATOCARRETEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcontratocarreteiro
        {
            get { return  numcontratocarreteiro; }
            set {  numcontratocarreteiro = value; }
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
        /// Propriedade referente ao campo: NUMDOCCTEREF
        /// Comentário: Número do documento do cte referenciado
        /// </summary>
        private string numdoccteref;
        [XmlElement(ElementName = "NUMDOCCTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numdoccteref
        {
            get { return  numdoccteref; }
            set {  numdoccteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDRAWBACK
        /// Comentário: Número do ato concessório do Drawback
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
        /// Comentário: 
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
        /// Comentário: Número de empenho do Órgão Púbico.
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
        /// Propriedade referente ao campo: NUMENDERECO
        /// Comentário: Número do Logradouro do destinatário
        /// </summary>
        private string numendereco;
        [XmlElement(ElementName = "NUMENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numendereco
        {
            get { return  numendereco; }
            set {  numendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROAPOLICE
        /// Comentário: NUMERO DA APOLICE DO SEGURO
        /// </summary>
        private string numeroapolice;
        [XmlElement(ElementName = "NUMEROAPOLICE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numeroapolice
        {
            get { return  numeroapolice; }
            set {  numeroapolice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROAVERBACAO
        /// Comentário: NUMERO DA AVERBAÇÃO DO SEGURO
        /// </summary>
        private string numeroaverbacao;
        [XmlElement(ElementName = "NUMEROAVERBACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numeroaverbacao
        {
            get { return  numeroaverbacao; }
            set {  numeroaverbacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROCOLETA
        /// Comentário: Número do endereço do local de Coleta do CTE
        /// </summary>
        private string numerocoleta;
        [XmlElement(ElementName = "NUMEROCOLETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Numerocoleta
        {
            get { return  numerocoleta; }
            set {  numerocoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERODOCSUB
        /// Comentário: Número do documento fiscal
        /// </summary>
        private decimal numerodocsub;
        [XmlElement(ElementName = "NUMERODOCSUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numerodocsub
        {
            get { return  numerodocsub; }
            set {  numerodocsub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMULARIO
        /// Comentário: 
        /// </summary>
        private decimal numformulario;
        [XmlElement(ElementName = "NUMFORMULARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numformulario
        {
            get { return  numformulario; }
            set {  numformulario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMIDF
        /// Comentário: 
        /// </summary>
        private string numidf;
        [XmlElement(ElementName = "NUMIDF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numidf
        {
            get { return  numidf; }
            set {  numidf = value; }
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
        /// Propriedade referente ao campo: NUMLANCCP
        /// Comentário: 
        /// </summary>
        private decimal numlanccp;
        [XmlElement(ElementName = "NUMLANCCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numlanccp
        {
            get { return  numlanccp; }
            set {  numlanccp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLISTA
        /// Comentário: Número da Lista de Presente
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
        /// Propriedade referente ao campo: NUMLOTECTE
        /// Comentário: Numero do lote do cte
        /// </summary>
        private string numlotecte;
        [XmlElement(ElementName = "NUMLOTECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlotecte
        {
            get { return  numlotecte; }
            set {  numlotecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTENFE
        /// Comentário: Número de Lote da Nota Fiscal Eletrônica. 
        /// </summary>
        private string numlotenfe;
        [XmlElement(ElementName = "NUMLOTENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlotenfe
        {
            get { return  numlotenfe; }
            set {  numlotenfe = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: NUMNFTRANSF
        /// Comentário: 
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
        /// Comentário: Número da nota de manifesto
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
        /// Propriedade referente ao campo: NUMOP
        /// Comentário: Indica o numero da ordem de produção.
        /// </summary>
        private decimal numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numop
        {
            get { return  numop; }
            set {  numop = value; }
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
        /// Propriedade referente ao campo: NUMOS
        /// Comentário: Campo para armazenar o número da ordem de serviço que gerou a NF.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
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
        /// Propriedade referente ao campo: NUMPEDCLI
        /// Comentário: Número do pedido do cliente
        /// </summary>
        private string numpedcli;
        [XmlElement(ElementName = "NUMPEDCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Numpedcli
        {
            get { return  numpedcli; }
            set {  numpedcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDVANXML
        /// Comentário: Num. Pedido VAN para gravar no XML da NF-e.
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
        /// Propriedade referente ao campo: NUMREGEXP
        /// Comentário: Número do Registro de Exportação 
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
        /// Comentário: Região de preço usada na nota fiscal. 
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
        /// Propriedade referente ao campo: NUMREGIAOFRETE
        /// Comentário: 
        /// </summary>
        private decimal numregiaofrete;
        [XmlElement(ElementName = "NUMREGIAOFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiaofrete
        {
            get { return  numregiaofrete; }
            set {  numregiaofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREMESSA
        /// Comentário: Número remessa garantia
        /// </summary>
        private decimal numremessa;
        [XmlElement(ElementName = "NUMREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numremessa
        {
            get { return  numremessa; }
            set {  numremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSELONF
        /// Comentário: 
        /// </summary>
        private decimal numselonf;
        [XmlElement(ElementName = "NUMSELONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numselonf
        {
            get { return  numselonf; }
            set {  numselonf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTREGA
        /// Comentário: Número de sequência de entrega
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
        /// Propriedade referente ao campo: NUMSEQMONTAGEM
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMTAB
        /// Comentário: 
        /// </summary>
        private decimal numtab;
        [XmlElement(ElementName = "NUMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numtab
        {
            get { return  numtab; }
            set {  numtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSCTEANUL
        /// Comentário: Para que o Ct-e de substituição(Saída) seja vinculado ao Ct-e que foi excluído fiscalmente
        /// </summary>
        private decimal numtranscteanul;
        [XmlElement(ElementName = "NUMTRANSCTEANUL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranscteanul
        {
            get { return  numtranscteanul; }
            set {  numtranscteanul = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSCTESUBS
        /// Comentário: Para que Ct-e de substituição(Saída) seja vinculado ao Ct-e de entrada
        /// </summary>
        private decimal numtransctesubs;
        [XmlElement(ElementName = "NUMTRANSCTESUBS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransctesubs
        {
            get { return  numtransctesubs; }
            set {  numtransctesubs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTDEST
        /// Comentário: Gravar o NUMTRANSENT da nota de destino
        /// </summary>
        private decimal numtransentdest;
        [XmlElement(ElementName = "NUMTRANSENTDEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentdest
        {
            get { return  numtransentdest; }
            set {  numtransentdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTORIGEM
        /// Comentário: Campo que grava o número da transação de entrada associadas a nota fiscal de saída.
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
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDACONHEC
        /// Comentário: Número de transação do conhecimento de frete.
        /// </summary>
        private decimal numtransvendaconhec;
        [XmlElement(ElementName = "NUMTRANSVENDACONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Numtransvendaconhec
        {
            get { return  numtransvendaconhec; }
            set {  numtransvendaconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDADESTINO
        /// Comentário: 
        /// </summary>
        private decimal numtransvendadestino;
        [XmlElement(ElementName = "NUMTRANSVENDADESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendadestino
        {
            get { return  numtransvendadestino; }
            set {  numtransvendadestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAECF
        /// Comentário: 
        /// </summary>
        private decimal numtransvendaecf;
        [XmlElement(ElementName = "NUMTRANSVENDAECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaecf
        {
            get { return  numtransvendaecf; }
            set {  numtransvendaecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAORIGEM
        /// Comentário: 
        /// </summary>
        private decimal numtransvendaorigem;
        [XmlElement(ElementName = "NUMTRANSVENDAORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaorigem
        {
            get { return  numtransvendaorigem; }
            set {  numtransvendaorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDATV13
        /// Comentário: Número de transação da nota fiscal tipo 13.
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
        /// Propriedade referente ao campo: NUMVALEPEDAGIO
        /// Comentário: Número do comprovante de compra do vale pedagio
        /// </summary>
        private string numvalepedagio;
        [XmlElement(ElementName = "NUMVALEPEDAGIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numvalepedagio
        {
            get { return  numvalepedagio; }
            set {  numvalepedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: 
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASPU
        /// Comentário: 
        /// </summary>
        private decimal numviaspu;
        [XmlElement(ElementName = "NUMVIASPU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numviaspu
        {
            get { return  numviaspu; }
            set {  numviaspu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLUME
        /// Comentário: 
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
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,120)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: OBSCONHECFRETE
        /// Comentário: Indica a observação do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private string obsconhecfrete;
        [XmlElement(ElementName = "OBSCONHECFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obsconhecfrete
        {
            get { return  obsconhecfrete; }
            set {  obsconhecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSEXP
        /// Comentário: Obs. De ocorrência de entrega de nota fiscal.
        /// </summary>
        private string obsexp;
        [XmlElement(ElementName = "OBSEXP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obsexp
        {
            get { return  obsexp; }
            set {  obsexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSNFAJUSTE
        /// Comentário: Observação complementar para NF de ajuste
        /// </summary>
        private string obsnfajuste;
        [XmlElement(ElementName = "OBSNFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Obsnfajuste
        {
            get { return  obsnfajuste; }
            set {  obsnfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSNFCARREG
        /// Comentário: OBSERVAÇÕES NA NOTA FISCAL REFERENTE A ENTREGA DA CARGA.
        /// </summary>
        private string obsnfcarreg;
        [XmlElement(ElementName = "OBSNFCARREG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Obsnfcarreg
        {
            get { return  obsnfcarreg; }
            set {  obsnfcarreg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSNFE
        /// Comentário: Observações da NF-e.
        /// </summary>
        private string obsnfe;
        [XmlElement(ElementName = "OBSNFE", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Obsnfe
        {
            get { return  obsnfe; }
            set {  obsnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSPISCOFINS
        /// Comentário: Observação da tributação de PIS/COFINS
        /// </summary>
        private string obspiscofins;
        [XmlElement(ElementName = "OBSPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obspiscofins
        {
            get { return  obspiscofins; }
            set {  obspiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAOPUB
        /// Comentário: Indica orgão público.
        /// </summary>
        private string orgaopub;
        [XmlElement(ElementName = "ORGAOPUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orgaopub
        {
            get { return  orgaopub; }
            set {  orgaopub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAOPUBFEDERAL
        /// Comentário: Orgão Pub. Federal
        /// </summary>
        private string orgaopubfederal;
        [XmlElement(ElementName = "ORGAOPUBFEDERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orgaopubfederal
        {
            get { return  orgaopubfederal; }
            set {  orgaopubfederal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAOPUBMUNICIPAL
        /// Comentário: Orgão Pub. Municipal
        /// </summary>
        private string orgaopubmunicipal;
        [XmlElement(ElementName = "ORGAOPUBMUNICIPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Orgaopubmunicipal
        {
            get { return  orgaopubmunicipal; }
            set {  orgaopubmunicipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMFRETE
        /// Comentário: Origem do percentual de Frete
        /// </summary>
        private string origemfrete;
        [XmlElement(ElementName = "ORIGEMFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemfrete
        {
            get { return  origemfrete; }
            set {  origemfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDOUTRASDESP
        /// Comentário: Contém o percentual de redução para despesas acessórias (se houver).
        /// </summary>
        private decimal perbaseredoutrasdesp;
        [XmlElement(ElementName = "PERBASEREDOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredoutrasdesp
        {
            get { return  perbaseredoutrasdesp; }
            set {  perbaseredoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMPROFISSIONAL
        /// Comentário: Indica o percentual de comissao do profissional cadastrado na rotina 340. 
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
        /// Propriedade referente ao campo: PERCFRETE
        /// Comentário: 
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
        /// Comentário: Percentual de frete retido.
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
        /// Propriedade referente ao campo: PERCICMFRETE
        /// Comentário: Aliq.ICMS do frete na nota fiscal.
        /// </summary>
        private decimal percicmfrete;
        [XmlElement(ElementName = "PERCICMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percicmfrete
        {
            get { return  percicmfrete; }
            set {  percicmfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Comentário: Percentual COFINS
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSTFRETERETIDO
        /// Comentário: Percentual de ST do frete retido.
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
        /// Propriedade referente ao campo: PERDESCFIN
        /// Comentário: Mesmo campo gravado no pedido, que é replicado durante o faturamento. 
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
        /// Propriedade referente ao campo: PERPIS
        /// Comentário: Percentual PIS
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISRETIDO
        /// Comentário: Identificar se foi retido PIS na nota fiscal de saída
        /// </summary>
        private string pisretido;
        [XmlElement(ElementName = "PISRETIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pisretido
        {
            get { return  pisretido; }
            set {  pisretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACAVEIC
        /// Comentário: Placa do veículo utilizado para transporte.
        /// </summary>
        private string placaveic;
        [XmlElement(ElementName = "PLACAVEIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Placaveic
        {
            get { return  placaveic; }
            set {  placaveic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL
        /// Comentário: 
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
        /// Comentário: Prazo de pagamento em dias da primeira parcela.
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
        /// Comentário: Prazo de pagamento em dias da décima parcela.
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
        /// Comentário: Prazo de pagamento em dias da décima primeira parcela.
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
        /// Comentário: Prazo de pagamento em dias da décima segunda parcela.
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
        /// Comentário: Prazo de pagamento em dias da segunda parcela.
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
        /// Comentário: Prazo de pagamento em dias da terceira parcela.
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
        /// Comentário: Prazo de pagamento em dias da quarta parcela.
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
        /// Comentário: Prazo de pagamento em dias da quinta parcela.
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
        /// Comentário: Prazo de pagamento em dias da sexta parcela.
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
        /// Comentário: Prazo de pagamento em dias da sétima parcela.
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
        /// Comentário: Prazo de pagamento em dias da oitava parcela.
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
        /// Comentário: Prazo de pagamento em dias da nona parcela.
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
        /// Propriedade referente ao campo: PROTOCOLO
        /// Comentário: Número do protocolo
        /// </summary>
        private string protocolo;
        [XmlElement(ElementName = "PROTOCOLO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Protocolo
        {
            get { return  protocolo; }
            set {  protocolo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOCANCELAMENTO
        /// Comentário: Indica o número do protocolo de cancelamento.
        /// </summary>
        private string protocolocancelamento;
        [XmlElement(ElementName = "PROTOCOLOCANCELAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocolocancelamento
        {
            get { return  protocolocancelamento; }
            set {  protocolocancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOCANCELAMENTOCTE
        /// Comentário: Protocolo de cancelamento do CTE.
        /// </summary>
        private string protocolocancelamentocte;
        [XmlElement(ElementName = "PROTOCOLOCANCELAMENTOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocolocancelamentocte
        {
            get { return  protocolocancelamentocte; }
            set {  protocolocancelamentocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOCTE
        /// Comentário: Protocolo do cte
        /// </summary>
        private string protocolocte;
        [XmlElement(ElementName = "PROTOCOLOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolocte
        {
            get { return  protocolocte; }
            set {  protocolocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFE
        /// Comentário: 
        /// </summary>
        private string protocolonfe;
        [XmlElement(ElementName = "PROTOCOLONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolonfe
        {
            get { return  protocolonfe; }
            set {  protocolonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFEAUTO
        /// Comentário: Indica o protocolo de autorizaçãoda NF-e.
        /// </summary>
        private string protocolonfeauto;
        [XmlElement(ElementName = "PROTOCOLONFEAUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolonfeauto
        {
            get { return  protocolonfeauto; }
            set {  protocolonfeauto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFECAN
        /// Comentário: Indica o protocolo de cancelamento da NF-e.
        /// </summary>
        private string protocolonfecan;
        [XmlElement(ElementName = "PROTOCOLONFECAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Protocolonfecan
        {
            get { return  protocolonfecan; }
            set {  protocolonfecan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIALCOLETA
        /// Comentário: Razão Social do local de Coleta do CTE
        /// </summary>
        private string razaosocialcoleta;
        [XmlElement(ElementName = "RAZAOSOCIALCOLETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Razaosocialcoleta
        {
            get { return  razaosocialcoleta; }
            set {  razaosocialcoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIALCTEREF
        /// Comentário: Razão social do cte referenciado
        /// </summary>
        private string razaosocialcteref;
        [XmlElement(ElementName = "RAZAOSOCIALCTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Razaosocialcteref
        {
            get { return  razaosocialcteref; }
            set {  razaosocialcteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECARGA
        /// Comentário: Indica pedido de recarga.
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
        /// Propriedade referente ao campo: RECIBOCTE
        /// Comentário: Recibo cte
        /// </summary>
        private string recibocte;
        [XmlElement(ElementName = "RECIBOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibocte
        {
            get { return  recibocte; }
            set {  recibocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECIBODPEC
        /// Comentário: Indica o recibo de envio de lote dpec.
        /// </summary>
        private string recibodpec;
        [XmlElement(ElementName = "RECIBODPEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibodpec
        {
            get { return  recibodpec; }
            set {  recibodpec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECIBONFE
        /// Comentário: Indica o recibo de envio de lote.
        /// </summary>
        private string recibonfe;
        [XmlElement(ElementName = "RECIBONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibonfe
        {
            get { return  recibonfe; }
            set {  recibonfe = value; }
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
        /// Propriedade referente ao campo: RESPSEGURO
        /// Comentário: RESPONSÁVEL PELO SEGURO
        /// </summary>
        private decimal respseguro;
        [XmlElement(ElementName = "RESPSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Respseguro
        {
            get { return  respseguro; }
            set {  respseguro = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: ROTINACADCTE
        /// Comentário: Rotina que efetuou a geração do CTE
        /// </summary>
        private string rotinacadcte;
        [XmlElement(ElementName = "ROTINACADCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinacadcte
        {
            get { return  rotinacadcte; }
            set {  rotinacadcte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Comentário: 
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
        /// Propriedade referente ao campo: SELO
        /// Comentário: Selo da sefaz
        /// </summary>
        private string selo;
        [XmlElement(ElementName = "SELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Selo
        {
            get { return  selo; }
            set {  selo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEDOCCTEREF
        /// Comentário: Série do documento do cte referenciado
        /// </summary>
        private string seriedoccteref;
        [XmlElement(ElementName = "SERIEDOCCTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Seriedoccteref
        {
            get { return  seriedoccteref; }
            set {  seriedoccteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEDOCSUB
        /// Comentário: Serie do documento fiscal
        /// </summary>
        private string seriedocsub;
        [XmlElement(ElementName = "SERIEDOCSUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Seriedocsub
        {
            get { return  seriedocsub; }
            set {  seriedocsub = value; }
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
        /// Propriedade referente ao campo: SERIEORIGINAL
        /// Comentário: SERIE ORIGINAL DA NOTA FISCAL ELETRONICA
        /// </summary>
        private string serieoriginal;
        [XmlElement(ElementName = "SERIEORIGINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serieoriginal
        {
            get { return  serieoriginal; }
            set {  serieoriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPLESNACIONAL
        /// Comentário: Informar se o cliente é optante do simples
        /// </summary>
        private string simplesnacional;
        [XmlElement(ElementName = "SIMPLESNACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Simplesnacional
        {
            get { return  simplesnacional; }
            set {  simplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITDOC
        /// Comentário: Situação Documento
        /// </summary>
        private string sitdoc;
        [XmlElement(ElementName = "SITDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Sitdoc
        {
            get { return  sitdoc; }
            set {  sitdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOCTE
        /// Comentário: Situaçao do cte
        /// </summary>
        private decimal situacaocte;
        [XmlElement(ElementName = "SITUACAOCTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Situacaocte
        {
            get { return  situacaocte; }
            set {  situacaocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAONFE
        /// Comentário: 
        /// </summary>
        private decimal situacaonfe;
        [XmlElement(ElementName = "SITUACAONFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Situacaonfe
        {
            get { return  situacaonfe; }
            set {  situacaonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAONFEORIG
        /// Comentário: Situação NFe Original.
        /// </summary>
        private decimal situacaonfeorig;
        [XmlElement(ElementName = "SITUACAONFEORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Situacaonfeorig
        {
            get { return  situacaonfeorig; }
            set {  situacaonfeorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STRIBUT
        /// Comentário: 
        /// </summary>
        private decimal stribut;
        [XmlElement(ElementName = "STRIBUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Stribut
        {
            get { return  stribut; }
            set {  stribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBSERIE
        /// Comentário: Indica a subserie da nota fiscal.
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
        /// Propriedade referente ao campo: SUBSERIEDOCCTEREF
        /// Comentário: Sub-série do documento do cte referenciado
        /// </summary>
        private string subseriedoccteref;
        [XmlElement(ElementName = "SUBSERIEDOCCTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Subseriedoccteref
        {
            get { return  subseriedoccteref; }
            set {  subseriedoccteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBSERIEDOCSUB
        /// Comentário: Subserie do documento fiscal
        /// </summary>
        private string subseriedocsub;
        [XmlElement(ElementName = "SUBSERIEDOCSUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Subseriedocsub
        {
            get { return  subseriedocsub; }
            set {  subseriedocsub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SULFRAMA
        /// Comentário: Incrição Suframa do cliente.
        /// </summary>
        private string sulframa;
        [XmlElement(ElementName = "SULFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Sulframa
        {
            get { return  sulframa; }
            set {  sulframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXAENTREGA
        /// Comentário: Valor cobrado para realizar a entrega da compra.
        /// </summary>
        private decimal taxaentrega;
        [XmlElement(ElementName = "TAXAENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Taxaentrega
        {
            get { return  taxaentrega; }
            set {  taxaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Comentário: Telefone do destinatário
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TENTATIVAENVIOCTE
        /// Comentário: Nro de Tentativas de Envio do CTE.
        /// </summary>
        private decimal tentativaenviocte;
        [XmlElement(ElementName = "TENTATIVAENVIOCTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Tentativaenviocte
        {
            get { return  tentativaenviocte; }
            set {  tentativaenviocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TENTATIVAENVIONFE
        /// Comentário: Indica a quantidade de tentativas de envio da nota fiscal a SEFAZ.
        /// </summary>
        private decimal tentativaenvionfe;
        [XmlElement(ElementName = "TENTATIVAENVIONFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tentativaenvionfe
        {
            get { return  tentativaenvionfe; }
            set {  tentativaenvionfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOALIQOUTRASDESP
        /// Comentário: Tipo de tributação do frete e despesas acessórias.
        /// </summary>
        private string tipoaliqoutrasdesp;
        [XmlElement(ElementName = "TIPOALIQOUTRASDESP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoaliqoutrasdesp
        {
            get { return  tipoaliqoutrasdesp; }
            set {  tipoaliqoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODEVOL
        /// Comentário: 
        /// </summary>
        private string tipodevol;
        [XmlElement(ElementName = "TIPODEVOL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipodevol
        {
            get { return  tipodevol; }
            set {  tipodevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOCCTEREF
        /// Comentário: Tipo do documento do cte referenciado
        /// </summary>
        private string tipodoccteref;
        [XmlElement(ElementName = "TIPODOCCTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipodoccteref
        {
            get { return  tipodoccteref; }
            set {  tipodoccteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOCUMENTOSUB
        /// Comentário: Flag para identificação do tipo do documento (NF/ NFE/ CT/ CTE)
        /// </summary>
        private string tipodocumentosub;
        [XmlElement(ElementName = "TIPODOCUMENTOSUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipodocumentosub
        {
            get { return  tipodocumentosub; }
            set {  tipodocumentosub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMISSAO
        /// Comentário: Tipo de emissão da NFE (Normal, Contingência, SCAN). Campo do tipo caracter, de tamanho 1, com valor default 1
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
        /// Propriedade referente ao campo: TIPOEMISSAOCTE
        /// Comentário: Tipo Emissão Ct-e
        /// </summary>
        private string tipoemissaocte;
        [XmlElement(ElementName = "TIPOEMISSAOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoemissaocte
        {
            get { return  tipoemissaocte; }
            set {  tipoemissaocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMPRESA
        /// Comentário: Tipo da empresa do cliente.
        /// </summary>
        private string tipoempresa;
        [XmlElement(ElementName = "TIPOEMPRESA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Tipoempresa
        {
            get { return  tipoempresa; }
            set {  tipoempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFJ
        /// Comentário: Tipo pessoa (em casos de dev. de clientes).
        /// </summary>
        private string tipofj;
        [XmlElement(ElementName = "TIPOFJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofj
        {
            get { return  tipofj; }
            set {  tipofj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Comentário: 
        /// </summary>
        private string tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOVGARANTIA
        /// Comentário: Define qual tipo de movimentação de garantia a nota representa.
        /// </summary>
        private decimal tipomovgarantia;
        [XmlElement(ElementName = "TIPOMOVGARANTIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tipomovgarantia
        {
            get { return  tipomovgarantia; }
            set {  tipomovgarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRESENCAADQUIRINTE
        /// Comentário: Tipo presença do adquirinte
        /// </summary>
        private string tipopresencaadquirinte;
        [XmlElement(ElementName = "TIPOPRESENCAADQUIRINTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopresencaadquirinte
        {
            get { return  tipopresencaadquirinte; }
            set {  tipopresencaadquirinte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSERVICOCTE
        /// Comentário: Código do tipo de serviço do CT-e
        /// </summary>
        private string tiposervicocte;
        [XmlElement(ElementName = "TIPOSERVICOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposervicocte
        {
            get { return  tiposervicocte; }
            set {  tiposervicocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSUBCONTRATACAOCTE
        /// Comentário: Tipo do CT-e
        /// </summary>
        private string tiposubcontratacaocte;
        [XmlElement(ElementName = "TIPOSUBCONTRATACAOCTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposubcontratacaocte
        {
            get { return  tiposubcontratacaocte; }
            set {  tiposubcontratacaocte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Comentário: 
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTDIFALIQUOTAS
        /// Comentário: Total do diferencial de alíquotas.
        /// </summary>
        private decimal totdifaliquotas;
        [XmlElement(ElementName = "TOTDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Totdifaliquotas
        {
            get { return  totdifaliquotas; }
            set {  totdifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESO
        /// Comentário: 
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
        /// Propriedade referente ao campo: TOTPESOBRUTO
        /// Comentário: Total do peso bruto das mercadorias.
        /// </summary>
        private decimal totpesobruto;
        [XmlElement(ElementName = "TOTPESOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Totpesobruto
        {
            get { return  totpesobruto; }
            set {  totpesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTPESOLIQ
        /// Comentário: Peso liquido dos produtos.
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
        /// Comentário: Peso total liquido agrupado.
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
        [DataObjectField(false,false,true,18)]
        public decimal Totvolume
        {
            get { return  totvolume; }
            set {  totvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTVOLUMEAGRUPADO
        /// Comentário: Volume total agrupado.
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
        /// Propriedade referente ao campo: TRANSPORTADORA
        /// Comentário: Indica a transportadora.
        /// </summary>
        private string transportadora;
        [XmlElement(ElementName = "TRANSPORTADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,120)]
        public string Transportadora
        {
            get { return  transportadora; }
            set {  transportadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: UF cliente.
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
        /// Propriedade referente ao campo: UFCODIGO
        /// Comentário: Código da UF.
        /// </summary>
        private string ufcodigo;
        [XmlElement(ElementName = "UFCODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufcodigo
        {
            get { return  ufcodigo; }
            set {  ufcodigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFCTEREF
        /// Comentário: Sigla da UF do Emissor do documento anterior
        /// </summary>
        private string ufcteref;
        [XmlElement(ElementName = "UFCTEREF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufcteref
        {
            get { return  ufcteref; }
            set {  ufcteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDESEMBARACO
        /// Comentário: Indica a UF desembaraço.
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
        /// Propriedade referente ao campo: UFFILIAL
        /// Comentário: UF da filial.
        /// </summary>
        private string uffilial;
        [XmlElement(ElementName = "UFFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uffilial
        {
            get { return  uffilial; }
            set {  uffilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFFRETE
        /// Comentário: UF do transportador.
        /// </summary>
        private string uffrete;
        [XmlElement(ElementName = "UFFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uffrete
        {
            get { return  uffrete; }
            set {  uffrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFPLACAVEI
        /// Comentário: Uf da Placa do Veiculo
        /// </summary>
        private string ufplacavei;
        [XmlElement(ElementName = "UFPLACAVEI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufplacavei
        {
            get { return  ufplacavei; }
            set {  ufplacavei = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFPLACAVEIC
        /// Comentário: Gravar a UF da Placa do Veiculo
        /// </summary>
        private string ufplacaveic;
        [XmlElement(ElementName = "UFPLACAVEIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufplacaveic
        {
            get { return  ufplacaveic; }
            set {  ufplacaveic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADENFAJUSTE
        /// Comentário: Unidade de medida para NF de ajuste
        /// </summary>
        private string unidadenfajuste;
        [XmlElement(ElementName = "UNIDADENFAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Unidadenfajuste
        {
            get { return  unidadenfajuste; }
            set {  unidadenfajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAINTEGRACAOWMS
        /// Comentário: Usa integração WMS
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
        /// Propriedade referente ao campo: UTILIZAIPICALCICMS
        /// Comentário: Utiliza IPI no calculo de ICMS
        /// </summary>
        private string utilizaipicalcicms;
        [XmlElement(ElementName = "UTILIZAIPICALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaipicalcicms
        {
            get { return  utilizaipicalcicms; }
            set {  utilizaipicalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDOCSUB
        /// Comentário: Valor do documento fiscal
        /// </summary>
        private decimal valordocsub;
        [XmlElement(ElementName = "VALORDOCSUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valordocsub
        {
            get { return  valordocsub; }
            set {  valordocsub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPEDAGIO
        /// Comentário: Valor do Vale Pedágio 
        /// </summary>
        private decimal valorpedagio;
        [XmlElement(ElementName = "VALORPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorpedagio
        {
            get { return  valorpedagio; }
            set {  valorpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORST
        /// Comentário: Valor de ST da nota fiscal
        /// </summary>
        private decimal valorst;
        [XmlElement(ElementName = "VALORST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorst
        {
            get { return  valorst; }
            set {  valorst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDAASSISTIDA
        /// Comentário: Indica se a NF é de venda assistida. 
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
        /// Propriedade referente ao campo: VENDAEXPORTACAO
        /// Comentário: Venda de exportação
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
        /// Propriedade referente ao campo: VERSAOROTINA
        /// Comentário: Versão da rotina gerarou os dados
        /// </summary>
        private string versaorotina;
        [XmlElement(ElementName = "VERSAOROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Versaorotina
        {
            get { return  versaorotina; }
            set {  versaorotina = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: VLBASE
        /// Comentário: 
        /// </summary>
        private decimal vlbase;
        [XmlElement(ElementName = "VLBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbase
        {
            get { return  vlbase; }
            set {  vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPI
        /// Comentário: 
        /// </summary>
        private decimal vlbaseipi;
        [XmlElement(ElementName = "VLBASEIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlbaseipi
        {
            get { return  vlbaseipi; }
            set {  vlbaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEPISCOFINS
        /// Comentário: Valor Base PIS/COFINS
        /// </summary>
        private decimal vlbasepiscofins;
        [XmlElement(ElementName = "VLBASEPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbasepiscofins
        {
            get { return  vlbasepiscofins; }
            set {  vlbasepiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: 
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
        /// Propriedade referente ao campo: VLBONIFICACERTO
        /// Comentário: Valor da bonificação acerto
        /// </summary>
        private decimal vlbonificacerto;
        [XmlElement(ElementName = "VLBONIFICACERTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlbonificacerto
        {
            get { return  vlbonificacerto; }
            set {  vlbonificacerto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Comentário: Indica o valor total de crédito de COFINS na NF.
        /// </summary>
        private decimal vlcofins;
        [XmlElement(ElementName = "VLCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofins
        {
            get { return  vlcofins; }
            set {  vlcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOCONT
        /// Comentário: 
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
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustorep
        {
            get { return  vlcustorep; }
            set {  vlcustorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCABATIMENTO
        /// Comentário: GRAVAR O VALOR DO DESCONTO DO ABATIMENTO
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
        /// Propriedade referente ao campo: VLDESCICMS
        /// Comentário: Valor de desconto do ICMS de isenção.
        /// </summary>
        private decimal vldescicms;
        [XmlElement(ElementName = "VLDESCICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldescicms
        {
            get { return  vldescicms; }
            set {  vldescicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Comentário: Valor total do desconto.
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
        /// Propriedade referente ao campo: VLDESCPROM
        /// Comentário: 
        /// </summary>
        private decimal vldescprom;
        [XmlElement(ElementName = "VLDESCPROM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldescprom
        {
            get { return  vldescprom; }
            set {  vldescprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCSOCIOTORCEDOR
        /// Comentário: Desconto Sócio Torcedor
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
        /// Propriedade referente ao campo: VLDESPACHO
        /// Comentário: Indica o valor de despesa de despacho. (Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal vldespacho;
        [XmlElement(ElementName = "VLDESPACHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespacho
        {
            get { return  vldespacho; }
            set {  vldespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPDENTRONF
        /// Comentário: Indica o Valor outras despesas na NF.
        /// </summary>
        private decimal vldespdentronf;
        [XmlElement(ElementName = "VLDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldespdentronf
        {
            get { return  vldespdentronf; }
            set {  vldespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPPEDAGIO
        /// Comentário: Valor de Outras despesas de pedágio
        /// </summary>
        private decimal vldesppedagio;
        [XmlElement(ElementName = "VLDESPPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldesppedagio
        {
            get { return  vldesppedagio; }
            set {  vldesppedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVOLUCAO
        /// Comentário: 
        /// </summary>
        private decimal vldevolucao;
        [XmlElement(ElementName = "VLDEVOLUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevolucao
        {
            get { return  vldevolucao; }
            set {  vldevolucao = value; }
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
        /// Propriedade referente ao campo: VLFRETERETIDO
        /// Comentário: Valor de frete retido.
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
        /// Propriedade referente ao campo: VLGRIS
        /// Comentário: Valor do GRIS no conhecimento
        /// </summary>
        private decimal vlgris;
        [XmlElement(ElementName = "VLGRIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlgris
        {
            get { return  vlgris; }
            set {  vlgris = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Comentário: 
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSANTECIPADO
        /// Comentário: 
        /// </summary>
        private decimal vlicmsantecipado;
        [XmlElement(ElementName = "VLICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicmsantecipado
        {
            get { return  vlicmsantecipado; }
            set {  vlicmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLINSS
        /// Comentário: Indica o valor do INSS.
        /// </summary>
        private decimal vlinss;
        [XmlElement(ElementName = "VLINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlinss
        {
            get { return  vlinss; }
            set {  vlinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: 
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIOUTRAS
        /// Comentário: Esse atributo serve para armazenar o valor do ipi para devolução simbolica.
        /// </summary>
        private decimal vlipioutras;
        [XmlElement(ElementName = "VLIPIOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipioutras
        {
            get { return  vlipioutras; }
            set {  vlipioutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIR
        /// Comentário: 
        /// </summary>
        private decimal vlir;
        [XmlElement(ElementName = "VLIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlir
        {
            get { return  vlir; }
            set {  vlir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISENTAS
        /// Comentário: 
        /// </summary>
        private decimal vlisentas;
        [XmlElement(ElementName = "VLISENTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlisentas
        {
            get { return  vlisentas; }
            set {  vlisentas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISS
        /// Comentário: 
        /// </summary>
        private decimal vliss;
        [XmlElement(ElementName = "VLISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vliss
        {
            get { return  vliss; }
            set {  vliss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLTR
        /// Comentário: Indica o valor de despesa de LTR. (Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal vlltr;
        [XmlElement(ElementName = "VLLTR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlltr
        {
            get { return  vlltr; }
            set {  vlltr = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: VLOUTRAS
        /// Comentário: 
        /// </summary>
        private decimal vloutras;
        [XmlElement(ElementName = "VLOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vloutras
        {
            get { return  vloutras; }
            set {  vloutras = value; }
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
        /// Propriedade referente ao campo: VLPAUTAFRETE
        /// Comentário: Vl.Pauta do frete na nota.
        /// </summary>
        private decimal vlpautafrete;
        [XmlElement(ElementName = "VLPAUTAFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpautafrete
        {
            get { return  vlpautafrete; }
            set {  vlpautafrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPEDAGIO
        /// Comentário: Indica o valor de despesa do pedágio.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal vlpedagio;
        [XmlElement(ElementName = "VLPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpedagio
        {
            get { return  vlpedagio; }
            set {  vlpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Comentário: Valor do PIS a ser lançado na Geração de Nota Fiscal de Prestação de Serviço (rotina 1446). 
        /// </summary>
        private decimal vlpis;
        [XmlElement(ElementName = "VLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpis
        {
            get { return  vlpis; }
            set {  vlpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRAVERBACAO
        /// Comentário: Valor da Averbação.
        /// </summary>
        private decimal vlraverbacao;
        [XmlElement(ElementName = "VLRAVERBACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Vlraverbacao
        {
            get { return  vlraverbacao; }
            set {  vlraverbacao = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: VLRECEBIDOBOLETO
        /// Comentário: 
        /// </summary>
        private decimal vlrecebidoboleto;
        [XmlElement(ElementName = "VLRECEBIDOBOLETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlrecebidoboleto
        {
            get { return  vlrecebidoboleto; }
            set {  vlrecebidoboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRECEBIDOCARTAO
        /// Comentário: 
        /// </summary>
        private decimal vlrecebidocartao;
        [XmlElement(ElementName = "VLRECEBIDOCARTAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlrecebidocartao
        {
            get { return  vlrecebidocartao; }
            set {  vlrecebidocartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRECEBIDOCH
        /// Comentário: 
        /// </summary>
        private decimal vlrecebidoch;
        [XmlElement(ElementName = "VLRECEBIDOCH", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlrecebidoch
        {
            get { return  vlrecebidoch; }
            set {  vlrecebidoch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRECEBIDODIN
        /// Comentário: 
        /// </summary>
        private decimal vlrecebidodin;
        [XmlElement(ElementName = "VLRECEBIDODIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlrecebidodin
        {
            get { return  vlrecebidodin; }
            set {  vlrecebidodin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSECCAT
        /// Comentário: Indica o valor de despesa com escolta.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal vlseccat;
        [XmlElement(ElementName = "VLSECCAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlseccat
        {
            get { return  vlseccat; }
            set {  vlseccat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Comentário: Indica o valor de despesa de seguro da carga.(Utilizado apenas para o projeto 50507 - Transportadora)
        /// </summary>
        private decimal vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTFRETERETIDO
        /// Comentário: Valor ST de frete retido.
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
        /// Comentário: Valor do subtotal dos itens
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
        /// Comentário: 
        /// </summary>
        private decimal vltabela;
        [XmlElement(ElementName = "VLTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltabela
        {
            get { return  vltabela; }
            set {  vltabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTAS
        /// Comentário: Valor do TAS no conheciemento
        /// </summary>
        private decimal vltas;
        [XmlElement(ElementName = "VLTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltas
        {
            get { return  vltas; }
            set {  vltas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: Valor total.
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALNF
        /// Comentário: 
        /// </summary>
        private decimal vltotalnf;
        [XmlElement(ElementName = "VLTOTALNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalnf
        {
            get { return  vltotalnf; }
            set {  vltotalnf = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: VLTOTALSEMDESCICMS
        /// Comentário: Valor total da NF sem desconto de Isenção de ICMS.
        /// </summary>
        private decimal vltotalsemdescicms;
        [XmlElement(ElementName = "VLTOTALSEMDESCICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotalsemdescicms
        {
            get { return  vltotalsemdescicms; }
            set {  vltotalsemdescicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTBRUTOPRODAJUSTE
        /// Comentário: Valor total bruto para NF de ajuste
        /// </summary>
        private decimal vltotbrutoprodajuste;
        [XmlElement(ElementName = "VLTOTBRUTOPRODAJUSTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotbrutoprodajuste
        {
            get { return  vltotbrutoprodajuste; }
            set {  vltotbrutoprodajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTGER
        /// Comentário: Valor total.
        /// </summary>
        private decimal vltotger;
        [XmlElement(ElementName = "VLTOTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotger
        {
            get { return  vltotger; }
            set {  vltotger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTRIBUTOS
        /// Comentário: Guarda o Valor do Conhec. Frete X Perc.
        /// </summary>
        private decimal vltributos;
        [XmlElement(ElementName = "VLTRIBUTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltributos
        {
            get { return  vltributos; }
            set {  vltributos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTROCO
        /// Comentário: 
        /// </summary>
        private decimal vltroco;
        [XmlElement(ElementName = "VLTROCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vltroco
        {
            get { return  vltroco; }
            set {  vltroco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMVCLI
        /// Comentário: Indica o valor total da verba CMV registrado no pedido. 
        /// </summary>
        private decimal vlverbacmvcli;
        [XmlElement(ElementName = "VLVERBACMVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlverbacmvcli
        {
            get { return  vlverbacmvcli; }
            set {  vlverbacmvcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: WMSCODFUNCIGNORA
        /// Comentário: Funcionário que ignorou WMS
        /// </summary>
        private decimal wmscodfuncignora;
        [XmlElement(ElementName = "WMSCODFUNCIGNORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Wmscodfuncignora
        {
            get { return  wmscodfuncignora; }
            set {  wmscodfuncignora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: WMSIGNORADO
        /// Comentário: WMS Ignorado
        /// </summary>
        private string wmsignorado;
        [XmlElement(ElementName = "WMSIGNORADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Wmsignorado
        {
            get { return  wmsignorado; }
            set {  wmsignorado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNfsaid()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFSAID";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNfsaid> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfsaid>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNfsaid> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfsaid>(where);
        }

        #endregion
    }
}
