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
    /// Classe referente a tabela PCXmlinutilizadas
    /// </summary>
    [XmlType("PCXMLINUTILIZADAS")]
    public class PCXmlinutilizadas : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CNPJ
        /// Comentário: CNPJ da filial.
        /// </summary>
        private string cnpj;
        [XmlElement(ElementName = "CNPJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cnpj
        {
            get { return  cnpj; }
            set {  cnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAFINAL
        /// Comentário: Número Nota Final.
        /// </summary>
        private decimal numnotafinal;
        [XmlElement(ElementName = "NUMNOTAFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotafinal
        {
            get { return  numnotafinal; }
            set {  numnotafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAINICIAL
        /// Comentário: Número Nota inicial.
        /// </summary>
        private decimal numnotainicial;
        [XmlElement(ElementName = "NUMNOTAINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotainicial
        {
            get { return  numnotainicial; }
            set {  numnotainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLINUT
        /// Comentário: XML de inutilização.
        /// </summary>
        private string xmlinut;
        [XmlElement(ElementName = "XMLINUT", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Xmlinut
        {
            get { return  xmlinut; }
            set {  xmlinut = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCXmlinutilizadas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCXMLINUTILIZADAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCXmlinutilizadas> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCXmlinutilizadas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCXmlinutilizadas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCXmlinutilizadas>(where);
        }

        #endregion
    }
}
