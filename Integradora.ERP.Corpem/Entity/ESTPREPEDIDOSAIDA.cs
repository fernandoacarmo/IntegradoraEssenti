using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.ERP.Corpem.Inherited;
using Integradora.ERP.Corpem.Persistente;

namespace Integradora.ERP.Corpem.Entity
{
    /// <summary>
    /// Classe referente a tabela ESTPedidosaida
    /// </summary>
    [XmlType("ESTPREPEDIDOSAIDA")]
    public class ESTPrePedidosaida : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIAL
        /// Comentário: 
        /// </summary>
        private string razaosocial;
        [XmlElement(ElementName = "RAZAOSOCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Razaosocial
        {
            get { return razaosocial; }
            set { razaosocial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRASTREAMENTO
        /// Comentário: 
        /// </summary>
        private string codrastreamento;
        [XmlElement(ElementName = "CODRASTREAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Codrastreamento
        {
            get { return codrastreamento; }
            set { codrastreamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: URLRASTREAMENTO
        /// Comentário: 
        /// </summary>
        private string urlrastreamento;
        [XmlElement(ElementName = "URLRASTREAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 200)]
        public string URLrastreamento
        {
            get { return urlrastreamento; }
            set { urlrastreamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA
        /// Comentário: 
        /// </summary>
        private string obsentrega;
        [XmlElement(ElementName = "OBSENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Obsentrega
        {
            get { return obsentrega; }
            set { obsentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: 
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONTOREFERENCIA
        /// Comentário: 
        /// </summary>
        private string pontoreferencia;
        [XmlElement(ElementName = "PONTOREFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Pontoreferencia
        {
            get { return pontoreferencia; }
            set { pontoreferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: 
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIBGE
        /// Comentário: 
        /// </summary>
        private Int64 codibge;
        [XmlElement(ElementName = "CODIBGE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public Int64 Codibge
        {
            get { return codibge; }
            set { codibge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: 
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Comentário: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Comentário: 
        /// </summary>
        private string numero;
        [XmlElement(ElementName = "NUMERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
		
        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTE
        /// Comentário: 
        /// </summary>
        private Int32 codcliente;
        [XmlElement(ElementName = "CODCLIENTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public Int32 Codcliente
        {
            get { return  codcliente; }
            set {  codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTITENS
        /// Comentário: 
        /// </summary>
        private decimal qtitens;
        [XmlElement(ElementName = "QTITENS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Qtitens
        {
            get { return qtitens; }
            set { qtitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSPORTADORA
        /// Comentário: 
        /// </summary>
        private Int32 codtransportadora;
        [XmlElement(ElementName = "CODTRANSPORTADORA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public Int32 Codtransportadora
        {
            get { return codtransportadora; }
            set { codtransportadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_FILIALEMISSOR
        /// Comentário: 
        /// </summary>
        private string cnpj_filialemissor;
        [XmlElement(ElementName = "CNPJ_FILIALEMISSOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 14)]
        public string Cnpj_filialemissor
        {
            get { return cnpj_filialemissor; }
            set { cnpj_filialemissor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 500)]
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_TRANSPORTADORA
        /// Comentário: 
        /// </summary>
        private string cnpj_transportadora;
        [XmlElement(ElementName = "CNPJ_TRANSPORTADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 14)]
        public string Cnpj_transportadora
        {
            get { return cnpj_transportadora; }
            set { cnpj_transportadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVOLUMES
        /// Comentário: 
        /// </summary>
        private decimal qtvolumes;
        [XmlElement(ElementName = "QTVOLUMES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Qtvolumes
        {
            get { return qtvolumes; }
            set { qtvolumes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_CPF
        /// Comentário: 
        /// </summary>
        private string cnpj_cpf;
        [XmlElement(ElementName = "CNPJ_CPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 14)]
        public string Cnpj_Cpf
        {
            get { return cnpj_cpf; }
            set { cnpj_cpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_FILIAL
        /// Comentário: 
        /// </summary>
        private string cnpj_filial;
        [XmlElement(ElementName = "CNPJ_FILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 14)]
        public string Cnpj_filial
        {
            get { return cnpj_filial; }
            set { cnpj_filial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Comentário: 
        /// </summary>
        private Int32 codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public Int32 Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGERENTE
        /// Comentário: 
        /// </summary>
        private Int32 codgerente;
        [XmlElement(ElementName = "CODGERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public Int32 Codgerente
        {
            get { return  codgerente; }
            set {  codgerente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Comentário: 
        /// </summary>
        private Int32 codprofissional;
        [XmlElement(ElementName = "CODPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public Int32 Codprofissional
        {
            get { return  codprofissional; }
            set {  codprofissional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRCA
        /// Comentário: 
        /// </summary>
        private Int32 codrca;
        [XmlElement(ElementName = "CODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public Int32 Codrca
        {
            get { return  codrca; }
            set {  codrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private Int32 codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public Int32 Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private Int64 numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public Int64 Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Comentário: 
        /// </summary>
        private Int64 numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public Int64 Numpedido
        {
            get { return  numpedido; }
            set {  numpedido = value; }
        }

        /// <summary>

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Comentário: 
        /// </summary>
        private string tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Comentário: 
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 15)]
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBERA
        /// Comentário: 
        /// </summary>
        private DateTime? dtlibera;
        [XmlElement(ElementName = "DTLIBERA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtlibera
        {
            get { return dtlibera; }
            set { dtlibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVISAOENTREGA
        /// Comentário: 
        /// </summary>
        private DateTime? dtprevisaoentrega;
        [XmlElement(ElementName = "DTPREVISAOENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtprevisaoentrega
        {
            get { return dtprevisaoentrega; }
            set { dtprevisaoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Comentário: 
        /// </summary>
        private Int64 numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 10)]
        public Int64 Numpedrca
        {
            get { return numpedrca; }
            set { numpedrca = value; }
        }


        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTPrePedidosaida()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPREPEDIDOSAIDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTPrePedidosaida> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPrePedidosaida.GetStringConnection());
            return ba.Listar<ESTPrePedidosaida>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTPrePedidosaida> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPrePedidosaida.GetStringConnection());
            return ba.Existe<ESTPrePedidosaida>(where);
        }

        #endregion
    }
}
