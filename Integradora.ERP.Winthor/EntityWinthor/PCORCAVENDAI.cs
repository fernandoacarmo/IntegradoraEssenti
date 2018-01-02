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
    /// Classe referente a tabela PCOrcavendai
    /// </summary>
    [XmlType("PCORCAVENDAI")]
    public class PCOrcavendai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS1
        /// Comentário: 
        /// </summary>
        private decimal aliqicms1;
        [XmlElement(ElementName = "ALIQICMS1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms1
        {
            get { return  aliqicms1; }
            set {  aliqicms1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS2
        /// Comentário: 
        /// </summary>
        private decimal aliqicms2;
        [XmlElement(ElementName = "ALIQICMS2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms2
        {
            get { return  aliqicms2; }
            set {  aliqicms2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTERNATIVO
        /// Comentário: 
        /// </summary>
        private string alternativo;
        [XmlElement(ElementName = "ALTERNATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Alternativo
        {
            get { return  alternativo; }
            set {  alternativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTE
        /// Comentário: Nome do Ambiente
        /// </summary>
        private string ambiente;
        [XmlElement(ElementName = "AMBIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Ambiente
        {
            get { return  ambiente; }
            set {  ambiente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIXADO
        /// Comentário: Estado do orçamento como baixado ou não.
        /// </summary>
        private string baixado;
        [XmlElement(ElementName = "BAIXADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Baixado
        {
            get { return  baixado; }
            set {  baixado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEDIFALIQUOTAS
        /// Comentário: Base da diferença entre alíquotas.
        /// </summary>
        private decimal basedifaliquotas;
        [XmlElement(ElementName = "BASEDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Basedifaliquotas
        {
            get { return  basedifaliquotas; }
            set {  basedifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEICST
        /// Comentário: Base de cálculo ST. 
        /// </summary>
        private decimal baseicst;
        [XmlElement(ElementName = "BASEICST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicst
        {
            get { return  baseicst; }
            set {  baseicst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BONIFIC
        /// Comentário: Identificação do item bonificado
        /// </summary>
        private string bonific;
        [XmlElement(ElementName = "BONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bonific
        {
            get { return  bonific; }
            set {  bonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BRINDE
        /// Comentário: Item de brinde. 
        /// </summary>
        private string brinde;
        [XmlElement(ElementName = "BRINDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Brinde
        {
            get { return  brinde; }
            set {  brinde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVEPRINCIPAL
        /// Comentário: 
        /// </summary>
        private string chaveprincipal;
        [XmlElement(ElementName = "CHAVEPRINCIPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Chaveprincipal
        {
            get { return  chaveprincipal; }
            set {  chaveprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBASE
        /// Comentário: 
        /// </summary>
        private string codbase;
        [XmlElement(ElementName = "CODBASE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codbase
        {
            get { return  codbase; }
            set {  codbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODCOMBO
        /// Comentário: Código da política de combo.
        /// </summary>
        private decimal codcombo;
        [XmlElement(ElementName = "CODCOMBO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcombo
        {
            get { return  codcombo; }
            set {  codcombo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCONTO
        /// Comentário: Código da política de desconto.
        /// </summary>
        private decimal coddesconto;
        [XmlElement(ElementName = "CODDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddesconto
        {
            get { return  coddesconto; }
            set {  coddesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITENTEITEMPEDIDO
        /// Comentário: Código emite item pedido.
        /// </summary>
        private decimal codemitenteitempedido;
        [XmlElement(ElementName = "CODEMITENTEITEMPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemitenteitempedido
        {
            get { return  codemitenteitempedido; }
            set {  codemitenteitempedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALRETIRA
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFORMULA
        /// Comentário: 
        /// </summary>
        private string codformula;
        [XmlElement(ElementName = "CODFORMULA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codformula
        {
            get { return  codformula; }
            set {  codformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODICMTAB
        /// Comentário: 
        /// </summary>
        private decimal codicmtab;
        [XmlElement(ElementName = "CODICMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codicmtab
        {
            get { return  codicmtab; }
            set {  codicmtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIMP
        /// Comentário: Código impressão
        /// </summary>
        private decimal codimp;
        [XmlElement(ElementName = "CODIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codimp
        {
            get { return  codimp; }
            set {  codimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Comentário: 
        /// </summary>
        private decimal codmaquina;
        [XmlElement(ElementName = "CODMAQUINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codmaquina
        {
            get { return  codmaquina; }
            set {  codmaquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDAESTRAGEIRA
        /// Comentário: Guarda código da moeda estrageira no momento da venda
        /// </summary>
        private decimal codmoedaestrageira;
        [XmlElement(ElementName = "CODMOEDAESTRAGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmoedaestrageira
        {
            get { return  codmoedaestrageira; }
            set {  codmoedaestrageira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOFERTAORIG
        /// Comentário: Codigo da oferta
        /// </summary>
        private decimal codofertaorig;
        [XmlElement(ElementName = "CODOFERTAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codofertaorig
        {
            get { return  codofertaorig; }
            set {  codofertaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRECOFIXO
        /// Comentário: Código preço fixo.
        /// </summary>
        private decimal codprecofixo;
        [XmlElement(ElementName = "CODPRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Codprecofixo
        {
            get { return  codprecofixo; }
            set {  codprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODTINTA
        /// Comentário: 
        /// </summary>
        private string codprodtinta;
        [XmlElement(ElementName = "CODPRODTINTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codprodtinta
        {
            get { return  codprodtinta; }
            set {  codprodtinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODST
        /// Comentário: 
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
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
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CUSTOFINEST
        /// Comentário: 
        /// </summary>
        private decimal custofinest;
        [XmlElement(ElementName = "CUSTOFINEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofinest
        {
            get { return  custofinest; }
            set {  custofinest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTENTREGA
        /// Comentário: Data de entrega do item
        /// </summary>
        private DateTime? dtentrega;
        [XmlElement(ElementName = "DTENTREGA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentrega
        {
            get { return  dtentrega; }
            set {  dtentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Comentário: DATA DE EXPORTAÇÃO DO ORÇAMENTO
        /// </summary>
        private DateTime? dtexportacao;
        [XmlElement(ElementName = "DTEXPORTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacao
        {
            get { return  dtexportacao; }
            set {  dtexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Comentário: Data última alteração.
        /// </summary>
        private DateTime? dtultalter;
        [XmlElement(ElementName = "DTULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalter
        {
            get { return  dtultalter; }
            set {  dtultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANCODPROD
        /// Comentário: Código EAN item do contrato. 
        /// </summary>
        private decimal eancodprod;
        [XmlElement(ElementName = "EANCODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eancodprod
        {
            get { return  eancodprod; }
            set {  eancodprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Comentário: STATUS DO REGISTRO, INDICA SE O REGISTRO FOI EXPORTADO
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORPRECO
        /// Comentário: Índice que se aplica ao preço de venda.
        /// </summary>
        private decimal fatorpreco;
        [XmlElement(ElementName = "FATORPRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Fatorpreco
        {
            get { return  fatorpreco; }
            set {  fatorpreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMANEGOCIACAO
        /// Comentário: Forma de negociação.
        /// </summary>
        private string formanegociacao;
        [XmlElement(ElementName = "FORMANEGOCIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Formanegociacao
        {
            get { return  formanegociacao; }
            set {  formanegociacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAGNRE_CNPJCLIENTE
        /// Comentário: Campo para definir se a GNRE será paga pelo cliente. 
        /// </summary>
        private string geragnre_cnpjcliente;
        [XmlElement(ElementName = "GERAGNRE_CNPJCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geragnre_Cnpjcliente
        {
            get { return  geragnre_cnpjcliente; }
            set {  geragnre_cnpjcliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOFATURAMENTO
        /// Comentário: Grupo Faturamento
        /// </summary>
        private string grupofaturamento;
        [XmlElement(ElementName = "GRUPOFATURAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Grupofaturamento
        {
            get { return  grupofaturamento; }
            set {  grupofaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRESSORESTAURANTE
        /// Comentário: Status de impressão do item
        /// </summary>
        private string impressorestaurante;
        [XmlElement(ElementName = "IMPRESSORESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impressorestaurante
        {
            get { return  impressorestaurante; }
            set {  impressorestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPRIMERESTAURANTE
        /// Comentário: Embalagem permite impressão restaurante
        /// </summary>
        private string imprimerestaurante;
        [XmlElement(ElementName = "IMPRIMERESTAURANTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Imprimerestaurante
        {
            get { return  imprimerestaurante; }
            set {  imprimerestaurante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IVA
        /// Comentário: 
        /// </summary>
        private decimal iva;
        [XmlElement(ElementName = "IVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Iva
        {
            get { return  iva; }
            set {  iva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LETRACOMISS
        /// Comentário: Letra de comissão por lucratividade. 
        /// </summary>
        private string letracomiss;
        [XmlElement(ElementName = "LETRACOMISS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Letracomiss
        {
            get { return  letracomiss; }
            set {  letracomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: MARGEM
        /// Comentário: 
        /// </summary>
        private decimal margem;
        [XmlElement(ElementName = "MARGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Margem
        {
            get { return  margem; }
            set {  margem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: Matrícula.
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MELPRECOFIXO
        /// Comentário: 
        /// </summary>
        private decimal melprecofixo;
        [XmlElement(ElementName = "MELPRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Melprecofixo
        {
            get { return  melprecofixo; }
            set {  melprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MELUSAPRECOFIXO
        /// Comentário: 
        /// </summary>
        private string melusaprecofixo;
        [XmlElement(ElementName = "MELUSAPRECOFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Melusaprecofixo
        {
            get { return  melusaprecofixo; }
            set {  melusaprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NEGOCIACAOPOSTERIOR
        /// Comentário: Negociação Posterior.
        /// </summary>
        private string negociacaoposterior;
        [XmlElement(ElementName = "NEGOCIACAOPOSTERIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Negociacaoposterior
        {
            get { return  negociacaoposterior; }
            set {  negociacaoposterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROETIQIMPRESSA
        /// Comentário: 
        /// </summary>
        private decimal numeroetiqimpressa;
        [XmlElement(ElementName = "NUMEROETIQIMPRESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Numeroetiqimpressa
        {
            get { return  numeroetiqimpressa; }
            set {  numeroetiqimpressa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFICHAORIG
        /// Comentário: Número da ficha de origem.
        /// </summary>
        private decimal numfichaorig;
        [XmlElement(ElementName = "NUMFICHAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numfichaorig
        {
            get { return  numfichaorig; }
            set {  numfichaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITEMORCA
        /// Comentário: Número item orçamento cliente.
        /// </summary>
        private decimal numitemorca;
        [XmlElement(ElementName = "NUMITEMORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numitemorca
        {
            get { return  numitemorca; }
            set {  numitemorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLISTA
        /// Comentário: Número da Lista de Presente
        /// </summary>
        private decimal numlista;
        [XmlElement(ElementName = "NUMLISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numlista
        {
            get { return  numlista; }
            set {  numlista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: Número do lote.
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
        /// Propriedade referente ao campo: NUMORCA
        /// Comentário: 
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCAORIG
        /// Comentário: Número orçamento de origem.
        /// </summary>
        private decimal numorcaorig;
        [XmlElement(ElementName = "NUMORCAORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numorcaorig
        {
            get { return  numorcaorig; }
            set {  numorcaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQCESTA
        /// Comentário: Número de sequência da cesta básica.
        /// </summary>
        private decimal numseqcesta;
        [XmlElement(ElementName = "NUMSEQCESTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseqcesta
        {
            get { return  numseqcesta; }
            set {  numseqcesta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQFORMULA
        /// Comentário: 
        /// </summary>
        private decimal numseqformula;
        [XmlElement(ElementName = "NUMSEQFORMULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseqformula
        {
            get { return  numseqformula; }
            set {  numseqformula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQIMPRESSAO
        /// Comentário: Sequência de impressão
        /// </summary>
        private decimal numseqimpressao;
        [XmlElement(ElementName = "NUMSEQIMPRESSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqimpressao
        {
            get { return  numseqimpressao; }
            set {  numseqimpressao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQITEMCONTRATO
        /// Comentário: Número da Sequência do Item no Contrato
        /// </summary>
        private decimal numseqitemcontrato;
        [XmlElement(ElementName = "NUMSEQITEMCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqitemcontrato
        {
            get { return  numseqitemcontrato; }
            set {  numseqitemcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBAREBCMV
        /// Comentário: 
        /// </summary>
        private decimal numverbarebcmv;
        [XmlElement(ElementName = "NUMVERBAREBCMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numverbarebcmv
        {
            get { return  numverbarebcmv; }
            set {  numverbarebcmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: Observação de Item da Ficha.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMST
        /// Comentário: Origem do cálculo de ST
        /// </summary>
        private string origemst;
        [XmlElement(ElementName = "ORIGEMST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemst
        {
            get { return  origemst; }
            set {  origemst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAUTA
        /// Comentário: 
        /// </summary>
        private decimal pauta;
        [XmlElement(ElementName = "PAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pauta
        {
            get { return  pauta; }
            set {  pauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PBASERCA
        /// Comentário: 
        /// </summary>
        private decimal pbaserca;
        [XmlElement(ElementName = "PBASERCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pbaserca
        {
            get { return  pbaserca; }
            set {  pbaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PBONIFIC
        /// Comentário: Valor do item bonificado
        /// </summary>
        private decimal pbonific;
        [XmlElement(ElementName = "PBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pbonific
        {
            get { return  pbonific; }
            set {  pbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal perbonific;
        [XmlElement(ElementName = "PERBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perbonific
        {
            get { return  perbonific; }
            set {  perbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAGREGADORST
        /// Comentário: 
        /// </summary>
        private decimal percagregadorst;
        [XmlElement(ElementName = "PERCAGREGADORST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percagregadorst
        {
            get { return  percagregadorst; }
            set {  percagregadorst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERED
        /// Comentário: 
        /// </summary>
        private decimal percbasered;
        [XmlElement(ElementName = "PERCBASERED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbasered
        {
            get { return  percbasered; }
            set {  percbasered = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDST
        /// Comentário: 
        /// </summary>
        private decimal percbaseredst;
        [XmlElement(ElementName = "PERCBASEREDST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredst
        {
            get { return  percbaseredst; }
            set {  percbaseredst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASEREDSTFONTE
        /// Comentário: 
        /// </summary>
        private decimal percbaseredstfonte;
        [XmlElement(ElementName = "PERCBASEREDSTFONTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbaseredstfonte
        {
            get { return  percbaseredstfonte; }
            set {  percbaseredstfonte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC_POLITICA
        /// Comentário: Percentual por Política de Desconto.
        /// </summary>
        private decimal percdesc_politica;
        [XmlElement(ElementName = "PERCDESC_POLITICA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdesc_Politica
        {
            get { return  percdesc_politica; }
            set {  percdesc_politica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCQUANT
        /// Comentário: Percentual de Desconto por Quantidade.
        /// </summary>
        private decimal percdescquant;
        [XmlElement(ElementName = "PERCDESCQUANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percdescquant
        {
            get { return  percdescquant; }
            set {  percdescquant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDIFALIQUOTAS
        /// Comentário: Percentual de diferença de tributação.
        /// </summary>
        private decimal percdifaliquotas;
        [XmlElement(ElementName = "PERCDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdifaliquotas
        {
            get { return  percdifaliquotas; }
            set {  percdifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCIPI
        /// Comentário: 
        /// </summary>
        private decimal percipi;
        [XmlElement(ElementName = "PERCIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percipi
        {
            get { return  percipi; }
            set {  percipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCISS
        /// Comentário: 
        /// </summary>
        private decimal perciss;
        [XmlElement(ElementName = "PERCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perciss
        {
            get { return  perciss; }
            set {  perciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Comentário: 
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMPROF
        /// Comentário: 
        /// </summary>
        private decimal percomprof;
        [XmlElement(ElementName = "PERCOMPROF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percomprof
        {
            get { return  percomprof; }
            set {  percomprof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMSUP
        /// Comentário: 
        /// </summary>
        private decimal percomsup;
        [XmlElement(ElementName = "PERCOMSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomsup
        {
            get { return  percomsup; }
            set {  percomsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMTAB
        /// Comentário: 
        /// </summary>
        private decimal percomtab;
        [XmlElement(ElementName = "PERCOMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomtab
        {
            get { return  percomtab; }
            set {  percomtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM2
        /// Comentário: Indica a comissão do primeiro profissional.
        /// </summary>
        private decimal percom2;
        [XmlElement(ElementName = "PERCOM2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom2
        {
            get { return  percom2; }
            set {  percom2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM3
        /// Comentário: Indica a comissão do segundo profissional.
        /// </summary>
        private decimal percom3;
        [XmlElement(ElementName = "PERCOM3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom3
        {
            get { return  percom3; }
            set {  percom3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM4
        /// Comentário: Indica a comissão do terceiro profissional.
        /// </summary>
        private decimal percom4;
        [XmlElement(ElementName = "PERCOM4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percom4
        {
            get { return  percom4; }
            set {  percom4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVENDA
        /// Comentário: Indica o percentual negociado na venda.
        /// </summary>
        private decimal percvenda;
        [XmlElement(ElementName = "PERCVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percvenda
        {
            get { return  percvenda; }
            set {  percvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC
        /// Comentário: 
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCAUX
        /// Comentário: 
        /// </summary>
        private decimal perdescaux;
        [XmlElement(ElementName = "PERDESCAUX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescaux
        {
            get { return  perdescaux; }
            set {  perdescaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCAVISTA
        /// Comentário: Percentual de desconta à vista.
        /// </summary>
        private decimal perdescavista;
        [XmlElement(ElementName = "PERDESCAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescavista
        {
            get { return  perdescavista; }
            set {  perdescavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCOM
        /// Comentário: 
        /// </summary>
        private decimal perdesccom;
        [XmlElement(ElementName = "PERDESCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdesccom
        {
            get { return  perdesccom; }
            set {  perdesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCCUSTO
        /// Comentário: 
        /// </summary>
        private decimal perdesccusto;
        [XmlElement(ElementName = "PERDESCCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdesccusto
        {
            get { return  perdesccusto; }
            set {  perdesccusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal perdescfin;
        [XmlElement(ElementName = "PERDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perdescfin
        {
            get { return  perdescfin; }
            set {  perdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFLEX
        /// Comentário: 
        /// </summary>
        private decimal perdescflex;
        [XmlElement(ElementName = "PERDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescflex
        {
            get { return  perdescflex; }
            set {  perdescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCISENTOICMS
        /// Comentário: 
        /// </summary>
        private decimal perdescisentoicms;
        [XmlElement(ElementName = "PERDESCISENTOICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perdescisentoicms
        {
            get { return  perdescisentoicms; }
            set {  perdescisentoicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCNEGOCIADO
        /// Comentário: Percentudal de desconto negociado.
        /// </summary>
        private decimal perdescnegociado;
        [XmlElement(ElementName = "PERDESCNEGOCIADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescnegociado
        {
            get { return  perdescnegociado; }
            set {  perdescnegociado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCPAUTA
        /// Comentário: Percentual de desconto utilizado para produtos com pauta.
        /// </summary>
        private decimal perdescpauta;
        [XmlElement(ElementName = "PERDESCPAUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdescpauta
        {
            get { return  perdescpauta; }
            set {  perdescpauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCPOLITICA
        /// Comentário: Indica o percentual de desconto política. 
        /// </summary>
        private decimal perdescpolitica;
        [XmlElement(ElementName = "PERDESCPOLITICA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdescpolitica
        {
            get { return  perdescpolitica; }
            set {  perdescpolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCTAB
        /// Comentário: 
        /// </summary>
        private decimal perdesctab;
        [XmlElement(ElementName = "PERDESCTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perdesctab
        {
            get { return  perdesctab; }
            set {  perdesctab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETECMV
        /// Comentário: 
        /// </summary>
        private decimal perfretecmv;
        [XmlElement(ElementName = "PERFRETECMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfretecmv
        {
            get { return  perfretecmv; }
            set {  perfretecmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERREDCOMISS
        /// Comentário: 
        /// </summary>
        private decimal perredcomiss;
        [XmlElement(ElementName = "PERREDCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perredcomiss
        {
            get { return  perredcomiss; }
            set {  perredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERREDCOMISSSUP
        /// Comentário: 
        /// </summary>
        private decimal perredcomisssup;
        [XmlElement(ElementName = "PERREDCOMISSSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perredcomisssup
        {
            get { return  perredcomisssup; }
            set {  perredcomisssup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOBRUTO
        /// Comentário: 
        /// </summary>
        private decimal pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POLITICAPRIORITARIA
        /// Comentário: Indica que a política de desconto é prioritária.
        /// </summary>
        private string politicaprioritaria;
        [XmlElement(ElementName = "POLITICAPRIORITARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Politicaprioritaria
        {
            get { return  politicaprioritaria; }
            set {  politicaprioritaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORIGINAL
        /// Comentário: 
        /// </summary>
        private decimal poriginal;
        [XmlElement(ElementName = "PORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Poriginal
        {
            get { return  poriginal; }
            set {  poriginal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMEDIO
        /// Comentário: 
        /// </summary>
        private decimal prazomedio;
        [XmlElement(ElementName = "PRAZOMEDIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomedio
        {
            get { return  prazomedio; }
            set {  prazomedio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFIXO
        /// Comentário: Preço Fixo.
        /// </summary>
        private decimal precofixo;
        [XmlElement(ElementName = "PRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Precofixo
        {
            get { return  precofixo; }
            set {  precofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODDESCRICAOCONTRATO
        /// Comentário: Indica a especificação do Contrato. 
        /// </summary>
        private string proddescricaocontrato;
        [XmlElement(ElementName = "PRODDESCRICAOCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Proddescricaocontrato
        {
            get { return  proddescricaocontrato; }
            set {  proddescricaocontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,19)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAAUTPECAS
        /// Comentário: Preço de tabela para auto peças.
        /// </summary>
        private decimal ptabelaautpecas;
        [XmlElement(ElementName = "PTABELAAUTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaautpecas
        {
            get { return  ptabelaautpecas; }
            set {  ptabelaautpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,19)]
        public decimal Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAANTERIOR
        /// Comentário: Indica o preço de venda anterior. 
        /// </summary>
        private decimal pvendaanterior;
        [XmlElement(ElementName = "PVENDAANTERIOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaanterior
        {
            get { return  pvendaanterior; }
            set {  pvendaanterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC
        /// Comentário: Preço de Venda Atacado.
        /// </summary>
        private decimal pvendaatac;
        [XmlElement(ElementName = "PVENDAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendaatac
        {
            get { return  pvendaatac; }
            set {  pvendaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDABASE
        /// Comentário: 
        /// </summary>
        private decimal pvendabase;
        [XmlElement(ElementName = "PVENDABASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendabase
        {
            get { return  pvendabase; }
            set {  pvendabase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA1
        /// Comentário: Valor do preço a vista, para realização de cálculo de comissão sobre preço a vista. 
        /// </summary>
        private decimal pvenda1;
        [XmlElement(ElementName = "PVENDA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda1
        {
            get { return  pvenda1; }
            set {  pvenda1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Comentário: Quantidade do item no orçamento..
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
        /// Propriedade referente ao campo: QTCX
        /// Comentário: Quantidade de caixas.
        /// </summary>
        private decimal qtcx;
        [XmlElement(ElementName = "QTCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtcx
        {
            get { return  qtcx; }
            set {  qtcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIASENTREGAITEM
        /// Comentário: Qtde de dias para entregar o produto sem estoque
        /// </summary>
        private decimal qtdiasentregaitem;
        [XmlElement(ElementName = "QTDIASENTREGAITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtdiasentregaitem
        {
            get { return  qtdiasentregaitem; }
            set {  qtdiasentregaitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTREGAR
        /// Comentário: Quantidade a ser Entregue.
        /// </summary>
        private decimal qtentregar;
        [XmlElement(ElementName = "QTENTREGAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentregar
        {
            get { return  qtentregar; }
            set {  qtentregar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTREGUE
        /// Comentário: 
        /// </summary>
        private decimal qtentregue;
        [XmlElement(ElementName = "QTENTREGUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentregue
        {
            get { return  qtentregue; }
            set {  qtentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENTREGUEAUX
        /// Comentário: 
        /// </summary>
        private decimal qtentregueaux;
        [XmlElement(ElementName = "QTENTREGUEAUX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtentregueaux
        {
            get { return  qtentregueaux; }
            set {  qtentregueaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFALTA
        /// Comentário: Quantidade da falta do item no orçamento.
        /// </summary>
        private decimal qtfalta;
        [XmlElement(ElementName = "QTFALTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtfalta
        {
            get { return  qtfalta; }
            set {  qtfalta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTIMEDIATA
        /// Comentário: Quantidade de Entrega Imediata.
        /// </summary>
        private decimal qtimediata;
        [XmlElement(ElementName = "QTIMEDIATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtimediata
        {
            get { return  qtimediata; }
            set {  qtimediata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINIMAATACADO
        /// Comentário: Quantidade Mínima de Atacado.
        /// </summary>
        private decimal qtminimaatacado;
        [XmlElement(ElementName = "QTMINIMAATACADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtminimaatacado
        {
            get { return  qtminimaatacado; }
            set {  qtminimaatacado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPECAS
        /// Comentário: Quantidade de peças.
        /// </summary>
        private decimal qtpecas;
        [XmlElement(ElementName = "QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Qtpecas
        {
            get { return  qtpecas; }
            set {  qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPOSTERIOR
        /// Comentário: Quantidade de Entrega Posterior.
        /// </summary>
        private decimal qtposterior;
        [XmlElement(ElementName = "QTPOSTERIOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtposterior
        {
            get { return  qtposterior; }
            set {  qtposterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRETIRA1
        /// Comentário: Quantidade a ser retirada na filial número 1.
        /// </summary>
        private decimal qtretira1;
        [XmlElement(ElementName = "QTRETIRA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtretira1
        {
            get { return  qtretira1; }
            set {  qtretira1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRETIRA2
        /// Comentário: Quantidade a ser retirada na filial número 2.
        /// </summary>
        private decimal qtretira2;
        [XmlElement(ElementName = "QTRETIRA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtretira2
        {
            get { return  qtretira2; }
            set {  qtretira2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRETIRA3
        /// Comentário: Quantidade a ser retirada na filial número 3.
        /// </summary>
        private decimal qtretira3;
        [XmlElement(ElementName = "QTRETIRA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtretira3
        {
            get { return  qtretira3; }
            set {  qtretira3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTUNITEMB
        /// Comentário: Indica a quantidade uitaria da embalagem.
        /// </summary>
        private decimal qtunitemb;
        [XmlElement(ElementName = "QTUNITEMB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtunitemb
        {
            get { return  qtunitemb; }
            set {  qtunitemb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFCOR
        /// Comentário: 
        /// </summary>
        private string refcor;
        [XmlElement(ElementName = "REFCOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Refcor
        {
            get { return  refcor; }
            set {  refcor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RP_IMEDIATA
        /// Comentário: Retira posterior
        /// </summary>
        private string rp_imediata;
        [XmlElement(ElementName = "RP_IMEDIATA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rp_Imediata
        {
            get { return  rp_imediata; }
            set {  rp_imediata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIGLAQUALIDADE
        /// Comentário: 
        /// </summary>
        private string siglaqualidade;
        [XmlElement(ElementName = "SIGLAQUALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Siglaqualidade
        {
            get { return  siglaqualidade; }
            set {  siglaqualidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Comentário: 
        /// </summary>
        private decimal st;
        [XmlElement(ElementName = "ST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal St
        {
            get { return  st; }
            set {  st = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSSUCATA
        /// Comentário: Status Sucata.
        /// </summary>
        private decimal statussucata;
        [XmlElement(ElementName = "STATUSSUCATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Statussucata
        {
            get { return  statussucata; }
            set {  statussucata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STCLIENTEGNRE
        /// Comentário: Valor ST cliente GNRE. 
        /// </summary>
        private decimal stclientegnre;
        [XmlElement(ElementName = "STCLIENTEGNRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stclientegnre
        {
            get { return  stclientegnre; }
            set {  stclientegnre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STPBASERCA
        /// Comentário: Valor do ST na base RCA
        /// </summary>
        private decimal stpbaserca;
        [XmlElement(ElementName = "STPBASERCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stpbaserca
        {
            get { return  stpbaserca; }
            set {  stpbaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STPTABELA
        /// Comentário: Valor do ST no preço de  Tabela
        /// </summary>
        private decimal stptabela;
        [XmlElement(ElementName = "STPTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Stptabela
        {
            get { return  stptabela; }
            set {  stptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXACASOMOEDAREAL
        /// Comentário: Taxa caso a moeda escolhida seja o real.
        /// </summary>
        private decimal taxacasomoedareal;
        [XmlElement(ElementName = "TAXACASOMOEDAREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Taxacasomoedareal
        {
            get { return  taxacasomoedareal; }
            set {  taxacasomoedareal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCAPLICADO
        /// Comentário: 
        /// </summary>
        private string tipodescaplicado;
        [XmlElement(ElementName = "TIPODESCAPLICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipodescaplicado
        {
            get { return  tipodescaplicado; }
            set {  tipodescaplicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENTREGA
        /// Comentário: Indica o tipo de entrega do Produto. (RP-Retira posterior/EN-Entrega Normal. 
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
        /// Propriedade referente ao campo: TIPOMERC
        /// Comentário: Tipo de Mercadoria.
        /// </summary>
        private string tipomerc;
        [XmlElement(ElementName = "TIPOMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipomerc
        {
            get { return  tipomerc; }
            set {  tipomerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPESO
        /// Comentário: 
        /// </summary>
        private string tipopeso;
        [XmlElement(ElementName = "TIPOPESO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopeso
        {
            get { return  tipopeso; }
            set {  tipopeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRUNCARITEM
        /// Comentário: Indica se trunca o varlor total do item.
        /// </summary>
        private string truncaritem;
        [XmlElement(ElementName = "TRUNCARITEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Truncaritem
        {
            get { return  truncaritem; }
            set {  truncaritem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXVENDA
        /// Comentário: 
        /// </summary>
        private decimal txvenda;
        [XmlElement(ElementName = "TXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Txvenda
        {
            get { return  txvenda; }
            set {  txvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Comentário: Unidade da fórmula de tinta
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESCCOMPLEMENTO
        /// Comentário: Valor de acréscimo do complemento.
        /// </summary>
        private decimal vlacresccomplemento;
        [XmlElement(ElementName = "VLACRESCCOMPLEMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlacresccomplemento
        {
            get { return  vlacresccomplemento; }
            set {  vlacresccomplemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLACRESFRETEKG
        /// Comentário: Valor de acréscimo Frete (kG).
        /// </summary>
        private decimal vlacresfretekg;
        [XmlElement(ElementName = "VLACRESFRETEKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlacresfretekg
        {
            get { return  vlacresfretekg; }
            set {  vlacresfretekg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal vlbonific;
        [XmlElement(ElementName = "VLBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlbonific
        {
            get { return  vlbonific; }
            set {  vlbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOCONT
        /// Comentário: 
        /// </summary>
        private decimal vlcustocont;
        [XmlElement(ElementName = "VLCUSTOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustocont
        {
            get { return  vlcustocont; }
            set {  vlcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal vlcustofin;
        [XmlElement(ElementName = "VLCUSTOFIN", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Vlcustofin
        {
            get { return  vlcustofin; }
            set {  vlcustofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal vlcustoreal;
        [XmlElement(ElementName = "VLCUSTOREAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Vlcustoreal
        {
            get { return  vlcustoreal; }
            set {  vlcustoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUSTOREP
        /// Comentário: 
        /// </summary>
        private decimal vlcustorep;
        [XmlElement(ElementName = "VLCUSTOREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcustorep
        {
            get { return  vlcustorep; }
            set {  vlcustorep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCCOM
        /// Comentário: 
        /// </summary>
        private decimal vldesccom;
        [XmlElement(ElementName = "VLDESCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldesccom
        {
            get { return  vldesccom; }
            set {  vldesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCCUSTOCMV
        /// Comentário: Valor desconto custo CMV. 
        /// </summary>
        private decimal vldesccustocmv;
        [XmlElement(ElementName = "VLDESCCUSTOCMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldesccustocmv
        {
            get { return  vldesccustocmv; }
            set {  vldesccustocmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal vldescfin;
        [XmlElement(ElementName = "VLDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescfin
        {
            get { return  vldescfin; }
            set {  vldescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCFLEX
        /// Comentário: 
        /// </summary>
        private decimal vldescflex;
        [XmlElement(ElementName = "VLDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescflex
        {
            get { return  vldescflex; }
            set {  vldescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCICMISENCAO
        /// Comentário: 
        /// </summary>
        private decimal vldescicmisencao;
        [XmlElement(ElementName = "VLDESCICMISENCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescicmisencao
        {
            get { return  vldescicmisencao; }
            set {  vldescicmisencao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCPISSUFRAMA
        /// Comentário: 
        /// </summary>
        private decimal vldescpissuframa;
        [XmlElement(ElementName = "VLDESCPISSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescpissuframa
        {
            get { return  vldescpissuframa; }
            set {  vldescpissuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCRODAPE
        /// Comentário: 
        /// </summary>
        private decimal vldescrodape;
        [XmlElement(ElementName = "VLDESCRODAPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescrodape
        {
            get { return  vldescrodape; }
            set {  vldescrodape = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCSUFRAMA
        /// Comentário: Valor desconto suframa. 
        /// </summary>
        private decimal vldescsuframa;
        [XmlElement(ElementName = "VLDESCSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescsuframa
        {
            get { return  vldescsuframa; }
            set {  vldescsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFALIQUOTAS
        /// Comentário: Valor da diferença de aliquotas.
        /// </summary>
        private decimal vldifaliquotas;
        [XmlElement(ElementName = "VLDIFALIQUOTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldifaliquotas
        {
            get { return  vldifaliquotas; }
            set {  vldifaliquotas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: 
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISS
        /// Comentário: 
        /// </summary>
        private decimal vliss;
        [XmlElement(ElementName = "VLISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vliss
        {
            get { return  vliss; }
            set {  vliss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDCMVSIMPLESNAC
        /// Comentário: Valor de redução no CMV para cliente Simples Nacional.
        /// </summary>
        private decimal vlredcmvsimplesnac;
        [XmlElement(ElementName = "VLREDCMVSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredcmvsimplesnac
        {
            get { return  vlredcmvsimplesnac; }
            set {  vlredcmvsimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDCOMISS
        /// Comentário: 
        /// </summary>
        private decimal vlredcomiss;
        [XmlElement(ElementName = "VLREDCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredcomiss
        {
            get { return  vlredcomiss; }
            set {  vlredcomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDCOMISSSUP
        /// Comentário: 
        /// </summary>
        private decimal vlredcomisssup;
        [XmlElement(ElementName = "VLREDCOMISSSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredcomisssup
        {
            get { return  vlredcomisssup; }
            set {  vlredcomisssup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREDPVENDASIMPLESNA
        /// Comentário: Valor de redução no preço de venda para cliente Simples Nacional.
        /// </summary>
        private decimal vlredpvendasimplesna;
        [XmlElement(ElementName = "VLREDPVENDASIMPLESNA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlredpvendasimplesna
        {
            get { return  vlredpvendasimplesna; }
            set {  vlredpvendasimplesna = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREPASSE
        /// Comentário: 
        /// </summary>
        private decimal vlrepasse;
        [XmlElement(ElementName = "VLREPASSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrepasse
        {
            get { return  vlrepasse; }
            set {  vlrepasse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRMOEDAESTRAGEIRA
        /// Comentário: Guarda valor da conversão do real para moeda extrangeira
        /// </summary>
        private decimal vlrmoedaestrageira;
        [XmlElement(ElementName = "VLRMOEDAESTRAGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrmoedaestrageira
        {
            get { return  vlrmoedaestrageira; }
            set {  vlrmoedaestrageira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMV
        /// Comentário: 
        /// </summary>
        private decimal vlverbacmv;
        [XmlElement(ElementName = "VLVERBACMV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlverbacmv
        {
            get { return  vlverbacmv; }
            set {  vlverbacmv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBACMVCLI
        /// Comentário: Valor verba CMV do cliente. 
        /// </summary>
        private decimal vlverbacmvcli;
        [XmlElement(ElementName = "VLVERBACMVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlverbacmvcli
        {
            get { return  vlverbacmvcli; }
            set {  vlverbacmvcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMEDESEJADO
        /// Comentário: 
        /// </summary>
        private decimal volumedesejado;
        [XmlElement(ElementName = "VOLUMEDESEJADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Volumedesejado
        {
            get { return  volumedesejado; }
            set {  volumedesejado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOrcavendai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORCAVENDAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOrcavendai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrcavendai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOrcavendai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrcavendai>(where);
        }

        #endregion
    }
}
