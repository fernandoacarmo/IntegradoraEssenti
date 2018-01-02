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
    /// Classe referente a tabela PCMensagemnfe
    /// </summary>
    [XmlType("PCMENSAGEMNFE")]
    public class PCMensagemnfe : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMENSAGEM
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: SOLUCAO
        /// Comentário: Gravar o hint de ajuda para solução dos problemas
        /// </summary>
        private string solucao;
        [XmlElement(ElementName = "SOLUCAO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Solucao
        {
            get { return  solucao; }
            set {  solucao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMensagemnfe()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMENSAGEMNFE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMensagemnfe> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMensagemnfe>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMensagemnfe> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMensagemnfe>(where);
        }

        #endregion
    }
}
