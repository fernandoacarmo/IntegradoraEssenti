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
    /// Classe referente a tabela Esvlogbox
    /// </summary>
    [XmlType("ESVLOGBOX")]
    public class Esvlogbox : OracleView
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
        /// Propriedade referente ao campo: CODCONFERENTE
        /// Coment�rio: 
        /// </summary>
        private decimal codconferente;
        [XmlElement(ElementName = "CODCONFERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codconferente
        {
            get { return  codconferente; }
            set {  codconferente = value; }
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
        /// Propriedade referente ao campo: CODUSUARIOEXC
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioexc;
        [XmlElement(ElementName = "CODUSUARIOEXC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusuarioexc
        {
            get { return  codusuarioexc; }
            set {  codusuarioexc = value; }
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
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
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

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Esvlogbox()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVLOGBOX";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Esvlogbox> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvlogbox.GetStringConnection());
            return ba.Listar<Esvlogbox>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Esvlogbox> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvlogbox.GetStringConnection());
            return ba.Existe<Esvlogbox>(where);
        }

        #endregion
    }
}
