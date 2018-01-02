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
    /// Classe referente a tabela PCPortos
    /// </summary>
    [XmlType("PCPORTOS")]
    public class PCPortos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: CEP do Porto.
        /// </summary>
        private decimal cep;
        [XmlElement(ElementName = "CEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Comentário: Cidade do Porto.
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código do fornecedor responsável pelo armazém alfandegário
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Comentário: País do Porto.
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPORTO
        /// Comentário: Código do Porto.
        /// </summary>
        private decimal codporto;
        [XmlElement(ElementName = "CODPORTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codporto
        {
            get { return  codporto; }
            set {  codporto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSISCOMEX
        /// Comentário: Código SISCOMEX do Porto.
        /// </summary>
        private decimal codsiscomex;
        [XmlElement(ElementName = "CODSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codsiscomex
        {
            get { return  codsiscomex; }
            set {  codsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATO
        /// Comentário: Contato do Porto.
        /// </summary>
        private string contato;
        [XmlElement(ElementName = "CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contato
        {
            get { return  contato; }
            set {  contato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do Porto.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: Email do Porto.
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
        /// Comentário: Endereço do Porto.
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
        /// Propriedade referente ao campo: FAX
        /// Comentário: Fax do Porto.
        /// </summary>
        private decimal fax;
        [XmlElement(ElementName = "FAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Fax
        {
            get { return  fax; }
            set {  fax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLA
        /// Comentário: Sigla do Porto.
        /// </summary>
        private string sigla;
        [XmlElement(ElementName = "SIGLA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Sigla
        {
            get { return  sigla; }
            set {  sigla = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Comentário: Telefone do Porto.
        /// </summary>
        private decimal telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: Estado do Porto.
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
        /// Propriedade referente ao campo: UNRECFEDCODSISCOMEX
        /// Comentário: Código SISCOMEX da Unidade da Receita Federal do Porto.
        /// </summary>
        private decimal unrecfedcodsiscomex;
        [XmlElement(ElementName = "UNRECFEDCODSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Unrecfedcodsiscomex
        {
            get { return  unrecfedcodsiscomex; }
            set {  unrecfedcodsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNRECFEDNOME
        /// Comentário: Nome da Unidade da Receita Federal do Porto.
        /// </summary>
        private string unrecfednome;
        [XmlElement(ElementName = "UNRECFEDNOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Unrecfednome
        {
            get { return  unrecfednome; }
            set {  unrecfednome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNRECFEDSIGLA
        /// Comentário: Sigla da Unidade da Receita Federal do Porto.
        /// </summary>
        private string unrecfedsigla;
        [XmlElement(ElementName = "UNRECFEDSIGLA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Unrecfedsigla
        {
            get { return  unrecfedsigla; }
            set {  unrecfedsigla = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPortos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPORTOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPortos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPortos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPortos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPortos>(where);
        }

        #endregion
    }
}
