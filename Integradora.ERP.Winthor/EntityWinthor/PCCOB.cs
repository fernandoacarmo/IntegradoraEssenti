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
    /// Classe referente a tabela PCCob
    /// </summary>
    [XmlType("PCCOB")]
    public class PCCob : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACERTOAUTOCXMOT
        /// Coment�rio: 
        /// </summary>
        private string acertoautocxmot;
        [XmlElement(ElementName = "ACERTOAUTOCXMOT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Acertoautocxmot
        {
            get { return  acertoautocxmot; }
            set {  acertoautocxmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOUTRO
        /// Coment�rio: Recebe o c�digo de cobran�a.
        /// </summary>
        private string codoutro;
        [XmlElement(ElementName = "CODOUTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 4)]
        public string Codoutro
        {
            get { return codoutro; }
            set { codoutro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTENTICARACERTOCX402
        /// Coment�rio: Autentica��o mec�nica no acerto de carga .
        /// </summary>
        private string autenticaracertocx402;
        [XmlElement(ElementName = "AUTENTICARACERTOCX402", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autenticaracertocx402
        {
            get { return  autenticaracertocx402; }
            set {  autenticaracertocx402 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXACXBANCO
        /// Coment�rio: 
        /// </summary>
        private string baixacxbanco;
        [XmlElement(ElementName = "BAIXACXBANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixacxbanco
        {
            get { return  baixacxbanco; }
            set {  baixacxbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQAUTOMATICO
        /// Coment�rio: 
        /// </summary>
        private string bloqautomatico;
        [XmlElement(ElementName = "BLOQAUTOMATICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqautomatico
        {
            get { return  bloqautomatico; }
            set {  bloqautomatico = value; }
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
        /// Propriedade referente ao campo: CALCJUROSCOBRANCA
        /// Coment�rio: Utilizar taxa cadastrada na cobran�a
        /// </summary>
        private string calcjuroscobranca;
        [XmlElement(ElementName = "CALCJUROSCOBRANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcjuroscobranca
        {
            get { return  calcjuroscobranca; }
            set {  calcjuroscobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAO
        /// Coment�rio: 
        /// </summary>
        private string cartao;
        [XmlElement(ElementName = "CARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cartao
        {
            get { return  cartao; }
            set {  cartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRANCA
        /// Coment�rio: 
        /// </summary>
        private string cobranca;
        [XmlElement(ElementName = "COBRANCA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,30)]
        public string Cobranca
        {
            get { return  cobranca; }
            set {  cobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRANCABROKER
        /// Coment�rio: 
        /// </summary>
        private string cobrancabroker;
        [XmlElement(ElementName = "COBRANCABROKER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cobrancabroker
        {
            get { return  cobrancabroker; }
            set {  cobrancabroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRANCAEMTRANSITO
        /// Coment�rio: Utilizado para valida��o do pedido no momento do acerto realizado.
        /// </summary>
        private string cobrancaemtransito;
        [XmlElement(ElementName = "COBRANCAEMTRANSITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cobrancaemtransito
        {
            get { return  cobrancaemtransito; }
            set {  cobrancaemtransito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCOTARIFA
        /// Coment�rio: C�digo do Banco associado a cobran�a no qual ser� utilizado o valor da tarifa banc�ria. 
        /// </summary>
        private decimal codbancotarifa;
        [XmlElement(ElementName = "CODBANCOTARIFA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbancotarifa
        {
            get { return  codbancotarifa; }
            set {  codbancotarifa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANDEIRA
        /// Coment�rio: C�digo da Bandeira do Sitef.
        /// </summary>
        private decimal codbandeira;
        [XmlElement(ElementName = "CODBANDEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codbandeira
        {
            get { return  codbandeira; }
            set {  codbandeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLICC
        /// Coment�rio: 
        /// </summary>
        private decimal codclicc;
        [XmlElement(ElementName = "CODCLICC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclicc
        {
            get { return  codclicc; }
            set {  codclicc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBCC
        /// Coment�rio: 
        /// </summary>
        private string codcobcc;
        [XmlElement(ElementName = "CODCOBCC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobcc
        {
            get { return  codcobcc; }
            set {  codcobcc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBCHDESC
        /// Coment�rio: C�digo de Cobran�a desconto de cheque.
        /// </summary>
        private string codcobchdesc;
        [XmlElement(ElementName = "CODCOBCHDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobchdesc
        {
            get { return  codcobchdesc; }
            set {  codcobchdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBDEVCHDESC
        /// Coment�rio: C�digo de Cobran�a devolu��o desconto de cheque.
        /// </summary>
        private string codcobdevchdesc;
        [XmlElement(ElementName = "CODCOBDEVCHDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobdevchdesc
        {
            get { return  codcobdevchdesc; }
            set {  codcobdevchdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACC
        /// Coment�rio: 
        /// </summary>
        private decimal codcontacc;
        [XmlElement(ElementName = "CODCONTACC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacc
        {
            get { return  codcontacc; }
            set {  codcontacc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODECF
        /// Coment�rio: 
        /// </summary>
        private string codecf;
        [XmlElement(ElementName = "CODECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codecf
        {
            get { return  codecf; }
            set {  codecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica qual filial a cobran�a poder� ser usada. � opcional, logo, se estiver vazio, pode ser utilizado em todas as filiais. 
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
        /// Propriedade referente ao campo: CODIGOBANDEIRA
        /// Coment�rio: C�digo da bandeira do cart�o de cr�dito para cobran�a
        /// </summary>
        private string codigobandeira;
        [XmlElement(ElementName = "CODIGOBANDEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codigobandeira
        {
            get { return  codigobandeira; }
            set {  codigobandeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDA
        /// Coment�rio: 
        /// </summary>
        private string codmoeda;
        [XmlElement(ElementName = "CODMOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codmoeda
        {
            get { return  codmoeda; }
            set {  codmoeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERADORACARTAO
        /// Coment�rio: Campo para armazenar o c�digo da operadora de cart�o associada � cobran�a.
        /// </summary>
        private string codoperadoracartao;
        [XmlElement(ElementName = "CODOPERADORACARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codoperadoracartao
        {
            get { return  codoperadoracartao; }
            set {  codoperadoracartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARANAOPROTESTO
        /// Coment�rio: Indica o c�digo para n�o protesto.
        /// </summary>
        private string codparanaoprotesto;
        [XmlElement(ElementName = "CODPARANAOPROTESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codparanaoprotesto
        {
            get { return  codparanaoprotesto; }
            set {  codparanaoprotesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARAPROTESTO
        /// Coment�rio: 
        /// </summary>
        private string codparaprotesto;
        [XmlElement(ElementName = "CODPARAPROTESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codparaprotesto
        {
            get { return  codparaprotesto; }
            set {  codparaprotesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDE
        /// Coment�rio: C�digo de rede
        /// </summary>
        private decimal codrede;
        [XmlElement(ElementName = "CODREDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrede
        {
            get { return  codrede; }
            set {  codrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAFLUXOCX
        /// Coment�rio: 
        /// </summary>
        private decimal colunafluxocx;
        [XmlElement(ElementName = "COLUNAFLUXOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Colunafluxocx
        {
            get { return  colunafluxocx; }
            set {  colunafluxocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONVENIO
        /// Coment�rio: Verificar se a empresa e conveniada.
        /// </summary>
        private string convenio;
        [XmlElement(ElementName = "CONVENIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Convenio
        {
            get { return  convenio; }
            set {  convenio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTODIA
        /// Coment�rio: 
        /// </summary>
        private string custodia;
        [XmlElement(ElementName = "CUSTODIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Custodia
        {
            get { return  custodia; }
            set {  custodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPOSITOBANCARIO
        /// Coment�rio: Indica se a cobran�a � relativa a Dep�sito Banc�rio. Caso positivo, no desdobramento das rotinas 1210 e 402, ser� obrigat�rio informar (Banco, Ag�ncia, Conta), seguindo o mesmo conceito de Cheques.
        /// </summary>
        private string depositobancario;
        [XmlElement(ElementName = "DEPOSITOBANCARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Depositobancario
        {
            get { return  depositobancario; }
            set {  depositobancario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASCARENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal diascarencia;
        [XmlElement(ElementName = "DIASCARENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Diascarencia
        {
            get { return  diascarencia; }
            set {  diascarencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIACOBRANCAFV
        /// Coment�rio: 
        /// </summary>
        private string enviacobrancafv;
        [XmlElement(ElementName = "ENVIACOBRANCAFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviacobrancafv
        {
            get { return  enviacobrancafv; }
            set {  enviacobrancafv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIOPARAPROTESTO
        /// Coment�rio: 
        /// </summary>
        private string envioparaprotesto;
        [XmlElement(ElementName = "ENVIOPARAPROTESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Envioparaprotesto
        {
            get { return  envioparaprotesto; }
            set {  envioparaprotesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRBK
        /// Coment�rio: 
        /// </summary>
        private string exibirbk;
        [XmlElement(ElementName = "EXIBIRBK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibirbk
        {
            get { return  exibirbk; }
            set {  exibirbk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRCXMOT
        /// Coment�rio: 
        /// </summary>
        private string exibircxmot;
        [XmlElement(ElementName = "EXIBIRCXMOT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibircxmot
        {
            get { return  exibircxmot; }
            set {  exibircxmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTARECF
        /// Coment�rio: Indica se a cobran�a � exporta para o Auto-Servi�o. Ser� usado na rotina PCAUX2075.
        /// </summary>
        private string exportarecf;
        [XmlElement(ElementName = "EXPORTARECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportarecf
        {
            get { return  exportarecf; }
            set {  exportarecf = value; }
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
        /// Propriedade referente ao campo: LETRACOB
        /// Coment�rio: 
        /// </summary>
        private string letracob;
        [XmlElement(ElementName = "LETRACOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Letracob
        {
            get { return  letracob; }
            set {  letracob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MXDIASINAD
        /// Coment�rio: 
        /// </summary>
        private decimal mxdiasinad;
        [XmlElement(ElementName = "MXDIASINAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Mxdiasinad
        {
            get { return  mxdiasinad; }
            set {  mxdiasinad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MXINAD
        /// Coment�rio: 
        /// </summary>
        private decimal mxinad;
        [XmlElement(ElementName = "MXINAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Mxinad
        {
            get { return  mxinad; }
            set {  mxinad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVELVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal nivelvenda;
        [XmlElement(ElementName = "NIVELVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Nivelvenda
        {
            get { return  nivelvenda; }
            set {  nivelvenda = value; }
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
        /// Propriedade referente ao campo: NUMDIASBLOQAUTOMATIC
        /// Coment�rio: 
        /// </summary>
        private decimal numdiasbloqautomatic;
        [XmlElement(ElementName = "NUMDIASBLOQAUTOMATIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasbloqautomatic
        {
            get { return  numdiasbloqautomatic; }
            set {  numdiasbloqautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASLIBERACAOCREDITO
        /// Coment�rio: 
        /// </summary>
        private decimal numdiasliberacaocredito;
        [XmlElement(ElementName = "NUMDIASLIBERACAOCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numdiasliberacaocredito
        {
            get { return  numdiasliberacaocredito; }
            set {  numdiasliberacaocredito = value; }
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
        /// Propriedade referente ao campo: NUMDIASVENCFLUXOCX
        /// Coment�rio: 
        /// </summary>
        private decimal numdiasvencfluxocx;
        [XmlElement(ElementName = "NUMDIASVENCFLUXOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numdiasvencfluxocx
        {
            get { return  numdiasvencfluxocx; }
            set {  numdiasvencfluxocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMAXPARCELAS
        /// Coment�rio: Indica o n�mero maximo de parcelas.
        /// </summary>
        private decimal nummaxparcelas;
        [XmlElement(ElementName = "NUMMAXPARCELAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Nummaxparcelas
        {
            get { return  nummaxparcelas; }
            set {  nummaxparcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Coment�rio: 
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASCPADICIONAL
        /// Coment�rio: Indica o n�meros de vias para cupons de convenio e entrega.
        /// </summary>
        private string numviascpadicional;
        [XmlElement(ElementName = "NUMVIASCPADICIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Numviascpadicional
        {
            get { return  numviascpadicional; }
            set {  numviascpadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSNF
        /// Coment�rio: 
        /// </summary>
        private string obsnf;
        [XmlElement(ElementName = "OBSNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obsnf
        {
            get { return  obsnf; }
            set {  obsnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGCOMISSAO
        /// Coment�rio: 
        /// </summary>
        private string pagcomissao;
        [XmlElement(ElementName = "PAGCOMISSAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Pagcomissao
        {
            get { return  pagcomissao; }
            set {  pagcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal percacresvenda;
        [XmlElement(ElementName = "PERCACRESVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percacresvenda
        {
            get { return  percacresvenda; }
            set {  percacresvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Coment�rio: 
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOT
        /// Coment�rio: Percentual de Comiss�o da Cobran�a para Motorista. Ser�o verificadas as cobran�as existentes nos carregamento do Motorista, e aplicado este percentual sobre o valor dos t�tulos da cobran�a
        /// </summary>
        private decimal percommot;
        [XmlElement(ElementName = "PERCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percommot
        {
            get { return  percommot; }
            set {  percommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTXADMINCC
        /// Coment�rio: 
        /// </summary>
        private decimal perctxadmincc;
        [XmlElement(ElementName = "PERCTXADMINCC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perctxadmincc
        {
            get { return  perctxadmincc; }
            set {  perctxadmincc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTCOBDESD
        /// Coment�rio: 
        /// </summary>
        private string permitealtcobdesd;
        [XmlElement(ElementName = "PERMITEALTCOBDESD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealtcobdesd
        {
            get { return  permitealtcobdesd; }
            set {  permitealtcobdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEBAIXAMANUAL
        /// Coment�rio: Indica se retringe ou permite a baixa manual por cobran�a.
        /// </summary>
        private string permitebaixamanual;
        [XmlElement(ElementName = "PERMITEBAIXAMANUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitebaixamanual
        {
            get { return  permitebaixamanual; }
            set {  permitebaixamanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITECONTRAVALE
        /// Coment�rio: PERMITE CONTRA VALE
        /// </summary>
        private string permitecontravale;
        [XmlElement(ElementName = "PERMITECONTRAVALE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitecontravale
        {
            get { return  permitecontravale; }
            set {  permitecontravale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEDESCDEVCLI
        /// Coment�rio: 
        /// </summary>
        private string permitedescdevcli;
        [XmlElement(ElementName = "PERMITEDESCDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitedescdevcli
        {
            get { return  permitedescdevcli; }
            set {  permitedescdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOCC
        /// Coment�rio: 
        /// </summary>
        private decimal prazocc;
        [XmlElement(ElementName = "PRAZOCC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazocc
        {
            get { return  prazocc; }
            set {  prazocc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXIMOVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal prazomaximovenda;
        [XmlElement(ElementName = "PRAZOMAXIMOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomaximovenda
        {
            get { return  prazomaximovenda; }
            set {  prazomaximovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECARGACELULAR
        /// Coment�rio: Restringir a recarga de celular
        /// </summary>
        private string recargacelular;
        [XmlElement(ElementName = "RECARGACELULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Recargacelular
        {
            get { return  recargacelular; }
            set {  recargacelular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SELECIONACLIENTEECF
        /// Coment�rio: Permite sele��o de cliente para cobran�a.
        /// </summary>
        private string selecionaclienteecf;
        [XmlElement(ElementName = "SELECIONACLIENTEECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Selecionaclienteecf
        {
            get { return  selecionaclienteecf; }
            set {  selecionaclienteecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMATARIFABANCDUPLIC
        /// Coment�rio: Indica se a se a taxa de boleto da cobran�a banc�ria ser� somada ao Contas a Receber (PCPREST). 
        /// </summary>
        private string somatarifabancduplic;
        [XmlElement(ElementName = "SOMATARIFABANCDUPLIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somatarifabancduplic
        {
            get { return  somatarifabancduplic; }
            set {  somatarifabancduplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMATARIFABANCNF
        /// Coment�rio: Indica se a se a taxa de boleto da cobran�a banc�ria ser� somada ao Cabe�alho da Nota Fiscal (PCNFSAID). 
        /// </summary>
        private string somatarifabancnf;
        [XmlElement(ElementName = "SOMATARIFABANCNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somatarifabancnf
        {
            get { return  somatarifabancnf; }
            set {  somatarifabancnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOMISSAO
        /// Coment�rio: Indica qual o tipo de comiss�o da cobran�a usado na apura��o, que podem ser: [V] Vendas (1249, 1266), [L] Liquidez (1248) ou [A] Ambas (1248, 1249, 1266). 
        /// </summary>
        private string tipocomissao;
        [XmlElement(ElementName = "TIPOCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocomissao
        {
            get { return  tipocomissao; }
            set {  tipocomissao = value; }
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
        /// Propriedade referente ao campo: TIPOPAGTOECF
        /// Coment�rio: Indica o tipo de pagamento.
        /// </summary>
        private string tipopagtoecf;
        [XmlElement(ElementName = "TIPOPAGTOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopagtoecf
        {
            get { return  tipopagtoecf; }
            set {  tipopagtoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXJUROS
        /// Coment�rio: 
        /// </summary>
        private decimal txjuros;
        [XmlElement(ElementName = "TXJUROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Txjuros
        {
            get { return  txjuros; }
            set {  txjuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACHDESC
        /// Coment�rio: Utiliza Cobran�a desconto de cheque.
        /// </summary>
        private string utilizachdesc;
        [XmlElement(ElementName = "UTILIZACHDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizachdesc
        {
            get { return  utilizachdesc; }
            set {  utilizachdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDALIMCREDECF
        /// Coment�rio: 
        /// </summary>
        private string validalimcredecf;
        [XmlElement(ElementName = "VALIDALIMCREDECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validalimcredecf
        {
            get { return  validalimcredecf; }
            set {  validalimcredecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINPEDIDO
        /// Coment�rio: Valor minimo de venda permitido para a cobran�a. 
        /// </summary>
        private decimal vlminpedido;
        [XmlElement(ElementName = "VLMINPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlminpedido
        {
            get { return  vlminpedido; }
            set {  vlminpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTARIFA
        /// Coment�rio: 
        /// </summary>
        private decimal vltarifa;
        [XmlElement(ElementName = "VLTARIFA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vltarifa
        {
            get { return  vltarifa; }
            set {  vltarifa = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCob()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOB";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCob> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCob>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCob> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCob>(where);
        }

        #endregion
    }
}
