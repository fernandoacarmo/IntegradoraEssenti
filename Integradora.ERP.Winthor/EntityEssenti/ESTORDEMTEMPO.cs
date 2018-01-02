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
    /// Classe referente a tabela ESTOrdemtempo
    /// </summary>
    [XmlType("ESTORDEMTEMPO")]
    public class ESTOrdemtempo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
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
        /// Propriedade referente ao campo: DTFINALIZACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfinalizacao;
        [XmlElement(ElementName = "DTFINALIZACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
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
        [XmlElement(ElementName = "DTINICIALIZACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtinicializacao
        {
            get { return  dtinicializacao; }
            set {  dtinicializacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FINALIZADO
        /// Coment�rio: 
        /// </summary>
        private string finalizado;
        [XmlElement(ElementName = "FINALIZADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Finalizado
        {
            get { return  finalizado; }
            set {  finalizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOGASTO
        /// Coment�rio: 
        /// </summary>
        private string tempogasto;
        [XmlElement(ElementName = "TEMPOGASTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public string Tempogasto
        {
            get { return  tempogasto; }
            set {  tempogasto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
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
        public ESTOrdemtempo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTORDEMTEMPO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTOrdemtempo> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTOrdemtempo.GetStringConnection());
            return ba.Listar<ESTOrdemtempo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTOrdemtempo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTOrdemtempo.GetStringConnection());
            return ba.Existe<ESTOrdemtempo>(where);
        }

        #endregion
    }
}
