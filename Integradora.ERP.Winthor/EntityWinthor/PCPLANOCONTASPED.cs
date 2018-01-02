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
    /// Classe referente a tabela PCPlanocontasped
    /// </summary>
    [XmlType("PCPLANOCONTASPED")]
    public class PCPlanocontasped : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA_SPED
        /// Coment�rio: Indica o c�digo da conta SPED.
        /// </summary>
        private string codconta_sped;
        [XmlElement(ElementName = "CODCONTA_SPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codconta_Sped
        {
            get { return  codconta_sped; }
            set {  codconta_sped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA_SPED
        /// Coment�rio: Indica o c�digo do plano contas SPED.
        /// </summary>
        private decimal codplanoconta_sped;
        [XmlElement(ElementName = "CODPLANOCONTA_SPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public decimal Codplanoconta_Sped
        {
            get { return  codplanoconta_sped; }
            set {  codplanoconta_sped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Indica a descri��o da conta.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: Data final.
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Data inicial.
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIENTACOES
        /// Coment�rio: Indica a especifica��o sobre a utilizaade da conta.
        /// </summary>
        private string orientacoes;
        [XmlElement(ElementName = "ORIENTACOES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Orientacoes
        {
            get { return  orientacoes; }
            set {  orientacoes = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPlanocontasped()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPLANOCONTASPED";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPlanocontasped> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPlanocontasped>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPlanocontasped> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPlanocontasped>(where);
        }

        #endregion
    }
}
