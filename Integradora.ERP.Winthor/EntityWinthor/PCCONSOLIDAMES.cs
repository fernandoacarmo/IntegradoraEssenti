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
    /// Classe referente a tabela PCConsolidames
    /// </summary>
    [XmlType("PCCONSOLIDAMES")]
    public class PCConsolidames : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Ano consolidado.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial consolidado.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Codigo definido pelo tipo de consolidação.
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: Mês consolidado.
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOMPRA
        /// Comentário: Quantidade compra por mês
        /// </summary>
        private decimal qtcompra;
        [XmlElement(ElementName = "QTCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtcompra
        {
            get { return  qtcompra; }
            set {  qtcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVCLIENTE
        /// Comentário: Quantidade de devolução de cliente
        /// </summary>
        private decimal qtdevcliente;
        [XmlElement(ElementName = "QTDEVCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtdevcliente
        {
            get { return  qtdevcliente; }
            set {  qtdevcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVFORNECEDOR
        /// Comentário: Quantidade de devolução a fornecedor por mês
        /// </summary>
        private decimal qtdevfornecedor;
        [XmlElement(ElementName = "QTDEVFORNECEDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtdevfornecedor
        {
            get { return  qtdevfornecedor; }
            set {  qtdevfornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIDA
        /// Comentário: Quantidade Produzida.
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
        /// Propriedade referente ao campo: QTVENDA
        /// Comentário: Quantidade venda consolidado no período.
        /// </summary>
        private decimal qtvenda;
        [XmlElement(ElementName = "QTVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtvenda
        {
            get { return  qtvenda; }
            set {  qtvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Define o tipo de consolidação: PCAUXPROD = "P", PCAUXCLI = "C", PCAUXFOR = "F".
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMPRA
        /// Comentário: Valor da compra consolidado no período.
        /// </summary>
        private decimal vlcompra;
        [XmlElement(ElementName = "VLCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlcompra
        {
            get { return  vlcompra; }
            set {  vlcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTENTMES
        /// Comentário: Média do valor da última entrada
        /// </summary>
        private decimal vlultentmes;
        [XmlElement(ElementName = "VLULTENTMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultentmes
        {
            get { return  vlultentmes; }
            set {  vlultentmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDA
        /// Comentário: Valor da venda consolidado no período.
        /// </summary>
        private decimal vlvenda;
        [XmlElement(ElementName = "VLVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlvenda
        {
            get { return  vlvenda; }
            set {  vlvenda = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConsolidames()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONSOLIDAMES";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConsolidames> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConsolidames>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConsolidames> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConsolidames>(where);
        }

        #endregion
    }
}
