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
    /// Classe referente a tabela ESTPedidositensenderecos
    /// </summary>
    [XmlType("ESTPEDIDOSITENSENDERECOS")]
    public class ESTPedidositensenderecos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLIENTE
        /// Comentário: 
        /// </summary>
        private decimal codcliente;
        [XmlElement(ElementName = "CODCLIENTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcliente
        {
            get { return  codcliente; }
            set {  codcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOBRANCA
        /// Comentário: 
        /// </summary>
        private string codcobranca;
        [XmlElement(ElementName = "CODCOBRANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcobranca
        {
            get { return  codcobranca; }
            set {  codcobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAGAMENTO
        /// Comentário: 
        /// </summary>
        private decimal codpagamento;
        [XmlElement(ElementName = "CODPAGAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpagamento
        {
            get { return  codpagamento; }
            set {  codpagamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUNIDADEEXECUTORA
        /// Comentário: 
        /// </summary>
        private string codunidadeexecutora;
        [XmlElement(ElementName = "CODUNIDADEEXECUTORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codunidadeexecutora
        {
            get { return  codunidadeexecutora; }
            set {  codunidadeexecutora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Comentário: 
        /// </summary>
        private decimal? codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codusuarioalt
        {
            get { return  codusuarioalt; }
            set {  codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Comentário: 
        /// </summary>
        private decimal? codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codusuarioinc
        {
            get { return  codusuarioinc; }
            set {  codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORACAD
        /// Comentário: 
        /// </summary>
        private DateTime? datahoracad;
        [XmlElement(ElementName = "DATAHORACAD", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datahoracad
        {
            get { return  datahoracad; }
            set {  datahoracad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMBARQUE
        /// Comentário: 
        /// </summary>
        private DateTime? dtembarque;
        [XmlElement(ElementName = "DTEMBARQUE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtembarque
        {
            get { return  dtembarque; }
            set {  dtembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMPENHO
        /// Comentário: 
        /// </summary>
        private DateTime? dtempenho;
        [XmlElement(ElementName = "DTEMPENHO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtempenho
        {
            get { return  dtempenho; }
            set {  dtempenho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGA
        /// Comentário: 
        /// </summary>
        private DateTime dtentrega;
        [XmlElement(ElementName = "DTENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime Dtentrega
        {
            get { return  dtentrega; }
            set {  dtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENTREGA
        /// Comentário: 
        /// </summary>
        private decimal entrega;
        [XmlElement(ElementName = "ENTREGA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Entrega
        {
            get { return  entrega; }
            set {  entrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORARIO
        /// Comentário: 
        /// </summary>
        private string horario;
        [XmlElement(ElementName = "HORARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Horario
        {
            get { return  horario; }
            set {  horario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALENTREGA
        /// Comentário: 
        /// </summary>
        private string localentrega;
        [XmlElement(ElementName = "LOCALENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Localentrega
        {
            get { return  localentrega; }
            set {  localentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARREGAMENTO
        /// Comentário: 
        /// </summary>
        private decimal? numcarregamento;
        [XmlElement(ElementName = "NUMCARREGAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numcarregamento
        {
            get { return  numcarregamento; }
            set {  numcarregamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEMPENHO
        /// Comentário: 
        /// </summary>
        private string numempenho;
        [XmlElement(ElementName = "NUMEMPENHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numempenho
        {
            get { return  numempenho; }
            set {  numempenho = value; }
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
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTREGA
        /// Comentário: 
        /// </summary>
        private decimal numseqentrega;
        [XmlElement(ElementName = "NUMSEQENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseqentrega
        {
            get { return  numseqentrega; }
            set {  numseqentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Comentário: 
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCARREGAMENTO
        /// Comentário: 
        /// </summary>
        private string obscarregamento;
        [XmlElement(ElementName = "OBSCARREGAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Obscarregamento
        {
            get { return  obscarregamento; }
            set {  obscarregamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSENTREGA
        /// Comentário: 
        /// </summary>
        private string obsentrega;
        [XmlElement(ElementName = "OBSENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,73)]
        public string Obsentrega
        {
            get { return  obsentrega; }
            set {  obsentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESMANCHE
        /// Comentário: 
        /// </summary>
        private decimal qtdesmanche;
        [XmlElement(ElementName = "QTDESMANCHE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtdesmanche
        {
            get { return  qtdesmanche; }
            set {  qtdesmanche = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTREGUE
        /// Comentário: 
        /// </summary>
        private decimal qtentregue;
        [XmlElement(ElementName = "QTENTREGUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtentregue
        {
            get { return  qtentregue; }
            set {  qtentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Comentário: 
        /// </summary>
        private decimal quantidade;
        [XmlElement(ElementName = "QUANTIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Quantidade
        {
            get { return  quantidade; }
            set {  quantidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: 
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTPedidositensenderecos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPEDIDOSITENSENDERECOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTPedidositensenderecos> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidositensenderecos.GetStringConnection());
            return ba.Listar<ESTPedidositensenderecos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTPedidositensenderecos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidositensenderecos.GetStringConnection());
            return ba.Existe<ESTPedidositensenderecos>(where);
        }

        #endregion
    }
}
