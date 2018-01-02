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
        /// Comentário: Indica se aceita deposito verba de fornecedor.
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
        /// Comentário: Indica se será aceito pagamento a menor. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Campo para controle do ano de envio de remessa, utilizado. 
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
        /// Comentário: Indica que baixará, via cobrança magnética, título pago com juros a menor. 
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
        /// Comentário: Indica se para cobrança não registrada será possível baixar sem informar código da filial.
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
        /// Comentário: Baixa títulos com diferenção de valores entre o arquivo e a PCPREST.
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
        /// Comentário: Indica se baixará, via cobrança magnética, título ainda não acertado. 
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
        /// Comentário: Indica que baixará, via cobrança magnética, título pago com desconto. 
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
        /// Comentário: Bloquear os créditos gerados pela rotina 1502.
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
        /// Comentário: Indica o CGC do cliente usado na remessa ao banco. 
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
        /// Comentário: Código da instituição bancária.
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
        /// Comentário: 
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
        /// Comentário: Campo utilizado para informar o banco secundário para impressão de boletas.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código de conta para lançamento de despesa bancária.
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
        /// Comentário: Código evento integração folha débito
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
        /// Comentário: Código evento integração folha crédito
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
        /// Propriedade referente ao campo: CODFUNCCAIXA
        /// Comentário: Indica o código funcionário caixa aberto.
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
        /// Comentário: Código layout para utilização na rotina 1521.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Desconsiderar a tarifa bancária para baixa de títulos pagos até o vencimento
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
        /// Comentário: Indica a data abertura do caixa.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Gera 2 DVs para o Banco Safra.
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
        /// Comentário: 
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
        /// Comentário: Gerar aquivo remessa com 444 posições
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
        /// Comentário: Indica que gera contas a receber de custas cartório.
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
        /// Comentário: Indica se gera credito cliente. 
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
        /// Comentário: Código da instituição bancária.
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
        /// Comentário: Gerar xml nfe.
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
        /// Comentário: Parâmetro utilizada para o processo de não geração de títulos para o valor do juros pagos pelo cliente a menor. 
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
        /// Comentário: Indica que não baixará, via cobrança magnética, título pago com juros a menor. 
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
        /// Comentário: 
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
        /// Comentário: Prefixo do arquivo remessa.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o código do layout da custódia usado pelo banco. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o número do convênio para os clientes que utilizam o banco CEF - 240.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto por dia de adiantamento de pagamento.
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
        /// Comentário: Indica o percentual de multa a ser cobrado para operações de boletos agrupados.
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
        /// Comentário: Indica banco aberto ou fechado para o caixa.
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
        /// Comentário: 
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
        /// Comentário: Numerador de nosso número de banco usado para as vendas ECF (PCAUX2075) na emissão de boleto bancário se usado servidor intermediário. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica a quantidade máxima de horas para fechamento de caixa.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Tipo da composição do valor pago para o Banrisul.
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
        /// Comentário: Campo utilizado para informar se a filial utiliza ou não banco secundário.
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
        /// Comentário: [S] = Indica que o valor da tarifa bancária é individual para cada banco, parametrizado na rotina 524. [N] = Indica que o valor da tarifa bancário é único, parametrizado na rotina 132. 
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
        /// Comentário: Se utiliza baixa de cartão ou não.
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
        /// Comentário: Indica se utiliza fechamento de caixa.
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
        /// Comentário: Determinar o valor máximo do juros que não será cobrado do cliente, quando o parâmetro INCDUPJUROSDESD ='S'. 
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
        /// Comentário: Indica o valor mínimo do título para envio à protesto.
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
        /// Comentário: Indica se este banco é para o varejo ou não.
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
        /// Comentário: 
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
        /// Comentário: Valor máximo para pagamento de contas a pagar.
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
        /// Comentário: Valor da tarifa bancária individual do banco. 
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBanco> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBanco>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
