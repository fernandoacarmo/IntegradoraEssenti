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
    /// Classe referente a tabela PCEstend
    /// </summary>
    [XmlType("PCESTEND")]
    public class PCEstend : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APTO
        /// Comentário: 
        /// </summary>
        private decimal apto;
        [XmlElement(ElementName = "APTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Apto
        {
            get { return  apto; }
            set {  apto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPE
        /// Comentário: 
        /// </summary>
        private string codequipe;
        [XmlElement(ElementName = "CODEQUIPE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codequipe
        {
            get { return  codequipe; }
            set {  codequipe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDESBLOQUEIO
        /// Comentário: 
        /// </summary>
        private decimal codfuncdesbloqueio;
        [XmlElement(ElementName = "CODFUNCDESBLOQUEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncdesbloqueio
        {
            get { return  codfuncdesbloqueio; }
            set {  codfuncdesbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRM
        /// Comentário: 
        /// </summary>
        private decimal codfuncrm;
        [XmlElement(ElementName = "CODFUNCRM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncrm
        {
            get { return  codfuncrm; }
            set {  codfuncrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATABLOQUEIO
        /// Comentário: 
        /// </summary>
        private DateTime? databloqueio;
        [XmlElement(ElementName = "DATABLOQUEIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Databloqueio
        {
            get { return  databloqueio; }
            set {  databloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATADESBLOQUEIO
        /// Comentário: 
        /// </summary>
        private DateTime? datadesbloqueio;
        [XmlElement(ElementName = "DATADESBLOQUEIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datadesbloqueio
        {
            get { return  datadesbloqueio; }
            set {  datadesbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFABRICACAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTULTMOVENT
        /// Comentário: 
        /// </summary>
        private DateTime? dtultmovent;
        [XmlElement(ElementName = "DTULTMOVENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultmovent
        {
            get { return  dtultmovent; }
            set {  dtultmovent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTMOVSAI
        /// Comentário: 
        /// </summary>
        private DateTime? dtultmovsai;
        [XmlElement(ElementName = "DTULTMOVSAI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultmovsai
        {
            get { return  dtultmovsai; }
            set {  dtultmovsai = value; }
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
        /// Propriedade referente ao campo: EMBALAGEM
        /// Comentário: 
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FABRICANTE
        /// Comentário: 
        /// </summary>
        private string fabricante;
        [XmlElement(ElementName = "FABRICANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Fabricante
        {
            get { return  fabricante; }
            set {  fabricante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICACAO
        /// Comentário: 
        /// </summary>
        private string identificacao;
        [XmlElement(ElementName = "IDENTIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Identificacao
        {
            get { return  identificacao; }
            set {  identificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPUREZA
        /// Comentário: 
        /// </summary>
        private string impureza;
        [XmlElement(ElementName = "IMPUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impureza
        {
            get { return  impureza; }
            set {  impureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LAUDO
        /// Comentário: 
        /// </summary>
        private string laudo;
        [XmlElement(ElementName = "LAUDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Laudo
        {
            get { return  laudo; }
            set {  laudo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LAUDOFAB
        /// Comentário: 
        /// </summary>
        private string laudofab;
        [XmlElement(ElementName = "LAUDOFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Laudofab
        {
            get { return  laudofab; }
            set {  laudofab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULO
        /// Comentário: 
        /// </summary>
        private decimal modulo;
        [XmlElement(ElementName = "MODULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Modulo
        {
            get { return  modulo; }
            set {  modulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Comentário: 
        /// </summary>
        private decimal numero;
        [XmlElement(ElementName = "NUMERO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numero
        {
            get { return  numero; }
            set {  numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMLOTEFAB
        /// Comentário: 
        /// </summary>
        private string numlotefab;
        [XmlElement(ElementName = "NUMLOTEFAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlotefab
        {
            get { return  numlotefab; }
            set {  numlotefab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTEFORNEC
        /// Comentário: 
        /// </summary>
        private string numlotefornec;
        [XmlElement(ElementName = "NUMLOTEFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlotefornec
        {
            get { return  numlotefornec; }
            set {  numlotefornec = value; }
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
        /// Propriedade referente ao campo: OBS1
        /// Comentário: 
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Comentário: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtreserv
        {
            get { return  qtreserv; }
            set {  qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Comentário: 
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOALTURAPALETE
        /// Comentário: 
        /// </summary>
        private decimal tipoalturapalete;
        [XmlElement(ElementName = "TIPOALTURAPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoalturapalete
        {
            get { return  tipoalturapalete; }
            set {  tipoalturapalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENDER
        /// Comentário: 
        /// </summary>
        private string tipoender;
        [XmlElement(ElementName = "TIPOENDER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoender
        {
            get { return  tipoender; }
            set {  tipoender = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UMIDADE
        /// Comentário: 
        /// </summary>
        private string umidade;
        [XmlElement(ElementName = "UMIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Umidade
        {
            get { return  umidade; }
            set {  umidade = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEstend()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTEND";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEstend> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstend>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEstend> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstend>(where);
        }

        #endregion
    }
}
