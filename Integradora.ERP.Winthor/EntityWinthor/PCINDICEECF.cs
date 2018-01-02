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
    /// Classe referente a tabela PCIndiceecf
    /// </summary>
    [XmlType("PCINDICEECF")]
    public class PCIndiceecf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODECF
        /// Coment�rio: Indica o c�digo ECF.
        /// </summary>
        private string codecf;
        [XmlElement(ElementName = "CODECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codecf
        {
            get { return  codecf; }
            set {  codecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICE
        /// Coment�rio: Indica o �ndice.
        /// </summary>
        private string indice;
        [XmlElement(ElementName = "INDICE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Indice
        {
            get { return  indice; }
            set {  indice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: Indica o n�mero do caixa.
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCIndiceecf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINDICEECF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCIndiceecf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIndiceecf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCIndiceecf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIndiceecf>(where);
        }

        #endregion
    }
}
