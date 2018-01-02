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
    /// Classe referente a tabela PCBenssuspensos
    /// </summary>
    [XmlType("PCBENSSUSPENSOS")]
    public class PCBenssuspensos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica o codigo da filial.
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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Indica o codigo do bem.
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
        /// Propriedade referente ao campo: CODSUSPENSAO
        /// Comentário: Indica o código da suspensão.
        /// </summary>
        private decimal codsuspensao;
        [XmlElement(ElementName = "CODSUSPENSAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codsuspensao
        {
            get { return  codsuspensao; }
            set {  codsuspensao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFINAL
        /// Comentário: Indica a data final.
        /// </summary>
        private DateTime? datafinal;
        [XmlElement(ElementName = "DATAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafinal
        {
            get { return  datafinal; }
            set {  datafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIAL
        /// Comentário: Indica a data inicial.
        /// </summary>
        private DateTime? datainicial;
        [XmlElement(ElementName = "DATAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datainicial
        {
            get { return  datainicial; }
            set {  datainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERADOPORMANUTENCAO
        /// Comentário: Suspensão gerada por manutenção de bens.
        /// </summary>
        private string geradopormanutencao;
        [XmlElement(ElementName = "GERADOPORMANUTENCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geradopormanutencao
        {
            get { return  geradopormanutencao; }
            set {  geradopormanutencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: Indica o numero da transação.
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
        /// Propriedade referente ao campo: TIPOSUSPENSAO
        /// Comentário: Indica qual o tipo da suspensão do bem.
        /// </summary>
        private string tiposuspensao;
        [XmlElement(ElementName = "TIPOSUSPENSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tiposuspensao
        {
            get { return  tiposuspensao; }
            set {  tiposuspensao = value; }
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
        public PCBenssuspensos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBENSSUSPENSOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBenssuspensos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBenssuspensos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBenssuspensos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBenssuspensos>(where);
        }

        #endregion
    }
}
