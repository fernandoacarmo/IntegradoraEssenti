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
    /// Classe referente a tabela PCParamfat
    /// </summary>
    [XmlType("PCPARAMFAT")]
    public class PCParamfat : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGREGARFRETEBASEIPI
        /// Comentário: 
        /// </summary>
        private string agregarfretebaseipi;
        [XmlElement(ElementName = "AGREGARFRETEBASEIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregarfretebaseipi
        {
            get { return  agregarfretebaseipi; }
            set {  agregarfretebaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEARENVIOXMLFILRETSEMTRANS
        /// Comentário: 
        /// </summary>
        private string bloquearenvioxmlfilretsemtrans;
        [XmlElement(ElementName = "BLOQUEARENVIOXMLFILRETSEMTRANS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloquearenvioxmlfilretsemtrans
        {
            get { return  bloquearenvioxmlfilretsemtrans; }
            set {  bloquearenvioxmlfilretsemtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULARPISCOFINSTV5_13_10
        /// Comentário: 
        /// </summary>
        private string calcularpiscofinstv5_13_10;
        [XmlElement(ElementName = "CALCULARPISCOFINSTV5_13_10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcularpiscofinstv5_13_10
        {
            get { return  calcularpiscofinstv5_13_10; }
            set {  calcularpiscofinstv5_13_10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBST
        /// Comentário: 
        /// </summary>
        private string codcobst;
        [XmlElement(ElementName = "CODCOBST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobst
        {
            get { return  codcobst; }
            set {  codcobst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA_PCLANC
        /// Comentário: 
        /// </summary>
        private string codconta_pclanc;
        [XmlElement(ElementName = "CODCONTA_PCLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Codconta_Pclanc
        {
            get { return  codconta_pclanc; }
            set {  codconta_pclanc = value; }
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
        /// Propriedade referente ao campo: CON_ABATERIMPOSTOSCOMISSAORCA
        /// Comentário: 
        /// </summary>
        private string con_abaterimpostoscomissaorca;
        [XmlElement(ElementName = "CON_ABATERIMPOSTOSCOMISSAORCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Abaterimpostoscomissaorca
        {
            get { return  con_abaterimpostoscomissaorca; }
            set {  con_abaterimpostoscomissaorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_ABATERIMPOSTOSDESCFIN
        /// Comentário: 
        /// </summary>
        private string con_abaterimpostosdescfin;
        [XmlElement(ElementName = "CON_ABATERIMPOSTOSDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Abaterimpostosdescfin
        {
            get { return  con_abaterimpostosdescfin; }
            set {  con_abaterimpostosdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_ACEITAPFCONTRIBUINTE
        /// Comentário: 
        /// </summary>
        private string con_aceitapfcontribuinte;
        [XmlElement(ElementName = "CON_ACEITAPFCONTRIBUINTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Aceitapfcontribuinte
        {
            get { return  con_aceitapfcontribuinte; }
            set {  con_aceitapfcontribuinte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_ALIQICMINTEROUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal con_aliqicminteroutrasdesp;
        [XmlElement(ElementName = "CON_ALIQICMINTEROUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Aliqicminteroutrasdesp
        {
            get { return  con_aliqicminteroutrasdesp; }
            set {  con_aliqicminteroutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_ALIQICMOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal con_aliqicmoutrasdesp;
        [XmlElement(ElementName = "CON_ALIQICMOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Aliqicmoutrasdesp
        {
            get { return  con_aliqicmoutrasdesp; }
            set {  con_aliqicmoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_CALCSTPF
        /// Comentário: 
        /// </summary>
        private string con_calcstpf;
        [XmlElement(ElementName = "CON_CALCSTPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Calcstpf
        {
            get { return  con_calcstpf; }
            set {  con_calcstpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_CALCULAGIROTRANSF
        /// Comentário: 
        /// </summary>
        private string con_calculagirotransf;
        [XmlElement(ElementName = "CON_CALCULAGIROTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Calculagirotransf
        {
            get { return  con_calculagirotransf; }
            set {  con_calculagirotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_CALCULARSTCOMIPI
        /// Comentário: 
        /// </summary>
        private string con_calcularstcomipi;
        [XmlElement(ElementName = "CON_CALCULARSTCOMIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Calcularstcomipi
        {
            get { return  con_calcularstcomipi; }
            set {  con_calcularstcomipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_COBRARVLTARIFAPARC1
        /// Comentário: 
        /// </summary>
        private string con_cobrarvltarifaparc1;
        [XmlElement(ElementName = "CON_COBRARVLTARIFAPARC1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Cobrarvltarifaparc1
        {
            get { return  con_cobrarvltarifaparc1; }
            set {  con_cobrarvltarifaparc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_CODCONTATRANSFTV10
        /// Comentário: 
        /// </summary>
        private decimal con_codcontatransftv10;
        [XmlElement(ElementName = "CON_CODCONTATRANSFTV10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Codcontatransftv10
        {
            get { return  con_codcontatransftv10; }
            set {  con_codcontatransftv10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_CODCONTAVERBACMV
        /// Comentário: 
        /// </summary>
        private decimal con_codcontaverbacmv;
        [XmlElement(ElementName = "CON_CODCONTAVERBACMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Codcontaverbacmv
        {
            get { return  con_codcontaverbacmv; }
            set {  con_codcontaverbacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_CODCONTCLI
        /// Comentário: 
        /// </summary>
        private decimal con_codcontcli;
        [XmlElement(ElementName = "CON_CODCONTCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Codcontcli
        {
            get { return  con_codcontcli; }
            set {  con_codcontcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_CONSIDERAISENTOSCOMOPF
        /// Comentário: 
        /// </summary>
        private string con_consideraisentoscomopf;
        [XmlElement(ElementName = "CON_CONSIDERAISENTOSCOMOPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Consideraisentoscomopf
        {
            get { return  con_consideraisentoscomopf; }
            set {  con_consideraisentoscomopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_DIVIDEPRZADICIONALPARCELAS
        /// Comentário: 
        /// </summary>
        private string con_divideprzadicionalparcelas;
        [XmlElement(ElementName = "CON_DIVIDEPRZADICIONALPARCELAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Divideprzadicionalparcelas
        {
            get { return  con_divideprzadicionalparcelas; }
            set {  con_divideprzadicionalparcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_GERANFTIPO8
        /// Comentário: 
        /// </summary>
        private string con_geranftipo8;
        [XmlElement(ElementName = "CON_GERANFTIPO8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Geranftipo8
        {
            get { return  con_geranftipo8; }
            set {  con_geranftipo8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_LANCARFRETEXPARCELAS
        /// Comentário: 
        /// </summary>
        private string con_lancarfretexparcelas;
        [XmlElement(ElementName = "CON_LANCARFRETEXPARCELAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Lancarfretexparcelas
        {
            get { return  con_lancarfretexparcelas; }
            set {  con_lancarfretexparcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_LANCARSTAPENASPARC1
        /// Comentário: 
        /// </summary>
        private string con_lancarstapenasparc1;
        [XmlElement(ElementName = "CON_LANCARSTAPENASPARC1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Lancarstapenasparc1
        {
            get { return  con_lancarstapenasparc1; }
            set {  con_lancarstapenasparc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_MOSTRARPVENDASEMST
        /// Comentário: 
        /// </summary>
        private string con_mostrarpvendasemst;
        [XmlElement(ElementName = "CON_MOSTRARPVENDASEMST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Mostrarpvendasemst
        {
            get { return  con_mostrarpvendasemst; }
            set {  con_mostrarpvendasemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_NAOUSARPCCRECLICONSFINAL
        /// Comentário: 
        /// </summary>
        private string con_naousarpccrecliconsfinal;
        [XmlElement(ElementName = "CON_NAOUSARPCCRECLICONSFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Naousarpccrecliconsfinal
        {
            get { return  con_naousarpccrecliconsfinal; }
            set {  con_naousarpccrecliconsfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_NUMCASASDECVENDA
        /// Comentário: 
        /// </summary>
        private decimal con_numcasasdecvenda;
        [XmlElement(ElementName = "CON_NUMCASASDECVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Numcasasdecvenda
        {
            get { return  con_numcasasdecvenda; }
            set {  con_numcasasdecvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_NUMDIASMINVENDABK
        /// Comentário: 
        /// </summary>
        private decimal con_numdiasminvendabk;
        [XmlElement(ElementName = "CON_NUMDIASMINVENDABK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Numdiasminvendabk
        {
            get { return  con_numdiasminvendabk; }
            set {  con_numdiasminvendabk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_PERBASEREDOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal con_perbaseredoutrasdesp;
        [XmlElement(ElementName = "CON_PERBASEREDOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Perbaseredoutrasdesp
        {
            get { return  con_perbaseredoutrasdesp; }
            set {  con_perbaseredoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_PERCICMFRETEENT
        /// Comentário: 
        /// </summary>
        private decimal con_percicmfreteent;
        [XmlElement(ElementName = "CON_PERCICMFRETEENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Percicmfreteent
        {
            get { return  con_percicmfreteent; }
            set {  con_percicmfreteent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_PERCICMINTERFRETEENT
        /// Comentário: 
        /// </summary>
        private decimal con_percicminterfreteent;
        [XmlElement(ElementName = "CON_PERCICMINTERFRETEENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Percicminterfreteent
        {
            get { return  con_percicminterfreteent; }
            set {  con_percicminterfreteent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_QTDEPARCELASIMPOSTOSFRETE
        /// Comentário: 
        /// </summary>
        private decimal con_qtdeparcelasimpostosfrete;
        [XmlElement(ElementName = "CON_QTDEPARCELASIMPOSTOSFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Qtdeparcelasimpostosfrete
        {
            get { return  con_qtdeparcelasimpostosfrete; }
            set {  con_qtdeparcelasimpostosfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_SOMATARIFABANCDUPLIC
        /// Comentário: 
        /// </summary>
        private string con_somatarifabancduplic;
        [XmlElement(ElementName = "CON_SOMATARIFABANCDUPLIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Somatarifabancduplic
        {
            get { return  con_somatarifabancduplic; }
            set {  con_somatarifabancduplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_SOMATXBOLETO
        /// Comentário: 
        /// </summary>
        private string con_somatxboleto;
        [XmlElement(ElementName = "CON_SOMATXBOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Somatxboleto
        {
            get { return  con_somatxboleto; }
            set {  con_somatxboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_SOMAVLTARIFAITENSNF
        /// Comentário: 
        /// </summary>
        private string con_somavltarifaitensnf;
        [XmlElement(ElementName = "CON_SOMAVLTARIFAITENSNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Somavltarifaitensnf
        {
            get { return  con_somavltarifaitensnf; }
            set {  con_somavltarifaitensnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_TIPOALIQOUTRASDESP
        /// Comentário: 
        /// </summary>
        private string con_tipoaliqoutrasdesp;
        [XmlElement(ElementName = "CON_TIPOALIQOUTRASDESP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Tipoaliqoutrasdesp
        {
            get { return  con_tipoaliqoutrasdesp; }
            set {  con_tipoaliqoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_TIPOORDENACAONFSAIDA
        /// Comentário: 
        /// </summary>
        private string con_tipoordenacaonfsaida;
        [XmlElement(ElementName = "CON_TIPOORDENACAONFSAIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Con_Tipoordenacaonfsaida
        {
            get { return  con_tipoordenacaonfsaida; }
            set {  con_tipoordenacaonfsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_TIPOTXBOLETO
        /// Comentário: 
        /// </summary>
        private string con_tipotxboleto;
        [XmlElement(ElementName = "CON_TIPOTXBOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Tipotxboleto
        {
            get { return  con_tipotxboleto; }
            set {  con_tipotxboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_TIPOVLMINVENDABK
        /// Comentário: 
        /// </summary>
        private string con_tipovlminvendabk;
        [XmlElement(ElementName = "CON_TIPOVLMINVENDABK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Con_Tipovlminvendabk
        {
            get { return  con_tipovlminvendabk; }
            set {  con_tipovlminvendabk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_TXVENDA
        /// Comentário: 
        /// </summary>
        private decimal con_txvenda;
        [XmlElement(ElementName = "CON_TXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Txvenda
        {
            get { return  con_txvenda; }
            set {  con_txvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USACOMISSAOPORCLIENTE
        /// Comentário: 
        /// </summary>
        private string con_usacomissaoporcliente;
        [XmlElement(ElementName = "CON_USACOMISSAOPORCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usacomissaoporcliente
        {
            get { return  con_usacomissaoporcliente; }
            set {  con_usacomissaoporcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USACOMISSAOPORRCA
        /// Comentário: 
        /// </summary>
        private string con_usacomissaoporrca;
        [XmlElement(ElementName = "CON_USACOMISSAOPORRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usacomissaoporrca
        {
            get { return  con_usacomissaoporrca; }
            set {  con_usacomissaoporrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USACRECLIVENDABALCAO
        /// Comentário: 
        /// </summary>
        private string con_usacreclivendabalcao;
        [XmlElement(ElementName = "CON_USACRECLIVENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usacreclivendabalcao
        {
            get { return  con_usacreclivendabalcao; }
            set {  con_usacreclivendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USACRECLIVENDATLMKT
        /// Comentário: 
        /// </summary>
        private string con_usacreclivendatlmkt;
        [XmlElement(ElementName = "CON_USACRECLIVENDATLMKT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usacreclivendatlmkt
        {
            get { return  con_usacreclivendatlmkt; }
            set {  con_usacreclivendatlmkt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USACREDRCA
        /// Comentário: 
        /// </summary>
        private string con_usacredrca;
        [XmlElement(ElementName = "CON_USACREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usacredrca
        {
            get { return  con_usacredrca; }
            set {  con_usacredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USAPRZADICIONALVENDA
        /// Comentário: 
        /// </summary>
        private string con_usaprzadicionalvenda;
        [XmlElement(ElementName = "CON_USAPRZADICIONALVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usaprzadicionalvenda
        {
            get { return  con_usaprzadicionalvenda; }
            set {  con_usaprzadicionalvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USARREDUCAOICMSABATRANSF
        /// Comentário: 
        /// </summary>
        private string con_usarreducaoicmsabatransf;
        [XmlElement(ElementName = "CON_USARREDUCAOICMSABATRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usarreducaoicmsabatransf
        {
            get { return  con_usarreducaoicmsabatransf; }
            set {  con_usarreducaoicmsabatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USARTRIBUTACAOTRANSFTV10
        /// Comentário: 
        /// </summary>
        private string con_usartributacaotransftv10;
        [XmlElement(ElementName = "CON_USARTRIBUTACAOTRANSFTV10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usartributacaotransftv10
        {
            get { return  con_usartributacaotransftv10; }
            set {  con_usartributacaotransftv10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_USATRIBUTACAOPORUF
        /// Comentário: 
        /// </summary>
        private string con_usatributacaoporuf;
        [XmlElement(ElementName = "CON_USATRIBUTACAOPORUF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Usatributacaoporuf
        {
            get { return  con_usatributacaoporuf; }
            set {  con_usatributacaoporuf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_UTILIZAPERCBASEREDPF
        /// Comentário: 
        /// </summary>
        private string con_utilizapercbaseredpf;
        [XmlElement(ElementName = "CON_UTILIZAPERCBASEREDPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Con_Utilizapercbaseredpf
        {
            get { return  con_utilizapercbaseredpf; }
            set {  con_utilizapercbaseredpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_VLMAXTARIFABANC
        /// Comentário: 
        /// </summary>
        private decimal con_vlmaxtarifabanc;
        [XmlElement(ElementName = "CON_VLMAXTARIFABANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Vlmaxtarifabanc
        {
            get { return  con_vlmaxtarifabanc; }
            set {  con_vlmaxtarifabanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_VLMINTARIFABANC
        /// Comentário: 
        /// </summary>
        private decimal con_vlmintarifabanc;
        [XmlElement(ElementName = "CON_VLMINTARIFABANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Vlmintarifabanc
        {
            get { return  con_vlmintarifabanc; }
            set {  con_vlmintarifabanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CON_VLTARIFA
        /// Comentário: 
        /// </summary>
        private decimal con_vltarifa;
        [XmlElement(ElementName = "CON_VLTARIFA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Con_Vltarifa
        {
            get { return  con_vltarifa; }
            set {  con_vltarifa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIL_ALTERARCOBBKCHFATURAMENTO
        /// Comentário: 
        /// </summary>
        private string fil_alterarcobbkchfaturamento;
        [XmlElement(ElementName = "FIL_ALTERARCOBBKCHFATURAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fil_Alterarcobbkchfaturamento
        {
            get { return  fil_alterarcobbkchfaturamento; }
            set {  fil_alterarcobbkchfaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIL_CALCULARIPIVENDA
        /// Comentário: 
        /// </summary>
        private string fil_calcularipivenda;
        [XmlElement(ElementName = "FIL_CALCULARIPIVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fil_Calcularipivenda
        {
            get { return  fil_calcularipivenda; }
            set {  fil_calcularipivenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIL_PERCICMSSIMPLESNAC
        /// Comentário: 
        /// </summary>
        private decimal fil_percicmssimplesnac;
        [XmlElement(ElementName = "FIL_PERCICMSSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Fil_Percicmssimplesnac
        {
            get { return  fil_percicmssimplesnac; }
            set {  fil_percicmssimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIL_PERMITEAGRUPARBOLETOS
        /// Comentário: 
        /// </summary>
        private string fil_permiteagruparboletos;
        [XmlElement(ElementName = "FIL_PERMITEAGRUPARBOLETOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fil_Permiteagruparboletos
        {
            get { return  fil_permiteagruparboletos; }
            set {  fil_permiteagruparboletos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIL_USADIAUTILFILIAL
        /// Comentário: 
        /// </summary>
        private string fil_usadiautilfilial;
        [XmlElement(ElementName = "FIL_USADIAUTILFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fil_Usadiautilfilial
        {
            get { return  fil_usadiautilfilial; }
            set {  fil_usadiautilfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPOSTOCOMISSAORCA
        /// Comentário: 
        /// </summary>
        private string impostocomissaorca;
        [XmlElement(ElementName = "IMPOSTOCOMISSAORCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Impostocomissaorca
        {
            get { return  impostocomissaorca; }
            set {  impostocomissaorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MSG
        /// Comentário: 
        /// </summary>
        private string msg;
        [XmlElement(ElementName = "MSG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Msg
        {
            get { return  msg; }
            set {  msg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
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
        /// Propriedade referente ao campo: SEQ
        /// Comentário: 
        /// </summary>
        private decimal seq;
        [XmlElement(ElementName = "SEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Seq
        {
            get { return  seq; }
            set {  seq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACRECLIVENDACALLCENTER
        /// Comentário: 
        /// </summary>
        private string usacreclivendacallcenter;
        [XmlElement(ElementName = "USACRECLIVENDACALLCENTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacreclivendacallcenter
        {
            get { return  usacreclivendacallcenter; }
            set {  usacreclivendacallcenter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACREDCLITODASFILIAIS
        /// Comentário: 
        /// </summary>
        private string usacredclitodasfiliais;
        [XmlElement(ElementName = "USACREDCLITODASFILIAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacredclitodasfiliais
        {
            get { return  usacredclitodasfiliais; }
            set {  usacredclitodasfiliais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATXBOLETOAPENASUMANFMESMOCAR
        /// Comentário: 
        /// </summary>
        private string usatxboletoapenasumanfmesmocar;
        [XmlElement(ElementName = "USATXBOLETOAPENASUMANFMESMOCAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatxboletoapenasumanfmesmocar
        {
            get { return  usatxboletoapenasumanfmesmocar; }
            set {  usatxboletoapenasumanfmesmocar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRREDBCMA
        /// Comentário: 
        /// </summary>
        private decimal vlrredbcma;
        [XmlElement(ElementName = "VLRREDBCMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrredbcma
        {
            get { return  vlrredbcma; }
            set {  vlrredbcma = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCParamfat()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARAMFAT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCParamfat> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParamfat>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCParamfat> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParamfat>(where);
        }

        #endregion
    }
}
