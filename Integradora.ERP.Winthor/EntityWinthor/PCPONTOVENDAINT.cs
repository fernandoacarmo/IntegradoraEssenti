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
    /// Classe referente a tabela PCPontovendaint
    /// </summary>
    [XmlType("PCPONTOVENDAINT")]
    public class PCPontovendaint : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLIINT
        /// Coment�rio: Recebe o identificador do cliente.
        /// </summary>
        private decimal codcliint;
        [XmlElement(ElementName = "CODCLIINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcliint
        {
            get { return  codcliint; }
            set {  codcliint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPONTOVENDA
        /// Coment�rio: Recebe o identificador do ponto de venda.
        /// </summary>
        private decimal codpontovenda;
        [XmlElement(ElementName = "CODPONTOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codpontovenda
        {
            get { return  codpontovenda; }
            set {  codpontovenda = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPontovendaint()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPONTOVENDAINT";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPontovendaint> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPontovendaint>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPontovendaint> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPontovendaint>(where);
        }

        #endregion
    }
}
