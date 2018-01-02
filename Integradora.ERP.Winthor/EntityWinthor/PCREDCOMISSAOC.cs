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
    /// Classe referente a tabela PCRedcomissaoc
    /// </summary>
    [XmlType("PCREDCOMISSAOC")]
    public class PCRedcomissaoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODREDCOMISS
        /// Coment�rio: 
        /// </summary>
        private decimal codredcomiss;
        [XmlElement(ElementName = "CODREDCOMISS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codredcomiss
        {
            get { return  codredcomiss; }
            set {  codredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDCOMISS
        /// Coment�rio: 
        /// </summary>
        private decimal percredcomiss;
        [XmlElement(ElementName = "PERCREDCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percredcomiss
        {
            get { return  percredcomiss; }
            set {  percredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOREDCOMISS
        /// Coment�rio: 
        /// </summary>
        private string tiporedcomiss;
        [XmlElement(ElementName = "TIPOREDCOMISS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tiporedcomiss
        {
            get { return  tiporedcomiss; }
            set {  tiporedcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal vlvendaprev;
        [XmlElement(ElementName = "VLVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvendaprev
        {
            get { return  vlvendaprev; }
            set {  vlvendaprev = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRedcomissaoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREDCOMISSAOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRedcomissaoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRedcomissaoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRedcomissaoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRedcomissaoc>(where);
        }

        #endregion
    }
}
