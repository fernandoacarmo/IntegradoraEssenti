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
    /// Classe referente a tabela PCLancpreent
    /// </summary>
    [XmlType("PCLANCPREENT")]
    public class PCLancpreent : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ADIANTAMENTO
        /// Comentário: Campo para identificar se o lançamento de contas a pagar é proveniente de um adiantamento - (Rotina 745).
        /// </summary>
        private string adiantamento;
        [XmlElement(ElementName = "ADIANTAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Adiantamento
        {
            get { return  adiantamento; }
            set {  adiantamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Comentário: 
        /// </summary>
        private string assinatura;
        [XmlElement(ElementName = "ASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Assinatura
        {
            get { return  assinatura; }
            set {  assinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOMPRADOR
        /// Comentário: 
        /// </summary>
        private decimal codcomprador;
        [XmlElement(ElementName = "CODCOMPRADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcomprador
        {
            get { return  codcomprador; }
            set {  codcomprador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Comentário: 
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECPRINC
        /// Comentário: 
        /// </summary>
        private decimal codfornecprinc;
        [XmlElement(ElementName = "CODFORNECPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfornecprinc
        {
            get { return  codfornecprinc; }
            set {  codfornecprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAUTOR
        /// Comentário: 
        /// </summary>
        private decimal codfuncautor;
        [XmlElement(ElementName = "CODFUNCAUTOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncautor
        {
            get { return  codfuncautor; }
            set {  codfuncautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCBAIXA
        /// Comentário: 
        /// </summary>
        private decimal codfuncbaixa;
        [XmlElement(ElementName = "CODFUNCBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncbaixa
        {
            get { return  codfuncbaixa; }
            set {  codfuncbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCESTORNOBAIXA
        /// Comentário: 
        /// </summary>
        private decimal codfuncestornobaixa;
        [XmlElement(ElementName = "CODFUNCESTORNOBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncestornobaixa
        {
            get { return  codfuncestornobaixa; }
            set {  codfuncestornobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRECLASSIFIC
        /// Comentário: 
        /// </summary>
        private decimal codfuncreclassific;
        [XmlElement(ElementName = "CODFUNCRECLASSIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncreclassific
        {
            get { return  codfuncreclassific; }
            set {  codfuncreclassific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINABAIXA
        /// Comentário: 
        /// </summary>
        private decimal codrotinabaixa;
        [XmlElement(ElementName = "CODROTINABAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotinabaixa
        {
            get { return  codrotinabaixa; }
            set {  codrotinabaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAO
        /// Comentário: 
        /// </summary>
        private decimal cotacao;
        [XmlElement(ElementName = "COTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Cotacao
        {
            get { return  cotacao; }
            set {  cotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAOBAIXA
        /// Comentário: 
        /// </summary>
        private decimal cotacaobaixa;
        [XmlElement(ElementName = "COTACAOBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Cotacaobaixa
        {
            get { return  cotacaobaixa; }
            set {  cotacaobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCONTOCONTRATO
        /// Comentário: 
        /// </summary>
        private decimal descontocontrato;
        [XmlElement(ElementName = "DESCONTOCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Descontocontrato
        {
            get { return  descontocontrato; }
            set {  descontocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCONTOFIN
        /// Comentário: 
        /// </summary>
        private decimal descontofin;
        [XmlElement(ElementName = "DESCONTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Descontofin
        {
            get { return  descontofin; }
            set {  descontofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCONTOFINREAL
        /// Comentário: 
        /// </summary>
        private decimal descontofinreal;
        [XmlElement(ElementName = "DESCONTOFINREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Descontofinreal
        {
            get { return  descontofinreal; }
            set {  descontofinreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCONTOLOGISTICO
        /// Comentário: 
        /// </summary>
        private decimal descontologistico;
        [XmlElement(ElementName = "DESCONTOLOGISTICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Descontologistico
        {
            get { return  descontologistico; }
            set {  descontologistico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTASSINATURA
        /// Comentário: 
        /// </summary>
        private DateTime? dtassinatura;
        [XmlElement(ElementName = "DTASSINATURA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtassinatura
        {
            get { return  dtassinatura; }
            set {  dtassinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAUTOR
        /// Comentário: 
        /// </summary>
        private DateTime? dtautor;
        [XmlElement(ElementName = "DTAUTOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtautor
        {
            get { return  dtautor; }
            set {  dtautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBORDER
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTCHEQ
        /// Comentário: 
        /// </summary>
        private DateTime? dtcheq;
        [XmlElement(ElementName = "DTCHEQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcheq
        {
            get { return  dtcheq; }
            set {  dtcheq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOTACAO
        /// Comentário: Campo para armazenar a data da cotação do pedido de compra.
        /// </summary>
        private DateTime? dtcotacao;
        [XmlElement(ElementName = "DTCOTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcotacao
        {
            get { return  dtcotacao; }
            set {  dtcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNOBAIXA
        /// Comentário: 
        /// </summary>
        private DateTime? dtestornobaixa;
        [XmlElement(ElementName = "DTESTORNOBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestornobaixa
        {
            get { return  dtestornobaixa; }
            set {  dtestornobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMOEDA
        /// Comentário: 
        /// </summary>
        private string dtmoeda;
        [XmlElement(ElementName = "DTMOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dtmoeda
        {
            get { return  dtmoeda; }
            set {  dtmoeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtpagto;
        [XmlElement(ElementName = "DTPAGTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagto
        {
            get { return  dtpagto; }
            set {  dtpagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPRORROG
        /// Comentário: 
        /// </summary>
        private DateTime? dtprorrog;
        [XmlElement(ElementName = "DTPRORROG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprorrog
        {
            get { return  dtprorrog; }
            set {  dtprorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRECLASSIFIC
        /// Comentário: 
        /// </summary>
        private DateTime? dtreclassific;
        [XmlElement(ElementName = "DTRECLASSIFIC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtreclassific
        {
            get { return  dtreclassific; }
            set {  dtreclassific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DUPLIC
        /// Comentário: 
        /// </summary>
        private string duplic;
        [XmlElement(ElementName = "DUPLIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Duplic
        {
            get { return  duplic; }
            set {  duplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVAG
        /// Comentário: 
        /// </summary>
        private string dvag;
        [XmlElement(ElementName = "DVAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Dvag
        {
            get { return  dvag; }
            set {  dvag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal frota_codpraca;
        [XmlElement(ElementName = "FROTA_CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Frota_Codpraca
        {
            get { return  frota_codpraca; }
            set {  frota_codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_CODVEICULO
        /// Comentário: 
        /// </summary>
        private decimal frota_codveiculo;
        [XmlElement(ElementName = "FROTA_CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Frota_Codveiculo
        {
            get { return  frota_codveiculo; }
            set {  frota_codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_COMISSAO
        /// Comentário: 
        /// </summary>
        private decimal frota_comissao;
        [XmlElement(ElementName = "FROTA_COMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Frota_Comissao
        {
            get { return  frota_comissao; }
            set {  frota_comissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_DTABASTECE
        /// Comentário: Dados de Frota: data e horário do abastecimento.
        /// </summary>
        private DateTime? frota_dtabastece;
        [XmlElement(ElementName = "FROTA_DTABASTECE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Frota_Dtabastece
        {
            get { return  frota_dtabastece; }
            set {  frota_dtabastece = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_KMABASTECE
        /// Comentário: Dados de Frota: quilometragem do abastecimento.
        /// </summary>
        private decimal frota_kmabastece;
        [XmlElement(ElementName = "FROTA_KMABASTECE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Frota_Kmabastece
        {
            get { return  frota_kmabastece; }
            set {  frota_kmabastece = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal frota_numcar;
        [XmlElement(ElementName = "FROTA_NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Frota_Numcar
        {
            get { return  frota_numcar; }
            set {  frota_numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_QTLITROS
        /// Comentário: 
        /// </summary>
        private decimal frota_qtlitros;
        [XmlElement(ElementName = "FROTA_QTLITROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Frota_Qtlitros
        {
            get { return  frota_qtlitros; }
            set {  frota_qtlitros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO2
        /// Comentário: 
        /// </summary>
        private string historico2;
        [XmlElement(ElementName = "HISTORICO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Historico2
        {
            get { return  historico2; }
            set {  historico2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICE
        /// Comentário: 
        /// </summary>
        private string indice;
        [XmlElement(ElementName = "INDICE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indice
        {
            get { return  indice; }
            set {  indice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Comentário: 
        /// </summary>
        private string localizacao;
        [XmlElement(ElementName = "LOCALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Localizacao
        {
            get { return  localizacao; }
            set {  localizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDA
        /// Comentário: 
        /// </summary>
        private string moeda;
        [XmlElement(ElementName = "MOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Moeda
        {
            get { return  moeda; }
            set {  moeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDAESTRANGEIRA
        /// Comentário: 
        /// </summary>
        private decimal moedaestrangeira;
        [XmlElement(ElementName = "MOEDAESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Moedaestrangeira
        {
            get { return  moedaestrangeira; }
            set {  moedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NFSERVICO
        /// Comentário: Campo para indicar se o título gerado é referente a uma nota fiscal de serviço.
        /// </summary>
        private string nfservico;
        [XmlElement(ElementName = "NFSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Nfservico
        {
            get { return  nfservico; }
            set {  nfservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEFUNC
        /// Comentário: 
        /// </summary>
        private string nomefunc;
        [XmlElement(ElementName = "NOMEFUNC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomefunc
        {
            get { return  nomefunc; }
            set {  nomefunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGDESTDOC
        /// Comentário: 
        /// </summary>
        private decimal numagdestdoc;
        [XmlElement(ElementName = "NUMAGDESTDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numagdestdoc
        {
            get { return  numagdestdoc; }
            set {  numagdestdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGDESTDOC2
        /// Comentário: 
        /// </summary>
        private decimal numagdestdoc2;
        [XmlElement(ElementName = "NUMAGDESTDOC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numagdestdoc2
        {
            get { return  numagdestdoc2; }
            set {  numagdestdoc2 = value; }
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
        /// Propriedade referente ao campo: NUMBCODESTDOC
        /// Comentário: 
        /// </summary>
        private decimal numbcodestdoc;
        [XmlElement(ElementName = "NUMBCODESTDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numbcodestdoc
        {
            get { return  numbcodestdoc; }
            set {  numbcodestdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBORDERO
        /// Comentário: 
        /// </summary>
        private decimal numbordero;
        [XmlElement(ElementName = "NUMBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numbordero
        {
            get { return  numbordero; }
            set {  numbordero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCDESTDOC
        /// Comentário: 
        /// </summary>
        private decimal numccdestdoc;
        [XmlElement(ElementName = "NUMCCDESTDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numccdestdoc
        {
            get { return  numccdestdoc; }
            set {  numccdestdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Comentário: 
        /// </summary>
        private string numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE2
        /// Comentário: 
        /// </summary>
        private decimal numcheque2;
        [XmlElement(ElementName = "NUMCHEQUE2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcheque2
        {
            get { return  numcheque2; }
            set {  numcheque2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCODBARRA
        /// Comentário: 
        /// </summary>
        private string numcodbarra;
        [XmlElement(ElementName = "NUMCODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Numcodbarra
        {
            get { return  numcodbarra; }
            set {  numcodbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIIMPORTACAO
        /// Comentário: Campo utilizado para armazenar o número do documento de importação.
        /// </summary>
        private string numdiimportacao;
        [XmlElement(ElementName = "NUMDIIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Numdiimportacao
        {
            get { return  numdiimportacao; }
            set {  numdiimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDVDESTDOC
        /// Comentário: 
        /// </summary>
        private string numdvdestdoc;
        [XmlElement(ElementName = "NUMDVDESTDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numdvdestdoc
        {
            get { return  numdvdestdoc; }
            set {  numdvdestdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNEGOCIACAO
        /// Comentário: Indica o número de negociação.
        /// </summary>
        private decimal numnegociacao;
        [XmlElement(ElementName = "NUMNEGOCIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numnegociacao
        {
            get { return  numnegociacao; }
            set {  numnegociacao = value; }
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
        /// Propriedade referente ao campo: NUMNOTADEV
        /// Comentário: 
        /// </summary>
        private decimal numnotadev;
        [XmlElement(ElementName = "NUMNOTADEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotadev
        {
            get { return  numnotadev; }
            set {  numnotadev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQBORDERO
        /// Comentário: 
        /// </summary>
        private decimal numseqbordero;
        [XmlElement(ElementName = "NUMSEQBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqbordero
        {
            get { return  numseqbordero; }
            set {  numseqbordero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTAB
        /// Comentário: 
        /// </summary>
        private decimal numtab;
        [XmlElement(ElementName = "NUMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtab
        {
            get { return  numtab; }
            set {  numtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSADIANTFOR
        /// Comentário: 
        /// </summary>
        private decimal numtransadiantfor;
        [XmlElement(ElementName = "NUMTRANSADIANTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransadiantfor
        {
            get { return  numtransadiantfor; }
            set {  numtransadiantfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
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
        /// Propriedade referente ao campo: NUMVIA
        /// Comentário: 
        /// </summary>
        private decimal numvia;
        [XmlElement(ElementName = "NUMVIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numvia
        {
            get { return  numvia; }
            set {  numvia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASFICHACP
        /// Comentário: 
        /// </summary>
        private decimal numviasfichacp;
        [XmlElement(ElementName = "NUMVIASFICHACP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numviasfichacp
        {
            get { return  numviasfichacp; }
            set {  numviasfichacp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFINREAL
        /// Comentário: 
        /// </summary>
        private decimal percdescfinreal;
        [XmlElement(ElementName = "PERCDESCFINREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Percdescfinreal
        {
            get { return  percdescfinreal; }
            set {  percdescfinreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTADORCHEQUE
        /// Comentário: 
        /// </summary>
        private string portadorcheque;
        [XmlElement(ElementName = "PORTADORCHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Portadorcheque
        {
            get { return  portadorcheque; }
            set {  portadorcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: Ligação com PCPREST.PREST.
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRORROG
        /// Comentário: 
        /// </summary>
        private decimal prorrog;
        [XmlElement(ElementName = "PRORROG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prorrog
        {
            get { return  prorrog; }
            set {  prorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTID
        /// Comentário: 
        /// </summary>
        private decimal quantid;
        [XmlElement(ElementName = "QUANTID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Quantid
        {
            get { return  quantid; }
            set {  quantid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM
        /// Comentário: 
        /// </summary>
        private decimal recnum;
        [XmlElement(ElementName = "RECNUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnum
        {
            get { return  recnum; }
            set {  recnum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUMPRINC
        /// Comentário: 
        /// </summary>
        private decimal recnumprinc;
        [XmlElement(ElementName = "RECNUMPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnumprinc
        {
            get { return  recnumprinc; }
            set {  recnumprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOLANC
        /// Comentário: 
        /// </summary>
        private string tipolanc;
        [XmlElement(ElementName = "TIPOLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipolanc
        {
            get { return  tipolanc; }
            set {  tipolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPAGTO
        /// Comentário: 
        /// </summary>
        private string tipopagto;
        [XmlElement(ElementName = "TIPOPAGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipopagto
        {
            get { return  tipopagto; }
            set {  tipopagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPARCEIRO
        /// Comentário: 
        /// </summary>
        private string tipoparceiro;
        [XmlElement(ElementName = "TIPOPARCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoparceiro
        {
            get { return  tipoparceiro; }
            set {  tipoparceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPREENT
        /// Comentário: 
        /// </summary>
        private string tipopreent;
        [XmlElement(ElementName = "TIPOPREENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopreent
        {
            get { return  tipopreent; }
            set {  tipopreent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXPERM
        /// Comentário: 
        /// </summary>
        private decimal txperm;
        [XmlElement(ElementName = "TXPERM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Txperm
        {
            get { return  txperm; }
            set {  txperm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDEV
        /// Comentário: 
        /// </summary>
        private decimal valordev;
        [XmlElement(ElementName = "VALORDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valordev
        {
            get { return  valordev; }
            set {  valordev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMOEDAESTRANGEIRA
        /// Comentário: Campo para armazenar o valor do lançamento em moeda estrangeira.
        /// </summary>
        private decimal valormoedaestrangeira;
        [XmlElement(ElementName = "VALORMOEDAESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valormoedaestrangeira
        {
            get { return  valormoedaestrangeira; }
            set {  valormoedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILDESCONTOVERBA
        /// Comentário: 
        /// </summary>
        private decimal vildescontoverba;
        [XmlElement(ElementName = "VILDESCONTOVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vildescontoverba
        {
            get { return  vildescontoverba; }
            set {  vildescontoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIRRF
        /// Comentário: 
        /// </summary>
        private decimal vlirrf;
        [XmlElement(ElementName = "VLIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlirrf
        {
            get { return  vlirrf; }
            set {  vlirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEXIVA
        /// Comentário: Valor do IVA
        /// </summary>
        private decimal vlmexiva;
        [XmlElement(ElementName = "VLMEXIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmexiva
        {
            get { return  vlmexiva; }
            set {  vlmexiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSESTSENAT
        /// Comentário: 
        /// </summary>
        private decimal vlsestsenat;
        [XmlElement(ElementName = "VLSESTSENAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlsestsenat
        {
            get { return  vlsestsenat; }
            set {  vlsestsenat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLUNIT
        /// Comentário: 
        /// </summary>
        private decimal vlunit;
        [XmlElement(ElementName = "VLUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlunit
        {
            get { return  vlunit; }
            set {  vlunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VPAGO
        /// Comentário: 
        /// </summary>
        private decimal vpago;
        [XmlElement(ElementName = "VPAGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vpago
        {
            get { return  vpago; }
            set {  vpago = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VPAGOBORDERO
        /// Comentário: 
        /// </summary>
        private decimal vpagobordero;
        [XmlElement(ElementName = "VPAGOBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vpagobordero
        {
            get { return  vpagobordero; }
            set {  vpagobordero = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLancpreent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLANCPREENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLancpreent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLancpreent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLancpreent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLancpreent>(where);
        }

        #endregion
    }
}
