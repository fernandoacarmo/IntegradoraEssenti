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
        /// Coment�rio: C�d. Cont�bil da nota de produ��o
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
        /// Coment�rio: C�d. Cont�bil da nota de entrada
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
        /// Coment�rio: Data da produ��o
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
        /// Coment�rio: Numtransent da nota de produ��o
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
        /// Coment�rio: Numtransent da nota de entrada
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
        /// Coment�rio: n�mero da transa��o de venda para onde foi destinado o estoque
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
        /// Coment�rio: n�mero da transa��o de venda que gerou a movimenta��o de estoque
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdautoboicasado> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdautoboicasado>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
