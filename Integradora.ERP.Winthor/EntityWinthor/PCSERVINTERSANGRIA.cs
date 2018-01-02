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
    /// Classe referente a tabela PCServintersangria
    /// </summary>
    [XmlType("PCSERVINTERSANGRIA")]
    public class PCServintersangria : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: 
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

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
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
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
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCMOVCR
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcmovcr;
        [XmlElement(ElementName = "ITENS_EXP_PCMOVCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcmovcr
        {
            get { return  itens_exp_pcmovcr; }
            set {  itens_exp_pcmovcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_EXP_PCVALECX
        /// Comentário: 
        /// </summary>
        private decimal itens_exp_pcvalecx;
        [XmlElement(ElementName = "ITENS_EXP_PCVALECX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Exp_Pcvalecx
        {
            get { return  itens_exp_pcvalecx; }
            set {  itens_exp_pcvalecx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCMOVCR
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcmovcr;
        [XmlElement(ElementName = "ITENS_IMP_PCMOVCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcmovcr
        {
            get { return  itens_imp_pcmovcr; }
            set {  itens_imp_pcmovcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENS_IMP_PCVALECX
        /// Comentário: 
        /// </summary>
        private decimal itens_imp_pcvalecx;
        [XmlElement(ElementName = "ITENS_IMP_PCVALECX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Itens_Imp_Pcvalecx
        {
            get { return  itens_imp_pcvalecx; }
            set {  itens_imp_pcvalecx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMTRANSECF
        /// Comentário: 
        /// </summary>
        private decimal numtransecf;
        [XmlElement(ElementName = "NUMTRANSECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransecf
        {
            get { return  numtransecf; }
            set {  numtransecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSWINTHOR
        /// Comentário: 
        /// </summary>
        private decimal numtranswinthor;
        [XmlElement(ElementName = "NUMTRANSWINTHOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranswinthor
        {
            get { return  numtranswinthor; }
            set {  numtranswinthor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVALEECF
        /// Comentário: 
        /// </summary>
        private decimal numvaleecf;
        [XmlElement(ElementName = "NUMVALEECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numvaleecf
        {
            get { return  numvaleecf; }
            set {  numvaleecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVALEINTER
        /// Comentário: 
        /// </summary>
        private decimal numvaleinter;
        [XmlElement(ElementName = "NUMVALEINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numvaleinter
        {
            get { return  numvaleinter; }
            set {  numvaleinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVALEWINTHOR
        /// Comentário: 
        /// </summary>
        private decimal numvalewinthor;
        [XmlElement(ElementName = "NUMVALEWINTHOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numvalewinthor
        {
            get { return  numvalewinthor; }
            set {  numvalewinthor = value; }
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
        public PCServintersangria()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVINTERSANGRIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCServintersangria> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServintersangria>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCServintersangria> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServintersangria>(where);
        }

        #endregion
    }
}
