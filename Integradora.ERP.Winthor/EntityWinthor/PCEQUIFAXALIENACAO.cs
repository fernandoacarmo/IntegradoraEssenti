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
    /// Classe referente a tabela PCEquifaxalienacao
    /// </summary>
    [XmlType("PCEQUIFAXALIENACAO")]
    public class PCEquifaxalienacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOPERSONALIZADA
        /// Comentário: Nome Personalizado da Tag XML
        /// </summary>
        private string descricaopersonalizada;
        [XmlElement(ElementName = "DESCRICAOPERSONALIZADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricaopersonalizada
        {
            get { return  descricaopersonalizada; }
            set {  descricaopersonalizada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOXML
        /// Comentário: Nome da Tag XML
        /// </summary>
        private string descricaoxml;
        [XmlElement(ElementName = "DESCRICAOXML", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Descricaoxml
        {
            get { return  descricaoxml; }
            set {  descricaoxml = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEquifaxalienacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEQUIFAXALIENACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEquifaxalienacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEquifaxalienacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEquifaxalienacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEquifaxalienacao>(where);
        }

        #endregion
    }
}
