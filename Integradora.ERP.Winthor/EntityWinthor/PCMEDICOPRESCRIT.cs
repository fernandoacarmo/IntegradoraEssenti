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
    /// Classe referente a tabela PCMedicoprescrit
    /// </summary>
    [XmlType("PCMEDICOPRESCRIT")]
    public class PCMedicoprescrit : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Coment�rio: CEP.
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Coment�rio: Cidade.
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cidade
        {
            get { return  cidade; }
            set {  cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMEDICOPRESCRIT
        /// Coment�rio: C�digo do M�dico Prescritor.
        /// </summary>
        private decimal codmedicoprescrit;
        [XmlElement(ElementName = "CODMEDICOPRESCRIT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codmedicoprescrit
        {
            get { return  codmedicoprescrit; }
            set {  codmedicoprescrit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Coment�rio: Complemento.
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACAD
        /// Coment�rio: Data Cadastro.
        /// </summary>
        private DateTime? datacad;
        [XmlElement(ElementName = "DATACAD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacad
        {
            get { return  datacad; }
            set {  datacad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Coment�rio: E-mail.
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
        /// Propriedade referente ao campo: ENDERECO
        /// Coment�rio: Endere�o.
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,70)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAX
        /// Coment�rio: Fax.
        /// </summary>
        private string fax;
        [XmlElement(ElementName = "FAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Fax
        {
            get { return  fax; }
            set {  fax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Coment�rio: Nome do M�dico.
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCRM
        /// Coment�rio: N�mero do CRM.
        /// </summary>
        private string numcrm;
        [XmlElement(ElementName = "NUMCRM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Numcrm
        {
            get { return  numcrm; }
            set {  numcrm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Coment�rio: Telefone.
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: UF.
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: URL
        /// Coment�rio: Endere�o WEB.
        /// </summary>
        private string url;
        [XmlElement(ElementName = "URL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Url
        {
            get { return  url; }
            set {  url = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMedicoprescrit()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMEDICOPRESCRIT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMedicoprescrit> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMedicoprescrit>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMedicoprescrit> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMedicoprescrit>(where);
        }

        #endregion
    }
}
