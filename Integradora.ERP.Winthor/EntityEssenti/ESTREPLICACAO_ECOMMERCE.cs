using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela Estreplicacao_Ecommerce
    /// </summary>
    [XmlType("ESTREPLICACAO_ECOMMERCE")]
    public class Estreplicacao_Ecommerce : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACAO
        /// Comentário: 
        /// </summary>
        private decimal acao;
        [XmlElement(ElementName = "ACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 2)]
        public decimal Acao
        {
            get { return acao; }
            set { acao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true, false, false, 7)]
        public DateTime? Dtinclusao
        {
            get { return dtinclusao; }
            set { dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREPLICACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtreplicacao;
        [XmlElement(ElementName = "DTREPLICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtreplicacao
        {
            get { return dtreplicacao; }
            set { dtreplicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREPLICACAOWMS
        /// Comentário: 
        /// </summary>
        private DateTime? dtreplicacaoWMS;
        [XmlElement(ElementName = "DTREPLICACAOWMS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? DtreplicacaoWMS
        {
            get { return dtreplicacaoWMS; }
            set { dtreplicacaoWMS = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: 
        /// </summary>
        private string id;
        [XmlElement(ElementName = "ID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Comentário: 
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true, false, false, 50)]
        public string Tabela
        {
            get { return tabela; }
            set { tabela = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Estreplicacao_Ecommerce()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTREPLICACAO_ECOMMERCE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Estreplicacao_Ecommerce> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<Estreplicacao_Ecommerce>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Estreplicacao_Ecommerce> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<Estreplicacao_Ecommerce>(where);
        }

        #endregion
    }
}
