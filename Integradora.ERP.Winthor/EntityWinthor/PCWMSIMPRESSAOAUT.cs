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
    /// Classe referente a tabela PCWmsimpressaoaut
    /// </summary>
    [XmlType("PCWMSIMPRESSAOAUT")]
    public class PCWmsimpressaoaut : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONF
        /// Comentário: Código da configuração
        /// </summary>
        private decimal codconf;
        [XmlElement(ElementName = "CODCONF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codconf
        {
            get { return  codconf; }
            set {  codconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Filial da configuração
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
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Código da rotina
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data de cadastro
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_IMPRESSORA
        /// Comentário: Nome da Impressora
        /// </summary>
        private string nome_impressora;
        [XmlElement(ElementName = "NOME_IMPRESSORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nome_Impressora
        {
            get { return  nome_impressora; }
            set {  nome_impressora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOC
        /// Comentário: Tipo do Documento
        /// </summary>
        private string tipodoc;
        [XmlElement(ElementName = "TIPODOC", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodoc
        {
            get { return  tipodoc; }
            set {  tipodoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOS
        /// Comentário: Tipo da O.S
        /// </summary>
        private decimal tipoos;
        [XmlElement(ElementName = "TIPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tipoos
        {
            get { return  tipoos; }
            set {  tipoos = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmsimpressaoaut()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSIMPRESSAOAUT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmsimpressaoaut> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsimpressaoaut.GetStringConnection());
            return ba.Listar<PCWmsimpressaoaut>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmsimpressaoaut> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsimpressaoaut.GetStringConnection());
            return ba.Existe<PCWmsimpressaoaut>(where);
        }

        #endregion
    }
}
