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
    /// Classe referente a tabela PCNfbasesaid
    /// </summary>
    [XmlType("PCNFBASESAID")]
    public class PCNfbasesaid : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BASEST
        /// Coment�rio: 
        /// </summary>
        private decimal basest;
        [XmlElement(ElementName = "BASEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Basest
        {
            get { return  basest; }
            set {  basest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASESTFORANF
        /// Coment�rio: Indica a base do ST fora da nota fiscal.
        /// </summary>
        private decimal basestforanf;
        [XmlElement(ElementName = "BASESTFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Basestforanf
        {
            get { return  basestforanf; }
            set {  basestforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BCIMPESTADUAL
        /// Coment�rio: 
        /// </summary>
        private decimal bcimpestadual;
        [XmlElement(ElementName = "BCIMPESTADUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Bcimpestadual
        {
            get { return  bcimpestadual; }
            set {  bcimpestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGC
        /// Coment�rio: Indica o CNPJ do cliente.
        /// </summary>
        private string cgc;
        [XmlElement(ElementName = "CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgc
        {
            get { return  cgc; }
            set {  cgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE
        /// Coment�rio: Indica a raz�o social do cliente.
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Cliente
        {
            get { return  cliente; }
            set {  cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONT
        /// Coment�rio: 
        /// </summary>
        private string codcont;
        [XmlElement(ElementName = "CODCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codcont
        {
            get { return  codcont; }
            set {  codcont = value; }
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
        /// Propriedade referente ao campo: CODFISCAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODOPER
        /// Coment�rio: Indica o c�digo da opera��o.
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTGERA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtgera;
        [XmlElement(ElementName = "DTGERA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtgera
        {
            get { return  dtgera; }
            set {  dtgera = value; }
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
        /// Propriedade referente ao campo: ESPECIE
        /// Coment�rio: 
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLAG
        /// Coment�rio: 
        /// </summary>
        private string flag;
        [XmlElement(ElementName = "FLAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Flag
        {
            get { return  flag; }
            set {  flag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IE
        /// Coment�rio: Indica a insc. estadual do cliente
        /// </summary>
        private string ie;
        [XmlElement(ElementName = "IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ie
        {
            get { return  ie; }
            set {  ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Coment�rio: 
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICM
        /// Coment�rio: 
        /// </summary>
        private decimal percicm;
        [XmlElement(ElementName = "PERCICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicm
        {
            get { return  percicm; }
            set {  percicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMNAOTRIB
        /// Coment�rio: Percentual do ICMS n�o tributado
        /// </summary>
        private decimal percicmnaotrib;
        [XmlElement(ElementName = "PERCICMNAOTRIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicmnaotrib
        {
            get { return  percicmnaotrib; }
            set {  percicmnaotrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI
        /// Coment�rio: 
        /// </summary>
        private decimal percipi;
        [XmlElement(ElementName = "PERCIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percipi
        {
            get { return  percipi; }
            set {  percipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNITCONT
        /// Coment�rio: 
        /// </summary>
        private decimal punitcont;
        [XmlElement(ElementName = "PUNITCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Punitcont
        {
            get { return  punitcont; }
            set {  punitcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONT
        /// Coment�rio: 
        /// </summary>
        private decimal qtcont;
        [XmlElement(ElementName = "QTCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtcont
        {
            get { return  qtcont; }
            set {  qtcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Coment�rio: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Coment�rio: Situa��o Tribut�ria do registro
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Coment�rio: 
        /// </summary>
        private decimal st;
        [XmlElement(ElementName = "ST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal St
        {
            get { return  st; }
            set {  st = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBSERIE
        /// Coment�rio: Indica a subs�rie da nota fiscal.
        /// </summary>
        private string subserie;
        [XmlElement(ElementName = "SUBSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Subserie
        {
            get { return  subserie; }
            set {  subserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFJ
        /// Coment�rio: 
        /// </summary>
        private string tipofj;
        [XmlElement(ElementName = "TIPOFJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofj
        {
            get { return  tipofj; }
            set {  tipofj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOREGISTRO
        /// Coment�rio: Identifica o tipo do registro do livro fiscal (N - normal, D - Despesas Acess�rias e F - Frete). 
        /// </summary>
        private string tiporegistro;
        [XmlElement(ElementName = "TIPOREGISTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tiporegistro
        {
            get { return  tiporegistro; }
            set {  tiporegistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Coment�rio: 
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFFILIAL
        /// Coment�rio: Indica a UF da filial.
        /// </summary>
        private string uffilial;
        [XmlElement(ElementName = "UFFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uffilial
        {
            get { return  uffilial; }
            set {  uffilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASE
        /// Coment�rio: 
        /// </summary>
        private decimal vlbase;
        [XmlElement(ElementName = "VLBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbase
        {
            get { return  vlbase; }
            set {  vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEBCR
        /// Coment�rio: Valor Base de c�lculo BCR. 
        /// </summary>
        private decimal vlbasebcr;
        [XmlElement(ElementName = "VLBASEBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbasebcr
        {
            get { return  vlbasebcr; }
            set {  vlbasebcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEFRETE
        /// Coment�rio: Indica o valor base do frete na nota fiscal.
        /// </summary>
        private decimal vlbasefrete;
        [XmlElement(ElementName = "VLBASEFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbasefrete
        {
            get { return  vlbasefrete; }
            set {  vlbasefrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEIPI
        /// Coment�rio: 
        /// </summary>
        private decimal vlbaseipi;
        [XmlElement(ElementName = "VLBASEIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbaseipi
        {
            get { return  vlbaseipi; }
            set {  vlbaseipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEISENTASIPI
        /// Coment�rio: Indica o valor base n�o tributada do IPI para isentas.
        /// </summary>
        private decimal vlbaseisentasipi;
        [XmlElement(ElementName = "VLBASEISENTASIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlbaseisentasipi
        {
            get { return  vlbaseisentasipi; }
            set {  vlbaseisentasipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASENAOTRIB
        /// Coment�rio: Indica o valor base n�o tributado.
        /// </summary>
        private decimal vlbasenaotrib;
        [XmlElement(ElementName = "VLBASENAOTRIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbasenaotrib
        {
            get { return  vlbasenaotrib; }
            set {  vlbasenaotrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEOUTRASDESP
        /// Coment�rio: Indica o valor base despesas acessorias na nota fiscal.
        /// </summary>
        private decimal vlbaseoutrasdesp;
        [XmlElement(ElementName = "VLBASEOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbaseoutrasdesp
        {
            get { return  vlbaseoutrasdesp; }
            set {  vlbaseoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEOUTRASIPI
        /// Coment�rio: Indica o valor base n�o tributada do IPI para outras.
        /// </summary>
        private decimal vlbaseoutrasipi;
        [XmlElement(ElementName = "VLBASEOUTRASIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlbaseoutrasipi
        {
            get { return  vlbaseoutrasipi; }
            set {  vlbaseoutrasipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASERED_DAPI
        /// Coment�rio: Valor de redu��o de base de c�lculo para DAPI no campo de observa��o. 
        /// </summary>
        private decimal vlbasered_dapi;
        [XmlElement(ElementName = "VLBASERED_DAPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbasered_Dapi
        {
            get { return  vlbasered_dapi; }
            set {  vlbasered_dapi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASE_REDUCAO
        /// Coment�rio: Indica o valor da redu��o de base de ICMS.
        /// </summary>
        private decimal vlbase_reducao;
        [XmlElement(ElementName = "VLBASE_REDUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbase_Reducao
        {
            get { return  vlbase_reducao; }
            set {  vlbase_reducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Coment�rio: Indica o valor do COFINS.
        /// </summary>
        private decimal vlcofins;
        [XmlElement(ElementName = "VLCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlcofins
        {
            get { return  vlcofins; }
            set {  vlcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDPRESUMIDO
        /// Coment�rio: Valor do cr�dito presumido.
        /// </summary>
        private decimal vlcredpresumido;
        [XmlElement(ElementName = "VLCREDPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Vlcredpresumido
        {
            get { return  vlcredpresumido; }
            set {  vlcredpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCREDUCAOCOFINS
        /// Coment�rio: Valor de Desconto da Redu��o do COFINS
        /// </summary>
        private decimal vldescreducaocofins;
        [XmlElement(ElementName = "VLDESCREDUCAOCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vldescreducaocofins
        {
            get { return  vldescreducaocofins; }
            set {  vldescreducaocofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCREDUCAOPIS
        /// Coment�rio: Valor de Desconto da Redu��o do PIS
        /// </summary>
        private decimal vldescreducaopis;
        [XmlElement(ElementName = "VLDESCREDUCAOPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vldescreducaopis
        {
            get { return  vldescreducaopis; }
            set {  vldescreducaopis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESDOBRADO
        /// Coment�rio: 
        /// </summary>
        private decimal vldesdobrado;
        [XmlElement(ElementName = "VLDESDOBRADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldesdobrado
        {
            get { return  vldesdobrado; }
            set {  vldesdobrado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Coment�rio: Indica o valor do frete na nota fiscal.
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Coment�rio: 
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSDIFERIDO
        /// Coment�rio: Valor do ICMS Diferido
        /// </summary>
        private decimal vlicmsdiferido;
        [XmlElement(ElementName = "VLICMSDIFERIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicmsdiferido
        {
            get { return  vlicmsdiferido; }
            set {  vlicmsdiferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSNAOTRIB
        /// Coment�rio: Valor do ICMS n�o tributado
        /// </summary>
        private decimal vlicmsnaotrib;
        [XmlElement(ElementName = "VLICMSNAOTRIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicmsnaotrib
        {
            get { return  vlicmsnaotrib; }
            set {  vlicmsnaotrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIMPESTADUAL
        /// Coment�rio: 
        /// </summary>
        private decimal vlimpestadual;
        [XmlElement(ElementName = "VLIMPESTADUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlimpestadual
        {
            get { return  vlimpestadual; }
            set {  vlimpestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Coment�rio: 
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISENTAS
        /// Coment�rio: 
        /// </summary>
        private decimal vlisentas;
        [XmlElement(ElementName = "VLISENTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlisentas
        {
            get { return  vlisentas; }
            set {  vlisentas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISENTAS_DAPI
        /// Coment�rio: Valor de isentas para DAPI no campo de observa��o. 
        /// </summary>
        private decimal vlisentas_dapi;
        [XmlElement(ElementName = "VLISENTAS_DAPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlisentas_Dapi
        {
            get { return  vlisentas_dapi; }
            set {  vlisentas_dapi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISENTASIPI
        /// Coment�rio: Indica o valor de isen��o do IPI.
        /// </summary>
        private decimal vlisentasipi;
        [XmlElement(ElementName = "VLISENTASIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlisentasipi
        {
            get { return  vlisentasipi; }
            set {  vlisentasipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLNAOTRIB_DAPI
        /// Coment�rio: Valor de n�o tributados para DAPI no campo de observa��o. 
        /// </summary>
        private decimal vlnaotrib_dapi;
        [XmlElement(ElementName = "VLNAOTRIB_DAPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlnaotrib_Dapi
        {
            get { return  vlnaotrib_dapi; }
            set {  vlnaotrib_dapi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRAS
        /// Coment�rio: 
        /// </summary>
        private decimal vloutras;
        [XmlElement(ElementName = "VLOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vloutras
        {
            get { return  vloutras; }
            set {  vloutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRAS_DAPI
        /// Coment�rio: Valor de outras para DAPI no campo de observa��o. 
        /// </summary>
        private decimal vloutras_dapi;
        [XmlElement(ElementName = "VLOUTRAS_DAPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vloutras_Dapi
        {
            get { return  vloutras_dapi; }
            set {  vloutras_dapi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Coment�rio: Indica o valor despesas acessorias na nota fiscal.
        /// </summary>
        private decimal vloutrasdesp;
        [XmlElement(ElementName = "VLOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vloutrasdesp
        {
            get { return  vloutrasdesp; }
            set {  vloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASIPI
        /// Coment�rio: indica o valor de outras do IPI.
        /// </summary>
        private decimal vloutrasipi;
        [XmlElement(ElementName = "VLOUTRASIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vloutrasipi
        {
            get { return  vloutrasipi; }
            set {  vloutrasipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Coment�rio: Indica o valor do PIS.
        /// </summary>
        private decimal vlpis;
        [XmlElement(ElementName = "VLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlpis
        {
            get { return  vlpis; }
            set {  vlpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPISRETIDO
        /// Coment�rio: 
        /// </summary>
        private decimal vlpisretido;
        [XmlElement(ElementName = "VLPISRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpisretido
        {
            get { return  vlpisretido; }
            set {  vlpisretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREPASSE
        /// Coment�rio: 
        /// </summary>
        private decimal vlrepasse;
        [XmlElement(ElementName = "VLREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlrepasse
        {
            get { return  vlrepasse; }
            set {  vlrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLST
        /// Coment�rio: 
        /// </summary>
        private decimal vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlst
        {
            get { return  vlst; }
            set {  vlst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTBCR
        /// Coment�rio: Valor de BCR. 
        /// </summary>
        private decimal vlstbcr;
        [XmlElement(ElementName = "VLSTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlstbcr
        {
            get { return  vlstbcr; }
            set {  vlstbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLST_DAPI
        /// Coment�rio: Valor de substitui��o tribut�ria para DAPI no campo de observa��o. 
        /// </summary>
        private decimal vlst_dapi;
        [XmlElement(ElementName = "VLST_DAPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlst_Dapi
        {
            get { return  vlst_dapi; }
            set {  vlst_dapi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSTFORANF
        /// Coment�rio: Indica o valor de ST fora da nota fiscal.
        /// </summary>
        private decimal vlstforanf;
        [XmlElement(ElementName = "VLSTFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlstforanf
        {
            get { return  vlstforanf; }
            set {  vlstforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUSPENSAS_DAPI
        /// Coment�rio: Valor de suspensas para DAPI no campo de observa��o. 
        /// </summary>
        private decimal vlsuspensas_dapi;
        [XmlElement(ElementName = "VLSUSPENSAS_DAPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlsuspensas_Dapi
        {
            get { return  vlsuspensas_dapi; }
            set {  vlsuspensas_dapi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Coment�rio: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCNfbasesaid()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFBASESAID";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCNfbasesaid> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfbasesaid>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCNfbasesaid> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfbasesaid>(where);
        }

        #endregion
    }
}
