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
    /// Classe referente a tabela PCPedido
    /// </summary>
    [XmlType("PCPEDIDO")]
    public class PCPedido : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTERAPERCPRESUMIDO
        /// Coment�rio: 
        /// </summary>
        private string alterapercpresumido;
        [XmlElement(ElementName = "ALTERAPERCPRESUMIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alterapercpresumido
        {
            get { return  alterapercpresumido; }
            set {  alterapercpresumido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAPERCDESCCOMCAB
        /// Coment�rio: 
        /// </summary>
        private string aplicapercdesccomcab;
        [XmlElement(ElementName = "APLICAPERCDESCCOMCAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicapercdesccomcab
        {
            get { return  aplicapercdesccomcab; }
            set {  aplicapercdesccomcab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAPERCFRETECAB
        /// Coment�rio: 
        /// </summary>
        private string aplicapercfretecab;
        [XmlElement(ElementName = "APLICAPERCFRETECAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicapercfretecab
        {
            get { return  aplicapercfretecab; }
            set {  aplicapercfretecab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTOMATICO
        /// Coment�rio: Indica se o pedido e automatico.
        /// </summary>
        private string automatico;
        [XmlElement(ElementName = "AUTOMATICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Automatico
        {
            get { return  automatico; }
            set {  automatico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AVALIACAOVENDA
        /// Coment�rio: Per�odo de Avalia��o de venda para calculo da sugest�o de compra
        /// </summary>
        private string avaliacaovenda;
        [XmlElement(ElementName = "AVALIACAOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Avaliacaovenda
        {
            get { return  avaliacaovenda; }
            set {  avaliacaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCDESPFINPRAZOPGTO
        /// Coment�rio: Calcular vendor por prazo de pagamento
        /// </summary>
        private string calcdespfinprazopgto;
        [XmlElement(ElementName = "CALCDESPFINPRAZOPGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcdespfinprazopgto
        {
            get { return  calcdespfinprazopgto; }
            set {  calcdespfinprazopgto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMDESC
        /// Coment�rio: Considera desconto para calculo do IPI.
        /// </summary>
        private string calcipicomdesc;
        [XmlElement(ElementName = "CALCIPICOMDESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipicomdesc
        {
            get { return  calcipicomdesc; }
            set {  calcipicomdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMFRETEFOB
        /// Coment�rio: Considera frete FOB para calculo do IPI.
        /// </summary>
        private string calcipicomfretefob;
        [XmlElement(ElementName = "CALCIPICOMFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipicomfretefob
        {
            get { return  calcipicomfretefob; }
            set {  calcipicomfretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCIPICOMFRETENF
        /// Coment�rio: Considera frete CIF para calculo do IPI.
        /// </summary>
        private string calcipicomfretenf;
        [XmlElement(ElementName = "CALCIPICOMFRETENF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcipicomfretenf
        {
            get { return  calcipicomfretenf; }
            set {  calcipicomfretenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCPISCOFINSBASERED
        /// Coment�rio: Indica o c�digo da transportadora.
        /// </summary>
        private string calcpiscofinsbasered;
        [XmlElement(ElementName = "CALCPISCOFINSBASERED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcpiscofinsbasered
        {
            get { return  calcpiscofinsbasered; }
            set {  calcpiscofinsbasered = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSTGUIAALIQEXT
        /// Coment�rio: Calcula ST guia al�quota externa.
        /// </summary>
        private string calcstguiaaliqext;
        [XmlElement(ElementName = "CALCSTGUIAALIQEXT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcstguiaaliqext
        {
            get { return  calcstguiaaliqext; }
            set {  calcstguiaaliqext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCSUFRAMASOBREPLIQUIDO
        /// Coment�rio: Deduzir descontos para calcular SUFRAMA.
        /// </summary>
        private string calcsuframasobrepliquido;
        [XmlElement(ElementName = "CALCSUFRAMASOBREPLIQUIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcsuframasobrepliquido
        {
            get { return  calcsuframasobrepliquido; }
            set {  calcsuframasobrepliquido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULAPISCOFINSCOMIPI
        /// Coment�rio: Incluir IPI para calcular PIS/COFINS.
        /// </summary>
        private string calculapiscofinscomipi;
        [XmlElement(ElementName = "CALCULAPISCOFINSCOMIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calculapiscofinscomipi
        {
            get { return  calculapiscofinscomipi; }
            set {  calculapiscofinscomipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULARIPIPESOLIQ
        /// Coment�rio: Calcula IPI com base no peso l�quido.
        /// </summary>
        private string calcularipipesoliq;
        [XmlElement(ElementName = "CALCULARIPIPESOLIQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcularipipesoliq
        {
            get { return  calcularipipesoliq; }
            set {  calcularipipesoliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CANALCONFERENCIA
        /// Coment�rio: Canal de confer�ncia da receita
        /// </summary>
        private decimal canalconferencia;
        [XmlElement(ElementName = "CANALCONFERENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Canalconferencia
        {
            get { return  canalconferencia; }
            set {  canalconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIDEST
        /// Coment�rio: Cliente destino do pedido
        /// </summary>
        private decimal codclidest;
        [XmlElement(ElementName = "CODCLIDEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codclidest
        {
            get { return  codclidest; }
            set {  codclidest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOMPRADOR
        /// Coment�rio: Codigo do comprador.
        /// </summary>
        private decimal codcomprador;
        [XmlElement(ElementName = "CODCOMPRADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcomprador
        {
            get { return  codcomprador; }
            set {  codcomprador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: Codigo da conta.
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESPACHANTE
        /// Coment�rio: C�digo do fornecedor do tipo Despachante.
        /// </summary>
        private decimal coddespachante;
        [XmlElement(ElementName = "CODDESPACHANTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddespachante
        {
            get { return  coddespachante; }
            set {  coddespachante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESPACHANTE2
        /// Coment�rio: C�dido de fornecedor despachante Courier
        /// </summary>
        private decimal coddespachante2;
        [XmlElement(ElementName = "CODDESPACHANTE2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddespachante2
        {
            get { return  coddespachante2; }
            set {  coddespachante2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEDITAL
        /// Coment�rio: C�digo do edital
        /// </summary>
        private decimal codedital;
        [XmlElement(ElementName = "CODEDITAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Codedital
        {
            get { return  codedital; }
            set {  codedital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Codigo da filial.
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
        /// Propriedade referente ao campo: CODFILIALPRINC
        /// Coment�rio: N�mero da filial principal pedido de compra.
        /// </summary>
        private string codfilialprinc;
        [XmlElement(ElementName = "CODFILIALPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialprinc
        {
            get { return  codfilialprinc; }
            set {  codfilialprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: Codigo do fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFABRIC
        /// Coment�rio: C�digo do Fornecedor do tipo fabricante.
        /// </summary>
        private decimal codfornecfabric;
        [XmlElement(ElementName = "CODFORNECFABRIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecfabric
        {
            get { return  codfornecfabric; }
            set {  codfornecfabric = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECFRETE
        /// Coment�rio: Indica o c�digo da transportadora.
        /// </summary>
        private decimal codfornecfrete;
        [XmlElement(ElementName = "CODFORNECFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfornecfrete
        {
            get { return  codfornecfrete; }
            set {  codfornecfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECIMPORT
        /// Coment�rio: C�digo do Fornecedor do tipo importador.
        /// </summary>
        private decimal codfornecimport;
        [XmlElement(ElementName = "CODFORNECIMPORT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecimport
        {
            get { return  codfornecimport; }
            set {  codfornecimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECNOTIF
        /// Coment�rio: Fornecedor a ser notificado do embarque
        /// </summary>
        private decimal codfornecnotif;
        [XmlElement(ElementName = "CODFORNECNOTIF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecnotif
        {
            get { return  codfornecnotif; }
            set {  codfornecnotif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECOUTRASDESP
        /// Coment�rio: Indica o c�digo do fornecedor de outras despesas.
        /// </summary>
        private decimal codfornecoutrasdesp;
        [XmlElement(ElementName = "CODFORNECOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecoutrasdesp
        {
            get { return  codfornecoutrasdesp; }
            set {  codfornecoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECPROD
        /// Coment�rio: C�digo do Fornecedor do tipo produtor.
        /// </summary>
        private decimal codfornecprod;
        [XmlElement(ElementName = "CODFORNECPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecprod
        {
            get { return  codfornecprod; }
            set {  codfornecprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECRCA
        /// Coment�rio: C�digo do representante comercial;.
        /// </summary>
        private decimal codfornecrca;
        [XmlElement(ElementName = "CODFORNECRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecrca
        {
            get { return  codfornecrca; }
            set {  codfornecrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECSTGUIA
        /// Coment�rio: Indica o c�digo fornecedor ST guia.
        /// </summary>
        private decimal codfornecstguia;
        [XmlElement(ElementName = "CODFORNECSTGUIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornecstguia
        {
            get { return  codfornecstguia; }
            set {  codfornecstguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: Codigo do funcionario.
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
        /// Propriedade referente ao campo: CODFUNCALTERACAO
        /// Coment�rio: Codigo do funcionario da alteracao.
        /// </summary>
        private decimal codfuncalteracao;
        [XmlElement(ElementName = "CODFUNCALTERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncalteracao
        {
            get { return  codfuncalteracao; }
            set {  codfuncalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCENVIOEDI
        /// Coment�rio: Codigo do funcionario que enviou arquivo EDI (rotina 2425).
        /// </summary>
        private decimal codfuncenvioedi;
        [XmlElement(ElementName = "CODFUNCENVIOEDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncenvioedi
        {
            get { return  codfuncenvioedi; }
            set {  codfuncenvioedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINCLUSAO
        /// Coment�rio: Codigo do funcionario da inclusao.
        /// </summary>
        private decimal codfuncinclusao;
        [XmlElement(ElementName = "CODFUNCINCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncinclusao
        {
            get { return  codfuncinclusao; }
            set {  codfuncinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBERA
        /// Coment�rio: Codigo do funcionario que liberou o pedido (rotina 215).
        /// </summary>
        private decimal codfunclibera;
        [XmlElement(ElementName = "CODFUNCLIBERA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclibera
        {
            get { return  codfunclibera; }
            set {  codfunclibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDA
        /// Coment�rio: Codigo da moeda utilizada para digitar pedido de compra. 
        /// </summary>
        private decimal codmoeda;
        [XmlElement(ElementName = "CODMOEDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmoeda
        {
            get { return  codmoeda; }
            set {  codmoeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDAAVISTA
        /// Coment�rio: C�digo de moeda estrangeira para pagamento a vista
        /// </summary>
        private decimal codmoedaavista;
        [XmlElement(ElementName = "CODMOEDAAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmoedaavista
        {
            get { return  codmoedaavista; }
            set {  codmoedaavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOEDACUSTO
        /// Coment�rio: C�digo Moeda Estrangeira
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
        /// Propriedade referente ao campo: CODPAISAQUISICAO
        /// Coment�rio: C�digo do pa�s de aquisi��o.
        /// </summary>
        private decimal codpaisaquisicao;
        [XmlElement(ElementName = "CODPAISAQUISICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpaisaquisicao
        {
            get { return  codpaisaquisicao; }
            set {  codpaisaquisicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAISORIGEM
        /// Coment�rio: C�digo do pa�s de origem.
        /// </summary>
        private decimal codpaisorigem;
        [XmlElement(ElementName = "CODPAISORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpaisorigem
        {
            get { return  codpaisorigem; }
            set {  codpaisorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAISPROC
        /// Coment�rio: C�digo do pa�s de proced�ncia.
        /// </summary>
        private decimal codpaisproc;
        [XmlElement(ElementName = "CODPAISPROC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codpaisproc
        {
            get { return  codpaisproc; }
            set {  codpaisproc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCELA
        /// Coment�rio: C�digo da Parcela. 
        /// </summary>
        private decimal codparcela;
        [XmlElement(ElementName = "CODPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codparcela
        {
            get { return  codparcela; }
            set {  codparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPARCELASTGUIA
        /// Coment�rio: Indica o c�digo parcela ST guia.
        /// </summary>
        private decimal codparcelastguia;
        [XmlElement(ElementName = "CODPARCELASTGUIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codparcelastguia
        {
            get { return  codparcelastguia; }
            set {  codparcelastguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: Codigo do plano de pagamento rotina 256.
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGADIANT
        /// Coment�rio: C�digo do plano de pagamento para modalidade adiantamento.
        /// </summary>
        private decimal codplpagadiant;
        [XmlElement(ElementName = "CODPLPAGADIANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codplpagadiant
        {
            get { return  codplpagadiant; }
            set {  codplpagadiant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGAVISTA
        /// Coment�rio: C�digo do plano de pagamento para modalidade � vista.
        /// </summary>
        private decimal codplpagavista;
        [XmlElement(ElementName = "CODPLPAGAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codplpagavista
        {
            get { return  codplpagavista; }
            set {  codplpagavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPORTOCHEGADA
        /// Coment�rio: C�digo do porto de chegada
        /// </summary>
        private decimal codportochegada;
        [XmlElement(ElementName = "CODPORTOCHEGADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codportochegada
        {
            get { return  codportochegada; }
            set {  codportochegada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPORTONACIONALIZACAO
        /// Coment�rio: C�digo do porto de nacionaliza��o
        /// </summary>
        private decimal codportonacionalizacao;
        [XmlElement(ElementName = "CODPORTONACIONALIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codportonacionalizacao
        {
            get { return  codportonacionalizacao; }
            set {  codportonacionalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPORTOORIGEM
        /// Coment�rio: Porto de origem de embarque
        /// </summary>
        private decimal codportoorigem;
        [XmlElement(ElementName = "CODPORTOORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codportoorigem
        {
            get { return  codportoorigem; }
            set {  codportoorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEGURADORA
        /// Coment�rio: C�digo do fornecedor do tipo Seguradora.
        /// </summary>
        private decimal codseguradora;
        [XmlElement(ElementName = "CODSEGURADORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codseguradora
        {
            get { return  codseguradora; }
            set {  codseguradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTERMINALPORTUARIO
        /// Coment�rio: C�digo do terminal portu�rio
        /// </summary>
        private decimal codterminalportuario;
        [XmlElement(ElementName = "CODTERMINALPORTUARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codterminalportuario
        {
            get { return  codterminalportuario; }
            set {  codterminalportuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSITARIO
        /// Coment�rio: C�digo do fornecedor do tipo Transit�rio.
        /// </summary>
        private decimal codtransitario;
        [XmlElement(ElementName = "CODTRANSITARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtransitario
        {
            get { return  codtransitario; }
            set {  codtransitario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVIA
        /// Coment�rio: C�digo da via de transporte.
        /// </summary>
        private decimal codvia;
        [XmlElement(ElementName = "CODVIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codvia
        {
            get { return  codvia; }
            set {  codvia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFIRMADO
        /// Coment�rio: Define se o pedido foi confirmado pelo fornecedor ap�s a digita��o web dos pre�os da cota��o utilizada.
        /// </summary>
        private string confirmado;
        [XmlElement(ElementName = "CONFIRMADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Confirmado
        {
            get { return  confirmado; }
            set {  confirmado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSFRETEFOBBASESTNF
        /// Coment�rio: Considera Frete FOB base ST NF
        /// </summary>
        private string consfretefobbasestnf;
        [XmlElement(ElementName = "CONSFRETEFOBBASESTNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consfretefobbasestnf
        {
            get { return  consfretefobbasestnf; }
            set {  consfretefobbasestnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSFRETEFOBCALCICMSANTECIP
        /// Coment�rio: Considera frete FOB para o calculo do ICMS antecipado.
        /// </summary>
        private string consfretefobcalcicmsantecip;
        [XmlElement(ElementName = "CONSFRETEFOBCALCICMSANTECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consfretefobcalcicmsantecip
        {
            get { return  consfretefobcalcicmsantecip; }
            set {  consfretefobcalcicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAESTPENDSUGCOMPRA
        /// Coment�rio: Considera estoque pendente de venda na sugest�o de compra
        /// </summary>
        private string consideraestpendsugcompra;
        [XmlElement(ElementName = "CONSIDERAESTPENDSUGCOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideraestpendsugcompra
        {
            get { return  consideraestpendsugcompra; }
            set {  consideraestpendsugcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIPICALCBASECREPRES
        /// Coment�rio: Considera IPI para calculo da base de credito presumido.
        /// </summary>
        private string consipicalcbasecrepres;
        [XmlElement(ElementName = "CONSIPICALCBASECREPRES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consipicalcbasecrepres
        {
            get { return  consipicalcbasecrepres; }
            set {  consipicalcbasecrepres = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIPICALCBASEST
        /// Coment�rio: Considera IPI para calculo da base ST.
        /// </summary>
        private string consipicalcbasest;
        [XmlElement(ElementName = "CONSIPICALCBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consipicalcbasest
        {
            get { return  consipicalcbasest; }
            set {  consipicalcbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSMAIORICMSVLPAUTA
        /// Coment�rio: Calcula ICMS sobre Vl.Pauta maior valor(Importa��o).
        /// </summary>
        private string consmaioricmsvlpauta;
        [XmlElement(ElementName = "CONSMAIORICMSVLPAUTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consmaioricmsvlpauta
        {
            get { return  consmaioricmsvlpauta; }
            set {  consmaioricmsvlpauta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSSTGUIAPISCOFINS
        /// Coment�rio: Considera ST Guia Base do PISCOFINS.
        /// </summary>
        private string consstguiapiscofins;
        [XmlElement(ElementName = "CONSSTGUIAPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consstguiapiscofins
        {
            get { return  consstguiapiscofins; }
            set {  consstguiapiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSSTNFPISCOFINS
        /// Coment�rio: Considerar o ST Nota fiscal no PIS/COFINS.
        /// </summary>
        private string consstnfpiscofins;
        [XmlElement(ElementName = "CONSSTNFPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consstnfpiscofins
        {
            get { return  consstnfpiscofins; }
            set {  consstnfpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAO
        /// Coment�rio: Valor da cota��o escolhida para digita��o do pedido de compra. 
        /// </summary>
        private decimal cotacao;
        [XmlElement(ElementName = "COTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Cotacao
        {
            get { return  cotacao; }
            set {  cotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAOAVISTA
        /// Coment�rio: Cota��o da moeda estrangeira para pagamento a vista
        /// </summary>
        private decimal cotacaoavista;
        [XmlElement(ElementName = "COTACAOAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Cotacaoavista
        {
            get { return  cotacaoavista; }
            set {  cotacaoavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAOCUSTO
        /// Coment�rio: Cota��o Moeda Estrangeira
        /// </summary>
        private decimal cotacaocusto;
        [XmlElement(ElementName = "COTACAOCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Cotacaocusto
        {
            get { return  cotacaocusto; }
            set {  cotacaocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAOPREVISTA
        /// Coment�rio: Cota��o prevista no momento da entrada
        /// </summary>
        private decimal cotacaoprevista;
        [XmlElement(ElementName = "COTACAOPREVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Cotacaoprevista
        {
            get { return  cotacaoprevista; }
            set {  cotacaoprevista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENVIOEDI
        /// Coment�rio: Data de envio EDI (rotina 2425).
        /// </summary>
        private DateTime? dataenvioedi;
        [XmlElement(ElementName = "DATAENVIOEDI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataenvioedi
        {
            get { return  dataenvioedi; }
            set {  dataenvioedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALANC
        /// Coment�rio: . |Campo do tipo data, com valor default SYSDATE
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
        /// Propriedade referente ao campo: DEDFRETECIFCREDPRESICMS
        /// Coment�rio: Considera frete FOB no calculo da base PIS/COFINS
        /// </summary>
        private string dedfretecifcredpresicms;
        [XmlElement(ElementName = "DEDFRETECIFCREDPRESICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dedfretecifcredpresicms
        {
            get { return  dedfretecifcredpresicms; }
            set {  dedfretecifcredpresicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMABCSTALIQ1
        /// Coment�rio: Deduzir SUFRAMA BC ST aliquota interna.
        /// </summary>
        private string deduzirsuframabcstaliq1;
        [XmlElement(ElementName = "DEDUZIRSUFRAMABCSTALIQ1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframabcstaliq1
        {
            get { return  deduzirsuframabcstaliq1; }
            set {  deduzirsuframabcstaliq1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMACALCCREDICM
        /// Coment�rio: Deduzir SUFRAMA credito ICMS.
        /// </summary>
        private string deduzirsuframacalccredicm;
        [XmlElement(ElementName = "DEDUZIRSUFRAMACALCCREDICM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframacalccredicm
        {
            get { return  deduzirsuframacalccredicm; }
            set {  deduzirsuframacalccredicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEDUZIRSUFRAMACALCCREDPIS
        /// Coment�rio: Deduzir SUFRAMA credito PIS/COFINS.
        /// </summary>
        private string deduzirsuframacalccredpis;
        [XmlElement(ElementName = "DEDUZIRSUFRAMACALCCREDPIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Deduzirsuframacalccredpis
        {
            get { return  deduzirsuframacalccredpis; }
            set {  deduzirsuframacalccredpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASAVALIACAOVENDA
        /// Coment�rio: Per�odo de Avalia��o de venda para calculo da sugest�o de compra
        /// </summary>
        private decimal diasavaliacaovenda;
        [XmlElement(ElementName = "DIASAVALIACAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Diasavaliacaovenda
        {
            get { return  diasavaliacaovenda; }
            set {  diasavaliacaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCIMPORTACAO
        /// Coment�rio: Lista de documentos solicitados para embarque
        /// </summary>
        private string docimportacao;
        [XmlElement(ElementName = "DOCIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Docimportacao
        {
            get { return  docimportacao; }
            set {  docimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCHEGADA
        /// Coment�rio: Data de chegada
        /// </summary>
        private DateTime? dtchegada;
        [XmlElement(ElementName = "DTCHEGADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtchegada
        {
            get { return  dtchegada; }
            set {  dtchegada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOMPROVIMPORT
        /// Coment�rio: Data de emiss�o do comprovante de importa��o
        /// </summary>
        private DateTime? dtcomprovimport;
        [XmlElement(ElementName = "DTCOMPROVIMPORT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcomprovimport
        {
            get { return  dtcomprovimport; }
            set {  dtcomprovimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOTACAO
        /// Coment�rio: Campo para armazenar a data da cota��o do pedido de compra.
        /// </summary>
        private DateTime? dtcotacao;
        [XmlElement(ElementName = "DTCOTACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcotacao
        {
            get { return  dtcotacao; }
            set {  dtcotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOTACAOAVISTA
        /// Coment�rio: Data da cota��o da moeda estrangeira
        /// </summary>
        private DateTime? dtcotacaoavista;
        [XmlElement(ElementName = "DTCOTACAOAVISTA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcotacaoavista
        {
            get { return  dtcotacaoavista; }
            set {  dtcotacaoavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOTACAOCUSTO
        /// Coment�rio: Data Cota��o Moeda Estrangeira
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
        /// Propriedade referente ao campo: DTDIFLI
        /// Coment�rio: Data diferimento da LI
        /// </summary>
        private DateTime? dtdifli;
        [XmlElement(ElementName = "DTDIFLI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdifli
        {
            get { return  dtdifli; }
            set {  dtdifli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMBARQUE
        /// Coment�rio: Data de embarque
        /// </summary>
        private DateTime? dtembarque;
        [XmlElement(ElementName = "DTEMBARQUE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtembarque
        {
            get { return  dtembarque; }
            set {  dtembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Coment�rio: Data de emissao do pedido.
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOCONHECEMBARQ
        /// Coment�rio: Data de emiss�o do conhecimento de embarque
        /// </summary>
        private DateTime? dtemissaoconhecembarq;
        [XmlElement(ElementName = "DTEMISSAOCONHECEMBARQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoconhecembarq
        {
            get { return  dtemissaoconhecembarq; }
            set {  dtemissaoconhecembarq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAODOCIMPORT
        /// Coment�rio: Data do documento de importa��o
        /// </summary>
        private DateTime? dtemissaodocimport;
        [XmlElement(ElementName = "DTEMISSAODOCIMPORT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaodocimport
        {
            get { return  dtemissaodocimport; }
            set {  dtemissaodocimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOINVOCE
        /// Coment�rio: Data de emiss�o da fatura comercial.
        /// </summary>
        private DateTime? dtemissaoinvoce;
        [XmlElement(ElementName = "DTEMISSAOINVOCE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaoinvoce
        {
            get { return  dtemissaoinvoce; }
            set {  dtemissaoinvoce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAOPASTA
        /// Coment�rio: Data de emiss�o da pasta/ processo
        /// </summary>
        private DateTime? dtemissaopasta;
        [XmlElement(ElementName = "DTEMISSAOPASTA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissaopasta
        {
            get { return  dtemissaopasta; }
            set {  dtemissaopasta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTRADAESTOQUE
        /// Coment�rio: Data de entrada efetiva no estoque.
        /// </summary>
        private DateTime? dtentradaestoque;
        [XmlElement(ElementName = "DTENTRADAESTOQUE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentradaestoque
        {
            get { return  dtentradaestoque; }
            set {  dtentradaestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENVIODESPACHANTE
        /// Coment�rio: Data de envio de documentos ao despachante
        /// </summary>
        private DateTime? dtenviodespachante;
        [XmlElement(ElementName = "DTENVIODESPACHANTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtenviodespachante
        {
            get { return  dtenviodespachante; }
            set {  dtenviodespachante = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPEDI
        /// Coment�rio: Data de Exporta��o para EDI
        /// </summary>
        private DateTime? dtexpedi;
        [XmlElement(ElementName = "DTEXPEDI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexpedi
        {
            get { return  dtexpedi; }
            set {  dtexpedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFATUR
        /// Coment�rio: Data do faturamento.
        /// </summary>
        private DateTime? dtfatur;
        [XmlElement(ElementName = "DTFATUR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfatur
        {
            get { return  dtfatur; }
            set {  dtfatur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHACE
        /// Coment�rio: Data de fechamento do controle de embarque.
        /// </summary>
        private DateTime? dtfechace;
        [XmlElement(ElementName = "DTFECHACE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechace
        {
            get { return  dtfechace; }
            set {  dtfechace = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLEMISSAOLICENCAIMPORT
        /// Coment�rio: Data de emiss�o da licen�a de importa��o
        /// </summary>
        private DateTime? dtlemissaolicencaimport;
        [XmlElement(ElementName = "DTLEMISSAOLICENCAIMPORT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlemissaolicencaimport
        {
            get { return  dtlemissaolicencaimport; }
            set {  dtlemissaolicencaimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLI
        /// Coment�rio: Data LI
        /// </summary>
        private DateTime? dtli;
        [XmlElement(ElementName = "DTLI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtli
        {
            get { return  dtli; }
            set {  dtli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLIBERA
        /// Coment�rio: Data da liberacao do pedido utilizado na rotina 215.
        /// </summary>
        private DateTime? dtlibera;
        [XmlElement(ElementName = "DTLIBERA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlibera
        {
            get { return  dtlibera; }
            set {  dtlibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNACIONALIZACAO
        /// Coment�rio: Data de nacionaliza��o efetiva da mercadoria.
        /// </summary>
        private DateTime? dtnacionalizacao;
        [XmlElement(ElementName = "DTNACIONALIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnacionalizacao
        {
            get { return  dtnacionalizacao; }
            set {  dtnacionalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVCHEGADA
        /// Coment�rio: Data de previs�o chegada
        /// </summary>
        private DateTime? dtprevchegada;
        [XmlElement(ElementName = "DTPREVCHEGADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevchegada
        {
            get { return  dtprevchegada; }
            set {  dtprevchegada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVEMBARQUE
        /// Coment�rio: Data de previs�o de embarque
        /// </summary>
        private DateTime? dtprevembarque;
        [XmlElement(ElementName = "DTPREVEMBARQUE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevembarque
        {
            get { return  dtprevembarque; }
            set {  dtprevembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVENT
        /// Coment�rio: Data de previsao de entrada.
        /// </summary>
        private DateTime? dtprevent;
        [XmlElement(ElementName = "DTPREVENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevent
        {
            get { return  dtprevent; }
            set {  dtprevent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVENTRADAESTOQUE
        /// Coment�rio: Data de previs�o de entrada no estoque..
        /// </summary>
        private DateTime? dtpreventradaestoque;
        [XmlElement(ElementName = "DTPREVENTRADAESTOQUE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpreventradaestoque
        {
            get { return  dtpreventradaestoque; }
            set {  dtpreventradaestoque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVNACIONALIZACAO
        /// Coment�rio: Data prevista para nacionaliza��o
        /// </summary>
        private DateTime? dtprevnacionalizacao;
        [XmlElement(ElementName = "DTPREVNACIONALIZACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevnacionalizacao
        {
            get { return  dtprevnacionalizacao; }
            set {  dtprevnacionalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPREVPRIMEMBARQUE
        /// Coment�rio: Data de previs�o do primeiro embarque.
        /// </summary>
        private DateTime? dtprevprimembarque;
        [XmlElement(ElementName = "DTPREVPRIMEMBARQUE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprevprimembarque
        {
            get { return  dtprevprimembarque; }
            set {  dtprevprimembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREGISTROCANAL
        /// Coment�rio: Data de registro do canal
        /// </summary>
        private DateTime? dtregistrocanal;
        [XmlElement(ElementName = "DTREGISTROCANAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtregistrocanal
        {
            get { return  dtregistrocanal; }
            set {  dtregistrocanal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: Data de vencimento da parte que vai ser paga a vista.
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
        /// Propriedade referente ao campo: DTVENCLICENCAIMPORT
        /// Coment�rio: Data de vencimento da licen�a de importa��o
        /// </summary>
        private DateTime? dtvenclicencaimport;
        [XmlElement(ElementName = "DTVENCLICENCAIMPORT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenclicencaimport
        {
            get { return  dtvenclicencaimport; }
            set {  dtvenclicencaimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVISTORIAORGAOANUENTE
        /// Coment�rio: Data da vistoria do �rg�o anuente
        /// </summary>
        private DateTime? dtvistoriaorgaoanuente;
        [XmlElement(ElementName = "DTVISTORIAORGAOANUENTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvistoriaorgaoanuente
        {
            get { return  dtvistoriaorgaoanuente; }
            set {  dtvistoriaorgaoanuente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTZONASECUNDARIA
        /// Coment�rio: Data da chegada na zona secund�ria
        /// </summary>
        private DateTime? dtzonasecundaria;
        [XmlElement(ElementName = "DTZONASECUNDARIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtzonasecundaria
        {
            get { return  dtzonasecundaria; }
            set {  dtzonasecundaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENTANTECIP
        /// Coment�rio: Permite entrada antes da data de previsao de entrada.
        /// </summary>
        private string entantecip;
        [XmlElement(ElementName = "ENTANTECIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Entantecip
        {
            get { return  entantecip; }
            set {  entantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EREABASTECIMENTO
        /// Coment�rio: Indica se � de reabastecimento. 
        /// </summary>
        private string ereabastecimento;
        [XmlElement(ElementName = "EREABASTECIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ereabastecimento
        {
            get { return  ereabastecimento; }
            set {  ereabastecimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: Se o pedido ja foi exportado (modulo 25).
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
        /// Propriedade referente ao campo: FRETE
        /// Coment�rio: Tipo de frete.
        /// </summary>
        private string frete;
        [XmlElement(ElementName = "FRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Frete
        {
            get { return  frete; }
            set {  frete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCLANC
        /// Coment�rio: . |Campo do tipo caracter, de tamanho 30. 
        /// </summary>
        private string funclanc;
        [XmlElement(ElementName = "FUNCLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Funclanc
        {
            get { return  funclanc; }
            set {  funclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACPPREV
        /// Coment�rio: DEVE GERAR CONTAS A PAGAR PREVISTO
        /// </summary>
        private string geracpprev;
        [XmlElement(ElementName = "GERACPPREV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracpprev
        {
            get { return  geracpprev; }
            set {  geracpprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAPEDBONIFIC
        /// Coment�rio: Gera Pedido Bonificado Autom�tico
        /// </summary>
        private string gerapedbonific;
        [XmlElement(ElementName = "GERAPEDBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerapedbonific
        {
            get { return  gerapedbonific; }
            set {  gerapedbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORALIBERA
        /// Coment�rio: Hora da liberacao do pedido utilizado na rotina 215.
        /// </summary>
        private string horalibera;
        [XmlElement(ElementName = "HORALIBERA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Horalibera
        {
            get { return  horalibera; }
            set {  horalibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCONTROLEEMBARQUE
        /// Coment�rio: Identifica��o do controle de embarque
        /// </summary>
        private string idcontroleembarque;
        [XmlElement(ElementName = "IDCONTROLEEMBARQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Idcontroleembarque
        {
            get { return  idcontroleembarque; }
            set {  idcontroleembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDPEDIDOMASTER
        /// Coment�rio: Identifica��o Pedido M�ster.
        /// </summary>
        private string idpedidomaster;
        [XmlElement(ElementName = "IDPEDIDOMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Idpedidomaster
        {
            get { return  idpedidomaster; }
            set {  idpedidomaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTACAO
        /// Coment�rio: Se o pedido foi importado (modulo 25).
        /// </summary>
        private string importacao;
        [XmlElement(ElementName = "IMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importacao
        {
            get { return  importacao; }
            set {  importacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOXML
        /// Coment�rio: Importado do xml
        /// </summary>
        private string importadoxml;
        [XmlElement(ElementName = "IMPORTADOXML", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoxml
        {
            get { return  importadoxml; }
            set {  importadoxml = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCLUIRFRETECUSTOCPAGAR
        /// Coment�rio: 
        /// </summary>
        private string incluirfretecustocpagar;
        [XmlElement(ElementName = "INCLUIRFRETECUSTOCPAGAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incluirfretecustocpagar
        {
            get { return  incluirfretecustocpagar; }
            set {  incluirfretecustocpagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCOTERM
        /// Coment�rio: Sigla Incoterm.
        /// </summary>
        private string incoterm;
        [XmlElement(ElementName = "INCOTERM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Incoterm
        {
            get { return  incoterm; }
            set {  incoterm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCPRODUTOMAISDEUMAVEZ
        /// Coment�rio: Incluir o mesmo produto mais de uma vez.
        /// </summary>
        private string incprodutomaisdeumavez;
        [XmlElement(ElementName = "INCPRODUTOMAISDEUMAVEZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incprodutomaisdeumavez
        {
            get { return  incprodutomaisdeumavez; }
            set {  incprodutomaisdeumavez = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ISENTOST
        /// Coment�rio: Indica o fornecedor isento de ST.
        /// </summary>
        private string isentost;
        [XmlElement(ElementName = "ISENTOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Isentost
        {
            get { return  isentost; }
            set {  isentost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALEMBARQUE
        /// Coment�rio: Local de embarque
        /// </summary>
        private string localembarque;
        [XmlElement(ElementName = "LOCALEMBARQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Localembarque
        {
            get { return  localembarque; }
            set {  localembarque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEIOTRANSPORTE
        /// Coment�rio: Nome do meio de transporte
        /// </summary>
        private string meiotransporte;
        [XmlElement(ElementName = "MEIOTRANSPORTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Meiotransporte
        {
            get { return  meiotransporte; }
            set {  meiotransporte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOLIBERA
        /// Coment�rio: Minuto da liberacao utilizado na rotina 215.
        /// </summary>
        private string minutolibera;
        [XmlElement(ElementName = "MINUTOLIBERA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Minutolibera
        {
            get { return  minutolibera; }
            set {  minutolibera = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODALIDADEPGTO
        /// Coment�rio: Modalidade de pagamento
        /// </summary>
        private string modalidadepgto;
        [XmlElement(ElementName = "MODALIDADEPGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Modalidadepgto
        {
            get { return  modalidadepgto; }
            set {  modalidadepgto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODALIDADEPGTOADIANT
        /// Coment�rio: Descri��o da modalidade de pagamento adiantamento
        /// </summary>
        private string modalidadepgtoadiant;
        [XmlElement(ElementName = "MODALIDADEPGTOADIANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Modalidadepgtoadiant
        {
            get { return  modalidadepgtoadiant; }
            set {  modalidadepgtoadiant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODALIDADEPGTOPRAZO
        /// Coment�rio: Descri��o da modalidade de pagamento a prazo
        /// </summary>
        private string modalidadepgtoprazo;
        [XmlElement(ElementName = "MODALIDADEPGTOPRAZO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Modalidadepgtoprazo
        {
            get { return  modalidadepgtoprazo; }
            set {  modalidadepgtoprazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIMPLOUNIDADEMASTER
        /// Coment�rio: Calcula Sugest�o em multiplos da Unidade Master
        /// </summary>
        private string multimplounidademaster;
        [XmlElement(ElementName = "MULTIMPLOUNIDADEMASTER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Multimplounidademaster
        {
            get { return  multimplounidademaster; }
            set {  multimplounidademaster = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NFIMPORTACAO
        /// Coment�rio: Numero da nota fiscal de importacao (rotina 3002).
        /// </summary>
        private string nfimportacao;
        [XmlElement(ElementName = "NFIMPORTACAO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Nfimportacao
        {
            get { return  nfimportacao; }
            set {  nfimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONIFIC
        /// Coment�rio: N�o utilizado.
        /// </summary>
        private decimal numbonific;
        [XmlElement(ElementName = "NUMBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numbonific
        {
            get { return  numbonific; }
            set {  numbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Coment�rio: Numero do Bonus
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONHECEMBARQ
        /// Coment�rio: N�mero do conhecimento de embarque
        /// </summary>
        private string numconhecembarq;
        [XmlElement(ElementName = "NUMCONHECEMBARQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numconhecembarq
        {
            get { return  numconhecembarq; }
            set {  numconhecembarq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOCIMPORT
        /// Coment�rio: N�mero do documento de importa��o
        /// </summary>
        private string numdocimport;
        [XmlElement(ElementName = "NUMDOCIMPORT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numdocimport
        {
            get { return  numdocimport; }
            set {  numdocimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINVOCE
        /// Coment�rio: N�mero da fatura comercial
        /// </summary>
        private string numinvoce;
        [XmlElement(ElementName = "NUMINVOCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numinvoce
        {
            get { return  numinvoce; }
            set {  numinvoce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLICENCAIMPORT
        /// Coment�rio: N�mero da licen�a de importa��o
        /// </summary>
        private string numlicencaimport;
        [XmlElement(ElementName = "NUMLICENCAIMPORT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlicencaimport
        {
            get { return  numlicencaimport; }
            set {  numlicencaimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNEGOCIACAO
        /// Coment�rio: Numero da negociacao.
        /// </summary>
        private decimal numnegociacao;
        [XmlElement(ElementName = "NUMNEGOCIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numnegociacao
        {
            get { return  numnegociacao; }
            set {  numnegociacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPASTA
        /// Coment�rio: N�mero da pasta/processo
        /// </summary>
        private string numpasta;
        [XmlElement(ElementName = "NUMPASTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numpasta
        {
            get { return  numpasta; }
            set {  numpasta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: Numero do pedido.
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDPRINC
        /// Coment�rio: N�mero do pedido de compra principal.
        /// </summary>
        private decimal numpedprinc;
        [XmlElement(ElementName = "NUMPEDPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numpedprinc
        {
            get { return  numpedprinc; }
            set {  numpedprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPROFORMA
        /// Coment�rio: N�mero Proforma.
        /// </summary>
        private string numproforma;
        [XmlElement(ElementName = "NUMPROFORMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numproforma
        {
            get { return  numproforma; }
            set {  numproforma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTN
        /// Coment�rio: N�mero de transa��o tipo N
        /// </summary>
        private decimal numtransentn;
        [XmlElement(ElementName = "NUMTRANSENTN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentn
        {
            get { return  numtransentn; }
            set {  numtransentn = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Numero de transacao de venda.
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
        /// Propriedade referente ao campo: NUMVERBA
        /// Coment�rio: Numero da verba em Mercadoria.
        /// </summary>
        private decimal numverba;
        [XmlElement(ElementName = "NUMVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numverba
        {
            get { return  numverba; }
            set {  numverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBABONIFIC
        /// Coment�rio: Numero da verba em Mercadoria pedido bonificado.
        /// </summary>
        private decimal numverbabonific;
        [XmlElement(ElementName = "NUMVERBABONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numverbabonific
        {
            get { return  numverbabonific; }
            set {  numverbabonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBADIN
        /// Coment�rio: Numero da verba em dinheiro.
        /// </summary>
        private decimal numverbadin;
        [XmlElement(ElementName = "NUMVERBADIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numverbadin
        {
            get { return  numverbadin; }
            set {  numverbadin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBAOUTRAS
        /// Coment�rio: Numero de outras verbas.
        /// </summary>
        private decimal numverbaoutras;
        [XmlElement(ElementName = "NUMVERBAOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numverbaoutras
        {
            get { return  numverbaoutras; }
            set {  numverbaoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observacao linha 1.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Coment�rio: Observacao linha 2.
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS3
        /// Coment�rio: Observacao linha 3.
        /// </summary>
        private string obs3;
        [XmlElement(ElementName = "OBS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs3
        {
            get { return  obs3; }
            set {  obs3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS4
        /// Coment�rio: Observacao linha 4.
        /// </summary>
        private string obs4;
        [XmlElement(ElementName = "OBS4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs4
        {
            get { return  obs4; }
            set {  obs4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS5
        /// Coment�rio: Observacao linha 5.
        /// </summary>
        private string obs5;
        [XmlElement(ElementName = "OBS5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs5
        {
            get { return  obs5; }
            set {  obs5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS6
        /// Coment�rio: Observacao linha 6.
        /// </summary>
        private string obs6;
        [XmlElement(ElementName = "OBS6", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs6
        {
            get { return  obs6; }
            set {  obs6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS7
        /// Coment�rio: Observacao linha 7.
        /// </summary>
        private string obs7;
        [XmlElement(ElementName = "OBS7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs7
        {
            get { return  obs7; }
            set {  obs7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OCORRENCIAS
        /// Coment�rio: Texto geral registros de ocorr�ncias
        /// </summary>
        private string ocorrencias;
        [XmlElement(ElementName = "OCORRENCIAS", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Ocorrencias
        {
            get { return  ocorrencias; }
            set {  ocorrencias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORCAMENTO
        /// Coment�rio: valores poss�veis "S" quando for um Pedido m�ster de importa��o; "N" quando n�o for; VALOR DEFAULT "N".
        /// </summary>
        private string orcamento;
        [XmlElement(ElementName = "ORCAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Orcamento
        {
            get { return  orcamento; }
            set {  orcamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PALETIZADO
        /// Coment�rio: Tipo da carga paletizada.
        /// </summary>
        private string paletizado;
        [XmlElement(ElementName = "PALETIZADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Paletizado
        {
            get { return  paletizado; }
            set {  paletizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCADIANTAMENTO
        /// Coment�rio: Percentual sobre o valor total da compra que vai ser pago de modo antecipado.
        /// </summary>
        private decimal percadiantamento;
        [XmlElement(ElementName = "PERCADIANTAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percadiantamento
        {
            get { return  percadiantamento; }
            set {  percadiantamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAPRAZO
        /// Coment�rio: Percentual sobre o valor total da compra que vai ser pago de modo a prazo.
        /// </summary>
        private decimal percaprazo;
        [XmlElement(ElementName = "PERCAPRAZO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percaprazo
        {
            get { return  percaprazo; }
            set {  percaprazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCAVISTA
        /// Coment�rio: Percentual sobre o valor total da compra que vai ser pago de modo � vista.
        /// </summary>
        private decimal percavista;
        [XmlElement(ElementName = "PERCAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percavista
        {
            get { return  percavista; }
            set {  percavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE
        /// Coment�rio: Porcentagem do frete CIF no pedido.
        /// </summary>
        private decimal percfrete;
        [XmlElement(ElementName = "PERCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percfrete
        {
            get { return  percfrete; }
            set {  percfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO1
        /// Coment�rio: Nao utilizado(Descontinuado).
        /// </summary>
        private decimal prazo1;
        [XmlElement(ElementName = "PRAZO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo1
        {
            get { return  prazo1; }
            set {  prazo1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO2
        /// Coment�rio: Nao utilizado(Descontinuado).
        /// </summary>
        private decimal prazo2;
        [XmlElement(ElementName = "PRAZO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo2
        {
            get { return  prazo2; }
            set {  prazo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO3
        /// Coment�rio: Nao utilizado(Descontinuado).
        /// </summary>
        private decimal prazo3;
        [XmlElement(ElementName = "PRAZO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo3
        {
            get { return  prazo3; }
            set {  prazo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO4
        /// Coment�rio: Nao utilizado(Descontinuado).
        /// </summary>
        private decimal prazo4;
        [XmlElement(ElementName = "PRAZO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo4
        {
            get { return  prazo4; }
            set {  prazo4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO5
        /// Coment�rio: Nao utilizado(Descontinuado).
        /// </summary>
        private decimal prazo5;
        [XmlElement(ElementName = "PRAZO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo5
        {
            get { return  prazo5; }
            set {  prazo5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO6
        /// Coment�rio: Nao utilizado(Descontinuado).
        /// </summary>
        private decimal prazo6;
        [XmlElement(ElementName = "PRAZO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo6
        {
            get { return  prazo6; }
            set {  prazo6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REBAIXARPR
        /// Coment�rio: Se deve rebaixar o preco.
        /// </summary>
        private string rebaixarpr;
        [XmlElement(ElementName = "REBAIXARPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rebaixarpr
        {
            get { return  rebaixarpr; }
            set {  rebaixarpr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: . |Campo do tipo caracter, de tamanho 48. 
        /// </summary>
        private string rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMAFRETEFOBNOSTFORANF
        /// Coment�rio: Soma frete FOB no ST guia.
        /// </summary>
        private string somafretefobnostforanf;
        [XmlElement(ElementName = "SOMAFRETEFOBNOSTFORANF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somafretefobnostforanf
        {
            get { return  somafretefobnostforanf; }
            set {  somafretefobnostforanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBONIFIC
        /// Coment�rio: Tipo do pedido: Normal, bonificado, consignado, consumo proprio.
        /// </summary>
        private string tipobonific;
        [XmlElement(ElementName = "TIPOBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipobonific
        {
            get { return  tipobonific; }
            set {  tipobonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCARGA
        /// Coment�rio: Tipo do pedido (descarga). Se informado, ser� validado na entrada de mercadoria. 
        /// </summary>
        private string tipodescarga;
        [XmlElement(ElementName = "TIPODESCARGA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodescarga
        {
            get { return  tipodescarga; }
            set {  tipodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMBALAGEMPEDIDO
        /// Coment�rio: Tipo de embalagem: Master ou Venda.
        /// </summary>
        private string tipoembalagempedido;
        [XmlElement(ElementName = "TIPOEMBALAGEMPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoembalagempedido
        {
            get { return  tipoembalagempedido; }
            set {  tipoembalagempedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETEFOB
        /// Coment�rio: Indica o tipo do frete FOB. 
        /// </summary>
        private string tipofretefob;
        [XmlElement(ElementName = "TIPOFRETEFOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofretefob
        {
            get { return  tipofretefob; }
            set {  tipofretefob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENC
        /// Coment�rio: Tipo de vencimento (Faturamento, Embarque, Entrega, Emissao Pedido, Dia Fixo, Bonificado).
        /// </summary>
        private string tipovenc;
        [XmlElement(ElementName = "TIPOVENC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovenc
        {
            get { return  tipovenc; }
            set {  tipovenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVERBAOUTRAS
        /// Coment�rio: Tipo de pagamento da verba outras
        /// </summary>
        private string tipoverbaoutras;
        [XmlElement(ElementName = "TIPOVERBAOUTRAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoverbaoutras
        {
            get { return  tipoverbaoutras; }
            set {  tipoverbaoutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSPORTE
        /// Coment�rio: Nome da transportadora.
        /// </summary>
        private string transporte;
        [XmlElement(ElementName = "TRANSPORTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,28)]
        public string Transporte
        {
            get { return  transporte; }
            set {  transporte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACREDPISCOFINSENTBONIFIC
        /// Coment�rio: Apresenta se o pedido utiliza cr�dito PIS/COFINS em entrada bonificada
        /// </summary>
        private string usacredpiscofinsentbonific;
        [XmlElement(ElementName = "USACREDPISCOFINSENTBONIFIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacredpiscofinsentbonific
        {
            get { return  usacredpiscofinsentbonific; }
            set {  usacredpiscofinsentbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADRAWBACK
        /// Coment�rio: PIS/COFINS DrawBack
        /// </summary>
        private string usadrawback;
        [XmlElement(ElementName = "USADRAWBACK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadrawback
        {
            get { return  usadrawback; }
            set {  usadrawback = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAOUTRASDESPSEGUROPISCOFINS
        /// Coment�rio: Somar outras despesas e seguros na base PIS/COFINS
        /// </summary>
        private string usaoutrasdespseguropiscofins;
        [XmlElement(ElementName = "USAOUTRASDESPSEGUROPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaoutrasdespseguropiscofins
        {
            get { return  usaoutrasdespseguropiscofins; }
            set {  usaoutrasdespseguropiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPERCICMSNAALIQEXTST
        /// Coment�rio: Considera frete FOB para o calculo do ICMS antecipado.
        /// </summary>
        private string usapercicmsnaaliqextst;
        [XmlElement(ElementName = "USAPERCICMSNAALIQEXTST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapercicmsnaaliqextst
        {
            get { return  usapercicmsnaaliqextst; }
            set {  usapercicmsnaaliqextst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZADESCCALCICMS
        /// Coment�rio: Esse campo ser� utilizada pelas rotinas de pedido de compra, fornecedor e entrada de mercadoria quando esse campo possuir o valor igual a [S] os descontos comerciais ser�o utilizados ICMS.
        /// </summary>
        private string utilizadesccalcicms;
        [XmlElement(ElementName = "UTILIZADESCCALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadesccalcicms
        {
            get { return  utilizadesccalcicms; }
            set {  utilizadesccalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZADESCCALCST
        /// Coment�rio: Esse campo ser� utilizada pelas rotinas de pedido de compra, fornecedor e entrada de mercadoria quando esse campo possuir o valor igual a [S] os descontos comerciais ser�o utilizados Substitui��o Tribut�ria (ST).
        /// </summary>
        private string utilizadesccalcst;
        [XmlElement(ElementName = "UTILIZADESCCALCST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizadesccalcst
        {
            get { return  utilizadesccalcst; }
            set {  utilizadesccalcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAFRETECALCICMS
        /// Coment�rio: Considera frete CIF para calculo do ICMS.
        /// </summary>
        private string utilizafretecalcicms;
        [XmlElement(ElementName = "UTILIZAFRETECALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizafretecalcicms
        {
            get { return  utilizafretecalcicms; }
            set {  utilizafretecalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAICMSDIFZERADO
        /// Coment�rio: Indica se utiliza ICMS diferido com al�quota zero.
        /// </summary>
        private string utilizaicmsdifzerado;
        [XmlElement(ElementName = "UTILIZAICMSDIFZERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaicmsdifzerado
        {
            get { return  utilizaicmsdifzerado; }
            set {  utilizaicmsdifzerado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAIPICALCICMS
        /// Coment�rio: Utiliza IPI no calculo de ICMS
        /// </summary>
        private string utilizaipicalcicms;
        [XmlElement(ElementName = "UTILIZAIPICALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaipicalcicms
        {
            get { return  utilizaipicalcicms; }
            set {  utilizaipicalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTDESPCALCSUFRAMA
        /// Coment�rio: Utiliza outras despesa para calculo do desconto SUFRAMA.
        /// </summary>
        private string utilizaoutdespcalcsuframa;
        [XmlElement(ElementName = "UTILIZAOUTDESPCALCSUFRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutdespcalcsuframa
        {
            get { return  utilizaoutdespcalcsuframa; }
            set {  utilizaoutdespcalcsuframa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTDESPNFBASEST
        /// Coment�rio: Considerar o valor Outras Despesas NF + Seguro na base de calculo ST
        /// </summary>
        private string utilizaoutdespnfbasest;
        [XmlElement(ElementName = "UTILIZAOUTDESPNFBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutdespnfbasest
        {
            get { return  utilizaoutdespnfbasest; }
            set {  utilizaoutdespnfbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTRASDESPCALCICMS
        /// Coment�rio: Considera Outras despesas e Seguro para calculo do ICMS.
        /// </summary>
        private string utilizaoutrasdespcalcicms;
        [XmlElement(ElementName = "UTILIZAOUTRASDESPCALCICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutrasdespcalcicms
        {
            get { return  utilizaoutrasdespcalcicms; }
            set {  utilizaoutrasdespcalcicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAOUTRASDESPCALCIPI
        /// Coment�rio: Utilizado na rotina 209 e 1301, caso o valor seja igual a "S" ser� utilizado o valor de outras despesas para c�lculo de IPI.
        /// </summary>
        private string utilizaoutrasdespcalcipi;
        [XmlElement(ElementName = "UTILIZAOUTRASDESPCALCIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaoutrasdespcalcipi
        {
            get { return  utilizaoutrasdespcalcipi; }
            set {  utilizaoutrasdespcalcipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILEXISTEBAIXACUSTO
        /// Coment�rio: 
        /// </summary>
        private string vilexistebaixacusto;
        [XmlElement(ElementName = "VILEXISTEBAIXACUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vilexistebaixacusto
        {
            get { return  vilexistebaixacusto; }
            set {  vilexistebaixacusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLENTREGUE
        /// Coment�rio: Valor entregue.
        /// </summary>
        private decimal vlentregue;
        [XmlElement(ElementName = "VLENTREGUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlentregue
        {
            get { return  vlentregue; }
            set {  vlentregue = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Coment�rio: Valor do frete CIF.
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPRODUTO
        /// Coment�rio: Valor do produto.
        /// </summary>
        private decimal vlproduto;
        [XmlElement(ElementName = "VLPRODUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlproduto
        {
            get { return  vlproduto; }
            set {  vlproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Coment�rio: Valor total do pedido.
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBA
        /// Coment�rio: Valor da verba.
        /// </summary>
        private decimal vlverba;
        [XmlElement(ElementName = "VLVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlverba
        {
            get { return  vlverba; }
            set {  vlverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVERBAOUTRAS
        /// Coment�rio: Valor de outras verbas.
        /// </summary>
        private decimal vlverbaoutras;
        [XmlElement(ElementName = "VLVERBAOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlverbaoutras
        {
            get { return  vlverbaoutras; }
            set {  vlverbaoutras = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPedido()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDIDO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPedido> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedido>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPedido> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedido>(where);
        }

        #endregion
    }
}
