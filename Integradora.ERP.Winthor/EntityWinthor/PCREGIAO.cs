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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Campo para informar observações importantes sobre a Região. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Valor de Frete Kg por Região, que será gravado na Tabela de Preço (PCTABPR.VLACRESFRETEKG). 
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
        /// Comentário: Valor de Venda Kg por Região. 
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
        /// Comentário: 
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
        /// Comentário: 
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRegiao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRegiao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
