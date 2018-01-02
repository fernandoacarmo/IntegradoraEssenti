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
    /// Classe referente a tabela PCContamaster
    /// </summary>
    [XmlType("PCCONTAMASTER")]
    public class PCContamaster : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAMASTER
        /// Coment�rio: Identificador da conta master.
        /// </summary>
        private decimal codcontamaster;
        [XmlElement(ElementName = "CODCONTAMASTER", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcontamaster
        {
            get { return  codcontamaster; }
            set {  codcontamaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOCONTA
        /// Coment�rio: Ordena��o de exibi��o das contas.
        /// </summary>
        private decimal codtipoconta;
        [XmlElement(ElementName = "CODTIPOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codtipoconta
        {
            get { return  codtipoconta; }
            set {  codtipoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o da conta master.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDENACAO
        /// Coment�rio: Define o codigo do tipo de conta master.
        /// </summary>
        private decimal ordenacao;
        [XmlElement(ElementName = "ORDENACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Ordenacao
        {
            get { return  ordenacao; }
            set {  ordenacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCContamaster()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTAMASTER";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCContamaster> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContamaster>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCContamaster> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContamaster>(where);
        }

        #endregion
    }
}
