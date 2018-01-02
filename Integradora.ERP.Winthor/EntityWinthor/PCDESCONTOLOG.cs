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
    /// Classe referente a tabela PCDescontolog
    /// </summary>
    [XmlType("PCDESCONTOLOG")]
    public class PCDescontolog : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTERAPTABELA
        /// Comentário: Alterar Preço de Tabela. 
        /// </summary>
        private string alteraptabela;
        [XmlElement(ElementName = "ALTERAPTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alteraptabela
        {
            get { return  alteraptabela; }
            set {  alteraptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APENASPLPAGMAX
        /// Comentário: Utilizr plano de pagamento máximo na venda.
        /// </summary>
        private string apenasplpagmax;
        [XmlElement(ElementName = "APENASPLPAGMAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Apenasplpagmax
        {
            get { return  apenasplpagmax; }
            set {  apenasplpagmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICADESCONTO
        /// Comentário: Aplica Desconto Automático. 
        /// </summary>
        private string aplicadesconto;
        [XmlElement(ElementName = "APLICADESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicadesconto
        {
            get { return  aplicadesconto; }
            set {  aplicadesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICADESCSIMPLESNACIONAL
        /// Comentário: Aplica Desconto simples nacional.
        /// </summary>
        private string aplicadescsimplesnacional;
        [XmlElement(ElementName = "APLICADESCSIMPLESNACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicadescsimplesnacional
        {
            get { return  aplicadescsimplesnacional; }
            set {  aplicadescsimplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AREAATUACAO
        /// Comentário: Indica a área de atuação do RCA.
        /// </summary>
        private string areaatuacao;
        [XmlElement(ElementName = "AREAATUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Areaatuacao
        {
            get { return  areaatuacao; }
            set {  areaatuacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASECREDDEBRCA
        /// Comentário: Crédito RCA. 
        /// </summary>
        private string basecreddebrca;
        [XmlElement(ElementName = "BASECREDDEBRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Basecreddebrca
        {
            get { return  basecreddebrca; }
            set {  basecreddebrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Comentário: Classe de Venda do Cliente. 
        /// </summary>
        private string classevenda;
        [XmlElement(ElementName = "CLASSEVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classevenda
        {
            get { return  classevenda; }
            set {  classevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Comentário: Ramo de Atividade. 
        /// </summary>
        private decimal codativ;
        [XmlElement(ElementName = "CODATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codativ
        {
            get { return  codativ; }
            set {  codativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Comentário: Código da Categoria. 
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Código do Cliente. 
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
        /// Propriedade referente ao campo: CODCLICONV
        /// Comentário: CÓDIGO DO CLIENTE CONVENIADO
        /// </summary>
        private decimal codcliconv;
        [XmlElement(ElementName = "CODCLICONV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcliconv
        {
            get { return  codcliconv; }
            set {  codcliconv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCONTO
        /// Comentário: Chave Primária. 
        /// </summary>
        private decimal coddesconto;
        [XmlElement(ElementName = "CODDESCONTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Coddesconto
        {
            get { return  coddesconto; }
            set {  coddesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: Código do Departamento. 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica o código da filial.|Campo do tipo caracter, de tamanho 2. 
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código do Fornecedor. 
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
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Comentário: Usuário Exclusão. 
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Comentário: Código do Func. que realizou o lançamento. 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Comentário: Indica o código do funcionario da última alteração.
        /// </summary>
        private decimal codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Comentário: Indica o código do grupo de desconto.
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOREST
        /// Comentário: Código do grupo de restrição
        /// </summary>
        private decimal codgruporest;
        [XmlElement(ElementName = "CODGRUPOREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgruporest
        {
            get { return  codgruporest; }
            set {  codgruporest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIDENTIFICADOR
        /// Comentário: Código identificador de politicas
        /// </summary>
        private decimal codidentificador;
        [XmlElement(ElementName = "CODIDENTIFICADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codidentificador
        {
            get { return  codidentificador; }
            set {  codidentificador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMARCA
        /// Comentário: Código da marca
        /// </summary>
        private decimal codmarca;
        [XmlElement(ElementName = "CODMARCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmarca
        {
            get { return  codmarca; }
            set {  codmarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: Código do Plano de Pagamento. 
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
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: Código da Praça. 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do Produto. 
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
        /// Propriedade referente ao campo: CODPRODCB
        /// Comentário: Código do Produto que é item da Cesta. 
        /// </summary>
        private decimal codprodcb;
        [XmlElement(ElementName = "CODPRODCB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodcb
        {
            get { return  codprodcb; }
            set {  codprodcb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODPRINC
        /// Comentário: Código do Produto Principal. 
        /// </summary>
        private decimal codprodprinc;
        [XmlElement(ElementName = "CODPRODPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodprinc
        {
            get { return  codprodprinc; }
            set {  codprodprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDE
        /// Comentário: Código da rede de Clientes
        /// </summary>
        private decimal codrede;
        [XmlElement(ElementName = "CODREDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrede
        {
            get { return  codrede; }
            set {  codrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: Código da Seção. 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: Código do Supervisor. 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Código do Usuário. 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERACALCGIROMEDIC
        /// Comentário: Considera no Cálculo do Giro (Medicamentos)
        /// </summary>
        private string consideracalcgiromedic;
        [XmlElement(ElementName = "CONSIDERACALCGIROMEDIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideracalcgiromedic
        {
            get { return  consideracalcgiromedic; }
            set {  consideracalcgiromedic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CREDITASOBREPOLITICA
        /// Comentário: Credita RCA na venda com preço maior que política de desconto. 
        /// </summary>
        private string creditasobrepolitica;
        [XmlElement(ElementName = "CREDITASOBREPOLITICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Creditasobrepolitica
        {
            get { return  creditasobrepolitica; }
            set {  creditasobrepolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALANC
        /// Comentário: Data do Lançamento. 
        /// </summary>
        private DateTime? datalanc;
        [XmlElement(ElementName = "DATALANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datalanc
        {
            get { return  datalanc; }
            set {  datalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAULTALTER
        /// Comentário: Indica a data da última alteração.
        /// </summary>
        private DateTime? dataultalter;
        [XmlElement(ElementName = "DATAULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataultalter
        {
            get { return  dataultalter; }
            set {  dataultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: Data Fim. 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Comentário: Data Fim. 
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
        /// Comentário: Data Inicio. 
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
        /// Propriedade referente ao campo: FISCALCAIXA
        /// Comentário: SE O DESCONTO É SOMENTE PARA O FISCAL DE CAIXA
        /// </summary>
        private string fiscalcaixa;
        [XmlElement(ElementName = "FISCALCAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fiscalcaixa
        {
            get { return  fiscalcaixa; }
            set {  fiscalcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Comentário: Número do Orçamento. 
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
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: Código da Região. 
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
        /// Propriedade referente ao campo: ORIGEMPED
        /// Comentário: Origem do Pedido. 
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCCOMPROFISSIONALMINIMO
        /// Comentário: Valor mínimo do percentual de comissão de profissional permitido para orçamento. 
        /// </summary>
        private decimal percccomprofissionalminimo;
        [XmlElement(ElementName = "PERCCCOMPROFISSIONALMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percccomprofissionalminimo
        {
            get { return  percccomprofissionalminimo; }
            set {  percccomprofissionalminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: Percentual de Desconto. 
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFIN
        /// Comentário: Percentual de Desconto Financeiro. 
        /// </summary>
        private decimal percdescfin;
        [XmlElement(ElementName = "PERCDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescfin
        {
            get { return  percdescfin; }
            set {  percdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFORNEC
        /// Comentário: Percentual de Desconto Fornecedor. 
        /// </summary>
        private decimal percdescfornec;
        [XmlElement(ElementName = "PERCDESCFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescfornec
        {
            get { return  percdescfornec; }
            set {  percdescfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCMAX
        /// Comentário: Percentual máximo de desconto no preço à vista
        /// </summary>
        private decimal percdescmax;
        [XmlElement(ElementName = "PERCDESCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescmax
        {
            get { return  percdescmax; }
            set {  percdescmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMEXT
        /// Comentário: % Comissao vendedor externo.
        /// </summary>
        private decimal percomext;
        [XmlElement(ElementName = "PERCOMEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percomext
        {
            get { return  percomext; }
            set {  percomext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMINT
        /// Comentário: % Comissao vendedor interno.
        /// </summary>
        private decimal percommint;
        [XmlElement(ElementName = "PERCOMMINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percommint
        {
            get { return  percommint; }
            set {  percommint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMREP
        /// Comentário: % Comissao representante.
        /// </summary>
        private decimal percomrep;
        [XmlElement(ElementName = "PERCOMREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percomrep
        {
            get { return  percomrep; }
            set {  percomrep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFORNEC
        /// Comentário: Percentual de Desconto do Fornecedor. 
        /// </summary>
        private decimal perdescfornec;
        [XmlElement(ElementName = "PERDESCFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescfornec
        {
            get { return  perdescfornec; }
            set {  perdescfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFIXO
        /// Comentário: PREÇO DESCONTO
        /// </summary>
        private decimal precofixo;
        [XmlElement(ElementName = "PRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Precofixo
        {
            get { return  precofixo; }
            set {  precofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMAXIMAPEDIDO
        /// Comentário: Indica a quantidade máxima do pedido.|Campo do tipo numérico, de tamanho 10, com 4 casas decimais. 
        /// </summary>
        private decimal qtdemaximapedido;
        [XmlElement(ElementName = "QTDEMAXIMAPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdemaximapedido
        {
            get { return  qtdemaximapedido; }
            set {  qtdemaximapedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMAXIMAPOLITICA
        /// Comentário: Indica a quantidade máxima da política.|Campo do tipo numérico, de tamanho 10, com 4 casas decimais. 
        /// </summary>
        private decimal qtdemaximapolitica;
        [XmlElement(ElementName = "QTDEMAXIMAPOLITICA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdemaximapolitica
        {
            get { return  qtdemaximapolitica; }
            set {  qtdemaximapolitica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMINDESCONTO
        /// Comentário: QUANTIDADE MINÍMA PARA SER CONCEDIDO O DESCONTO
        /// </summary>
        private decimal qtdemindesconto;
        [XmlElement(ElementName = "QTDEMINDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtdemindesconto
        {
            get { return  qtdemindesconto; }
            set {  qtdemindesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTFIM
        /// Comentário: Quantidade final para desconto
        /// </summary>
        private decimal qtfim;
        [XmlElement(ElementName = "QTFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtfim
        {
            get { return  qtfim; }
            set {  qtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTINI
        /// Comentário: Quantidade inicial para desconto
        /// </summary>
        private decimal qtini;
        [XmlElement(ElementName = "QTINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtini
        {
            get { return  qtini; }
            set {  qtini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBCATEGORIA
        /// Comentário: SUBCATEGORIA DO PRODUTO
        /// </summary>
        private decimal subcategoria;
        [XmlElement(ElementName = "SUBCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Subcategoria
        {
            get { return  subcategoria; }
            set {  subcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: Tipo de Desconto. 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAPLICDESCONTOCB
        /// Comentário: Tipo de Aplicação do Desconto. 
        /// </summary>
        private string tipoaplicdescontocb;
        [XmlElement(ElementName = "TIPOAPLICDESCONTOCB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoaplicdescontocb
        {
            get { return  tipoaplicdescontocb; }
            set {  tipoaplicdescontocb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCARGA
        /// Comentário: Tipo de Entrega. 
        /// </summary>
        private string tipocarga;
        [XmlElement(ElementName = "TIPOCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocarga
        {
            get { return  tipocarga; }
            set {  tipocarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCLIMED
        /// Comentário: Tipo Cliente. 
        /// </summary>
        private string tipoclimed;
        [XmlElement(ElementName = "TIPOCLIMED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoclimed
        {
            get { return  tipoclimed; }
            set {  tipoclimed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOGRUPOREST
        /// Comentário: Tipo do grupo de restrição
        /// </summary>
        private string tipogruporest;
        [XmlElement(ElementName = "TIPOGRUPOREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipogruporest
        {
            get { return  tipogruporest; }
            set {  tipogruporest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Comentário: Tipo de Venda. 
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Comentário: Unidade da Federação. 
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
        /// Propriedade referente ao campo: UTILIZADESCREDE
        /// Comentário: Utiliza Desconto Rede. 
        /// </summary>
        private string utilizadescrede;
        [XmlElement(ElementName = "UTILIZADESCREDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadescrede
        {
            get { return  utilizadescrede; }
            set {  utilizadescrede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRMAXIMO
        /// Comentário: Valor máximo para desconto
        /// </summary>
        private decimal vlrmaximo;
        [XmlElement(ElementName = "VLRMAXIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrmaximo
        {
            get { return  vlrmaximo; }
            set {  vlrmaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRMINIMO
        /// Comentário: Valor mínimo para desconto
        /// </summary>
        private decimal vlrminimo;
        [XmlElement(ElementName = "VLRMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrminimo
        {
            get { return  vlrminimo; }
            set {  vlrminimo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDescontolog()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESCONTOLOG";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDescontolog> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDescontolog>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDescontolog> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDescontolog>(where);
        }

        #endregion
    }
}
