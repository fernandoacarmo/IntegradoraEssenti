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
    /// Classe referente a tabela PCEnderecodelivery
    /// </summary>
    [XmlType("PCENDERECODELIVERY")]
    public class PCEnderecodelivery : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Coment�rio: BAIRRO
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Coment�rio: CEP
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
        /// Coment�rio: CIDADE
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Cidade
        {
            get { return  cidade; }
            set {  cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIRRODELIV
        /// Coment�rio: C�digo do Bairro para entrega
        /// </summary>
        private decimal codbairrodeliv;
        [XmlElement(ElementName = "CODBAIRRODELIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codbairrodeliv
        {
            get { return  codbairrodeliv; }
            set {  codbairrodeliv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCX
        /// Coment�rio: CODFUNCCX
        /// </summary>
        private decimal codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Coment�rio: CODVEICULO
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Coment�rio: COMPLEMENTO
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPFCNPJ
        /// Coment�rio: CPFCNPJ
        /// </summary>
        private string cpfcnpj;
        [XmlElement(ElementName = "CPFCNPJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cpfcnpj
        {
            get { return  cpfcnpj; }
            set {  cpfcnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENTREGA
        /// Coment�rio: Data de entrega
        /// </summary>
        private DateTime? dataentrega;
        [XmlElement(ElementName = "DATAENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataentrega
        {
            get { return  dataentrega; }
            set {  dataentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALADOR
        /// Coment�rio: EMBALADOR
        /// </summary>
        private string embalador;
        [XmlElement(ElementName = "EMBALADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Embalador
        {
            get { return  embalador; }
            set {  embalador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Coment�rio: ESTADO
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Estado
        {
            get { return  estado; }
            set {  estado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: Indicador se registro foi exportado.
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORATENTATIVA
        /// Coment�rio: Hora em que foi feita a tentativa da entrega.
        /// </summary>
        private string horatentativa;
        [XmlElement(ElementName = "HORATENTATIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Horatentativa
        {
            get { return  horatentativa; }
            set {  horatentativa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOGRADOURO
        /// Coment�rio: LOGRADOURO
        /// </summary>
        private string logradouro;
        [XmlElement(ElementName = "LOGRADOURO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Logradouro
        {
            get { return  logradouro; }
            set {  logradouro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULAMOTORISTA
        /// Coment�rio: MATRICULAMOTORISTA
        /// </summary>
        private decimal matriculamotorista;
        [XmlElement(ElementName = "MATRICULAMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matriculamotorista
        {
            get { return  matriculamotorista; }
            set {  matriculamotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECLIENTE
        /// Coment�rio: NOMECLIENTE
        /// </summary>
        private string nomecliente;
        [XmlElement(ElementName = "NOMECLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomecliente
        {
            get { return  nomecliente; }
            set {  nomecliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: NUMCAIXA
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXAS
        /// Coment�rio: NUMCAIXAS
        /// </summary>
        private string numcaixas;
        [XmlElement(ElementName = "NUMCAIXAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Numcaixas
        {
            get { return  numcaixas; }
            set {  numcaixas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: NUMCAR
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Coment�rio: NUMERO
        /// </summary>
        private string numero;
        [XmlElement(ElementName = "NUMERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numero
        {
            get { return  numero; }
            set {  numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Coment�rio: N�mero do pedido da venda feita no caixa.
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: OBS
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,400)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODODIAENTREGA
        /// Coment�rio: Per�odo do dia para entrega
        /// </summary>
        private string periododiaentrega;
        [XmlElement(ElementName = "PERIODODIAENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Periododiaentrega
        {
            get { return  periododiaentrega; }
            set {  periododiaentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCAIXAS
        /// Coment�rio: QTCAIXAS
        /// </summary>
        private decimal qtcaixas;
        [XmlElement(ElementName = "QTCAIXAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtcaixas
        {
            get { return  qtcaixas; }
            set {  qtcaixas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVOLCONG
        /// Coment�rio: QTVOLCONG
        /// </summary>
        private decimal qtvolcong;
        [XmlElement(ElementName = "QTVOLCONG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtvolcong
        {
            get { return  qtvolcong; }
            set {  qtvolcong = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVOLRESF
        /// Coment�rio: QTVOLRESF
        /// </summary>
        private decimal qtvolresf;
        [XmlElement(ElementName = "QTVOLRESF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtvolresf
        {
            get { return  qtvolresf; }
            set {  qtvolresf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIA
        /// Coment�rio: REFERENCIA
        /// </summary>
        private string referencia;
        [XmlElement(ElementName = "REFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Referencia
        {
            get { return  referencia; }
            set {  referencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: SITUACAO
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Coment�rio: TELEFONE
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
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
        public PCEnderecodelivery()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCENDERECODELIVERY";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEnderecodelivery> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEnderecodelivery>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEnderecodelivery> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEnderecodelivery>(where);
        }

        #endregion
    }
}
