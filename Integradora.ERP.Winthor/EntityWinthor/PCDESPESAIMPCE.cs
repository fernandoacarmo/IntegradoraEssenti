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
    /// Classe referente a tabela PCDespesaimpce
    /// </summary>
    [XmlType("PCDESPESAIMPCE")]
    public class PCDespesaimpce : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: C�digo do banco conta vale pendente
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESPESA
        /// Coment�rio: C�digo da despesa de importa��o
        /// </summary>
        private decimal coddespesa;
        [XmlElement(ElementName = "CODDESPESA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Coddespesa
        {
            get { return  coddespesa; }
            set {  coddespesa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do fornecedor.
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
        /// Propriedade referente ao campo: CODHIST
        /// Coment�rio: C�digo do historico da despesa
        /// </summary>
        private decimal codhist;
        [XmlElement(ElementName = "CODHIST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codhist
        {
            get { return  codhist; }
            set {  codhist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDACUSTO
        /// Coment�rio: C�digo da moeda estrangeira
        /// </summary>
        private decimal codmoedacusto;
        [XmlElement(ElementName = "CODMOEDACUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmoedacusto
        {
            get { return  codmoedacusto; }
            set {  codmoedacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDADI
        /// Coment�rio: C�digo da moeda estrangeira
        /// </summary>
        private decimal codmoedadi;
        [XmlElement(ElementName = "CODMOEDADI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmoedadi
        {
            get { return  codmoedadi; }
            set {  codmoedadi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOTACAOCUSTO
        /// Coment�rio: Data da cota��o moeda estrageira
        /// </summary>
        private DateTime? dtcotacaocusto;
        [XmlElement(ElementName = "DTCOTACAOCUSTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcotacaocusto
        {
            get { return  dtcotacaocusto; }
            set {  dtcotacaocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOTACAODI
        /// Coment�rio: Data da cota��o moeda estrageira
        /// </summary>
        private DateTime? dtcotacaodi;
        [XmlElement(ElementName = "DTCOTACAODI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcotacaodi
        {
            get { return  dtcotacaodi; }
            set {  dtcotacaodi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: Data de vencimento do lan�amento
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCONTROLEEMBARQUE
        /// Coment�rio: Identifica��o do controle de embarque.
        /// </summary>
        private string idcontroleembarque;
        [XmlElement(ElementName = "IDCONTROLEEMBARQUE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Idcontroleembarque
        {
            get { return  idcontroleembarque; }
            set {  idcontroleembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDAESTRANGEIRA
        /// Coment�rio: Informa se a despesa � em moeda estrangeira
        /// </summary>
        private string moedaestrangeira;
        [XmlElement(ElementName = "MOEDAESTRANGEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Moedaestrangeira
        {
            get { return  moedaestrangeira; }
            set {  moedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOCUMENTO
        /// Coment�rio: N�mero de documento de despesa importa��o
        /// </summary>
        private string numdocumento;
        [XmlElement(ElementName = "NUMDOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numdocumento
        {
            get { return  numdocumento; }
            set {  numdocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: N�mero do documento fiscal
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: N�mero do pedido de compra
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM
        /// Coment�rio: N�mero do lan�amento na tabela PCLANC
        /// </summary>
        private decimal recnum;
        [XmlElement(ElementName = "RECNUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnum
        {
            get { return  recnum; }
            set {  recnum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALE
        /// Coment�rio: Vale
        /// </summary>
        private string vale;
        [XmlElement(ElementName = "VALE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Vale
        {
            get { return  vale; }
            set {  vale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor da despesa
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFISCAL
        /// Coment�rio: Valor fiscal da despesa calculado na DI
        /// </summary>
        private decimal valorfiscal;
        [XmlElement(ElementName = "VALORFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorfiscal
        {
            get { return  valorfiscal; }
            set {  valorfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOTACAO
        /// Coment�rio: Cota��o da moeda da despesa na DI
        /// </summary>
        private decimal vlcotacao;
        [XmlElement(ElementName = "VLCOTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcotacao
        {
            get { return  vlcotacao; }
            set {  vlcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOTACAOCUSTO
        /// Coment�rio: Cota��o custo fiscal
        /// </summary>
        private decimal vlcotacaocusto;
        [XmlElement(ElementName = "VLCOTACAOCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcotacaocusto
        {
            get { return  vlcotacaocusto; }
            set {  vlcotacaocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPESA
        /// Coment�rio: Valor da despesa em moeda da DI
        /// </summary>
        private decimal vldespesa;
        [XmlElement(ElementName = "VLDESPESA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespesa
        {
            get { return  vldespesa; }
            set {  vldespesa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREALIZADO
        /// Coment�rio: Valor realizado
        /// </summary>
        private decimal vlrealizado;
        [XmlElement(ElementName = "VLREALIZADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlrealizado
        {
            get { return  vlrealizado; }
            set {  vlrealizado = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDespesaimpce()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESPESAIMPCE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDespesaimpce> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDespesaimpce>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDespesaimpce> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDespesaimpce>(where);
        }

        #endregion
    }
}
