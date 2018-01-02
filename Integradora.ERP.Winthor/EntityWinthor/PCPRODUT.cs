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
    /// Classe referente a tabela PCProdut
    /// </summary>
    [XmlType("PCPRODUT")]
    public class PCProdut : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ABASTEPALETE
        /// Coment�rio: 
        /// </summary>
        private string abastepalete;
        [XmlElement(ElementName = "ABASTEPALETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abastepalete
        {
            get { return  abastepalete; }
            set {  abastepalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ABASTEPALETECX
        /// Coment�rio: 
        /// </summary>
        private string abastepaletecx;
        [XmlElement(ElementName = "ABASTEPALETECX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abastepaletecx
        {
            get { return  abastepaletecx; }
            set {  abastepaletecx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDAFRACAO
        /// Coment�rio: 
        /// </summary>
        private string aceitavendafracao;
        [XmlElement(ElementName = "ACEITAVENDAFRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendafracao
        {
            get { return  aceitavendafracao; }
            set {  aceitavendafracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQAVULSADARE
        /// Coment�rio: 
        /// </summary>
        private decimal? aliqavulsadare;
        [XmlElement(ElementName = "ALIQAVULSADARE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Aliqavulsadare
        {
            get { return  aliqavulsadare; }
            set {  aliqavulsadare = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Coment�rio: Altura do Produto.
        /// </summary>
        private decimal? altura;
        [XmlElement(ElementName = "ALTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Altura
        {
            get { return  altura; }
            set {  altura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURAARM
        /// Coment�rio: 
        /// </summary>
        private decimal? alturaarm;
        [XmlElement(ElementName = "ALTURAARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Alturaarm
        {
            get { return  alturaarm; }
            set {  alturaarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURAM3
        /// Coment�rio: Altura do produto na norma pallete.
        /// </summary>
        private decimal? alturam3;
        [XmlElement(ElementName = "ALTURAM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Alturam3
        {
            get { return  alturam3; }
            set {  alturam3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURAPAL
        /// Coment�rio: 
        /// </summary>
        private decimal? alturapal;
        [XmlElement(ElementName = "ALTURAPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Alturapal
        {
            get { return  alturapal; }
            set {  alturapal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTURATOTAL
        /// Coment�rio: Altura Total do Produto.
        /// </summary>
        private decimal? alturatotal;
        [XmlElement(ElementName = "ALTURATOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Alturatotal
        {
            get { return  alturatotal; }
            set {  alturatotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANALISEDESC
        /// Coment�rio: Descontos de An�lise.
        /// </summary>
        private string analisedesc;
        [XmlElement(ElementName = "ANALISEDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Analisedesc
        {
            get { return  analisedesc; }
            set {  analisedesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANP
        /// Coment�rio: C�digo ANP utilizado em combustiveis.
        /// </summary>
        private decimal? anp;
        [XmlElement(ElementName = "ANP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal? Anp
        {
            get { return  anp; }
            set {  anp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISA
        /// Coment�rio: C�digo do produto na Anvisa.
        /// </summary>
        private string anvisa;
        [XmlElement(ElementName = "ANVISA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Anvisa
        {
            get { return  anvisa; }
            set {  anvisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISACAPINSTAL
        /// Coment�rio: 
        /// </summary>
        private decimal? anvisacapinstal;
        [XmlElement(ElementName = "ANVISACAPINSTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public decimal? Anvisacapinstal
        {
            get { return  anvisacapinstal; }
            set {  anvisacapinstal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISACLASTERAPEUTICA
        /// Coment�rio: 
        /// </summary>
        private string anvisaclasterapeutica;
        [XmlElement(ElementName = "ANVISACLASTERAPEUTICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Anvisaclasterapeutica
        {
            get { return  anvisaclasterapeutica; }
            set {  anvisaclasterapeutica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISACOEFTEC
        /// Coment�rio: 
        /// </summary>
        private string anvisacoeftec;
        [XmlElement(ElementName = "ANVISACOEFTEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Anvisacoeftec
        {
            get { return  anvisacoeftec; }
            set {  anvisacoeftec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISACONCEN
        /// Coment�rio: 
        /// </summary>
        private decimal? anvisaconcen;
        [XmlElement(ElementName = "ANVISACONCEN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Anvisaconcen
        {
            get { return  anvisaconcen; }
            set {  anvisaconcen = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISADESCPRINCAT1
        /// Coment�rio: 
        /// </summary>
        private string anvisadescprincat1;
        [XmlElement(ElementName = "ANVISADESCPRINCAT1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Anvisadescprincat1
        {
            get { return  anvisadescprincat1; }
            set {  anvisadescprincat1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISADESCPRINCAT2
        /// Coment�rio: 
        /// </summary>
        private string anvisadescprincat2;
        [XmlElement(ElementName = "ANVISADESCPRINCAT2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Anvisadescprincat2
        {
            get { return  anvisadescprincat2; }
            set {  anvisadescprincat2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISADESCPRINCAT3
        /// Coment�rio: 
        /// </summary>
        private string anvisadescprincat3;
        [XmlElement(ElementName = "ANVISADESCPRINCAT3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Anvisadescprincat3
        {
            get { return  anvisadescprincat3; }
            set {  anvisadescprincat3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISADESCPRINCAT4
        /// Coment�rio: 
        /// </summary>
        private string anvisadescprincat4;
        [XmlElement(ElementName = "ANVISADESCPRINCAT4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Anvisadescprincat4
        {
            get { return  anvisadescprincat4; }
            set {  anvisadescprincat4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISAFORMAFARM
        /// Coment�rio: 
        /// </summary>
        private string anvisaformafarm;
        [XmlElement(ElementName = "ANVISAFORMAFARM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Anvisaformafarm
        {
            get { return  anvisaformafarm; }
            set {  anvisaformafarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISANUMPRINCAT
        /// Coment�rio: 
        /// </summary>
        private decimal? anvisanumprincat;
        [XmlElement(ElementName = "ANVISANUMPRINCAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Anvisanumprincat
        {
            get { return  anvisanumprincat; }
            set {  anvisanumprincat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISANUMREGMED
        /// Coment�rio: 
        /// </summary>
        private string anvisanumregmed;
        [XmlElement(ElementName = "ANVISANUMREGMED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Anvisanumregmed
        {
            get { return  anvisanumregmed; }
            set {  anvisanumregmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISAQTEMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private decimal? anvisaqtembalagem;
        [XmlElement(ElementName = "ANVISAQTEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Anvisaqtembalagem
        {
            get { return  anvisaqtembalagem; }
            set {  anvisaqtembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISAUNCOEFTEC
        /// Coment�rio: 
        /// </summary>
        private string anvisauncoeftec;
        [XmlElement(ElementName = "ANVISAUNCOEFTEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Anvisauncoeftec
        {
            get { return  anvisauncoeftec; }
            set {  anvisauncoeftec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISAUNDOSAG
        /// Coment�rio: 
        /// </summary>
        private string anvisaundosag;
        [XmlElement(ElementName = "ANVISAUNDOSAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Anvisaundosag
        {
            get { return  anvisaundosag; }
            set {  anvisaundosag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISAUSOCONTINUO
        /// Coment�rio: 
        /// </summary>
        private string anvisausocontinuo;
        [XmlElement(ElementName = "ANVISAUSOCONTINUO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Anvisausocontinuo
        {
            get { return  anvisausocontinuo; }
            set {  anvisausocontinuo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANVISAVIAADM
        /// Coment�rio: 
        /// </summary>
        private string anvisaviaadm;
        [XmlElement(ElementName = "ANVISAVIAADM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Anvisaviaadm
        {
            get { return  anvisaviaadm; }
            set {  anvisaviaadm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICACOES
        /// Coment�rio: 
        /// </summary>
        private string aplicacoes;
        [XmlElement(ElementName = "APLICACOES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Aplicacoes
        {
            get { return  aplicacoes; }
            set {  aplicacoes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICPERCIVAPAUTA
        /// Coment�rio: Aplica %IVA sobre a Pauta ST..
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
        /// Propriedade referente ao campo: APLICPERCIVAPAUTAICMSANTECIP
        /// Coment�rio: Aplica IVA sobre valor de pauta ICMS antecipado
        /// </summary>
        private string aplicpercivapautaicmsantecip;
        [XmlElement(ElementName = "APLICPERCIVAPAUTAICMSANTECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicpercivapautaicmsantecip
        {
            get { return  aplicpercivapautaicmsantecip; }
            set {  aplicpercivapautaicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICREDBASEIVAPLIQ
        /// Coment�rio: Aplicar redu��o base IVA pre�o liquido
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
        /// Propriedade referente ao campo: APLICREDBASEIVAPLIQBCR
        /// Coment�rio: Aplicar redu��o base IVA pre�o liquido BCR
        /// </summary>
        private string aplicredbaseivapliqbcr;
        [XmlElement(ElementName = "APLICREDBASEIVAPLIQBCR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicredbaseivapliqbcr
        {
            get { return  aplicredbaseivapliqbcr; }
            set {  aplicredbaseivapliqbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDICMS
        /// Coment�rio: Indica se o produto ser� aproveitado cr�dito ICMS na entrada. 
        /// </summary>
        private string aproveitacredicms;
        [XmlElement(ElementName = "APROVEITACREDICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredicms
        {
            get { return  aproveitacredicms; }
            set {  aproveitacredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDICMSCONT
        /// Coment�rio: Aproveita cr�dito ICMS custo contabil na importa��o
        /// </summary>
        private string aproveitacredicmscont;
        [XmlElement(ElementName = "APROVEITACREDICMSCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredicmscont
        {
            get { return  aproveitacredicmscont; }
            set {  aproveitacredicmscont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDPISCOFINS
        /// Coment�rio: 
        /// </summary>
        private string aproveitacredpiscofins;
        [XmlElement(ElementName = "APROVEITACREDPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredpiscofins
        {
            get { return  aproveitacredpiscofins; }
            set {  aproveitacredpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITACREDPISCOFINSCONT
        /// Coment�rio: Aproveita cr�dito PIS/COFINS custo contabil na importa��o
        /// </summary>
        private string aproveitacredpiscofinscont;
        [XmlElement(ElementName = "APROVEITACREDPISCOFINSCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitacredpiscofinscont
        {
            get { return  aproveitacredpiscofinscont; }
            set {  aproveitacredpiscofinscont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APTO
        /// Coment�rio: 
        /// </summary>
        private decimal? apto;
        [XmlElement(ElementName = "APTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Apto
        {
            get { return  apto; }
            set {  apto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APTOCT
        /// Coment�rio: 
        /// </summary>
        private decimal? aptoct;
        [XmlElement(ElementName = "APTOCT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Aptoct
        {
            get { return  aptoct; }
            set {  aptoct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APTOCX
        /// Coment�rio: 
        /// </summary>
        private decimal? aptocx;
        [XmlElement(ElementName = "APTOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Aptocx
        {
            get { return  aptocx; }
            set {  aptocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APTO2
        /// Coment�rio: 
        /// </summary>
        private decimal? apto2;
        [XmlElement(ElementName = "APTO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Apto2
        {
            get { return  apto2; }
            set {  apto2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Coment�rio: C�digo MD-5 
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
        /// Propriedade referente ao campo: ATUPESOMASTERENT
        /// Coment�rio: Campo para verificar se na entrada do produto tem que validar o peso master
        /// </summary>
        private string atupesomasterent;
        [XmlElement(ElementName = "ATUPESOMASTERENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atupesomasterent
        {
            get { return  atupesomasterent; }
            set {  atupesomasterent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTORIZATIPO4
        /// Coment�rio: 
        /// </summary>
        private string autorizatipo4;
        [XmlElement(ElementName = "AUTORIZATIPO4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autorizatipo4
        {
            get { return  autorizatipo4; }
            set {  autorizatipo4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEPISCOFINSLIT
        /// Coment�rio: Base PIS/COFINS por litragem
        /// </summary>
        private decimal? basepiscofinslit;
        [XmlElement(ElementName = "BASEPISCOFINSLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Basepiscofinslit
        {
            get { return  basepiscofinslit; }
            set {  basepiscofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEPISCOFINSLITIMP
        /// Coment�rio: Base PIS/COFINS por litragem
        /// </summary>
        private decimal? basepiscofinslitimp;
        [XmlElement(ElementName = "BASEPISCOFINSLITIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Basepiscofinslitimp
        {
            get { return  basepiscofinslitimp; }
            set {  basepiscofinslitimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEPISCOFINSLITRAGEM
        /// Coment�rio: Base PIS/COFINS litragem.
        /// </summary>
        private decimal? basepiscofinslitragem;
        [XmlElement(ElementName = "BASEPISCOFINSLITRAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Basepiscofinslitragem
        {
            get { return  basepiscofinslitragem; }
            set {  basepiscofinslitragem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BOLORESLEVEDURAS
        /// Coment�rio: 
        /// </summary>
        private string boloresleveduras;
        [XmlElement(ElementName = "BOLORESLEVEDURAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Boloresleveduras
        {
            get { return  boloresleveduras; }
            set {  boloresleveduras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDIPI
        /// Coment�rio: Calcular Custo com Cr�dito de IPI (Compra). 
        /// </summary>
        private string calccredipi;
        [XmlElement(ElementName = "CALCCREDIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredipi
        {
            get { return  calccredipi; }
            set {  calccredipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDIPICONT
        /// Coment�rio: Calcula cr�dito IPI custo contabil na importa��o
        /// </summary>
        private string calccredipicont;
        [XmlElement(ElementName = "CALCCREDIPICONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredipicont
        {
            get { return  calccredipicont; }
            set {  calccredipicont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMAPAPAL
        /// Coment�rio: 
        /// </summary>
        private decimal? camapapal;
        [XmlElement(ElementName = "CAMAPAPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Camapapal
        {
            get { return  camapapal; }
            set {  camapapal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMPANHA
        /// Coment�rio: 
        /// </summary>
        private string campanha;
        [XmlElement(ElementName = "CAMPANHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Campanha
        {
            get { return  campanha; }
            set {  campanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAPACIDADEPA
        /// Coment�rio: 
        /// </summary>
        private decimal? capacidadepa;
        [XmlElement(ElementName = "CAPACIDADEPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Capacidadepa
        {
            get { return  capacidadepa; }
            set {  capacidadepa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAPACIDADEPICKING
        /// Coment�rio: 
        /// </summary>
        private decimal? capacidadepicking;
        [XmlElement(ElementName = "CAPACIDADEPICKING", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Capacidadepicking
        {
            get { return  capacidadepicking; }
            set {  capacidadepicking = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAPACIDADEPICKINGAL
        /// Coment�rio: Indica capacidade de picking
        /// </summary>
        private decimal? capacidadepickingal;
        [XmlElement(ElementName = "CAPACIDADEPICKINGAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Capacidadepickingal
        {
            get { return  capacidadepickingal; }
            set {  capacidadepickingal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAPACIDADEPICKINGCX
        /// Coment�rio: 
        /// </summary>
        private decimal? capacidadepickingcx;
        [XmlElement(ElementName = "CAPACIDADEPICKINGCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Capacidadepickingcx
        {
            get { return  capacidadepickingcx; }
            set {  capacidadepickingcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAPVOLDNF
        /// Coment�rio: Capacidade volum�trica para gera��o DNF.
        /// </summary>
        private decimal? capvoldnf;
        [XmlElement(ElementName = "CAPVOLDNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Capvoldnf
        {
            get { return  capvoldnf; }
            set {  capvoldnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CATERGORIA
        /// Coment�rio: Categoria de Produtos.
        /// </summary>
        private string catergoria;
        [XmlElement(ElementName = "CATERGORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Catergoria
        {
            get { return  catergoria; }
            set {  catergoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CESTABASICALEGIS
        /// Coment�rio: Cesta B�sica - Legisla��o
        /// </summary>
        private string cestabasicalegis;
        [XmlElement(ElementName = "CESTABASICALEGIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cestabasicalegis
        {
            get { return  cestabasicalegis; }
            set {  cestabasicalegis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHECARMULTIPLOVENDABNF
        /// Coment�rio: Checar m�ltiplo em vendas bonificadas. Verifica obrigatoriedade de venda em quantidades m�ltiplas no caso de pedido de venda bonificado/troca (tps. 5, 6, 11 e 12). 
        /// </summary>
        private string checarmultiplovendabnf;
        [XmlElement(ElementName = "CHECARMULTIPLOVENDABNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Checarmultiplovendabnf
        {
            get { return  checarmultiplovendabnf; }
            set {  checarmultiplovendabnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSE
        /// Coment�rio: 
        /// </summary>
        private string classe;
        [XmlElement(ElementName = "CLASSE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classe
        {
            get { return  classe; }
            set {  classe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSECOMISSAO
        /// Coment�rio: Indica a classe para comissionamento do produto. 
        /// </summary>
        private string classecomissao;
        [XmlElement(ElementName = "CLASSECOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Classecomissao
        {
            get { return  classecomissao; }
            set {  classecomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSECOMPRA
        /// Coment�rio: 
        /// </summary>
        private string classecompra;
        [XmlElement(ElementName = "CLASSECOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classecompra
        {
            get { return  classecompra; }
            set {  classecompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEESTOQUE
        /// Coment�rio: 
        /// </summary>
        private string classeestoque;
        [XmlElement(ElementName = "CLASSEESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classeestoque
        {
            get { return  classeestoque; }
            set {  classeestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEFLOW
        /// Coment�rio: Contempla Fluxo de Produtos
        /// </summary>
        private string classeflow;
        [XmlElement(ElementName = "CLASSEFLOW", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Classeflow
        {
            get { return  classeflow; }
            set {  classeflow = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEMC
        /// Coment�rio: Classe margem do produto
        /// </summary>
        private string classemc;
        [XmlElement(ElementName = "CLASSEMC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classemc
        {
            get { return  classemc; }
            set {  classemc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Coment�rio: Clase venda do produto.
        /// </summary>
        private string classevenda;
        [XmlElement(ElementName = "CLASSEVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classevenda
        {
            get { return  classevenda; }
            set {  classevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSIFICFISCAL
        /// Coment�rio: 
        /// </summary>
        private string classificfiscal;
        [XmlElement(ElementName = "CLASSIFICFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Classificfiscal
        {
            get { return  classificfiscal; }
            set {  classificfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODACONDICIONAMENTO
        /// Coment�rio: 
        /// </summary>
        private string codacondicionamento;
        [XmlElement(ElementName = "CODACONDICIONAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codacondicionamento
        {
            get { return  codacondicionamento; }
            set {  codacondicionamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAGRUPMAPASEP
        /// Coment�rio: C�digo de Agrupamento de Mapa de Separa��o, utilizado na rotina 203. 
        /// </summary>
        private string codagrupmapasep;
        [XmlElement(ElementName = "CODAGRUPMAPASEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codagrupmapasep
        {
            get { return  codagrupmapasep; }
            set {  codagrupmapasep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: 
        /// </summary>
        private decimal? codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR2
        /// Coment�rio: C�digo barra embalagem master.
        /// </summary>
        private decimal? codauxiliar2;
        [XmlElement(ElementName = "CODAUXILIAR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Codauxiliar2
        {
            get { return  codauxiliar2; }
            set {  codauxiliar2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCARACPROD
        /// Coment�rio: 
        /// </summary>
        private decimal? codcaracprod;
        [XmlElement(ElementName = "CODCARACPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Codcaracprod
        {
            get { return  codcaracprod; }
            set {  codcaracprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Coment�rio: 
        /// </summary>
        private decimal? codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIAWEB
        /// Coment�rio: Codigo da Categoria na WEB
        /// </summary>
        private decimal? codcategoriaweb;
        [XmlElement(ElementName = "CODCATEGORIAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codcategoriaweb
        {
            get { return  codcategoriaweb; }
            set {  codcategoriaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLASSETERAPEUTSNGPC
        /// Coment�rio: C�digo da classe terap�utica na ANVISA
        /// </summary>
        private decimal? codclasseterapeutsngpc;
        [XmlElement(ElementName = "CODCLASSETERAPEUTSNGPC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Codclasseterapeutsngpc
        {
            get { return  codclasseterapeutsngpc; }
            set {  codclasseterapeutsngpc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOR
        /// Coment�rio: 
        /// </summary>
        private decimal? codcor;
        [XmlElement(ElementName = "CODCOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codcor
        {
            get { return  codcor; }
            set {  codcor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEPTOWEB
        /// Coment�rio: Codigo do Departamento na WEB
        /// </summary>
        private decimal? coddeptoweb;
        [XmlElement(ElementName = "CODDEPTOWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Coddeptoweb
        {
            get { return  coddeptoweb; }
            set {  coddeptoweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDISTRIB
        /// Coment�rio: 
        /// </summary>
        private string coddistrib;
        [XmlElement(ElementName = "CODDISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Coddistrib
        {
            get { return  coddistrib; }
            set {  coddistrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOAL
        /// Coment�rio: 
        /// </summary>
        private decimal? codenderecoal;
        [XmlElement(ElementName = "CODENDERECOAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codenderecoal
        {
            get { return  codenderecoal; }
            set {  codenderecoal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOAP
        /// Coment�rio: 
        /// </summary>
        private decimal? codenderecoap;
        [XmlElement(ElementName = "CODENDERECOAP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codenderecoap
        {
            get { return  codenderecoap; }
            set {  codenderecoap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOCX
        /// Coment�rio: 
        /// </summary>
        private decimal? codenderecocx;
        [XmlElement(ElementName = "CODENDERECOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codenderecocx
        {
            get { return  codenderecocx; }
            set {  codenderecocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOPA
        /// Coment�rio: 
        /// </summary>
        private decimal? codenderecopa;
        [XmlElement(ElementName = "CODENDERECOPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codenderecopa
        {
            get { return  codenderecopa; }
            set {  codenderecopa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Coment�rio: 
        /// </summary>
        private decimal? codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal? Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPE
        /// Coment�rio: 
        /// </summary>
        private decimal? codequipe;
        [XmlElement(ElementName = "CODEQUIPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codequipe
        {
            get { return  codequipe; }
            set {  codequipe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEXCECAOPISCOFINS
        /// Coment�rio: C�digo da exce��o PIS/COFINS
        /// </summary>
        private decimal? codexcecaopiscofins;
        [XmlElement(ElementName = "CODEXCECAOPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codexcecaopiscofins
        {
            get { return  codexcecaopiscofins; }
            set {  codexcecaopiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFAB
        /// Coment�rio: 
        /// </summary>
        private string codfab;
        [XmlElement(ElementName = "CODFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Codfab
        {
            get { return  codfab; }
            set {  codfab = value; }
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
        /// Propriedade referente ao campo: CODFILIALPRODUTORA
        /// Coment�rio: 
        /// </summary>
        private string codfilialprodutora;
        [XmlElement(ElementName = "CODFILIALPRODUTORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialprodutora
        {
            get { return  codfilialprodutora; }
            set {  codfilialprodutora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Coment�rio: Indica o c�digo da filial retira padr�o.
        /// </summary>
        private string codfilialretira;
        [XmlElement(ElementName = "CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira
        {
            get { return  codfilialretira; }
            set {  codfilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Coment�rio: 
        /// </summary>
        private decimal? codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALBONIFIC
        /// Coment�rio: C�digo Fiscal utilizado nas Entradas Bonificadas. 
        /// </summary>
        private decimal? codfiscalbonific;
        [XmlElement(ElementName = "CODFISCALBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codfiscalbonific
        {
            get { return  codfiscalbonific; }
            set {  codfiscalbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCOCOMPRA
        /// Coment�rio: CFOP Compra e Ordem - Compra
        /// </summary>
        private decimal? codfiscalcocompra;
        [XmlElement(ElementName = "CODFISCALCOCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfiscalcocompra
        {
            get { return  codfiscalcocompra; }
            set {  codfiscalcocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONSIG
        /// Coment�rio: Indica o c�digo fiscal para produto consignado.
        /// </summary>
        private decimal? codfiscalconsig;
        [XmlElement(ElementName = "CODFISCALCONSIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codfiscalconsig
        {
            get { return  codfiscalconsig; }
            set {  codfiscalconsig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCONSIGFAT
        /// Coment�rio: Indica o c�digo fiscal compra produto consigna��o.
        /// </summary>
        private decimal? codfiscalconsigfat;
        [XmlElement(ElementName = "CODFISCALCONSIGFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codfiscalconsigfat
        {
            get { return  codfiscalconsigfat; }
            set {  codfiscalconsigfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALCOREMESSA
        /// Coment�rio: CFOP Compra e Ordem - Remessa
        /// </summary>
        private decimal? codfiscalcoremessa;
        [XmlElement(ElementName = "CODFISCALCOREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfiscalcoremessa
        {
            get { return  codfiscalcoremessa; }
            set {  codfiscalcoremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVFORNEC
        /// Coment�rio: CFOP DEVOLU��O FORNECEDOR 
        /// </summary>
        private decimal? codfiscaldevfornec;
        [XmlElement(ElementName = "CODFISCALDEVFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfiscaldevfornec
        {
            get { return  codfiscaldevfornec; }
            set {  codfiscaldevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVOPLOG
        /// Coment�rio: C�digo Fiscal Devolu��o Transf. Operador Log�stico
        /// </summary>
        private decimal? codfiscaldevoplog;
        [XmlElement(ElementName = "CODFISCALDEVOPLOG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfiscaldevoplog
        {
            get { return  codfiscaldevoplog; }
            set {  codfiscaldevoplog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTOPLOG
        /// Coment�rio: C�digo Fiscal Entrada Transf. Operador Log�stico
        /// </summary>
        private decimal? codfiscalentoplog;
        [XmlElement(ElementName = "CODFISCALENTOPLOG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfiscalentoplog
        {
            get { return  codfiscalentoplog; }
            set {  codfiscalentoplog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTTRANSF
        /// Coment�rio: Indica o c�digo fiscal de entrada por transfer�ncia.
        /// </summary>
        private decimal? codfiscalenttransf;
        [XmlElement(ElementName = "CODFISCALENTTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codfiscalenttransf
        {
            get { return  codfiscalenttransf; }
            set {  codfiscalenttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALENTTV9
        /// Coment�rio: Apresenta o C�digo fiscal de entrada TV9
        /// </summary>
        private decimal? codfiscalenttv9;
        [XmlElement(ElementName = "CODFISCALENTTV9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfiscalenttv9
        {
            get { return  codfiscalenttv9; }
            set {  codfiscalenttv9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALSR
        /// Coment�rio: C�digo Fiscal utilizado nas Entradas de Simples Remessas. 
        /// </summary>
        private decimal? codfiscalsr;
        [XmlElement(ElementName = "CODFISCALSR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codfiscalsr
        {
            get { return  codfiscalsr; }
            set {  codfiscalsr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORMATOPAPEL
        /// Coment�rio: C�digo do formato do papel.
        /// </summary>
        private decimal? codformatopapel;
        [XmlElement(ElementName = "CODFORMATOPAPEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codformatopapel
        {
            get { return  codformatopapel; }
            set {  codformatopapel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
        /// </summary>
        private decimal? codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal? Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCADASTRO
        /// Coment�rio: 
        /// </summary>
        private decimal? codfunccadastro;
        [XmlElement(ElementName = "CODFUNCCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunccadastro
        {
            get { return  codfunccadastro; }
            set {  codfunccadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Coment�rio: 
        /// </summary>
        private decimal? codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGENEROFISCAL
        /// Coment�rio: 
        /// </summary>
        private decimal? codgenerofiscal;
        [XmlElement(ElementName = "CODGENEROFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codgenerofiscal
        {
            get { return  codgenerofiscal; }
            set {  codgenerofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRADE
        /// Coment�rio: 
        /// </summary>
        private decimal? codgrade;
        [XmlElement(ElementName = "CODGRADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codgrade
        {
            get { return  codgrade; }
            set {  codgrade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRULIT
        /// Coment�rio: C�digo do Grupo de Litragem
        /// </summary>
        private string codgrulit;
        [XmlElement(ElementName = "CODGRULIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codgrulit
        {
            get { return  codgrulit; }
            set {  codgrulit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODINFNUTRI
        /// Coment�rio: 
        /// </summary>
        private decimal? codinfnutri;
        [XmlElement(ElementName = "CODINFNUTRI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Codinfnutri
        {
            get { return  codinfnutri; }
            set {  codinfnutri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODINTERNO
        /// Coment�rio: 
        /// </summary>
        private string codinterno;
        [XmlElement(ElementName = "CODINTERNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codinterno
        {
            get { return  codinterno; }
            set {  codinterno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHA
        /// Coment�rio: C�digo da linha de produ��o.
        /// </summary>
        private decimal? codlinha;
        [XmlElement(ElementName = "CODLINHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codlinha
        {
            get { return  codlinha; }
            set {  codlinha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHANESTLE
        /// Coment�rio: C�digo da Linha Nestl�
        /// </summary>
        private decimal? codlinhanestle;
        [XmlElement(ElementName = "CODLINHANESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codlinhanestle
        {
            get { return  codlinhanestle; }
            set {  codlinhanestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHAPRAZO
        /// Coment�rio: Campo num�rico para o usuario informar o Codigo da linha de prazo
        /// </summary>
        private decimal? codlinhaprazo;
        [XmlElement(ElementName = "CODLINHAPRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codlinhaprazo
        {
            get { return  codlinhaprazo; }
            set {  codlinhaprazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHAPROD
        /// Coment�rio: 
        /// </summary>
        private decimal? codlinhaprod;
        [XmlElement(ElementName = "CODLINHAPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codlinhaprod
        {
            get { return  codlinhaprod; }
            set {  codlinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Coment�rio: Indica o peso da embalagem.
        /// </summary>
        private decimal? codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codmarca
        {
            get { return  codmarca; }
            set {  codmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNCMEX
        /// Coment�rio: C�digo de exce��o de NCM
        /// </summary>
        private string codncmex;
        [XmlElement(ElementName = "CODNCMEX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codncmex
        {
            get { return  codncmex; }
            set {  codncmex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNESTLETERCEIROS
        /// Coment�rio: 
        /// </summary>
        private string codnestleterceiros;
        [XmlElement(ElementName = "CODNESTLETERCEIROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Codnestleterceiros
        {
            get { return  codnestleterceiros; }
            set {  codnestleterceiros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODONU
        /// Coment�rio: Indica o n�mero da ONU do produto quimico.
        /// </summary>
        private string codonu;
        [XmlElement(ElementName = "CODONU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codonu
        {
            get { return  codonu; }
            set {  codonu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPASSEFISCAL
        /// Coment�rio: 
        /// </summary>
        private decimal? codpassefiscal;
        [XmlElement(ElementName = "CODPASSEFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codpassefiscal
        {
            get { return  codpassefiscal; }
            set {  codpassefiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRAZOENT
        /// Coment�rio: Campo de liga��o com o Prazo de Entrega (PCPRAZO), que ser� usado para c�lculo da data de entrega do item do pedido de compra.
        /// </summary>
        private string codprazoent;
        [XmlElement(ElementName = "CODPRAZOENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codprazoent
        {
            get { return  codprazoent; }
            set {  codprazoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRINCIPATIVO
        /// Coment�rio: 
        /// </summary>
        private decimal? codprincipativo;
        [XmlElement(ElementName = "CODPRINCIPATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codprincipativo
        {
            get { return  codprincipativo; }
            set {  codprincipativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODANTUTICAD
        /// Coment�rio: C�digo produto antes utilizar cadastro produto Winthor
        /// </summary>
        private string codprodantuticad;
        [XmlElement(ElementName = "CODPRODANTUTICAD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codprodantuticad
        {
            get { return  codprodantuticad; }
            set {  codprodantuticad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODDNF
        /// Coment�rio: C�digo do produto para gera��o DNF.
        /// </summary>
        private decimal? codproddnf;
        [XmlElement(ElementName = "CODPRODDNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Codproddnf
        {
            get { return  codproddnf; }
            set {  codproddnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODEMBALAGEM
        /// Coment�rio: Indica o c�digo da embalagem.
        /// </summary>
        private decimal? codprodembalagem;
        [XmlElement(ElementName = "CODPRODEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprodembalagem
        {
            get { return  codprodembalagem; }
            set {  codprodembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODFORNEC
        /// Coment�rio: C�digo do Produto do Fornecedor
        /// </summary>
        private decimal? codprodfornec;
        [XmlElement(ElementName = "CODPRODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprodfornec
        {
            get { return  codprodfornec; }
            set {  codprodfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODMASTER
        /// Coment�rio: 
        /// </summary>
        private decimal? codprodmaster;
        [XmlElement(ElementName = "CODPRODMASTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprodmaster
        {
            get { return  codprodmaster; }
            set {  codprodmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINC
        /// Coment�rio: 
        /// </summary>
        private decimal? codprodprinc;
        [XmlElement(ElementName = "CODPRODPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprodprinc
        {
            get { return  codprodprinc; }
            set {  codprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODRELEV
        /// Coment�rio: C�digo do produto relevante.
        /// </summary>
        private decimal? codprodrelev;
        [XmlElement(ElementName = "CODPRODRELEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codprodrelev
        {
            get { return  codprodrelev; }
            set {  codprodrelev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODSIMILAR
        /// Coment�rio: 
        /// </summary>
        private decimal? codprodsimilar;
        [XmlElement(ElementName = "CODPRODSIMILAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprodsimilar
        {
            get { return  codprodsimilar; }
            set {  codprodsimilar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODSINTEGRA
        /// Coment�rio: 
        /// </summary>
        private string codprodsintegra;
        [XmlElement(ElementName = "CODPRODSINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codprodsintegra
        {
            get { return  codprodsintegra; }
            set {  codprodsintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRISCO
        /// Coment�rio: 
        /// </summary>
        private string codrisco;
        [XmlElement(ElementName = "CODRISCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codrisco
        {
            get { return  codrisco; }
            set {  codrisco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAULTALTCOM
        /// Coment�rio: C�digo da �ltima rotina que fez atera��o comercial no produto.
        /// </summary>
        private decimal? codrotinaultaltcom;
        [XmlElement(ElementName = "CODROTINAULTALTCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codrotinaultaltcom
        {
            get { return  codrotinaultaltcom; }
            set {  codrotinaultaltcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAULTALTCOMTAB
        /// Coment�rio: c�digo da �ltima rotina que fez atera��o comercial no produto tab.
        /// </summary>
        private decimal? codrotinaultaltcomtab;
        [XmlElement(ElementName = "CODROTINAULTALTCOMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codrotinaultaltcomtab
        {
            get { return  codrotinaultaltcomtab; }
            set {  codrotinaultaltcomtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAULTALTER
        /// Coment�rio: 
        /// </summary>
        private decimal? codrotinaultalter;
        [XmlElement(ElementName = "CODROTINAULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codrotinaultalter
        {
            get { return  codrotinaultalter; }
            set {  codrotinaultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Coment�rio: 
        /// </summary>
        private decimal? codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal? Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSECAOWEB
        /// Coment�rio: Codigo da Se��o na WEB
        /// </summary>
        private decimal? codsecaoweb;
        [XmlElement(ElementName = "CODSECAOWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codsecaoweb
        {
            get { return  codsecaoweb; }
            set {  codsecaoweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINS
        /// Coment�rio: Indica o C�digo da Situa��o Tribut�ria Referente ao PIS/COFINS
        /// </summary>
        private decimal? codsittribpiscofins;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Codsittribpiscofins
        {
            get { return  codsittribpiscofins; }
            set {  codsittribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINSDEV
        /// Coment�rio: C�digo Situa��o Tributaria PIS/COFINS devolu��o
        /// </summary>
        private decimal? codsittribpiscofinsdev;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINSDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Codsittribpiscofinsdev
        {
            get { return  codsittribpiscofinsdev; }
            set {  codsittribpiscofinsdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBST
        /// Coment�rio: GRAVAR O C�DIGO DA SITUA��O TRIBUT�RIA ST
        /// </summary>
        private string codsittribst;
        [XmlElement(ElementName = "CODSITTRIBST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codsittribst
        {
            get { return  codsittribst; }
            set {  codsittribst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIA
        /// Coment�rio: 
        /// </summary>
        private decimal? codsubcategoria;
        [XmlElement(ElementName = "CODSUBCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codsubcategoria
        {
            get { return  codsubcategoria; }
            set {  codsubcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIAWEB
        /// Coment�rio: Codigo da SubCategoria na WEB
        /// </summary>
        private decimal? codsubcategoriaweb;
        [XmlElement(ElementName = "CODSUBCATEGORIAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codsubcategoriaweb
        {
            get { return  codsubcategoriaweb; }
            set {  codsubcategoriaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBMARCA
        /// Coment�rio: Submarca do Produto
        /// </summary>
        private decimal? codsubmarca;
        [XmlElement(ElementName = "CODSUBMARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codsubmarca
        {
            get { return  codsubmarca; }
            set {  codsubmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTABLIT
        /// Coment�rio: C�digo da Tabela de Litragem
        /// </summary>
        private string codtablit;
        [XmlElement(ElementName = "CODTABLIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codtablit
        {
            get { return  codtablit; }
            set {  codtablit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOESTRUTURA
        /// Coment�rio: 
        /// </summary>
        private decimal? codtipoestrutura;
        [XmlElement(ElementName = "CODTIPOESTRUTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Codtipoestrutura
        {
            get { return  codtipoestrutura; }
            set {  codtipoestrutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOESTRUTURAPUL
        /// Coment�rio: 
        /// </summary>
        private decimal? codtipoestruturapul;
        [XmlElement(ElementName = "CODTIPOESTRUTURAPUL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Codtipoestruturapul
        {
            get { return  codtipoestruturapul; }
            set {  codtipoestruturapul = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPORECEIT
        /// Coment�rio: C�DIGO DO TIPO USO RECEITU�RIO.
        /// </summary>
        private decimal? codtiporeceit;
        [XmlElement(ElementName = "CODTIPORECEIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal? Codtiporeceit
        {
            get { return  codtiporeceit; }
            set {  codtiporeceit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOUSOMED
        /// Coment�rio: C�DIGO DO TIPO USO M�DICO.
        /// </summary>
        private decimal? codtipousomed;
        [XmlElement(ElementName = "CODTIPOUSOMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal? Codtipousomed
        {
            get { return  codtipousomed; }
            set {  codtipousomed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRIBPISCOFINS
        /// Coment�rio: C�digo da figura tribut�ria para c�lculo do PIS/COFINS
        /// </summary>
        private decimal? codtribpiscofins;
        [XmlElement(ElementName = "CODTRIBPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codtribpiscofins
        {
            get { return  codtribpiscofins; }
            set {  codtribpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUNIDMEDIDANF
        /// Coment�rio: C�digo da unidade de medida utilizada na Nota Fiscal.
        /// </summary>
        private decimal? codunidmedidanf;
        [XmlElement(ElementName = "CODUNIDMEDIDANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Codunidmedidanf
        {
            get { return  codunidmedidanf; }
            set {  codunidmedidanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUULTALTCOM
        /// Coment�rio: Ultimo usuario altera politica comercial
        /// </summary>
        private decimal? codusuultaltcom;
        [XmlElement(ElementName = "CODUSUULTALTCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codusuultaltcom
        {
            get { return  codusuultaltcom; }
            set {  codusuultaltcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUULTALTCOMTAB
        /// Coment�rio: C�digo do �ltimo usu�rio que fez atera��o comercial no produto.
        /// </summary>
        private decimal? codusuultaltcomtab;
        [XmlElement(ElementName = "CODUSUULTALTCOMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codusuultaltcomtab
        {
            get { return  codusuultaltcomtab; }
            set {  codusuultaltcomtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVASILHAME
        /// Coment�rio: 
        /// </summary>
        private decimal? codvasilhame;
        [XmlElement(ElementName = "CODVASILHAME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codvasilhame
        {
            get { return  codvasilhame; }
            set {  codvasilhame = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COFINSRETIDO
        /// Coment�rio: Percentual de COFINS retido venda.
        /// </summary>
        private decimal? cofinsretido;
        [XmlElement(ElementName = "COFINSRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Cofinsretido
        {
            get { return  cofinsretido; }
            set {  cofinsretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAGRADE
        /// Coment�rio: 
        /// </summary>
        private decimal? colunagrade;
        [XmlElement(ElementName = "COLUNAGRADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Colunagrade
        {
            get { return  colunagrade; }
            set {  colunagrade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COL95
        /// Coment�rio: 
        /// </summary>
        private string col95;
        [XmlElement(ElementName = "COL95", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Col95
        {
            get { return  col95; }
            set {  col95 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOFIXA
        /// Coment�rio: 
        /// </summary>
        private string comissaofixa;
        [XmlElement(ElementName = "COMISSAOFIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comissaofixa
        {
            get { return  comissaofixa; }
            set {  comissaofixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOPORLUCRATIVIDADE
        /// Coment�rio: 
        /// </summary>
        private string comissaoporlucratividade;
        [XmlElement(ElementName = "COMISSAOPORLUCRATIVIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comissaoporlucratividade
        {
            get { return  comissaoporlucratividade; }
            set {  comissaoporlucratividade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOSERVICOPRESTADO
        /// Coment�rio: Comiss�o servi�o prestado.
        /// </summary>
        private decimal? comissaoservicoprestado;
        [XmlElement(ElementName = "COMISSAOSERVICOPRESTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Comissaoservicoprestado
        {
            get { return  comissaoservicoprestado; }
            set {  comissaoservicoprestado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRACONSIGNADO
        /// Coment�rio: Indica o produto em consigna��o.
        /// </summary>
        private string compraconsignado;
        [XmlElement(ElementName = "COMPRACONSIGNADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Compraconsignado
        {
            get { return  compraconsignado; }
            set {  compraconsignado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTOARM
        /// Coment�rio: 
        /// </summary>
        private decimal? comprimentoarm;
        [XmlElement(ElementName = "COMPRIMENTOARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Comprimentoarm
        {
            get { return  comprimentoarm; }
            set {  comprimentoarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTOM3
        /// Coment�rio: Comprimento do produto na norma pallete.
        /// </summary>
        private decimal? comprimentom3;
        [XmlElement(ElementName = "COMPRIMENTOM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Comprimentom3
        {
            get { return  comprimentom3; }
            set {  comprimentom3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCENTRACAO
        /// Coment�rio: Concentra��o do Produto
        /// </summary>
        private decimal? concentracao;
        [XmlElement(ElementName = "CONCENTRACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Concentracao
        {
            get { return  concentracao; }
            set {  concentracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCILIAIMPORTACAO
        /// Coment�rio: Indica se para o produto dever� ter ou n�o concilia��o de importa��o.
        /// </summary>
        private string conciliaimportacao;
        [XmlElement(ElementName = "CONCILIAIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conciliaimportacao
        {
            get { return  conciliaimportacao; }
            set {  conciliaimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFAZ
        /// Coment�rio: 
        /// </summary>
        private string confaz;
        [XmlElement(ElementName = "CONFAZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Confaz
        {
            get { return  confaz; }
            set {  confaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFERENOCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private string conferenocheckout;
        [XmlElement(ElementName = "CONFERENOCHECKOUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferenocheckout
        {
            get { return  conferenocheckout; }
            set {  conferenocheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERARICMSANTECIPCUSTO
        /// Coment�rio: Considerar ICMS Atencipado no Custo.
        /// </summary>
        private string consideraricmsantecipcusto;
        [XmlElement(ElementName = "CONSIDERARICMSANTECIPCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideraricmsantecipcusto
        {
            get { return  consideraricmsantecipcusto; }
            set {  consideraricmsantecipcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIISUSPENSOBASEICMS
        /// Coment�rio: Considera II Suspenso base ICMS.
        /// </summary>
        private string consiisuspensobaseicms;
        [XmlElement(ElementName = "CONSIISUSPENSOBASEICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consiisuspensobaseicms
        {
            get { return  consiisuspensobaseicms; }
            set {  consiisuspensobaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIPISUSPENSOBASEICMS
        /// Coment�rio: Considera IPI Suspenso base ICMS.
        /// </summary>
        private string consipisuspensobaseicms;
        [XmlElement(ElementName = "CONSIPISUSPENSOBASEICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consipisuspensobaseicms
        {
            get { return  consipisuspensobaseicms; }
            set {  consipisuspensobaseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTLOGANALISE
        /// Coment�rio: 
        /// </summary>
        private decimal? contloganalise;
        [XmlElement(ElementName = "CONTLOGANALISE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Contloganalise
        {
            get { return  contloganalise; }
            set {  contloganalise = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTMICROBIANA
        /// Coment�rio: Contamina��o Microbiana.
        /// </summary>
        private string contmicrobiana;
        [XmlElement(ElementName = "CONTMICROBIANA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Contmicrobiana
        {
            get { return  contmicrobiana; }
            set {  contmicrobiana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLADOIBAMA
        /// Coment�rio: Controlado pelo IBAMA
        /// </summary>
        private string controladoibama;
        [XmlElement(ElementName = "CONTROLADOIBAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controladoibama
        {
            get { return  controladoibama; }
            set {  controladoibama = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLANUMSERIA
        /// Coment�rio: Indica se controla o n�mero de s�rie.
        /// </summary>
        private string controlanumseria;
        [XmlElement(ElementName = "CONTROLANUMSERIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlanumseria
        {
            get { return  controlanumseria; }
            set {  controlanumseria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLANUMSERIE
        /// Coment�rio: Indica que o produtco controla n�mero de s�rie.
        /// </summary>
        private string controlanumserie;
        [XmlElement(ElementName = "CONTROLANUMSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlanumserie
        {
            get { return  controlanumserie; }
            set {  controlanumserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLAPATRIMONIO
        /// Coment�rio: Verifica-se se o produto ter� controle ou n�o de numera��o de patrim�nio.
        /// </summary>
        private string controlapatrimonio;
        [XmlElement(ElementName = "CONTROLAPATRIMONIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlapatrimonio
        {
            get { return  controlapatrimonio; }
            set {  controlapatrimonio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLAVALIDADEDOLOTE
        /// Coment�rio: 
        /// </summary>
        private string controlavalidadedolote;
        [XmlElement(ElementName = "CONTROLAVALIDADEDOLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlavalidadedolote
        {
            get { return  controlavalidadedolote; }
            set {  controlavalidadedolote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CORREDOR
        /// Coment�rio: 
        /// </summary>
        private string corredor;
        [XmlElement(ElementName = "CORREDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Corredor
        {
            get { return  corredor; }
            set {  corredor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CSLLRETIDO
        /// Coment�rio: Percentual de CSLL retido venda.
        /// </summary>
        private decimal? csllretido;
        [XmlElement(ElementName = "CSLLRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Csllretido
        {
            get { return  csllretido; }
            set {  csllretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFORNEC
        /// Coment�rio: Custo de precifica��o por fornecedor, calculado a partir do pre�o de tabela do fornecedor informado pelo usu�rio. 
        /// </summary>
        private decimal? custofornec;
        [XmlElement(ElementName = "CUSTOFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Custofornec
        {
            get { return  custofornec; }
            set {  custofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFORNECSEMST
        /// Coment�rio: Valor do Custo Fornecedor sem ST.
        /// </summary>
        private decimal? custofornecsemst;
        [XmlElement(ElementName = "CUSTOFORNECSEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custofornecsemst
        {
            get { return  custofornecsemst; }
            set {  custofornecsemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRA
        /// Coment�rio: 
        /// </summary>
        private decimal? custoproximacompra;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custoproximacompra
        {
            get { return  custoproximacompra; }
            set {  custoproximacompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPROXIMACOMPRASEMST
        /// Coment�rio: Valor do Custo da pr�xima compra sem ST.
        /// </summary>
        private decimal? custoproximacomprasemst;
        [XmlElement(ElementName = "CUSTOPROXIMACOMPRASEMST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custoproximacomprasemst
        {
            get { return  custoproximacomprasemst; }
            set {  custoproximacomprasemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREP
        /// Coment�rio: Custo de reposi��o da fabrica.
        /// </summary>
        private decimal? custorep;
        [XmlElement(ElementName = "CUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custorep
        {
            get { return  custorep; }
            set {  custorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPANT
        /// Coment�rio: Preco de Compra anterior a atualiza��o.
        /// </summary>
        private decimal? custorepant;
        [XmlElement(ElementName = "CUSTOREPANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custorepant
        {
            get { return  custorepant; }
            set {  custorepant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPMC
        /// Coment�rio: 
        /// </summary>
        private decimal? custorepmc;
        [XmlElement(ElementName = "CUSTOREPMC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custorepmc
        {
            get { return  custorepmc; }
            set {  custorepmc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPTAB
        /// Coment�rio: 
        /// </summary>
        private decimal? custoreptab;
        [XmlElement(ElementName = "CUSTOREPTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custoreptab
        {
            get { return  custoreptab; }
            set {  custoreptab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPTABANT
        /// Coment�rio: Gravar o valor do pre�o fabrica anterior.
        /// </summary>
        private decimal? custoreptabant;
        [XmlElement(ElementName = "CUSTOREPTABANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custoreptabant
        {
            get { return  custoreptabant; }
            set {  custoreptabant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPZFM
        /// Coment�rio: 
        /// </summary>
        private decimal? custorepzfm;
        [XmlElement(ElementName = "CUSTOREPZFM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custorepzfm
        {
            get { return  custorepzfm; }
            set {  custorepzfm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPZFMANT
        /// Coment�rio: Gravar o valor do pre�o Fabrica ZF manaus anterior
        /// </summary>
        private decimal? custorepzfmant;
        [XmlElement(ElementName = "CUSTOREPZFMANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custorepzfmant
        {
            get { return  custorepzfmant; }
            set {  custorepzfmant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREPZFMTAB
        /// Coment�rio: 
        /// </summary>
        private decimal? custorepzfmtab;
        [XmlElement(ElementName = "CUSTOREPZFMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Custorepzfmtab
        {
            get { return  custorepzfmtab; }
            set {  custorepzfmtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DADOSTECNICOS
        /// Coment�rio: Informa os dados t�cnicos do produto. 
        /// </summary>
        private string dadostecnicos;
        [XmlElement(ElementName = "DADOSTECNICOS", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Dadostecnicos
        {
            get { return  dadostecnicos; }
            set {  dadostecnicos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAVOCOLLECT
        /// Coment�rio: .
        /// </summary>
        private DateTime? datavocollect;
        [XmlElement(ElementName = "DATAVOCOLLECT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datavocollect
        {
            get { return  datavocollect; }
            set {  datavocollect = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DENOMINACAOCOMUNBRASILEIRA
        /// Coment�rio: 
        /// </summary>
        private string denominacaocomunbrasileira;
        [XmlElement(ElementName = "DENOMINACAOCOMUNBRASILEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Denominacaocomunbrasileira
        {
            get { return  denominacaocomunbrasileira; }
            set {  denominacaocomunbrasileira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DENSIDADE
        /// Coment�rio: Pesquisa de Densidade.
        /// </summary>
        private string densidade;
        [XmlElement(ElementName = "DENSIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Densidade
        {
            get { return  densidade; }
            set {  densidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPOSITO
        /// Coment�rio: 
        /// </summary>
        private decimal? deposito;
        [XmlElement(ElementName = "DEPOSITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Deposito
        {
            get { return  deposito; }
            set {  deposito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPOSITOCX
        /// Coment�rio: 
        /// </summary>
        private decimal? depositocx;
        [XmlElement(ElementName = "DEPOSITOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Depositocx
        {
            get { return  depositocx; }
            set {  depositocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCPAPEL
        /// Coment�rio: Descri��o do produto para sistema DIF-PAPEL IMUNE.
        /// </summary>
        private string descpapel;
        [XmlElement(ElementName = "DESCPAPEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descpapel
        {
            get { return  descpapel; }
            set {  descpapel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO1
        /// Coment�rio: 
        /// </summary>
        private string descricao1;
        [XmlElement(ElementName = "DESCRICAO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao1
        {
            get { return  descricao1; }
            set {  descricao1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO2
        /// Coment�rio: 
        /// </summary>
        private string descricao2;
        [XmlElement(ElementName = "DESCRICAO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao2
        {
            get { return  descricao2; }
            set {  descricao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO3
        /// Coment�rio: 
        /// </summary>
        private string descricao3;
        [XmlElement(ElementName = "DESCRICAO3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao3
        {
            get { return  descricao3; }
            set {  descricao3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO4
        /// Coment�rio: 
        /// </summary>
        private string descricao4;
        [XmlElement(ElementName = "DESCRICAO4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao4
        {
            get { return  descricao4; }
            set {  descricao4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO5
        /// Coment�rio: 
        /// </summary>
        private string descricao5;
        [XmlElement(ElementName = "DESCRICAO5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao5
        {
            get { return  descricao5; }
            set {  descricao5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO6
        /// Coment�rio: 
        /// </summary>
        private string descricao6;
        [XmlElement(ElementName = "DESCRICAO6", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao6
        {
            get { return  descricao6; }
            set {  descricao6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO7
        /// Coment�rio: 
        /// </summary>
        private string descricao7;
        [XmlElement(ElementName = "DESCRICAO7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao7
        {
            get { return  descricao7; }
            set {  descricao7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESINTEGRACAO
        /// Coment�rio: Pesquisa de Desintegra��o.
        /// </summary>
        private string desintegracao;
        [XmlElement(ElementName = "DESINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Desintegracao
        {
            get { return  desintegracao; }
            set {  desintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTAQUEFICHATECNICA
        /// Coment�rio: Indica destaque na ficha t�cnica.
        /// </summary>
        private string destaquefichatecnica;
        [XmlElement(ElementName = "DESTAQUEFICHATECNICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Destaquefichatecnica
        {
            get { return  destaquefichatecnica; }
            set {  destaquefichatecnica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAMETROEXTERNO
        /// Coment�rio: Di�metro externo do produto.
        /// </summary>
        private decimal? diametroexterno;
        [XmlElement(ElementName = "DIAMETROEXTERNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Diametroexterno
        {
            get { return  diametroexterno; }
            set {  diametroexterno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAMETROINTERNO
        /// Coment�rio: Di�metro interno do produto.
        /// </summary>
        private decimal? diametrointerno;
        [XmlElement(ElementName = "DIAMETROINTERNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Diametrointerno
        {
            get { return  diametrointerno; }
            set {  diametrointerno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASCONSECENT
        /// Coment�rio: Dias �teis consecutivos para entrega
        /// </summary>
        private decimal? diasconsecent;
        [XmlElement(ElementName = "DIASCONSECENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Diasconsecent
        {
            get { return  diasconsecent; }
            set {  diasconsecent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRASSINATURA
        /// Coment�rio: Diret�rio da Assinatura.
        /// </summary>
        private string dirassinatura;
        [XmlElement(ElementName = "DIRASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,140)]
        public string Dirassinatura
        {
            get { return  dirassinatura; }
            set {  dirassinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRETORIOFOTOS
        /// Coment�rio: Diret�rio de imagens para e-commerce
        /// </summary>
        private string diretoriofotos;
        [XmlElement(ElementName = "DIRETORIOFOTOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Diretoriofotos
        {
            get { return  diretoriofotos; }
            set {  diretoriofotos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRFOTOPROD
        /// Coment�rio: 
        /// </summary>
        private string dirfotoprod;
        [XmlElement(ElementName = "DIRFOTOPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Dirfotoprod
        {
            get { return  dirfotoprod; }
            set {  dirfotoprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISSOLUCAO
        /// Coment�rio: Pesquisa de Dissolu��o.
        /// </summary>
        private string dissolucao;
        [XmlElement(ElementName = "DISSOLUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Dissolucao
        {
            get { return  dissolucao; }
            set {  dissolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOSEAMENTO
        /// Coment�rio: Pesquisa de Doseamento.
        /// </summary>
        private string doseamento;
        [XmlElement(ElementName = "DOSEAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Doseamento
        {
            get { return  doseamento; }
            set {  doseamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DSCPRODANTUTICAD
        /// Coment�rio: Descri��o produto antes utilizar cadastro produto Winthor
        /// </summary>
        private string dscprodantuticad;
        [XmlElement(ElementName = "DSCPRODANTUTICAD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Dscprodantuticad
        {
            get { return  dscprodantuticad; }
            set {  dscprodantuticad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTCUSTOFORNEC
        /// Coment�rio: Data altera��o custo fornecedor.
        /// </summary>
        private DateTime? dtaltcustofornec;
        [XmlElement(ElementName = "DTALTCUSTOFORNEC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaltcustofornec
        {
            get { return  dtaltcustofornec; }
            set {  dtaltcustofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDOLAR
        /// Coment�rio: 
        /// </summary>
        private string dtdolar;
        [XmlElement(ElementName = "DTDOLAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dtdolar
        {
            get { return  dtdolar; }
            set {  dtdolar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAOWMS
        /// Coment�rio: Data  e hora de exporta��o
        /// </summary>
        private DateTime? dtexportacaowms;
        [XmlElement(ElementName = "DTEXPORTACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaowms
        {
            get { return  dtexportacaowms; }
            set {  dtexportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINUTICODPRODANTUTICAD
        /// Coment�rio: Data final utiliza��o c�digo produto antes utilizar cadastro produto Winthor
        /// </summary>
        private DateTime? dtfinuticodprodantuticad;
        [XmlElement(ElementName = "DTFINUTICODPRODANTUTICAD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinuticodprodantuticad
        {
            get { return  dtfinuticodprodantuticad; }
            set {  dtfinuticodprodantuticad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOWMS
        /// Coment�rio: Data  e hora de importa��o
        /// </summary>
        private DateTime? dtimportacaowms;
        [XmlElement(ElementName = "DTIMPORTACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaowms
        {
            get { return  dtimportacaowms; }
            set {  dtimportacaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTINTEGRACAO
        /// Coment�rio: Data da �ltima importa��o do registro na filial de destino da informa��o.
        /// </summary>
        private DateTime? dtimportintegracao;
        [XmlElement(ElementName = "DTIMPORTINTEGRACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportintegracao
        {
            get { return  dtimportintegracao; }
            set {  dtimportintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICODPRODANTUTICAD
        /// Coment�rio: Data in�cio c�digo produto antes utilizar cadastro produto Winthor
        /// </summary>
        private DateTime? dtinicodprodantuticad;
        [XmlElement(ElementName = "DTINICODPRODANTUTICAD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicodprodantuticad
        {
            get { return  dtinicodprodantuticad; }
            set {  dtinicodprodantuticad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICONTLOTE
        /// Coment�rio: Data de in�cio do controle de validade por lote.
        /// </summary>
        private DateTime? dtinicontlote;
        [XmlElement(ElementName = "DTINICONTLOTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicontlote
        {
            get { return  dtinicontlote; }
            set {  dtinicontlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPRIMOVNOVCODPROD
        /// Coment�rio: Data primeira Movimenta��o novo c�digo produto Winthor
        /// </summary>
        private DateTime? dtprimovnovcodprod;
        [XmlElement(ElementName = "DTPRIMOVNOVCODPROD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprimovnovcodprod
        {
            get { return  dtprimovnovcodprod; }
            set {  dtprimovnovcodprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXEXPURGO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtproxexpurgo;
        [XmlElement(ElementName = "DTPROXEXPURGO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxexpurgo
        {
            get { return  dtproxexpurgo; }
            set {  dtproxexpurgo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTCOM
        /// Coment�rio: Data da ultima altera��o de comiss�o.
        /// </summary>
        private DateTime? dtultaltcom;
        [XmlElement(ElementName = "DTULTALTCOM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltcom
        {
            get { return  dtultaltcom; }
            set {  dtultaltcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTCUSTOREP
        /// Coment�rio: Data da ultima atualiza��o do custo reposi��o da fabrica.
        /// </summary>
        private DateTime? dtultaltcustorep;
        [XmlElement(ElementName = "DTULTALTCUSTOREP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltcustorep
        {
            get { return  dtultaltcustorep; }
            set {  dtultaltcustorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Coment�rio: Data da �ltima altera��o do registro no banco de dados.
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
        /// Propriedade referente ao campo: DTULTALTERSRVPRC
        /// Coment�rio: Indica a data da ultima altera��o nesta tabela.
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
        /// Propriedade referente ao campo: DTULTATUPCOMPRA
        /// Coment�rio: Data da �ltima atualiza��o do pre�o de compra
        /// </summary>
        private DateTime? dtultatupcompra;
        [XmlElement(ElementName = "DTULTATUPCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultatupcompra
        {
            get { return  dtultatupcompra; }
            set {  dtultatupcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTEXPURGO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultexpurgo;
        [XmlElement(ElementName = "DTULTEXPURGO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultexpurgo
        {
            get { return  dtultexpurgo; }
            set {  dtultexpurgo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTVIGENCIAPOLITICA
        /// Coment�rio: Data de virg�ncia da pol�tica comercial
        /// </summary>
        private DateTime? dtvigenciapolitica;
        [XmlElement(ElementName = "DTVIGENCIAPOLITICA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvigenciapolitica
        {
            get { return  dtvigenciapolitica; }
            set {  dtvigenciapolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DV
        /// Coment�rio: 
        /// </summary>
        private decimal? dv;
        [XmlElement(ElementName = "DV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal? Dv
        {
            get { return  dv; }
            set {  dv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFICIENCIAOPERACIONAL
        /// Coment�rio: 
        /// </summary>
        private decimal? eficienciaoperacional;
        [XmlElement(ElementName = "EFICIENCIAOPERACIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Eficienciaoperacional
        {
            get { return  eficienciaoperacional; }
            set {  eficienciaoperacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEMCT
        /// Coment�rio: 
        /// </summary>
        private string embalagemct;
        [XmlElement(ElementName = "EMBALAGEMCT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Embalagemct
        {
            get { return  embalagemct; }
            set {  embalagemct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEMMASTER
        /// Coment�rio: 
        /// </summary>
        private string embalagemmaster;
        [XmlElement(ElementName = "EMBALAGEMMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Embalagemmaster
        {
            get { return  embalagemmaster; }
            set {  embalagemmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIAINFTECNICANFE
        /// Coment�rio: Informa��es T�cnicas
        /// </summary>
        private string enviainftecnicanfe;
        [XmlElement(ElementName = "ENVIAINFTECNICANFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviainftecnicanfe
        {
            get { return  enviainftecnicanfe; }
            set {  enviainftecnicanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIARFORCAVENDAS
        /// Coment�rio: Informa se envia para o for�a de vendas. 
        /// </summary>
        private string enviarforcavendas;
        [XmlElement(ElementName = "ENVIARFORCAVENDAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviarforcavendas
        {
            get { return  enviarforcavendas; }
            set {  enviarforcavendas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIASNGPC
        /// Coment�rio: Envia SNGPC [S-Sim;N-N�o]
        /// </summary>
        private string enviasngpc;
        [XmlElement(ElementName = "ENVIASNGPC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviasngpc
        {
            get { return  enviasngpc; }
            set {  enviasngpc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIFICOATIVIDADEPR
        /// Coment�rio: 
        /// </summary>
        private string especificoatividadepr;
        [XmlElement(ElementName = "ESPECIFICOATIVIDADEPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Especificoatividadepr
        {
            get { return  especificoatividadepr; }
            set {  especificoatividadepr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTFAUREAUS
        /// Coment�rio: 
        /// </summary>
        private string estfaureaus;
        [XmlElement(ElementName = "ESTFAUREAUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Estfaureaus
        {
            get { return  estfaureaus; }
            set {  estfaureaus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUEPORLOTE
        /// Coment�rio: 
        /// </summary>
        private string estoqueporlote;
        [XmlElement(ElementName = "ESTOQUEPORLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estoqueporlote
        {
            get { return  estoqueporlote; }
            set {  estoqueporlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_ANALISEDESC
        /// Coment�rio: Indica se exibe descri��o da an�lise.
        /// </summary>
        private string ex_analisedesc;
        [XmlElement(ElementName = "EX_ANALISEDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Analisedesc
        {
            get { return  ex_analisedesc; }
            set {  ex_analisedesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_BOLORESLEVEDURAS
        /// Coment�rio: Indica se exibe bolores e leveduras.
        /// </summary>
        private string ex_boloresleveduras;
        [XmlElement(ElementName = "EX_BOLORESLEVEDURAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Boloresleveduras
        {
            get { return  ex_boloresleveduras; }
            set {  ex_boloresleveduras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_COL95
        /// Coment�rio: Indica se exibe col 95�.
        /// </summary>
        private string ex_col95;
        [XmlElement(ElementName = "EX_COL95", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Col95
        {
            get { return  ex_col95; }
            set {  ex_col95 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_CONTMICROBIANA
        /// Coment�rio: Indica se exibe contamina��o microbiana.
        /// </summary>
        private string ex_contmicrobiana;
        [XmlElement(ElementName = "EX_CONTMICROBIANA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Contmicrobiana
        {
            get { return  ex_contmicrobiana; }
            set {  ex_contmicrobiana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_DENSIDADE
        /// Coment�rio: Indica se exibe densidade.
        /// </summary>
        private string ex_densidade;
        [XmlElement(ElementName = "EX_DENSIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Densidade
        {
            get { return  ex_densidade; }
            set {  ex_densidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_DESINTEGRACAO
        /// Coment�rio: Indica se exibe desintegra��o.
        /// </summary>
        private string ex_desintegracao;
        [XmlElement(ElementName = "EX_DESINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Desintegracao
        {
            get { return  ex_desintegracao; }
            set {  ex_desintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_DISSOLUCAO
        /// Coment�rio: Indica se exibe dissolu��o.
        /// </summary>
        private string ex_dissolucao;
        [XmlElement(ElementName = "EX_DISSOLUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Dissolucao
        {
            get { return  ex_dissolucao; }
            set {  ex_dissolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_DOSEAMENTO
        /// Coment�rio: Exibir o doseamento do produto.
        /// </summary>
        private string ex_doseamento;
        [XmlElement(ElementName = "EX_DOSEAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Doseamento
        {
            get { return  ex_doseamento; }
            set {  ex_doseamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_ESTFAUREAUS
        /// Coment�rio: Indica se exibe estafilococos aureas.
        /// </summary>
        private string ex_estfaureaus;
        [XmlElement(ElementName = "EX_ESTFAUREAUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Estfaureaus
        {
            get { return  ex_estfaureaus; }
            set {  ex_estfaureaus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_FRIABILIDADE
        /// Coment�rio: Indica se exibe friabilidade.
        /// </summary>
        private string ex_friabilidade;
        [XmlElement(ElementName = "EX_FRIABILIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Friabilidade
        {
            get { return  ex_friabilidade; }
            set {  ex_friabilidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_IDENTIFICACAO
        /// Coment�rio: Indica se exibe identifica��o.
        /// </summary>
        private string ex_identificacao;
        [XmlElement(ElementName = "EX_IDENTIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Identificacao
        {
            get { return  ex_identificacao; }
            set {  ex_identificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_IMPUREZA
        /// Coment�rio: Exibir impureza do produto.
        /// </summary>
        private string ex_impureza;
        [XmlElement(ElementName = "EX_IMPUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Impureza
        {
            get { return  ex_impureza; }
            set {  ex_impureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_LIPIDEO
        /// Coment�rio: Indica se exibe lip�deos.
        /// </summary>
        private string ex_lipideo;
        [XmlElement(ElementName = "EX_LIPIDEO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Lipideo
        {
            get { return  ex_lipideo; }
            set {  ex_lipideo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_MOFADO
        /// Coment�rio: Indica se exibe mofado.
        /// </summary>
        private string ex_mofado;
        [XmlElement(ElementName = "EX_MOFADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Mofado
        {
            get { return  ex_mofado; }
            set {  ex_mofado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_PESQPATOGENOS
        /// Coment�rio: Indica se exibe pesquisa de patogenos.
        /// </summary>
        private string ex_pesqpatogenos;
        [XmlElement(ElementName = "EX_PESQPATOGENOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Pesqpatogenos
        {
            get { return  ex_pesqpatogenos; }
            set {  ex_pesqpatogenos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_PH
        /// Coment�rio: Indica se exibe PH.
        /// </summary>
        private string ex_ph;
        [XmlElement(ElementName = "EX_PH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Ph
        {
            get { return  ex_ph; }
            set {  ex_ph = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTABALANCA
        /// Coment�rio: 
        /// </summary>
        private string exportabalanca;
        [XmlElement(ElementName = "EXPORTABALANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportabalanca
        {
            get { return  exportabalanca; }
            set {  exportabalanca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_PROTEINA
        /// Coment�rio: Indica se exibe proteina.
        /// </summary>
        private string ex_proteina;
        [XmlElement(ElementName = "EX_PROTEINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Proteina
        {
            get { return  ex_proteina; }
            set {  ex_proteina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_SALMONELA
        /// Coment�rio: Indica se exibe salmonela.
        /// </summary>
        private string ex_salmonela;
        [XmlElement(ElementName = "EX_SALMONELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Salmonela
        {
            get { return  ex_salmonela; }
            set {  ex_salmonela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXTIPI
        /// Coment�rio: Exc e��o da TIPI para grava��o do arquivo XML NFe.
        /// </summary>
        private string extipi;
        [XmlElement(ElementName = "EXTIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Extipi
        {
            get { return  extipi; }
            set {  extipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_TOTDEFEITO
        /// Coment�rio: Indica se exibe total de defeitos.
        /// </summary>
        private string ex_totdefeito;
        [XmlElement(ElementName = "EX_TOTDEFEITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Totdefeito
        {
            get { return  ex_totdefeito; }
            set {  ex_totdefeito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_UMIDADE
        /// Coment�rio: Indica se exibe umidade do produto.
        /// </summary>
        private string ex_umidade;
        [XmlElement(ElementName = "EX_UMIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Umidade
        {
            get { return  ex_umidade; }
            set {  ex_umidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_UNIFORMIDADE
        /// Coment�rio: Indica se exibe uniformidades.
        /// </summary>
        private string ex_uniformidade;
        [XmlElement(ElementName = "EX_UNIFORMIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Uniformidade
        {
            get { return  ex_uniformidade; }
            set {  ex_uniformidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_VLCALORICO
        /// Coment�rio: Indica se exibe valor calorico.
        /// </summary>
        private string ex_vlcalorico;
        [XmlElement(ElementName = "EX_VLCALORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Vlcalorico
        {
            get { return  ex_vlcalorico; }
            set {  ex_vlcalorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EX_VOLPESMED
        /// Coment�rio: Indica se exibe volume e peso m�dio.
        /// </summary>
        private string ex_volpesmed;
        [XmlElement(ElementName = "EX_VOLPESMED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ex_Volpesmed
        {
            get { return  ex_volpesmed; }
            set {  ex_volpesmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FARMACIAPOPULAR
        /// Coment�rio: Produto da Farm�cia Popular
        /// </summary>
        private string farmaciapopular;
        [XmlElement(ElementName = "FARMACIAPOPULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Farmaciapopular
        {
            get { return  farmaciapopular; }
            set {  farmaciapopular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCONVDNF
        /// Coment�rio: Fator de convers�o a aplicar sobre a unidade de venda para gera��o DNF.
        /// </summary>
        private decimal? fatorconvdnf;
        [XmlElement(ElementName = "FATORCONVDNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Fatorconvdnf
        {
            get { return  fatorconvdnf; }
            set {  fatorconvdnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCONVERSAOKG
        /// Coment�rio: Fator de convers�o do peso.
        /// </summary>
        private decimal? fatorconversaokg;
        [XmlElement(ElementName = "FATORCONVERSAOKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Fatorconversaokg
        {
            get { return  fatorconversaokg; }
            set {  fatorconversaokg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCONVERSAONESTLE
        /// Coment�rio: 
        /// </summary>
        private decimal? fatorconversaonestle;
        [XmlElement(ElementName = "FATORCONVERSAONESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Fatorconversaonestle
        {
            get { return  fatorconversaonestle; }
            set {  fatorconversaonestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCONVTRIB
        /// Coment�rio: Fator Convers�o NF-e
        /// </summary>
        private decimal? fatorconvtrib;
        [XmlElement(ElementName = "FATORCONVTRIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Fatorconvtrib
        {
            get { return  fatorconvtrib; }
            set {  fatorconvtrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORTRANSF
        /// Coment�rio: 
        /// </summary>
        private decimal? fatortransf;
        [XmlElement(ElementName = "FATORTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Fatortransf
        {
            get { return  fatortransf; }
            set {  fatortransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORUNFARM
        /// Coment�rio: 
        /// </summary>
        private decimal? fatorunfarm;
        [XmlElement(ElementName = "FATORUNFARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Fatorunfarm
        {
            get { return  fatorunfarm; }
            set {  fatorunfarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLAGS
        /// Coment�rio: 
        /// </summary>
        private string flags;
        [XmlElement(ElementName = "FLAGS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Flags
        {
            get { return  flags; }
            set {  flags = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLAG0
        /// Coment�rio: 
        /// </summary>
        private string flag0;
        [XmlElement(ElementName = "FLAG0", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Flag0
        {
            get { return  flag0; }
            set {  flag0 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLAG1
        /// Coment�rio: 
        /// </summary>
        private string flag1;
        [XmlElement(ElementName = "FLAG1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Flag1
        {
            get { return  flag1; }
            set {  flag1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLAG2
        /// Coment�rio: 
        /// </summary>
        private string flag2;
        [XmlElement(ElementName = "FLAG2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Flag2
        {
            get { return  flag2; }
            set {  flag2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FOLHAROSTO
        /// Coment�rio: 
        /// </summary>
        private string folharosto;
        [XmlElement(ElementName = "FOLHAROSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Folharosto
        {
            get { return  folharosto; }
            set {  folharosto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRACAOCIPA
        /// Coment�rio: 
        /// </summary>
        private decimal? fracaocipa;
        [XmlElement(ElementName = "FRACAOCIPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Fracaocipa
        {
            get { return  fracaocipa; }
            set {  fracaocipa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRACAOSEPARACAO
        /// Coment�rio: 
        /// </summary>
        private decimal? fracaoseparacao;
        [XmlElement(ElementName = "FRACAOSEPARACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Fracaoseparacao
        {
            get { return  fracaoseparacao; }
            set {  fracaoseparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRACIONADO
        /// Coment�rio: 
        /// </summary>
        private string fracionado;
        [XmlElement(ElementName = "FRACIONADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fracionado
        {
            get { return  fracionado; }
            set {  fracionado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETEESPECIAL
        /// Coment�rio: 
        /// </summary>
        private string freteespecial;
        [XmlElement(ElementName = "FRETEESPECIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Freteespecial
        {
            get { return  freteespecial; }
            set {  freteespecial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRIABILIDADE
        /// Coment�rio: Pesquisa de Friabilidade.
        /// </summary>
        private string friabilidade;
        [XmlElement(ElementName = "FRIABILIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Friabilidade
        {
            get { return  friabilidade; }
            set {  friabilidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNDAPIANO
        /// Coment�rio: Produto pertencente ao FUNDAP, legisla��o do Espirito Santos, para impress�o de livros fiscais.
        /// </summary>
        private string fundapiano;
        [XmlElement(ElementName = "FUNDAPIANO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fundapiano
        {
            get { return  fundapiano; }
            set {  fundapiano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERABASEPISCOFINSSEMALIQ
        /// Coment�rio: Defina se deve gerar base de PIS/CONFINS mesmo quando n�o for informado aliquotas de PIS/CONFINS
        /// </summary>
        private string gerabasepiscofinssemaliq;
        [XmlElement(ElementName = "GERABASEPISCOFINSSEMALIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerabasepiscofinssemaliq
        {
            get { return  gerabasepiscofinssemaliq; }
            set {  gerabasepiscofinssemaliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAICMSLIVROFISCALDEVFORNEC
        /// Coment�rio: Gerar icms livro fiscal na devolu��o fornecedor
        /// </summary>
        private string geraicmslivrofiscaldevfornec;
        [XmlElement(ElementName = "GERAICMSLIVROFISCALDEVFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraicmslivrofiscaldevfornec
        {
            get { return  geraicmslivrofiscaldevfornec; }
            set {  geraicmslivrofiscaldevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAOSAUTOMATIC
        /// Coment�rio: Campo para definir que ao fechar a Ordem de servi�o o sistema deve gerar outra ordem de servi�o automaticamente.
        /// </summary>
        private string geraosautomatic;
        [XmlElement(ElementName = "GERAOSAUTOMATIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraosautomatic
        {
            get { return  geraosautomatic; }
            set {  geraosautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRAMATURA
        /// Coment�rio: Gramatura do papel.
        /// </summary>
        private decimal? gramatura;
        [XmlElement(ElementName = "GRAMATURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal? Gramatura
        {
            get { return  gramatura; }
            set {  gramatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOFATURAMENTO
        /// Coment�rio: GRUPO DE FATURAMENTO DO PRODUTO. UTILIZADO PARA EMPRESAS DO RAMO DE MEDICAMENTO.
        /// </summary>
        private string grupofaturamento;
        [XmlElement(ElementName = "GRUPOFATURAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Grupofaturamento
        {
            get { return  grupofaturamento; }
            set {  grupofaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTINCODAUXILIAR
        /// Coment�rio: Apresenta o padr�o de c�digo de barras GTIN
        /// </summary>
        private decimal? gtincodauxiliar;
        [XmlElement(ElementName = "GTINCODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Gtincodauxiliar
        {
            get { return  gtincodauxiliar; }
            set {  gtincodauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTINCODAUXILIAR2
        /// Coment�rio: Apresenta o padr�o de c�digo de barras GTIN
        /// </summary>
        private decimal? gtincodauxiliar2;
        [XmlElement(ElementName = "GTINCODAUXILIAR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Gtincodauxiliar2
        {
            get { return  gtincodauxiliar2; }
            set {  gtincodauxiliar2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ICMSRESSARC
        /// Coment�rio: Percentual ICMS ressarcimento.
        /// </summary>
        private decimal? icmsressarc;
        [XmlElement(ElementName = "ICMSRESSARC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Icmsressarc
        {
            get { return  icmsressarc; }
            set {  icmsressarc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDDESTAQUE
        /// Coment�rio: C�digo do cadastro de Destaques importa��o rotina 3006.
        /// </summary>
        private string iddestaque;
        [XmlElement(ElementName = "IDDESTAQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Iddestaque
        {
            get { return  iddestaque; }
            set {  iddestaque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDEMBALAGEM
        /// Coment�rio: C�digo Identifica��o Embalagem
        /// </summary>
        private decimal? idembalagem;
        [XmlElement(ElementName = "IDEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Idembalagem
        {
            get { return  idembalagem; }
            set {  idembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICACAO
        /// Coment�rio: Identifica��o da An�lise.
        /// </summary>
        private string identificacao;
        [XmlElement(ElementName = "IDENTIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Identificacao
        {
            get { return  identificacao; }
            set {  identificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IECTEREF
        /// Coment�rio: Inscri��o estadual do cte referenciado
        /// </summary>
        private decimal? iecteref;
        [XmlElement(ElementName = "IECTEREF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Iecteref
        {
            get { return  iecteref; }
            set {  iecteref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: 
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPUREZA
        /// Coment�rio: Pesquisa de Impurezas.
        /// </summary>
        private string impureza;
        [XmlElement(ElementName = "IMPUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Impureza
        {
            get { return  impureza; }
            set {  impureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMUNETRIB
        /// Coment�rio: Imune de Tributa��o.
        /// </summary>
        private string imunetrib;
        [XmlElement(ElementName = "IMUNETRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imunetrib
        {
            get { return  imunetrib; }
            set {  imunetrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDUZLOTE
        /// Coment�rio: Induzir Lotes
        /// </summary>
        private string induzlote;
        [XmlElement(ElementName = "INDUZLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Induzlote
        {
            get { return  induzlote; }
            set {  induzlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFORMACOESTECNICAS
        /// Coment�rio: 
        /// </summary>
        private string informacoestecnicas;
        [XmlElement(ElementName = "INFORMACOESTECNICAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Informacoestecnicas
        {
            get { return  informacoestecnicas; }
            set {  informacoestecnicas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INVENTARIOPARCIAL
        /// Coment�rio: Indica se faz parte de invent�rio parcial.
        /// </summary>
        private string inventarioparcial;
        [XmlElement(ElementName = "INVENTARIOPARCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inventarioparcial
        {
            get { return  inventarioparcial; }
            set {  inventarioparcial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IPIPORVALOR
        /// Coment�rio: Define se o produto utiliza IPI com valor fixo
        /// </summary>
        private string ipiporvalor;
        [XmlElement(ElementName = "IPIPORVALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ipiporvalor
        {
            get { return  ipiporvalor; }
            set {  ipiporvalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IRRETIDO
        /// Coment�rio: Percentual de IR retido venda.
        /// </summary>
        private decimal? irretido;
        [XmlElement(ElementName = "IRRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Irretido
        {
            get { return  irretido; }
            set {  irretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTOREGMS
        /// Coment�rio: Indica se o produto � isento ou n�o do registro no Minist�rio da Sa�de. 
        /// </summary>
        private string isentoregms;
        [XmlElement(ElementName = "ISENTOREGMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Isentoregms
        {
            get { return  isentoregms; }
            set {  isentoregms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVARESSARC
        /// Coment�rio: Percentual IVA ressarcimento.
        /// </summary>
        private decimal? ivaressarc;
        [XmlElement(ElementName = "IVARESSARC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Ivaressarc
        {
            get { return  ivaressarc; }
            set {  ivaressarc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURAARM
        /// Coment�rio: 
        /// </summary>
        private decimal? larguraarm;
        [XmlElement(ElementName = "LARGURAARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Larguraarm
        {
            get { return  larguraarm; }
            set {  larguraarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURAM3
        /// Coment�rio: Largura do produto na norma pallete.
        /// </summary>
        private decimal? larguram3;
        [XmlElement(ElementName = "LARGURAM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Larguram3
        {
            get { return  larguram3; }
            set {  larguram3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LASTROPAL
        /// Coment�rio: 
        /// </summary>
        private decimal? lastropal;
        [XmlElement(ElementName = "LASTROPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Lastropal
        {
            get { return  lastropal; }
            set {  lastropal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LETRAPAGINA
        /// Coment�rio: Indica a letra da p�gina.
        /// </summary>
        private string letrapagina;
        [XmlElement(ElementName = "LETRAPAGINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Letrapagina
        {
            get { return  letrapagina; }
            set {  letrapagina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LINHAPROD
        /// Coment�rio: C�digo da Linha de Produto.
        /// </summary>
        private decimal? linhaprod;
        [XmlElement(ElementName = "LINHAPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Linhaprod
        {
            get { return  linhaprod; }
            set {  linhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIPIDEO
        /// Coment�rio: 
        /// </summary>
        private string lipideo;
        [XmlElement(ElementName = "LIPIDEO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Lipideo
        {
            get { return  lipideo; }
            set {  lipideo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LITRAGEM
        /// Coment�rio: APRESENTA A LITRAGEM DO PRODUTO
        /// </summary>
        private decimal? litragem;
        [XmlElement(ElementName = "LITRAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Litragem
        {
            get { return  litragem; }
            set {  litragem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTEINCCOMPRA
        /// Coment�rio: 
        /// </summary>
        private decimal? loteinccompra;
        [XmlElement(ElementName = "LOTEINCCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Loteinccompra
        {
            get { return  loteinccompra; }
            set {  loteinccompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTEMINCOMPRA
        /// Coment�rio: 
        /// </summary>
        private decimal? lotemincompra;
        [XmlElement(ElementName = "LOTEMINCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Lotemincompra
        {
            get { return  lotemincompra; }
            set {  lotemincompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTEPRODUCAO
        /// Coment�rio: 
        /// </summary>
        private decimal? loteproducao;
        [XmlElement(ElementName = "LOTEPRODUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Loteproducao
        {
            get { return  loteproducao; }
            set {  loteproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAGENTO_ID
        /// Coment�rio: 
        /// </summary>
        private string magento_id;
        [XmlElement(ElementName = "MAGENTO_ID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Magento_Id
        {
            get { return  magento_id; }
            set {  magento_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARCA
        /// Coment�rio: Indica do produto.
        /// </summary>
        private string marca;
        [XmlElement(ElementName = "MARCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Marca
        {
            get { return  marca; }
            set {  marca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMMIN
        /// Coment�rio: 
        /// </summary>
        private decimal? margemmin;
        [XmlElement(ElementName = "MARGEMMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Margemmin
        {
            get { return  margemmin; }
            set {  margemmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDCODFUNCLIBVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal? medcodfunclibvenda;
        [XmlElement(ElementName = "MEDCODFUNCLIBVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Medcodfunclibvenda
        {
            get { return  medcodfunclibvenda; }
            set {  medcodfunclibvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDDTLIBVENDA
        /// Coment�rio: 
        /// </summary>
        private DateTime? meddtlibvenda;
        [XmlElement(ElementName = "MEDDTLIBVENDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Meddtlibvenda
        {
            get { return  meddtlibvenda; }
            set {  meddtlibvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDICAMENTOHOSPITALAR
        /// Coment�rio: 
        /// </summary>
        private string medicamentohospitalar;
        [XmlElement(ElementName = "MEDICAMENTOHOSPITALAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Medicamentohospitalar
        {
            get { return  medicamentohospitalar; }
            set {  medicamentohospitalar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEXFPGC
        /// Coment�rio: 
        /// </summary>
        private decimal? mexfpgc;
        [XmlElement(ElementName = "MEXFPGC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Mexfpgc
        {
            get { return  mexfpgc; }
            set {  mexfpgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEXIEPS
        /// Coment�rio: 
        /// </summary>
        private decimal? mexieps;
        [XmlElement(ElementName = "MEXIEPS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Mexieps
        {
            get { return  mexieps; }
            set {  mexieps = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEXIVA
        /// Coment�rio: 
        /// </summary>
        private decimal? mexiva;
        [XmlElement(ElementName = "MEXIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Mexiva
        {
            get { return  mexiva; }
            set {  mexiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULO
        /// Coment�rio: 
        /// </summary>
        private decimal? modulo;
        [XmlElement(ElementName = "MODULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Modulo
        {
            get { return  modulo; }
            set {  modulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULOCT
        /// Coment�rio: 
        /// </summary>
        private decimal? moduloct;
        [XmlElement(ElementName = "MODULOCT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Moduloct
        {
            get { return  moduloct; }
            set {  moduloct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULOCX
        /// Coment�rio: 
        /// </summary>
        private decimal? modulocx;
        [XmlElement(ElementName = "MODULOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Modulocx
        {
            get { return  modulocx; }
            set {  modulocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULO2
        /// Coment�rio: 
        /// </summary>
        private decimal? modulo2;
        [XmlElement(ElementName = "MODULO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Modulo2
        {
            get { return  modulo2; }
            set {  modulo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: MOFADO
        /// Coment�rio: 
        /// </summary>
        private string mofado;
        [XmlElement(ElementName = "MOFADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Mofado
        {
            get { return  mofado; }
            set {  mofado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPLO
        /// Coment�rio: 
        /// </summary>
        private decimal? multiplo;
        [XmlElement(ElementName = "MULTIPLO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Multiplo
        {
            get { return  multiplo; }
            set {  multiplo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPLOCOMPRAS
        /// Coment�rio: Quantidade m�ltipla de compras do produto
        /// </summary>
        private decimal? multiplocompras;
        [XmlElement(ElementName = "MULTIPLOCOMPRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Multiplocompras
        {
            get { return  multiplocompras; }
            set {  multiplocompras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPLO2
        /// Coment�rio: 
        /// </summary>
        private decimal? multiplo2;
        [XmlElement(ElementName = "MULTIPLO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Multiplo2
        {
            get { return  multiplo2; }
            set {  multiplo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MYFROTA
        /// Coment�rio: Enviar para o myFrota
        /// </summary>
        private string myfrota;
        [XmlElement(ElementName = "MYFROTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Myfrota
        {
            get { return  myfrota; }
            set {  myfrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZAPRODUTO
        /// Coment�rio: Indica a natureza do produto.
        /// </summary>
        private string naturezaproduto;
        [XmlElement(ElementName = "NATUREZAPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Naturezaproduto
        {
            get { return  naturezaproduto; }
            set {  naturezaproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NBM
        /// Coment�rio: 
        /// </summary>
        private string nbm;
        [XmlElement(ElementName = "NBM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nbm
        {
            get { return  nbm; }
            set {  nbm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL
        /// Coment�rio: 
        /// </summary>
        private decimal? nivel;
        [XmlElement(ElementName = "NIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Nivel
        {
            get { return  nivel; }
            set {  nivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVELCX
        /// Coment�rio: 
        /// </summary>
        private decimal? nivelcx;
        [XmlElement(ElementName = "NIVELCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Nivelcx
        {
            get { return  nivelcx; }
            set {  nivelcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECOMERCIAL
        /// Coment�rio: 
        /// </summary>
        private string nomecomercial;
        [XmlElement(ElementName = "NOMECOMERCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomecomercial
        {
            get { return  nomecomercial; }
            set {  nomecomercial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEECOMMERCE
        /// Coment�rio: Nome do produto para e-commerce
        /// </summary>
        private string nomeecommerce;
        [XmlElement(ElementName = "NOMEECOMMERCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Nomeecommerce
        {
            get { return  nomeecommerce; }
            set {  nomeecommerce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NORMAFORNECEDOR
        /// Coment�rio: 
        /// </summary>
        private string normafornecedor;
        [XmlElement(ElementName = "NORMAFORNECEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Normafornecedor
        {
            get { return  normafornecedor; }
            set {  normafornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NORMAPALETE
        /// Coment�rio: 
        /// </summary>
        private string normapalete;
        [XmlElement(ElementName = "NORMAPALETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Normapalete
        {
            get { return  normapalete; }
            set {  normapalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCASASDECREDUCAOICMS
        /// Coment�rio: Permitir que o usu�rio defina a quantidade de casas decimais que devem ser consideradas durante o c�lculo de redu��o de ICMS
        /// </summary>
        private decimal? numcasasdecreducaoicms;
        [XmlElement(ElementName = "NUMCASASDECREDUCAOICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Numcasasdecreducaoicms
        {
            get { return  numcasasdecreducaoicms; }
            set {  numcasasdecreducaoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal? numdiasmaxvenda;
        [XmlElement(ElementName = "NUMDIASMAXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Numdiasmaxvenda
        {
            get { return  numdiasmaxvenda; }
            set {  numdiasmaxvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASVALIDADEMIN
        /// Coment�rio: Numero de dias m�nimo de validade.
        /// </summary>
        private decimal? numdiasvalidademin;
        [XmlElement(ElementName = "NUMDIASVALIDADEMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numdiasvalidademin
        {
            get { return  numdiasvalidademin; }
            set {  numdiasvalidademin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Coment�rio: 
        /// </summary>
        private decimal? numero;
        [XmlElement(ElementName = "NUMERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Numero
        {
            get { return  numero; }
            set {  numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROCT
        /// Coment�rio: 
        /// </summary>
        private decimal? numeroct;
        [XmlElement(ElementName = "NUMEROCT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Numeroct
        {
            get { return  numeroct; }
            set {  numeroct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROCX
        /// Coment�rio: 
        /// </summary>
        private decimal? numerocx;
        [XmlElement(ElementName = "NUMEROCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Numerocx
        {
            get { return  numerocx; }
            set {  numerocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROSSERIECONTROLADOS
        /// Coment�rio: Quantidade de N�mero de serie vinculados
        /// </summary>
        private decimal? numerosseriecontrolados;
        [XmlElement(ElementName = "NUMEROSSERIECONTROLADOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numerosseriecontrolados
        {
            get { return  numerosseriecontrolados; }
            set {  numerosseriecontrolados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO2
        /// Coment�rio: 
        /// </summary>
        private decimal? numero2;
        [XmlElement(ElementName = "NUMERO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Numero2
        {
            get { return  numero2; }
            set {  numero2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLISTAINVENTROT
        /// Coment�rio: 
        /// </summary>
        private decimal? numlistainventrot;
        [XmlElement(ElementName = "NUMLISTAINVENTROT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Numlistainventrot
        {
            get { return  numlistainventrot; }
            set {  numlistainventrot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORIGINAL
        /// Coment�rio: 
        /// </summary>
        private string numoriginal;
        [XmlElement(ElementName = "NUMORIGINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numoriginal
        {
            get { return  numoriginal; }
            set {  numoriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPAG
        /// Coment�rio: Indica o numero da p�gina.
        /// </summary>
        private decimal? numpag;
        [XmlElement(ElementName = "NUMPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numpag
        {
            get { return  numpag; }
            set {  numpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGAGRMAP
        /// Coment�rio: N�mero Registro Agrot�xico MAPA
        /// </summary>
        private string numregagrmap;
        [XmlElement(ElementName = "NUMREGAGRMAP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numregagrmap
        {
            get { return  numregagrmap; }
            set {  numregagrmap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQATU
        /// Coment�rio: 
        /// </summary>
        private decimal? numseqatu;
        [XmlElement(ElementName = "NUMSEQATU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal? Numseqatu
        {
            get { return  numseqatu; }
            set {  numseqatu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQINVENTROT
        /// Coment�rio: 
        /// </summary>
        private decimal? numseqinventrot;
        [XmlElement(ElementName = "NUMSEQINVENTROT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Numseqinventrot
        {
            get { return  numseqinventrot; }
            set {  numseqinventrot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERVICO
        /// Coment�rio: Campo para definir qual o servi�o que deve contar na OS gerada automaticamente.
        /// </summary>
        private decimal? numservico;
        [XmlElement(ElementName = "NUMSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Numservico
        {
            get { return  numservico; }
            set {  numservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMULTEXPURGO
        /// Coment�rio: 
        /// </summary>
        private decimal? numultexpurgo;
        [XmlElement(ElementName = "NUMULTEXPURGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numultexpurgo
        {
            get { return  numultexpurgo; }
            set {  numultexpurgo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGAPREENCCONTRATO
        /// Coment�rio: Campo para definir se para esse servi�o ser� obrigat�rio informar o numero do contrato de comodato na cria��o da OS.
        /// </summary>
        private string obrigapreenccontrato;
        [XmlElement(ElementName = "OBRIGAPREENCCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigapreenccontrato
        {
            get { return  obrigapreenccontrato; }
            set {  obrigapreenccontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OSCOMODATO
        /// Coment�rio: Campo para definir se o servi�o � de comodato.
        /// </summary>
        private string oscomodato;
        [XmlElement(ElementName = "OSCOMODATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Oscomodato
        {
            get { return  oscomodato; }
            set {  oscomodato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAISORIGEM
        /// Coment�rio: 
        /// </summary>
        private string paisorigem;
        [XmlElement(ElementName = "PAISORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Paisorigem
        {
            get { return  paisorigem; }
            set {  paisorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PASSELIVRE
        /// Coment�rio: 
        /// </summary>
        private string passelivre;
        [XmlElement(ElementName = "PASSELIVRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Passelivre
        {
            get { return  passelivre; }
            set {  passelivre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCKROTATIVO
        /// Coment�rio: 
        /// </summary>
        private string pckrotativo;
        [XmlElement(ElementName = "PCKROTATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pckrotativo
        {
            get { return  pckrotativo; }
            set {  pckrotativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMEXT1
        /// Coment�rio: 
        /// </summary>
        private decimal? pcomext1;
        [XmlElement(ElementName = "PCOMEXT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Pcomext1
        {
            get { return  pcomext1; }
            set {  pcomext1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMINT1
        /// Coment�rio: 
        /// </summary>
        private decimal? pcomint1;
        [XmlElement(ElementName = "PCOMINT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Pcomint1
        {
            get { return  pcomint1; }
            set {  pcomint1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMPROF1
        /// Coment�rio: 
        /// </summary>
        private decimal? pcomprof1;
        [XmlElement(ElementName = "PCOMPROF1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Pcomprof1
        {
            get { return  pcomprof1; }
            set {  pcomprof1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMREP1
        /// Coment�rio: 
        /// </summary>
        private decimal? pcomrep1;
        [XmlElement(ElementName = "PCOMREP1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Pcomrep1
        {
            get { return  pcomrep1; }
            set {  pcomrep1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMTLMKT
        /// Coment�rio: 
        /// </summary>
        private decimal? pcomtlmkt;
        [XmlElement(ElementName = "PCOMTLMKT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Pcomtlmkt
        {
            get { return  pcomtlmkt; }
            set {  pcomtlmkt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRES
        /// Coment�rio: Percentual de acr�scimo a ser aplicado sobre o custo de precifica��o por fornecedor. 
        /// </summary>
        private decimal? percacres;
        [XmlElement(ElementName = "PERCACRES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percacres
        {
            get { return  percacres; }
            set {  percacres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQCREDICMSDIFEREST
        /// Coment�rio: 
        /// </summary>
        private decimal? percaliqcredicmsdiferest;
        [XmlElement(ElementName = "PERCALIQCREDICMSDIFEREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Percaliqcredicmsdiferest
        {
            get { return  percaliqcredicmsdiferest; }
            set {  percaliqcredicmsdiferest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQCREDICMSDIFERINTER
        /// Coment�rio: 
        /// </summary>
        private decimal? percaliqcredicmsdiferinter;
        [XmlElement(ElementName = "PERCALIQCREDICMSDIFERINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Percaliqcredicmsdiferinter
        {
            get { return  percaliqcredicmsdiferinter; }
            set {  percaliqcredicmsdiferinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXT
        /// Coment�rio: 
        /// </summary>
        private decimal? percaliqext;
        [XmlElement(ElementName = "PERCALIQEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percaliqext
        {
            get { return  percaliqext; }
            set {  percaliqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTBCR
        /// Coment�rio: Indica � aliquota externa BCR.
        /// </summary>
        private decimal? percaliqextbcr;
        [XmlElement(ElementName = "PERCALIQEXTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Percaliqextbcr
        {
            get { return  percaliqextbcr; }
            set {  percaliqextbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTGUIA
        /// Coment�rio: Percentual da al�quota externa para calculo do ST Guia.
        /// </summary>
        private decimal? percaliqextguia;
        [XmlElement(ElementName = "PERCALIQEXTGUIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percaliqextguia
        {
            get { return  percaliqextguia; }
            set {  percaliqextguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQEXTICMANTECIP
        /// Coment�rio: 
        /// </summary>
        private decimal? percaliqexticmantecip;
        [XmlElement(ElementName = "PERCALIQEXTICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percaliqexticmantecip
        {
            get { return  percaliqexticmantecip; }
            set {  percaliqexticmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINT
        /// Coment�rio: 
        /// </summary>
        private decimal? percaliqint;
        [XmlElement(ElementName = "PERCALIQINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percaliqint
        {
            get { return  percaliqint; }
            set {  percaliqint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINTBCR
        /// Coment�rio: Indica � aliquota interna BCR.
        /// </summary>
        private decimal? percaliqintbcr;
        [XmlElement(ElementName = "PERCALIQINTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Percaliqintbcr
        {
            get { return  percaliqintbcr; }
            set {  percaliqintbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALIQINTICMANTECIP
        /// Coment�rio: 
        /// </summary>
        private decimal? percaliqinticmantecip;
        [XmlElement(ElementName = "PERCALIQINTICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percaliqinticmantecip
        {
            get { return  percaliqinticmantecip; }
            set {  percaliqinticmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDENT
        /// Coment�rio: 
        /// </summary>
        private decimal? percbaseredent;
        [XmlElement(ElementName = "PERCBASEREDENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Percbaseredent
        {
            get { return  percbaseredent; }
            set {  percbaseredent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBON
        /// Coment�rio: 
        /// </summary>
        private decimal? percbon;
        [XmlElement(ElementName = "PERCBON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percbon
        {
            get { return  percbon; }
            set {  percbon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFIC
        /// Coment�rio: % Bonifica��o Dinheiro
        /// </summary>
        private decimal? percbonific;
        [XmlElement(ElementName = "PERCBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Percbonific
        {
            get { return  percbonific; }
            set {  percbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFICTAB
        /// Coment�rio: % Bonifica��o Dinheiro Futuro
        /// </summary>
        private decimal? percbonifictab;
        [XmlElement(ElementName = "PERCBONIFICTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Percbonifictab
        {
            get { return  percbonifictab; }
            set {  percbonifictab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFICVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal? percbonificvenda;
        [XmlElement(ElementName = "PERCBONIFICVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Percbonificvenda
        {
            get { return  percbonificvenda; }
            set {  percbonificvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONOUTRAS
        /// Coment�rio: 
        /// </summary>
        private decimal? percbonoutras;
        [XmlElement(ElementName = "PERCBONOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Percbonoutras
        {
            get { return  percbonoutras; }
            set {  percbonoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONOUTRASTAB
        /// Coment�rio: % Bonifica��o Outras Verbas Futuro
        /// </summary>
        private decimal? percbonoutrastab;
        [XmlElement(ElementName = "PERCBONOUTRASTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Percbonoutrastab
        {
            get { return  percbonoutrastab; }
            set {  percbonoutrastab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONTAB
        /// Coment�rio: % Bonifica��o Mercadoria Futuro
        /// </summary>
        private decimal? percbontab;
        [XmlElement(ElementName = "PERCBONTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percbontab
        {
            get { return  percbontab; }
            set {  percbontab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCARGATRIBMEDIA
        /// Coment�rio: Percentual de carga tribut�ria m�dia, utilizado no SEFAZ MT para calculo da substitui��o tribut�ria
        /// </summary>
        private decimal? perccargatribmedia;
        [XmlElement(ElementName = "PERCCARGATRIBMEDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Perccargatribmedia
        {
            get { return  perccargatribmedia; }
            set {  perccargatribmedia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCARGATRIBMEDIAICMSANTECIP
        /// Coment�rio: % Carga M�dia tribut�ria Icms Antecipado
        /// </summary>
        private decimal? perccargatribmediaicmsantecip;
        [XmlElement(ElementName = "PERCCARGATRIBMEDIAICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Perccargatribmediaicmsantecip
        {
            get { return  perccargatribmediaicmsantecip; }
            set {  perccargatribmediaicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMMOT
        /// Coment�rio: Percentual comiss�o motorista.
        /// </summary>
        private decimal? perccommot;
        [XmlElement(ElementName = "PERCCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Perccommot
        {
            get { return  perccommot; }
            set {  perccommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCREDICMPRESUMIDO
        /// Coment�rio: Indica o percentual de cr�dito ICMS presumido para o produto.
        /// </summary>
        private decimal? perccredicmpresumido;
        [XmlElement(ElementName = "PERCCREDICMPRESUMIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Perccredicmpresumido
        {
            get { return  perccredicmpresumido; }
            set {  perccredicmpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCICMS
        /// Coment�rio: Percentual de desconto a ser aplicado sobre o c�lculo do ICMS. 
        /// </summary>
        private decimal? percdescicms;
        [XmlElement(ElementName = "PERCDESCICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdescicms
        {
            get { return  percdescicms; }
            set {  percdescicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCICMSDIF
        /// Coment�rio: Percentual do desconto de ICMS Difererido.
        /// </summary>
        private decimal? percdescicmsdif;
        [XmlElement(ElementName = "PERCDESCICMSDIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Percdescicmsdif
        {
            get { return  percdescicmsdif; }
            set {  percdescicmsdif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC1
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc1;
        [XmlElement(ElementName = "PERCDESC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc1
        {
            get { return  percdesc1; }
            set {  percdesc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC1TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc1tab;
        [XmlElement(ElementName = "PERCDESC1TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc1tab
        {
            get { return  percdesc1tab; }
            set {  percdesc1tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC10
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc10;
        [XmlElement(ElementName = "PERCDESC10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc10
        {
            get { return  percdesc10; }
            set {  percdesc10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC10TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc10tab;
        [XmlElement(ElementName = "PERCDESC10TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc10tab
        {
            get { return  percdesc10tab; }
            set {  percdesc10tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC2
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc2;
        [XmlElement(ElementName = "PERCDESC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc2
        {
            get { return  percdesc2; }
            set {  percdesc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC2TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc2tab;
        [XmlElement(ElementName = "PERCDESC2TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc2tab
        {
            get { return  percdesc2tab; }
            set {  percdesc2tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC3
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc3;
        [XmlElement(ElementName = "PERCDESC3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc3
        {
            get { return  percdesc3; }
            set {  percdesc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC3TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc3tab;
        [XmlElement(ElementName = "PERCDESC3TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc3tab
        {
            get { return  percdesc3tab; }
            set {  percdesc3tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC4
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc4;
        [XmlElement(ElementName = "PERCDESC4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc4
        {
            get { return  percdesc4; }
            set {  percdesc4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC4TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc4tab;
        [XmlElement(ElementName = "PERCDESC4TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc4tab
        {
            get { return  percdesc4tab; }
            set {  percdesc4tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC5
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc5;
        [XmlElement(ElementName = "PERCDESC5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc5
        {
            get { return  percdesc5; }
            set {  percdesc5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC5TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc5tab;
        [XmlElement(ElementName = "PERCDESC5TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc5tab
        {
            get { return  percdesc5tab; }
            set {  percdesc5tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC6
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc6;
        [XmlElement(ElementName = "PERCDESC6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc6
        {
            get { return  percdesc6; }
            set {  percdesc6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC6TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc6tab;
        [XmlElement(ElementName = "PERCDESC6TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc6tab
        {
            get { return  percdesc6tab; }
            set {  percdesc6tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC7
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc7;
        [XmlElement(ElementName = "PERCDESC7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc7
        {
            get { return  percdesc7; }
            set {  percdesc7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC7TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc7tab;
        [XmlElement(ElementName = "PERCDESC7TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc7tab
        {
            get { return  percdesc7tab; }
            set {  percdesc7tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC8
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc8;
        [XmlElement(ElementName = "PERCDESC8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc8
        {
            get { return  percdesc8; }
            set {  percdesc8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC8TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc8tab;
        [XmlElement(ElementName = "PERCDESC8TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc8tab
        {
            get { return  percdesc8tab; }
            set {  percdesc8tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC9
        /// Coment�rio: 
        /// </summary>
        private decimal? percdesc9;
        [XmlElement(ElementName = "PERCDESC9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc9
        {
            get { return  percdesc9; }
            set {  percdesc9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC9TAB
        /// Coment�rio: Percentual de desconto comercial 1 futuro
        /// </summary>
        private decimal? percdesc9tab;
        [XmlElement(ElementName = "PERCDESC9TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdesc9tab
        {
            get { return  percdesc9tab; }
            set {  percdesc9tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPADICIONAL
        /// Coment�rio: 
        /// </summary>
        private decimal? percdespadicional;
        [XmlElement(ElementName = "PERCDESPADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percdespadicional
        {
            get { return  percdespadicional; }
            set {  percdespadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPDENTRONF
        /// Coment�rio: Indica o percentual outras despesa na NF.
        /// </summary>
        private decimal? percdespdentronf;
        [XmlElement(ElementName = "PERCDESPDENTRONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percdespdentronf
        {
            get { return  percdespdentronf; }
            set {  percdespdentronf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFIN
        /// Coment�rio: 
        /// </summary>
        private decimal? percdespfin;
        [XmlElement(ElementName = "PERCDESPFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percdespfin
        {
            get { return  percdespfin; }
            set {  percdespfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFORANF
        /// Coment�rio: Indica o percentual de despesa fora da nota.
        /// </summary>
        private decimal? percdespforanf;
        [XmlElement(ElementName = "PERCDESPFORANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdespforanf
        {
            get { return  percdespforanf; }
            set {  percdespforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFALIQUOTAS
        /// Coment�rio: Indica o percentual de diferen�a de al�quota.
        /// </summary>
        private decimal? percdifaliquotas;
        [XmlElement(ElementName = "PERCDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Percdifaliquotas
        {
            get { return  percdifaliquotas; }
            set {  percdifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFERENCAKGFRIO
        /// Coment�rio: Indica o percentual de diferen�a no kg de produtos frios.
        /// </summary>
        private decimal? percdiferencakgfrio;
        [XmlElement(ElementName = "PERCDIFERENCAKGFRIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percdiferencakgfrio
        {
            get { return  percdiferencakgfrio; }
            set {  percdiferencakgfrio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal? percfrete;
        [XmlElement(ElementName = "PERCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percfrete
        {
            get { return  percfrete; }
            set {  percfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETEFOB
        /// Coment�rio: 
        /// </summary>
        private decimal? percfretefob;
        [XmlElement(ElementName = "PERCFRETEFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Percfretefob
        {
            get { return  percfretefob; }
            set {  percfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMRED
        /// Coment�rio: 
        /// </summary>
        private decimal? percicmred;
        [XmlElement(ElementName = "PERCICMRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percicmred
        {
            get { return  percicmred; }
            set {  percicmred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSBASEICMSANTECIPADO
        /// Coment�rio: Aliq. Para base do ICMS antecipado
        /// </summary>
        private decimal? percicmsbaseicmsantecipado;
        [XmlElement(ElementName = "PERCICMSBASEICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percicmsbaseicmsantecipado
        {
            get { return  percicmsbaseicmsantecipado; }
            set {  percicmsbaseicmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSDIFERIDO
        /// Coment�rio: Indica o percentual do ICMS diferido.
        /// </summary>
        private decimal? percicmsdiferido;
        [XmlElement(ElementName = "PERCICMSDIFERIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Percicmsdiferido
        {
            get { return  percicmsdiferido; }
            set {  percicmsdiferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBICMSANTECIP
        /// Coment�rio: % ICMS Frete FOB p/ calc.Icms Antecipado
        /// </summary>
        private decimal? percicmsfretefobicmsantecip;
        [XmlElement(ElementName = "PERCICMSFRETEFOBICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percicmsfretefobicmsantecip
        {
            get { return  percicmsfretefobicmsantecip; }
            set {  percicmsfretefobicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBST
        /// Coment�rio: Percentual de cr�dito de ICMS sobre o valor Frete FOB, utilizado no calculo do ST
        /// </summary>
        private decimal? percicmsfretefobst;
        [XmlElement(ElementName = "PERCICMSFRETEFOBST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percicmsfretefobst
        {
            get { return  percicmsfretefobst; }
            set {  percicmsfretefobst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSFRETEFOBSTBCR
        /// Coment�rio: Percentual de cr�dito de ICMS sobre o valor Frete FOB, utilizado no calculo do STBCR
        /// </summary>
        private decimal? percicmsfretefobstbcr;
        [XmlElement(ElementName = "PERCICMSFRETEFOBSTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percicmsfretefobstbcr
        {
            get { return  percicmsfretefobstbcr; }
            set {  percicmsfretefobstbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPORTACAO
        /// Coment�rio: 
        /// </summary>
        private decimal? percimportacao;
        [XmlElement(ElementName = "PERCIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percimportacao
        {
            get { return  percimportacao; }
            set {  percimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPPRODUTORURAL
        /// Coment�rio: Indica o percentual do imposto do produtor rural.
        /// </summary>
        private decimal? percimpprodutorural;
        [XmlElement(ElementName = "PERCIMPPRODUTORURAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percimpprodutorural
        {
            get { return  percimpprodutorural; }
            set {  percimpprodutorural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI
        /// Coment�rio: 
        /// </summary>
        private decimal? percipi;
        [XmlElement(ElementName = "PERCIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percipi
        {
            get { return  percipi; }
            set {  percipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPISUSPENSO
        /// Coment�rio: Percentual do IPI suspenso
        /// </summary>
        private decimal? percipisuspenso;
        [XmlElement(ElementName = "PERCIPISUSPENSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percipisuspenso
        {
            get { return  percipisuspenso; }
            set {  percipisuspenso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPIVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal? percipivenda;
        [XmlElement(ElementName = "PERCIPIVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Percipivenda
        {
            get { return  percipivenda; }
            set {  percipivenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPIVENDATAB
        /// Coment�rio: Indica o % do IPI venda futuro.
        /// </summary>
        private decimal? percipivendatab;
        [XmlElement(ElementName = "PERCIPIVENDATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Percipivendatab
        {
            get { return  percipivendatab; }
            set {  percipivendatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVA
        /// Coment�rio: 
        /// </summary>
        private decimal? perciva;
        [XmlElement(ElementName = "PERCIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Perciva
        {
            get { return  perciva; }
            set {  perciva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVABCR
        /// Coment�rio: Indica o % IVA BCR.
        /// </summary>
        private decimal? percivabcr;
        [XmlElement(ElementName = "PERCIVABCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Percivabcr
        {
            get { return  percivabcr; }
            set {  percivabcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIVAICMANTECIP
        /// Coment�rio: 
        /// </summary>
        private decimal? percivaicmantecip;
        [XmlElement(ElementName = "PERCIVAICMANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Percivaicmantecip
        {
            get { return  percivaicmantecip; }
            set {  percivaicmantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMVAORIG
        /// Coment�rio: Percentual de MVA Original para c�lculo do MVA ajustado
        /// </summary>
        private decimal? percmvaorig;
        [XmlElement(ElementName = "PERCMVAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percmvaorig
        {
            get { return  percmvaorig; }
            set {  percmvaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMVAORIGICMSANTECIP
        /// Coment�rio: % IVA Original ICMS Antecipado
        /// </summary>
        private decimal? percmvaorigicmsantecip;
        [XmlElement(ElementName = "PERCMVAORIGICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percmvaorigicmsantecip
        {
            get { return  percmvaorigicmsantecip; }
            set {  percmvaorigicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Coment�rio: Indica o percentual de COFINS.
        /// </summary>
        private decimal? percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: PERCOFINSIMP
        /// Coment�rio: 
        /// </summary>
        private decimal? percofinsimp;
        [XmlElement(ElementName = "PERCOFINSIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Percofinsimp
        {
            get { return  percofinsimp; }
            set {  percofinsimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS_SERVICO
        /// Coment�rio: Referente ao %COFINS de Servi�o cadastrado
        /// </summary>
        private decimal? percofins_servico;
        [XmlElement(ElementName = "PERCOFINS_SERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percofins_Servico
        {
            get { return  percofins_servico; }
            set {  percofins_servico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTRASDESP
        /// Coment�rio: 
        /// </summary>
        private decimal? percoutrasdesp;
        [XmlElement(ElementName = "PERCOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percoutrasdesp
        {
            get { return  percoutrasdesp; }
            set {  percoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPERDAKG
        /// Coment�rio: Percentual de perda para rendimento de um Kg
        /// </summary>
        private decimal? percperdakg;
        [XmlElement(ElementName = "PERCPERDAKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percperdakg
        {
            get { return  percperdakg; }
            set {  percperdakg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPRODEIC
        /// Coment�rio: Percentual benef�cio PRODEIC utilizado no relat�rio do PRODEIC da rotina 1031
        /// </summary>
        private decimal? percprodeic;
        [XmlElement(ElementName = "PERCPRODEIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Percprodeic
        {
            get { return  percprodeic; }
            set {  percprodeic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCQUEBRAPRODUCAO
        /// Coment�rio: Percentual de quebra permitido.
        /// </summary>
        private decimal? percquebraproducao;
        [XmlElement(ElementName = "PERCQUEBRAPRODUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Percquebraproducao
        {
            get { return  percquebraproducao; }
            set {  percquebraproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDICMS
        /// Coment�rio: Indica o percentual de cr�dito ICMS.
        /// </summary>
        private decimal? percredicms;
        [XmlElement(ElementName = "PERCREDICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percredicms
        {
            get { return  percredicms; }
            set {  percredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDPMC
        /// Coment�rio: Perc.redu��o PMC
        /// </summary>
        private decimal? percredpmc;
        [XmlElement(ElementName = "PERCREDPMC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percredpmc
        {
            get { return  percredpmc; }
            set {  percredpmc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSEGURO
        /// Coment�rio: Indica o percentual de seguro.
        /// </summary>
        private decimal? percseguro;
        [XmlElement(ElementName = "PERCSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Percseguro
        {
            get { return  percseguro; }
            set {  percseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCST
        /// Coment�rio: 
        /// </summary>
        private decimal? percst;
        [XmlElement(ElementName = "PERCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percst
        {
            get { return  percst; }
            set {  percst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSUFRAMA
        /// Coment�rio: 
        /// </summary>
        private decimal? percsuframa;
        [XmlElement(ElementName = "PERCSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Percsuframa
        {
            get { return  percsuframa; }
            set {  percsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLERANCIAVAL
        /// Coment�rio: 
        /// </summary>
        private decimal? perctoleranciaval;
        [XmlElement(ElementName = "PERCTOLERANCIAVAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Perctoleranciaval
        {
            get { return  perctoleranciaval; }
            set {  perctoleranciaval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVENDA
        /// Coment�rio: Indica o percentual negociado na venda.
        /// </summary>
        private decimal? percvenda;
        [XmlElement(ElementName = "PERCVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Percvenda
        {
            get { return  percvenda; }
            set {  percvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICM
        /// Coment�rio: 
        /// </summary>
        private decimal? pericm;
        [XmlElement(ElementName = "PERICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Pericm
        {
            get { return  pericm; }
            set {  pericm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICMFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal? pericmfrete;
        [XmlElement(ElementName = "PERICMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Pericmfrete
        {
            get { return  pericmfrete; }
            set {  pericmfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERICMSANTECIPADO
        /// Coment�rio: 
        /// </summary>
        private decimal? pericmsantecipado;
        [XmlElement(ElementName = "PERICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Pericmsantecipado
        {
            get { return  pericmsantecipado; }
            set {  pericmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERINDENIZ
        /// Coment�rio: 
        /// </summary>
        private decimal? perindeniz;
        [XmlElement(ElementName = "PERINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Perindeniz
        {
            get { return  perindeniz; }
            set {  perindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEPRODUCAO
        /// Coment�rio: Permite programar produ��o.
        /// </summary>
        private string permiteproducao;
        [XmlElement(ElementName = "PERMITEPRODUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteproducao
        {
            get { return  permiteproducao; }
            set {  permiteproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Coment�rio: 
        /// </summary>
        private decimal? perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPISIMP
        /// Coment�rio: 
        /// </summary>
        private decimal? perpisimp;
        [XmlElement(ElementName = "PERPISIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Perpisimp
        {
            get { return  perpisimp; }
            set {  perpisimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS_SERVICO
        /// Coment�rio: Referente ao %PIS de Servi�o cadastrado
        /// </summary>
        private decimal? perpis_servico;
        [XmlElement(ElementName = "PERPIS_SERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Perpis_Servico
        {
            get { return  perpis_servico; }
            set {  perpis_servico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Coment�rio: 
        /// </summary>
        private decimal? pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTOMASTER
        /// Coment�rio: 
        /// </summary>
        private decimal? pesobrutomaster;
        [XmlElement(ElementName = "PESOBRUTOMASTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Pesobrutomaster
        {
            get { return  pesobrutomaster; }
            set {  pesobrutomaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOEMBALAGEM
        /// Coment�rio: Indica o peso da embalagem.
        /// </summary>
        private decimal? pesoembalagem;
        [XmlElement(ElementName = "PESOEMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Pesoembalagem
        {
            get { return  pesoembalagem; }
            set {  pesoembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQ
        /// Coment�rio: 
        /// </summary>
        private decimal? pesoliq;
        [XmlElement(ElementName = "PESOLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Pesoliq
        {
            get { return  pesoliq; }
            set {  pesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQMASTER
        /// Coment�rio: 
        /// </summary>
        private decimal? pesoliqmaster;
        [XmlElement(ElementName = "PESOLIQMASTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Pesoliqmaster
        {
            get { return  pesoliqmaster; }
            set {  pesoliqmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOMAXIMO
        /// Coment�rio: Peso m�ximo
        /// </summary>
        private decimal? pesomaximo;
        [XmlElement(ElementName = "PESOMAXIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Pesomaximo
        {
            get { return  pesomaximo; }
            set {  pesomaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOMINIMO
        /// Coment�rio: Peso m�nimo
        /// </summary>
        private decimal? pesominimo;
        [XmlElement(ElementName = "PESOMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Pesominimo
        {
            get { return  pesominimo; }
            set {  pesominimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOPALETE
        /// Coment�rio: 
        /// </summary>
        private decimal? pesopalete;
        [XmlElement(ElementName = "PESOPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Pesopalete
        {
            get { return  pesopalete; }
            set {  pesopalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOPECA
        /// Coment�rio: 
        /// </summary>
        private decimal? pesopeca;
        [XmlElement(ElementName = "PESOPECA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Pesopeca
        {
            get { return  pesopeca; }
            set {  pesopeca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOVARIAVEL
        /// Coment�rio: Indica se o peso e vari�vel.
        /// </summary>
        private string pesovariavel;
        [XmlElement(ElementName = "PESOVARIAVEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pesovariavel
        {
            get { return  pesovariavel; }
            set {  pesovariavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESQPATOGENOS
        /// Coment�rio: Pesquisa de Pat�genos.
        /// </summary>
        private string pesqpatogenos;
        [XmlElement(ElementName = "PESQPATOGENOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Pesqpatogenos
        {
            get { return  pesqpatogenos; }
            set {  pesqpatogenos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PH
        /// Coment�rio: Pesquisa de PH.
        /// </summary>
        private string ph;
        [XmlElement(ElementName = "PH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Ph
        {
            get { return  ph; }
            set {  ph = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISCOFINSRETIDO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PISRETIDO
        /// Coment�rio: Percentual de PIS retido venda.
        /// </summary>
        private decimal? pisretido;
        [XmlElement(ElementName = "PISRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Pisretido
        {
            get { return  pisretido; }
            set {  pisretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONTOREPOSICAO
        /// Coment�rio: 
        /// </summary>
        private decimal? pontoreposicao;
        [XmlElement(ElementName = "PONTOREPOSICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Pontoreposicao
        {
            get { return  pontoreposicao; }
            set {  pontoreposicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONTOREPOSICAOAL
        /// Coment�rio: 
        /// </summary>
        private decimal? pontoreposicaoal;
        [XmlElement(ElementName = "PONTOREPOSICAOAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Pontoreposicaoal
        {
            get { return  pontoreposicaoal; }
            set {  pontoreposicaoal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONTOREPOSICAOCX
        /// Coment�rio: 
        /// </summary>
        private decimal? pontoreposicaocx;
        [XmlElement(ElementName = "PONTOREPOSICAOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Pontoreposicaocx
        {
            get { return  pontoreposicaocx; }
            set {  pontoreposicaocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONTOREPOSICAOPA
        /// Coment�rio: 
        /// </summary>
        private decimal? pontoreposicaopa;
        [XmlElement(ElementName = "PONTOREPOSICAOPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Pontoreposicaopa
        {
            get { return  pontoreposicaopa; }
            set {  pontoreposicaopa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO
        /// Coment�rio: 
        /// </summary>
        private decimal? prazo;
        [XmlElement(ElementName = "PRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazo
        {
            get { return  prazo; }
            set {  prazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOENTR
        /// Coment�rio: 
        /// </summary>
        private decimal? prazoentr;
        [XmlElement(ElementName = "PRAZOENTR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Prazoentr
        {
            get { return  prazoentr; }
            set {  prazoentr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOEXPURGO
        /// Coment�rio: 
        /// </summary>
        private decimal? prazoexpurgo;
        [XmlElement(ElementName = "PRAZOEXPURGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Prazoexpurgo
        {
            get { return  prazoexpurgo; }
            set {  prazoexpurgo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOGARANTIA
        /// Coment�rio: Indica o prazo de garantia do produto.
        /// </summary>
        private decimal? prazogarantia;
        [XmlElement(ElementName = "PRAZOGARANTIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Prazogarantia
        {
            get { return  prazogarantia; }
            set {  prazogarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXINDENIZACAO
        /// Coment�rio: Indica o prazo m�ximo para indeniza��o ou troca.
        /// </summary>
        private decimal? prazomaxindenizacao;
        [XmlElement(ElementName = "PRAZOMAXINDENIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Prazomaxindenizacao
        {
            get { return  prazomaxindenizacao; }
            set {  prazomaxindenizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXVALIDADE
        /// Coment�rio: Indica o % prazo m�ximo vencimento produto.
        /// </summary>
        private decimal? prazomaxvalidade;
        [XmlElement(ElementName = "PRAZOMAXVALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Prazomaxvalidade
        {
            get { return  prazomaxvalidade; }
            set {  prazomaxvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXVENDA
        /// Coment�rio: PRAZO M�XIMO VENDA
        /// </summary>
        private decimal? prazomaxvenda;
        [XmlElement(ElementName = "PRAZOMAXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Prazomaxvenda
        {
            get { return  prazomaxvenda; }
            set {  prazomaxvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIOPRODUCAO
        /// Coment�rio: 
        /// </summary>
        private decimal? prazomedioproducao;
        [XmlElement(ElementName = "PRAZOMEDIOPRODUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Prazomedioproducao
        {
            get { return  prazomedioproducao; }
            set {  prazomedioproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIOVENDA
        /// Coment�rio: Prazo M�dio de Venda. O Produto n�o poder� ser vendido quando o Prazo M�dio � maior que o informado.
        /// </summary>
        private decimal? prazomediovenda;
        [XmlElement(ElementName = "PRAZOMEDIOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Prazomediovenda
        {
            get { return  prazomediovenda; }
            set {  prazomediovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMINVALIDADE
        /// Coment�rio: Indica o % prazo minimo vencimento produto.
        /// </summary>
        private decimal? prazominvalidade;
        [XmlElement(ElementName = "PRAZOMINVALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Prazominvalidade
        {
            get { return  prazominvalidade; }
            set {  prazominvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOVAL
        /// Coment�rio: 
        /// </summary>
        private decimal? prazoval;
        [XmlElement(ElementName = "PRAZOVAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazoval
        {
            get { return  prazoval; }
            set {  prazoval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECIFICACAOAUTOMATICA
        /// Coment�rio: Informar se o produto poder ser precificado autom�ticamente
        /// </summary>
        private string precificacaoautomatica;
        [XmlElement(ElementName = "PRECIFICACAOAUTOMATICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Precificacaoautomatica
        {
            get { return  precificacaoautomatica; }
            set {  precificacaoautomatica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECIFICESTRANGEIRA
        /// Coment�rio: Verifica se a precifica��o � feita em moeda estrangeira ou n�o.
        /// </summary>
        private string precificestrangeira;
        [XmlElement(ElementName = "PRECIFICESTRANGEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Precificestrangeira
        {
            get { return  precificestrangeira; }
            set {  precificestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFIXO
        /// Coment�rio: 
        /// </summary>
        private string precofixo;
        [XmlElement(ElementName = "PRECOFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Precofixo
        {
            get { return  precofixo; }
            set {  precofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUM
        /// Coment�rio: 
        /// </summary>
        private decimal? precomaxconsum;
        [XmlElement(ElementName = "PRECOMAXCONSUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Precomaxconsum
        {
            get { return  precomaxconsum; }
            set {  precomaxconsum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUMTAB
        /// Coment�rio: 
        /// </summary>
        private decimal? precomaxconsumtab;
        [XmlElement(ElementName = "PRECOMAXCONSUMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Precomaxconsumtab
        {
            get { return  precomaxconsumtab; }
            set {  precomaxconsumtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUMTABANT
        /// Coment�rio: Gravar o valor do pre�o Maximo cosumidor anterior
        /// </summary>
        private decimal? precomaxconsumtabant;
        [XmlElement(ElementName = "PRECOMAXCONSUMTABANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Precomaxconsumtabant
        {
            get { return  precomaxconsumtabant; }
            set {  precomaxconsumtabant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUMZFM
        /// Coment�rio: 
        /// </summary>
        private decimal? precomaxconsumzfm;
        [XmlElement(ElementName = "PRECOMAXCONSUMZFM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Precomaxconsumzfm
        {
            get { return  precomaxconsumzfm; }
            set {  precomaxconsumzfm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUMZFMANT
        /// Coment�rio: Gravar o valor do pre�o maximo cosumidor ZF manaus anterior
        /// </summary>
        private decimal? precomaxconsumzfmant;
        [XmlElement(ElementName = "PRECOMAXCONSUMZFMANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Precomaxconsumzfmant
        {
            get { return  precomaxconsumzfmant; }
            set {  precomaxconsumzfmant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOMAXCONSUMZFMTAB
        /// Coment�rio: 
        /// </summary>
        private decimal? precomaxconsumzfmtab;
        [XmlElement(ElementName = "PRECOMAXCONSUMZFMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Precomaxconsumzfmtab
        {
            get { return  precomaxconsumzfmtab; }
            set {  precomaxconsumzfmtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREDIO
        /// Coment�rio: 
        /// </summary>
        private decimal? predio;
        [XmlElement(ElementName = "PREDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Predio
        {
            get { return  predio; }
            set {  predio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREDIOCX
        /// Coment�rio: 
        /// </summary>
        private decimal? prediocx;
        [XmlElement(ElementName = "PREDIOCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Prediocx
        {
            get { return  prediocx; }
            set {  prediocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREFIXOLOTE
        /// Coment�rio: 
        /// </summary>
        private string prefixolote;
        [XmlElement(ElementName = "PREFIXOLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Prefixolote
        {
            get { return  prefixolote; }
            set {  prefixolote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRINCIPIOATIVO
        /// Coment�rio: 
        /// </summary>
        private string principioativo;
        [XmlElement(ElementName = "PRINCIPIOATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Principioativo
        {
            get { return  principioativo; }
            set {  principioativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTEINA
        /// Coment�rio: 
        /// </summary>
        private string proteina;
        [XmlElement(ElementName = "PROTEINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Proteina
        {
            get { return  proteina; }
            set {  proteina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTE
        /// Coment�rio: 
        /// </summary>
        private decimal? proxnumlote;
        [XmlElement(ElementName = "PROXNUMLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Proxnumlote
        {
            get { return  proxnumlote; }
            set {  proxnumlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PSICOTROPICO
        /// Coment�rio: 
        /// </summary>
        private string psicotropico;
        [XmlElement(ElementName = "PSICOTROPICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Psicotropico
        {
            get { return  psicotropico; }
            set {  psicotropico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAFORNEC
        /// Coment�rio: Pre�o de tabela do fornecedor, este pre�o � disponibilizado atrav�s de tabela de pre�os do fornecedor.. 
        /// </summary>
        private decimal? ptabelafornec;
        [XmlElement(ElementName = "PTABELAFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Ptabelafornec
        {
            get { return  ptabelafornec; }
            set {  ptabelafornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Coment�rio: Indica o pre�o de tabela do servi�o.
        /// </summary>
        private decimal? pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal? Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMAXSEPARPEDIDO
        /// Coment�rio: Indica a quantidade m�xima para separa��o por pedido.
        /// </summary>
        private decimal? qtdemaxseparpedido;
        [XmlElement(ElementName = "QTDEMAXSEPARPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Qtdemaxseparpedido
        {
            get { return  qtdemaxseparpedido; }
            set {  qtdemaxseparpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDMAXSEPARARPEDIDO
        /// Coment�rio: Indica a quantidade m�xima para separa��o por pedido.
        /// </summary>
        private decimal? qtdmaxsepararpedido;
        [XmlElement(ElementName = "QTDMAXSEPARARPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Qtdmaxsepararpedido
        {
            get { return  qtdmaxsepararpedido; }
            set {  qtdmaxsepararpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXGONDULA
        /// Coment�rio: 
        /// </summary>
        private decimal? qtmaxgondula;
        [XmlElement(ElementName = "QTMAXGONDULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtmaxgondula
        {
            get { return  qtmaxgondula; }
            set {  qtmaxgondula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMETROS
        /// Coment�rio: Na rotina 203, pasta Armazenagem, receber� a metragem do produto. 
        /// </summary>
        private decimal? qtmetros;
        [XmlElement(ElementName = "QTMETROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Qtmetros
        {
            get { return  qtmetros; }
            set {  qtmetros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINGONDULA
        /// Coment�rio: 
        /// </summary>
        private decimal? qtmingondula;
        [XmlElement(ElementName = "QTMINGONDULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtmingondula
        {
            get { return  qtmingondula; }
            set {  qtmingondula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINIMAATACADO
        /// Coment�rio: 
        /// </summary>
        private decimal? qtminimaatacado;
        [XmlElement(ElementName = "QTMINIMAATACADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtminimaatacado
        {
            get { return  qtminimaatacado; }
            set {  qtminimaatacado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINIMAATACADOF
        /// Coment�rio: 
        /// </summary>
        private decimal? qtminimaatacadof;
        [XmlElement(ElementName = "QTMINIMAATACADOF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtminimaatacadof
        {
            get { return  qtminimaatacadof; }
            set {  qtminimaatacadof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINPRODUZIR
        /// Coment�rio: 
        /// </summary>
        private decimal? qtminproduzir;
        [XmlElement(ElementName = "QTMINPRODUZIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtminproduzir
        {
            get { return  qtminproduzir; }
            set {  qtminproduzir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINSUGCOMPRA
        /// Coment�rio: Qtde M�nima para compra
        /// </summary>
        private decimal? qtminsugcompra;
        [XmlElement(ElementName = "QTMINSUGCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal? Qtminsugcompra
        {
            get { return  qtminsugcompra; }
            set {  qtminsugcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOPEDIDO
        /// Coment�rio: 
        /// </summary>
        private decimal? qtpontopedido;
        [XmlElement(ElementName = "QTPONTOPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtpontopedido
        {
            get { return  qtpontopedido; }
            set {  qtpontopedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIR
        /// Coment�rio: Quantidade a produzir.
        /// </summary>
        private decimal? qtproduzir;
        [XmlElement(ElementName = "QTPRODUZIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Qtproduzir
        {
            get { return  qtproduzir; }
            set {  qtproduzir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPULMAOREGULADOR
        /// Coment�rio: 
        /// </summary>
        private decimal? qtpulmaoregulador;
        [XmlElement(ElementName = "QTPULMAOREGULADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Qtpulmaoregulador
        {
            get { return  qtpulmaoregulador; }
            set {  qtpulmaoregulador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTOTPAL
        /// Coment�rio: 
        /// </summary>
        private decimal? qttotpal;
        [XmlElement(ElementName = "QTTOTPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Qttotpal
        {
            get { return  qttotpal; }
            set {  qttotpal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTOTPALFRAC
        /// Coment�rio: Quantidade total pallete or�ado.
        /// </summary>
        private decimal? qttotpalfrac;
        [XmlElement(ElementName = "QTTOTPALFRAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qttotpalfrac
        {
            get { return  qttotpalfrac; }
            set {  qttotpalfrac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT
        /// Coment�rio: 
        /// </summary>
        private decimal? qtunit;
        [XmlElement(ElementName = "QTUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtunit
        {
            get { return  qtunit; }
            set {  qtunit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITCT
        /// Coment�rio: 
        /// </summary>
        private decimal? qtunitct;
        [XmlElement(ElementName = "QTUNITCT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Qtunitct
        {
            get { return  qtunitct; }
            set {  qtunitct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITCX
        /// Coment�rio: 
        /// </summary>
        private decimal? qtunitcx;
        [XmlElement(ElementName = "QTUNITCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Qtunitcx
        {
            get { return  qtunitcx; }
            set {  qtunitcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECMINARM
        /// Coment�rio: 
        /// </summary>
        private decimal? recminarm;
        [XmlElement(ElementName = "RECMINARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Recminarm
        {
            get { return  recminarm; }
            set {  recminarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXT
        /// Coment�rio: Ser� utilizado para Redu��o da Base de C�lculo da Aliquota Externa ref a substitui��o Tribut�ria na Entrada.
        /// </summary>
        private decimal? redbasealiqext;
        [XmlElement(ElementName = "REDBASEALIQEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Redbasealiqext
        {
            get { return  redbasealiqext; }
            set {  redbasealiqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXTBCR
        /// Coment�rio: Indica a redu��o base BCR.
        /// </summary>
        private decimal? redbasealiqextbcr;
        [XmlElement(ElementName = "REDBASEALIQEXTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Redbasealiqextbcr
        {
            get { return  redbasealiqextbcr; }
            set {  redbasealiqextbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEALIQEXTICMSANTECIP
        /// Coment�rio: % Redu��o Aliquota externa ICMS Antecipado.
        /// </summary>
        private decimal? redbasealiqexticmsantecip;
        [XmlElement(ElementName = "REDBASEALIQEXTICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Redbasealiqexticmsantecip
        {
            get { return  redbasealiqexticmsantecip; }
            set {  redbasealiqexticmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVA
        /// Coment�rio: Ser� utilizado para Redu��o da Base de C�lculo de Substitui��o Tribut�ria na Entrada.
        /// </summary>
        private decimal? redbaseiva;
        [XmlElement(ElementName = "REDBASEIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Redbaseiva
        {
            get { return  redbaseiva; }
            set {  redbaseiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVABCR
        /// Coment�rio: Indica redu��o base IVA BCR.
        /// </summary>
        private decimal? redbaseivabcr;
        [XmlElement(ElementName = "REDBASEIVABCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Redbaseivabcr
        {
            get { return  redbaseivabcr; }
            set {  redbaseivabcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDBASEIVAICMSANTECIP
        /// Coment�rio: % Redu��o IVA Icms Antecipado
        /// </summary>
        private decimal? redbaseivaicmsantecip;
        [XmlElement(ElementName = "REDBASEIVAICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Redbaseivaicmsantecip
        {
            get { return  redbaseivaicmsantecip; }
            set {  redbaseivaicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGISTROMSMED
        /// Coment�rio: Registro do Medicamento no Minist�rio da Sa�de
        /// </summary>
        private string registromsmed;
        [XmlElement(ElementName = "REGISTROMSMED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Registromsmed
        {
            get { return  registromsmed; }
            set {  registromsmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGMS
        /// Coment�rio: Registro do produto no Minist�rio da Sa�de. 
        /// </summary>
        private string regms;
        [XmlElement(ElementName = "REGMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Regms
        {
            get { return  regms; }
            set {  regms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOBLOCADO
        /// Coment�rio: 
        /// </summary>
        private decimal? restricaoblocado;
        [XmlElement(ElementName = "RESTRICAOBLOCADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Restricaoblocado
        {
            get { return  restricaoblocado; }
            set {  restricaoblocado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOTRANSP
        /// Coment�rio: Define se o produto tem restri��o "N" (Normal) ou "C" (Congelado).
        /// </summary>
        private string restricaotransp;
        [XmlElement(ElementName = "RESTRICAOTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restricaotransp
        {
            get { return  restricaotransp; }
            set {  restricaotransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRINGECOTACAO
        /// Coment�rio: APRESENTA SE O PRODUTO DEVE SER RESTRITO PARA COTA��O
        /// </summary>
        private string restringecotacao;
        [XmlElement(ElementName = "RESTRINGECOTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restringecotacao
        {
            get { return  restringecotacao; }
            set {  restringecotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETINOICO
        /// Coment�rio: Campo que define se o produto ser� do tipo retinoico sim ou n�o.
        /// </summary>
        private string retinoico;
        [XmlElement(ElementName = "RETINOICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Retinoico
        {
            get { return  retinoico; }
            set {  retinoico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REVENDA
        /// Coment�rio: 
        /// </summary>
        private string revenda;
        [XmlElement(ElementName = "REVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Revenda
        {
            get { return  revenda; }
            set {  revenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: ROTINA QUE GRAVOU A INFORMACAO
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
        private decimal? rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUACT
        /// Coment�rio: 
        /// </summary>
        private decimal? ruact;
        [XmlElement(ElementName = "RUACT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Ruact
        {
            get { return  ruact; }
            set {  ruact = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUACX
        /// Coment�rio: 
        /// </summary>
        private decimal? ruacx;
        [XmlElement(ElementName = "RUACX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Ruacx
        {
            get { return  ruacx; }
            set {  ruacx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA2
        /// Coment�rio: 
        /// </summary>
        private decimal? rua2;
        [XmlElement(ElementName = "RUA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Rua2
        {
            get { return  rua2; }
            set {  rua2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALMONELA
        /// Coment�rio: 
        /// </summary>
        private string salmonela;
        [XmlElement(ElementName = "SALMONELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Salmonela
        {
            get { return  salmonela; }
            set {  salmonela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQPAGINA
        /// Coment�rio: Indica o numero da linha.
        /// </summary>
        private decimal? seqpagina;
        [XmlElement(ElementName = "SEQPAGINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Seqpagina
        {
            get { return  seqpagina; }
            set {  seqpagina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQTABPRECO
        /// Coment�rio: 
        /// </summary>
        private decimal? seqtabpreco;
        [XmlElement(ElementName = "SEQTABPRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Seqtabpreco
        {
            get { return  seqtabpreco; }
            set {  seqtabpreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPRO
        /// Coment�rio: C�digo do produto no Simpro.
        /// </summary>
        private string simpro;
        [XmlElement(ElementName = "SIMPRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Simpro
        {
            get { return  simpro; }
            set {  simpro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: SITTRIBUTDEV
        /// Coment�rio: C�digo situa��o tributaria devolucao
        /// </summary>
        private string sittributdev;
        [XmlElement(ElementName = "SITTRIBUTDEV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributdev
        {
            get { return  sittributdev; }
            set {  sittributdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTDEVFORNEC
        /// Coment�rio: SITUA��O TRIBUTARIA DEVOLU��O FORNECEDOR
        /// </summary>
        private string sittributdevfornec;
        [XmlElement(ElementName = "SITTRIBUTDEVFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributdevfornec
        {
            get { return  sittributdevfornec; }
            set {  sittributdevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTENT
        /// Coment�rio: C�digo situa��o tributaria entrada
        /// </summary>
        private string sittributent;
        [XmlElement(ElementName = "SITTRIBUTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributent
        {
            get { return  sittributent; }
            set {  sittributent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT_SERVICO
        /// Coment�rio: Referente ao CST de sa�da de Servi�o cadastrado
        /// </summary>
        private string sittribut_servico;
        [XmlElement(ElementName = "SITTRIBUT_SERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribut_Servico
        {
            get { return  sittribut_servico; }
            set {  sittribut_servico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMENTETV3
        /// Coment�rio: 
        /// </summary>
        private string somentetv3;
        [XmlElement(ElementName = "SOMENTETV3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somentetv3
        {
            get { return  somentetv3; }
            set {  somentetv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSSUCATA
        /// Coment�rio: Define se o produto deve: devolver, n�o devolver ou calcular a sucata. 
        /// </summary>
        private decimal? statussucata;
        [XmlElement(ElementName = "STATUSSUCATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal? Statussucata
        {
            get { return  statussucata; }
            set {  statussucata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBSTANCIA
        /// Coment�rio: Gravar a substancia do produto para obter um controle especial
        /// </summary>
        private string substancia;
        [XmlElement(ElementName = "SUBSTANCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Substancia
        {
            get { return  substancia; }
            set {  substancia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBTITULOECOMMERCE
        /// Coment�rio: Subtitulo do produto para e-commerce
        /// </summary>
        private string subtituloecommerce;
        [XmlElement(ElementName = "SUBTITULOECOMMERCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Subtituloecommerce
        {
            get { return  subtituloecommerce; }
            set {  subtituloecommerce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUGVENDA
        /// Coment�rio: Sugerir pre�o venda baseado
        /// </summary>
        private decimal? sugvenda;
        [XmlElement(ElementName = "SUGVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Sugvenda
        {
            get { return  sugvenda; }
            set {  sugvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHOLOTEFAB
        /// Coment�rio: 
        /// </summary>
        private decimal? tamanholotefab;
        [XmlElement(ElementName = "TAMANHOLOTEFAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Tamanholotefab
        {
            get { return  tamanholotefab; }
            set {  tamanholotefab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHOPECA
        /// Coment�rio: Tamanho da pe�a na bitola pra pesquisa na 316
        /// </summary>
        private decimal? tamanhopeca;
        [XmlElement(ElementName = "TAMANHOPECA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Tamanhopeca
        {
            get { return  tamanhopeca; }
            set {  tamanhopeca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARAPORPECA
        /// Coment�rio: TARA do Produto Por Pe�a
        /// </summary>
        private decimal? taraporpeca;
        [XmlElement(ElementName = "TARAPORPECA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Taraporpeca
        {
            get { return  taraporpeca; }
            set {  taraporpeca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMREPOS
        /// Coment�rio: 
        /// </summary>
        private decimal? temrepos;
        [XmlElement(ElementName = "TEMREPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Temrepos
        {
            get { return  temrepos; }
            set {  temrepos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOALTURAPALETE
        /// Coment�rio: 
        /// </summary>
        private decimal? tipoalturapalete;
        [XmlElement(ElementName = "TIPOALTURAPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Tipoalturapalete
        {
            get { return  tipoalturapalete; }
            set {  tipoalturapalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOARM
        /// Coment�rio: 
        /// </summary>
        private decimal? tipoarm;
        [XmlElement(ElementName = "TIPOARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Tipoarm
        {
            get { return  tipoarm; }
            set {  tipoarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCST
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOCARGA
        /// Coment�rio: 
        /// </summary>
        private decimal? tipocarga;
        [XmlElement(ElementName = "TIPOCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Tipocarga
        {
            get { return  tipocarga; }
            set {  tipocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOMISSAO
        /// Coment�rio: Define se o produto utiliza Comiss�o Padr�o ou Comiss�o por Lucratividade.
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
        /// Propriedade referente ao campo: TIPOCUSTOTRANSF
        /// Coment�rio: Tipo de Custo de Transfer�ncia de Venda
        /// </summary>
        private string tipocustotransf;
        [XmlElement(ElementName = "TIPOCUSTOTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocustotransf
        {
            get { return  tipocustotransf; }
            set {  tipocustotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCARGA
        /// Coment�rio: 
        /// </summary>
        private string tipodescarga;
        [XmlElement(ElementName = "TIPODESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodescarga
        {
            get { return  tipodescarga; }
            set {  tipodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGE
        /// Coment�rio: 
        /// </summary>
        private string tipoembalage;
        [XmlElement(ElementName = "TIPOEMBALAGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoembalage
        {
            get { return  tipoembalage; }
            set {  tipoembalage = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMNESTLE
        /// Coment�rio: 
        /// </summary>
        private decimal? tipoembalagemnestle;
        [XmlElement(ElementName = "TIPOEMBALAGEMNESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Tipoembalagemnestle
        {
            get { return  tipoembalagemnestle; }
            set {  tipoembalagemnestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBARQUEIMP
        /// Coment�rio: Tipo de embarque para importa��o
        /// </summary>
        private string tipoembarqueimp;
        [XmlElement(ElementName = "TIPOEMBARQUEIMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Tipoembarqueimp
        {
            get { return  tipoembarqueimp; }
            set {  tipoembarqueimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOESTOQUE
        /// Coment�rio: 
        /// </summary>
        private string tipoestoque;
        [XmlElement(ElementName = "TIPOESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoestoque
        {
            get { return  tipoestoque; }
            set {  tipoestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMEDICAMENTO
        /// Coment�rio: Descri��o do tipo de medicamento.
        /// </summary>
        private string tipomedicamento;
        [XmlElement(ElementName = "TIPOMEDICAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipomedicamento
        {
            get { return  tipomedicamento; }
            set {  tipomedicamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMERC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOMP
        /// Coment�rio: 
        /// </summary>
        private string tipomp;
        [XmlElement(ElementName = "TIPOMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomp
        {
            get { return  tipomp; }
            set {  tipomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPONORMA
        /// Coment�rio: 
        /// </summary>
        private string tiponorma;
        [XmlElement(ElementName = "TIPONORMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiponorma
        {
            get { return  tiponorma; }
            set {  tiponorma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPAL
        /// Coment�rio: 
        /// </summary>
        private decimal? tipopal;
        [XmlElement(ElementName = "TIPOPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Tipopal
        {
            get { return  tipopal; }
            set {  tipopal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPALPUL
        /// Coment�rio: 
        /// </summary>
        private decimal? tipopalpul;
        [XmlElement(ElementName = "TIPOPALPUL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Tipopalpul
        {
            get { return  tipopalpul; }
            set {  tipopalpul = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPISCOFINSRETIDO
        /// Coment�rio: 
        /// </summary>
        private decimal? tipopiscofinsretido;
        [XmlElement(ElementName = "TIPOPISCOFINSRETIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Tipopiscofinsretido
        {
            get { return  tipopiscofinsretido; }
            set {  tipopiscofinsretido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPROD
        /// Coment�rio: 
        /// </summary>
        private decimal? tipoprod;
        [XmlElement(ElementName = "TIPOPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Tipoprod
        {
            get { return  tipoprod; }
            set {  tipoprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORESTRICAO
        /// Coment�rio: Tipo de resti��o para venda e separa��o de mercadoria.
        /// </summary>
        private string tiporestricao;
        [XmlElement(ElementName = "TIPORESTRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiporestricao
        {
            get { return  tiporestricao; }
            set {  tiporestricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORESTRICAOMED
        /// Coment�rio: 
        /// </summary>
        private string tiporestricaomed;
        [XmlElement(ElementName = "TIPORESTRICAOMED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tiporestricaomed
        {
            get { return  tiporestricaomed; }
            set {  tiporestricaomed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSUGCOMPRA
        /// Coment�rio: 
        /// </summary>
        private string tiposugcompra;
        [XmlElement(ElementName = "TIPOSUGCOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tiposugcompra
        {
            get { return  tiposugcompra; }
            set {  tiposugcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRIBUTMEDIC
        /// Coment�rio: 
        /// </summary>
        private string tipotributmedic;
        [XmlElement(ElementName = "TIPOTRIBUTMEDIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipotributmedic
        {
            get { return  tipotributmedic; }
            set {  tipotributmedic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVOLUMEDESCARGA
        /// Coment�rio: 
        /// </summary>
        private string tipovolumedescarga;
        [XmlElement(ElementName = "TIPOVOLUMEDESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovolumedescarga
        {
            get { return  tipovolumedescarga; }
            set {  tipovolumedescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULOECOMMERCE
        /// Coment�rio: T�tulo do produto para e-commerce
        /// </summary>
        private string tituloecommerce;
        [XmlElement(ElementName = "TITULOECOMMERCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Tituloecommerce
        {
            get { return  tituloecommerce; }
            set {  tituloecommerce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTDEFEITO
        /// Coment�rio: 
        /// </summary>
        private string totdefeito;
        [XmlElement(ElementName = "TOTDEFEITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Totdefeito
        {
            get { return  totdefeito; }
            set {  totdefeito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRIBFEDERAL
        /// Coment�rio: 
        /// </summary>
        private string tribfederal;
        [XmlElement(ElementName = "TRIBFEDERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Tribfederal
        {
            get { return  tribfederal; }
            set {  tribfederal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UMIDADE
        /// Coment�rio: 
        /// </summary>
        private string umidade;
        [XmlElement(ElementName = "UMIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Umidade
        {
            get { return  umidade; }
            set {  umidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UMIDADEANALISE
        /// Coment�rio: CAMPO DE ANALISE DE UMIDADE DA AMOSTRA.
        /// </summary>
        private string umidadeanalise;
        [XmlElement(ElementName = "UMIDADEANALISE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Umidadeanalise
        {
            get { return  umidadeanalise; }
            set {  umidadeanalise = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNDPOREMBALAGEM
        /// Coment�rio: Indica a unidades por embalagem.
        /// </summary>
        private decimal? undporembalagem;
        [XmlElement(ElementName = "UNDPOREMBALAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Undporembalagem
        {
            get { return  undporembalagem; }
            set {  undporembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Coment�rio: 
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADECT
        /// Coment�rio: 
        /// </summary>
        private string unidadect;
        [XmlElement(ElementName = "UNIDADECT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidadect
        {
            get { return  unidadect; }
            set {  unidadect = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADEMASTER
        /// Coment�rio: 
        /// </summary>
        private string unidademaster;
        [XmlElement(ElementName = "UNIDADEMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidademaster
        {
            get { return  unidademaster; }
            set {  unidademaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADETRIB
        /// Coment�rio: Unidade Tribut�vel
        /// </summary>
        private string unidadetrib;
        [XmlElement(ElementName = "UNIDADETRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Unidadetrib
        {
            get { return  unidadetrib; }
            set {  unidadetrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIFORMIDADE
        /// Coment�rio: Pesquisa de Uniformidade.
        /// </summary>
        private string uniformidade;
        [XmlElement(ElementName = "UNIFORMIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Uniformidade
        {
            get { return  uniformidade; }
            set {  uniformidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAALIQCREDICMSDIFER
        /// Coment�rio: 
        /// </summary>
        private string usaaliqcredicmsdifer;
        [XmlElement(ElementName = "USAALIQCREDICMSDIFER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaaliqcredicmsdifer
        {
            get { return  usaaliqcredicmsdifer; }
            set {  usaaliqcredicmsdifer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACLASSIFICACAO
        /// Coment�rio: 
        /// </summary>
        private string usaclassificacao;
        [XmlElement(ElementName = "USACLASSIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaclassificacao
        {
            get { return  usaclassificacao; }
            set {  usaclassificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACROSS
        /// Coment�rio: 
        /// </summary>
        private string usacross;
        [XmlElement(ElementName = "USACROSS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacross
        {
            get { return  usacross; }
            set {  usacross = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USALICENCAIMPORTACAO
        /// Coment�rio: Utiliza licen�a de importa��o
        /// </summary>
        private string usalicencaimportacao;
        [XmlElement(ElementName = "USALICENCAIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usalicencaimportacao
        {
            get { return  usalicencaimportacao; }
            set {  usalicencaimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPISCOFINSLIT
        /// Coment�rio: Usa PIS/COFINS por litragem
        /// </summary>
        private string usapiscofinslit;
        [XmlElement(ElementName = "USAPISCOFINSLIT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapiscofinslit
        {
            get { return  usapiscofinslit; }
            set {  usapiscofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPISCOFINSLITIMP
        /// Coment�rio: Usa PIS/COFINS por litragem
        /// </summary>
        private string usapiscofinslitimp;
        [XmlElement(ElementName = "USAPISCOFINSLITIMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapiscofinslitimp
        {
            get { return  usapiscofinslitimp; }
            set {  usapiscofinslitimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPMCBASEST
        /// Coment�rio: Usa PMC base ST
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
        /// Propriedade referente ao campo: USAPULMAOREGULADOR
        /// Coment�rio: 
        /// </summary>
        private string usapulmaoregulador;
        [XmlElement(ElementName = "USAPULMAOREGULADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapulmaoregulador
        {
            get { return  usapulmaoregulador; }
            set {  usapulmaoregulador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAWMS
        /// Coment�rio: 
        /// </summary>
        private string usawms;
        [XmlElement(ElementName = "USAWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usawms
        {
            get { return  usawms; }
            set {  usawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USOPROLONGADOSNGPC
        /// Coment�rio: Uso Prolongado na ANVISA	
        /// </summary>
        private string usoprolongadosngpc;
        [XmlElement(ElementName = "USOPROLONGADOSNGPC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usoprolongadosngpc
        {
            get { return  usoprolongadosngpc; }
            set {  usoprolongadosngpc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPRECOMAXCONSUMIDOR
        /// Coment�rio: Indica se utiliza pre�o m�ximo consumidor.
        /// </summary>
        private string utilizaprecomaxconsumidor;
        [XmlElement(ElementName = "UTILIZAPRECOMAXCONSUMIDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaprecomaxconsumidor
        {
            get { return  utilizaprecomaxconsumidor; }
            set {  utilizaprecomaxconsumidor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZARVASILHAME
        /// Coment�rio: 
        /// </summary>
        private string utilizarvasilhame;
        [XmlElement(ElementName = "UTILIZARVASILHAME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizarvasilhame
        {
            get { return  utilizarvasilhame; }
            set {  utilizarvasilhame = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZASELO
        /// Coment�rio: Identifica se o produto utiliza controle de selo IPI
        /// </summary>
        private string utilizaselo;
        [XmlElement(ElementName = "UTILIZASELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaselo
        {
            get { return  utilizaselo; }
            set {  utilizaselo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARLOTE
        /// Coment�rio: Indica se haver� valida��o de lote.
        /// </summary>
        private string validarlote;
        [XmlElement(ElementName = "VALIDARLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarlote
        {
            get { return  validarlote; }
            set {  validarlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCOFINSLITRAGEM
        /// Coment�rio: Valor PIS/COFINS litragem.
        /// </summary>
        private decimal? valorcofinslitragem;
        [XmlElement(ElementName = "VALORCOFINSLITRAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Valorcofinslitragem
        {
            get { return  valorcofinslitragem; }
            set {  valorcofinslitragem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPISLITRAGEM
        /// Coment�rio: Valor PIS/COFINS litragem.
        /// </summary>
        private decimal? valorpislitragem;
        [XmlElement(ElementName = "VALORPISLITRAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Valorpislitragem
        {
            get { return  valorpislitragem; }
            set {  valorpislitragem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTARAPORPECA
        /// Coment�rio: Valor TARA Por Pe�a
        /// </summary>
        private decimal? valortaraporpeca;
        [XmlElement(ElementName = "VALORTARAPORPECA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Valortaraporpeca
        {
            get { return  valortaraporpeca; }
            set {  valortaraporpeca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VELOCIDADEESP
        /// Coment�rio: 
        /// </summary>
        private decimal? velocidadeesp;
        [XmlElement(ElementName = "VELOCIDADEESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Velocidadeesp
        {
            get { return  velocidadeesp; }
            set {  velocidadeesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VELOCIDADEOPERACIONAL
        /// Coment�rio: 
        /// </summary>
        private decimal? velocidadeoperacional;
        [XmlElement(ElementName = "VELOCIDADEOPERACIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Velocidadeoperacional
        {
            get { return  velocidadeoperacional; }
            set {  velocidadeoperacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDADIRETA
        /// Coment�rio: 
        /// </summary>
        private string vendadireta;
        [XmlElement(ElementName = "VENDADIRETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendadireta
        {
            get { return  vendadireta; }
            set {  vendadireta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERBADINPORPERC
        /// Coment�rio: Calcular verba dinheiro por percentual
        /// </summary>
        private string verbadinporperc;
        [XmlElement(ElementName = "VERBADINPORPERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verbadinporperc
        {
            get { return  verbadinporperc; }
            set {  verbadinporperc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSANALISE
        /// Coment�rio: Vers�o da An�lise.
        /// </summary>
        private decimal? versanalise;
        [XmlElement(ElementName = "VERSANALISE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Versanalise
        {
            get { return  versanalise; }
            set {  versanalise = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONALBCICMSANTECIP
        /// Coment�rio: Valor adicional base Icms Antecipado
        /// </summary>
        private decimal? vladicionalbcicmsantecip;
        [XmlElement(ElementName = "VLADICIONALBCICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vladicionalbcicmsantecip
        {
            get { return  vladicionalbcicmsantecip; }
            set {  vladicionalbcicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONALBCST
        /// Coment�rio: Indica o valor adicional da base ST.
        /// </summary>
        private decimal? vladicionalbcst;
        [XmlElement(ElementName = "VLADICIONALBCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vladicionalbcst
        {
            get { return  vladicionalbcst; }
            set {  vladicionalbcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONALBCSTBCR
        /// Coment�rio: Indica o valor adicional base BCR.
        /// </summary>
        private decimal? vladicionalbcstbcr;
        [XmlElement(ElementName = "VLADICIONALBCSTBCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vladicionalbcstbcr
        {
            get { return  vladicionalbcstbcr; }
            set {  vladicionalbcstbcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Coment�rio: 
        /// </summary>
        private decimal? vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFICTAB
        /// Coment�rio: Valor Bonifica��o em Dinheiro Futuro
        /// </summary>
        private decimal? vlbonifictab;
        [XmlElement(ElementName = "VLBONIFICTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlbonifictab
        {
            get { return  vlbonifictab; }
            set {  vlbonifictab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCALORICO
        /// Coment�rio: 
        /// </summary>
        private string vlcalorico;
        [XmlElement(ElementName = "VLCALORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Vlcalorico
        {
            get { return  vlcalorico; }
            set {  vlcalorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINSLIT
        /// Coment�rio: Valor COFINS por litragem
        /// </summary>
        private decimal? vlcofinslit;
        [XmlElement(ElementName = "VLCOFINSLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlcofinslit
        {
            get { return  vlcofinslit; }
            set {  vlcofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINSLITIMP
        /// Coment�rio: Valor COFINS por litragem
        /// </summary>
        private decimal? vlcofinslitimp;
        [XmlElement(ElementName = "VLCOFINSLITIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlcofinslitimp
        {
            get { return  vlcofinslitimp; }
            set {  vlcofinslitimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFALIQUOTAS
        /// Coment�rio: Indica o valor da diferen�a de al�quota.
        /// </summary>
        private decimal? vldifaliquotas;
        [XmlElement(ElementName = "VLDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vldifaliquotas
        {
            get { return  vldifaliquotas; }
            set {  vldifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEPORKG
        /// Coment�rio: Valor de frete FOB por kg
        /// </summary>
        private decimal? vlfreteporkg;
        [XmlElement(ElementName = "VLFRETEPORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlfreteporkg
        {
            get { return  vlfreteporkg; }
            set {  vlfreteporkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSANTECIPADO
        /// Coment�rio: . |Campo do tipo num�rico, de tamanho 18, com 6 casas decimais, com valor default 0 , obrigat�rio. 
        /// </summary>
        private decimal? vlicmsantecipado;
        [XmlElement(ElementName = "VLICMSANTECIPADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlicmsantecipado
        {
            get { return  vlicmsantecipado; }
            set {  vlicmsantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Coment�rio: Valor do IPI
        /// </summary>
        private decimal? vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPESO
        /// Coment�rio: 
        /// </summary>
        private decimal? vlipipeso;
        [XmlElement(ElementName = "VLIPIPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlipipeso
        {
            get { return  vlipipeso; }
            set {  vlipipeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPORKG
        /// Coment�rio: 
        /// </summary>
        private decimal? vlipiporkg;
        [XmlElement(ElementName = "VLIPIPORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlipiporkg
        {
            get { return  vlipiporkg; }
            set {  vlipiporkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPORKGVENDA
        /// Coment�rio: Indica o IPI/KG venda.
        /// </summary>
        private decimal? vlipiporkgvenda;
        [XmlElement(ElementName = "VLIPIPORKGVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlipiporkgvenda
        {
            get { return  vlipiporkgvenda; }
            set {  vlipiporkgvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPORKGVENDATAB
        /// Coment�rio: Indica o IPI/KG venda futuro.
        /// </summary>
        private decimal? vlipiporkgvendatab;
        [XmlElement(ElementName = "VLIPIPORKGVENDATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlipiporkgvendatab
        {
            get { return  vlipiporkgvendatab; }
            set {  vlipiporkgvendatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPISUSPENSO
        /// Coment�rio: Valor do IPI suspenso
        /// </summary>
        private decimal? vlipisuspenso;
        [XmlElement(ElementName = "VLIPISUSPENSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlipisuspenso
        {
            get { return  vlipisuspenso; }
            set {  vlipisuspenso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAODEOBRA
        /// Coment�rio: Valor da M�o de Obra ao montar o Produto. 
        /// </summary>
        private decimal? vlmaodeobra;
        [XmlElement(ElementName = "VLMAODEOBRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Vlmaodeobra
        {
            get { return  vlmaodeobra; }
            set {  vlmaodeobra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTA
        /// Coment�rio: 
        /// </summary>
        private decimal? vlpauta;
        [XmlElement(ElementName = "VLPAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpauta
        {
            get { return  vlpauta; }
            set {  vlpauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTABCR
        /// Coment�rio: Indica valor pauta BCR.
        /// </summary>
        private decimal? vlpautabcr;
        [XmlElement(ElementName = "VLPAUTABCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpautabcr
        {
            get { return  vlpautabcr; }
            set {  vlpautabcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMS
        /// Coment�rio: Indica o valor de pauta ICMS.
        /// </summary>
        private decimal? vlpautaicms;
        [XmlElement(ElementName = "VLPAUTAICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpautaicms
        {
            get { return  vlpautaicms; }
            set {  vlpautaicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAICMSANTEC
        /// Coment�rio: Valor de pauta de ICMS Antecipado
        /// </summary>
        private decimal? vlpautaicmsantec;
        [XmlElement(ElementName = "VLPAUTAICMSANTEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpautaicmsantec
        {
            get { return  vlpautaicmsantec; }
            set {  vlpautaicmsantec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAIPI
        /// Coment�rio: Informar valor da pauta do IPI na tabela PCPRODUT.
        /// </summary>
        private decimal? vlpautaipi;
        [XmlElement(ElementName = "VLPAUTAIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpautaipi
        {
            get { return  vlpautaipi; }
            set {  vlpautaipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAIPIVENDA
        /// Coment�rio: Indica a pauta IPI venda.
        /// </summary>
        private decimal? vlpautaipivenda;
        [XmlElement(ElementName = "VLPAUTAIPIVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpautaipivenda
        {
            get { return  vlpautaipivenda; }
            set {  vlpautaipivenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAIPIVENDATAB
        /// Coment�rio: Indica a pauta IPI venda futuro.
        /// </summary>
        private decimal? vlpautaipivendatab;
        [XmlElement(ElementName = "VLPAUTAIPIVENDATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpautaipivendatab
        {
            get { return  vlpautaipivendatab; }
            set {  vlpautaipivendatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAPISCOFINS
        /// Coment�rio: Valor pauta PIS/COFINS
        /// </summary>
        private decimal? vlpautapiscofins;
        [XmlElement(ElementName = "VLPAUTAPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpautapiscofins
        {
            get { return  vlpautapiscofins; }
            set {  vlpautapiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAPISCOFINSIMP
        /// Coment�rio: Valor pauta PIS/COFINS
        /// </summary>
        private decimal? vlpautapiscofinsimp;
        [XmlElement(ElementName = "VLPAUTAPISCOFINSIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpautapiscofinsimp
        {
            get { return  vlpautapiscofinsimp; }
            set {  vlpautapiscofinsimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPISLIT
        /// Coment�rio: Valor PIS por litragem
        /// </summary>
        private decimal? vlpislit;
        [XmlElement(ElementName = "VLPISLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpislit
        {
            get { return  vlpislit; }
            set {  vlpislit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPISLITIMP
        /// Coment�rio: Valor PIS por litragem
        /// </summary>
        private decimal? vlpislitimp;
        [XmlElement(ElementName = "VLPISLITIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlpislitimp
        {
            get { return  vlpislitimp; }
            set {  vlpislitimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRAPLICINT
        /// Coment�rio: Valor interno para Integra��o APLIC.
        /// </summary>
        private decimal? vlraplicint;
        [XmlElement(ElementName = "VLRAPLICINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Vlraplicint
        {
            get { return  vlraplicint; }
            set {  vlraplicint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDATEMP
        /// Coment�rio: 
        /// </summary>
        private decimal? vlvendatemp;
        [XmlElement(ElementName = "VLVENDATEMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal? Vlvendatemp
        {
            get { return  vlvendatemp; }
            set {  vlvendatemp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLPESMED
        /// Coment�rio: Volume / Peso e Medida.
        /// </summary>
        private string volpesmed;
        [XmlElement(ElementName = "VOLPESMED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Volpesmed
        {
            get { return  volpesmed; }
            set {  volpesmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Coment�rio: 
        /// </summary>
        private decimal? volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMEARM
        /// Coment�rio: 
        /// </summary>
        private decimal? volumearm;
        [XmlElement(ElementName = "VOLUMEARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Volumearm
        {
            get { return  volumearm; }
            set {  volumearm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMEREC
        /// Coment�rio: 
        /// </summary>
        private decimal? volumerec;
        [XmlElement(ElementName = "VOLUMEREC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Volumerec
        {
            get { return  volumerec; }
            set {  volumerec = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdut()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdut> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdut>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdut> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdut>(where);
        }

        #endregion
    }
}
