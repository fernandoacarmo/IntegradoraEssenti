using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTPagamento
    /// </summary>
    [XmlType("ESTPAGAMENTO")]
    public class ESTPagamento : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAPTURA
        /// Coment�rio: 
        /// </summary>
        private string captura;
        [XmlElement(ElementName = "CAPTURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Captura
        {
            get { return  captura; }
            set {  captura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARTAO
        /// Coment�rio: 
        /// </summary>
        private string cartao;
        [XmlElement(ElementName = "CARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cartao
        {
            get { return  cartao; }
            set {  cartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAID
        /// Coment�rio: 
        /// </summary>
        private string codaid;
        [XmlElement(ElementName = "CODAID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Codaid
        {
            get { return  codaid; }
            set {  codaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAO
        /// Coment�rio: 
        /// </summary>
        private string codautorizacao;
        [XmlElement(ElementName = "CODAUTORIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codautorizacao
        {
            get { return  codautorizacao; }
            set {  codautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTOMATRIZ
        /// Coment�rio: 
        /// </summary>
        private string codprodutomatriz;
        [XmlElement(ElementName = "CODPRODUTOMATRIZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codprodutomatriz
        {
            get { return  codprodutomatriz; }
            set {  codprodutomatriz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTOSECUNDARIO
        /// Coment�rio: 
        /// </summary>
        private string codprodutosecundario;
        [XmlElement(ElementName = "CODPRODUTOSECUNDARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codprodutosecundario
        {
            get { return  codprodutosecundario; }
            set {  codprodutosecundario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRESPOSTA
        /// Coment�rio: 
        /// </summary>
        private string codresposta;
        [XmlElement(ElementName = "CODRESPOSTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codresposta
        {
            get { return  codresposta; }
            set {  codresposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPROVANTECLIENTE
        /// Coment�rio: 
        /// </summary>
        private string comprovantecliente;
        [XmlElement(ElementName = "COMPROVANTECLIENTE", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Comprovantecliente
        {
            get { return  comprovantecliente; }
            set {  comprovantecliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPROVANTEVENDEDOR
        /// Coment�rio: 
        /// </summary>
        private string comprovantevendedor;
        [XmlElement(ElementName = "COMPROVANTEVENDEDOR", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Comprovantevendedor
        {
            get { return  comprovantevendedor; }
            set {  comprovantevendedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGAMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtpagamento;
        [XmlElement(ElementName = "DTPAGAMENTO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtpagamento
        {
            get { return  dtpagamento; }
            set {  dtpagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREQUISICAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtrequisicao;
        [XmlElement(ElementName = "DTREQUISICAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtrequisicao
        {
            get { return  dtrequisicao; }
            set {  dtrequisicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSERVIDOR
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtservidor;
        [XmlElement(ElementName = "DTSERVIDOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtservidor
        {
            get { return  dtservidor; }
            set {  dtservidor = value; }
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
        /// Propriedade referente ao campo: ESTACQUIRER
        /// Coment�rio: 
        /// </summary>
        private string estacquirer;
        [XmlElement(ElementName = "ESTACQUIRER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Estacquirer
        {
            get { return  estacquirer; }
            set {  estacquirer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTVENDA
        /// Coment�rio: 
        /// </summary>
        private string estvenda;
        [XmlElement(ElementName = "ESTVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Estvenda
        {
            get { return  estvenda; }
            set {  estvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FLUXO
        /// Coment�rio: 
        /// </summary>
        private string fluxo;
        [XmlElement(ElementName = "FLUXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Fluxo
        {
            get { return  fluxo; }
            set {  fluxo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDAPLICACAO
        /// Coment�rio: 
        /// </summary>
        private string idaplicacao;
        [XmlElement(ElementName = "IDAPLICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Idaplicacao
        {
            get { return  idaplicacao; }
            set {  idaplicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDTRANSACAO
        /// Coment�rio: 
        /// </summary>
        private string idtransacao;
        [XmlElement(ElementName = "IDTRANSACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Idtransacao
        {
            get { return  idtransacao; }
            set {  idtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEBANDEIRA
        /// Coment�rio: 
        /// </summary>
        private string nomebandeira;
        [XmlElement(ElementName = "NOMEBANDEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomebandeira
        {
            get { return  nomebandeira; }
            set {  nomebandeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPRODUTOMATRIZ
        /// Coment�rio: 
        /// </summary>
        private string nomeprodutomatriz;
        [XmlElement(ElementName = "NOMEPRODUTOMATRIZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomeprodutomatriz
        {
            get { return  nomeprodutomatriz; }
            set {  nomeprodutomatriz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPRODUTOSECUNDARIO
        /// Coment�rio: 
        /// </summary>
        private string nomeprodutosecundario;
        [XmlElement(ElementName = "NOMEPRODUTOSECUNDARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomeprodutosecundario
        {
            get { return  nomeprodutosecundario; }
            set {  nomeprodutosecundario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Coment�rio: 
        /// </summary>
        private string nsu;
        [XmlElement(ElementName = "NSU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Coment�rio: 
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAN
        /// Coment�rio: 
        /// </summary>
        private string pan;
        [XmlElement(ElementName = "PAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Pan
        {
            get { return  pan; }
            set {  pan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELAS
        /// Coment�rio: 
        /// </summary>
        private decimal parcelas;
        [XmlElement(ElementName = "PARCELAS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Parcelas
        {
            get { return  parcelas; }
            set {  parcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIA
        /// Coment�rio: 
        /// </summary>
        private string referencia;
        [XmlElement(ElementName = "REFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Referencia
        {
            get { return  referencia; }
            set {  referencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETORNOAPLICACAO
        /// Coment�rio: 
        /// </summary>
        private string retornoaplicacao;
        [XmlElement(ElementName = "RETORNOAPLICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Retornoaplicacao
        {
            get { return  retornoaplicacao; }
            set {  retornoaplicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRANSACAO
        /// Coment�rio: 
        /// </summary>
        private string tipotransacao;
        [XmlElement(ElementName = "TIPOTRANSACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotransacao
        {
            get { return  tipotransacao; }
            set {  tipotransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOAPPFINANCEIRA
        /// Coment�rio: 
        /// </summary>
        private string versaoappfinanceira;
        [XmlElement(ElementName = "VERSAOAPPFINANCEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Versaoappfinanceira
        {
            get { return  versaoappfinanceira; }
            set {  versaoappfinanceira = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTPagamento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPAGAMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTPagamento> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPagamento.GetStringConnection());
            return ba.Listar<ESTPagamento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTPagamento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPagamento.GetStringConnection());
            return ba.Existe<ESTPagamento>(where);
        }

        #endregion
    }
}
