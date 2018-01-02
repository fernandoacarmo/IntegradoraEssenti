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
    /// Classe referente a tabela PCGruposcampanhai
    /// </summary>
    [XmlType("PCGRUPOSCAMPANHAI")]
    public class PCGruposcampanhai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Coment�rio: C�digo do grupo
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODITEM
        /// Coment�rio: C�digo do item do grupo (RCA ou Produto)
        /// </summary>
        private decimal coditem;
        [XmlElement(ElementName = "CODITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Coditem
        {
            get { return  coditem; }
            set {  coditem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Data da exclus�o
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCGruposcampanhai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGRUPOSCAMPANHAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCGruposcampanhai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGruposcampanhai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCGruposcampanhai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGruposcampanhai>(where);
        }

        #endregion
    }
}
