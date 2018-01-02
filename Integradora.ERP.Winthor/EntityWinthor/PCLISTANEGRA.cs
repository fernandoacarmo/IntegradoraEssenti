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
    /// Classe referente a tabela PCListanegra
    /// </summary>
    [XmlType("PCLISTANEGRA")]
    public class PCListanegra : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CGCCPF
        /// Coment�rio: 
        /// </summary>
        private string cgccpf;
        [XmlElement(ElementName = "CGCCPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgccpf
        {
            get { return  cgccpf; }
            set {  cgccpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALNEGATIVADO
        /// Coment�rio: 
        /// </summary>
        private string codfilialnegativado;
        [XmlElement(ElementName = "CODFILIALNEGATIVADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialnegativado
        {
            get { return  codfilialnegativado; }
            set {  codfilialnegativado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCNEGATIVADO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncnegativado;
        [XmlElement(ElementName = "CODFUNCNEGATIVADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncnegativado
        {
            get { return  codfuncnegativado; }
            set {  codfuncnegativado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNEGATIVACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtnegativacao;
        [XmlElement(ElementName = "DTNEGATIVACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnegativacao
        {
            get { return  dtnegativacao; }
            set {  dtnegativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FANTASIA
        /// Coment�rio: 
        /// </summary>
        private string fantasia;
        [XmlElement(ElementName = "FANTASIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Fantasia
        {
            get { return  fantasia; }
            set {  fantasia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEFILIALNEG
        /// Coment�rio: 
        /// </summary>
        private string nomefilialneg;
        [XmlElement(ElementName = "NOMEFILIALNEG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomefilialneg
        {
            get { return  nomefilialneg; }
            set {  nomefilialneg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS3
        /// Coment�rio: 
        /// </summary>
        private string obs3;
        [XmlElement(ElementName = "OBS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Obs3
        {
            get { return  obs3; }
            set {  obs3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIAL
        /// Coment�rio: 
        /// </summary>
        private string razaosocial;
        [XmlElement(ElementName = "RAZAOSOCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Razaosocial
        {
            get { return  razaosocial; }
            set {  razaosocial = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCListanegra()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLISTANEGRA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCListanegra> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCListanegra>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCListanegra> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCListanegra>(where);
        }

        #endregion
    }
}
