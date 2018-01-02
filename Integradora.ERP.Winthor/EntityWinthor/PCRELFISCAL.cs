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
    /// Classe referente a tabela PCRelfiscal
    /// </summary>
    [XmlType("PCRELFISCAL")]
    public class PCRelfiscal : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODRELATORIO
        /// Comentário: Código do Relatório.
        /// </summary>
        private decimal codrelatorio;
        [XmlElement(ElementName = "CODRELATORIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codrelatorio
        {
            get { return  codrelatorio; }
            set {  codrelatorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBETOTALGERAL
        /// Comentário: 
        /// </summary>
        private string exibetotalgeral;
        [XmlElement(ElementName = "EXIBETOTALGERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibetotalgeral
        {
            get { return  exibetotalgeral; }
            set {  exibetotalgeral = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBETOTALGRUPO
        /// Comentário: Indica se exibe o total do geral.
        /// </summary>
        private string exibetotalgrupo;
        [XmlElement(ElementName = "EXIBETOTALGRUPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibetotalgrupo
        {
            get { return  exibetotalgrupo; }
            set {  exibetotalgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBTITULO
        /// Comentário: Sub Titulo do Relatório.
        /// </summary>
        private string subtitulo;
        [XmlElement(ElementName = "SUBTITULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Subtitulo
        {
            get { return  subtitulo; }
            set {  subtitulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULO
        /// Comentário: Titulo do Relatório.
        /// </summary>
        private string titulo;
        [XmlElement(ElementName = "TITULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Titulo
        {
            get { return  titulo; }
            set {  titulo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRelfiscal()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRELFISCAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRelfiscal> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRelfiscal>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRelfiscal> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRelfiscal>(where);
        }

        #endregion
    }
}
