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
    /// Classe referente a tabela PCExpressaoesp
    /// </summary>
    [XmlType("PCEXPRESSAOESP")]
    public class PCExpressaoesp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEXPRESSAO
        /// Comentário: CÓDIGO DA EXPRESSAO
        /// </summary>
        private decimal codexpressao;
        [XmlElement(ElementName = "CODEXPRESSAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codexpressao
        {
            get { return  codexpressao; }
            set {  codexpressao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Comentário: CÓDIGO DO RELATORIO
        /// </summary>
        private decimal codrelatorio;
        [XmlElement(ElementName = "CODRELATORIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrelatorio
        {
            get { return  codrelatorio; }
            set {  codrelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCEXPRESSAO
        /// Comentário: DESCRICAO DA EXPRESSAO
        /// </summary>
        private string descexpressao;
        [XmlElement(ElementName = "DESCEXPRESSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Descexpressao
        {
            get { return  descexpressao; }
            set {  descexpressao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEEXPRESSAO
        /// Comentário: NOME DA EXPRESSAO
        /// </summary>
        private string nomeexpressao;
        [XmlElement(ElementName = "NOMEEXPRESSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Nomeexpressao
        {
            get { return  nomeexpressao; }
            set {  nomeexpressao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCExpressaoesp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEXPRESSAOESP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCExpressaoesp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCExpressaoesp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCExpressaoesp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCExpressaoesp>(where);
        }

        #endregion
    }
}
