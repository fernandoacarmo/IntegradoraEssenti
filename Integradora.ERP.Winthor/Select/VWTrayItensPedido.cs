using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.Select
{
    /// <summary>
    /// Classe referente ao select VWTrayPedidos
    /// </summary>
    [XmlType("VWTRAYITENSPEDIDOS")]
    public class VWTrayItensPedidos : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWTrayItensPedidos()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWTrayItensPedidos> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWTrayItensPedidos.GetStringConnection());
            return ba.Listar<VWTrayItensPedidos>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWTrayItensPedidos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWTrayPedidos.GetStringConnection());
            return ba.Existe<VWTrayPedidos>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            string script = "";

            script = string.Format(@"SELECT B.* 
                                       FROM VWTRAYITENSPEDIDOS B
                                      WHERE 1=1 ");

            return script;
        }
        #endregion

        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: product_id
        /// Comentário: 
        /// </summary>
        private decimal product_id;
        [XmlElement(ElementName = "PRODUCT_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Product_ID
        {
            get { return product_id; }
            set { product_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: variation_id
        /// Comentário: 
        /// </summary>
        private decimal variation_id;
        [XmlElement(ElementName = "VARIATION_ID", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Variation_ID
        {
            get { return variation_id; }
            set { variation_id = value; }
        }


        /// <summary>
        /// Propriedade referente ao campo: CFOP
        /// Comentário: 
        /// </summary>
        private decimal cfop;
        [XmlElement(ElementName = "CFOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal CFOP
        {
            get { return cfop; }
            set { cfop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public decimal Numtransvenda
        {
            get { return numtransvenda; }
            set { numtransvenda = value; }
        }

        #endregion
    }

}

