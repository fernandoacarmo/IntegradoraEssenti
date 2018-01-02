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
    /// Classe referente a tabela PCOrigemcomis
    /// </summary>
    [XmlType("PCORIGEMCOMIS")]
    public class PCOrigemcomis : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código de barras auxiliar
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: Código da cobrança
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOMIS
        /// Comentário: Código do registro da comissão validada
        /// </summary>
        private decimal codcomis;
        [XmlElement(ElementName = "CODCOMIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcomis
        {
            get { return  codcomis; }
            set {  codcomis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial do pedido
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHAPROD
        /// Comentário: codigo de linha do produto
        /// </summary>
        private decimal codlinhaprod;
        [XmlElement(ElementName = "CODLINHAPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlinhaprod
        {
            get { return  codlinhaprod; }
            set {  codlinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: Código do Plano de pagamento
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do Produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINACOMIS
        /// Comentário: Rotina utilizada para lançamento do percentual de comissão
        /// </summary>
        private string codrotinacomis;
        [XmlElement(ElementName = "CODROTINACOMIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codrotinacomis
        {
            get { return  codrotinacomis; }
            set {  codrotinacomis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Código do RCA
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAORCATIPOVENDA
        /// Comentário: Registra o valor do Parâmetro 1514 da rotina 132 no momento do cálculo da comissão
        /// </summary>
        private string comissaorcatipovenda;
        [XmlElement(ElementName = "COMISSAORCATIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comissaorcatipovenda
        {
            get { return  comissaorcatipovenda; }
            set {  comissaorcatipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERARCOMISSAOZERO
        /// Comentário: Registra o valor do Parâmetro 2220 da rotina 132 no momento do cálculo da comissão
        /// </summary>
        private string considerarcomissaozero;
        [XmlElement(ElementName = "CONSIDERARCOMISSAOZERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerarcomissaozero
        {
            get { return  considerarcomissaozero; }
            set {  considerarcomissaozero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Data de inclusao do registro
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Número do pedido no Winthor
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: Número da região onde o preço foi validado
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Sequência de inserção
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMAVALIACAOCOMISSAORCA
        /// Comentário: Registra o valor do Parâmetro 1185 da rotina 132 no momento do cálculo da comissão
        /// </summary>
        private decimal ordemavaliacaocomissaorca;
        [XmlElement(ElementName = "ORDEMAVALIACAOCOMISSAORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Ordemavaliacaocomissaorca
        {
            get { return  ordemavaliacaocomissaorca; }
            set {  ordemavaliacaocomissaorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Comentário: Origem do pedido, se 'T' Telemarketing, se  'F' Força de vendas, se 'W' Web
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Comentário: Percentual de comissão apurado
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC
        /// Comentário: Percentual de desconto concedido pelo RCA
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAVALIACAOCOMISSAO
        /// Comentário: Registra o valor do Parâmetro 2273 da rotina 132 no momento do cálculo da comissão
        /// </summary>
        private decimal tipoavaliacaocomissao;
        [XmlElement(ElementName = "TIPOAVALIACAOCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoavaliacaocomissao
        {
            get { return  tipoavaliacaocomissao; }
            set {  tipoavaliacaocomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOMISSAO
        /// Comentário: Tipo de comissão da pcprodut
        /// </summary>
        private string tipocomissao;
        [XmlElement(ElementName = "TIPOCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocomissao
        {
            get { return  tipocomissao; }
            set {  tipocomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVEND
        /// Comentário: tipo venda da pcusuari
        /// </summary>
        private string tipovend;
        [XmlElement(ElementName = "TIPOVEND", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovend
        {
            get { return  tipovend; }
            set {  tipovend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Comentário: tipo venda do plano de pagamento
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMISSAOPORCLIENTE
        /// Comentário: Registra o valor do Parâmetro 1265 da  rotina 132 no momento do cálculo da comissão
        /// </summary>
        private string usacomissaoporcliente;
        [XmlElement(ElementName = "USACOMISSAOPORCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomissaoporcliente
        {
            get { return  usacomissaoporcliente; }
            set {  usacomissaoporcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMISSAOPORLINHAPROD
        /// Comentário: Registra o valor do Parâmetro 1103 da rotina 132 no momento do cálculo da comissão
        /// </summary>
        private string usacomissaoporlinhaprod;
        [XmlElement(ElementName = "USACOMISSAOPORLINHAPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomissaoporlinhaprod
        {
            get { return  usacomissaoporlinhaprod; }
            set {  usacomissaoporlinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOMISSAOPORRCA
        /// Comentário: Registra o valor do Parâmetro 1266 da rotina 132 no momento do cálculo da comissão
        /// </summary>
        private string usacomissaoporrca;
        [XmlElement(ElementName = "USACOMISSAOPORRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacomissaoporrca
        {
            get { return  usacomissaoporrca; }
            set {  usacomissaoporrca = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOrigemcomis()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORIGEMCOMIS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOrigemcomis> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrigemcomis>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOrigemcomis> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrigemcomis>(where);
        }

        #endregion
    }
}
