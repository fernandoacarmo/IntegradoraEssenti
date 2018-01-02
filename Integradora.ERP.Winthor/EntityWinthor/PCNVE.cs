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
    /// Classe referente a tabela PCNve
    /// </summary>
    [XmlType("PCNVE")]
    public class PCNve : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODATRIBUTO
        /// Comentário: Código do atributo
        /// </summary>
        private string codatributo;
        [XmlElement(ElementName = "CODATRIBUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codatributo
        {
            get { return  codatributo; }
            set {  codatributo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESPECIFICACAO
        /// Comentário: Código da especificação
        /// </summary>
        private string codespecificacao;
        [XmlElement(ElementName = "CODESPECIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codespecificacao
        {
            get { return  codespecificacao; }
            set {  codespecificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNIVEL
        /// Comentário: Nível
        /// </summary>
        private string codnivel;
        [XmlElement(ElementName = "CODNIVEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codnivel
        {
            get { return  codnivel; }
            set {  codnivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNVE
        /// Comentário: Código NVE (NCM)
        /// </summary>
        private string codnve;
        [XmlElement(ElementName = "CODNVE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Codnve
        {
            get { return  codnve; }
            set {  codnve = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do produto
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
        /// Propriedade referente ao campo: DESCATRIBUTO
        /// Comentário: Descrição do atributo
        /// </summary>
        private string descatributo;
        [XmlElement(ElementName = "DESCATRIBUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descatributo
        {
            get { return  descatributo; }
            set {  descatributo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCESPECIFICACAO
        /// Comentário: Descrição da especificação
        /// </summary>
        private string descespecificacao;
        [XmlElement(ElementName = "DESCESPECIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descespecificacao
        {
            get { return  descespecificacao; }
            set {  descespecificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADENVE
        /// Comentário: Unidade de medida do NVE
        /// </summary>
        private string unidadenve;
        [XmlElement(ElementName = "UNIDADENVE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Unidadenve
        {
            get { return  unidadenve; }
            set {  unidadenve = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCNve()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNVE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNve> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNve>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCNve> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNve>(where);
        }

        #endregion
    }
}
