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
    /// Classe referente a tabela PCEstcom
    /// </summary>
    [XmlType("PCESTCOM")]
    public class PCEstcom : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR2
        /// Coment�rio: Indica o c�digo do primeiro profissional.
        /// </summary>
        private decimal codusur2;
        [XmlElement(ElementName = "CODUSUR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusur2
        {
            get { return  codusur2; }
            set {  codusur2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR3
        /// Coment�rio: Indica o c�digo do segundo profissional.
        /// </summary>
        private decimal codusur3;
        [XmlElement(ElementName = "CODUSUR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusur3
        {
            get { return  codusur3; }
            set {  codusur3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR4
        /// Coment�rio: Indica o c�digo do terceiro profissional.
        /// </summary>
        private decimal codusur4;
        [XmlElement(ElementName = "CODUSUR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codusur4
        {
            get { return  codusur4; }
            set {  codusur4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtestorno;
        [XmlElement(ElementName = "DTESTORNO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtestorno
        {
            get { return  dtestorno; }
            set {  dtestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Coment�rio: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBDTACERTOCOMMOT
        /// Coment�rio: 
        /// </summary>
        private DateTime? hobdtacertocommot;
        [XmlElement(ElementName = "HOBDTACERTOCOMMOT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hobdtacertocommot
        {
            get { return  hobdtacertocommot; }
            set {  hobdtacertocommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBDTACERTOCOMRCA
        /// Coment�rio: 
        /// </summary>
        private DateTime? hobdtacertocomrca;
        [XmlElement(ElementName = "HOBDTACERTOCOMRCA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hobdtacertocomrca
        {
            get { return  hobdtacertocomrca; }
            set {  hobdtacertocomrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBDTACERTOCOMSUP
        /// Coment�rio: 
        /// </summary>
        private DateTime? hobdtacertocomsup;
        [XmlElement(ElementName = "HOBDTACERTOCOMSUP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hobdtacertocomsup
        {
            get { return  hobdtacertocomsup; }
            set {  hobdtacertocomsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBVLESTORNOMOT
        /// Coment�rio: 
        /// </summary>
        private decimal hobvlestornomot;
        [XmlElement(ElementName = "HOBVLESTORNOMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Hobvlestornomot
        {
            get { return  hobvlestornomot; }
            set {  hobvlestornomot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBVLESTORNOSUPERV
        /// Coment�rio: 
        /// </summary>
        private decimal hobvlestornosuperv;
        [XmlElement(ElementName = "HOBVLESTORNOSUPERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Hobvlestornosuperv
        {
            get { return  hobvlestornosuperv; }
            set {  hobvlestornosuperv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVOLUCAO
        /// Coment�rio: 
        /// </summary>
        private decimal vldevolucao;
        [XmlElement(ElementName = "VLDEVOLUCAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Vldevolucao
        {
            get { return  vldevolucao; }
            set {  vldevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTORNO
        /// Coment�rio: 
        /// </summary>
        private decimal vlestorno;
        [XmlElement(ElementName = "VLESTORNO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Vlestorno
        {
            get { return  vlestorno; }
            set {  vlestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTORNOCMV
        /// Coment�rio: Indica o valor estorno CMV.
        /// </summary>
        private decimal vlestornocmv;
        [XmlElement(ElementName = "VLESTORNOCMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlestornocmv
        {
            get { return  vlestornocmv; }
            set {  vlestornocmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTORNO2
        /// Coment�rio: Data de pagamento comis�o do primeiro profissional.
        /// </summary>
        private decimal vlestorno2;
        [XmlElement(ElementName = "VLESTORNO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestorno2
        {
            get { return  vlestorno2; }
            set {  vlestorno2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTORNO3
        /// Coment�rio: Data de pagamento comis�o do segundo profissional.
        /// </summary>
        private decimal vlestorno3;
        [XmlElement(ElementName = "VLESTORNO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestorno3
        {
            get { return  vlestorno3; }
            set {  vlestorno3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTORNO4
        /// Coment�rio: Data de pagamento comis�o do segundo profissional.
        /// </summary>
        private decimal vlestorno4;
        [XmlElement(ElementName = "VLESTORNO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlestorno4
        {
            get { return  vlestorno4; }
            set {  vlestorno4 = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEstcom()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTCOM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEstcom> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstcom>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEstcom> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstcom>(where);
        }

        #endregion
    }
}
