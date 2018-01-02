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
    /// Classe referente a tabela PCPrestauxpedido
    /// </summary>
    [XmlType("PCPRESTAUXPEDIDO")]
    public class PCPrestauxpedido : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODADMCARTAO
        /// Comentário: CÓD. ADM CARTÃO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string codadmcartao;
        [XmlElement(ElementName = "CODADMCARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codadmcartao
        {
            get { return  codadmcartao; }
            set {  codadmcartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAOTEF
        /// Comentário: CÓD. AUTORIZAÇÃO TEF DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string codautorizacaotef;
        [XmlElement(ElementName = "CODAUTORIZACAOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Codautorizacaotef
        {
            get { return  codautorizacaotef; }
            set {  codautorizacaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANDEIRATEF
        /// Comentário: CÓD. DA BANDEIRA TEF DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string codbandeiratef;
        [XmlElement(ElementName = "CODBANDEIRATEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Codbandeiratef
        {
            get { return  codbandeiratef; }
            set {  codbandeiratef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: CÓD. CLIENTE DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: COBRANÇA DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: CÓD. FILIAL DA FORMA DE PAGAMENTO DO PEDIDO.
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
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: CÓD. FUNCIONÁRIO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUP
        /// Comentário: CÓD. DO SUPERVISOR DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal codsup;
        [XmlElement(ElementName = "CODSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsup
        {
            get { return  codsup; }
            set {  codsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEND
        /// Comentário: CÓD. DO VENDEDOR DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal codvend;
        [XmlElement(ElementName = "CODVEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codvend
        {
            get { return  codvend; }
            set {  codvend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: DATA DE EMISSÃO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHA
        /// Comentário: DATA DE FECHAMENTO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private DateTime? dtfecha;
        [XmlElement(ElementName = "DTFECHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecha
        {
            get { return  dtfecha; }
            set {  dtfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGO
        /// Comentário: DATA DE PAGAMENTO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private DateTime? dtpago;
        [XmlElement(ElementName = "DTPAGO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpago
        {
            get { return  dtpago; }
            set {  dtpago = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: DATA DE VENCIMENTO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMAPGTONOECF
        /// Comentário: FORMA DE PGTO NO ECF DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string formapgtonoecf;
        [XmlElement(ElementName = "FORMAPGTONOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Formapgtonoecf
        {
            get { return  formapgtonoecf; }
            set {  formapgtonoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUTEF
        /// Comentário: NSUTEF DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string nsutef;
        [XmlElement(ElementName = "NSUTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsutef
        {
            get { return  nsutef; }
            set {  nsutef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAG
        /// Comentário: NUM. DA AGÊNCIA DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal numag;
        [XmlElement(ElementName = "NUMAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numag
        {
            get { return  numag; }
            set {  numag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBCO
        /// Comentário: NUM. DO BANCO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal numbco;
        [XmlElement(ElementName = "NUMBCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbco
        {
            get { return  numbco; }
            set {  numbco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCH
        /// Comentário: NUM. DO CHEQUE DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal numch;
        [XmlElement(ElementName = "NUMCH", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numch
        {
            get { return  numch; }
            set {  numch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCX
        /// Comentário: NUM. DO CAIXA DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal numcx;
        [XmlElement(ElementName = "NUMCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcx
        {
            get { return  numcx; }
            set {  numcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: NUM. DA NOTA FISCAL DA FORMA DE PAGAMENTO DO PEDIDO.
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
        /// Propriedade referente ao campo: NUMORCA
        /// Comentário: NÚMERO DO ORÇAMENTO
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: NUM. DO PEDIDO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: OBS. DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELAMENTOTEF
        /// Comentário: PARCELAMENTO TEF DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string parcelamentotef;
        [XmlElement(ElementName = "PARCELAMENTOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Parcelamentotef
        {
            get { return  parcelamentotef; }
            set {  parcelamentotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Comentário: PERCENTUAL DE COMISSÃO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: NUM. DA PRESTAÇÃO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTTEF
        /// Comentário: PRESTAÇÃO DO TEF FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal presttef;
        [XmlElement(ElementName = "PRESTTEF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Presttef
        {
            get { return  presttef; }
            set {  presttef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPARCELAS
        /// Comentário: QT. PARCELAS DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal qtparcelas;
        [XmlElement(ElementName = "QTPARCELAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Qtparcelas
        {
            get { return  qtparcelas; }
            set {  qtparcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEF
        /// Comentário: TEF DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string tef;
        [XmlElement(ElementName = "TEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tef
        {
            get { return  tef; }
            set {  tef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOPERACAOTEF
        /// Comentário: TIPO OPERAÇÃO TEF DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private string tipooperacaotef;
        [XmlElement(ElementName = "TIPOOPERACAOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Tipooperacaotef
        {
            get { return  tipooperacaotef; }
            set {  tipooperacaotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: VALOR DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAUX
        /// Comentário: VALOR AUXILIAR DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal vlaux;
        [XmlElement(ElementName = "VLAUX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlaux
        {
            get { return  vlaux; }
            set {  vlaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Comentário: VALOR DO DESCONTO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLJURO
        /// Comentário: VALOR DOS JUROS DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal vljuro;
        [XmlElement(ElementName = "VLJURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vljuro
        {
            get { return  vljuro; }
            set {  vljuro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLIQCOM
        /// Comentário: VALOR LÍQUIDO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal vlliqcom;
        [XmlElement(ElementName = "VLLIQCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlliqcom
        {
            get { return  vlliqcom; }
            set {  vlliqcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTXBOLETO
        /// Comentário: TAXA DO BOLETO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal vltxboleto;
        [XmlElement(ElementName = "VLTXBOLETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltxboleto
        {
            get { return  vltxboleto; }
            set {  vltxboleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VPAGO
        /// Comentário: VALOR PAGO DA FORMA DE PAGAMENTO DO PEDIDO.
        /// </summary>
        private decimal vpago;
        [XmlElement(ElementName = "VPAGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vpago
        {
            get { return  vpago; }
            set {  vpago = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPrestauxpedido()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRESTAUXPEDIDO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPrestauxpedido> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPrestauxpedido>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPrestauxpedido> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPrestauxpedido>(where);
        }

        #endregion
    }
}
