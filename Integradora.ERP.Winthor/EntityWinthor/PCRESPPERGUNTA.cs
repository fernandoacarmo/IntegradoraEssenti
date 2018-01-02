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
    /// Classe referente a tabela PCResppergunta
    /// </summary>
    [XmlType("PCRESPPERGUNTA")]
    public class PCResppergunta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPERGUNTAENCADEADA
        /// Comentário: 
        /// </summary>
        private decimal codperguntaencadeada;
        [XmlElement(ElementName = "CODPERGUNTAENCADEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codperguntaencadeada
        {
            get { return  codperguntaencadeada; }
            set {  codperguntaencadeada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPESQUISA
        /// Comentário: 
        /// </summary>
        private decimal codpesquisa;
        [XmlElement(ElementName = "CODPESQUISA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpesquisa
        {
            get { return  codpesquisa; }
            set {  codpesquisa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRESPPERGUNTA
        /// Comentário: 
        /// </summary>
        private decimal codresppergunta;
        [XmlElement(ElementName = "CODRESPPERGUNTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codresppergunta
        {
            get { return  codresppergunta; }
            set {  codresppergunta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENCADEADA
        /// Comentário: 
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
        /// Propriedade referente ao campo: PERGUNTA
        /// Comentário: 
        /// </summary>
        private decimal pergunta;
        [XmlElement(ElementName = "PERGUNTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pergunta
        {
            get { return  pergunta; }
            set {  pergunta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTO
        /// Comentário: 
        /// </summary>
        private string texto;
        [XmlElement(ElementName = "TEXTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Texto
        {
            get { return  texto; }
            set {  texto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCResppergunta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRESPPERGUNTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCResppergunta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCResppergunta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCResppergunta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCResppergunta>(where);
        }

        #endregion
    }
}
