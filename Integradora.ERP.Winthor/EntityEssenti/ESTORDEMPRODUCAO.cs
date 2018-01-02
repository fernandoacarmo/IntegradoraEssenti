using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTOrdemproducao
    /// </summary>
    [XmlType("ESTORDEMPRODUCAO")]
    public class ESTOrdemproducao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBOX
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal codsacola;
        [XmlElement(ElementName = "CODSACOLA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
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
        /// Propriedade referente ao campo: CONFERENTE_ID
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtagendamento;
        [XmlElement(ElementName = "DTAGENDAMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtagendamento
        {
            get { return  dtagendamento; }
            set {  dtagendamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
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
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCELAMENTO
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Coment�rio: 
        /// </summary>
        private decimal numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
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
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Coment�rio: 
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCANCELAMENTO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ORDEMPRODUCAO_ID
        /// Coment�rio: 
        /// </summary>
        private decimal ordemproducao_id;
        [XmlElement(ElementName = "ORDEMPRODUCAO_ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Ordemproducao_Id
        {
            get { return  ordemproducao_id; }
            set {  ordemproducao_id = value; }
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
        /// Propriedade referente ao campo: QTFUNCIONARIOS
        /// Coment�rio: 
        /// </summary>
        private decimal qtfuncionarios;
        [XmlElement(ElementName = "QTFUNCIONARIOS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Qtfuncionarios
        {
            get { return  qtfuncionarios; }
            set {  qtfuncionarios = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIDO
        /// Coment�rio: 
        /// </summary>
        private decimal qtproduzido;
        [XmlElement(ElementName = "QTPRODUZIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtproduzido
        {
            get { return  qtproduzido; }
            set {  qtproduzido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSOLICITADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtsolicitada;
        [XmlElement(ElementName = "QTSOLICITADA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtsolicitada
        {
            get { return  qtsolicitada; }
            set {  qtsolicitada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARADO
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal tempogasto;
        [XmlElement(ElementName = "TEMPOGASTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Tempogasto
        {
            get { return  tempogasto; }
            set {  tempogasto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLHORACONFERENTE
        /// Coment�rio: 
        /// </summary>
        private decimal vlhoraconferente;
        [XmlElement(ElementName = "VLHORACONFERENTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlhoraconferente
        {
            get { return  vlhoraconferente; }
            set {  vlhoraconferente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLHORAPRODUCAO
        /// Coment�rio: 
        /// </summary>
        private decimal vlhoraproducao;
        [XmlElement(ElementName = "VLHORAPRODUCAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlhoraproducao
        {
            get { return  vlhoraproducao; }
            set {  vlhoraproducao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTOrdemproducao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTORDEMPRODUCAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTOrdemproducao> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTOrdemproducao.GetStringConnection());
            return ba.Listar<ESTOrdemproducao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTOrdemproducao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTOrdemproducao.GetStringConnection());
            return ba.Existe<ESTOrdemproducao>(where);
        }

        #endregion
    }
}
