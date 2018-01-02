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
    /// Classe referente a tabela PCContratocambio
    /// </summary>
    [XmlType("PCCONTRATOCAMBIO")]
    public class PCContratocambio : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Código do banco
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCORRETORA
        /// Comentário: Código da corretora de cãmbio
        /// </summary>
        private decimal codcorretora;
        [XmlElement(ElementName = "CODCORRETORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcorretora
        {
            get { return  codcorretora; }
            set {  codcorretora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código do fornecedor que vai receber o pagamento.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANC
        /// Comentário: Data de cancelamento do contrato de câmbio
        /// </summary>
        private DateTime? dtcanc;
        [XmlElement(ElementName = "DTCANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcanc
        {
            get { return  dtcanc; }
            set {  dtcanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONTRATO
        /// Comentário: Data do contrato de câmbio
        /// </summary>
        private DateTime? dtcontrato;
        [XmlElement(ElementName = "DTCONTRATO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcontrato
        {
            get { return  dtcontrato; }
            set {  dtcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVLIQUIDACAO
        /// Comentário: Data prevista para liquidação
        /// </summary>
        private DateTime? dtprevliquidacao;
        [XmlElement(ElementName = "DTPREVLIQUIDACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevliquidacao
        {
            get { return  dtprevliquidacao; }
            set {  dtprevliquidacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IBANC
        /// Comentário: Código iBanc da banco destinado para deposito.
        /// </summary>
        private string ibanc;
        [XmlElement(ElementName = "IBANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ibanc
        {
            get { return  ibanc; }
            set {  ibanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDAESTRANGEIRA
        /// Comentário: Código da moeda estrangeira
        /// </summary>
        private decimal moedaestrangeira;
        [XmlElement(ElementName = "MOEDAESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Moedaestrangeira
        {
            get { return  moedaestrangeira; }
            set {  moedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATO
        /// Comentário: Número do contrato de câmbio
        /// </summary>
        private string numcontrato;
        [XmlElement(ElementName = "NUMCONTRATO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Numcontrato
        {
            get { return  numcontrato; }
            set {  numcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observações
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRACA
        /// Comentário: Identificação da praça
        /// </summary>
        private string praca;
        [XmlElement(ElementName = "PRACA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Praca
        {
            get { return  praca; }
            set {  praca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTRATO
        /// Comentário: Tipo do contrato
        /// </summary>
        private decimal tipocontrato;
        [XmlElement(ElementName = "TIPOCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tipocontrato
        {
            get { return  tipocontrato; }
            set {  tipocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXCAMBIO
        /// Comentário: Taxa de câmbio
        /// </summary>
        private decimal txcambio;
        [XmlElement(ElementName = "TXCAMBIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Txcambio
        {
            get { return  txcambio; }
            set {  txcambio = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCContratocambio()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTRATOCAMBIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCContratocambio> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContratocambio>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCContratocambio> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContratocambio>(where);
        }

        #endregion
    }
}
