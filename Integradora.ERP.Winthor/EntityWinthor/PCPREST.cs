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
    /// Classe referente a tabela PCPrest
    /// </summary>
    [XmlType("PCPREST")]
    public class PCPrest : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGRUPADO
        /// Coment�rio: Indica se o t�tulo foi agrupado atrav�s da rotina 1515. 
        /// </summary>
        private string agrupado;
        [XmlElement(ElementName = "AGRUPADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agrupado
        {
            get { return  agrupado; }
            set {  agrupado = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: ESC_COBRAJUROS
        /// Coment�rio: Indica se o t�tulo foi agrupado atrav�s da rotina 1515. 
        /// </summary>
        private string esc_cobrajuros;
        [XmlElement(ElementName = "ESC_COBRAJUROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Esc_cobrajuros
        {
            get { return esc_cobrajuros; }
            set { esc_cobrajuros = value; }
        }

                
        /// <summary>
        /// Propriedade referente ao campo: ALINEA
        /// Coment�rio: 
        /// </summary>
        private decimal alinea;
        [XmlElement(ElementName = "ALINEA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Alinea
        {
            get { return  alinea; }
            set {  alinea = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARQRETORNO
        /// Coment�rio: Indica o nome do arquivo de retorno.
        /// </summary>
        private string arqretorno;
        [XmlElement(ElementName = "ARQRETORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Arqretorno
        {
            get { return  arqretorno; }
            set {  arqretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXACONCILIADA
        /// Coment�rio: Indica se o t�tulo foi baixado com um lan�amento DNI. 
        /// </summary>
        private string baixaconciliada;
        [XmlElement(ElementName = "BAIXACONCILIADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixaconciliada
        {
            get { return  baixaconciliada; }
            set {  baixaconciliada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQDESDEMITENTEDIF
        /// Coment�rio: Bloqueia desdobramento de emitentes diferentes.
        /// </summary>
        private string bloqdesdemitentedif;
        [XmlElement(ElementName = "BLOQDESDEMITENTEDIF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqdesdemitentedif
        {
            get { return  bloqdesdemitentedif; }
            set {  bloqdesdemitentedif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BOLETO
        /// Coment�rio: 
        /// </summary>
        private string boleto;
        [XmlElement(ElementName = "BOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Boleto
        {
            get { return  boleto; }
            set {  boleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTORIO
        /// Coment�rio: 
        /// </summary>
        private string cartorio;
        [XmlElement(ElementName = "CARTORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cartorio
        {
            get { return  cartorio; }
            set {  cartorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCPFCH
        /// Coment�rio: 
        /// </summary>
        private string cgccpfch;
        [XmlElement(ElementName = "CGCCPFCH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgccpfch
        {
            get { return  cgccpfch; }
            set {  cgccpfch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHEQUETERCEIRO
        /// Coment�rio: Indica se e cheque de terceiro ou proprio.
        /// </summary>
        private string chequeterceiro;
        [XmlElement(ElementName = "CHEQUETERCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Chequeterceiro
        {
            get { return  chequeterceiro; }
            set {  chequeterceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJCISP
        /// Coment�rio: CNPJ para CISP.
        /// </summary>
        private string cnpjcisp;
        [XmlElement(ElementName = "CNPJCISP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cnpjcisp
        {
            get { return  cnpjcisp; }
            set {  cnpjcisp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODADMCARTAO
        /// Coment�rio: C�digo da administradora que efetuou a transa��o. 
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
        /// Propriedade referente ao campo: CODAGENTECOBRANCA
        /// Coment�rio: Indica o c�digo agente de cobran�a.
        /// </summary>
        private decimal codagentecobranca;
        [XmlElement(ElementName = "CODAGENTECOBRANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codagentecobranca
        {
            get { return  codagentecobranca; }
            set {  codagentecobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAOTEF
        /// Coment�rio: Campo para armazenar o c�digo de autoriza��o da venda TEF.
        /// </summary>
        private decimal codautorizacaotef;
        [XmlElement(ElementName = "CODAUTORIZACAOTEF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codautorizacaotef
        {
            get { return  codautorizacaotef; }
            set {  codautorizacaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIXA
        /// Coment�rio: 
        /// </summary>
        private decimal? codbaixa;
        [XmlElement(ElementName = "CODBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codbaixa
        {
            get { return  codbaixa; }
            set {  codbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal? codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCOBAIXA
        /// Coment�rio: Indica o c�digo do banco o qual caixa foi acertado.
        /// </summary>
        private decimal codbancobaixa;
        [XmlElement(ElementName = "CODBANCOBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codbancobaixa
        {
            get { return  codbancobaixa; }
            set {  codbancobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCOCM
        /// Coment�rio: 
        /// </summary>
        private decimal codbancocm;
        [XmlElement(ElementName = "CODBANCOCM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbancocm
        {
            get { return  codbancocm; }
            set {  codbancocm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCOCM2
        /// Coment�rio: Campo que informa o c�digo do banco da cobran�a magn�tica.
        /// </summary>
        private decimal codbancocm2;
        [XmlElement(ElementName = "CODBANCOCM2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbancocm2
        {
            get { return  codbancocm2; }
            set {  codbancocm2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCOCUSTODIA
        /// Coment�rio: 
        /// </summary>
        private decimal codbancocustodia;
        [XmlElement(ElementName = "CODBANCOCUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbancocustodia
        {
            get { return  codbancocustodia; }
            set {  codbancocustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCOVENDOR
        /// Coment�rio: 
        /// </summary>
        private decimal codbancovendor;
        [XmlElement(ElementName = "CODBANCOVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbancovendor
        {
            get { return  codbancovendor; }
            set {  codbancovendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANDEIRATEF
        /// Coment�rio: C�digo da Bandeira do Cart�o Tef.
        /// </summary>
        private string codbandeiratef;
        [XmlElement(ElementName = "CODBANDEIRATEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Codbandeiratef
        {
            get { return  codbandeiratef; }
            set {  codbandeiratef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Coment�rio: 
        /// </summary>
        private string codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA2
        /// Coment�rio: Campo que informa o c�digo de barras do banco secund�rio.
        /// </summary>
        private string codbarra2;
        [XmlElement(ElementName = "CODBARRA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Codbarra2
        {
            get { return  codbarra2; }
            set {  codbarra2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBCOCUSTODIA
        /// Coment�rio: Indica o c�digo do banco de cust�dia.
        /// </summary>
        private decimal codbcocustodia;
        [XmlElement(ElementName = "CODBCOCUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbcocustodia
        {
            get { return  codbcocustodia; }
            set {  codbcocustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBLOCO
        /// Coment�rio: 
        /// </summary>
        private decimal codbloco;
        [XmlElement(ElementName = "CODBLOCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Codbloco
        {
            get { return  codbloco; }
            set {  codbloco = value; }
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
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODCOBBANCO
        /// Coment�rio: 
        /// </summary>
        private string codcobbanco;
        [XmlElement(ElementName = "CODCOBBANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobbanco
        {
            get { return  codcobbanco; }
            set {  codcobbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBORIG
        /// Coment�rio: 
        /// </summary>
        private string codcoborig;
        [XmlElement(ElementName = "CODCOBORIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcoborig
        {
            get { return  codcoborig; }
            set {  codcoborig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBPOS
        /// Coment�rio: Cobran�a das parcelas a desdobrar, referente venda POS (Auto-Servi�o). Informado na 409-Acerto Checkout.
        /// </summary>
        private string codcobpos;
        [XmlElement(ElementName = "CODCOBPOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobpos
        {
            get { return  codcobpos; }
            set {  codcobpos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBRADOR
        /// Coment�rio: 
        /// </summary>
        private decimal codcobrador;
        [XmlElement(ElementName = "CODCOBRADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcobrador
        {
            get { return  codcobrador; }
            set {  codcobrador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCRED
        /// Coment�rio: C�digo do Cr�dito utilizado no pagamento
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
        /// Propriedade referente ao campo: CODFUNCBORDERO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncbordero;
        [XmlElement(ElementName = "CODFUNCBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncbordero
        {
            get { return  codfuncbordero; }
            set {  codfuncbordero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccheckout;
        [XmlElement(ElementName = "CODFUNCCHECKOUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccheckout
        {
            get { return  codfunccheckout; }
            set {  codfunccheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONCIL
        /// Coment�rio: Campo para armazenar o c�digo do funcion�rio que realizou a concilia��o dos t�tulos.
        /// </summary>
        private decimal codfuncconcil;
        [XmlElement(ElementName = "CODFUNCCONCIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconcil
        {
            get { return  codfuncconcil; }
            set {  codfuncconcil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONCILVENC
        /// Coment�rio: Campo para armazenar o c�digo do funcion�rio que realizou a concilia��o de vencimento.
        /// </summary>
        private decimal codfuncconcilvenc;
        [XmlElement(ElementName = "CODFUNCCONCILVENC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconcilvenc
        {
            get { return  codfuncconcilvenc; }
            set {  codfuncconcilvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCXMOT
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccxmot;
        [XmlElement(ElementName = "CODFUNCCXMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccxmot
        {
            get { return  codfunccxmot; }
            set {  codfunccxmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDESD
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncdesd;
        [XmlElement(ElementName = "CODFUNCDESD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncdesd
        {
            get { return  codfuncdesd; }
            set {  codfuncdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDESD1
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncdesd1;
        [XmlElement(ElementName = "CODFUNCDESD1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncdesd1
        {
            get { return  codfuncdesd1; }
            set {  codfuncdesd1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDNICLI
        /// Coment�rio: C�digo do funcionario que realizou a associa��o de DNI
        /// </summary>
        private decimal codfuncdnicli;
        [XmlElement(ElementName = "CODFUNCDNICLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncdnicli
        {
            get { return  codfuncdnicli; }
            set {  codfuncdnicli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCESTORNO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncestorno;
        [XmlElement(ElementName = "CODFUNCESTORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncestorno
        {
            get { return  codfuncestorno; }
            set {  codfuncestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINC
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncinc;
        [XmlElement(ElementName = "CODFUNCINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncinc
        {
            get { return  codfuncinc; }
            set {  codfuncinc = value; }
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
        /// Propriedade referente ao campo: CODFUNCPRORROG
        /// Coment�rio: C�digo do funcion�rio que prorrogou o t�tulo, na rotina 1231.
        /// </summary>
        private decimal codfuncprorrog;
        [XmlElement(ElementName = "CODFUNCPRORROG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncprorrog
        {
            get { return  codfuncprorrog; }
            set {  codfuncprorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCVALE
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncvale;
        [XmlElement(ElementName = "CODFUNCVALE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncvale
        {
            get { return  codfuncvale; }
            set {  codfuncvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCVEND
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncvend;
        [XmlElement(ElementName = "CODFUNCVEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncvend
        {
            get { return  codfuncvend; }
            set {  codfuncvend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTVALE
        /// Coment�rio: 
        /// </summary>
        private decimal codhistvale;
        [XmlElement(ElementName = "CODHISTVALE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistvale
        {
            get { return  codhistvale; }
            set {  codhistvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODOCORRBAIXA
        /// Coment�rio: 
        /// </summary>
        private decimal codocorrbaixa;
        [XmlElement(ElementName = "CODOCORRBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codocorrbaixa
        {
            get { return  codocorrbaixa; }
            set {  codocorrbaixa = value; }
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
        /// Propriedade referente ao campo: CODPORTADOR
        /// Coment�rio: 
        /// </summary>
        private decimal codportador;
        [XmlElement(ElementName = "CODPORTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codportador
        {
            get { return  codportador; }
            set {  codportador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Coment�rio: Indica o c�digo profissional.
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
        /// Propriedade referente ao campo: CODSTATUSCOB
        /// Coment�rio: indica a situa��o da cobran�a do t�tulo
        /// </summary>
        private decimal codstatuscob;
        [XmlElement(ElementName = "CODSTATUSCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codstatuscob
        {
            get { return  codstatuscob; }
            set {  codstatuscob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Coment�rio: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
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
        /// Propriedade referente ao campo: CODUSURANT
        /// Coment�rio: Indica o c�digo do RCA anterior.
        /// </summary>
        private decimal codusurant;
        [XmlElement(ElementName = "CODUSURANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusurant
        {
            get { return  codusurant; }
            set {  codusurant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURPGCOMISSAO
        /// Coment�rio: Usu�rio gerador da comiss�o definitiva na rotina 1248.
        /// </summary>
        private decimal codusurpgcomissao;
        [XmlElement(ElementName = "CODUSURPGCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusurpgcomissao
        {
            get { return  codusurpgcomissao; }
            set {  codusurpgcomissao = value; }
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
        /// Propriedade referente ao campo: COMPENSACAOBCO
        /// Coment�rio: 
        /// </summary>
        private decimal compensacaobco;
        [XmlElement(ElementName = "COMPENSACAOBCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Compensacaobco
        {
            get { return  compensacaobco; }
            set {  compensacaobco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTRATOVENDOR
        /// Coment�rio: 
        /// </summary>
        private decimal contratovendor;
        [XmlElement(ElementName = "CONTRATOVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Contratovendor
        {
            get { return  contratovendor; }
            set {  contratovendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DADOSECF
        /// Coment�rio: O valor [ M ] indica que os dados ECF foram informados manualmente.
        /// </summary>
        private string dadosecf;
        [XmlElement(ElementName = "DADOSECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dadosecf
        {
            get { return  dadosecf; }
            set {  dadosecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_ENVIODEBITOAUT
        /// Coment�rio: O valor [ M ] indica que os dados ECF foram informados manualmente.
        /// </summary>
        private string esc_enviodebitoaut;
        [XmlElement(ElementName = "ESC_ENVIODEBITOAUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Esc_enviodebitoaut
        {
            get { return esc_enviodebitoaut; }
            set { esc_enviodebitoaut = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: DATAHORAMINUTOBAIXA
        /// Coment�rio: Data, com hora e minuto, da baixa manual de t�tulos (1207).
        /// </summary>
        private DateTime? datahoraminutobaixa;
        [XmlElement(ElementName = "DATAHORAMINUTOBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahoraminutobaixa
        {
            get { return  datahoraminutobaixa; }
            set {  datahoraminutobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGITAO
        /// Coment�rio: 
        /// </summary>
        private string digitao;
        [XmlElement(ElementName = "DIGITAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Digitao
        {
            get { return  digitao; }
            set {  digitao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURACONTA
        /// Coment�rio: Indica a data de abertura da conta.
        /// </summary>
        private DateTime? dtaberturaconta;
        [XmlElement(ElementName = "DTABERTURACONTA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaberturaconta
        {
            get { return  dtaberturaconta; }
            set {  dtaberturaconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTASSOCIADNICLI
        /// Coment�rio: Data de associa��o de DNI
        /// </summary>
        private DateTime? dtassociadnicli;
        [XmlElement(ElementName = "DTASSOCIADNICLI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtassociadnicli
        {
            get { return  dtassociadnicli; }
            set {  dtassociadnicli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBAIXA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtbaixa;
        [XmlElement(ElementName = "DTBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbaixa
        {
            get { return  dtbaixa; }
            set {  dtbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBAIXACRED
        /// Coment�rio: Indica a data e hora da baixa do cr�dito.
        /// </summary>
        private DateTime? dtbaixacred;
        [XmlElement(ElementName = "DTBAIXACRED", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbaixacred
        {
            get { return  dtbaixacred; }
            set {  dtbaixacred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBORDER
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtborder;
        [XmlElement(ElementName = "DTBORDER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtborder
        {
            get { return  dtborder; }
            set {  dtborder = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBORDERO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtbordero;
        [XmlElement(ElementName = "DTBORDERO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbordero
        {
            get { return  dtbordero; }
            set {  dtbordero = value; }
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
        /// Propriedade referente ao campo: DTCONCIL
        /// Coment�rio: Campo para armazenar a data e hora de concilia��o dos t�tulos.
        /// </summary>
        private DateTime? dtconcil;
        [XmlElement(ElementName = "DTCONCIL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtconcil
        {
            get { return  dtconcil; }
            set {  dtconcil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONCILVENC
        /// Coment�rio: Campo para armazenar a data de concilia��o do vencimento.
        /// </summary>
        private DateTime? dtconcilvenc;
        [XmlElement(ElementName = "DTCONCILVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtconcilvenc
        {
            get { return  dtconcilvenc; }
            set {  dtconcilvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCRIACAO
        /// Coment�rio: Indica a data de cria��o da parcela.
        /// </summary>
        private DateTime? dtcriacao;
        [XmlElement(ElementName = "DTCRIACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcriacao
        {
            get { return  dtcriacao; }
            set {  dtcriacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCUSTODIA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcustodia;
        [XmlElement(ElementName = "DTCUSTODIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcustodia
        {
            get { return  dtcustodia; }
            set {  dtcustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCXMOT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcxmot;
        [XmlElement(ElementName = "DTCXMOT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcxmot
        {
            get { return  dtcxmot; }
            set {  dtcxmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCXMOTHHMMSS
        /// Coment�rio: Data/Hora/Min/Segundos do acerto do t�tulo.
        /// </summary>
        private DateTime? dtcxmothhmmss;
        [XmlElement(ElementName = "DTCXMOTHHMMSS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcxmothhmmss
        {
            get { return  dtcxmothhmmss; }
            set {  dtcxmothhmmss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDEFAGENTE
        /// Coment�rio: Indica a data de transfer�ncia de agente.
        /// </summary>
        private DateTime? dtdefagente;
        [XmlElement(ElementName = "DTDEFAGENTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdefagente
        {
            get { return  dtdefagente; }
            set {  dtdefagente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDESC
        /// Coment�rio: 25/05/2011 - v.16.0.5.22 - 133287
        /// </summary>
        private DateTime? dtdesc;
        [XmlElement(ElementName = "DTDESC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdesc
        {
            get { return  dtdesc; }
            set {  dtdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDESCONTADO
        /// Coment�rio: Indica a data em que o cheque foi descontado.
        /// </summary>
        private DateTime? dtdescontado;
        [XmlElement(ElementName = "DTDESCONTADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdescontado
        {
            get { return  dtdescontado; }
            set {  dtdescontado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDESCONTOTITBCO
        /// Coment�rio: Indica data desconto do t�tulo do banco.
        /// </summary>
        private DateTime? dtdescontotitbco;
        [XmlElement(ElementName = "DTDESCONTOTITBCO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdescontotitbco
        {
            get { return  dtdescontotitbco; }
            set {  dtdescontotitbco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDESD
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtdesd;
        [XmlElement(ElementName = "DTDESD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdesd
        {
            get { return  dtdesd; }
            set {  dtdesd = value; }
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
        /// Propriedade referente ao campo: DTEMISSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOORIG
        /// Coment�rio: Data de Emiss�o Original do T�tulo, gravado no desdobramento do Acerto de Checkout (409).
        /// </summary>
        private DateTime? dtemissaoorig;
        [XmlElement(ElementName = "DTEMISSAOORIG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoorig
        {
            get { return  dtemissaoorig; }
            set {  dtemissaoorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENVIOSERASA
        /// Coment�rio: Data de Envio para o Serasa.
        /// </summary>
        private DateTime? dtenvioserasa;
        [XmlElement(ElementName = "DTENVIOSERASA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtenvioserasa
        {
            get { return  dtenvioserasa; }
            set {  dtenvioserasa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtestorno;
        [XmlElement(ElementName = "DTESTORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestorno
        {
            get { return  dtestorno; }
            set {  dtestorno = value; }
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
        /// Propriedade referente ao campo: DTFECHA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTFECHAVENDOR
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfechavendor;
        [XmlElement(ElementName = "DTFECHAVENDOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechavendor
        {
            get { return  dtfechavendor; }
            set {  dtfechavendor = value; }
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
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAOMANUAL
        /// Coment�rio: Indica a data e hora da baixa do cr�dito.
        /// </summary>
        private DateTime? dtinclusaomanual;
        [XmlElement(ElementName = "DTINCLUSAOMANUAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusaomanual
        {
            get { return  dtinclusaomanual; }
            set {  dtinclusaomanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANCCH
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtlancch;
        [XmlElement(ElementName = "DTLANCCH", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlancch
        {
            get { return  dtlancch; }
            set {  dtlancch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANCPRORROG
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtlancprorrog;
        [XmlElement(ElementName = "DTLANCPRORROG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlancprorrog
        {
            get { return  dtlancprorrog; }
            set {  dtlancprorrog = value; }
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
        /// Propriedade referente ao campo: DTLIBERACAOFECHAMENTO
        /// Coment�rio: Indica data de libera��o do contas a receber no caixa varejo.
        /// </summary>
        private DateTime? dtliberacaofechamento;
        [XmlElement(ElementName = "DTLIBERACAOFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtliberacaofechamento
        {
            get { return  dtliberacaofechamento; }
            set {  dtliberacaofechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAG
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtpag;
        [XmlElement(ElementName = "DTPAG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpag
        {
            get { return  dtpag; }
            set {  dtpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGCOMISSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtpagcomissao;
        [XmlElement(ElementName = "DTPAGCOMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagcomissao
        {
            get { return  dtpagcomissao; }
            set {  dtpagcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGCOMISSAOPROF
        /// Coment�rio: Indica a data pagamento comiss�o profissional.
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
        /// Propriedade referente ao campo: DTPAGCOMISSAO2
        /// Coment�rio: Data de pagamento comis�o do primeiro profissional.
        /// </summary>
        private DateTime? dtpagcomissao2;
        [XmlElement(ElementName = "DTPAGCOMISSAO2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagcomissao2
        {
            get { return  dtpagcomissao2; }
            set {  dtpagcomissao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGCOMISSAO3
        /// Coment�rio: Data de pagamento comis�o do segundo profissional.
        /// </summary>
        private DateTime? dtpagcomissao3;
        [XmlElement(ElementName = "DTPAGCOMISSAO3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagcomissao3
        {
            get { return  dtpagcomissao3; }
            set {  dtpagcomissao3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGCOMISSAO4
        /// Coment�rio: Data de pagamento comis�o do segundo profissional.
        /// </summary>
        private DateTime? dtpagcomissao4;
        [XmlElement(ElementName = "DTPAGCOMISSAO4", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagcomissao4
        {
            get { return  dtpagcomissao4; }
            set {  dtpagcomissao4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROCESSAMENTO
        /// Coment�rio: Indica a data de processamento do arquivo de remessa/retorno.
        /// </summary>
        private DateTime? dtprocessamento;
        [XmlElement(ElementName = "DTPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprocessamento
        {
            get { return  dtprocessamento; }
            set {  dtprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRECEBIMENTOPREVISTO
        /// Coment�rio: Data de recebimento previsto.
        /// </summary>
        private DateTime? dtrecebimentoprevisto;
        [XmlElement(ElementName = "DTRECEBIMENTOPREVISTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtrecebimentoprevisto
        {
            get { return  dtrecebimentoprevisto; }
            set {  dtrecebimentoprevisto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREGCARTEIRA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtregcarteira;
        [XmlElement(ElementName = "DTREGCARTEIRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtregcarteira
        {
            get { return  dtregcarteira; }
            set {  dtregcarteira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREMVENDOR
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtremvendor;
        [XmlElement(ElementName = "DTREMVENDOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtremvendor
        {
            get { return  dtremvendor; }
            set {  dtremvendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRETIRADASERASA
        /// Coment�rio: Apresenta a data em que o lan�amento foi enviado para exclus�o ao serasa
        /// </summary>
        private DateTime? dtretiradaserasa;
        [XmlElement(ElementName = "DTRETIRADASERASA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtretiradaserasa
        {
            get { return  dtretiradaserasa; }
            set {  dtretiradaserasa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSAIDA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtsaida;
        [XmlElement(ElementName = "DTSAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsaida
        {
            get { return  dtsaida; }
            set {  dtsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultalter;
        [XmlElement(ElementName = "DTULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalter
        {
            get { return  dtultalter; }
            set {  dtultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTESTORNO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultestorno;
        [XmlElement(ElementName = "DTULTESTORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultestorno
        {
            get { return  dtultestorno; }
            set {  dtultestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: 
        /// </summary>
        private DateTime dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESC_DTREFERENCIA
        /// Coment�rio: data de refer�ncia do t�tulo
        /// </summary>
        private DateTime? esc_dtreferencia;
        [XmlElement(ElementName = "ESC_DTREFERENCIA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? ESC_Dtreferencia
        {
            get { return esc_dtreferencia; }
            set { esc_dtreferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCANTERIOR
        /// Coment�rio: Indica data de vencimento (original) que foi prorrogada na 1231.
        /// </summary>
        private DateTime? dtvencanterior;
        [XmlElement(ElementName = "DTVENCANTERIOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencanterior
        {
            get { return  dtvencanterior; }
            set {  dtvencanterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCORIG
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvencorig;
        [XmlElement(ElementName = "DTVENCORIG", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtvencorig
        {
            get { return  dtvencorig; }
            set {  dtvencorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCVALE
        /// Coment�rio: Data do vencimento do vale, quando a cobran�a do t�tulo � DEBM, DEBV ou DBFU. 
        /// </summary>
        private DateTime? dtvencvale;
        [XmlElement(ElementName = "DTVENCVALE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencvale
        {
            get { return  dtvencvale; }
            set {  dtvencvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENDOR
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvendor;
        [XmlElement(ElementName = "DTVENDOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvendor
        {
            get { return  dtvendor; }
            set {  dtvendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DUPLIC
        /// Coment�rio: 
        /// </summary>
        private decimal duplic;
        [XmlElement(ElementName = "DUPLIC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Duplic
        {
            get { return  duplic; }
            set {  duplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVAGENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal dvagencia;
        [XmlElement(ElementName = "DVAGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvagencia
        {
            get { return  dvagencia; }
            set {  dvagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCHEQUE
        /// Coment�rio: 
        /// </summary>
        private decimal dvcheque;
        [XmlElement(ElementName = "DVCHEQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvcheque
        {
            get { return  dvcheque; }
            set {  dvcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCOB
        /// Coment�rio: 
        /// </summary>
        private decimal dvcob;
        [XmlElement(ElementName = "DVCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvcob
        {
            get { return  dvcob; }
            set {  dvcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCONTA
        /// Coment�rio: 
        /// </summary>
        private decimal dvconta;
        [XmlElement(ElementName = "DVCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvconta
        {
            get { return  dvconta; }
            set {  dvconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADOQIS
        /// Coment�rio: Valores enviados para o sistema QIS
        /// </summary>
        private string enviadoqis;
        [XmlElement(ElementName = "ENVIADOQIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviadoqis
        {
            get { return  enviadoqis; }
            set {  enviadoqis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EQUIPLANC
        /// Coment�rio: Equipamento de lan�amento que alterou o registro
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
        /// Propriedade referente ao campo: FUNCLANC
        /// Coment�rio: Funcion�rio logado que alterou o registro
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
        /// Propriedade referente ao campo: HISTORIGDESDOBRAMENTO
        /// Coment�rio: Historico de origem do desdobramento do t�tulo.
        /// </summary>
        private string historigdesdobramento;
        [XmlElement(ElementName = "HISTORIGDESDOBRAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Historigdesdobramento
        {
            get { return  historigdesdobramento; }
            set {  historigdesdobramento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORADESD
        /// Coment�rio: 
        /// </summary>
        private decimal horadesd;
        [XmlElement(ElementName = "HORADESD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horadesd
        {
            get { return  horadesd; }
            set {  horadesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAESTORNO
        /// Coment�rio: Indica a hora do estorno.
        /// </summary>
        private decimal horaestorno;
        [XmlElement(ElementName = "HORAESTORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horaestorno
        {
            get { return  horaestorno; }
            set {  horaestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFECHA
        /// Coment�rio: 
        /// </summary>
        private decimal? horafecha;
        [XmlElement(ElementName = "HORAFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Horafecha
        {
            get { return  horafecha; }
            set {  horafecha = value; }
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
        /// Propriedade referente ao campo: LINHADIG
        /// Coment�rio: 
        /// </summary>
        private string linhadig;
        [XmlElement(ElementName = "LINHADIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,65)]
        public string Linhadig
        {
            get { return  linhadig; }
            set {  linhadig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LINHADIG2
        /// Coment�rio: Campo utilizado para informar a linha digit�vel do banco secund�rio.
        /// </summary>
        private string linhadig2;
        [XmlElement(ElementName = "LINHADIG2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,65)]
        public string Linhadig2
        {
            get { return  linhadig2; }
            set {  linhadig2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTODESD
        /// Coment�rio: 
        /// </summary>
        private decimal? minutodesd;
        [XmlElement(ElementName = "MINUTODESD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Minutodesd
        {
            get { return  minutodesd; }
            set {  minutodesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOESTORNO
        /// Coment�rio: Indica o minuto do estorno.
        /// </summary>
        private decimal minutoestorno;
        [XmlElement(ElementName = "MINUTOESTORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoestorno
        {
            get { return  minutoestorno; }
            set {  minutoestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFECHA
        /// Coment�rio: 
        /// </summary>
        private decimal? minutofecha;
        [XmlElement(ElementName = "MINUTOFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Minutofecha
        {
            get { return  minutofecha; }
            set {  minutofecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEARQUIVO
        /// Coment�rio: Indica o nome do arquivo + extens�o do arquivo de remessa/retorno.
        /// </summary>
        private string nomearquivo;
        [XmlElement(ElementName = "NOMEARQUIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Nomearquivo
        {
            get { return  nomearquivo; }
            set {  nomearquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOSSONUMBCO
        /// Coment�rio: 
        /// </summary>
        private string nossonumbco;
        [XmlElement(ElementName = "NOSSONUMBCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nossonumbco
        {
            get { return  nossonumbco; }
            set {  nossonumbco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOSSONUMBCO2
        /// Coment�rio: Campo que informa o nossonumbanco do banco secund�rio.
        /// </summary>
        private string nossonumbco2;
        [XmlElement(ElementName = "NOSSONUMBCO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nossonumbco2
        {
            get { return  nossonumbco2; }
            set {  nossonumbco2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUHOST
        /// Coment�rio: N�mero do NSUHOST transa��o de cart�o
        /// </summary>
        private string nsuhost;
        [XmlElement(ElementName = "NSUHOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsuhost
        {
            get { return  nsuhost; }
            set {  nsuhost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUTEF
        /// Coment�rio: N�mero de controle vinculado ao cart�o (n�mero de controle do TEF). Gravado na rotina 2075 ao emitir venda TEF DLL e em seguida exportado pela procedure do servidor. 
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
        /// Propriedade referente ao campo: NUMAGENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal numagencia;
        [XmlElement(ElementName = "NUMAGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numagencia
        {
            get { return  numagencia; }
            set {  numagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMASSOCDNI
        /// Coment�rio: N�mero de associa��o de DNI com titulos
        /// </summary>
        private decimal numassocdni;
        [XmlElement(ElementName = "NUMASSOCDNI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numassocdni
        {
            get { return  numassocdni; }
            set {  numassocdni = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBORDERO
        /// Coment�rio: 
        /// </summary>
        private decimal numbordero;
        [XmlElement(ElementName = "NUMBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numbordero
        {
            get { return  numbordero; }
            set {  numbordero = value; }
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
        /// Propriedade referente ao campo: NUMCARTAO
        /// Coment�rio: Campo para armazenar o n�mero do cart�o.
        /// </summary>
        private string numcartao;
        [XmlElement(ElementName = "NUMCARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numcartao
        {
            get { return  numcartao; }
            set {  numcartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTAOCRM
        /// Coment�rio: N�mero do cart�o CRM
        /// </summary>
        private string numcartaocrm;
        [XmlElement(ElementName = "NUMCARTAOCRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public string Numcartaocrm
        {
            get { return  numcartaocrm; }
            set {  numcartaocrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private decimal numcheckout;
        [XmlElement(ElementName = "NUMCHECKOUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcheckout
        {
            get { return  numcheckout; }
            set {  numcheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Coment�rio: 
        /// </summary>
        private decimal numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTACORRENTE
        /// Coment�rio: 
        /// </summary>
        private decimal numcontacorrente;
        [XmlElement(ElementName = "NUMCONTACORRENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcontacorrente
        {
            get { return  numcontacorrente; }
            set {  numcontacorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUSTODIA
        /// Coment�rio: 
        /// </summary>
        private decimal numcustodia;
        [XmlElement(ElementName = "NUMCUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcustodia
        {
            get { return  numcustodia; }
            set {  numcustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASCARENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal numdiascarencia;
        [XmlElement(ElementName = "NUMDIASCARENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiascarencia
        {
            get { return  numdiascarencia; }
            set {  numdiascarencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASPRAZOPROTESTO
        /// Coment�rio: 
        /// </summary>
        private decimal numdiasprazoprotesto;
        [XmlElement(ElementName = "NUMDIASPRAZOPROTESTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasprazoprotesto
        {
            get { return  numdiasprazoprotesto; }
            set {  numdiasprazoprotesto = value; }
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
        /// Propriedade referente ao campo: NUMLOTECARTAOTEF
        /// Coment�rio: Campo para armazenar o n�mero do lote gerado para concilia��o de cart�es.
        /// </summary>
        private string numlotecartaotef;
        [XmlElement(ElementName = "NUMLOTECARTAOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Numlotecartaotef
        {
            get { return  numlotecartaotef; }
            set {  numlotecartaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTECUSTODIA
        /// Coment�rio: 
        /// </summary>
        private decimal numlotecustodia;
        [XmlElement(ElementName = "NUMLOTECUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numlotecustodia
        {
            get { return  numlotecustodia; }
            set {  numlotecustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNEGOCIACAO
        /// Coment�rio: N�mero da negocia��o de compra referente a este contas a receber. 
        /// </summary>
        private decimal numnegociacao;
        [XmlElement(ElementName = "NUMNEGOCIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numnegociacao
        {
            get { return  numnegociacao; }
            set {  numnegociacao = value; }
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
        /// Propriedade referente ao campo: NUMRECIBO
        /// Coment�rio: 
        /// </summary>
        private decimal numrecibo;
        [XmlElement(ElementName = "NUMRECIBO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numrecibo
        {
            get { return  numrecibo; }
            set {  numrecibo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREMESSA
        /// Coment�rio: Indica o n�mero da remessa enviada ao banco.
        /// </summary>
        private decimal numremessa;
        [XmlElement(ElementName = "NUMREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Numremessa
        {
            get { return  numremessa; }
            set {  numremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQRETORNO
        /// Coment�rio: Indica o n�mero da posi��o do t�tulo no arquivo de retorno.
        /// </summary>
        private decimal numseqretorno;
        [XmlElement(ElementName = "NUMSEQRETORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqretorno
        {
            get { return  numseqretorno; }
            set {  numseqretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Coment�rio: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: N�mero de transa��o da nota fiscal de entrada.
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTDEVCLI
        /// Coment�rio: 
        /// </summary>
        private decimal numtransentdevcli;
        [XmlElement(ElementName = "NUMTRANSENTDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentdevcli
        {
            get { return  numtransentdevcli; }
            set {  numtransentdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAST
        /// Coment�rio: N�mero de transa��o de venda de t�tulos de ST.
        /// </summary>
        private decimal numtransvendast;
        [XmlElement(ElementName = "NUMTRANSVENDAST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendast
        {
            get { return  numtransvendast; }
            set {  numtransvendast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDOR
        /// Coment�rio: 
        /// </summary>
        private decimal numtransvendor;
        [XmlElement(ElementName = "NUMTRANSVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtransvendor
        {
            get { return  numtransvendor; }
            set {  numtransvendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCUSTODIA
        /// Coment�rio: Indica a observa��o custodia.
        /// </summary>
        private string obscustodia;
        [XmlElement(ElementName = "OBSCUSTODIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obscustodia
        {
            get { return  obscustodia; }
            set {  obscustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSFINANC
        /// Coment�rio: 
        /// </summary>
        private string obsfinanc;
        [XmlElement(ElementName = "OBSFINANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obsfinanc
        {
            get { return  obsfinanc; }
            set {  obsfinanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSTITULO
        /// Coment�rio: Observa��o do t�tulo
        /// </summary>
        private string obstitulo;
        [XmlElement(ElementName = "OBSTITULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Obstitulo
        {
            get { return  obstitulo; }
            set {  obstitulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
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
        /// Propriedade referente ao campo: ORIGEMBOLETO
        /// Coment�rio: Campo para armazenar a origem da gera��o do boleto banc�rio. Padr�o do campo ser� nulo.
        /// </summary>
        private string origemboleto;
        [XmlElement(ElementName = "ORIGEMBOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Origemboleto
        {
            get { return  origemboleto; }
            set {  origemboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELAMENTOTEF
        /// Coment�rio: Indica se os t�tulos foram gravados de acordo com o parcelamento da transa��o TEF. 
        /// </summary>
        private string parcelamentotef;
        [XmlElement(ElementName = "PARCELAMENTOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Parcelamentotef
        {
            get { return  parcelamentotef; }
            set {  parcelamentotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Coment�rio: 
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMSUP
        /// Coment�rio: 
        /// </summary>
        private decimal percomsup;
        [XmlElement(ElementName = "PERCOMSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomsup
        {
            get { return  percomsup; }
            set {  percomsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC
        /// Coment�rio: 
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEESTORNO
        /// Coment�rio: Indica se ser� permitido estornar o t�tulo. 
        /// </summary>
        private string permiteestorno;
        [XmlElement(ElementName = "PERMITEESTORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteestorno
        {
            get { return  permiteestorno; }
            set {  permiteestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Coment�rio: 
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTTEF
        /// Coment�rio: N�mero da parcela original. 
        /// </summary>
        private decimal presttef;
        [XmlElement(ElementName = "PRESTTEF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Presttef
        {
            get { return  presttef; }
            set {  presttef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTESTO
        /// Coment�rio: T�tulo em protesto.
        /// </summary>
        private string protesto;
        [XmlElement(ElementName = "PROTESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Protesto
        {
            get { return  protesto; }
            set {  protesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPARCELASPOS
        /// Coment�rio: Quantidade de parcelas a desdobrar, referente venda POS (Auto-Servi�o). Informado na 409-Acerto Checkout.
        /// </summary>
        private decimal qtparcelaspos;
        [XmlElement(ElementName = "QTPARCELASPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtparcelaspos
        {
            get { return  qtparcelaspos; }
            set {  qtparcelaspos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESPONSAVELPAG
        /// Coment�rio: Respons�vel pelo pagamento
        /// </summary>
        private string responsavelpag;
        [XmlElement(ElementName = "RESPONSAVELPAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Responsavelpag
        {
            get { return  responsavelpag; }
            set {  responsavelpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTDESD
        /// Coment�rio: 
        /// </summary>
        private decimal rotdesd;
        [XmlElement(ElementName = "ROTDESD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Rotdesd
        {
            get { return  rotdesd; }
            set {  rotdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: Indica a rotina de lan�amento do t�tulo: 306 ou 2075.
        /// </summary>
        private decimal rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANCULTALT
        /// Coment�rio: Ultima rotina que alterou o registro
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
        /// Propriedade referente ao campo: SOMATXBOLETO
        /// Coment�rio: Somar tarifa ao valor do boleto.
        /// </summary>
        private string somatxboleto;
        [XmlElement(ElementName = "SOMATXBOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somatxboleto
        {
            get { return  somatxboleto; }
            set {  somatxboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Status credito do t�tulo.
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSSCI
        /// Coment�rio: Gravar Status do titulo referente a rotina 1271
        /// </summary>
        private string statussci;
        [XmlElement(ElementName = "STATUSSCI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Statussci
        {
            get { return  statussci; }
            set {  statussci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOESTORNO
        /// Coment�rio: 
        /// </summary>
        private string tipoestorno;
        [XmlElement(ElementName = "TIPOESTORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoestorno
        {
            get { return  tipoestorno; }
            set {  tipoestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPERACAOTEF
        /// Coment�rio: Tipo de Opera��o de Cart�o Tef.
        /// </summary>
        private string tipooperacaotef;
        [XmlElement(ElementName = "TIPOOPERACAOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Tipooperacaotef
        {
            get { return  tipooperacaotef; }
            set {  tipooperacaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPORTADOR
        /// Coment�rio: 
        /// </summary>
        private string tipoportador;
        [XmlElement(ElementName = "TIPOPORTADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoportador
        {
            get { return  tipoportador; }
            set {  tipoportador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRORROG
        /// Coment�rio: 
        /// </summary>
        private string tipoprorrog;
        [XmlElement(ElementName = "TIPOPRORROG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprorrog
        {
            get { return  tipoprorrog; }
            set {  tipoprorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXPERM
        /// Coment�rio: 
        /// </summary>
        private decimal txperm;
        [XmlElement(ElementName = "TXPERM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Txperm
        {
            get { return  txperm; }
            set {  txperm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXPERMPREVISTO
        /// Coment�rio: Juros previsto.
        /// </summary>
        private decimal txpermprevisto;
        [XmlElement(ElementName = "TXPERMPREVISTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Txpermprevisto
        {
            get { return  txpermprevisto; }
            set {  txpermprevisto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXPERMPREVREAL
        /// Coment�rio: Juros previsto que o cliente realmente deve.
        /// </summary>
        private decimal txpermprevreal;
        [XmlElement(ElementName = "TXPERMPREVREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Txpermprevreal
        {
            get { return  txpermprevreal; }
            set {  txpermprevreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDORBCO
        /// Coment�rio: 
        /// </summary>
        private decimal txvendorbco;
        [XmlElement(ElementName = "TXVENDORBCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Txvendorbco
        {
            get { return  txvendorbco; }
            set {  txvendorbco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDORCLI
        /// Coment�rio: 
        /// </summary>
        private decimal txvendorcli;
        [XmlElement(ElementName = "TXVENDORCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Txvendorcli
        {
            get { return  txvendorcli; }
            set {  txvendorcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDESC
        /// Coment�rio: 
        /// </summary>
        private decimal valordesc;
        [XmlElement(ElementName = "VALORDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valordesc
        {
            get { return  valordesc; }
            set {  valordesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDESCORIG
        /// Coment�rio: Valor de desconto original do t�tulo. 
        /// </summary>
        private decimal valordescorig;
        [XmlElement(ElementName = "VALORDESCORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valordescorig
        {
            get { return  valordescorig; }
            set {  valordescorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORESTORNO
        /// Coment�rio: Valor Estornado do T�tulo (ser� menor ou igual ao valor pago). 
        /// </summary>
        private decimal valorestorno;
        [XmlElement(ElementName = "VALORESTORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorestorno
        {
            get { return  valorestorno; }
            set {  valorestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORLIQCOM
        /// Coment�rio: 
        /// </summary>
        private decimal valorliqcom;
        [XmlElement(ElementName = "VALORLIQCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorliqcom
        {
            get { return  valorliqcom; }
            set {  valorliqcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORLIQCOMSUP
        /// Coment�rio: 
        /// </summary>
        private decimal valorliqcomsup;
        [XmlElement(ElementName = "VALORLIQCOMSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorliqcomsup
        {
            get { return  valorliqcomsup; }
            set {  valorliqcomsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORORIG
        /// Coment�rio: 
        /// </summary>
        private decimal valororig;
        [XmlElement(ElementName = "VALORORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valororig
        {
            get { return  valororig; }
            set {  valororig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCONTRATOVENDOR
        /// Coment�rio: 
        /// </summary>
        private decimal vlcontratovendor;
        [XmlElement(ElementName = "VLCONTRATOVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcontratovendor
        {
            get { return  vlcontratovendor; }
            set {  vlcontratovendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTODOCVENDOR
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustodocvendor;
        [XmlElement(ElementName = "VLCUSTODOCVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcustodocvendor
        {
            get { return  vlcustodocvendor; }
            set {  vlcustodocvendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVOL
        /// Coment�rio: 
        /// </summary>
        private decimal vldevol;
        [XmlElement(ElementName = "VLDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vldevol
        {
            get { return  vldevol; }
            set {  vldevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRCOFINSORGPUB
        /// Coment�rio: Vlr. COFINS �rg�os p�blicos.
        /// </summary>
        private decimal vlrcofinsorgpub;
        [XmlElement(ElementName = "VLRCOFINSORGPUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrcofinsorgpub
        {
            get { return  vlrcofinsorgpub; }
            set {  vlrcofinsorgpub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRCONTSOCIALORGPUB
        /// Coment�rio: Vlr. CS �rg�os p�blicos.
        /// </summary>
        private decimal vlrcontsocialorgpub;
        [XmlElement(ElementName = "VLRCONTSOCIALORGPUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrcontsocialorgpub
        {
            get { return  vlrcontsocialorgpub; }
            set {  vlrcontsocialorgpub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDESPBANCARIAS
        /// Coment�rio: Vlr. Desp.Banc�rias.
        /// </summary>
        private decimal vlrdespbancarias;
        [XmlElement(ElementName = "VLRDESPBANCARIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrdespbancarias
        {
            get { return  vlrdespbancarias; }
            set {  vlrdespbancarias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDESPCARTORAIS
        /// Coment�rio: Vlr. Desp. Cartorais.
        /// </summary>
        private decimal vlrdespcartorais;
        [XmlElement(ElementName = "VLRDESPCARTORAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrdespcartorais
        {
            get { return  vlrdespcartorais; }
            set {  vlrdespcartorais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRICMSRETORGPUB
        /// Coment�rio: Vlr. ICMSRET �rg�os p�blicos.
        /// </summary>
        private decimal vlricmsretorgpub;
        [XmlElement(ElementName = "VLRICMSRETORGPUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlricmsretorgpub
        {
            get { return  vlricmsretorgpub; }
            set {  vlricmsretorgpub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRIMPRENDAORGPUB
        /// Coment�rio: Vlr. IR �rg�os p�blicos.
        /// </summary>
        private decimal vlrimprendaorgpub;
        [XmlElement(ElementName = "VLRIMPRENDAORGPUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrimprendaorgpub
        {
            get { return  vlrimprendaorgpub; }
            set {  vlrimprendaorgpub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLROUTRASDEDUCOESORGPUB
        /// Coment�rio: Vlr. Outras dedu��es �rg�os p�blicos.
        /// </summary>
        private decimal vlroutrasdeducoesorgpub;
        [XmlElement(ElementName = "VLROUTRASDEDUCOESORGPUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlroutrasdeducoesorgpub
        {
            get { return  vlroutrasdeducoesorgpub; }
            set {  vlroutrasdeducoesorgpub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLROUTROSACRESC
        /// Coment�rio: Valor outros acr�scimos.
        /// </summary>
        private decimal vlroutrosacresc;
        [XmlElement(ElementName = "VLROUTROSACRESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlroutrosacresc
        {
            get { return  vlroutrosacresc; }
            set {  vlroutrosacresc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRPISORGPUB
        /// Coment�rio: Vlr. PIS �rg�os p�blicos.
        /// </summary>
        private decimal vlrpisorgpub;
        [XmlElement(ElementName = "VLRPISORGPUB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrpisorgpub
        {
            get { return  vlrpisorgpub; }
            set {  vlrpisorgpub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRTOTDESPESASEJUROS
        /// Coment�rio: Valor de outras despesas do t�tulo
        /// </summary>
        private decimal vlrtotdespesasejuros;
        [XmlElement(ElementName = "VLRTOTDESPESASEJUROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrtotdespesasejuros
        {
            get { return  vlrtotdespesasejuros; }
            set {  vlrtotdespesasejuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTXBOLETO
        /// Coment�rio: 
        /// </summary>
        private decimal vltxboleto;
        [XmlElement(ElementName = "VLTXBOLETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltxboleto
        {
            get { return  vltxboleto; }
            set {  vltxboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTXIOF
        /// Coment�rio: 
        /// </summary>
        private decimal vltxiof;
        [XmlElement(ElementName = "VLTXIOF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltxiof
        {
            get { return  vltxiof; }
            set {  vltxiof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTXIOFCOMPLEMENTAR
        /// Coment�rio: Valor taxa IOF complementar.
        /// </summary>
        private decimal vltxiofcomplementar;
        [XmlElement(ElementName = "VLTXIOFCOMPLEMENTAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltxiofcomplementar
        {
            get { return  vltxiofcomplementar; }
            set {  vltxiofcomplementar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTXVENDOR
        /// Coment�rio: 
        /// </summary>
        private decimal vltxvendor;
        [XmlElement(ElementName = "VLTXVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltxvendor
        {
            get { return  vltxvendor; }
            set {  vltxvendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VPAGO
        /// Coment�rio: 
        /// </summary>
        private decimal vpago;
        [XmlElement(ElementName = "VPAGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vpago
        {
            get { return  vpago; }
            set {  vpago = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPrest()
        {
            Esc_cobrajuros = "S";
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPREST";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPrest> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrest>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPrest> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrest>(where);
        }

        #endregion
    }
}
