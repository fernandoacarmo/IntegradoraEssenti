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
        /// Coment�rio: C�digo de barras auxiliar
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
        /// Coment�rio: C�digo do cliente
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
        /// Coment�rio: C�digo da cobran�a
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
        /// Coment�rio: C�digo do registro da comiss�o validada
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
        /// Coment�rio: C�digo da filial do pedido
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
        /// Coment�rio: codigo de linha do produto
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
        /// Coment�rio: C�digo do Plano de pagamento
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
        /// Coment�rio: C�digo do Produto
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
        /// Coment�rio: Rotina utilizada para lan�amento do percentual de comiss�o
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
        /// Coment�rio: C�digo do RCA
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
        /// Coment�rio: Registra o valor do Par�metro 1514 da rotina 132 no momento do c�lculo da comiss�o
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
        /// Coment�rio: Registra o valor do Par�metro 2220 da rotina 132 no momento do c�lculo da comiss�o
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
        /// Coment�rio: Data de inclusao do registro
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
        /// Coment�rio: N�mero do pedido no Winthor
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
        /// Coment�rio: N�mero da regi�o onde o pre�o foi validado
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
        /// Coment�rio: Sequ�ncia de inser��o
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
        /// Coment�rio: Registra o valor do Par�metro 1185 da rotina 132 no momento do c�lculo da comiss�o
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
        /// Coment�rio: Origem do pedido, se 'T' Telemarketing, se  'F' For�a de vendas, se 'W' Web
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
        /// Coment�rio: Percentual de comiss�o apurado
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
        /// Coment�rio: Percentual de desconto concedido pelo RCA
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
        /// Coment�rio: Registra o valor do Par�metro 2273 da rotina 132 no momento do c�lculo da comiss�o
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
        /// Coment�rio: Tipo de comiss�o da pcprodut
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
        /// Coment�rio: tipo venda da pcusuari
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
        /// Coment�rio: tipo venda do plano de pagamento
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
        /// Coment�rio: Registra o valor do Par�metro 1265 da  rotina 132 no momento do c�lculo da comiss�o
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
        /// Coment�rio: Registra o valor do Par�metro 1103 da rotina 132 no momento do c�lculo da comiss�o
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
        /// Coment�rio: Registra o valor do Par�metro 1266 da rotina 132 no momento do c�lculo da comiss�o
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOrigemcomis> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrigemcomis>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
