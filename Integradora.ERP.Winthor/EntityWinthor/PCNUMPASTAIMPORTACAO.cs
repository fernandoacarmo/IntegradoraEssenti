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
    /// Classe referente a tabela PCNumpastaimportacao
    /// </summary>
    [XmlType("PCNUMPASTAIMPORTACAO")]
    public class PCNumpastaimportacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Ano que identifica o numerador.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPASTA
        /// Comentário: Numerador para identificar a pasta/processo de importação.
        /// </summary>
        private decimal proxnumpasta;
        [XmlElement(ElementName = "PROXNUMPASTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Proxnumpasta
        {
            get { return  proxnumpasta; }
            set {  proxnumpasta = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNumpastaimportacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNUMPASTAIMPORTACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNumpastaimportacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNumpastaimportacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNumpastaimportacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNumpastaimportacao>(where);
        }

        #endregion
    }
}
