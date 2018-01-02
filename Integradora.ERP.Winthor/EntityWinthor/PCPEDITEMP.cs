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
    /// Classe referente a tabela PCPeditemp
    /// </summary>
    [XmlType("PCPEDITEMP")]
    public class PCPeditemp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Coment�rio: 
        /// </summary>
        private decimal? codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal? Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCERTIFIC
        /// Coment�rio: 
        /// </summary>
        private decimal? codcertific;
        [XmlElement(ElementName = "CODCERTIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal? Codcertific
        {
            get { return  codcertific; }
            set {  codcertific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODCESTA
        /// Coment�rio: 
        /// </summary>
        private decimal codprodcesta;
        [XmlElement(ElementName = "CODPRODCESTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true, false, false, 6)]
        public decimal Codprodcesta
        {
            get { return codprodcesta; }
            set { codprodcesta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEGUSTACAO
        /// Coment�rio: 
        /// </summary>
        private decimal? coddegustacao;
        [XmlElement(ElementName = "CODDEGUSTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Coddegustacao
        {
            get { return  coddegustacao; }
            set {  coddegustacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Coment�rio: 
        /// </summary>
        private string codfilialretira;
        [XmlElement(ElementName = "CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialretira
        {
            get { return  codfilialretira; }
            set {  codfilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNAOATENDIMENTO
        /// Coment�rio: 
        /// </summary>
        private decimal? codnaoatendimento;
        [XmlElement(ElementName = "CODNAOATENDIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal? Codnaoatendimento
        {
            get { return  codnaoatendimento; }
            set {  codnaoatendimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAO
        /// Coment�rio: 
        /// </summary>
        private string codpromocao;
        [XmlElement(ElementName = "CODPROMOCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codpromocao
        {
            get { return  codpromocao; }
            set {  codpromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRETORNO
        /// Coment�rio: Codigo de retorno da tabela pcretornoimportarvendas
        /// </summary>
        private decimal? codretorno;
        [XmlElement(ElementName = "CODRETORNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal? Codretorno
        {
            get { return  codretorno; }
            set {  codretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRETORNOS
        /// Coment�rio: C�digos de retornos
        /// </summary>
        private string codretornos;
        [XmlElement(ElementName = "CODRETORNOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Codretornos
        {
            get { return  codretornos; }
            set {  codretornos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOATIM
        /// Coment�rio: Comissao de ganho da Aplic.
        /// </summary>
        private decimal? comissaoatim;
        [XmlElement(ElementName = "COMISSAOATIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Comissaoatim
        {
            get { return  comissaoatim; }
            set {  comissaoatim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Coment�rio: 
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal? eancodprod;
        [XmlElement(ElementName = "EANCODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal? Eancodprod
        {
            get { return  eancodprod; }
            set {  eancodprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDVENDA
        /// Coment�rio: Recebe o identificador da venda.
        /// </summary>
        private decimal? idvenda;
        [XmlElement(ElementName = "IDVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal? Idvenda
        {
            get { return  idvenda; }
            set {  idvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Coment�rio: Recebe o c�digo da integradora de dados.
        /// </summary>
        private decimal integradora;
        [XmlElement(ElementName = "INTEGRADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Integradora
        {
            get { return  integradora; }
            set {  integradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Coment�rio: 
        /// </summary>
        private string localizacao;
        [XmlElement(ElementName = "LOCALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Localizacao
        {
            get { return  localizacao; }
            set {  localizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDCLI
        /// Coment�rio: 
        /// </summary>
        private string numpedcli;
        [XmlElement(ElementName = "NUMPEDCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 50)]
        public string Numpedcli
        {
            get { return  numpedcli; }
            set {  numpedcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Coment�rio: 
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedrca
        {
            get { return  numpedrca; }
            set {  numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDWEB
        /// Coment�rio: 
        /// </summary>
        private decimal numpedweb;
        [XmlElement(ElementName = "NUMPEDWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public decimal Numpedweb
        {
            get { return  numpedweb; }
            set {  numpedweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Coment�rio: 
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO1
        /// Coment�rio: 
        /// </summary>
        private string obsintegracao1;
        [XmlElement(ElementName = "OBSINTEGRACAO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsintegracao1
        {
            get { return  obsintegracao1; }
            set {  obsintegracao1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO2
        /// Coment�rio: 
        /// </summary>
        private string obsintegracao2;
        [XmlElement(ElementName = "OBSINTEGRACAO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsintegracao2
        {
            get { return  obsintegracao2; }
            set {  obsintegracao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PBONIFIC
        /// Coment�rio: 
        /// </summary>
        private decimal? pbonific;
        [XmlElement(ElementName = "PBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal? Pbonific
        {
            get { return  pbonific; }
            set {  pbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC
        /// Coment�rio: 
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Coment�rio: 
        /// </summary>
        private decimal? pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal? Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIO
        /// Coment�rio: 
        /// </summary>
        private decimal? prazomedio;
        [XmlElement(ElementName = "PRAZOMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal? Prazomedio
        {
            get { return  prazomedio; }
            set {  prazomedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Coment�rio: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT_FATURADA
        /// Coment�rio: 
        /// </summary>
        private decimal? qt_faturada;
        [XmlElement(ElementName = "QT_FATURADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal? Qt_Faturada
        {
            get { return  qt_faturada; }
            set {  qt_faturada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENTREGA
        /// Coment�rio: Tipo de Entrega
        /// </summary>
        private string tipoentrega;
        [XmlElement(ElementName = "TIPOENTREGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoentrega
        {
            get { return  tipoentrega; }
            set {  tipoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOINTEGRACAO
        /// Coment�rio: 
        /// </summary>
        private string tipointegracao;
        [XmlElement(ElementName = "TIPOINTEGRACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipointegracao
        {
            get { return  tipointegracao; }
            set {  tipointegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSACAO
        /// Coment�rio: Indica o n�mero da transa��o.
        /// </summary>
        private decimal? transacao;
        [XmlElement(ElementName = "TRANSACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal? Transacao
        {
            get { return  transacao; }
            set {  transacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPeditemp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDITEMP";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPeditemp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPeditemp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPeditemp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPeditemp>(where);
        }

        #endregion
    }
}
