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
    /// Classe referente a tabela PCDegustacaoecf
    /// </summary>
    [XmlType("PCDEGUSTACAOECF")]
    public class PCDegustacaoecf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRROENT
        /// Coment�rio: 
        /// </summary>
        private string bairroent;
        [XmlElement(ElementName = "BAIRROENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairroent
        {
            get { return  bairroent; }
            set {  bairroent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPENT
        /// Coment�rio: 
        /// </summary>
        private string cepent;
        [XmlElement(ElementName = "CEPENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepent
        {
            get { return  cepent; }
            set {  cepent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCENT
        /// Coment�rio: 
        /// </summary>
        private string cgcent;
        [XmlElement(ElementName = "CGCENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgcent
        {
            get { return  cgcent; }
            set {  cgcent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENTE
        /// Coment�rio: 
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Cliente
        {
            get { return  cliente; }
            set {  cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEGUSTACAO
        /// Coment�rio: 
        /// </summary>
        private decimal coddegustacao;
        [XmlElement(ElementName = "CODDEGUSTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Coddegustacao
        {
            get { return  coddegustacao; }
            set {  coddegustacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDEGUSTACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtdegustacao;
        [XmlElement(ElementName = "DTDEGUSTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdegustacao
        {
            get { return  dtdegustacao; }
            set {  dtdegustacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Coment�rio: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERENT
        /// Coment�rio: 
        /// </summary>
        private string enderent;
        [XmlElement(ElementName = "ENDERENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Enderent
        {
            get { return  enderent; }
            set {  enderent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTENT
        /// Coment�rio: 
        /// </summary>
        private string estent;
        [XmlElement(ElementName = "ESTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estent
        {
            get { return  estent; }
            set {  estent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAXCLI
        /// Coment�rio: 
        /// </summary>
        private string faxcli;
        [XmlElement(ElementName = "FAXCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Faxcli
        {
            get { return  faxcli; }
            set {  faxcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEENT
        /// Coment�rio: 
        /// </summary>
        private string ieent;
        [XmlElement(ElementName = "IEENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ieent
        {
            get { return  ieent; }
            set {  ieent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICENT
        /// Coment�rio: 
        /// </summary>
        private string municent;
        [XmlElement(ElementName = "MUNICENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municent
        {
            get { return  municent; }
            set {  municent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROFISSAO
        /// Coment�rio: 
        /// </summary>
        private string profissao;
        [XmlElement(ElementName = "PROFISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Profissao
        {
            get { return  profissao; }
            set {  profissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELCELENT
        /// Coment�rio: 
        /// </summary>
        private string telcelent;
        [XmlElement(ElementName = "TELCELENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Telcelent
        {
            get { return  telcelent; }
            set {  telcelent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELCOM
        /// Coment�rio: 
        /// </summary>
        private string telcom;
        [XmlElement(ElementName = "TELCOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telcom
        {
            get { return  telcom; }
            set {  telcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELENT
        /// Coment�rio: 
        /// </summary>
        private string telent;
        [XmlElement(ElementName = "TELENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telent
        {
            get { return  telent; }
            set {  telent = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDegustacaoecf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDEGUSTACAOECF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDegustacaoecf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDegustacaoecf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDegustacaoecf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDegustacaoecf>(where);
        }

        #endregion
    }
}
