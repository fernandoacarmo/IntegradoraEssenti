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
    /// Classe referente a tabela PCInventrotativo
    /// </summary>
    [XmlType("PCINVENTROTATIVO")]
    public class PCInventrotativo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APTO
        /// Comentário: 
        /// </summary>
        private decimal apto;
        [XmlElement(ElementName = "APTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Apto
        {
            get { return  apto; }
            set {  apto = value; }
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
        /// Propriedade referente ao campo: CODFUNCCONTADOR
        /// Comentário: 
        /// </summary>
        private decimal codfunccontador;
        [XmlElement(ElementName = "CODFUNCCONTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccontador
        {
            get { return  codfunccontador; }
            set {  codfunccontador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDIGITADOR
        /// Comentário: 
        /// </summary>
        private decimal codfuncdigitador;
        [XmlElement(ElementName = "CODFUNCDIGITADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncdigitador
        {
            get { return  codfuncdigitador; }
            set {  codfuncdigitador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODPROD1
        /// Comentário: 
        /// </summary>
        private decimal codprod1;
        [XmlElement(ElementName = "CODPROD1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod1
        {
            get { return  codprod1; }
            set {  codprod1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD2
        /// Comentário: 
        /// </summary>
        private decimal codprod2;
        [XmlElement(ElementName = "CODPROD2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod2
        {
            get { return  codprod2; }
            set {  codprod2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD3
        /// Comentário: 
        /// </summary>
        private decimal codprod3;
        [XmlElement(ElementName = "CODPROD3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod3
        {
            get { return  codprod3; }
            set {  codprod3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPOSITO
        /// Comentário: 
        /// </summary>
        private decimal deposito;
        [XmlElement(ElementName = "DEPOSITO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Deposito
        {
            get { return  deposito; }
            set {  deposito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL1
        /// Comentário: 
        /// </summary>
        private DateTime? dtval1;
        [XmlElement(ElementName = "DTVAL1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval1
        {
            get { return  dtval1; }
            set {  dtval1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL2
        /// Comentário: 
        /// </summary>
        private DateTime? dtval2;
        [XmlElement(ElementName = "DTVAL2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval2
        {
            get { return  dtval2; }
            set {  dtval2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL3
        /// Comentário: 
        /// </summary>
        private DateTime? dtval3;
        [XmlElement(ElementName = "DTVAL3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval3
        {
            get { return  dtval3; }
            set {  dtval3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NIVEL
        /// Comentário: 
        /// </summary>
        private decimal nivel;
        [XmlElement(ElementName = "NIVEL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Nivel
        {
            get { return  nivel; }
            set {  nivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVENT
        /// Comentário: 
        /// </summary>
        private decimal numinvent;
        [XmlElement(ElementName = "NUMINVENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numinvent
        {
            get { return  numinvent; }
            set {  numinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREDIO
        /// Comentário: 
        /// </summary>
        private decimal predio;
        [XmlElement(ElementName = "PREDIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Predio
        {
            get { return  predio; }
            set {  predio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1
        /// Comentário: 
        /// </summary>
        private decimal qt1;
        [XmlElement(ElementName = "QT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt1
        {
            get { return  qt1; }
            set {  qt1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2
        /// Comentário: 
        /// </summary>
        private decimal qt2;
        [XmlElement(ElementName = "QT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt2
        {
            get { return  qt2; }
            set {  qt2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3
        /// Comentário: 
        /// </summary>
        private decimal qt3;
        [XmlElement(ElementName = "QT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt3
        {
            get { return  qt3; }
            set {  qt3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Comentário: 
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInventrotativo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINVENTROTATIVO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInventrotativo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInventrotativo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInventrotativo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInventrotativo>(where);
        }

        #endregion
    }
}
