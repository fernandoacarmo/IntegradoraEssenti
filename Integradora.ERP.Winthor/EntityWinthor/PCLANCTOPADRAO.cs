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
    /// Classe referente a tabela PCLanctopadrao
    /// </summary>
    [XmlType("PCLANCTOPADRAO")]
    public class PCLanctopadrao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODHISTORICO
        /// Comentário: 
        /// </summary>
        private decimal codhistorico;
        [XmlElement(ElementName = "CODHISTORICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codhistorico
        {
            get { return  codhistorico; }
            set {  codhistorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLANCPADRAO
        /// Comentário: 
        /// </summary>
        private decimal codlancpadrao;
        [XmlElement(ElementName = "CODLANCPADRAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codlancpadrao
        {
            get { return  codlancpadrao; }
            set {  codlancpadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Comentário: 
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_CR
        /// Comentário: 
        /// </summary>
        private string codreduzido_cr;
        [XmlElement(ElementName = "CODREDUZIDO_CR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codreduzido_Cr
        {
            get { return  codreduzido_cr; }
            set {  codreduzido_cr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_DB
        /// Comentário: 
        /// </summary>
        private string codreduzido_db;
        [XmlElement(ElementName = "CODREDUZIDO_DB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codreduzido_Db
        {
            get { return  codreduzido_db; }
            set {  codreduzido_db = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO_COMPL
        /// Comentário: 
        /// </summary>
        private string historico_compl;
        [XmlElement(ElementName = "HISTORICO_COMPL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Historico_Compl
        {
            get { return  historico_compl; }
            set {  historico_compl = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_LANCTOPADRAO
        /// Comentário: 
        /// </summary>
        private string nome_lanctopadrao;
        [XmlElement(ElementName = "NOME_LANCTOPADRAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Nome_Lanctopadrao
        {
            get { return  nome_lanctopadrao; }
            set {  nome_lanctopadrao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLanctopadrao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLANCTOPADRAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLanctopadrao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLanctopadrao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLanctopadrao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLanctopadrao>(where);
        }

        #endregion
    }
}
