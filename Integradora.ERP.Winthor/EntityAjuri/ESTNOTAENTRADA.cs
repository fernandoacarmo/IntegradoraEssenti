using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityAjuri
{
    /// <summary>
    /// Classe referente a tabela ESTNotaentrada
    /// </summary>
    [XmlType("ESTNOTAENTRADA")]
    public class ESTNotaentrada : BaseAjuri
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CFOP
        /// Comentário: 
        /// </summary>
        private string cfop;
        [XmlElement(ElementName = "CFOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Cfop
        {
            get { return cfop; }
            set { cfop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOCUMENTO
        /// Comentário: 
        /// </summary>
        private string tipodocumento;
        [XmlElement(ElementName = "TIPODOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 2)]
        public string TipoDocumento
        {
            get { return tipodocumento; }
            set { tipodocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFE
        /// Comentário: 
        /// </summary>
        private string chavenfe;
        [XmlElement(ElementName = "CHAVENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Chavenfe
        {
            get { return chavenfe; }
            set { chavenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCUMENTO
        /// Comentário: 
        /// </summary>
        private string documento;
        [XmlElement(ElementName = "DOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_CPF
        /// Comentário: 
        /// </summary>
        private string cnpj_cpf;
        [XmlElement(ElementName = "CNPJ_CPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Cnpj_Cpf
        {
            get { return  cnpj_cpf; }
            set {  cnpj_cpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_EMITENTE
        /// Comentário: 
        /// </summary>
        private string cnpj_emitente;
        [XmlElement(ElementName = "CNPJ_EMITENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Cnpj_Emitente
        {
            get { return  cnpj_emitente; }
            set {  cnpj_emitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_FILIAL
        /// Comentário: 
        /// </summary>
        private string cnpj_filial;
        [XmlElement(ElementName = "CNPJ_FILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Cnpj_Filial
        {
            get { return  cnpj_filial; }
            set {  cnpj_filial = value; }
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
        /// Propriedade referente ao campo: CODFORNECEDOR
        /// Comentário: 
        /// </summary>
        private decimal codfornecedor;
        [XmlElement(ElementName = "CODFORNECEDOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornecedor
        {
            get { return  codfornecedor; }
            set {  codfornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSPORTADORA
        /// Comentário: 
        /// </summary>
        private decimal? codtransportadora;
        [XmlElement(ElementName = "CODTRANSPORTADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codtransportadora
        {
            get { return  codtransportadora; }
            set {  codtransportadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCELADO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcancelado;
        [XmlElement(ElementName = "DTCANCELADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancelado
        {
            get { return dtcancelado; }
            set { dtcancelado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtemissao
        {
            get { return dtemissao; }
            set { dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFATURAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtfaturamento;
        [XmlElement(ElementName = "DTFATURAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfaturamento
        {
            get { return  dtfaturamento; }
            set {  dtfaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONFERENCIA
        /// Comentário: 
        /// </summary>
        private decimal numconferencia;
        [XmlElement(ElementName = "NUMCONFERENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numconferencia
        {
            get { return  numconferencia; }
            set {  numconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Comentário: 
        /// </summary>
        private decimal numpedido;
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedido
        {
            get { return  numpedido; }
            set {  numpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: 
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTITENS
        /// Comentário: 
        /// </summary>
        private decimal qtitens;
        [XmlElement(ElementName = "QTITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtitens
        {
            get { return  qtitens; }
            set {  qtitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

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
        /// Propriedade referente ao campo: TIPONOTA
        /// Comentário: 
        /// </summary>
        private string tiponota;
        [XmlElement(ElementName = "TIPONOTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tiponota
        {
            get { return  tiponota; }
            set {  tiponota = value; }
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

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTNotaentrada()
        {
            Inicializar();
            Tiponota = "E";
            Tipofrete = "C";
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTNOTAENTRADA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTNotaentrada> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTNotaentrada.GetStringConnection());
            return ba.Listar<ESTNotaentrada>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTNotaentrada> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTNotaentrada.GetStringConnection());
            return ba.Existe<ESTNotaentrada>(where);
        }

        #endregion
    }
}
