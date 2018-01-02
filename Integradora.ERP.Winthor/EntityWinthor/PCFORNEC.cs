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
    /// Classe referente a tabela PCFornec
    /// </summary>
    [XmlType("PCFORNEC")]
    public class PCFornec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAENTREGAANCECIP
        /// Coment�rio: 
        /// </summary>
        private string aceitaentregaancecip;
        [XmlElement(ElementName = "ACEITAENTREGAANCECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitaentregaancecip
        {
            get { return  aceitaentregaancecip; }
            set {  aceitaentregaancecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ADM_BAIRRO
        /// Coment�rio: 
        /// </summary>
        private string adm_bairro;
        [XmlElement(ElementName = "ADM_BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Adm_Bairro
        {
            get { return  adm_bairro; }
            set {  adm_bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ADM_CEP
        /// Coment�rio: 
        /// </summary>
        private decimal adm_cep;
        [XmlElement(ElementName = "ADM_CEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Adm_Cep
        {
            get { return  adm_cep; }
            set {  adm_cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ADM_CIDADE
        /// Coment�rio: 
        /// </summary>
        private string adm_cidade;
        [XmlElement(ElementName = "ADM_CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Adm_Cidade
        {
            get { return  adm_cidade; }
            set {  adm_cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ADM_CONTATO
        /// Coment�rio: 
        /// </summary>
        private string adm_contato;
        [XmlElement(ElementName = "ADM_CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Adm_Contato
        {
            get { return  adm_contato; }
            set {  adm_contato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ADM_DTANIVERSARIO
        /// Coment�rio: 
        /// </summary>
        private DateTime? adm_dtaniversario;
        [XmlElement(ElementName = "ADM_DTANIVERSARIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Adm_Dtaniversario
        {
            get { return  adm_dtaniversario; }
            set {  adm_dtaniversario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ADM_ENDERECO
        /// Coment�rio: 
        /// </summary>
        private string adm_endereco;
        [XmlElement(ElementName = "ADM_ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Adm_Endereco
        {
            get { return  adm_endereco; }
            set {  adm_endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ADM_UF
        /// Coment�rio: 
        /// </summary>
        private string adm_uf;
        [XmlElement(ElementName = "ADM_UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Adm_Uf
        {
            get { return  adm_uf; }
            set {  adm_uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZASTULTENT
        /// Coment�rio: Atualizar valores de ST da �ltima entrada.
        /// </summary>
        private string atualizastultent;
        [XmlElement(ElementName = "ATUALIZASTULTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizastultent
        {
            get { return  atualizastultent; }
            set {  atualizastultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AVALIACAOVENDA
        /// Coment�rio: Per�odo utilizado no calculo da sugest�o de compra.
        /// </summary>
        private string avaliacaovenda;
        [XmlElement(ElementName = "AVALIACAOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Avaliacaovenda
        {
            get { return  avaliacaovenda; }
            set {  avaliacaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Coment�rio: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRROCOB
        /// Coment�rio: 
        /// </summary>
        private string bairrocob;
        [XmlElement(ElementName = "BAIRROCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairrocob
        {
            get { return  bairrocob; }
            set {  bairrocob = value; }
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
        /// Propriedade referente ao campo: BLOQUEIOSEFAZFORNEC
        /// Coment�rio: BLOQUEADO SEFAZ.
        /// </summary>
        private string bloqueiosefazfornec;
        [XmlElement(ElementName = "BLOQUEIOSEFAZFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiosefazfornec
        {
            get { return  bloqueiosefazfornec; }
            set {  bloqueiosefazfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAE
        /// Coment�rio: Indica o c�digo nacional atividade economica.
        /// </summary>
        private string cae;
        [XmlElement(ElementName = "CAE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cae
        {
            get { return  cae; }
            set {  cae = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCDESPFINPRAZOPGTO
        /// Coment�rio: Calcular vendor por prazo de pagamento
        /// </summary>
        private string calcdespfinprazopgto;
        [XmlElement(ElementName = "CALCDESPFINPRAZOPGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcdespfinprazopgto
        {
            get { return  calcdespfinprazopgto; }
            set {  calcdespfinprazopgto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMDESC
        /// Coment�rio: 
        /// </summary>
        private string calcipicomdesc;
        [XmlElement(ElementName = "CALCIPICOMDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipicomdesc
        {
            get { return  calcipicomdesc; }
            set {  calcipicomdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMFRETEFOB
        /// Coment�rio: . 
        /// </summary>
        private string calcipicomfretefob;
        [XmlElement(ElementName = "CALCIPICOMFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipicomfretefob
        {
            get { return  calcipicomfretefob; }
            set {  calcipicomfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMFRETENF
        /// Coment�rio: 
        /// </summary>
        private string calcipicomfretenf;
        [XmlElement(ElementName = "CALCIPICOMFRETENF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipicomfretenf
        {
            get { return  calcipicomfretenf; }
            set {  calcipicomfretenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSTGUIAALIQEXT
        /// Coment�rio: Indica se calcula ST guia al�quota externa.
        /// </summary>
        private string calcstguiaaliqext;
        [XmlElement(ElementName = "CALCSTGUIAALIQEXT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcstguiaaliqext
        {
            get { return  calcstguiaaliqext; }
            set {  calcstguiaaliqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSUFRAMASOBREPLIQUIDO
        /// Coment�rio: 
        /// </summary>
        private string calcsuframasobrepliquido;
        [XmlElement(ElementName = "CALCSUFRAMASOBREPLIQUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcsuframasobrepliquido
        {
            get { return  calcsuframasobrepliquido; }
            set {  calcsuframasobrepliquido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULAPISCOFINSCOMIPI
        /// Coment�rio: 
        /// </summary>
        private string calculapiscofinscomipi;
        [XmlElement(ElementName = "CALCULAPISCOFINSCOMIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calculapiscofinscomipi
        {
            get { return  calculapiscofinscomipi; }
            set {  calculapiscofinscomipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULARIPIPESOLIQ
        /// Coment�rio: Calcula IPI com base no peso l�quido.
        /// </summary>
        private string calcularipipesoliq;
        [XmlElement(ElementName = "CALCULARIPIPESOLIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcularipipesoliq
        {
            get { return  calcularipipesoliq; }
            set {  calcularipipesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CENTRALIZACAO
        /// Coment�rio: 
        /// </summary>
        private string centralizacao;
        [XmlElement(ElementName = "CENTRALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Centralizacao
        {
            get { return  centralizacao; }
            set {  centralizacao = value; }
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
        /// Propriedade referente ao campo: CEPCOB
        /// Coment�rio: 
        /// </summary>
        private string cepcob;
        [XmlElement(ElementName = "CEPCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepcob
        {
            get { return  cepcob; }
            set {  cepcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CFOPENTADJUD
        /// Coment�rio: CFOP Adjudica��o
        /// </summary>
        private decimal cfopentadjud;
        [XmlElement(ElementName = "CFOPENTADJUD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cfopentadjud
        {
            get { return  cfopentadjud; }
            set {  cfopentadjud = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CFOPRESTITUICAO
        /// Coment�rio: CFOP Restitui��o
        /// </summary>
        private decimal cfoprestituicao;
        [XmlElement(ElementName = "CFOPRESTITUICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cfoprestituicao
        {
            get { return  cfoprestituicao; }
            set {  cfoprestituicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CGCAUX
        /// Coment�rio: Campo auxiliar para armazenar o CGC sem formata��o.
        /// </summary>
        private string cgcaux;
        [XmlElement(ElementName = "CGCAUX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cgcaux
        {
            get { return  cgcaux; }
            set {  cgcaux = value; }
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
        /// Propriedade referente ao campo: CLASSE
        /// Coment�rio: Classe do Fornecedor. 
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
        /// Propriedade referente ao campo: CLASSEMC
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CLASSIFICTIPOFORNEC
        /// Coment�rio: Classifica o tipo do fornecedor comercial.
        /// </summary>
        private string classifictipofornec;
        [XmlElement(ElementName = "CLASSIFICTIPOFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classifictipofornec
        {
            get { return  classifictipofornec; }
            set {  classifictipofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COBERTURA
        /// Coment�rio: 
        /// </summary>
        private decimal cobertura;
        [XmlElement(ElementName = "COBERTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Cobertura
        {
            get { return  cobertura; }
            set {  cobertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Coment�rio: 
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
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
        /// Propriedade referente ao campo: CODCOMPRADOR
        /// Coment�rio: 
        /// </summary>
        private decimal codcomprador;
        [XmlElement(ElementName = "CODCOMPRADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcomprador
        {
            get { return  codcomprador; }
            set {  codcomprador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAB
        /// Coment�rio: 
        /// </summary>
        private string codcontab;
        [XmlElement(ElementName = "CODCONTAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Codcontab
        {
            get { return  codcontab; }
            set {  codcontab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACOFINS
        /// Coment�rio: C�digo conta COFINS.
        /// </summary>
        private decimal codcontacofins;
        [XmlElement(ElementName = "CODCONTACOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacofins
        {
            get { return  codcontacofins; }
            set {  codcontacofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACONTABADIANTFOR
        /// Coment�rio: Para atender a altera��o ocorrida no cont�bil, para contabiliza��o dos adiantamentos.
        /// </summary>
        private decimal codcontacontabadiantfor;
        [XmlElement(ElementName = "CODCONTACONTABADIANTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacontabadiantfor
        {
            get { return  codcontacontabadiantfor; }
            set {  codcontacontabadiantfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACSRF
        /// Coment�rio: Campo para armazenar c�digo da conta de despesa para o CSRF. 
        /// </summary>
        private decimal codcontacsrf;
        [XmlElement(ElementName = "CODCONTACSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacsrf
        {
            get { return  codcontacsrf; }
            set {  codcontacsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAINSS
        /// Coment�rio: Campo para armazenar c�digo da conta de despesa para o INSS. 
        /// </summary>
        private decimal codcontainss;
        [XmlElement(ElementName = "CODCONTAINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontainss
        {
            get { return  codcontainss; }
            set {  codcontainss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAIRRF
        /// Coment�rio: Campo para armazenar c�digo da conta de despesa para o IRRF. 
        /// </summary>
        private decimal codcontairrf;
        [XmlElement(ElementName = "CODCONTAIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontairrf
        {
            get { return  codcontairrf; }
            set {  codcontairrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAISS
        /// Coment�rio: Campo para armazenar c�digo da conta de despesa para o ISS. 
        /// </summary>
        private decimal codcontaiss;
        [XmlElement(ElementName = "CODCONTAISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaiss
        {
            get { return  codcontaiss; }
            set {  codcontaiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTALANCFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal codcontalancfrete;
        [XmlElement(ElementName = "CODCONTALANCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcontalancfrete
        {
            get { return  codcontalancfrete; }
            set {  codcontalancfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAPIS
        /// Coment�rio: C�digo conta PIS.
        /// </summary>
        private decimal codcontapis;
        [XmlElement(ElementName = "CODCONTAPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontapis
        {
            get { return  codcontapis; }
            set {  codcontapis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEPTO
        /// Coment�rio: 
        /// </summary>
        private decimal coddepto;
        [XmlElement(ElementName = "CODDEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddepto
        {
            get { return  coddepto; }
            set {  coddepto = value; }
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
        /// Propriedade referente ao campo: CODFOLHA
        /// Coment�rio: 
        /// </summary>
        private string codfolha;
        [XmlElement(ElementName = "CODFOLHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codfolha
        {
            get { return  codfolha; }
            set {  codfolha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Coment�rio: Indica o c�digo da transportadora do frete.
        /// </summary>
        private decimal codfornecfrete;
        [XmlElement(ElementName = "CODFORNECFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfornecfrete
        {
            get { return  codfornecfrete; }
            set {  codfornecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECPRINC
        /// Coment�rio: 
        /// </summary>
        private decimal codfornecprinc;
        [XmlElement(ElementName = "CODFORNECPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecprinc
        {
            get { return  codfornecprinc; }
            set {  codfornecprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECSTGUIA
        /// Coment�rio: Indica o c�digo fornecedor ST guia.
        /// </summary>
        private decimal codfornecstguia;
        [XmlElement(ElementName = "CODFORNECSTGUIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecstguia
        {
            get { return  codfornecstguia; }
            set {  codfornecstguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTCONTATOCOB
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncultcontatocob;
        [XmlElement(ElementName = "CODFUNCULTCONTATOCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultcontatocob
        {
            get { return  codfuncultcontatocob; }
            set {  codfuncultcontatocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGLN
        /// Coment�rio: C�digo GLN - N�mero global de localiza��o
        /// </summary>
        private decimal codgln;
        [XmlElement(ElementName = "CODGLN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Codgln
        {
            get { return  codgln; }
            set {  codgln = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODINTERNO
        /// Coment�rio: 
        /// </summary>
        private decimal codinterno;
        [XmlElement(ElementName = "CODINTERNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codinterno
        {
            get { return  codinterno; }
            set {  codinterno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUNICIPIO
        /// Coment�rio: 
        /// </summary>
        private decimal codmunicipio;
        [XmlElement(ElementName = "CODMUNICIPIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codmunicipio
        {
            get { return  codmunicipio; }
            set {  codmunicipio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Coment�rio: C�digo do pa�s do fornecedor.
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCELA
        /// Coment�rio: C�digo da Parcela. 
        /// </summary>
        private decimal codparcela;
        [XmlElement(ElementName = "CODPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codparcela
        {
            get { return  codparcela; }
            set {  codparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCELASTGUIA
        /// Coment�rio: Indica o c�digo parcela ST guia.
        /// </summary>
        private decimal codparcelastguia;
        [XmlElement(ElementName = "CODPARCELASTGUIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codparcelastguia
        {
            get { return  codparcelastguia; }
            set {  codparcelastguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTORRURAL
        /// Coment�rio: 
        /// </summary>
        private string codprodutorrural;
        [XmlElement(ElementName = "CODPRODUTORRURAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codprodutorrural
        {
            get { return  codprodutorrural; }
            set {  codprodutorrural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINSCONHEC
        /// Coment�rio: C�digo Situa��o Tributaria PIS/COFINS conhecimento transporte
        /// </summary>
        private decimal codsittribpiscofinsconhec;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINSCONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribpiscofinsconhec
        {
            get { return  codsittribpiscofinsconhec; }
            set {  codsittribpiscofinsconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBPISCOFINSSERVICO
        /// Coment�rio: C�digo da situa��o tribut�ria de Pis/Cofins para nota fiscal de servi�o.
        /// </summary>
        private decimal codsittribpiscofinsservico;
        [XmlElement(ElementName = "CODSITTRIBPISCOFINSSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codsittribpiscofinsservico
        {
            get { return  codsittribpiscofinsservico; }
            set {  codsittribpiscofinsservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOWINTHOR
        /// Coment�rio: Indica o c�digo do usu�rio do sistema Winthor vinculado ao fornecedor.
        /// </summary>
        private decimal codusuariowinthor;
        [XmlElement(ElementName = "CODUSUARIOWINTHOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuariowinthor
        {
            get { return  codusuariowinthor; }
            set {  codusuariowinthor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_BAIRRO
        /// Coment�rio: 
        /// </summary>
        private string com_bairro;
        [XmlElement(ElementName = "COM_BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Com_Bairro
        {
            get { return  com_bairro; }
            set {  com_bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_CELULAR
        /// Coment�rio: 
        /// </summary>
        private string com_celular;
        [XmlElement(ElementName = "COM_CELULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Com_Celular
        {
            get { return  com_celular; }
            set {  com_celular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_CEP
        /// Coment�rio: 
        /// </summary>
        private decimal com_cep;
        [XmlElement(ElementName = "COM_CEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Com_Cep
        {
            get { return  com_cep; }
            set {  com_cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_CIDADE
        /// Coment�rio: 
        /// </summary>
        private string com_cidade;
        [XmlElement(ElementName = "COM_CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Com_Cidade
        {
            get { return  com_cidade; }
            set {  com_cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_CONTATO
        /// Coment�rio: 
        /// </summary>
        private string com_contato;
        [XmlElement(ElementName = "COM_CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Com_Contato
        {
            get { return  com_contato; }
            set {  com_contato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_DTANIVERSARIO
        /// Coment�rio: 
        /// </summary>
        private DateTime? com_dtaniversario;
        [XmlElement(ElementName = "COM_DTANIVERSARIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Com_Dtaniversario
        {
            get { return  com_dtaniversario; }
            set {  com_dtaniversario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_EMAIL
        /// Coment�rio: 
        /// </summary>
        private string com_email;
        [XmlElement(ElementName = "COM_EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Com_Email
        {
            get { return  com_email; }
            set {  com_email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_ENDERECO
        /// Coment�rio: 
        /// </summary>
        private string com_endereco;
        [XmlElement(ElementName = "COM_ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Com_Endereco
        {
            get { return  com_endereco; }
            set {  com_endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTOEND
        /// Coment�rio: Indica o complemento do endere�o.
        /// </summary>
        private string complementoend;
        [XmlElement(ElementName = "COMPLEMENTOEND", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Complementoend
        {
            get { return  complementoend; }
            set {  complementoend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COM_UF
        /// Coment�rio: 
        /// </summary>
        private string com_uf;
        [XmlElement(ElementName = "COM_UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Com_Uf
        {
            get { return  com_uf; }
            set {  com_uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCEDCREDPRES
        /// Coment�rio: 
        /// </summary>
        private string concedcredpres;
        [XmlElement(ElementName = "CONCEDCREDPRES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Concedcredpres
        {
            get { return  concedcredpres; }
            set {  concedcredpres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSFRETEFOBBASESTNF
        /// Coment�rio: Indica se o frete FOB ir� compor a base de calculo do ST NF.
        /// </summary>
        private string consfretefobbasestnf;
        [XmlElement(ElementName = "CONSFRETEFOBBASESTNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consfretefobbasestnf
        {
            get { return  consfretefobbasestnf; }
            set {  consfretefobbasestnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSFRETEFOBCALCICMSANTECIP
        /// Coment�rio: Considera frete FOB para o calculo do ICMS antecipado.
        /// </summary>
        private string consfretefobcalcicmsantecip;
        [XmlElement(ElementName = "CONSFRETEFOBCALCICMSANTECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consfretefobcalcicmsantecip
        {
            get { return  consfretefobcalcicmsantecip; }
            set {  consfretefobcalcicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIPICALCBASECREPRES
        /// Coment�rio: 
        /// </summary>
        private string consipicalcbasecrepres;
        [XmlElement(ElementName = "CONSIPICALCBASECREPRES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consipicalcbasecrepres
        {
            get { return  consipicalcbasecrepres; }
            set {  consipicalcbasecrepres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIPICALCBASEST
        /// Coment�rio: 
        /// </summary>
        private string consipicalcbasest;
        [XmlElement(ElementName = "CONSIPICALCBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consipicalcbasest
        {
            get { return  consipicalcbasest; }
            set {  consipicalcbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSMAIORICMSVLPAUTA
        /// Coment�rio: Calcula ICMS sobre Vl.Pauta maior valor(Importa��o).
        /// </summary>
        private string consmaioricmsvlpauta;
        [XmlElement(ElementName = "CONSMAIORICMSVLPAUTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consmaioricmsvlpauta
        {
            get { return  consmaioricmsvlpauta; }
            set {  consmaioricmsvlpauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSOLIDARDIFPRECOVERBA
        /// Coment�rio: Consolidar verba de diferen�a de pre�o.
        /// </summary>
        private string consolidardifprecoverba;
        [XmlElement(ElementName = "CONSOLIDARDIFPRECOVERBA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consolidardifprecoverba
        {
            get { return  consolidardifprecoverba; }
            set {  consolidardifprecoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSSTGUIAPISCOFINS
        /// Coment�rio: Considera ST Guia Base do PISCOFINS.
        /// </summary>
        private string consstguiapiscofins;
        [XmlElement(ElementName = "CONSSTGUIAPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consstguiapiscofins
        {
            get { return  consstguiapiscofins; }
            set {  consstguiapiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSSTNFPISCOFINS
        /// Coment�rio: Considerar o ST NF na base de c�lculo do PIS/COFINS.
        /// </summary>
        private string consstnfpiscofins;
        [XmlElement(ElementName = "CONSSTNFPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consstnfpiscofins
        {
            get { return  consstnfpiscofins; }
            set {  consstnfpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATO
        /// Coment�rio: 
        /// </summary>
        private string contato;
        [XmlElement(ElementName = "CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contato
        {
            get { return  contato; }
            set {  contato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATOADM
        /// Coment�rio: 
        /// </summary>
        private string contatoadm;
        [XmlElement(ElementName = "CONTATOADM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contatoadm
        {
            get { return  contatoadm; }
            set {  contatoadm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATOCOM
        /// Coment�rio: 
        /// </summary>
        private string contatocom;
        [XmlElement(ElementName = "CONTATOCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contatocom
        {
            get { return  contatocom; }
            set {  contatocom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATOVERBA
        /// Coment�rio: 
        /// </summary>
        private string contatoverba;
        [XmlElement(ElementName = "CONTATOVERBA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contatoverba
        {
            get { return  contatoverba; }
            set {  contatoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTRIBUINTEICMS
        /// Coment�rio: Fornecedor � contribuinte ICMS
        /// </summary>
        private string contribuinteicms;
        [XmlElement(ElementName = "CONTRIBUINTEICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contribuinteicms
        {
            get { return  contribuinteicms; }
            set {  contribuinteicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPFCONTATOVERBA
        /// Coment�rio: 
        /// </summary>
        private string cpfcontatoverba;
        [XmlElement(ElementName = "CPFCONTATOVERBA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cpfcontatoverba
        {
            get { return  cpfcontatoverba; }
            set {  cpfcontatoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRF
        /// Coment�rio: Num CRF
        /// </summary>
        private string crf;
        [XmlElement(ElementName = "CRF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Crf
        {
            get { return  crf; }
            set {  crf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDFRETECIFCREDPRESICMS
        /// Coment�rio: FRETE CIF CREDITO PRESUMIDO ICMS.
        /// </summary>
        private string dedfretecifcredpresicms;
        [XmlElement(ElementName = "DEDFRETECIFCREDPRESICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dedfretecifcredpresicms
        {
            get { return  dedfretecifcredpresicms; }
            set {  dedfretecifcredpresicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMABCSTALIQ1
        /// Coment�rio: 
        /// </summary>
        private string deduzirsuframabcstaliq1;
        [XmlElement(ElementName = "DEDUZIRSUFRAMABCSTALIQ1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframabcstaliq1
        {
            get { return  deduzirsuframabcstaliq1; }
            set {  deduzirsuframabcstaliq1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMACALCCREDICM
        /// Coment�rio: 
        /// </summary>
        private string deduzirsuframacalccredicm;
        [XmlElement(ElementName = "DEDUZIRSUFRAMACALCCREDICM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframacalccredicm
        {
            get { return  deduzirsuframacalccredicm; }
            set {  deduzirsuframacalccredicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMACALCCREDPIS
        /// Coment�rio: 
        /// </summary>
        private string deduzirsuframacalccredpis;
        [XmlElement(ElementName = "DEDUZIRSUFRAMACALCCREDPIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframacalccredpis
        {
            get { return  deduzirsuframacalccredpis; }
            set {  deduzirsuframacalccredpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCPAGTODUP
        /// Coment�rio: 
        /// </summary>
        private string descpagtodup;
        [XmlElement(ElementName = "DESCPAGTODUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Descpagtodup
        {
            get { return  descpagtodup; }
            set {  descpagtodup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTACASELONF
        /// Coment�rio: 
        /// </summary>
        private string destacaselonf;
        [XmlElement(ElementName = "DESTACASELONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Destacaselonf
        {
            get { return  destacaselonf; }
            set {  destacaselonf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASAVALIACAOVENDA
        /// Coment�rio: Avalia��o venda
        /// </summary>
        private decimal diasavaliacaovenda;
        [XmlElement(ElementName = "DIASAVALIACAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Diasavaliacaovenda
        {
            get { return  diasavaliacaovenda; }
            set {  diasavaliacaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANAATEND
        /// Coment�rio: 
        /// </summary>
        private decimal diasemanaatend;
        [XmlElement(ElementName = "DIASEMANAATEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diasemanaatend
        {
            get { return  diasemanaatend; }
            set {  diasemanaatend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISTRIB
        /// Coment�rio: 
        /// </summary>
        private string distrib;
        [XmlElement(ElementName = "DISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Distrib
        {
            get { return  distrib; }
            set {  distrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBLOQUEIO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtbloqueio;
        [XmlElement(ElementName = "DTBLOQUEIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbloqueio
        {
            get { return  dtbloqueio; }
            set {  dtbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBLOQUEIOSEFAZFORNEC
        /// Coment�rio: DATA BLOQUEIO SEFAZ.
        /// </summary>
        private DateTime? dtbloqueiosefazfornec;
        [XmlElement(ElementName = "DTBLOQUEIOSEFAZFORNEC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbloqueiosefazfornec
        {
            get { return  dtbloqueiosefazfornec; }
            set {  dtbloqueiosefazfornec = value; }
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
        /// Propriedade referente ao campo: DTPROXATEND
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtproxatend;
        [XmlElement(ElementName = "DTPROXATEND", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxatend
        {
            get { return  dtproxatend; }
            set {  dtproxatend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXCOMPRA
        /// Coment�rio: Data pr�xima compra
        /// </summary>
        private DateTime? dtproxcompra;
        [XmlElement(ElementName = "DTPROXCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxcompra
        {
            get { return  dtproxcompra; }
            set {  dtproxcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXCONTATOCOB
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtproxcontatocob;
        [XmlElement(ElementName = "DTPROXCONTATOCOB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxcontatocob
        {
            get { return  dtproxcontatocob; }
            set {  dtproxcontatocob = value; }
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
        /// Propriedade referente ao campo: DTULTCOMPRA
        /// Coment�rio: Data pr�xima compra
        /// </summary>
        private DateTime? dtultcompra;
        [XmlElement(ElementName = "DTULTCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcompra
        {
            get { return  dtultcompra; }
            set {  dtultcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCONTATOCOB
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultcontatocob;
        [XmlElement(ElementName = "DTULTCONTATOCOB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcontatocob
        {
            get { return  dtultcontatocob; }
            set {  dtultcontatocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCALVARAANVISA
        /// Coment�rio: Data Validade Alvar� ANVISA
        /// </summary>
        private DateTime? dtvencalvaraanvisa;
        [XmlElement(ElementName = "DTVENCALVARAANVISA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencalvaraanvisa
        {
            get { return  dtvencalvaraanvisa; }
            set {  dtvencalvaraanvisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCALVARAFUNC
        /// Coment�rio: Data Validade Alvar� Funcionamento
        /// </summary>
        private DateTime? dtvencalvarafunc;
        [XmlElement(ElementName = "DTVENCALVARAFUNC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencalvarafunc
        {
            get { return  dtvencalvarafunc; }
            set {  dtvencalvarafunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCALVARAPSICO
        /// Coment�rio: Data Validade Alvar� Psicotr�pico
        /// </summary>
        private DateTime? dtvencalvarapsico;
        [XmlElement(ElementName = "DTVENCALVARAPSICO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencalvarapsico
        {
            get { return  dtvencalvarapsico; }
            set {  dtvencalvarapsico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCCRF
        /// Coment�rio: Data Validade CRF
        /// </summary>
        private DateTime? dtvenccrf;
        [XmlElement(ElementName = "DTVENCCRF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenccrf
        {
            get { return  dtvenccrf; }
            set {  dtvenccrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVAG
        /// Coment�rio: 
        /// </summary>
        private string dvag;
        [XmlElement(ElementName = "DVAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Dvag
        {
            get { return  dvag; }
            set {  dvag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCC
        /// Coment�rio: 
        /// </summary>
        private string dvcc;
        [XmlElement(ElementName = "DVCC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Dvcc
        {
            get { return  dvcc; }
            set {  dvcc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Coment�rio: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMITENFE
        /// Coment�rio: IDENTIFICA SE O FORNECEDOR E EMITENTE DE NFE.
        /// </summary>
        private string emitenfe;
        [XmlElement(ElementName = "EMITENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Emitenfe
        {
            get { return  emitenfe; }
            set {  emitenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDER
        /// Coment�rio: 
        /// </summary>
        private string ender;
        [XmlElement(ElementName = "ENDER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Ender
        {
            get { return  ender; }
            set {  ender = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERCOB
        /// Coment�rio: 
        /// </summary>
        private string endercob;
        [XmlElement(ElementName = "ENDERCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endercob
        {
            get { return  endercob; }
            set {  endercob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EREABASTECIMENTO
        /// Coment�rio: Indica se � de reabastecimento. 
        /// </summary>
        private string ereabastecimento;
        [XmlElement(ElementName = "EREABASTECIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ereabastecimento
        {
            get { return  ereabastecimento; }
            set {  ereabastecimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EREDESPACHO
        /// Coment�rio: Indica que transportadora � redespacho. 
        /// </summary>
        private string eredespacho;
        [XmlElement(ElementName = "EREDESPACHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Eredespacho
        {
            get { return  eredespacho; }
            set {  eredespacho = value; }
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
        /// Propriedade referente ao campo: ESTCOB
        /// Coment�rio: 
        /// </summary>
        private string estcob;
        [XmlElement(ElementName = "ESTCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estcob
        {
            get { return  estcob; }
            set {  estcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTRATEGICO
        /// Coment�rio: 
        /// </summary>
        private string estrategico;
        [XmlElement(ElementName = "ESTRATEGICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estrategico
        {
            get { return  estrategico; }
            set {  estrategico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXCLUIDO
        /// Coment�rio: 
        /// </summary>
        private string excluido;
        [XmlElement(ElementName = "EXCLUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Excluido
        {
            get { return  excluido; }
            set {  excluido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIGEREDESPACHO
        /// Coment�rio: Transportadora exige redespacho. 
        /// </summary>
        private string exigeredespacho;
        [XmlElement(ElementName = "EXIGEREDESPACHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exigeredespacho
        {
            get { return  exigeredespacho; }
            set {  exigeredespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FANTASIA
        /// Coment�rio: 
        /// </summary>
        private string fantasia;
        [XmlElement(ElementName = "FANTASIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Fantasia
        {
            get { return  fantasia; }
            set {  fantasia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAXFAB
        /// Coment�rio: 
        /// </summary>
        private string faxfab;
        [XmlElement(ElementName = "FAXFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Faxfab
        {
            get { return  faxfab; }
            set {  faxfab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAXREP
        /// Coment�rio: 
        /// </summary>
        private string faxrep;
        [XmlElement(ElementName = "FAXREP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Faxrep
        {
            get { return  faxrep; }
            set {  faxrep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORNECEDOR
        /// Coment�rio: 
        /// </summary>
        private string fornecedor;
        [XmlElement(ElementName = "FORNECEDOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Fornecedor
        {
            get { return  fornecedor; }
            set {  fornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORNECIMPORTACAO
        /// Coment�rio: C�digo do tipo de fornecedor de importa��o.
        /// </summary>
        private decimal fornecimportacao;
        [XmlElement(ElementName = "FORNECIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Fornecimportacao
        {
            get { return  fornecimportacao; }
            set {  fornecimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GATILHO
        /// Coment�rio: 
        /// </summary>
        private decimal gatilho;
        [XmlElement(ElementName = "GATILHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Gatilho
        {
            get { return  gatilho; }
            set {  gatilho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACREDDIFPRECO
        /// Coment�rio: Gera cr�dito diferen�a de pre�o.
        /// </summary>
        private string geracreddifpreco;
        [XmlElement(ElementName = "GERACREDDIFPRECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracreddifpreco
        {
            get { return  geracreddifpreco; }
            set {  geracreddifpreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAPEDBONIFIC
        /// Coment�rio: Gera Pedido Bonificado Autom�tico
        /// </summary>
        private string gerapedbonific;
        [XmlElement(ElementName = "GERAPEDBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerapedbonific
        {
            get { return  gerapedbonific; }
            set {  gerapedbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOCAMPANHA
        /// Coment�rio: 
        /// </summary>
        private decimal grupocampanha;
        [XmlElement(ElementName = "GRUPOCAMPANHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Grupocampanha
        {
            get { return  grupocampanha; }
            set {  grupocampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ICMSSOBRETXMINIMA
        /// Coment�rio: 
        /// </summary>
        private string icmssobretxminima;
        [XmlElement(ElementName = "ICMSSOBRETXMINIMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Icmssobretxminima
        {
            get { return  icmssobretxminima; }
            set {  icmssobretxminima = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IE
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: IEST
        /// Coment�rio: Indica a inscri��o estadual para fornecedor substituto tribu�rio.
        /// </summary>
        private string iest;
        [XmlElement(ElementName = "IEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Iest
        {
            get { return  iest; }
            set {  iest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDUSTRIALOCAL
        /// Coment�rio: 
        /// </summary>
        private string industrialocal;
        [XmlElement(ElementName = "INDUSTRIALOCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Industrialocal
        {
            get { return  industrialocal; }
            set {  industrialocal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSCESTRANGEIRA
        /// Coment�rio: 
        /// </summary>
        private decimal inscestrangeira;
        [XmlElement(ElementName = "INSCESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Inscestrangeira
        {
            get { return  inscestrangeira; }
            set {  inscestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSCMUNICIP
        /// Coment�rio: N�mero da inscri��o municipal.
        /// </summary>
        private string inscmunicip;
        [XmlElement(ElementName = "INSCMUNICIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Inscmunicip
        {
            get { return  inscmunicip; }
            set {  inscmunicip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSS
        /// Coment�rio: N�mero do INSS do fornecedor.
        /// </summary>
        private decimal inss;
        [XmlElement(ElementName = "INSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Inss
        {
            get { return  inss; }
            set {  inss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTOST
        /// Coment�rio: Indica o fornecedor isento de ST.
        /// </summary>
        private string isentost;
        [XmlElement(ElementName = "ISENTOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentost
        {
            get { return  isentost; }
            set {  isentost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LEDTIME
        /// Coment�rio: 
        /// </summary>
        private decimal ledtime;
        [XmlElement(ElementName = "LEDTIME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ledtime
        {
            get { return  ledtime; }
            set {  ledtime = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Coment�rio: 
        /// </summary>
        private string localizacao;
        [XmlElement(ElementName = "LOCALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Localizacao
        {
            get { return  localizacao; }
            set {  localizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEIOCOMUNICACAO
        /// Coment�rio: 
        /// </summary>
        private string meiocomunicacao;
        [XmlElement(ElementName = "MEIOCOMUNICACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Meiocomunicacao
        {
            get { return  meiocomunicacao; }
            set {  meiocomunicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICOB
        /// Coment�rio: 
        /// </summary>
        private string municob;
        [XmlElement(ElementName = "MUNICOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Municob
        {
            get { return  municob; }
            set {  municob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIADOC
        /// Coment�rio: 
        /// </summary>
        private decimal numagenciadoc;
        [XmlElement(ElementName = "NUMAGENCIADOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numagenciadoc
        {
            get { return  numagenciadoc; }
            set {  numagenciadoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARAANVISA
        /// Coment�rio: Num Alvar� ANVISA
        /// </summary>
        private string numalvaraanvisa;
        [XmlElement(ElementName = "NUMALVARAANVISA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numalvaraanvisa
        {
            get { return  numalvaraanvisa; }
            set {  numalvaraanvisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARAFUNC
        /// Coment�rio: Num Alvar� Funcionamento
        /// </summary>
        private string numalvarafunc;
        [XmlElement(ElementName = "NUMALVARAFUNC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numalvarafunc
        {
            get { return  numalvarafunc; }
            set {  numalvarafunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMALVARAPSICO
        /// Coment�rio: Num Alvar� Psicotr�pico
        /// </summary>
        private string numalvarapsico;
        [XmlElement(ElementName = "NUMALVARAPSICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numalvarapsico
        {
            get { return  numalvarapsico; }
            set {  numalvarapsico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCODOC
        /// Coment�rio: 
        /// </summary>
        private decimal numbancodoc;
        [XmlElement(ElementName = "NUMBANCODOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbancodoc
        {
            get { return  numbancodoc; }
            set {  numbancodoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCASASDECREDUCAOICMS
        /// Coment�rio: Campo usado para gravar a quantidade de casas decimais originarios do fornecedor
        /// </summary>
        private decimal numcasasdecreducaoicms;
        [XmlElement(ElementName = "NUMCASASDECREDUCAOICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numcasasdecreducaoicms
        {
            get { return  numcasasdecreducaoicms; }
            set {  numcasasdecreducaoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCORRENTEDOC
        /// Coment�rio: 
        /// </summary>
        private string numccorrentedoc;
        [XmlElement(ElementName = "NUMCCORRENTEDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numccorrentedoc
        {
            get { return  numccorrentedoc; }
            set {  numccorrentedoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDEPIRRF
        /// Coment�rio: 
        /// </summary>
        private decimal numdepirrf;
        [XmlElement(ElementName = "NUMDEPIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdepirrf
        {
            get { return  numdepirrf; }
            set {  numdepirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROEND
        /// Coment�rio: Indica o numero do endere�o.
        /// </summary>
        private string numeroend;
        [XmlElement(ElementName = "NUMEROEND", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numeroend
        {
            get { return  numeroend; }
            set {  numeroend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,35)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONDIN
        /// Coment�rio: 
        /// </summary>
        private decimal percbondin;
        [XmlElement(ElementName = "PERCBONDIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percbondin
        {
            get { return  percbondin; }
            set {  percbondin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONMERC
        /// Coment�rio: 
        /// </summary>
        private decimal percbonmerc;
        [XmlElement(ElementName = "PERCBONMERC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percbonmerc
        {
            get { return  percbonmerc; }
            set {  percbonmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONOUTRAS
        /// Coment�rio: 
        /// </summary>
        private decimal percbonoutras;
        [XmlElement(ElementName = "PERCBONOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percbonoutras
        {
            get { return  percbonoutras; }
            set {  percbonoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOFINSNFSERVICO
        /// Coment�rio: Percentual de COFINS NF servi�o.
        /// </summary>
        private decimal perccofinsnfservico;
        [XmlElement(ElementName = "PERCCOFINSNFSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perccofinsnfservico
        {
            get { return  perccofinsnfservico; }
            set {  perccofinsnfservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMISSAO
        /// Coment�rio: 
        /// </summary>
        private decimal perccomissao;
        [XmlElement(ElementName = "PERCCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perccomissao
        {
            get { return  perccomissao; }
            set {  perccomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCSRF
        /// Coment�rio: PERCENTUAL CSRF.
        /// </summary>
        private decimal perccsrf;
        [XmlElement(ElementName = "PERCCSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perccsrf
        {
            get { return  perccsrf; }
            set {  perccsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFIN
        /// Coment�rio: 
        /// </summary>
        private decimal percdescfin;
        [XmlElement(ElementName = "PERCDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdescfin
        {
            get { return  percdescfin; }
            set {  percdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPFIN
        /// Coment�rio: 
        /// </summary>
        private decimal percdespfin;
        [XmlElement(ElementName = "PERCDESPFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percdespfin
        {
            get { return  percdespfin; }
            set {  percdespfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFLUVIAL
        /// Coment�rio: 
        /// </summary>
        private decimal percfluvial;
        [XmlElement(ElementName = "PERCFLUVIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percfluvial
        {
            get { return  percfluvial; }
            set {  percfluvial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPPRODUTORURAL
        /// Coment�rio: Indica o percentual do imposto do produtor rural.
        /// </summary>
        private decimal percimpprodutorural;
        [XmlElement(ElementName = "PERCIMPPRODUTORURAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percimpprodutorural
        {
            get { return  percimpprodutorural; }
            set {  percimpprodutorural = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINSS
        /// Coment�rio: PERCENTUAL INSS.
        /// </summary>
        private decimal percinss;
        [XmlElement(ElementName = "PERCINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percinss
        {
            get { return  percinss; }
            set {  percinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIRRF
        /// Coment�rio: Campo para armazenar al�quota do IRRF. 
        /// </summary>
        private decimal percirrf;
        [XmlElement(ElementName = "PERCIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percirrf
        {
            get { return  percirrf; }
            set {  percirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCISS
        /// Coment�rio: Campo para armazenar al�quota do ISS. 
        /// </summary>
        private decimal perciss;
        [XmlElement(ElementName = "PERCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perciss
        {
            get { return  perciss; }
            set {  perciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXBONIFIC
        /// Coment�rio: 
        /// </summary>
        private decimal percmaxbonific;
        [XmlElement(ElementName = "PERCMAXBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percmaxbonific
        {
            get { return  percmaxbonific; }
            set {  percmaxbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOFINS
        /// Coment�rio: Percentual CONFINS
        /// </summary>
        private decimal percofins;
        [XmlElement(ElementName = "PERCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percofins
        {
            get { return  percofins; }
            set {  percofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOUTROSCUSTOSFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal percoutroscustosfrete;
        [XmlElement(ElementName = "PERCOUTROSCUSTOSFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percoutroscustosfrete
        {
            get { return  percoutroscustosfrete; }
            set {  percoutroscustosfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPISNFSERVICO
        /// Coment�rio: Percentual de PIS NF servi�o.
        /// </summary>
        private decimal percpisnfservico;
        [XmlElement(ElementName = "PERCPISNFSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percpisnfservico
        {
            get { return  percpisnfservico; }
            set {  percpisnfservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPISRED
        /// Coment�rio: 
        /// </summary>
        private decimal percpisred;
        [XmlElement(ElementName = "PERCPISRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percpisred
        {
            get { return  percpisred; }
            set {  percpisred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETEVALOR
        /// Coment�rio: Indica o valor percentual frete.
        /// </summary>
        private decimal perfretevalor;
        [XmlElement(ElementName = "PERFRETEVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perfretevalor
        {
            get { return  perfretevalor; }
            set {  perfretevalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERGRIS
        /// Coment�rio: 
        /// </summary>
        private decimal pergris;
        [XmlElement(ElementName = "PERGRIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pergris
        {
            get { return  pergris; }
            set {  pergris = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIOCIDADEATEND
        /// Coment�rio: 
        /// </summary>
        private decimal periocidadeatend;
        [XmlElement(ElementName = "PERIOCIDADEATEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Periocidadeatend
        {
            get { return  periocidadeatend; }
            set {  periocidadeatend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODICIDADECOMPRA
        /// Coment�rio: Periodicidade de compras
        /// </summary>
        private decimal periodicidadecompra;
        [XmlElement(ElementName = "PERIODICIDADECOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Periodicidadecompra
        {
            get { return  periodicidadecompra; }
            set {  periodicidadecompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPIS
        /// Coment�rio: Percentual PIS
        /// </summary>
        private decimal perpis;
        [XmlElement(ElementName = "PERPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perpis
        {
            get { return  perpis; }
            set {  perpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOMINTRANSP
        /// Coment�rio: Peso m�nimo que o frete transporta.
        /// </summary>
        private decimal pesomintransp;
        [XmlElement(ElementName = "PESOMINTRANSP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pesomintransp
        {
            get { return  pesomintransp; }
            set {  pesomintransp = value; }
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
        /// Propriedade referente ao campo: PRAZOMIN
        /// Coment�rio: 
        /// </summary>
        private decimal prazomin;
        [XmlElement(ElementName = "PRAZOMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomin
        {
            get { return  prazomin; }
            set {  prazomin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO1
        /// Coment�rio: 
        /// </summary>
        private decimal prazo1;
        [XmlElement(ElementName = "PRAZO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo1
        {
            get { return  prazo1; }
            set {  prazo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO2
        /// Coment�rio: 
        /// </summary>
        private decimal prazo2;
        [XmlElement(ElementName = "PRAZO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo2
        {
            get { return  prazo2; }
            set {  prazo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO3
        /// Coment�rio: 
        /// </summary>
        private decimal prazo3;
        [XmlElement(ElementName = "PRAZO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo3
        {
            get { return  prazo3; }
            set {  prazo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO4
        /// Coment�rio: 
        /// </summary>
        private decimal prazo4;
        [XmlElement(ElementName = "PRAZO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo4
        {
            get { return  prazo4; }
            set {  prazo4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO5
        /// Coment�rio: 
        /// </summary>
        private decimal prazo5;
        [XmlElement(ElementName = "PRAZO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo5
        {
            get { return  prazo5; }
            set {  prazo5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO6
        /// Coment�rio: 
        /// </summary>
        private decimal prazo6;
        [XmlElement(ElementName = "PRAZO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo6
        {
            get { return  prazo6; }
            set {  prazo6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIASVENCVERBAS
        /// Coment�rio: Quantidade dias(Padr�o) vencimento de verbas.
        /// </summary>
        private decimal qtdiasvencverbas;
        [XmlElement(ElementName = "QTDIASVENCVERBAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtdiasvencverbas
        {
            get { return  qtdiasvencverbas; }
            set {  qtdiasvencverbas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECALCTRIBENT
        /// Coment�rio: Recalcula tributa��o do pedido de compra no momento da entrada NF
        /// </summary>
        private string recalctribent;
        [XmlElement(ElementName = "RECALCTRIBENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Recalctribent
        {
            get { return  recalctribent; }
            set {  recalctribent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGIONAL
        /// Coment�rio: 
        /// </summary>
        private string regional;
        [XmlElement(ElementName = "REGIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Regional
        {
            get { return  regional; }
            set {  regional = value; }
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
        /// Propriedade referente ao campo: RG
        /// Coment�rio: 
        /// </summary>
        private string rg;
        [XmlElement(ElementName = "RG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rg
        {
            get { return  rg; }
            set {  rg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RGCONTATOVERBA
        /// Coment�rio: 
        /// </summary>
        private string rgcontatoverba;
        [XmlElement(ElementName = "RGCONTATOVERBA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rgcontatoverba
        {
            get { return  rgcontatoverba; }
            set {  rgcontatoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPLESNACIONAL
        /// Coment�rio: Indica optante pelo simples nacional.
        /// </summary>
        private string simplesnacional;
        [XmlElement(ElementName = "SIMPLESNACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Simplesnacional
        {
            get { return  simplesnacional; }
            set {  simplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBENTADJUD
        /// Coment�rio: Sit.Tribut�ria Adjudica��o
        /// </summary>
        private string sittribentadjud;
        [XmlElement(ElementName = "SITTRIBENTADJUD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribentadjud
        {
            get { return  sittribentadjud; }
            set {  sittribentadjud = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBRESTITUICAO
        /// Coment�rio: Sit.Tribut�ria Restitui��o
        /// </summary>
        private string sittribrestituicao;
        [XmlElement(ElementName = "SITTRIBRESTITUICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribrestituicao
        {
            get { return  sittribrestituicao; }
            set {  sittribrestituicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMAFRETEFOBNOSTFORANF
        /// Coment�rio: 
        /// </summary>
        private string somafretefobnostforanf;
        [XmlElement(ElementName = "SOMAFRETEFOBNOSTFORANF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somafretefobnostforanf
        {
            get { return  somafretefobnostforanf; }
            set {  somafretefobnostforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUFRAMA
        /// Coment�rio: 
        /// </summary>
        private string suframa;
        [XmlElement(ElementName = "SUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Suframa
        {
            get { return  suframa; }
            set {  suframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUP_CELULAR
        /// Coment�rio: 
        /// </summary>
        private string sup_celular;
        [XmlElement(ElementName = "SUP_CELULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Sup_Celular
        {
            get { return  sup_celular; }
            set {  sup_celular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUP_EMAIL
        /// Coment�rio: 
        /// </summary>
        private string sup_email;
        [XmlElement(ElementName = "SUP_EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Sup_Email
        {
            get { return  sup_email; }
            set {  sup_email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUPERVISORVERBA
        /// Coment�rio: 
        /// </summary>
        private string supervisorverba;
        [XmlElement(ElementName = "SUPERVISORVERBA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Supervisorverba
        {
            get { return  supervisorverba; }
            set {  supervisorverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXAEMISSAOCT
        /// Coment�rio: Taxa de emiss�o de conhecimento de transporte.
        /// </summary>
        private decimal taxaemissaoct;
        [XmlElement(ElementName = "TAXAEMISSAOCT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Taxaemissaoct
        {
            get { return  taxaemissaoct; }
            set {  taxaemissaoct = value; }
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
        /// Propriedade referente ao campo: TELCOB
        /// Coment�rio: 
        /// </summary>
        private string telcob;
        [XmlElement(ElementName = "TELCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telcob
        {
            get { return  telcob; }
            set {  telcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONEADM
        /// Coment�rio: 
        /// </summary>
        private string telefoneadm;
        [XmlElement(ElementName = "TELEFONEADM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telefoneadm
        {
            get { return  telefoneadm; }
            set {  telefoneadm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONECOM
        /// Coment�rio: 
        /// </summary>
        private string telefonecom;
        [XmlElement(ElementName = "TELEFONECOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telefonecom
        {
            get { return  telefonecom; }
            set {  telefonecom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEXFAB
        /// Coment�rio: 
        /// </summary>
        private string telexfab;
        [XmlElement(ElementName = "TELEXFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telexfab
        {
            get { return  telexfab; }
            set {  telexfab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEXREP
        /// Coment�rio: 
        /// </summary>
        private string telexrep;
        [XmlElement(ElementName = "TELEXREP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telexrep
        {
            get { return  telexrep; }
            set {  telexrep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELFAB
        /// Coment�rio: 
        /// </summary>
        private string telfab;
        [XmlElement(ElementName = "TELFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telfab
        {
            get { return  telfab; }
            set {  telfab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELREP
        /// Coment�rio: 
        /// </summary>
        private string telrep;
        [XmlElement(ElementName = "TELREP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telrep
        {
            get { return  telrep; }
            set {  telrep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal tipocalcfrete;
        [XmlElement(ElementName = "TIPOCALCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipocalcfrete
        {
            get { return  tipocalcfrete; }
            set {  tipocalcfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMPEDIDO
        /// Coment�rio: 
        /// </summary>
        private string tipoembalagempedido;
        [XmlElement(ElementName = "TIPOEMBALAGEMPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagempedido
        {
            get { return  tipoembalagempedido; }
            set {  tipoembalagempedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFINANCDEVFORNEC
        /// Coment�rio: Forma de Pagamento Devolu��o Fornecedor
        /// </summary>
        private decimal tipofinancdevfornec;
        [XmlElement(ElementName = "TIPOFINANCDEVFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipofinancdevfornec
        {
            get { return  tipofinancdevfornec; }
            set {  tipofinancdevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFORNEC
        /// Coment�rio: 
        /// </summary>
        private string tipofornec;
        [XmlElement(ElementName = "TIPOFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofornec
        {
            get { return  tipofornec; }
            set {  tipofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETECIFFOB
        /// Coment�rio: 
        /// </summary>
        private string tipofreteciffob;
        [XmlElement(ElementName = "TIPOFRETECIFFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofreteciffob
        {
            get { return  tipofreteciffob; }
            set {  tipofreteciffob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPESSOA
        /// Coment�rio: Campo para armazenar o tipo de pessoa (F-F�sica ou J-Jur�dica). 
        /// </summary>
        private string tipopessoa;
        [XmlElement(ElementName = "TIPOPESSOA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopessoa
        {
            get { return  tipopessoa; }
            set {  tipopessoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSPAUTONOMO
        /// Coment�rio: Informa se a transportadora � aut�noma ou n�o.
        /// </summary>
        private string transpautonomo;
        [XmlElement(ElementName = "TRANSPAUTONOMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Transpautonomo
        {
            get { return  transpautonomo; }
            set {  transpautonomo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSPORTEPROPRIO
        /// Coment�rio: 
        /// </summary>
        private string transporteproprio;
        [XmlElement(ElementName = "TRANSPORTEPROPRIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Transporteproprio
        {
            get { return  transporteproprio; }
            set {  transporteproprio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACREDPISCOFINSENTBONIFIC
        /// Coment�rio: Fornecedor utiliza cr�dito PIS/COFINS entrada bonificada
        /// </summary>
        private string usacredpiscofinsentbonific;
        [XmlElement(ElementName = "USACREDPISCOFINSENTBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacredpiscofinsentbonific
        {
            get { return  usacredpiscofinsentbonific; }
            set {  usacredpiscofinsentbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAFRETEFOBPORFORNEC
        /// Coment�rio: Define se o Frete FOB � por Fornecedor, onde os valores ser�o definidos no cadastro do Fornecedor(Auto Pe�as).
        /// </summary>
        private string usafretefobporfornec;
        [XmlElement(ElementName = "USAFRETEFOBPORFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usafretefobporfornec
        {
            get { return  usafretefobporfornec; }
            set {  usafretefobporfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANUMNEGOCIACAO
        /// Coment�rio: Indica se utiliza o n�mero de negocia��o.
        /// </summary>
        private string usanumnegociacao;
        [XmlElement(ElementName = "USANUMNEGOCIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanumnegociacao
        {
            get { return  usanumnegociacao; }
            set {  usanumnegociacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAOUTRASDESPSEGUROPISCOFINS
        /// Coment�rio: Somar outras despesas e seguros na base PIS/COFINS
        /// </summary>
        private string usaoutrasdespseguropiscofins;
        [XmlElement(ElementName = "USAOUTRASDESPSEGUROPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaoutrasdespseguropiscofins
        {
            get { return  usaoutrasdespseguropiscofins; }
            set {  usaoutrasdespseguropiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCALTERCUSTOENT
        /// Coment�rio: Utiliza o percentual de custo na entrada. 
        /// </summary>
        private string usapercaltercustoent;
        [XmlElement(ElementName = "USAPERCALTERCUSTOENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercaltercustoent
        {
            get { return  usapercaltercustoent; }
            set {  usapercaltercustoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCICMSNAALIQEXTST
        /// Coment�rio: Considera frete FOB para o calculo do ICMS antecipado.
        /// </summary>
        private string usapercicmsnaaliqextst;
        [XmlElement(ElementName = "USAPERCICMSNAALIQEXTST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercicmsnaaliqextst
        {
            get { return  usapercicmsnaaliqextst; }
            set {  usapercicmsnaaliqextst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZADESCCALCICMS
        /// Coment�rio: Esse campo ser� utilizada pelas rotinas de pedido de compra, fornecedor e entrada de mercadoria quando esse campo possuir o valor igual a [S] os descontos comerciais ser�o utilizados ICMS.
        /// </summary>
        private string utilizadesccalcicms;
        [XmlElement(ElementName = "UTILIZADESCCALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadesccalcicms
        {
            get { return  utilizadesccalcicms; }
            set {  utilizadesccalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZADESCCALCIPI
        /// Coment�rio: 
        /// </summary>
        private string utilizadesccalcipi;
        [XmlElement(ElementName = "UTILIZADESCCALCIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadesccalcipi
        {
            get { return  utilizadesccalcipi; }
            set {  utilizadesccalcipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZADESCCALCST
        /// Coment�rio: Esse campo ser� utilizada pelas rotinas de pedido de compra, fornecedor e entrada de mercadoria quando esse campo possuir o valor igual a [S] os descontos comerciais ser�o utilizados Substitui��o Tribut�ria (ST).
        /// </summary>
        private string utilizadesccalcst;
        [XmlElement(ElementName = "UTILIZADESCCALCST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadesccalcst
        {
            get { return  utilizadesccalcst; }
            set {  utilizadesccalcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAFRETECALCICMS
        /// Coment�rio: 
        /// </summary>
        private string utilizafretecalcicms;
        [XmlElement(ElementName = "UTILIZAFRETECALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizafretecalcicms
        {
            get { return  utilizafretecalcicms; }
            set {  utilizafretecalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAFRETECALCIPI
        /// Coment�rio: 
        /// </summary>
        private string utilizafretecalcipi;
        [XmlElement(ElementName = "UTILIZAFRETECALCIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizafretecalcipi
        {
            get { return  utilizafretecalcipi; }
            set {  utilizafretecalcipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAIPICALCICMS
        /// Coment�rio: Utiliza IPI no calculo de ICMS
        /// </summary>
        private string utilizaipicalcicms;
        [XmlElement(ElementName = "UTILIZAIPICALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaipicalcicms
        {
            get { return  utilizaipicalcicms; }
            set {  utilizaipicalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTDESPCALCSUFRAMA
        /// Coment�rio: Utiliza outras despesa para calculo do desconto SUFRAMA.
        /// </summary>
        private string utilizaoutdespcalcsuframa;
        [XmlElement(ElementName = "UTILIZAOUTDESPCALCSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutdespcalcsuframa
        {
            get { return  utilizaoutdespcalcsuframa; }
            set {  utilizaoutdespcalcsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTDESPNFBASEST
        /// Coment�rio: Caso este par�metro esteja igual Sim,  o valor de Outras Despesas NF + Seguro, ser�o considerados na base de calculo do ST.
        /// </summary>
        private string utilizaoutdespnfbasest;
        [XmlElement(ElementName = "UTILIZAOUTDESPNFBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutdespnfbasest
        {
            get { return  utilizaoutdespnfbasest; }
            set {  utilizaoutdespnfbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTRASDESPCALCICMS
        /// Coment�rio: 
        /// </summary>
        private string utilizaoutrasdespcalcicms;
        [XmlElement(ElementName = "UTILIZAOUTRASDESPCALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutrasdespcalcicms
        {
            get { return  utilizaoutrasdespcalcicms; }
            set {  utilizaoutrasdespcalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTRASDESPCALCIPI
        /// Coment�rio: Utilizado na rotina 209 e 1301, caso o valor seja igual a "S" ser� utilizado o valor de outras despesas para c�lculo de IPI.
        /// </summary>
        private string utilizaoutrasdespcalcipi;
        [XmlElement(ElementName = "UTILIZAOUTRASDESPCALCIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutrasdespcalcipi
        {
            get { return  utilizaoutrasdespcalcipi; }
            set {  utilizaoutrasdespcalcipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPERCBON
        /// Coment�rio: 
        /// </summary>
        private string utilizapercbon;
        [XmlElement(ElementName = "UTILIZAPERCBON", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizapercbon
        {
            get { return  utilizapercbon; }
            set {  utilizapercbon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDEDUCAOIRRF
        /// Coment�rio: 
        /// </summary>
        private decimal valordeducaoirrf;
        [XmlElement(ElementName = "VALORDEDUCAOIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valordeducaoirrf
        {
            get { return  valordeducaoirrf; }
            set {  valordeducaoirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEKG
        /// Coment�rio: 
        /// </summary>
        private decimal vlfretekg;
        [XmlElement(ElementName = "VLFRETEKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfretekg
        {
            get { return  vlfretekg; }
            set {  vlfretekg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLIMITEFRETEMIN
        /// Coment�rio: 
        /// </summary>
        private decimal vllimitefretemin;
        [XmlElement(ElementName = "VLLIMITEFRETEMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vllimitefretemin
        {
            get { return  vllimitefretemin; }
            set {  vllimitefretemin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINPEDCOMPRA
        /// Coment�rio: 
        /// </summary>
        private decimal vlminpedcompra;
        [XmlElement(ElementName = "VLMINPEDCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlminpedcompra
        {
            get { return  vlminpedcompra; }
            set {  vlminpedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINPEDREPOSICAO
        /// Coment�rio: Vl. M�n. Pedido Reposi��o.
        /// </summary>
        private decimal vlminpedreposicao;
        [XmlElement(ElementName = "VLMINPEDREPOSICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Vlminpedreposicao
        {
            get { return  vlminpedreposicao; }
            set {  vlminpedreposicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPEDAGIO
        /// Coment�rio: 
        /// </summary>
        private decimal vlpedagio;
        [XmlElement(ElementName = "VLPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpedagio
        {
            get { return  vlpedagio; }
            set {  vlpedagio = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFornec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORNEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFornec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFornec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFornec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFornec>(where);
        }

        #endregion
    }
}
