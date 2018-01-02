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
    /// Classe referente a tabela PCTribut
    /// </summary>
    [XmlType("PCTRIBUT")]
    public class PCTribut : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ADGPERACRESTRANSF
        /// Comentário: 
        /// </summary>
        private decimal adgperacrestransf;
        [XmlElement(ElementName = "ADGPERACRESTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Adgperacrestransf
        {
            get { return  adgperacrestransf; }
            set {  adgperacrestransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ADGPERDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal adgperdescfin;
        [XmlElement(ElementName = "ADGPERDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Adgperdescfin
        {
            get { return  adgperdescfin; }
            set {  adgperdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGREGARIPICALCULOST
        /// Comentário: Agregar IPI no cálculo do ST.
        /// </summary>
        private string agregaripicalculost;
        [XmlElement(ElementName = "AGREGARIPICALCULOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregaripicalculost
        {
            get { return  agregaripicalculost; }
            set {  agregaripicalculost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSFECP
        /// Comentário: Aliquota do FECP
        /// </summary>
        private decimal aliqicmsfecp;
        [XmlElement(ElementName = "ALIQICMSFECP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicmsfecp
        {
            get { return  aliqicmsfecp; }
            set {  aliqicmsfecp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSSIMPLESNACIONAL
        /// Comentário: Alíquota de ICMS que será utilizada quando a figura tributária estiver parametrizada para usar alíquota de ICMS Simples Nacional.
        /// </summary>
        private decimal aliqicmssimplesnacional;
        [XmlElement(ElementName = "ALIQICMSSIMPLESNACIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicmssimplesnacional
        {
            get { return  aliqicmssimplesnacional; }
            set {  aliqicmssimplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMSTV9
        /// Comentário: Aliquota de ICMS da venda tipo 9
        /// </summary>
        private decimal aliqicmstv9;
        [XmlElement(ElementName = "ALIQICMSTV9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicmstv9
        {
            get { return  aliqicmstv9; }
            set {  aliqicmstv9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1
        /// Comentário: 
        /// </summary>
        private decimal aliqicms1;
        [XmlElement(ElementName = "ALIQICMS1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1
        {
            get { return  aliqicms1; }
            set {  aliqicms1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1FONTE
        /// Comentário: 
        /// </summary>
        private decimal aliqicms1fonte;
        [XmlElement(ElementName = "ALIQICMS1FONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1fonte
        {
            get { return  aliqicms1fonte; }
            set {  aliqicms1fonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1_MC
        /// Comentário: Aliq. ICMS1  para Material de Consumo
        /// </summary>
        private decimal aliqicms1_mc;
        [XmlElement(ElementName = "ALIQICMS1_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1_Mc
        {
            get { return  aliqicms1_mc; }
            set {  aliqicms1_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1TAB
        /// Comentário: 
        /// </summary>
        private decimal aliqicms1tab;
        [XmlElement(ElementName = "ALIQICMS1TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1tab
        {
            get { return  aliqicms1tab; }
            set {  aliqicms1tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1TRANSF
        /// Comentário: 
        /// </summary>
        private decimal aliqicms1transf;
        [XmlElement(ElementName = "ALIQICMS1TRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1transf
        {
            get { return  aliqicms1transf; }
            set {  aliqicms1transf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2
        /// Comentário: 
        /// </summary>
        private decimal aliqicms2;
        [XmlElement(ElementName = "ALIQICMS2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms2
        {
            get { return  aliqicms2; }
            set {  aliqicms2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2FONTE
        /// Comentário: 
        /// </summary>
        private decimal aliqicms2fonte;
        [XmlElement(ElementName = "ALIQICMS2FONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms2fonte
        {
            get { return  aliqicms2fonte; }
            set {  aliqicms2fonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2_MC
        /// Comentário: Aliq. ICMS2  para Material de Consumo
        /// </summary>
        private decimal aliqicms2_mc;
        [XmlElement(ElementName = "ALIQICMS2_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms2_Mc
        {
            get { return  aliqicms2_mc; }
            set {  aliqicms2_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2TAB
        /// Comentário: 
        /// </summary>
        private decimal aliqicms2tab;
        [XmlElement(ElementName = "ALIQICMS2TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms2tab
        {
            get { return  aliqicms2tab; }
            set {  aliqicms2tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2TRANSF
        /// Comentário: 
        /// </summary>
        private decimal aliqicms2transf;
        [XmlElement(ElementName = "ALIQICMS2TRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms2transf
        {
            get { return  aliqicms2transf; }
            set {  aliqicms2transf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQISS
        /// Comentário: 
        /// </summary>
        private decimal aliqiss;
        [XmlElement(ElementName = "ALIQISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqiss
        {
            get { return  aliqiss; }
            set {  aliqiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQSTSAIDA
        /// Comentário: Alíquota de Substituição Tributária para uso em casos de redução de base de st conforme legilasção estadual, como exemplo legislação do estado de Alagoas.
        /// </summary>
        private decimal aliqstsaida;
        [XmlElement(ElementName = "ALIQSTSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqstsaida
        {
            get { return  aliqstsaida; }
            set {  aliqstsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQSTSAIDAPF
        /// Comentário: Alíquota de Substituição Tributária para pessoa física para uso em casos de redução de base de st conforme legilasção estadual, como exemplo legislação do estado de Alagoas.
        /// </summary>
        private decimal aliqstsaidapf;
        [XmlElement(ElementName = "ALIQSTSAIDAPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqstsaidapf
        {
            get { return  aliqstsaidapf; }
            set {  aliqstsaidapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQSTSIMPLESNACIONAL
        /// Comentário: Alíquota de ST que será utilizada quando a figura tributária estiver parametrizada para usar alíquota de ICMS Simples Nacional.
        /// </summary>
        private decimal aliqstsimplesnacional;
        [XmlElement(ElementName = "ALIQSTSIMPLESNACIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqstsimplesnacional
        {
            get { return  aliqstsimplesnacional; }
            set {  aliqstsimplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTAICMSENTTRANSF
        /// Comentário: Alíquota de ICMS para entrada de mercadoria de transferencia.
        /// </summary>
        private decimal aliquotaicmsenttransf;
        [XmlElement(ElementName = "ALIQUOTAICMSENTTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliquotaicmsenttransf
        {
            get { return  aliquotaicmsenttransf; }
            set {  aliquotaicmsenttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAACRESCPJISENTA
        /// Comentário: 
        /// </summary>
        private string aplicaacrescpjisenta;
        [XmlElement(ElementName = "APLICAACRESCPJISENTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicaacrescpjisenta
        {
            get { return  aplicaacrescpjisenta; }
            set {  aplicaacrescpjisenta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAREDICMSSEMIPIBA
        /// Comentário: Aplicar redução na base de ICMS sem o IPI
        /// </summary>
        private string aplicaredicmssemipiba;
        [XmlElement(ElementName = "APLICAREDICMSSEMIPIBA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicaredicmssemipiba
        {
            get { return  aplicaredicmssemipiba; }
            set {  aplicaredicmssemipiba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Comentário: Código MD-5 
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
        /// Propriedade referente ao campo: BNFNAOCALCULAICMS
        /// Comentário: Não calcular ICMS de item bonificado em mercadoria no pedido de venda (TV1)
        /// </summary>
        private string bnfnaocalculaicms;
        [XmlElement(ElementName = "BNFNAOCALCULAICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bnfnaocalculaicms
        {
            get { return  bnfnaocalculaicms; }
            set {  bnfnaocalculaicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCBASEREDICMSTRANSF
        /// Comentário: 
        /// </summary>
        private string calcbaseredicmstransf;
        [XmlElement(ElementName = "CALCBASEREDICMSTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcbaseredicmstransf
        {
            get { return  calcbaseredicmstransf; }
            set {  calcbaseredicmstransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCBCICMSNF
        /// Comentário: 
        /// </summary>
        private string calcbcicmsnf;
        [XmlElement(ElementName = "CALCBCICMSNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcbcicmsnf
        {
            get { return  calcbcicmsnf; }
            set {  calcbcicmsnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSTTRANSF
        /// Comentário: 
        /// </summary>
        private string calcsttransf;
        [XmlElement(ElementName = "CALCSTTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcsttransf
        {
            get { return  calcsttransf; }
            set {  calcsttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULARICMSSITTRIBUT060
        /// Comentário: Indica se calcula ICMS para sittribut 060.
        /// </summary>
        private string calcularicmssittribut060;
        [XmlElement(ElementName = "CALCULARICMSSITTRIBUT060", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcularicmssittribut060
        {
            get { return  calcularicmssittribut060; }
            set {  calcularicmssittribut060 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODECF
        /// Comentário: 
        /// </summary>
        private string codecf;
        [XmlElement(ElementName = "CODECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codecf
        {
            get { return  codecf; }
            set {  codecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODECFFUNCEP
        /// Comentário: Fundo Nacional para Erradicação da Pobreza.
        /// </summary>
        private string codecffuncep;
        [XmlElement(ElementName = "CODECFFUNCEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codecffuncep
        {
            get { return  codecffuncep; }
            set {  codecffuncep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODECFNRPA
        /// Comentário: Código de tributação do produto que será utilizado em vendas com emissão de cupom fiscal para clientes NRPA.
        /// </summary>
        private string codecfnrpa;
        [XmlElement(ElementName = "CODECFNRPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codecfnrpa
        {
            get { return  codecfnrpa; }
            set {  codecfnrpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODECFREDUZIDO
        /// Comentário: CODECF reduzido para cupom.
        /// </summary>
        private string codecfreduzido;
        [XmlElement(ElementName = "CODECFREDUZIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codecfreduzido
        {
            get { return  codecfreduzido; }
            set {  codecfreduzido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: 
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal codfiscalbonific;
        [XmlElement(ElementName = "CODFISCALBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbonific
        {
            get { return  codfiscalbonific; }
            set {  codfiscalbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBONIFICINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalbonificinter;
        [XmlElement(ElementName = "CODFISCALBONIFICINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbonificinter
        {
            get { return  codfiscalbonificinter; }
            set {  codfiscalbonificinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBONIFICINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscalbonificinternasc;
        [XmlElement(ElementName = "CODFISCALBONIFICINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbonificinternasc
        {
            get { return  codfiscalbonificinternasc; }
            set {  codfiscalbonificinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBROKERDEVENT
        /// Comentário: Indica o CFOP de entrada por devolução no broker.
        /// </summary>
        private decimal codfiscalbrokerdevent;
        [XmlElement(ElementName = "CODFISCALBROKERDEVENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbrokerdevent
        {
            get { return  codfiscalbrokerdevent; }
            set {  codfiscalbrokerdevent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBROKERDEVSAID
        /// Comentário: Indica o CFOP de saída por devolução no broker.
        /// </summary>
        private decimal codfiscalbrokerdevsaid;
        [XmlElement(ElementName = "CODFISCALBROKERDEVSAID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbrokerdevsaid
        {
            get { return  codfiscalbrokerdevsaid; }
            set {  codfiscalbrokerdevsaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBROKERENT
        /// Comentário: Indica o CFOP de entrada do broker.
        /// </summary>
        private decimal codfiscalbrokerent;
        [XmlElement(ElementName = "CODFISCALBROKERENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbrokerent
        {
            get { return  codfiscalbrokerent; }
            set {  codfiscalbrokerent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBROKERSAID
        /// Comentário: Indica o CFOP de saída no broker.
        /// </summary>
        private decimal codfiscalbrokersaid;
        [XmlElement(ElementName = "CODFISCALBROKERSAID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalbrokersaid
        {
            get { return  codfiscalbrokersaid; }
            set {  codfiscalbrokersaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONSIG
        /// Comentário: Indica o código fiscal venda estadual de produtos em consignação.
        /// </summary>
        private decimal codfiscalconsig;
        [XmlElement(ElementName = "CODFISCALCONSIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalconsig
        {
            get { return  codfiscalconsig; }
            set {  codfiscalconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONSIGINTER
        /// Comentário: Indica o código fiscal venda interestadual de produtos em consignação.
        /// </summary>
        private decimal codfiscalconsiginter;
        [XmlElement(ElementName = "CODFISCALCONSIGINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalconsiginter
        {
            get { return  codfiscalconsiginter; }
            set {  codfiscalconsiginter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONSIGINTERNAC
        /// Comentário: Indica o código fiscal venda internacional de produtos em consignação.
        /// </summary>
        private decimal codfiscalconsiginternac;
        [XmlElement(ElementName = "CODFISCALCONSIGINTERNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalconsiginternac
        {
            get { return  codfiscalconsiginternac; }
            set {  codfiscalconsiginternac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONTAORDEM
        /// Comentário: CFOP venda estadual conta e ordem.
        /// </summary>
        private decimal codfiscalcontaordem;
        [XmlElement(ElementName = "CODFISCALCONTAORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalcontaordem
        {
            get { return  codfiscalcontaordem; }
            set {  codfiscalcontaordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONTAORDEMINTER
        /// Comentário: CFOP venda interestadual conta e ordem.
        /// </summary>
        private decimal codfiscalcontaordeminter;
        [XmlElement(ElementName = "CODFISCALCONTAORDEMINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalcontaordeminter
        {
            get { return  codfiscalcontaordeminter; }
            set {  codfiscalcontaordeminter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONTAORDEMSIMPENT
        /// Comentário: CFOP Simples entrega estadual conta e ordem.
        /// </summary>
        private decimal codfiscalcontaordemsimpent;
        [XmlElement(ElementName = "CODFISCALCONTAORDEMSIMPENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalcontaordemsimpent
        {
            get { return  codfiscalcontaordemsimpent; }
            set {  codfiscalcontaordemsimpent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONTAORDEMSIMPENTINTE
        /// Comentário: CFOP Simples entrega interestadual conta e ordem.
        /// </summary>
        private decimal codfiscalcontaordemsimpentinte;
        [XmlElement(ElementName = "CODFISCALCONTAORDEMSIMPENTINTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalcontaordemsimpentinte
        {
            get { return  codfiscalcontaordemsimpentinte; }
            set {  codfiscalcontaordemsimpentinte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLI
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevcli;
        [XmlElement(ElementName = "CODFISCALDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcli
        {
            get { return  codfiscaldevcli; }
            set {  codfiscaldevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevclibonific;
        [XmlElement(ElementName = "CODFISCALDEVCLIBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevclibonific
        {
            get { return  codfiscaldevclibonific; }
            set {  codfiscaldevclibonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIBONIFICINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevclibonificinter;
        [XmlElement(ElementName = "CODFISCALDEVCLIBONIFICINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevclibonificinter
        {
            get { return  codfiscaldevclibonificinter; }
            set {  codfiscaldevclibonificinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIBONINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevcliboninternasc;
        [XmlElement(ElementName = "CODFISCALDEVCLIBONINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcliboninternasc
        {
            get { return  codfiscaldevcliboninternasc; }
            set {  codfiscaldevcliboninternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevcliinter;
        [XmlElement(ElementName = "CODFISCALDEVCLIINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcliinter
        {
            get { return  codfiscaldevcliinter; }
            set {  codfiscaldevcliinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevcliinternasc;
        [XmlElement(ElementName = "CODFISCALDEVCLIINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcliinternasc
        {
            get { return  codfiscaldevcliinternasc; }
            set {  codfiscaldevcliinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIPF
        /// Comentário: Código fiscal devolução cliente pessoa fisica
        /// </summary>
        private decimal codfiscaldevclipf;
        [XmlElement(ElementName = "CODFISCALDEVCLIPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevclipf
        {
            get { return  codfiscaldevclipf; }
            set {  codfiscaldevclipf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIPFINTER
        /// Comentário: Código fiscal devolução cliente pessoa fisica interestadual
        /// </summary>
        private decimal codfiscaldevclipfinter;
        [XmlElement(ElementName = "CODFISCALDEVCLIPFINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevclipfinter
        {
            get { return  codfiscaldevclipfinter; }
            set {  codfiscaldevclipfinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIPFINTERNASC
        /// Comentário: Código fiscal devolução cliente pessoa fisica internacional
        /// </summary>
        private decimal codfiscaldevclipfinternasc;
        [XmlElement(ElementName = "CODFISCALDEVCLIPFINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevclipfinternasc
        {
            get { return  codfiscaldevclipfinternasc; }
            set {  codfiscaldevclipfinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIPROENTINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevcliproentinternasc;
        [XmlElement(ElementName = "CODFISCALDEVCLIPROENTINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcliproentinternasc
        {
            get { return  codfiscaldevcliproentinternasc; }
            set {  codfiscaldevcliproentinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIPRONTAENT
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevcliprontaent;
        [XmlElement(ElementName = "CODFISCALDEVCLIPRONTAENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcliprontaent
        {
            get { return  codfiscaldevcliprontaent; }
            set {  codfiscaldevcliprontaent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCLIPRONTAENTINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevcliprontaentinter;
        [XmlElement(ElementName = "CODFISCALDEVCLIPRONTAENTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcliprontaentinter
        {
            get { return  codfiscaldevcliprontaentinter; }
            set {  codfiscaldevcliprontaentinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCOMODATOEST
        /// Comentário: Campo para armazenar o CFOP de Devolução de Comodato - Estadual
        /// </summary>
        private decimal codfiscaldevcomodatoest;
        [XmlElement(ElementName = "CODFISCALDEVCOMODATOEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcomodatoest
        {
            get { return  codfiscaldevcomodatoest; }
            set {  codfiscaldevcomodatoest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVCOMODATOINTER
        /// Comentário: Campo para armazenar  o CFOP de Devolução  de Comodato -  Interestadual
        /// </summary>
        private decimal codfiscaldevcomodatointer;
        [XmlElement(ElementName = "CODFISCALDEVCOMODATOINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevcomodatointer
        {
            get { return  codfiscaldevcomodatointer; }
            set {  codfiscaldevcomodatointer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVISENTOST
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevisentost;
        [XmlElement(ElementName = "CODFISCALDEVISENTOST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevisentost
        {
            get { return  codfiscaldevisentost; }
            set {  codfiscaldevisentost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVISENTOSTINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevisentostinter;
        [XmlElement(ElementName = "CODFISCALDEVISENTOSTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevisentostinter
        {
            get { return  codfiscaldevisentostinter; }
            set {  codfiscaldevisentostinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVISENTOSTINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevisentostinternasc;
        [XmlElement(ElementName = "CODFISCALDEVISENTOSTINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevisentostinternasc
        {
            get { return  codfiscaldevisentostinternasc; }
            set {  codfiscaldevisentostinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVISEORGAOPUBEST
        /// Comentário: CFOP Devolução Venda c/ Isenção ICMS Órgãos Públicos Estadual
        /// </summary>
        private decimal codfiscaldeviseorgaopubest;
        [XmlElement(ElementName = "CODFISCALDEVISEORGAOPUBEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldeviseorgaopubest
        {
            get { return  codfiscaldeviseorgaopubest; }
            set {  codfiscaldeviseorgaopubest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVISEORGAOPUBINTER
        /// Comentário: CFOP Devolução Venda c/ Isenção ICMS Órgãos Públicos Interstadual
        /// </summary>
        private decimal codfiscaldeviseorgaopubinter;
        [XmlElement(ElementName = "CODFISCALDEVISEORGAOPUBINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldeviseorgaopubinter
        {
            get { return  codfiscaldeviseorgaopubinter; }
            set {  codfiscaldeviseorgaopubinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVMERCCONSIG
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevmercconsig;
        [XmlElement(ElementName = "CODFISCALDEVMERCCONSIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevmercconsig
        {
            get { return  codfiscaldevmercconsig; }
            set {  codfiscaldevmercconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVMERCCONSIGINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevmercconsiginter;
        [XmlElement(ElementName = "CODFISCALDEVMERCCONSIGINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevmercconsiginter
        {
            get { return  codfiscaldevmercconsiginter; }
            set {  codfiscaldevmercconsiginter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVTRANSF
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevtransf;
        [XmlElement(ElementName = "CODFISCALDEVTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevtransf
        {
            get { return  codfiscaldevtransf; }
            set {  codfiscaldevtransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVTRANSFENT
        /// Comentário: Indica CFOP de devolução de transf. dentro do estado
        /// </summary>
        private decimal codfiscaldevtransfent;
        [XmlElement(ElementName = "CODFISCALDEVTRANSFENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevtransfent
        {
            get { return  codfiscaldevtransfent; }
            set {  codfiscaldevtransfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVTRANSFENTINTER
        /// Comentário: Indica CFOP de devolução de transf. interestadual.
        /// </summary>
        private decimal codfiscaldevtransfentinter;
        [XmlElement(ElementName = "CODFISCALDEVTRANSFENTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevtransfentinter
        {
            get { return  codfiscaldevtransfentinter; }
            set {  codfiscaldevtransfentinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVTRANSFINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevtransfinter;
        [XmlElement(ElementName = "CODFISCALDEVTRANSFINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevtransfinter
        {
            get { return  codfiscaldevtransfinter; }
            set {  codfiscaldevtransfinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTBENEFICEST
        /// Comentário: CFOP de Entrada Beneficiamento Estadual.
        /// </summary>
        private decimal codfiscalentbeneficest;
        [XmlElement(ElementName = "CODFISCALENTBENEFICEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentbeneficest
        {
            get { return  codfiscalentbeneficest; }
            set {  codfiscalentbeneficest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTBENEFICINTEREST
        /// Comentário: CFOP de Entrada Beneficiamento Interestadual.
        /// </summary>
        private decimal codfiscalentbeneficinterest;
        [XmlElement(ElementName = "CODFISCALENTBENEFICINTEREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentbeneficinterest
        {
            get { return  codfiscalentbeneficinterest; }
            set {  codfiscalentbeneficinterest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTBENEFINTERNAC
        /// Comentário: CFOP de Entrada Beneficiamento Internancional.
        /// </summary>
        private decimal codfiscalentbenefinternac;
        [XmlElement(ElementName = "CODFISCALENTBENEFINTERNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentbenefinternac
        {
            get { return  codfiscalentbenefinternac; }
            set {  codfiscalentbenefinternac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTDEVTRANSFVIR
        /// Comentário: Código fiscal de entrada de devolução de transferência de filial virtual 
        /// </summary>
        private decimal codfiscalentdevtransfvir;
        [XmlElement(ElementName = "CODFISCALENTDEVTRANSFVIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentdevtransfvir
        {
            get { return  codfiscalentdevtransfvir; }
            set {  codfiscalentdevtransfvir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTDEVTRANSFVIRINTER
        /// Comentário: Código fiscal de entrada de devolução de transferência de filial virtual interestadual
        /// </summary>
        private decimal codfiscalentdevtransfvirinter;
        [XmlElement(ElementName = "CODFISCALENTDEVTRANSFVIRINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentdevtransfvirinter
        {
            get { return  codfiscalentdevtransfvirinter; }
            set {  codfiscalentdevtransfvirinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTDEVTRFFILRET
        /// Comentário: Código fiscal de entrada de devolução de transferência de filial retira.
        /// </summary>
        private decimal codfiscalentdevtrffilret;
        [XmlElement(ElementName = "CODFISCALENTDEVTRFFILRET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalentdevtrffilret
        {
            get { return  codfiscalentdevtrffilret; }
            set {  codfiscalentdevtrffilret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTTRANSFVIR
        /// Comentário: Código fiscal de entrada de transferência de filial virtual
        /// </summary>
        private decimal codfiscalenttransfvir;
        [XmlElement(ElementName = "CODFISCALENTTRANSFVIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalenttransfvir
        {
            get { return  codfiscalenttransfvir; }
            set {  codfiscalenttransfvir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTTRANSFVIRINTER
        /// Comentário: Código fiscal de entrada de transferência de filial virtual interestadual
        /// </summary>
        private decimal codfiscalenttransfvirinter;
        [XmlElement(ElementName = "CODFISCALENTTRANSFVIRINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalenttransfvirinter
        {
            get { return  codfiscalenttransfvirinter; }
            set {  codfiscalenttransfvirinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTTRFFILRET
        /// Comentário: Código fiscal de entrada transferência de filial retira.
        /// </summary>
        private decimal codfiscalenttrffilret;
        [XmlElement(ElementName = "CODFISCALENTTRFFILRET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalenttrffilret
        {
            get { return  codfiscalenttrffilret; }
            set {  codfiscalenttrffilret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTTRFFILRETINTER
        /// Comentário: Código fiscal de entrada transferência de filial retira interestadual.
        /// </summary>
        private decimal codfiscalenttrffilretinter;
        [XmlElement(ElementName = "CODFISCALENTTRFFILRETINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalenttrffilretinter
        {
            get { return  codfiscalenttrffilretinter; }
            set {  codfiscalenttrffilretinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENVCOMODATOEST
        /// Comentário: Campo para armazenar  o CFOP de Envio  de Comodato - Estadual
        /// </summary>
        private decimal codfiscalenvcomodatoest;
        [XmlElement(ElementName = "CODFISCALENVCOMODATOEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalenvcomodatoest
        {
            get { return  codfiscalenvcomodatoest; }
            set {  codfiscalenvcomodatoest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENVCOMODATOINTER
        /// Comentário: Campo para armazenar o CFOP de Envio  de Comodato - Interestadual
        /// </summary>
        private decimal codfiscalenvcomodatointer;
        [XmlElement(ElementName = "CODFISCALENVCOMODATOINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalenvcomodatointer
        {
            get { return  codfiscalenvcomodatointer; }
            set {  codfiscalenvcomodatointer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalinter;
        [XmlElement(ElementName = "CODFISCALINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalinter
        {
            get { return  codfiscalinter; }
            set {  codfiscalinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTER_MC
        /// Comentário: Cod. Fiscal Inter  para Material de Consumo
        /// </summary>
        private decimal codfiscalinter_mc;
        [XmlElement(ElementName = "CODFISCALINTER_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalinter_Mc
        {
            get { return  codfiscalinter_mc; }
            set {  codfiscalinter_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscalinternasc;
        [XmlElement(ElementName = "CODFISCALINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalinternasc
        {
            get { return  codfiscalinternasc; }
            set {  codfiscalinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERNASCPF
        /// Comentário: 
        /// </summary>
        private decimal codfiscalinternascpf;
        [XmlElement(ElementName = "CODFISCALINTERNASCPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalinternascpf
        {
            get { return  codfiscalinternascpf; }
            set {  codfiscalinternascpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERNASCTV9
        /// Comentário: Indica o código fiscal internacional venda TV9.
        /// </summary>
        private decimal codfiscalinternasctv9;
        [XmlElement(ElementName = "CODFISCALINTERNASCTV9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalinternasctv9
        {
            get { return  codfiscalinternasctv9; }
            set {  codfiscalinternasctv9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERPF
        /// Comentário: 
        /// </summary>
        private decimal codfiscalinterpf;
        [XmlElement(ElementName = "CODFISCALINTERPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalinterpf
        {
            get { return  codfiscalinterpf; }
            set {  codfiscalinterpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERTV9
        /// Comentário: Indica o código fiscal interestadual venda TV9.
        /// </summary>
        private decimal codfiscalintertv9;
        [XmlElement(ElementName = "CODFISCALINTERTV9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalintertv9
        {
            get { return  codfiscalintertv9; }
            set {  codfiscalintertv9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALISENTOST
        /// Comentário: 
        /// </summary>
        private decimal codfiscalisentost;
        [XmlElement(ElementName = "CODFISCALISENTOST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalisentost
        {
            get { return  codfiscalisentost; }
            set {  codfiscalisentost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALISENTOSTINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalisentostinter;
        [XmlElement(ElementName = "CODFISCALISENTOSTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalisentostinter
        {
            get { return  codfiscalisentostinter; }
            set {  codfiscalisentostinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALISENTOSTINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscalisentostinternasc;
        [XmlElement(ElementName = "CODFISCALISENTOSTINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalisentostinternasc
        {
            get { return  codfiscalisentostinternasc; }
            set {  codfiscalisentostinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL_MC
        /// Comentário: Cod. Fiscal  para Material de Consumo
        /// </summary>
        private decimal codfiscal_mc;
        [XmlElement(ElementName = "CODFISCAL_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscal_Mc
        {
            get { return  codfiscal_mc; }
            set {  codfiscal_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALMERCCONSIG
        /// Comentário: 
        /// </summary>
        private decimal codfiscalmercconsig;
        [XmlElement(ElementName = "CODFISCALMERCCONSIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalmercconsig
        {
            get { return  codfiscalmercconsig; }
            set {  codfiscalmercconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALMERCCONSIGINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalmercconsiginter;
        [XmlElement(ElementName = "CODFISCALMERCCONSIGINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalmercconsiginter
        {
            get { return  codfiscalmercconsiginter; }
            set {  codfiscalmercconsiginter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALMERCCONSIGINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscalmercconsiginternasc;
        [XmlElement(ElementName = "CODFISCALMERCCONSIGINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalmercconsiginternasc
        {
            get { return  codfiscalmercconsiginternasc; }
            set {  codfiscalmercconsiginternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALPF
        /// Comentário: 
        /// </summary>
        private decimal codfiscalpf;
        [XmlElement(ElementName = "CODFISCALPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalpf
        {
            get { return  codfiscalpf; }
            set {  codfiscalpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALPRONTAENT
        /// Comentário: 
        /// </summary>
        private decimal codfiscalprontaent;
        [XmlElement(ElementName = "CODFISCALPRONTAENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalprontaent
        {
            get { return  codfiscalprontaent; }
            set {  codfiscalprontaent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALPRONTAENTINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalprontaentinter;
        [XmlElement(ElementName = "CODFISCALPRONTAENTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalprontaentinter
        {
            get { return  codfiscalprontaentinter; }
            set {  codfiscalprontaentinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALPRONTAENTINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscalprontaentinternasc;
        [XmlElement(ElementName = "CODFISCALPRONTAENTINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalprontaentinternasc
        {
            get { return  codfiscalprontaentinternasc; }
            set {  codfiscalprontaentinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDBENEFEST
        /// Comentário: CFOP de Saída Beneficiamento Estadual.
        /// </summary>
        private decimal codfiscalsaidbenefest;
        [XmlElement(ElementName = "CODFISCALSAIDBENEFEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaidbenefest
        {
            get { return  codfiscalsaidbenefest; }
            set {  codfiscalsaidbenefest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDBENEFINTEREST
        /// Comentário: CFOP de Saída Beneficiamento Interestadual.
        /// </summary>
        private decimal codfiscalsaidbenefinterest;
        [XmlElement(ElementName = "CODFISCALSAIDBENEFINTEREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaidbenefinterest
        {
            get { return  codfiscalsaidbenefinterest; }
            set {  codfiscalsaidbenefinterest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDBENEFINTERNAC
        /// Comentário: CFOP de Saída Beneficiamento Internacional.
        /// </summary>
        private decimal codfiscalsaidbenefinternac;
        [XmlElement(ElementName = "CODFISCALSAIDBENEFINTERNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaidbenefinternac
        {
            get { return  codfiscalsaidbenefinternac; }
            set {  codfiscalsaidbenefinternac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDDEVTRANSFVIR
        /// Comentário: Código fiscal de saída de devolução de transferência de filial virtual 
        /// </summary>
        private decimal codfiscalsaiddevtransfvir;
        [XmlElement(ElementName = "CODFISCALSAIDDEVTRANSFVIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaiddevtransfvir
        {
            get { return  codfiscalsaiddevtransfvir; }
            set {  codfiscalsaiddevtransfvir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDDEVTRANSFVIRINTER
        /// Comentário: Código fiscal de saída de devolução de transferência de filial virtual interestadual
        /// </summary>
        private decimal codfiscalsaiddevtransfvirinter;
        [XmlElement(ElementName = "CODFISCALSAIDDEVTRANSFVIRINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaiddevtransfvirinter
        {
            get { return  codfiscalsaiddevtransfvirinter; }
            set {  codfiscalsaiddevtransfvirinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDDEVTRFFILRET
        /// Comentário: Código fiscal de saída de devolução de transferência de filial retira.
        /// </summary>
        private decimal codfiscalsaiddevtrffilret;
        [XmlElement(ElementName = "CODFISCALSAIDDEVTRFFILRET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaiddevtrffilret
        {
            get { return  codfiscalsaiddevtrffilret; }
            set {  codfiscalsaiddevtrffilret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDTRANSFVIR
        /// Comentário: Código fiscal de saída transferência de filial virtual
        /// </summary>
        private decimal codfiscalsaidtransfvir;
        [XmlElement(ElementName = "CODFISCALSAIDTRANSFVIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaidtransfvir
        {
            get { return  codfiscalsaidtransfvir; }
            set {  codfiscalsaidtransfvir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDTRANSFVIRINTER
        /// Comentário: Código fiscal de saída de transferência de filial virtual interestadual
        /// </summary>
        private decimal codfiscalsaidtransfvirinter;
        [XmlElement(ElementName = "CODFISCALSAIDTRANSFVIRINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaidtransfvirinter
        {
            get { return  codfiscalsaidtransfvirinter; }
            set {  codfiscalsaidtransfvirinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDTRFFILRET
        /// Comentário: Código fiscal de saída transferência de filial retira.
        /// </summary>
        private decimal codfiscalsaidtrffilret;
        [XmlElement(ElementName = "CODFISCALSAIDTRFFILRET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaidtrffilret
        {
            get { return  codfiscalsaidtrffilret; }
            set {  codfiscalsaidtrffilret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSAIDTRFFILRETINTER
        /// Comentário: Código fiscal de saída transferência de filial retira interestadual.
        /// </summary>
        private decimal codfiscalsaidtrffilretinter;
        [XmlElement(ElementName = "CODFISCALSAIDTRFFILRETINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsaidtrffilretinter
        {
            get { return  codfiscalsaidtrffilretinter; }
            set {  codfiscalsaidtrffilretinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSIMPENTFUT
        /// Comentário: 
        /// </summary>
        private decimal codfiscalsimpentfut;
        [XmlElement(ElementName = "CODFISCALSIMPENTFUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsimpentfut
        {
            get { return  codfiscalsimpentfut; }
            set {  codfiscalsimpentfut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSIMPENTFUTINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalsimpentfutinter;
        [XmlElement(ElementName = "CODFISCALSIMPENTFUTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsimpentfutinter
        {
            get { return  codfiscalsimpentfutinter; }
            set {  codfiscalsimpentfutinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSRESTSR
        /// Comentário: CFOP Simples Remessa Estadual|Código Fiscal de Simples Remessa para Operações Estaduais (dentro do estado).
        /// </summary>
        private decimal codfiscalsrestsr;
        [XmlElement(ElementName = "CODFISCALSRESTSR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsrestsr
        {
            get { return  codfiscalsrestsr; }
            set {  codfiscalsrestsr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSREXT
        /// Comentário: CFOP Simples Remessa Exterior|Código Fiscal de Simples Remessa para Operações no Exterior (fora do país)
        /// </summary>
        private decimal codfiscalsrext;
        [XmlElement(ElementName = "CODFISCALSREXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsrext
        {
            get { return  codfiscalsrext; }
            set {  codfiscalsrext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSRINTE
        /// Comentário: CFOP Simples Remessa Interestadual|Código Fiscal de Simples Remessa para Operações Interestaduais (fora do estado)
        /// </summary>
        private decimal codfiscalsrinte;
        [XmlElement(ElementName = "CODFISCALSRINTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsrinte
        {
            get { return  codfiscalsrinte; }
            set {  codfiscalsrinte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSUFRAMA
        /// Comentário: Código fiscal para clientes suframa ou orgão público
        /// </summary>
        private decimal codfiscalsuframa;
        [XmlElement(ElementName = "CODFISCALSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfiscalsuframa
        {
            get { return  codfiscalsuframa; }
            set {  codfiscalsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSUFRAMAINTER
        /// Comentário: Código Fiscal Suframa interestadual
        /// </summary>
        private decimal codfiscalsuframainter;
        [XmlElement(ElementName = "CODFISCALSUFRAMAINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalsuframainter
        {
            get { return  codfiscalsuframainter; }
            set {  codfiscalsuframainter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSF
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltransf;
        [XmlElement(ElementName = "CODFISCALTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransf
        {
            get { return  codfiscaltransf; }
            set {  codfiscaltransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFENT
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltransfent;
        [XmlElement(ElementName = "CODFISCALTRANSFENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransfent
        {
            get { return  codfiscaltransfent; }
            set {  codfiscaltransfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFENTINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltransfentinter;
        [XmlElement(ElementName = "CODFISCALTRANSFENTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransfentinter
        {
            get { return  codfiscaltransfentinter; }
            set {  codfiscaltransfentinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFF
        /// Comentário: Indica o CFOP de devolução de transf. entre filiais na mesma UF
        /// </summary>
        private decimal codfiscaltransff;
        [XmlElement(ElementName = "CODFISCALTRANSFF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransff
        {
            get { return  codfiscaltransff; }
            set {  codfiscaltransff = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFFINTER
        /// Comentário: Indica o CFOP de devolução de transf. entre filiais em UF diferentes
        /// </summary>
        private decimal codfiscaltransffinter;
        [XmlElement(ElementName = "CODFISCALTRANSFFINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransffinter
        {
            get { return  codfiscaltransffinter; }
            set {  codfiscaltransffinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFFINTERNASC
        /// Comentário: Indica o CFOP de devolução de transf. entre filiais Internacionais
        /// </summary>
        private decimal codfiscaltransffinternasc;
        [XmlElement(ElementName = "CODFISCALTRANSFFINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransffinternasc
        {
            get { return  codfiscaltransffinternasc; }
            set {  codfiscaltransffinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltransfinter;
        [XmlElement(ElementName = "CODFISCALTRANSFINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransfinter
        {
            get { return  codfiscaltransfinter; }
            set {  codfiscaltransfinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltransfinternasc;
        [XmlElement(ElementName = "CODFISCALTRANSFINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransfinternasc
        {
            get { return  codfiscaltransfinternasc; }
            set {  codfiscaltransfinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFSAIDAEST
        /// Comentário: Código fisca de Saída Interestadual.
        /// </summary>
        private decimal codfiscaltransfsaidaest;
        [XmlElement(ElementName = "CODFISCALTRANSFSAIDAEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransfsaidaest
        {
            get { return  codfiscaltransfsaidaest; }
            set {  codfiscaltransfsaidaest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRANSFSAIDAINT
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltransfsaidaint;
        [XmlElement(ElementName = "CODFISCALTRANSFSAIDAINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltransfsaidaint
        {
            get { return  codfiscaltransfsaidaint; }
            set {  codfiscaltransfsaidaint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRIANGULAR
        /// Comentário: Código fiscal venda triangular estadual.
        /// </summary>
        private decimal codfiscaltriangular;
        [XmlElement(ElementName = "CODFISCALTRIANGULAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltriangular
        {
            get { return  codfiscaltriangular; }
            set {  codfiscaltriangular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRIANGULARINTER
        /// Comentário: Código fiscal venda triangular interestadual.
        /// </summary>
        private decimal codfiscaltriangularinter;
        [XmlElement(ElementName = "CODFISCALTRIANGULARINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltriangularinter
        {
            get { return  codfiscaltriangularinter; }
            set {  codfiscaltriangularinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRIANGULARINTERNASC
        /// Comentário: Código fiscal venda triangular internacional.
        /// </summary>
        private decimal codfiscaltriangularinternasc;
        [XmlElement(ElementName = "CODFISCALTRIANGULARINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltriangularinternasc
        {
            get { return  codfiscaltriangularinternasc; }
            set {  codfiscaltriangularinternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRIANGULARINTERNASCPF
        /// Comentário: Cód. Fiscal Triangular Interna Pessoa Fisica.
        /// </summary>
        private decimal codfiscaltriangularinternascpf;
        [XmlElement(ElementName = "CODFISCALTRIANGULARINTERNASCPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltriangularinternascpf
        {
            get { return  codfiscaltriangularinternascpf; }
            set {  codfiscaltriangularinternascpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRIANGULARINTERPF
        /// Comentário: Cód. Fiscal Triangular Interestadual Pessoa Fisica.
        /// </summary>
        private decimal codfiscaltriangularinterpf;
        [XmlElement(ElementName = "CODFISCALTRIANGULARINTERPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltriangularinterpf
        {
            get { return  codfiscaltriangularinterpf; }
            set {  codfiscaltriangularinterpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTRIANGULARPF
        /// Comentário: Cód. Fiscal Triangular Pessoa Fisica.
        /// </summary>
        private decimal codfiscaltriangularpf;
        [XmlElement(ElementName = "CODFISCALTRIANGULARPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltriangularpf
        {
            get { return  codfiscaltriangularpf; }
            set {  codfiscaltriangularpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTROCA
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltroca;
        [XmlElement(ElementName = "CODFISCALTROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltroca
        {
            get { return  codfiscaltroca; }
            set {  codfiscaltroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTROCAINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltrocainter;
        [XmlElement(ElementName = "CODFISCALTROCAINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltrocainter
        {
            get { return  codfiscaltrocainter; }
            set {  codfiscaltrocainter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTROCAINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscaltrocainternasc;
        [XmlElement(ElementName = "CODFISCALTROCAINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltrocainternasc
        {
            get { return  codfiscaltrocainternasc; }
            set {  codfiscaltrocainternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALTV9
        /// Comentário: Indica o código fiscal venda TV9.
        /// </summary>
        private decimal codfiscaltv9;
        [XmlElement(ElementName = "CODFISCALTV9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaltv9
        {
            get { return  codfiscaltv9; }
            set {  codfiscaltv9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENDACONSIG
        /// Comentário: 
        /// </summary>
        private decimal codfiscalvendaconsig;
        [XmlElement(ElementName = "CODFISCALVENDACONSIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfiscalvendaconsig
        {
            get { return  codfiscalvendaconsig; }
            set {  codfiscalvendaconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENDACONSIGINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalvendaconsiginter;
        [XmlElement(ElementName = "CODFISCALVENDACONSIGINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfiscalvendaconsiginter
        {
            get { return  codfiscalvendaconsiginter; }
            set {  codfiscalvendaconsiginter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENDACONSIGINTERNASC
        /// Comentário: 
        /// </summary>
        private decimal codfiscalvendaconsiginternasc;
        [XmlElement(ElementName = "CODFISCALVENDACONSIGINTERNASC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfiscalvendaconsiginternasc
        {
            get { return  codfiscalvendaconsiginternasc; }
            set {  codfiscalvendaconsiginternasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENDAENTFUT
        /// Comentário: 
        /// </summary>
        private decimal codfiscalvendaentfut;
        [XmlElement(ElementName = "CODFISCALVENDAENTFUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalvendaentfut
        {
            get { return  codfiscalvendaentfut; }
            set {  codfiscalvendaentfut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENDAENTFUTINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalvendaentfutinter;
        [XmlElement(ElementName = "CODFISCALVENDAENTFUTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalvendaentfutinter
        {
            get { return  codfiscalvendaentfutinter; }
            set {  codfiscalvendaentfutinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENDAPRONTAENT
        /// Comentário: 
        /// </summary>
        private decimal codfiscalvendaprontaent;
        [XmlElement(ElementName = "CODFISCALVENDAPRONTAENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalvendaprontaent
        {
            get { return  codfiscalvendaprontaent; }
            set {  codfiscalvendaprontaent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENDAPRONTAENTINTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalvendaprontaentinter;
        [XmlElement(ElementName = "CODFISCALVENDAPRONTAENTINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalvendaprontaentinter
        {
            get { return  codfiscalvendaprontaentinter; }
            set {  codfiscalvendaprontaentinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENISEORGAOPUBEST
        /// Comentário: CFOP Venda c/ Isenção ICMS Órgãos Públicos Estadual
        /// </summary>
        private decimal codfiscalveniseorgaopubest;
        [XmlElement(ElementName = "CODFISCALVENISEORGAOPUBEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalveniseorgaopubest
        {
            get { return  codfiscalveniseorgaopubest; }
            set {  codfiscalveniseorgaopubest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALVENISEORGAOPUBINTER
        /// Comentário: CFOP Venda c/ Isenção ICMS Órgãos Públicos Interstadual
        /// </summary>
        private decimal codfiscalveniseorgaopubinter;
        [XmlElement(ElementName = "CODFISCALVENISEORGAOPUBINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalveniseorgaopubinter
        {
            get { return  codfiscalveniseorgaopubinter; }
            set {  codfiscalveniseorgaopubinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCENTDEVTRFFILRETINTER
        /// Comentário: Código fiscal de entrada de devolução de transferência de filial retira interestadual.
        /// </summary>
        private decimal codfiscentdevtrffilretinter;
        [XmlElement(ElementName = "CODFISCENTDEVTRFFILRETINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscentdevtrffilretinter
        {
            get { return  codfiscentdevtrffilretinter; }
            set {  codfiscentdevtrffilretinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCSAIDDEVTRFFILRETINTER
        /// Comentário: Código fiscal de saída de devolução de transferência de filial retira interestadual.
        /// </summary>
        private decimal codfiscsaiddevtrffilretinter;
        [XmlElement(ElementName = "CODFISCSAIDDEVTRFFILRETINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscsaiddevtrffilretinter
        {
            get { return  codfiscsaiddevtrffilretinter; }
            set {  codfiscsaiddevtrffilretinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODICM
        /// Comentário: 
        /// </summary>
        private decimal codicm;
        [XmlElement(ElementName = "CODICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicm
        {
            get { return  codicm; }
            set {  codicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMANTECIPADO
        /// Comentário: 
        /// </summary>
        private decimal codicmantecipado;
        [XmlElement(ElementName = "CODICMANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmantecipado
        {
            get { return  codicmantecipado; }
            set {  codicmantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMCONSUMIDOR
        /// Comentário: 
        /// </summary>
        private decimal codicmconsumidor;
        [XmlElement(ElementName = "CODICMCONSUMIDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmconsumidor
        {
            get { return  codicmconsumidor; }
            set {  codicmconsumidor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICM_MC
        /// Comentário: CODICM para Material de Consumo
        /// </summary>
        private decimal codicm_mc;
        [XmlElement(ElementName = "CODICM_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codicm_Mc
        {
            get { return  codicm_mc; }
            set {  codicm_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMNRPA
        /// Comentário: 
        /// </summary>
        private decimal codicmnrpa;
        [XmlElement(ElementName = "CODICMNRPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmnrpa
        {
            get { return  codicmnrpa; }
            set {  codicmnrpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMPF
        /// Comentário: 
        /// </summary>
        private decimal codicmpf;
        [XmlElement(ElementName = "CODICMPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmpf
        {
            get { return  codicmpf; }
            set {  codicmpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMPRODRURAL
        /// Comentário: 
        /// </summary>
        private decimal codicmprodrural;
        [XmlElement(ElementName = "CODICMPRODRURAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codicmprodrural
        {
            get { return  codicmprodrural; }
            set {  codicmprodrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMSIMPLESNAC
        /// Comentário: Percentual de alíquota de icms.
        /// </summary>
        private decimal codicmsimplesnac;
        [XmlElement(ElementName = "CODICMSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmsimplesnac
        {
            get { return  codicmsimplesnac; }
            set {  codicmsimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMTAB
        /// Comentário: 
        /// </summary>
        private decimal codicmtab;
        [XmlElement(ElementName = "CODICMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtab
        {
            get { return  codicmtab; }
            set {  codicmtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMTABNRPA
        /// Comentário: 
        /// </summary>
        private decimal codicmtabnrpa;
        [XmlElement(ElementName = "CODICMTABNRPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtabnrpa
        {
            get { return  codicmtabnrpa; }
            set {  codicmtabnrpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMTABPF
        /// Comentário: 
        /// </summary>
        private decimal codicmtabpf;
        [XmlElement(ElementName = "CODICMTABPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtabpf
        {
            get { return  codicmtabpf; }
            set {  codicmtabpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMTABTRANSF
        /// Comentário: Percentual de acréscimo ao CMV na transferência
        /// </summary>
        private decimal codicmtabtransf;
        [XmlElement(ElementName = "CODICMTABTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtabtransf
        {
            get { return  codicmtabtransf; }
            set {  codicmtabtransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMTRANSF
        /// Comentário: 
        /// </summary>
        private decimal codicmtransf;
        [XmlElement(ElementName = "CODICMTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtransf
        {
            get { return  codicmtransf; }
            set {  codicmtransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODGNRE
        /// Comentário: CÓDIGO DO PRODUTO PARA GNRE.
        /// </summary>
        private decimal codprodgnre;
        [XmlElement(ElementName = "CODPRODGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodgnre
        {
            get { return  codprodgnre; }
            set {  codprodgnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Comentário: 
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPARARPAUTACOMST
        /// Comentário: Utiliza comparação entre Valor Pauta e Base ST
        /// </summary>
        private string compararpautacomst;
        [XmlElement(ElementName = "COMPARARPAUTACOMST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Compararpautacomst
        {
            get { return  compararpautacomst; }
            set {  compararpautacomst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCICMSREDUZBASEICMS
        /// Comentário: Indica se o percentual de desconto do ICMS reduz a base do ICMS. 
        /// </summary>
        private string descicmsreduzbaseicms;
        [XmlElement(ElementName = "DESCICMSREDUZBASEICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Descicmsreduzbaseicms
        {
            get { return  descicmsreduzbaseicms; }
            set {  descicmsreduzbaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMVIGENCIA
        /// Comentário: Data  final de vigência da figura tributária
        /// </summary>
        private DateTime? dtfimvigencia;
        [XmlElement(ElementName = "DTFIMVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimvigencia
        {
            get { return  dtfimvigencia; }
            set {  dtfimvigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOVIGENCIA
        /// Comentário: Data do inicio de vigência da figura tributária
        /// </summary>
        private DateTime? dtiniciovigencia;
        [XmlElement(ElementName = "DTINICIOVIGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciovigencia
        {
            get { return  dtiniciovigencia; }
            set {  dtiniciovigencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Comentário: 
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
        /// Propriedade referente ao campo: GERACODFISCALENTDEVTRANSFVIR
        /// Comentário: GERACODFISCALENTDEVTRANSFVIR
        /// </summary>
        private string geracodfiscalentdevtransfvir;
        [XmlElement(ElementName = "GERACODFISCALENTDEVTRANSFVIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracodfiscalentdevtransfvir
        {
            get { return  geracodfiscalentdevtransfvir; }
            set {  geracodfiscalentdevtransfvir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACODFISCALENTTRANSFVIR
        /// Comentário: GERACODFISCALENTTRANSFVIR
        /// </summary>
        private string geracodfiscalenttransfvir;
        [XmlElement(ElementName = "GERACODFISCALENTTRANSFVIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracodfiscalenttransfvir
        {
            get { return  geracodfiscalenttransfvir; }
            set {  geracodfiscalenttransfvir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACODFISCALENTTRFFILRET
        /// Comentário: GERACODFISCALENTTRFFILRET
        /// </summary>
        private string geracodfiscalenttrffilret;
        [XmlElement(ElementName = "GERACODFISCALENTTRFFILRET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracodfiscalenttrffilret
        {
            get { return  geracodfiscalenttrffilret; }
            set {  geracodfiscalenttrffilret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACODFISCALSAIDDEVTRANSFVIR
        /// Comentário: GERACODFISCALSAIDDEVTRANSFVIR
        /// </summary>
        private string geracodfiscalsaiddevtransfvir;
        [XmlElement(ElementName = "GERACODFISCALSAIDDEVTRANSFVIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracodfiscalsaiddevtransfvir
        {
            get { return  geracodfiscalsaiddevtransfvir; }
            set {  geracodfiscalsaiddevtransfvir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACODFISCALSAIDTRANSFVIR
        /// Comentário: SITTRIBUTSIMPLESNAC
        /// </summary>
        private string geracodfiscalsaidtransfvir;
        [XmlElement(ElementName = "GERACODFISCALSAIDTRANSFVIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracodfiscalsaidtransfvir
        {
            get { return  geracodfiscalsaidtransfvir; }
            set {  geracodfiscalsaidtransfvir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACODFISCALSAIDTRFFILRET
        /// Comentário: GERACODFISCALSAIDTRFFILRET
        /// </summary>
        private string geracodfiscalsaidtrffilret;
        [XmlElement(ElementName = "GERACODFISCALSAIDTRFFILRET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracodfiscalsaidtrffilret
        {
            get { return  geracodfiscalsaidtrffilret; }
            set {  geracodfiscalsaidtrffilret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACODFISCENTDEVTRFFILRET
        /// Comentário: GERACODFISCENTDEVTRFFILRET
        /// </summary>
        private string geracodfiscentdevtrffilret;
        [XmlElement(ElementName = "GERACODFISCENTDEVTRFFILRET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracodfiscentdevtrffilret
        {
            get { return  geracodfiscentdevtrffilret; }
            set {  geracodfiscentdevtrffilret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACODFISCSAIDDEVTRFFILRET
        /// Comentário: GERACODFISCSAIDDEVTRFFILRET
        /// </summary>
        private string geracodfiscsaiddevtrffilret;
        [XmlElement(ElementName = "GERACODFISCSAIDDEVTRFFILRET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracodfiscsaiddevtrffilret
        {
            get { return  geracodfiscsaiddevtrffilret; }
            set {  geracodfiscsaiddevtrffilret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICEST
        /// Comentário: 
        /// </summary>
        private decimal indicest;
        [XmlElement(ElementName = "INDICEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Indicest
        {
            get { return  indicest; }
            set {  indicest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENCAOICMSORGAOPUB
        /// Comentário: Isenção ICMS Orgão Pub.
        /// </summary>
        private string isencaoicmsorgaopub;
        [XmlElement(ElementName = "ISENCAOICMSORGAOPUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isencaoicmsorgaopub
        {
            get { return  isencaoicmsorgaopub; }
            set {  isencaoicmsorgaopub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENCAOSTORGAOPUB
        /// Comentário: Isenção ICMS/ST Orgão Pub.
        /// </summary>
        private string isencaostorgaopub;
        [XmlElement(ElementName = "ISENCAOSTORGAOPUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isencaostorgaopub
        {
            get { return  isencaostorgaopub; }
            set {  isencaostorgaopub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTAICMSBONIFIC
        /// Comentário: Isenta ICMS das bonificações(TV5) estaduais
        /// </summary>
        private string isentaicmsbonific;
        [XmlElement(ElementName = "ISENTAICMSBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentaicmsbonific
        {
            get { return  isentaicmsbonific; }
            set {  isentaicmsbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTNUMEMPENHO
        /// Comentário: Isenção de ICMS somente com número de empenho
        /// </summary>
        private string isentnumempenho;
        [XmlElement(ElementName = "ISENTNUMEMPENHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentnumempenho
        {
            get { return  isentnumempenho; }
            set {  isentnumempenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVA
        /// Comentário: 
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
        /// Propriedade referente ao campo: IVAFONTE
        /// Comentário: 
        /// </summary>
        private decimal ivafonte;
        [XmlElement(ElementName = "IVAFONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ivafonte
        {
            get { return  ivafonte; }
            set {  ivafonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVA_MC
        /// Comentário: %IVA  para Material de Consumo
        /// </summary>
        private decimal iva_mc;
        [XmlElement(ElementName = "IVA_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Iva_Mc
        {
            get { return  iva_mc; }
            set {  iva_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVATAB
        /// Comentário: 
        /// </summary>
        private decimal ivatab;
        [XmlElement(ElementName = "IVATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ivatab
        {
            get { return  ivatab; }
            set {  ivatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVATRANSF
        /// Comentário: 
        /// </summary>
        private decimal ivatransf;
        [XmlElement(ElementName = "IVATRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ivatransf
        {
            get { return  ivatransf; }
            set {  ivatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM
        /// Comentário: 
        /// </summary>
        private string mensagem;
        [XmlElement(ElementName = "MENSAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Mensagem
        {
            get { return  mensagem; }
            set {  mensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEMNRPA
        /// Comentário: Mensagem de vendas para clientes com regime especial NRPA. 
        /// </summary>
        private string mensagemnrpa;
        [XmlElement(ElementName = "MENSAGEMNRPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Mensagemnrpa
        {
            get { return  mensagemnrpa; }
            set {  mensagemnrpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM2
        /// Comentário: Descrição detalhada da figurada tributária.
        /// </summary>
        private string mensagem2;
        [XmlElement(ElementName = "MENSAGEM2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Mensagem2
        {
            get { return  mensagem2; }
            set {  mensagem2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOSTRARPVENDASEMIPI
        /// Comentário: Mostrar Preço de Venda Sem IPI.
        /// </summary>
        private string mostrarpvendasemipi;
        [XmlElement(ElementName = "MOSTRARPVENDASEMIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mostrarpvendasemipi
        {
            get { return  mostrarpvendasemipi; }
            set {  mostrarpvendasemipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOSTRARPVENDASEMST
        /// Comentário: Mostrar o Preço de Venda sem ICMS Substituição.|. 
        /// </summary>
        private string mostrarpvendasemst;
        [XmlElement(ElementName = "MOSTRARPVENDASEMST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mostrarpvendasemst
        {
            get { return  mostrarpvendasemst; }
            set {  mostrarpvendasemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQATU
        /// Comentário: 
        /// </summary>
        private decimal numseqatu;
        [XmlElement(ElementName = "NUMSEQATU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Numseqatu
        {
            get { return  numseqatu; }
            set {  numseqatu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
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
        /// Propriedade referente ao campo: OBS_INFORMATIVO
        /// Comentário: Observação informativo.
        /// </summary>
        private string obs_informativo;
        [XmlElement(ElementName = "OBS_INFORMATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Obs_Informativo
        {
            get { return  obs_informativo; }
            set {  obs_informativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSISEORGAOPUB1
        /// Comentário: Mensagem 1 Isenção ICMS Órgão Público
        /// </summary>
        private string obsiseorgaopub1;
        [XmlElement(ElementName = "OBSISEORGAOPUB1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obsiseorgaopub1
        {
            get { return  obsiseorgaopub1; }
            set {  obsiseorgaopub1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSISEORGAOPUB2
        /// Comentário: Mensagem 2 Isenção ICMS Órgão Público
        /// </summary>
        private string obsiseorgaopub2;
        [XmlElement(ElementName = "OBSISEORGAOPUB2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obsiseorgaopub2
        {
            get { return  obsiseorgaopub2; }
            set {  obsiseorgaopub2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSPF
        /// Comentário: 
        /// </summary>
        private string obspf;
        [XmlElement(ElementName = "OBSPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obspf
        {
            get { return  obspf; }
            set {  obspf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSPF2
        /// Comentário: 
        /// </summary>
        private string obspf2;
        [XmlElement(ElementName = "OBSPF2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obspf2
        {
            get { return  obspf2; }
            set {  obspf2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSSIMPLES
        /// Comentário: Observação simples nacional.
        /// </summary>
        private string obssimples;
        [XmlElement(ElementName = "OBSSIMPLES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obssimples
        {
            get { return  obssimples; }
            set {  obssimples = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSSUFRAMA
        /// Comentário: Observação cliente suframa. 
        /// </summary>
        private string obssuframa;
        [XmlElement(ElementName = "OBSSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obssuframa
        {
            get { return  obssuframa; }
            set {  obssuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSTRANSF
        /// Comentário: 
        /// </summary>
        private string obstransf;
        [XmlElement(ElementName = "OBSTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obstransf
        {
            get { return  obstransf; }
            set {  obstransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSTRIBUT_GNRE
        /// Comentário: Indica a observação GNRE.
        /// </summary>
        private string obstribut_gnre;
        [XmlElement(ElementName = "OBSTRIBUT_GNRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obstribut_Gnre
        {
            get { return  obstribut_gnre; }
            set {  obstribut_gnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
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
        /// Propriedade referente ao campo: PAGTONOMEDESTTRANSF
        /// Comentário: Efetuar pagamento em nome do destinatário
        /// </summary>
        private string pagtonomedesttransf;
        [XmlElement(ElementName = "PAGTONOMEDESTTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtonomedesttransf
        {
            get { return  pagtonomedesttransf; }
            set {  pagtonomedesttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTONOMEDESTTRANSFTAB
        /// Comentário: Efetuar pagamento em nome do destinatário futuro
        /// </summary>
        private string pagtonomedesttransftab;
        [XmlElement(ElementName = "PAGTONOMEDESTTRANSFTAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtonomedesttransftab
        {
            get { return  pagtonomedesttransftab; }
            set {  pagtonomedesttransftab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTONOMEDOCLIENTE
        /// Comentário: Indicação para efetuar pagamento em nome do cliente, quando Tipo Cálculo GNRE é Próprio. 
        /// </summary>
        private string pagtonomedocliente;
        [XmlElement(ElementName = "PAGTONOMEDOCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtonomedocliente
        {
            get { return  pagtonomedocliente; }
            set {  pagtonomedocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTONOMEDOREMETENTE
        /// Comentário: Indica efetuar pagto. no nome do remetente.
        /// </summary>
        private string pagtonomedoremetente;
        [XmlElement(ElementName = "PAGTONOMEDOREMETENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtonomedoremetente
        {
            get { return  pagtonomedoremetente; }
            set {  pagtonomedoremetente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTONOMEREMETTRANSF
        /// Comentário: Efetuar pagmento em nome do remetente
        /// </summary>
        private string pagtonomeremettransf;
        [XmlElement(ElementName = "PAGTONOMEREMETTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtonomeremettransf
        {
            get { return  pagtonomeremettransf; }
            set {  pagtonomeremettransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTONOMEREMETTRANSFTAB
        /// Comentário: Efetuar pagmento em nome do remetente futuro
        /// </summary>
        private string pagtonomeremettransftab;
        [XmlElement(ElementName = "PAGTONOMEREMETTRANSFTAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtonomeremettransftab
        {
            get { return  pagtonomeremettransftab; }
            set {  pagtonomeremettransftab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAUTA
        /// Comentário: 
        /// </summary>
        private decimal pauta;
        [XmlElement(ElementName = "PAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pauta
        {
            get { return  pauta; }
            set {  pauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAUTAFONTE
        /// Comentário: Valor pauta ST Fonte
        /// </summary>
        private decimal pautafonte;
        [XmlElement(ElementName = "PAUTAFONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pautafonte
        {
            get { return  pautafonte; }
            set {  pautafonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAUTA_MC
        /// Comentário: Vl. Pauta  para Material de Consumo
        /// </summary>
        private decimal pauta_mc;
        [XmlElement(ElementName = "PAUTA_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pauta_Mc
        {
            get { return  pauta_mc; }
            set {  pauta_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAUTATAB
        /// Comentário: 
        /// </summary>
        private decimal pautatab;
        [XmlElement(ElementName = "PAUTATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pautatab
        {
            get { return  pautatab; }
            set {  pautatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAUTATRANSF
        /// Comentário: 
        /// </summary>
        private decimal pautatransf;
        [XmlElement(ElementName = "PAUTATRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pautatransf
        {
            get { return  pautatransf; }
            set {  pautatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESCIMOCUSTO
        /// Comentário: Indica o percentual de acréscimo sobre custo.
        /// </summary>
        private decimal peracrescimocusto;
        [XmlElement(ElementName = "PERACRESCIMOCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Peracrescimocusto
        {
            get { return  peracrescimocusto; }
            set {  peracrescimocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESCIMOFUNCEP
        /// Comentário: Indica o percentual de acréscimo FUNCEP.
        /// </summary>
        private decimal peracrescimofuncep;
        [XmlElement(ElementName = "PERACRESCIMOFUNCEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Peracrescimofuncep
        {
            get { return  peracrescimofuncep; }
            set {  peracrescimofuncep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESCIMONRPA
        /// Comentário: 
        /// </summary>
        private decimal peracrescimonrpa;
        [XmlElement(ElementName = "PERACRESCIMONRPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Peracrescimonrpa
        {
            get { return  peracrescimonrpa; }
            set {  peracrescimonrpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESCIMOPF
        /// Comentário: Indica o percentual de acréscimo pessoa física.
        /// </summary>
        private decimal peracrescimopf;
        [XmlElement(ElementName = "PERACRESCIMOPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Peracrescimopf
        {
            get { return  peracrescimopf; }
            set {  peracrescimopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESCISMOPF
        /// Comentário: 
        /// </summary>
        private decimal peracrescismopf;
        [XmlElement(ElementName = "PERACRESCISMOPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Peracrescismopf
        {
            get { return  peracrescismopf; }
            set {  peracrescismopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDNRPA
        /// Comentário: 
        /// </summary>
        private decimal perbaserednrpa;
        [XmlElement(ElementName = "PERBASEREDNRPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaserednrpa
        {
            get { return  perbaserednrpa; }
            set {  perbaserednrpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDSIMPLESNAC
        /// Comentário: Percentual de redução da base de redução de icms para cliente simples nacional.
        /// </summary>
        private decimal perbaseredsimplesnac;
        [XmlElement(ElementName = "PERBASEREDSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredsimplesnac
        {
            get { return  perbaseredsimplesnac; }
            set {  perbaseredsimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDTRANSFENT
        /// Comentário: 
        /// </summary>
        private decimal perbaseredtransfent;
        [XmlElement(ElementName = "PERBASEREDTRANSFENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredtransfent
        {
            get { return  perbaseredtransfent; }
            set {  perbaseredtransfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACREPFVLACIMAPERMITIDO
        /// Comentário: % de acréscimo para pessoa física quando valor total da NF for acima de X reais.
        /// </summary>
        private decimal percacrepfvlacimapermitido;
        [XmlElement(ElementName = "PERCACREPFVLACIMAPERMITIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percacrepfvlacimapermitido
        {
            get { return  percacrepfvlacimapermitido; }
            set {  percacrepfvlacimapermitido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCBASEPFEST
        /// Comentário: 
        /// </summary>
        private decimal percacrescbasepfest;
        [XmlElement(ElementName = "PERCACRESCBASEPFEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percacrescbasepfest
        {
            get { return  percacrescbasepfest; }
            set {  percacrescbasepfest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCBASEPFINT
        /// Comentário: Indica o percentual de acrescimo base de ICMS interestadual pessoa física.
        /// </summary>
        private decimal percacrescbasepfint;
        [XmlElement(ElementName = "PERCACRESCBASEPFINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percacrescbasepfint
        {
            get { return  percacrescbasepfint; }
            set {  percacrescbasepfint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESICMSPF_PI
        /// Comentário: Valor do ICMS substituição do Piauí
        /// </summary>
        private decimal percacresicmspf_pi;
        [XmlElement(ElementName = "PERCACRESICMSPF_PI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percacresicmspf_Pi
        {
            get { return  percacresicmspf_pi; }
            set {  percacresicmspf_pi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAGREGADORST
        /// Comentário: Percentual agregador a ser utilizado no cálculo do ST, porém somente quando o estado de origem do produto(Lote) seja igual ao estado da filial de venda.
        /// </summary>
        private decimal percagregadorst;
        [XmlElement(ElementName = "PERCAGREGADORST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percagregadorst
        {
            get { return  percagregadorst; }
            set {  percagregadorst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASECALCREPASSE
        /// Comentário: Valor do percentual base de cálculo de repasse. 
        /// </summary>
        private decimal percbasecalcrepasse;
        [XmlElement(ElementName = "PERCBASECALCREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbasecalcrepasse
        {
            get { return  percbasecalcrepasse; }
            set {  percbasecalcrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERED
        /// Comentário: 
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
        /// Propriedade referente ao campo: PERCBASEREDADICIONAL
        /// Comentário: Este campo permite informar apenas para impressão nos dados adicionais da nota fiscal, qual seria a redução de base de ICMS, quando usada pauta de ICMS.
        /// </summary>
        private decimal percbaseredadicional;
        [XmlElement(ElementName = "PERCBASEREDADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbaseredadicional
        {
            get { return  percbaseredadicional; }
            set {  percbaseredadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDADICIONALINTER
        /// Comentário: Este campo permite informar apenas para impressão nos dados adicionais da nota fiscal, qual seria a redução de base de ICMS, quando usada pauta de ICMS.
        /// </summary>
        private decimal percbaseredadicionalinter;
        [XmlElement(ElementName = "PERCBASEREDADICIONALINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbaseredadicionalinter
        {
            get { return  percbaseredadicionalinter; }
            set {  percbaseredadicionalinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDCONSUMIDOR
        /// Comentário: 
        /// </summary>
        private decimal percbaseredconsumidor;
        [XmlElement(ElementName = "PERCBASEREDCONSUMIDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredconsumidor
        {
            get { return  percbaseredconsumidor; }
            set {  percbaseredconsumidor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERED_MC
        /// Comentário: %Base Red. para Material de Consumo
        /// </summary>
        private decimal percbasered_mc;
        [XmlElement(ElementName = "PERCBASERED_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbasered_Mc
        {
            get { return  percbasered_mc; }
            set {  percbasered_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDST
        /// Comentário: 
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
        /// Propriedade referente ao campo: PERCBASEREDSTFONTE
        /// Comentário: 
        /// </summary>
        private decimal percbaseredstfonte;
        [XmlElement(ElementName = "PERCBASEREDSTFONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredstfonte
        {
            get { return  percbaseredstfonte; }
            set {  percbaseredstfonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDST_MC
        /// Comentário: %Base Red.ST  para Material de Consumo
        /// </summary>
        private decimal percbaseredst_mc;
        [XmlElement(ElementName = "PERCBASEREDST_MC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredst_Mc
        {
            get { return  percbaseredst_mc; }
            set {  percbaseredst_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDSTTRANSF
        /// Comentário: 
        /// </summary>
        private decimal percbaseredsttransf;
        [XmlElement(ElementName = "PERCBASEREDSTTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredsttransf
        {
            get { return  percbaseredsttransf; }
            set {  percbaseredsttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDTRANFSAID
        /// Comentário: Valor do percentual base de redução do ICMS de transferência de saída. 
        /// </summary>
        private decimal percbaseredtranfsaid;
        [XmlElement(ElementName = "PERCBASEREDTRANFSAID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredtranfsaid
        {
            get { return  percbaseredtranfsaid; }
            set {  percbaseredtranfsaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASESTRJ
        /// Comentário: Percentual de comparação da base do ST para o Decreto 40.016/2006 RJ
        /// </summary>
        private decimal percbasestrj;
        [XmlElement(ElementName = "PERCBASESTRJ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbasestrj
        {
            get { return  percbasestrj; }
            set {  percbasestrj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCCOFINS
        /// Comentário: Indica o % de desconto COFINS.
        /// </summary>
        private decimal percdesccofins;
        [XmlElement(ElementName = "PERCDESCCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdesccofins
        {
            get { return  percdesccofins; }
            set {  percdesccofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCPIS
        /// Comentário: Indica o % de desconto PIS.
        /// </summary>
        private decimal percdescpis;
        [XmlElement(ElementName = "PERCDESCPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescpis
        {
            get { return  percdescpis; }
            set {  percdescpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFALIQUOTAS
        /// Comentário: Percentual de diferença de tributação.
        /// </summary>
        private decimal percdifaliquotas;
        [XmlElement(ElementName = "PERCDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdifaliquotas
        {
            get { return  percdifaliquotas; }
            set {  percdifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFALIQUOTASTAB
        /// Comentário: Indica % diferencial de alíquotas.
        /// </summary>
        private decimal percdifaliquotastab;
        [XmlElement(ElementName = "PERCDIFALIQUOTASTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdifaliquotastab
        {
            get { return  percdifaliquotastab; }
            set {  percdifaliquotastab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSCOMPLEMENTAR
        /// Comentário: % de acréscimo complementar.
        /// </summary>
        private decimal percicmscomplementar;
        [XmlElement(ElementName = "PERCICMSCOMPLEMENTAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percicmscomplementar
        {
            get { return  percicmscomplementar; }
            set {  percicmscomplementar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVAMEX
        /// Comentário: Utilizado no cálculo do IVA (México)
        /// </summary>
        private decimal percivamex;
        [XmlElement(ElementName = "PERCIVAMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percivamex
        {
            get { return  percivamex; }
            set {  percivamex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVAPAUTA
        /// Comentário: Percentual de iva e pauta.
        /// </summary>
        private decimal percivapauta;
        [XmlElement(ElementName = "PERCIVAPAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percivapauta
        {
            get { return  percivapauta; }
            set {  percivapauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDPVENDASIMPLESNAC
        /// Comentário: Percentual de redução preço de venda optante simples nacional.
        /// </summary>
        private decimal percredpvendasimplesnac;
        [XmlElement(ElementName = "PERCREDPVENDASIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percredpvendasimplesnac
        {
            get { return  percredpvendasimplesnac; }
            set {  percredpvendasimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTRIBUTOS
        /// Comentário: PERCENTUAL DE TRIBUTOS.
        /// </summary>
        private decimal perctributos;
        [XmlElement(ElementName = "PERCTRIBUTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perctributos
        {
            get { return  perctributos; }
            set {  perctributos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCUSTO
        /// Comentário: 
        /// </summary>
        private decimal perdesccusto;
        [XmlElement(ElementName = "PERDESCCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdesccusto
        {
            get { return  perdesccusto; }
            set {  perdesccusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCUSTOTRANSF
        /// Comentário: % Desconto custo transferência. 
        /// </summary>
        private decimal perdesccustotransf;
        [XmlElement(ElementName = "PERDESCCUSTOTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdesccustotransf
        {
            get { return  perdesccustotransf; }
            set {  perdesccustotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCICMISENCAO
        /// Comentário: 
        /// </summary>
        private decimal perdescicmisencao;
        [XmlElement(ElementName = "PERDESCICMISENCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdescicmisencao
        {
            get { return  perdescicmisencao; }
            set {  perdescicmisencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCPISSUFRAMA
        /// Comentário: 
        /// </summary>
        private decimal perdescpissuframa;
        [XmlElement(ElementName = "PERDESCPISSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdescpissuframa
        {
            get { return  perdescpissuframa; }
            set {  perdescpissuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCREPASSE
        /// Comentário: 
        /// </summary>
        private decimal perdescrepasse;
        [XmlElement(ElementName = "PERDESCREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdescrepasse
        {
            get { return  perdescrepasse; }
            set {  perdescrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCSUFRAMA
        /// Comentário: 
        /// </summary>
        private decimal perdescsuframa;
        [XmlElement(ElementName = "PERDESCSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdescsuframa
        {
            get { return  perdescsuframa; }
            set {  perdescsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESTAB
        /// Comentário: 
        /// </summary>
        private decimal perdestab;
        [XmlElement(ElementName = "PERDESTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdestab
        {
            get { return  perdestab; }
            set {  perdestab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDIFEREIMENTOICMS
        /// Comentário: Percentual Diferimento Icms.
        /// </summary>
        private decimal perdifereimentoicms;
        [XmlElement(ElementName = "PERDIFEREIMENTOICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdifereimentoicms
        {
            get { return  perdifereimentoicms; }
            set {  perdifereimentoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPAUTAICMS
        /// Comentário: %Pauta ICMS Estadual: Este campo altera a forma de cálculo da base de ICMS estadual para cliente contribuinte (PCCLIENT.CONTRIBUINTE = [S]).
        /// </summary>
        private decimal perpautaicms;
        [XmlElement(ElementName = "PERPAUTAICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perpautaicms
        {
            get { return  perpautaicms; }
            set {  perpautaicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPAUTAICMSINTER
        /// Comentário: Este campo altera a forma de cálculo da base de ICMS interestadual para cliente contribuinte (PCCLIENT.CONTRIBUINTE = [S]).
        /// </summary>
        private decimal perpautaicmsinter;
        [XmlElement(ElementName = "PERPAUTAICMSINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perpautaicmsinter
        {
            get { return  perpautaicmsinter; }
            set {  perpautaicmsinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODTRANSFTRIBRJ
        /// Comentário: Define se é venda de produto de transferência com tributação do RJ.
        /// </summary>
        private string prodtransftribrj;
        [XmlElement(ElementName = "PRODTRANSFTRIBRJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prodtransftribrj
        {
            get { return  prodtransftribrj; }
            set {  prodtransftribrj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDUZBASEICMDECRETOMARANHAO
        /// Comentário: Aplica redução de base de calculo ICMS decreto 20.969/2004 - MA
        /// </summary>
        private string reduzbaseicmdecretomaranhao;
        [XmlElement(ElementName = "REDUZBASEICMDECRETOMARANHAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reduzbaseicmdecretomaranhao
        {
            get { return  reduzbaseicmdecretomaranhao; }
            set {  reduzbaseicmdecretomaranhao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Comentário: 
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
        /// Propriedade referente ao campo: SITTRIBUTBNFTV1
        /// Comentário: Situação tributária de item bonificado em mercadoria no pedido de venda (TV1)
        /// </summary>
        private string sittributbnftv1;
        [XmlElement(ElementName = "SITTRIBUTBNFTV1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributbnftv1
        {
            get { return  sittributbnftv1; }
            set {  sittributbnftv1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTBONIFIC
        /// Comentário: Situação Tributária das bonificações isentas. Utilizado quando a venda for tributada e a bonificação for Isenta
        /// </summary>
        private string sittributbonific;
        [XmlElement(ElementName = "SITTRIBUTBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributbonific
        {
            get { return  sittributbonific; }
            set {  sittributbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTECF
        /// Comentário: Situação Tributária Varejo
        /// </summary>
        private string sittributecf;
        [XmlElement(ElementName = "SITTRIBUTECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributecf
        {
            get { return  sittributecf; }
            set {  sittributecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTISENTOST
        /// Comentário: 
        /// </summary>
        private string sittributisentost;
        [XmlElement(ElementName = "SITTRIBUTISENTOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributisentost
        {
            get { return  sittributisentost; }
            set {  sittributisentost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTISEORGAOPUB
        /// Comentário: CST Isenção ICMS Órgão Público
        /// </summary>
        private string sittributiseorgaopub;
        [XmlElement(ElementName = "SITTRIBUTISEORGAOPUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributiseorgaopub
        {
            get { return  sittributiseorgaopub; }
            set {  sittributiseorgaopub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT_MC
        /// Comentário: Sit. Tribut.  para Material de Consumo
        /// </summary>
        private string sittribut_mc;
        [XmlElement(ElementName = "SITTRIBUT_MC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribut_Mc
        {
            get { return  sittribut_mc; }
            set {  sittribut_mc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTNRPA
        /// Comentário: 
        /// </summary>
        private string sittributnrpa;
        [XmlElement(ElementName = "SITTRIBUTNRPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributnrpa
        {
            get { return  sittributnrpa; }
            set {  sittributnrpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTORGAOPUB
        /// Comentário: Cst para clientes orgão públicos
        /// </summary>
        private string sittributorgaopub;
        [XmlElement(ElementName = "SITTRIBUTORGAOPUB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributorgaopub
        {
            get { return  sittributorgaopub; }
            set {  sittributorgaopub = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTPAUTAICMS
        /// Comentário: CST para pauta de ICMS
        /// </summary>
        private string sittributpautaicms;
        [XmlElement(ElementName = "SITTRIBUTPAUTAICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributpautaicms
        {
            get { return  sittributpautaicms; }
            set {  sittributpautaicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTPAUTAICMSPF
        /// Comentário: Pauta de icmf de pessoa física.
        /// </summary>
        private string sittributpautaicmspf;
        [XmlElement(ElementName = "SITTRIBUTPAUTAICMSPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributpautaicmspf
        {
            get { return  sittributpautaicmspf; }
            set {  sittributpautaicmspf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTPF
        /// Comentário: 
        /// </summary>
        private string sittributpf;
        [XmlElement(ElementName = "SITTRIBUTPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributpf
        {
            get { return  sittributpf; }
            set {  sittributpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTSIMPLESNAC
        /// Comentário: Situação Tributária simples nacional.
        /// </summary>
        private string sittributsimplesnac;
        [XmlElement(ElementName = "SITTRIBUTSIMPLESNAC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributsimplesnac
        {
            get { return  sittributsimplesnac; }
            set {  sittributsimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTSUFRAMA
        /// Comentário: Situação tributaria clientes suframa
        /// </summary>
        private string sittributsuframa;
        [XmlElement(ElementName = "SITTRIBUTSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributsuframa
        {
            get { return  sittributsuframa; }
            set {  sittributsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTTRANSF
        /// Comentário: 
        /// </summary>
        private string sittributtransf;
        [XmlElement(ElementName = "SITTRIBUTTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributtransf
        {
            get { return  sittributtransf; }
            set {  sittributtransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTTRANSFENT
        /// Comentário: 
        /// </summary>
        private string sittributtransfent;
        [XmlElement(ElementName = "SITTRIBUTTRANSFENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Sittributtransfent
        {
            get { return  sittributtransfent; }
            set {  sittributtransfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTTV7
        /// Comentário: Código de situação tributária do tipo de venda 7
        /// </summary>
        private string sittributtv7;
        [XmlElement(ElementName = "SITTRIBUTTV7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributtv7
        {
            get { return  sittributtv7; }
            set {  sittributtv7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTTV8
        /// Comentário: Situação Tributária das vendas Tipo 8
        /// </summary>
        private string sittributtv8;
        [XmlElement(ElementName = "SITTRIBUTTV8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributtv8
        {
            get { return  sittributtv8; }
            set {  sittributtv8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCULOGNRE
        /// Comentário: 
        /// </summary>
        private string tipocalculognre;
        [XmlElement(ElementName = "TIPOCALCULOGNRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalculognre
        {
            get { return  tipocalculognre; }
            set {  tipocalculognre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCULOGNRETAB
        /// Comentário: 
        /// </summary>
        private string tipocalculognretab;
        [XmlElement(ElementName = "TIPOCALCULOGNRETAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalculognretab
        {
            get { return  tipocalculognretab; }
            set {  tipocalculognretab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCULOGNRETRANSF
        /// Comentário: Tipo calculo GNRE transferencias futuro
        /// </summary>
        private string tipocalculognretransf;
        [XmlElement(ElementName = "TIPOCALCULOGNRETRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalculognretransf
        {
            get { return  tipocalculognretransf; }
            set {  tipocalculognretransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCULOGNRETRANSFTAB
        /// Comentário: Tipo calculo GNRE transferencias futuro
        /// </summary>
        private string tipocalculognretransftab;
        [XmlElement(ElementName = "TIPOCALCULOGNRETRANSFTAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalculognretransftab
        {
            get { return  tipocalculognretransftab; }
            set {  tipocalculognretransftab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAALIQICMSSIMPLESNACIONAL
        /// Comentário: Usa alíq icms simples nacional.
        /// </summary>
        private string usaaliqicmssimplesnacional;
        [XmlElement(ElementName = "USAALIQICMSSIMPLESNACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaaliqicmssimplesnacional
        {
            get { return  usaaliqicmssimplesnacional; }
            set {  usaaliqicmssimplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USABASEICMSREDUZIDA
        /// Comentário: Usa base de ICMS reduzida para calcular ST
        /// </summary>
        private string usabaseicmsreduzida;
        [XmlElement(ElementName = "USABASEICMSREDUZIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usabaseicmsreduzida
        {
            get { return  usabaseicmsreduzida; }
            set {  usabaseicmsreduzida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACFOPBNFPARABRINDE
        /// Comentário: Utiliza CFOP de bonificação para brinde.
        /// </summary>
        private string usacfopbnfparabrinde;
        [XmlElement(ElementName = "USACFOPBNFPARABRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacfopbnfparabrinde
        {
            get { return  usacfopbnfparabrinde; }
            set {  usacfopbnfparabrinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAISENCAOICMSVP
        /// Comentário: Usa isenção de ICMS nas vendas a prazo
        /// </summary>
        private string usaisencaoicmsvp;
        [XmlElement(ElementName = "USAISENCAOICMSVP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaisencaoicmsvp
        {
            get { return  usaisencaoicmsvp; }
            set {  usaisencaoicmsvp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPAUTASEMIVA
        /// Comentário: Usa pauta sem iva.
        /// </summary>
        private string usapautasemiva;
        [XmlElement(ElementName = "USAPAUTASEMIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapautasemiva
        {
            get { return  usapautasemiva; }
            set {  usapautasemiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCBASEREDASSOC
        /// Comentário: 
        /// </summary>
        private string usapercbaseredassoc;
        [XmlElement(ElementName = "USAPERCBASEREDASSOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercbaseredassoc
        {
            get { return  usapercbaseredassoc; }
            set {  usapercbaseredassoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCBASEREDDIST
        /// Comentário: 
        /// </summary>
        private string usapercbasereddist;
        [XmlElement(ElementName = "USAPERCBASEREDDIST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercbasereddist
        {
            get { return  usapercbasereddist; }
            set {  usapercbasereddist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCBASEREDFARMA
        /// Comentário: 
        /// </summary>
        private string usapercbaseredfarma;
        [XmlElement(ElementName = "USAPERCBASEREDFARMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercbaseredfarma
        {
            get { return  usapercbaseredfarma; }
            set {  usapercbaseredfarma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCBASEREDHOSP
        /// Comentário: 
        /// </summary>
        private string usapercbaseredhosp;
        [XmlElement(ElementName = "USAPERCBASEREDHOSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercbaseredhosp
        {
            get { return  usapercbaseredhosp; }
            set {  usapercbaseredhosp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCBASEREDMEDICO
        /// Comentário: 
        /// </summary>
        private string usapercbaseredmedico;
        [XmlElement(ElementName = "USAPERCBASEREDMEDICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercbaseredmedico
        {
            get { return  usapercbaseredmedico; }
            set {  usapercbaseredmedico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCBASEREDOPE
        /// Comentário: 
        /// </summary>
        private string usapercbaseredope;
        [XmlElement(ElementName = "USAPERCBASEREDOPE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercbaseredope
        {
            get { return  usapercbaseredope; }
            set {  usapercbaseredope = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCBASEREDOPF
        /// Comentário: 
        /// </summary>
        private string usapercbaseredopf;
        [XmlElement(ElementName = "USAPERCBASEREDOPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercbaseredopf
        {
            get { return  usapercbaseredopf; }
            set {  usapercbaseredopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCBASEREDOPM
        /// Comentário: 
        /// </summary>
        private string usapercbaseredopm;
        [XmlElement(ElementName = "USAPERCBASEREDOPM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercbaseredopm
        {
            get { return  usapercbaseredopm; }
            set {  usapercbaseredopm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPMCBASEST
        /// Comentário: Utilizar PMC (Preço Máximo ao Consumidor) como Base ST (Decreto 47.363)
        /// </summary>
        private string usapmcbasest;
        [XmlElement(ElementName = "USAPMCBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapmcbasest
        {
            get { return  usapmcbasest; }
            set {  usapmcbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAREDBASEICMSFONTEST
        /// Comentário: 
        /// </summary>
        private string usaredbaseicmsfontest;
        [XmlElement(ElementName = "USAREDBASEICMSFONTEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaredbaseicmsfontest
        {
            get { return  usaredbaseicmsfontest; }
            set {  usaredbaseicmsfontest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVALORULTENTBASEST
        /// Comentário: 
        /// </summary>
        private string usavalorultentbasest;
        [XmlElement(ElementName = "USAVALORULTENTBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usavalorultentbasest
        {
            get { return  usavalorultentbasest; }
            set {  usavalorultentbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVALORULTENTBASEST2
        /// Comentário: Usar valor ultima entrada p/ cálculo do ICMS a ser deduzido do valor do ST.
        /// </summary>
        private string usavalorultentbasest2;
        [XmlElement(ElementName = "USAVALORULTENTBASEST2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usavalorultentbasest2
        {
            get { return  usavalorultentbasest2; }
            set {  usavalorultentbasest2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVLULTENTMEDIOBASEST
        /// Comentário: Usa valor da última entrada mês como base de ST
        /// </summary>
        private string usavlultentmediobasest;
        [XmlElement(ElementName = "USAVLULTENTMEDIOBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usavlultentmediobasest
        {
            get { return  usavlultentmediobasest; }
            set {  usavlultentmediobasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPARCADICFECP
        /// Comentário: Utilizar o pagamento  da parcela adicional do FECP(RESOLUÇÃO SEF N.º 6.556/RJ).
        /// </summary>
        private string utilizaparcadicfecp;
        [XmlElement(ElementName = "UTILIZAPARCADICFECP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaparcadicfecp
        {
            get { return  utilizaparcadicfecp; }
            set {  utilizaparcadicfecp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPERCBASEREDPF
        /// Comentário: 
        /// </summary>
        private string utilizapercbaseredpf;
        [XmlElement(ElementName = "UTILIZAPERCBASEREDPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizapercbaseredpf
        {
            get { return  utilizapercbaseredpf; }
            set {  utilizapercbaseredpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPERCBASEREDVENCONSIGN
        /// Comentário: Utiliza Percentual de Redução de ICMS na Venda Consignada.
        /// </summary>
        private string utilizapercbaseredvenconsign;
        [XmlElement(ElementName = "UTILIZAPERCBASEREDVENCONSIGN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizapercbaseredvenconsign
        {
            get { return  utilizapercbaseredvenconsign; }
            set {  utilizapercbaseredvenconsign = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMSINTEREST
        /// Comentário: Valor de Pauta ICMS 
        /// </summary>
        private decimal vlpautaicmsinterest;
        [XmlElement(ElementName = "VLPAUTAICMSINTEREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlpautaicmsinterest
        {
            get { return  vlpautaicmsinterest; }
            set {  vlpautaicmsinterest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTASEMIVA
        /// Comentário: Valor de pauta sem iva.
        /// </summary>
        private decimal vlpautasemiva;
        [XmlElement(ElementName = "VLPAUTASEMIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlpautasemiva
        {
            get { return  vlpautasemiva; }
            set {  vlpautasemiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ZERARBASEICMSORGPUBSUFRAMA
        /// Comentário: Zerar Base de Icms Orgão Público ou Suframados.
        /// </summary>
        private string zerarbaseicmsorgpubsuframa;
        [XmlElement(ElementName = "ZERARBASEICMSORGPUBSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Zerarbaseicmsorgpubsuframa
        {
            get { return  zerarbaseicmsorgpubsuframa; }
            set {  zerarbaseicmsorgpubsuframa = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTribut()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBUT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTribut> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribut>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTribut> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribut>(where);
        }

        #endregion
    }
}
