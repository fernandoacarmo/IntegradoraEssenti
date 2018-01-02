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
    /// Classe referente a tabela ESTOrdemseparacao
    /// </summary>
    [XmlType("ESTORDEMSEPARACAO")]
    public class ESTOrdemseparacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMOSTRA
        /// Comentário: 
        /// </summary>
        private string amostra;
        [XmlElement(ElementName = "AMOSTRA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Amostra
        {
            get { return  amostra; }
            set {  amostra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BOX
        /// Comentário: 
        /// </summary>
        private decimal box;
        [XmlElement(ElementName = "BOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Box
        {
            get { return  box; }
            set {  box = value; }
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
        /// Propriedade referente ao campo: CODUSUARIOLIB
        /// Comentário: 
        /// </summary>
        private decimal codusuariolib;
        [XmlElement(ElementName = "CODUSUARIOLIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuariolib
        {
            get { return  codusuariolib; }
            set {  codusuariolib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAGENDAMENTO
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTLIBERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtliberacao;
        [XmlElement(ElementName = "DTLIBERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtliberacao
        {
            get { return  dtliberacao; }
            set {  dtliberacao = value; }
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
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: 
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
        /// Propriedade referente ao campo: OBSARMAZENAMENTO
        /// Comentário: 
        /// </summary>
        private string obsarmazenamento;
        [XmlElement(ElementName = "OBSARMAZENAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obsarmazenamento
        {
            get { return  obsarmazenamento; }
            set {  obsarmazenamento = value; }
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
        /// Propriedade referente ao campo: OBSERROS
        /// Comentário: 
        /// </summary>
        private string obserros;
        [XmlElement(ElementName = "OBSERROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obserros
        {
            get { return  obserros; }
            set {  obserros = value; }
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
        /// Propriedade referente ao campo: ORDEMSEPARACAO_ID
        /// Comentário: 
        /// </summary>
        private decimal ordemseparacao_id;
        [XmlElement(ElementName = "ORDEMSEPARACAO_ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Ordemseparacao_Id
        {
            get { return  ordemseparacao_id; }
            set {  ordemseparacao_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Comentário: 
        /// </summary>
        private decimal pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTERROS
        /// Comentário: 
        /// </summary>
        private decimal qterros;
        [XmlElement(ElementName = "QTERROS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Qterros
        {
            get { return  qterros; }
            set {  qterros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPALETE
        /// Comentário: 
        /// </summary>
        private decimal qtpalete;
        [XmlElement(ElementName = "QTPALETE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Qtpalete
        {
            get { return  qtpalete; }
            set {  qtpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Comentário: 
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEPARADOR_ID
        /// Comentário: 
        /// </summary>
        private decimal separador_id;
        [XmlElement(ElementName = "SEPARADOR_ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Separador_Id
        {
            get { return  separador_id; }
            set {  separador_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOGASTO
        /// Comentário: 
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
        /// Propriedade referente ao campo: TIPOSEPARACAO
        /// Comentário: 
        /// </summary>
        private decimal tiposeparacao;
        [XmlElement(ElementName = "TIPOSEPARACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Tiposeparacao
        {
            get { return  tiposeparacao; }
            set {  tiposeparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLHORASEPARADOR
        /// Comentário: 
        /// </summary>
        private decimal vlhoraseparador;
        [XmlElement(ElementName = "VLHORASEPARADOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlhoraseparador
        {
            get { return  vlhoraseparador; }
            set {  vlhoraseparador = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTOrdemseparacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTORDEMSEPARACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTOrdemseparacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTOrdemseparacao.GetStringConnection());
            return ba.Listar<ESTOrdemseparacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTOrdemseparacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTOrdemseparacao.GetStringConnection());
            return ba.Existe<ESTOrdemseparacao>(where);
        }

        #endregion
    }
}
