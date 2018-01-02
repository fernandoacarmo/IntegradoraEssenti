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
    /// Classe referente a tabela PCSerasaerrospefin
    /// </summary>
    [XmlType("PCSERASAERROSPEFIN")]
    public class PCSerasaerrospefin : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Código de erros do serasa.
        /// </summary>
        private string codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOERRO
        /// Comentário: Descrição do Erro
        /// </summary>
        private string descricaoerro;
        [XmlElement(ElementName = "DESCRICAOERRO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Descricaoerro
        {
            get { return  descricaoerro; }
            set {  descricaoerro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEF
        /// Comentário: Tipo Erro Pefin
        /// </summary>
        private string pef;
        [XmlElement(ElementName = "PEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pef
        {
            get { return  pef; }
            set {  pef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REMINF
        /// Comentário: Tipo Erro Remessa Informacional
        /// </summary>
        private string reminf;
        [XmlElement(ElementName = "REMINF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reminf
        {
            get { return  reminf; }
            set {  reminf = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCSerasaerrospefin()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERASAERROSPEFIN";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCSerasaerrospefin> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSerasaerrospefin>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCSerasaerrospefin> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSerasaerrospefin>(where);
        }

        #endregion
    }
}
