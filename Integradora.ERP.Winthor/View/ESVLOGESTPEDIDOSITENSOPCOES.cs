using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvlogestpedidositensopcoes
    /// </summary>
    [XmlType("ESVLOGESTPEDIDOSITENSOPCOES")]
    public class Esvlogestpedidositensopcoes : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODINSUMO
        /// Coment�rio: 
        /// </summary>
        private decimal codinsumo;
        [XmlElement(ElementName = "CODINSUMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codinsumo
        {
            get { return  codinsumo; }
            set {  codinsumo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Coment�rio: 
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioalt
        {
            get { return  codusuarioalt; }
            set {  codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioinc
        {
            get { return  codusuarioinc; }
            set {  codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOATRIBUIDO
        /// Coment�rio: 
        /// </summary>
        private decimal custoatribuido;
        [XmlElement(ElementName = "CUSTOATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoatribuido
        {
            get { return  custoatribuido; }
            set {  custoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal custoultent;
        [XmlElement(ElementName = "CUSTOULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Custoultent
        {
            get { return  custoultent; }
            set {  custoultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORACAD
        /// Coment�rio: 
        /// </summary>
        private DateTime? datahoracad;
        [XmlElement(ElementName = "DATAHORACAD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahoracad
        {
            get { return  datahoracad; }
            set {  datahoracad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRNAPROPOSTA
        /// Coment�rio: 
        /// </summary>
        private string exibirnaproposta;
        [XmlElement(ElementName = "EXIBIRNAPROPOSTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibirnaproposta
        {
            get { return  exibirnaproposta; }
            set {  exibirnaproposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGACAO
        /// Coment�rio: 
        /// </summary>
        private string logacao;
        [XmlElement(ElementName = "LOGACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Logacao
        {
            get { return  logacao; }
            set {  logacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGDATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? logdata;
        [XmlElement(ElementName = "LOGDATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Logdata
        {
            get { return  logdata; }
            set {  logdata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGPROGRAMA
        /// Coment�rio: 
        /// </summary>
        private string logprograma;
        [XmlElement(ElementName = "LOGPROGRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Logprograma
        {
            get { return  logprograma; }
            set {  logprograma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGUSUARIOOS
        /// Coment�rio: 
        /// </summary>
        private string logusuarioos;
        [XmlElement(ElementName = "LOGUSUARIOOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Logusuarioos
        {
            get { return  logusuarioos; }
            set {  logusuarioos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Coment�rio: 
        /// </summary>
        private decimal numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedido
        {
            get { return  numpedido; }
            set {  numpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Coment�rio: 
        /// </summary>
        private decimal quantidade;
        [XmlElement(ElementName = "QUANTIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Quantidade
        {
            get { return  quantidade; }
            set {  quantidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal valorultent;
        [XmlElement(ElementName = "VALORULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Valorultent
        {
            get { return  valorultent; }
            set {  valorultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal vltabela;
        [XmlElement(ElementName = "VLTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vltabela
        {
            get { return  vltabela; }
            set {  vltabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLUNITARIO
        /// Coment�rio: 
        /// </summary>
        private decimal vlunitario;
        [XmlElement(ElementName = "VLUNITARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlunitario
        {
            get { return  vlunitario; }
            set {  vlunitario = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Esvlogestpedidositensopcoes()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVLOGESTPEDIDOSITENSOPCOES";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Esvlogestpedidositensopcoes> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvlogestpedidositensopcoes.GetStringConnection());
            return ba.Listar<Esvlogestpedidositensopcoes>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Esvlogestpedidositensopcoes> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvlogestpedidositensopcoes.GetStringConnection());
            return ba.Existe<Esvlogestpedidositensopcoes>(where);
        }

        #endregion
    }
}
