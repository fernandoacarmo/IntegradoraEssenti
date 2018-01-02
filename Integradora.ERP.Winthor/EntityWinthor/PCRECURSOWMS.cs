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
    /// Classe referente a tabela PCRecursowms
    /// </summary>
    [XmlType("PCRECURSOWMS")]
    public class PCRecursowms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private string codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRECURSO
        /// Comentário: 
        /// </summary>
        private decimal codrecurso;
        [XmlElement(ElementName = "CODRECURSO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codrecurso
        {
            get { return  codrecurso; }
            set {  codrecurso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECURSOPROPRIO
        /// Comentário: 
        /// </summary>
        private string recursoproprio;
        [XmlElement(ElementName = "RECURSOPROPRIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Recursoproprio
        {
            get { return  recursoproprio; }
            set {  recursoproprio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORECURSO
        /// Comentário: 
        /// </summary>
        private string tiporecurso;
        [XmlElement(ElementName = "TIPORECURSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiporecurso
        {
            get { return  tiporecurso; }
            set {  tiporecurso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORHORA
        /// Comentário: 
        /// </summary>
        private decimal valorhora;
        [XmlElement(ElementName = "VALORHORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorhora
        {
            get { return  valorhora; }
            set {  valorhora = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRecursowms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRECURSOWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRecursowms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRecursowms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRecursowms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRecursowms>(where);
        }

        #endregion
    }
}
