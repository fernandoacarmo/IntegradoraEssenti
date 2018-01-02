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
    /// Classe referente a tabela PCMixidealnestle
    /// </summary>
    [XmlType("PCMIXIDEALNESTLE")]
    public class PCMixidealnestle : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODATIVNESTLE
        /// Coment�rio: C�digo ramo de atividade nestle.
        /// </summary>
        private decimal codativnestle;
        [XmlElement(ElementName = "CODATIVNESTLE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codativnestle
        {
            get { return  codativnestle; }
            set {  codativnestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODNESTLE
        /// Coment�rio: C�digo do produto nestle.
        /// </summary>
        private string codprodnestle;
        [XmlElement(ElementName = "CODPRODNESTLE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Codprodnestle
        {
            get { return  codprodnestle; }
            set {  codprodnestle = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMixidealnestle()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMIXIDEALNESTLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMixidealnestle> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMixidealnestle>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMixidealnestle> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMixidealnestle>(where);
        }

        #endregion
    }
}
