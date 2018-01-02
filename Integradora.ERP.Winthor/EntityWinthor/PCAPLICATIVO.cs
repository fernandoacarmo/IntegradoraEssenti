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
    /// Classe referente a tabela PCAplicativo
    /// </summary>
    [XmlType("PCAPLICATIVO")]
    public class PCAplicativo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APLICATIVO
        /// Comentário: Agente em forma de arquivo binário
        /// </summary>
        private string aplicativo;
        [XmlElement(ElementName = "APLICATIVO", DataType = "BLOB", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Aplicativo
        {
            get { return  aplicativo; }
            set {  aplicativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BACKUPAPLICATIVO
        /// Comentário: 
        /// </summary>
        private string backupaplicativo;
        [XmlElement(ElementName = "BACKUPAPLICATIVO", DataType = "BLOB", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Backupaplicativo
        {
            get { return  backupaplicativo; }
            set {  backupaplicativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHASH
        /// Comentário: Hash calculado
        /// </summary>
        private string codhash;
        [XmlElement(ElementName = "CODHASH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Codhash
        {
            get { return  codhash; }
            set {  codhash = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data de inclusão do agente
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do agente
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HASHCODIGO
        /// Comentário: Campo HashCodigo
        /// </summary>
        private string hashcodigo;
        [XmlElement(ElementName = "HASHCODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Hashcodigo
        {
            get { return  hashcodigo; }
            set {  hashcodigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAO
        /// Comentário: Versão do agente
        /// </summary>
        private decimal versao;
        [XmlElement(ElementName = "VERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Versao
        {
            get { return  versao; }
            set {  versao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAplicativo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAPLICATIVO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAplicativo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAplicativo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAplicativo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAplicativo>(where);
        }

        #endregion
    }
}
