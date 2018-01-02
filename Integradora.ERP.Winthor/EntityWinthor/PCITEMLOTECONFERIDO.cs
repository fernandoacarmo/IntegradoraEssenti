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
    /// Classe referente a tabela PCItemloteconferido
    /// </summary>
    [XmlType("PCITEMLOTECONFERIDO")]
    public class PCItemloteconferido : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIARORIGINAL
        /// Comentário: 
        /// </summary>
        private decimal codauxiliaroriginal;
        [XmlElement(ElementName = "CODAUXILIARORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliaroriginal
        {
            get { return  codauxiliaroriginal; }
            set {  codauxiliaroriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCERTIFIC
        /// Comentário: Indica o código do certif que o lote em conferencia esta vinculado.
        /// </summary>
        private decimal codcertific;
        [XmlElement(ElementName = "CODCERTIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcertific
        {
            get { return  codcertific; }
            set {  codcertific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Comentário: 
        /// </summary>
        private decimal codfuncconf;
        [XmlElement(ElementName = "CODFUNCCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconf
        {
            get { return  codfuncconf; }
            set {  codfuncconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSEP
        /// Comentário: 
        /// </summary>
        private decimal codfuncsep;
        [XmlElement(ElementName = "CODFUNCSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncsep
        {
            get { return  codfuncsep; }
            set {  codfuncsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
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
        /// Propriedade referente ao campo: DATACONF
        /// Comentário: 
        /// </summary>
        private DateTime? dataconf;
        [XmlElement(ElementName = "DATACONF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataconf
        {
            get { return  dataconf; }
            set {  dataconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: data validade
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
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: 
        /// </summary>
        private string numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: Número do Carregamento.
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Número de sequencia.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVOLUMESCONFERENCIA
        /// Comentário: Indica a quantidade de volumes confereido de itens.
        /// </summary>
        private decimal numvolumesconferencia;
        [XmlElement(ElementName = "NUMVOLUMESCONFERENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvolumesconferencia
        {
            get { return  numvolumesconferencia; }
            set {  numvolumesconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTOANTECIPADO
        /// Comentário: 
        /// </summary>
        private string pagtoantecipado;
        [XmlElement(ElementName = "PAGTOANTECIPADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtoantecipado
        {
            get { return  pagtoantecipado; }
            set {  pagtoantecipado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONF
        /// Comentário: 
        /// </summary>
        private decimal qtconf;
        [XmlElement(ElementName = "QTCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtconf
        {
            get { return  qtconf; }
            set {  qtconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTINDUZIDA
        /// Comentário: Quantidade induzida no mapa de separação
        /// </summary>
        private decimal qtinduzida;
        [XmlElement(ElementName = "QTINDUZIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtinduzida
        {
            get { return  qtinduzida; }
            set {  qtinduzida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Comentário: Quantidade reservada do lote na conferência do pedido.
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Qtreserv
        {
            get { return  qtreserv; }
            set {  qtreserv = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCItemloteconferido()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCITEMLOTECONFERIDO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCItemloteconferido> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCItemloteconferido>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCItemloteconferido> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCItemloteconferido>(where);
        }

        #endregion
    }
}
