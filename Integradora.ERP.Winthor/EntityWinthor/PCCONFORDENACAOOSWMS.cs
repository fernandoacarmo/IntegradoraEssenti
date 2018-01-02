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
    /// Classe referente a tabela PCConfordenacaooswms
    /// </summary>
    [XmlType("PCCONFORDENACAOOSWMS")]
    public class PCConfordenacaooswms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGRUPAMENTO
        /// Coment�rio: Agrupamento definito - v�rios
        /// </summary>
        private string agrupamento;
        [XmlElement(ElementName = "AGRUPAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Agrupamento
        {
            get { return  agrupamento; }
            set {  agrupamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODORDENACAO
        /// Coment�rio: C�digo da ordena��o
        /// </summary>
        private decimal codordenacao;
        [XmlElement(ElementName = "CODORDENACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codordenacao
        {
            get { return  codordenacao; }
            set {  codordenacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOS
        /// Coment�rio: C�digo do tipo da o.s.
        /// </summary>
        private decimal codos;
        [XmlElement(ElementName = "CODOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codos
        {
            get { return  codos; }
            set {  codos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Coment�rio: Tipo da opera��o - entrada/sa�da
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDERBY
        /// Coment�rio: Cl�usula order by final
        /// </summary>
        private string orderby;
        [XmlElement(ElementName = "ORDERBY", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Orderby
        {
            get { return  orderby; }
            set {  orderby = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_DOC
        /// Coment�rio: Tipo do documento - o.s./etiqueta
        /// </summary>
        private string tipo_doc;
        [XmlElement(ElementName = "TIPO_DOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo_Doc
        {
            get { return  tipo_doc; }
            set {  tipo_doc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCConfordenacaooswms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFORDENACAOOSWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConfordenacaooswms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConfordenacaooswms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCConfordenacaooswms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConfordenacaooswms>(where);
        }

        #endregion
    }
}
