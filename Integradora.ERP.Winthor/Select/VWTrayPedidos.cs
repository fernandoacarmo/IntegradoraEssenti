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
    [XmlType("VWTRAYPEDIDOS")]
    public class VWTrayPedidos : OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWTrayPedidos()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWTrayPedidos> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWTrayPedidos.GetStringConnection());
            return ba.Listar<VWTrayPedidos>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWTrayPedidos> Listar()
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
                                       FROM VWTRAYPEDIDOS B
                                      WHERE 1=1 ");

            return script;
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: ROWID da tabela PCPEDC
        /// Comentário: 
        /// </summary>
        private string rid;
        [XmlElement(ElementName = "RID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 10)]
        public string RId
        {
            get { return rid; }
            set { rid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: data de emissao da nota fiscal
        /// Comentário: 
        /// </summary>
        private string issue_date;
        [XmlElement(ElementName = "ISSUE_DATE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 10)]
        public string Issue_Date
        {
            get { return issue_date; }
            set { issue_date = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numpedweb;
        [XmlElement(ElementName = "NUMPEDWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal Numpedweb
        {
            get { return numpedweb; }
            set { numpedweb = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal NumNota
        {
            get { return numnota; }
            set { numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 4)]
        public string Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: valornotafiscal
        /// Comentário: 
        /// </summary>
        private decimal valornotafiscal;
        [XmlElement(ElementName = "VALORNOTAFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public decimal ValorNotaFiscal
        {
            get { return valornotafiscal; }
            set { valornotafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: chavenfe
        /// Comentário: 
        /// </summary>
        private string chavenfe;
        [XmlElement(ElementName = "CHAVENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string ChaveNFE
        {
            get { return chavenfe; }
            set { chavenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: linknfe
        /// Comentário: 
        /// </summary>
        private string linknfe;
        [XmlElement(ElementName = "LINKNFE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 100)]
        public string LinkNFE
        {
            get { return linknfe; }
            set { linknfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: XMLNFE
        /// Comentário: 
        /// </summary>
        private string xmlnfe;
        [XmlElement(ElementName = "XMLNFE", DataType = "CLOB", IsNullable = false)]
        [DataObjectField(false, false, false, 0)]
        public string XMLNfe
        {
            get { return xmlnfe; }
            set { xmlnfe = value; }
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

