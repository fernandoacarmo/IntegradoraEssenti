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
    /// Classe referente a tabela PCGrupofilial
    /// </summary>
    [XmlType("PCGRUPOFILIAL")]
    public class PCGrupofilial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOFILIAL
        /// Comentário: 
        /// </summary>
        private decimal codgrupofilial;
        [XmlElement(ElementName = "CODGRUPOFILIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codgrupofilial
        {
            get { return  codgrupofilial; }
            set {  codgrupofilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_GRUPOFILIAL
        /// Comentário: 
        /// </summary>
        private string nome_grupofilial;
        [XmlElement(ElementName = "NOME_GRUPOFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nome_Grupofilial
        {
            get { return  nome_grupofilial; }
            set {  nome_grupofilial = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCGrupofilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGRUPOFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCGrupofilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGrupofilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCGrupofilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGrupofilial>(where);
        }

        #endregion
    }
}
