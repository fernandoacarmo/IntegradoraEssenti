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
    /// Classe referente a tabela PCInutilizacaonfe
    /// </summary>
    [XmlType("PCINUTILIZACAONFE")]
    public class PCInutilizacaonfe : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTE
        /// Comentário: Indica o ambiente de inutilização.
        /// </summary>
        private string ambiente;
        [XmlElement(ElementName = "AMBIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambiente
        {
            get { return  ambiente; }
            set {  ambiente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Indica o ano do número de inutilização.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica o código da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIO
        /// Comentário: Indica o código do usuário de inutilização.
        /// </summary>
        private decimal codusuario;
        [XmlElement(ElementName = "CODUSUARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuario
        {
            get { return  codusuario; }
            set {  codusuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHORAPROCESSAMENTO
        /// Comentário: Indica a data do processamento do pedido.
        /// </summary>
        private DateTime? dthoraprocessamento;
        [XmlElement(ElementName = "DTHORAPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoraprocessamento
        {
            get { return  dthoraprocessamento; }
            set {  dthoraprocessamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: JUSTIFICATIVA
        /// Comentário: Indica a justificativa da inutilizacao.
        /// </summary>
        private string justificativa;
        [XmlElement(ElementName = "JUSTIFICATIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,256)]
        public string Justificativa
        {
            get { return  justificativa; }
            set {  justificativa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAFINAL
        /// Comentário: Indica o número final de inutilização.
        /// </summary>
        private decimal numnotafinal;
        [XmlElement(ElementName = "NUMNOTAFINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numnotafinal
        {
            get { return  numnotafinal; }
            set {  numnotafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTAINICIAL
        /// Comentário: Indica o número inicial de inutilização.
        /// </summary>
        private decimal numnotainicial;
        [XmlElement(ElementName = "NUMNOTAINICIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numnotainicial
        {
            get { return  numnotainicial; }
            set {  numnotainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOINUTILIZACAO
        /// Comentário: Indica protocolo de inutilização.
        /// </summary>
        private string protocoloinutilizacao;
        [XmlElement(ElementName = "PROTOCOLOINUTILIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocoloinutilizacao
        {
            get { return  protocoloinutilizacao; }
            set {  protocoloinutilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: Indica o série do número da nota.
        /// </summary>
        private decimal serie;
        [XmlElement(ElementName = "SERIE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInutilizacaonfe()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINUTILIZACAONFE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInutilizacaonfe> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInutilizacaonfe>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInutilizacaonfe> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInutilizacaonfe>(where);
        }

        #endregion
    }
}
