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
    /// Classe referente a tabela PCServintercancel
    /// </summary>
    [XmlType("PCSERVINTERCANCEL")]
    public class PCServintercancel : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ITENS_EXP_PCMOV
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ITENS_EXP_PCNFCAN
        /// Coment�rio: 
        /// </summary>
        private decimal itens_exp_pcnfcan;
        [XmlElement(ElementName = "ITENS_EXP_PCNFCAN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcnfcan
        {
            get { return  itens_exp_pcnfcan; }
            set {  itens_exp_pcnfcan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCNFCANITEM
        /// Coment�rio: 
        /// </summary>
        private decimal itens_exp_pcnfcanitem;
        [XmlElement(ElementName = "ITENS_EXP_PCNFCANITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcnfcanitem
        {
            get { return  itens_exp_pcnfcanitem; }
            set {  itens_exp_pcnfcanitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCNFSAID
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ITENS_EXP_PCPEDCCANCECF
        /// Coment�rio: 
        /// </summary>
        private decimal itens_exp_pcpedccancecf;
        [XmlElement(ElementName = "ITENS_EXP_PCPEDCCANCECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcpedccancecf
        {
            get { return  itens_exp_pcpedccancecf; }
            set {  itens_exp_pcpedccancecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCPEDI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ITENS_EXP_PCPEDICANCECF
        /// Coment�rio: 
        /// </summary>
        private decimal itens_exp_pcpedicancecf;
        [XmlElement(ElementName = "ITENS_EXP_PCPEDICANCECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcpedicancecf
        {
            get { return  itens_exp_pcpedicancecf; }
            set {  itens_exp_pcpedicancecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCMOV
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ITENS_IMP_PCNFCAN
        /// Coment�rio: 
        /// </summary>
        private decimal itens_imp_pcnfcan;
        [XmlElement(ElementName = "ITENS_IMP_PCNFCAN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcnfcan
        {
            get { return  itens_imp_pcnfcan; }
            set {  itens_imp_pcnfcan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCNFCANITEM
        /// Coment�rio: 
        /// </summary>
        private decimal itens_imp_pcnfcanitem;
        [XmlElement(ElementName = "ITENS_IMP_PCNFCANITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcnfcanitem
        {
            get { return  itens_imp_pcnfcanitem; }
            set {  itens_imp_pcnfcanitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCNFSAID
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ITENS_IMP_PCPEDCCANCECF
        /// Coment�rio: 
        /// </summary>
        private decimal itens_imp_pcpedccancecf;
        [XmlElement(ElementName = "ITENS_IMP_PCPEDCCANCECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcpedccancecf
        {
            get { return  itens_imp_pcpedccancecf; }
            set {  itens_imp_pcpedccancecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCPEDI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ITENS_IMP_PCPEDICANCECF
        /// Coment�rio: 
        /// </summary>
        private decimal itens_imp_pcpedicancecf;
        [XmlElement(ElementName = "ITENS_IMP_PCPEDICANCECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcpedicancecf
        {
            get { return  itens_imp_pcpedicancecf; }
            set {  itens_imp_pcpedicancecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: 
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Coment�rio: 
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAECF
        /// Coment�rio: 
        /// </summary>
        private decimal numtransvendaecf;
        [XmlElement(ElementName = "NUMTRANSVENDAECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaecf
        {
            get { return  numtransvendaecf; }
            set {  numtransvendaecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAWINTHOR
        /// Coment�rio: 
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
        /// Coment�rio: 
        /// </summary>
        private string serieecf;
        [XmlElement(ElementName = "SERIEECF", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Serieecf
        {
            get { return  serieecf; }
            set {  serieecf = value; }
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
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCServintercancel()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVINTERCANCEL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCServintercancel> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServintercancel>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCServintercancel> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServintercancel>(where);
        }

        #endregion
    }
}
