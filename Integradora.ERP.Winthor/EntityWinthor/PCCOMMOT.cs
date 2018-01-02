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
    /// Classe referente a tabela PCCommot
    /// </summary>
    [XmlType("PCCOMMOT")]
    public class PCCommot : OracleTable
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
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Comentário: 
        /// </summary>
        private decimal codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCMOT
        /// Comentário: 
        /// </summary>
        private decimal codfuncmot;
        [XmlElement(ElementName = "CODFUNCMOT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codfuncmot
        {
            get { return  codfuncmot; }
            set {  codfuncmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFIM
        /// Comentário: 
        /// </summary>
        private DateTime? datafim;
        [XmlElement(ElementName = "DATAFIM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datafim
        {
            get { return  datafim; }
            set {  datafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? datainicio;
        [XmlElement(ElementName = "DATAINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datainicio
        {
            get { return  datainicio; }
            set {  datainicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHA
        /// Comentário: 
        /// </summary>
        private DateTime? dtfecha;
        [XmlElement(ElementName = "DTFECHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecha
        {
            get { return  dtfecha; }
            set {  dtfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Comentário: 
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMPAG
        /// Comentário: 
        /// </summary>
        private decimal percompag;
        [XmlElement(ElementName = "PERCOMPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percompag
        {
            get { return  percompag; }
            set {  percompag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPAGCOM
        /// Comentário: 
        /// </summary>
        private decimal perpagcom;
        [XmlElement(ElementName = "PERPAGCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perpagcom
        {
            get { return  perpagcom; }
            set {  perpagcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNF
        /// Comentário: 
        /// </summary>
        private decimal qtnf;
        [XmlElement(ElementName = "QTNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtnf
        {
            get { return  qtnf; }
            set {  qtnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMISSAO
        /// Comentário: 
        /// </summary>
        private decimal vlcomissao;
        [XmlElement(ElementName = "VLCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcomissao
        {
            get { return  vlcomissao; }
            set {  vlcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVOLUCAO
        /// Comentário: 
        /// </summary>
        private decimal vldevolucao;
        [XmlElement(ElementName = "VLDEVOLUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldevolucao
        {
            get { return  vldevolucao; }
            set {  vldevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTORNODEVOL
        /// Comentário: 
        /// </summary>
        private decimal vlestornodevol;
        [XmlElement(ElementName = "VLESTORNODEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlestornodevol
        {
            get { return  vlestornodevol; }
            set {  vlestornodevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVALE
        /// Comentário: 
        /// </summary>
        private decimal vlvale;
        [XmlElement(ElementName = "VLVALE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvale
        {
            get { return  vlvale; }
            set {  vlvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVALOR
        /// Comentário: 
        /// </summary>
        private decimal vlvalor;
        [XmlElement(ElementName = "VLVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvalor
        {
            get { return  vlvalor; }
            set {  vlvalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDA
        /// Comentário: 
        /// </summary>
        private decimal vlvenda;
        [XmlElement(ElementName = "VLVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
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
        public PCCommot()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMMOT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCommot> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCommot>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCommot> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCommot>(where);
        }

        #endregion
    }
}
