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
    /// Classe referente a tabela PCMovrotacli
    /// </summary>
    [XmlType("PCMOVROTACLI")]
    public class PCMovrotacli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CICLOVISITA
        /// Coment�rio: Ciclo de visita
        /// </summary>
        private decimal ciclovisita;
        [XmlElement(ElementName = "CICLOVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ciclovisita
        {
            get { return  ciclovisita; }
            set {  ciclovisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTA
        /// Coment�rio: C�digo do RCA possuidor das rotas antes a transfer�ncia
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�digo do rca
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVISITA
        /// Coment�rio: Recebe o mesmo valor do campo CODVISITA da tabela PCVISITA
        /// </summary>
        private decimal codvisita;
        [XmlElement(ElementName = "CODVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codvisita
        {
            get { return  codvisita; }
            set {  codvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAREF
        /// Coment�rio: Data de refer�ncia
        /// </summary>
        private DateTime? dataref;
        [XmlElement(ElementName = "DATAREF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataref
        {
            get { return  dataref; }
            set {  dataref = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANA
        /// Coment�rio: Dia da semana
        /// </summary>
        private string diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Coment�rio: Data de cancelamento do registro de rotas.
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINAL
        /// Coment�rio: Data incial
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Data final
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTJUSTIFIC
        /// Coment�rio: Data da justificativa de n�o visita / venda
        /// </summary>
        private DateTime? dtjustific;
        [XmlElement(ElementName = "DTJUSTIFIC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtjustific
        {
            get { return  dtjustific; }
            set {  dtjustific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPEDIDO
        /// Coment�rio: Data do �ltimo pedido do cliente
        /// </summary>
        private DateTime? dtpedido;
        [XmlElement(ElementName = "DTPEDIDO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpedido
        {
            get { return  dtpedido; }
            set {  dtpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXVISITA
        /// Coment�rio: Data para qual foi reagendada a visita
        /// </summary>
        private DateTime? dtproxvisita;
        [XmlElement(ElementName = "DTPROXVISITA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxvisita
        {
            get { return  dtproxvisita; }
            set {  dtproxvisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTVISITAPREV
        /// Coment�rio: Recebe o valor do campo DTPROXVISITA antes da altera��o
        /// </summary>
        private DateTime? dtultvisitaprev;
        [XmlElement(ElementName = "DTULTVISITAPREV", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultvisitaprev
        {
            get { return  dtultvisitaprev; }
            set {  dtultvisitaprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVISITAPROG
        /// Coment�rio: Data original programada para a visita
        /// </summary>
        private DateTime? dtvisitaprog;
        [XmlElement(ElementName = "DTVISITAPROG", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtvisitaprog
        {
            get { return  dtvisitaprog; }
            set {  dtvisitaprog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAVISITA
        /// Coment�rio: Hora da visita
        /// </summary>
        private decimal horavisita;
        [XmlElement(ElementName = "HORAVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horavisita
        {
            get { return  horavisita; }
            set {  horavisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOVISITA
        /// Coment�rio: Minuto da visita
        /// </summary>
        private decimal minutovisita;
        [XmlElement(ElementName = "MINUTOVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutovisita
        {
            get { return  minutovisita; }
            set {  minutovisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEMANA
        /// Coment�rio: N�mero referente ao dia da semana
        /// </summary>
        private decimal numsemana;
        [XmlElement(ElementName = "NUMSEMANA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numsemana
        {
            get { return  numsemana; }
            set {  numsemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMZONA
        /// Coment�rio: N�mero da zona
        /// </summary>
        private decimal numzona;
        [XmlElement(ElementName = "NUMZONA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numzona
        {
            get { return  numzona; }
            set {  numzona = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o do vendedor
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODICIDADE
        /// Coment�rio: Periodicidade da visita
        /// </summary>
        private string periodicidade;
        [XmlElement(ElementName = "PERIODICIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Periodicidade
        {
            get { return  periodicidade; }
            set {  periodicidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDO
        /// Coment�rio: Registra a quantidade de vendas realizadas em uma mesma data
        /// </summary>
        private decimal qtpedido;
        [XmlElement(ElementName = "QTPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtpedido
        {
            get { return  qtpedido; }
            set {  qtpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUENCIA
        /// Coment�rio: Sequ�ncia da visita
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQ1
        /// Coment�rio: Sequencia semana e quinzenal
        /// </summary>
        private decimal seq1;
        [XmlElement(ElementName = "SEQ1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seq1
        {
            get { return  seq1; }
            set {  seq1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQ2
        /// Coment�rio: Sequencia semana e quinzenal
        /// </summary>
        private decimal seq2;
        [XmlElement(ElementName = "SEQ2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seq2
        {
            get { return  seq2; }
            set {  seq2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQ3
        /// Coment�rio: C�digo do dia da semna
        /// </summary>
        private decimal seq3;
        [XmlElement(ElementName = "SEQ3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seq3
        {
            get { return  seq3; }
            set {  seq3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVISITA
        /// Coment�rio: Recebe uma lista de valores:
        /// </summary>
        private string tipovisita;
        [XmlElement(ElementName = "TIPOVISITA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovisita
        {
            get { return  tipovisita; }
            set {  tipovisita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAVENDA
        /// Coment�rio: Valor da meta de venda
        /// </summary>
        private decimal vlmetavenda;
        [XmlElement(ElementName = "VLMETAVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmetavenda
        {
            get { return  vlmetavenda; }
            set {  vlmetavenda = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMovrotacli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVROTACLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMovrotacli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovrotacli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMovrotacli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovrotacli>(where);
        }

        #endregion
    }
}
