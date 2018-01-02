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
    /// Classe referente a tabela PCBenslocalizacao
    /// </summary>
    [XmlType("PCBENSLOCALIZACAO")]
    public class PCBenslocalizacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODLOCALIZACAO
        /// Coment�rio: Indica o c�digo da localiza��o do bem.
        /// </summary>
        private decimal codlocalizacao;
        [XmlElement(ElementName = "CODLOCALIZACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codlocalizacao
        {
            get { return  codlocalizacao; }
            set {  codlocalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCLOCALIZACAO
        /// Coment�rio: Indica a descri��o da localiza��o do bem.
        /// </summary>
        private string desclocalizacao;
        [XmlElement(ElementName = "DESCLOCALIZACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Desclocalizacao
        {
            get { return  desclocalizacao; }
            set {  desclocalizacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCBenslocalizacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBENSLOCALIZACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBenslocalizacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBenslocalizacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCBenslocalizacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBenslocalizacao>(where);
        }

        #endregion
    }
}
