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
    /// Classe referente a tabela PCRegiao
    /// </summary>
    [XmlType("PCREGIAO")]
    public class PCRegiao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAF11
        /// Coment�rio: 
        /// </summary>
        private string atualizaf11;
        [XmlElement(ElementName = "ATUALIZAF11", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaf11
        {
            get { return  atualizaf11; }
            set {  atualizaf11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTABELECIMENTO
        /// Coment�rio: 
        /// </summary>
        private string codestabelecimento;
        [XmlElement(ElementName = "CODESTABELECIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codestabelecimento
        {
            get { return  codestabelecimento; }
            set {  codestabelecimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DISTRIB
        /// Coment�rio: 
        /// </summary>
        private string distrib;
        [XmlElement(ElementName = "DISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Distrib
        {
            get { return  distrib; }
            set {  distrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTAFV
        /// Coment�rio: 
        /// </summary>
        private decimal exportafv;
        [XmlElement(ElementName = "EXPORTAFV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Exportafv
        {
            get { return  exportafv; }
            set {  exportafv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTABELA
        /// Coment�rio: 
        /// </summary>
        private string numtabela;
        [XmlElement(ElementName = "NUMTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numtabela
        {
            get { return  numtabela; }
            set {  numtabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Campo para informar observa��es importantes sobre a Regi�o. 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal perfrete;
        [XmlElement(ElementName = "PERFRETE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Perfrete
        {
            get { return  perfrete; }
            set {  perfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETECONHEC
        /// Coment�rio: 
        /// </summary>
        private decimal perfreteconhec;
        [XmlElement(ElementName = "PERFRETECONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfreteconhec
        {
            get { return  perfreteconhec; }
            set {  perfreteconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETEESPECIAL
        /// Coment�rio: 
        /// </summary>
        private decimal perfreteespecial;
        [XmlElement(ElementName = "PERFRETEESPECIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfreteespecial
        {
            get { return  perfreteespecial; }
            set {  perfreteespecial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETETERCEIROS
        /// Coment�rio: 
        /// </summary>
        private decimal perfreteterceiros;
        [XmlElement(ElementName = "PERFRETETERCEIROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfreteterceiros
        {
            get { return  perfreteterceiros; }
            set {  perfreteterceiros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGIAO
        /// Coment�rio: 
        /// </summary>
        private string regiao;
        [XmlElement(ElementName = "REGIAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Regiao
        {
            get { return  regiao; }
            set {  regiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGIAOZFM
        /// Coment�rio: 
        /// </summary>
        private string regiaozfm;
        [XmlElement(ElementName = "REGIAOZFM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Regiaozfm
        {
            get { return  regiaozfm; }
            set {  regiaozfm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEGMENTO
        /// Coment�rio: 
        /// </summary>
        private string segmento;
        [XmlElement(ElementName = "SEGMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Segmento
        {
            get { return  segmento; }
            set {  segmento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STONUMDIASCARENCIACOBRJUROS
        /// Coment�rio: 
        /// </summary>
        private decimal stonumdiascarenciacobrjuros;
        [XmlElement(ElementName = "STONUMDIASCARENCIACOBRJUROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Stonumdiascarenciacobrjuros
        {
            get { return  stonumdiascarenciacobrjuros; }
            set {  stonumdiascarenciacobrjuros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAREPF
        /// Coment�rio: 
        /// </summary>
        private string tarepf;
        [XmlElement(ElementName = "TAREPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tarepf
        {
            get { return  tarepf; }
            set {  tarepf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: 
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEKG
        /// Coment�rio: 
        /// </summary>
        private decimal vlfretekg;
        [XmlElement(ElementName = "VLFRETEKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlfretekg
        {
            get { return  vlfretekg; }
            set {  vlfretekg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEKGPADRAO
        /// Coment�rio: Valor de Frete Kg por Regi�o, que ser� gravado na Tabela de Pre�o (PCTABPR.VLACRESFRETEKG). 
        /// </summary>
        private decimal vlfretekgpadrao;
        [XmlElement(ElementName = "VLFRETEKGPADRAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlfretekgpadrao
        {
            get { return  vlfretekgpadrao; }
            set {  vlfretekgpadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEKGVENDA
        /// Coment�rio: Valor de Venda Kg por Regi�o. 
        /// </summary>
        private decimal vlfretekgvenda;
        [XmlElement(ElementName = "VLFRETEKGVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlfretekgvenda
        {
            get { return  vlfretekgvenda; }
            set {  vlfretekgvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINFATBK
        /// Coment�rio: 
        /// </summary>
        private decimal vlminfatbk;
        [XmlElement(ElementName = "VLMINFATBK", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlminfatbk
        {
            get { return  vlminfatbk; }
            set {  vlminfatbk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINFATCH
        /// Coment�rio: 
        /// </summary>
        private decimal vlminfatch;
        [XmlElement(ElementName = "VLMINFATCH", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlminfatch
        {
            get { return  vlminfatch; }
            set {  vlminfatch = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRegiao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREGIAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRegiao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRegiao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRegiao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRegiao>(where);
        }

        #endregion
    }
}
