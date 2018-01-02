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
    /// Classe referente a tabela PCRelgrupo
    /// </summary>
    [XmlType("PCRELGRUPO")]
    public class PCRelgrupo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Comentário: Código do Grupo.
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Comentário: Código do Relatório.
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
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBE_VLBASE
        /// Comentário: Exibir Vl.Base.
        /// </summary>
        private string exibe_vlbase;
        [XmlElement(ElementName = "EXIBE_VLBASE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibe_Vlbase
        {
            get { return  exibe_vlbase; }
            set {  exibe_vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBE_VLCONTABIL
        /// Comentário: Exibir Vl.Contábil.
        /// </summary>
        private string exibe_vlcontabil;
        [XmlElement(ElementName = "EXIBE_VLCONTABIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibe_Vlcontabil
        {
            get { return  exibe_vlcontabil; }
            set {  exibe_vlcontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBE_VLICMS
        /// Comentário: Exibir Vl.ICMS.
        /// </summary>
        private string exibe_vlicms;
        [XmlElement(ElementName = "EXIBE_VLICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibe_Vlicms
        {
            get { return  exibe_vlicms; }
            set {  exibe_vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Comentário: Ordem do Grupo.
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRelgrupo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRELGRUPO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRelgrupo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRelgrupo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRelgrupo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRelgrupo>(where);
        }

        #endregion
    }
}
