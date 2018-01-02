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
        /// Coment�rio: C�digo de barras de uma embalagem.
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
        /// Coment�rio: C�digo da filial
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
        /// Coment�rio: C�digo funcion�rio cancelamento.
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
        /// Coment�rio: C�digo do gar�om respons�vel pelo cancelamento de itens e mesas.
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
        /// Coment�rio: C�d. Cadastro de Impress�o
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
        /// Coment�rio: C�digo produto
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
        /// Coment�rio: C�digo da situa��o tribut�ria do item
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
        /// Coment�rio: Supervisor que autorizou o cancelamento do item.
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
        /// Coment�rio: Data cancelamento.
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
        /// Coment�rio: Data abertura.
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
        /// Coment�rio: Status de impress�o do item
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
        /// Coment�rio: Embalagem permite impress�o restaurante
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
        /// Coment�rio: N�mero de ficha destino.
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
        /// Coment�rio: N�mero de ficha origem.
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
        /// Coment�rio: N�mero or�amento
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
        /// Coment�rio: N�mero or�amento destino.
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
        /// Coment�rio: N�mero de sequencia
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
        /// Coment�rio: N�m. S�q de Impress�o Restaurante
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
        /// Coment�rio: Pre�o de tabela
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
        /// Coment�rio: Pre�o de venda
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
        /// Coment�rio: Quantidade
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
        /// Coment�rio: Tipo de cancelamento
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOrcavendaicanc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrcavendaicanc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
