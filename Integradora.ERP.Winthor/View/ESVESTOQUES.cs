using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvestoques
    /// </summary>
    [XmlType("ESVESTOQUES")]
    public class Esvestoques : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Comentário: 
        /// </summary>
        private decimal codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMPRESA
        /// Comentário: 
        /// </summary>
        private string codempresa;
        [XmlElement(ElementName = "CODEMPRESA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codempresa
        {
            get { return  codempresa; }
            set {  codempresa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODMASTER
        /// Comentário: 
        /// </summary>
        private decimal codprodmaster;
        [XmlElement(ElementName = "CODPRODMASTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Codprodmaster
        {
            get { return  codprodmaster; }
            set {  codprodmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CUSTOATRIBUIDO
        /// Comentário: 
        /// </summary>
        private decimal custoatribuido;
        [XmlElement(ElementName = "CUSTOATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Custoatribuido
        {
            get { return  custoatribuido; }
            set {  custoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOULTENT
        /// Comentário: 
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMBALAGEM
        /// Comentário: 
        /// </summary>
        private string embalagem;
        [XmlElement(ElementName = "EMBALAGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public string Embalagem
        {
            get { return  embalagem; }
            set {  embalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FOTOPRODUTO
        /// Comentário: 
        /// </summary>
        private string fotoproduto;
        [XmlElement(ElementName = "FOTOPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Fotoproduto
        {
            get { return  fotoproduto; }
            set {  fotoproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NCM
        /// Comentário: 
        /// </summary>
        private string ncm;
        [XmlElement(ElementName = "NCM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ncm
        {
            get { return  ncm; }
            set {  ncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTULTENT
        /// Comentário: 
        /// </summary>
        private decimal numtransentultent;
        [XmlElement(ElementName = "NUMTRANSENTULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentultent
        {
            get { return  numtransentultent; }
            set {  numtransentultent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODUTO
        /// Comentário: 
        /// </summary>
        private string produto;
        [XmlElement(ElementName = "PRODUTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Produto
        {
            get { return  produto; }
            set {  produto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal qtestoque;
        [XmlElement(ElementName = "QTESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtestoque
        {
            get { return  qtestoque; }
            set {  qtestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMASTERBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal qtmasterbloqueada;
        [XmlElement(ElementName = "QTMASTERBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtmasterbloqueada
        {
            get { return  qtmasterbloqueada; }
            set {  qtmasterbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMASTERESTOQUE
        /// Comentário: 
        /// </summary>
        private decimal qtmasterestoque;
        [XmlElement(ElementName = "QTMASTERESTOQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtmasterestoque
        {
            get { return  qtmasterestoque; }
            set {  qtmasterestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMASTERPEDIDA
        /// Comentário: 
        /// </summary>
        private decimal qtmasterpedida;
        [XmlElement(ElementName = "QTMASTERPEDIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtmasterpedida
        {
            get { return  qtmasterpedida; }
            set {  qtmasterpedida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMASTERRESERVADA
        /// Comentário: 
        /// </summary>
        private decimal qtmasterreservada;
        [XmlElement(ElementName = "QTMASTERRESERVADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtmasterreservada
        {
            get { return  qtmasterreservada; }
            set {  qtmasterreservada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMASTERSALDOATUAL
        /// Comentário: 
        /// </summary>
        private decimal qtmastersaldoatual;
        [XmlElement(ElementName = "QTMASTERSALDOATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtmastersaldoatual
        {
            get { return  qtmastersaldoatual; }
            set {  qtmastersaldoatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDIDA
        /// Comentário: 
        /// </summary>
        private decimal qtpedida;
        [XmlElement(ElementName = "QTPEDIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtpedida
        {
            get { return  qtpedida; }
            set {  qtpedida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERVADA
        /// Comentário: 
        /// </summary>
        private decimal qtreservada;
        [XmlElement(ElementName = "QTRESERVADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtreservada
        {
            get { return  qtreservada; }
            set {  qtreservada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSALDOATUAL
        /// Comentário: 
        /// </summary>
        private decimal qtsaldoatual;
        [XmlElement(ElementName = "QTSALDOATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtsaldoatual
        {
            get { return  qtsaldoatual; }
            set {  qtsaldoatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Comentário: 
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORULTENT
        /// Comentário: 
        /// </summary>
        private decimal valorultent;
        [XmlElement(ElementName = "VALORULTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Valorultent
        {
            get { return  valorultent; }
            set {  valorultent = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvestoques()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVESTOQUES";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvestoques> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvestoques.GetStringConnection());
            return ba.Listar<Esvestoques>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvestoques> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvestoques.GetStringConnection());
            return ba.Existe<Esvestoques>(where);
        }

        #endregion
    }
}
