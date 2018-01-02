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
    /// Classe referente a tabela PCFornecfv
    /// </summary>
    [XmlType("PCFORNECFV")]
    public class PCFornecfv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORNFV
        /// Comentário: 
        /// </summary>
        private decimal codfornfv;
        [XmlElement(ElementName = "CODFORNFV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornfv
        {
            get { return  codfornfv; }
            set {  codfornfv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DELIMITADOR
        /// Comentário: 
        /// </summary>
        private string delimitador;
        [XmlElement(ElementName = "DELIMITADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Delimitador
        {
            get { return  delimitador; }
            set {  delimitador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGSEPARADOR
        /// Comentário: 
        /// </summary>
        private string digseparador;
        [XmlElement(ElementName = "DIGSEPARADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Digseparador
        {
            get { return  digseparador; }
            set {  digseparador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIGUSURARQUIVO
        /// Comentário: 
        /// </summary>
        private decimal qtdigusurarquivo;
        [XmlElement(ElementName = "QTDIGUSURARQUIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtdigusurarquivo
        {
            get { return  qtdigusurarquivo; }
            set {  qtdigusurarquivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIGUSURPASTA
        /// Comentário: 
        /// </summary>
        private decimal qtdigusurpasta;
        [XmlElement(ElementName = "QTDIGUSURPASTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtdigusurpasta
        {
            get { return  qtdigusurpasta; }
            set {  qtdigusurpasta = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFornecfv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORNECFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFornecfv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFornecfv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFornecfv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFornecfv>(where);
        }

        #endregion
    }
}
