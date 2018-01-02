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
    /// Classe referente a tabela PCPessoa
    /// </summary>
    [XmlType("PCPESSOA")]
    public class PCPessoa : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CNPJCPF
        /// Comentário: Cnpj ou Cpf.
        /// </summary>
        private string cnpjcpf;
        [XmlElement(ElementName = "CNPJCPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpjcpf
        {
            get { return  cnpjcpf; }
            set {  cnpjcpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTE
        /// Comentário: Chave secundária da tabela pcclient.
        /// </summary>
        private decimal codcliente;
        [XmlElement(ElementName = "CODCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcliente
        {
            get { return  codcliente; }
            set {  codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECEDOR
        /// Comentário: Chave secundária da tabela pcfornec.
        /// </summary>
        private decimal codfornecedor;
        [XmlElement(ElementName = "CODFORNECEDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfornecedor
        {
            get { return  codfornecedor; }
            set {  codfornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCADASTRO
        /// Comentário: Código funcionario que cadastrou.
        /// </summary>
        private decimal codfuncadastro;
        [XmlElement(ElementName = "CODFUNCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncadastro
        {
            get { return  codfuncadastro; }
            set {  codfuncadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCIONARIO
        /// Comentário: Chave secundária da tabela pcempr.
        /// </summary>
        private decimal codfuncionario;
        [XmlElement(ElementName = "CODFUNCIONARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncionario
        {
            get { return  codfuncionario; }
            set {  codfuncionario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNEXCLUSAO
        /// Comentário: Código funcionario que excluiu.
        /// </summary>
        private decimal codfunexclusao;
        [XmlElement(ElementName = "CODFUNEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunexclusao
        {
            get { return  codfunexclusao; }
            set {  codfunexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPESSOA
        /// Comentário: Chave primária da tabela pccpessoa.
        /// </summary>
        private decimal codpessoa;
        [XmlElement(ElementName = "CODPESSOA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codpessoa
        {
            get { return  codpessoa; }
            set {  codpessoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Código da rotina.
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data de cadastro.
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
        /// Comentário: Data de exclusão.
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
        /// Propriedade referente ao campo: ECLIENTE
        /// Comentário: Se é cliente.
        /// </summary>
        private string ecliente;
        [XmlElement(ElementName = "ECLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ecliente
        {
            get { return  ecliente; }
            set {  ecliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFORNECEDOR
        /// Comentário: Se é fornecedor.
        /// </summary>
        private string efornecedor;
        [XmlElement(ElementName = "EFORNECEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Efornecedor
        {
            get { return  efornecedor; }
            set {  efornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFUNCIONARIO
        /// Comentário: Se é Funcionairo.
        /// </summary>
        private string efuncionario;
        [XmlElement(ElementName = "EFUNCIONARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Efuncionario
        {
            get { return  efuncionario; }
            set {  efuncionario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ETRANSPORTADORA
        /// Comentário: Se é Transportadora.
        /// </summary>
        private string etransportadora;
        [XmlElement(ElementName = "ETRANSPORTADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Etransportadora
        {
            get { return  etransportadora; }
            set {  etransportadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FANTASIA
        /// Comentário: Nome Fantasia.
        /// </summary>
        private string fantasia;
        [XmlElement(ElementName = "FANTASIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Fantasia
        {
            get { return  fantasia; }
            set {  fantasia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: Nome pessoa.
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
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observação.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPessoa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPESSOA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPessoa> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPessoa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPessoa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPessoa>(where);
        }

        #endregion
    }
}
