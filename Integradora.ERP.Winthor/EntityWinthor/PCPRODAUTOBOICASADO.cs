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
    /// Classe referente a tabela PCProdautoboicasado
    /// </summary>
    [XmlType("PCPRODAUTOBOICASADO")]
    public class PCProdautoboicasado : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTDEST
        /// Comentário: Cód. Contábil da nota de produção
        /// </summary>
        private decimal codcontdest;
        [XmlElement(ElementName = "CODCONTDEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontdest
        {
            get { return  codcontdest; }
            set {  codcontdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTORIG
        /// Comentário: Cód. Contábil da nota de entrada
        /// </summary>
        private decimal codcontorig;
        [XmlElement(ElementName = "CODCONTORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontorig
        {
            get { return  codcontorig; }
            set {  codcontorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data da produção
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTDEST
        /// Comentário: Numtransent da nota de produção
        /// </summary>
        private decimal numtransentdest;
        [XmlElement(ElementName = "NUMTRANSENTDEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentdest
        {
            get { return  numtransentdest; }
            set {  numtransentdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTORIG
        /// Comentário: Numtransent da nota de entrada
        /// </summary>
        private decimal numtransentorig;
        [XmlElement(ElementName = "NUMTRANSENTORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentorig
        {
            get { return  numtransentorig; }
            set {  numtransentorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDADEST
        /// Comentário: número da transação de venda para onde foi destinado o estoque
        /// </summary>
        private decimal numtransvendadest;
        [XmlElement(ElementName = "NUMTRANSVENDADEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendadest
        {
            get { return  numtransvendadest; }
            set {  numtransvendadest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAORIG
        /// Comentário: número da transação de venda que gerou a movimentação de estoque
        /// </summary>
        private decimal numtransvendaorig;
        [XmlElement(ElementName = "NUMTRANSVENDAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaorig
        {
            get { return  numtransvendaorig; }
            set {  numtransvendaorig = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdautoboicasado()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODAUTOBOICASADO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdautoboicasado> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdautoboicasado>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdautoboicasado> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdautoboicasado>(where);
        }

        #endregion
    }
}
