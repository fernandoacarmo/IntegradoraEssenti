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
        /// Comentário: 
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
        /// Comentário: Código do cliente associado ao DNI.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o crédito de cliente.
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
        /// Comentário: Indica o código da filial.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código do funcionário responsável por associar o cliente ao deposito DNI.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Grava a data completa da movimentação.
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
        /// Comentário: Data em que foi realizada a associação entre o DNI e Cliente.
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
        /// Comentário: Data de compensação do lançamento, informada pelo usuário. Gravado na rotina 604.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Data de exclusão de movimentação de DNI
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Número da duplicata utilizada na baixa do lançamento. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Número de associação de DNI com titulos
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
        /// Comentário: 
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
        /// Comentário: Número do Carregamento, conforme informado na [631 - Lançamento de Depesas/Receitas].
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Número de identificação DNI
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
        /// Comentário: 
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
        /// Comentário: Número sequencial de inserção na tabela PCMOVCR.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Número da prestação da duplicata utilizada na baixa do lançamento. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Valor movimentação financeira títulos acertados rotina 403 onde a cobrança não seja baixa automática.
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
        /// Comentário: 
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
        /// Comentário: 
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovcr> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovcr>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
