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
    /// Classe referente a tabela PCProjeto
    /// </summary>
    [XmlType("PCPROJETO")]
    public class PCProjeto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROJETO
        /// Comentário: Código do Projeto. Cadastrado na 607, e usado na 631 e 749. 
        /// </summary>
        private decimal codprojeto;
        [XmlElement(ElementName = "CODPROJETO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprojeto
        {
            get { return  codprojeto; }
            set {  codprojeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROJETO
        /// Comentário: Nome do Projeto. Cadastrado na 607, e usado na 631 e 749. 
        /// </summary>
        private string projeto;
        [XmlElement(ElementName = "PROJETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Projeto
        {
            get { return  projeto; }
            set {  projeto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProjeto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPROJETO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProjeto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProjeto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProjeto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProjeto>(where);
        }

        #endregion
    }
}
