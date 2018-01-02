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
    /// Classe referente ao select VWCupomFiscal
    /// </summary>
    [XmlType("VWCUPOMFISCAL")] 
    public class VWCupomFiscal: OracleSelect
    {
        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public VWCupomFiscal()
        {
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<VWCupomFiscal> Listar(string where)
        {
            //string filtro = where.ToUpper().Replace("ROWID", "OID");
            Persistencia ba = new Persistencia(VWCupomFiscal.GetStringConnection());
            return ba.Listar<VWCupomFiscal>(GetSelect(), where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<VWCupomFiscal> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(VWCupomFiscal.GetStringConnection());
            return ba.Existe<VWCupomFiscal>(where);
        }

        /// <summary>
        /// Retorna o select de obteção dos registros
        /// </summary>
        public static string GetSelect()
        {
            return @"SELECT B.*
                       FROM ESV_CUPOM_GSGRUP B
                      WHERE 1=1";
        }
        #endregion

        #region Atributos
        /// <summary>
        /// Propriedade referente ao campo: CNPJCPF
        /// Comentário: 
        /// </summary>
        private string cnpjcpf;
        [XmlElement(ElementName = "CNPJCPF", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 14)]
        public string CnpjCpf
        {
            get { return cnpjcpf; }
            set { cnpjcpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGSGROUP
        /// Comentário: 
        /// </summary>
        private string codgsgroup;
        [XmlElement(ElementName = "CODGSGROUP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 14)]
        public string CodGSGroup
        {
            get { return codgsgroup; }
            set { codgsgroup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCUMENTO
        /// Comentário: 
        /// </summary>
        private string documento;
        [XmlElement(ElementName = "DOCUMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 14)]
        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Comentário: 
        /// </summary>
        private decimal numcupom;
        [XmlElement(ElementName = "NUMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 60)]
        public decimal Numcupom
        {
            get { return numcupom; }
            set { numcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 60)]
        public decimal Codplpag
        {
            get { return codplpag; }
            set { codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 10)]
        public decimal Numtransvenda
        {
            get { return numtransvenda; }
            set { numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORA
        /// Comentário: 
        /// </summary>
        private string datahora;
        [XmlElement(ElementName = "DATAHORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Datahora
        {
            get { return datahora; }
            set { datahora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAATUAL
        /// Comentário: 
        /// </summary>
        private string dataatual;
        [XmlElement(ElementName = "DATAATUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 10)]
        public string Dataatual
        {
            get { return dataatual; }
            set { dataatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PDV
        /// Comentário: 
        /// </summary>
        private string pdv;
        [XmlElement(ElementName = "PDV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string PDV
        {
            get { return pdv; }
            set { pdv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHASH
        /// Comentário: 
        /// </summary>
        private string codhash;
        [XmlElement(ElementName = "CODHASH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 100)]
        public string Codhash
        {
            get { return codhash; }
            set { codhash = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private decimal codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Codfilial
        {
            get { return codfilial; }
            set { codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CATEGORIAPRODUTO
        /// Comentário: 
        /// </summary>
        private decimal categoriaproduto;
        [XmlElement(ElementName = "CATEGORIAPRODUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Categoriaproduto
        {
            get { return categoriaproduto; }
            set { categoriaproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false, false, true, 22)]
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        #endregion
    }
}
