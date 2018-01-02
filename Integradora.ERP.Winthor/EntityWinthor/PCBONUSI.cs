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
    /// Classe referente a tabela PCBonusi
    /// </summary>
    [XmlType("PCBONUSI")]
    public class PCBonusi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: 
        /// </summary>
        private decimal? codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal? codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSOLUCAODIVERGENCIA
        /// Comentário: 
        /// </summary>
        private decimal? codfuncsolucaodivergencia;
        [XmlElement(ElementName = "CODFUNCSOLUCAODIVERGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfuncsolucaodivergencia
        {
            get { return  codfuncsolucaodivergencia; }
            set {  codfuncsolucaodivergencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTIVO
        /// Comentário: 
        /// </summary>
        private decimal? codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFERIDA
        /// Comentário: Utilizado na rotina 1799. 
        /// </summary>
        private string conferida;
        [XmlElement(ElementName = "CONFERIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferida
        {
            get { return  conferida; }
            set {  conferida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFABRICACAO
        /// Comentário: Indica a data de fabricação do item.
        /// </summary>
        private DateTime? datafabricacao;
        [XmlElement(ElementName = "DATAFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafabricacao
        {
            get { return  datafabricacao; }
            set {  datafabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIVERGENCIA
        /// Comentário: 
        /// </summary>
        private string divergencia;
        [XmlElement(ElementName = "DIVERGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Divergencia
        {
            get { return  divergencia; }
            set {  divergencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSOLUCAODIVERGENCIA
        /// Comentário: 
        /// </summary>
        private DateTime? dtsolucaodivergencia;
        [XmlElement(ElementName = "DTSOLUCAODIVERGENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsolucaodivergencia
        {
            get { return  dtsolucaodivergencia; }
            set {  dtsolucaodivergencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTSAIDA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultsaida;
        [XmlElement(ElementName = "DTULTSAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultsaida
        {
            get { return  dtultsaida; }
            set {  dtultsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: 
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
        /// Propriedade referente ao campo: ENDERECADO
        /// Comentário: 
        /// </summary>
        private string enderecado;
        [XmlElement(ElementName = "ENDERECADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enderecado
        {
            get { return  enderecado; }
            set {  enderecado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONO
        /// Comentário: 
        /// </summary>
        private decimal? numbono;
        [XmlElement(ElementName = "NUMBONO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numbono
        {
            get { return  numbono; }
            set {  numbono = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: NÚmero de Sequencia
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSDIVERGENCIA
        /// Comentário: 
        /// </summary>
        private string obsdivergencia;
        [XmlElement(ElementName = "OBSDIVERGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Obsdivergencia
        {
            get { return  obsdivergencia; }
            set {  obsdivergencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIMPUREZA
        /// Comentário: 
        /// </summary>
        private decimal? percimpureza;
        [XmlElement(ElementName = "PERCIMPUREZA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Percimpureza
        {
            get { return  percimpureza; }
            set {  percimpureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINTEIRO
        /// Comentário: 
        /// </summary>
        private decimal? percinteiro;
        [XmlElement(ElementName = "PERCINTEIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Percinteiro
        {
            get { return  percinteiro; }
            set {  percinteiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCQUEBRADO
        /// Comentário: 
        /// </summary>
        private decimal? percquebrado;
        [XmlElement(ElementName = "PERCQUEBRADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Percquebrado
        {
            get { return  percquebrado; }
            set {  percquebrado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCUMIDADE
        /// Comentário: 
        /// </summary>
        private decimal? percumidade;
        [XmlElement(ElementName = "PERCUMIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Percumidade
        {
            get { return  percumidade; }
            set {  percumidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVERMELHO
        /// Comentário: 
        /// </summary>
        private decimal? percvermelho;
        [XmlElement(ElementName = "PERCVERMELHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Percvermelho
        {
            get { return  percvermelho; }
            set {  percvermelho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIA
        /// Comentário: 
        /// </summary>
        private decimal? qtavaria;
        [XmlElement(ElementName = "QTAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtavaria
        {
            get { return  qtavaria; }
            set {  qtavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTAVARIANF
        /// Comentário: 
        /// </summary>
        private decimal? qtavarianf;
        [XmlElement(ElementName = "QTAVARIANF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal? Qtavarianf
        {
            get { return  qtavarianf; }
            set {  qtavarianf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADALIBERADA
        /// Comentário: Quantidade bloqueada liberada.
        /// </summary>
        private string qtbloqueadaliberada;
        [XmlElement(ElementName = "QTBLOQUEADALIBERADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Qtbloqueadaliberada
        {
            get { return  qtbloqueadaliberada; }
            set {  qtbloqueadaliberada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEPECAPESAGEM
        /// Comentário: Qtde. peças na pesagem
        /// </summary>
        private decimal? qtdepecapesagem;
        [XmlElement(ElementName = "QTDEPECAPESAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Qtdepecapesagem
        {
            get { return  qtdepecapesagem; }
            set {  qtdepecapesagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTRADA
        /// Comentário: 
        /// </summary>
        private decimal? qtentrada;
        [XmlElement(ElementName = "QTENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtentrada
        {
            get { return  qtentrada; }
            set {  qtentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGER
        /// Comentário: 
        /// </summary>
        private decimal? qtestger;
        [XmlElement(ElementName = "QTESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtestger
        {
            get { return  qtestger; }
            set {  qtestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEXCESSO
        /// Comentário: 
        /// </summary>
        private decimal? qtexcesso;
        [XmlElement(ElementName = "QTEXCESSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtexcesso
        {
            get { return  qtexcesso; }
            set {  qtexcesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFALTA
        /// Comentário: 
        /// </summary>
        private decimal? qtfalta;
        [XmlElement(ElementName = "QTFALTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtfalta
        {
            get { return  qtfalta; }
            set {  qtfalta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNF
        /// Comentário: 
        /// </summary>
        private decimal? qtnf;
        [XmlElement(ElementName = "QTNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtnf
        {
            get { return  qtnf; }
            set {  qtnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSAIDA
        /// Comentário: 
        /// </summary>
        private decimal? qtsaida;
        [XmlElement(ElementName = "QTSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qtsaida
        {
            get { return  qtsaida; }
            set {  qtsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODIVERGENCIA
        /// Comentário: 
        /// </summary>
        private decimal? tipodivergencia;
        [XmlElement(ElementName = "TIPODIVERGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Tipodivergencia
        {
            get { return  tipodivergencia; }
            set {  tipodivergencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOLERANCIASHELFLIFE
        /// Comentário: 
        /// </summary>
        private decimal? toleranciashelflife;
        [XmlElement(ElementName = "TOLERANCIASHELFLIFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Toleranciashelflife
        {
            get { return  toleranciashelflife; }
            set {  toleranciashelflife = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTARAPORPECA
        /// Comentário: Valor da tara por peça
        /// </summary>
        private decimal? valortaraporpeca;
        [XmlElement(ElementName = "VALORTARAPORPECA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Valortaraporpeca
        {
            get { return  valortaraporpeca; }
            set {  valortaraporpeca = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBonusi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBONUSI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBonusi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBonusi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBonusi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBonusi>(where);
        }

        #endregion
    }
}
