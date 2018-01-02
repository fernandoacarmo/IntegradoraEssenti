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
    /// Classe referente a tabela PCPergunta
    /// </summary>
    [XmlType("PCPERGUNTA")]
    public class PCPergunta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPERGUNTA
        /// Coment�rio: 
        /// </summary>
        private decimal codpergunta;
        [XmlElement(ElementName = "CODPERGUNTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codpergunta
        {
            get { return  codpergunta; }
            set {  codpergunta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPESQUISA
        /// Coment�rio: 
        /// </summary>
        private decimal codpesquisa;
        [XmlElement(ElementName = "CODPESQUISA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codpesquisa
        {
            get { return  codpesquisa; }
            set {  codpesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSERVICO
        /// Coment�rio: Indica o c�digo do servi�o.
        /// </summary>
        private decimal codservico;
        [XmlElement(ElementName = "CODSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codservico
        {
            get { return  codservico; }
            set {  codservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENCADEADA
        /// Coment�rio: 
        /// </summary>
        private string encadeada;
        [XmlElement(ElementName = "ENCADEADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Encadeada
        {
            get { return  encadeada; }
            set {  encadeada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODULO
        /// Coment�rio: Indica o modulo da pergunta.
        /// </summary>
        private decimal modulo;
        [XmlElement(ElementName = "MODULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Modulo
        {
            get { return  modulo; }
            set {  modulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERGUNTA
        /// Coment�rio: 
        /// </summary>
        private string pergunta;
        [XmlElement(ElementName = "PERGUNTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,200)]
        public string Pergunta
        {
            get { return  pergunta; }
            set {  pergunta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORESPOSTA
        /// Coment�rio: 
        /// </summary>
        private string tiporesposta;
        [XmlElement(ElementName = "TIPORESPOSTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiporesposta
        {
            get { return  tiporesposta; }
            set {  tiporesposta = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPergunta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPERGUNTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPergunta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPergunta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPergunta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPergunta>(where);
        }

        #endregion
    }
}
