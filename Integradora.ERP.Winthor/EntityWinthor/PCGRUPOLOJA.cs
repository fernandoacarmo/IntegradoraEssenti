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
    /// Classe referente a tabela PCGrupoloja
    /// </summary>
    [XmlType("PCGRUPOLOJA")]
    public class PCGrupoloja : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOLOJA
        /// Coment�rio:  C�digo do Grupo de Lojas
        /// </summary>
        private decimal codgrupoloja;
        [XmlElement(ElementName = "CODGRUPOLOJA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codgrupoloja
        {
            get { return  codgrupoloja; }
            set {  codgrupoloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o do Grupo de Lojas
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCGrupoloja()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGRUPOLOJA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCGrupoloja> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGrupoloja>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCGrupoloja> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGrupoloja>(where);
        }

        #endregion
    }
}
