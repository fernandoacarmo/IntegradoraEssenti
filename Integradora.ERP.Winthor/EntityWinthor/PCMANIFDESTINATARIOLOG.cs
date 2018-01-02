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
    /// Classe referente a tabela PCManifdestinatariolog
    /// </summary>
    [XmlType("PCMANIFDESTINATARIOLOG")]
    public class PCManifdestinatariolog : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Filial utilizada na opera��o
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
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: C�digo Func. realizou a opera��o
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: C�digo de identifica��o
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSULTOUNFTRANSF
        /// Coment�rio: Indica se consultou notas de transferencias
        /// </summary>
        private string consultounftransf;
        [XmlElement(ElementName = "CONSULTOUNFTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consultounftransf
        {
            get { return  consultounftransf; }
            set {  consultounftransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data da opera��o
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
        /// Propriedade referente ao campo: MAQUINA
        /// Coment�rio: Maquina que realizou a opera��o
        /// </summary>
        private string maquina;
        [XmlElement(ElementName = "MAQUINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Maquina
        {
            get { return  maquina; }
            set {  maquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPCAOUTILIZADA
        /// Coment�rio: Op��o selecionada pelo usu�rio
        /// </summary>
        private decimal opcaoutilizada;
        [XmlElement(ElementName = "OPCAOUTILIZADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Opcaoutilizada
        {
            get { return  opcaoutilizada; }
            set {  opcaoutilizada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITCONFIRMACAODEST
        /// Coment�rio: Confirma��o Destinat�rio
        /// </summary>
        private decimal sitconfirmacaodest;
        [XmlElement(ElementName = "SITCONFIRMACAODEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Sitconfirmacaodest
        {
            get { return  sitconfirmacaodest; }
            set {  sitconfirmacaodest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOSO
        /// Coment�rio: Usuario do sistema operacional
        /// </summary>
        private string usuarioso;
        [XmlElement(ElementName = "USUARIOSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Usuarioso
        {
            get { return  usuarioso; }
            set {  usuarioso = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCManifdestinatariolog()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMANIFDESTINATARIOLOG";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCManifdestinatariolog> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCManifdestinatariolog>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCManifdestinatariolog> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCManifdestinatariolog>(where);
        }

        #endregion
    }
}
