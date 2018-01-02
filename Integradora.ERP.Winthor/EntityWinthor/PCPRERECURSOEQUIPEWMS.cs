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
    /// Classe referente a tabela PCPrerecursoequipewms
    /// </summary>
    [XmlType("PCPRERECURSOEQUIPEWMS")]
    public class PCPrerecursoequipewms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPE
        /// Comentário: Indica o código da equipe.
        /// </summary>
        private decimal codequipe;
        [XmlElement(ElementName = "CODEQUIPE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codequipe
        {
            get { return  codequipe; }
            set {  codequipe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRECURSO
        /// Comentário: Indica o código do recurso.
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
        /// Propriedade referente ao campo: VALORHORA
        /// Comentário: Indica o valor da hora.
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
        public PCPrerecursoequipewms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRERECURSOEQUIPEWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPrerecursoequipewms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrerecursoequipewms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPrerecursoequipewms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrerecursoequipewms>(where);
        }

        #endregion
    }
}
