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
    /// Classe referente a tabela PCCentrocusto
    /// </summary>
    [XmlType("PCCENTROCUSTO")]
    public class PCCentrocusto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Coment�rio: Indica se o N�vel do Centro de custos est� ativo.
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCENTROCUSTO
        /// Coment�rio: 
        /// </summary>
        private decimal codcentrocusto;
        [XmlElement(ElementName = "CODCENTROCUSTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codcentrocusto
        {
            get { return  codcentrocusto; }
            set {  codcentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCENTROCUSTOAUX
        /// Coment�rio: 
        /// </summary>
        private string codcentrocustoaux;
        [XmlElement(ElementName = "CODCENTROCUSTOAUX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codcentrocustoaux
        {
            get { return  codcentrocustoaux; }
            set {  codcentrocustoaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOCENTROCUSTO
        /// Coment�rio: C�digo do centro de custo
        /// </summary>
        private string codigocentrocusto;
        [XmlElement(ElementName = "CODIGOCENTROCUSTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codigocentrocusto
        {
            get { return  codigocentrocusto; }
            set {  codigocentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOCENTROCUSTOINTFOLHA
        /// Coment�rio: C�d. Centro de Custo - RM
        /// </summary>
        private string codigocentrocustointfolha;
        [XmlElement(ElementName = "CODIGOCENTROCUSTOINTFOLHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codigocentrocustointfolha
        {
            get { return  codigocentrocustointfolha; }
            set {  codigocentrocustointfolha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o do Centro de Custo.
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
        /// Propriedade referente ao campo: RECEBE_LANCTO
        /// Coment�rio: Indica se o N�vel do Centro de custos recebe lan�amentos
        /// </summary>
        private string recebe_lancto;
        [XmlElement(ElementName = "RECEBE_LANCTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Recebe_Lancto
        {
            get { return  recebe_lancto; }
            set {  recebe_lancto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCentrocusto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCENTROCUSTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCentrocusto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCentrocusto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCentrocusto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCentrocusto>(where);
        }

        #endregion
    }
}
