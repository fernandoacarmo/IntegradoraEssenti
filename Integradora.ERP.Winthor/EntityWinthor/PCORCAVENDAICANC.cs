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
    /// Classe referente a tabela PCOrcavendaicanc
    /// </summary>
    [XmlType("PCORCAVENDAICANC")]
    public class PCOrcavendaicanc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código de barras de uma embalagem.
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial
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
        /// Propriedade referente ao campo: CODFUNCCANC
        /// Comentário: Código funcionário cancelamento.
        /// </summary>
        private decimal codfunccanc;
        [XmlElement(ElementName = "CODFUNCCANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccanc
        {
            get { return  codfunccanc; }
            set {  codfunccanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGARCOMCANC
        /// Comentário: Código do garçom responsável pelo cancelamento de itens e mesas.
        /// </summary>
        private decimal codgarcomcanc;
        [XmlElement(ElementName = "CODGARCOMCANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codgarcomcanc
        {
            get { return  codgarcomcanc; }
            set {  codgarcomcanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIMP
        /// Comentário: Cód. Cadastro de Impressão
        /// </summary>
        private decimal codimp;
        [XmlElement(ElementName = "CODIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codimp
        {
            get { return  codimp; }
            set {  codimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código produto
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
        /// Propriedade referente ao campo: CODST
        /// Comentário: Código da situação tributária do item
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVLIBCANC
        /// Comentário: Supervisor que autorizou o cancelamento do item.
        /// </summary>
        private decimal codsupervlibcanc;
        [XmlElement(ElementName = "CODSUPERVLIBCANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsupervlibcanc
        {
            get { return  codsupervlibcanc; }
            set {  codsupervlibcanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACANC
        /// Comentário: Data cancelamento.
        /// </summary>
        private DateTime? datacanc;
        [XmlElement(ElementName = "DATACANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacanc
        {
            get { return  datacanc; }
            set {  datacanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURA
        /// Comentário: Data abertura.
        /// </summary>
        private DateTime? dtabertura;
        [XmlElement(ElementName = "DTABERTURA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtabertura
        {
            get { return  dtabertura; }
            set {  dtabertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRESSORESTAURANTE
        /// Comentário: Status de impressão do item
        /// </summary>
        private string impressorestaurante;
        [XmlElement(ElementName = "IMPRESSORESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impressorestaurante
        {
            get { return  impressorestaurante; }
            set {  impressorestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRIMERESTAURANTE
        /// Comentário: Embalagem permite impressão restaurante
        /// </summary>
        private string imprimerestaurante;
        [XmlElement(ElementName = "IMPRIMERESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprimerestaurante
        {
            get { return  imprimerestaurante; }
            set {  imprimerestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFICHADEST
        /// Comentário: Número de ficha destino.
        /// </summary>
        private decimal numfichadest;
        [XmlElement(ElementName = "NUMFICHADEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numfichadest
        {
            get { return  numfichadest; }
            set {  numfichadest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFICHAORIG
        /// Comentário: Número de ficha origem.
        /// </summary>
        private decimal numfichaorig;
        [XmlElement(ElementName = "NUMFICHAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numfichaorig
        {
            get { return  numfichaorig; }
            set {  numfichaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Comentário: Número orçamento
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCADEST
        /// Comentário: Número orçamento destino.
        /// </summary>
        private decimal numorcadest;
        [XmlElement(ElementName = "NUMORCADEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorcadest
        {
            get { return  numorcadest; }
            set {  numorcadest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Número de sequencia
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
        /// Propriedade referente ao campo: NUMSEQIMPRESSAO
        /// Comentário: Núm. Sêq de Impressâo Restaurante
        /// </summary>
        private decimal numseqimpressao;
        [XmlElement(ElementName = "NUMSEQIMPRESSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqimpressao
        {
            get { return  numseqimpressao; }
            set {  numseqimpressao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: Preço de tabela
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: Preço de venda
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public decimal Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: Quantidade
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCANCEL
        /// Comentário: Tipo de cancelamento
        /// </summary>
        private string tipocancel;
        [XmlElement(ElementName = "TIPOCANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocancel
        {
            get { return  tipocancel; }
            set {  tipocancel = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOrcavendaicanc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORCAVENDAICANC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOrcavendaicanc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrcavendaicanc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOrcavendaicanc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrcavendaicanc>(where);
        }

        #endregion
    }
}
