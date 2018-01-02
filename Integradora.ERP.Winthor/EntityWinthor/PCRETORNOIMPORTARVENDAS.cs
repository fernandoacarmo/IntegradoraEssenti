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
    /// Classe referente a tabela PCRetornoimportarvendas
    /// </summary>
    [XmlType("PCRETORNOIMPORTARVENDAS")]
    public class PCRetornoimportarvendas : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODRETORNO
        /// Coment�rio: C�digo de retorno
        /// </summary>
        private decimal codretorno;
        [XmlElement(ElementName = "CODRETORNO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codretorno
        {
            get { return  codretorno; }
            set {  codretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Mensagem
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORETORNO
        /// Coment�rio: Tipo do retorno
        /// </summary>
        private string tiporetorno;
        [XmlElement(ElementName = "TIPORETORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiporetorno
        {
            get { return  tiporetorno; }
            set {  tiporetorno = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRetornoimportarvendas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRETORNOIMPORTARVENDAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRetornoimportarvendas> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRetornoimportarvendas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRetornoimportarvendas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRetornoimportarvendas>(where);
        }

        #endregion
    }
}
