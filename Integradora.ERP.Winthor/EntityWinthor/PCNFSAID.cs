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
        /// Coment�rio: Agencia de pagto.
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
        /// Coment�rio: Agregar ou n�o o ST ao valor dos itens (Sintegra).
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
        /// Coment�rio: Agregar valor de ST ao valor da mercadoria.
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
        /// Coment�rio: Aliq.ICMS da despesa na nota fiscal.
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
        /// Coment�rio: Indica a al�quota de ICMS.|Campo do tipo num�rico, de tamanho 7, com 2 casas decimais. 
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
        /// Coment�rio: Indica o ambiente em que foi enviada a nota.
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
        /// Coment�rio: Ambiente do cte
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
        /// Coment�rio: Ambiente da nfe
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se o cliente � atacadista.
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
        /// Coment�rio: Autentica��o bancaria.
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
        /// Coment�rio: Bairro do cliente.
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
        /// Coment�rio: Bairro do local de Coleta do CTE
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
        /// Coment�rio: Banco de pagto.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CAIXA
        /// Coment�rio: Caixa
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
        /// Coment�rio: N�mero do CPF do cliente ou N�mero do cart�o de fidelidade DOTZ.
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
        /// Coment�rio: CEP do cliente.
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
        /// Coment�rio: CNPJ do cliente.
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
        /// Coment�rio: CNPJ da filial.
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
        /// Coment�rio: CNPJ do transportador.
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
        /// Coment�rio: Chave do cte
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
        /// Coment�rio: Chave de acesso do CT-e de Anula��o
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
        /// Coment�rio: Chave do cte referenciado
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
        /// Coment�rio: Chave de acesso do CT-e a ser substituido (original)
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
        /// Coment�rio: Chave de acesso do CT-e emitido pelo Tomador
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
        /// Coment�rio: 
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
        /// Coment�rio: Chave de acesso da NF-e emitida pelo Tomador
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
        /// Coment�rio: Raz�o social do cliente.
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
        /// Coment�rio: Indica o cliente fonte ST.
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
        /// Coment�rio: CNPJ para CISP.
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
        /// Coment�rio: CNPJ do local de Coleta do CTE
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
        /// Coment�rio: CNPJ/CPF do cte referenciado
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
        /// Coment�rio: CNPJ ou CPF do emitente
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
        /// Coment�rio: CNPF do Fornecedor.
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
        /// Coment�rio: CPNJ da empresa fornecedora do vale pedagio
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
        /// Coment�rio: CNPF do Responsavel.
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
        /// Coment�rio: Cobran�a utilizada para a nota.
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
        /// Coment�rio: C�d.Atividade do cliente.
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
        /// Coment�rio: C�digo do tipo de bonifica��o TV5.
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
        /// Coment�rio: C�digo da Cidade do local de Coleta do CTE
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
        /// Propriedade referente ao campo: CODCLIFILIAL
        /// Coment�rio: Indica o c�digo do cliente para a filial.
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
        /// Coment�rio: C�digo do cliente para o endere�o de entraga da NF.
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
        /// Coment�rio: Indica o cliente recebedor da mercadoria em pedidos feitos para redes de clientes. 
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
        /// Coment�rio: Indica o c�digo da condi��o de venda.
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
        /// Coment�rio: Indica o c�digo do consignat�rio do conhecimento de frete.
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo da conta de cliente.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo do destinat�rio do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo do emitente do pedido. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo de exportador.
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
        /// Propriedade referente ao campo: CODFISCAL
        /// Coment�rio: 
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
        /// Coment�rio: CFOP do frete na nota fiscal.
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
        /// Coment�rio: Indica o c�digo fiscal da NF.
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
        /// Coment�rio: CFOP da despesa na nota fiscal.
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo do Fornecedor da Bonifica��o TV5.
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo do fornecedor de frete referenciado (redespacho) informado na 1450
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
        /// Coment�rio: C�digo fornecedore frete redespacho.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo do funcion�rio que efetuou libera��o de entrega do pedido na expedi��o.
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
        /// Coment�rio: C�digo do Gerente do RCA
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
        /// Coment�rio: C�digo da cidade no IBGE.
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
        /// Coment�rio: C�digo do M�dico Prescritor.
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
        /// Coment�rio: Indica o c�digo do motorista do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: C�d.Municipio do cliente.
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
        /// Coment�rio: C�digo do Pa�s.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo do frete (rota de entrega) do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: C�digo de produto para NF-e de ajuste
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
        /// Coment�rio: C�digo produto predominante conhecimento de frete eletr�nico.
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
        /// Coment�rio: C�digo do Recebedor de frete referenciado(redespacho) informado na 1450
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
        /// Coment�rio: Indica o c�digo do remetente do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: C�digo Situa��o Tribut�rio PIS COFINS
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo do terceiro profissional.
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
        /// Coment�rio: Indica o c�digo do ve�culo do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: Ve�culo 1
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
        /// Coment�rio: Ve�culo 2
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
        /// Coment�rio: Identificar se foi retido cofins na nota fiscal de sa�da
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor de comiss�o para o motorista.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a comiss�o do terceiro profissional.
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
        /// Coment�rio: Complemento do local de Coleta do CTE
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
        /// Coment�rio: Indica a condi��o da venda.
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
        /// Coment�rio: Nota Fiscal Conferida.
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
        /// Coment�rio: Indica se cliente � consumidor final.
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
        /// Coment�rio: Consumiu n�mero de cte
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
        /// Coment�rio: Se j� tem um n�mero de Nfe para o registro.
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
        /// Coment�rio: Contador cupom fiscal.
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
        /// Coment�rio: Indica que a venda TV7, TV8 � do tipo conta e ordem.
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
        /// Coment�rio: Indica se o e contribuinte ou n�o.
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
        /// Coment�rio: CNPJ do respons�vel pelo pagamento do vale ped�gio 
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
        /// Coment�rio: Identificar se foi retido csll na nota fiscal de sa�da 
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
        /// Coment�rio: C�digo do tomador de servi�o cte subcontratado
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
        /// Coment�rio: C�digo do veiculo cte subcontratado
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
        /// Coment�rio: C�digo da transportadora cte subcontratante
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
        /// Coment�rio: C�digo do veiculo cte subcontratante
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
        /// Coment�rio: Chave do cte referenciado pelo tomador servi�o
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
        /// Propriedade referente ao campo: DEPOSITOFECHADO
        /// Coment�rio: Identifica��o de deposito fechado
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
        /// Coment�rio: Descri��o do Pa�s.
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
        /// Coment�rio: Descri��o do produto paa NF ajuste
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
        /// Coment�rio: Informar se o frete e outras despesas foram rateados nos itens.
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
        /// Propriedade referente ao campo: DTAHORAENTRADACONTIGENCIA
        /// Coment�rio: Data e Hora da entrada de contig�ncia.
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
        /// Coment�rio: Data e hora do envio do cte ao sefaz
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
        /// Propriedade referente ao campo: DTCANCELWMS
        /// Coment�rio: Indica se o processo do WMS foi cancelado.
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
        /// Coment�rio: 
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
        /// Coment�rio: Data denegada
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
        /// Coment�rio: 
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
        /// Coment�rio: Data de emiss�o do cte referenciado
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
        /// Coment�rio: Data de emiss�o da declara��o emitida pelo tomador do Ct-e, quando este n�o for contribuinte
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
        /// Coment�rio: Data da emiss�o do documento fiscal
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTFAT
        /// Coment�rio: Data de faturamento
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
        /// Coment�rio: Data de fechamento da carga.
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
        /// Coment�rio: Indica se foi lan�ado saldo no contacorrente do RCA para a NF.
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
        /// Coment�rio: Indica a hora que foi autorizado no sefaz.
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
        /// Coment�rio: Indica a data e hora em que foi cancelada no sefaz.
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
        /// Coment�rio: 
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
        /// Coment�rio: Data e Hora do CTE.
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
        /// Coment�rio: 
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
        /// Coment�rio: Data e hora do recibo DPEC.
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTLANCTO
        /// Coment�rio: Indica a data da inclus�o do lan�amento.
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
        /// Coment�rio: 
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
        /// Coment�rio: Data de libera��o de entrega do pedido na expedi��o.
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
        /// Coment�rio: Data e hora de gera��o do NSU (n�mero sequencial �nico), que deve ser impresso em todas as notas fiscais (entrada e sa�da). 
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
        /// Coment�rio: Indica quando a comiss�o foi paga para o profissional.
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
        /// Coment�rio: Data do pagamento para Dotz.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Data de emiss�o da Nota Fiscal.
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
        /// Propriedade referente ao campo: EMAILDEST
        /// Coment�rio: E-mail do destinat�rio
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
        /// Coment�rio: E-mail fornecedor frete.
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
        /// Coment�rio: E-mail fornecedor frete redespacho.
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
        /// Coment�rio: Endere�o do cliente.
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
        /// Coment�rio: Indica se o item ser� entregue ao inv�s de ser retirando em venda balc�o.
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
        /// Coment�rio: Indica se em caso de conting�ncia, j� enviou para o SEFAZ. 
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
        /// Coment�rio: NF-e j� enviada ao cliente. 
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
        /// Coment�rio: ENVIADO EMAIL CANCELADO
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: FINALIDADENFE
        /// Coment�rio: Finalidade NF-e
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
        /// Coment�rio: Formul�rio da nota fiscal
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
        /// Coment�rio: Campo que grava a venda do cliente como venda com entrega pelo fornecedor.
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
        /// Propriedade referente ao campo: FUNCLANC
        /// Coment�rio: 
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
        /// Coment�rio: Indica que j� foi importado na gera��o do Raz�o Auxiliar (rotina 1050). 
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
        /// Coment�rio: Indica se pedido TV10 ir� gerar Contas a Pagar. |Campo do tipo caracter, de tamanho 1, com valor padr�o "N 
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
        /// Coment�rio: Informa se o n�mero da nota foi gerado automatico.
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
        /// Coment�rio: Inserir os valores Base e ST BCR no XML da NF-e
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
        /// Coment�rio: Gerou hist�rico para o registro, sim ou n�o.
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
        /// Coment�rio: Hora da emiss�o da venda.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Identifica��o do local de destino da mercadoria
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
        /// Propriedade referente ao campo: IE
        /// Coment�rio: IE do cliente.
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
        /// Coment�rio: Inscri��o estadual do cte referenciado
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
        /// Coment�rio: 
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
        /// Coment�rio: IE da filial.
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
        /// Coment�rio: IE do transportador.
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
        /// Coment�rio: IE como substituto tribut�rio.
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
        /// Propriedade referente ao campo: INSSRETIDO
        /// Coment�rio: Identificar se foi retido INSS na nota fiscal de sa�da
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
        /// Coment�rio: INFORMA SE FOI INUTILIZA��O DE NUMERACAO.
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
        /// Coment�rio: Identificar se foi retido IRR na nota fiscal de sa�da
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
        /// Coment�rio: Motivo da entrada de contig�ncia.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o local desembara�o.
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
        /// Coment�rio: Logradouro do local de Coleta do CTE
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
        /// Coment�rio: Indica o n�mero do lote dpec.
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
        /// Coment�rio: Indica a marca dos produtos da nota fiscal.
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
        /// Coment�rio: Mensagens da tributa��o PIS/COFINS
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
        /// Coment�rio: 
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
        /// Coment�rio: Modelo do documento fiscal
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
        /// Coment�rio: Motivo de estorno Nfe
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
        /// Coment�rio: Motorista Ve�culo
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
        /// Coment�rio: Municpio do cliente.
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
        /// Coment�rio: Nat. Opera��o Nfe
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
        /// Coment�rio: NCM para item de NF de ajuste
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
        /// Coment�rio: Atualiza��o Nota Fiscal no WMAS Store.
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
        /// Coment�rio: 
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
        /// Coment�rio: NOME DA SEGURADORA
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
        /// Coment�rio: Norma Especifica (Regime Especial)
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
        /// Coment�rio: NSU (n�mero sequencial �nico) que deve ser gerado e impresso em todas as notas fiscais (entrada e sa�da).
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
        /// Propriedade referente ao campo: NUMCARGAEDI
        /// Coment�rio: N�mero Carga EDI
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
        /// Coment�rio: N�m. Cirurgia
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
        /// Propriedade referente ao campo: NUMCOMPROVANTE
        /// Coment�rio: N�mero do comprovante do pagamento do pedagio.
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
        /// Coment�rio: Indica o n�mero do contrato.
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
        /// Coment�rio: N�mero do Contrato Carreteiro
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero do documento do cte referenciado
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
        /// Coment�rio: N�mero de empenho do �rg�o P�bico.
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
        /// Coment�rio: N�mero do Logradouro do destinat�rio
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
        /// Coment�rio: NUMERO DA APOLICE DO SEGURO
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
        /// Coment�rio: NUMERO DA AVERBA��O DO SEGURO
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
        /// Coment�rio: N�mero do endere�o do local de Coleta do CTE
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
        /// Coment�rio: N�mero do documento fiscal
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMLANCCP
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMLOTECTE
        /// Coment�rio: Numero do lote do cte
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
        /// Coment�rio: N�mero de Lote da Nota Fiscal Eletr�nica. 
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
        /// Propriedade referente ao campo: NUMNOTAMANIF
        /// Coment�rio: N�mero da nota de manifesto
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
        /// Coment�rio: Indica o numero da ordem de produ��o.
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
        /// Coment�rio: N�mero Or�amento da Filial. 
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
        /// Coment�rio: Campo para armazenar o n�mero da ordem de servi�o que gerou a NF.
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero do pedido do cliente
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
        /// Coment�rio: Regi�o de pre�o usada na nota fiscal. 
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero remessa garantia
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero de sequ�ncia de entrega
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
        /// Propriedade referente ao campo: NUMTAB
        /// Coment�rio: 
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
        /// Coment�rio: Para que o Ct-e de substitui��o(Sa�da) seja vinculado ao Ct-e que foi exclu�do fiscalmente
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
        /// Coment�rio: Para que Ct-e de substitui��o(Sa�da) seja vinculado ao Ct-e de entrada
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
        /// Coment�rio: Gravar o NUMTRANSENT da nota de destino
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
        /// Coment�rio: Campo que grava o n�mero da transa��o de entrada associadas a nota fiscal de sa�da.
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero de transa��o do conhecimento de frete.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMVALEPEDAGIO
        /// Coment�rio: N�mero do comprovante de compra do vale pedagio
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a observa��o do conhecimento de frete.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: Obs. De ocorr�ncia de entrega de nota fiscal.
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
        /// Coment�rio: Observa��o complementar para NF de ajuste
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
        /// Coment�rio: OBSERVA��ES NA NOTA FISCAL REFERENTE A ENTREGA DA CARGA.
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
        /// Coment�rio: Observa��es da NF-e.
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
        /// Coment�rio: Observa��o da tributa��o de PIS/COFINS
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
        /// Coment�rio: Indica org�o p�blico.
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
        /// Coment�rio: Org�o Pub. Federal
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
        /// Coment�rio: Org�o Pub. Municipal
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
        /// Coment�rio: Origem do percentual de Frete
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
        /// Coment�rio: Cont�m o percentual de redu��o para despesas acess�rias (se houver).
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
        /// Propriedade referente ao campo: PERCFRETE
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PERCICMFRETE
        /// Coment�rio: Aliq.ICMS do frete na nota fiscal.
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
        /// Coment�rio: Percentual COFINS
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
        /// Propriedade referente ao campo: PERDESCFIN
        /// Coment�rio: Mesmo campo gravado no pedido, que � replicado durante o faturamento. 
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
        /// Coment�rio: Percentual PIS
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
        /// Coment�rio: Identificar se foi retido PIS na nota fiscal de sa�da
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
        /// Coment�rio: Placa do ve�culo utilizado para transporte.
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
        /// Coment�rio: Prazo de pagamento em dias da primeira parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da d�cima parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da d�cima primeira parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da d�cima segunda parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da segunda parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da terceira parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da quarta parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da quinta parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da sexta parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da s�tima parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da oitava parcela.
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
        /// Coment�rio: Prazo de pagamento em dias da nona parcela.
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
        /// Coment�rio: N�mero do protocolo
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
        /// Coment�rio: Indica o n�mero do protocolo de cancelamento.
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
        /// Coment�rio: Protocolo de cancelamento do CTE.
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
        /// Coment�rio: Protocolo do cte
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o protocolo de autoriza��oda NF-e.
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
        /// Coment�rio: Indica o protocolo de cancelamento da NF-e.
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
        /// Coment�rio: Raz�o Social do local de Coleta do CTE
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
        /// Coment�rio: Raz�o social do cte referenciado
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
        /// Propriedade referente ao campo: RECIBOCTE
        /// Coment�rio: Recibo cte
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
        /// Coment�rio: Indica o recibo de envio de lote dpec.
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
        /// Coment�rio: Indica o recibo de envio de lote.
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
        /// Propriedade referente ao campo: RESPSEGURO
        /// Coment�rio: RESPONS�VEL PELO SEGURO
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
        /// Coment�rio: Rotina que efetuou a gera��o do CTE
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
        /// Coment�rio: 
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
        /// Coment�rio: Selo da sefaz
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
        /// Coment�rio: 
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
        /// Coment�rio: S�rie do documento do cte referenciado
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
        /// Coment�rio: Serie do documento fiscal
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
        /// Propriedade referente ao campo: SERIEORIGINAL
        /// Coment�rio: SERIE ORIGINAL DA NOTA FISCAL ELETRONICA
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
        /// Coment�rio: Informar se o cliente � optante do simples
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
        /// Coment�rio: Situa��o Documento
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
        /// Coment�rio: Situa�ao do cte
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
        /// Coment�rio: 
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
        /// Coment�rio: Situa��o NFe Original.
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: SUBSERIEDOCCTEREF
        /// Coment�rio: Sub-s�rie do documento do cte referenciado
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
        /// Coment�rio: Subserie do documento fiscal
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
        /// Coment�rio: Incri��o Suframa do cliente.
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
        /// Coment�rio: Valor cobrado para realizar a entrega da compra.
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
        /// Coment�rio: Telefone do destinat�rio
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
        /// Coment�rio: Nro de Tentativas de Envio do CTE.
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
        /// Coment�rio: Indica a quantidade de tentativas de envio da nota fiscal a SEFAZ.
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
        /// Coment�rio: Tipo de tributa��o do frete e despesas acess�rias.
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
        /// Coment�rio: 
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
        /// Coment�rio: Tipo do documento do cte referenciado
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
        /// Coment�rio: Flag para identifica��o do tipo do documento (NF/ NFE/ CT/ CTE)
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
        /// Coment�rio: Tipo de emiss�o da NFE (Normal, Conting�ncia, SCAN). Campo do tipo caracter, de tamanho 1, com valor default 1
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
        /// Coment�rio: Tipo Emiss�o Ct-e
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
        /// Coment�rio: Tipo da empresa do cliente.
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
        /// Coment�rio: Tipo pessoa (em casos de dev. de clientes).
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
        /// Coment�rio: 
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
        /// Coment�rio: Define qual tipo de movimenta��o de garantia a nota representa.
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
        /// Coment�rio: Tipo presen�a do adquirinte
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
        /// Coment�rio: C�digo do tipo de servi�o do CT-e
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
        /// Coment�rio: Tipo do CT-e
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
        /// Coment�rio: 
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
        /// Coment�rio: Total do diferencial de al�quotas.
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
        /// Propriedade referente ao campo: TOTPESOBRUTO
        /// Coment�rio: Total do peso bruto das mercadorias.
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
        /// Coment�rio: Peso liquido dos produtos.
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
        /// Coment�rio: Peso total liquido agrupado.
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
        /// Coment�rio: Volume total agrupado.
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
        /// Coment�rio: Indica a transportadora.
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
        /// Coment�rio: UF cliente.
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
        /// Coment�rio: C�digo da UF.
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
        /// Coment�rio: Sigla da UF do Emissor do documento anterior
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
        /// Coment�rio: Indica a UF desembara�o.
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
        /// Coment�rio: UF da filial.
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
        /// Coment�rio: UF do transportador.
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
        /// Coment�rio: Uf da Placa do Veiculo
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
        /// Coment�rio: Gravar a UF da Placa do Veiculo
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
        /// Coment�rio: Unidade de medida para NF de ajuste
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
        /// Coment�rio: Usa integra��o WMS
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
        /// Coment�rio: Utiliza IPI no calculo de ICMS
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
        /// Coment�rio: Valor do documento fiscal
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
        /// Coment�rio: Valor do Vale Ped�gio 
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
        /// Coment�rio: Valor de ST da nota fiscal
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
        /// Coment�rio: Indica se a NF � de venda assistida. 
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
        /// Propriedade referente ao campo: VERSAOROTINA
        /// Coment�rio: Vers�o da rotina gerarou os dados
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Valor Base PIS/COFINS
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
        /// Propriedade referente ao campo: VLBONIFICACERTO
        /// Coment�rio: Valor da bonifica��o acerto
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
        /// Coment�rio: Indica o valor total de cr�dito de COFINS na NF.
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
        /// Coment�rio: GRAVAR O VALOR DO DESCONTO DO ABATIMENTO
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
        /// Coment�rio: Valor de desconto do ICMS de isen��o.
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
        /// Coment�rio: Valor total do desconto.
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLDESPACHO
        /// Coment�rio: Indica o valor de despesa de despacho. (Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: Indica o Valor outras despesas na NF.
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
        /// Coment�rio: Valor de Outras despesas de ped�gio
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLGRIS
        /// Coment�rio: Valor do GRIS no conhecimento
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor do INSS.
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
        /// Coment�rio: 
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
        /// Coment�rio: Esse atributo serve para armazenar o valor do ipi para devolu��o simbolica.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor de despesa de LTR. (Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Vl.Pauta do frete na nota.
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
        /// Coment�rio: Indica o valor de despesa do ped�gio.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: Valor do PIS a ser lan�ado na Gera��o de Nota Fiscal de Presta��o de Servi�o (rotina 1446). 
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
        /// Coment�rio: Valor da Averba��o.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor de despesa com escolta.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        /// Coment�rio: Indica o valor de despesa de seguro da carga.(Utilizado apenas para o projeto 50507 - Transportadora)
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
        [DataObjectField(false,false,true,12)]
        public decimal Vltabela
        {
            get { return  vltabela; }
            set {  vltabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTAS
        /// Coment�rio: Valor do TAS no conheciemento
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
        /// Coment�rio: Valor total.
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
        /// Coment�rio: 
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
        /// Coment�rio: Valor total da NF sem desconto de Isen��o de ICMS.
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
        /// Coment�rio: Valor total bruto para NF de ajuste
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
        /// Coment�rio: Valor total.
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
        /// Coment�rio: Guarda o Valor do Conhec. Frete X Perc.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor total da verba CMV registrado no pedido. 
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
        /// Coment�rio: Funcion�rio que ignorou WMS
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
        /// Coment�rio: WMS Ignorado
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCNfsaid> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfsaid>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
