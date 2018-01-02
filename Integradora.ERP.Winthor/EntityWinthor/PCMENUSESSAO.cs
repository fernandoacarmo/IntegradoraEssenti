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
    /// Classe referente a tabela PCMenusessao
    /// </summary>
    [XmlType("PCMENUSESSAO")]
    public class PCMenusessao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Coment�rio: C�digo do usu�rio
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SID
        /// Coment�rio: C�digo da sess�o no oracle
        /// </summary>
        private decimal sid;
        [XmlElement(ElementName = "SID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Sid
        {
            get { return  sid; }
            set {  sid = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMenusessao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMENUSESSAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMenusessao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMenusessao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMenusessao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMenusessao>(where);
        }

        #endregion
    }
}
