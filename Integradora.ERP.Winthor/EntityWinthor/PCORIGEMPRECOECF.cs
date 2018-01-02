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
    /// Classe referente a tabela PCOrigemprecoecf
    /// </summary>
    [XmlType("PCORIGEMPRECOECF")]
    public class PCOrigemprecoecf : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUTORIZACAO
        /// Coment�rio: Campo para armazenar o c�digo da autoriza��o utilizado.
        /// </summary>
        private decimal codautorizacao;
        [XmlElement(ElementName = "CODAUTORIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codautorizacao
        {
            get { return  codautorizacao; }
            set {  codautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCFLEX
        /// Coment�rio: Campo para armazenar o c�digo da pol�tica de desconto flex�vel utilizada.
        /// </summary>
        private decimal coddescflex;
        [XmlElement(ElementName = "CODDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddescflex
        {
            get { return  coddescflex; }
            set {  coddescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCPTABELA
        /// Coment�rio: Campo para armazenar o c�digo da pol�tica de desconto que influenciou o pre�o de tabela.
        /// </summary>
        private decimal coddescptabela;
        [XmlElement(ElementName = "CODDESCPTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddescptabela
        {
            get { return  coddescptabela; }
            set {  coddescptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCVOLPTABELA
        /// Coment�rio: Campo para armazenar o c�digo da pol�tica de desconto por volume que influenciou o pre�o de tabela.
        /// </summary>
        private decimal coddescvolptabela;
        [XmlElement(ElementName = "CODDESCVOLPTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddescvolptabela
        {
            get { return  coddescvolptabela; }
            set {  coddescvolptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCVOLUME
        /// Coment�rio: Campo para armazenar o c�digo da pol�tica de desconto autom�tico por volume.
        /// </summary>
        private decimal coddescvolume;
        [XmlElement(ElementName = "CODDESCVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddescvolume
        {
            get { return  coddescvolume; }
            set {  coddescvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEMITENTE
        /// Coment�rio: Indica o funcion�rio que incluiu o item.
        /// </summary>
        private decimal codemitente;
        [XmlElement(ElementName = "CODEMITENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codemitente
        {
            get { return  codemitente; }
            set {  codemitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial de venda.
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
        /// Propriedade referente ao campo: CODFILIALNF
        /// Coment�rio: Indica o c�digo da filial virtual.
        /// </summary>
        private string codfilialnf;
        [XmlElement(ElementName = "CODFILIALNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialnf
        {
            get { return  codfilialnf; }
            set {  codfilialnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCX
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccx;
        [XmlElement(ElementName = "CODFUNCCX", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunccx
        {
            get { return  codfunccx; }
            set {  codfunccx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRECOFIXO
        /// Coment�rio: Campo para armazenar o c�digo da pol�tica de pre�o fixo utilizado.
        /// </summary>
        private decimal codprecofixo;
        [XmlElement(ElementName = "CODPRECOFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprecofixo
        {
            get { return  codprecofixo; }
            set {  codprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Campo para armazenar o c�digo do produto da origem de pre�o.
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
        /// Propriedade referente ao campo: COLUNAPRECO
        /// Coment�rio: Campo para armazenar o n�mero da coluna de pre�o utilizada.
        /// </summary>
        private decimal colunapreco;
        [XmlElement(ElementName = "COLUNAPRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Colunapreco
        {
            get { return  colunapreco; }
            set {  colunapreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Indica a data da inclus�o do Item.
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
        /// Propriedade referente ao campo: DTEXPORTACAO
        /// Coment�rio: Data em que a expporta��o do BD local ocorreu.
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
        /// Propriedade referente ao campo: DTFIMAUTOR
        /// Coment�rio: Campo para armazenar a data final da autoriza��o.
        /// </summary>
        private DateTime? dtfimautor;
        [XmlElement(ElementName = "DTFIMAUTOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimautor
        {
            get { return  dtfimautor; }
            set {  dtfimautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMDESCFLEX
        /// Coment�rio: Campo para armazenar a data final do desconto Flex�vel.
        /// </summary>
        private DateTime? dtfimdescflex;
        [XmlElement(ElementName = "DTFIMDESCFLEX", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimdescflex
        {
            get { return  dtfimdescflex; }
            set {  dtfimdescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMDESCPTABELA
        /// Coment�rio: Campo para armazenar a data final da pol�tica de pre�o de influenciou no pre�o de tabela.
        /// </summary>
        private DateTime? dtfimdescptabela;
        [XmlElement(ElementName = "DTFIMDESCPTABELA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimdescptabela
        {
            get { return  dtfimdescptabela; }
            set {  dtfimdescptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMDESCVOLUME
        /// Coment�rio: Campo para armazenar a data final do desconto autom�tico por volume.
        /// </summary>
        private DateTime? dtfimdescvolume;
        [XmlElement(ElementName = "DTFIMDESCVOLUME", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimdescvolume
        {
            get { return  dtfimdescvolume; }
            set {  dtfimdescvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMOFERTA
        /// Coment�rio: Campo para armazenar a data final do pre�o de oferta.
        /// </summary>
        private DateTime? dtfimoferta;
        [XmlElement(ElementName = "DTFIMOFERTA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimoferta
        {
            get { return  dtfimoferta; }
            set {  dtfimoferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOAUTOR
        /// Coment�rio: Campo para armazenar a data inicial da autoriza��o.
        /// </summary>
        private DateTime? dtinicioautor;
        [XmlElement(ElementName = "DTINICIOAUTOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicioautor
        {
            get { return  dtinicioautor; }
            set {  dtinicioautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIODESCFLEX
        /// Coment�rio: Campo para armazenar a data inicial do desconto flex�vel.
        /// </summary>
        private DateTime? dtiniciodescflex;
        [XmlElement(ElementName = "DTINICIODESCFLEX", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciodescflex
        {
            get { return  dtiniciodescflex; }
            set {  dtiniciodescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIODESCPTABELA
        /// Coment�rio: Campo para armazenar a data inicial da pol�tica de pre�o de influenciou no pre�o de tabela.
        /// </summary>
        private DateTime? dtiniciodescptabela;
        [XmlElement(ElementName = "DTINICIODESCPTABELA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciodescptabela
        {
            get { return  dtiniciodescptabela; }
            set {  dtiniciodescptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIODESCVOLUME
        /// Coment�rio: Campo para armazenar a data inicial do desconto autom�tico por volume.
        /// </summary>
        private DateTime? dtiniciodescvolume;
        [XmlElement(ElementName = "DTINICIODESCVOLUME", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciodescvolume
        {
            get { return  dtiniciodescvolume; }
            set {  dtiniciodescvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOOFERTA
        /// Coment�rio: Campo para armazenar a data inicial do pre�o de oferta.
        /// </summary>
        private DateTime? dtiniciooferta;
        [XmlElement(ElementName = "DTINICIOOFERTA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciooferta
        {
            get { return  dtiniciooferta; }
            set {  dtiniciooferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: 
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
        /// Coment�rio: Campo para armazenar o fator de pre�o por embalagem utilizado sobre o pre�o de tabela normal.
        /// </summary>
        private decimal fatorpreco;
        [XmlElement(ElementName = "FATORPRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Fatorpreco
        {
            get { return  fatorpreco; }
            set {  fatorpreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIMINTERVALO
        /// Coment�rio: Indica a qtde Final.
        /// </summary>
        private decimal fimintervalo;
        [XmlElement(ElementName = "FIMINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Fimintervalo
        {
            get { return  fimintervalo; }
            set {  fimintervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIMINTERVALOAUTORI
        /// Coment�rio: Indica o fim da quantidade da autoriza��o.
        /// </summary>
        private decimal fimintervaloautori;
        [XmlElement(ElementName = "FIMINTERVALOAUTORI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Fimintervaloautori
        {
            get { return  fimintervaloautori; }
            set {  fimintervaloautori = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADO
        /// Coment�rio: 
        /// </summary>
        private string importado;
        [XmlElement(ElementName = "IMPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importado
        {
            get { return  importado; }
            set {  importado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INICIOINTERVALO
        /// Coment�rio: Indica a qtde inicial.
        /// </summary>
        private decimal iniciointervalo;
        [XmlElement(ElementName = "INICIOINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Iniciointervalo
        {
            get { return  iniciointervalo; }
            set {  iniciointervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INICIOINTERVALOAUTORI
        /// Coment�rio: Indica o in�cio da quantidade da autoriza��o.
        /// </summary>
        private decimal iniciointervaloautori;
        [XmlElement(ElementName = "INICIOINTERVALOAUTORI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Iniciointervaloautori
        {
            get { return  iniciointervaloautori; }
            set {  iniciointervaloautori = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: Numero do Pedido.
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
        /// Propriedade referente ao campo: NUMPEDECF
        /// Coment�rio: Campo para armazenar o n�mero do pedido ao qual os dados da origem de pre�o se referem.
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: Indica a regi�o tabela de pre�o.
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
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: Campo para armazenar o n�mero da seq��ncia do produto no pedido.
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
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Coment�rio: 
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,30)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Coment�rio: Indica a origem do pedido de venda.
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
        /// Propriedade referente ao campo: ORIGEMPRECO
        /// Coment�rio: Campo para armazenar o c�digo da origem do pre�o de tabela. Valores poss�veis s�o: 1, 2, 3, 4, 5, 6, 7, 8, 9 e 10.
        /// </summary>
        private string origempreco;
        [XmlElement(ElementName = "ORIGEMPRECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Origempreco
        {
            get { return  origempreco; }
            set {  origempreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCBALCAO
        /// Coment�rio: Campo para armazenar o percentual de acr�scimo das vendas balc�o.
        /// </summary>
        private decimal percacrescbalcao;
        [XmlElement(ElementName = "PERCACRESCBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percacrescbalcao
        {
            get { return  percacrescbalcao; }
            set {  percacrescbalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCPF
        /// Coment�rio: Campo para armazenar o percentual de acr�scimo ao pre�o de venda caso o cliente seja pessoa f�sica.
        /// </summary>
        private decimal percacrescpf;
        [XmlElement(ElementName = "PERCACRESCPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percacrescpf
        {
            get { return  percacrescpf; }
            set {  percacrescpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCAUTOR
        /// Coment�rio: Campo para armazenar o percentual de desconto da autoriza��o.
        /// </summary>
        private decimal percdescautor;
        [XmlElement(ElementName = "PERCDESCAUTOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percdescautor
        {
            get { return  percdescautor; }
            set {  percdescautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFLEX
        /// Coment�rio: Campo para armazenar o percentual de desconto flex�vel utilizado.
        /// </summary>
        private decimal percdescflex;
        [XmlElement(ElementName = "PERCDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescflex
        {
            get { return  percdescflex; }
            set {  percdescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCPTABELA
        /// Coment�rio: Campo para armazenar o percentual de desconto que influencia sobre o pre�o de tabela.
        /// </summary>
        private decimal percdescptabela;
        [XmlElement(ElementName = "PERCDESCPTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescptabela
        {
            get { return  percdescptabela; }
            set {  percdescptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCVOLUME
        /// Coment�rio: Campo para armazenar o percentual de desconto autom�tico por volume.
        /// </summary>
        private decimal percdescvolume;
        [XmlElement(ElementName = "PERCDESCVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescvolume
        {
            get { return  percdescvolume; }
            set {  percdescvolume = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE
        /// Coment�rio: Campo para armazenar o percentual de frete aplicado no pre�o de venda.
        /// </summary>
        private decimal percfrete;
        [XmlElement(ElementName = "PERCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percfrete
        {
            get { return  percfrete; }
            set {  percfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPLPAG
        /// Coment�rio: Campo para armazenar o percentual de acr�scimo para os planos de pagamento.
        /// </summary>
        private decimal percplpag;
        [XmlElement(ElementName = "PERCPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percplpag
        {
            get { return  percplpag; }
            set {  percplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCRAMOATIV
        /// Coment�rio: Campo para armazenar o percentual de acr�scimo aplicado no pre�o de venda, registrado no ramo de atividade do cliente.
        /// </summary>
        private decimal percramoativ;
        [XmlElement(ElementName = "PERCRAMOATIV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percramoativ
        {
            get { return  percramoativ; }
            set {  percramoativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORIGINAL
        /// Coment�rio: Campo para armazenar o pre�o original do produto.
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
        /// Propriedade referente ao campo: QTMINATACADO
        /// Coment�rio: Campo para armazenar a quantidade m�nima para aplica��o do pre�o de varejo ou de atacado.
        /// </summary>
        private decimal qtminatacado;
        [XmlElement(ElementName = "QTMINATACADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtminatacado
        {
            get { return  qtminatacado; }
            set {  qtminatacado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBROKER
        /// Coment�rio: Campo para armazenar o tipo de Broker utilizado: Padr�o ou Mabel.
        /// </summary>
        private string tipobroker;
        [XmlElement(ElementName = "TIPOBROKER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipobroker
        {
            get { return  tipobroker; }
            set {  tipobroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCFLEX
        /// Coment�rio: Campo para armazenar o tipo de desconto flex�vel aplicado no pre�o de venda. Valores poss�veis: 1, 2, 3 e 4.
        /// </summary>
        private string tipodescflex;
        [XmlElement(ElementName = "TIPODESCFLEX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipodescflex
        {
            get { return  tipodescflex; }
            set {  tipodescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Coment�rio: Campo para armazenar o tipo de frete aplicado no pre�o de venda. Valores poss�veis: 1-Abate frete no balc�o e 2-Abate frete FOB.
        /// </summary>
        private string tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATRIBUTPORUF
        /// Coment�rio: Campo para indicar se o produto usa ou n�o tributa��o por estado.
        /// </summary>
        private string usatributporuf;
        [XmlElement(ElementName = "USATRIBUTPORUF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatributporuf
        {
            get { return  usatributporuf; }
            set {  usatributporuf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCICMS
        /// Coment�rio: Campo para armazenar o valor do desconto de icms aplicado ao pre�o de venda.
        /// </summary>
        private decimal vldescicms;
        [XmlElement(ElementName = "VLDESCICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldescicms
        {
            get { return  vldescicms; }
            set {  vldescicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIFALIQUOTAS
        /// Coment�rio: Valor do diferencial de al�quotas.
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
        /// Coment�rio: Campo para armazenar o valor do ipi tribut�ria aplicado ao pre�o de venda.
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
        /// Propriedade referente ao campo: VLST
        /// Coment�rio: Campo para armazenar o valor da substitui��o tribut�ria aplicado ao pre�o de venda.
        /// </summary>
        private decimal vlst;
        [XmlElement(ElementName = "VLST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlst
        {
            get { return  vlst; }
            set {  vlst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSUFRAMA
        /// Coment�rio: Campo para armazenar o valor do suframa aplicado ao pre�o de venda.
        /// </summary>
        private decimal vlsuframa;
        [XmlElement(ElementName = "VLSUFRAMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlsuframa
        {
            get { return  vlsuframa; }
            set {  vlsuframa = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOrigemprecoecf()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORIGEMPRECOECF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOrigemprecoecf> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrigemprecoecf>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOrigemprecoecf> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrigemprecoecf>(where);
        }

        #endregion
    }
}
