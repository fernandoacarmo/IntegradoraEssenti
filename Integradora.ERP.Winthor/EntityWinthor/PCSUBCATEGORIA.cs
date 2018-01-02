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
    /// Classe referente a tabela PCSubcategoria
    /// </summary>
    [XmlType("PCSUBCATEGORIA")]
    public class PCSubcategoria : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CMSCLASSIFICACAOCAXIAS
        /// Comentário: 
        /// </summary>
        private string cmsclassificacaocaxias;
        [XmlElement(ElementName = "CMSCLASSIFICACAOCAXIAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cmsclassificacaocaxias
        {
            get { return  cmsclassificacaocaxias; }
            set {  cmsclassificacaocaxias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CMSCLASSIFICACAOJOACABA
        /// Comentário: 
        /// </summary>
        private string cmsclassificacaojoacaba;
        [XmlElement(ElementName = "CMSCLASSIFICACAOJOACABA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cmsclassificacaojoacaba
        {
            get { return  cmsclassificacaojoacaba; }
            set {  cmsclassificacaojoacaba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Comentário: 
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIA
        /// Comentário: 
        /// </summary>
        private decimal codsubcategoria;
        [XmlElement(ElementName = "CODSUBCATEGORIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codsubcategoria
        {
            get { return  codsubcategoria; }
            set {  codsubcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBCATEGORIA
        /// Comentário: 
        /// </summary>
        private string subcategoria;
        [XmlElement(ElementName = "SUBCATEGORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Subcategoria
        {
            get { return  subcategoria; }
            set {  subcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAMIX2
        /// Comentário: 
        /// </summary>
        private string usamix2;
        [XmlElement(ElementName = "USAMIX2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usamix2
        {
            get { return  usamix2; }
            set {  usamix2 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSubcategoria()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSUBCATEGORIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSubcategoria> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSubcategoria>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSubcategoria> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSubcategoria>(where);
        }

        #endregion
    }
}
