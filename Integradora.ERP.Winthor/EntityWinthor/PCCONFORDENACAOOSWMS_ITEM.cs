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
    /// Classe referente a tabela PCConfordenacaooswms_item
    /// </summary>
    [XmlType("PCCONFORDENACAOOSWMS_ITEM")]
    public class PCConfordenacaooswms_item : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODORDENACAO
        /// Coment�rio: C�digo da ordena��o
        /// </summary>
        private decimal codordenacao;
        [XmlElement(ElementName = "CODORDENACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codordenacao
        {
            get { return  codordenacao; }
            set {  codordenacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODORDENACAOITENS
        /// Coment�rio: C�digo da ordena��o dos �tens
        /// </summary>
        private decimal codordenacaoitens;
        [XmlElement(ElementName = "CODORDENACAOITENS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codordenacaoitens
        {
            get { return  codordenacaoitens; }
            set {  codordenacaoitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Coment�rio: Sequencia dos valores
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_ORDENACAO
        /// Coment�rio: Tipo da ordena��o - o.s./�tens
        /// </summary>
        private string tipo_ordenacao;
        [XmlElement(ElementName = "TIPO_ORDENACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo_Ordenacao
        {
            get { return  tipo_ordenacao; }
            set {  tipo_ordenacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor do �tem
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCConfordenacaooswms_item()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFORDENACAOOSWMS_ITEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConfordenacaooswms_item> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConfordenacaooswms_item>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCConfordenacaooswms_item> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConfordenacaooswms_item>(where);
        }

        #endregion
    }
}
