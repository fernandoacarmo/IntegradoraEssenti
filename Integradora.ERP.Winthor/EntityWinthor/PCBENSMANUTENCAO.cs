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
    /// Classe referente a tabela PCBensmanutencao
    /// </summary>
    [XmlType("PCBENSMANUTENCAO")]
    public class PCBensmanutencao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica o código da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMANUTENCAO
        /// Comentário: Indica o código da manutenção.
        /// </summary>
        private decimal codmanutencao;
        [XmlElement(ElementName = "CODMANUTENCAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codmanutencao
        {
            get { return  codmanutencao; }
            set {  codmanutencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Indica o código do bem.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAPREVRETORNO
        /// Comentário: Indica a data da previsao de retorno da manutenção.
        /// </summary>
        private DateTime? dataprevretorno;
        [XmlElement(ElementName = "DATAPREVRETORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataprevretorno
        {
            get { return  dataprevretorno; }
            set {  dataprevretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATARETORNO
        /// Comentário: Indica a data do retorno da manutenção.
        /// </summary>
        private DateTime? dataretorno;
        [XmlElement(ElementName = "DATARETORNO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataretorno
        {
            get { return  dataretorno; }
            set {  dataretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATASAIDA
        /// Comentário: Indica a data da saida para manutenção.
        /// </summary>
        private DateTime? datasaida;
        [XmlElement(ElementName = "DATASAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datasaida
        {
            get { return  datasaida; }
            set {  datasaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCMANUTENCAO
        /// Comentário: Indica a descricao manutenção.
        /// </summary>
        private string descmanutencao;
        [XmlElement(ElementName = "DESCMANUTENCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descmanutencao
        {
            get { return  descmanutencao; }
            set {  descmanutencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALMANUTENCAO
        /// Comentário: Indica o local da manutenção.
        /// </summary>
        private string localmanutencao;
        [XmlElement(ElementName = "LOCALMANUTENCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Localmanutencao
        {
            get { return  localmanutencao; }
            set {  localmanutencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORDEMSERVICO
        /// Comentário: Indica o número da ordem de serviço.
        /// </summary>
        private string numordemservico;
        [XmlElement(ElementName = "NUMORDEMSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numordemservico
        {
            get { return  numordemservico; }
            set {  numordemservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: Indica o número da transação.
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESPMANUTENCAO
        /// Comentário: Indica o responsavel pela manutenção.
        /// </summary>
        private string respmanutencao;
        [XmlElement(ElementName = "RESPMANUTENCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Respmanutencao
        {
            get { return  respmanutencao; }
            set {  respmanutencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQBENSPATRIMONIAIS
        /// Comentário: Sequência do bem individualizado.
        /// </summary>
        private decimal seqbenspatrimoniais;
        [XmlElement(ElementName = "SEQBENSPATRIMONIAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Seqbenspatrimoniais
        {
            get { return  seqbenspatrimoniais; }
            set {  seqbenspatrimoniais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUSPBEMMANUTENCAO
        /// Comentário: Indica se suspende bem durante a manutenção.
        /// </summary>
        private string suspbemmanutencao;
        [XmlElement(ElementName = "SUSPBEMMANUTENCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Suspbemmanutencao
        {
            get { return  suspbemmanutencao; }
            set {  suspbemmanutencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRANSACAO
        /// Comentário: Indica o tipo da transação.
        /// </summary>
        private string tipotransacao;
        [XmlElement(ElementName = "TIPOTRANSACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipotransacao
        {
            get { return  tipotransacao; }
            set {  tipotransacao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBensmanutencao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBENSMANUTENCAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBensmanutencao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBensmanutencao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBensmanutencao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBensmanutencao>(where);
        }

        #endregion
    }
}
