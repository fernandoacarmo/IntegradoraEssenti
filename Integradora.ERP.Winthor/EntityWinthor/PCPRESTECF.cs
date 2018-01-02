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
    /// Classe referente a tabela PCPrestecf
    /// </summary>
    [XmlType("PCPRESTECF")]
    public class PCPrestecf : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: BOLETO
        /// Coment�rio: 
        /// </summary>
        private string boleto;
        [XmlElement(ElementName = "BOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Boleto
        {
            get { return  boleto; }
            set {  boleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAOCRM
        /// Coment�rio: N�mero cart�o CRM
        /// </summary>
        private string cartaocrm;
        [XmlElement(ElementName = "CARTAOCRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public string Cartaocrm
        {
            get { return  cartaocrm; }
            set {  cartaocrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCPFCH
        /// Coment�rio: CGC ou CPF do cheque
        /// </summary>
        private string cgccpfch;
        [XmlElement(ElementName = "CGCCPFCH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgccpfch
        {
            get { return  cgccpfch; }
            set {  cgccpfch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODADMCARTAO
        /// Coment�rio: C�digo da administradora que efetuou a transa��o. 
        /// </summary>
        private string codadmcartao;
        [XmlElement(ElementName = "CODADMCARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codadmcartao
        {
            get { return  codadmcartao; }
            set {  codadmcartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAOTEF
        /// Coment�rio: Campo para armazenar o c�digo de autoriza��o da venda TEF.
        /// </summary>
        private decimal codautorizacaotef;
        [XmlElement(ElementName = "CODAUTORIZACAOTEF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codautorizacaotef
        {
            get { return  codautorizacaotef; }
            set {  codautorizacaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANDEIRATEF
        /// Coment�rio: C�digo da Bandeira do Cart�o Tef.
        /// </summary>
        private string codbandeiratef;
        [XmlElement(ElementName = "CODBANDEIRATEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Codbandeiratef
        {
            get { return  codbandeiratef; }
            set {  codbandeiratef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Coment�rio: 
        /// </summary>
        private string codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBORIG
        /// Coment�rio: 
        /// </summary>
        private string codcoborig;
        [XmlElement(ElementName = "CODCOBORIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcoborig
        {
            get { return  codcoborig; }
            set {  codcoborig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCRED
        /// Coment�rio: C�digo do Cr�dito utilizado no pagamento
        /// </summary>
        private decimal codcred;
        [XmlElement(ElementName = "CODCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcred
        {
            get { return  codcred; }
            set {  codcred = value; }
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
        /// Propriedade referente ao campo: CODFUNCCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccheckout;
        [XmlElement(ElementName = "CODFUNCCHECKOUT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunccheckout
        {
            get { return  codfunccheckout; }
            set {  codfunccheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAGTONFCE
        /// Coment�rio: C�digo da Forma de Pagamento.
        /// </summary>
        private decimal codpagtonfce;
        [XmlElement(ElementName = "CODPAGTONFCE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codpagtonfce
        {
            get { return  codpagtonfce; }
            set {  codpagtonfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Coment�rio: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPENSACAOBCO
        /// Coment�rio: Cod. Compensa��o do banco
        /// </summary>
        private decimal compensacaobco;
        [XmlElement(ElementName = "COMPENSACAOBCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Compensacaobco
        {
            get { return  compensacaobco; }
            set {  compensacaobco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBAIXA
        /// Coment�rio: Indica a data da baixa do titulo.
        /// </summary>
        private DateTime? dtbaixa;
        [XmlElement(ElementName = "DTBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbaixa
        {
            get { return  dtbaixa; }
            set {  dtbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Coment�rio: Data em que a exporta��o do BD local ocorreu.
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCORIG
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvencorig;
        [XmlElement(ElementName = "DTVENCORIG", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtvencorig
        {
            get { return  dtvencorig; }
            set {  dtvencorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DUPLIC
        /// Coment�rio: 
        /// </summary>
        private decimal duplic;
        [XmlElement(ElementName = "DUPLIC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Duplic
        {
            get { return  duplic; }
            set {  duplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVAGENCIA
        /// Coment�rio: Digito Verificador Agencia
        /// </summary>
        private decimal dvagencia;
        [XmlElement(ElementName = "DVAGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvagencia
        {
            get { return  dvagencia; }
            set {  dvagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCHEQUE
        /// Coment�rio: Digito Verificador Cheque
        /// </summary>
        private decimal dvcheque;
        [XmlElement(ElementName = "DVCHEQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvcheque
        {
            get { return  dvcheque; }
            set {  dvcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCONTA
        /// Coment�rio: Digito Verificador Conta
        /// </summary>
        private decimal dvconta;
        [XmlElement(ElementName = "DVCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvconta
        {
            get { return  dvconta; }
            set {  dvconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: 
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
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
        /// Propriedade referente ao campo: LINHADIG
        /// Coment�rio: Tarja magn�tica do cheque.
        /// </summary>
        private string linhadig;
        [XmlElement(ElementName = "LINHADIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,65)]
        public string Linhadig
        {
            get { return  linhadig; }
            set {  linhadig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUHOST
        /// Coment�rio: N�mero do NSUHOST transa��o de cart�o
        /// </summary>
        private string nsuhost;
        [XmlElement(ElementName = "NSUHOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsuhost
        {
            get { return  nsuhost; }
            set {  nsuhost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUTEF
        /// Coment�rio: 
        /// </summary>
        private string nsutef;
        [XmlElement(ElementName = "NSUTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsutef
        {
            get { return  nsutef; }
            set {  nsutef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIA
        /// Coment�rio: 
        /// </summary>
        private decimal numagencia;
        [XmlElement(ElementName = "NUMAGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Numagencia
        {
            get { return  numagencia; }
            set {  numagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXAFISCAL
        /// Coment�rio: 
        /// </summary>
        private decimal numcaixafiscal;
        [XmlElement(ElementName = "NUMCAIXAFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixafiscal
        {
            get { return  numcaixafiscal; }
            set {  numcaixafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTAOCRM
        /// Coment�rio: N�mero do cart�o CRM
        /// </summary>
        private string numcartaocrm;
        [XmlElement(ElementName = "NUMCARTAOCRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public string Numcartaocrm
        {
            get { return  numcartaocrm; }
            set {  numcartaocrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCF
        /// Coment�rio: Indica o n�mero do CCF.
        /// </summary>
        private decimal numccf;
        [XmlElement(ElementName = "NUMCCF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numccf
        {
            get { return  numccf; }
            set {  numccf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHECKOUT
        /// Coment�rio: 
        /// </summary>
        private decimal numcheckout;
        [XmlElement(ElementName = "NUMCHECKOUT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcheckout
        {
            get { return  numcheckout; }
            set {  numcheckout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Coment�rio: 
        /// </summary>
        private decimal numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTACORRENTE
        /// Coment�rio: 
        /// </summary>
        private decimal numcontacorrente;
        [XmlElement(ElementName = "NUMCONTACORRENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public decimal Numcontacorrente
        {
            get { return  numcontacorrente; }
            set {  numcontacorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMECF
        /// Coment�rio: 
        /// </summary>
        private decimal numecf;
        [XmlElement(ElementName = "NUMECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numecf
        {
            get { return  numecf; }
            set {  numecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGNF
        /// Coment�rio: Geral de opera��o n�o fiscal
        /// </summary>
        private decimal numgnf;
        [XmlElement(ElementName = "NUMGNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numgnf
        {
            get { return  numgnf; }
            set {  numgnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMPEDECF
        /// Coment�rio: 
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Coment�rio: 
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
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
        /// Propriedade referente ao campo: OPERACAO
        /// Coment�rio: 
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELAMENTOTEF
        /// Coment�rio: Indica se os t�tulos foram gravados de acordo com o parcelamento da transa��o TEF. 
        /// </summary>
        private string parcelamentotef;
        [XmlElement(ElementName = "PARCELAMENTOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Parcelamentotef
        {
            get { return  parcelamentotef; }
            set {  parcelamentotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Coment�rio: 
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTECF
        /// Coment�rio: 
        /// </summary>
        private string prestecf;
        [XmlElement(ElementName = "PRESTECF", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Prestecf
        {
            get { return  prestecf; }
            set {  prestecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTTEF
        /// Coment�rio: N�mero da parcela original. 
        /// </summary>
        private decimal presttef;
        [XmlElement(ElementName = "PRESTTEF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Presttef
        {
            get { return  presttef; }
            set {  presttef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPERACAOTEF
        /// Coment�rio: Tipo de Opera��o de Cart�o Tef.
        /// </summary>
        private string tipooperacaotef;
        [XmlElement(ElementName = "TIPOOPERACAOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Tipooperacaotef
        {
            get { return  tipooperacaotef; }
            set {  tipooperacaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORORIG
        /// Coment�rio: 
        /// </summary>
        private decimal valororig;
        [XmlElement(ElementName = "VALORORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valororig
        {
            get { return  valororig; }
            set {  valororig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTXBOLETO
        /// Coment�rio: 
        /// </summary>
        private decimal vltxboleto;
        [XmlElement(ElementName = "VLTXBOLETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltxboleto
        {
            get { return  vltxboleto; }
            set {  vltxboleto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPrestecf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRESTECF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPrestecf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrestecf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPrestecf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrestecf>(where);
        }

        #endregion
    }
}
