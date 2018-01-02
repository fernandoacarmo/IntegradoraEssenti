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
    /// Classe referente a tabela PCCrecli
    /// </summary>
    [XmlType("PCCRECLI")]
    public class PCCrecli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BIN
        /// Comentário: Indica o BIN do cartão transação TEF.
        /// </summary>
        private decimal? bin;
        [XmlElement(ElementName = "BIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Bin
        {
            get { return  bin; }
            set {  bin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODADMCARTAO
        /// Comentário: Indica o código de operadora realizou operação SISCRED.
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
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal? codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal? Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIORIG
        /// Comentário: Código do cliente orignial
        /// </summary>
        private decimal? codcliorig;
        [XmlElement(ElementName = "CODCLIORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codcliorig
        {
            get { return  codcliorig; }
            set {  codcliorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFILIALDESC
        /// Comentário: 
        /// </summary>
        private string codfilialdesc;
        [XmlElement(ElementName = "CODFILIALDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialdesc
        {
            get { return  codfilialdesc; }
            set {  codfilialdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: 
        /// </summary>
        private decimal? codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCX
        /// Comentário: Indica o código do Funcionário gerado pela 2075. 
        /// </summary>
        private decimal? codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: 
        /// </summary>
        private decimal? codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Indica o numero identificador.
        /// </summary>
        private decimal? codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOVIMENTO
        /// Comentário: 
        /// </summary>
        private decimal? codmovimento;
        [XmlElement(ElementName = "CODMOVIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Codmovimento
        {
            get { return  codmovimento; }
            set {  codmovimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Código da rotina na qual o crédito foi gerado. 
        /// </summary>
        private decimal? codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDESCONTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtdesconto;
        [XmlElement(ElementName = "DTDESCONTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdesconto
        {
            get { return  dtdesconto; }
            set {  dtdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Comentário: 
        /// </summary>
        private decimal? hora;
        [XmlElement(ElementName = "HORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTO
        /// Comentário: 
        /// </summary>
        private decimal? minuto;
        [XmlElement(ElementName = "MINUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Minuto
        {
            get { return  minuto; }
            set {  minuto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSUTEF
        /// Comentário: Indica o NSU da transação TEF.
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
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: Indica o número do Caixa gerado pela 2075.
        /// </summary>
        private decimal? numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOM
        /// Comentário: Indica o numero do cupom.
        /// </summary>
        private decimal? numcupom;
        [XmlElement(ElementName = "NUMCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numcupom
        {
            get { return  numcupom; }
            set {  numcupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERARIO
        /// Comentário: 
        /// </summary>
        private string numerario;
        [XmlElement(ElementName = "NUMERARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Numerario
        {
            get { return  numerario; }
            set {  numerario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGIFTCARD
        /// Comentário: Número do cartão GiftCard
        /// </summary>
        private decimal? numgiftcard;
        [XmlElement(ElementName = "NUMGIFTCARD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public decimal? Numgiftcard
        {
            get { return  numgiftcard; }
            set {  numgiftcard = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINDENIZ
        /// Comentário: Número da Indenização que gerou o Crédito. 
        /// </summary>
        private decimal? numindeniz;
        [XmlElement(ElementName = "NUMINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numindeniz
        {
            get { return  numindeniz; }
            set {  numindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANC
        /// Comentário: 
        /// </summary>
        private decimal? numlanc;
        [XmlElement(ElementName = "NUMLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numlanc
        {
            get { return  numlanc; }
            set {  numlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANCBAIXA
        /// Comentário: 
        /// </summary>
        private decimal? numlancbaixa;
        [XmlElement(ElementName = "NUMLANCBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Numlancbaixa
        {
            get { return  numlancbaixa; }
            set {  numlancbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal? numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTADESC
        /// Comentário: 
        /// </summary>
        private decimal? numnotadesc;
        [XmlElement(ElementName = "NUMNOTADESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numnotadesc
        {
            get { return  numnotadesc; }
            set {  numnotadesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
        /// </summary>
        private decimal? numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Comentário: Indica o número do Pedido gerado pela rotina 2075 no caixa. 
        /// </summary>
        private decimal? numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Comentário: Indica o número de Série da Impressora Fiscal. 
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: 
        /// </summary>
        private decimal? numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSBAIXA
        /// Comentário: 
        /// </summary>
        private decimal? numtransbaixa;
        [XmlElement(ElementName = "NUMTRANSBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransbaixa
        {
            get { return  numtransbaixa; }
            set {  numtransbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTDEVCLI
        /// Comentário: 
        /// </summary>
        private decimal? numtransentdevcli;
        [XmlElement(ElementName = "NUMTRANSENTDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransentdevcli
        {
            get { return  numtransentdevcli; }
            set {  numtransentdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal? numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDADESC
        /// Comentário: 
        /// </summary>
        private decimal? numtransvendadesc;
        [XmlElement(ElementName = "NUMTRANSVENDADESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal? Numtransvendadesc
        {
            get { return  numtransvendadesc; }
            set {  numtransvendadesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Indica a observação para estorno do crédito.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEM
        /// Comentário: 
        /// </summary>
        private string origem;
        [XmlElement(ElementName = "ORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origem
        {
            get { return  origem; }
            set {  origem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTRESTCLI
        /// Comentário: Prestação usado somente na Restituição de Cliente (1259). 
        /// </summary>
        private string prestrestcli;
        [XmlElement(ElementName = "PRESTRESTCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prestrestcli
        {
            get { return  prestrestcli; }
            set {  prestrestcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEDESC
        /// Comentário: 
        /// </summary>
        private string seriedesc;
        [XmlElement(ElementName = "SERIEDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Seriedesc
        {
            get { return  seriedesc; }
            set {  seriedesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: Indica a situação do Crédito: Nulo ou P (Pendente). P indica que o crédito não será usado durante o faturamento. 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORESTORNOLIBERADO
        /// Comentário: Indica o valor de estorno liberado no caixa varejo.
        /// </summary>
        private decimal? valorestornoliberado;
        [XmlElement(ElementName = "VALORESTORNOLIBERADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Valorestornoliberado
        {
            get { return  valorestornoliberado; }
            set {  valorestornoliberado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCrecli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCRECLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCrecli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCrecli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCrecli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCrecli>(where);
        }

        #endregion
    }
}
