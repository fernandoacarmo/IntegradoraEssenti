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
    /// Classe referente a tabela PCCaixa
    /// </summary>
    [XmlType("PCCAIXA")]
    public class PCCaixa : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ADMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? admissao;
        [XmlElement(ElementName = "ADMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Admissao
        {
            get { return  admissao; }
            set {  admissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURACAIXA
        /// Comentário: 
        /// </summary>
        private string assinaturacaixa;
        [XmlElement(ElementName = "ASSINATURACAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,255)]
        public string Assinaturacaixa
        {
            get { return  assinaturacaixa; }
            set {  assinaturacaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACESTABASICA
        /// Comentário: 
        /// </summary>
        private string atualizacestabasica;
        [XmlElement(ElementName = "ATUALIZACESTABASICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizacestabasica
        {
            get { return  atualizacestabasica; }
            set {  atualizacestabasica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACFO
        /// Comentário: 
        /// </summary>
        private string atualizacfo;
        [XmlElement(ElementName = "ATUALIZACFO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizacfo
        {
            get { return  atualizacfo; }
            set {  atualizacfo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACLIENTE
        /// Comentário: 
        /// </summary>
        private string atualizacliente;
        [XmlElement(ElementName = "ATUALIZACLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizacliente
        {
            get { return  atualizacliente; }
            set {  atualizacliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACLIENTEDTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? atualizaclientedtfim;
        [XmlElement(ElementName = "ATUALIZACLIENTEDTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Atualizaclientedtfim
        {
            get { return  atualizaclientedtfim; }
            set {  atualizaclientedtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACLIENTEDTINI
        /// Comentário: 
        /// </summary>
        private DateTime? atualizaclientedtini;
        [XmlElement(ElementName = "ATUALIZACLIENTEDTINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Atualizaclientedtini
        {
            get { return  atualizaclientedtini; }
            set {  atualizaclientedtini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAEMPREGADO
        /// Comentário: 
        /// </summary>
        private string atualizaempregado;
        [XmlElement(ElementName = "ATUALIZAEMPREGADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaempregado
        {
            get { return  atualizaempregado; }
            set {  atualizaempregado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAFORMAPG
        /// Comentário: 
        /// </summary>
        private string atualizaformapg;
        [XmlElement(ElementName = "ATUALIZAFORMAPG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaformapg
        {
            get { return  atualizaformapg; }
            set {  atualizaformapg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZALAYOUT
        /// Comentário: 
        /// </summary>
        private string atualizalayout;
        [XmlElement(ElementName = "ATUALIZALAYOUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizalayout
        {
            get { return  atualizalayout; }
            set {  atualizalayout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPCCOMISSAOPLPAG
        /// Comentário: Atualizar comissão progressimo por plano.
        /// </summary>
        private string atualizapccomissaoplpag;
        [XmlElement(ElementName = "ATUALIZAPCCOMISSAOPLPAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizapccomissaoplpag
        {
            get { return  atualizapccomissaoplpag; }
            set {  atualizapccomissaoplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPCCOMISSAOUSUR
        /// Comentário: Atualizar comissão progressimo por RCA.
        /// </summary>
        private string atualizapccomissaousur;
        [XmlElement(ElementName = "ATUALIZAPCCOMISSAOUSUR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizapccomissaousur
        {
            get { return  atualizapccomissaousur; }
            set {  atualizapccomissaousur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPLANO
        /// Comentário: 
        /// </summary>
        private string atualizaplano;
        [XmlElement(ElementName = "ATUALIZAPLANO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaplano
        {
            get { return  atualizaplano; }
            set {  atualizaplano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRECOEMBALAGEM
        /// Comentário: 
        /// </summary>
        private string atualizaprecoembalagem;
        [XmlElement(ElementName = "ATUALIZAPRECOEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaprecoembalagem
        {
            get { return  atualizaprecoembalagem; }
            set {  atualizaprecoembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRECOEMBALAGEMDTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? atualizaprecoembalagemdtfim;
        [XmlElement(ElementName = "ATUALIZAPRECOEMBALAGEMDTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Atualizaprecoembalagemdtfim
        {
            get { return  atualizaprecoembalagemdtfim; }
            set {  atualizaprecoembalagemdtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRECOEMBALAGEMDTINI
        /// Comentário: 
        /// </summary>
        private DateTime? atualizaprecoembalagemdtini;
        [XmlElement(ElementName = "ATUALIZAPRECOEMBALAGEMDTINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Atualizaprecoembalagemdtini
        {
            get { return  atualizaprecoembalagemdtini; }
            set {  atualizaprecoembalagemdtini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRECOFIMVENDA
        /// Comentário: Indica se utiliza a carga parcial no fim da venda.
        /// </summary>
        private string atualizaprecofimvenda;
        [XmlElement(ElementName = "ATUALIZAPRECOFIMVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaprecofimvenda
        {
            get { return  atualizaprecofimvenda; }
            set {  atualizaprecofimvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRECOREGIAO
        /// Comentário: 
        /// </summary>
        private string atualizaprecoregiao;
        [XmlElement(ElementName = "ATUALIZAPRECOREGIAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaprecoregiao
        {
            get { return  atualizaprecoregiao; }
            set {  atualizaprecoregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRECOREGIAODTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? atualizaprecoregiaodtfim;
        [XmlElement(ElementName = "ATUALIZAPRECOREGIAODTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Atualizaprecoregiaodtfim
        {
            get { return  atualizaprecoregiaodtfim; }
            set {  atualizaprecoregiaodtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRECOREGIAODTINI
        /// Comentário: 
        /// </summary>
        private DateTime? atualizaprecoregiaodtini;
        [XmlElement(ElementName = "ATUALIZAPRECOREGIAODTINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Atualizaprecoregiaodtini
        {
            get { return  atualizaprecoregiaodtini; }
            set {  atualizaprecoregiaodtini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRODUTO
        /// Comentário: 
        /// </summary>
        private string atualizaproduto;
        [XmlElement(ElementName = "ATUALIZAPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizaproduto
        {
            get { return  atualizaproduto; }
            set {  atualizaproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRODUTODTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? atualizaprodutodtfim;
        [XmlElement(ElementName = "ATUALIZAPRODUTODTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Atualizaprodutodtfim
        {
            get { return  atualizaprodutodtfim; }
            set {  atualizaprodutodtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZAPRODUTODTINI
        /// Comentário: 
        /// </summary>
        private DateTime? atualizaprodutodtini;
        [XmlElement(ElementName = "ATUALIZAPRODUTODTINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Atualizaprodutodtini
        {
            get { return  atualizaprodutodtini; }
            set {  atualizaprodutodtini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZASETOR
        /// Comentário: 
        /// </summary>
        private string atualizasetor;
        [XmlElement(ElementName = "ATUALIZASETOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizasetor
        {
            get { return  atualizasetor; }
            set {  atualizasetor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZATRIBUTACAO
        /// Comentário: 
        /// </summary>
        private string atualizatributacao;
        [XmlElement(ElementName = "ATUALIZATRIBUTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizatributacao
        {
            get { return  atualizatributacao; }
            set {  atualizatributacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BITSDEDADOSLEITOR
        /// Comentário: Indica a velocidade dos dados.
        /// </summary>
        private string bitsdedadosleitor;
        [XmlElement(ElementName = "BITSDEDADOSLEITOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Bitsdedadosleitor
        {
            get { return  bitsdedadosleitor; }
            set {  bitsdedadosleitor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BITSPORSEGUNDOLEITOR
        /// Comentário: Indica a velocidade do envio.
        /// </summary>
        private string bitsporsegundoleitor;
        [XmlElement(ElementName = "BITSPORSEGUNDOLEITOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Bitsporsegundoleitor
        {
            get { return  bitsporsegundoleitor; }
            set {  bitsporsegundoleitor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Indica o código do banco/caixa checkout.
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
        /// Propriedade referente ao campo: CODCLIPARC
        /// Comentário: Indica o código cliente parcial.
        /// </summary>
        private decimal codcliparc;
        [XmlElement(ElementName = "CODCLIPARC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcliparc
        {
            get { return  codcliparc; }
            set {  codcliparc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMPRESASITEF
        /// Comentário: 
        /// </summary>
        private string codempresasitef;
        [XmlElement(ElementName = "CODEMPRESASITEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codempresasitef
        {
            get { return  codempresasitef; }
            set {  codempresasitef = value; }
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
        /// Propriedade referente ao campo: CODFUNCCX
        /// Comentário: 
        /// </summary>
        private decimal codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNACIONALECF
        /// Comentário: Indica o código nacional do ECF.
        /// </summary>
        private string codnacionalecf;
        [XmlElement(ElementName = "CODNACIONALECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codnacionalecf
        {
            get { return  codnacionalecf; }
            set {  codnacionalecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPARC
        /// Comentário: Indica o código produto parcial.
        /// </summary>
        private decimal codprodparc;
        [XmlElement(ElementName = "CODPRODPARC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodparc
        {
            get { return  codprodparc; }
            set {  codprodparc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFIRMAR_CARGA
        /// Comentário: Confirmar geração de carga geral.
        /// </summary>
        private string confirmar_carga;
        [XmlElement(ElementName = "CONFIRMAR_CARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Confirmar_Carga
        {
            get { return  confirmar_carga; }
            set {  confirmar_carga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFIMPARC
        /// Comentário: Indica a data final da carga parcial.
        /// </summary>
        private DateTime? datafimparc;
        [XmlElement(ElementName = "DATAFIMPARC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafimparc
        {
            get { return  datafimparc; }
            set {  datafimparc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINIPARC
        /// Comentário: Indica a data inicio da carga parcial.
        /// </summary>
        private DateTime? datainiparc;
        [XmlElement(ElementName = "DATAINIPARC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datainiparc
        {
            get { return  datainiparc; }
            set {  datainiparc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEGUSTACAO
        /// Comentário: 
        /// </summary>
        private string degustacao;
        [XmlElement(ElementName = "DEGUSTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Degustacao
        {
            get { return  degustacao; }
            set {  degustacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRATUALIZACAO
        /// Comentário: 
        /// </summary>
        private string diratualizacao;
        [XmlElement(ElementName = "DIRATUALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Diratualizacao
        {
            get { return  diratualizacao; }
            set {  diratualizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXATULIZACAO
        /// Comentário: Indica a data da proxima atualização.
        /// </summary>
        private decimal dtproxatulizacao;
        [XmlElement(ElementName = "DTPROXATULIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Dtproxatulizacao
        {
            get { return  dtproxatulizacao; }
            set {  dtproxatulizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXCARGAGERAL
        /// Comentário: Indica a data da proxima carga geral dos dados no caixa.
        /// </summary>
        private DateTime? dtproxcargageral;
        [XmlElement(ElementName = "DTPROXCARGAGERAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxcargageral
        {
            get { return  dtproxcargageral; }
            set {  dtproxcargageral = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROXCARGAPARCIAL
        /// Comentário: Indica a data da proxima carga parcial dos dados no caixa.
        /// </summary>
        private DateTime? dtproxcargaparcial;
        [XmlElement(ElementName = "DTPROXCARGAPARCIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtproxcargaparcial
        {
            get { return  dtproxcargaparcial; }
            set {  dtproxcargaparcial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREINICIOOP
        /// Comentário: Indica a data de reinício da operação.
        /// </summary>
        private DateTime? dtreinicioop;
        [XmlElement(ElementName = "DTREINICIOOP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtreinicioop
        {
            get { return  dtreinicioop; }
            set {  dtreinicioop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSWBASICO
        /// Comentário: Indica a data do software básico.
        /// </summary>
        private DateTime? dtswbasico;
        [XmlElement(ElementName = "DTSWBASICO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtswbasico
        {
            get { return  dtswbasico; }
            set {  dtswbasico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSWUSUARIO
        /// Comentário: Indica a data de cadastro do usuário.
        /// </summary>
        private DateTime? dtswusuario;
        [XmlElement(ElementName = "DTSWUSUARIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtswusuario
        {
            get { return  dtswusuario; }
            set {  dtswusuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCARGAGERAL
        /// Comentário: Indica a data da ultima carga geral dos dados no caixa.
        /// </summary>
        private DateTime? dtultcargageral;
        [XmlElement(ElementName = "DTULTCARGAGERAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcargageral
        {
            get { return  dtultcargageral; }
            set {  dtultcargageral = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCARGAPARCIAL
        /// Comentário: Indica a data da ultima carga parcial dos dados no caixa.
        /// </summary>
        private DateTime? dtultcargaparcial;
        [XmlElement(ElementName = "DTULTCARGAPARCIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultcargaparcial
        {
            get { return  dtultcargaparcial; }
            set {  dtultcargaparcial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GAVETAACOPLADA
        /// Comentário: 
        /// </summary>
        private string gavetaacoplada;
        [XmlElement(ElementName = "GAVETAACOPLADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gavetaacoplada
        {
            get { return  gavetaacoplada; }
            set {  gavetaacoplada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IPSERVIDORSITEF
        /// Comentário: 
        /// </summary>
        private string ipservidorsitef;
        [XmlElement(ElementName = "IPSERVIDORSITEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ipservidorsitef
        {
            get { return  ipservidorsitef; }
            set {  ipservidorsitef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENSCARGAGERAL
        /// Comentário: Itens da carga geral para carga dos dados do caixa.
        /// </summary>
        private string itenscargageral;
        [XmlElement(ElementName = "ITENSCARGAGERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Itenscargageral
        {
            get { return  itenscargageral; }
            set {  itenscargageral = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ITENSCARGAPARCIAL
        /// Comentário: Indica os itens da carga parcial para carga dos dados do caixa.
        /// </summary>
        private string itenscargaparcial;
        [XmlElement(ElementName = "ITENSCARGAPARCIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Itenscargaparcial
        {
            get { return  itenscargaparcial; }
            set {  itenscargaparcial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: 
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Modelo
        {
            get { return  modelo; }
            set {  modelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELOECF
        /// Comentário: Modelo de Impressora para NFP.
        /// </summary>
        private string modeloecf;
        [XmlElement(ElementName = "MODELOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Modeloecf
        {
            get { return  modeloecf; }
            set {  modeloecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MSGCUPOMFISCAL
        /// Comentário: 
        /// </summary>
        private string msgcupomfiscal;
        [XmlElement(ElementName = "MSGCUPOMFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Msgcupomfiscal
        {
            get { return  msgcupomfiscal; }
            set {  msgcupomfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: 
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXAFISCAL
        /// Comentário: 
        /// </summary>
        private decimal numcaixafiscal;
        [XmlElement(ElementName = "NUMCAIXAFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixafiscal
        {
            get { return  numcaixafiscal; }
            set {  numcaixafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOMABERTO
        /// Comentário: 
        /// </summary>
        private decimal numcupomaberto;
        [XmlElement(ElementName = "NUMCUPOMABERTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcupomaberto
        {
            get { return  numcupomaberto; }
            set {  numcupomaberto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCUPOMFECHADO
        /// Comentário: 
        /// </summary>
        private decimal numcupomfechado;
        [XmlElement(ElementName = "NUMCUPOMFECHADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcupomfechado
        {
            get { return  numcupomfechado; }
            set {  numcupomfechado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOPCX
        /// Comentário: 
        /// </summary>
        private decimal numopcx;
        [XmlElement(ElementName = "NUMOPCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numopcx
        {
            get { return  numopcx; }
            set {  numopcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMUSUARIOECF
        /// Comentário: Indica o número do usuário da ECF.
        /// </summary>
        private decimal numusuarioecf;
        [XmlElement(ElementName = "NUMUSUARIOECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numusuarioecf
        {
            get { return  numusuarioecf; }
            set {  numusuarioecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARIDADELEITOR
        /// Comentário: Indica a paridade do leitor.
        /// </summary>
        private string paridadeleitor;
        [XmlElement(ElementName = "PARIDADELEITOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Paridadeleitor
        {
            get { return  paridadeleitor; }
            set {  paridadeleitor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEABRIRGAVETA
        /// Comentário: 
        /// </summary>
        private string permiteabrirgaveta;
        [XmlElement(ElementName = "PERMITEABRIRGAVETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteabrirgaveta
        {
            get { return  permiteabrirgaveta; }
            set {  permiteabrirgaveta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTAIMPRESSORA
        /// Comentário: 
        /// </summary>
        private decimal portaimpressora;
        [XmlElement(ElementName = "PORTAIMPRESSORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Portaimpressora
        {
            get { return  portaimpressora; }
            set {  portaimpressora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTAIMPRESSORACHEQUE
        /// Comentário: 
        /// </summary>
        private decimal portaimpressoracheque;
        [XmlElement(ElementName = "PORTAIMPRESSORACHEQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Portaimpressoracheque
        {
            get { return  portaimpressoracheque; }
            set {  portaimpressoracheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTALEITOR
        /// Comentário: 
        /// </summary>
        private decimal portaleitor;
        [XmlElement(ElementName = "PORTALEITOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Portaleitor
        {
            get { return  portaleitor; }
            set {  portaleitor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTALEITORCH
        /// Comentário: 
        /// </summary>
        private decimal portaleitorch;
        [XmlElement(ElementName = "PORTALEITORCH", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Portaleitorch
        {
            get { return  portaleitorch; }
            set {  portaleitorch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSSUIGUILHOTINA
        /// Comentário: Utilização de guilhotina pela impressora
        /// </summary>
        private string possuiguilhotina;
        [XmlElement(ElementName = "POSSUIGUILHOTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Possuiguilhotina
        {
            get { return  possuiguilhotina; }
            set {  possuiguilhotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFCE
        /// Comentário: Numerador do próximo número de NFCe.
        /// </summary>
        private decimal proxnumnfce;
        [XmlElement(ElementName = "PROXNUMNFCE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnfce
        {
            get { return  proxnumnfce; }
            set {  proxnumnfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESPSITEFTECLADO
        /// Comentário: Indica o retorno da transação TEF.
        /// </summary>
        private string respsitefteclado;
        [XmlElement(ElementName = "RESPSITEFTECLADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Respsitefteclado
        {
            get { return  respsitefteclado; }
            set {  respsitefteclado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALTARLINHATEF
        /// Comentário: 
        /// </summary>
        private string saltarlinhatef;
        [XmlElement(ElementName = "SALTARLINHATEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Saltarlinhatef
        {
            get { return  saltarlinhatef; }
            set {  saltarlinhatef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOLICITARCAVENDA
        /// Comentário: Solicitar RCA Venda
        /// </summary>
        private string solicitarcavenda;
        [XmlElement(ElementName = "SOLICITARCAVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Solicitarcavenda
        {
            get { return  solicitarcavenda; }
            set {  solicitarcavenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TERMINALSITEF
        /// Comentário: 
        /// </summary>
        private string terminalsitef;
        [XmlElement(ElementName = "TERMINALSITEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Terminalsitef
        {
            get { return  terminalsitef; }
            set {  terminalsitef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBALANCA
        /// Comentário: 
        /// </summary>
        private string tipobalanca;
        [XmlElement(ElementName = "TIPOBALANCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipobalanca
        {
            get { return  tipobalanca; }
            set {  tipobalanca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCAIXA
        /// Comentário: Tipo de caixa
        /// </summary>
        private string tipocaixa;
        [XmlElement(ElementName = "TIPOCAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocaixa
        {
            get { return  tipocaixa; }
            set {  tipocaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODECAIXA
        /// Comentário: Tipo de caixa
        /// </summary>
        private string tipodecaixa;
        [XmlElement(ElementName = "TIPODECAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Tipodecaixa
        {
            get { return  tipodecaixa; }
            set {  tipodecaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOIMPRESSORA
        /// Comentário: 
        /// </summary>
        private string tipoimpressora;
        [XmlElement(ElementName = "TIPOIMPRESSORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoimpressora
        {
            get { return  tipoimpressora; }
            set {  tipoimpressora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOIMPRESSORACHEQUE
        /// Comentário: 
        /// </summary>
        private string tipoimpressoracheque;
        [XmlElement(ElementName = "TIPOIMPRESSORACHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoimpressoracheque
        {
            get { return  tipoimpressoracheque; }
            set {  tipoimpressoracheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTECLADO
        /// Comentário: 
        /// </summary>
        private string tipoteclado;
        [XmlElement(ElementName = "TIPOTECLADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoteclado
        {
            get { return  tipoteclado; }
            set {  tipoteclado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTEF
        /// Comentário: 
        /// </summary>
        private string tipotef;
        [XmlElement(ElementName = "TIPOTEF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Tipotef
        {
            get { return  tipotef; }
            set {  tipotef = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAINDICEECF
        /// Comentário: Indica se utiliza indice no ECF.
        /// </summary>
        private string usaindiceecf;
        [XmlElement(ElementName = "USAINDICEECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaindiceecf
        {
            get { return  usaindiceecf; }
            set {  usaindiceecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USASUFIXOLEITOR
        /// Comentário: Indica se gravação do uso de sufixo.
        /// </summary>
        private string usasufixoleitor;
        [XmlElement(ElementName = "USASUFIXOLEITOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usasufixoleitor
        {
            get { return  usasufixoleitor; }
            set {  usasufixoleitor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDACH
        /// Comentário: 
        /// </summary>
        private string validach;
        [XmlElement(ElementName = "VALIDACH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validach
        {
            get { return  validach; }
            set {  validach = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERFIRMWARE
        /// Comentário: Indica a versão do firmware.
        /// </summary>
        private string verfirmware;
        [XmlElement(ElementName = "VERFIRMWARE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Verfirmware
        {
            get { return  verfirmware; }
            set {  verfirmware = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOIMPRESSORA
        /// Comentário: 
        /// </summary>
        private string versaoimpressora;
        [XmlElement(ElementName = "VERSAOIMPRESSORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Versaoimpressora
        {
            get { return  versaoimpressora; }
            set {  versaoimpressora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOIMPRESSORACHEQUE
        /// Comentário: 
        /// </summary>
        private string versaoimpressoracheque;
        [XmlElement(ElementName = "VERSAOIMPRESSORACHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Versaoimpressoracheque
        {
            get { return  versaoimpressoracheque; }
            set {  versaoimpressoracheque = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCaixa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCAIXA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCaixa> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCaixa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCaixa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCaixa>(where);
        }

        #endregion
    }
}
