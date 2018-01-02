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
    /// Classe referente a tabela PCPediaux
    /// </summary>
    [XmlType("PCPEDIAUX")]
    public class PCPediaux : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Coment�rio: 
        /// </summary>
        private string codfilialretira;
        [XmlElement(ElementName = "CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilialretira
        {
            get { return  codfilialretira; }
            set {  codfilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCTRANSF
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTTRANSF
        /// Coment�rio: 
        /// </summary>
        private DateTime? dttransf;
        [XmlElement(ElementName = "DTTRANSF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dttransf
        {
            get { return  dttransf; }
            set {  dttransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNFTRANSF
        /// Coment�rio: 
        /// </summary>
        private decimal numnftransf;
        [XmlElement(ElementName = "NUMNFTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numnftransf
        {
            get { return  numnftransf; }
            set {  numnftransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPediaux()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDIAUX";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPediaux> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPediaux>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPediaux> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPediaux>(where);
        }

        #endregion
    }
}
