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
    /// Classe referente a tabela PCTerminalportuario
    /// </summary>
    [XmlType("PCTERMINALPORTUARIO")]
    public class PCTerminalportuario : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPORTO
        /// Comentário: Código do Porto onde o Terminal Portuário está situado.
        /// </summary>
        private decimal codporto;
        [XmlElement(ElementName = "CODPORTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codporto
        {
            get { return  codporto; }
            set {  codporto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTERMINAL
        /// Comentário: Código do Terminal Portuário.
        /// </summary>
        private decimal codterminal;
        [XmlElement(ElementName = "CODTERMINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codterminal
        {
            get { return  codterminal; }
            set {  codterminal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do Terminal Portuário.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTerminalportuario()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTERMINALPORTUARIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTerminalportuario> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTerminalportuario>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTerminalportuario> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTerminalportuario>(where);
        }

        #endregion
    }
}
