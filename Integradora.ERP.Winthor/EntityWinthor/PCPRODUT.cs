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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Altura do Produto.
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
        /// Comentário: 
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
        /// Comentário: Altura do produto na norma pallete.
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
        /// Comentário: 
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
        /// Comentário: Altura Total do Produto.
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
        /// Comentário: Descontos de Análise.
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
        /// Comentário: Código ANP utilizado em combustiveis.
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
        /// Comentário: Código do produto na Anvisa.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Aplica %IVA sobre a Pauta ST..
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
        /// Comentário: Aplica IVA sobre valor de pauta ICMS antecipado
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
        /// Comentário: Aplicar redução base IVA preço liquido
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
        /// Comentário: Aplicar redução base IVA preço liquido BCR
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
        /// Comentário: Indica se o produto será aproveitado crédito ICMS na entrada. 
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
        /// Comentário: Aproveita crédito ICMS custo contabil na importação
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
        /// Comentário: 
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
        /// Comentário: Aproveita crédito PIS/COFINS custo contabil na importação
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: ATUPESOMASTERENT
        /// Comentário: Campo para verificar se na entrada do produto tem que validar o peso master
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
        /// Comentário: 
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
        /// Comentário: Base PIS/COFINS por litragem
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
        /// Comentário: Base PIS/COFINS por litragem
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
        /// Comentário: Base PIS/COFINS litragem.
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
        /// Comentário: 
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
        /// Comentário: Calcular Custo com Crédito de IPI (Compra). 
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
        /// Comentário: Calcula crédito IPI custo contabil na importação
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica capacidade de picking
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
        /// Comentário: 
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
        /// Comentário: Capacidade volumétrica para geração DNF.
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
        /// Comentário: Categoria de Produtos.
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
        /// Comentário: Cesta Básica - Legislação
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
        /// Comentário: Checar múltiplo em vendas bonificadas. Verifica obrigatoriedade de venda em quantidades múltiplas no caso de pedido de venda bonificado/troca (tps. 5, 6, 11 e 12). 
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
        /// Comentário: 
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
        /// Comentário: Indica a classe para comissionamento do produto. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Contempla Fluxo de Produtos
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
        /// Comentário: Classe margem do produto
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
        /// Comentário: Clase venda do produto.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código de Agrupamento de Mapa de Separação, utilizado na rotina 203. 
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
        /// Comentário: 
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
        /// Comentário: Código barra embalagem master.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Codigo da Categoria na WEB
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
        /// Comentário: Código da classe terapêutica na ANVISA
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
        /// Comentário: 
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
        /// Comentário: Codigo do Departamento na WEB
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código da exceção PIS/COFINS
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFILIALPRODUTORA
        /// Comentário: 
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
        /// Comentário: Indica o código da filial retira padrão.
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
        /// Comentário: 
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
        /// Comentário: Código Fiscal utilizado nas Entradas Bonificadas. 
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
        /// Comentário: CFOP Compra e Ordem - Compra
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
        /// Comentário: Indica o código fiscal para produto consignado.
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
        /// Comentário: Indica o código fiscal compra produto consignação.
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
        /// Comentário: CFOP Compra e Ordem - Remessa
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
        /// Comentário: CFOP DEVOLUÇÃO FORNECEDOR 
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
        /// Comentário: Código Fiscal Devolução Transf. Operador Logístico
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
        /// Comentário: Código Fiscal Entrada Transf. Operador Logístico
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
        /// Comentário: Indica o código fiscal de entrada por transferência.
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
        /// Comentário: Apresenta o Código fiscal de entrada TV9
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
        /// Comentário: Código Fiscal utilizado nas Entradas de Simples Remessas. 
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
        /// Comentário: Código do formato do papel.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código do Grupo de Litragem
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código da linha de produção.
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
        /// Comentário: Código da Linha Nestlé
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
        /// Comentário: Campo numérico para o usuario informar o Codigo da linha de prazo
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
        /// Comentário: 
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
        /// Comentário: Indica o peso da embalagem.
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
        /// Comentário: Código de exceção de NCM
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
        /// Comentário: 
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
        /// Comentário: Indica o número da ONU do produto quimico.
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
        /// Comentário: 
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
        /// Comentário: Campo de ligação com o Prazo de Entrega (PCPRAZO), que será usado para cálculo da data de entrega do item do pedido de compra.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código produto antes utilizar cadastro produto Winthor
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
        /// Comentário: Código do produto para geração DNF.
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
        /// Comentário: Indica o código da embalagem.
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
        /// Comentário: Código do Produto do Fornecedor
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código do produto relevante.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código da última rotina que fez ateração comercial no produto.
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
        /// Comentário: código da última rotina que fez ateração comercial no produto tab.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Codigo da Seção na WEB
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
        /// Comentário: Indica o Código da Situação Tributária Referente ao PIS/COFINS
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
        /// Comentário: Código Situação Tributaria PIS/COFINS devolução
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
        /// Comentário: GRAVAR O CÓDIGO DA SITUAÇÃO TRIBUTÁRIA ST
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
        /// Comentário: 
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
        /// Comentário: Codigo da SubCategoria na WEB
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
        /// Comentário: Submarca do Produto
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
        /// Comentário: Código da Tabela de Litragem
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: CÓDIGO DO TIPO USO RECEITUÁRIO.
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
        /// Comentário: CÓDIGO DO TIPO USO MÉDICO.
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
        /// Comentário: Código da figura tributária para cálculo do PIS/COFINS
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
        /// Comentário: Código da unidade de medida utilizada na Nota Fiscal.
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
        /// Comentário: Ultimo usuario altera politica comercial
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
        /// Comentário: Código do último usuário que fez ateração comercial no produto.
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
        /// Comentário: 
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
        /// Comentário: Percentual de COFINS retido venda.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Comissão serviço prestado.
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
        /// Comentário: Indica o produto em consignação.
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
        /// Comentário: 
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
        /// Comentário: Comprimento do produto na norma pallete.
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
        /// Comentário: Concentração do Produto
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
        /// Comentário: Indica se para o produto deverá ter ou não conciliação de importação.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Considerar ICMS Atencipado no Custo.
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
        /// Comentário: Considera II Suspenso base ICMS.
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
        /// Comentário: Considera IPI Suspenso base ICMS.
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
        /// Comentário: 
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
        /// Comentário: Contaminação Microbiana.
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
        /// Comentário: Controlado pelo IBAMA
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
        /// Comentário: Indica se controla o número de série.
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
        /// Comentário: Indica que o produtco controla número de série.
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
        /// Comentário: Verifica-se se o produto terá controle ou não de numeração de patrimônio.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Percentual de CSLL retido venda.
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
        /// Comentário: Custo de precificação por fornecedor, calculado a partir do preço de tabela do fornecedor informado pelo usuário. 
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
        /// Comentário: Valor do Custo Fornecedor sem ST.
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
        /// Comentário: 
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
        /// Comentário: Valor do Custo da próxima compra sem ST.
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
        /// Comentário: Custo de reposição da fabrica.
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
        /// Comentário: Preco de Compra anterior a atualização.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Gravar o valor do preço fabrica anterior.
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
        /// Comentário: 
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
        /// Comentário: Gravar o valor do preço Fabrica ZF manaus anterior
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
        /// Comentário: 
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
        /// Comentário: Informa os dados técnicos do produto. 
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
        /// Comentário: .
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
        /// Comentário: 
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
        /// Comentário: Pesquisa de Densidade.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Descrição do produto para sistema DIF-PAPEL IMUNE.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Pesquisa de Desintegração.
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
        /// Comentário: Indica destaque na ficha técnica.
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
        /// Comentário: Diâmetro externo do produto.
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
        /// Comentário: Diâmetro interno do produto.
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
        /// Comentário: Dias úteis consecutivos para entrega
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
        /// Comentário: Diretório da Assinatura.
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
        /// Comentário: Diretório de imagens para e-commerce
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
        /// Comentário: 
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
        /// Comentário: Pesquisa de Dissolução.
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
        /// Comentário: Pesquisa de Doseamento.
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
        /// Comentário: Descrição produto antes utilizar cadastro produto Winthor
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
        /// Comentário: Data alteração custo fornecedor.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Data  e hora de exportação
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
        /// Comentário: Data final utilização código produto antes utilizar cadastro produto Winthor
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
        /// Comentário: Data  e hora de importação
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
        /// Comentário: Data da última importação do registro na filial de destino da informação.
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
        /// Comentário: Data início código produto antes utilizar cadastro produto Winthor
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
        /// Comentário: Data de início do controle de validade por lote.
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
        /// Comentário: Data primeira Movimentação novo código produto Winthor
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
        /// Comentário: 
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
        /// Comentário: Data da ultima alteração de comissão.
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
        /// Comentário: Data da ultima atualização do custo reposição da fabrica.
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
        /// Comentário: Data da última alteração do registro no banco de dados.
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
        /// Comentário: Indica a data da ultima alteração nesta tabela.
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
        /// Comentário: Data da última atualização do preço de compra
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTVIGENCIAPOLITICA
        /// Comentário: Data de virgência da política comercial
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Informações Técnicas
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
        /// Comentário: Informa se envia para o força de vendas. 
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
        /// Comentário: Envia SNGPC [S-Sim;N-Não]
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica se exibe descrição da análise.
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
        /// Comentário: Indica se exibe bolores e leveduras.
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
        /// Comentário: Indica se exibe col 95º.
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
        /// Comentário: Indica se exibe contaminação microbiana.
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
        /// Comentário: Indica se exibe densidade.
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
        /// Comentário: Indica se exibe desintegração.
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
        /// Comentário: Indica se exibe dissolução.
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
        /// Comentário: Exibir o doseamento do produto.
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
        /// Comentário: Indica se exibe estafilococos aureas.
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
        /// Comentário: Indica se exibe friabilidade.
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
        /// Comentário: Indica se exibe identificação.
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
        /// Comentário: Exibir impureza do produto.
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
        /// Comentário: Indica se exibe lipídeos.
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
        /// Comentário: Indica se exibe mofado.
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
        /// Comentário: Indica se exibe pesquisa de patogenos.
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
        /// Comentário: Indica se exibe PH.
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
        /// Comentário: 
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
        /// Comentário: Indica se exibe proteina.
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
        /// Comentário: Indica se exibe salmonela.
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
        /// Comentário: Exc eção da TIPI para gravação do arquivo XML NFe.
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
        /// Comentário: Indica se exibe total de defeitos.
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
        /// Comentário: Indica se exibe umidade do produto.
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
        /// Comentário: Indica se exibe uniformidades.
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
        /// Comentário: Indica se exibe valor calorico.
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
        /// Comentário: Indica se exibe volume e peso médio.
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
        /// Comentário: Produto da Farmácia Popular
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
        /// Comentário: Fator de conversão a aplicar sobre a unidade de venda para geração DNF.
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
        /// Comentário: Fator de conversão do peso.
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
        /// Comentário: 
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
        /// Comentário: Fator Conversão NF-e
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Pesquisa de Friabilidade.
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
        /// Comentário: Produto pertencente ao FUNDAP, legislação do Espirito Santos, para impressão de livros fiscais.
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
        /// Comentário: Defina se deve gerar base de PIS/CONFINS mesmo quando não for informado aliquotas de PIS/CONFINS
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
        /// Comentário: Gerar icms livro fiscal na devolução fornecedor
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
        /// Comentário: Campo para definir que ao fechar a Ordem de serviço o sistema deve gerar outra ordem de serviço automaticamente.
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
        /// Comentário: Gramatura do papel.
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
        /// Comentário: GRUPO DE FATURAMENTO DO PRODUTO. UTILIZADO PARA EMPRESAS DO RAMO DE MEDICAMENTO.
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
        /// Comentário: Apresenta o padrão de código de barras GTIN
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
        /// Comentário: Apresenta o padrão de código de barras GTIN
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
        /// Comentário: Percentual ICMS ressarcimento.
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
        /// Comentário: Código do cadastro de Destaques importação rotina 3006.
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
        /// Comentário: Código Identificação Embalagem
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
        /// Comentário: Identificação da Análise.
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
        /// Comentário: Inscrição estadual do cte referenciado
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
        /// Comentário: 
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
        /// Comentário: Pesquisa de Impurezas.
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
        /// Comentário: Imune de Tributação.
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
        /// Comentário: Induzir Lotes
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
        /// Comentário: 
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
        /// Comentário: Indica se faz parte de inventário parcial.
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
        /// Comentário: Define se o produto utiliza IPI com valor fixo
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
        /// Comentário: Percentual de IR retido venda.
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
        /// Comentário: Indica se o produto é isento ou não do registro no Ministério da Saúde. 
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
        /// Comentário: Percentual IVA ressarcimento.
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
        /// Comentário: 
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
        /// Comentário: Largura do produto na norma pallete.
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
        /// Comentário: 
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
        /// Comentário: Indica a letra da página.
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
        /// Comentário: Código da Linha de Produto.
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
        /// Comentário: 
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
        /// Comentário: APRESENTA A LITRAGEM DO PRODUTO
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica do produto.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: MOFADO
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Quantidade múltipla de compras do produto
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
        /// Comentário: 
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
        /// Comentário: Enviar para o myFrota
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
        /// Comentário: Indica a natureza do produto.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Nome do produto para e-commerce
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Permitir que o usuário defina a quantidade de casas decimais que devem ser consideradas durante o cálculo de redução de ICMS
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
        /// Comentário: 
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
        /// Comentário: Numero de dias mínimo de validade.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Quantidade de Número de serie vinculados
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o numero da página.
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
        /// Comentário: Número Registro Agrotóxico MAPA
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Campo para definir qual o serviço que deve contar na OS gerada automaticamente.
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
        /// Comentário: 
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
        /// Comentário: Campo para definir se para esse serviço será obrigatório informar o numero do contrato de comodato na criação da OS.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Campo para definir se o serviço é de comodato.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Percentual de acréscimo a ser aplicado sobre o custo de precificação por fornecedor. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica à aliquota externa BCR.
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
        /// Comentário: Percentual da alíquota externa para calculo do ST Guia.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica á aliquota interna BCR.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: % Bonificação Dinheiro
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
        /// Comentário: % Bonificação Dinheiro Futuro
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: % Bonificação Outras Verbas Futuro
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
        /// Comentário: % Bonificação Mercadoria Futuro
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
        /// Comentário: Percentual de carga tributária média, utilizado no SEFAZ MT para calculo da substituição tributária
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
        /// Comentário: % Carga Média tributária Icms Antecipado
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
        /// Comentário: Percentual comissão motorista.
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
        /// Comentário: Indica o percentual de crédito ICMS presumido para o produto.
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto a ser aplicado sobre o cálculo do ICMS. 
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
        /// Comentário: Percentual do desconto de ICMS Difererido.
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Percentual de desconto comercial 1 futuro
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
        /// Comentário: 
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
        /// Comentário: Indica o percentual outras despesa na NF.
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
        /// Comentário: 
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
        /// Comentário: Indica o percentual de despesa fora da nota.
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
        /// Comentário: Indica o percentual de diferença de alíquota.
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
        /// Comentário: Indica o percentual de diferença no kg de produtos frios.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Aliq. Para base do ICMS antecipado
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
        /// Comentário: Indica o percentual do ICMS diferido.
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
        /// Comentário: % ICMS Frete FOB p/ calc.Icms Antecipado
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
        /// Comentário: Percentual de crédito de ICMS sobre o valor Frete FOB, utilizado no calculo do ST
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
        /// Comentário: Percentual de crédito de ICMS sobre o valor Frete FOB, utilizado no calculo do STBCR
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
        /// Comentário: 
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
        /// Comentário: Indica o percentual do imposto do produtor rural.
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
        /// Comentário: 
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
        /// Comentário: Percentual do IPI suspenso
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
        /// Comentário: 
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
        /// Comentário: Indica o % do IPI venda futuro.
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
        /// Comentário: 
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
        /// Comentário: Indica o % IVA BCR.
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
        /// Comentário: 
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
        /// Comentário: Percentual de MVA Original para cálculo do MVA ajustado
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
        /// Comentário: % IVA Original ICMS Antecipado
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
        /// Comentário: Indica o percentual de COFINS.
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
        /// Comentário: 
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
        /// Comentário: Referente ao %COFINS de Serviço cadastrado
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
        /// Comentário: 
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
        /// Comentário: Percentual de perda para rendimento de um Kg
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
        /// Comentário: Percentual benefício PRODEIC utilizado no relatório do PRODEIC da rotina 1031
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
        /// Comentário: Percentual de quebra permitido.
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
        /// Comentário: Indica o percentual de crédito ICMS.
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
        /// Comentário: Perc.redução PMC
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
        /// Comentário: Indica o percentual de seguro.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o percentual negociado na venda.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Permite programar produção.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Referente ao %PIS de Serviço cadastrado
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o peso da embalagem.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Peso máximo
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
        /// Comentário: Peso mínimo
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica se o peso e variável.
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
        /// Comentário: Pesquisa de Patógenos.
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
        /// Comentário: Pesquisa de PH.
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
        /// Comentário: 
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
        /// Comentário: Percentual de PIS retido venda.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o prazo de garantia do produto.
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
        /// Comentário: Indica o prazo máximo para indenização ou troca.
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
        /// Comentário: Indica o % prazo máximo vencimento produto.
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
        /// Comentário: PRAZO MÁXIMO VENDA
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
        /// Comentário: 
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
        /// Comentário: Prazo Médio de Venda. O Produto não poderá ser vendido quando o Prazo Médio é maior que o informado.
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
        /// Comentário: Indica o % prazo minimo vencimento produto.
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
        /// Comentário: 
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
        /// Comentário: Informar se o produto poder ser precificado automáticamente
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
        /// Comentário: Verifica se a precificação é feita em moeda estrangeira ou não.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Gravar o valor do preço Maximo cosumidor anterior
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
        /// Comentário: 
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
        /// Comentário: Gravar o valor do preço maximo cosumidor ZF manaus anterior
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Preço de tabela do fornecedor, este preço é disponibilizado através de tabela de preços do fornecedor.. 
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
        /// Comentário: Indica o preço de tabela do serviço.
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
        /// Comentário: Indica a quantidade máxima para separação por pedido.
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
        /// Comentário: Indica a quantidade máxima para separação por pedido.
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
        /// Comentário: 
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
        /// Comentário: Na rotina 203, pasta Armazenagem, receberá a metragem do produto. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Qtde Mínima para compra
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
        /// Comentário: 
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
        /// Comentário: Quantidade a produzir.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Quantidade total pallete orçado.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Será utilizado para Redução da Base de Cálculo da Aliquota Externa ref a substituição Tributária na Entrada.
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
        /// Comentário: Indica a redução base BCR.
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
        /// Comentário: % Redução Aliquota externa ICMS Antecipado.
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
        /// Comentário: Será utilizado para Redução da Base de Cálculo de Substituição Tributária na Entrada.
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
        /// Comentário: Indica redução base IVA BCR.
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
        /// Comentário: % Redução IVA Icms Antecipado
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
        /// Comentário: Registro do Medicamento no Ministério da Saúde
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
        /// Comentário: Registro do produto no Ministério da Saúde. 
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
        /// Comentário: 
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
        /// Comentário: Define se o produto tem restrição "N" (Normal) ou "C" (Congelado).
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
        /// Comentário: APRESENTA SE O PRODUTO DEVE SER RESTRITO PARA COTAÇÃO
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
        /// Comentário: Campo que define se o produto será do tipo retinoico sim ou não.
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
        /// Comentário: 
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
        /// Comentário: ROTINA QUE GRAVOU A INFORMACAO
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o numero da linha.
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
        /// Comentário: 
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
        /// Comentário: Código do produto no Simpro.
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
        /// Propriedade referente ao campo: SITTRIBUTDEV
        /// Comentário: Código situação tributaria devolucao
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
        /// Comentário: SITUAÇÃO TRIBUTARIA DEVOLUÇÃO FORNECEDOR
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
        /// Comentário: Código situação tributaria entrada
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
        /// Comentário: Referente ao CST de saída de Serviço cadastrado
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Define se o produto deve: devolver, não devolver ou calcular a sucata. 
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
        /// Comentário: Gravar a substancia do produto para obter um controle especial
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
        /// Comentário: Subtitulo do produto para e-commerce
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
        /// Comentário: Sugerir preço venda baseado
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
        /// Comentário: 
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
        /// Comentário: Tamanho da peça na bitola pra pesquisa na 316
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
        /// Comentário: TARA do Produto Por Peça
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Define se o produto utiliza Comissão Padrão ou Comissão por Lucratividade.
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
        /// Comentário: Tipo de Custo de Transferência de Venda
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Tipo de embarque para importação
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
        /// Comentário: 
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
        /// Comentário: Descrição do tipo de medicamento.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Tipo de restição para venda e separação de mercadoria.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Título do produto para e-commerce
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: CAMPO DE ANALISE DE UMIDADE DA AMOSTRA.
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
        /// Comentário: Indica a unidades por embalagem.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Unidade Tributável
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
        /// Comentário: Pesquisa de Uniformidade.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Utiliza licença de importação
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
        /// Comentário: Usa PIS/COFINS por litragem
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
        /// Comentário: Usa PIS/COFINS por litragem
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
        /// Comentário: Usa PMC base ST
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Uso Prolongado na ANVISA	
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
        /// Comentário: Indica se utiliza preço máximo consumidor.
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
        /// Comentário: 
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
        /// Comentário: Identifica se o produto utiliza controle de selo IPI
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
        /// Comentário: Indica se haverá validação de lote.
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
        /// Comentário: Valor PIS/COFINS litragem.
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
        /// Comentário: Valor PIS/COFINS litragem.
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
        /// Comentário: Valor TARA Por Peça
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Calcular verba dinheiro por percentual
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
        /// Comentário: Versão da Análise.
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
        /// Comentário: Valor adicional base Icms Antecipado
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
        /// Comentário: Indica o valor adicional da base ST.
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
        /// Comentário: Indica o valor adicional base BCR.
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
        /// Comentário: 
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
        /// Comentário: Valor Bonificação em Dinheiro Futuro
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
        /// Comentário: 
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
        /// Comentário: Valor COFINS por litragem
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
        /// Comentário: Valor COFINS por litragem
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
        /// Comentário: Indica o valor da diferença de alíquota.
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
        /// Comentário: Valor de frete FOB por kg
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
        /// Comentário: . |Campo do tipo numérico, de tamanho 18, com 6 casas decimais, com valor default 0 , obrigatório. 
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
        /// Comentário: Valor do IPI
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o IPI/KG venda.
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
        /// Comentário: Indica o IPI/KG venda futuro.
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
        /// Comentário: Valor do IPI suspenso
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
        /// Comentário: Valor da Mão de Obra ao montar o Produto. 
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
        /// Comentário: 
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
        /// Comentário: Indica valor pauta BCR.
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
        /// Comentário: Indica o valor de pauta ICMS.
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
        /// Comentário: Valor de pauta de ICMS Antecipado
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
        /// Comentário: Informar valor da pauta do IPI na tabela PCPRODUT.
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
        /// Comentário: Indica a pauta IPI venda.
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
        /// Comentário: Indica a pauta IPI venda futuro.
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
        /// Comentário: Valor pauta PIS/COFINS
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
        /// Comentário: Valor pauta PIS/COFINS
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
        /// Comentário: Valor PIS por litragem
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
        /// Comentário: Valor PIS por litragem
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
        /// Comentário: Valor interno para Integração APLIC.
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
        /// Comentário: 
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
        /// Comentário: Volume / Peso e Medida.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdut> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdut>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
