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
    /// Classe referente a tabela Esvempresas
    /// </summary>
    [XmlType("ESVEMPRESAS")]
    public class Esvempresas : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Coment�rio: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Coment�rio: 
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CNPJCPF
        /// Coment�rio: 
        /// </summary>
        private string cnpjcpf;
        [XmlElement(ElementName = "CNPJCPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cnpjcpf
        {
            get { return  cnpjcpf; }
            set {  cnpjcpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTE
        /// Coment�rio: 
        /// </summary>
        private decimal codcliente;
        [XmlElement(ElementName = "CODCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcliente
        {
            get { return  codcliente; }
            set {  codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMPRESA
        /// Coment�rio: 
        /// </summary>
        private string codempresa;
        [XmlElement(ElementName = "CODEMPRESA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codempresa
        {
            get { return  codempresa; }
            set {  codempresa = value; }
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
        /// Propriedade referente ao campo: EMPRESA
        /// Coment�rio: 
        /// </summary>
        private string empresa;
        [XmlElement(ElementName = "EMPRESA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Empresa
        {
            get { return  empresa; }
            set {  empresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Coment�rio: 
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Coment�rio: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estado
        {
            get { return  estado; }
            set {  estado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSCRICAOESTADUAL
        /// Coment�rio: 
        /// </summary>
        private string inscricaoestadual;
        [XmlElement(ElementName = "INSCRICAOESTADUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Inscricaoestadual
        {
            get { return  inscricaoestadual; }
            set {  inscricaoestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Coment�rio: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEFANTASIA
        /// Coment�rio: 
        /// </summary>
        private string nomefantasia;
        [XmlElement(ElementName = "NOMEFANTASIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Nomefantasia
        {
            get { return  nomefantasia; }
            set {  nomefantasia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIAL
        /// Coment�rio: 
        /// </summary>
        private string razaosocial;
        [XmlElement(ElementName = "RAZAOSOCIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Razaosocial
        {
            get { return  razaosocial; }
            set {  razaosocial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SMPTSERVIDOR
        /// Coment�rio: 
        /// </summary>
        private string smptservidor;
        [XmlElement(ElementName = "SMPTSERVIDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Smptservidor
        {
            get { return  smptservidor; }
            set {  smptservidor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Coment�rio: 
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Esvempresas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVEMPRESAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Esvempresas> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvempresas.GetStringConnection());
            return ba.Listar<Esvempresas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Esvempresas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvempresas.GetStringConnection());
            return ba.Existe<Esvempresas>(where);
        }

        #endregion
    }
}
