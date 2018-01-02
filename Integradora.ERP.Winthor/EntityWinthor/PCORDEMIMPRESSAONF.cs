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
    /// Classe referente a tabela PCOrdemimpressaonf
    /// </summary>
    [XmlType("PCORDEMIMPRESSAONF")]
    public class PCOrdemimpressaonf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDOC
        /// Coment�rio: C�digo do documento informado na PCFILIAL.CODDOCNF.
        /// </summary>
        private decimal coddoc;
        [XmlElement(ElementName = "CODDOC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Coddoc
        {
            get { return  coddoc; }
            set {  coddoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Indica a descri��o.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Coment�rio: Ordem em que ser� impresso no DANF-e.
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SECAO
        /// Coment�rio: Indica a se��o.
        /// </summary>
        private string secao;
        [XmlElement(ElementName = "SECAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Secao
        {
            get { return  secao; }
            set {  secao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOrdemimpressaonf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORDEMIMPRESSAONF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOrdemimpressaonf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrdemimpressaonf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOrdemimpressaonf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrdemimpressaonf>(where);
        }

        #endregion
    }
}
