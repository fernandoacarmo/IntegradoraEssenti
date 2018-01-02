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
    /// Classe referente a tabela PCTrafegoregistros
    /// </summary>
    [XmlType("PCTRAFEGOREGISTROS")]
    public class PCTrafegoregistros : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data de inclus�o do registro.
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
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��es sobre a inclus�o do registro.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Coment�rio: Tabela do registro.
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Tabela
        {
            get { return  tabela; }
            set {  tabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAG
        /// Coment�rio: Identifica��o da opera��o.
        /// </summary>
        private string tag;
        [XmlElement(ElementName = "TAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tag
        {
            get { return  tag; }
            set {  tag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORROWID
        /// Coment�rio: Identifica��o do registro na origem.
        /// </summary>
        private string valorrowid;
        [XmlElement(ElementName = "VALORROWID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Valorrowid
        {
            get { return  valorrowid; }
            set {  valorrowid = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTrafegoregistros()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRAFEGOREGISTROS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTrafegoregistros> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTrafegoregistros>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTrafegoregistros> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTrafegoregistros>(where);
        }

        #endregion
    }
}
