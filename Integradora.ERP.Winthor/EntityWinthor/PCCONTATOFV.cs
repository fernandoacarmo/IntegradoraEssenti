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
    /// Classe referente a tabela PCContatofv
    /// </summary>
    [XmlType("PCCONTATOFV")]
    public class PCContatofv : OracleTable
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
        /// Propriedade referente ao campo: CARGO
        /// Comentário: 
        /// </summary>
        private string cargo;
        [XmlElement(ElementName = "CARGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cargo
        {
            get { return  cargo; }
            set {  cargo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CELULAR
        /// Comentário: 
        /// </summary>
        private string celular;
        [XmlElement(ElementName = "CELULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
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
        [DataObjectField(false,false,true,9)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCLI
        /// Comentário: 
        /// </summary>
        private string cgccli;
        [XmlElement(ElementName = "CGCCLI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public string Cgccli
        {
            get { return  cgccli; }
            set {  cgccli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCPF
        /// Comentário: 
        /// </summary>
        private string cgccpf;
        [XmlElement(ElementName = "CGCCPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgccpf
        {
            get { return  cgccpf; }
            set {  cgccpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Codigo do cliente que será usado em conjunto com o campo cnpj para identificar o cliente no caso de ter no cadastro mais de um cliente com mesmo cnpj
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: Data de Alteração no registro
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
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Grava Data e Hora da Última Importação.
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNASCCONJUGE
        /// Comentário: 
        /// </summary>
        private DateTime? dtnascconjuge;
        [XmlElement(ElementName = "DTNASCCONJUGE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnascconjuge
        {
            get { return  dtnascconjuge; }
            set {  dtnascconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNASCIMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtnascimento;
        [XmlElement(ElementName = "DTNASCIMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnascimento
        {
            get { return  dtnascimento; }
            set {  dtnascimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
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
        [DataObjectField(false,false,true,40)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Comentário: 
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
        /// Propriedade referente ao campo: HOBBIE
        /// Comentário: 
        /// </summary>
        private string hobbie;
        [XmlElement(ElementName = "HOBBIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Hobbie
        {
            get { return  hobbie; }
            set {  hobbie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Comentário: 
        /// </summary>
        private decimal importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECONJUGE
        /// Comentário: 
        /// </summary>
        private string nomeconjuge;
        [XmlElement(ElementName = "NOMECONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomeconjuge
        {
            get { return  nomeconjuge; }
            set {  nomeconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECONTATO
        /// Comentário: 
        /// </summary>
        private string nomecontato;
        [XmlElement(ElementName = "NOMECONTATO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nomecontato
        {
            get { return  nomecontato; }
            set {  nomecontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Comentário: 
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Comentário: 
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIME
        /// Comentário: 
        /// </summary>
        private string time;
        [XmlElement(ElementName = "TIME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Time
        {
            get { return  time; }
            set {  time = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTATO
        /// Comentário: 
        /// </summary>
        private string tipocontato;
        [XmlElement(ElementName = "TIPOCONTATO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipocontato
        {
            get { return  tipocontato; }
            set {  tipocontato = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCContatofv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTATOFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCContatofv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContatofv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCContatofv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContatofv>(where);
        }

        #endregion
    }
}
