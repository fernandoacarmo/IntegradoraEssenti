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
    /// Classe referente a tabela PCVinculoespecificacao
    /// </summary>
    [XmlType("PCVINCULOESPECIFICACAO")]
    public class PCVinculoespecificacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODATRIBUTO
        /// Coment�rio: C�digo do Atributo
        /// </summary>
        private string codatributo;
        [XmlElement(ElementName = "CODATRIBUTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codatributo
        {
            get { return  codatributo; }
            set {  codatributo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESPECIFICACAO
        /// Coment�rio: C�digo da Especifica��o
        /// </summary>
        private string codespecificacao;
        [XmlElement(ElementName = "CODESPECIFICACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public string Codespecificacao
        {
            get { return  codespecificacao; }
            set {  codespecificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNVE
        /// Coment�rio: C�digo NVE
        /// </summary>
        private string codnve;
        [XmlElement(ElementName = "CODNVE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codnve
        {
            get { return  codnve; }
            set {  codnve = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIO
        /// Coment�rio: C�digo do usu�rio Cadastro
        /// </summary>
        private decimal codusuario;
        [XmlElement(ElementName = "CODUSUARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuario
        {
            get { return  codusuario; }
            set {  codusuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data do Vinculo
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCVinculoespecificacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVINCULOESPECIFICACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCVinculoespecificacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVinculoespecificacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCVinculoespecificacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVinculoespecificacao>(where);
        }

        #endregion
    }
}
