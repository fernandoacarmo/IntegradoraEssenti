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
    /// Classe referente a tabela PCInventenderecoi
    /// </summary>
    [XmlType("PCINVENTENDERECOI")]
    public class PCInventenderecoi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZADO
        /// Comentário: 
        /// </summary>
        private string atualizado;
        [XmlElement(ElementName = "ATUALIZADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizado
        {
            get { return  atualizado; }
            set {  atualizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAGEM
        /// Comentário: 
        /// </summary>
        private decimal contagem;
        [XmlElement(ElementName = "CONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Contagem
        {
            get { return  contagem; }
            set {  contagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATADIG
        /// Comentário: 
        /// </summary>
        private DateTime? datadig;
        [XmlElement(ElementName = "DATADIG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datadig
        {
            get { return  datadig; }
            set {  datadig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATADIGINI
        /// Comentário: 
        /// </summary>
        private DateTime? datadigini;
        [XmlElement(ElementName = "DATADIGINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datadigini
        {
            get { return  datadigini; }
            set {  datadigini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? dtcontfim;
        [XmlElement(ElementName = "DTCONTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcontfim
        {
            get { return  dtcontfim; }
            set {  dtcontfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONTINI
        /// Comentário: 
        /// </summary>
        private DateTime? dtcontini;
        [XmlElement(ElementName = "DTCONTINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcontini
        {
            get { return  dtcontini; }
            set {  dtcontini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL
        /// Comentário: 
        /// </summary>
        private DateTime? dtval;
        [XmlElement(ElementName = "DTVAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval
        {
            get { return  dtval; }
            set {  dtval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADEEST
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalidadeest;
        [XmlElement(ElementName = "DTVALIDADEEST", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadeest
        {
            get { return  dtvalidadeest; }
            set {  dtvalidadeest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICADOR
        /// Comentário: IDENTIFICADOR
        /// </summary>
        private string identificador;
        [XmlElement(ElementName = "IDENTIFICADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,70)]
        public string Identificador
        {
            get { return  identificador; }
            set {  identificador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INPUTINVENTARIO
        /// Comentário: 
        /// </summary>
        private string inputinventario;
        [XmlElement(ElementName = "INPUTINVENTARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inputinventario
        {
            get { return  inputinventario; }
            set {  inputinventario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INVENTOS
        /// Comentário: 
        /// </summary>
        private decimal inventos;
        [XmlElement(ElementName = "INVENTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Inventos
        {
            get { return  inventos; }
            set {  inventos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LEGENDA
        /// Comentário: 
        /// </summary>
        private decimal legenda;
        [XmlElement(ElementName = "LEGENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Legenda
        {
            get { return  legenda; }
            set {  legenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATCONT
        /// Comentário: 
        /// </summary>
        private decimal matcont;
        [XmlElement(ElementName = "MATCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matcont
        {
            get { return  matcont; }
            set {  matcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATDIG
        /// Comentário: 
        /// </summary>
        private decimal matdig;
        [XmlElement(ElementName = "MATDIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matdig
        {
            get { return  matdig; }
            set {  matdig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVENT
        /// Comentário: 
        /// </summary>
        private decimal numinvent;
        [XmlElement(ElementName = "NUMINVENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Numinvent
        {
            get { return  numinvent; }
            set {  numinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: Indica o lote referente ao produto contado.
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: Indica o numero de listagem impressas.
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCX
        /// Comentário: 
        /// </summary>
        private decimal qtcx;
        [XmlElement(ElementName = "QTCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtcx
        {
            get { return  qtcx; }
            set {  qtcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEST
        /// Comentário: 
        /// </summary>
        private decimal qtest;
        [XmlElement(ElementName = "QTEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtest
        {
            get { return  qtest; }
            set {  qtest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECAS
        /// Comentário: Qt peças
        /// </summary>
        private decimal qtpecas;
        [XmlElement(ElementName = "QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpecas
        {
            get { return  qtpecas; }
            set {  qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUND
        /// Comentário: 
        /// </summary>
        private decimal qtund;
        [XmlElement(ElementName = "QTUND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtund
        {
            get { return  qtund; }
            set {  qtund = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RF
        /// Comentário: 
        /// </summary>
        private string rf;
        [XmlElement(ElementName = "RF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rf
        {
            get { return  rf; }
            set {  rf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInventenderecoi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINVENTENDERECOI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInventenderecoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInventenderecoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInventenderecoi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInventenderecoi>(where);
        }

        #endregion
    }
}
