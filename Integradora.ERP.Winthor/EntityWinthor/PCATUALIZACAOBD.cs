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
    /// Classe referente a tabela PCAtualizacaobd
    /// </summary>
    [XmlType("PCATUALIZACAOBD")]
    public class PCAtualizacaobd : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição que será mostrada ao usuário
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,150)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPCAO
        /// Comentário: Opção da rotina
        /// </summary>
        private decimal opcao;
        [XmlElement(ElementName = "OPCAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Opcao
        {
            get { return  opcao; }
            set {  opcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Comentário: Rotina que altera o BD
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAO
        /// Comentário: Versão atual da rotina
        /// </summary>
        private string versao;
        [XmlElement(ElementName = "VERSAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
        public string Versao
        {
            get { return  versao; }
            set {  versao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAtualizacaobd()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCATUALIZACAOBD";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAtualizacaobd> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAtualizacaobd>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAtualizacaobd> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAtualizacaobd>(where);
        }

        #endregion
    }
}
