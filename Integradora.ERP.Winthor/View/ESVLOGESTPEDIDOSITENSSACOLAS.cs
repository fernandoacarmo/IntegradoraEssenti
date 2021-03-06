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
    /// Classe referente a tabela Esvlogestpedidositenssacolas
    /// </summary>
    [XmlType("ESVLOGESTPEDIDOSITENSSACOLAS")]
    public class Esvlogestpedidositenssacolas : OracleView
    {
        #region Atributos

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
        /// Propriedade referente ao campo: CODSACOLA
        /// Coment�rio: 
        /// </summary>
        private decimal codsacola;
        [XmlElement(ElementName = "CODSACOLA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsacola
        {
            get { return  codsacola; }
            set {  codsacola = value; }
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
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
        /// Propriedade referente ao campo: DTVALIDADELOTE01
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvalidadelote01;
        [XmlElement(ElementName = "DTVALIDADELOTE01", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadelote01
        {
            get { return  dtvalidadelote01; }
            set {  dtvalidadelote01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADELOTE02
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvalidadelote02;
        [XmlElement(ElementName = "DTVALIDADELOTE02", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadelote02
        {
            get { return  dtvalidadelote02; }
            set {  dtvalidadelote02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADELOTE03
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvalidadelote03;
        [XmlElement(ElementName = "DTVALIDADELOTE03", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadelote03
        {
            get { return  dtvalidadelote03; }
            set {  dtvalidadelote03 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADELOTE04
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvalidadelote04;
        [XmlElement(ElementName = "DTVALIDADELOTE04", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadelote04
        {
            get { return  dtvalidadelote04; }
            set {  dtvalidadelote04 = value; }
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
        /// Propriedade referente ao campo: ORDEMSEPARACAOANT_ID
        /// Coment�rio: 
        /// </summary>
        private decimal ordemseparacaoant_id;
        [XmlElement(ElementName = "ORDEMSEPARACAOANT_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Ordemseparacaoant_Id
        {
            get { return  ordemseparacaoant_id; }
            set {  ordemseparacaoant_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMSEPARACAO_ID
        /// Coment�rio: 
        /// </summary>
        private decimal ordemseparacao_id;
        [XmlElement(ElementName = "ORDEMSEPARACAO_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Ordemseparacao_Id
        {
            get { return  ordemseparacao_id; }
            set {  ordemseparacao_id = value; }
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

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Esvlogestpedidositenssacolas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVLOGESTPEDIDOSITENSSACOLAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Esvlogestpedidositenssacolas> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvlogestpedidositenssacolas.GetStringConnection());
            return ba.Listar<Esvlogestpedidositenssacolas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Esvlogestpedidositenssacolas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvlogestpedidositenssacolas.GetStringConnection());
            return ba.Existe<Esvlogestpedidositenssacolas>(where);
        }

        #endregion
    }
}
