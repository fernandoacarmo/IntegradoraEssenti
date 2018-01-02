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
    /// Classe referente a tabela PCOperadoracartaobin
    /// </summary>
    [XmlType("PCOPERADORACARTAOBIN")]
    public class PCOperadoracartaobin : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BIN
        /// Coment�rio: Indica o numero do BIN do cart�o.
        /// </summary>
        private decimal bin;
        [XmlElement(ElementName = "BIN", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Bin
        {
            get { return  bin; }
            set {  bin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERADORA
        /// Coment�rio: Indica o c�digo da operadora de cart�o.
        /// </summary>
        private string codoperadora;
        [XmlElement(ElementName = "CODOPERADORA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Codoperadora
        {
            get { return  codoperadora; }
            set {  codoperadora = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOperadoracartaobin()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOPERADORACARTAOBIN";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOperadoracartaobin> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOperadoracartaobin>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOperadoracartaobin> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOperadoracartaobin>(where);
        }

        #endregion
    }
}
