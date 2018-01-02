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
    /// Classe referente a tabela PCFornecobs
    /// </summary>
    [XmlType("PCFORNECOBS")]
    public class PCFornecobs : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código do fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDOBS
        /// Comentário: ID da observação.
        /// </summary>
        private decimal idobs;
        [XmlElement(ElementName = "IDOBS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Idobs
        {
            get { return  idobs; }
            set {  idobs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEXTO
        /// Comentário: Texto da obsersação.
        /// </summary>
        private string texto;
        [XmlElement(ElementName = "TEXTO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Texto
        {
            get { return  texto; }
            set {  texto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOBS
        /// Comentário: Tipo da observação.
        /// </summary>
        private string tipoobs;
        [XmlElement(ElementName = "TIPOOBS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,3)]
        public string Tipoobs
        {
            get { return  tipoobs; }
            set {  tipoobs = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFornecobs()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORNECOBS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFornecobs> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFornecobs>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFornecobs> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFornecobs>(where);
        }

        #endregion
    }
}
