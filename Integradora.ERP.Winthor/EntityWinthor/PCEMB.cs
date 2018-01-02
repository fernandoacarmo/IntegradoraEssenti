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
    /// Classe referente a tabela PCEmb
    /// </summary>
    [XmlType("PCEMB")]
    public class PCEmb : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPRODEMB1
        /// Comentário: 
        /// </summary>
        private decimal codprodemb1;
        [XmlElement(ElementName = "CODPRODEMB1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodemb1
        {
            get { return  codprodemb1; }
            set {  codprodemb1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODEMB2
        /// Comentário: 
        /// </summary>
        private decimal codprodemb2;
        [XmlElement(ElementName = "CODPRODEMB2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodemb2
        {
            get { return  codprodemb2; }
            set {  codprodemb2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODEMB3
        /// Comentário: 
        /// </summary>
        private decimal codprodemb3;
        [XmlElement(ElementName = "CODPRODEMB3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodemb3
        {
            get { return  codprodemb3; }
            set {  codprodemb3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINC
        /// Comentário: 
        /// </summary>
        private decimal codprodprinc;
        [XmlElement(ElementName = "CODPRODPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodprinc
        {
            get { return  codprodprinc; }
            set {  codprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCEMB1
        /// Comentário: 
        /// </summary>
        private string descemb1;
        [XmlElement(ElementName = "DESCEMB1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descemb1
        {
            get { return  descemb1; }
            set {  descemb1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCEMB2
        /// Comentário: 
        /// </summary>
        private string descemb2;
        [XmlElement(ElementName = "DESCEMB2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descemb2
        {
            get { return  descemb2; }
            set {  descemb2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCEMB3
        /// Comentário: 
        /// </summary>
        private string descemb3;
        [XmlElement(ElementName = "DESCEMB3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descemb3
        {
            get { return  descemb3; }
            set {  descemb3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCREDUZIDA
        /// Comentário: 
        /// </summary>
        private string descreduzida;
        [XmlElement(ElementName = "DESCREDUZIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descreduzida
        {
            get { return  descreduzida; }
            set {  descreduzida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRESSO
        /// Comentário: 
        /// </summary>
        private string impresso;
        [XmlElement(ElementName = "IMPRESSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impresso
        {
            get { return  impresso; }
            set {  impresso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT1
        /// Comentário: 
        /// </summary>
        private decimal qtunit1;
        [XmlElement(ElementName = "QTUNIT1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtunit1
        {
            get { return  qtunit1; }
            set {  qtunit1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT2
        /// Comentário: 
        /// </summary>
        private decimal qtunit2;
        [XmlElement(ElementName = "QTUNIT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtunit2
        {
            get { return  qtunit2; }
            set {  qtunit2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNIT3
        /// Comentário: 
        /// </summary>
        private decimal qtunit3;
        [XmlElement(ElementName = "QTUNIT3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtunit3
        {
            get { return  qtunit3; }
            set {  qtunit3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE1
        /// Comentário: 
        /// </summary>
        private string unidade1;
        [XmlElement(ElementName = "UNIDADE1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade1
        {
            get { return  unidade1; }
            set {  unidade1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE2
        /// Comentário: 
        /// </summary>
        private string unidade2;
        [XmlElement(ElementName = "UNIDADE2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade2
        {
            get { return  unidade2; }
            set {  unidade2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE3
        /// Comentário: 
        /// </summary>
        private string unidade3;
        [XmlElement(ElementName = "UNIDADE3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade3
        {
            get { return  unidade3; }
            set {  unidade3 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEmb()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEMB";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEmb> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEmb>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEmb> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEmb>(where);
        }

        #endregion
    }
}
