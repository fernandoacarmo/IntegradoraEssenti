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
    /// Classe referente a tabela PCCortefv
    /// </summary>
    [XmlType("PCCORTEFV")]
    public class PCCortefv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: C�digo de barras
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
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial do pedido
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
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Coment�rio: C�digo da Filial retira do item
        /// </summary>
        private string codfilialretira;
        [XmlElement(ElementName = "CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira
        {
            get { return  codfilialretira; }
            set {  codfilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCORTE
        /// Coment�rio: C�digo do Usuario que fez o corte
        /// </summary>
        private string codfunccorte;
        [XmlElement(ElementName = "CODFUNCCORTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Codfunccorte
        {
            get { return  codfunccorte; }
            set {  codfunccorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto
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
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�digo do rca
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
        /// Propriedade referente ao campo: DTABERTURAPEDPALM
        /// Coment�rio: Data do pedido no palm
        /// </summary>
        private DateTime? dtaberturapedpalm;
        [XmlElement(ElementName = "DTABERTURAPEDPALM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaberturapedpalm
        {
            get { return  dtaberturapedpalm; }
            set {  dtaberturapedpalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCORTE
        /// Coment�rio: Data do corte
        /// </summary>
        private DateTime? dtcorte;
        [XmlElement(ElementName = "DTCORTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcorte
        {
            get { return  dtcorte; }
            set {  dtcorte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAQUINA
        /// Coment�rio: M�quina onde foi feito o corte
        /// </summary>
        private string maquina;
        [XmlElement(ElementName = "MAQUINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Maquina
        {
            get { return  maquina; }
            set {  maquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: N�mero do pedido do Winthor
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
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Coment�rio: N�mero do pedido do palm
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
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: Sequencia
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
        /// Propriedade referente ao campo: PROGRAMA
        /// Coment�rio: C�digo da rotina onde foi feito o corte
        /// </summary>
        private string programa;
        [XmlElement(ElementName = "PROGRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Programa
        {
            get { return  programa; }
            set {  programa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTANT
        /// Coment�rio: Quantidade anterior ao corte
        /// </summary>
        private decimal qtant;
        [XmlElement(ElementName = "QTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtant
        {
            get { return  qtant; }
            set {  qtant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCORTE
        /// Coment�rio: Quantidade cortada
        /// </summary>
        private decimal qtcorte;
        [XmlElement(ElementName = "QTCORTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtcorte
        {
            get { return  qtcorte; }
            set {  qtcorte = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCortefv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCORTEFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCortefv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCortefv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCortefv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCortefv>(where);
        }

        #endregion
    }
}
