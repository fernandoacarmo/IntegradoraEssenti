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
    /// Classe referente a tabela PCTrocafvmanif
    /// </summary>
    [XmlType("PCTROCAFVMANIF")]
    public class PCTrocafvmanif : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AVARIA
        /// Comentário: Informa se o produto a ser trocado está avariado.
        /// </summary>
        private string avaria;
        [XmlElement(ElementName = "AVARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Avaria
        {
            get { return  avaria; }
            set {  avaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Codigo de barras do produto enviado.
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
        /// Propriedade referente ao campo: CODAUXILIARTROCA
        /// Comentário: Codigo de barras do produto a ser recolhido.
        /// </summary>
        private decimal codauxiliartroca;
        [XmlElement(ElementName = "CODAUXILIARTROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliartroca
        {
            get { return  codauxiliartroca; }
            set {  codauxiliartroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do cliente do pedido manifesto.
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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto que está sendo trocado.
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
        /// Propriedade referente ao campo: CODPRODTROCA
        /// Comentário: Código do produto que está sendo entregue.
        /// </summary>
        private decimal codprodtroca;
        [XmlElement(ElementName = "CODPRODTROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodtroca
        {
            get { return  codprodtroca; }
            set {  codprodtroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: RCA responsável pela troca.
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
        /// Propriedade referente ao campo: DTDEVOL
        /// Comentário: Data da devolução. Preenchido após a entrada da mercadoria pela rotina 1303.
        /// </summary>
        private DateTime? dtdevol;
        [XmlElement(ElementName = "DTDEVOL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdevol
        {
            get { return  dtdevol; }
            set {  dtdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALPROD
        /// Comentário: Data de validade do produto que está sendo trocado.
        /// </summary>
        private DateTime? dtvalprod;
        [XmlElement(ElementName = "DTVALPROD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalprod
        {
            get { return  dtvalprod; }
            set {  dtvalprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALPRODTROCA
        /// Comentário: Data de validade do produto que está sendo entregue.
        /// </summary>
        private DateTime? dtvalprodtroca;
        [XmlElement(ElementName = "DTVALPRODTROCA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalprodtroca
        {
            get { return  dtvalprodtroca; }
            set {  dtvalprodtroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: Motivo selecionado no momento da devolução pela rotina 1303.
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINDENIZ
        /// Comentário: Número da indenizacao gerada na pcindc.
        /// </summary>
        private decimal numindeniz;
        [XmlElement(ElementName = "NUMINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numindeniz
        {
            get { return  numindeniz; }
            set {  numindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Recebe o número da nota gerada na devolução.
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
        /// Propriedade referente ao campo: NUMPEDFAT
        /// Comentário: Número do pedido já faturado que está sendo indenizado.
        /// </summary>
        private decimal numpedfat;
        [XmlElement(ElementName = "NUMPEDFAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedfat
        {
            get { return  numpedfat; }
            set {  numpedfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Comentário: Número do pedido manifesto.
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedrca
        {
            get { return  numpedrca; }
            set {  numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDTV5
        /// Comentário: Número do pedido bonificado utilizado para indenizar o cliente.
        /// </summary>
        private decimal numpedtv5;
        [XmlElement(ElementName = "NUMPEDTV5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedtv5
        {
            get { return  numpedtv5; }
            set {  numpedtv5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: Preço de tabela do produto que está sendo trocado.
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELATROCA
        /// Comentário: Preço de tabela do produto que está sendo entregue.
        /// </summary>
        private decimal ptabelatroca;
        [XmlElement(ElementName = "PTABELATROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelatroca
        {
            get { return  ptabelatroca; }
            set {  ptabelatroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: Quantidade do produto que está sendo trocado.
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTROCA
        /// Comentário: Quantidade do produt oque está sendo entregue.
        /// </summary>
        private decimal qttroca;
        [XmlElement(ElementName = "QTTROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qttroca
        {
            get { return  qttroca; }
            set {  qttroca = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTrocafvmanif()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTROCAFVMANIF";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTrocafvmanif> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTrocafvmanif>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTrocafvmanif> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTrocafvmanif>(where);
        }

        #endregion
    }
}
