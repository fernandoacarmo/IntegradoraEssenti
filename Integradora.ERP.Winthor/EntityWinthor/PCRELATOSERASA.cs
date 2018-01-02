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
    /// Classe referente a tabela PCRelatoserasa
    /// </summary>
    [XmlType("PCRELATOSERASA")]
    public class PCRelatoserasa : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CNPJ
        /// Comentário: Indica o número do CNPJ do cliente.
        /// </summary>
        private string cnpj;
        [XmlElement(ElementName = "CNPJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cnpj
        {
            get { return  cnpj; }
            set {  cnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAATUAL
        /// Comentário: Indica a data atual.
        /// </summary>
        private DateTime? dataatual;
        [XmlElement(ElementName = "DATAATUAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataatual
        {
            get { return  dataatual; }
            set {  dataatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDLINHA
        /// Comentário: Indica a identificação do tipop de informação.
        /// </summary>
        private string idlinha;
        [XmlElement(ElementName = "IDLINHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Idlinha
        {
            get { return  idlinha; }
            set {  idlinha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LINHA
        /// Comentário: Dados da movimentação do cliente.
        /// </summary>
        private string linha;
        [XmlElement(ElementName = "LINHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Linha
        {
            get { return  linha; }
            set {  linha = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRelatoserasa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRELATOSERASA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRelatoserasa> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRelatoserasa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRelatoserasa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRelatoserasa>(where);
        }

        #endregion
    }
}
