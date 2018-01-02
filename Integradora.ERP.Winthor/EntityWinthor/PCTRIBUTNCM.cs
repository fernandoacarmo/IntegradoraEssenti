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
    /// Classe referente a tabela PCTributncm
    /// </summary>
    [XmlType("PCTRIBUTNCM")]
    public class PCTributncm : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1TAB
        /// Comentário: % Aliq. Interna.
        /// </summary>
        private decimal aliqicms1tab;
        [XmlElement(ElementName = "ALIQICMS1TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1tab
        {
            get { return  aliqicms1tab; }
            set {  aliqicms1tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2TAB
        /// Comentário: % Aliq. Externa.
        /// </summary>
        private decimal aliqicms2tab;
        [XmlElement(ElementName = "ALIQICMS2TAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms2tab
        {
            get { return  aliqicms2tab; }
            set {  aliqicms2tab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAPVOLDNF
        /// Comentário: capacidade Volume (DNF)
        /// </summary>
        private decimal capvoldnf;
        [XmlElement(ElementName = "CAPVOLDNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Capvoldnf
        {
            get { return  capvoldnf; }
            set {  capvoldnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICM
        /// Comentário: %ICMSCMV.
        /// </summary>
        private decimal codicm;
        [XmlElement(ElementName = "CODICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicm
        {
            get { return  codicm; }
            set {  codicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMTAB
        /// Comentário: %ICMS Antecipado.
        /// </summary>
        private decimal codicmtab;
        [XmlElement(ElementName = "CODICMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtab
        {
            get { return  codicmtab; }
            set {  codicmtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPASSEFISCAL
        /// Comentário: Código passe fiscal
        /// </summary>
        private decimal codpassefiscal;
        [XmlElement(ElementName = "CODPASSEFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Codpassefiscal
        {
            get { return  codpassefiscal; }
            set {  codpassefiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODDNF
        /// Comentário: Código produto (DNF)
        /// </summary>
        private decimal codproddnf;
        [XmlElement(ElementName = "CODPRODDNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Codproddnf
        {
            get { return  codproddnf; }
            set {  codproddnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Comentário: Código da situação tributária.
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCONVDNF
        /// Comentário: Fator de conversão (DNF)
        /// </summary>
        private decimal fatorconvdnf;
        [XmlElement(ElementName = "FATORCONVDNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Fatorconvdnf
        {
            get { return  fatorconvdnf; }
            set {  fatorconvdnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVATAB
        /// Comentário: % IVA.
        /// </summary>
        private decimal ivatab;
        [XmlElement(ElementName = "IVATAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Ivatab
        {
            get { return  ivatab; }
            set {  ivatab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NCM
        /// Comentário: Nomeclatura comum Mercosul
        /// </summary>
        private string ncm;
        [XmlElement(ElementName = "NCM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Ncm
        {
            get { return  ncm; }
            set {  ncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PASSELIVRE
        /// Comentário: Passe Livre
        /// </summary>
        private string passelivre;
        [XmlElement(ElementName = "PASSELIVRE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Passelivre
        {
            get { return  passelivre; }
            set {  passelivre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERED
        /// Comentário: % base de redução.
        /// </summary>
        private decimal percbasered;
        [XmlElement(ElementName = "PERCBASERED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbasered
        {
            get { return  percbasered; }
            set {  percbasered = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPIVENDA
        /// Comentário: % de IPI (imposto produtos industrializados)
        /// </summary>
        private decimal percipivenda;
        [XmlElement(ElementName = "PERCIPIVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Percipivenda
        {
            get { return  percipivenda; }
            set {  percipivenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCUSTO
        /// Comentário: % Desconto Custo.
        /// </summary>
        private decimal perdesccusto;
        [XmlElement(ElementName = "PERDESCCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdesccusto
        {
            get { return  perdesccusto; }
            set {  perdesccusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Comentário: Situação Tributária.
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIPORKGVENDA
        /// Comentário: Valor de IPI por Kilo
        /// </summary>
        private decimal vlipiporkgvenda;
        [XmlElement(ElementName = "VLIPIPORKGVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlipiporkgvenda
        {
            get { return  vlipiporkgvenda; }
            set {  vlipiporkgvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPAUTAIPIVENDA
        /// Comentário: Valor Pauta de IPI na venda
        /// </summary>
        private decimal vlpautaipivenda;
        [XmlElement(ElementName = "VLPAUTAIPIVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlpautaipivenda
        {
            get { return  vlpautaipivenda; }
            set {  vlpautaipivenda = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTributncm()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBUTNCM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTributncm> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTributncm>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTributncm> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTributncm>(where);
        }

        #endregion
    }
}
