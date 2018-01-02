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
    /// Classe referente a tabela PCTransfloja
    /// </summary>
    [XmlType("PCTRANSFLOJA")]
    public class PCTransfloja : OracleTable
    {
        #region Atributos

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
        /// Propriedade referente ao campo: CODFUNCCONF
        /// Comentário: 
        /// </summary>
        private decimal codfuncconf;
        [XmlElement(ElementName = "CODFUNCCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncconf
        {
            get { return  codfuncconf; }
            set {  codfuncconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCTRANSF
        /// Comentário: 
        /// </summary>
        private decimal codfunctransf;
        [XmlElement(ElementName = "CODFUNCTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunctransf
        {
            get { return  codfunctransf; }
            set {  codfunctransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPER
        /// Comentário: 
        /// </summary>
        private string codoper;
        [XmlElement(ElementName = "CODOPER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codoper
        {
            get { return  codoper; }
            set {  codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
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
        /// Propriedade referente ao campo: HORAFECHA
        /// Comentário: 
        /// </summary>
        private string horafecha;
        [XmlElement(ElementName = "HORAFECHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Horafecha
        {
            get { return  horafecha; }
            set {  horafecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFECHA
        /// Comentário: 
        /// </summary>
        private string minutofecha;
        [XmlElement(ElementName = "MINUTOFECHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Minutofecha
        {
            get { return  minutofecha; }
            set {  minutofecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSFLOJA
        /// Comentário: 
        /// </summary>
        private decimal numtransfloja;
        [XmlElement(ElementName = "NUMTRANSFLOJA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransfloja
        {
            get { return  numtransfloja; }
            set {  numtransfloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASMAPASEP
        /// Comentário: 
        /// </summary>
        private decimal numviasmapasep;
        [XmlElement(ElementName = "NUMVIASMAPASEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numviasmapasep
        {
            get { return  numviasmapasep; }
            set {  numviasmapasep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PUNIT
        /// Comentário: 
        /// </summary>
        private decimal punit;
        [XmlElement(ElementName = "PUNIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Punit
        {
            get { return  punit; }
            set {  punit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSEPARADA
        /// Comentário: 
        /// </summary>
        private decimal qtseparada;
        [XmlElement(ElementName = "QTSEPARADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtseparada
        {
            get { return  qtseparada; }
            set {  qtseparada = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTransfloja()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRANSFLOJA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTransfloja> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTransfloja>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTransfloja> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTransfloja>(where);
        }

        #endregion
    }
}
