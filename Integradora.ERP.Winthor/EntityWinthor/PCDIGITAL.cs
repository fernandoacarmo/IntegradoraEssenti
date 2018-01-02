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
    /// Classe referente a tabela PCDigital
    /// </summary>
    [XmlType("PCDIGITAL")]
    public class PCDigital : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGODIGITAL
        /// Comentário: Indica o código de registro da digital.
        /// </summary>
        private decimal codigodigital;
        [XmlElement(ElementName = "CODIGODIGITAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigodigital
        {
            get { return  codigodigital; }
            set {  codigodigital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGITAL
        /// Comentário: Indica a digital armazenada.
        /// </summary>
        private string digital;
        [XmlElement(ElementName = "DIGITAL", DataType = "BLOB", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Digital
        {
            get { return  digital; }
            set {  digital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: Indica a matricula correspondente ao usuário.
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDigital()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDIGITAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDigital> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDigital>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDigital> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDigital>(where);
        }

        #endregion
    }
}
