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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se aceita acr�scimo no pre�o fixo.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se aceita o desconto maior que o flex�vel na venda balc�o reserva.
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: Indica se e aceito desconto em pre�o fixo de cesta b�sica.
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: Indica se o campo PCCLIENT.CONTRIBUINTE ser� validado na procedure de Faturamento. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Permite acerto de carga com t�tulos de filial diferente da filial informada no filtro.
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se o �ndice de venda ser� utilizado para o c�lculo CMV no processo de venda.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se deve atualizar os dados da �ltima entrada pela rotina 1122.
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
        /// Coment�rio: Indica atualiza��o do estoque cont�bil com  convers�o de embalagem.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica baixa de t�tulo com moeda DNI associada a lan�amento de tesouraria n�o conciliada. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: Indica se bloqueia cliente autom�tico.
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
        /// Coment�rio: Bloquear cliente por excesso de devolu��o. 
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
        /// Coment�rio: Bloqueia os clientes do Cliente Principal, quando este � bloqueado.
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
        /// Coment�rio: Permite Bloquear ou N�o a grava��o na consist�ncia do NUMMAPA na rotina 1064.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a utiliza��o da op��o "Bloqueia Fornecedores com Verbas Vencidas" na rotina [504 - Atualiza��o Di�ria I].
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se bloqueia a altera��o do hist�rico nas rotinas de movimenta��o financeira.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica Bloqueio de Pedido de Venda Bonificado.
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
        /// Coment�rio: Indica se ser� bloqueada a venda de estoque pendente. Op��es: Sim(S) ou N�o(N).
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se pedidos Broker ir�o contabilizar no d�bito/cr�dito de RCAs.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se ser� apurado automaticamente o cr�dito a deduzir de Fome Zero na rotina 1025. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a classe de comiss�o padr�o usada no produto. 
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
        /// Coment�rio: Indica que a cidade IBGE obrigat�rio.
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
        /// Coment�rio: Obrigar informar se � Isento de IPI.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo do Cliente PC
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo de Cobran�a para Desconto Financeiro, usado na rotina 402 - Acerto de Carga, em conjunto com o par�metro "Usa Saldo C.Corrente como Desc. Fin." (rotina 132, pasta "Venda/B)Permiss�es/Processo de Venda 1). 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo da conta de adiantamento a outros fornecedores.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica conta de despesa ou receita padr�o para o processo de beneficiamento. 
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
        /// Coment�rio: Cod.Contabil nas Operacoes com Cupom Fiscal
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
        /// Coment�rio: C�digo de conta para lan�amento de varia��o cambial, gerado na rotina 750. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo da conta do lan�amento no Contas a Pagar para Custos de Cart�rio informado no Desdobramento (1210).
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo conta despesa ordem de servi�o.
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
        /// Coment�rio: Indica o c�digo de conta padr�o na devolu��o de cliente gerando contas a pagar.
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
        /// Coment�rio: Indica o C�digo da Conta no Contas a Pagar(PCLANC), referente ao lan�amento de Falta de Caixa, efetuado ao fechar o caixa na 409.
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
        /// Coment�rio: Indica o c�digo da conta das GNRE.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a conta rebaixa de CMV com valor a apurar.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o C�digo da Conta no Contas a Pagar(PCLANC), referente ao lan�amento de Sobra de Caixa, efetuado ao fechar o caixa na 409. 
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
        /// Coment�rio: C�digo da Conta para o Lan�amento de Sobra de Mercadoria. 
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
        /// Coment�rio: C�digo da Conta para transfer�ncias de tipo de venda 10. 
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
        /// Coment�rio: Indica a conta de receita ou despesa utilizada no momento do faturamento, ou devolu��o de cliente, referente ao valor da verba de aplicado ao CMV. Esta verba � calculada na digita��o do pedido e n�o poder� ser informada contas do Grupo 100. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo da conta de despesa ordem de servi�o.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo da Conta para Lan�amento de Di�rias de Viagens e Despesas Ajudante, a ser utilizada pela rotina 1449.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Campo que identifica o CFOP padr�o para fretes na entrada estadual.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Campo que identifica o CFOP padr�o para fretes na entrada interestadual.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo plano pagamento autom�tico.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o c�digo do setor cobran�a.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indicador de conferencia.
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
        /// Coment�rio: Conceder acesso proprio na 530.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se usa Cr�dito de Cliente na Venda Telemarketing. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se considera Qtde. Reservada Rebaixa Custo (rotina 1806). 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se pedidos do CRM ir�o contabilizar no d�bito/cr�dito de RCAs.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Dias para analisar as vendas e devolu��es
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
        /// Coment�rio: Indica a quantidade de dias para bloquear fornecedor na op��o [Bloqueia Fornecedores com Verbas Vencidas] na rotina [504 - Atualiza��o Di�ria I].
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica��o do segundo diret�rio de importa��o do For�a de Vendas. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Data de Atualiza��o do Banco de Dados|Utilizado no Auto-Servi�o
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a data de inicio de NFP.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Ser� atribu�do a data da ultima valida��o dos clientes ativos na sefaz atraves da rotina 1075. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Enviar mensagem de notifica��o de corte para RCA. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se existir� faturamento e gera��o de t�tulos na filial de Broker.
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: Indica qual filial padr�o do sistema a ser utilizada em determinados processos dentre as existentes cadastradas.
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
        /// Coment�rio: 
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
        /// Coment�rio: Gera frete n�o trib. como Outras. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se deve ser gerado PCAUXLAN apenas com valores de Or�amento na rotina [506 - Fechamento Mensal], op��o [Atualizacao Balancete 12 Meses].
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
        /// Coment�rio: Indica se ir� gerar Contas a Pagar do Frete para a Transportadora. 
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
        /// Coment�rio: Indica se haver� a gera��o do Contas a Pagar (PCLANC) referente ao ICMS Antecipado na rotina 1301.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se vai ser gerado automaticamente vale da diferen�a para o RCA (rotina 1332), se a devolu��o de uma venda manifesto for parcial. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se ser� ou n�o informada qual moeda estrangeira utilizada e sua respectiva cota��o. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se ir� informar dados de frota no Winthor ( a princ�pio nas rotinas 749, 631 e 1206). Par�metro interno, que n�o consta na 132. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Campo para indicar se a comiss�o do RCA ser� inclu�da na sugest�o do pre�o de venda e no custo da mercadoria vendida.
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
        /// Coment�rio: Indica se a comiss�o do RCA ser� inclu�da na sugest�o do pre�o de venda, e no custo da mercadoria vendida. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica para qual cliente ser� feita a entrega da mercadoria em pedidos de venda para redes de clientes. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Inserir Cupom Fiscal.
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
        /// Coment�rio: Inserir Mapa Resumo.
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero do IP do Servidor de NF-e. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Lan�ar frete em X parcelas. 
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
        /// Coment�rio: Indica que ao gerar o contas a receber, cobrar o valor da substitui��o tribut�ria no primeiro vencimento, quando a venda � parcelada. 
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
        /// Coment�rio: Indica se deve lan�ar o valor dos vales como despesa no fechamento de comiss�o (rotina 1268). 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Limpar Observacao das Notas de Devolucao Cliente.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica quantidade m�xima que o representante pode ficar sem fazer vendas para um cliente e ainda assim receber comiss�o pelas vendas do Call Center.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: N�o gravar saldo do estoque em inventario rotativo.
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
        /// Coment�rio: 
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
        /// Coment�rio: N�o utilizar cr�dito de cliente para Consumidor Final.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a quantidade de casas decimais utilizado para a produ��o, nas rotinas do m�dulo 16 - Ind�stria. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o numero de dias para desbloqueio automatico de cobran�a.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o n�mero m�ximo de dias para Baixa de T�tulo com recibo retroativo.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o n�mero m�ximo de dias para desdobramento al�m do prazo m�dio.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Se par�metro estiver zerado o mesmo n�o ser� validado, mas se par�metro estiver x > 0 n�o ser�o permitidas vendas em atraso a x dias.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o n�mero de dias m�nimo para venda BK. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o n�mero de dias de atraso t�tulo p/ cobran�a externa.
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
        /// Coment�rio: Indica o n�mero de dias de atraso t�tulo p/ cobran�a interna.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero m�ximo de parcelas na entrada. 
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
        /// Coment�rio: Indica o n�mero m�ximo de t�tulos a serem baixados por Recibo.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica permite alterar a ordem da avalia��o dos diferentes tipos de comiss�o dispon�veis no WinThor. A sequ�ncia de avalia��o indica qual forma de comiss�o tem maior prioridade. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Reserva de produto somente na execu��o da ordem de servi�o.
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
        /// Coment�rio: 
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
        /// Coment�rio: Pasta do Relatorio
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se � permitido ao RCA vender produtos independente da sua distribui��o.
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
        /// Coment�rio: 
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
        /// Coment�rio: Percentual de Redu��o da Base ICMS de Despesas Acess�rias.
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Campo para armazenar al�quota do CSRF. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Bloquear cliente com excesso de devolu��es
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
        /// Coment�rio: 
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
        /// Coment�rio: Campo que identifica o percentual de ICMS padr�o para fretes na entrada estadual.
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
        /// Coment�rio: 
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
        /// Coment�rio: Campo que identifica o percentual de ICMS padr�o para fretes na entrada interestadual.
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
        /// Coment�rio: Campo para armazenar al�quota do INSS. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Percentual de Uso de Cr�dito do Cliente.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o %m�ximo de desconto no rodap� que pode ser lan�ado na PCAUX2075 quando o par�metro PERMITIRDESCRODAPECHECKOUT estiver habilitado. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se permite vender produtos proibidos. 
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
        /// Coment�rio: Indica se permite lan�ar desconto no rodap� na rotina PCAUX2075, baseado em controle de acesso por usu�rio e validando %m�ximo de desconto no rodap�. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Porta do Servidor de NF-e. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o n�mero da lista que a cota��o pertence. 
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
        /// Coment�rio: Indica o c�digo do proximo plano de pagamento.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o pr�ximo n�mero do Lote.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Pr�ximo N�mero de Lote da Nota Fiscal Eletr�nica. 
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
        /// Coment�rio: Pr�ximo lote DPEC.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a quantidade de parcelas para lan�ar impostos e frete. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a quantidade de meses anteriores para classificar estrelas. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica Qtde de meses p/ CIAP. 
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
        /// Coment�rio: Indica a quantidade de meses que o cliente permanece no mesmo grupo. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Considerar Reducao da Base de Calculo como Isenta.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Restringir checkout pedido.
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
        /// Coment�rio: Utilizado para determinar a quantidade de usu�rios utilizando 2562. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica que na convers�o entre embalagens, sempre atualizar QtEst. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se os produtos com restri��o de transporte ser�o separados em um novo pedido. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se a situa��o inicial do cliente ser� (N)�Desbloqueado ou (S)�Bloqueado.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica que o valor da tarifa ser� somado ao valor do boleto na Cobran�a Magn�tica. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o tempo de mensagem do Flow Rack (em segundos). 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o timporizador da agenda.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Tipo de C�lculo de Descarga Paletizada. T=Peso Total, P=Quantidade de Paletes.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Identifica o custo utilizado na rotina 1322, que pode ser: C-Custo de Resposi��o, V-Pre�o de Venda, R-Custo Real, F-Custo Financeiro, T-Custo Cont�bil.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o tipo da integra��o.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o tipo da m�scara de endere�amento do WMS.
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
        /// Coment�rio: Indica o tipo de movimenta��o de contacorrente de RCA.
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
        /// Coment�rio: 
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
        /// Coment�rio: . 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a origem do t�tulo exibidos na 402: 1) Ambos 2) 2075 3) 306.
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
        /// Coment�rio: Indica a origem do t�tulo exibidos na 409: 1) Ambos 2) 2075 3) 306.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Caso esteja como S-Sim, ent�o dever� ser feita uma valida��o em separado das pol�ticas de desconto cadastradas com o %desc positivo 
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
        /// Coment�rio: Travar Venda para Pessoa F�sica|Parametrizado na rotina 132 - Parametros da Presidencia
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
        /// Coment�rio: Indica se tributa frete rateado.
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
        /// Coment�rio: . 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: IOF Complementar
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a ultima atualiza��o do DataCheq.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se aceita venda de Cesta B�sica em Cupons Fiscais.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se ser� usado comiss�o de produtos por classe (letra). 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se o cliente utiliza controle de recibo na Baixa de T�tulos.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se utiliza o controle de tipo de verba ao inv�s de contas fixas.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se utiliza credito de cliente em todas as filiais.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a utiliza��o da Data de Desbloqueio do Cliente na op��o [Bloqueia Clientes Inativos a mais de XXX Dias] na rotina [504 - Atualiza��o Di�ria I]. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica uso do Fechamento de Caixa Cego no Auto Servi�o. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o limite de cr�dito por CNPJ/CPF.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se utiliza marca de produto.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se utiliza a tributa��o de PIS/COFINS por filial.
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
        /// Coment�rio: Utiliza pol�tica de senha.
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
        /// Coment�rio: Quando tiver o valor "S", ir� gravar PCLANC.INDICE = B em 631, 749 e 750.
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
        /// Coment�rio: Indica se ser� informado o motivo da precifica��o com 
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
        /// Coment�rio: Indica se altera layout de impress�o de produtos fracionados para Cupons Fiscais.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o uso do prec�o bruto como base para c�lculo de d�bito/cr�dito de RCA nas vendas bonificadas. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o uso de endere�os por fornecedor.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se utiliza redu��o de ICMS na venda TV10 da aba de transfer�ncia.
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
        /// Coment�rio: Permitir entrar com a Senha Expirada|Parametrizado na rotina 132 - Parametros da Presidencia
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
        /// Coment�rio: Alterar o tratamento do tipo de venda 10, nos programas de venda 316/336/1400, para utilizar as al�quotas/taxas de transfer�ncia definidas no 514.
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
        /// Coment�rio: Indica a utiliza��o do saldo de conta corrente do RCA como Desconto Financeiro. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Usa pre�o de venda para mercadorias a retirar nos tipos de venda 11 e 12. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se aceita venda balc�o para cliente com filial virtual.
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
        /// Coment�rio: Selecionar vendedor vinculado ao cliente.
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
        /// Propriedade referente ao campo: USUARIOLOGON
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se utiliza controle de abertura e fechamento de caixa para contas a receber.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indicar se em algumas rotinas ser�o utilizadas funcionalidades direcionadas para produtos do segmento de medicamentos. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Utiliza endere�amento do produto por filial|Utiliza endere�amento do produto por filial, 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se haver� rateio entre contas nos lan�amentos de Contas a Pagar ou de Despesas.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se Valida Estoque no Auto Servi�o. 
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
        /// Coment�rio: Indicar se a valida��o das restri��es de venda por RCA / Fornecedor ser�o feitas apenas se existirem registros na tabela para o RCA selecionado. 
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
        /// Coment�rio: . 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor m�ximo permitido ao usu�rio no lan�amento de falta de Caixa, efetuado ao fechar o caixa na 409. 
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
        /// Coment�rio: Campo para armazenar valor m�nimo para gera��o do CSRF.. 
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
        /// Coment�rio: Campo para armazenar o valor m�nimo para gera��o do INSS. 
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
        /// Coment�rio: Campo para armazenar o valor m�nimo para gera��o do IRRF. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica que ser� verificado no cadastro, se a cobran�a est� parametrizada para ser bloqueada, ao executar a rotina 504, op��es 16 e 17.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica se haver� verifica��o do Desconto Financeiro na  Baixa de T�tulo atrav�s da Cobran�a Magn�tica. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero de vias da nota fiscal eletr�nica. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor m�ximo para venda bonificada.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor m�nimo para venda bonificada.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Utilizado pelo m�dulo WMS, para indicar o volume do palete. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConsum> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConsum>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
