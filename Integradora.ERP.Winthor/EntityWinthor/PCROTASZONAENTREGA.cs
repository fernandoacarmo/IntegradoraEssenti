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
    /// Classe referente a tabela PCRotaszonaentrega
    /// </summary>
    [XmlType("PCROTASZONAENTREGA")]
    public class PCRotaszonaentrega : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODROTA
        /// Coment�rio: C�digo da Rota
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODZONAENTREGA
        /// Coment�rio: C�digo da Zona de Entrega
        /// </summary>
        private decimal codzonaentrega;
        [XmlElement(ElementName = "CODZONAENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codzonaentrega
        {
            get { return  codzonaentrega; }
            set {  codzonaentrega = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRotaszonaentrega()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTASZONAENTREGA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRotaszonaentrega> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotaszonaentrega>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRotaszonaentrega> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotaszonaentrega>(where);
        }

        #endregion
    }
}
