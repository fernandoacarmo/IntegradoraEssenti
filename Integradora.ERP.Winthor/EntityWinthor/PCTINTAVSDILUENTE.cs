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
    /// Classe referente a tabela PCTintavsdiluente
    /// </summary>
    [XmlType("PCTINTAVSDILUENTE")]
    public class PCTintavsdiluente : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODLINHA
        /// Coment�rio: 
        /// </summary>
        private string codlinha;
        [XmlElement(ElementName = "CODLINHA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codlinha
        {
            get { return  codlinha; }
            set {  codlinha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Coment�rio: 
        /// </summary>
        private decimal codmaquina;
        [XmlElement(ElementName = "CODMAQUINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmaquina
        {
            get { return  codmaquina; }
            set {  codmaquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODTINTA
        /// Coment�rio: 
        /// </summary>
        private string codprodtinta;
        [XmlElement(ElementName = "CODPRODTINTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codprodtinta
        {
            get { return  codprodtinta; }
            set {  codprodtinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODQUALIDADE
        /// Coment�rio: 
        /// </summary>
        private string codqualidade;
        [XmlElement(ElementName = "CODQUALIDADE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codqualidade
        {
            get { return  codqualidade; }
            set {  codqualidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAX
        /// Coment�rio: 
        /// </summary>
        private decimal percmax;
        [XmlElement(ElementName = "PERCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Percmax
        {
            get { return  percmax; }
            set {  percmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMIN
        /// Coment�rio: 
        /// </summary>
        private decimal percmin;
        [XmlElement(ElementName = "PERCMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Percmin
        {
            get { return  percmin; }
            set {  percmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPADRAO
        /// Coment�rio: 
        /// </summary>
        private decimal percpadrao;
        [XmlElement(ElementName = "PERCPADRAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Percpadrao
        {
            get { return  percpadrao; }
            set {  percpadrao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTintavsdiluente()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTINTAVSDILUENTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTintavsdiluente> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTintavsdiluente>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTintavsdiluente> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTintavsdiluente>(where);
        }

        #endregion
    }
}
