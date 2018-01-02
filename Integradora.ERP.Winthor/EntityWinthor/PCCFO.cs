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
    /// Classe referente a tabela PCCfo
    /// </summary>
    [XmlType("PCCFO")]
    public class PCCfo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CFOPINVERSO
        /// Comentário: 
        /// </summary>
        private decimal cfopinverso;
        [XmlElement(ElementName = "CFOPINVERSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cfopinverso
        {
            get { return  cfopinverso; }
            set {  cfopinverso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: 
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALMASTER
        /// Comentário: 
        /// </summary>
        private decimal codfiscalmaster;
        [XmlElement(ElementName = "CODFISCALMASTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscalmaster
        {
            get { return  codfiscalmaster; }
            set {  codfiscalmaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPER
        /// Comentário: 
        /// </summary>
        private string codoper;
        [XmlElement(ElementName = "CODOPER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codoper
        {
            get { return  codoper; }
            set {  codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCCFO
        /// Comentário: 
        /// </summary>
        private string desccfo;
        [XmlElement(ElementName = "DESCCFO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Desccfo
        {
            get { return  desccfo; }
            set {  desccfo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCSINTEGRA
        /// Comentário: 
        /// </summary>
        private string descsintegra;
        [XmlElement(ElementName = "DESCSINTEGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Descsintegra
        {
            get { return  descsintegra; }
            set {  descsintegra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCFO
        /// Comentário: 
        /// </summary>
        private string obscfo;
        [XmlElement(ElementName = "OBSCFO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obscfo
        {
            get { return  obscfo; }
            set {  obscfo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCfo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCFO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCfo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCfo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCfo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCfo>(where);
        }

        #endregion
    }
}
