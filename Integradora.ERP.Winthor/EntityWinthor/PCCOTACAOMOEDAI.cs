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
    /// Classe referente a tabela PCCotacaomoedai
    /// </summary>
    [XmlType("PCCOTACAOMOEDAI")]
    public class PCCotacaomoedai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
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
        /// Propriedade referente ao campo: COTACAO
        /// Comentário: 
        /// </summary>
        private decimal cotacao;
        [XmlElement(ElementName = "COTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Cotacao
        {
            get { return  cotacao; }
            set {  cotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAOCOMPRA
        /// Comentário: Valor da Cotação Livre (Compra) da moeda.
        /// </summary>
        private decimal cotacaocompra;
        [XmlElement(ElementName = "COTACAOCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Cotacaocompra
        {
            get { return  cotacaocompra; }
            set {  cotacaocompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAOVENDA
        /// Comentário: Valor da Cotação Livre (Venda) da moeda.
        /// </summary>
        private decimal cotacaovenda;
        [XmlElement(ElementName = "COTACAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Cotacaovenda
        {
            get { return  cotacaovenda; }
            set {  cotacaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACOTACAO
        /// Comentário: 
        /// </summary>
        private DateTime? datacotacao;
        [XmlElement(ElementName = "DATACOTACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datacotacao
        {
            get { return  datacotacao; }
            set {  datacotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARIDADECOMPRA
        /// Comentário: Paridade em relação ao dolar de compra
        /// </summary>
        private decimal paridadecompra;
        [XmlElement(ElementName = "PARIDADECOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Paridadecompra
        {
            get { return  paridadecompra; }
            set {  paridadecompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARIDADEVENDA
        /// Comentário: Paridade em relação ao dolar de venda
        /// </summary>
        private decimal paridadevenda;
        [XmlElement(ElementName = "PARIDADEVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Paridadevenda
        {
            get { return  paridadevenda; }
            set {  paridadevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPARIDADE
        /// Comentário: Tipo de paridade
        /// </summary>
        private string tipoparidade;
        [XmlElement(ElementName = "TIPOPARIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoparidade
        {
            get { return  tipoparidade; }
            set {  tipoparidade = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCotacaomoedai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTACAOMOEDAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCotacaomoedai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotacaomoedai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCotacaomoedai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotacaomoedai>(where);
        }

        #endregion
    }
}
