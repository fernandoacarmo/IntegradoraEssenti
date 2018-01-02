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
    /// Classe referente a tabela PCServintervendas
    /// </summary>
    [XmlType("PCSERVINTERVENDAS")]
    public class PCServintervendas : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCX
        /// Comentário: 
        /// </summary>
        private decimal codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtimportacao;
        [XmlElement(ElementName = "DTIMPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacao
        {
            get { return  dtimportacao; }
            set {  dtimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCAUTORI
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcautori;
        [XmlElement(ElementName = "ITENS_EXP_PCAUTORI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcautori
        {
            get { return  itens_exp_pcautori; }
            set {  itens_exp_pcautori = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCMOV
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcmov;
        [XmlElement(ElementName = "ITENS_EXP_PCMOV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcmov
        {
            get { return  itens_exp_pcmov; }
            set {  itens_exp_pcmov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCNFBASE
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcnfbase;
        [XmlElement(ElementName = "ITENS_EXP_PCNFBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcnfbase
        {
            get { return  itens_exp_pcnfbase; }
            set {  itens_exp_pcnfbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCNFSAID
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcnfsaid;
        [XmlElement(ElementName = "ITENS_EXP_PCNFSAID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcnfsaid
        {
            get { return  itens_exp_pcnfsaid; }
            set {  itens_exp_pcnfsaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCPEDC
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcpedc;
        [XmlElement(ElementName = "ITENS_EXP_PCPEDC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcpedc
        {
            get { return  itens_exp_pcpedc; }
            set {  itens_exp_pcpedc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCPEDI
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcpedi;
        [XmlElement(ElementName = "ITENS_EXP_PCPEDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcpedi
        {
            get { return  itens_exp_pcpedi; }
            set {  itens_exp_pcpedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCPREST
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcprest;
        [XmlElement(ElementName = "ITENS_EXP_PCPREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcprest
        {
            get { return  itens_exp_pcprest; }
            set {  itens_exp_pcprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCVENDACONSUM
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcvendaconsum;
        [XmlElement(ElementName = "ITENS_EXP_PCVENDACONSUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcvendaconsum
        {
            get { return  itens_exp_pcvendaconsum; }
            set {  itens_exp_pcvendaconsum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCAUTORI
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcautori;
        [XmlElement(ElementName = "ITENS_IMP_PCAUTORI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcautori
        {
            get { return  itens_imp_pcautori; }
            set {  itens_imp_pcautori = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCMOV
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcmov;
        [XmlElement(ElementName = "ITENS_IMP_PCMOV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcmov
        {
            get { return  itens_imp_pcmov; }
            set {  itens_imp_pcmov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCNFBASE
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcnfbase;
        [XmlElement(ElementName = "ITENS_IMP_PCNFBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcnfbase
        {
            get { return  itens_imp_pcnfbase; }
            set {  itens_imp_pcnfbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCNFSAID
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcnfsaid;
        [XmlElement(ElementName = "ITENS_IMP_PCNFSAID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcnfsaid
        {
            get { return  itens_imp_pcnfsaid; }
            set {  itens_imp_pcnfsaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCPEDC
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcpedc;
        [XmlElement(ElementName = "ITENS_IMP_PCPEDC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcpedc
        {
            get { return  itens_imp_pcpedc; }
            set {  itens_imp_pcpedc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCPEDI
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcpedi;
        [XmlElement(ElementName = "ITENS_IMP_PCPEDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcpedi
        {
            get { return  itens_imp_pcpedi; }
            set {  itens_imp_pcpedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCPREST
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcprest;
        [XmlElement(ElementName = "ITENS_IMP_PCPREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcprest
        {
            get { return  itens_imp_pcprest; }
            set {  itens_imp_pcprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCVENDACONSUM
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcvendaconsum;
        [XmlElement(ElementName = "ITENS_IMP_PCVENDACONSUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcvendaconsum
        {
            get { return  itens_imp_pcvendaconsum; }
            set {  itens_imp_pcvendaconsum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: 
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMPEDECF
        /// Comentário: 
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Comentário: 
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAECF
        /// Comentário: 
        /// </summary>
        private decimal numtransvendaecf;
        [XmlElement(ElementName = "NUMTRANSVENDAECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransvendaecf
        {
            get { return  numtransvendaecf; }
            set {  numtransvendaecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAWINTHOR
        /// Comentário: 
        /// </summary>
        private decimal numtransvendawinthor;
        [XmlElement(ElementName = "NUMTRANSVENDAWINTHOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendawinthor
        {
            get { return  numtransvendawinthor; }
            set {  numtransvendawinthor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEECF
        /// Comentário: 
        /// </summary>
        private string serieecf;
        [XmlElement(ElementName = "SERIEECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Serieecf
        {
            get { return  serieecf; }
            set {  serieecf = value; }
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

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCServintervendas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVINTERVENDAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCServintervendas> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServintervendas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCServintervendas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServintervendas>(where);
        }

        #endregion
    }
}
