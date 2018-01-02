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
    /// Classe referente a tabela PCPrecocestai
    /// </summary>
    [XmlType("PCPRECOCESTAI")]
    public class PCPrecocestai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial vinculada a este preço.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRECOCESTA
        /// Comentário: Indica o código do preço da cesta.
        /// </summary>
        private decimal codprecocesta;
        [XmlElement(ElementName = "CODPRECOCESTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codprecocesta
        {
            get { return  codprecocesta; }
            set {  codprecocesta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODACAB
        /// Comentário: Indica o código do produto acabado.
        /// </summary>
        private decimal codprodacab;
        [XmlElement(ElementName = "CODPRODACAB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodacab
        {
            get { return  codprodacab; }
            set {  codprodacab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODMP
        /// Comentário: Indica o código do produto matéria-prima.
        /// </summary>
        private decimal codprodmp;
        [XmlElement(ElementName = "CODPRODMP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodmp
        {
            get { return  codprodmp; }
            set {  codprodmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: Percentual de desconto concedido em uma embalagem da cesta ou kit. Este percentual será aplicado ao preço da embalagem vigente no momento da venda.
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFIXO
        /// Comentário: Indica o preço fixo.
        /// </summary>
        private decimal precofixo;
        [XmlElement(ElementName = "PRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precofixo
        {
            get { return  precofixo; }
            set {  precofixo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPrecocestai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRECOCESTAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPrecocestai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrecocestai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPrecocestai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrecocestai>(where);
        }

        #endregion
    }
}
