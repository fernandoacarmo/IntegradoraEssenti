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
    /// Classe referente a tabela PCConsum
    /// </summary>
    [XmlType("PCCONSUM")]
    public class PCConsum : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ABASTCORRETIVOAUTOMAT
        /// Comentário: 
        /// </summary>
        private string abastcorretivoautomat;
        [XmlElement(ElementName = "ABASTCORRETIVOAUTOMAT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abastcorretivoautomat
        {
            get { return  abastcorretivoautomat; }
            set {  abastcorretivoautomat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ABATEFRETEPRECOMINIMO
        /// Comentário: 
        /// </summary>
        private string abatefreteprecominimo;
        [XmlElement(ElementName = "ABATEFRETEPRECOMINIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abatefreteprecominimo
        {
            get { return  abatefreteprecominimo; }
            set {  abatefreteprecominimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ABATEFRETEVENDABALCAO
        /// Comentário: 
        /// </summary>
        private string abatefretevendabalcao;
        [XmlElement(ElementName = "ABATEFRETEVENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abatefretevendabalcao
        {
            get { return  abatefretevendabalcao; }
            set {  abatefretevendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ABATERDESCFINCOMISSAORCA
        /// Comentário: 
        /// </summary>
        private string abaterdescfincomissaorca;
        [XmlElement(ElementName = "ABATERDESCFINCOMISSAORCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abaterdescfincomissaorca
        {
            get { return  abaterdescfincomissaorca; }
            set {  abaterdescfincomissaorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ABATERIMPOSTOSCOMISSAORCA
        /// Comentário: 
        /// </summary>
        private string abaterimpostoscomissaorca;
        [XmlElement(ElementName = "ABATERIMPOSTOSCOMISSAORCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abaterimpostoscomissaorca
        {
            get { return  abaterimpostoscomissaorca; }
            set {  abaterimpostoscomissaorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ABATERIMPOSTOSDESCFIN
        /// Comentário: 
        /// </summary>
        private string abaterimpostosdescfin;
        [XmlElement(ElementName = "ABATERIMPOSTOSDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abaterimpostosdescfin
        {
            get { return  abaterimpostosdescfin; }
            set {  abaterimpostosdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAACRESCIMOPRECOFIXO
        /// Comentário: Indica se aceita acréscimo no preço fixo.
        /// </summary>
        private string aceitaacrescimoprecofixo;
        [XmlElement(ElementName = "ACEITAACRESCIMOPRECOFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitaacrescimoprecofixo
        {
            get { return  aceitaacrescimoprecofixo; }
            set {  aceitaacrescimoprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITABKTV3
        /// Comentário: 
        /// </summary>
        private string aceitabktv3;
        [XmlElement(ElementName = "ACEITABKTV3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitabktv3
        {
            get { return  aceitabktv3; }
            set {  aceitabktv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITACNPJEXCLUSIVOFORNEC
        /// Comentário: 
        /// </summary>
        private string aceitacnpjexclusivofornec;
        [XmlElement(ElementName = "ACEITACNPJEXCLUSIVOFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitacnpjexclusivofornec
        {
            get { return  aceitacnpjexclusivofornec; }
            set {  aceitacnpjexclusivofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITADESCBALCAORESERVA
        /// Comentário: Indica se aceita o desconto maior que o flexível na venda balcão reserva.
        /// </summary>
        private string aceitadescbalcaoreserva;
        [XmlElement(ElementName = "ACEITADESCBALCAORESERVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitadescbalcaoreserva
        {
            get { return  aceitadescbalcaoreserva; }
            set {  aceitadescbalcaoreserva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITADESCFLEXPRODMONITORADO
        /// Comentário: 
        /// </summary>
        private string aceitadescflexprodmonitorado;
        [XmlElement(ElementName = "ACEITADESCFLEXPRODMONITORADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitadescflexprodmonitorado
        {
            get { return  aceitadescflexprodmonitorado; }
            set {  aceitadescflexprodmonitorado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITADESCPRECOFIXO
        /// Comentário: . 
        /// </summary>
        private string aceitadescprecofixo;
        [XmlElement(ElementName = "ACEITADESCPRECOFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitadescprecofixo
        {
            get { return  aceitadescprecofixo; }
            set {  aceitadescprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITADESCPRECOFIXOCESTA
        /// Comentário: Indica se e aceito desconto em preço fixo de cesta básica.
        /// </summary>
        private string aceitadescprecofixocesta;
        [XmlElement(ElementName = "ACEITADESCPRECOFIXOCESTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitadescprecofixocesta
        {
            get { return  aceitadescprecofixocesta; }
            set {  aceitadescprecofixocesta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITADESCTMK
        /// Comentário: 
        /// </summary>
        private string aceitadesctmk;
        [XmlElement(ElementName = "ACEITADESCTMK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitadesctmk
        {
            get { return  aceitadesctmk; }
            set {  aceitadesctmk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITADESDCONSUMIDOROUTROSCLI
        /// Comentário: . 
        /// </summary>
        private string aceitadesdconsumidoroutroscli;
        [XmlElement(ElementName = "ACEITADESDCONSUMIDOROUTROSCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitadesdconsumidoroutroscli
        {
            get { return  aceitadesdconsumidoroutroscli; }
            set {  aceitadesdconsumidoroutroscli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAPFCONTRIBUINTE
        /// Comentário: Indica se o campo PCCLIENT.CONTRIBUINTE será validado na procedure de Faturamento. 
        /// </summary>
        private string aceitapfcontribuinte;
        [XmlElement(ElementName = "ACEITAPFCONTRIBUINTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitapfcontribuinte
        {
            get { return  aceitapfcontribuinte; }
            set {  aceitapfcontribuinte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDAALTUSUR
        /// Comentário: 
        /// </summary>
        private string aceitavendaaltusur;
        [XmlElement(ElementName = "ACEITAVENDAALTUSUR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendaaltusur
        {
            get { return  aceitavendaaltusur; }
            set {  aceitavendaaltusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDABALCAOESTNEG
        /// Comentário: 
        /// </summary>
        private string aceitavendabalcaoestneg;
        [XmlElement(ElementName = "ACEITAVENDABALCAOESTNEG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendabalcaoestneg
        {
            get { return  aceitavendabalcaoestneg; }
            set {  aceitavendabalcaoestneg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDABLOQ
        /// Comentário: 
        /// </summary>
        private string aceitavendabloq;
        [XmlElement(ElementName = "ACEITAVENDABLOQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendabloq
        {
            get { return  aceitavendabloq; }
            set {  aceitavendabloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDAPF
        /// Comentário: 
        /// </summary>
        private string aceitavendapf;
        [XmlElement(ElementName = "ACEITAVENDAPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendapf
        {
            get { return  aceitavendapf; }
            set {  aceitavendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDASEMEST
        /// Comentário: 
        /// </summary>
        private string aceitavendasemest;
        [XmlElement(ElementName = "ACEITAVENDASEMEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendasemest
        {
            get { return  aceitavendasemest; }
            set {  aceitavendasemest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACERTOCARGAFILIALDIFERENTE
        /// Comentário: Permite acerto de carga com títulos de filial diferente da filial informada no filtro.
        /// </summary>
        private string acertocargafilialdiferente;
        [XmlElement(ElementName = "ACERTOCARGAFILIALDIFERENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Acertocargafilialdiferente
        {
            get { return  acertocargafilialdiferente; }
            set {  acertocargafilialdiferente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACRESCIMOPFCOMIE
        /// Comentário: 
        /// </summary>
        private string acrescimopfcomie;
        [XmlElement(ElementName = "ACRESCIMOPFCOMIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Acrescimopfcomie
        {
            get { return  acrescimopfcomie; }
            set {  acrescimopfcomie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGREGARSTPRODSINTEGRA
        /// Comentário: . 
        /// </summary>
        private string agregarstprodsintegra;
        [XmlElement(ElementName = "AGREGARSTPRODSINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agregarstprodsintegra
        {
            get { return  agregarstprodsintegra; }
            set {  agregarstprodsintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMINTEROUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal aliqicminteroutrasdesp;
        [XmlElement(ElementName = "ALIQICMINTEROUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicminteroutrasdesp
        {
            get { return  aliqicminteroutrasdesp; }
            set {  aliqicminteroutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal aliqicmoutrasdesp;
        [XmlElement(ElementName = "ALIQICMOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmoutrasdesp
        {
            get { return  aliqicmoutrasdesp; }
            set {  aliqicmoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTERARCONTAAJUSTEEST
        /// Comentário: 
        /// </summary>
        private string alterarcontaajusteest;
        [XmlElement(ElementName = "ALTERARCONTAAJUSTEEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alterarcontaajusteest
        {
            get { return  alterarcontaajusteest; }
            set {  alterarcontaajusteest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTERARFILIALENTPA
        /// Comentário: 
        /// </summary>
        private string alterarfilialentpa;
        [XmlElement(ElementName = "ALTERARFILIALENTPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alterarfilialentpa
        {
            get { return  alterarfilialentpa; }
            set {  alterarfilialentpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTERARNUMSEQPEDIDO
        /// Comentário: 
        /// </summary>
        private string alterarnumseqpedido;
        [XmlElement(ElementName = "ALTERARNUMSEQPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Alterarnumseqpedido
        {
            get { return  alterarnumseqpedido; }
            set {  alterarnumseqpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTERARPRECOPLPAGAMENTO
        /// Comentário: 
        /// </summary>
        private string alterarprecoplpagamento;
        [XmlElement(ElementName = "ALTERARPRECOPLPAGAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alterarprecoplpagamento
        {
            get { return  alterarprecoplpagamento; }
            set {  alterarprecoplpagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APENASMIUDEZACHEKOUTCARREG
        /// Comentário: 
        /// </summary>
        private string apenasmiudezachekoutcarreg;
        [XmlElement(ElementName = "APENASMIUDEZACHEKOUTCARREG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Apenasmiudezachekoutcarreg
        {
            get { return  apenasmiudezachekoutcarreg; }
            set {  apenasmiudezachekoutcarreg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAACRESCPFTV3
        /// Comentário: 
        /// </summary>
        private string aplicaacrescpftv3;
        [XmlElement(ElementName = "APLICAACRESCPFTV3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicaacrescpftv3
        {
            get { return  aplicaacrescpftv3; }
            set {  aplicaacrescpftv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAREPASSEPERCBONIFIC
        /// Comentário: 
        /// </summary>
        private string aplicarepassepercbonific;
        [XmlElement(ElementName = "APLICAREPASSEPERCBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicarepassepercbonific
        {
            get { return  aplicarepassepercbonific; }
            set {  aplicarepassepercbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICARINDICECMV
        /// Comentário: Indica se o índice de venda será utilizado para o cálculo CMV no processo de venda.
        /// </summary>
        private string aplicarindicecmv;
        [XmlElement(ElementName = "APLICARINDICECMV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicarindicecmv
        {
            get { return  aplicarindicecmv; }
            set {  aplicarindicecmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICATXFIMAUTORIZACAO
        /// Comentário: 
        /// </summary>
        private string aplicatxfimautorizacao;
        [XmlElement(ElementName = "APLICATXFIMAUTORIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicatxfimautorizacao
        {
            get { return  aplicatxfimautorizacao; }
            set {  aplicatxfimautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AREADEAPANHA
        /// Comentário: 
        /// </summary>
        private string areadeapanha;
        [XmlElement(ElementName = "AREADEAPANHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Areadeapanha
        {
            get { return  areadeapanha; }
            set {  areadeapanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACLIULTALTER1203
        /// Comentário: 
        /// </summary>
        private string atualizacliultalter1203;
        [XmlElement(ElementName = "ATUALIZACLIULTALTER1203", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizacliultalter1203
        {
            get { return  atualizacliultalter1203; }
            set {  atualizacliultalter1203 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACONDCOMPEDCOMPRA
        /// Comentário: 
        /// </summary>
        private string atualizacondcompedcompra;
        [XmlElement(ElementName = "ATUALIZACONDCOMPEDCOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizacondcompedcompra
        {
            get { return  atualizacondcompedcompra; }
            set {  atualizacondcompedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACUSTOULTENTRANSF
        /// Comentário: 
        /// </summary>
        private string atualizacustoultentransf;
        [XmlElement(ElementName = "ATUALIZACUSTOULTENTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizacustoultentransf
        {
            get { return  atualizacustoultentransf; }
            set {  atualizacustoultentransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAENT1122
        /// Comentário: Indica se deve atualizar os dados da última entrada pela rotina 1122.
        /// </summary>
        private string atualizaent1122;
        [XmlElement(ElementName = "ATUALIZAENT1122", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaent1122
        {
            get { return  atualizaent1122; }
            set {  atualizaent1122 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAESTCONTCONVEMBALAGEM
        /// Comentário: Indica atualização do estoque contábil com  conversão de embalagem.
        /// </summary>
        private string atualizaestcontconvembalagem;
        [XmlElement(ElementName = "ATUALIZAESTCONTCONVEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaestcontconvembalagem
        {
            get { return  atualizaestcontconvembalagem; }
            set {  atualizaestcontconvembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZARPCPRODUTBONIFIC
        /// Comentário: 
        /// </summary>
        private string atualizarpcprodutbonific;
        [XmlElement(ElementName = "ATUALIZARPCPRODUTBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizarpcprodutbonific
        {
            get { return  atualizarpcprodutbonific; }
            set {  atualizarpcprodutbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTENTICARACERTOCX
        /// Comentário: 
        /// </summary>
        private string autenticaracertocx;
        [XmlElement(ElementName = "AUTENTICARACERTOCX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autenticaracertocx
        {
            get { return  autenticaracertocx; }
            set {  autenticaracertocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTENTICARDOC
        /// Comentário: 
        /// </summary>
        private string autenticardoc;
        [XmlElement(ElementName = "AUTENTICARDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autenticardoc
        {
            get { return  autenticardoc; }
            set {  autenticardoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AVISAFALTAEST
        /// Comentário: 
        /// </summary>
        private string avisafaltaest;
        [XmlElement(ElementName = "AVISAFALTAEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Avisafaltaest
        {
            get { return  avisafaltaest; }
            set {  avisafaltaest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXAMPNAENTPA
        /// Comentário: 
        /// </summary>
        private string baixampnaentpa;
        [XmlElement(ElementName = "BAIXAMPNAENTPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixampnaentpa
        {
            get { return  baixampnaentpa; }
            set {  baixampnaentpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXARDNICOMLANCAMENTO
        /// Comentário: Indica baixa de título com moeda DNI associada a lançamento de tesouraria não conciliada. 
        /// </summary>
        private string baixardnicomlancamento;
        [XmlElement(ElementName = "BAIXARDNICOMLANCAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixardnicomlancamento
        {
            get { return  baixardnicomlancamento; }
            set {  baixardnicomlancamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASECREDDEBRCAAUTORI
        /// Comentário: 
        /// </summary>
        private string basecreddebrcaautori;
        [XmlElement(ElementName = "BASECREDDEBRCAAUTORI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Basecreddebrcaautori
        {
            get { return  basecreddebrcaautori; }
            set {  basecreddebrcaautori = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BIOMETRIAPARTICIPASORTEIOBIRO
        /// Comentário: 
        /// </summary>
        private string biometriaparticipasorteiobiro;
        [XmlElement(ElementName = "BIOMETRIAPARTICIPASORTEIOBIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Biometriaparticipasorteiobiro
        {
            get { return  biometriaparticipasorteiobiro; }
            set {  biometriaparticipasorteiobiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQAPLICPERCMANUTINV
        /// Comentário: . 
        /// </summary>
        private string bloqaplicpercmanutinv;
        [XmlElement(ElementName = "BLOQAPLICPERCMANUTINV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqaplicpercmanutinv
        {
            get { return  bloqaplicpercmanutinv; }
            set {  bloqaplicpercmanutinv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQCLIAUT
        /// Comentário: Indica se bloqueia cliente automático.
        /// </summary>
        private string bloqcliaut;
        [XmlElement(ElementName = "BLOQCLIAUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqcliaut
        {
            get { return  bloqcliaut; }
            set {  bloqcliaut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQCLIENTEEXCDEVOL
        /// Comentário: Bloquear cliente por excesso de devolução. 
        /// </summary>
        private string bloqclienteexcdevol;
        [XmlElement(ElementName = "BLOQCLIENTEEXCDEVOL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqclienteexcdevol
        {
            get { return  bloqclienteexcdevol; }
            set {  bloqclienteexcdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQCODCLIPRINC
        /// Comentário: Bloqueia os clientes do Cliente Principal, quando este é bloqueado.
        /// </summary>
        private string bloqcodcliprinc;
        [XmlElement(ElementName = "BLOQCODCLIPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqcodcliprinc
        {
            get { return  bloqcodcliprinc; }
            set {  bloqcodcliprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQCONSISTENUMMAPA
        /// Comentário: Permite Bloquear ou Não a gravação na consistência do NUMMAPA na rotina 1064.
        /// </summary>
        private string bloqconsistenummapa;
        [XmlElement(ElementName = "BLOQCONSISTENUMMAPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqconsistenummapa
        {
            get { return  bloqconsistenummapa; }
            set {  bloqconsistenummapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQDESPVLRORC
        /// Comentário: 
        /// </summary>
        private string bloqdespvlrorc;
        [XmlElement(ElementName = "BLOQDESPVLRORC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqdespvlrorc
        {
            get { return  bloqdespvlrorc; }
            set {  bloqdespvlrorc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQDEVCLI
        /// Comentário: 
        /// </summary>
        private string bloqdevcli;
        [XmlElement(ElementName = "BLOQDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqdevcli
        {
            get { return  bloqdevcli; }
            set {  bloqdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQESTOQUETRANSF
        /// Comentário: 
        /// </summary>
        private string bloqestoquetransf;
        [XmlElement(ElementName = "BLOQESTOQUETRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqestoquetransf
        {
            get { return  bloqestoquetransf; }
            set {  bloqestoquetransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQFORNECVERBASVENCIDAS
        /// Comentário: Indica a utilização da opção "Bloqueia Fornecedores com Verbas Vencidas" na rotina [504 - Atualização Diária I].
        /// </summary>
        private string bloqfornecverbasvencidas;
        [XmlElement(ElementName = "BLOQFORNECVERBASVENCIDAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqfornecverbasvencidas
        {
            get { return  bloqfornecverbasvencidas; }
            set {  bloqfornecverbasvencidas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQF6PEDVENDABALCAO
        /// Comentário: 
        /// </summary>
        private string bloqf6pedvendabalcao;
        [XmlElement(ElementName = "BLOQF6PEDVENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqf6pedvendabalcao
        {
            get { return  bloqf6pedvendabalcao; }
            set {  bloqf6pedvendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQHISTORICOFIN
        /// Comentário: Indica se bloqueia a alteração do histórico nas rotinas de movimentação financeira.
        /// </summary>
        private string bloqhistoricofin;
        [XmlElement(ElementName = "BLOQHISTORICOFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqhistoricofin
        {
            get { return  bloqhistoricofin; }
            set {  bloqhistoricofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQITENSCORTE936
        /// Comentário: 
        /// </summary>
        private string bloqitenscorte936;
        [XmlElement(ElementName = "BLOQITENSCORTE936", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqitenscorte936
        {
            get { return  bloqitenscorte936; }
            set {  bloqitenscorte936 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQLIBPEDCOMDESCONTO
        /// Comentário: 
        /// </summary>
        private string bloqlibpedcomdesconto;
        [XmlElement(ElementName = "BLOQLIBPEDCOMDESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqlibpedcomdesconto
        {
            get { return  bloqlibpedcomdesconto; }
            set {  bloqlibpedcomdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQLIBPEDMARGEMNEG
        /// Comentário: 
        /// </summary>
        private string bloqlibpedmargemneg;
        [XmlElement(ElementName = "BLOQLIBPEDMARGEMNEG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqlibpedmargemneg
        {
            get { return  bloqlibpedmargemneg; }
            set {  bloqlibpedmargemneg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQPEDLIMCRED
        /// Comentário: 
        /// </summary>
        private string bloqpedlimcred;
        [XmlElement(ElementName = "BLOQPEDLIMCRED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqpedlimcred
        {
            get { return  bloqpedlimcred; }
            set {  bloqpedlimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQPRAZOMDVENDA
        /// Comentário: 
        /// </summary>
        private string bloqprazomdvenda;
        [XmlElement(ElementName = "BLOQPRAZOMDVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqprazomdvenda
        {
            get { return  bloqprazomdvenda; }
            set {  bloqprazomdvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEAPRODENT
        /// Comentário: 
        /// </summary>
        private string bloqueaprodent;
        [XmlElement(ElementName = "BLOQUEAPRODENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueaprodent
        {
            get { return  bloqueaprodent; }
            set {  bloqueaprodent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEARENDINVENT
        /// Comentário: 
        /// </summary>
        private string bloquearendinvent;
        [XmlElement(ElementName = "BLOQUEARENDINVENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloquearendinvent
        {
            get { return  bloquearendinvent; }
            set {  bloquearendinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEARENTPA
        /// Comentário: 
        /// </summary>
        private string bloquearentpa;
        [XmlElement(ElementName = "BLOQUEARENTPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloquearentpa
        {
            get { return  bloquearentpa; }
            set {  bloquearentpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEARPEDBONIFIC
        /// Comentário: Indica Bloqueio de Pedido de Venda Bonificado.
        /// </summary>
        private string bloquearpedbonific;
        [XmlElement(ElementName = "BLOQUEARPEDBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloquearpedbonific
        {
            get { return  bloquearpedbonific; }
            set {  bloquearpedbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIAVENDAESTPENDENTE
        /// Comentário: Indica se será bloqueada a venda de estoque pendente. Opções: Sim(S) ou Não(N).
        /// </summary>
        private string bloqueiavendaestpendente;
        [XmlElement(ElementName = "BLOQUEIAVENDAESTPENDENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiavendaestpendente
        {
            get { return  bloqueiavendaestpendente; }
            set {  bloqueiavendaestpendente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIO
        /// Comentário: 
        /// </summary>
        private string bloqueio;
        [XmlElement(ElementName = "BLOQUEIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueio
        {
            get { return  bloqueio; }
            set {  bloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQVENDATP1TPF
        /// Comentário: 
        /// </summary>
        private string bloqvendatp1tpf;
        [XmlElement(ElementName = "BLOQVENDATP1TPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqvendatp1tpf
        {
            get { return  bloqvendatp1tpf; }
            set {  bloqvendatp1tpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BONIFICALTDEBCREDRCA
        /// Comentário: 
        /// </summary>
        private string bonificaltdebcredrca;
        [XmlElement(ElementName = "BONIFICALTDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bonificaltdebcredrca
        {
            get { return  bonificaltdebcredrca; }
            set {  bonificaltdebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BROKERALTDEBCREDRCA
        /// Comentário: Indica se pedidos Broker irão contabilizar no débito/crédito de RCAs.
        /// </summary>
        private string brokeraltdebcredrca;
        [XmlElement(ElementName = "BROKERALTDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Brokeraltdebcredrca
        {
            get { return  brokeraltdebcredrca; }
            set {  brokeraltdebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDICMS
        /// Comentário: 
        /// </summary>
        private string calccredicms;
        [XmlElement(ElementName = "CALCCREDICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredicms
        {
            get { return  calccredicms; }
            set {  calccredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDPISCOFINS
        /// Comentário: 
        /// </summary>
        private string calccredpiscofins;
        [XmlElement(ElementName = "CALCCREDPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredpiscofins
        {
            get { return  calccredpiscofins; }
            set {  calccredpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCFRETEPORITEM
        /// Comentário: 
        /// </summary>
        private string calcfreteporitem;
        [XmlElement(ElementName = "CALCFRETEPORITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcfreteporitem
        {
            get { return  calcfreteporitem; }
            set {  calcfreteporitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCICMSFOMEZERO
        /// Comentário: Indica se será apurado automaticamente o crédito a deduzir de Fome Zero na rotina 1025. 
        /// </summary>
        private string calcicmsfomezero;
        [XmlElement(ElementName = "CALCICMSFOMEZERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcicmsfomezero
        {
            get { return  calcicmsfomezero; }
            set {  calcicmsfomezero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIOFVENDORCOMPOSTO
        /// Comentário: 
        /// </summary>
        private string calciofvendorcomposto;
        [XmlElement(ElementName = "CALCIOFVENDORCOMPOSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calciofvendorcomposto
        {
            get { return  calciofvendorcomposto; }
            set {  calciofvendorcomposto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCJUROSDESD
        /// Comentário: 
        /// </summary>
        private string calcjurosdesd;
        [XmlElement(ElementName = "CALCJUROSDESD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcjurosdesd
        {
            get { return  calcjurosdesd; }
            set {  calcjurosdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSTFONTEPF
        /// Comentário: 
        /// </summary>
        private string calcstfontepf;
        [XmlElement(ElementName = "CALCSTFONTEPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcstfontepf
        {
            get { return  calcstfontepf; }
            set {  calcstfontepf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSTPF
        /// Comentário: 
        /// </summary>
        private string calcstpf;
        [XmlElement(ElementName = "CALCSTPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcstpf
        {
            get { return  calcstpf; }
            set {  calcstpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULACUSTOENTPA
        /// Comentário: 
        /// </summary>
        private string calculacustoentpa;
        [XmlElement(ElementName = "CALCULACUSTOENTPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calculacustoentpa
        {
            get { return  calculacustoentpa; }
            set {  calculacustoentpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULAGIROTRANSF
        /// Comentário: 
        /// </summary>
        private string calculagirotransf;
        [XmlElement(ElementName = "CALCULAGIROTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calculagirotransf
        {
            get { return  calculagirotransf; }
            set {  calculagirotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULARSTCOMIPI
        /// Comentário: 
        /// </summary>
        private string calcularstcomipi;
        [XmlElement(ElementName = "CALCULARSTCOMIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcularstcomipi
        {
            get { return  calcularstcomipi; }
            set {  calcularstcomipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAMINHODIR
        /// Comentário: 
        /// </summary>
        private string caminhodir;
        [XmlElement(ElementName = "CAMINHODIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Caminhodir
        {
            get { return  caminhodir; }
            set {  caminhodir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAOPARTICIPASORTEIOBIRO
        /// Comentário: 
        /// </summary>
        private string cartaoparticipasorteiobiro;
        [XmlElement(ElementName = "CARTAOPARTICIPASORTEIOBIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cartaoparticipasorteiobiro
        {
            get { return  cartaoparticipasorteiobiro; }
            set {  cartaoparticipasorteiobiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: 
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CFOP5929ISENTO
        /// Comentário: 
        /// </summary>
        private string cfop5929isento;
        [XmlElement(ElementName = "CFOP5929ISENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cfop5929isento
        {
            get { return  cfop5929isento; }
            set {  cfop5929isento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGC
        /// Comentário: 
        /// </summary>
        private string cgc;
        [XmlElement(ElementName = "CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cgc
        {
            get { return  cgc; }
            set {  cgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCLIEXCLUSIVO
        /// Comentário: 
        /// </summary>
        private string cgccliexclusivo;
        [XmlElement(ElementName = "CGCCLIEXCLUSIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cgccliexclusivo
        {
            get { return  cgccliexclusivo; }
            set {  cgccliexclusivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHECARDIASUTEISTITPGNLIB
        /// Comentário: 
        /// </summary>
        private string checardiasuteistitpgnlib;
        [XmlElement(ElementName = "CHECARDIASUTEISTITPGNLIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Checardiasuteistitpgnlib
        {
            get { return  checardiasuteistitpgnlib; }
            set {  checardiasuteistitpgnlib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHECKOUTMAPAEMITIDO
        /// Comentário: 
        /// </summary>
        private string checkoutmapaemitido;
        [XmlElement(ElementName = "CHECKOUTMAPAEMITIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Checkoutmapaemitido
        {
            get { return  checkoutmapaemitido; }
            set {  checkoutmapaemitido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cidade
        {
            get { return  cidade; }
            set {  cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSECOMISPADRAO
        /// Comentário: Indica a classe de comissão padrão usada no produto. 
        /// </summary>
        private string classecomispadrao;
        [XmlElement(ElementName = "CLASSECOMISPADRAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Classecomispadrao
        {
            get { return  classecomispadrao; }
            set {  classecomispadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIIBGEOBRG
        /// Comentário: Indica que a cidade IBGE obrigatório.
        /// </summary>
        private string cliibgeobrg;
        [XmlElement(ElementName = "CLIIBGEOBRG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cliibgeobrg
        {
            get { return  cliibgeobrg; }
            set {  cliibgeobrg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIIPIOBRG
        /// Comentário: Obrigar informar se é Isento de IPI.
        /// </summary>
        private string cliipiobrg;
        [XmlElement(ElementName = "CLIIPIOBRG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cliipiobrg
        {
            get { return  cliipiobrg; }
            set {  cliipiobrg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBRARVLTARIFAPARC1
        /// Comentário: 
        /// </summary>
        private string cobrarvltarifaparc1;
        [XmlElement(ElementName = "COBRARVLTARIFAPARC1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cobrarvltarifaparc1
        {
            get { return  cobrarvltarifaparc1; }
            set {  cobrarvltarifaparc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLICONSUMIDOR
        /// Comentário: 
        /// </summary>
        private decimal codcliconsumidor;
        [XmlElement(ElementName = "CODCLICONSUMIDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcliconsumidor
        {
            get { return  codcliconsumidor; }
            set {  codcliconsumidor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIPC
        /// Comentário: Código do Cliente PC
        /// </summary>
        private decimal codclipc;
        [XmlElement(ElementName = "CODCLIPC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclipc
        {
            get { return  codclipc; }
            set {  codclipc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBINICIAL
        /// Comentário: 
        /// </summary>
        private string codcobinicial;
        [XmlElement(ElementName = "CODCOBINICIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobinicial
        {
            get { return  codcobinicial; }
            set {  codcobinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBRANCADESCFINANCEIRO
        /// Comentário: Código de Cobrança para Desconto Financeiro, usado na rotina 402 - Acerto de Carga, em conjunto com o parâmetro "Usa Saldo C.Corrente como Desc. Fin." (rotina 132, pasta "Venda/B)Permissões/Processo de Venda 1). 
        /// </summary>
        private string codcobrancadescfinanceiro;
        [XmlElement(ElementName = "CODCOBRANCADESCFINANCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobrancadescfinanceiro
        {
            get { return  codcobrancadescfinanceiro; }
            set {  codcobrancadescfinanceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAADIANTFOR
        /// Comentário: 
        /// </summary>
        private decimal codcontaadiantfor;
        [XmlElement(ElementName = "CODCONTAADIANTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaadiantfor
        {
            get { return  codcontaadiantfor; }
            set {  codcontaadiantfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAADIANTFOROUTROS
        /// Comentário: Indica o código da conta de adiantamento a outros fornecedores.
        /// </summary>
        private decimal codcontaadiantforoutros;
        [XmlElement(ElementName = "CODCONTAADIANTFOROUTROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaadiantforoutros
        {
            get { return  codcontaadiantforoutros; }
            set {  codcontaadiantforoutros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAAMOSTRAS
        /// Comentário: 
        /// </summary>
        private decimal codcontaamostras;
        [XmlElement(ElementName = "CODCONTAAMOSTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaamostras
        {
            get { return  codcontaamostras; }
            set {  codcontaamostras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTABENEFIC
        /// Comentário: Indica conta de despesa ou receita padrão para o processo de beneficiamento. 
        /// </summary>
        private decimal codcontabenefic;
        [XmlElement(ElementName = "CODCONTABENEFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontabenefic
        {
            get { return  codcontabenefic; }
            set {  codcontabenefic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTABILCF
        /// Comentário: Cod.Contabil nas Operacoes com Cupom Fiscal
        /// </summary>
        private string codcontabilcf;
        [XmlElement(ElementName = "CODCONTABILCF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codcontabilcf
        {
            get { return  codcontabilcf; }
            set {  codcontabilcf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACAMBIAL
        /// Comentário: Código de conta para lançamento de variação cambial, gerado na rotina 750. 
        /// </summary>
        private decimal codcontacambial;
        [XmlElement(ElementName = "CODCONTACAMBIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacambial
        {
            get { return  codcontacambial; }
            set {  codcontacambial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACOMISSAO
        /// Comentário: 
        /// </summary>
        private decimal codcontacomissao;
        [XmlElement(ElementName = "CODCONTACOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacomissao
        {
            get { return  codcontacomissao; }
            set {  codcontacomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACOMISSAO3
        /// Comentário: 
        /// </summary>
        private decimal codcontacomissao3;
        [XmlElement(ElementName = "CODCONTACOMISSAO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacomissao3
        {
            get { return  codcontacomissao3; }
            set {  codcontacomissao3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACUSTOSCARTORIO
        /// Comentário: Código da conta do lançamento no Contas a Pagar para Custos de Cartório informado no Desdobramento (1210).
        /// </summary>
        private decimal codcontacustoscartorio;
        [XmlElement(ElementName = "CODCONTACUSTOSCARTORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacustoscartorio
        {
            get { return  codcontacustoscartorio; }
            set {  codcontacustoscartorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADESCCR
        /// Comentário: 
        /// </summary>
        private decimal codcontadesccr;
        [XmlElement(ElementName = "CODCONTADESCCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontadesccr
        {
            get { return  codcontadesccr; }
            set {  codcontadesccr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADESENVOLVIMENTO
        /// Comentário: 
        /// </summary>
        private decimal codcontadesenvolvimento;
        [XmlElement(ElementName = "CODCONTADESENVOLVIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontadesenvolvimento
        {
            get { return  codcontadesenvolvimento; }
            set {  codcontadesenvolvimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADESPESAPRODUCAO
        /// Comentário: 
        /// </summary>
        private decimal codcontadespesaproducao;
        [XmlElement(ElementName = "CODCONTADESPESAPRODUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontadespesaproducao
        {
            get { return  codcontadespesaproducao; }
            set {  codcontadespesaproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADESPOS
        /// Comentário: Indica o código conta despesa ordem de serviço.
        /// </summary>
        private decimal codcontadespos;
        [XmlElement(ElementName = "CODCONTADESPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontadespos
        {
            get { return  codcontadespos; }
            set {  codcontadespos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADEVCLI
        /// Comentário: Indica o código de conta padrão na devolução de cliente gerando contas a pagar.
        /// </summary>
        private decimal codcontadevcli;
        [XmlElement(ElementName = "CODCONTADEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontadevcli
        {
            get { return  codcontadevcli; }
            set {  codcontadevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAFALTACAIXA
        /// Comentário: Indica o Código da Conta no Contas a Pagar(PCLANC), referente ao lançamento de Falta de Caixa, efetuado ao fechar o caixa na 409.
        /// </summary>
        private decimal codcontafaltacaixa;
        [XmlElement(ElementName = "CODCONTAFALTACAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontafaltacaixa
        {
            get { return  codcontafaltacaixa; }
            set {  codcontafaltacaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAGNRE
        /// Comentário: Indica o código da conta das GNRE.
        /// </summary>
        private decimal codcontagnre;
        [XmlElement(ElementName = "CODCONTAGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontagnre
        {
            get { return  codcontagnre; }
            set {  codcontagnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAGUIAST
        /// Comentário: 
        /// </summary>
        private decimal codcontaguiast;
        [XmlElement(ElementName = "CODCONTAGUIAST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaguiast
        {
            get { return  codcontaguiast; }
            set {  codcontaguiast = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAJUSTEEST
        /// Comentário: 
        /// </summary>
        private decimal codcontajusteest;
        [XmlElement(ElementName = "CODCONTAJUSTEEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontajusteest
        {
            get { return  codcontajusteest; }
            set {  codcontajusteest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTALP
        /// Comentário: 
        /// </summary>
        private decimal codcontalp;
        [XmlElement(ElementName = "CODCONTALP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontalp
        {
            get { return  codcontalp; }
            set {  codcontalp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAMANUTCUSTO
        /// Comentário: 
        /// </summary>
        private decimal codcontamanutcusto;
        [XmlElement(ElementName = "CODCONTAMANUTCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontamanutcusto
        {
            get { return  codcontamanutcusto; }
            set {  codcontamanutcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTANTPAG
        /// Comentário: 
        /// </summary>
        private decimal codcontantpag;
        [XmlElement(ElementName = "CODCONTANTPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontantpag
        {
            get { return  codcontantpag; }
            set {  codcontantpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAPERDA
        /// Comentário: 
        /// </summary>
        private decimal codcontaperda;
        [XmlElement(ElementName = "CODCONTAPERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaperda
        {
            get { return  codcontaperda; }
            set {  codcontaperda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAPERDAESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal codcontaperdaestoque;
        [XmlElement(ElementName = "CODCONTAPERDAESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaperdaestoque
        {
            get { return  codcontaperdaestoque; }
            set {  codcontaperdaestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAPRODUCAO
        /// Comentário: 
        /// </summary>
        private decimal codcontaproducao;
        [XmlElement(ElementName = "CODCONTAPRODUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaproducao
        {
            get { return  codcontaproducao; }
            set {  codcontaproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAQUALIDADE
        /// Comentário: 
        /// </summary>
        private decimal codcontaqualidade;
        [XmlElement(ElementName = "CODCONTAQUALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaqualidade
        {
            get { return  codcontaqualidade; }
            set {  codcontaqualidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAREBAIXACMV
        /// Comentário: 
        /// </summary>
        private decimal codcontarebaixacmv;
        [XmlElement(ElementName = "CODCONTAREBAIXACMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontarebaixacmv
        {
            get { return  codcontarebaixacmv; }
            set {  codcontarebaixacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAREBAIXACMVAAPURAR
        /// Comentário: Indica a conta rebaixa de CMV com valor a apurar.
        /// </summary>
        private decimal codcontarebaixacmvaapurar;
        [XmlElement(ElementName = "CODCONTAREBAIXACMVAAPURAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontarebaixacmvaapurar
        {
            get { return  codcontarebaixacmvaapurar; }
            set {  codcontarebaixacmvaapurar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAREBAIXACUSTO
        /// Comentário: 
        /// </summary>
        private decimal codcontarebaixacusto;
        [XmlElement(ElementName = "CODCONTAREBAIXACUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontarebaixacusto
        {
            get { return  codcontarebaixacusto; }
            set {  codcontarebaixacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTARECDESCARGA
        /// Comentário: 
        /// </summary>
        private decimal codcontarecdescarga;
        [XmlElement(ElementName = "CODCONTARECDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontarecdescarga
        {
            get { return  codcontarecdescarga; }
            set {  codcontarecdescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAREQMP
        /// Comentário: 
        /// </summary>
        private decimal codcontareqmp;
        [XmlElement(ElementName = "CODCONTAREQMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontareqmp
        {
            get { return  codcontareqmp; }
            set {  codcontareqmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTARESTCLI
        /// Comentário: 
        /// </summary>
        private decimal codcontarestcli;
        [XmlElement(ElementName = "CODCONTARESTCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontarestcli
        {
            get { return  codcontarestcli; }
            set {  codcontarestcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTARESTRCA
        /// Comentário: 
        /// </summary>
        private decimal codcontarestrca;
        [XmlElement(ElementName = "CODCONTARESTRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontarestrca
        {
            get { return  codcontarestrca; }
            set {  codcontarestrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTASOBRAACERTO
        /// Comentário: 
        /// </summary>
        private decimal codcontasobraacerto;
        [XmlElement(ElementName = "CODCONTASOBRAACERTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontasobraacerto
        {
            get { return  codcontasobraacerto; }
            set {  codcontasobraacerto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTASOBRACAIXA
        /// Comentário: Indica o Código da Conta no Contas a Pagar(PCLANC), referente ao lançamento de Sobra de Caixa, efetuado ao fechar o caixa na 409. 
        /// </summary>
        private decimal codcontasobracaixa;
        [XmlElement(ElementName = "CODCONTASOBRACAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontasobracaixa
        {
            get { return  codcontasobracaixa; }
            set {  codcontasobracaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTASOBRAMERC
        /// Comentário: Código da Conta para o Lançamento de Sobra de Mercadoria. 
        /// </summary>
        private decimal codcontasobramerc;
        [XmlElement(ElementName = "CODCONTASOBRAMERC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontasobramerc
        {
            get { return  codcontasobramerc; }
            set {  codcontasobramerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTATRANSFTV10
        /// Comentário: Código da Conta para transferências de tipo de venda 10. 
        /// </summary>
        private decimal codcontatransftv10;
        [XmlElement(ElementName = "CODCONTATRANSFTV10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontatransftv10
        {
            get { return  codcontatransftv10; }
            set {  codcontatransftv10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAVERBACMV
        /// Comentário: Indica a conta de receita ou despesa utilizada no momento do faturamento, ou devolução de cliente, referente ao valor da verba de aplicado ao CMV. Esta verba é calculada na digitação do pedido e não poderá ser informada contas do Grupo 100. 
        /// </summary>
        private decimal codcontaverbacmv;
        [XmlElement(ElementName = "CODCONTAVERBACMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaverbacmv
        {
            get { return  codcontaverbacmv; }
            set {  codcontaverbacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAVERBAFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codcontaverbafornec;
        [XmlElement(ElementName = "CODCONTAVERBAFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaverbafornec
        {
            get { return  codcontaverbafornec; }
            set {  codcontaverbafornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTCLI
        /// Comentário: 
        /// </summary>
        private decimal codcontcli;
        [XmlElement(ElementName = "CODCONTCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontcli
        {
            get { return  codcontcli; }
            set {  codcontcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTDEBV
        /// Comentário: 
        /// </summary>
        private decimal codcontdebv;
        [XmlElement(ElementName = "CODCONTDEBV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontdebv
        {
            get { return  codcontdebv; }
            set {  codcontdebv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTDESCCONC
        /// Comentário: 
        /// </summary>
        private decimal codcontdescconc;
        [XmlElement(ElementName = "CODCONTDESCCONC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontdescconc
        {
            get { return  codcontdescconc; }
            set {  codcontdescconc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTDESPORDEMSERVICO
        /// Comentário: Indica o código da conta de despesa ordem de serviço.
        /// </summary>
        private decimal codcontdespordemservico;
        [XmlElement(ElementName = "CODCONTDESPORDEMSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontdespordemservico
        {
            get { return  codcontdespordemservico; }
            set {  codcontdespordemservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTDEVCLI
        /// Comentário: 
        /// </summary>
        private decimal codcontdevcli;
        [XmlElement(ElementName = "CODCONTDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontdevcli
        {
            get { return  codcontdevcli; }
            set {  codcontdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTEMPREST
        /// Comentário: 
        /// </summary>
        private decimal codcontemprest;
        [XmlElement(ElementName = "CODCONTEMPREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontemprest
        {
            get { return  codcontemprest; }
            set {  codcontemprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTFOR
        /// Comentário: 
        /// </summary>
        private decimal codcontfor;
        [XmlElement(ElementName = "CODCONTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontfor
        {
            get { return  codcontfor; }
            set {  codcontfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTFRE
        /// Comentário: 
        /// </summary>
        private decimal codcontfre;
        [XmlElement(ElementName = "CODCONTFRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontfre
        {
            get { return  codcontfre; }
            set {  codcontfre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTICMSANTECIP
        /// Comentário: 
        /// </summary>
        private decimal codconticmsantecip;
        [XmlElement(ElementName = "CODCONTICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconticmsantecip
        {
            get { return  codconticmsantecip; }
            set {  codconticmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTOUT
        /// Comentário: 
        /// </summary>
        private decimal codcontout;
        [XmlElement(ElementName = "CODCONTOUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontout
        {
            get { return  codcontout; }
            set {  codcontout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTPAGDIARIA
        /// Comentário: Código da Conta para Lançamento de Diárias de Viagens e Despesas Ajudante, a ser utilizada pela rotina 1449.
        /// </summary>
        private decimal codcontpagdiaria;
        [XmlElement(ElementName = "CODCONTPAGDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontpagdiaria
        {
            get { return  codcontpagdiaria; }
            set {  codcontpagdiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTPAGJUR
        /// Comentário: 
        /// </summary>
        private decimal codcontpagjur;
        [XmlElement(ElementName = "CODCONTPAGJUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontpagjur
        {
            get { return  codcontpagjur; }
            set {  codcontpagjur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTRECJUR
        /// Comentário: 
        /// </summary>
        private decimal codcontrecjur;
        [XmlElement(ElementName = "CODCONTRECJUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontrecjur
        {
            get { return  codcontrecjur; }
            set {  codcontrecjur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALCX
        /// Comentário: 
        /// </summary>
        private string codfilialcx;
        [XmlElement(ElementName = "CODFILIALCX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialcx
        {
            get { return  codfilialcx; }
            set {  codfilialcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALFV
        /// Comentário: 
        /// </summary>
        private string codfilialfv;
        [XmlElement(ElementName = "CODFILIALFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialfv
        {
            get { return  codfilialfv; }
            set {  codfilialfv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal codfiscaldevoutrasdesp;
        [XmlElement(ElementName = "CODFISCALDEVOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscaldevoutrasdesp
        {
            get { return  codfiscaldevoutrasdesp; }
            set {  codfiscaldevoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETE
        /// Comentário: 
        /// </summary>
        private decimal codfiscalfrete;
        [XmlElement(ElementName = "CODFISCALFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfiscalfrete
        {
            get { return  codfiscalfrete; }
            set {  codfiscalfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALFRETEENT
        /// Comentário: Campo que identifica o CFOP padrão para fretes na entrada estadual.
        /// </summary>
        private decimal codfiscalfreteent;
        [XmlElement(ElementName = "CODFISCALFRETEENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfiscalfreteent
        {
            get { return  codfiscalfreteent; }
            set {  codfiscalfreteent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERDEVOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal codfiscalinterdevoutrasdesp;
        [XmlElement(ElementName = "CODFISCALINTERDEVOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalinterdevoutrasdesp
        {
            get { return  codfiscalinterdevoutrasdesp; }
            set {  codfiscalinterdevoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERFRETE
        /// Comentário: 
        /// </summary>
        private decimal codfiscalinterfrete;
        [XmlElement(ElementName = "CODFISCALINTERFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfiscalinterfrete
        {
            get { return  codfiscalinterfrete; }
            set {  codfiscalinterfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERFRETEENT
        /// Comentário: Campo que identifica o CFOP padrão para fretes na entrada interestadual.
        /// </summary>
        private decimal codfiscalinterfreteent;
        [XmlElement(ElementName = "CODFISCALINTERFRETEENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfiscalinterfreteent
        {
            get { return  codfiscalinterfreteent; }
            set {  codfiscalinterfreteent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTEROUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal codfiscalinteroutrasdesp;
        [XmlElement(ElementName = "CODFISCALINTEROUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalinteroutrasdesp
        {
            get { return  codfiscalinteroutrasdesp; }
            set {  codfiscalinteroutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOUTRASDESP
        /// Comentário: 
        /// </summary>
        private decimal codfiscaloutrasdesp;
        [XmlElement(ElementName = "CODFISCALOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscaloutrasdesp
        {
            get { return  codfiscaloutrasdesp; }
            set {  codfiscaloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTADICOMIS
        /// Comentário: 
        /// </summary>
        private decimal codhistadicomis;
        [XmlElement(ElementName = "CODHISTADICOMIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistadicomis
        {
            get { return  codhistadicomis; }
            set {  codhistadicomis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTFECHCOMIS
        /// Comentário: 
        /// </summary>
        private decimal codhistfechcomis;
        [XmlElement(ElementName = "CODHISTFECHCOMIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistfechcomis
        {
            get { return  codhistfechcomis; }
            set {  codhistfechcomis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTFECHCOMISNEG
        /// Comentário: 
        /// </summary>
        private decimal codhistfechcomisneg;
        [XmlElement(ElementName = "CODHISTFECHCOMISNEG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistfechcomisneg
        {
            get { return  codhistfechcomisneg; }
            set {  codhistfechcomisneg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTVISITAPADRAOCALLCENTER
        /// Comentário: 
        /// </summary>
        private decimal codmotvisitapadraocallcenter;
        [XmlElement(ElementName = "CODMOTVISITAPADRAOCALLCENTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmotvisitapadraocallcenter
        {
            get { return  codmotvisitapadraocallcenter; }
            set {  codmotvisitapadraocallcenter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGAUTOMATIC
        /// Comentário: Indica o código plano pagamento automático.
        /// </summary>
        private string codplpagautomatic;
        [XmlElement(ElementName = "CODPLPAGAUTOMATIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codplpagautomatic
        {
            get { return  codplpagautomatic; }
            set {  codplpagautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGINICIAL
        /// Comentário: 
        /// </summary>
        private decimal codplpaginicial;
        [XmlElement(ElementName = "CODPLPAGINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpaginicial
        {
            get { return  codplpaginicial; }
            set {  codplpaginicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACAAUTOMATIC
        /// Comentário: 
        /// </summary>
        private string codpracaautomatic;
        [XmlElement(ElementName = "CODPRACAAUTOMATIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codpracaautomatic
        {
            get { return  codpracaautomatic; }
            set {  codpracaautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORCALLCENTER
        /// Comentário: 
        /// </summary>
        private decimal codsetorcallcenter;
        [XmlElement(ElementName = "CODSETORCALLCENTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorcallcenter
        {
            get { return  codsetorcallcenter; }
            set {  codsetorcallcenter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORCOBRANCA
        /// Comentário: Indica o código do setor cobrança.
        /// </summary>
        private decimal codsetorcobranca;
        [XmlElement(ElementName = "CODSETORCOBRANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorcobranca
        {
            get { return  codsetorcobranca; }
            set {  codsetorcobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORCOMPRADOR
        /// Comentário: 
        /// </summary>
        private decimal codsetorcomprador;
        [XmlElement(ElementName = "CODSETORCOMPRADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorcomprador
        {
            get { return  codsetorcomprador; }
            set {  codsetorcomprador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORDIRETORIA
        /// Comentário: 
        /// </summary>
        private decimal codsetordiretoria;
        [XmlElement(ElementName = "CODSETORDIRETORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsetordiretoria
        {
            get { return  codsetordiretoria; }
            set {  codsetordiretoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORDIRETORIO
        /// Comentário: 
        /// </summary>
        private decimal codsetordiretorio;
        [XmlElement(ElementName = "CODSETORDIRETORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetordiretorio
        {
            get { return  codsetordiretorio; }
            set {  codsetordiretorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETOREMBALADOR
        /// Comentário: 
        /// </summary>
        private decimal codsetorembalador;
        [XmlElement(ElementName = "CODSETOREMBALADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorembalador
        {
            get { return  codsetorembalador; }
            set {  codsetorembalador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETOREXPED
        /// Comentário: 
        /// </summary>
        private decimal codsetorexped;
        [XmlElement(ElementName = "CODSETOREXPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorexped
        {
            get { return  codsetorexped; }
            set {  codsetorexped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORFISCALCX
        /// Comentário: 
        /// </summary>
        private decimal codsetorfiscalcx;
        [XmlElement(ElementName = "CODSETORFISCALCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorfiscalcx
        {
            get { return  codsetorfiscalcx; }
            set {  codsetorfiscalcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORMOTORISTA
        /// Comentário: 
        /// </summary>
        private decimal codsetormotorista;
        [XmlElement(ElementName = "CODSETORMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetormotorista
        {
            get { return  codsetormotorista; }
            set {  codsetormotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETOROPERCX
        /// Comentário: 
        /// </summary>
        private decimal codsetoropercx;
        [XmlElement(ElementName = "CODSETOROPERCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetoropercx
        {
            get { return  codsetoropercx; }
            set {  codsetoropercx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSURAUTOMATIC
        /// Comentário: 
        /// </summary>
        private string codusurautomatic;
        [XmlElement(ElementName = "CODUSURAUTOMATIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codusurautomatic
        {
            get { return  codusurautomatic; }
            set {  codusurautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAFLUXOCXCR1
        /// Comentário: 
        /// </summary>
        private string colunafluxocxcr1;
        [XmlElement(ElementName = "COLUNAFLUXOCXCR1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Colunafluxocxcr1
        {
            get { return  colunafluxocxcr1; }
            set {  colunafluxocxcr1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAFLUXOCXCR2
        /// Comentário: 
        /// </summary>
        private string colunafluxocxcr2;
        [XmlElement(ElementName = "COLUNAFLUXOCXCR2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Colunafluxocxcr2
        {
            get { return  colunafluxocxcr2; }
            set {  colunafluxocxcr2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAFLUXOCXCR3
        /// Comentário: 
        /// </summary>
        private string colunafluxocxcr3;
        [XmlElement(ElementName = "COLUNAFLUXOCXCR3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Colunafluxocxcr3
        {
            get { return  colunafluxocxcr3; }
            set {  colunafluxocxcr3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAFLUXOCXCR4
        /// Comentário: 
        /// </summary>
        private string colunafluxocxcr4;
        [XmlElement(ElementName = "COLUNAFLUXOCXCR4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Colunafluxocxcr4
        {
            get { return  colunafluxocxcr4; }
            set {  colunafluxocxcr4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAFLUXOCXCR5
        /// Comentário: 
        /// </summary>
        private string colunafluxocxcr5;
        [XmlElement(ElementName = "COLUNAFLUXOCXCR5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Colunafluxocxcr5
        {
            get { return  colunafluxocxcr5; }
            set {  colunafluxocxcr5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAORCATIPOVENDA
        /// Comentário: 
        /// </summary>
        private string comissaorcatipovenda;
        [XmlElement(ElementName = "COMISSAORCATIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comissaorcatipovenda
        {
            get { return  comissaorcatipovenda; }
            set {  comissaorcatipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA1
        /// Comentário: 
        /// </summary>
        private string condvenda1;
        [XmlElement(ElementName = "CONDVENDA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda1
        {
            get { return  condvenda1; }
            set {  condvenda1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA10
        /// Comentário: 
        /// </summary>
        private string condvenda10;
        [XmlElement(ElementName = "CONDVENDA10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda10
        {
            get { return  condvenda10; }
            set {  condvenda10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA11
        /// Comentário: 
        /// </summary>
        private string condvenda11;
        [XmlElement(ElementName = "CONDVENDA11", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda11
        {
            get { return  condvenda11; }
            set {  condvenda11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA12
        /// Comentário: 
        /// </summary>
        private string condvenda12;
        [XmlElement(ElementName = "CONDVENDA12", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda12
        {
            get { return  condvenda12; }
            set {  condvenda12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA13
        /// Comentário: 
        /// </summary>
        private string condvenda13;
        [XmlElement(ElementName = "CONDVENDA13", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda13
        {
            get { return  condvenda13; }
            set {  condvenda13 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA14
        /// Comentário: 
        /// </summary>
        private string condvenda14;
        [XmlElement(ElementName = "CONDVENDA14", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda14
        {
            get { return  condvenda14; }
            set {  condvenda14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA2
        /// Comentário: 
        /// </summary>
        private string condvenda2;
        [XmlElement(ElementName = "CONDVENDA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda2
        {
            get { return  condvenda2; }
            set {  condvenda2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA20
        /// Comentário: 
        /// </summary>
        private string condvenda20;
        [XmlElement(ElementName = "CONDVENDA20", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda20
        {
            get { return  condvenda20; }
            set {  condvenda20 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA3
        /// Comentário: 
        /// </summary>
        private string condvenda3;
        [XmlElement(ElementName = "CONDVENDA3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda3
        {
            get { return  condvenda3; }
            set {  condvenda3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA4
        /// Comentário: 
        /// </summary>
        private string condvenda4;
        [XmlElement(ElementName = "CONDVENDA4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda4
        {
            get { return  condvenda4; }
            set {  condvenda4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA5
        /// Comentário: 
        /// </summary>
        private string condvenda5;
        [XmlElement(ElementName = "CONDVENDA5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda5
        {
            get { return  condvenda5; }
            set {  condvenda5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA6
        /// Comentário: 
        /// </summary>
        private string condvenda6;
        [XmlElement(ElementName = "CONDVENDA6", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda6
        {
            get { return  condvenda6; }
            set {  condvenda6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA7
        /// Comentário: 
        /// </summary>
        private string condvenda7;
        [XmlElement(ElementName = "CONDVENDA7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda7
        {
            get { return  condvenda7; }
            set {  condvenda7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA8
        /// Comentário: 
        /// </summary>
        private string condvenda8;
        [XmlElement(ElementName = "CONDVENDA8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda8
        {
            get { return  condvenda8; }
            set {  condvenda8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA9
        /// Comentário: 
        /// </summary>
        private string condvenda9;
        [XmlElement(ElementName = "CONDVENDA9", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda9
        {
            get { return  condvenda9; }
            set {  condvenda9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFERINDOCARGAPEDIDO
        /// Comentário: Indicador de conferencia.
        /// </summary>
        private string conferindocargapedido;
        [XmlElement(ElementName = "CONFERINDOCARGAPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferindocargapedido
        {
            get { return  conferindocargapedido; }
            set {  conferindocargapedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSEDERACESSOPROPRIO530
        /// Comentário: Conceder acesso proprio na 530.
        /// </summary>
        private string consederacessoproprio530;
        [XmlElement(ElementName = "CONSEDERACESSOPROPRIO530", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consederacessoproprio530
        {
            get { return  consederacessoproprio530; }
            set {  consederacessoproprio530 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERACMVDEVOLUCAO
        /// Comentário: 
        /// </summary>
        private string consideracmvdevolucao;
        [XmlElement(ElementName = "CONSIDERACMVDEVOLUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideracmvdevolucao
        {
            get { return  consideracmvdevolucao; }
            set {  consideracmvdevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAISENTOSCOMOPF
        /// Comentário: 
        /// </summary>
        private string consideraisentoscomopf;
        [XmlElement(ElementName = "CONSIDERAISENTOSCOMOPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideraisentoscomopf
        {
            get { return  consideraisentoscomopf; }
            set {  consideraisentoscomopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERARICMSANTECIPCUSTO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CONSISTECNPJFORNEC
        /// Comentário: Indica se usa Crédito de Cliente na Venda Telemarketing. 
        /// </summary>
        private string consistecnpjfornec;
        [XmlElement(ElementName = "CONSISTECNPJFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consistecnpjfornec
        {
            get { return  consistecnpjfornec; }
            set {  consistecnpjfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSOLIDANDO
        /// Comentário: 
        /// </summary>
        private string consolidando;
        [XmlElement(ElementName = "CONSOLIDANDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consolidando
        {
            get { return  consolidando; }
            set {  consolidando = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSQTRESERVREBAIXACUSTO
        /// Comentário: Indica se considera Qtde. Reservada Rebaixa Custo (rotina 1806). 
        /// </summary>
        private string consqtreservrebaixacusto;
        [XmlElement(ElementName = "CONSQTRESERVREBAIXACUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consqtreservrebaixacusto
        {
            get { return  consqtreservrebaixacusto; }
            set {  consqtreservrebaixacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTALANCPERDA
        /// Comentário: 
        /// </summary>
        private decimal contalancperda;
        [XmlElement(ElementName = "CONTALANCPERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Contalancperda
        {
            get { return  contalancperda; }
            set {  contalancperda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLAEDICAOPEDIDOCOMPRA
        /// Comentário: 
        /// </summary>
        private string controlaedicaopedidocompra;
        [XmlElement(ElementName = "CONTROLAEDICAOPEDIDOCOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlaedicaopedidocompra
        {
            get { return  controlaedicaopedidocompra; }
            set {  controlaedicaopedidocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLAPRODUTIVSEP
        /// Comentário: 
        /// </summary>
        private string controlaprodutivsep;
        [XmlElement(ElementName = "CONTROLAPRODUTIVSEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlaprodutivsep
        {
            get { return  controlaprodutivsep; }
            set {  controlaprodutivsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CREDENCIALPARTICIPASORTEIOBIRO
        /// Comentário: 
        /// </summary>
        private string credencialparticipasorteiobiro;
        [XmlElement(ElementName = "CREDENCIALPARTICIPASORTEIOBIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Credencialparticipasorteiobiro
        {
            get { return  credencialparticipasorteiobiro; }
            set {  credencialparticipasorteiobiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRMALTDEBCREDRCA
        /// Comentário: Indica se pedidos do CRM irão contabilizar no débito/crédito de RCAs.
        /// </summary>
        private string crmaltdebcredrca;
        [XmlElement(ElementName = "CRMALTDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Crmaltdebcredrca
        {
            get { return  crmaltdebcredrca; }
            set {  crmaltdebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOINDUSTRIA
        /// Comentário: 
        /// </summary>
        private string custoindustria;
        [XmlElement(ElementName = "CUSTOINDUSTRIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Custoindustria
        {
            get { return  custoindustria; }
            set {  custoindustria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRAVARIAESTCOMDEVCLI
        /// Comentário: 
        /// </summary>
        private string deduziravariaestcomdevcli;
        [XmlElement(ElementName = "DEDUZIRAVARIAESTCOMDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduziravariaestcomdevcli
        {
            get { return  deduziravariaestcomdevcli; }
            set {  deduziravariaestcomdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEFINIRLOTEOP
        /// Comentário: 
        /// </summary>
        private string definirloteop;
        [XmlElement(ElementName = "DEFINIRLOTEOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Definirloteop
        {
            get { return  definirloteop; }
            set {  definirloteop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPOSITOVIRTUAL
        /// Comentário: 
        /// </summary>
        private decimal depositovirtual;
        [XmlElement(ElementName = "DEPOSITOVIRTUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Depositovirtual
        {
            get { return  depositovirtual; }
            set {  depositovirtual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESBLOQCLIBXTITULO
        /// Comentário: 
        /// </summary>
        private string desbloqclibxtitulo;
        [XmlElement(ElementName = "DESBLOQCLIBXTITULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Desbloqclibxtitulo
        {
            get { return  desbloqclibxtitulo; }
            set {  desbloqclibxtitulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESBLOQUEARPRODFIMOS
        /// Comentário: 
        /// </summary>
        private string desbloquearprodfimos;
        [XmlElement(ElementName = "DESBLOQUEARPRODFIMOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Desbloquearprodfimos
        {
            get { return  desbloquearprodfimos; }
            set {  desbloquearprodfimos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCVENDA
        /// Comentário: 
        /// </summary>
        private string descvenda;
        [XmlElement(ElementName = "DESCVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Descvenda
        {
            get { return  descvenda; }
            set {  descvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESDCARTAOFECHCARGA
        /// Comentário: 
        /// </summary>
        private string desdcartaofechcarga;
        [XmlElement(ElementName = "DESDCARTAOFECHCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Desdcartaofechcarga
        {
            get { return  desdcartaofechcarga; }
            set {  desdcartaofechcarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESDOBRARCADIFERENTE
        /// Comentário: 
        /// </summary>
        private string desdobrarcadiferente;
        [XmlElement(ElementName = "DESDOBRARCADIFERENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Desdobrarcadiferente
        {
            get { return  desdobrarcadiferente; }
            set {  desdobrarcadiferente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASANALISEDEVOL
        /// Comentário: Dias para analisar as vendas e devoluções
        /// </summary>
        private decimal diasanalisedevol;
        [XmlElement(ElementName = "DIASANALISEDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Diasanalisedevol
        {
            get { return  diasanalisedevol; }
            set {  diasanalisedevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASBLOQFORNECVERBASVENCIDAS
        /// Comentário: Indica a quantidade de dias para bloquear fornecedor na opção [Bloqueia Fornecedores com Verbas Vencidas] na rotina [504 - Atualização Diária I].
        /// </summary>
        private decimal diasbloqfornecverbasvencidas;
        [XmlElement(ElementName = "DIASBLOQFORNECVERBASVENCIDAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Diasbloqfornecverbasvencidas
        {
            get { return  diasbloqfornecverbasvencidas; }
            set {  diasbloqfornecverbasvencidas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRARQUIVOINTEGRACAO
        /// Comentário: 
        /// </summary>
        private string dirarquivointegracao;
        [XmlElement(ElementName = "DIRARQUIVOINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Dirarquivointegracao
        {
            get { return  dirarquivointegracao; }
            set {  dirarquivointegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIREXPORTACAOFV
        /// Comentário: 
        /// </summary>
        private string direxportacaofv;
        [XmlElement(ElementName = "DIREXPORTACAOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Direxportacaofv
        {
            get { return  direxportacaofv; }
            set {  direxportacaofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRIMPORTACAOFV
        /// Comentário: 
        /// </summary>
        private string dirimportacaofv;
        [XmlElement(ElementName = "DIRIMPORTACAOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Dirimportacaofv
        {
            get { return  dirimportacaofv; }
            set {  dirimportacaofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRIMPORTACAOFV2
        /// Comentário: Indicação do segundo diretório de importação do Força de Vendas. 
        /// </summary>
        private string dirimportacaofv2;
        [XmlElement(ElementName = "DIRIMPORTACAOFV2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Dirimportacaofv2
        {
            get { return  dirimportacaofv2; }
            set {  dirimportacaofv2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIROP
        /// Comentário: 
        /// </summary>
        private string dirop;
        [XmlElement(ElementName = "DIROP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Dirop
        {
            get { return  dirop; }
            set {  dirop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRWINTHOR
        /// Comentário: 
        /// </summary>
        private string dirwinthor;
        [XmlElement(ElementName = "DIRWINTHOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Dirwinthor
        {
            get { return  dirwinthor; }
            set {  dirwinthor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRWINTHORREMOTO
        /// Comentário: 
        /// </summary>
        private string dirwinthorremoto;
        [XmlElement(ElementName = "DIRWINTHORREMOTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Dirwinthorremoto
        {
            get { return  dirwinthorremoto; }
            set {  dirwinthorremoto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIVIDEPRZADICIONALPARCELAS
        /// Comentário: 
        /// </summary>
        private string divideprzadicionalparcelas;
        [XmlElement(ElementName = "DIVIDEPRZADICIONALPARCELAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Divideprzadicionalparcelas
        {
            get { return  divideprzadicionalparcelas; }
            set {  divideprzadicionalparcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTATUALIZACAOBD
        /// Comentário: Data de Atualização do Banco de Dados|Utilizado no Auto-Serviço
        /// </summary>
        private DateTime? dtatualizacaobd;
        [XmlElement(ElementName = "DTATUALIZACAOBD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtatualizacaobd
        {
            get { return  dtatualizacaobd; }
            set {  dtatualizacaobd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPIRACAOWINTHOR
        /// Comentário: 
        /// </summary>
        private DateTime? dtexpiracaowinthor;
        [XmlElement(ElementName = "DTEXPIRACAOWINTHOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexpiracaowinthor
        {
            get { return  dtexpiracaowinthor; }
            set {  dtexpiracaowinthor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIONFP
        /// Comentário: Indica a data de inicio de NFP.
        /// </summary>
        private DateTime? dtinicionfp;
        [XmlElement(ElementName = "DTINICIONFP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicionfp
        {
            get { return  dtinicionfp; }
            set {  dtinicionfp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROCESSAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtprocessamento;
        [XmlElement(ElementName = "DTPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprocessamento
        {
            get { return  dtprocessamento; }
            set {  dtprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXATU
        /// Comentário: 
        /// </summary>
        private DateTime? dtproxatu;
        [XmlElement(ElementName = "DTPROXATU", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxatu
        {
            get { return  dtproxatu; }
            set {  dtproxatu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXFECHAMES
        /// Comentário: 
        /// </summary>
        private DateTime? dtproxfechames;
        [XmlElement(ElementName = "DTPROXFECHAMES", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxfechames
        {
            get { return  dtproxfechames; }
            set {  dtproxfechames = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTIMAGERACAOSERASA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultimageracaoserasa;
        [XmlElement(ElementName = "DTULTIMAGERACAOSERASA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultimageracaoserasa
        {
            get { return  dtultimageracaoserasa; }
            set {  dtultimageracaoserasa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDASEFAZ
        /// Comentário: Será atribuído a data da ultima validação dos clientes ativos na sefaz atraves da rotina 1075. 
        /// </summary>
        private DateTime? dtvalidasefaz;
        [XmlElement(ElementName = "DTVALIDASEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidasefaz
        {
            get { return  dtvalidasefaz; }
            set {  dtvalidasefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCANTDESD
        /// Comentário: 
        /// </summary>
        private string dtvencantdesd;
        [XmlElement(ElementName = "DTVENCANTDESD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dtvencantdesd
        {
            get { return  dtvencantdesd; }
            set {  dtvencantdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCTK
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenctk;
        [XmlElement(ElementName = "DTVENCTK", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenctk
        {
            get { return  dtvenctk; }
            set {  dtvenctk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCTT
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenctt;
        [XmlElement(ElementName = "DTVENCTT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenctt
        {
            get { return  dtvenctt; }
            set {  dtvenctt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVIRADAWMS
        /// Comentário: 
        /// </summary>
        private DateTime? dtviradawms;
        [XmlElement(ElementName = "DTVIRADAWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtviradawms
        {
            get { return  dtviradawms; }
            set {  dtviradawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVOBRIGATORIO
        /// Comentário: 
        /// </summary>
        private string dvobrigatorio;
        [XmlElement(ElementName = "DVOBRIGATORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dvobrigatorio
        {
            get { return  dvobrigatorio; }
            set {  dvobrigatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITEPEDIDOVENDA
        /// Comentário: 
        /// </summary>
        private string emitepedidovenda;
        [XmlElement(ElementName = "EMITEPEDIDOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Emitepedidovenda
        {
            get { return  emitepedidovenda; }
            set {  emitepedidovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITINDOMAPA
        /// Comentário: 
        /// </summary>
        private string emitindomapa;
        [XmlElement(ElementName = "EMITINDOMAPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitindomapa
        {
            get { return  emitindomapa; }
            set {  emitindomapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPRESA
        /// Comentário: 
        /// </summary>
        private string empresa;
        [XmlElement(ElementName = "EMPRESA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Empresa
        {
            get { return  empresa; }
            set {  empresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECACOMBONUSABERTO
        /// Comentário: 
        /// </summary>
        private string enderecacombonusaberto;
        [XmlElement(ElementName = "ENDERECACOMBONUSABERTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enderecacombonusaberto
        {
            get { return  enderecacombonusaberto; }
            set {  enderecacombonusaberto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: 
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECOAPANHAFILIAL
        /// Comentário: 
        /// </summary>
        private string enderecoapanhafilial;
        [XmlElement(ElementName = "ENDERECOAPANHAFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enderecoapanhafilial
        {
            get { return  enderecoapanhafilial; }
            set {  enderecoapanhafilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENTREGA_FUTURA
        /// Comentário: 
        /// </summary>
        private string entrega_futura;
        [XmlElement(ElementName = "ENTREGA_FUTURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Entrega_Futura
        {
            get { return  entrega_futura; }
            set {  entrega_futura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIAMENSRCALIBEST
        /// Comentário: 
        /// </summary>
        private string enviamensrcalibest;
        [XmlElement(ElementName = "ENVIAMENSRCALIBEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviamensrcalibest
        {
            get { return  enviamensrcalibest; }
            set {  enviamensrcalibest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIARMSGRCACORTE
        /// Comentário: Enviar mensagem de notificação de corte para RCA. 
        /// </summary>
        private string enviarmsgrcacorte;
        [XmlElement(ElementName = "ENVIARMSGRCACORTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviarmsgrcacorte
        {
            get { return  enviarmsgrcacorte; }
            set {  enviarmsgrcacorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Comentário: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estado
        {
            get { return  estado; }
            set {  estado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRPVENDA
        /// Comentário: 
        /// </summary>
        private string exibirpvenda;
        [XmlElement(ElementName = "EXIBIRPVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibirpvenda
        {
            get { return  exibirpvenda; }
            set {  exibirpvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIGEDTVALIDADEBONUSRM
        /// Comentário: 
        /// </summary>
        private string exigedtvalidadebonusrm;
        [XmlElement(ElementName = "EXIGEDTVALIDADEBONUSRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exigedtvalidadebonusrm
        {
            get { return  exigedtvalidadebonusrm; }
            set {  exigedtvalidadebonusrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPEDEPALETEFECHADODIRETOBOX
        /// Comentário: 
        /// </summary>
        private string expedepaletefechadodiretobox;
        [XmlElement(ElementName = "EXPEDEPALETEFECHADODIRETOBOX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Expedepaletefechadodiretobox
        {
            get { return  expedepaletefechadodiretobox; }
            set {  expedepaletefechadodiretobox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTANDODADOS
        /// Comentário: 
        /// </summary>
        private string exportandodados;
        [XmlElement(ElementName = "EXPORTANDODADOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportandodados
        {
            get { return  exportandodados; }
            set {  exportandodados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAFIMTEOR
        /// Comentário: 
        /// </summary>
        private decimal faixafimteor;
        [XmlElement(ElementName = "FAIXAFIMTEOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Faixafimteor
        {
            get { return  faixafimteor; }
            set {  faixafimteor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAINITEOR
        /// Comentário: 
        /// </summary>
        private decimal faixainiteor;
        [XmlElement(ElementName = "FAIXAINITEOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Faixainiteor
        {
            get { return  faixainiteor; }
            set {  faixainiteor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATURAFILIALBROKER
        /// Comentário: Indica se existirá faturamento e geração de títulos na filial de Broker.
        /// </summary>
        private string faturafilialbroker;
        [XmlElement(ElementName = "FATURAFILIALBROKER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Faturafilialbroker
        {
            get { return  faturafilialbroker; }
            set {  faturafilialbroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAX
        /// Comentário: 
        /// </summary>
        private string fax;
        [XmlElement(ElementName = "FAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Fax
        {
            get { return  fax; }
            set {  fax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAZERINSERTPCEMBALAGEM
        /// Comentário: . 
        /// </summary>
        private string fazerinsertpcembalagem;
        [XmlElement(ElementName = "FAZERINSERTPCEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fazerinsertpcembalagem
        {
            get { return  fazerinsertpcembalagem; }
            set {  fazerinsertpcembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FECHABONUSEMRECIBODESC
        /// Comentário: 
        /// </summary>
        private string fechabonusemrecibodesc;
        [XmlElement(ElementName = "FECHABONUSEMRECIBODESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fechabonusemrecibodesc
        {
            get { return  fechabonusemrecibodesc; }
            set {  fechabonusemrecibodesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FECHACARREGAUTVENDABALCAO
        /// Comentário: . 
        /// </summary>
        private string fechacarregautvendabalcao;
        [XmlElement(ElementName = "FECHACARREGAUTVENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fechacarregautvendabalcao
        {
            get { return  fechacarregautvendabalcao; }
            set {  fechacarregautvendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILIALPADRAO
        /// Comentário: Indica qual filial padrão do sistema a ser utilizada em determinados processos dentre as existentes cadastradas.
        /// </summary>
        private string filialpadrao;
        [XmlElement(ElementName = "FILIALPADRAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Filialpadrao
        {
            get { return  filialpadrao; }
            set {  filialpadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMMAPA
        /// Comentário: 
        /// </summary>
        private decimal formmapa;
        [XmlElement(ElementName = "FORMMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Formmapa
        {
            get { return  formmapa; }
            set {  formmapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FRETENAOTRIBCOMOOUTRAS
        /// Comentário: Gera frete não trib. como Outras. 
        /// </summary>
        private string fretenaotribcomooutras;
        [XmlElement(ElementName = "FRETENAOTRIBCOMOOUTRAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fretenaotribcomooutras
        {
            get { return  fretenaotribcomooutras; }
            set {  fretenaotribcomooutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FTP_CONEXAOPASSIVA
        /// Comentário: 
        /// </summary>
        private string ftp_conexaopassiva;
        [XmlElement(ElementName = "FTP_CONEXAOPASSIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ftp_Conexaopassiva
        {
            get { return  ftp_conexaopassiva; }
            set {  ftp_conexaopassiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FTP_IP
        /// Comentário: 
        /// </summary>
        private string ftp_ip;
        [XmlElement(ElementName = "FTP_IP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Ftp_Ip
        {
            get { return  ftp_ip; }
            set {  ftp_ip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FTP_PORTA
        /// Comentário: 
        /// </summary>
        private decimal ftp_porta;
        [XmlElement(ElementName = "FTP_PORTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ftp_Porta
        {
            get { return  ftp_porta; }
            set {  ftp_porta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACONTASPAGARDEVCLI
        /// Comentário: 
        /// </summary>
        private string geracontaspagardevcli;
        [XmlElement(ElementName = "GERACONTASPAGARDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracontaspagardevcli
        {
            get { return  geracontaspagardevcli; }
            set {  geracontaspagardevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERANDOMAPA
        /// Comentário: 
        /// </summary>
        private string gerandomapa;
        [XmlElement(ElementName = "GERANDOMAPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerandomapa
        {
            get { return  gerandomapa; }
            set {  gerandomapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERANFTIPO8
        /// Comentário: 
        /// </summary>
        private string geranftipo8;
        [XmlElement(ElementName = "GERANFTIPO8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geranftipo8
        {
            get { return  geranftipo8; }
            set {  geranftipo8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERANUMLOTEAUTOMATICO
        /// Comentário: . 
        /// </summary>
        private string geranumloteautomatico;
        [XmlElement(ElementName = "GERANUMLOTEAUTOMATICO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geranumloteautomatico
        {
            get { return  geranumloteautomatico; }
            set {  geranumloteautomatico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAPARCELAMENTOTEF
        /// Comentário: 
        /// </summary>
        private string geraparcelamentotef;
        [XmlElement(ElementName = "GERAPARCELAMENTOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraparcelamentotef
        {
            get { return  geraparcelamentotef; }
            set {  geraparcelamentotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARBRINDEPEDBONIFIC
        /// Comentário: . 
        /// </summary>
        private string gerarbrindepedbonific;
        [XmlElement(ElementName = "GERARBRINDEPEDBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarbrindepedbonific
        {
            get { return  gerarbrindepedbonific; }
            set {  gerarbrindepedbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARCRECLIDEVCLI
        /// Comentário: 
        /// </summary>
        private string gerarcreclidevcli;
        [XmlElement(ElementName = "GERARCRECLIDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarcreclidevcli
        {
            get { return  gerarcreclidevcli; }
            set {  gerarcreclidevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARDADOSREDUCAOZ
        /// Comentário: 
        /// </summary>
        private string gerardadosreducaoz;
        [XmlElement(ElementName = "GERARDADOSREDUCAOZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerardadosreducaoz
        {
            get { return  gerardadosreducaoz; }
            set {  gerardadosreducaoz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARNUMLOTEAUTOMATICPA
        /// Comentário: 
        /// </summary>
        private string gerarnumloteautomaticpa;
        [XmlElement(ElementName = "GERARNUMLOTEAUTOMATICPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarnumloteautomaticpa
        {
            get { return  gerarnumloteautomaticpa; }
            set {  gerarnumloteautomaticpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARPCAUXLANCONTASORCAM
        /// Comentário: Indica se deve ser gerado PCAUXLAN apenas com valores de Orçamento na rotina [506 - Fechamento Mensal], opção [Atualizacao Balancete 12 Meses].
        /// </summary>
        private string gerarpcauxlancontasorcam;
        [XmlElement(ElementName = "GERARPCAUXLANCONTASORCAM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarpcauxlancontasorcam
        {
            get { return  gerarpcauxlancontasorcam; }
            set {  gerarpcauxlancontasorcam = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARPCFRETE
        /// Comentário: Indica se irá gerar Contas a Pagar do Frete para a Transportadora. 
        /// </summary>
        private string gerarpcfrete;
        [XmlElement(ElementName = "GERARPCFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarpcfrete
        {
            get { return  gerarpcfrete; }
            set {  gerarpcfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARPCLANCICMSANTECIP
        /// Comentário: Indica se haverá a geração do Contas a Pagar (PCLANC) referente ao ICMS Antecipado na rotina 1301.
        /// </summary>
        private string gerarpclancicmsantecip;
        [XmlElement(ElementName = "GERARPCLANCICMSANTECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarpclancicmsantecip
        {
            get { return  gerarpclancicmsantecip; }
            set {  gerarpclancicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARTROCOCOBDIN
        /// Comentário: 
        /// </summary>
        private string gerartrococobdin;
        [XmlElement(ElementName = "GERARTROCOCOBDIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerartrococobdin
        {
            get { return  gerartrococobdin; }
            set {  gerartrococobdin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAVALERCADEVMANIF
        /// Comentário: Indica se vai ser gerado automaticamente vale da diferença para o RCA (rotina 1332), se a devolução de uma venda manifesto for parcial. 
        /// </summary>
        private string geravalercadevmanif;
        [XmlElement(ElementName = "GERAVALERCADEVMANIF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geravalercadevmanif
        {
            get { return  geravalercadevmanif; }
            set {  geravalercadevmanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRAVAPCMENSALTCADCLI
        /// Comentário: 
        /// </summary>
        private string gravapcmensaltcadcli;
        [XmlElement(ElementName = "GRAVAPCMENSALTCADCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gravapcmensaltcadcli
        {
            get { return  gravapcmensaltcadcli; }
            set {  gravapcmensaltcadcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRAVARCOTACAO
        /// Comentário: Indica se será ou não informada qual moeda estrangeira utilizada e sua respectiva cotação. 
        /// </summary>
        private string gravarcotacao;
        [XmlElement(ElementName = "GRAVARCOTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gravarcotacao
        {
            get { return  gravarcotacao; }
            set {  gravarcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRAVAROBSCLIENTENOPEDIDO
        /// Comentário: 
        /// </summary>
        private string gravarobsclientenopedido;
        [XmlElement(ElementName = "GRAVAROBSCLIENTENOPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gravarobsclientenopedido
        {
            get { return  gravarobsclientenopedido; }
            set {  gravarobsclientenopedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HABILITARLANCTODADOSFROTA
        /// Comentário: Indica se irá informar dados de frota no Winthor ( a princípio nas rotinas 749, 631 e 1206). Parâmetro interno, que não consta na 132. 
        /// </summary>
        private string habilitarlanctodadosfrota;
        [XmlElement(ElementName = "HABILITARLANCTODADOSFROTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Habilitarlanctodadosfrota
        {
            get { return  habilitarlanctodadosfrota; }
            set {  habilitarlanctodadosfrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HASHSISTEMA
        /// Comentário: 
        /// </summary>
        private string hashsistema;
        [XmlElement(ElementName = "HASHSISTEMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Hashsistema
        {
            get { return  hashsistema; }
            set {  hashsistema = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTFOR
        /// Comentário: 
        /// </summary>
        private string histfor;
        [XmlElement(ElementName = "HISTFOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Histfor
        {
            get { return  histfor; }
            set {  histfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTFRE
        /// Comentário: 
        /// </summary>
        private string histfre;
        [XmlElement(ElementName = "HISTFRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Histfre
        {
            get { return  histfre; }
            set {  histfre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTOUT
        /// Comentário: 
        /// </summary>
        private string histout;
        [XmlElement(ElementName = "HISTOUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Histout
        {
            get { return  histout; }
            set {  histout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IE
        /// Comentário: 
        /// </summary>
        private string ie;
        [XmlElement(ElementName = "IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ie
        {
            get { return  ie; }
            set {  ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IECLIEXCLUSIVA
        /// Comentário: 
        /// </summary>
        private string iecliexclusiva;
        [XmlElement(ElementName = "IECLIEXCLUSIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Iecliexclusiva
        {
            get { return  iecliexclusiva; }
            set {  iecliexclusiva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPCARTACOBJUROS
        /// Comentário: 
        /// </summary>
        private string impcartacobjuros;
        [XmlElement(ElementName = "IMPCARTACOBJUROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impcartacobjuros
        {
            get { return  impcartacobjuros; }
            set {  impcartacobjuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTANDOPEDIDOS
        /// Comentário: 
        /// </summary>
        private string importandopedidos;
        [XmlElement(ElementName = "IMPORTANDOPEDIDOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importandopedidos
        {
            get { return  importandopedidos; }
            set {  importandopedidos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPQTBONUS
        /// Comentário: 
        /// </summary>
        private string impqtbonus;
        [XmlElement(ElementName = "IMPQTBONUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impqtbonus
        {
            get { return  impqtbonus; }
            set {  impqtbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRESSAOAUTOMATICA
        /// Comentário: 
        /// </summary>
        private string impressaoautomatica;
        [XmlElement(ElementName = "IMPRESSAOAUTOMATICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impressaoautomatica
        {
            get { return  impressaoautomatica; }
            set {  impressaoautomatica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRIMEDESCONTOCF
        /// Comentário: 
        /// </summary>
        private string imprimedescontocf;
        [XmlElement(ElementName = "IMPRIMEDESCONTOCF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprimedescontocf
        {
            get { return  imprimedescontocf; }
            set {  imprimedescontocf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRIMIRESPELHOENTMERC
        /// Comentário: 
        /// </summary>
        private string imprimirespelhoentmerc;
        [XmlElement(ElementName = "IMPRIMIRESPELHOENTMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprimirespelhoentmerc
        {
            get { return  imprimirespelhoentmerc; }
            set {  imprimirespelhoentmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCDUPJUROSDESD
        /// Comentário: 
        /// </summary>
        private string incdupjurosdesd;
        [XmlElement(ElementName = "INCDUPJUROSDESD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incdupjurosdesd
        {
            get { return  incdupjurosdesd; }
            set {  incdupjurosdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCLUIDESPRODAPENF
        /// Comentário: 
        /// </summary>
        private string incluidesprodapenf;
        [XmlElement(ElementName = "INCLUIDESPRODAPENF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incluidesprodapenf
        {
            get { return  incluidesprodapenf; }
            set {  incluidesprodapenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCLUIRCOMISSAOCMVVENDA
        /// Comentário: Campo para indicar se a comissão do RCA será incluída na sugestão do preço de venda e no custo da mercadoria vendida.
        /// </summary>
        private string incluircomissaocmvvenda;
        [XmlElement(ElementName = "INCLUIRCOMISSAOCMVVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incluircomissaocmvvenda
        {
            get { return  incluircomissaocmvvenda; }
            set {  incluircomissaocmvvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCLUIRCOMISSAOSUGPVENDACMV
        /// Comentário: Indica se a comissão do RCA será incluída na sugestão do preço de venda, e no custo da mercadoria vendida. 
        /// </summary>
        private string incluircomissaosugpvendacmv;
        [XmlElement(ElementName = "INCLUIRCOMISSAOSUGPVENDACMV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incluircomissaosugpvendacmv
        {
            get { return  incluircomissaosugpvendacmv; }
            set {  incluircomissaosugpvendacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDESPELHO
        /// Comentário: 
        /// </summary>
        private string indespelho;
        [XmlElement(ElementName = "INDESPELHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indespelho
        {
            get { return  indespelho; }
            set {  indespelho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICECUSTOTRANSF
        /// Comentário: 
        /// </summary>
        private decimal indicecustotransf;
        [XmlElement(ElementName = "INDICECUSTOTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Indicecustotransf
        {
            get { return  indicecustotransf; }
            set {  indicecustotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFNUMVERBAPEDBONIFIC
        /// Comentário: 
        /// </summary>
        private string infnumverbapedbonific;
        [XmlElement(ElementName = "INFNUMVERBAPEDBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Infnumverbapedbonific
        {
            get { return  infnumverbapedbonific; }
            set {  infnumverbapedbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFORMARECEBEDORVENDA
        /// Comentário: Indica para qual cliente será feita a entrega da mercadoria em pedidos de venda para redes de clientes. 
        /// </summary>
        private string informarecebedorvenda;
        [XmlElement(ElementName = "INFORMARECEBEDORVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Informarecebedorvenda
        {
            get { return  informarecebedorvenda; }
            set {  informarecebedorvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INICIAROPSEMEM
        /// Comentário: 
        /// </summary>
        private string iniciaropsemem;
        [XmlElement(ElementName = "INICIAROPSEMEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Iniciaropsemem
        {
            get { return  iniciaropsemem; }
            set {  iniciaropsemem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSERIRCUPOM
        /// Comentário: Inserir Cupom Fiscal.
        /// </summary>
        private string inserircupom;
        [XmlElement(ElementName = "INSERIRCUPOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inserircupom
        {
            get { return  inserircupom; }
            set {  inserircupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSERIRMAPA
        /// Comentário: Inserir Mapa Resumo.
        /// </summary>
        private string inserirmapa;
        [XmlElement(ElementName = "INSERIRMAPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inserirmapa
        {
            get { return  inserirmapa; }
            set {  inserirmapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSERIRREDUCAOZ
        /// Comentário: 
        /// </summary>
        private string inserirreducaoz;
        [XmlElement(ElementName = "INSERIRREDUCAOZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inserirreducaoz
        {
            get { return  inserirreducaoz; }
            set {  inserirreducaoz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IPNFE
        /// Comentário: Número do IP do Servidor de NF-e. 
        /// </summary>
        private string ipnfe;
        [XmlElement(ElementName = "IPNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ipnfe
        {
            get { return  ipnfe; }
            set {  ipnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IPTABPRECO
        /// Comentário: 
        /// </summary>
        private string iptabpreco;
        [XmlElement(ElementName = "IPTABPRECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Iptabpreco
        {
            get { return  iptabpreco; }
            set {  iptabpreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LANCARDESPVENDORAUTOMATICO
        /// Comentário: 
        /// </summary>
        private string lancardespvendorautomatico;
        [XmlElement(ElementName = "LANCARDESPVENDORAUTOMATICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lancardespvendorautomatico
        {
            get { return  lancardespvendorautomatico; }
            set {  lancardespvendorautomatico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LANCARFRETEXPARCELAS
        /// Comentário: Lançar frete em X parcelas. 
        /// </summary>
        private string lancarfretexparcelas;
        [XmlElement(ElementName = "LANCARFRETEXPARCELAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lancarfretexparcelas
        {
            get { return  lancarfretexparcelas; }
            set {  lancarfretexparcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LANCARSTAPENASPARC1
        /// Comentário: Indica que ao gerar o contas a receber, cobrar o valor da substituição tributária no primeiro vencimento, quando a venda é parcelada. 
        /// </summary>
        private string lancarstapenasparc1;
        [XmlElement(ElementName = "LANCARSTAPENASPARC1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lancarstapenasparc1
        {
            get { return  lancarstapenasparc1; }
            set {  lancarstapenasparc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LANCARVALECOMODESPESANA1268
        /// Comentário: Indica se deve lançar o valor dos vales como despesa no fechamento de comissão (rotina 1268). 
        /// </summary>
        private string lancarvalecomodespesana1268;
        [XmlElement(ElementName = "LANCARVALECOMODESPESANA1268", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lancarvalecomodespesana1268
        {
            get { return  lancarvalecomodespesana1268; }
            set {  lancarvalecomodespesana1268 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LEITURACH
        /// Comentário: 
        /// </summary>
        private string leiturach;
        [XmlElement(ElementName = "LEITURACH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Leiturach
        {
            get { return  leiturach; }
            set {  leiturach = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBERAESTENTMERC
        /// Comentário: 
        /// </summary>
        private string liberaestentmerc;
        [XmlElement(ElementName = "LIBERAESTENTMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Liberaestentmerc
        {
            get { return  liberaestentmerc; }
            set {  liberaestentmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBERAESTFECHBONUS
        /// Comentário: 
        /// </summary>
        private string liberaestfechbonus;
        [XmlElement(ElementName = "LIBERAESTFECHBONUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Liberaestfechbonus
        {
            get { return  liberaestfechbonus; }
            set {  liberaestfechbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBERARPEDIDOPENDENTE
        /// Comentário: 
        /// </summary>
        private string liberarpedidopendente;
        [XmlElement(ElementName = "LIBERARPEDIDOPENDENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Liberarpedidopendente
        {
            get { return  liberarpedidopendente; }
            set {  liberarpedidopendente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCREDINICIAL
        /// Comentário: 
        /// </summary>
        private decimal limcredinicial;
        [XmlElement(ElementName = "LIMCREDINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Limcredinicial
        {
            get { return  limcredinicial; }
            set {  limcredinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMCREDINICIALPF
        /// Comentário: 
        /// </summary>
        private decimal limcredinicialpf;
        [XmlElement(ElementName = "LIMCREDINICIALPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Limcredinicialpf
        {
            get { return  limcredinicialpf; }
            set {  limcredinicialpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMITEARREDONDAMENTO
        /// Comentário: 
        /// </summary>
        private decimal limitearredondamento;
        [XmlElement(ElementName = "LIMITEARREDONDAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Limitearredondamento
        {
            get { return  limitearredondamento; }
            set {  limitearredondamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMPARBASECALCENTRADA
        /// Comentário: 
        /// </summary>
        private string limparbasecalcentrada;
        [XmlElement(ElementName = "LIMPARBASECALCENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Limparbasecalcentrada
        {
            get { return  limparbasecalcentrada; }
            set {  limparbasecalcentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMPAROBSNFDEVOL
        /// Comentário: Limpar Observacao das Notas de Devolucao Cliente.
        /// </summary>
        private string limparobsnfdevol;
        [XmlElement(ElementName = "LIMPAROBSNFDEVOL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Limparobsnfdevol
        {
            get { return  limparobsnfdevol; }
            set {  limparobsnfdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MANTEMNOSSONUMBCO1210
        /// Comentário: 
        /// </summary>
        private string mantemnossonumbco1210;
        [XmlElement(ElementName = "MANTEMNOSSONUMBCO1210", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mantemnossonumbco1210
        {
            get { return  mantemnossonumbco1210; }
            set {  mantemnossonumbco1210 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MANTEMNOSSONUMBCO402
        /// Comentário: 
        /// </summary>
        private string mantemnossonumbco402;
        [XmlElement(ElementName = "MANTEMNOSSONUMBCO402", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mantemnossonumbco402
        {
            get { return  mantemnossonumbco402; }
            set {  mantemnossonumbco402 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMMIN
        /// Comentário: 
        /// </summary>
        private decimal margemmin;
        [XmlElement(ElementName = "MARGEMMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Margemmin
        {
            get { return  margemmin; }
            set {  margemmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMPREV
        /// Comentário: 
        /// </summary>
        private decimal margemprev;
        [XmlElement(ElementName = "MARGEMPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Margemprev
        {
            get { return  margemprev; }
            set {  margemprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAXDIASSEMVENDA
        /// Comentário: Indica quantidade máxima que o representante pode ficar sem fazer vendas para um cliente e ainda assim receber comissão pelas vendas do Call Center.
        /// </summary>
        private decimal maxdiassemvenda;
        [XmlElement(ElementName = "MAXDIASSEMVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Maxdiassemvenda
        {
            get { return  maxdiassemvenda; }
            set {  maxdiassemvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAXPRZMEDIODESDCP
        /// Comentário: 
        /// </summary>
        private decimal maxprzmediodesdcp;
        [XmlElement(ElementName = "MAXPRZMEDIODESDCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Maxprzmediodesdcp
        {
            get { return  maxprzmediodesdcp; }
            set {  maxprzmediodesdcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM1NF
        /// Comentário: 
        /// </summary>
        private string mensagem1nf;
        [XmlElement(ElementName = "MENSAGEM1NF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Mensagem1nf
        {
            get { return  mensagem1nf; }
            set {  mensagem1nf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM2NF
        /// Comentário: 
        /// </summary>
        private string mensagem2nf;
        [XmlElement(ElementName = "MENSAGEM2NF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Mensagem2nf
        {
            get { return  mensagem2nf; }
            set {  mensagem2nf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MERCADOALVO
        /// Comentário: 
        /// </summary>
        private string mercadoalvo;
        [XmlElement(ElementName = "MERCADOALVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Mercadoalvo
        {
            get { return  mercadoalvo; }
            set {  mercadoalvo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MONTANDO
        /// Comentário: 
        /// </summary>
        private string montando;
        [XmlElement(ElementName = "MONTANDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Montando
        {
            get { return  montando; }
            set {  montando = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOSTRARPVENDASEMST
        /// Comentário: 
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
        /// Propriedade referente ao campo: MUDACOBCLIENTE
        /// Comentário: 
        /// </summary>
        private string mudacobcliente;
        [XmlElement(ElementName = "MUDACOBCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mudacobcliente
        {
            get { return  mudacobcliente; }
            set {  mudacobcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUDACOBCLIENTEDIAS
        /// Comentário: 
        /// </summary>
        private decimal mudacobclientedias;
        [XmlElement(ElementName = "MUDACOBCLIENTEDIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Mudacobclientedias
        {
            get { return  mudacobclientedias; }
            set {  mudacobclientedias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAOGRAVARSALDOESTOQUEINVENTROT
        /// Comentário: Não gravar saldo do estoque em inventario rotativo.
        /// </summary>
        private string naogravarsaldoestoqueinventrot;
        [XmlElement(ElementName = "NAOGRAVARSALDOESTOQUEINVENTROT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naogravarsaldoestoqueinventrot
        {
            get { return  naogravarsaldoestoqueinventrot; }
            set {  naogravarsaldoestoqueinventrot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAOUSAENDERECOMISTO
        /// Comentário: 
        /// </summary>
        private string naousaenderecomisto;
        [XmlElement(ElementName = "NAOUSAENDERECOMISTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naousaenderecomisto
        {
            get { return  naousaenderecomisto; }
            set {  naousaenderecomisto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAOUSARPCCRECLICONSFINAL
        /// Comentário: Não utilizar crédito de cliente para Consumidor Final.
        /// </summary>
        private string naousarpccrecliconsfinal;
        [XmlElement(ElementName = "NAOUSARPCCRECLICONSFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naousarpccrecliconsfinal
        {
            get { return  naousarpccrecliconsfinal; }
            set {  naousarpccrecliconsfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAOUSARPICKINGCX
        /// Comentário: 
        /// </summary>
        private string naousarpickingcx;
        [XmlElement(ElementName = "NAOUSARPICKINGCX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naousarpickingcx
        {
            get { return  naousarpickingcx; }
            set {  naousarpickingcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NDIASEXPIRASENHA
        /// Comentário: 
        /// </summary>
        private decimal ndiasexpirasenha;
        [XmlElement(ElementName = "NDIASEXPIRASENHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ndiasexpirasenha
        {
            get { return  ndiasexpirasenha; }
            set {  ndiasexpirasenha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAUTOMATICCLI
        /// Comentário: 
        /// </summary>
        private string numautomaticcli;
        [XmlElement(ElementName = "NUMAUTOMATICCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Numautomaticcli
        {
            get { return  numautomaticcli; }
            set {  numautomaticcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAUTOMATICFOR
        /// Comentário: 
        /// </summary>
        private string numautomaticfor;
        [XmlElement(ElementName = "NUMAUTOMATICFOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Numautomaticfor
        {
            get { return  numautomaticfor; }
            set {  numautomaticfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAUTOMATICPROD
        /// Comentário: 
        /// </summary>
        private string numautomaticprod;
        [XmlElement(ElementName = "NUMAUTOMATICPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Numautomaticprod
        {
            get { return  numautomaticprod; }
            set {  numautomaticprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCASASDECCUSTO
        /// Comentário: 
        /// </summary>
        private decimal numcasasdeccusto;
        [XmlElement(ElementName = "NUMCASASDECCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numcasasdeccusto
        {
            get { return  numcasasdeccusto; }
            set {  numcasasdeccusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCASASDECESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal numcasasdecestoque;
        [XmlElement(ElementName = "NUMCASASDECESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numcasasdecestoque
        {
            get { return  numcasasdecestoque; }
            set {  numcasasdecestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCASASDECINVENTARIO
        /// Comentário: 
        /// </summary>
        private decimal numcasasdecinventario;
        [XmlElement(ElementName = "NUMCASASDECINVENTARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numcasasdecinventario
        {
            get { return  numcasasdecinventario; }
            set {  numcasasdecinventario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCASASDECPRODUCAO
        /// Comentário: Indica a quantidade de casas decimais utilizado para a produção, nas rotinas do módulo 16 - Indústria. 
        /// </summary>
        private decimal numcasasdecproducao;
        [XmlElement(ElementName = "NUMCASASDECPRODUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numcasasdecproducao
        {
            get { return  numcasasdecproducao; }
            set {  numcasasdecproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCASASDECVENDA
        /// Comentário: 
        /// </summary>
        private decimal numcasasdecvenda;
        [XmlElement(ElementName = "NUMCASASDECVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numcasasdecvenda
        {
            get { return  numcasasdecvenda; }
            set {  numcasasdecvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUSTODIAAUTOMATIC
        /// Comentário: 
        /// </summary>
        private string numcustodiaautomatic;
        [XmlElement(ElementName = "NUMCUSTODIAAUTOMATIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Numcustodiaautomatic
        {
            get { return  numcustodiaautomatic; }
            set {  numcustodiaautomatic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASALTDTENTREGA
        /// Comentário: 
        /// </summary>
        private decimal numdiasaltdtentrega;
        [XmlElement(ElementName = "NUMDIASALTDTENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasaltdtentrega
        {
            get { return  numdiasaltdtentrega; }
            set {  numdiasaltdtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASALTERALIVRO
        /// Comentário: 
        /// </summary>
        private decimal numdiasalteralivro;
        [XmlElement(ElementName = "NUMDIASALTERALIVRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdiasalteralivro
        {
            get { return  numdiasalteralivro; }
            set {  numdiasalteralivro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASATU
        /// Comentário: 
        /// </summary>
        private decimal numdiasatu;
        [XmlElement(ElementName = "NUMDIASATU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numdiasatu
        {
            get { return  numdiasatu; }
            set {  numdiasatu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASBLOQAUTOMATIC
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMDIASBLOQCHP
        /// Comentário: 
        /// </summary>
        private decimal numdiasbloqchp;
        [XmlElement(ElementName = "NUMDIASBLOQCHP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numdiasbloqchp
        {
            get { return  numdiasbloqchp; }
            set {  numdiasbloqchp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASCADCLIBLOQCHDV
        /// Comentário: 
        /// </summary>
        private decimal numdiascadclibloqchdv;
        [XmlElement(ElementName = "NUMDIASCADCLIBLOQCHDV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiascadclibloqchdv
        {
            get { return  numdiascadclibloqchdv; }
            set {  numdiascadclibloqchdv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASCHDVBLOQCLI
        /// Comentário: 
        /// </summary>
        private decimal numdiaschdvbloqcli;
        [XmlElement(ElementName = "NUMDIASCHDVBLOQCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiaschdvbloqcli
        {
            get { return  numdiaschdvbloqcli; }
            set {  numdiaschdvbloqcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASCLIINATIV
        /// Comentário: 
        /// </summary>
        private decimal numdiascliinativ;
        [XmlElement(ElementName = "NUMDIASCLIINATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiascliinativ
        {
            get { return  numdiascliinativ; }
            set {  numdiascliinativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASDESBLOQCHD1
        /// Comentário: Indica o numero de dias para desbloqueio automatico de cobrança.
        /// </summary>
        private decimal numdiasdesbloqchd1;
        [XmlElement(ElementName = "NUMDIASDESBLOQCHD1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasdesbloqchd1
        {
            get { return  numdiasdesbloqchd1; }
            set {  numdiasdesbloqchd1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXACERTARCARGA
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxacertarcarga;
        [XmlElement(ElementName = "NUMDIASMAXACERTARCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmaxacertarcarga
        {
            get { return  numdiasmaxacertarcarga; }
            set {  numdiasmaxacertarcarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXBAIXARECIBO
        /// Comentário: Indica o número máximo de dias para Baixa de Título com recibo retroativo.
        /// </summary>
        private decimal numdiasmaxbaixarecibo;
        [XmlElement(ElementName = "NUMDIASMAXBAIXARECIBO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdiasmaxbaixarecibo
        {
            get { return  numdiasmaxbaixarecibo; }
            set {  numdiasmaxbaixarecibo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXCANCBORDERO
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxcancbordero;
        [XmlElement(ElementName = "NUMDIASMAXCANCBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdiasmaxcancbordero
        {
            get { return  numdiasmaxcancbordero; }
            set {  numdiasmaxcancbordero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXCANCNFENT
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxcancnfent;
        [XmlElement(ElementName = "NUMDIASMAXCANCNFENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numdiasmaxcancnfent
        {
            get { return  numdiasmaxcancnfent; }
            set {  numdiasmaxcancnfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXCANCNFSAIDA
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxcancnfsaida;
        [XmlElement(ElementName = "NUMDIASMAXCANCNFSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numdiasmaxcancnfsaida
        {
            get { return  numdiasmaxcancnfsaida; }
            set {  numdiasmaxcancnfsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXDESDCPAGAR
        /// Comentário: Indica o número máximo de dias para desdobramento além do prazo médio.
        /// </summary>
        private decimal numdiasmaxdesdcpagar;
        [XmlElement(ElementName = "NUMDIASMAXDESDCPAGAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmaxdesdcpagar
        {
            get { return  numdiasmaxdesdcpagar; }
            set {  numdiasmaxdesdcpagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXDESD1210
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxdesd1210;
        [XmlElement(ElementName = "NUMDIASMAXDESD1210", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmaxdesd1210
        {
            get { return  numdiasmaxdesd1210; }
            set {  numdiasmaxdesd1210 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXDESD402
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxdesd402;
        [XmlElement(ElementName = "NUMDIASMAXDESD402", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmaxdesd402
        {
            get { return  numdiasmaxdesd402; }
            set {  numdiasmaxdesd402 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXEMISSAOCP
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxemissaocp;
        [XmlElement(ElementName = "NUMDIASMAXEMISSAOCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmaxemissaocp
        {
            get { return  numdiasmaxemissaocp; }
            set {  numdiasmaxemissaocp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXEMISSAONF
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxemissaonf;
        [XmlElement(ElementName = "NUMDIASMAXEMISSAONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdiasmaxemissaonf
        {
            get { return  numdiasmaxemissaonf; }
            set {  numdiasmaxemissaonf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXFATURA
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxfatura;
        [XmlElement(ElementName = "NUMDIASMAXFATURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmaxfatura
        {
            get { return  numdiasmaxfatura; }
            set {  numdiasmaxfatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXPRORROG
        /// Comentário: 
        /// </summary>
        private decimal numdiasmaxprorrog;
        [XmlElement(ElementName = "NUMDIASMAXPRORROG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmaxprorrog
        {
            get { return  numdiasmaxprorrog; }
            set {  numdiasmaxprorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXVENDACLIINADIMPLENTE
        /// Comentário: Se parâmetro estiver zerado o mesmo não será validado, mas se parâmetro estiver x > 0 não serão permitidas vendas em atraso a x dias.
        /// </summary>
        private decimal numdiasmaxvendacliinadimplente;
        [XmlElement(ElementName = "NUMDIASMAXVENDACLIINADIMPLENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numdiasmaxvendacliinadimplente
        {
            get { return  numdiasmaxvendacliinadimplente; }
            set {  numdiasmaxvendacliinadimplente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMINDESPPAG
        /// Comentário: 
        /// </summary>
        private decimal numdiasmindesppag;
        [XmlElement(ElementName = "NUMDIASMINDESPPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmindesppag
        {
            get { return  numdiasmindesppag; }
            set {  numdiasmindesppag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMINVENDABK
        /// Comentário: Indica o número de dias mínimo para venda BK. 
        /// </summary>
        private decimal numdiasminvendabk;
        [XmlElement(ElementName = "NUMDIASMINVENDABK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numdiasminvendabk
        {
            get { return  numdiasminvendabk; }
            set {  numdiasminvendabk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASPAGCHQCANCEL
        /// Comentário: 
        /// </summary>
        private decimal numdiaspagchqcancel;
        [XmlElement(ElementName = "NUMDIASPAGCHQCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdiaspagchqcancel
        {
            get { return  numdiaspagchqcancel; }
            set {  numdiaspagchqcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASPAGTORETRO
        /// Comentário: 
        /// </summary>
        private decimal numdiaspagtoretro;
        [XmlElement(ElementName = "NUMDIASPAGTORETRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdiaspagtoretro
        {
            get { return  numdiaspagtoretro; }
            set {  numdiaspagtoretro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASUTEISSEMANA
        /// Comentário: 
        /// </summary>
        private decimal numdiasuteissemana;
        [XmlElement(ElementName = "NUMDIASUTEISSEMANA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasuteissemana
        {
            get { return  numdiasuteissemana; }
            set {  numdiasuteissemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASUTEISTRIMESTRE
        /// Comentário: 
        /// </summary>
        private decimal numdiasuteistrimestre;
        [XmlElement(ElementName = "NUMDIASUTEISTRIMESTRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasuteistrimestre
        {
            get { return  numdiasuteistrimestre; }
            set {  numdiasuteistrimestre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASVENCTITULOCOBEXT
        /// Comentário: Indica o número de dias de atraso título p/ cobrança externa.
        /// </summary>
        private decimal numdiasvenctitulocobext;
        [XmlElement(ElementName = "NUMDIASVENCTITULOCOBEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numdiasvenctitulocobext
        {
            get { return  numdiasvenctitulocobext; }
            set {  numdiasvenctitulocobext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASVENCTITULOCOBINT
        /// Comentário: Indica o número de dias de atraso título p/ cobrança interna.
        /// </summary>
        private decimal numdiasvenctitulocobint;
        [XmlElement(ElementName = "NUMDIASVENCTITULOCOBINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numdiasvenctitulocobint
        {
            get { return  numdiasvenctitulocobint; }
            set {  numdiasvenctitulocobint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITENSOS
        /// Comentário: 
        /// </summary>
        private decimal numitensos;
        [XmlElement(ElementName = "NUMITENSOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numitensos
        {
            get { return  numitensos; }
            set {  numitensos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMAXNFTRANSF
        /// Comentário: 
        /// </summary>
        private decimal nummaxnftransf;
        [XmlElement(ElementName = "NUMMAXNFTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Nummaxnftransf
        {
            get { return  nummaxnftransf; }
            set {  nummaxnftransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMAXPARCENT
        /// Comentário: Número máximo de parcelas na entrada. 
        /// </summary>
        private decimal nummaxparcent;
        [XmlElement(ElementName = "NUMMAXPARCENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Nummaxparcent
        {
            get { return  nummaxparcent; }
            set {  nummaxparcent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMAXTITULOSPORRECIBO
        /// Comentário: Indica o número máximo de títulos a serem baixados por Recibo.
        /// </summary>
        private decimal nummaxtitulosporrecibo;
        [XmlElement(ElementName = "NUMMAXTITULOSPORRECIBO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Nummaxtitulosporrecibo
        {
            get { return  nummaxtitulosporrecibo; }
            set {  nummaxtitulosporrecibo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORDABAS
        /// Comentário: 
        /// </summary>
        private decimal numordabas;
        [XmlElement(ElementName = "NUMORDABAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numordabas
        {
            get { return  numordabas; }
            set {  numordabas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAOPADRAO
        /// Comentário: 
        /// </summary>
        private decimal numregiaopadrao;
        [XmlElement(ElementName = "NUMREGIAOPADRAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiaopadrao
        {
            get { return  numregiaopadrao; }
            set {  numregiaopadrao = value; }
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
        /// Propriedade referente ao campo: NUMVIASMAPASEP
        /// Comentário: 
        /// </summary>
        private decimal numviasmapasep;
        [XmlElement(ElementName = "NUMVIASMAPASEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numviasmapasep
        {
            get { return  numviasmapasep; }
            set {  numviasmapasep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBTERPREFERENCIACLIECF
        /// Comentário: 
        /// </summary>
        private string obterpreferenciacliecf;
        [XmlElement(ElementName = "OBTERPREFERENCIACLIECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obterpreferenciacliecf
        {
            get { return  obterpreferenciacliecf; }
            set {  obterpreferenciacliecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMAVALIACAOCOMISSAORCA
        /// Comentário: Indica permite alterar a ordem da avaliação dos diferentes tipos de comissão disponíveis no WinThor. A sequência de avaliação indica qual forma de comissão tem maior prioridade. 
        /// </summary>
        private decimal ordemavaliacaocomissaorca;
        [XmlElement(ElementName = "ORDEMAVALIACAOCOMISSAORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Ordemavaliacaocomissaorca
        {
            get { return  ordemavaliacaocomissaorca; }
            set {  ordemavaliacaocomissaorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMMAPA
        /// Comentário: 
        /// </summary>
        private decimal ordemmapa;
        [XmlElement(ElementName = "ORDEMMAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Ordemmapa
        {
            get { return  ordemmapa; }
            set {  ordemmapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OSRESERVANAEXECUCAO
        /// Comentário: Reserva de produto somente na execução da ordem de serviço.
        /// </summary>
        private string osreservanaexecucao;
        [XmlElement(ElementName = "OSRESERVANAEXECUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Osreservanaexecucao
        {
            get { return  osreservanaexecucao; }
            set {  osreservanaexecucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PADRAOCALLCENTER
        /// Comentário: 
        /// </summary>
        private string padraocallcenter;
        [XmlElement(ElementName = "PADRAOCALLCENTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Padraocallcenter
        {
            get { return  padraocallcenter; }
            set {  padraocallcenter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PASTA_RELATORIO
        /// Comentário: Pasta do Relatorio
        /// </summary>
        private string pasta_relatorio;
        [XmlElement(ElementName = "PASTA_RELATORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Pasta_Relatorio
        {
            get { return  pasta_relatorio; }
            set {  pasta_relatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCKABASTECIDO
        /// Comentário: 
        /// </summary>
        private string pckabastecido;
        [XmlElement(ElementName = "PCKABASTECIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pckabastecido
        {
            get { return  pckabastecido; }
            set {  pckabastecido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOCOMPRAPORPALETE
        /// Comentário: 
        /// </summary>
        private string pedidocompraporpalete;
        [XmlElement(ElementName = "PEDIDOCOMPRAPORPALETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pedidocompraporpalete
        {
            get { return  pedidocompraporpalete; }
            set {  pedidocompraporpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDIDOPORDISTRIB
        /// Comentário: Indica se é permitido ao RCA vender produtos independente da sua distribuição.
        /// </summary>
        private string pedidopordistrib;
        [XmlElement(ElementName = "PEDIDOPORDISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pedidopordistrib
        {
            get { return  pedidopordistrib; }
            set {  pedidopordistrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEDVENDADEPTO
        /// Comentário: 
        /// </summary>
        private string pedvendadepto;
        [XmlElement(ElementName = "PEDVENDADEPTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pedvendadepto
        {
            get { return  pedvendadepto; }
            set {  pedvendadepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDOUTRASDESP
        /// Comentário: Percentual de Redução da Base ICMS de Despesas Acessórias.
        /// </summary>
        private decimal perbaseredoutrasdesp;
        [XmlElement(ElementName = "PERBASEREDOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredoutrasdesp
        {
            get { return  perbaseredoutrasdesp; }
            set {  perbaseredoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEVEND
        /// Comentário: 
        /// </summary>
        private decimal perbasevend;
        [XmlElement(ElementName = "PERBASEVEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perbasevend
        {
            get { return  perbasevend; }
            set {  perbasevend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCIMOBALCAO
        /// Comentário: . 
        /// </summary>
        private decimal percacrescimobalcao;
        [XmlElement(ElementName = "PERCACRESCIMOBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percacrescimobalcao
        {
            get { return  percacrescimobalcao; }
            set {  percacrescimobalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCIMOCUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal percacrescimocustofin;
        [XmlElement(ElementName = "PERCACRESCIMOCUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percacrescimocustofin
        {
            get { return  percacrescimocustofin; }
            set {  percacrescimocustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCIMOCUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal percacrescimocustoreal;
        [XmlElement(ElementName = "PERCACRESCIMOCUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percacrescimocustoreal
        {
            get { return  percacrescimocustoreal; }
            set {  percacrescimocustoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAPANHA
        /// Comentário: 
        /// </summary>
        private decimal percapanha;
        [XmlElement(ElementName = "PERCAPANHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percapanha
        {
            get { return  percapanha; }
            set {  percapanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCSRF
        /// Comentário: Campo para armazenar alíquota do CSRF. 
        /// </summary>
        private decimal perccsrf;
        [XmlElement(ElementName = "PERCCSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perccsrf
        {
            get { return  perccsrf; }
            set {  perccsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFQTENT
        /// Comentário: 
        /// </summary>
        private decimal percdifqtent;
        [XmlElement(ElementName = "PERCDIFQTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Percdifqtent
        {
            get { return  percdifqtent; }
            set {  percdifqtent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCEXCESSODEVOL
        /// Comentário: Bloquear cliente com excesso de devoluções
        /// </summary>
        private decimal percexcessodevol;
        [XmlElement(ElementName = "PERCEXCESSODEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percexcessodevol
        {
            get { return  percexcessodevol; }
            set {  percexcessodevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMFRETE
        /// Comentário: 
        /// </summary>
        private decimal percicmfrete;
        [XmlElement(ElementName = "PERCICMFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percicmfrete
        {
            get { return  percicmfrete; }
            set {  percicmfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMFRETEENT
        /// Comentário: Campo que identifica o percentual de ICMS padrão para fretes na entrada estadual.
        /// </summary>
        private decimal percicmfreteent;
        [XmlElement(ElementName = "PERCICMFRETEENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percicmfreteent
        {
            get { return  percicmfreteent; }
            set {  percicmfreteent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMINTERFRETE
        /// Comentário: 
        /// </summary>
        private decimal percicminterfrete;
        [XmlElement(ElementName = "PERCICMINTERFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percicminterfrete
        {
            get { return  percicminterfrete; }
            set {  percicminterfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMINTERFRETEENT
        /// Comentário: Campo que identifica o percentual de ICMS padrão para fretes na entrada interestadual.
        /// </summary>
        private decimal percicminterfreteent;
        [XmlElement(ElementName = "PERCICMINTERFRETEENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percicminterfreteent
        {
            get { return  percicminterfreteent; }
            set {  percicminterfreteent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINSS
        /// Comentário: Campo para armazenar alíquota do INSS. 
        /// </summary>
        private decimal percinss;
        [XmlElement(ElementName = "PERCINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percinss
        {
            get { return  percinss; }
            set {  percinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCJUROSMORA
        /// Comentário: 
        /// </summary>
        private decimal percjurosmora;
        [XmlElement(ElementName = "PERCJUROSMORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percjurosmora
        {
            get { return  percjurosmora; }
            set {  percjurosmora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCLANCCREDCLI
        /// Comentário: Percentual de Uso de Crédito do Cliente.
        /// </summary>
        private decimal perclanccredcli;
        [XmlElement(ElementName = "PERCLANCCREDCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perclanccredcli
        {
            get { return  perclanccredcli; }
            set {  perclanccredcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXDESCCR
        /// Comentário: 
        /// </summary>
        private decimal percmaxdesccr;
        [XmlElement(ElementName = "PERCMAXDESCCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percmaxdesccr
        {
            get { return  percmaxdesccr; }
            set {  percmaxdesccr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXDESCDESD
        /// Comentário: 
        /// </summary>
        private decimal percmaxdescdesd;
        [XmlElement(ElementName = "PERCMAXDESCDESD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percmaxdescdesd
        {
            get { return  percmaxdescdesd; }
            set {  percmaxdescdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXJUROSMORA
        /// Comentário: 
        /// </summary>
        private decimal percmaxjurosmora;
        [XmlElement(ElementName = "PERCMAXJUROSMORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percmaxjurosmora
        {
            get { return  percmaxjurosmora; }
            set {  percmaxjurosmora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXLIBESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal percmaxlibestoque;
        [XmlElement(ElementName = "PERCMAXLIBESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percmaxlibestoque
        {
            get { return  percmaxlibestoque; }
            set {  percmaxlibestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMINJUROSMORA
        /// Comentário: 
        /// </summary>
        private decimal percminjurosmora;
        [XmlElement(ElementName = "PERCMINJUROSMORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percminjurosmora
        {
            get { return  percminjurosmora; }
            set {  percminjurosmora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLERANCIAIMPUREZA
        /// Comentário: 
        /// </summary>
        private decimal perctoleranciaimpureza;
        [XmlElement(ElementName = "PERCTOLERANCIAIMPUREZA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perctoleranciaimpureza
        {
            get { return  perctoleranciaimpureza; }
            set {  perctoleranciaimpureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLERANCIAINTEIRO
        /// Comentário: 
        /// </summary>
        private decimal perctoleranciainteiro;
        [XmlElement(ElementName = "PERCTOLERANCIAINTEIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perctoleranciainteiro
        {
            get { return  perctoleranciainteiro; }
            set {  perctoleranciainteiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLERANCIAQUEBRADO
        /// Comentário: 
        /// </summary>
        private decimal perctoleranciaquebrado;
        [XmlElement(ElementName = "PERCTOLERANCIAQUEBRADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perctoleranciaquebrado
        {
            get { return  perctoleranciaquebrado; }
            set {  perctoleranciaquebrado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLERANCIAUMIDADE
        /// Comentário: 
        /// </summary>
        private decimal perctoleranciaumidade;
        [XmlElement(ElementName = "PERCTOLERANCIAUMIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perctoleranciaumidade
        {
            get { return  perctoleranciaumidade; }
            set {  perctoleranciaumidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLERANCIAVERMELHO
        /// Comentário: 
        /// </summary>
        private decimal perctoleranciavermelho;
        [XmlElement(ElementName = "PERCTOLERANCIAVERMELHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perctoleranciavermelho
        {
            get { return  perctoleranciavermelho; }
            set {  perctoleranciavermelho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXBALCAO
        /// Comentário: 
        /// </summary>
        private decimal perdescmaxbalcao;
        [XmlElement(ElementName = "PERDESCMAXBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescmaxbalcao
        {
            get { return  perdescmaxbalcao; }
            set {  perdescmaxbalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMEDIOVENDA
        /// Comentário: 
        /// </summary>
        private decimal perdescmediovenda;
        [XmlElement(ElementName = "PERDESCMEDIOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescmediovenda
        {
            get { return  perdescmediovenda; }
            set {  perdescmediovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCPROM
        /// Comentário: 
        /// </summary>
        private decimal perdescprom;
        [XmlElement(ElementName = "PERDESCPROM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescprom
        {
            get { return  perdescprom; }
            set {  perdescprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEREXCEDELIMCRED
        /// Comentário: 
        /// </summary>
        private decimal perexcedelimcred;
        [XmlElement(ElementName = "PEREXCEDELIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perexcedelimcred
        {
            get { return  perexcedelimcred; }
            set {  perexcedelimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERGUNTARSOMAQTPEDVENDA
        /// Comentário: 
        /// </summary>
        private string perguntarsomaqtpedvenda;
        [XmlElement(ElementName = "PERGUNTARSOMAQTPEDVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Perguntarsomaqtpedvenda
        {
            get { return  perguntarsomaqtpedvenda; }
            set {  perguntarsomaqtpedvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERLIMVENDAPF
        /// Comentário: 
        /// </summary>
        private decimal perlimvendapf;
        [XmlElement(ElementName = "PERLIMVENDAPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perlimvendapf
        {
            get { return  perlimvendapf; }
            set {  perlimvendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXDESCAUTOR
        /// Comentário: 
        /// </summary>
        private decimal permaxdescautor;
        [XmlElement(ElementName = "PERMAXDESCAUTOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Permaxdescautor
        {
            get { return  permaxdescautor; }
            set {  permaxdescautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXDESCITEMCF
        /// Comentário: 
        /// </summary>
        private decimal permaxdescitemcf;
        [XmlElement(ElementName = "PERMAXDESCITEMCF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Permaxdescitemcf
        {
            get { return  permaxdescitemcf; }
            set {  permaxdescitemcf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXDESCVENDA
        /// Comentário: 
        /// </summary>
        private decimal permaxdescvenda;
        [XmlElement(ElementName = "PERMAXDESCVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Permaxdescvenda
        {
            get { return  permaxdescvenda; }
            set {  permaxdescvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXDIFENTRADA
        /// Comentário: 
        /// </summary>
        private decimal permaxdifentrada;
        [XmlElement(ElementName = "PERMAXDIFENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Permaxdifentrada
        {
            get { return  permaxdifentrada; }
            set {  permaxdifentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXINDENIZPEDIDO
        /// Comentário: 
        /// </summary>
        private decimal permaxindenizpedido;
        [XmlElement(ElementName = "PERMAXINDENIZPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Permaxindenizpedido
        {
            get { return  permaxindenizpedido; }
            set {  permaxindenizpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXPCOMPRA
        /// Comentário: 
        /// </summary>
        private decimal permaxpcompra;
        [XmlElement(ElementName = "PERMAXPCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Permaxpcompra
        {
            get { return  permaxpcompra; }
            set {  permaxpcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXRODAPE
        /// Comentário: 
        /// </summary>
        private decimal permaxrodape;
        [XmlElement(ElementName = "PERMAXRODAPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Permaxrodape
        {
            get { return  permaxrodape; }
            set {  permaxrodape = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXRODAPECHECKOUT
        /// Comentário: Indica o %máximo de desconto no rodapé que pode ser lançado na PCAUX2075 quando o parâmetro PERMITIRDESCRODAPECHECKOUT estiver habilitado. 
        /// </summary>
        private decimal permaxrodapecheckout;
        [XmlElement(ElementName = "PERMAXRODAPECHECKOUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Permaxrodapecheckout
        {
            get { return  permaxrodapecheckout; }
            set {  permaxrodapecheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXVENDA
        /// Comentário: 
        /// </summary>
        private decimal permaxvenda;
        [XmlElement(ElementName = "PERMAXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Permaxvenda
        {
            get { return  permaxvenda; }
            set {  permaxvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMINDIFENTRADA
        /// Comentário: 
        /// </summary>
        private decimal permindifentrada;
        [XmlElement(ElementName = "PERMINDIFENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Permindifentrada
        {
            get { return  permindifentrada; }
            set {  permindifentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTCODCOBVENDA
        /// Comentário: 
        /// </summary>
        private string permitealtcodcobvenda;
        [XmlElement(ElementName = "PERMITEALTCODCOBVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealtcodcobvenda
        {
            get { return  permitealtcodcobvenda; }
            set {  permitealtcodcobvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTDTVENCENTMERC
        /// Comentário: 
        /// </summary>
        private string permitealtdtvencentmerc;
        [XmlElement(ElementName = "PERMITEALTDTVENCENTMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealtdtvencentmerc
        {
            get { return  permitealtdtvencentmerc; }
            set {  permitealtdtvencentmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTPLPAGVENDA
        /// Comentário: 
        /// </summary>
        private string permitealtplpagvenda;
        [XmlElement(ElementName = "PERMITEALTPLPAGVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealtplpagvenda
        {
            get { return  permitealtplpagvenda; }
            set {  permitealtplpagvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITECODBARRADUPLICADO
        /// Comentário: 
        /// </summary>
        private string permitecodbarraduplicado;
        [XmlElement(ElementName = "PERMITECODBARRADUPLICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitecodbarraduplicado
        {
            get { return  permitecodbarraduplicado; }
            set {  permitecodbarraduplicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITECOMPRAFORNECBLOQ
        /// Comentário: 
        /// </summary>
        private string permitecomprafornecbloq;
        [XmlElement(ElementName = "PERMITECOMPRAFORNECBLOQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitecomprafornecbloq
        {
            get { return  permitecomprafornecbloq; }
            set {  permitecomprafornecbloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITECRDEVFORNEC
        /// Comentário: 
        /// </summary>
        private string permitecrdevfornec;
        [XmlElement(ElementName = "PERMITECRDEVFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitecrdevfornec
        {
            get { return  permitecrdevfornec; }
            set {  permitecrdevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEDESCCR
        /// Comentário: 
        /// </summary>
        private string permitedesccr;
        [XmlElement(ElementName = "PERMITEDESCCR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitedesccr
        {
            get { return  permitedesccr; }
            set {  permitedesccr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEDEVOLREQNORMAL
        /// Comentário: 
        /// </summary>
        private string permitedevolreqnormal;
        [XmlElement(ElementName = "PERMITEDEVOLREQNORMAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitedevolreqnormal
        {
            get { return  permitedevolreqnormal; }
            set {  permitedevolreqnormal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEINICIAROPSEMMP
        /// Comentário: 
        /// </summary>
        private string permiteiniciaropsemmp;
        [XmlElement(ElementName = "PERMITEINICIAROPSEMMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteiniciaropsemmp
        {
            get { return  permiteiniciaropsemmp; }
            set {  permiteiniciaropsemmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEPEDCOMPRAMULTIPLO
        /// Comentário: 
        /// </summary>
        private string permitepedcompramultiplo;
        [XmlElement(ElementName = "PERMITEPEDCOMPRAMULTIPLO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitepedcompramultiplo
        {
            get { return  permitepedcompramultiplo; }
            set {  permitepedcompramultiplo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEPEDCOMPRAUNIDMASTER
        /// Comentário: 
        /// </summary>
        private string permitepedcompraunidmaster;
        [XmlElement(ElementName = "PERMITEPEDCOMPRAUNIDMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitepedcompraunidmaster
        {
            get { return  permitepedcompraunidmaster; }
            set {  permitepedcompraunidmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEPLPAGTOSUPERIOR
        /// Comentário: 
        /// </summary>
        private string permiteplpagtosuperior;
        [XmlElement(ElementName = "PERMITEPLPAGTOSUPERIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteplpagtosuperior
        {
            get { return  permiteplpagtosuperior; }
            set {  permiteplpagtosuperior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEVARIOSPEDIDOSORCAMENTO
        /// Comentário: 
        /// </summary>
        private string permitevariospedidosorcamento;
        [XmlElement(ElementName = "PERMITEVARIOSPEDIDOSORCAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitevariospedidosorcamento
        {
            get { return  permitevariospedidosorcamento; }
            set {  permitevariospedidosorcamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEVENDAECF402
        /// Comentário: 
        /// </summary>
        private string permitevendaecf402;
        [XmlElement(ElementName = "PERMITEVENDAECF402", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitevendaecf402
        {
            get { return  permitevendaecf402; }
            set {  permitevendaecf402 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEVENDAPRODUTOPV
        /// Comentário: Indica se permite vender produtos proibidos. 
        /// </summary>
        private string permitevendaprodutopv;
        [XmlElement(ElementName = "PERMITEVENDAPRODUTOPV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitevendaprodutopv
        {
            get { return  permitevendaprodutopv; }
            set {  permitevendaprodutopv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIRDESCRODAPECHECKOUT
        /// Comentário: Indica se permite lançar desconto no rodapé na rotina PCAUX2075, baseado em controle de acesso por usuário e validando %máximo de desconto no rodapé. 
        /// </summary>
        private string permitirdescrodapecheckout;
        [XmlElement(ElementName = "PERMITIRDESCRODAPECHECKOUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitirdescrodapecheckout
        {
            get { return  permitirdescrodapecheckout; }
            set {  permitirdescrodapecheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIRDESDDEVCLI
        /// Comentário: 
        /// </summary>
        private string permitirdesddevcli;
        [XmlElement(ElementName = "PERMITIRDESDDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitirdesddevcli
        {
            get { return  permitirdesddevcli; }
            set {  permitirdesddevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIRDESDTITVENCSEMJUROS
        /// Comentário: 
        /// </summary>
        private string permitirdesdtitvencsemjuros;
        [XmlElement(ElementName = "PERMITIRDESDTITVENCSEMJUROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitirdesdtitvencsemjuros
        {
            get { return  permitirdesdtitvencsemjuros; }
            set {  permitirdesdtitvencsemjuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIRDIVNFDUPLIC
        /// Comentário: 
        /// </summary>
        private string permitirdivnfduplic;
        [XmlElement(ElementName = "PERMITIRDIVNFDUPLIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitirdivnfduplic
        {
            get { return  permitirdivnfduplic; }
            set {  permitirdivnfduplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERVENDAPF
        /// Comentário: 
        /// </summary>
        private decimal pervendapf;
        [XmlElement(ElementName = "PERVENDAPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pervendapf
        {
            get { return  pervendapf; }
            set {  pervendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOMAXPALETE
        /// Comentário: 
        /// </summary>
        private decimal pesomaxpalete;
        [XmlElement(ElementName = "PESOMAXPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pesomaxpalete
        {
            get { return  pesomaxpalete; }
            set {  pesomaxpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOSUPPALETE
        /// Comentário: 
        /// </summary>
        private decimal pesosuppalete;
        [XmlElement(ElementName = "PESOSUPPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pesosuppalete
        {
            get { return  pesosuppalete; }
            set {  pesosuppalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOTRANSF
        /// Comentário: 
        /// </summary>
        private decimal pesotransf;
        [XmlElement(ElementName = "PESOTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pesotransf
        {
            get { return  pesotransf; }
            set {  pesotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTANFE
        /// Comentário: Porta do Servidor de NF-e. 
        /// </summary>
        private decimal portanfe;
        [XmlElement(ElementName = "PORTANFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Portanfe
        {
            get { return  portanfe; }
            set {  portanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONALMAX
        /// Comentário: 
        /// </summary>
        private decimal prazoadicionalmax;
        [XmlElement(ElementName = "PRAZOADICIONALMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Prazoadicionalmax
        {
            get { return  prazoadicionalmax; }
            set {  prazoadicionalmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOEDICAOPEDIDOCOMPRA
        /// Comentário: 
        /// </summary>
        private decimal prazoedicaopedidocompra;
        [XmlElement(ElementName = "PRAZOEDICAOPEDIDOCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Prazoedicaopedidocompra
        {
            get { return  prazoedicaopedidocompra; }
            set {  prazoedicaopedidocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOENTREGA
        /// Comentário: 
        /// </summary>
        private decimal prazoentrega;
        [XmlElement(ElementName = "PRAZOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoentrega
        {
            get { return  prazoentrega; }
            set {  prazoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOFATALMED
        /// Comentário: 
        /// </summary>
        private decimal prazofatalmed;
        [XmlElement(ElementName = "PRAZOFATALMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazofatalmed
        {
            get { return  prazofatalmed; }
            set {  prazofatalmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXDTENTREGA
        /// Comentário: 
        /// </summary>
        private decimal prazomaxdtentrega;
        [XmlElement(ElementName = "PRAZOMAXDTENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Prazomaxdtentrega
        {
            get { return  prazomaxdtentrega; }
            set {  prazomaxdtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXVALIDADE
        /// Comentário: 
        /// </summary>
        private decimal prazomaxvalidade;
        [XmlElement(ElementName = "PRAZOMAXVALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Prazomaxvalidade
        {
            get { return  prazomaxvalidade; }
            set {  prazomaxvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMINVALIDADE
        /// Comentário: 
        /// </summary>
        private decimal prazominvalidade;
        [XmlElement(ElementName = "PRAZOMINVALIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Prazominvalidade
        {
            get { return  prazominvalidade; }
            set {  prazominvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOVALIDADEORCAMENTO
        /// Comentário: 
        /// </summary>
        private decimal prazovalidadeorcamento;
        [XmlElement(ElementName = "PRAZOVALIDADEORCAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazovalidadeorcamento
        {
            get { return  prazovalidadeorcamento; }
            set {  prazovalidadeorcamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOVALIDADEPEDBALCAO
        /// Comentário: 
        /// </summary>
        private decimal prazovalidadepedbalcao;
        [XmlElement(ElementName = "PRAZOVALIDADEPEDBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazovalidadepedbalcao
        {
            get { return  prazovalidadepedbalcao; }
            set {  prazovalidadepedbalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOPOREMBALAGEM
        /// Comentário: 
        /// </summary>
        private string precoporembalagem;
        [XmlElement(ElementName = "PRECOPOREMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Precoporembalagem
        {
            get { return  precoporembalagem; }
            set {  precoporembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROCNUMLISTA
        /// Comentário: Indica o número da lista que a cotação pertence. 
        /// </summary>
        private decimal procnumlista;
        [XmlElement(ElementName = "PROCNUMLISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Procnumlista
        {
            get { return  procnumlista; }
            set {  procnumlista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXCODPLPAG
        /// Comentário: Indica o código do proximo plano de pagamento.
        /// </summary>
        private decimal proxcodplpag;
        [XmlElement(ElementName = "PROXCODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Proxcodplpag
        {
            get { return  proxcodplpag; }
            set {  proxcodplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXCODPRACA
        /// Comentário: 
        /// </summary>
        private decimal proxcodpraca;
        [XmlElement(ElementName = "PROXCODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Proxcodpraca
        {
            get { return  proxcodpraca; }
            set {  proxcodpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXCODUSUR
        /// Comentário: 
        /// </summary>
        private decimal proxcodusur;
        [XmlElement(ElementName = "PROXCODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Proxcodusur
        {
            get { return  proxcodusur; }
            set {  proxcodusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMAPLIC
        /// Comentário: 
        /// </summary>
        private decimal proxnumaplic;
        [XmlElement(ElementName = "PROXNUMAPLIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumaplic
        {
            get { return  proxnumaplic; }
            set {  proxnumaplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal proxnumbonus;
        [XmlElement(ElementName = "PROXNUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumbonus
        {
            get { return  proxnumbonus; }
            set {  proxnumbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMBORDERO
        /// Comentário: 
        /// </summary>
        private decimal proxnumbordero;
        [XmlElement(ElementName = "PROXNUMBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumbordero
        {
            get { return  proxnumbordero; }
            set {  proxnumbordero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMBORDEROCR
        /// Comentário: 
        /// </summary>
        private decimal proxnumborderocr;
        [XmlElement(ElementName = "PROXNUMBORDEROCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumborderocr
        {
            get { return  proxnumborderocr; }
            set {  proxnumborderocr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCAR
        /// Comentário: 
        /// </summary>
        private decimal proxnumcar;
        [XmlElement(ElementName = "PROXNUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumcar
        {
            get { return  proxnumcar; }
            set {  proxnumcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCLI
        /// Comentário: 
        /// </summary>
        private decimal proxnumcli;
        [XmlElement(ElementName = "PROXNUMCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumcli
        {
            get { return  proxnumcli; }
            set {  proxnumcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCODBARRALOTE
        /// Comentário: Indica o próximo número do Lote.
        /// </summary>
        private decimal proxnumcodbarralote;
        [XmlElement(ElementName = "PROXNUMCODBARRALOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumcodbarralote
        {
            get { return  proxnumcodbarralote; }
            set {  proxnumcodbarralote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCONHEC
        /// Comentário: 
        /// </summary>
        private decimal proxnumconhec;
        [XmlElement(ElementName = "PROXNUMCONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumconhec
        {
            get { return  proxnumconhec; }
            set {  proxnumconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCONTRATO
        /// Comentário: 
        /// </summary>
        private decimal proxnumcontrato;
        [XmlElement(ElementName = "PROXNUMCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumcontrato
        {
            get { return  proxnumcontrato; }
            set {  proxnumcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCUSTODIA
        /// Comentário: 
        /// </summary>
        private decimal proxnumcustodia;
        [XmlElement(ElementName = "PROXNUMCUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumcustodia
        {
            get { return  proxnumcustodia; }
            set {  proxnumcustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMFORNEC
        /// Comentário: 
        /// </summary>
        private decimal proxnumfornec;
        [XmlElement(ElementName = "PROXNUMFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumfornec
        {
            get { return  proxnumfornec; }
            set {  proxnumfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMINDENIZ
        /// Comentário: 
        /// </summary>
        private decimal proxnumindeniz;
        [XmlElement(ElementName = "PROXNUMINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumindeniz
        {
            get { return  proxnumindeniz; }
            set {  proxnumindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMINVENTROT
        /// Comentário: 
        /// </summary>
        private decimal proxnuminventrot;
        [XmlElement(ElementName = "PROXNUMINVENTROT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnuminventrot
        {
            get { return  proxnuminventrot; }
            set {  proxnuminventrot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLANC
        /// Comentário: 
        /// </summary>
        private decimal proxnumlanc;
        [XmlElement(ElementName = "PROXNUMLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumlanc
        {
            get { return  proxnumlanc; }
            set {  proxnumlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTE
        /// Comentário: 
        /// </summary>
        private decimal proxnumlote;
        [XmlElement(ElementName = "PROXNUMLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumlote
        {
            get { return  proxnumlote; }
            set {  proxnumlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTECUSTODIA
        /// Comentário: 
        /// </summary>
        private decimal proxnumlotecustodia;
        [XmlElement(ElementName = "PROXNUMLOTECUSTODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumlotecustodia
        {
            get { return  proxnumlotecustodia; }
            set {  proxnumlotecustodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTEEM
        /// Comentário: 
        /// </summary>
        private decimal proxnumloteem;
        [XmlElement(ElementName = "PROXNUMLOTEEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumloteem
        {
            get { return  proxnumloteem; }
            set {  proxnumloteem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTEMP
        /// Comentário: 
        /// </summary>
        private decimal proxnumlotemp;
        [XmlElement(ElementName = "PROXNUMLOTEMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumlotemp
        {
            get { return  proxnumlotemp; }
            set {  proxnumlotemp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTENFE
        /// Comentário: Próximo Número de Lote da Nota Fiscal Eletrônica. 
        /// </summary>
        private decimal proxnumlotenfe;
        [XmlElement(ElementName = "PROXNUMLOTENFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumlotenfe
        {
            get { return  proxnumlotenfe; }
            set {  proxnumlotenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTENFEDPEC
        /// Comentário: Próximo lote DPEC.
        /// </summary>
        private decimal proxnumlotenfedpec;
        [XmlElement(ElementName = "PROXNUMLOTENFEDPEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumlotenfedpec
        {
            get { return  proxnumlotenfedpec; }
            set {  proxnumlotenfedpec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTEREAGENTE
        /// Comentário: 
        /// </summary>
        private decimal proxnumlotereagente;
        [XmlElement(ElementName = "PROXNUMLOTEREAGENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumlotereagente
        {
            get { return  proxnumlotereagente; }
            set {  proxnumlotereagente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTESA
        /// Comentário: 
        /// </summary>
        private decimal proxnumlotesa;
        [XmlElement(ElementName = "PROXNUMLOTESA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumlotesa
        {
            get { return  proxnumlotesa; }
            set {  proxnumlotesa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMMANIF
        /// Comentário: 
        /// </summary>
        private decimal proxnummanif;
        [XmlElement(ElementName = "PROXNUMMANIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnummanif
        {
            get { return  proxnummanif; }
            set {  proxnummanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNEG
        /// Comentário: 
        /// </summary>
        private decimal proxnumneg;
        [XmlElement(ElementName = "PROXNUMNEG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumneg
        {
            get { return  proxnumneg; }
            set {  proxnumneg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMOP
        /// Comentário: 
        /// </summary>
        private decimal proxnumop;
        [XmlElement(ElementName = "PROXNUMOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumop
        {
            get { return  proxnumop; }
            set {  proxnumop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMOPI
        /// Comentário: 
        /// </summary>
        private decimal proxnumopi;
        [XmlElement(ElementName = "PROXNUMOPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumopi
        {
            get { return  proxnumopi; }
            set {  proxnumopi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMORC
        /// Comentário: 
        /// </summary>
        private decimal proxnumorc;
        [XmlElement(ElementName = "PROXNUMORC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumorc
        {
            get { return  proxnumorc; }
            set {  proxnumorc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMORDEMTRANSF
        /// Comentário: 
        /// </summary>
        private decimal proxnumordemtransf;
        [XmlElement(ElementName = "PROXNUMORDEMTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumordemtransf
        {
            get { return  proxnumordemtransf; }
            set {  proxnumordemtransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPCP
        /// Comentário: 
        /// </summary>
        private decimal proxnumpcp;
        [XmlElement(ElementName = "PROXNUMPCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumpcp
        {
            get { return  proxnumpcp; }
            set {  proxnumpcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPED
        /// Comentário: 
        /// </summary>
        private decimal proxnumped;
        [XmlElement(ElementName = "PROXNUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumped
        {
            get { return  proxnumped; }
            set {  proxnumped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPEDTLMK
        /// Comentário: 
        /// </summary>
        private decimal proxnumpedtlmk;
        [XmlElement(ElementName = "PROXNUMPEDTLMK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumpedtlmk
        {
            get { return  proxnumpedtlmk; }
            set {  proxnumpedtlmk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPESQUISA
        /// Comentário: 
        /// </summary>
        private decimal proxnumpesquisa;
        [XmlElement(ElementName = "PROXNUMPESQUISA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumpesquisa
        {
            get { return  proxnumpesquisa; }
            set {  proxnumpesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPRODUT
        /// Comentário: 
        /// </summary>
        private decimal proxnumprodut;
        [XmlElement(ElementName = "PROXNUMPRODUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumprodut
        {
            get { return  proxnumprodut; }
            set {  proxnumprodut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMRCA
        /// Comentário: 
        /// </summary>
        private decimal proxnumrca;
        [XmlElement(ElementName = "PROXNUMRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumrca
        {
            get { return  proxnumrca; }
            set {  proxnumrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMRPA
        /// Comentário: 
        /// </summary>
        private decimal proxnumrpa;
        [XmlElement(ElementName = "PROXNUMRPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumrpa
        {
            get { return  proxnumrpa; }
            set {  proxnumrpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMSIMULACAOPCP
        /// Comentário: 
        /// </summary>
        private decimal proxnumsimulacaopcp;
        [XmlElement(ElementName = "PROXNUMSIMULACAOPCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumsimulacaopcp
        {
            get { return  proxnumsimulacaopcp; }
            set {  proxnumsimulacaopcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTIRA
        /// Comentário: 
        /// </summary>
        private decimal proxnumtira;
        [XmlElement(ElementName = "PROXNUMTIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumtira
        {
            get { return  proxnumtira; }
            set {  proxnumtira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANS
        /// Comentário: 
        /// </summary>
        private decimal proxnumtrans;
        [XmlElement(ElementName = "PROXNUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtrans
        {
            get { return  proxnumtrans; }
            set {  proxnumtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSAVULSA
        /// Comentário: 
        /// </summary>
        private decimal proxnumtransavulsa;
        [XmlElement(ElementName = "PROXNUMTRANSAVULSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtransavulsa
        {
            get { return  proxnumtransavulsa; }
            set {  proxnumtransavulsa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSCRFOR
        /// Comentário: 
        /// </summary>
        private decimal proxnumtranscrfor;
        [XmlElement(ElementName = "PROXNUMTRANSCRFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumtranscrfor
        {
            get { return  proxnumtranscrfor; }
            set {  proxnumtranscrfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal proxnumtransent;
        [XmlElement(ElementName = "PROXNUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtransent
        {
            get { return  proxnumtransent; }
            set {  proxnumtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSOP
        /// Comentário: 
        /// </summary>
        private decimal proxnumtransop;
        [XmlElement(ElementName = "PROXNUMTRANSOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtransop
        {
            get { return  proxnumtransop; }
            set {  proxnumtransop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal proxnumtransvenda;
        [XmlElement(ElementName = "PROXNUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtransvenda
        {
            get { return  proxnumtransvenda; }
            set {  proxnumtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSVENDOR
        /// Comentário: 
        /// </summary>
        private decimal proxnumtransvendor;
        [XmlElement(ElementName = "PROXNUMTRANSVENDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumtransvendor
        {
            get { return  proxnumtransvendor; }
            set {  proxnumtransvendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSWMS
        /// Comentário: 
        /// </summary>
        private decimal proxnumtranswms;
        [XmlElement(ElementName = "PROXNUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtranswms
        {
            get { return  proxnumtranswms; }
            set {  proxnumtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTROCA
        /// Comentário: 
        /// </summary>
        private decimal proxnumtroca;
        [XmlElement(ElementName = "PROXNUMTROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumtroca
        {
            get { return  proxnumtroca; }
            set {  proxnumtroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMVALE
        /// Comentário: 
        /// </summary>
        private decimal proxnumvale;
        [XmlElement(ElementName = "PROXNUMVALE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxnumvale
        {
            get { return  proxnumvale; }
            set {  proxnumvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMVERBA
        /// Comentário: 
        /// </summary>
        private decimal proxnumverba;
        [XmlElement(ElementName = "PROXNUMVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumverba
        {
            get { return  proxnumverba; }
            set {  proxnumverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCHDVBLOQCLI
        /// Comentário: 
        /// </summary>
        private decimal qtchdvbloqcli;
        [XmlElement(ElementName = "QTCHDVBLOQCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtchdvbloqcli
        {
            get { return  qtchdvbloqcli; }
            set {  qtchdvbloqcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEGERLIVRO
        /// Comentário: 
        /// </summary>
        private decimal qtdegerlivro;
        [XmlElement(ElementName = "QTDEGERLIVRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtdegerlivro
        {
            get { return  qtdegerlivro; }
            set {  qtdegerlivro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMINIMAUSOASTERISCO936
        /// Comentário: 
        /// </summary>
        private decimal qtdeminimausoasterisco936;
        [XmlElement(ElementName = "QTDEMINIMAUSOASTERISCO936", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdeminimausoasterisco936
        {
            get { return  qtdeminimausoasterisco936; }
            set {  qtdeminimausoasterisco936 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEPARCELASIMPOSTOSFRETE
        /// Comentário: Indica a quantidade de parcelas para lançar impostos e frete. 
        /// </summary>
        private decimal qtdeparcelasimpostosfrete;
        [XmlElement(ElementName = "QTDEPARCELASIMPOSTOSFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtdeparcelasimpostosfrete
        {
            get { return  qtdeparcelasimpostosfrete; }
            set {  qtdeparcelasimpostosfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXUNIDADEPF
        /// Comentário: 
        /// </summary>
        private decimal qtmaxunidadepf;
        [XmlElement(ElementName = "QTMAXUNIDADEPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtmaxunidadepf
        {
            get { return  qtmaxunidadepf; }
            set {  qtmaxunidadepf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMESESCLASSESTRELAS
        /// Comentário: Indica a quantidade de meses anteriores para classificar estrelas. 
        /// </summary>
        private decimal qtmesesclassestrelas;
        [XmlElement(ElementName = "QTMESESCLASSESTRELAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtmesesclassestrelas
        {
            get { return  qtmesesclassestrelas; }
            set {  qtmesesclassestrelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMESESCLASSGRUPOCARTAO
        /// Comentário: 
        /// </summary>
        private decimal qtmesesclassgrupocartao;
        [XmlElement(ElementName = "QTMESESCLASSGRUPOCARTAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtmesesclassgrupocartao
        {
            get { return  qtmesesclassgrupocartao; }
            set {  qtmesesclassgrupocartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMESESCREDCIAP
        /// Comentário: Indica Qtde de meses p/ CIAP. 
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
        /// Propriedade referente ao campo: QTMESESGRUPOS
        /// Comentário: Indica a quantidade de meses que o cliente permanece no mesmo grupo. 
        /// </summary>
        private decimal qtmesesgrupos;
        [XmlElement(ElementName = "QTMESESGRUPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtmesesgrupos
        {
            get { return  qtmesesgrupos; }
            set {  qtmesesgrupos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RATEIODESCBAIXACR
        /// Comentário: 
        /// </summary>
        private string rateiodescbaixacr;
        [XmlElement(ElementName = "RATEIODESCBAIXACR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rateiodescbaixacr
        {
            get { return  rateiodescbaixacr; }
            set {  rateiodescbaixacr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REBAIXACUSTOCOMDESCFIN
        /// Comentário: 
        /// </summary>
        private string rebaixacustocomdescfin;
        [XmlElement(ElementName = "REBAIXACUSTOCOMDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rebaixacustocomdescfin
        {
            get { return  rebaixacustocomdescfin; }
            set {  rebaixacustocomdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REBAIXACUSTOULTENT
        /// Comentário: 
        /// </summary>
        private string rebaixacustoultent;
        [XmlElement(ElementName = "REBAIXACUSTOULTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rebaixacustoultent
        {
            get { return  rebaixacustoultent; }
            set {  rebaixacustoultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDUCAOBCISENTA
        /// Comentário: Considerar Reducao da Base de Calculo como Isenta.
        /// </summary>
        private string reducaobcisenta;
        [XmlElement(ElementName = "REDUCAOBCISENTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reducaobcisenta
        {
            get { return  reducaobcisenta; }
            set {  reducaobcisenta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRINGENUMITENSNF
        /// Comentário: 
        /// </summary>
        private string restringenumitensnf;
        [XmlElement(ElementName = "RESTRINGENUMITENSNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restringenumitensnf
        {
            get { return  restringenumitensnf; }
            set {  restringenumitensnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRINGENUMVIASNF
        /// Comentário: 
        /// </summary>
        private string restringenumviasnf;
        [XmlElement(ElementName = "RESTRINGENUMVIASNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restringenumviasnf
        {
            get { return  restringenumviasnf; }
            set {  restringenumviasnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRINGENUMVIASPU
        /// Comentário: 
        /// </summary>
        private string restringenumviaspu;
        [XmlElement(ElementName = "RESTRINGENUMVIASPU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restringenumviaspu
        {
            get { return  restringenumviaspu; }
            set {  restringenumviaspu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRINGIRCONFERENCIALOTE
        /// Comentário: Restringir checkout pedido.
        /// </summary>
        private string restringirconferencialote;
        [XmlElement(ElementName = "RESTRINGIRCONFERENCIALOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Restringirconferencialote
        {
            get { return  restringirconferencialote; }
            set {  restringirconferencialote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA2562EMUSO
        /// Comentário: Utilizado para determinar a quantidade de usuários utilizando 2562. 
        /// </summary>
        private decimal rotina2562emuso;
        [XmlElement(ElementName = "ROTINA2562EMUSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Rotina2562emuso
        {
            get { return  rotina2562emuso; }
            set {  rotina2562emuso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALTARPAGINARUA
        /// Comentário: 
        /// </summary>
        private string saltarpaginarua;
        [XmlElement(ElementName = "SALTARPAGINARUA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Saltarpaginarua
        {
            get { return  saltarpaginarua; }
            set {  saltarpaginarua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGMENTOSERASA
        /// Comentário: 
        /// </summary>
        private decimal segmentoserasa;
        [XmlElement(ElementName = "SEGMENTOSERASA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Segmentoserasa
        {
            get { return  segmentoserasa; }
            set {  segmentoserasa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMPREATUALIZAQTESTCONVEMB
        /// Comentário: Indica que na conversão entre embalagens, sempre atualizar QtEst. 
        /// </summary>
        private string sempreatualizaqtestconvemb;
        [XmlElement(ElementName = "SEMPREATUALIZAQTESTCONVEMB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sempreatualizaqtestconvemb
        {
            get { return  sempreatualizaqtestconvemb; }
            set {  sempreatualizaqtestconvemb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHALOGON
        /// Comentário: 
        /// </summary>
        private string senhalogon;
        [XmlElement(ElementName = "SENHALOGON", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Senhalogon
        {
            get { return  senhalogon; }
            set {  senhalogon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARACAOFLOWRACK
        /// Comentário: 
        /// </summary>
        private string separacaoflowrack;
        [XmlElement(ElementName = "SEPARACAOFLOWRACK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separacaoflowrack
        {
            get { return  separacaoflowrack; }
            set {  separacaoflowrack = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARARPRODCOMRESTRICAOTRANSP
        /// Comentário: Indica se os produtos com restrição de transporte serão separados em um novo pedido. 
        /// </summary>
        private string separarprodcomrestricaotransp;
        [XmlElement(ElementName = "SEPARARPRODCOMRESTRICAOTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separarprodcomrestricaotransp
        {
            get { return  separarprodcomrestricaotransp; }
            set {  separarprodcomrestricaotransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLAESPECIE
        /// Comentário: 
        /// </summary>
        private string siglaespecie;
        [XmlElement(ElementName = "SIGLAESPECIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Siglaespecie
        {
            get { return  siglaespecie; }
            set {  siglaespecie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLASERIE
        /// Comentário: 
        /// </summary>
        private string siglaserie;
        [XmlElement(ElementName = "SIGLASERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Siglaserie
        {
            get { return  siglaserie; }
            set {  siglaserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOINICIALBLOQUEIO
        /// Comentário: Indica se a situação inicial do cliente será (N)¿Desbloqueado ou (S)¿Bloqueado.
        /// </summary>
        private string situacaoinicialbloqueio;
        [XmlElement(ElementName = "SITUACAOINICIALBLOQUEIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacaoinicialbloqueio
        {
            get { return  situacaoinicialbloqueio; }
            set {  situacaoinicialbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMACOMISSAOCMV
        /// Comentário: 
        /// </summary>
        private string somacomissaocmv;
        [XmlElement(ElementName = "SOMACOMISSAOCMV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somacomissaocmv
        {
            get { return  somacomissaocmv; }
            set {  somacomissaocmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMACOMPRAPREVFLUXOCX
        /// Comentário: 
        /// </summary>
        private string somacompraprevfluxocx;
        [XmlElement(ElementName = "SOMACOMPRAPREVFLUXOCX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somacompraprevfluxocx
        {
            get { return  somacompraprevfluxocx; }
            set {  somacompraprevfluxocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMADESCCLIDESCPROD
        /// Comentário: 
        /// </summary>
        private string somadescclidescprod;
        [XmlElement(ElementName = "SOMADESCCLIDESCPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somadescclidescprod
        {
            get { return  somadescclidescprod; }
            set {  somadescclidescprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMADESPFINITEMCF
        /// Comentário: 
        /// </summary>
        private string somadespfinitemcf;
        [XmlElement(ElementName = "SOMADESPFINITEMCF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somadespfinitemcf
        {
            get { return  somadespfinitemcf; }
            set {  somadespfinitemcf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMAICMSANTECIPDUPLIC
        /// Comentário: 
        /// </summary>
        private string somaicmsantecipduplic;
        [XmlElement(ElementName = "SOMAICMSANTECIPDUPLIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somaicmsantecipduplic
        {
            get { return  somaicmsantecipduplic; }
            set {  somaicmsantecipduplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMAIMPOSTOSTRANSF
        /// Comentário: 
        /// </summary>
        private string somaimpostostransf;
        [XmlElement(ElementName = "SOMAIMPOSTOSTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somaimpostostransf
        {
            get { return  somaimpostostransf; }
            set {  somaimpostostransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMAQTPEDVENDA
        /// Comentário: 
        /// </summary>
        private string somaqtpedvenda;
        [XmlElement(ElementName = "SOMAQTPEDVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somaqtpedvenda
        {
            get { return  somaqtpedvenda; }
            set {  somaqtpedvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMATARIFABANCDUPLIC
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: SOMATXBOLETO
        /// Comentário: Indica que o valor da tarifa será somado ao valor do boleto na Cobrança Magnética. 
        /// </summary>
        private string somatxboleto;
        [XmlElement(ElementName = "SOMATXBOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somatxboleto
        {
            get { return  somatxboleto; }
            set {  somatxboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMAVLTARIFAITENSNF
        /// Comentário: 
        /// </summary>
        private string somavltarifaitensnf;
        [XmlElement(ElementName = "SOMAVLTARIFAITENSNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somavltarifaitensnf
        {
            get { return  somavltarifaitensnf; }
            set {  somavltarifaitensnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMENTECODBARRASBONUS
        /// Comentário: 
        /// </summary>
        private string somentecodbarrasbonus;
        [XmlElement(ElementName = "SOMENTECODBARRASBONUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somentecodbarrasbonus
        {
            get { return  somentecodbarrasbonus; }
            set {  somentecodbarrasbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMENTECODBARRASCONFPED
        /// Comentário: 
        /// </summary>
        private string somentecodbarrasconfped;
        [XmlElement(ElementName = "SOMENTECODBARRASCONFPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somentecodbarrasconfped
        {
            get { return  somentecodbarrasconfped; }
            set {  somentecodbarrasconfped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUGVENDA
        /// Comentário: 
        /// </summary>
        private decimal sugvenda;
        [XmlElement(ElementName = "SUGVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Sugvenda
        {
            get { return  sugvenda; }
            set {  sugvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TARJAMAGNETICAOBRIGATORIA
        /// Comentário: 
        /// </summary>
        private string tarjamagneticaobrigatoria;
        [XmlElement(ElementName = "TARJAMAGNETICAOBRIGATORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tarjamagneticaobrigatoria
        {
            get { return  tarjamagneticaobrigatoria; }
            set {  tarjamagneticaobrigatoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXATABPR
        /// Comentário: 
        /// </summary>
        private string taxatabpr;
        [XmlElement(ElementName = "TAXATABPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Taxatabpr
        {
            get { return  taxatabpr; }
            set {  taxatabpr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA0
        /// Comentário: 
        /// </summary>
        private decimal taxa0;
        [XmlElement(ElementName = "TAXA0", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa0
        {
            get { return  taxa0; }
            set {  taxa0 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA14
        /// Comentário: 
        /// </summary>
        private decimal taxa14;
        [XmlElement(ElementName = "TAXA14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa14
        {
            get { return  taxa14; }
            set {  taxa14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA21
        /// Comentário: 
        /// </summary>
        private decimal taxa21;
        [XmlElement(ElementName = "TAXA21", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa21
        {
            get { return  taxa21; }
            set {  taxa21 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA28
        /// Comentário: 
        /// </summary>
        private decimal taxa28;
        [XmlElement(ElementName = "TAXA28", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa28
        {
            get { return  taxa28; }
            set {  taxa28 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA35
        /// Comentário: 
        /// </summary>
        private decimal taxa35;
        [XmlElement(ElementName = "TAXA35", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa35
        {
            get { return  taxa35; }
            set {  taxa35 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA42
        /// Comentário: 
        /// </summary>
        private decimal taxa42;
        [XmlElement(ElementName = "TAXA42", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa42
        {
            get { return  taxa42; }
            set {  taxa42 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA7
        /// Comentário: 
        /// </summary>
        private decimal taxa7;
        [XmlElement(ElementName = "TAXA7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa7
        {
            get { return  taxa7; }
            set {  taxa7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Comentário: 
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPMENFLOW
        /// Comentário: Indica o tempo de mensagem do Flow Rack (em segundos). 
        /// </summary>
        private decimal tempmenflow;
        [XmlElement(ElementName = "TEMPMENFLOW", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Tempmenflow
        {
            get { return  tempmenflow; }
            set {  tempmenflow = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOMAXCANCEL
        /// Comentário: 
        /// </summary>
        private string tempomaxcancel;
        [XmlElement(ElementName = "TEMPOMAXCANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tempomaxcancel
        {
            get { return  tempomaxcancel; }
            set {  tempomaxcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMREPOS
        /// Comentário: 
        /// </summary>
        private decimal temrepos;
        [XmlElement(ElementName = "TEMREPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Temrepos
        {
            get { return  temrepos; }
            set {  temrepos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIMERMSGAGENDA
        /// Comentário: Indica o timporizador da agenda.
        /// </summary>
        private decimal timermsgagenda;
        [XmlElement(ElementName = "TIMERMSGAGENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Timermsgagenda
        {
            get { return  timermsgagenda; }
            set {  timermsgagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOABASPREV
        /// Comentário: 
        /// </summary>
        private string tipoabasprev;
        [XmlElement(ElementName = "TIPOABASPREV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoabasprev
        {
            get { return  tipoabasprev; }
            set {  tipoabasprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOALIQOUTRASDESP
        /// Comentário: 
        /// </summary>
        private string tipoaliqoutrasdesp;
        [XmlElement(ElementName = "TIPOALIQOUTRASDESP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoaliqoutrasdesp
        {
            get { return  tipoaliqoutrasdesp; }
            set {  tipoaliqoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAPLICINDICE
        /// Comentário: 
        /// </summary>
        private string tipoaplicindice;
        [XmlElement(ElementName = "TIPOAPLICINDICE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoaplicindice
        {
            get { return  tipoaplicindice; }
            set {  tipoaplicindice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAPLICREPASSE
        /// Comentário: 
        /// </summary>
        private string tipoaplicrepasse;
        [XmlElement(ElementName = "TIPOAPLICREPASSE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoaplicrepasse
        {
            get { return  tipoaplicrepasse; }
            set {  tipoaplicrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBAIXACOBMAG
        /// Comentário: 
        /// </summary>
        private decimal tipobaixacobmag;
        [XmlElement(ElementName = "TIPOBAIXACOBMAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipobaixacobmag
        {
            get { return  tipobaixacobmag; }
            set {  tipobaixacobmag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCDESCARGAPAL
        /// Comentário: Tipo de Cálculo de Descarga Paletizada. T=Peso Total, P=Quantidade de Paletes.
        /// </summary>
        private string tipocalcdescargapal;
        [XmlElement(ElementName = "TIPOCALCDESCARGAPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalcdescargapal
        {
            get { return  tipocalcdescargapal; }
            set {  tipocalcdescargapal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCGIRODIA
        /// Comentário: 
        /// </summary>
        private string tipocalcgirodia;
        [XmlElement(ElementName = "TIPOCALCGIRODIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocalcgirodia
        {
            get { return  tipocalcgirodia; }
            set {  tipocalcgirodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCIPI
        /// Comentário: 
        /// </summary>
        private string tipocalcipi;
        [XmlElement(ElementName = "TIPOCALCIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocalcipi
        {
            get { return  tipocalcipi; }
            set {  tipocalcipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCST
        /// Comentário: 
        /// </summary>
        private string tipocalcst;
        [XmlElement(ElementName = "TIPOCALCST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocalcst
        {
            get { return  tipocalcst; }
            set {  tipocalcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCSULFRAMA
        /// Comentário: 
        /// </summary>
        private string tipocalcsulframa;
        [XmlElement(ElementName = "TIPOCALCSULFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocalcsulframa
        {
            get { return  tipocalcsulframa; }
            set {  tipocalcsulframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCUSTOAJUSTE
        /// Comentário: 
        /// </summary>
        private string tipocustoajuste;
        [XmlElement(ElementName = "TIPOCUSTOAJUSTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocustoajuste
        {
            get { return  tipocustoajuste; }
            set {  tipocustoajuste = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCUSTOTRANSF
        /// Comentário: 
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
        /// Propriedade referente ao campo: TIPOCUSTO1322
        /// Comentário: Identifica o custo utilizado na rotina 1322, que pode ser: C-Custo de Resposição, V-Preço de Venda, R-Custo Real, F-Custo Financeiro, T-Custo Contábil.
        /// </summary>
        private string tipocusto1322;
        [XmlElement(ElementName = "TIPOCUSTO1322", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocusto1322
        {
            get { return  tipocusto1322; }
            set {  tipocusto1322 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEM
        /// Comentário: 
        /// </summary>
        private string tipoembalagem;
        [XmlElement(ElementName = "TIPOEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagem
        {
            get { return  tipoembalagem; }
            set {  tipoembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENDERECAMENTO
        /// Comentário: 
        /// </summary>
        private string tipoenderecamento;
        [XmlElement(ElementName = "TIPOENDERECAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoenderecamento
        {
            get { return  tipoenderecamento; }
            set {  tipoenderecamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENTREGAPADRAOCALLCENTER
        /// Comentário: 
        /// </summary>
        private string tipoentregapadraocallcenter;
        [XmlElement(ElementName = "TIPOENTREGAPADRAOCALLCENTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoentregapadraocallcenter
        {
            get { return  tipoentregapadraocallcenter; }
            set {  tipoentregapadraocallcenter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOGERACAODADOSPCAUXPRO
        /// Comentário: 
        /// </summary>
        private string tipogeracaodadospcauxpro;
        [XmlElement(ElementName = "TIPOGERACAODADOSPCAUXPRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipogeracaodadospcauxpro
        {
            get { return  tipogeracaodadospcauxpro; }
            set {  tipogeracaodadospcauxpro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINTEGRACAO
        /// Comentário: Indica o tipo da integração.
        /// </summary>
        private string tipointegracao;
        [XmlElement(ElementName = "TIPOINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipointegracao
        {
            get { return  tipointegracao; }
            set {  tipointegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMAPAWMSVENDABALCAO
        /// Comentário: 
        /// </summary>
        private string tipomapawmsvendabalcao;
        [XmlElement(ElementName = "TIPOMAPAWMSVENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipomapawmsvendabalcao
        {
            get { return  tipomapawmsvendabalcao; }
            set {  tipomapawmsvendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMASCARAENDERWMS
        /// Comentário: Indica o tipo da máscara de endereçamento do WMS.
        /// </summary>
        private decimal tipomascaraenderwms;
        [XmlElement(ElementName = "TIPOMASCARAENDERWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipomascaraenderwms
        {
            get { return  tipomascaraenderwms; }
            set {  tipomascaraenderwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOVCCRCA
        /// Comentário: Indica o tipo de movimentação de contacorrente de RCA.
        /// </summary>
        private string tipomovccrca;
        [XmlElement(ElementName = "TIPOMOVCCRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomovccrca
        {
            get { return  tipomovccrca; }
            set {  tipomovccrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPONUMNFENTRADA
        /// Comentário: 
        /// </summary>
        private string tiponumnfentrada;
        [XmlElement(ElementName = "TIPONUMNFENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiponumnfentrada
        {
            get { return  tiponumnfentrada; }
            set {  tiponumnfentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOORDENACAONFSAIDA
        /// Comentário: . 
        /// </summary>
        private string tipoordenacaonfsaida;
        [XmlElement(ElementName = "TIPOORDENACAONFSAIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoordenacaonfsaida
        {
            get { return  tipoordenacaonfsaida; }
            set {  tipoordenacaonfsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPERIODOGIRODIA
        /// Comentário: 
        /// </summary>
        private string tipoperiodogirodia;
        [XmlElement(ElementName = "TIPOPERIODOGIRODIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoperiodogirodia
        {
            get { return  tipoperiodogirodia; }
            set {  tipoperiodogirodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORELMAPA
        /// Comentário: 
        /// </summary>
        private string tiporelmapa;
        [XmlElement(ElementName = "TIPORELMAPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiporelmapa
        {
            get { return  tiporelmapa; }
            set {  tiporelmapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTAXAVENDOR
        /// Comentário: 
        /// </summary>
        private string tipotaxavendor;
        [XmlElement(ElementName = "TIPOTAXAVENDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotaxavendor
        {
            get { return  tipotaxavendor; }
            set {  tipotaxavendor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTITULOSECF402
        /// Comentário: Indica a origem do título exibidos na 402: 1) Ambos 2) 2075 3) 306.
        /// </summary>
        private string tipotitulosecf402;
        [XmlElement(ElementName = "TIPOTITULOSECF402", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotitulosecf402
        {
            get { return  tipotitulosecf402; }
            set {  tipotitulosecf402 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTITULOSECF409
        /// Comentário: Indica a origem do título exibidos na 409: 1) Ambos 2) 2075 3) 306.
        /// </summary>
        private string tipotitulosecf409;
        [XmlElement(ElementName = "TIPOTITULOSECF409", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotitulosecf409
        {
            get { return  tipotitulosecf409; }
            set {  tipotitulosecf409 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTXBOLETO
        /// Comentário: 
        /// </summary>
        private string tipotxboleto;
        [XmlElement(ElementName = "TIPOTXBOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotxboleto
        {
            get { return  tipotxboleto; }
            set {  tipotxboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALORGIRODIA
        /// Comentário: 
        /// </summary>
        private string tipovalorgirodia;
        [XmlElement(ElementName = "TIPOVALORGIRODIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalorgirodia
        {
            get { return  tipovalorgirodia; }
            set {  tipovalorgirodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVLMINVENDABK
        /// Comentário: 
        /// </summary>
        private string tipovlminvendabk;
        [XmlElement(ElementName = "TIPOVLMINVENDABK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovlminvendabk
        {
            get { return  tipovlminvendabk; }
            set {  tipovlminvendabk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRATARRESTRICAOACRESCIMO
        /// Comentário: Caso esteja como S-Sim, então deverá ser feita uma validação em separado das políticas de desconto cadastradas com o %desc positivo 
        /// </summary>
        private string tratarrestricaoacrescimo;
        [XmlElement(ElementName = "TRATARRESTRICAOACRESCIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tratarrestricaoacrescimo
        {
            get { return  tratarrestricaoacrescimo; }
            set {  tratarrestricaoacrescimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRAVAVENDAPF
        /// Comentário: Travar Venda para Pessoa Física|Parametrizado na rotina 132 - Parametros da Presidencia
        /// </summary>
        private string travavendapf;
        [XmlElement(ElementName = "TRAVAVENDAPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Travavendapf
        {
            get { return  travavendapf; }
            set {  travavendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRIBUTAFRETERATEADO
        /// Comentário: Indica se tributa frete rateado.
        /// </summary>
        private string tributafreterateado;
        [XmlElement(ElementName = "TRIBUTAFRETERATEADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tributafreterateado
        {
            get { return  tributafreterateado; }
            set {  tributafreterateado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TROCAALTDEBCREDRCA
        /// Comentário: . 
        /// </summary>
        private string trocaaltdebcredrca;
        [XmlElement(ElementName = "TROCAALTDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Trocaaltdebcredrca
        {
            get { return  trocaaltdebcredrca; }
            set {  trocaaltdebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TX
        /// Comentário: 
        /// </summary>
        private decimal tx;
        [XmlElement(ElementName = "TX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Tx
        {
            get { return  tx; }
            set {  tx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXIOF
        /// Comentário: 
        /// </summary>
        private decimal txiof;
        [XmlElement(ElementName = "TXIOF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Txiof
        {
            get { return  txiof; }
            set {  txiof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXIOFCOMPLEMENTAR
        /// Comentário: IOF Complementar
        /// </summary>
        private decimal txiofcomplementar;
        [XmlElement(ElementName = "TXIOFCOMPLEMENTAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Txiofcomplementar
        {
            get { return  txiofcomplementar; }
            set {  txiofcomplementar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDA
        /// Comentário: 
        /// </summary>
        private decimal txvenda;
        [XmlElement(ElementName = "TXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Txvenda
        {
            get { return  txvenda; }
            set {  txvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDORCLI
        /// Comentário: 
        /// </summary>
        private decimal txvendorcli;
        [XmlElement(ElementName = "TXVENDORCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Txvendorcli
        {
            get { return  txvendorcli; }
            set {  txvendorcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ULTNUMDATACHEQ
        /// Comentário: Indica a ultima atualização do DataCheq.
        /// </summary>
        private DateTime? ultnumdatacheq;
        [XmlElement(ElementName = "ULTNUMDATACHEQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Ultnumdatacheq
        {
            get { return  ultnumdatacheq; }
            set {  ultnumdatacheq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UPDATEAUTMENU
        /// Comentário: 
        /// </summary>
        private string updateautmenu;
        [XmlElement(ElementName = "UPDATEAUTMENU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,31)]
        public string Updateautmenu
        {
            get { return  updateautmenu; }
            set {  updateautmenu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USABCRENT
        /// Comentário: 
        /// </summary>
        private string usabcrent;
        [XmlElement(ElementName = "USABCRENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usabcrent
        {
            get { return  usabcrent; }
            set {  usabcrent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACANCELAMENTOAUTOMATICOECF
        /// Comentário: 
        /// </summary>
        private string usacancelamentoautomaticoecf;
        [XmlElement(ElementName = "USACANCELAMENTOAUTOMATICOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacancelamentoautomaticoecf
        {
            get { return  usacancelamentoautomaticoecf; }
            set {  usacancelamentoautomaticoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACATEGORIA
        /// Comentário: 
        /// </summary>
        private string usacategoria;
        [XmlElement(ElementName = "USACATEGORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacategoria
        {
            get { return  usacategoria; }
            set {  usacategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACESTABASICACF
        /// Comentário: Indica se aceita venda de Cesta Básica em Cupons Fiscais.
        /// </summary>
        private string usacestabasicacf;
        [XmlElement(ElementName = "USACESTABASICACF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacestabasicacf
        {
            get { return  usacestabasicacf; }
            set {  usacestabasicacf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACHAVETRIPLAPCPEDI
        /// Comentário: 
        /// </summary>
        private string usachavetriplapcpedi;
        [XmlElement(ElementName = "USACHAVETRIPLAPCPEDI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usachavetriplapcpedi
        {
            get { return  usachavetriplapcpedi; }
            set {  usachavetriplapcpedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMISSAOECF
        /// Comentário: 
        /// </summary>
        private string usacomissaoecf;
        [XmlElement(ElementName = "USACOMISSAOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomissaoecf
        {
            get { return  usacomissaoecf; }
            set {  usacomissaoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMISSAOPORCLASSE
        /// Comentário: Indica se será usado comissão de produtos por classe (letra). 
        /// </summary>
        private string usacomissaoporclasse;
        [XmlElement(ElementName = "USACOMISSAOPORCLASSE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomissaoporclasse
        {
            get { return  usacomissaoporclasse; }
            set {  usacomissaoporclasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMISSAOPORCLIENTE
        /// Comentário: 
        /// </summary>
        private string usacomissaoporcliente;
        [XmlElement(ElementName = "USACOMISSAOPORCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomissaoporcliente
        {
            get { return  usacomissaoporcliente; }
            set {  usacomissaoporcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMISSAOPORLINHAPROD
        /// Comentário: 
        /// </summary>
        private string usacomissaoporlinhaprod;
        [XmlElement(ElementName = "USACOMISSAOPORLINHAPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomissaoporlinhaprod
        {
            get { return  usacomissaoporlinhaprod; }
            set {  usacomissaoporlinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMISSAOPORRCA
        /// Comentário: 
        /// </summary>
        private string usacomissaoporrca;
        [XmlElement(ElementName = "USACOMISSAOPORRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomissaoporrca
        {
            get { return  usacomissaoporrca; }
            set {  usacomissaoporrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONTROLEDERECIBOS
        /// Comentário: Indica se o cliente utiliza controle de recibo na Baixa de Títulos.
        /// </summary>
        private string usacontrolederecibos;
        [XmlElement(ElementName = "USACONTROLEDERECIBOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacontrolederecibos
        {
            get { return  usacontrolederecibos; }
            set {  usacontrolederecibos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONTROLEEMISSAONF
        /// Comentário: 
        /// </summary>
        private string usacontroleemissaonf;
        [XmlElement(ElementName = "USACONTROLEEMISSAONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacontroleemissaonf
        {
            get { return  usacontroleemissaonf; }
            set {  usacontroleemissaonf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONTROLEFORNECPEDCOMPRA
        /// Comentário: 
        /// </summary>
        private string usacontrolefornecpedcompra;
        [XmlElement(ElementName = "USACONTROLEFORNECPEDCOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacontrolefornecpedcompra
        {
            get { return  usacontrolefornecpedcompra; }
            set {  usacontrolefornecpedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONTROLETIPOVERBA
        /// Comentário: Indica se utiliza o controle de tipo de verba ao invés de contas fixas.
        /// </summary>
        private string usacontroletipoverba;
        [XmlElement(ElementName = "USACONTROLETIPOVERBA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacontroletipoverba
        {
            get { return  usacontroletipoverba; }
            set {  usacontroletipoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONVERSAOEMBALAGEM
        /// Comentário: 
        /// </summary>
        private string usaconversaoembalagem;
        [XmlElement(ElementName = "USACONVERSAOEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaconversaoembalagem
        {
            get { return  usaconversaoembalagem; }
            set {  usaconversaoembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACRECLIVENDABALCAO
        /// Comentário: 
        /// </summary>
        private string usacreclivendabalcao;
        [XmlElement(ElementName = "USACRECLIVENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacreclivendabalcao
        {
            get { return  usacreclivendabalcao; }
            set {  usacreclivendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACRECLIVENDATLMKT
        /// Comentário: 
        /// </summary>
        private string usacreclivendatlmkt;
        [XmlElement(ElementName = "USACRECLIVENDATLMKT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacreclivendatlmkt
        {
            get { return  usacreclivendatlmkt; }
            set {  usacreclivendatlmkt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACREDCLITODASFILIAIS
        /// Comentário: Indica se utiliza credito de cliente em todas as filiais.
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
        /// Propriedade referente ao campo: USACREDRCA
        /// Comentário: 
        /// </summary>
        private string usacredrca;
        [XmlElement(ElementName = "USACREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacredrca
        {
            get { return  usacredrca; }
            set {  usacredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCPORLINHAPROD
        /// Comentário: 
        /// </summary>
        private string usadescporlinhaprod;
        [XmlElement(ElementName = "USADESCPORLINHAPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescporlinhaprod
        {
            get { return  usadescporlinhaprod; }
            set {  usadescporlinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCPORQUANT
        /// Comentário: 
        /// </summary>
        private string usadescporquant;
        [XmlElement(ElementName = "USADESCPORQUANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescporquant
        {
            get { return  usadescporquant; }
            set {  usadescporquant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADTDESBLOQUEIOBLOQCLIINATIV
        /// Comentário: Indica a utilização da Data de Desbloqueio do Cliente na opção [Bloqueia Clientes Inativos a mais de XXX Dias] na rotina [504 - Atualização Diária I]. 
        /// </summary>
        private string usadtdesbloqueiobloqcliinativ;
        [XmlElement(ElementName = "USADTDESBLOQUEIOBLOQCLIINATIV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadtdesbloqueiobloqcliinativ
        {
            get { return  usadtdesbloqueiobloqcliinativ; }
            set {  usadtdesbloqueiobloqcliinativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADVPRODUTO
        /// Comentário: 
        /// </summary>
        private string usadvproduto;
        [XmlElement(ElementName = "USADVPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadvproduto
        {
            get { return  usadvproduto; }
            set {  usadvproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAESTOQUEDEPFECHADO
        /// Comentário: 
        /// </summary>
        private string usaestoquedepfechado;
        [XmlElement(ElementName = "USAESTOQUEDEPFECHADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaestoquedepfechado
        {
            get { return  usaestoquedepfechado; }
            set {  usaestoquedepfechado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAFECHAMENTOCXCEGO
        /// Comentário: Indica uso do Fechamento de Caixa Cego no Auto Serviço. 
        /// </summary>
        private string usafechamentocxcego;
        [XmlElement(ElementName = "USAFECHAMENTOCXCEGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usafechamentocxcego
        {
            get { return  usafechamentocxcego; }
            set {  usafechamentocxcego = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAFLUIG
        /// Comentário: 
        /// </summary>
        private string usafluig;
        [XmlElement(ElementName = "USAFLUIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usafluig
        {
            get { return  usafluig; }
            set {  usafluig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAICMSANTECIPPVENDA
        /// Comentário: 
        /// </summary>
        private string usaicmsantecippvenda;
        [XmlElement(ElementName = "USAICMSANTECIPPVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaicmsantecippvenda
        {
            get { return  usaicmsantecippvenda; }
            set {  usaicmsantecippvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USALIMCREDCPF
        /// Comentário: Indica o limite de crédito por CNPJ/CPF.
        /// </summary>
        private string usalimcredcpf;
        [XmlElement(ElementName = "USALIMCREDCPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usalimcredcpf
        {
            get { return  usalimcredcpf; }
            set {  usalimcredcpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAMAPSEPRUA
        /// Comentário: 
        /// </summary>
        private string usamapseprua;
        [XmlElement(ElementName = "USAMAPSEPRUA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usamapseprua
        {
            get { return  usamapseprua; }
            set {  usamapseprua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAMARCAPRODUTOS
        /// Comentário: Indica se utiliza marca de produto.
        /// </summary>
        private string usamarcaprodutos;
        [XmlElement(ElementName = "USAMARCAPRODUTOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usamarcaprodutos
        {
            get { return  usamarcaprodutos; }
            set {  usamarcaprodutos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANEGFORNEC
        /// Comentário: 
        /// </summary>
        private string usanegfornec;
        [XmlElement(ElementName = "USANEGFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanegfornec
        {
            get { return  usanegfornec; }
            set {  usanegfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANFCOMPLEMENTARBK
        /// Comentário: 
        /// </summary>
        private string usanfcomplementarbk;
        [XmlElement(ElementName = "USANFCOMPLEMENTARBK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanfcomplementarbk
        {
            get { return  usanfcomplementarbk; }
            set {  usanfcomplementarbk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANUMCARVENDABALCAO
        /// Comentário: 
        /// </summary>
        private string usanumcarvendabalcao;
        [XmlElement(ElementName = "USANUMCARVENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanumcarvendabalcao
        {
            get { return  usanumcarvendabalcao; }
            set {  usanumcarvendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANUMNFDEVCLI
        /// Comentário: 
        /// </summary>
        private string usanumnfdevcli;
        [XmlElement(ElementName = "USANUMNFDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanumnfdevcli
        {
            get { return  usanumnfdevcli; }
            set {  usanumnfdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAOUTRASMOEDAS
        /// Comentário: 
        /// </summary>
        private string usaoutrasmoedas;
        [XmlElement(ElementName = "USAOUTRASMOEDAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaoutrasmoedas
        {
            get { return  usaoutrasmoedas; }
            set {  usaoutrasmoedas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCDIFQTENT
        /// Comentário: 
        /// </summary>
        private string usapercdifqtent;
        [XmlElement(ElementName = "USAPERCDIFQTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercdifqtent
        {
            get { return  usapercdifqtent; }
            set {  usapercdifqtent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPISCOFINSPORFILIAL
        /// Comentário: Indica se utiliza a tributação de PIS/COFINS por filial.
        /// </summary>
        private string usapiscofinsporfilial;
        [XmlElement(ElementName = "USAPISCOFINSPORFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapiscofinsporfilial
        {
            get { return  usapiscofinsporfilial; }
            set {  usapiscofinsporfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPOLITICADESENHA
        /// Comentário: Utiliza política de senha.
        /// </summary>
        private string usapoliticadesenha;
        [XmlElement(ElementName = "USAPOLITICADESENHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapoliticadesenha
        {
            get { return  usapoliticadesenha; }
            set {  usapoliticadesenha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPOSICAOCPAGAR
        /// Comentário: Quando tiver o valor "S", irá gravar PCLANC.INDICE = B em 631, 749 e 750.
        /// </summary>
        private string usaposicaocpagar;
        [XmlElement(ElementName = "USAPOSICAOCPAGAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaposicaocpagar
        {
            get { return  usaposicaocpagar; }
            set {  usaposicaocpagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPRECIFMENORMARGEMM
        /// Comentário: Indica se será informado o motivo da precificação com 
        /// </summary>
        private string usaprecifmenormargemm;
        [XmlElement(ElementName = "USAPRECIFMENORMARGEMM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaprecifmenormargemm
        {
            get { return  usaprecifmenormargemm; }
            set {  usaprecifmenormargemm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPRODFRACUNITARIO
        /// Comentário: Indica se altera layout de impressão de produtos fracionados para Cupons Fiscais.
        /// </summary>
        private string usaprodfracunitario;
        [XmlElement(ElementName = "USAPRODFRACUNITARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaprodfracunitario
        {
            get { return  usaprodfracunitario; }
            set {  usaprodfracunitario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPRZADICIONALVENDA
        /// Comentário: 
        /// </summary>
        private string usaprzadicionalvenda;
        [XmlElement(ElementName = "USAPRZADICIONALVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaprzadicionalvenda
        {
            get { return  usaprzadicionalvenda; }
            set {  usaprzadicionalvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPTABELACOMOBASE
        /// Comentário: Indica o uso do precço bruto como base para cálculo de débito/crédito de RCA nas vendas bonificadas. 
        /// </summary>
        private string usaptabelacomobase;
        [XmlElement(ElementName = "USAPTABELACOMOBASE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaptabelacomobase
        {
            get { return  usaptabelacomobase; }
            set {  usaptabelacomobase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARDESCONTOVENDACODBARRA
        /// Comentário: 
        /// </summary>
        private string usardescontovendacodbarra;
        [XmlElement(ElementName = "USARDESCONTOVENDACODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usardescontovendacodbarra
        {
            get { return  usardescontovendacodbarra; }
            set {  usardescontovendacodbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAREDUCAOCOMISSAORCA
        /// Comentário: 
        /// </summary>
        private string usareducaocomissaorca;
        [XmlElement(ElementName = "USAREDUCAOCOMISSAORCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usareducaocomissaorca
        {
            get { return  usareducaocomissaorca; }
            set {  usareducaocomissaorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARENDERFORNEC
        /// Comentário: Indica o uso de endereços por fornecedor.
        /// </summary>
        private string usarenderfornec;
        [XmlElement(ElementName = "USARENDERFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarenderfornec
        {
            get { return  usarenderfornec; }
            set {  usarenderfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARMOVIMENTAHORIZONTAL
        /// Comentário: 
        /// </summary>
        private string usarmovimentahorizontal;
        [XmlElement(ElementName = "USARMOVIMENTAHORIZONTAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarmovimentahorizontal
        {
            get { return  usarmovimentahorizontal; }
            set {  usarmovimentahorizontal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARREDUCAOICMSABATRANSF
        /// Comentário: Indica se utiliza redução de ICMS na venda TV10 da aba de transferência.
        /// </summary>
        private string usarreducaoicmsabatransf;
        [XmlElement(ElementName = "USARREDUCAOICMSABATRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarreducaoicmsabatransf
        {
            get { return  usarreducaoicmsabatransf; }
            set {  usarreducaoicmsabatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARSENHAEXPIRADA
        /// Comentário: Permitir entrar com a Senha Expirada|Parametrizado na rotina 132 - Parametros da Presidencia
        /// </summary>
        private string usarsenhaexpirada;
        [XmlElement(ElementName = "USARSENHAEXPIRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarsenhaexpirada
        {
            get { return  usarsenhaexpirada; }
            set {  usarsenhaexpirada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARTRIBUTACAOTRANSFTV10
        /// Comentário: Alterar o tratamento do tipo de venda 10, nos programas de venda 316/336/1400, para utilizar as alíquotas/taxas de transferência definidas no 514.
        /// </summary>
        private string usartributacaotransftv10;
        [XmlElement(ElementName = "USARTRIBUTACAOTRANSFTV10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usartributacaotransftv10
        {
            get { return  usartributacaotransftv10; }
            set {  usartributacaotransftv10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USASALDOCONTACORRENTEDESCFIN
        /// Comentário: Indica a utilização do saldo de conta corrente do RCA como Desconto Financeiro. 
        /// </summary>
        private string usasaldocontacorrentedescfin;
        [XmlElement(ElementName = "USASALDOCONTACORRENTEDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usasaldocontacorrentedescfin
        {
            get { return  usasaldocontacorrentedescfin; }
            set {  usasaldocontacorrentedescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USASEPARACAOCXFECHADA
        /// Comentário: 
        /// </summary>
        private string usaseparacaocxfechada;
        [XmlElement(ElementName = "USASEPARACAOCXFECHADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaseparacaocxfechada
        {
            get { return  usaseparacaocxfechada; }
            set {  usaseparacaocxfechada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATECLADOGERTEC
        /// Comentário: 
        /// </summary>
        private string usatecladogertec;
        [XmlElement(ElementName = "USATECLADOGERTEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatecladogertec
        {
            get { return  usatecladogertec; }
            set {  usatecladogertec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATRIBENTPORUF
        /// Comentário: 
        /// </summary>
        private string usatribentporuf;
        [XmlElement(ElementName = "USATRIBENTPORUF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatribentporuf
        {
            get { return  usatribentporuf; }
            set {  usatribentporuf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATRIBUTACAOPORUF
        /// Comentário: 
        /// </summary>
        private string usatributacaoporuf;
        [XmlElement(ElementName = "USATRIBUTACAOPORUF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatributacaoporuf
        {
            get { return  usatributacaoporuf; }
            set {  usatributacaoporuf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATROCACOMPRECOVENDA
        /// Comentário: Usa preço de venda para mercadorias a retirar nos tipos de venda 11 e 12. 
        /// </summary>
        private string usatrocacomprecovenda;
        [XmlElement(ElementName = "USATROCACOMPRECOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatrocacomprecovenda
        {
            get { return  usatrocacomprecovenda; }
            set {  usatrocacomprecovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVALORMEDIOENTRADA
        /// Comentário: 
        /// </summary>
        private string usavalormedioentrada;
        [XmlElement(ElementName = "USAVALORMEDIOENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usavalormedioentrada
        {
            get { return  usavalormedioentrada; }
            set {  usavalormedioentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVENDABALCAOCLIFILIALVIRTUAL
        /// Comentário: Indica se aceita venda balcão para cliente com filial virtual.
        /// </summary>
        private string usavendabalcaoclifilialvirtual;
        [XmlElement(ElementName = "USAVENDABALCAOCLIFILIALVIRTUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usavendabalcaoclifilialvirtual
        {
            get { return  usavendabalcaoclifilialvirtual; }
            set {  usavendabalcaoclifilialvirtual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAVENDEDORNATROCA
        /// Comentário: Selecionar vendedor vinculado ao cliente.
        /// </summary>
        private string usavendedornatroca;
        [XmlElement(ElementName = "USAVENDEDORNATROCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usavendedornatroca
        {
            get { return  usavendedornatroca; }
            set {  usavendedornatroca = value; }
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
        /// Propriedade referente ao campo: USUARIOLOGON
        /// Comentário: 
        /// </summary>
        private string usuariologon;
        [XmlElement(ElementName = "USUARIOLOGON", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Usuariologon
        {
            get { return  usuariologon; }
            set {  usuariologon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAAUTORCPAGAR
        /// Comentário: 
        /// </summary>
        private string utilizaautorcpagar;
        [XmlElement(ElementName = "UTILIZAAUTORCPAGAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaautorcpagar
        {
            get { return  utilizaautorcpagar; }
            set {  utilizaautorcpagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZABOLETOPREIMPR
        /// Comentário: 
        /// </summary>
        private string utilizaboletopreimpr;
        [XmlElement(ElementName = "UTILIZABOLETOPREIMPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaboletopreimpr
        {
            get { return  utilizaboletopreimpr; }
            set {  utilizaboletopreimpr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACHECKOUT936
        /// Comentário: 
        /// </summary>
        private string utilizacheckout936;
        [XmlElement(ElementName = "UTILIZACHECKOUT936", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacheckout936
        {
            get { return  utilizacheckout936; }
            set {  utilizacheckout936 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACONTROLECAIXA
        /// Comentário: Indica se utiliza controle de abertura e fechamento de caixa para contas a receber.
        /// </summary>
        private string utilizacontrolecaixa;
        [XmlElement(ElementName = "UTILIZACONTROLECAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacontrolecaixa
        {
            get { return  utilizacontrolecaixa; }
            set {  utilizacontrolecaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACONTROLELOTE
        /// Comentário: 
        /// </summary>
        private string utilizacontrolelote;
        [XmlElement(ElementName = "UTILIZACONTROLELOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacontrolelote
        {
            get { return  utilizacontrolelote; }
            set {  utilizacontrolelote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACONTROLEMEDICAMENTOS
        /// Comentário: Indicar se em algumas rotinas serão utilizadas funcionalidades direcionadas para produtos do segmento de medicamentos. 
        /// </summary>
        private string utilizacontrolemedicamentos;
        [XmlElement(ElementName = "UTILIZACONTROLEMEDICAMENTOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacontrolemedicamentos
        {
            get { return  utilizacontrolemedicamentos; }
            set {  utilizacontrolemedicamentos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAEMBMASTER
        /// Comentário: 
        /// </summary>
        private string utilizaembmaster;
        [XmlElement(ElementName = "UTILIZAEMBMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaembmaster
        {
            get { return  utilizaembmaster; }
            set {  utilizaembmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAENDPORFILIAL
        /// Comentário: Utiliza endereçamento do produto por filial|Utiliza endereçamento do produto por filial, 
        /// </summary>
        private string utilizaendporfilial;
        [XmlElement(ElementName = "UTILIZAENDPORFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaendporfilial
        {
            get { return  utilizaendporfilial; }
            set {  utilizaendporfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAFILIALREGIAOCX
        /// Comentário: 
        /// </summary>
        private string utilizafilialregiaocx;
        [XmlElement(ElementName = "UTILIZAFILIALREGIAOCX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizafilialregiaocx
        {
            get { return  utilizafilialregiaocx; }
            set {  utilizafilialregiaocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAGUIAPROPRIANFENT
        /// Comentário: 
        /// </summary>
        private string utilizaguiaproprianfent;
        [XmlElement(ElementName = "UTILIZAGUIAPROPRIANFENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaguiaproprianfent
        {
            get { return  utilizaguiaproprianfent; }
            set {  utilizaguiaproprianfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZALIBERACAOPEDCOMPRA
        /// Comentário: 
        /// </summary>
        private string utilizaliberacaopedcompra;
        [XmlElement(ElementName = "UTILIZALIBERACAOPEDCOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaliberacaopedcompra
        {
            get { return  utilizaliberacaopedcompra; }
            set {  utilizaliberacaopedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAORCVENDA
        /// Comentário: 
        /// </summary>
        private string utilizaorcvenda;
        [XmlElement(ElementName = "UTILIZAORCVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaorcvenda
        {
            get { return  utilizaorcvenda; }
            set {  utilizaorcvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPCUSURFORNEC
        /// Comentário: 
        /// </summary>
        private string utilizapcusurfornec;
        [XmlElement(ElementName = "UTILIZAPCUSURFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizapcusurfornec
        {
            get { return  utilizapcusurfornec; }
            set {  utilizapcusurfornec = value; }
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
        /// Propriedade referente ao campo: UTILIZAPERCFINPRECOPROM
        /// Comentário: 
        /// </summary>
        private string utilizapercfinprecoprom;
        [XmlElement(ElementName = "UTILIZAPERCFINPRECOPROM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizapercfinprecoprom
        {
            get { return  utilizapercfinprecoprom; }
            set {  utilizapercfinprecoprom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAQTFRACIONADACONF
        /// Comentário: 
        /// </summary>
        private string utilizaqtfracionadaconf;
        [XmlElement(ElementName = "UTILIZAQTFRACIONADACONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaqtfracionadaconf
        {
            get { return  utilizaqtfracionadaconf; }
            set {  utilizaqtfracionadaconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZARATEIODESPESAS
        /// Comentário: Indica se haverá rateio entre contas nos lançamentos de Contas a Pagar ou de Despesas.
        /// </summary>
        private string utilizarateiodespesas;
        [XmlElement(ElementName = "UTILIZARATEIODESPESAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizarateiodespesas
        {
            get { return  utilizarateiodespesas; }
            set {  utilizarateiodespesas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAREMBUNITSINTEGRA
        /// Comentário: 
        /// </summary>
        private string utilizarembunitsintegra;
        [XmlElement(ElementName = "UTILIZAREMBUNITSINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizarembunitsintegra
        {
            get { return  utilizarembunitsintegra; }
            set {  utilizarembunitsintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAVENDAPOREMBALAGEM
        /// Comentário: 
        /// </summary>
        private string utilizavendaporembalagem;
        [XmlElement(ElementName = "UTILIZAVENDAPOREMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizavendaporembalagem
        {
            get { return  utilizavendaporembalagem; }
            set {  utilizavendaporembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDADVCODBARRA
        /// Comentário: 
        /// </summary>
        private string validadvcodbarra;
        [XmlElement(ElementName = "VALIDADVCODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validadvcodbarra
        {
            get { return  validadvcodbarra; }
            set {  validadvcodbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDAESTOQUEMAPASEP
        /// Comentário: 
        /// </summary>
        private string validaestoquemapasep;
        [XmlElement(ElementName = "VALIDAESTOQUEMAPASEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validaestoquemapasep
        {
            get { return  validaestoquemapasep; }
            set {  validaestoquemapasep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDANUMSERIEEQUIPECF
        /// Comentário: 
        /// </summary>
        private string validanumserieequipecf;
        [XmlElement(ElementName = "VALIDANUMSERIEEQUIPECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validanumserieequipecf
        {
            get { return  validanumserieequipecf; }
            set {  validanumserieequipecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDAPRECOMINIMO
        /// Comentário: 
        /// </summary>
        private string validaprecominimo;
        [XmlElement(ElementName = "VALIDAPRECOMINIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validaprecominimo
        {
            get { return  validaprecominimo; }
            set {  validaprecominimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDAPVENDABONIFIC
        /// Comentário: 
        /// </summary>
        private string validapvendabonific;
        [XmlElement(ElementName = "VALIDAPVENDABONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validapvendabonific
        {
            get { return  validapvendabonific; }
            set {  validapvendabonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARESTOQUEAUTOSERVICO
        /// Comentário: Indica se Valida Estoque no Auto Serviço. 
        /// </summary>
        private string validarestoqueautoservico;
        [XmlElement(ElementName = "VALIDARESTOQUEAUTOSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarestoqueautoservico
        {
            get { return  validarestoqueautoservico; }
            set {  validarestoqueautoservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARESTRICOESVENDAPORRCA
        /// Comentário: Indicar se a validação das restrições de venda por RCA / Fornecedor serão feitas apenas se existirem registros na tabela para o RCA selecionado. 
        /// </summary>
        private string validarestricoesvendaporrca;
        [XmlElement(ElementName = "VALIDARESTRICOESVENDAPORRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarestricoesvendaporrca
        {
            get { return  validarestricoesvendaporrca; }
            set {  validarestricoesvendaporrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARIECONSUMIDORFINAL
        /// Comentário: . 
        /// </summary>
        private string validarieconsumidorfinal;
        [XmlElement(ElementName = "VALIDARIECONSUMIDORFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarieconsumidorfinal
        {
            get { return  validarieconsumidorfinal; }
            set {  validarieconsumidorfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARUFFILIAL
        /// Comentário: 
        /// </summary>
        private string validaruffilial;
        [XmlElement(ElementName = "VALIDARUFFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validaruffilial
        {
            get { return  validaruffilial; }
            set {  validaruffilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARVLMINVENDAAPOSCORTE
        /// Comentário: 
        /// </summary>
        private string validarvlminvendaaposcorte;
        [XmlElement(ElementName = "VALIDARVLMINVENDAAPOSCORTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarvlminvendaaposcorte
        {
            get { return  validarvlminvendaaposcorte; }
            set {  validarvlminvendaaposcorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDAVLMINVENDABALCAO
        /// Comentário: 
        /// </summary>
        private string validavlminvendabalcao;
        [XmlElement(ElementName = "VALIDAVLMINVENDABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validavlminvendabalcao
        {
            get { return  validavlminvendabalcao; }
            set {  validavlminvendabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR_FRETE_PADRAO
        /// Comentário: 
        /// </summary>
        private decimal valor_frete_padrao;
        [XmlElement(ElementName = "VALOR_FRETE_PADRAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor_Frete_Padrao
        {
            get { return  valor_frete_padrao; }
            set {  valor_frete_padrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMAXFALTACAIXA
        /// Comentário: Indica o valor máximo permitido ao usuário no lançamento de falta de Caixa, efetuado ao fechar o caixa na 409. 
        /// </summary>
        private decimal valormaxfaltacaixa;
        [XmlElement(ElementName = "VALORMAXFALTACAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valormaxfaltacaixa
        {
            get { return  valormaxfaltacaixa; }
            set {  valormaxfaltacaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMINIMOCSRF
        /// Comentário: Campo para armazenar valor mínimo para geração do CSRF.. 
        /// </summary>
        private decimal valorminimocsrf;
        [XmlElement(ElementName = "VALORMINIMOCSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Valorminimocsrf
        {
            get { return  valorminimocsrf; }
            set {  valorminimocsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMINIMOINSS
        /// Comentário: Campo para armazenar o valor mínimo para geração do INSS. 
        /// </summary>
        private decimal valorminimoinss;
        [XmlElement(ElementName = "VALORMINIMOINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Valorminimoinss
        {
            get { return  valorminimoinss; }
            set {  valorminimoinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMINIMOIRRF
        /// Comentário: Campo para armazenar o valor mínimo para geração do IRRF. 
        /// </summary>
        private decimal valorminimoirrf;
        [XmlElement(ElementName = "VALORMINIMOIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Valorminimoirrf
        {
            get { return  valorminimoirrf; }
            set {  valorminimoirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORSANGRIA1
        /// Comentário: 
        /// </summary>
        private decimal valorsangria1;
        [XmlElement(ElementName = "VALORSANGRIA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorsangria1
        {
            get { return  valorsangria1; }
            set {  valorsangria1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORSANGRIA2
        /// Comentário: 
        /// </summary>
        private decimal valorsangria2;
        [XmlElement(ElementName = "VALORSANGRIA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorsangria2
        {
            get { return  valorsangria2; }
            set {  valorsangria2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERCOBRANCABLOQCLI504_16_17
        /// Comentário: Indica que será verificado no cadastro, se a cobrança está parametrizada para ser bloqueada, ao executar a rotina 504, opções 16 e 17.
        /// </summary>
        private string vercobrancabloqcli504_16_17;
        [XmlElement(ElementName = "VERCOBRANCABLOQCLI504_16_17", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vercobrancabloqcli504_16_17
        {
            get { return  vercobrancabloqcli504_16_17; }
            set {  vercobrancabloqcli504_16_17 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICADATAHORAECF
        /// Comentário: 
        /// </summary>
        private string verificadatahoraecf;
        [XmlElement(ElementName = "VERIFICADATAHORAECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificadatahoraecf
        {
            get { return  verificadatahoraecf; }
            set {  verificadatahoraecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICADESCFINBAIXACM
        /// Comentário: Indica se haverá verificação do Desconto Financeiro na  Baixa de Título através da Cobrança Magnética. 
        /// </summary>
        private string verificadescfinbaixacm;
        [XmlElement(ElementName = "VERIFICADESCFINBAIXACM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificadescfinbaixacm
        {
            get { return  verificadescfinbaixacm; }
            set {  verificadescfinbaixacm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICAESTOQUECONT
        /// Comentário: 
        /// </summary>
        private string verificaestoquecont;
        [XmlElement(ElementName = "VERIFICAESTOQUECONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificaestoquecont
        {
            get { return  verificaestoquecont; }
            set {  verificaestoquecont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICALIMCREDCODCOBD
        /// Comentário: 
        /// </summary>
        private string verificalimcredcodcobd;
        [XmlElement(ElementName = "VERIFICALIMCREDCODCOBD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificalimcredcodcobd
        {
            get { return  verificalimcredcodcobd; }
            set {  verificalimcredcodcobd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICAMARGEMLIBPEDIDO
        /// Comentário: 
        /// </summary>
        private string verificamargemlibpedido;
        [XmlElement(ElementName = "VERIFICAMARGEMLIBPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificamargemlibpedido
        {
            get { return  verificamargemlibpedido; }
            set {  verificamargemlibpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICANIVELVENDA402
        /// Comentário: 
        /// </summary>
        private string verificanivelvenda402;
        [XmlElement(ElementName = "VERIFICANIVELVENDA402", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificanivelvenda402
        {
            get { return  verificanivelvenda402; }
            set {  verificanivelvenda402 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICAPEDBONIFICENTNORMAL
        /// Comentário: 
        /// </summary>
        private string verificapedbonificentnormal;
        [XmlElement(ElementName = "VERIFICAPEDBONIFICENTNORMAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificapedbonificentnormal
        {
            get { return  verificapedbonificentnormal; }
            set {  verificapedbonificentnormal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICAPESOMAXPALETE
        /// Comentário: 
        /// </summary>
        private string verificapesomaxpalete;
        [XmlElement(ElementName = "VERIFICAPESOMAXPALETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificapesomaxpalete
        {
            get { return  verificapesomaxpalete; }
            set {  verificapesomaxpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICAPICKINGARM
        /// Comentário: 
        /// </summary>
        private string verificapickingarm;
        [XmlElement(ElementName = "VERIFICAPICKINGARM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificapickingarm
        {
            get { return  verificapickingarm; }
            set {  verificapickingarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICARCLIENTESREDE
        /// Comentário: 
        /// </summary>
        private string verificarclientesrede;
        [XmlElement(ElementName = "VERIFICARCLIENTESREDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificarclientesrede
        {
            get { return  verificarclientesrede; }
            set {  verificarclientesrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICARENDEROCUPADO
        /// Comentário: 
        /// </summary>
        private string verificarenderocupado;
        [XmlElement(ElementName = "VERIFICARENDEROCUPADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificarenderocupado
        {
            get { return  verificarenderocupado; }
            set {  verificarenderocupado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICARLIMVENDAPF
        /// Comentário: 
        /// </summary>
        private string verificarlimvendapf;
        [XmlElement(ElementName = "VERIFICARLIMVENDAPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verificarlimvendapf
        {
            get { return  verificarlimvendapf; }
            set {  verificarlimvendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFPERMISSAOCOBRNODESDOBR402
        /// Comentário: 
        /// </summary>
        private string verifpermissaocobrnodesdobr402;
        [XmlElement(ElementName = "VERIFPERMISSAOCOBRNODESDOBR402", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verifpermissaocobrnodesdobr402
        {
            get { return  verifpermissaocobrnodesdobr402; }
            set {  verifpermissaocobrnodesdobr402 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERLANCTOBCOCHQ
        /// Comentário: 
        /// </summary>
        private string verlanctobcochq;
        [XmlElement(ElementName = "VERLANCTOBCOCHQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Verlanctobcochq
        {
            get { return  verlanctobcochq; }
            set {  verlanctobcochq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VIASDANFE
        /// Comentário: Número de vias da nota fiscal eletrônica. 
        /// </summary>
        private decimal viasdanfe;
        [XmlElement(ElementName = "VIASDANFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Viasdanfe
        {
            get { return  viasdanfe; }
            set {  viasdanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBLOQCHD3
        /// Comentário: 
        /// </summary>
        private decimal vlbloqchd3;
        [XmlElement(ElementName = "VLBLOQCHD3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbloqchd3
        {
            get { return  vlbloqchd3; }
            set {  vlbloqchd3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFERENCA
        /// Comentário: 
        /// </summary>
        private decimal vldiferenca;
        [XmlElement(ElementName = "VLDIFERENCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vldiferenca
        {
            get { return  vldiferenca; }
            set {  vldiferenca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXPEDIDOPF
        /// Comentário: 
        /// </summary>
        private decimal vlmaxpedidopf;
        [XmlElement(ElementName = "VLMAXPEDIDOPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlmaxpedidopf
        {
            get { return  vlmaxpedidopf; }
            set {  vlmaxpedidopf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXTARIFABANC
        /// Comentário: 
        /// </summary>
        private decimal vlmaxtarifabanc;
        [XmlElement(ElementName = "VLMAXTARIFABANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmaxtarifabanc
        {
            get { return  vlmaxtarifabanc; }
            set {  vlmaxtarifabanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXVENDA
        /// Comentário: 
        /// </summary>
        private decimal vlmaxvenda;
        [XmlElement(ElementName = "VLMAXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmaxvenda
        {
            get { return  vlmaxvenda; }
            set {  vlmaxvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXVENDABNF
        /// Comentário: Indica o valor máximo para venda bonificada.
        /// </summary>
        private decimal vlmaxvendabnf;
        [XmlElement(ElementName = "VLMAXVENDABNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmaxvendabnf
        {
            get { return  vlmaxvendabnf; }
            set {  vlmaxvendabnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXVENDAPF
        /// Comentário: 
        /// </summary>
        private decimal vlmaxvendapf;
        [XmlElement(ElementName = "VLMAXVENDAPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmaxvendapf
        {
            get { return  vlmaxvendapf; }
            set {  vlmaxvendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXVENDATLMKCODCOBD
        /// Comentário: 
        /// </summary>
        private decimal vlmaxvendatlmkcodcobd;
        [XmlElement(ElementName = "VLMAXVENDATLMKCODCOBD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmaxvendatlmkcodcobd
        {
            get { return  vlmaxvendatlmkcodcobd; }
            set {  vlmaxvendatlmkcodcobd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINCANCCUPOM
        /// Comentário: 
        /// </summary>
        private decimal vlmincanccupom;
        [XmlElement(ElementName = "VLMINCANCCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlmincanccupom
        {
            get { return  vlmincanccupom; }
            set {  vlmincanccupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINCANCITEMCUPOM
        /// Comentário: 
        /// </summary>
        private decimal vlmincancitemcupom;
        [XmlElement(ElementName = "VLMINCANCITEMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlmincancitemcupom
        {
            get { return  vlmincancitemcupom; }
            set {  vlmincancitemcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINTARIFABANC
        /// Comentário: 
        /// </summary>
        private decimal vlmintarifabanc;
        [XmlElement(ElementName = "VLMINTARIFABANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmintarifabanc
        {
            get { return  vlmintarifabanc; }
            set {  vlmintarifabanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINVENDA
        /// Comentário: 
        /// </summary>
        private decimal vlminvenda;
        [XmlElement(ElementName = "VLMINVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlminvenda
        {
            get { return  vlminvenda; }
            set {  vlminvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINVENDABK
        /// Comentário: 
        /// </summary>
        private decimal vlminvendabk;
        [XmlElement(ElementName = "VLMINVENDABK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlminvendabk
        {
            get { return  vlminvendabk; }
            set {  vlminvendabk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINVENDABNF
        /// Comentário: Indica o valor mínimo para venda bonificada.
        /// </summary>
        private decimal vlminvendabnf;
        [XmlElement(ElementName = "VLMINVENDABNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlminvendabnf
        {
            get { return  vlminvendabnf; }
            set {  vlminvendabnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINVENDATV3
        /// Comentário: 
        /// </summary>
        private decimal vlminvendatv3;
        [XmlElement(ElementName = "VLMINVENDATV3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlminvendatv3
        {
            get { return  vlminvendatv3; }
            set {  vlminvendatv3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPALETEDESCARG
        /// Comentário: 
        /// </summary>
        private decimal vlpaletedescarg;
        [XmlElement(ElementName = "VLPALETEDESCARG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpaletedescarg
        {
            get { return  vlpaletedescarg; }
            set {  vlpaletedescarg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPESODESCARGA
        /// Comentário: 
        /// </summary>
        private decimal vlpesodescarga;
        [XmlElement(ElementName = "VLPESODESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpesodescarga
        {
            get { return  vlpesodescarga; }
            set {  vlpesodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPESODESCARGAPAL
        /// Comentário: 
        /// </summary>
        private decimal vlpesodescargapal;
        [XmlElement(ElementName = "VLPESODESCARGAPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpesodescargapal
        {
            get { return  vlpesodescargapal; }
            set {  vlpesodescargapal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREMONTEDESCARGA
        /// Comentário: 
        /// </summary>
        private decimal vlremontedescarga;
        [XmlElement(ElementName = "VLREMONTEDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlremontedescarga
        {
            get { return  vlremontedescarga; }
            set {  vlremontedescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTARIFA
        /// Comentário: 
        /// </summary>
        private decimal vltarifa;
        [XmlElement(ElementName = "VLTARIFA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vltarifa
        {
            get { return  vltarifa; }
            set {  vltarifa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVOLDESCARGA
        /// Comentário: 
        /// </summary>
        private decimal vlvoldescarga;
        [XmlElement(ElementName = "VLVOLDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlvoldescarga
        {
            get { return  vlvoldescarga; }
            set {  vlvoldescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVOLUMEDESCARGAFD
        /// Comentário: 
        /// </summary>
        private decimal vlvolumedescargafd;
        [XmlElement(ElementName = "VLVOLUMEDESCARGAFD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlvolumedescargafd
        {
            get { return  vlvolumedescargafd; }
            set {  vlvolumedescargafd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMEPALETE
        /// Comentário: Utilizado pelo módulo WMS, para indicar o volume do palete. 
        /// </summary>
        private decimal volumepalete;
        [XmlElement(ElementName = "VOLUMEPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Volumepalete
        {
            get { return  volumepalete; }
            set {  volumepalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMETRANSF
        /// Comentário: 
        /// </summary>
        private decimal volumetransf;
        [XmlElement(ElementName = "VOLUMETRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Volumetransf
        {
            get { return  volumetransf; }
            set {  volumetransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ZERALIMCREDBLOQAUTOMATIC
        /// Comentário: 
        /// </summary>
        private string zeralimcredbloqautomatic;
        [XmlElement(ElementName = "ZERALIMCREDBLOQAUTOMATIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Zeralimcredbloqautomatic
        {
            get { return  zeralimcredbloqautomatic; }
            set {  zeralimcredbloqautomatic = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConsum()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONSUM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConsum> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConsum>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConsum> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConsum>(where);
        }

        #endregion
    }
}
