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
    /// Classe referente a tabela ESTPedidosaidaitens
    /// </summary>
    [XmlType("ESTPEDIDOSAIDAITENS")]
    public class ESTPedidosaidaitens : BaseAjuri
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
        /// </summary>
        private decimal codproduto;
        [XmlElement(ElementName = "CODPRODUTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codproduto
        {
            get { return  codproduto; }
            set {  codproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIAL
        /// Comentário: 
        /// </summary>
        private string serial;
        [XmlElement(ElementName = "SERIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOESTOQUE
        /// Comentário: 
        /// </summary>
        private string tipoestoque;
        [XmlElement(ElementName = "TIPOESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 30)]
        public string Tipoestoque
        {
            get { return tipoestoque; }
            set { tipoestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: 
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 300)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 300)]
        public string Numlote
        {
            get { return numlote; }
            set { numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAESTOQUEBLOQUEADO 
        /// Comentário: 
        /// </summary>
        private string usaestoquebloqueado;
        [XmlElement(ElementName = "USAESTOQUEBLOQUEADO ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 1)]
        public string Usaestoquebloqueado
        {
            get { return usaestoquebloqueado; }
            set { usaestoquebloqueado = value; }
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
        [DataObjectField(true,false,false,6)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTATENDIDO
        /// Comentário: 
        /// </summary>
        private decimal qtatendido;
        [XmlElement(ElementName = "QTATENDIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtatendido
        {
            get { return  qtatendido; }
            set {  qtatendido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCORTE
        /// Comentário: 
        /// </summary>
        private decimal qtcorte;
        [XmlElement(ElementName = "QTCORTE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Qtcorte
        {
            get { return  qtcorte; }
            set {  qtcorte = value; }
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
        /// Propriedade referente ao campo: VLUNITARIO
        /// Comentário: 
        /// </summary>
        private decimal vlunitario;
        [XmlElement(ElementName = "VLUNITARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Vlunitario
        {
            get { return  vlunitario; }
            set {  vlunitario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFABRICACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtfabricacao;
        [XmlElement(ElementName = "DTFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtfabricacao
        {
            get { return dtfabricacao; }
            set { dtfabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtvalidade
        {
            get { return dtvalidade; }
            set { dtvalidade = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTPedidosaidaitens()
        {
            Inicializar();
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTPEDIDOSAIDAITENS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTPedidosaidaitens> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidosaidaitens.GetStringConnection());
            return ba.Listar<ESTPedidosaidaitens>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTPedidosaidaitens> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTPedidosaidaitens.GetStringConnection());
            return ba.Existe<ESTPedidosaidaitens>(where);
        }

        #endregion
    }
}
