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
    /// Classe referente a tabela PCMetanestle
    /// </summary>
    [XmlType("PCMETANESTLE")]
    public class PCMetanestle : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica o código da filial.
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
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Indica o código do vendedor.
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Indica a data da meta a ser cumprida.
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCOBERTURA
        /// Comentário: Indica a quantidade prevista de clientes cobertos.
        /// </summary>
        private decimal qtcobertura;
        [XmlElement(ElementName = "QTCOBERTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtcobertura
        {
            get { return  qtcobertura; }
            set {  qtcobertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPOSITIVACAO
        /// Comentário: Indica a quantidade prevista de clientes positivados.
        /// </summary>
        private decimal qtpositivacao;
        [XmlElement(ElementName = "QTPOSITIVACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtpositivacao
        {
            get { return  qtpositivacao; }
            set {  qtpositivacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPROSPECCAO
        /// Comentário: Indica a quantidade prevista prospecção de novos clientes.
        /// </summary>
        private decimal qtprospeccao;
        [XmlElement(ElementName = "QTPROSPECCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtprospeccao
        {
            get { return  qtprospeccao; }
            set {  qtprospeccao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPROSPECCAOFINAL
        /// Comentário: Indica o objetivo de clientes a prospectar.
        /// </summary>
        private decimal qtprospeccaofinal;
        [XmlElement(ElementName = "QTPROSPECCAOFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtprospeccaofinal
        {
            get { return  qtprospeccaofinal; }
            set {  qtprospeccaofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMETAMIXPILAR
        /// Comentário: Valor de meta para os produtos pertencentes a linha mix pilar
        /// </summary>
        private decimal vlmetamixpilar;
        [XmlElement(ElementName = "VLMETAMIXPILAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmetamixpilar
        {
            get { return  vlmetamixpilar; }
            set {  vlmetamixpilar = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMetanestle()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETANESTLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMetanestle> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetanestle>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMetanestle> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetanestle>(where);
        }

        #endregion
    }
}
