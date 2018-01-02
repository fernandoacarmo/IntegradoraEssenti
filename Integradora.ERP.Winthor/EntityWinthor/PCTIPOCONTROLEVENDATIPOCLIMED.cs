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
    /// Classe referente a tabela PCTipocontrolevendatipoclimed
    /// </summary>
    [XmlType("PCTIPOCONTROLEVENDATIPOCLIMED")]
    public class PCTipocontrolevendatipoclimed : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOCONTROLEVENDA
        /// Coment�rio: C�digo Tipo Controle de Venda
        /// </summary>
        private decimal codtipocontrolevenda;
        [XmlElement(ElementName = "CODTIPOCONTROLEVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codtipocontrolevenda
        {
            get { return  codtipocontrolevenda; }
            set {  codtipocontrolevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCLIMED
        /// Coment�rio: Tipo de Cliente Ramo Medic.
        /// </summary>
        private string tipoclimed;
        [XmlElement(ElementName = "TIPOCLIMED", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Tipoclimed
        {
            get { return  tipoclimed; }
            set {  tipoclimed = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCTipocontrolevendatipoclimed()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOCONTROLEVENDATIPOCLIMED";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCTipocontrolevendatipoclimed> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipocontrolevendatipoclimed>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCTipocontrolevendatipoclimed> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipocontrolevendatipoclimed>(where);
        }

        #endregion
    }
}
