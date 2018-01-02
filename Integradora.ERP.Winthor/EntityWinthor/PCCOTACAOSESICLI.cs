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
    /// Classe referente a tabela PCCotacaosesicli
    /// </summary>
    [XmlType("PCCOTACAOSESICLI")]
    public class PCCotacaosesicli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APROVADO
        /// Comentário: Informa cliente aprovado ou não.
        /// </summary>
        private string aprovado;
        [XmlElement(ElementName = "APROVADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aprovado
        {
            get { return  aprovado; }
            set {  aprovado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ
        /// Comentário: CNPJ do cliente.
        /// </summary>
        private string cnpj;
        [XmlElement(ElementName = "CNPJ", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,14)]
        public string Cnpj
        {
            get { return  cnpj; }
            set {  cnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do cliente da cotação.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
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
        /// Propriedade referente ao campo: CODMOTIVO
        /// Comentário: Código do motivo.
        /// </summary>
        private decimal codmotivo;
        [XmlElement(ElementName = "CODMOTIVO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Codmotivo
        {
            get { return  codmotivo; }
            set {  codmotivo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCotacaosesicli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOTACAOSESICLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCotacaosesicli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCotacaosesicli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCotacaosesicli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCotacaosesicli>(where);
        }

        #endregion
    }
}
