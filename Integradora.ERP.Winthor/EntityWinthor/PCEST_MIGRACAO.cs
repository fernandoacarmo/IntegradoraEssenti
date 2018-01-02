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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: RUA
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEst_migracao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEst_migracao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
