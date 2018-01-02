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
    /// Classe referente a tabela PCParametrocontacontabil
    /// </summary>
    [XmlType("PCPARAMETROCONTACONTABIL")]
    public class PCParametrocontacontabil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGOPARAMETRO
        /// Comentário: Indica o código do parâmetro.
        /// </summary>
        private decimal codigoparametro;
        [XmlElement(ElementName = "CODIGOPARAMETRO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigoparametro
        {
            get { return  codigoparametro; }
            set {  codigoparametro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOPARAMETRO
        /// Comentário: Indica a descrição do parâmetro.
        /// </summary>
        private string descricaoparametro;
        [XmlElement(ElementName = "DESCRICAOPARAMETRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricaoparametro
        {
            get { return  descricaoparametro; }
            set {  descricaoparametro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLA
        /// Comentário: Sigla do parâmetro contabil
        /// </summary>
        private string sigla;
        [XmlElement(ElementName = "SIGLA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Sigla
        {
            get { return  sigla; }
            set {  sigla = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Indica a situação do parâmetro - [A]tiva ou [D]esativa.
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCParametrocontacontabil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARAMETROCONTACONTABIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCParametrocontacontabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParametrocontacontabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCParametrocontacontabil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParametrocontacontabil>(where);
        }

        #endregion
    }
}
