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
    /// Classe referente a tabela PCAtflogclient
    /// </summary>
    [XmlType("PCATFLOGCLIENT")]
    public class PCAtflogclient : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATFCODCLINF_ANTES
        /// Comentário: 
        /// </summary>
        private decimal atfcodclinf_antes;
        [XmlElement(ElementName = "ATFCODCLINF_ANTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Atfcodclinf_Antes
        {
            get { return  atfcodclinf_antes; }
            set {  atfcodclinf_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATFCODCLINF_DEPOIS
        /// Comentário: 
        /// </summary>
        private decimal atfcodclinf_depois;
        [XmlElement(ElementName = "ATFCODCLINF_DEPOIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Atfcodclinf_Depois
        {
            get { return  atfcodclinf_depois; }
            set {  atfcodclinf_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATFPERCACRESCTV4_ANTES
        /// Comentário: 
        /// </summary>
        private decimal atfpercacresctv4_antes;
        [XmlElement(ElementName = "ATFPERCACRESCTV4_ANTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Atfpercacresctv4_Antes
        {
            get { return  atfpercacresctv4_antes; }
            set {  atfpercacresctv4_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATFPERCACRESCTV4_DEPOIS
        /// Comentário: 
        /// </summary>
        private decimal atfpercacresctv4_depois;
        [XmlElement(ElementName = "ATFPERCACRESCTV4_DEPOIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Atfpercacresctv4_Depois
        {
            get { return  atfpercacresctv4_depois; }
            set {  atfpercacresctv4_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATFPIS_ANTES
        /// Comentário: 
        /// </summary>
        private string atfpis_antes;
        [XmlElement(ElementName = "ATFPIS_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atfpis_Antes
        {
            get { return  atfpis_antes; }
            set {  atfpis_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATFPIS_DEPOIS
        /// Comentário: 
        /// </summary>
        private string atfpis_depois;
        [XmlElement(ElementName = "ATFPIS_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atfpis_Depois
        {
            get { return  atfpis_depois; }
            set {  atfpis_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALT
        /// Comentário: 
        /// </summary>
        private decimal codfuncalt;
        [XmlElement(ElementName = "CODFUNCALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncalt
        {
            get { return  codfuncalt; }
            set {  codfuncalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA1_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda1_antes;
        [XmlElement(ElementName = "CONDVENDA1_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda1_Antes
        {
            get { return  condvenda1_antes; }
            set {  condvenda1_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA1_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda1_depois;
        [XmlElement(ElementName = "CONDVENDA1_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda1_Depois
        {
            get { return  condvenda1_depois; }
            set {  condvenda1_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA10_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda10_antes;
        [XmlElement(ElementName = "CONDVENDA10_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda10_Antes
        {
            get { return  condvenda10_antes; }
            set {  condvenda10_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA10_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda10_depois;
        [XmlElement(ElementName = "CONDVENDA10_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda10_Depois
        {
            get { return  condvenda10_depois; }
            set {  condvenda10_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA11_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda11_antes;
        [XmlElement(ElementName = "CONDVENDA11_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda11_Antes
        {
            get { return  condvenda11_antes; }
            set {  condvenda11_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA11_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda11_depois;
        [XmlElement(ElementName = "CONDVENDA11_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda11_Depois
        {
            get { return  condvenda11_depois; }
            set {  condvenda11_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA12_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda12_antes;
        [XmlElement(ElementName = "CONDVENDA12_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda12_Antes
        {
            get { return  condvenda12_antes; }
            set {  condvenda12_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA12_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda12_depois;
        [XmlElement(ElementName = "CONDVENDA12_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda12_Depois
        {
            get { return  condvenda12_depois; }
            set {  condvenda12_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA13_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda13_antes;
        [XmlElement(ElementName = "CONDVENDA13_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda13_Antes
        {
            get { return  condvenda13_antes; }
            set {  condvenda13_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA13_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda13_depois;
        [XmlElement(ElementName = "CONDVENDA13_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda13_Depois
        {
            get { return  condvenda13_depois; }
            set {  condvenda13_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA14_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda14_antes;
        [XmlElement(ElementName = "CONDVENDA14_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda14_Antes
        {
            get { return  condvenda14_antes; }
            set {  condvenda14_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA14_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda14_depois;
        [XmlElement(ElementName = "CONDVENDA14_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda14_Depois
        {
            get { return  condvenda14_depois; }
            set {  condvenda14_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA2_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda2_antes;
        [XmlElement(ElementName = "CONDVENDA2_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda2_Antes
        {
            get { return  condvenda2_antes; }
            set {  condvenda2_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA2_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda2_depois;
        [XmlElement(ElementName = "CONDVENDA2_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda2_Depois
        {
            get { return  condvenda2_depois; }
            set {  condvenda2_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA20_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda20_antes;
        [XmlElement(ElementName = "CONDVENDA20_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda20_Antes
        {
            get { return  condvenda20_antes; }
            set {  condvenda20_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA20_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda20_depois;
        [XmlElement(ElementName = "CONDVENDA20_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda20_Depois
        {
            get { return  condvenda20_depois; }
            set {  condvenda20_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA3_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda3_antes;
        [XmlElement(ElementName = "CONDVENDA3_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda3_Antes
        {
            get { return  condvenda3_antes; }
            set {  condvenda3_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA3_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda3_depois;
        [XmlElement(ElementName = "CONDVENDA3_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda3_Depois
        {
            get { return  condvenda3_depois; }
            set {  condvenda3_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA4_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda4_antes;
        [XmlElement(ElementName = "CONDVENDA4_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda4_Antes
        {
            get { return  condvenda4_antes; }
            set {  condvenda4_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA4_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda4_depois;
        [XmlElement(ElementName = "CONDVENDA4_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda4_Depois
        {
            get { return  condvenda4_depois; }
            set {  condvenda4_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA5_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda5_antes;
        [XmlElement(ElementName = "CONDVENDA5_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda5_Antes
        {
            get { return  condvenda5_antes; }
            set {  condvenda5_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA5_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda5_depois;
        [XmlElement(ElementName = "CONDVENDA5_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda5_Depois
        {
            get { return  condvenda5_depois; }
            set {  condvenda5_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA6_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda6_antes;
        [XmlElement(ElementName = "CONDVENDA6_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda6_Antes
        {
            get { return  condvenda6_antes; }
            set {  condvenda6_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA6_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda6_depois;
        [XmlElement(ElementName = "CONDVENDA6_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda6_Depois
        {
            get { return  condvenda6_depois; }
            set {  condvenda6_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA7_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda7_antes;
        [XmlElement(ElementName = "CONDVENDA7_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda7_Antes
        {
            get { return  condvenda7_antes; }
            set {  condvenda7_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA7_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda7_depois;
        [XmlElement(ElementName = "CONDVENDA7_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda7_Depois
        {
            get { return  condvenda7_depois; }
            set {  condvenda7_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA8_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda8_antes;
        [XmlElement(ElementName = "CONDVENDA8_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda8_Antes
        {
            get { return  condvenda8_antes; }
            set {  condvenda8_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA8_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda8_depois;
        [XmlElement(ElementName = "CONDVENDA8_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda8_Depois
        {
            get { return  condvenda8_depois; }
            set {  condvenda8_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA9_ANTES
        /// Comentário: 
        /// </summary>
        private string condvenda9_antes;
        [XmlElement(ElementName = "CONDVENDA9_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda9_Antes
        {
            get { return  condvenda9_antes; }
            set {  condvenda9_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONDVENDA9_DEPOIS
        /// Comentário: 
        /// </summary>
        private string condvenda9_depois;
        [XmlElement(ElementName = "CONDVENDA9_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condvenda9_Depois
        {
            get { return  condvenda9_depois; }
            set {  condvenda9_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC_ANTES
        /// Comentário: 
        /// </summary>
        private decimal perdesc_antes;
        [XmlElement(ElementName = "PERDESC_ANTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdesc_Antes
        {
            get { return  perdesc_antes; }
            set {  perdesc_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC_DEPOIS
        /// Comentário: 
        /// </summary>
        private decimal perdesc_depois;
        [XmlElement(ElementName = "PERDESC_DEPOIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdesc_Depois
        {
            get { return  perdesc_depois; }
            set {  perdesc_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFIN_ANTES
        /// Comentário: 
        /// </summary>
        private decimal perdescfin_antes;
        [XmlElement(ElementName = "PERDESCFIN_ANTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perdescfin_Antes
        {
            get { return  perdescfin_antes; }
            set {  perdescfin_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFIN_DEPOIS
        /// Comentário: 
        /// </summary>
        private decimal perdescfin_depois;
        [XmlElement(ElementName = "PERDESCFIN_DEPOIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perdescfin_Depois
        {
            get { return  perdescfin_depois; }
            set {  perdescfin_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLPAGNEG_ANTES
        /// Comentário: 
        /// </summary>
        private string plpagneg_antes;
        [XmlElement(ElementName = "PLPAGNEG_ANTES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Plpagneg_Antes
        {
            get { return  plpagneg_antes; }
            set {  plpagneg_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLPAGNEG_DEPOIS
        /// Comentário: 
        /// </summary>
        private string plpagneg_depois;
        [XmlElement(ElementName = "PLPAGNEG_DEPOIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Plpagneg_Depois
        {
            get { return  plpagneg_depois; }
            set {  plpagneg_depois = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL_ANTES
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional_antes;
        [XmlElement(ElementName = "PRAZOADICIONAL_ANTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional_Antes
        {
            get { return  prazoadicional_antes; }
            set {  prazoadicional_antes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOADICIONAL_DEPOIS
        /// Comentário: 
        /// </summary>
        private decimal prazoadicional_depois;
        [XmlElement(ElementName = "PRAZOADICIONAL_DEPOIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoadicional_Depois
        {
            get { return  prazoadicional_depois; }
            set {  prazoadicional_depois = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAtflogclient()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCATFLOGCLIENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAtflogclient> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAtflogclient>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAtflogclient> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAtflogclient>(where);
        }

        #endregion
    }
}
