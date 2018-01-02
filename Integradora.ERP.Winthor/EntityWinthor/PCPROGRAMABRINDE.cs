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
    /// Classe referente a tabela PCProgramabrinde
    /// </summary>
    [XmlType("PCPROGRAMABRINDE")]
    public class PCProgramabrinde : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBRINDEPREMIO
        /// Coment�rio: 
        /// </summary>
        private decimal codbrindepremio;
        [XmlElement(ElementName = "CODBRINDEPREMIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codbrindepremio
        {
            get { return  codbrindepremio; }
            set {  codbrindepremio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIPREMIO
        /// Coment�rio: 
        /// </summary>
        private decimal codclipremio;
        [XmlElement(ElementName = "CODCLIPREMIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclipremio
        {
            get { return  codclipremio; }
            set {  codclipremio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIPROG
        /// Coment�rio: 
        /// </summary>
        private decimal codcliprog;
        [XmlElement(ElementName = "CODCLIPROG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcliprog
        {
            get { return  codcliprog; }
            set {  codcliprog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALPREMIO
        /// Coment�rio: 
        /// </summary>
        private string codfilialpremio;
        [XmlElement(ElementName = "CODFILIALPREMIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialpremio
        {
            get { return  codfilialpremio; }
            set {  codfilialpremio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALPROG
        /// Coment�rio: 
        /// </summary>
        private string codfilialprog;
        [XmlElement(ElementName = "CODFILIALPROG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialprog
        {
            get { return  codfilialprog; }
            set {  codfilialprog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORALANC
        /// Coment�rio: 
        /// </summary>
        private DateTime? datahoralanc;
        [XmlElement(ElementName = "DATAHORALANC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datahoralanc
        {
            get { return  datahoralanc; }
            set {  datahoralanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORAPREMIO
        /// Coment�rio: 
        /// </summary>
        private DateTime? datahorapremio;
        [XmlElement(ElementName = "DATAHORAPREMIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahorapremio
        {
            get { return  datahorapremio; }
            set {  datahorapremio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORAPROG
        /// Coment�rio: 
        /// </summary>
        private DateTime? datahoraprog;
        [XmlElement(ElementName = "DATAHORAPROG", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datahoraprog
        {
            get { return  datahoraprog; }
            set {  datahoraprog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCBRINDEPREMIO
        /// Coment�rio: 
        /// </summary>
        private string descbrindepremio;
        [XmlElement(ElementName = "DESCBRINDEPREMIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descbrindepremio
        {
            get { return  descbrindepremio; }
            set {  descbrindepremio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultalter;
        [XmlElement(ElementName = "DTULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalter
        {
            get { return  dtultalter; }
            set {  dtultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANC
        /// Coment�rio: 
        /// </summary>
        private decimal numlanc;
        [XmlElement(ElementName = "NUMLANC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numlanc
        {
            get { return  numlanc; }
            set {  numlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAPROG
        /// Coment�rio: 
        /// </summary>
        private decimal qtestrelaprog;
        [XmlElement(ElementName = "QTESTRELAPROG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtestrelaprog
        {
            get { return  qtestrelaprog; }
            set {  qtestrelaprog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSORTEIO
        /// Coment�rio: 
        /// </summary>
        private string tiposorteio;
        [XmlElement(ElementName = "TIPOSORTEIO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tiposorteio
        {
            get { return  tiposorteio; }
            set {  tiposorteio = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProgramabrinde()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPROGRAMABRINDE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProgramabrinde> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProgramabrinde>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProgramabrinde> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProgramabrinde>(where);
        }

        #endregion
    }
}
