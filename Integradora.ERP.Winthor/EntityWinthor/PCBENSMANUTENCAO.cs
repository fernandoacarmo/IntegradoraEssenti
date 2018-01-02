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
        /// Coment�rio: Indica o c�digo da filial.
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
        /// Coment�rio: Indica o c�digo da manuten��o.
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
        /// Coment�rio: Indica o c�digo do bem.
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
        /// Coment�rio: Indica a data da previsao de retorno da manuten��o.
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
        /// Coment�rio: Indica a data do retorno da manuten��o.
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
        /// Coment�rio: Indica a data da saida para manuten��o.
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
        /// Coment�rio: Indica a descricao manuten��o.
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
        /// Coment�rio: Indica o local da manuten��o.
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
        /// Coment�rio: Indica o n�mero da ordem de servi�o.
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
        /// Coment�rio: Indica o n�mero da transa��o.
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
        /// Coment�rio: Indica o responsavel pela manuten��o.
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
        /// Coment�rio: Sequ�ncia do bem individualizado.
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
        /// Coment�rio: Indica se suspende bem durante a manuten��o.
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
        /// Coment�rio: Indica o tipo da transa��o.
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCBensmanutencao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBensmanutencao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
