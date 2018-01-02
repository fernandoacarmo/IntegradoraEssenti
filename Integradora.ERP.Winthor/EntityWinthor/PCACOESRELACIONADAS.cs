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
    /// Classe referente a tabela PCAcoesrelacionadas
    /// </summary>
    [XmlType("PCACOESRELACIONADAS")]
    public class PCAcoesrelacionadas : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Coment�rio: Informa se a a��o esta ativa ou n�o
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODACAORELACIONADA
        /// Coment�rio: C�digo da a��o relacionada
        /// </summary>
        private decimal codacaorelacionada;
        [XmlElement(ElementName = "CODACAORELACIONADA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,22)]
        public decimal Codacaorelacionada
        {
            get { return  codacaorelacionada; }
            set {  codacaorelacionada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: C�digo da rotina que utiliza esta a��o
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,22)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAEXECUTAR
        /// Coment�rio: C�digo da rotina que ser� executada na a��o
        /// </summary>
        private decimal codrotinaexecutar;
        [XmlElement(ElementName = "CODROTINAEXECUTAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Codrotinaexecutar
        {
            get { return  codrotinaexecutar; }
            set {  codrotinaexecutar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data de cadatro
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICE
        /// Coment�rio: �ndice para ordena��o de cria��o da a��o
        /// </summary>
        private decimal indice;
        [XmlElement(ElementName = "INDICE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Indice
        {
            get { return  indice; }
            set {  indice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARAMEXECUCAO
        /// Coment�rio: Par�metros para execu��o da rotina
        /// </summary>
        private string paramexecucao;
        [XmlElement(ElementName = "PARAMEXECUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Paramexecucao
        {
            get { return  paramexecucao; }
            set {  paramexecucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULOACAO
        /// Coment�rio: T�tulo do a��o
        /// </summary>
        private string tituloacao;
        [XmlElement(ElementName = "TITULOACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Tituloacao
        {
            get { return  tituloacao; }
            set {  tituloacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAcoesrelacionadas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCACOESRELACIONADAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAcoesrelacionadas> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAcoesrelacionadas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAcoesrelacionadas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAcoesrelacionadas>(where);
        }

        #endregion
    }
}
