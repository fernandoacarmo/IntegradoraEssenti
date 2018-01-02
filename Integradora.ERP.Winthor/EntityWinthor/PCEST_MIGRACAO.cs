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
    /// Classe referente a tabela PCEst_migracao
    /// </summary>
    [XmlType("PCEST_MIGRACAO")]
    public class PCEst_migracao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1ULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal aliqicms1ultent;
        [XmlElement(ElementName = "ALIQICMS1ULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms1ultent
        {
            get { return  aliqicms1ultent; }
            set {  aliqicms1ultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1ULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal aliqicms1ultenttab;
        [XmlElement(ElementName = "ALIQICMS1ULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms1ultenttab
        {
            get { return  aliqicms1ultenttab; }
            set {  aliqicms1ultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2ULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal aliqicms2ultent;
        [XmlElement(ElementName = "ALIQICMS2ULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms2ultent
        {
            get { return  aliqicms2ultent; }
            set {  aliqicms2ultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2ULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal aliqicms2ultenttab;
        [XmlElement(ElementName = "ALIQICMS2ULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Aliqicms2ultenttab
        {
            get { return  aliqicms2ultenttab; }
            set {  aliqicms2ultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APTO
        /// Coment�rio: 
        /// </summary>
        private decimal apto;
        [XmlElement(ElementName = "APTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Apto
        {
            get { return  apto; }
            set {  apto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APTOCX
        /// Coment�rio: 
        /// </summary>
        private decimal aptocx;
        [XmlElement(ElementName = "APTOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aptocx
        {
            get { return  aptocx; }
            set {  aptocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ATFQTDEPOSITO
        /// Coment�rio: 
        /// </summary>
        private decimal atfqtdeposito;
        [XmlElement(ElementName = "ATFQTDEPOSITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Atfqtdeposito
        {
            get { return  atfqtdeposito; }
            set {  atfqtdeposito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEBCR
        /// Coment�rio: 
        /// </summary>
        private decimal basebcr;
        [XmlElement(ElementName = "BASEBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basebcr
        {
            get { return  basebcr; }
            set {  basebcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMSULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal baseicmsultent;
        [XmlElement(ElementName = "BASEICMSULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicmsultent
        {
            get { return  baseicmsultent; }
            set {  baseicmsultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICMSULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal baseicmsultenttab;
        [XmlElement(ElementName = "BASEICMSULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicmsultenttab
        {
            get { return  baseicmsultenttab; }
            set {  baseicmsultenttab = value; }
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CORREDOR
        /// Coment�rio: 
        /// </summary>
        private decimal corredor;
        [XmlElement(ElementName = "CORREDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Corredor
        {
            get { return  corredor; }
            set {  corredor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONT
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CUSTODOLAR
        /// Coment�rio: 
        /// </summary>
        private decimal custodolar;
        [XmlElement(ElementName = "CUSTODOLAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custodolar
        {
            get { return  custodolar; }
            set {  custodolar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CUSTOFINSEMST
        /// Coment�rio: 
        /// </summary>
        private decimal custofinsemst;
        [XmlElement(ElementName = "CUSTOFINSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinsemst
        {
            get { return  custofinsemst; }
            set {  custofinsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFORNEC
        /// Coment�rio: 
        /// </summary>
        private decimal custofornec;
        [XmlElement(ElementName = "CUSTOFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Custofornec
        {
            get { return  custofornec; }
            set {  custofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFORNECSEMST
        /// Coment�rio: 
        /// </summary>
        private decimal custofornecsemst;
        [XmlElement(ElementName = "CUSTOFORNECSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofornecsemst
        {
            get { return  custofornecsemst; }
            set {  custofornecsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMST
        /// Coment�rio: 
        /// </summary>
        private decimal custonfsemst;
        [XmlElement(ElementName = "CUSTONFSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemst
        {
            get { return  custonfsemst; }
            set {  custonfsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMSTGUIAULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal custonfsemstguiaultent;
        [XmlElement(ElementName = "CUSTONFSEMSTGUIAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemstguiaultent
        {
            get { return  custonfsemstguiaultent; }
            set {  custonfsemstguiaultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMSTGUIAULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal custonfsemstguiaultenttab;
        [XmlElement(ElementName = "CUSTONFSEMSTGUIAULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemstguiaultenttab
        {
            get { return  custonfsemstguiaultenttab; }
            set {  custonfsemstguiaultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTONFSEMSTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal custonfsemsttab;
        [XmlElement(ElementName = "CUSTONFSEMSTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custonfsemsttab
        {
            get { return  custonfsemsttab; }
            set {  custonfsemsttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRA
        /// Coment�rio: 
        /// </summary>
        private decimal custoproximacompra;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoproximacompra
        {
            get { return  custoproximacompra; }
            set {  custoproximacompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRASEMST
        /// Coment�rio: 
        /// </summary>
        private decimal custoproximacomprasemst;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRASEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoproximacomprasemst
        {
            get { return  custoproximacomprasemst; }
            set {  custoproximacomprasemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CUSTOREALLIQ
        /// Coment�rio: 
        /// </summary>
        private decimal custorealliq;
        [XmlElement(ElementName = "CUSTOREALLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorealliq
        {
            get { return  custorealliq; }
            set {  custorealliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREALSEMST
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CUSTOULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal custoultent;
        [XmlElement(ElementName = "CUSTOULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultent
        {
            get { return  custoultent; }
            set {  custoultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTANT
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentant;
        [XmlElement(ElementName = "CUSTOULTENTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentant
        {
            get { return  custoultentant; }
            set {  custoultentant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTCONT
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentcont;
        [XmlElement(ElementName = "CUSTOULTENTCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentcont
        {
            get { return  custoultentcont; }
            set {  custoultentcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTFIN
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentfin;
        [XmlElement(ElementName = "CUSTOULTENTFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentfin
        {
            get { return  custoultentfin; }
            set {  custoultentfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTFINSEMST
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentfinsemst;
        [XmlElement(ElementName = "CUSTOULTENTFINSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentfinsemst
        {
            get { return  custoultentfinsemst; }
            set {  custoultentfinsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTLIQ
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentliq;
        [XmlElement(ElementName = "CUSTOULTENTLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentliq
        {
            get { return  custoultentliq; }
            set {  custoultentliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTMED
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentmed;
        [XmlElement(ElementName = "CUSTOULTENTMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentmed
        {
            get { return  custoultentmed; }
            set {  custoultentmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENTSEMST
        /// Coment�rio: 
        /// </summary>
        private decimal custoultentsemst;
        [XmlElement(ElementName = "CUSTOULTENTSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultentsemst
        {
            get { return  custoultentsemst; }
            set {  custoultentsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTPEDCOMPRA
        /// Coment�rio: 
        /// </summary>
        private decimal custoultpedcompra;
        [XmlElement(ElementName = "CUSTOULTPEDCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultpedcompra
        {
            get { return  custoultpedcompra; }
            set {  custoultpedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTPEDCOMPRASEMST
        /// Coment�rio: 
        /// </summary>
        private decimal custoultpedcomprasemst;
        [XmlElement(ElementName = "CUSTOULTPEDCOMPRASEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoultpedcomprasemst
        {
            get { return  custoultpedcomprasemst; }
            set {  custoultpedcomprasemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO1107
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtalteracao1107;
        [XmlElement(ElementName = "DTALTERACAO1107", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao1107
        {
            get { return  dtalteracao1107; }
            set {  dtalteracao1107 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOULTENT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtemissaoultent;
        [XmlElement(ElementName = "DTEMISSAOULTENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoultent
        {
            get { return  dtemissaoultent; }
            set {  dtemissaoultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPRIMCOMPRA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtprimcompra;
        [XmlElement(ElementName = "DTPRIMCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprimcompra
        {
            get { return  dtprimcompra; }
            set {  dtprimcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTERSRVPRC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultaltersrvprc;
        [XmlElement(ElementName = "DTULTALTERSRVPRC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltersrvprc
        {
            get { return  dtultaltersrvprc; }
            set {  dtultaltersrvprc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTDESDOBRA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultdesdobra;
        [XmlElement(ElementName = "DTULTDESDOBRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultdesdobra
        {
            get { return  dtultdesdobra; }
            set {  dtultdesdobra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTENT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultent;
        [XmlElement(ElementName = "DTULTENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultent
        {
            get { return  dtultent; }
            set {  dtultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTFAT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultfat;
        [XmlElement(ElementName = "DTULTFAT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultfat
        {
            get { return  dtultfat; }
            set {  dtultfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTINVENT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultinvent;
        [XmlElement(ElementName = "DTULTINVENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultinvent
        {
            get { return  dtultinvent; }
            set {  dtultinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTPEDCOMPRA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultpedcompra;
        [XmlElement(ElementName = "DTULTPEDCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultpedcompra
        {
            get { return  dtultpedcompra; }
            set {  dtultpedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTSAIDA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultsaida;
        [XmlElement(ElementName = "DTULTSAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultsaida
        {
            get { return  dtultsaida; }
            set {  dtultsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTIDEAL
        /// Coment�rio: 
        /// </summary>
        private decimal estideal;
        [XmlElement(ElementName = "ESTIDEAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Estideal
        {
            get { return  estideal; }
            set {  estideal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTMAX
        /// Coment�rio: 
        /// </summary>
        private decimal estmax;
        [XmlElement(ElementName = "ESTMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Estmax
        {
            get { return  estmax; }
            set {  estmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTMIN
        /// Coment�rio: 
        /// </summary>
        private decimal estmin;
        [XmlElement(ElementName = "ESTMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Estmin
        {
            get { return  estmin; }
            set {  estmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIMESTOQUE
        /// Coment�rio: 
        /// </summary>
        private string fimestoque;
        [XmlElement(ElementName = "FIMESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fimestoque
        {
            get { return  fimestoque; }
            set {  fimestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVAULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal ivaultent;
        [XmlElement(ElementName = "IVAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ivaultent
        {
            get { return  ivaultent; }
            set {  ivaultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVAULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal ivaultenttab;
        [XmlElement(ElementName = "IVAULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ivaultenttab
        {
            get { return  ivaultenttab; }
            set {  ivaultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULO
        /// Coment�rio: 
        /// </summary>
        private decimal modulo;
        [XmlElement(ElementName = "MODULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Modulo
        {
            get { return  modulo; }
            set {  modulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULOCX
        /// Coment�rio: 
        /// </summary>
        private decimal modulocx;
        [XmlElement(ElementName = "MODULOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Modulocx
        {
            get { return  modulocx; }
            set {  modulocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOBLOQESTOQUE
        /// Coment�rio: 
        /// </summary>
        private string motivobloqestoque;
        [XmlElement(ElementName = "MOTIVOBLOQESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Motivobloqestoque
        {
            get { return  motivobloqestoque; }
            set {  motivobloqestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Coment�rio: 
        /// </summary>
        private decimal numero;
        [XmlElement(ElementName = "NUMERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numero
        {
            get { return  numero; }
            set {  numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROCX
        /// Coment�rio: 
        /// </summary>
        private decimal numerocx;
        [XmlElement(ElementName = "NUMEROCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numerocx
        {
            get { return  numerocx; }
            set {  numerocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFCI
        /// Coment�rio: 
        /// </summary>
        private string numfci;
        [XmlElement(ElementName = "NUMFCI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,36)]
        public string Numfci
        {
            get { return  numfci; }
            set {  numfci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal numnotaultent;
        [XmlElement(ElementName = "NUMNOTAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotaultent
        {
            get { return  numnotaultent; }
            set {  numnotaultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal numtransentultent;
        [XmlElement(ElementName = "NUMTRANSENTULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentultent
        {
            get { return  numtransentultent; }
            set {  numtransentultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMPRAULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal pcompraultent;
        [XmlElement(ElementName = "PCOMPRAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pcompraultent
        {
            get { return  pcompraultent; }
            set {  pcompraultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCUSTOANT
        /// Coment�rio: 
        /// </summary>
        private decimal pcustoant;
        [XmlElement(ElementName = "PCUSTOANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pcustoant
        {
            get { return  pcustoant; }
            set {  pcustoant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTGUIAULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal percaliqextguiaultent;
        [XmlElement(ElementName = "PERCALIQEXTGUIAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqextguiaultent
        {
            get { return  percaliqextguiaultent; }
            set {  percaliqextguiaultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTGUIAULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal percaliqextguiaultenttab;
        [XmlElement(ElementName = "PERCALIQEXTGUIAULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percaliqextguiaultenttab
        {
            get { return  percaliqextguiaultenttab; }
            set {  percaliqextguiaultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCONTEUDOIMPFCI
        /// Coment�rio: 
        /// </summary>
        private decimal percconteudoimpfci;
        [XmlElement(ElementName = "PERCCONTEUDOIMPFCI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percconteudoimpfci
        {
            get { return  percconteudoimpfci; }
            set {  percconteudoimpfci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCEVOLUCAOVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal percevolucaovenda;
        [XmlElement(ElementName = "PERCEVOLUCAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percevolucaovenda
        {
            get { return  percevolucaovenda; }
            set {  percevolucaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBSTULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal percicmsfretefobstultent;
        [XmlElement(ElementName = "PERCICMSFRETEFOBSTULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmsfretefobstultent
        {
            get { return  percicmsfretefobstultent; }
            set {  percicmsfretefobstultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBSTULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal percicmsfretefobstultenttab;
        [XmlElement(ElementName = "PERCICMSFRETEFOBSTULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percicmsfretefobstultenttab
        {
            get { return  percicmsfretefobstultenttab; }
            set {  percicmsfretefobstultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMVAORIGTAB
        /// Coment�rio: 
        /// </summary>
        private decimal percmvaorigtab;
        [XmlElement(ElementName = "PERCMVAORIGTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percmvaorigtab
        {
            get { return  percmvaorigtab; }
            set {  percmvaorigtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMVAORIGULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal percmvaorigultent;
        [XmlElement(ElementName = "PERCMVAORIGULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percmvaorigultent
        {
            get { return  percmvaorigultent; }
            set {  percmvaorigultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQTRANSF
        /// Coment�rio: 
        /// </summary>
        private decimal qtbloqtransf;
        [XmlElement(ElementName = "QTBLOQTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtbloqtransf
        {
            get { return  qtbloqtransf; }
            set {  qtbloqtransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVOLMES
        /// Coment�rio: 
        /// </summary>
        private decimal qtdevolmes;
        [XmlElement(ElementName = "QTDEVOLMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevolmes
        {
            get { return  qtdevolmes; }
            set {  qtdevolmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVOLMES1
        /// Coment�rio: 
        /// </summary>
        private decimal qtdevolmes1;
        [XmlElement(ElementName = "QTDEVOLMES1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevolmes1
        {
            get { return  qtdevolmes1; }
            set {  qtdevolmes1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVOLMES2
        /// Coment�rio: 
        /// </summary>
        private decimal qtdevolmes2;
        [XmlElement(ElementName = "QTDEVOLMES2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevolmes2
        {
            get { return  qtdevolmes2; }
            set {  qtdevolmes2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVOLMES3
        /// Coment�rio: 
        /// </summary>
        private decimal qtdevolmes3;
        [XmlElement(ElementName = "QTDEVOLMES3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdevolmes3
        {
            get { return  qtdevolmes3; }
            set {  qtdevolmes3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTDIA
        /// Coment�rio: 
        /// </summary>
        private decimal qtentdia;
        [XmlElement(ElementName = "QTENTDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentdia
        {
            get { return  qtentdia; }
            set {  qtentdia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTMES
        /// Coment�rio: 
        /// </summary>
        private decimal qtentmes;
        [XmlElement(ElementName = "QTENTMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentmes
        {
            get { return  qtentmes; }
            set {  qtentmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEST
        /// Coment�rio: 
        /// </summary>
        private decimal qtest;
        [XmlElement(ElementName = "QTEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtest
        {
            get { return  qtest; }
            set {  qtest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTANT
        /// Coment�rio: 
        /// </summary>
        private decimal qtestant;
        [XmlElement(ElementName = "QTESTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestant
        {
            get { return  qtestant; }
            set {  qtestant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGER
        /// Coment�rio: 
        /// </summary>
        private decimal qtestger;
        [XmlElement(ElementName = "QTESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtestger
        {
            get { return  qtestger; }
            set {  qtestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTORNOPRODUZDIA
        /// Coment�rio: 
        /// </summary>
        private decimal qtestornoproduzdia;
        [XmlElement(ElementName = "QTESTORNOPRODUZDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtestornoproduzdia
        {
            get { return  qtestornoproduzdia; }
            set {  qtestornoproduzdia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTORNOPRODUZMES
        /// Coment�rio: 
        /// </summary>
        private decimal qtestornoproduzmes;
        [XmlElement(ElementName = "QTESTORNOPRODUZMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtestornoproduzmes
        {
            get { return  qtestornoproduzmes; }
            set {  qtestornoproduzmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFRENTELOJA
        /// Coment�rio: 
        /// </summary>
        private decimal qtfrenteloja;
        [XmlElement(ElementName = "QTFRENTELOJA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtfrenteloja
        {
            get { return  qtfrenteloja; }
            set {  qtfrenteloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTGIROCURVATURA
        /// Coment�rio: 
        /// </summary>
        private decimal qtgirocurvatura;
        [XmlElement(ElementName = "QTGIROCURVATURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtgirocurvatura
        {
            get { return  qtgirocurvatura; }
            set {  qtgirocurvatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTGIROCURVATURAANT
        /// Coment�rio: 
        /// </summary>
        private decimal qtgirocurvaturaant;
        [XmlElement(ElementName = "QTGIROCURVATURAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtgirocurvaturaant
        {
            get { return  qtgirocurvaturaant; }
            set {  qtgirocurvaturaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTGIRODIA
        /// Coment�rio: 
        /// </summary>
        private decimal qtgirodia;
        [XmlElement(ElementName = "QTGIRODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtgirodia
        {
            get { return  qtgirodia; }
            set {  qtgirodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTINDENIZ
        /// Coment�rio: 
        /// </summary>
        private decimal qtindeniz;
        [XmlElement(ElementName = "QTINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtindeniz
        {
            get { return  qtindeniz; }
            set {  qtindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLOJA
        /// Coment�rio: 
        /// </summary>
        private decimal qtloja;
        [XmlElement(ElementName = "QTLOJA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtloja
        {
            get { return  qtloja; }
            set {  qtloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDA
        /// Coment�rio: 
        /// </summary>
        private decimal qtpedida;
        [XmlElement(ElementName = "QTPEDIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtpedida
        {
            get { return  qtpedida; }
            set {  qtpedida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDENTE
        /// Coment�rio: 
        /// </summary>
        private decimal qtpendente;
        [XmlElement(ElementName = "QTPENDENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtpendente
        {
            get { return  qtpendente; }
            set {  qtpendente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDADIA
        /// Coment�rio: 
        /// </summary>
        private decimal qtperdadia;
        [XmlElement(ElementName = "QTPERDADIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdadia
        {
            get { return  qtperdadia; }
            set {  qtperdadia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDAMES
        /// Coment�rio: 
        /// </summary>
        private decimal qtperdames;
        [XmlElement(ElementName = "QTPERDAMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperdames
        {
            get { return  qtperdames; }
            set {  qtperdames = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIDADIA
        /// Coment�rio: 
        /// </summary>
        private decimal qtproduzidadia;
        [XmlElement(ElementName = "QTPRODUZIDADIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtproduzidadia
        {
            get { return  qtproduzidadia; }
            set {  qtproduzidadia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIDAMES
        /// Coment�rio: 
        /// </summary>
        private decimal qtproduzidames;
        [XmlElement(ElementName = "QTPRODUZIDAMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtproduzidames
        {
            get { return  qtproduzidames; }
            set {  qtproduzidames = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTREQUISICAO
        /// Coment�rio: 
        /// </summary>
        private decimal qtrequisicao;
        [XmlElement(ElementName = "QTREQUISICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtrequisicao
        {
            get { return  qtrequisicao; }
            set {  qtrequisicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Coment�rio: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtreserv
        {
            get { return  qtreserv; }
            set {  qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERVMED
        /// Coment�rio: 
        /// </summary>
        private decimal qtreservmed;
        [XmlElement(ElementName = "QTRESERVMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtreservmed
        {
            get { return  qtreservmed; }
            set {  qtreservmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTRANSITO
        /// Coment�rio: 
        /// </summary>
        private decimal qttransito;
        [XmlElement(ElementName = "QTTRANSITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qttransito
        {
            get { return  qttransito; }
            set {  qttransito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal qtultent;
        [XmlElement(ElementName = "QTULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtultent
        {
            get { return  qtultent; }
            set {  qtultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTULTINVENT
        /// Coment�rio: 
        /// </summary>
        private decimal qtultinvent;
        [XmlElement(ElementName = "QTULTINVENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtultinvent
        {
            get { return  qtultinvent; }
            set {  qtultinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDAPERDIDA
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendaperdida;
        [XmlElement(ElementName = "QTVENDAPERDIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendaperdida
        {
            get { return  qtvendaperdida; }
            set {  qtvendaperdida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDDIA
        /// Coment�rio: 
        /// </summary>
        private decimal qtvenddia;
        [XmlElement(ElementName = "QTVENDDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvenddia
        {
            get { return  qtvenddia; }
            set {  qtvenddia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDMES
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendmes;
        [XmlElement(ElementName = "QTVENDMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendmes
        {
            get { return  qtvendmes; }
            set {  qtvendmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDMES1
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendmes1;
        [XmlElement(ElementName = "QTVENDMES1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendmes1
        {
            get { return  qtvendmes1; }
            set {  qtvendmes1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDMES2
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendmes2;
        [XmlElement(ElementName = "QTVENDMES2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendmes2
        {
            get { return  qtvendmes2; }
            set {  qtvendmes2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDMES3
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendmes3;
        [XmlElement(ElementName = "QTVENDMES3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendmes3
        {
            get { return  qtvendmes3; }
            set {  qtvendmes3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDSEMANA
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendsemana;
        [XmlElement(ElementName = "QTVENDSEMANA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendsemana
        {
            get { return  qtvendsemana; }
            set {  qtvendsemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDSEMANA1
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendsemana1;
        [XmlElement(ElementName = "QTVENDSEMANA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendsemana1
        {
            get { return  qtvendsemana1; }
            set {  qtvendsemana1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDSEMANA2
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendsemana2;
        [XmlElement(ElementName = "QTVENDSEMANA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendsemana2
        {
            get { return  qtvendsemana2; }
            set {  qtvendsemana2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDSEMANA3
        /// Coment�rio: 
        /// </summary>
        private decimal qtvendsemana3;
        [XmlElement(ElementName = "QTVENDSEMANA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtvendsemana3
        {
            get { return  qtvendsemana3; }
            set {  qtvendsemana3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVAULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal redbaseivaultent;
        [XmlElement(ElementName = "REDBASEIVAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbaseivaultent
        {
            get { return  redbaseivaultent; }
            set {  redbaseivaultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVAULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal redbaseivaultenttab;
        [XmlElement(ElementName = "REDBASEIVAULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Redbaseivaultenttab
        {
            get { return  redbaseivaultenttab; }
            set {  redbaseivaultenttab = value; }
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
        /// Propriedade referente ao campo: RUA
        /// Coment�rio: 
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUACX
        /// Coment�rio: 
        /// </summary>
        private decimal ruacx;
        [XmlElement(ElementName = "RUACX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ruacx
        {
            get { return  ruacx; }
            set {  ruacx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STBCR
        /// Coment�rio: 
        /// </summary>
        private decimal stbcr;
        [XmlElement(ElementName = "STBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stbcr
        {
            get { return  stbcr; }
            set {  stbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal valorultent;
        [XmlElement(ElementName = "VALORULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorultent
        {
            get { return  valorultent; }
            set {  valorultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENTMED
        /// Coment�rio: 
        /// </summary>
        private decimal valorultentmed;
        [XmlElement(ElementName = "VALORULTENTMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorultentmed
        {
            get { return  valorultentmed; }
            set {  valorultentmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTODIAFIN
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustodiafin;
        [XmlElement(ElementName = "VLCUSTODIAFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcustodiafin
        {
            get { return  vlcustodiafin; }
            set {  vlcustodiafin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTODIAREAL
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustodiareal;
        [XmlElement(ElementName = "VLCUSTODIAREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcustodiareal
        {
            get { return  vlcustodiareal; }
            set {  vlcustodiareal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMESFIN
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustomesfin;
        [XmlElement(ElementName = "VLCUSTOMESFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcustomesfin
        {
            get { return  vlcustomesfin; }
            set {  vlcustomesfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMESFINANT
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustomesfinant;
        [XmlElement(ElementName = "VLCUSTOMESFINANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustomesfinant
        {
            get { return  vlcustomesfinant; }
            set {  vlcustomesfinant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMESREAL
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustomesreal;
        [XmlElement(ElementName = "VLCUSTOMESREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcustomesreal
        {
            get { return  vlcustomesreal; }
            set {  vlcustomesreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOMESREALANT
        /// Coment�rio: 
        /// </summary>
        private decimal vlcustomesrealant;
        [XmlElement(ElementName = "VLCUSTOMESREALANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcustomesrealant
        {
            get { return  vlcustomesrealant; }
            set {  vlcustomesrealant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETECONHECULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal vlfreteconhecultent;
        [XmlElement(ElementName = "VLFRETECONHECULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfreteconhecultent
        {
            get { return  vlfreteconhecultent; }
            set {  vlfreteconhecultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETECONHECULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal vlfreteconhecultenttab;
        [XmlElement(ElementName = "VLFRETECONHECULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfreteconhecultenttab
        {
            get { return  vlfreteconhecultenttab; }
            set {  vlfreteconhecultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIMPORTACAOFCI
        /// Coment�rio: 
        /// </summary>
        private decimal vlimportacaofci;
        [XmlElement(ElementName = "VLIMPORTACAOFCI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlimportacaofci
        {
            get { return  vlimportacaofci; }
            set {  vlimportacaofci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPARCELAIMPFCI
        /// Coment�rio: 
        /// </summary>
        private decimal vlparcelaimpfci;
        [XmlElement(ElementName = "VLPARCELAIMPFCI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlparcelaimpfci
        {
            get { return  vlparcelaimpfci; }
            set {  vlparcelaimpfci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTGUIAULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal vlstguiaultent;
        [XmlElement(ElementName = "VLSTGUIAULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstguiaultent
        {
            get { return  vlstguiaultent; }
            set {  vlstguiaultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTGUIAULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal vlstguiaultenttab;
        [XmlElement(ElementName = "VLSTGUIAULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstguiaultenttab
        {
            get { return  vlstguiaultenttab; }
            set {  vlstguiaultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal vlstultent;
        [XmlElement(ElementName = "VLSTULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstultent
        {
            get { return  vlstultent; }
            set {  vlstultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTULTENTTAB
        /// Coment�rio: 
        /// </summary>
        private decimal vlstultenttab;
        [XmlElement(ElementName = "VLSTULTENTTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlstultenttab
        {
            get { return  vlstultenttab; }
            set {  vlstultenttab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTENTCONTSEMST
        /// Coment�rio: 
        /// </summary>
        private decimal vlultentcontsemst;
        [XmlElement(ElementName = "VLULTENTCONTSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultentcontsemst
        {
            get { return  vlultentcontsemst; }
            set {  vlultentcontsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTPCOMPRA
        /// Coment�rio: 
        /// </summary>
        private decimal vlultpcompra;
        [XmlElement(ElementName = "VLULTPCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultpcompra
        {
            get { return  vlultpcompra; }
            set {  vlultpcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDDIA
        /// Coment�rio: 
        /// </summary>
        private decimal vlvenddia;
        [XmlElement(ElementName = "VLVENDDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvenddia
        {
            get { return  vlvenddia; }
            set {  vlvenddia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDDIAREAL
        /// Coment�rio: 
        /// </summary>
        private decimal vlvenddiareal;
        [XmlElement(ElementName = "VLVENDDIAREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvenddiareal
        {
            get { return  vlvenddiareal; }
            set {  vlvenddiareal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDMES
        /// Coment�rio: 
        /// </summary>
        private decimal vlvendmes;
        [XmlElement(ElementName = "VLVENDMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvendmes
        {
            get { return  vlvendmes; }
            set {  vlvendmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDMESANT
        /// Coment�rio: 
        /// </summary>
        private decimal vlvendmesant;
        [XmlElement(ElementName = "VLVENDMESANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlvendmesant
        {
            get { return  vlvendmesant; }
            set {  vlvendmesant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDMESREAL
        /// Coment�rio: 
        /// </summary>
        private decimal vlvendmesreal;
        [XmlElement(ElementName = "VLVENDMESREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvendmesreal
        {
            get { return  vlvendmesreal; }
            set {  vlvendmesreal = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEst_migracao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEST_MIGRACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEst_migracao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEst_migracao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEst_migracao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEst_migracao>(where);
        }

        #endregion
    }
}
