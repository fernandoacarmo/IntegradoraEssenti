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
    /// Classe referente a tabela PCForneccotacao
    /// </summary>
    [XmlType("PCFORNECCOTACAO")]
    public class PCForneccotacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: Indica o c�digo do fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCELA
        /// Coment�rio: C�digo de prazo de pagamento cadastro pela rotina 256
        /// </summary>
        private decimal codparcela;
        [XmlElement(ElementName = "CODPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codparcela
        {
            get { return  codparcela; }
            set {  codparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOTACAO
        /// Coment�rio: Indica o n�mero da cota��o.
        /// </summary>
        private decimal numcotacao;
        [XmlElement(ElementName = "NUMCOTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcotacao
        {
            get { return  numcotacao; }
            set {  numcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Situa��o da cota��o A-aberta ou F-fechada.
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCForneccotacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFORNECCOTACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCForneccotacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCForneccotacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCForneccotacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCForneccotacao>(where);
        }

        #endregion
    }
}
