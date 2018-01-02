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
    /// Classe referente a tabela PCCotacaosesii
    /// </summary>
    [XmlType("PCCOTACAOSESII")]
    public class PCCotacaosesii : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Comentário: Código de barras do item.
        /// </summary>
        private decimal codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOTACAO
        /// Comentário: Código da cotação.
        /// </summary>
        private decimal codcotacao;
        [XmlElement(ElementName = "CODCOTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codcotacao
        {
            get { return  codcotacao; }
            set {  codcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Codigo do produto.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDE
        /// Comentário: Qtde item na cotação.
        /// </summary>
        private decimal qtde;
        [XmlElement(ElementName = "QTDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtde
        {
            get { return  qtde; }
            set {  qtde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOTACAO
        /// Comentário: Valor de cotação do item.
        /// </summary>
        private decimal vlcotacao;
        [XmlElement(ElementName = "VLCOTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcotacao
        {
            get { return  vlcotacao; }
            set {  vlcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREFERENCIA
        /// Comentário: Valor de referência do item.
        /// </summary>
        private decimal vlreferencia;
        [XmlElement(ElementName = "VLREFERENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlreferencia
        {
            get { return  vlreferencia; }
            set {  vlreferencia = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCotacaosesii()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTACAOSESII";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCotacaosesii> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotacaosesii>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCotacaosesii> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotacaosesii>(where);
        }

        #endregion
    }
}
