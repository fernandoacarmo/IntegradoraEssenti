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
    /// Classe referente a tabela PCExpurgo
    /// </summary>
    [XmlType("PCEXPURGO")]
    public class PCExpurgo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACOMPANHAMENTO
        /// Coment�rio: 
        /// </summary>
        private string acompanhamento;
        [XmlElement(ElementName = "ACOMPANHAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Acompanhamento
        {
            get { return  acompanhamento; }
            set {  acompanhamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CONDICOESAMBIENTE
        /// Coment�rio: 
        /// </summary>
        private string condicoesambiente;
        [XmlElement(ElementName = "CONDICOESAMBIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Condicoesambiente
        {
            get { return  condicoesambiente; }
            set {  condicoesambiente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COORDENADOR
        /// Coment�rio: 
        /// </summary>
        private string coordenador;
        [XmlElement(ElementName = "COORDENADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Coordenador
        {
            get { return  coordenador; }
            set {  coordenador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTFECHAMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfechamento;
        [XmlElement(ElementName = "DTFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamento
        {
            get { return  dtfechamento; }
            set {  dtfechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVERIFICACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtverificacao;
        [XmlElement(ElementName = "DTVERIFICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtverificacao
        {
            get { return  dtverificacao; }
            set {  dtverificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EVIDENCIAPRAGA
        /// Coment�rio: 
        /// </summary>
        private string evidenciapraga;
        [XmlElement(ElementName = "EVIDENCIAPRAGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Evidenciapraga
        {
            get { return  evidenciapraga; }
            set {  evidenciapraga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXECUTOR
        /// Coment�rio: 
        /// </summary>
        private string executor;
        [XmlElement(ElementName = "EXECUTOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Executor
        {
            get { return  executor; }
            set {  executor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTENSIDADEPRAGA
        /// Coment�rio: 
        /// </summary>
        private string intensidadepraga;
        [XmlElement(ElementName = "INTENSIDADEPRAGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Intensidadepraga
        {
            get { return  intensidadepraga; }
            set {  intensidadepraga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Coment�rio: 
        /// </summary>
        private decimal numtranswms;
        [XmlElement(ElementName = "NUMTRANSWMS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtranswms
        {
            get { return  numtranswms; }
            set {  numtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSEVIDENCIAPRAGA
        /// Coment�rio: 
        /// </summary>
        private string obsevidenciapraga;
        [XmlElement(ElementName = "OBSEVIDENCIAPRAGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Obsevidenciapraga
        {
            get { return  obsevidenciapraga; }
            set {  obsevidenciapraga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSTIPO
        /// Coment�rio: 
        /// </summary>
        private string obstipo;
        [XmlElement(ElementName = "OBSTIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Obstipo
        {
            get { return  obstipo; }
            set {  obstipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPANTES
        /// Coment�rio: 
        /// </summary>
        private string participantes;
        [XmlElement(ElementName = "PARTICIPANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Participantes
        {
            get { return  participantes; }
            set {  participantes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUTOEXPURGO
        /// Coment�rio: 
        /// </summary>
        private string produtoexpurgo;
        [XmlElement(ElementName = "PRODUTOEXPURGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Produtoexpurgo
        {
            get { return  produtoexpurgo; }
            set {  produtoexpurgo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: SUPERVISOR
        /// Coment�rio: 
        /// </summary>
        private string supervisor;
        [XmlElement(ElementName = "SUPERVISOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Supervisor
        {
            get { return  supervisor; }
            set {  supervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCExpurgo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEXPURGO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCExpurgo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCExpurgo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCExpurgo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCExpurgo>(where);
        }

        #endregion
    }
}
