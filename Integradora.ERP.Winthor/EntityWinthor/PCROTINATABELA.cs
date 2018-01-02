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
    /// Classe referente a tabela PCRotinatabela
    /// </summary>
    [XmlType("PCROTINATABELA")]
    public class PCRotinatabela : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZARPERMISSAO
        /// Comentário: 
        /// </summary>
        private string atualizarpermissao;
        [XmlElement(ElementName = "ATUALIZARPERMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizarpermissao
        {
            get { return  atualizarpermissao; }
            set {  atualizarpermissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Código da rotina
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: Data de criação do registro
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
        /// Propriedade referente ao campo: NOMEOBJETO
        /// Comentário: Nome da tabela vinculado a rotina
        /// </summary>
        private string nomeobjeto;
        [XmlElement(ElementName = "NOMEOBJETO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Nomeobjeto
        {
            get { return  nomeobjeto; }
            set {  nomeobjeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTERAR
        /// Comentário: Permissão para alterar no cadastro
        /// </summary>
        private string permitealterar;
        [XmlElement(ElementName = "PERMITEALTERAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealterar
        {
            get { return  permitealterar; }
            set {  permitealterar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEEXCLUIR
        /// Comentário: Permissão para excluir no cadastro
        /// </summary>
        private string permiteexcluir;
        [XmlElement(ElementName = "PERMITEEXCLUIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteexcluir
        {
            get { return  permiteexcluir; }
            set {  permiteexcluir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEINCLUIR
        /// Comentário: Permissão para incluir no cadastro
        /// </summary>
        private string permiteincluir;
        [XmlElement(ElementName = "PERMITEINCLUIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteincluir
        {
            get { return  permiteincluir; }
            set {  permiteincluir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULOROTINA
        /// Comentário: 
        /// </summary>
        private string titulorotina;
        [XmlElement(ElementName = "TITULOROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Titulorotina
        {
            get { return  titulorotina; }
            set {  titulorotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARCADGENERICO
        /// Comentário: Verifica se aceita usar cadastro generico
        /// </summary>
        private string usarcadgenerico;
        [XmlElement(ElementName = "USARCADGENERICO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarcadgenerico
        {
            get { return  usarcadgenerico; }
            set {  usarcadgenerico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: WHEREADICIONALPESQ
        /// Comentário: Clausula adiciona no select de pesquisa
        /// </summary>
        private string whereadicionalpesq;
        [XmlElement(ElementName = "WHEREADICIONALPESQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Whereadicionalpesq
        {
            get { return  whereadicionalpesq; }
            set {  whereadicionalpesq = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRotinatabela()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTINATABELA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRotinatabela> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotinatabela>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRotinatabela> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotinatabela>(where);
        }

        #endregion
    }
}
