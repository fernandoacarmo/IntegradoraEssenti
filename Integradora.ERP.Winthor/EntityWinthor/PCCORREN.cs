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
    /// Classe referente a tabela PCCorren
    /// </summary>
    [XmlType("PCCORREN")]
    public class PCCorren : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: COBJUROS
        /// Comentário: 
        /// </summary>
        private string cobjuros;
        [XmlElement(ElementName = "COBJUROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cobjuros
        {
            get { return  cobjuros; }
            set {  cobjuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: 
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITE
        /// Comentário: 
        /// </summary>
        private decimal codemite;
        [XmlElement(ElementName = "CODEMITE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemite
        {
            get { return  codemite; }
            set {  codemite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITEORIG
        /// Comentário: 
        /// </summary>
        private decimal codemiteorig;
        [XmlElement(ElementName = "CODEMITEORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemiteorig
        {
            get { return  codemiteorig; }
            set {  codemiteorig = value; }
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
        /// Propriedade referente ao campo: CODFUNBAIXA
        /// Comentário: Código do funcionário que realizou a baixa
        /// </summary>
        private decimal codfunbaixa;
        [XmlElement(ElementName = "CODFUNBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfunbaixa
        {
            get { return  codfunbaixa; }
            set {  codfunbaixa = value; }
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
        /// Propriedade referente ao campo: CODFUNCORIG
        /// Comentário: 
        /// </summary>
        private decimal codfuncorig;
        [XmlElement(ElementName = "CODFUNCORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncorig
        {
            get { return  codfuncorig; }
            set {  codfuncorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCPRORROG
        /// Comentário: 
        /// </summary>
        private decimal codfuncprorrog;
        [XmlElement(ElementName = "CODFUNCPRORROG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncprorrog
        {
            get { return  codfuncprorrog; }
            set {  codfuncprorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHIST
        /// Comentário: 
        /// </summary>
        private decimal codhist;
        [XmlElement(ElementName = "CODHIST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codhist
        {
            get { return  codhist; }
            set {  codhist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Indica a rotina geradora do Vale. 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERABASECALCULOIMPOSTO
        /// Comentário: Considerar na Base de Cálculo dos Impostos.
        /// </summary>
        private string considerabasecalculoimposto;
        [XmlElement(ElementName = "CONSIDERABASECALCULOIMPOSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerabasecalculoimposto
        {
            get { return  considerabasecalculoimposto; }
            set {  considerabasecalculoimposto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEBNUMCAR
        /// Comentário: 
        /// </summary>
        private decimal debnumcar;
        [XmlElement(ElementName = "DEBNUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Debnumcar
        {
            get { return  debnumcar; }
            set {  debnumcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBAIXAVALE
        /// Comentário: Data de baixa do vale
        /// </summary>
        private DateTime? dtbaixavale;
        [XmlElement(ElementName = "DTBAIXAVALE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbaixavale
        {
            get { return  dtbaixavale; }
            set {  dtbaixavale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDOC
        /// Comentário: 
        /// </summary>
        private DateTime? dtdoc;
        [XmlElement(ElementName = "DTDOC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdoc
        {
            get { return  dtdoc; }
            set {  dtdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTTRANSF
        /// Comentário: 
        /// </summary>
        private DateTime? dttransf;
        [XmlElement(ElementName = "DTTRANSF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dttransf
        {
            get { return  dttransf; }
            set {  dttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: 
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
        /// Comentário: 
        /// </summary>
        private DateTime? dtvencorig;
        [XmlElement(ElementName = "DTVENCORIG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencorig
        {
            get { return  dtvencorig; }
            set {  dtvencorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
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
        [DataObjectField(false,false,true,40)]
        public string Historico2
        {
            get { return  historico2; }
            set {  historico2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBDTACERTOCOMMOT
        /// Comentário: 
        /// </summary>
        private DateTime? hobdtacertocommot;
        [XmlElement(ElementName = "HOBDTACERTOCOMMOT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hobdtacertocommot
        {
            get { return  hobdtacertocommot; }
            set {  hobdtacertocommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBDTACERTOCOMRCA
        /// Comentário: 
        /// </summary>
        private DateTime? hobdtacertocomrca;
        [XmlElement(ElementName = "HOBDTACERTOCOMRCA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hobdtacertocomrca
        {
            get { return  hobdtacertocomrca; }
            set {  hobdtacertocomrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBDTACERTOCOMSUP
        /// Comentário: 
        /// </summary>
        private DateTime? hobdtacertocomsup;
        [XmlElement(ElementName = "HOBDTACERTOCOMSUP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hobdtacertocomsup
        {
            get { return  hobdtacertocomsup; }
            set {  hobdtacertocomsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Comentário: 
        /// </summary>
        private decimal hora;
        [XmlElement(ElementName = "HORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICE
        /// Comentário: 
        /// </summary>
        private string indice;
        [XmlElement(ElementName = "INDICE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
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
        [XmlElement(ElementName = "MINUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minuto
        {
            get { return  minuto; }
            set {  minuto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARREGAMENTOS
        /// Comentário: 
        /// </summary>
        private string numcarregamentos;
        [XmlElement(ElementName = "NUMCARREGAMENTOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Numcarregamentos
        {
            get { return  numcarregamentos; }
            set {  numcarregamentos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOC
        /// Comentário: 
        /// </summary>
        private decimal numdoc;
        [XmlElement(ElementName = "NUMDOC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Numdoc
        {
            get { return  numdoc; }
            set {  numdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSBAIXA
        /// Comentário: Número de transação de baixa.
        /// </summary>
        private decimal numtransbaixa;
        [XmlElement(ElementName = "NUMTRANSBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransbaixa
        {
            get { return  numtransbaixa; }
            set {  numtransbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTDEVCLI
        /// Comentário: 
        /// </summary>
        private decimal numtransentdevcli;
        [XmlElement(ElementName = "NUMTRANSENTDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentdevcli
        {
            get { return  numtransentdevcli; }
            set {  numtransentdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVALE
        /// Comentário: 
        /// </summary>
        private decimal numvale;
        [XmlElement(ElementName = "NUMVALE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Numvale
        {
            get { return  numvale; }
            set {  numvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMLANCAMENTO
        /// Comentário: Origem do lançamento do vale.
        /// </summary>
        private string origemlancamento;
        [XmlElement(ElementName = "ORIGEMLANCAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Origemlancamento
        {
            get { return  origemlancamento; }
            set {  origemlancamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM
        /// Comentário: 
        /// </summary>
        private decimal recnum;
        [XmlElement(ElementName = "RECNUM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Recnum
        {
            get { return  recnum; }
            set {  recnum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFUNC
        /// Comentário: 
        /// </summary>
        private string tipofunc;
        [XmlElement(ElementName = "TIPOFUNC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipofunc
        {
            get { return  tipofunc; }
            set {  tipofunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOLANC
        /// Comentário: 
        /// </summary>
        private string tipolanc;
        [XmlElement(ElementName = "TIPOLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipolanc
        {
            get { return  tipolanc; }
            set {  tipolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALEEXPORTADO
        /// Comentário: Vale exportado para folha de pagamento
        /// </summary>
        private string valeexportado;
        [XmlElement(ElementName = "VALEEXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Valeexportado
        {
            get { return  valeexportado; }
            set {  valeexportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCorren()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCORREN";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCorren> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCorren>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCorren> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCorren>(where);
        }

        #endregion
    }
}
