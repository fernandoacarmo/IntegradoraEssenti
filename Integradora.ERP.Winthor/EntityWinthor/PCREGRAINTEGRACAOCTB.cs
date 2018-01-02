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
    /// Classe referente a tabela PCRegraintegracaoctb
    /// </summary>
    [XmlType("PCREGRAINTEGRACAOCTB")]
    public class PCRegraintegracaoctb : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica o código da filial. 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

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
        /// Propriedade referente ao campo: CODREGRA
        /// Comentário: 
        /// </summary>
        private decimal codregra;
        [XmlElement(ElementName = "CODREGRA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,38)]
        public decimal Codregra
        {
            get { return  codregra; }
            set {  codregra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
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
        /// Propriedade referente ao campo: REGRAATIVA
        /// Comentário: Regra está ativa para integração.
        /// </summary>
        private string regraativa;
        [XmlElement(ElementName = "REGRAATIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Regraativa
        {
            get { return  regraativa; }
            set {  regraativa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SCRIPTSQL
        /// Comentário: 
        /// </summary>
        private string scriptsql;
        [XmlElement(ElementName = "SCRIPTSQL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Scriptsql
        {
            get { return  scriptsql; }
            set {  scriptsql = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINTEGRACAO
        /// Comentário: Identifica o tipo da integração: Analítica ou Sintética. 
        /// </summary>
        private string tipointegracao;
        [XmlElement(ElementName = "TIPOINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipointegracao
        {
            get { return  tipointegracao; }
            set {  tipointegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPERACAO
        /// Comentário: 
        /// </summary>
        private string tipooperacao;
        [XmlElement(ElementName = "TIPOOPERACAO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipooperacao
        {
            get { return  tipooperacao; }
            set {  tipooperacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRegraintegracaoctb()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREGRAINTEGRACAOCTB";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRegraintegracaoctb> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRegraintegracaoctb>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRegraintegracaoctb> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRegraintegracaoctb>(where);
        }

        #endregion
    }
}
