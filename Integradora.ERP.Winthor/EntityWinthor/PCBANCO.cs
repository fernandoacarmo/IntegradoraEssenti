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
    /// Classe referente a tabela PCBanco
    /// </summary>
    [XmlType("PCBANCO")]
    public class PCBanco : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITADEPOSITOVERBAFORNEC
        /// Coment�rio: Indica se aceita deposito verba de fornecedor.
        /// </summary>
        private string aceitadepositoverbafornec;
        [XmlElement(ElementName = "ACEITADEPOSITOVERBAFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitadepositoverbafornec
        {
            get { return  aceitadepositoverbafornec; }
            set {  aceitadepositoverbafornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAPGTOMENOR
        /// Coment�rio: Indica se ser� aceito pagamento a menor. 
        /// </summary>
        private string aceitapgtomenor;
        [XmlElement(ElementName = "ACEITAPGTOMENOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitapgtomenor
        {
            get { return  aceitapgtomenor; }
            set {  aceitapgtomenor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGENCIA
        /// Coment�rio: 
        /// </summary>
        private string agencia;
        [XmlElement(ElementName = "AGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Agencia
        {
            get { return  agencia; }
            set {  agencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGENCIACORRESPONDENTE
        /// Coment�rio: 
        /// </summary>
        private string agenciacorrespondente;
        [XmlElement(ElementName = "AGENCIACORRESPONDENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Agenciacorrespondente
        {
            get { return  agenciacorrespondente; }
            set {  agenciacorrespondente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGENCIAENTREGA
        /// Coment�rio: 
        /// </summary>
        private string agenciaentrega;
        [XmlElement(ElementName = "AGENCIAENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Agenciaentrega
        {
            get { return  agenciaentrega; }
            set {  agenciaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANOREMESSA
        /// Coment�rio: Campo para controle do ano de envio de remessa, utilizado. 
        /// </summary>
        private decimal anoremessa;
        [XmlElement(ElementName = "ANOREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Anoremessa
        {
            get { return  anoremessa; }
            set {  anoremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXAJUROSMENORCM
        /// Coment�rio: Indica que baixar�, via cobran�a magn�tica, t�tulo pago com juros a menor. 
        /// </summary>
        private string baixajurosmenorcm;
        [XmlElement(ElementName = "BAIXAJUROSMENORCM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixajurosmenorcm
        {
            get { return  baixajurosmenorcm; }
            set {  baixajurosmenorcm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXARSEMINFORMARFILIAL
        /// Coment�rio: Indica se para cobran�a n�o registrada ser� poss�vel baixar sem informar c�digo da filial.
        /// </summary>
        private string baixarseminformarfilial;
        [XmlElement(ElementName = "BAIXARSEMINFORMARFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixarseminformarfilial
        {
            get { return  baixarseminformarfilial; }
            set {  baixarseminformarfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXATITCOMDIFVALORES
        /// Coment�rio: Baixa t�tulos com diferen��o de valores entre o arquivo e a PCPREST.
        /// </summary>
        private string baixatitcomdifvalores;
        [XmlElement(ElementName = "BAIXATITCOMDIFVALORES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixatitcomdifvalores
        {
            get { return  baixatitcomdifvalores; }
            set {  baixatitcomdifvalores = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXATITULONAOACERTADO
        /// Coment�rio: Indica se baixar�, via cobran�a magn�tica, t�tulo ainda n�o acertado. 
        /// </summary>
        private string baixatitulonaoacertado;
        [XmlElement(ElementName = "BAIXATITULONAOACERTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixatitulonaoacertado
        {
            get { return  baixatitulonaoacertado; }
            set {  baixatitulonaoacertado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXATITULOSDESCFINCM
        /// Coment�rio: Indica que baixar�, via cobran�a magn�tica, t�tulo pago com desconto. 
        /// </summary>
        private string baixatitulosdescfincm;
        [XmlElement(ElementName = "BAIXATITULOSDESCFINCM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixatitulosdescfincm
        {
            get { return  baixatitulosdescfincm; }
            set {  baixatitulosdescfincm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQCREDCLIBAIXA
        /// Coment�rio: Bloquear os cr�ditos gerados pela rotina 1502.
        /// </summary>
        private string bloqcredclibaixa;
        [XmlElement(ElementName = "BLOQCREDCLIBAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqcredclibaixa
        {
            get { return  bloqcredclibaixa; }
            set {  bloqcredclibaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCREMESSA
        /// Coment�rio: Indica o CGC do cliente usado na remessa ao banco. 
        /// </summary>
        private string cgcremessa;
        [XmlElement(ElementName = "CGCREMESSA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cgcremessa
        {
            get { return  cgcremessa; }
            set {  cgcremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBACEN
        /// Coment�rio: C�digo da institui��o banc�ria.
        /// </summary>
        private string codbacen;
        [XmlElement(ElementName = "CODBACEN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codbacen
        {
            get { return  codbacen; }
            set {  codbacen = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCOSEC
        /// Coment�rio: Campo utilizado para informar o banco secund�rio para impress�o de boletas.
        /// </summary>
        private decimal codbancosec;
        [XmlElement(ElementName = "CODBANCOSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbancosec
        {
            get { return  codbancosec; }
            set {  codbancosec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCEDENTE
        /// Coment�rio: 
        /// </summary>
        private string codcedente;
        [XmlElement(ElementName = "CODCEDENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codcedente
        {
            get { return  codcedente; }
            set {  codcedente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTENOBANCO
        /// Coment�rio: 
        /// </summary>
        private string codclientenobanco;
        [XmlElement(ElementName = "CODCLIENTENOBANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codclientenobanco
        {
            get { return  codclientenobanco; }
            set {  codclientenobanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTABIL
        /// Coment�rio: 
        /// </summary>
        private decimal codcontabil;
        [XmlElement(ElementName = "CODCONTABIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontabil
        {
            get { return  codcontabil; }
            set {  codcontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTABILCHDV
        /// Coment�rio: 
        /// </summary>
        private decimal codcontabilchdv;
        [XmlElement(ElementName = "CODCONTABILCHDV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontabilchdv
        {
            get { return  codcontabilchdv; }
            set {  codcontabilchdv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTABILCOBS
        /// Coment�rio: 
        /// </summary>
        private decimal codcontabilcobs;
        [XmlElement(ElementName = "CODCONTABILCOBS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontabilcobs
        {
            get { return  codcontabilcobs; }
            set {  codcontabilcobs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTABILDNI
        /// Coment�rio: 
        /// </summary>
        private decimal codcontabildni;
        [XmlElement(ElementName = "CODCONTABILDNI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontabildni
        {
            get { return  codcontabildni; }
            set {  codcontabildni = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTDESPBC
        /// Coment�rio: C�digo de conta para lan�amento de despesa banc�ria.
        /// </summary>
        private decimal codcontdespbc;
        [XmlElement(ElementName = "CODCONTDESPBC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontdespbc
        {
            get { return  codcontdespbc; }
            set {  codcontdespbc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEVENTOINTFOLHACRED
        /// Coment�rio: C�digo evento integra��o folha d�bito
        /// </summary>
        private string codeventointfolhacred;
        [XmlElement(ElementName = "CODEVENTOINTFOLHACRED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codeventointfolhacred
        {
            get { return  codeventointfolhacred; }
            set {  codeventointfolhacred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEVENTOINTFOLHADEB
        /// Coment�rio: C�digo evento integra��o folha cr�dito
        /// </summary>
        private string codeventointfolhadeb;
        [XmlElement(ElementName = "CODEVENTOINTFOLHADEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codeventointfolhadeb
        {
            get { return  codeventointfolhadeb; }
            set {  codeventointfolhadeb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCCAIXA
        /// Coment�rio: Indica o c�digo funcion�rio caixa aberto.
        /// </summary>
        private decimal codfunccaixa;
        [XmlElement(ElementName = "CODFUNCCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfunccaixa
        {
            get { return  codfunccaixa; }
            set {  codfunccaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLAYOUTCM
        /// Coment�rio: C�digo layout para utiliza��o na rotina 1521.
        /// </summary>
        private decimal codlayoutcm;
        [XmlElement(ElementName = "CODLAYOUTCM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codlayoutcm
        {
            get { return  codlayoutcm; }
            set {  codlayoutcm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTA
        /// Coment�rio: 
        /// </summary>
        private string conta;
        [XmlElement(ElementName = "CONTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Conta
        {
            get { return  conta; }
            set {  conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAPAGMAGNETICO
        /// Coment�rio: 
        /// </summary>
        private string contapagmagnetico;
        [XmlElement(ElementName = "CONTAPAGMAGNETICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Contapagmagnetico
        {
            get { return  contapagmagnetico; }
            set {  contapagmagnetico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCTARBANC
        /// Coment�rio: Desconsiderar a tarifa banc�ria para baixa de t�tulos pagos at� o vencimento
        /// </summary>
        private string desctarbanc;
        [XmlElement(ElementName = "DESCTARBANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Desctarbanc
        {
            get { return  desctarbanc; }
            set {  desctarbanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURA
        /// Coment�rio: Indica a data abertura do caixa.
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
        /// Propriedade referente ao campo: FAIXAFIM
        /// Coment�rio: 
        /// </summary>
        private decimal faixafim;
        [XmlElement(ElementName = "FAIXAFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Faixafim
        {
            get { return  faixafim; }
            set {  faixafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAINI
        /// Coment�rio: 
        /// </summary>
        private decimal faixaini;
        [XmlElement(ElementName = "FAIXAINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Faixaini
        {
            get { return  faixaini; }
            set {  faixaini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLUXOCX
        /// Coment�rio: 
        /// </summary>
        private string fluxocx;
        [XmlElement(ElementName = "FLUXOCX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fluxocx
        {
            get { return  fluxocx; }
            set {  fluxocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERADOISDVBANCOSAFRACORRESP
        /// Coment�rio: Gera 2 DVs para o Banco Safra.
        /// </summary>
        private string geradoisdvbancosafracorresp;
        [XmlElement(ElementName = "GERADOISDVBANCOSAFRACORRESP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geradoisdvbancosafracorresp
        {
            get { return  geradoisdvbancosafracorresp; }
            set {  geradoisdvbancosafracorresp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARBOLETO
        /// Coment�rio: 
        /// </summary>
        private string gerarboleto;
        [XmlElement(ElementName = "GERARBOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarboleto
        {
            get { return  gerarboleto; }
            set {  gerarboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARCNAB444
        /// Coment�rio: Gerar aquivo remessa com 444 posi��es
        /// </summary>
        private string gerarcnab444;
        [XmlElement(ElementName = "GERARCNAB444", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarcnab444
        {
            get { return  gerarcnab444; }
            set {  gerarcnab444 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARCRECEBERCARTORIO
        /// Coment�rio: Indica que gera contas a receber de custas cart�rio.
        /// </summary>
        private string gerarcrecebercartorio;
        [XmlElement(ElementName = "GERARCRECEBERCARTORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarcrecebercartorio
        {
            get { return  gerarcrecebercartorio; }
            set {  gerarcrecebercartorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARCREDCLIPAGMAIOR
        /// Coment�rio: Indica se gera credito cliente. 
        /// </summary>
        private string gerarcredclipagmaior;
        [XmlElement(ElementName = "GERARCREDCLIPAGMAIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarcredclipagmaior
        {
            get { return  gerarcredclipagmaior; }
            set {  gerarcredclipagmaior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARRECEITAPAGMAIOR
        /// Coment�rio: C�digo da institui��o banc�ria.
        /// </summary>
        private string gerarreceitapagmaior;
        [XmlElement(ElementName = "GERARRECEITAPAGMAIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarreceitapagmaior
        {
            get { return  gerarreceitapagmaior; }
            set {  gerarreceitapagmaior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAXMLNFE
        /// Coment�rio: Gerar xml nfe.
        /// </summary>
        private string geraxmlnfe;
        [XmlElement(ElementName = "GERAXMLNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraxmlnfe
        {
            get { return  geraxmlnfe; }
            set {  geraxmlnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCDUPJUROSDESD
        /// Coment�rio: Par�metro utilizada para o processo de n�o gera��o de t�tulos para o valor do juros pagos pelo cliente a menor. 
        /// </summary>
        private string incdupjurosdesd;
        [XmlElement(ElementName = "INCDUPJUROSDESD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incdupjurosdesd
        {
            get { return  incdupjurosdesd; }
            set {  incdupjurosdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAOBAIXAJUROSMENORCM
        /// Coment�rio: Indica que n�o baixar�, via cobran�a magn�tica, t�tulo pago com juros a menor. 
        /// </summary>
        private string naobaixajurosmenorcm;
        [XmlElement(ElementName = "NAOBAIXAJUROSMENORCM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naobaixajurosmenorcm
        {
            get { return  naobaixajurosmenorcm; }
            set {  naobaixajurosmenorcm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Coment�rio: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,30)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPREFREMESSA
        /// Coment�rio: Prefixo do arquivo remessa.
        /// </summary>
        private string nomeprefremessa;
        [XmlElement(ElementName = "NOMEPREFREMESSA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Nomeprefremessa
        {
            get { return  nomeprefremessa; }
            set {  nomeprefremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMERTM
        /// Coment�rio: 
        /// </summary>
        private string nomertm;
        [XmlElement(ElementName = "NOMERTM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Nomertm
        {
            get { return  nomertm; }
            set {  nomertm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOSSONUMBCOPREIMPR
        /// Coment�rio: 
        /// </summary>
        private decimal nossonumbcopreimpr;
        [XmlElement(ElementName = "NOSSONUMBCOPREIMPR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public decimal Nossonumbcopreimpr
        {
            get { return  nossonumbcopreimpr; }
            set {  nossonumbcopreimpr = value; }
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
        /// Propriedade referente ao campo: NUMCARTEIRA
        /// Coment�rio: 
        /// </summary>
        private string numcarteira;
        [XmlElement(ElementName = "NUMCARTEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numcarteira
        {
            get { return  numcarteira; }
            set {  numcarteira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTEIRA3
        /// Coment�rio: 
        /// </summary>
        private string numcarteira3;
        [XmlElement(ElementName = "NUMCARTEIRA3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Numcarteira3
        {
            get { return  numcarteira3; }
            set {  numcarteira3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCODLAYOUTCUSTODIA
        /// Coment�rio: Indica o c�digo do layout da cust�dia usado pelo banco. 
        /// </summary>
        private decimal numcodlayoutcustodia;
        [XmlElement(ElementName = "NUMCODLAYOUTCUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Numcodlayoutcustodia
        {
            get { return  numcodlayoutcustodia; }
            set {  numcodlayoutcustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOLSVENDOR
        /// Coment�rio: 
        /// </summary>
        private decimal numcolsvendor;
        [XmlElement(ElementName = "NUMCOLSVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numcolsvendor
        {
            get { return  numcolsvendor; }
            set {  numcolsvendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONVENIO
        /// Coment�rio: 
        /// </summary>
        private decimal numconvenio;
        [XmlElement(ElementName = "NUMCONVENIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numconvenio
        {
            get { return  numconvenio; }
            set {  numconvenio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONVENIOCEF
        /// Coment�rio: Indica o n�mero do conv�nio para os clientes que utilizam o banco CEF - 240.
        /// </summary>
        private string numconveniocef;
        [XmlElement(ElementName = "NUMCONVENIOCEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numconveniocef
        {
            get { return  numconveniocef; }
            set {  numconveniocef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONVENIOCUSTODIA
        /// Coment�rio: 
        /// </summary>
        private decimal numconveniocustodia;
        [XmlElement(ElementName = "NUMCONVENIOCUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numconveniocustodia
        {
            get { return  numconveniocustodia; }
            set {  numconveniocustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONVENIOPAGTO
        /// Coment�rio: 
        /// </summary>
        private string numconveniopagto;
        [XmlElement(ElementName = "NUMCONVENIOPAGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numconveniopagto
        {
            get { return  numconveniopagto; }
            set {  numconveniopagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASPROTESTO
        /// Coment�rio: 
        /// </summary>
        private string numdiasprotesto;
        [XmlElement(ElementName = "NUMDIASPROTESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numdiasprotesto
        {
            get { return  numdiasprotesto; }
            set {  numdiasprotesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQCUSTODIA
        /// Coment�rio: 
        /// </summary>
        private decimal numseqcustodia;
        [XmlElement(ElementName = "NUMSEQCUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Numseqcustodia
        {
            get { return  numseqcustodia; }
            set {  numseqcustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCONTODIA
        /// Coment�rio: Percentual de desconto por dia de adiantamento de pagamento.
        /// </summary>
        private decimal percdescontodia;
        [XmlElement(ElementName = "PERCDESCONTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percdescontodia
        {
            get { return  percdescontodia; }
            set {  percdescontodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMULTA
        /// Coment�rio: Indica o percentual de multa a ser cobrado para opera��es de boletos agrupados.
        /// </summary>
        private decimal percmulta;
        [XmlElement(ElementName = "PERCMULTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percmulta
        {
            get { return  percmulta; }
            set {  percmulta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Coment�rio: Indica banco aberto ou fechado para o caixa.
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
        /// Propriedade referente ao campo: PROXNOSSONUMBCO
        /// Coment�rio: 
        /// </summary>
        private decimal proxnossonumbco;
        [XmlElement(ElementName = "PROXNOSSONUMBCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public decimal Proxnossonumbco
        {
            get { return  proxnossonumbco; }
            set {  proxnossonumbco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNOSSONUMBCOECF
        /// Coment�rio: Numerador de nosso n�mero de banco usado para as vendas ECF (PCAUX2075) na emiss�o de boleto banc�rio se usado servidor intermedi�rio. 
        /// </summary>
        private decimal proxnossonumbcoecf;
        [XmlElement(ElementName = "PROXNOSSONUMBCOECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnossonumbcoecf
        {
            get { return  proxnossonumbcoecf; }
            set {  proxnossonumbcoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCH
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumch;
        [XmlElement(ElementName = "PROXNUMCH", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumch
        {
            get { return  proxnumch; }
            set {  proxnumch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCUSTODIA
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumcustodia;
        [XmlElement(ElementName = "PROXNUMCUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumcustodia
        {
            get { return  proxnumcustodia; }
            set {  proxnumcustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPAGTO
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumpagto;
        [XmlElement(ElementName = "PROXNUMPAGTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumpagto
        {
            get { return  proxnumpagto; }
            set {  proxnumpagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMREMESSA
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumremessa;
        [XmlElement(ElementName = "PROXNUMREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Proxnumremessa
        {
            get { return  proxnumremessa; }
            set {  proxnumremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTHORASMAXFECHACX
        /// Coment�rio: Indica a quantidade m�xima de horas para fechamento de caixa.
        /// </summary>
        private decimal qthorasmaxfechacx;
        [XmlElement(ElementName = "QTHORASMAXFECHACX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qthorasmaxfechacx
        {
            get { return  qthorasmaxfechacx; }
            set {  qthorasmaxfechacx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOB
        /// Coment�rio: 
        /// </summary>
        private string tipocob;
        [XmlElement(ElementName = "TIPOCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocob
        {
            get { return  tipocob; }
            set {  tipocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCXBCO
        /// Coment�rio: 
        /// </summary>
        private string tipocxbco;
        [XmlElement(ElementName = "TIPOCXBCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocxbco
        {
            get { return  tipocxbco; }
            set {  tipocxbco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALORPAGOBANRISUL
        /// Coment�rio: Tipo da composi��o do valor pago para o Banrisul.
        /// </summary>
        private decimal tipovalorpagobanrisul;
        [XmlElement(ElementName = "TIPOVALORPAGOBANRISUL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipovalorpagobanrisul
        {
            get { return  tipovalorpagobanrisul; }
            set {  tipovalorpagobanrisul = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USABANCOSEC
        /// Coment�rio: Campo utilizado para informar se a filial utiliza ou n�o banco secund�rio.
        /// </summary>
        private string usabancosec;
        [XmlElement(ElementName = "USABANCOSEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usabancosec
        {
            get { return  usabancosec; }
            set {  usabancosec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATARIFABANCARIAPORBANCO
        /// Coment�rio: [S] = Indica que o valor da tarifa banc�ria � individual para cada banco, parametrizado na rotina 524. [N] = Indica que o valor da tarifa banc�rio � �nico, parametrizado na rotina 132. 
        /// </summary>
        private string usatarifabancariaporbanco;
        [XmlElement(ElementName = "USATARIFABANCARIAPORBANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatarifabancariaporbanco
        {
            get { return  usatarifabancariaporbanco; }
            set {  usatarifabancariaporbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZABAIXACC
        /// Coment�rio: Se utiliza baixa de cart�o ou n�o.
        /// </summary>
        private string utilizabaixacc;
        [XmlElement(ElementName = "UTILIZABAIXACC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizabaixacc
        {
            get { return  utilizabaixacc; }
            set {  utilizabaixacc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAFECHAMENTOCAIXA
        /// Coment�rio: Indica se utiliza fechamento de caixa.
        /// </summary>
        private string utilizafechamentocaixa;
        [XmlElement(ElementName = "UTILIZAFECHAMENTOCAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizafechamentocaixa
        {
            get { return  utilizafechamentocaixa; }
            set {  utilizafechamentocaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORGERAJUROS
        /// Coment�rio: Determinar o valor m�ximo do juros que n�o ser� cobrado do cliente, quando o par�metro INCDUPJUROSDESD ='S'. 
        /// </summary>
        private decimal valorgerajuros;
        [XmlElement(ElementName = "VALORGERAJUROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Valorgerajuros
        {
            get { return  valorgerajuros; }
            set {  valorgerajuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMINENVIOPROT
        /// Coment�rio: Indica o valor m�nimo do t�tulo para envio � protesto.
        /// </summary>
        private decimal valorminenvioprot;
        [XmlElement(ElementName = "VALORMINENVIOPROT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Valorminenvioprot
        {
            get { return  valorminenvioprot; }
            set {  valorminenvioprot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VAREJO
        /// Coment�rio: Indica se este banco � para o varejo ou n�o.
        /// </summary>
        private string varejo;
        [XmlElement(ElementName = "VAREJO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Varejo
        {
            get { return  varejo; }
            set {  varejo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VARIACAO
        /// Coment�rio: 
        /// </summary>
        private decimal variacao;
        [XmlElement(ElementName = "VARIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Variacao
        {
            get { return  variacao; }
            set {  variacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRMAXBAIXATITPAGAR
        /// Coment�rio: Valor m�ximo para pagamento de contas a pagar.
        /// </summary>
        private decimal vlrmaxbaixatitpagar;
        [XmlElement(ElementName = "VLRMAXBAIXATITPAGAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrmaxbaixatitpagar
        {
            get { return  vlrmaxbaixatitpagar; }
            set {  vlrmaxbaixatitpagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTARIFABANCARIA
        /// Coment�rio: Valor da tarifa banc�ria individual do banco. 
        /// </summary>
        private decimal vltarifabancaria;
        [XmlElement(ElementName = "VLTARIFABANCARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vltarifabancaria
        {
            get { return  vltarifabancaria; }
            set {  vltarifabancaria = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBanco()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBANCO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBanco> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBanco>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBanco> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBanco>(where);
        }

        #endregion
    }
}
