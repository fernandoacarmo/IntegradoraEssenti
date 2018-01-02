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
    /// Classe referente a tabela PCMensagemadicional
    /// </summary>
    [XmlType("PCMENSAGEMADICIONAL")]
    public class PCMensagemadicional : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMENSAGEM
        /// Comentário: Código da mensagem.
        /// </summary>
        private decimal codmensagem;
        [XmlElement(ElementName = "CODMENSAGEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codmensagem
        {
            get { return  codmensagem; }
            set {  codmensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descricao da mensagem. 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,180)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVIMENTO
        /// Comentário: Indica se o movimento e de Entrada ou Saída. 
        /// </summary>
        private string movimento;
        [XmlElement(ElementName = "MOVIMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Movimento
        {
            get { return  movimento; }
            set {  movimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SQL
        /// Comentário: Contém o SQL do usuário. 
        /// </summary>
        private string sql;
        [XmlElement(ElementName = "SQL", DataType = "CLOB", IsNullable = false)]
        [DataObjectField(false,false,false,0)]
        public string Sql
        {
            get { return  sql; }
            set {  sql = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMensagemadicional()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMENSAGEMADICIONAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMensagemadicional> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMensagemadicional>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMensagemadicional> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMensagemadicional>(where);
        }

        #endregion
    }
}
