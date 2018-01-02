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
    /// Classe referente a tabela PCDtprod
    /// </summary>
    [XmlType("PCDTPROD")]
    public class PCDtprod : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CLASSE
        /// Comentário: 
        /// </summary>
        private string classe;
        [XmlElement(ElementName = "CLASSE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classe
        {
            get { return  classe; }
            set {  classe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINC
        /// Comentário: 
        /// </summary>
        private decimal codprodprinc;
        [XmlElement(ElementName = "CODPRODPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodprinc
        {
            get { return  codprodprinc; }
            set {  codprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOCONT
        /// Comentário: 
        /// </summary>
        private decimal custocont;
        [XmlElement(ElementName = "CUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custocont
        {
            get { return  custocont; }
            set {  custocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREP
        /// Comentário: 
        /// </summary>
        private decimal custorep;
        [XmlElement(ElementName = "CUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custorep
        {
            get { return  custorep; }
            set {  custorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMOV
        /// Comentário: 
        /// </summary>
        private DateTime? dtmov;
        [XmlElement(ElementName = "DTMOV", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtmov
        {
            get { return  dtmov; }
            set {  dtmov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBONIFIC
        /// Comentário: Quantidade bonificada.
        /// </summary>
        private decimal qtbonific;
        [XmlElement(ElementName = "QTBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtbonific
        {
            get { return  qtbonific; }
            set {  qtbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVOLCLI
        /// Comentário: 
        /// </summary>
        private decimal qtdevolcli;
        [XmlElement(ElementName = "QTDEVOLCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtdevolcli
        {
            get { return  qtdevolcli; }
            set {  qtdevolcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENT
        /// Comentário: 
        /// </summary>
        private decimal qtent;
        [XmlElement(ElementName = "QTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtent
        {
            get { return  qtent; }
            set {  qtent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTGER
        /// Comentário: 
        /// </summary>
        private decimal qtestger;
        [XmlElement(ElementName = "QTESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtestger
        {
            get { return  qtestger; }
            set {  qtestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNOTA
        /// Comentário: 
        /// </summary>
        private decimal qtnota;
        [XmlElement(ElementName = "QTNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtnota
        {
            get { return  qtnota; }
            set {  qtnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPERDA
        /// Comentário: 
        /// </summary>
        private decimal qtperda;
        [XmlElement(ElementName = "QTPERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtperda
        {
            get { return  qtperda; }
            set {  qtperda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTVENDA
        /// Comentário: 
        /// </summary>
        private decimal qtvenda;
        [XmlElement(ElementName = "QTVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtvenda
        {
            get { return  qtvenda; }
            set {  qtvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Comentário: Valor do ST
        /// </summary>
        private decimal st;
        [XmlElement(ElementName = "ST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal St
        {
            get { return  st; }
            set {  st = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STDEVOLUCAO
        /// Comentário: Valor do ST de devolução.
        /// </summary>
        private decimal stdevolucao;
        [XmlElement(ElementName = "STDEVOLUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Stdevolucao
        {
            get { return  stdevolucao; }
            set {  stdevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILVLCUSTOFINSEMPERDA
        /// Comentário: 
        /// </summary>
        private decimal vilvlcustofinsemperda;
        [XmlElement(ElementName = "VILVLCUSTOFINSEMPERDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vilvlcustofinsemperda
        {
            get { return  vilvlcustofinsemperda; }
            set {  vilvlcustofinsemperda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VIL_VLDEVOLCUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal vil_vldevolcustofin;
        [XmlElement(ElementName = "VIL_VLDEVOLCUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vil_Vldevolcustofin
        {
            get { return  vil_vldevolcustofin; }
            set {  vil_vldevolcustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: Valor bonificado.
        /// </summary>
        private decimal vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOCONT
        /// Comentário: 
        /// </summary>
        private decimal vlcustocont;
        [XmlElement(ElementName = "VLCUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustocont
        {
            get { return  vlcustocont; }
            set {  vlcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal vlcustofin;
        [XmlElement(ElementName = "VLCUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustofin
        {
            get { return  vlcustofin; }
            set {  vlcustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFINDEVOLCLI
        /// Comentário: Valor total de custos financeiros de devolução de cliente por filial dia e produto
        /// </summary>
        private decimal vlcustofindevolcli;
        [XmlElement(ElementName = "VLCUSTOFINDEVOLCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustofindevolcli
        {
            get { return  vlcustofindevolcli; }
            set {  vlcustofindevolcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal vlcustoreal;
        [XmlElement(ElementName = "VLCUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustoreal
        {
            get { return  vlcustoreal; }
            set {  vlcustoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREP
        /// Comentário: 
        /// </summary>
        private decimal vlcustorep;
        [XmlElement(ElementName = "VLCUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustorep
        {
            get { return  vlcustorep; }
            set {  vlcustorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVOLCLI
        /// Comentário: 
        /// </summary>
        private decimal vldevolcli;
        [XmlElement(ElementName = "VLDEVOLCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldevolcli
        {
            get { return  vldevolcli; }
            set {  vldevolcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENT
        /// Comentário: 
        /// </summary>
        private decimal vlent;
        [XmlElement(ElementName = "VLENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlent
        {
            get { return  vlent; }
            set {  vlent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: Valor do IPI
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPIDEVOLUCAO
        /// Comentário: Valor do IPI de devolução
        /// </summary>
        private decimal vlipidevolucao;
        [XmlElement(ElementName = "VLIPIDEVOLUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipidevolucao
        {
            get { return  vlipidevolucao; }
            set {  vlipidevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREPASSE
        /// Comentário: Valor do repasse
        /// </summary>
        private decimal vlrepasse;
        [XmlElement(ElementName = "VLREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrepasse
        {
            get { return  vlrepasse; }
            set {  vlrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREPASSEDEVOLUCAO
        /// Comentário: Valor do repasse das devoluções
        /// </summary>
        private decimal vlrepassedevolucao;
        [XmlElement(ElementName = "VLREPASSEDEVOLUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrepassedevolucao
        {
            get { return  vlrepassedevolucao; }
            set {  vlrepassedevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDA
        /// Comentário: 
        /// </summary>
        private decimal vlvenda;
        [XmlElement(ElementName = "VLVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlvenda
        {
            get { return  vlvenda; }
            set {  vlvenda = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDtprod()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDTPROD";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDtprod> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDtprod>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDtprod> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDtprod>(where);
        }

        #endregion
    }
}
