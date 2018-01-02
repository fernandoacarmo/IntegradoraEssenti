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
    /// Classe referente a tabela PCDicionariofiltro
    /// </summary>
    [XmlType("PCDICIONARIOFILTRO")]
    public class PCDicionariofiltro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Código da rotina que utiliza o filtro
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

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
        /// Comentário: Nome do campo filho utilizando no filtro
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
        /// Propriedade referente ao campo: NOMEOBJETOFILHO
        /// Comentário: Nome da tabela filho
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
        /// Comentário: Nome da tabela pai
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
        public PCDicionariofiltro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDICIONARIOFILTRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDicionariofiltro> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDicionariofiltro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDicionariofiltro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDicionariofiltro>(where);
        }

        #endregion
    }
}
