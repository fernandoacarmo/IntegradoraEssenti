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
    /// Classe referente a tabela PCMovciap
    /// </summary>
    [XmlType("PCMOVCIAP")]
    public class PCMovciap : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSEXT
        /// Comentário: Aliquota externa.
        /// </summary>
        private decimal aliqicmsext;
        [XmlElement(ElementName = "ALIQICMSEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Aliqicmsext
        {
            get { return  aliqicmsext; }
            set {  aliqicmsext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSINT
        /// Comentário: Aliquota Interna.
        /// </summary>
        private decimal aliqicmsint;
        [XmlElement(ElementName = "ALIQICMSINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Aliqicmsint
        {
            get { return  aliqicmsint; }
            set {  aliqicmsint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1
        /// Comentário: Alíquota de ICMS Interna.
        /// </summary>
        private decimal aliqicms1;
        [XmlElement(ElementName = "ALIQICMS1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms1
        {
            get { return  aliqicms1; }
            set {  aliqicms1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2
        /// Comentário: Alíquota de ICMS Externa.
        /// </summary>
        private decimal aliqicms2;
        [XmlElement(ElementName = "ALIQICMS2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms2
        {
            get { return  aliqicms2; }
            set {  aliqicms2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICPERCIVAPAUTA
        /// Comentário: Aplica IVA sob pauta
        /// </summary>
        private string aplicpercivapauta;
        [XmlElement(ElementName = "APLICPERCIVAPAUTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicpercivapauta
        {
            get { return  aplicpercivapauta; }
            set {  aplicpercivapauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICREDBASEIVAPLIQ
        /// Comentário: Aplica redução IVA sob pliquido
        /// </summary>
        private string aplicredbaseivapliq;
        [XmlElement(ElementName = "APLICREDBASEIVAPLIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicredbaseivapliq
        {
            get { return  aplicredbaseivapliq; }
            set {  aplicredbaseivapliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMS
        /// Comentário: Base do ICMS.
        /// </summary>
        private decimal baseicms;
        [XmlElement(ElementName = "BASEICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicms
        {
            get { return  baseicms; }
            set {  baseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICST
        /// Comentário: Valor Base de Substituição de Tributação.
        /// </summary>
        private decimal baseicst;
        [XmlElement(ElementName = "BASEICST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicst
        {
            get { return  baseicst; }
            set {  baseicst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do Cliente.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial.
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
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: CFOP do item.
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código fornecedor.
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
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: Código Funcionário.
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
        /// Propriedade referente ao campo: CODOPER
        /// Comentário: Códio da operação.
        /// </summary>
        private string codoper;
        [XmlElement(ElementName = "CODOPER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codoper
        {
            get { return  codoper; }
            set {  codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODIMOPRI
        /// Comentário: Código de produto do bem imobilizado principal.
        /// </summary>
        private decimal codprodimopri;
        [XmlElement(ElementName = "CODPRODIMOPRI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodimopri
        {
            get { return  codprodimopri; }
            set {  codprodimopri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBIPI
        /// Comentário: Situação Tributária do IPI
        /// </summary>
        private decimal codsittribipi;
        [XmlElement(ElementName = "CODSITTRIBIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribipi
        {
            get { return  codsittribipi; }
            set {  codsittribipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINS
        /// Comentário: Cód. Sit. Trib. Pis/Cofins.
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
        /// Propriedade referente ao campo: CUSTOCONT
        /// Comentário: Custo Contábil.
        /// </summary>
        private decimal custocont;
        [XmlElement(ElementName = "CUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocont
        {
            get { return  custocont; }
            set {  custocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Comentário: Custo Financeiro.
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Comentário: Custo Real.
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALSEMST
        /// Comentário: Custo Real sem ST.
        /// </summary>
        private decimal custorealsemst;
        [XmlElement(ElementName = "CUSTOREALSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealsemst
        {
            get { return  custorealsemst; }
            set {  custorealsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREP
        /// Comentário: Custo de Reposição.
        /// </summary>
        private decimal custorep;
        [XmlElement(ElementName = "CUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorep
        {
            get { return  custorep; }
            set {  custorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPANT
        /// Comentário: Custo Reposição Anterior.
        /// </summary>
        private decimal custorepant;
        [XmlElement(ElementName = "CUSTOREPANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorepant
        {
            get { return  custorepant; }
            set {  custorepant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATABAIXA
        /// Comentário: Indica a data da baixa.
        /// </summary>
        private DateTime? databaixa;
        [XmlElement(ElementName = "DATABAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Databaixa
        {
            get { return  databaixa; }
            set {  databaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCCOMPLEMENTAR
        /// Comentário: Descrição complementar para entrada do bem.
        /// </summary>
        private string desccomplementar;
        [XmlElement(ElementName = "DESCCOMPLEMENTAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1500)]
        public string Desccomplementar
        {
            get { return  desccomplementar; }
            set {  desccomplementar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data de cancelamento
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
        /// Propriedade referente ao campo: DTMOV
        /// Comentário: Data da movimentação
        /// </summary>
        private DateTime? dtmov;
        [XmlElement(ElementName = "DTMOV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmov
        {
            get { return  dtmov; }
            set {  dtmov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERADOCONTASPAGAR
        /// Comentário: Gerado contas a pagar para NF.
        /// </summary>
        private string geradocontaspagar;
        [XmlElement(ElementName = "GERADOCONTASPAGAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geradocontaspagar
        {
            get { return  geradocontaspagar; }
            set {  geradocontaspagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAICMSLIVROFISCAL
        /// Comentário: Gera ICMS no Livro Fiscal.
        /// </summary>
        private string geraicmslivrofiscal;
        [XmlElement(ElementName = "GERAICMSLIVROFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraicmslivrofiscal
        {
            get { return  geraicmslivrofiscal; }
            set {  geraicmslivrofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVA
        /// Comentário: Percentual IVA.
        /// </summary>
        private decimal iva;
        [XmlElement(ElementName = "IVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Iva
        {
            get { return  iva; }
            set {  iva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LEASING
        /// Comentário: Determina se o bem foi adiquirido via operação de leasing
        /// </summary>
        private string leasing;
        [XmlElement(ElementName = "LEASING", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Leasing
        {
            get { return  leasing; }
            set {  leasing = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODBCICMS
        /// Comentário: Modalidade de Redução da Base de Cálculo do ST
        /// </summary>
        private string modbcicms;
        [XmlElement(ElementName = "MODBCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Modbcicms
        {
            get { return  modbcicms; }
            set {  modbcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTDESICMS
        /// Comentário: Motivo da Desoneração do ICMS
        /// </summary>
        private string motdesicms;
        [XmlElement(ElementName = "MOTDESICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Motdesicms
        {
            get { return  motdesicms; }
            set {  motdesicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NCM
        /// Comentário: Nomenclatura Comum do Mercosul
        /// </summary>
        private string ncm;
        [XmlElement(ElementName = "NCM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ncm
        {
            get { return  ncm; }
            set {  ncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Número da Nota Fiscal.
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
        /// Propriedade referente ao campo: NUMPATRIMONIO
        /// Comentário: Indica o número do patrimônio.
        /// </summary>
        private string numpatrimonio;
        [XmlElement(ElementName = "NUMPATRIMONIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numpatrimonio
        {
            get { return  numpatrimonio; }
            set {  numpatrimonio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Número do pedido
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
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Sequência
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQPED
        /// Comentário: Sequência do pedido
        /// </summary>
        private decimal numseqped;
        [XmlElement(ElementName = "NUMSEQPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseqped
        {
            get { return  numseqped; }
            set {  numseqped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: Numero de transação.
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
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Indica o númerro transação de venda.
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
        /// Propriedade referente ao campo: PAUTA
        /// Comentário: Valor de Pauta.
        /// </summary>
        private decimal pauta;
        [XmlElement(ElementName = "PAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pauta
        {
            get { return  pauta; }
            set {  pauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERED
        /// Comentário: Percentual de Base de Redução.
        /// </summary>
        private decimal percbasered;
        [XmlElement(ElementName = "PERCBASERED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbasered
        {
            get { return  percbasered; }
            set {  percbasered = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDST
        /// Comentário: Percentual de Redução do ST
        /// </summary>
        private decimal percbaseredst;
        [XmlElement(ElementName = "PERCBASEREDST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredst
        {
            get { return  percbaseredst; }
            set {  percbaseredst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCREDICMPRESUMIDO
        /// Comentário: Alíquota ICMS presumido
        /// </summary>
        private decimal perccredicmpresumido;
        [XmlElement(ElementName = "PERCCREDICMPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perccredicmpresumido
        {
            get { return  perccredicmpresumido; }
            set {  perccredicmpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: Percentual de desconto
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPDENTRONF
        /// Comentário: Alíquota de outras despesas
        /// </summary>
        private decimal percdespdentronf;
        [XmlElement(ElementName = "PERCDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespdentronf
        {
            get { return  percdespdentronf; }
            set {  percdespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE
        /// Comentário: Percentual do Frete.
        /// </summary>
        private decimal percfrete;
        [XmlElement(ElementName = "PERCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete
        {
            get { return  percfrete; }
            set {  percfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Comentário: Alíquota de ICMS
        /// </summary>
        private decimal percicm;
        [XmlElement(ElementName = "PERCICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicm
        {
            get { return  percicm; }
            set {  percicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMRED
        /// Comentário: Alíquota de redução ICMS
        /// </summary>
        private decimal percicmred;
        [XmlElement(ElementName = "PERCICMRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmred
        {
            get { return  percicmred; }
            set {  percicmred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSSIMPLESNAC
        /// Comentário: Percentual de ICMS Simples Nacional
        /// </summary>
        private decimal percicmssimplesnac;
        [XmlElement(ElementName = "PERCICMSSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percicmssimplesnac
        {
            get { return  percicmssimplesnac; }
            set {  percicmssimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI
        /// Comentário: Percentual de IPI
        /// </summary>
        private decimal percipi;
        [XmlElement(ElementName = "PERCIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percipi
        {
            get { return  percipi; }
            set {  percipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVA
        /// Comentário: Alíquota de IVA
        /// </summary>
        private decimal perciva;
        [XmlElement(ElementName = "PERCIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perciva
        {
            get { return  perciva; }
            set {  perciva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Comentário: Percentual Cofins.
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTRASDESP
        /// Comentário: Percentual Outras Despesas.
        /// </summary>
        private decimal percoutrasdesp;
        [XmlElement(ElementName = "PERCOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percoutrasdesp
        {
            get { return  percoutrasdesp; }
            set {  percoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDICMS
        /// Comentário: Alíquota de Créd. ICMS
        /// </summary>
        private decimal percredicms;
        [XmlElement(ElementName = "PERCREDICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percredicms
        {
            get { return  percredicms; }
            set {  percredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSEGURO
        /// Comentário: Alíquota de seguro
        /// </summary>
        private decimal percseguro;
        [XmlElement(ElementName = "PERCSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percseguro
        {
            get { return  percseguro; }
            set {  percseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCST
        /// Comentário: Percentual de ST
        /// </summary>
        private decimal percst;
        [XmlElement(ElementName = "PERCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percst
        {
            get { return  percst; }
            set {  percst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSUFRAMA
        /// Comentário: Percentual Suframa.
        /// </summary>
        private decimal percsuframa;
        [XmlElement(ElementName = "PERCSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percsuframa
        {
            get { return  percsuframa; }
            set {  percsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Comentário: Percentual Pis.
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISCOFINSRETIDO
        /// Comentário: Pis/Cofins retido
        /// </summary>
        private string piscofinsretido;
        [XmlElement(ElementName = "PISCOFINSRETIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Piscofinsretido
        {
            get { return  piscofinsretido; }
            set {  piscofinsretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLIQUIDO
        /// Comentário: Preço liquido
        /// </summary>
        private decimal pliquido;
        [XmlElement(ElementName = "PLIQUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pliquido
        {
            get { return  pliquido; }
            set {  pliquido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: Preço de tabela do produto.
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNITCONT
        /// Comentário: Indica o valor unitário. 
        /// </summary>
        private decimal punitcont;
        [XmlElement(ElementName = "PUNITCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punitcont
        {
            get { return  punitcont; }
            set {  punitcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBAIXADOS
        /// Comentário: Quantidade de itens dos Bens Patrimoniais Baixada
        /// </summary>
        private decimal qtbaixados;
        [XmlElement(ElementName = "QTBAIXADOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtbaixados
        {
            get { return  qtbaixados; }
            set {  qtbaixados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONT
        /// Comentário: Indica a quantidade. 
        /// </summary>
        private decimal qtcont;
        [XmlElement(ElementName = "QTCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtcont
        {
            get { return  qtcont; }
            set {  qtcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDTRANSFERIDA
        /// Comentário: Quantidade transferida do bem.
        /// </summary>
        private decimal qtdtransferida;
        [XmlElement(ElementName = "QTDTRANSFERIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdtransferida
        {
            get { return  qtdtransferida; }
            set {  qtdtransferida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMESESCREDCIAP
        /// Comentário: Qtd. Meses para aproveitamento do crédito CIAP.
        /// </summary>
        private decimal qtmesescredciap;
        [XmlElement(ElementName = "QTMESESCREDCIAP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtmesescredciap
        {
            get { return  qtmesescredciap; }
            set {  qtmesescredciap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXT
        /// Comentário: Redução da alíquota externa
        /// </summary>
        private decimal redbasealiqext;
        [XmlElement(ElementName = "REDBASEALIQEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Redbasealiqext
        {
            get { return  redbasealiqext; }
            set {  redbasealiqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVA
        /// Comentário: Redução de IVA
        /// </summary>
        private decimal redbaseiva;
        [XmlElement(ElementName = "REDBASEIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Redbaseiva
        {
            get { return  redbaseiva; }
            set {  redbaseiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Comentário: Rotina cadastro
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
        /// Propriedade referente ao campo: SEQUENCIA
        /// Comentário: Sequencia de individualização
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Comentário: Situação tributária.
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Comentário: Substituição Tributária.
        /// </summary>
        private decimal st;
        [XmlElement(ElementName = "ST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal St
        {
            get { return  st; }
            set {  st = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXADEPRECIACAO
        /// Comentário: Indica a taxa de depreciação.
        /// </summary>
        private decimal taxadepreciacao;
        [XmlElement(ElementName = "TAXADEPRECIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Taxadepreciacao
        {
            get { return  taxadepreciacao; }
            set {  taxadepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBAIXA
        /// Comentário: Indica o tipo da baixa.
        /// </summary>
        private string tipobaixa;
        [XmlElement(ElementName = "TIPOBAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipobaixa
        {
            get { return  tipobaixa; }
            set {  tipobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCST
        /// Comentário: Tipo do calculo do ST
        /// </summary>
        private string tipocalcst;
        [XmlElement(ElementName = "TIPOCALCST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalcst
        {
            get { return  tipocalcst; }
            set {  tipocalcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMERC
        /// Comentário: Tipo de mercadoria do CIAP
        /// </summary>
        private string tipomerc;
        [XmlElement(ElementName = "TIPOMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomerc
        {
            get { return  tipomerc; }
            set {  tipomerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOVBEM
        /// Comentário: Tipo de movimentação do bem.
        /// </summary>
        private string tipomovbem;
        [XmlElement(ElementName = "TIPOMOVBEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomovbem
        {
            get { return  tipomovbem; }
            set {  tipomovbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONALBCST
        /// Comentário: Valor adicional na base do ST
        /// </summary>
        private decimal vladicionalbcst;
        [XmlElement(ElementName = "VLADICIONALBCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vladicionalbcst
        {
            get { return  vladicionalbcst; }
            set {  vladicionalbcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPI
        /// Comentário: Valor base do IPI.
        /// </summary>
        private decimal vlbaseipi;
        [XmlElement(ElementName = "VLBASEIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlbaseipi
        {
            get { return  vlbaseipi; }
            set {  vlbaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEPISCOFINS
        /// Comentário: Valor base Pis/Cofins.
        /// </summary>
        private decimal vlbasepiscofins;
        [XmlElement(ElementName = "VLBASEPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlbasepiscofins
        {
            get { return  vlbasepiscofins; }
            set {  vlbasepiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Comentário: Valor Cofins.
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
        /// Propriedade referente ao campo: VLCREDCOFINS
        /// Comentário: Valor Cofins
        /// </summary>
        private decimal vlcredcofins;
        [XmlElement(ElementName = "VLCREDCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredcofins
        {
            get { return  vlcredcofins; }
            set {  vlcredcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDICMS
        /// Comentário: Valor de Créd. ICMS
        /// </summary>
        private decimal vlcredicms;
        [XmlElement(ElementName = "VLCREDICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredicms
        {
            get { return  vlcredicms; }
            set {  vlcredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDITO
        /// Comentário: Valor de Crédito.
        /// </summary>
        private decimal vlcredito;
        [XmlElement(ElementName = "VLCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcredito
        {
            get { return  vlcredito; }
            set {  vlcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPIS
        /// Comentário: Valor Pis
        /// </summary>
        private decimal vlcredpis;
        [XmlElement(ElementName = "VLCREDPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpis
        {
            get { return  vlcredpis; }
            set {  vlcredpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPRESUMIDO
        /// Comentário: Valor ICMS presumido
        /// </summary>
        private decimal vlcredpresumido;
        [XmlElement(ElementName = "VLCREDPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcredpresumido
        {
            get { return  vlcredpresumido; }
            set {  vlcredpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Comentário: Indica o valor do desconto do item. 
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPDENTRONF
        /// Comentário: Valor de outras despesas
        /// </summary>
        private decimal vldespdentronf;
        [XmlElement(ElementName = "VLDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespdentronf
        {
            get { return  vldespdentronf; }
            set {  vldespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFALIQUOTA
        /// Comentário: Valor do Dif. De aliquota
        /// </summary>
        private decimal vldifaliquota;
        [XmlElement(ElementName = "VLDIFALIQUOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vldifaliquota
        {
            get { return  vldifaliquota; }
            set {  vldifaliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: Valor do Frete.
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Comentário: Valor do ICMS do Produto
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: Valor do IPI do patrimônio.
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLITEM
        /// Comentário: Valor do item.
        /// </summary>
        private decimal vlitem;
        [XmlElement(ElementName = "VLITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlitem
        {
            get { return  vlitem; }
            set {  vlitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Comentário: Valor Outras Despesas.
        /// </summary>
        private decimal vloutrasdesp;
        [XmlElement(ElementName = "VLOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutrasdesp
        {
            get { return  vloutrasdesp; }
            set {  vloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMS
        /// Comentário: Pauta de ICMS
        /// </summary>
        private decimal vlpautaicms;
        [XmlElement(ElementName = "VLPAUTAICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautaicms
        {
            get { return  vlpautaicms; }
            set {  vlpautaicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAIPI
        /// Comentário: Pauta de IPI
        /// </summary>
        private decimal vlpautaipi;
        [XmlElement(ElementName = "VLPAUTAIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautaipi
        {
            get { return  vlpautaipi; }
            set {  vlpautaipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAPISCOFINS
        /// Comentário: Pauta Pis/Cofins
        /// </summary>
        private decimal vlpautapiscofins;
        [XmlElement(ElementName = "VLPAUTAPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpautapiscofins
        {
            get { return  vlpautapiscofins; }
            set {  vlpautapiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Comentário: Valor Pis.
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
        /// Propriedade referente ao campo: VLRATUALBEM
        /// Comentário: Indica o valor atual do bem.
        /// </summary>
        private decimal vlratualbem;
        [XmlElement(ElementName = "VLRATUALBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlratualbem
        {
            get { return  vlratualbem; }
            set {  vlratualbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECIAR
        /// Comentário: Valor a depreciar do bem
        /// </summary>
        private decimal vlrdepreciar;
        [XmlElement(ElementName = "VLRDEPRECIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlrdepreciar
        {
            get { return  vlrdepreciar; }
            set {  vlrdepreciar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Comentário: Valor seguro do item da NF.
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
        /// Propriedade referente ao campo: VLST
        /// Comentário: Valor de Substituição de Tributação.
        /// </summary>
        private decimal vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlst
        {
            get { return  vlst; }
            set {  vlst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUFRAMA
        /// Comentário: Valor Suframa.
        /// </summary>
        private decimal vlsuframa;
        [XmlElement(ElementName = "VLSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsuframa
        {
            get { return  vlsuframa; }
            set {  vlsuframa = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMovciap()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVCIAP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovciap> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovciap>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMovciap> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovciap>(where);
        }

        #endregion
    }
}
