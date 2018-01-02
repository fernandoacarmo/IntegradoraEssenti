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
    /// Classe referente a tabela PCProdfilial
    /// </summary>
    [XmlType("PCPRODFILIAL")]
    public class PCProdfilial : OracleTable
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
        /// Coment�rio: Aceita venda fracionada. 
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
        /// Propriedade referente ao campo: ALTURAPAL
        /// Coment�rio: 
        /// </summary>
        private decimal alturapal;
        [XmlElement(ElementName = "ALTURAPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Alturapal
        {
            get { return  alturapal; }
            set {  alturapal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Coment�rio: Indica o produto ativo na filial. 
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAFILIALGESTAOWMS
        /// Coment�rio: Informa se o produto deve  ter a filial gest�o atualizada no invent�rio.
        /// </summary>
        private string atualizafilialgestaowms;
        [XmlElement(ElementName = "ATUALIZAFILIALGESTAOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizafilialgestaowms
        {
            get { return  atualizafilialgestaowms; }
            set {  atualizafilialgestaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEPISCOFINSLIT
        /// Coment�rio: Base PIS/COFINS por litragem
        /// </summary>
        private decimal basepiscofinslit;
        [XmlElement(ElementName = "BASEPISCOFINSLIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basepiscofinslit
        {
            get { return  basepiscofinslit; }
            set {  basepiscofinslit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDIPI
        /// Coment�rio: Informa se o produto far� parte do c�lculo do valor de IPI.
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
        /// Propriedade referente ao campo: CHECARMULTIPLOVENDABNF
        /// Coment�rio: Verificar Multiplo na Venda. 
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
        /// Coment�rio: Classe do produto. 
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
        /// Propriedade referente ao campo: CLASSEESTOQUE
        /// Coment�rio: Classe Estoque. 
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
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Coment�rio: Informa a classifica��o de acordo com o volume de venda (A, B, C) etc.
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
        /// Propriedade referente ao campo: CNAEDESONERACAO
        /// Coment�rio: C�digo CNAE sera utilizado no rec�lculo desonera��o na rotina 1000
        /// </summary>
        private string cnaedesoneracao;
        [XmlElement(ElementName = "CNAEDESONERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Cnaedesoneracao
        {
            get { return  cnaedesoneracao; }
            set {  cnaedesoneracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODALTERESTQMAXIMO
        /// Coment�rio: 
        /// </summary>
        private decimal? codalterestqmaximo;
        [XmlElement(ElementName = "CODALTERESTQMAXIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codalterestqmaximo
        {
            get { return  codalterestqmaximo; }
            set {  codalterestqmaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIARFAV
        /// Coment�rio: C�digo Auxiliar Favorito
        /// </summary>
        private string codauxiliarfav;
        [XmlElement(ElementName = "CODAUXILIARFAV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Codauxiliarfav
        {
            get { return  codauxiliarfav; }
            set {  codauxiliarfav = value; }
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
        /// Propriedade referente ao campo: CODCOMPRADOR
        /// Coment�rio: C�digo do Comprador respons�vel pelo produto na filial.
        /// </summary>
        private decimal? codcomprador;
        [XmlElement(ElementName = "CODCOMPRADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codcomprador
        {
            get { return  codcomprador; }
            set {  codcomprador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDISPESTRUTURA
        /// Coment�rio: C�digo dispositivo estrutura. 
        /// </summary>
        private decimal? coddispestrutura;
        [XmlElement(ElementName = "CODDISPESTRUTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Coddispestrutura
        {
            get { return  coddispestrutura; }
            set {  coddispestrutura = value; }
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
        /// Propriedade referente ao campo: CODFIGURA
        /// Coment�rio: C�digo da figura tribut�ria.
        /// </summary>
        private decimal? codfigura;
        [XmlElement(ElementName = "CODFIGURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfigura
        {
            get { return  codfigura; }
            set {  codfigura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial. 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do Produto. 
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
        [DataObjectField(false,false,true,4)]
        public decimal? Codrotinaultalter
        {
            get { return  codrotinaultalter; }
            set {  codrotinaultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINS
        /// Coment�rio: Indica o c�digo da situa��o tribut�ria ref�rente ao PIS/COFINS.
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
        /// Propriedade referente ao campo: CODTRIBSEFAZ
        /// Coment�rio: C�digo de Tributa��o da Sefaz.
        /// </summary>
        private string codtribsefaz;
        [XmlElement(ElementName = "CODTRIBSEFAZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Codtribsefaz
        {
            get { return  codtribsefaz; }
            set {  codtribsefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUULTALTCOM
        /// Coment�rio: Usu�rio altera
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
        /// Propriedade referente ao campo: CONSIDERASTGUIACUSTO
        /// Coment�rio: Considera ST Guia no Custo.
        /// </summary>
        private string considerastguiacusto;
        [XmlElement(ElementName = "CONSIDERASTGUIACUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerastguiacusto
        {
            get { return  considerastguiacusto; }
            set {  considerastguiacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERASTGUIACUSTOCONT
        /// Coment�rio: Considera ST Guia no Custo Cont�bil.
        /// </summary>
        private string considerastguiacustocont;
        [XmlElement(ElementName = "CONSIDERASTGUIACUSTOCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerastguiacustocont
        {
            get { return  considerastguiacustocont; }
            set {  considerastguiacustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERASTNFCUSTO
        /// Coment�rio: Indica se considera ST no custo do produto.
        /// </summary>
        private string considerastnfcusto;
        [XmlElement(ElementName = "CONSIDERASTNFCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerastnfcusto
        {
            get { return  considerastnfcusto; }
            set {  considerastnfcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERASTNFCUSTOCONT
        /// Coment�rio: Considera ST NF no Custo Cont�bil.
        /// </summary>
        private string considerastnfcustocont;
        [XmlElement(ElementName = "CONSIDERASTNFCUSTOCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerastnfcustocont
        {
            get { return  considerastnfcustocont; }
            set {  considerastnfcustocont = value; }
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
        /// Propriedade referente ao campo: CONTROLARFCI
        /// Coment�rio: CONTROLARFCI.
        /// </summary>
        private string controlarfci;
        [XmlElement(ElementName = "CONTROLARFCI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlarfci
        {
            get { return  controlarfci; }
            set {  controlarfci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLEDEVALIDADE
        /// Coment�rio: Indica se controla validade do produto.
        /// </summary>
        private string controledevalidade;
        [XmlElement(ElementName = "CONTROLEDEVALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controledevalidade
        {
            get { return  controledevalidade; }
            set {  controledevalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREP
        /// Coment�rio: Custo reposi��o
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
        /// Coment�rio: Pre�o de compra anterior
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
        /// Propriedade referente ao campo: CUSTOREPTAB
        /// Coment�rio: Pre�o de compra futuro
        /// </summary>
        private decimal custoreptab;
        [XmlElement(ElementName = "CUSTOREPTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreptab
        {
            get { return  custoreptab; }
            set {  custoreptab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGITARQTMASTER
        /// Coment�rio: Conversor para Unidade de Venda CX para UN
        /// </summary>
        private string digitarqtmaster;
        [XmlElement(ElementName = "DIGITARQTMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Digitarqtmaster
        {
            get { return  digitarqtmaster; }
            set {  digitarqtmaster = value; }
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
        /// Propriedade referente ao campo: DTALTERAESTQMAXIMO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtalteraestqmaximo;
        [XmlElement(ElementName = "DTALTERAESTQMAXIMO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteraestqmaximo
        {
            get { return  dtalteraestqmaximo; }
            set {  dtalteraestqmaximo = value; }
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
        /// Propriedade referente ao campo: DTULTALTCOM
        /// Coment�rio: Data da �ltuma altera��o comercial.
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
        /// Propriedade referente ao campo: EMITIRETQENT
        /// Coment�rio: Emitir Etiqueta na Entrada
        /// </summary>
        private string emitiretqent;
        [XmlElement(ElementName = "EMITIRETQENT", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitiretqent
        {
            get { return  emitiretqent; }
            set {  emitiretqent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIARFORCAVENDAS
        /// Coment�rio: Enviar para For�a de Vendas
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
        /// Propriedade referente ao campo: ESTOQUEIDEAL
        /// Coment�rio: Valor do Estoque Ideal do produto na filial.
        /// </summary>
        private decimal estoqueideal;
        [XmlElement(ElementName = "ESTOQUEIDEAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Estoqueideal
        {
            get { return  estoqueideal; }
            set {  estoqueideal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUEMAX
        /// Coment�rio: 
        /// </summary>
        private decimal estoquemax;
        [XmlElement(ElementName = "ESTOQUEMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Estoquemax
        {
            get { return  estoquemax; }
            set {  estoquemax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUEMIN
        /// Coment�rio: 
        /// </summary>
        private decimal estoquemin;
        [XmlElement(ElementName = "ESTOQUEMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Estoquemin
        {
            get { return  estoquemin; }
            set {  estoquemin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTOQUEPORSERIE
        /// Coment�rio: Indica o estoque do produto por s�rie.
        /// </summary>
        private string estoqueporserie;
        [XmlElement(ElementName = "ESTOQUEPORSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estoqueporserie
        {
            get { return  estoqueporserie; }
            set {  estoqueporserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILIALGESTAOWMS
        /// Coment�rio: Filial gest�o que ser� atualizada no invent�rio.
        /// </summary>
        private string filialgestaowms;
        [XmlElement(ElementName = "FILIALGESTAOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Filialgestaowms
        {
            get { return  filialgestaowms; }
            set {  filialgestaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORALINHA
        /// Coment�rio: Indica se o produto est� fora de linha na filial.
        /// </summary>
        private string foralinha;
        [XmlElement(ElementName = "FORALINHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Foralinha
        {
            get { return  foralinha; }
            set {  foralinha = value; }
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
        /// Propriedade referente ao campo: GERAICMSLIVROFISCAL
        /// Coment�rio: Gera ICMS livro fiscal
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
        /// Propriedade referente ao campo: GERAICMSLIVROFISCALDEVFORNEC
        /// Coment�rio: Gera livro fiscal de devolu��o a fornecedor.
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
        /// Propriedade referente ao campo: GERAICMSLIVROFISCALENT
        /// Coment�rio: Gera ICMS livro fiscal entrada
        /// </summary>
        private string geraicmslivrofiscalent;
        [XmlElement(ElementName = "GERAICMSLIVROFISCALENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraicmslivrofiscalent
        {
            get { return  geraicmslivrofiscalent; }
            set {  geraicmslivrofiscalent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ICMSDIFERIDO
        /// Coment�rio: Indica se o produto possui ICMS Diferido
        /// </summary>
        private string icmsdiferido;
        [XmlElement(ElementName = "ICMSDIFERIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Icmsdiferido
        {
            get { return  icmsdiferido; }
            set {  icmsdiferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LASTROPAL
        /// Coment�rio: 
        /// </summary>
        private decimal lastropal;
        [XmlElement(ElementName = "LASTROPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Lastropal
        {
            get { return  lastropal; }
            set {  lastropal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPLO
        /// Coment�rio: . 
        /// </summary>
        private decimal multiplo;
        [XmlElement(ElementName = "MULTIPLO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Multiplo
        {
            get { return  multiplo; }
            set {  multiplo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPLOCOMPRAS
        /// Coment�rio: Essa informa��o ser� utilizada nos bot�es aumentar e diminuir a quantidade pedida para compra do produto na rotina de pedido de compra de auto-pe�as.
        /// </summary>
        private decimal multiplocompras;
        [XmlElement(ElementName = "MULTIPLOCOMPRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Multiplocompras
        {
            get { return  multiplocompras; }
            set {  multiplocompras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVELMAXIMOARM
        /// Coment�rio: 
        /// </summary>
        private decimal nivelmaximoarm;
        [XmlElement(ElementName = "NIVELMAXIMOARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Nivelmaximoarm
        {
            get { return  nivelmaximoarm; }
            set {  nivelmaximoarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVELMINIMOARM
        /// Coment�rio: 
        /// </summary>
        private decimal nivelminimoarm;
        [XmlElement(ElementName = "NIVELMINIMOARM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Nivelminimoarm
        {
            get { return  nivelminimoarm; }
            set {  nivelminimoarm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NORMAPALETE
        /// Coment�rio: 
        /// </summary>
        private string normapalete;
        [XmlElement(ElementName = "NORMAPALETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Normapalete
        {
            get { return  normapalete; }
            set {  normapalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOVACAIXAFLOWRACK
        /// Coment�rio: Indica a gera��o ou n�o de nova caixa.
        /// </summary>
        private string novacaixaflowrack;
        [XmlElement(ElementName = "NOVACAIXAFLOWRACK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Novacaixaflowrack
        {
            get { return  novacaixaflowrack; }
            set {  novacaixaflowrack = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROSSERIECONTROLADOS
        /// Coment�rio: Quantidade de N�mero de serie vinculados
        /// </summary>
        private decimal numerosseriecontrolados;
        [XmlElement(ElementName = "NUMEROSSERIECONTROLADOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numerosseriecontrolados
        {
            get { return  numerosseriecontrolados; }
            set {  numerosseriecontrolados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGMERCTRIB
        /// Coment�rio: C�digo de origem da mercadoria na situa��o tribut�ria
        /// </summary>
        private string origmerctrib;
        [XmlElement(ElementName = "ORIGMERCTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origmerctrib
        {
            get { return  origmerctrib; }
            set {  origmerctrib = value; }
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
        /// Coment�rio: Indica o percentual de comiss�o externo.
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
        /// Coment�rio: Indica o percentual de comiss�o interno.
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
        /// Propriedade referente ao campo: PCOMREP1
        /// Coment�rio: Indica o percentual de comiss�o representante.
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
        /// Propriedade referente ao campo: PERCACRES
        /// Coment�rio: Percentual de acrescimo
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
        /// Propriedade referente ao campo: PERCALIQVIGINT
        /// Coment�rio: Al�quota de ICMS para opera��es internas.
        /// </summary>
        private decimal? percaliqvigint;
        [XmlElement(ElementName = "PERCALIQVIGINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Percaliqvigint
        {
            get { return  percaliqvigint; }
            set {  percaliqvigint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALTERCUSTOENT
        /// Coment�rio: % Acrecimo pre�o custo
        /// </summary>
        private decimal? percaltercustoent;
        [XmlElement(ElementName = "PERCALTERCUSTOENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Percaltercustoent
        {
            get { return  percaltercustoent; }
            set {  percaltercustoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCARREDONDA
        /// Coment�rio: 
        /// </summary>
        private decimal? percarredonda;
        [XmlElement(ElementName = "PERCARREDONDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal? Percarredonda
        {
            get { return  percarredonda; }
            set {  percarredonda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBON
        /// Coment�rio: % Bonifica��o Mercadoria
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
        /// Propriedade referente ao campo: PERCBONOUTRAS
        /// Coment�rio: % Bonifica��o Outras Verbas
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
        /// Propriedade referente ao campo: PERCDESC
        /// Coment�rio: Desconto pregressivo
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
        /// Propriedade referente ao campo: PERCDESC1
        /// Coment�rio: 1� Desconto progressivo
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
        /// Coment�rio: 10� Desconto progressivo
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
        /// Coment�rio: 2� Desconto progressivo
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
        /// Coment�rio: 3� Desconto progressivo
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
        /// Coment�rio: 4� Desconto progressivo
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
        /// Coment�rio: 5� Desconto progressivo
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
        /// Coment�rio: 6� Desconto progressivo
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
        /// Coment�rio: 7� Desconto progressivo
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
        /// Coment�rio: 8� Desconto progressivo
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
        /// Coment�rio: 9� Desconto progressivo
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
        /// Propriedade referente ao campo: PERCDESONERACAO
        /// Coment�rio: Percentual de desonera��o ser� utilizado no rec�lculo de desonera��o na rotina 1000
        /// </summary>
        private decimal? percdesoneracao;
        [XmlElement(ElementName = "PERCDESONERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Percdesoneracao
        {
            get { return  percdesoneracao; }
            set {  percdesoneracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXVARPVENDA
        /// Coment�rio: Percentual m�ximo de varia��o do pre�o de compra
        /// </summary>
        private decimal? percmaxvarpvenda;
        [XmlElement(ElementName = "PERCMAXVARPVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Percmaxvarpvenda
        {
            get { return  percmaxvarpvenda; }
            set {  percmaxvarpvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Coment�rio: Indica o % de Cofins. 
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
        /// Propriedade referente ao campo: PERCREDPMC
        /// Coment�rio: Percentual de redu��o do PMC
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
        /// Propriedade referente ao campo: PERCTOLERANCIACORTE
        /// Coment�rio: Indica o percentual de toler�ncia de corte.
        /// </summary>
        private decimal? perctoleranciacorte;
        [XmlElement(ElementName = "PERCTOLERANCIACORTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Perctoleranciacorte
        {
            get { return  perctoleranciacorte; }
            set {  perctoleranciacorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCTOLERANCIADEPURATRANSF
        /// Coment�rio: CAMPO PARA PODER CONTEMPLAR C�LCULOS DE PESO VARI�VEL
        /// </summary>
        private decimal? perctoleranciadepuratransf;
        [XmlElement(ElementName = "PERCTOLERANCIADEPURATRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Perctoleranciadepuratransf
        {
            get { return  perctoleranciadepuratransf; }
            set {  perctoleranciadepuratransf = value; }
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
        /// Propriedade referente ao campo: PERDESCRETENCAO
        /// Coment�rio: Indica o percentual de desconto reten��o.
        /// </summary>
        private decimal? perdescretencao;
        [XmlElement(ElementName = "PERDESCRETENCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Perdescretencao
        {
            get { return  perdescretencao; }
            set {  perdescretencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Coment�rio: Indica o % do Pis. 
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
        /// Propriedade referente ao campo: PESOPALETE
        /// Coment�rio: 
        /// </summary>
        private decimal pesopalete;
        [XmlElement(ElementName = "PESOPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pesopalete
        {
            get { return  pesopalete; }
            set {  pesopalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PISCOFINSRETIDO
        /// Coment�rio: Indica o Pis/Cofins Retido
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
        /// Propriedade referente ao campo: PRAZOVAL
        /// Coment�rio: 
        /// </summary>
        private decimal prazoval;
        [XmlElement(ElementName = "PRAZOVAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoval
        {
            get { return  prazoval; }
            set {  prazoval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOUTILIZADONFE
        /// Coment�rio: Pre�o a utilizar na NF-e
        /// </summary>
        private string precoutilizadonfe;
        [XmlElement(ElementName = "PRECOUTILIZADONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Precoutilizadonfe
        {
            get { return  precoutilizadonfe; }
            set {  precoutilizadonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROIBIDAVENDA
        /// Coment�rio: Indica se o produto est� com venda proibida na filial.
        /// </summary>
        private string proibidavenda;
        [XmlElement(ElementName = "PROIBIDAVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Proibidavenda
        {
            get { return  proibidavenda; }
            set {  proibidavenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOICMS1785
        /// Coment�rio: Regulamento de ICMS do Estado de S�o Paulo a ser utilizado nas transfer�ncia via 1124.
        /// </summary>
        private string protocoloicms1785;
        [XmlElement(ElementName = "PROTOCOLOICMS1785", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Protocoloicms1785
        {
            get { return  protocoloicms1785; }
            set {  protocoloicms1785 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAFORNEC
        /// Coment�rio: Pre�o fornecedor
        /// </summary>
        private decimal ptabelafornec;
        [XmlElement(ElementName = "PTABELAFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Ptabelafornec
        {
            get { return  ptabelafornec; }
            set {  ptabelafornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDALTERESTQMAXIMO
        /// Coment�rio: 
        /// </summary>
        private decimal qtdalterestqmaximo;
        [XmlElement(ElementName = "QTDALTERESTQMAXIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtdalterestqmaximo
        {
            get { return  qtdalterestqmaximo; }
            set {  qtdalterestqmaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXPEDVENDA
        /// Coment�rio: Quantidade m�xima pedido venda
        /// </summary>
        private decimal qtmaxpedvenda;
        [XmlElement(ElementName = "QTMAXPEDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtmaxpedvenda
        {
            get { return  qtmaxpedvenda; }
            set {  qtmaxpedvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINAUTOSERV
        /// Coment�rio: Qtde m�nima Auto-Servi�o. 
        /// </summary>
        private decimal qtminautoserv;
        [XmlElement(ElementName = "QTMINAUTOSERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtminautoserv
        {
            get { return  qtminautoserv; }
            set {  qtminautoserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINIMAATACADO
        /// Coment�rio: Qtde m�nima Atacado. 
        /// </summary>
        private decimal qtminimaatacado;
        [XmlElement(ElementName = "QTMINIMAATACADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtminimaatacado
        {
            get { return  qtminimaatacado; }
            set {  qtminimaatacado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINIMAATACADOF
        /// Coment�rio: Qtde m�nima Atacado futuro. 
        /// </summary>
        private decimal qtminimaatacadof;
        [XmlElement(ElementName = "QTMINIMAATACADOF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtminimaatacadof
        {
            get { return  qtminimaatacadof; }
            set {  qtminimaatacadof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINSUGCOMPRA
        /// Coment�rio: 
        /// </summary>
        private decimal qtminsugcompra;
        [XmlElement(ElementName = "QTMINSUGCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtminsugcompra
        {
            get { return  qtminsugcompra; }
            set {  qtminsugcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPULMAOREGULADOR
        /// Coment�rio: 
        /// </summary>
        private decimal qtpulmaoregulador;
        [XmlElement(ElementName = "QTPULMAOREGULADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtpulmaoregulador
        {
            get { return  qtpulmaoregulador; }
            set {  qtpulmaoregulador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTOTPAL
        /// Coment�rio: 
        /// </summary>
        private decimal qttotpal;
        [XmlElement(ElementName = "QTTOTPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qttotpal
        {
            get { return  qttotpal; }
            set {  qttotpal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGIMEESPECIAL
        /// Coment�rio: Regime especial
        /// </summary>
        private string regimeespecial;
        [XmlElement(ElementName = "REGIMEESPECIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Regimeespecial
        {
            get { return  regimeespecial; }
            set {  regimeespecial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESTRICAOBLOCADO
        /// Coment�rio: 
        /// </summary>
        private decimal restricaoblocado;
        [XmlElement(ElementName = "RESTRICAOBLOCADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Restricaoblocado
        {
            get { return  restricaoblocado; }
            set {  restricaoblocado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REVENDA
        /// Coment�rio: Indica se o produto � para revenda na filial.
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
        /// Propriedade referente ao campo: SUBCLASSE
        /// Coment�rio: 
        /// </summary>
        private string subclasse;
        [XmlElement(ElementName = "SUBCLASSE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Subclasse
        {
            get { return  subclasse; }
            set {  subclasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUJDESONERACAO
        /// Coment�rio: Este par�metro ira dizer se o produto esta ou n�o sujeito a desonera��o
        /// </summary>
        private string sujdesoneracao;
        [XmlElement(ElementName = "SUJDESONERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sujdesoneracao
        {
            get { return  sujdesoneracao; }
            set {  sujdesoneracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOARREDUNIDMASTER
        /// Coment�rio: Arredondamento, Unidade Master
        /// </summary>
        private string tipoarredunidmaster;
        [XmlElement(ElementName = "TIPOARREDUNIDMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoarredunidmaster
        {
            get { return  tipoarredunidmaster; }
            set {  tipoarredunidmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCARGA
        /// Coment�rio: 
        /// </summary>
        private decimal tipocarga;
        [XmlElement(ElementName = "TIPOCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tipocarga
        {
            get { return  tipocarga; }
            set {  tipocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOESTAGENDA
        /// Coment�rio: Tipo limite agendamento de entrega
        /// </summary>
        private string tipoestagenda;
        [XmlElement(ElementName = "TIPOESTAGENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoestagenda
        {
            get { return  tipoestagenda; }
            set {  tipoestagenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOESTOQUEMAXIMO
        /// Coment�rio: 
        /// </summary>
        private string tipoestoquemaximo;
        [XmlElement(ElementName = "TIPOESTOQUEMAXIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoestoquemaximo
        {
            get { return  tipoestoquemaximo; }
            set {  tipoestoquemaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOESTOQUEMINIMO
        /// Coment�rio: 
        /// </summary>
        private string tipoestoqueminimo;
        [XmlElement(ElementName = "TIPOESTOQUEMINIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoestoqueminimo
        {
            get { return  tipoestoqueminimo; }
            set {  tipoestoqueminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPALPUL
        /// Coment�rio: 
        /// </summary>
        private decimal tipopalpul;
        [XmlElement(ElementName = "TIPOPALPUL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipopalpul
        {
            get { return  tipopalpul; }
            set {  tipopalpul = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPROD
        /// Coment�rio: 
        /// </summary>
        private decimal tipoprod;
        [XmlElement(ElementName = "TIPOPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoprod
        {
            get { return  tipoprod; }
            set {  tipoprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSUGESTAO
        /// Coment�rio: 
        /// </summary>
        private string tiposugestao;
        [XmlElement(ElementName = "TIPOSUGESTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposugestao
        {
            get { return  tiposugestao; }
            set {  tiposugestao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVARIACAO
        /// Coment�rio: Informa se o produto � hibrido, ou seja, utiliza o processo peso vari�vel apenas para quantidade fracionada
        /// </summary>
        private string tipovariacao;
        [XmlElement(ElementName = "TIPOVARIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovariacao
        {
            get { return  tipovariacao; }
            set {  tipovariacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANUMEROSERIE
        /// Coment�rio: Utilizado para informar se ir� controlar n�mero de s�rie na expedi��o.
        /// </summary>
        private string usanumeroserie;
        [XmlElement(ElementName = "USANUMEROSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanumeroserie
        {
            get { return  usanumeroserie; }
            set {  usanumeroserie = value; }
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
        /// Propriedade referente ao campo: USAPMCBASEST
        /// Coment�rio: Indica se usa PMC na base do ST
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
        /// Propriedade referente ao campo: USARQTOSUN
        /// Coment�rio: Usar Qtd. da Os em Unidade
        /// </summary>
        private string usarqtosun;
        [XmlElement(ElementName = "USARQTOSUN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Usarqtosun
        {
            get { return  usarqtosun; }
            set {  usarqtosun = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUALTERESTQMAXIMO
        /// Coment�rio: 
        /// </summary>
        private string usualterestqmaximo;
        [XmlElement(ElementName = "USUALTERESTQMAXIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Usualterestqmaximo
        {
            get { return  usualterestqmaximo; }
            set {  usualterestqmaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAQTDESUPMULTIPLA
        /// Coment�rio: Indica se utiliza integracao WMS?. 
        /// </summary>
        private string utilizaqtdesupmultipla;
        [XmlElement(ElementName = "UTILIZAQTDESUPMULTIPLA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaqtdesupmultipla
        {
            get { return  utilizaqtdesupmultipla; }
            set {  utilizaqtdesupmultipla = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDACAPACIDADEPICKING
        /// Coment�rio: Validar capacidade do picking ao gerar abast
        /// </summary>
        private string validacapacidadepicking;
        [XmlElement(ElementName = "VALIDACAPACIDADEPICKING", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validacapacidadepicking
        {
            get { return  validacapacidadepicking; }
            set {  validacapacidadepicking = value; }
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
        /// Propriedade referente ao campo: VLBONIFIC
        /// Coment�rio: Valor Bonifica��o em Dinheiro
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

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdfilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdfilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdfilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdfilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdfilial>(where);
        }

        #endregion
    }
}
