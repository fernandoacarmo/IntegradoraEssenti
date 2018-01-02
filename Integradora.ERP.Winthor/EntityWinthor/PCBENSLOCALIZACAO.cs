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
        /// Comentário: Indica o código da localização do bem.
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
        /// Comentário: Indica a descrição da localização do bem.
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBenslocalizacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBenslocalizacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
