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
    /// Classe referente a tabela PCInvent
    /// </summary>
    [XmlType("PCINVENT")]
    public class PCInvent : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APTO
        /// Coment�rio: 
        /// </summary>
        private decimal apto;
        [XmlElement(ElementName = "APTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Apto
        {
            get { return  apto; }
            set {  apto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AREA
        /// Coment�rio: 
        /// </summary>
        private string area;
        [XmlElement(ElementName = "AREA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Area
        {
            get { return  area; }
            set {  area = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCCONTADOR
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTVENC1
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvenc1;
        [XmlElement(ElementName = "DTVENC1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc1
        {
            get { return  dtvenc1; }
            set {  dtvenc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC2
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvenc2;
        [XmlElement(ElementName = "DTVENC2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc2
        {
            get { return  dtvenc2; }
            set {  dtvenc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC3
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvenc3;
        [XmlElement(ElementName = "DTVENC3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc3
        {
            get { return  dtvenc3; }
            set {  dtvenc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GONDOLA
        /// Coment�rio: 
        /// </summary>
        private decimal gondola;
        [XmlElement(ElementName = "GONDOLA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Gondola
        {
            get { return  gondola; }
            set {  gondola = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULO
        /// Coment�rio: 
        /// </summary>
        private decimal modulo;
        [XmlElement(ElementName = "MODULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Modulo
        {
            get { return  modulo; }
            set {  modulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Coment�rio: 
        /// </summary>
        private decimal numero;
        [XmlElement(ElementName = "NUMERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numero
        {
            get { return  numero; }
            set {  numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTAB
        /// Coment�rio: 
        /// </summary>
        private decimal numtab;
        [XmlElement(ElementName = "NUMTAB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Numtab
        {
            get { return  numtab; }
            set {  numtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1
        /// Coment�rio: 
        /// </summary>
        private decimal qt1;
        [XmlElement(ElementName = "QT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt1
        {
            get { return  qt1; }
            set {  qt1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1CT
        /// Coment�rio: 
        /// </summary>
        private decimal qt1ct;
        [XmlElement(ElementName = "QT1CT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt1ct
        {
            get { return  qt1ct; }
            set {  qt1ct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1CX
        /// Coment�rio: 
        /// </summary>
        private decimal qt1cx;
        [XmlElement(ElementName = "QT1CX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt1cx
        {
            get { return  qt1cx; }
            set {  qt1cx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT1UN
        /// Coment�rio: 
        /// </summary>
        private decimal qt1un;
        [XmlElement(ElementName = "QT1UN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt1un
        {
            get { return  qt1un; }
            set {  qt1un = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2
        /// Coment�rio: 
        /// </summary>
        private decimal qt2;
        [XmlElement(ElementName = "QT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt2
        {
            get { return  qt2; }
            set {  qt2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2CT
        /// Coment�rio: 
        /// </summary>
        private decimal qt2ct;
        [XmlElement(ElementName = "QT2CT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt2ct
        {
            get { return  qt2ct; }
            set {  qt2ct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2CX
        /// Coment�rio: 
        /// </summary>
        private decimal qt2cx;
        [XmlElement(ElementName = "QT2CX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt2cx
        {
            get { return  qt2cx; }
            set {  qt2cx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT2UN
        /// Coment�rio: 
        /// </summary>
        private decimal qt2un;
        [XmlElement(ElementName = "QT2UN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt2un
        {
            get { return  qt2un; }
            set {  qt2un = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3
        /// Coment�rio: 
        /// </summary>
        private decimal qt3;
        [XmlElement(ElementName = "QT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt3
        {
            get { return  qt3; }
            set {  qt3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3CT
        /// Coment�rio: 
        /// </summary>
        private decimal qt3ct;
        [XmlElement(ElementName = "QT3CT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt3ct
        {
            get { return  qt3ct; }
            set {  qt3ct = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3CX
        /// Coment�rio: 
        /// </summary>
        private decimal qt3cx;
        [XmlElement(ElementName = "QT3CX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt3cx
        {
            get { return  qt3cx; }
            set {  qt3cx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT3UN
        /// Coment�rio: 
        /// </summary>
        private decimal qt3un;
        [XmlElement(ElementName = "QT3UN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qt3un
        {
            get { return  qt3un; }
            set {  qt3un = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Coment�rio: 
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCInvent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINVENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCInvent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInvent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCInvent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInvent>(where);
        }

        #endregion
    }
}
