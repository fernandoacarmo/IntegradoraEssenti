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
    /// Classe referente a tabela PCManifdestinatario
    /// </summary>
    [XmlType("PCMANIFDESTINATARIO")]
    public class PCManifdestinatario : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTE
        /// Coment�rio: Ambiente NFe.
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
        /// Propriedade referente ao campo: CHAVENFE
        /// Coment�rio: Chave Nfe
        /// </summary>
        private string chavenfe;
        [XmlElement(ElementName = "CHAVENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Chavenfe
        {
            get { return  chavenfe; }
            set {  chavenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJCPF
        /// Coment�rio: CNPJ ou CPF
        /// </summary>
        private string cnpjcpf;
        [XmlElement(ElementName = "CNPJCPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cnpjcpf
        {
            get { return  cnpjcpf; }
            set {  cnpjcpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial
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
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: C�digo
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSTATUS
        /// Coment�rio: Codigo do Status.
        /// </summary>
        private decimal codstatus;
        [XmlElement(ElementName = "CODSTATUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codstatus
        {
            get { return  codstatus; }
            set {  codstatus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSTATUSDOWNLOAD
        /// Coment�rio: C�digo do Status Download
        /// </summary>
        private decimal codstatusdownload;
        [XmlElement(ElementName = "CODSTATUSDOWNLOAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codstatusdownload
        {
            get { return  codstatusdownload; }
            set {  codstatusdownload = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CORRECAO
        /// Coment�rio: Descri��o da Corre��o
        /// </summary>
        private string correcao;
        [XmlElement(ElementName = "CORRECAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Correcao
        {
            get { return  correcao; }
            set {  correcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAAUTORIZACAOSEFAZ
        /// Coment�rio: Data e Hora de autoriza��o de uso da NF-e
        /// </summary>
        private DateTime? dataautorizacaosefaz;
        [XmlElement(ElementName = "DATAAUTORIZACAOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataautorizacaosefaz
        {
            get { return  dataautorizacaosefaz; }
            set {  dataautorizacaosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAEMISSAO
        /// Coment�rio: Data de emiss�o Nfe e CCe
        /// </summary>
        private DateTime? dataemissao;
        [XmlElement(ElementName = "DATAEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataemissao
        {
            get { return  dataemissao; }
            set {  dataemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENTRADA
        /// Coment�rio: Data de entrada da mercadoria
        /// </summary>
        private DateTime? dataentrada;
        [XmlElement(ElementName = "DATAENTRADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataentrada
        {
            get { return  dataentrada; }
            set {  dataentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATARECEBDOCUMENTO
        /// Coment�rio: Data recebimento do Documento
        /// </summary>
        private DateTime? datarecebdocumento;
        [XmlElement(ElementName = "DATARECEBDOCUMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datarecebdocumento
        {
            get { return  datarecebdocumento; }
            set {  datarecebdocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOEVENTO
        /// Coment�rio: Descri��o do Evento
        /// </summary>
        private string descricaoevento;
        [XmlElement(ElementName = "DESCRICAOEVENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricaoevento
        {
            get { return  descricaoevento; }
            set {  descricaoevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCSTATUS
        /// Coment�rio: Descri��o do Status
        /// </summary>
        private string descstatus;
        [XmlElement(ElementName = "DESCSTATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Descstatus
        {
            get { return  descstatus; }
            set {  descstatus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCSTATUSDOWNLOAD
        /// Coment�rio: Descri��o do Status Download
        /// </summary>
        private string descstatusdownload;
        [XmlElement(ElementName = "DESCSTATUSDOWNLOAD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Descstatusdownload
        {
            get { return  descstatusdownload; }
            set {  descstatusdownload = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIGESTVALUE
        /// Coment�rio: DigestValue da NF-e Autorizada
        /// </summary>
        private string digestvalue;
        [XmlElement(ElementName = "DIGESTVALUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,28)]
        public string Digestvalue
        {
            get { return  digestvalue; }
            set {  digestvalue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FEZDOWNLOADXML
        /// Coment�rio: Raliza��o do download
        /// </summary>
        private string fezdownloadxml;
        [XmlElement(ElementName = "FEZDOWNLOADXML", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fezdownloadxml
        {
            get { return  fezdownloadxml; }
            set {  fezdownloadxml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FINALIDADENFE
        /// Coment�rio: 1=NF-e Normal 2=NF-e Complementar 3=NF-e Ajuste
        /// </summary>
        private decimal finalidadenfe;
        [XmlElement(ElementName = "FINALIDADENFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Finalidadenfe
        {
            get { return  finalidadenfe; }
            set {  finalidadenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDREMESSA
        /// Coment�rio: Id de remessa manifesta��o
        /// </summary>
        private decimal idremessa;
        [XmlElement(ElementName = "IDREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Idremessa
        {
            get { return  idremessa; }
            set {  idremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDREMESSADOWNLOAD
        /// Coment�rio: Id de remessa download
        /// </summary>
        private decimal idremessadownload;
        [XmlElement(ElementName = "IDREMESSADOWNLOAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Idremessadownload
        {
            get { return  idremessadownload; }
            set {  idremessadownload = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IE
        /// Coment�rio: Inscricao Estadual
        /// </summary>
        private string ie;
        [XmlElement(ElementName = "IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Ie
        {
            get { return  ie; }
            set {  ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: JUSTIFICATIVA
        /// Coment�rio: Justificativa da opera��o n�o realizada.
        /// </summary>
        private string justificativa;
        [XmlElement(ElementName = "JUSTIFICATIVA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Justificativa
        {
            get { return  justificativa; }
            set {  justificativa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Coment�rio: Nome/ Raz�o social
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Coment�rio: Numero de Sequencia Unica.
        /// </summary>
        private decimal nsu;
        [XmlElement(ElementName = "NSU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROLOTE
        /// Coment�rio: Numero de lote
        /// </summary>
        private decimal numerolote;
        [XmlElement(ElementName = "NUMEROLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numerolote
        {
            get { return  numerolote; }
            set {  numerolote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQEVENTO
        /// Coment�rio: Sequencial do evento
        /// </summary>
        private decimal seqevento;
        [XmlElement(ElementName = "SEQEVENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Seqevento
        {
            get { return  seqevento; }
            set {  seqevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITCONFIRMACAODEST
        /// Coment�rio: Confirma��o Destinat�rio:
        /// </summary>
        private decimal sitconfirmacaodest;
        [XmlElement(ElementName = "SITCONFIRMACAODEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Sitconfirmacaodest
        {
            get { return  sitconfirmacaodest; }
            set {  sitconfirmacaodest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITCONFIRMACAODESTANT
        /// Coment�rio: Situacao de confirma��o destinatario Atual.
        /// </summary>
        private decimal sitconfirmacaodestant;
        [XmlElement(ElementName = "SITCONFIRMACAODESTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Sitconfirmacaodestant
        {
            get { return  sitconfirmacaodestant; }
            set {  sitconfirmacaodestant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAONFE
        /// Coment�rio: 1=Autorizada 2=Cancelada 3=Denegada
        /// </summary>
        private decimal situacaonfe;
        [XmlElement(ElementName = "SITUACAONFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Situacaonfe
        {
            get { return  situacaonfe; }
            set {  situacaonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODOCUMENTO
        /// Coment�rio: 0-NF-e 1-Cancelamento 2-Evento de CC-e
        /// </summary>
        private decimal tipodocumento;
        [XmlElement(ElementName = "TIPODOCUMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipodocumento
        {
            get { return  tipodocumento; }
            set {  tipodocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEVENTO
        /// Coment�rio: C�digo do de evento
        /// </summary>
        private decimal tipoevento;
        [XmlElement(ElementName = "TIPOEVENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Tipoevento
        {
            get { return  tipoevento; }
            set {  tipoevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPONOTA
        /// Coment�rio: 0=Entrada 1=Sa�da
        /// </summary>
        private decimal tiponota;
        [XmlElement(ElementName = "TIPONOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tiponota
        {
            get { return  tiponota; }
            set {  tiponota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: UF
        /// </summary>
        private string uf;
        [XmlElement(ElementName = "UF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uf
        {
            get { return  uf; }
            set {  uf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALNFE
        /// Coment�rio: Valor total da NF-e
        /// </summary>
        private decimal vltotalnfe;
        [XmlElement(ElementName = "VLTOTALNFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Vltotalnfe
        {
            get { return  vltotalnfe; }
            set {  vltotalnfe = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCManifdestinatario()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMANIFDESTINATARIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCManifdestinatario> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCManifdestinatario>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCManifdestinatario> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCManifdestinatario>(where);
        }

        #endregion
    }
}
