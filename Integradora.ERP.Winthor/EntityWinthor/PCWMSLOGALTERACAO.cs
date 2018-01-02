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
    /// Classe referente a tabela PCWmslogalteracao
    /// </summary>
    [XmlType("PCWMSLOGALTERACAO")]
    public class PCWmslogalteracao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACAO
        /// Comentário: 
        /// </summary>
        private string acao;
        [XmlElement(ElementName = "ACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Acao
        {
            get { return  acao; }
            set {  acao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICACAO
        /// Comentário: 
        /// </summary>
        private string aplicacao;
        [XmlElement(ElementName = "APLICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Aplicacao
        {
            get { return  aplicacao; }
            set {  aplicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECOANT
        /// Comentário: 
        /// </summary>
        private decimal codenderecoant;
        [XmlElement(ElementName = "CODENDERECOANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codenderecoant
        {
            get { return  codenderecoant; }
            set {  codenderecoant = value; }
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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODANT
        /// Comentário: 
        /// </summary>
        private decimal codprodant;
        [XmlElement(ElementName = "CODPRODANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codprodant
        {
            get { return  codprodant; }
            set {  codprodant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLALOTE
        /// Comentário: 
        /// </summary>
        private string controlalote;
        [XmlElement(ElementName = "CONTROLALOTE", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlalote
        {
            get { return  controlalote; }
            set {  controlalote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
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
        /// Propriedade referente ao campo: DTVALANT
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalant;
        [XmlElement(ElementName = "DTVALANT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalant
        {
            get { return  dtvalant; }
            set {  dtvalant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDUZLOTE
        /// Comentário: 
        /// </summary>
        private string induzlote;
        [XmlElement(ElementName = "INDUZLOTE", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Induzlote
        {
            get { return  induzlote; }
            set {  induzlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAQUINA
        /// Comentário: 
        /// </summary>
        private string maquina;
        [XmlElement(ElementName = "MAQUINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Maquina
        {
            get { return  maquina; }
            set {  maquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAQUINA_REDE
        /// Comentário: 
        /// </summary>
        private string maquina_rede;
        [XmlElement(ElementName = "MAQUINA_REDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Maquina_Rede
        {
            get { return  maquina_rede; }
            set {  maquina_rede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Comentário: 
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
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
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: PROGRAMA
        /// Comentário: 
        /// </summary>
        private string programa;
        [XmlElement(ElementName = "PROGRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Programa
        {
            get { return  programa; }
            set {  programa = value; }
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
        /// Propriedade referente ao campo: QTANT
        /// Comentário: 
        /// </summary>
        private decimal qtant;
        [XmlElement(ElementName = "QTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtant
        {
            get { return  qtant; }
            set {  qtant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDENTRADA
        /// Comentário: 
        /// </summary>
        private decimal qtpendentrada;
        [XmlElement(ElementName = "QTPENDENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpendentrada
        {
            get { return  qtpendentrada; }
            set {  qtpendentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDENTRADAANT
        /// Comentário: 
        /// </summary>
        private decimal qtpendentradaant;
        [XmlElement(ElementName = "QTPENDENTRADAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpendentradaant
        {
            get { return  qtpendentradaant; }
            set {  qtpendentradaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDSAIDA
        /// Comentário: 
        /// </summary>
        private decimal qtpendsaida;
        [XmlElement(ElementName = "QTPENDSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpendsaida
        {
            get { return  qtpendsaida; }
            set {  qtpendsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDSAIDAANT
        /// Comentário: 
        /// </summary>
        private decimal qtpendsaidaant;
        [XmlElement(ElementName = "QTPENDSAIDAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpendsaidaant
        {
            get { return  qtpendsaidaant; }
            set {  qtpendsaidaant = value; }
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

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Comentário: 
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Tabela
        {
            get { return  tabela; }
            set {  tabela = value; }
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
        /// Propriedade referente ao campo: TRIGGER_DISPARADA
        /// Comentário: 
        /// </summary>
        private string trigger_disparada;
        [XmlElement(ElementName = "TRIGGER_DISPARADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Trigger_Disparada
        {
            get { return  trigger_disparada; }
            set {  trigger_disparada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAWMS
        /// Comentário: 
        /// </summary>
        private string usawms;
        [XmlElement(ElementName = "USAWMS", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usawms
        {
            get { return  usawms; }
            set {  usawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO_DB
        /// Comentário: 
        /// </summary>
        private string usuario_db;
        [XmlElement(ElementName = "USUARIO_DB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Usuario_Db
        {
            get { return  usuario_db; }
            set {  usuario_db = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO_OS
        /// Comentário: 
        /// </summary>
        private string usuario_os;
        [XmlElement(ElementName = "USUARIO_OS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Usuario_Os
        {
            get { return  usuario_os; }
            set {  usuario_os = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmslogalteracao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSLOGALTERACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmslogalteracao> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmslogalteracao.GetStringConnection());
            return ba.Listar<PCWmslogalteracao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmslogalteracao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmslogalteracao.GetStringConnection());
            return ba.Existe<PCWmslogalteracao>(where);
        }

        #endregion
    }
}
