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
    /// Classe referente a tabela PCBaixacartaoi
    /// </summary>
    [XmlType("PCBAIXACARTAOI")]
    public class PCBaixacartaoi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAO
        /// Comentário: Código da autorização do cartão
        /// </summary>
        private string codautorizacao;
        [XmlElement(ElementName = "CODAUTORIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Codautorizacao
        {
            get { return  codautorizacao; }
            set {  codautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIXACARTAO
        /// Comentário: Código do cabeçalho da baixa
        /// </summary>
        private decimal codbaixacartao;
        [XmlElement(ElementName = "CODBAIXACARTAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codbaixacartao
        {
            get { return  codbaixacartao; }
            set {  codbaixacartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIXAITEM
        /// Comentário: Código do item da baixa
        /// </summary>
        private decimal codbaixaitem;
        [XmlElement(ElementName = "CODBAIXAITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codbaixaitem
        {
            get { return  codbaixaitem; }
            set {  codbaixaitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Banco da baixa
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
        /// Propriedade referente ao campo: CODBANCOPREST
        /// Comentário: Banco que foi realizado a baixa
        /// </summary>
        private string codbancoprest;
        [XmlElement(ElementName = "CODBANCOPREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codbancoprest
        {
            get { return  codbancoprest; }
            set {  codbancoprest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANDEIRA
        /// Comentário: Código da bandeira do cartão
        /// </summary>
        private string codbandeira;
        [XmlElement(ElementName = "CODBANDEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codbandeira
        {
            get { return  codbandeira; }
            set {  codbandeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do cliente
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
        /// Propriedade referente ao campo: CODOPERADORA
        /// Comentário: Código da operadora
        /// </summary>
        private string codoperadora;
        [XmlElement(ElementName = "CODOPERADORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codoperadora
        {
            get { return  codoperadora; }
            set {  codoperadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDE
        /// Comentário: Código da rede
        /// </summary>
        private string codrede;
        [XmlElement(ElementName = "CODREDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codrede
        {
            get { return  codrede; }
            set {  codrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data da importação
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAANTECIPACAO
        /// Comentário: Data da antecipação do crédito
        /// </summary>
        private DateTime? dataantecipacao;
        [XmlElement(ElementName = "DATAANTECIPACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataantecipacao
        {
            get { return  dataantecipacao; }
            set {  dataantecipacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACREDITO
        /// Comentário: Data do crédito
        /// </summary>
        private DateTime? datacredito;
        [XmlElement(ElementName = "DATACREDITO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacredito
        {
            get { return  datacredito; }
            set {  datacredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBAIXA
        /// Comentário: Data da baixa dos títulos
        /// </summary>
        private DateTime? dtbaixa;
        [XmlElement(ElementName = "DTBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbaixa
        {
            get { return  dtbaixa; }
            set {  dtbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: Data da emissão da prestação
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
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: Data do vencimento da prestação
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
        /// Propriedade referente ao campo: DUPLIC
        /// Comentário: Duplicata da cobrança
        /// </summary>
        private string duplic;
        [XmlElement(ElementName = "DUPLIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Duplic
        {
            get { return  duplic; }
            set {  duplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEM
        /// Comentário: Campo indica o valor aceito na diferença durante a baixa automatica
        /// </summary>
        private decimal margem;
        [XmlElement(ElementName = "MARGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Margem
        {
            get { return  margem; }
            set {  margem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: Motivo da baixa
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Comentário: Nsu da Transação
        /// </summary>
        private string nsu;
        [XmlElement(ElementName = "NSU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUHOST
        /// Comentário: Nsu Host da Transação
        /// </summary>
        private string nsuhost;
        [XmlElement(ElementName = "NSUHOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsuhost
        {
            get { return  nsuhost; }
            set {  nsuhost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCARTAO
        /// Comentário: Número do cartão do cliente
        /// </summary>
        private string numcartao;
        [XmlElement(ElementName = "NUMCARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numcartao
        {
            get { return  numcartao; }
            set {  numcartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: Número do lote quando tem antecipação
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: Número da transação do lançamento do título
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Número da transação da venda
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELA
        /// Comentário: Parcela da cobrança
        /// </summary>
        private decimal parcela;
        [XmlElement(ElementName = "PARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Parcela
        {
            get { return  parcela; }
            set {  parcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: Prestação do título
        /// </summary>
        private decimal prest;
        [XmlElement(ElementName = "PREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: Situação da baixa
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Status da baixa
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA
        /// Comentário: Valor da taxa
        /// </summary>
        private decimal taxa;
        [XmlElement(ElementName = "TAXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Taxa
        {
            get { return  taxa; }
            set {  taxa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRODUTO
        /// Comentário: Tipo do produto
        /// </summary>
        private string tipoproduto;
        [XmlElement(ElementName = "TIPOPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoproduto
        {
            get { return  tipoproduto; }
            set {  tipoproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORANTERIOR
        /// Comentário: Valor anterior do campo
        /// </summary>
        private decimal valoranterior;
        [XmlElement(ElementName = "VALORANTERIOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valoranterior
        {
            get { return  valoranterior; }
            set {  valoranterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORATUAL
        /// Comentário: Valor atual do campo
        /// </summary>
        private decimal valoratual;
        [XmlElement(ElementName = "VALORATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valoratual
        {
            get { return  valoratual; }
            set {  valoratual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPARCELA
        /// Comentário: Valor da Parcela Bruta
        /// </summary>
        private decimal valorparcela;
        [XmlElement(ElementName = "VALORPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorparcela
        {
            get { return  valorparcela; }
            set {  valorparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPARCELALIQUIDO
        /// Comentário: Valor da Parcela Líquida
        /// </summary>
        private decimal valorparcelaliquido;
        [XmlElement(ElementName = "VALORPARCELALIQUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorparcelaliquido
        {
            get { return  valorparcelaliquido; }
            set {  valorparcelaliquido = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBaixacartaoi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBAIXACARTAOI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBaixacartaoi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBaixacartaoi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBaixacartaoi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBaixacartaoi>(where);
        }

        #endregion
    }
}
