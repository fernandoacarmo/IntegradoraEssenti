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
    /// Classe referente a tabela ESTPedidosaida
    /// </summary>
    [XmlType("ESTPEDIDOSAIDA")]
    public class ESTPedidosaida : BaseAjuri
    {
        #region Atributos

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
        /// Propriedade referente ao campo: CODCLIENTE
        /// Comentário: 
        /// </summary>
        private decimal codcliente;
        [XmlElement(ElementName = "CODCLIENTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcliente
        {
            get { return  codcliente; }
            set {  codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codendereco
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
        private decimal? codgerente;
        [XmlElement(ElementName = "CODGERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codgerente
        {
            get { return  codgerente; }
            set {  codgerente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROFISSIONAL
        /// Comentário: 
        /// </summary>
        private decimal? codprofissional;
        [XmlElement(ElementName = "CODPROFISSIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codprofissional
        {
            get { return  codprofissional; }
            set {  codprofissional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRCA
        /// Comentário: 
        /// </summary>
        private decimal codrca;
        [XmlElement(ElementName = "CODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrca
        {
            get { return  codrca; }
            set {  codrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
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
        /// Propriedade referente ao campo: PRIORIDADE
        /// Comentário: 
        /// </summary>
        private decimal? prioridade;
        [XmlElement(ElementName = "PRIORIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 6)]
        public decimal? Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
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
        /// Propriedade referente ao campo: DTCANCELADO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcancelado;
        [XmlElement(ElementName = "DTCANCELADO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtcancelado
        {
            get { return dtcancelado; }
            set { dtcancelado = value; }
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
        [XmlElement(ElementName = "NUMPEDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedido
        {
            get { return  numpedido; }
            set {  numpedido = value; }
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

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTPedidosaida()
        {
            Inicializar();
            Tipofrete = "C";

        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPEDIDOSAIDA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTPedidosaida> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidosaida.GetStringConnection());
            return ba.Listar<ESTPedidosaida>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTPedidosaida> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidosaida.GetStringConnection());
            return ba.Existe<ESTPedidosaida>(where);
        }

        #endregion
    }
}
