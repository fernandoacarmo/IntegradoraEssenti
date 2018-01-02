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
    /// Classe referente a tabela PCDescontorestricao
    /// </summary>
    [XmlType("PCDESCONTORESTRICAO")]
    public class PCDescontorestricao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Indica o código da campanha de desconto.
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOA
        /// Comentário: Indica o código alfanumérico de restrição.
        /// </summary>
        private string codigoa;
        [XmlElement(ElementName = "CODIGOA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Codigoa
        {
            get { return  codigoa; }
            set {  codigoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGON
        /// Comentário: Indica o código numérico de restrição.
        /// </summary>
        private decimal codigon;
        [XmlElement(ElementName = "CODIGON", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigon
        {
            get { return  codigon; }
            set {  codigon = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Indica o tipo da restrição de desconto: 1-FILIAL, 2-REGIÃO, 3-RAMO, 4-SUPERVISOR, 5-RCA, 6-CLIENTE, 7-DISTRIBUIÇÃO.
        /// </summary>
        private decimal tipo;
        [XmlElement(ElementName = "TIPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDescontorestricao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESCONTORESTRICAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDescontorestricao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDescontorestricao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDescontorestricao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDescontorestricao>(where);
        }

        #endregion
    }
}
