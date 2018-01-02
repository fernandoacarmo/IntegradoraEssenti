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
    /// Classe referente a tabela PCMovcr
    /// </summary>
    [XmlType("PCMOVCR")]
    public class PCMovcr : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente associado ao DNI.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
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
        /// Propriedade referente ao campo: CODCONTACRED
        /// Coment�rio: 
        /// </summary>
        private decimal? codcontacred;
        [XmlElement(ElementName = "CODCONTACRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codcontacred
        {
            get { return  codcontacred; }
            set {  codcontacred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADEB
        /// Coment�rio: 
        /// </summary>
        private decimal? codcontadeb;
        [XmlElement(ElementName = "CODCONTADEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codcontadeb
        {
            get { return  codcontadeb; }
            set {  codcontadeb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCRECLI
        /// Coment�rio: Indica o cr�dito de cliente.
        /// </summary>
        private decimal codcrecli;
        [XmlElement(ElementName = "CODCRECLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcrecli
        {
            get { return  codcrecli; }
            set {  codcrecli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial.
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
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCONCIL
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncconcil;
        [XmlElement(ElementName = "CODFUNCCONCIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconcil
        {
            get { return  codfuncconcil; }
            set {  codfuncconcil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDNICLI
        /// Coment�rio: C�digo do funcion�rio respons�vel por associar o cliente ao deposito DNI.
        /// </summary>
        private decimal codfuncdnicli;
        [XmlElement(ElementName = "CODFUNCDNICLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncdnicli
        {
            get { return  codfuncdnicli; }
            set {  codfuncdnicli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCESTORNOCONCIL
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncestornoconcil;
        [XmlElement(ElementName = "CODFUNCESTORNOCONCIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncestornoconcil
        {
            get { return  codfuncestornoconcil; }
            set {  codfuncestornoconcil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINALANC
        /// Coment�rio: 
        /// </summary>
        private decimal codrotinalanc;
        [XmlElement(ElementName = "CODROTINALANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotinalanc
        {
            get { return  codrotinalanc; }
            set {  codrotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCILIACAO
        /// Coment�rio: 
        /// </summary>
        private string conciliacao;
        [XmlElement(ElementName = "CONCILIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Conciliacao
        {
            get { return  conciliacao; }
            set {  conciliacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACOMPLETA
        /// Coment�rio: Grava a data completa da movimenta��o.
        /// </summary>
        private DateTime? datacompleta;
        [XmlElement(ElementName = "DATACOMPLETA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacompleta
        {
            get { return  datacompleta; }
            set {  datacompleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTASSOCIADNICLI
        /// Coment�rio: Data em que foi realizada a associa��o entre o DNI e Cliente.
        /// </summary>
        private DateTime? dtassociadnicli;
        [XmlElement(ElementName = "DTASSOCIADNICLI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtassociadnicli
        {
            get { return  dtassociadnicli; }
            set {  dtassociadnicli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOMPENSACAO
        /// Coment�rio: Data de compensa��o do lan�amento, informada pelo usu�rio. Gravado na rotina 604.
        /// </summary>
        private DateTime? dtcompensacao;
        [XmlElement(ElementName = "DTCOMPENSACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcompensacao
        {
            get { return  dtcompensacao; }
            set {  dtcompensacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONCIL
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtconcil;
        [XmlElement(ElementName = "DTCONCIL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtconcil
        {
            get { return  dtconcil; }
            set {  dtconcil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONTABIL
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcontabil;
        [XmlElement(ElementName = "DTCONTABIL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcontabil
        {
            get { return  dtcontabil; }
            set {  dtcontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtestorno;
        [XmlElement(ElementName = "DTESTORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestorno
        {
            get { return  dtestorno; }
            set {  dtestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNOLANC
        /// Coment�rio: Data de exclus�o de movimenta��o de DNI
        /// </summary>
        private DateTime? dtestornolanc;
        [XmlElement(ElementName = "DTESTORNOLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestornolanc
        {
            get { return  dtestornolanc; }
            set {  dtestornolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexportacaoservint;
        [XmlElement(ElementName = "DTEXPORTACAOSERVINT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaoservint
        {
            get { return  dtexportacaoservint; }
            set {  dtexportacaoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtimportacaoservprinc;
        [XmlElement(ElementName = "DTIMPORTACAOSERVPRINC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaoservprinc
        {
            get { return  dtimportacaoservprinc; }
            set {  dtimportacaoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCTICKT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvenctickt;
        [XmlElement(ElementName = "DTVENCTICKT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenctickt
        {
            get { return  dtvenctickt; }
            set {  dtvenctickt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DUPLICBAIXA
        /// Coment�rio: N�mero da duplicata utilizada na baixa do lan�amento. 
        /// </summary>
        private decimal duplicbaixa;
        [XmlElement(ElementName = "DUPLICBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Duplicbaixa
        {
            get { return  duplicbaixa; }
            set {  duplicbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTORNO
        /// Coment�rio: 
        /// </summary>
        private string estorno;
        [XmlElement(ElementName = "ESTORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estorno
        {
            get { return  estorno; }
            set {  estorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Coment�rio: 
        /// </summary>
        private string exportadoservint;
        [XmlElement(ElementName = "EXPORTADOSERVINT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadoservint
        {
            get { return  exportadoservint; }
            set {  exportadoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Coment�rio: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,200)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO2
        /// Coment�rio: 
        /// </summary>
        private string historico2;
        [XmlElement(ElementName = "HISTORICO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Historico2
        {
            get { return  historico2; }
            set {  historico2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: 
        /// </summary>
        private decimal hora;
        [XmlElement(ElementName = "HORA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private string importadoservprinc;
        [XmlElement(ElementName = "IMPORTADOSERVPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoservprinc
        {
            get { return  importadoservprinc; }
            set {  importadoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICE
        /// Coment�rio: 
        /// </summary>
        private string indice;
        [XmlElement(ElementName = "INDICE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Indice
        {
            get { return  indice; }
            set {  indice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Coment�rio: 
        /// </summary>
        private decimal minuto;
        [XmlElement(ElementName = "MINUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Minuto
        {
            get { return  minuto; }
            set {  minuto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMASSOCDNI
        /// Coment�rio: N�mero de associa��o de DNI com titulos
        /// </summary>
        private decimal numassocdni;
        [XmlElement(ElementName = "NUMASSOCDNI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numassocdni
        {
            get { return  numassocdni; }
            set {  numassocdni = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARR
        /// Coment�rio: 
        /// </summary>
        private decimal? numcarr;
        [XmlElement(ElementName = "NUMCARR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Numcarr
        {
            get { return  numcarr; }
            set {  numcarr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARREG
        /// Coment�rio: N�mero do Carregamento, conforme informado na [631 - Lan�amento de Depesas/Receitas].
        /// </summary>
        private decimal? numcarreg;
        [XmlElement(ElementName = "NUMCARREG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numcarreg
        {
            get { return  numcarreg; }
            set {  numcarreg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Coment�rio: 
        /// </summary>
        private string numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCX
        /// Coment�rio: 
        /// </summary>
        private decimal numcx;
        [XmlElement(ElementName = "NUMCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcx
        {
            get { return  numcx; }
            set {  numcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOC
        /// Coment�rio: N�mero de identifica��o DNI
        /// </summary>
        private string numdoc;
        [XmlElement(ElementName = "NUMDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numdoc
        {
            get { return  numdoc; }
            set {  numdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANC
        /// Coment�rio: 
        /// </summary>
        private decimal numlanc;
        [XmlElement(ElementName = "NUMLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numlanc
        {
            get { return  numlanc; }
            set {  numlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: N�mero sequencial de inser��o na tabela PCMOVCR.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Coment�rio: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSECF
        /// Coment�rio: 
        /// </summary>
        private decimal? numtransecf;
        [XmlElement(ElementName = "NUMTRANSECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransecf
        {
            get { return  numtransecf; }
            set {  numtransecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSEST
        /// Coment�rio: 
        /// </summary>
        private decimal? numtransest;
        [XmlElement(ElementName = "NUMTRANSEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransest
        {
            get { return  numtransest; }
            set {  numtransest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVALEECF
        /// Coment�rio: 
        /// </summary>
        private decimal? numvaleecf;
        [XmlElement(ElementName = "NUMVALEECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numvaleecf
        {
            get { return  numvaleecf; }
            set {  numvaleecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Coment�rio: 
        /// </summary>
        private decimal? operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTBAIXA
        /// Coment�rio: N�mero da presta��o da duplicata utilizada na baixa do lan�amento. 
        /// </summary>
        private string prestbaixa;
        [XmlElement(ElementName = "PRESTBAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prestbaixa
        {
            get { return  prestbaixa; }
            set {  prestbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOTMP
        /// Coment�rio: 
        /// </summary>
        private decimal? saldotmp;
        [XmlElement(ElementName = "SALDOTMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Saldotmp
        {
            get { return  saldotmp; }
            set {  saldotmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: 
        /// </summary>
        private decimal? valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal? Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCAIXA
        /// Coment�rio: Valor movimenta��o financeira t�tulos acertados rotina 403 onde a cobran�a n�o seja baixa autom�tica.
        /// </summary>
        private decimal? valorcaixa;
        [XmlElement(ElementName = "VALORCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Valorcaixa
        {
            get { return  valorcaixa; }
            set {  valorcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALDO
        /// Coment�rio: 
        /// </summary>
        private decimal? vlsaldo;
        [XmlElement(ElementName = "VLSALDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,16)]
        public decimal? Vlsaldo
        {
            get { return  vlsaldo; }
            set {  vlsaldo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALDOCONCIL
        /// Coment�rio: 
        /// </summary>
        private decimal? vlsaldoconcil;
        [XmlElement(ElementName = "VLSALDOCONCIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Vlsaldoconcil
        {
            get { return  vlsaldoconcil; }
            set {  vlsaldoconcil = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMovcr()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVCR";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovcr> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovcr>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMovcr> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovcr>(where);
        }

        #endregion
    }
}
