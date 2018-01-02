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
    /// Classe referente a tabela PCConfabastecimentowms
    /// </summary>
    [XmlType("PCCONFABASTECIMENTOWMS")]
    public class PCConfabastecimentowms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ABASTECEPICKINGVENDAPELOMASTER
        /// Coment�rio: Define se abastece o picking venda pelo master
        /// </summary>
        private string abastecepickingvendapelomaster;
        [XmlElement(ElementName = "ABASTECEPICKINGVENDAPELOMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Abastecepickingvendapelomaster
        {
            get { return  abastecepickingvendapelomaster; }
            set {  abastecepickingvendapelomaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERACAO
        /// Coment�rio: C�digo da opera��o
        /// </summary>
        private decimal codoperacao;
        [XmlElement(ElementName = "CODOPERACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codoperacao
        {
            get { return  codoperacao; }
            set {  codoperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o modelo abastecimento corretivo
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVIMENTACAOHORIZONTALVERTICAL
        /// Coment�rio: Define se utiliza movimenta��o horizontal vertical
        /// </summary>
        private string movimentacaohorizontalvertical;
        [XmlElement(ElementName = "MOVIMENTACAOHORIZONTALVERTICAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Movimentacaohorizontalvertical
        {
            get { return  movimentacaohorizontalvertical; }
            set {  movimentacaohorizontalvertical = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOABASTECIMENTOCORRETIVO
        /// Coment�rio: Define o tipo do abastecimento corretivo
        /// </summary>
        private string tipoabastecimentocorretivo;
        [XmlElement(ElementName = "TIPOABASTECIMENTOCORRETIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Tipoabastecimentocorretivo
        {
            get { return  tipoabastecimentocorretivo; }
            set {  tipoabastecimentocorretivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRIORIDADEABASTECIMENTO
        /// Coment�rio: Define o tipo da prioridade do abastecimento
        /// </summary>
        private string tipoprioridadeabastecimento;
        [XmlElement(ElementName = "TIPOPRIORIDADEABASTECIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Tipoprioridadeabastecimento
        {
            get { return  tipoprioridadeabastecimento; }
            set {  tipoprioridadeabastecimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRATAMENTOQTDEFRACIONADA
        /// Coment�rio: Define o tipo do tratamento da quantidade fracionada
        /// </summary>
        private string tipotratamentoqtdefracionada;
        [XmlElement(ElementName = "TIPOTRATAMENTOQTDEFRACIONADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Tipotratamentoqtdefracionada
        {
            get { return  tipotratamentoqtdefracionada; }
            set {  tipotratamentoqtdefracionada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAENDERECOPREPICKINGPARAVENDA
        /// Coment�rio: Define se usa o endere�o pr�-picking para venda
        /// </summary>
        private string usaenderecoprepickingparavenda;
        [XmlElement(ElementName = "USAENDERECOPREPICKINGPARAVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaenderecoprepickingparavenda
        {
            get { return  usaenderecoprepickingparavenda; }
            set {  usaenderecoprepickingparavenda = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCConfabastecimentowms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFABASTECIMENTOWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConfabastecimentowms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConfabastecimentowms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCConfabastecimentowms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConfabastecimentowms>(where);
        }

        #endregion
    }
}
