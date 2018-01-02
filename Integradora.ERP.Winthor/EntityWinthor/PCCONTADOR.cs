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
    /// Classe referente a tabela PCContador
    /// </summary>
    [XmlType("PCCONTADOR")]
    public class PCContador : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CELULAR
        /// Comentário: 
        /// </summary>
        private string celular;
        [XmlElement(ElementName = "CELULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Celular
        {
            get { return  celular; }
            set {  celular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: 
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_CPF_CEI
        /// Comentário: Indica o numero da inscrição do contador.
        /// </summary>
        private string cnpj_cpf_cei;
        [XmlElement(ElementName = "CNPJ_CPF_CEI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cnpj_Cpf_Cei
        {
            get { return  cnpj_cpf_cei; }
            set {  cnpj_cpf_cei = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Comentário: 
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADOR
        /// Comentário: 
        /// </summary>
        private decimal codcontador;
        [XmlElement(ElementName = "CODCONTADOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codcontador
        {
            get { return  codcontador; }
            set {  codcontador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRC
        /// Comentário: 
        /// </summary>
        private string crc;
        [XmlElement(ElementName = "CRC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public string Crc
        {
            get { return  crc; }
            set {  crc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADECRC
        /// Comentário: Data de validade do CRC.
        /// </summary>
        private DateTime? dtvalidadecrc;
        [XmlElement(ElementName = "DTVALIDADECRC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadecrc
        {
            get { return  dtvalidadecrc; }
            set {  dtvalidadecrc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,70)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: 
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_CONTADOR
        /// Comentário: 
        /// </summary>
        private string nome_contador;
        [XmlElement(ElementName = "NOME_CONTADOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Nome_Contador
        {
            get { return  nome_contador; }
            set {  nome_contador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RG
        /// Comentário: 
        /// </summary>
        private string rg;
        [XmlElement(ElementName = "RG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rg
        {
            get { return  rg; }
            set {  rg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE01
        /// Comentário: 
        /// </summary>
        private string telefone01;
        [XmlElement(ElementName = "TELEFONE01", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telefone01
        {
            get { return  telefone01; }
            set {  telefone01 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE02
        /// Comentário: 
        /// </summary>
        private string telefone02;
        [XmlElement(ElementName = "TELEFONE02", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telefone02
        {
            get { return  telefone02; }
            set {  telefone02 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTADOR
        /// Comentário: Indica se e Contador ou Téc. Contabilidade.
        /// </summary>
        private string tipocontador;
        [XmlElement(ElementName = "TIPOCONTADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocontador
        {
            get { return  tipocontador; }
            set {  tipocontador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINSCRICAO
        /// Comentário: Indica o tipo de inscrição do contador.
        /// </summary>
        private string tipoinscricao;
        [XmlElement(ElementName = "TIPOINSCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Tipoinscricao
        {
            get { return  tipoinscricao; }
            set {  tipoinscricao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCContador()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTADOR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCContador> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContador>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCContador> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContador>(where);
        }

        #endregion
    }
}
