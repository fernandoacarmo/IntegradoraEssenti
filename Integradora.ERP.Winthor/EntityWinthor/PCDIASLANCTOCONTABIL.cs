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
    /// Classe referente a tabela PCDiaslanctocontabil
    /// </summary>
    [XmlType("PCDIASLANCTOCONTABIL")]
    public class PCDiaslanctocontabil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial do lan�amento cont�bil.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Coment�rio: C�digo de plano de contas do lan�amento cont�bil.
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Coment�rio: Data do lan�amento cont�bil.
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDiaslanctocontabil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDIASLANCTOCONTABIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDiaslanctocontabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDiaslanctocontabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDiaslanctocontabil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDiaslanctocontabil>(where);
        }

        #endregion
    }
}
