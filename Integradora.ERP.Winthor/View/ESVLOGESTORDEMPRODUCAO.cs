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
    /// Classe referente a tabela Esvlogestordemproducao
    /// </summary>
    [XmlType("ESVLOGESTORDEMPRODUCAO")]
    public class Esvlogestordemproducao : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBOX
        /// Comentário: 
        /// </summary>
        private decimal codbox;
        [XmlElement(ElementName = "CODBOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbox
        {
            get { return  codbox; }
            set {  codbox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTEIRA
        /// Comentário: 
        /// </summary>
        private decimal codesteira;
        [XmlElement(ElementName = "CODESTEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codesteira
        {
            get { return  codesteira; }
            set {  codesteira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSACOLA
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CONFERENTE_ID
        /// Comentário: 
        /// </summary>
        private decimal conferente_id;
        [XmlElement(ElementName = "CONFERENTE_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Conferente_Id
        {
            get { return  conferente_id; }
            set {  conferente_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAGENDAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtagendamento;
        [XmlElement(ElementName = "DTAGENDAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtagendamento
        {
            get { return  dtagendamento; }
            set {  dtagendamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTCANCELAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcancelamento;
        [XmlElement(ElementName = "DTCANCELAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancelamento
        {
            get { return  dtcancelamento; }
            set {  dtcancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFINALIZACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtfinalizacao;
        [XmlElement(ElementName = "DTFINALIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinalizacao
        {
            get { return  dtfinalizacao; }
            set {  dtfinalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIALIZACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicializacao;
        [XmlElement(ElementName = "DTINICIALIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicializacao
        {
            get { return  dtinicializacao; }
            set {  dtinicializacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPARALIZACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtparalizacao;
        [XmlElement(ElementName = "DTPARALIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtparalizacao
        {
            get { return  dtparalizacao; }
            set {  dtparalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREINICILIZACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtreinicilizacao;
        [XmlElement(ElementName = "DTREINICILIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtreinicilizacao
        {
            get { return  dtreinicilizacao; }
            set {  dtreinicilizacao = value; }
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
        /// Propriedade referente ao campo: DT1FINALIZACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dt1finalizacao;
        [XmlElement(ElementName = "DT1FINALIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dt1finalizacao
        {
            get { return  dt1finalizacao; }
            set {  dt1finalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGACAO
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: 
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCANCELAMENTO
        /// Comentário: 
        /// </summary>
        private string obscancelamento;
        [XmlElement(ElementName = "OBSCANCELAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Obscancelamento
        {
            get { return  obscancelamento; }
            set {  obscancelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: ORDEMPRODUCAO_ID
        /// Comentário: 
        /// </summary>
        private decimal ordemproducao_id;
        [XmlElement(ElementName = "ORDEMPRODUCAO_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Ordemproducao_Id
        {
            get { return  ordemproducao_id; }
            set {  ordemproducao_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMSEPARACAO_ID
        /// Comentário: 
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
        /// Propriedade referente ao campo: QTFUNCIONARIOS
        /// Comentário: 
        /// </summary>
        private decimal qtfuncionarios;
        [XmlElement(ElementName = "QTFUNCIONARIOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtfuncionarios
        {
            get { return  qtfuncionarios; }
            set {  qtfuncionarios = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIDO
        /// Comentário: 
        /// </summary>
        private decimal qtproduzido;
        [XmlElement(ElementName = "QTPRODUZIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtproduzido
        {
            get { return  qtproduzido; }
            set {  qtproduzido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSOLICITADA
        /// Comentário: 
        /// </summary>
        private decimal qtsolicitada;
        [XmlElement(ElementName = "QTSOLICITADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtsolicitada
        {
            get { return  qtsolicitada; }
            set {  qtsolicitada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARADO
        /// Comentário: 
        /// </summary>
        private string separado;
        [XmlElement(ElementName = "SEPARADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Separado
        {
            get { return  separado; }
            set {  separado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOGASTO
        /// Comentário: 
        /// </summary>
        private decimal tempogasto;
        [XmlElement(ElementName = "TEMPOGASTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Tempogasto
        {
            get { return  tempogasto; }
            set {  tempogasto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLHORACONFERENTE
        /// Comentário: 
        /// </summary>
        private decimal vlhoraconferente;
        [XmlElement(ElementName = "VLHORACONFERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlhoraconferente
        {
            get { return  vlhoraconferente; }
            set {  vlhoraconferente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLHORAPRODUCAO
        /// Comentário: 
        /// </summary>
        private decimal vlhoraproducao;
        [XmlElement(ElementName = "VLHORAPRODUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlhoraproducao
        {
            get { return  vlhoraproducao; }
            set {  vlhoraproducao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvlogestordemproducao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVLOGESTORDEMPRODUCAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvlogestordemproducao> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvlogestordemproducao.GetStringConnection());
            return ba.Listar<Esvlogestordemproducao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvlogestordemproducao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvlogestordemproducao.GetStringConnection());
            return ba.Existe<Esvlogestordemproducao>(where);
        }

        #endregion
    }
}
