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
    /// Classe referente a tabela PCDicionariofkitem
    /// </summary>
    [XmlType("PCDICIONARIOFKITEM")]
    public class PCDicionariofkitem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data de cadastro
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECAMPOFILHO
        /// Comentário: Nome do campo da tabela secundária
        /// </summary>
        private string nomecampofilho;
        [XmlElement(ElementName = "NOMECAMPOFILHO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomecampofilho
        {
            get { return  nomecampofilho; }
            set {  nomecampofilho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECAMPOPAI
        /// Comentário: Nome do campo da tabela principal
        /// </summary>
        private string nomecampopai;
        [XmlElement(ElementName = "NOMECAMPOPAI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomecampopai
        {
            get { return  nomecampopai; }
            set {  nomecampopai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEOBJETOFILHO
        /// Comentário: Nome da tabela secundária
        /// </summary>
        private string nomeobjetofilho;
        [XmlElement(ElementName = "NOMEOBJETOFILHO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomeobjetofilho
        {
            get { return  nomeobjetofilho; }
            set {  nomeobjetofilho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEOBJETOPAI
        /// Comentário: Nome da tabela principal
        /// </summary>
        private string nomeobjetopai;
        [XmlElement(ElementName = "NOMEOBJETOPAI", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Nomeobjetopai
        {
            get { return  nomeobjetopai; }
            set {  nomeobjetopai = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDicionariofkitem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDICIONARIOFKITEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDicionariofkitem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDicionariofkitem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDicionariofkitem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDicionariofkitem>(where);
        }

        #endregion
    }
}
