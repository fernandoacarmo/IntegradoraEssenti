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
    /// Classe referente a tabela PCRotina
    /// </summary>
    [XmlType("PCROTINA")]
    public class PCRotina : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACAO
        /// Comentário: 
        /// </summary>
        private string acao;
        [XmlElement(ElementName = "ACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Acao
        {
            get { return  acao; }
            set {  acao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AJUDA
        /// Comentário: 
        /// </summary>
        private string ajuda;
        [XmlElement(ElementName = "AJUDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Ajuda
        {
            get { return  ajuda; }
            set {  ajuda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTMENU
        /// Comentário: 
        /// </summary>
        private decimal autmenu;
        [XmlElement(ElementName = "AUTMENU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Autmenu
        {
            get { return  autmenu; }
            set {  autmenu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTUTIL
        /// Comentário: 
        /// </summary>
        private decimal codfuncultutil;
        [XmlElement(ElementName = "CODFUNCULTUTIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultutil
        {
            get { return  codfuncultutil; }
            set {  codfuncultutil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMODULO
        /// Comentário: 
        /// </summary>
        private decimal codmodulo;
        [XmlElement(ElementName = "CODMODULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codmodulo
        {
            get { return  codmodulo; }
            set {  codmodulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBMODULO
        /// Comentário: 
        /// </summary>
        private decimal codsubmodulo;
        [XmlElement(ElementName = "CODSUBMODULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsubmodulo
        {
            get { return  codsubmodulo; }
            set {  codsubmodulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAEXE
        /// Comentário: 
        /// </summary>
        private DateTime? dataexe;
        [XmlElement(ElementName = "DATAEXE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataexe
        {
            get { return  dataexe; }
            set {  dataexe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPRIUTILIZACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtpriutilizacao;
        [XmlElement(ElementName = "DTPRIUTILIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpriutilizacao
        {
            get { return  dtpriutilizacao; }
            set {  dtpriutilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTUTILIZACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtultutilizacao;
        [XmlElement(ElementName = "DTULTUTILIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultutilizacao
        {
            get { return  dtultutilizacao; }
            set {  dtultutilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTVERSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtultversao;
        [XmlElement(ElementName = "DTULTVERSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultversao
        {
            get { return  dtultversao; }
            set {  dtultversao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRMENU
        /// Comentário: 
        /// </summary>
        private string exibirmenu;
        [XmlElement(ElementName = "EXIBIRMENU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibirmenu
        {
            get { return  exibirmenu; }
            set {  exibirmenu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIID
        /// Comentário: 
        /// </summary>
        private string fiid;
        [XmlElement(ElementName = "FIID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Fiid
        {
            get { return  fiid; }
            set {  fiid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HASHCODEMD5
        /// Comentário: Hashcode MD5 gerado na atualização da rotina.
        /// </summary>
        private string hashcodemd5;
        [XmlElement(ElementName = "HASHCODEMD5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Hashcodemd5
        {
            get { return  hashcodemd5; }
            set {  hashcodemd5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOG
        /// Comentário: 
        /// </summary>
        private string log;
        [XmlElement(ElementName = "LOG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Log
        {
            get { return  log; }
            set {  log = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL
        /// Comentário: 
        /// </summary>
        private decimal nivel;
        [XmlElement(ElementName = "NIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Nivel
        {
            get { return  nivel; }
            set {  nivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEROTINA
        /// Comentário: 
        /// </summary>
        private string nomerotina;
        [XmlElement(ElementName = "NOMEROTINA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nomerotina
        {
            get { return  nomerotina; }
            set {  nomerotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMULTVERSAO
        /// Comentário: 
        /// </summary>
        private decimal numultversao;
        [XmlElement(ElementName = "NUMULTVERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numultversao
        {
            get { return  numultversao; }
            set {  numultversao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUTILIZACAO
        /// Comentário: 
        /// </summary>
        private decimal qtutilizacao;
        [XmlElement(ElementName = "QTUTILIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtutilizacao
        {
            get { return  qtutilizacao; }
            set {  qtutilizacao = value; }
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
        /// Propriedade referente ao campo: UTILIZACONTROLEBIOMETRICO
        /// Comentário: Indica a utiliza controle biometrico.
        /// </summary>
        private string utilizacontrolebiometrico;
        [XmlElement(ElementName = "UTILIZACONTROLEBIOMETRICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacontrolebiometrico
        {
            get { return  utilizacontrolebiometrico; }
            set {  utilizacontrolebiometrico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOCOMPLETA
        /// Comentário: Indica a versão da rotina.|Campo do tipo caracter, de tamanho 20. 
        /// </summary>
        private string versaocompleta;
        [XmlElement(ElementName = "VERSAOCOMPLETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Versaocompleta
        {
            get { return  versaocompleta; }
            set {  versaocompleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOEXEANT
        /// Comentário: Versão anterior da rotina.
        /// </summary>
        private string versaoexeant;
        [XmlElement(ElementName = "VERSAOEXEANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Versaoexeant
        {
            get { return  versaoexeant; }
            set {  versaoexeant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOEXEATUAL
        /// Comentário: Versão atual da rotina
        /// </summary>
        private string versaoexeatual;
        [XmlElement(ElementName = "VERSAOEXEATUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Versaoexeatual
        {
            get { return  versaoexeatual; }
            set {  versaoexeatual = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRotina()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTINA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRotina> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotina>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRotina> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotina>(where);
        }

        #endregion
    }
}
