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
    /// Classe referente a tabela ESTPedidositens
    /// </summary>
    [XmlType("ESTPEDIDOSITENS")]
    public class ESTPedidositens : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CESTAMONTADA
        /// Coment�rio: 
        /// </summary>
        private string cestamontada;
        [XmlElement(ElementName = "CESTAMONTADA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Cestamontada
        {
            get { return  cestamontada; }
            set {  cestamontada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Coment�rio: 
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CUSTOATRIBUIDO
        /// Coment�rio: 
        /// </summary>
        private decimal custoatribuido;
        [XmlElement(ElementName = "CUSTOATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoatribuido
        {
            get { return  custoatribuido; }
            set {  custoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOESCOLHIDO
        /// Coment�rio: 
        /// </summary>
        private decimal custoescolhido;
        [XmlElement(ElementName = "CUSTOESCOLHIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Custoescolhido
        {
            get { return  custoescolhido; }
            set {  custoescolhido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal custoultent;
        [XmlElement(ElementName = "CUSTOULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Custoultent
        {
            get { return  custoultent; }
            set {  custoultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORACAD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DESCRICAOCLIENTE
        /// Coment�rio: 
        /// </summary>
        private string descricaocliente;
        [XmlElement(ElementName = "DESCRICAOCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Descricaocliente
        {
            get { return  descricaocliente; }
            set {  descricaocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTDESMANCHE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtdesmanche;
        [XmlElement(ElementName = "DTDESMANCHE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdesmanche
        {
            get { return  dtdesmanche; }
            set {  dtdesmanche = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDIDO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMPEDIDOREQUISITADO
        /// Coment�rio: 
        /// </summary>
        private decimal? numpedidorequisitado;
        [XmlElement(ElementName = "NUMPEDIDOREQUISITADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numpedidorequisitado
        {
            get { return  numpedidorequisitado; }
            set {  numpedidorequisitado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMSEQPAI
        /// Coment�rio: 
        /// </summary>
        private decimal? numseqpai;
        [XmlElement(ElementName = "NUMSEQPAI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numseqpai
        {
            get { return  numseqpai; }
            set {  numseqpai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQREQUISITADO
        /// Coment�rio: 
        /// </summary>
        private decimal? numseqrequisitado;
        [XmlElement(ElementName = "NUMSEQREQUISITADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Numseqrequisitado
        {
            get { return  numseqrequisitado; }
            set {  numseqrequisitado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSDESMANCHE
        /// Coment�rio: 
        /// </summary>
        private string obsdesmanche;
        [XmlElement(ElementName = "OBSDESMANCHE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obsdesmanche
        {
            get { return  obsdesmanche; }
            set {  obsdesmanche = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: OBSPRODUCAO
        /// Coment�rio: 
        /// </summary>
        private string obsproducao;
        [XmlElement(ElementName = "OBSPRODUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Obsproducao
        {
            get { return  obsproducao; }
            set {  obsproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCONTO
        /// Coment�rio: 
        /// </summary>
        private decimal percdesconto;
        [XmlElement(ElementName = "PERCDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Percdesconto
        {
            get { return  percdesconto; }
            set {  percdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESMANCHE
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: QTPRODUZIDA
        /// Coment�rio: 
        /// </summary>
        private decimal qtproduzida;
        [XmlElement(ElementName = "QTPRODUZIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtproduzida
        {
            get { return  qtproduzida; }
            set {  qtproduzida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUANTIDADE
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VALORULTENT
        /// Coment�rio: 
        /// </summary>
        private decimal valorultent;
        [XmlElement(ElementName = "VALORULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Valorultent
        {
            get { return  valorultent; }
            set {  valorultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Coment�rio: 
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal vltabela;
        [XmlElement(ElementName = "VLTABELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vltabela
        {
            get { return  vltabela; }
            set {  vltabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: VLUNITARIO
        /// Coment�rio: 
        /// </summary>
        private decimal vlunitario;
        [XmlElement(ElementName = "VLUNITARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlunitario
        {
            get { return  vlunitario; }
            set {  vlunitario = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTPedidositens()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPEDIDOSITENS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTPedidositens> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidositens.GetStringConnection());
            return ba.Listar<ESTPedidositens>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTPedidositens> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidositens.GetStringConnection());
            return ba.Existe<ESTPedidositens>(where);
        }

        #endregion
    }
}
