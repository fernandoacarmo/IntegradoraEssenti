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
    /// Classe referente a tabela PCFilial
    /// </summary>
    [XmlType("PCFILIAL")]
    public class PCFilial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDAAVISTACLIBLOQ
        /// Coment�rio: Indica se aceita venda a vista para cliente bloqueado.
        /// </summary>
        private string aceitavendaavistaclibloq;
        [XmlElement(ElementName = "ACEITAVENDAAVISTACLIBLOQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendaavistaclibloq
        {
            get { return  aceitavendaavistaclibloq; }
            set {  aceitavendaavistaclibloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ACEITAVENDASEMEST
        /// Coment�rio: 
        /// </summary>
        private string aceitavendasemest;
        [XmlElement(ElementName = "ACEITAVENDASEMEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitavendasemest
        {
            get { return  aceitavendasemest; }
            set {  aceitavendasemest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMINTEROUTRASDESP
        /// Coment�rio: 
        /// </summary>
        private decimal aliqicminteroutrasdesp;
        [XmlElement(ElementName = "ALIQICMINTEROUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicminteroutrasdesp
        {
            get { return  aliqicminteroutrasdesp; }
            set {  aliqicminteroutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMOUTRASDESP
        /// Coment�rio: 
        /// </summary>
        private decimal aliqicmoutrasdesp;
        [XmlElement(ElementName = "ALIQICMOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Aliqicmoutrasdesp
        {
            get { return  aliqicmoutrasdesp; }
            set {  aliqicmoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTAFRETEEST
        /// Coment�rio: Valor da Al�quota de Frete Estadual, parametrizado na rotina 535 - Cadastro de Filial, na pasta Outros.|Atender a legisla��o de frete para clientes, isentos e tributados.
        /// </summary>
        private decimal aliquotafreteest;
        [XmlElement(ElementName = "ALIQUOTAFRETEEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Aliquotafreteest
        {
            get { return  aliquotafreteest; }
            set {  aliquotafreteest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTERAPEDIDORETORNADOWMS
        /// Coment�rio: Altera pedido retornado pelo WMS.
        /// </summary>
        private string alterapedidoretornadowms;
        [XmlElement(ElementName = "ALTERAPEDIDORETORNADOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alterapedidoretornadowms
        {
            get { return  alterapedidoretornadowms; }
            set {  alterapedidoretornadowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALTERARCOBBKCHAUTOMATICO
        /// Coment�rio: Indica se alterar BK para CH autom�ticamente.
        /// </summary>
        private string alterarcobbkchautomatico;
        [XmlElement(ElementName = "ALTERARCOBBKCHAUTOMATICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alterarcobbkchautomatico
        {
            get { return  alterarcobbkchautomatico; }
            set {  alterarcobbkchautomatico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTE
        /// Coment�rio: Indica o ambiente da NF-e.
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
        /// Propriedade referente ao campo: APLICAPERCATACNAOCONTRIB
        /// Coment�rio: Indica se aplica % de acr�scimo no pre�o de atacado para n�o contribuinte.
        /// </summary>
        private string aplicapercatacnaocontrib;
        [XmlElement(ElementName = "APLICAPERCATACNAOCONTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicapercatacnaocontrib
        {
            get { return  aplicapercatacnaocontrib; }
            set {  aplicapercatacnaocontrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAPERCVARNAOCONTRIB
        /// Coment�rio: Indica se aplica % de acr�scimo no pre�o de varejo para n�o contribuinte.
        /// </summary>
        private string aplicapercvarnaocontrib;
        [XmlElement(ElementName = "APLICAPERCVARNAOCONTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicapercvarnaocontrib
        {
            get { return  aplicapercvarnaocontrib; }
            set {  aplicapercvarnaocontrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITADESP_PISCOFINS
        /// Coment�rio: Indica se aproveita despesa acessoria.
        /// </summary>
        private string aproveitadesp_piscofins;
        [XmlElement(ElementName = "APROVEITADESP_PISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitadesp_Piscofins
        {
            get { return  aproveitadesp_piscofins; }
            set {  aproveitadesp_piscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITAFRETE_PISCOFINS
        /// Coment�rio: Indica se aproveita Frete.
        /// </summary>
        private string aproveitafrete_piscofins;
        [XmlElement(ElementName = "APROVEITAFRETE_PISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitafrete_Piscofins
        {
            get { return  aproveitafrete_piscofins; }
            set {  aproveitafrete_piscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APROVEITAIPI_PISCOFINS
        /// Coment�rio: Indica se aproveita IPI.
        /// </summary>
        private string aproveitaipi_piscofins;
        [XmlElement(ElementName = "APROVEITAIPI_PISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aproveitaipi_Piscofins
        {
            get { return  aproveitaipi_piscofins; }
            set {  aproveitaipi_piscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AREAVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal areavenda;
        [XmlElement(ElementName = "AREAVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Areavenda
        {
            get { return  areavenda; }
            set {  areavenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARREDONDAQTGIRODIA
        /// Coment�rio: Arredonda o valor do campo PCEST.QTGIRODIA ao fazer o c�lculo da recomposi��o de estoque. (S)im ou (N)ao.
        /// </summary>
        private string arredondaqtgirodia;
        [XmlElement(ElementName = "ARREDONDAQTGIRODIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Arredondaqtgirodia
        {
            get { return  arredondaqtgirodia; }
            set {  arredondaqtgirodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ARREDVLITENSNFSAIDA
        /// Coment�rio: Indica se arredonda ou n�o o valor dos intens na NF saida.
        /// </summary>
        private string arredvlitensnfsaida;
        [XmlElement(ElementName = "ARREDVLITENSNFSAIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Arredvlitensnfsaida
        {
            get { return  arredvlitensnfsaida; }
            set {  arredvlitensnfsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATACADISTA
        /// Coment�rio: 
        /// </summary>
        private string atacadista;
        [XmlElement(ElementName = "ATACADISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atacadista
        {
            get { return  atacadista; }
            set {  atacadista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATIVIDADE
        /// Coment�rio: 
        /// </summary>
        private string atividade;
        [XmlElement(ElementName = "ATIVIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Atividade
        {
            get { return  atividade; }
            set {  atividade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATUALIZACUSTOULTENTRANSF
        /// Coment�rio: Atualiza custos da ultima entrada na transfer�ncia.
        /// </summary>
        private string atualizacustoultentransf;
        [XmlElement(ElementName = "ATUALIZACUSTOULTENTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atualizacustoultentransf
        {
            get { return  atualizacustoultentransf; }
            set {  atualizacustoultentransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTOSERVICO
        /// Coment�rio: 
        /// </summary>
        private string autoservico;
        [XmlElement(ElementName = "AUTOSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autoservico
        {
            get { return  autoservico; }
            set {  autoservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Coment�rio: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQDESDEMITENTEDIF
        /// Coment�rio: Indica se desdobramento de t�tulos (402, 1210) ser� permitido com t�tulos/notas de emitentes diferentes. 
        /// </summary>
        private string bloqdesdemitentedif;
        [XmlElement(ElementName = "BLOQDESDEMITENTEDIF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqdesdemitentedif
        {
            get { return  bloqdesdemitentedif; }
            set {  bloqdesdemitentedif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQDEVCLI
        /// Coment�rio: Indica se bloqueia estoque na entrada de devolu��o de cliente. 
        /// </summary>
        private string bloqdevcli;
        [XmlElement(ElementName = "BLOQDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqdevcli
        {
            get { return  bloqdevcli; }
            set {  bloqdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQESTOQUETRANSF
        /// Coment�rio: Bloqueia estoque na transfer�ncia entre filiais.
        /// </summary>
        private string bloqestoquetransf;
        [XmlElement(ElementName = "BLOQESTOQUETRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqestoquetransf
        {
            get { return  bloqestoquetransf; }
            set {  bloqestoquetransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEARPEDIDOSABAIXOVLMINIMO
        /// Coment�rio: Indicar se pedido de venda sera bloqueado se o valor for inferior ao m�nimo.
        /// </summary>
        private string bloquearpedidosabaixovlminimo;
        [XmlElement(ElementName = "BLOQUEARPEDIDOSABAIXOVLMINIMO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloquearpedidosabaixovlminimo
        {
            get { return  bloquearpedidosabaixovlminimo; }
            set {  bloquearpedidosabaixovlminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIARISKSCORING
        /// Coment�rio: Indica se ir� bloquear o cliente na importa��o do arquivo SERASA.
        /// </summary>
        private string bloqueiariskscoring;
        [XmlElement(ElementName = "BLOQUEIARISKSCORING", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueiariskscoring
        {
            get { return  bloqueiariskscoring; }
            set {  bloqueiariskscoring = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQVENDAPF
        /// Coment�rio: Indica se as vendas para pessoa f�sica dever�o ou n�o ser permitidas.
        /// </summary>
        private string bloqvendapf;
        [XmlElement(ElementName = "BLOQVENDAPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqvendapf
        {
            get { return  bloqvendapf; }
            set {  bloqvendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BROKER
        /// Coment�rio: 
        /// </summary>
        private string broker;
        [XmlElement(ElementName = "BROKER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Broker
        {
            get { return  broker; }
            set {  broker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CAE
        /// Coment�rio: 
        /// </summary>
        private string cae;
        [XmlElement(ElementName = "CAE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cae
        {
            get { return  cae; }
            set {  cae = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDICMCUSTOCONT
        /// Coment�rio: 
        /// </summary>
        private string calccredicmcustocont;
        [XmlElement(ElementName = "CALCCREDICMCUSTOCONT", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredicmcustocont
        {
            get { return  calccredicmcustocont; }
            set {  calccredicmcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDICMS
        /// Coment�rio: 
        /// </summary>
        private string calccredicms;
        [XmlElement(ElementName = "CALCCREDICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredicms
        {
            get { return  calccredicms; }
            set {  calccredicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDIPI
        /// Coment�rio: 
        /// </summary>
        private string calccredipi;
        [XmlElement(ElementName = "CALCCREDIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredipi
        {
            get { return  calccredipi; }
            set {  calccredipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDPISCOFINS
        /// Coment�rio: 
        /// </summary>
        private string calccredpiscofins;
        [XmlElement(ElementName = "CALCCREDPISCOFINS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredpiscofins
        {
            get { return  calccredpiscofins; }
            set {  calccredpiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCCREDPISCUSTOCONT
        /// Coment�rio: 
        /// </summary>
        private string calccredpiscustocont;
        [XmlElement(ElementName = "CALCCREDPISCUSTOCONT", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calccredpiscustocont
        {
            get { return  calccredpiscustocont; }
            set {  calccredpiscustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCESTDISPCOMQTMINAUTOSERV
        /// Coment�rio: Calcula est. dispon�vel com qtde m�nima Auto-Servi�o. 
        /// </summary>
        private string calcestdispcomqtminautoserv;
        [XmlElement(ElementName = "CALCESTDISPCOMQTMINAUTOSERV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcestdispcomqtminautoserv
        {
            get { return  calcestdispcomqtminautoserv; }
            set {  calcestdispcomqtminautoserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCREDPISFRETE
        /// Coment�rio: Indica se o % de Pis ir� abater o valor do frete, e com isso afetar os custos, exceto o custo cont�bil.
        /// </summary>
        private string calcredpisfrete;
        [XmlElement(ElementName = "CALCREDPISFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcredpisfrete
        {
            get { return  calcredpisfrete; }
            set {  calcredpisfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCREDPISFRETECONT
        /// Coment�rio: Indica se o % de Pis ir� abater o valor do frete, afetando o custo cont�bil.
        /// </summary>
        private string calcredpisfretecont;
        [XmlElement(ElementName = "CALCREDPISFRETECONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcredpisfretecont
        {
            get { return  calcredpisfretecont; }
            set {  calcredpisfretecont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULARCOMISSAOPVENDA1
        /// Coment�rio: Indica se ir� calcular comiss�o sobre pre�o de venda a vista. 
        /// </summary>
        private string calcularcomissaopvenda1;
        [XmlElement(ElementName = "CALCULARCOMISSAOPVENDA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcularcomissaopvenda1
        {
            get { return  calcularcomissaopvenda1; }
            set {  calcularcomissaopvenda1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CALCULARIPIVENDA
        /// Coment�rio: Indica se calcula IPI na venda.
        /// </summary>
        private string calcularipivenda;
        [XmlElement(ElementName = "CALCULARIPIVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Calcularipivenda
        {
            get { return  calcularipivenda; }
            set {  calcularipivenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CANCELANFDEVCLICOMWMS
        /// Coment�rio: Cancela nota fiscal de devolu��o a cliente com WMS.
        /// </summary>
        private string cancelanfdevclicomwms;
        [XmlElement(ElementName = "CANCELANFDEVCLICOMWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cancelanfdevclicomwms
        {
            get { return  cancelanfdevclicomwms; }
            set {  cancelanfdevclicomwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CANCELANFENTRADACOMWMS
        /// Coment�rio: Cancela nota fiscal de entrada com WMS.
        /// </summary>
        private string cancelanfentradacomwms;
        [XmlElement(ElementName = "CANCELANFENTRADACOMWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cancelanfentradacomwms
        {
            get { return  cancelanfentradacomwms; }
            set {  cancelanfentradacomwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CANCELANFVENDACOMWMS
        /// Coment�rio: Cancela nota fiscal de venda a cliente com WMS.
        /// </summary>
        private string cancelanfvendacomwms;
        [XmlElement(ElementName = "CANCELANFVENDACOMWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cancelanfvendacomwms
        {
            get { return  cancelanfvendacomwms; }
            set {  cancelanfvendacomwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CANCELAPEDIDORETORNADOWMS
        /// Coment�rio: Cancela pedido retornado pelo WMS.
        /// </summary>
        private string cancelapedidoretornadowms;
        [XmlElement(ElementName = "CANCELAPEDIDORETORNADOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cancelapedidoretornadowms
        {
            get { return  cancelapedidoretornadowms; }
            set {  cancelapedidoretornadowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Coment�rio: 
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGC
        /// Coment�rio: 
        /// </summary>
        private string cgc;
        [XmlElement(ElementName = "CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cgc
        {
            get { return  cgc; }
            set {  cgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGC_OPERADORLOGISTICO
        /// Coment�rio: Indica o CGC do operador log�stico.
        /// </summary>
        private string cgc_operadorlogistico;
        [XmlElement(ElementName = "CGC_OPERADORLOGISTICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cgc_Operadorlogistico
        {
            get { return  cgc_operadorlogistico; }
            set {  cgc_operadorlogistico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCTRANSP
        /// Coment�rio: 
        /// </summary>
        private string cgctransp;
        [XmlElement(ElementName = "CGCTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cgctransp
        {
            get { return  cgctransp; }
            set {  cgctransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Coment�rio: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cidade
        {
            get { return  cidade; }
            set {  cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADETRANSP
        /// Coment�rio: 
        /// </summary>
        private string cidadetransp;
        [XmlElement(ElementName = "CIDADETRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cidadetransp
        {
            get { return  cidadetransp; }
            set {  cidadetransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLICREPENDENTE
        /// Coment�rio: Definir se o cr�dito ao cliente vai ser lan�ado de forma padr�o com situa��o igual a pendente.
        /// </summary>
        private string clicrependente;
        [XmlElement(ElementName = "CLICREPENDENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clicrependente
        {
            get { return  clicrependente; }
            set {  clicrependente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNPJ_PAF
        /// Coment�rio: CNPJ EMPRESA DESENVOLVEDORA
        /// </summary>
        private string cnpj_paf;
        [XmlElement(ElementName = "CNPJ_PAF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cnpj_Paf
        {
            get { return  cnpj_paf; }
            set {  cnpj_paf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODCLICONSUMIDOR
        /// Coment�rio: 
        /// </summary>
        private decimal codcliconsumidor;
        [XmlElement(ElementName = "CODCLICONSUMIDOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcliconsumidor
        {
            get { return  codcliconsumidor; }
            set {  codcliconsumidor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACREDFORNEC
        /// Coment�rio: Indica o c�digo da conta para gera��o de cr�dito a fornecedor.
        /// </summary>
        private decimal codcontacredfornec;
        [XmlElement(ElementName = "CODCONTACREDFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacredfornec
        {
            get { return  codcontacredfornec; }
            set {  codcontacredfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTADOR
        /// Coment�rio: 
        /// </summary>
        private decimal codcontador;
        [XmlElement(ElementName = "CODCONTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codcontador
        {
            get { return  codcontador; }
            set {  codcontador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAENTIMPORTACAO
        /// Coment�rio: Campo para armazenar o c�digo da conta para lan�amento de receita ou despesa realizado na entrada de mercadoria de importa��o.
        /// </summary>
        private decimal codcontaentimportacao;
        [XmlElement(ElementName = "CODCONTAENTIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaentimportacao
        {
            get { return  codcontaentimportacao; }
            set {  codcontaentimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAPERCACRESCENT
        /// Coment�rio: C�digo da Conta que ser� creditado valor referente ao acr�scimo de mercadoria.
        /// </summary>
        private decimal codcontapercacrescent;
        [XmlElement(ElementName = "CODCONTAPERCACRESCENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontapercacrescent
        {
            get { return  codcontapercacrescent; }
            set {  codcontapercacrescent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTARECARGA
        /// Coment�rio: Indica o c�digo da conta para recargas.
        /// </summary>
        private decimal codcontarecarga;
        [XmlElement(ElementName = "CODCONTARECARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontarecarga
        {
            get { return  codcontarecarga; }
            set {  codcontarecarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAVENDAENTREGAFUT
        /// Coment�rio: Indica o c�digo da conta de venda entrega futura.
        /// </summary>
        private decimal codcontavendaentregafut;
        [XmlElement(ElementName = "CODCONTAVENDAENTREGAFUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontavendaentregafut
        {
            get { return  codcontavendaentregafut; }
            set {  codcontavendaentregafut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCDEVFORNEC
        /// Coment�rio: 
        /// </summary>
        private decimal coddocdevfornec;
        [XmlElement(ElementName = "CODDOCDEVFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocdevfornec
        {
            get { return  coddocdevfornec; }
            set {  coddocdevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCDEVOL
        /// Coment�rio: 
        /// </summary>
        private decimal coddocdevol;
        [XmlElement(ElementName = "CODDOCDEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocdevol
        {
            get { return  coddocdevol; }
            set {  coddocdevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCENTRADAMERC
        /// Coment�rio: 
        /// </summary>
        private decimal coddocentradamerc;
        [XmlElement(ElementName = "CODDOCENTRADAMERC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocentradamerc
        {
            get { return  coddocentradamerc; }
            set {  coddocentradamerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCNF
        /// Coment�rio: 
        /// </summary>
        private decimal coddocnf;
        [XmlElement(ElementName = "CODDOCNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocnf
        {
            get { return  coddocnf; }
            set {  coddocnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCNFC
        /// Coment�rio: 
        /// </summary>
        private decimal coddocnfc;
        [XmlElement(ElementName = "CODDOCNFC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocnfc
        {
            get { return  coddocnfc; }
            set {  coddocnfc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCNOTACOBRANCA
        /// Coment�rio: Indica o c�digo do layout da nota de cobran�a.
        /// </summary>
        private decimal coddocnotacobranca;
        [XmlElement(ElementName = "CODDOCNOTACOBRANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocnotacobranca
        {
            get { return  coddocnotacobranca; }
            set {  coddocnotacobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCORIGEMNF
        /// Coment�rio: Indica o c�digo do documento layout) por origem de venda.
        /// </summary>
        private decimal coddocorigemnf;
        [XmlElement(ElementName = "CODDOCORIGEMNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocorigemnf
        {
            get { return  coddocorigemnf; }
            set {  coddocorigemnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCSE
        /// Coment�rio: C�digo do Documento para Nota Fiscal de Servi�o. 
        /// </summary>
        private decimal coddocse;
        [XmlElement(ElementName = "CODDOCSE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddocse
        {
            get { return  coddocse; }
            set {  coddocse = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCSR
        /// Coment�rio: 
        /// </summary>
        private decimal coddocsr;
        [XmlElement(ElementName = "CODDOCSR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocsr
        {
            get { return  coddocsr; }
            set {  coddocsr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCSRAUTO
        /// Coment�rio: Indica a simples remessa do auto servi�o.
        /// </summary>
        private decimal coddocsrauto;
        [XmlElement(ElementName = "CODDOCSRAUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocsrauto
        {
            get { return  coddocsrauto; }
            set {  coddocsrauto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCSS
        /// Coment�rio: Indica��o do layout de nota fiscal de servi�� a ser usado na rotina 1446. 
        /// </summary>
        private decimal coddocss;
        [XmlElement(ElementName = "CODDOCSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddocss
        {
            get { return  coddocss; }
            set {  coddocss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDOCTRANSF
        /// Coment�rio: 
        /// </summary>
        private decimal coddoctransf;
        [XmlElement(ElementName = "CODDOCTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Coddoctransf
        {
            get { return  coddoctransf; }
            set {  coddoctransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODESTADO
        /// Coment�rio: 
        /// </summary>
        private decimal codestado;
        [XmlElement(ElementName = "CODESTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codestado
        {
            get { return  codestado; }
            set {  codestado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALPREFESTBALCAO
        /// Coment�rio: 
        /// </summary>
        private string codfilialprefestbalcao;
        [XmlElement(ElementName = "CODFILIALPREFESTBALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialprefestbalcao
        {
            get { return  codfilialprefestbalcao; }
            set {  codfilialprefestbalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALPREFESTTLMK
        /// Coment�rio: 
        /// </summary>
        private string codfilialprefesttlmk;
        [XmlElement(ElementName = "CODFILIALPREFESTTLMK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialprefesttlmk
        {
            get { return  codfilialprefesttlmk; }
            set {  codfilialprefesttlmk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALPRODUCAO
        /// Coment�rio: 
        /// </summary>
        private string codfilialproducao;
        [XmlElement(ElementName = "CODFILIALPRODUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialproducao
        {
            get { return  codfilialproducao; }
            set {  codfilialproducao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALDEVOUTRASDESP
        /// Coment�rio: 
        /// </summary>
        private decimal codfiscaldevoutrasdesp;
        [XmlElement(ElementName = "CODFISCALDEVOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfiscaldevoutrasdesp
        {
            get { return  codfiscaldevoutrasdesp; }
            set {  codfiscaldevoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTERDEVOUTRASDESP
        /// Coment�rio: 
        /// </summary>
        private decimal codfiscalinterdevoutrasdesp;
        [XmlElement(ElementName = "CODFISCALINTERDEVOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfiscalinterdevoutrasdesp
        {
            get { return  codfiscalinterdevoutrasdesp; }
            set {  codfiscalinterdevoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALINTEROUTRASDESP
        /// Coment�rio: 
        /// </summary>
        private decimal codfiscalinteroutrasdesp;
        [XmlElement(ElementName = "CODFISCALINTEROUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscalinteroutrasdesp
        {
            get { return  codfiscalinteroutrasdesp; }
            set {  codfiscalinteroutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOPCIONALNFIMPORTACAO
        /// Coment�rio: C�digo fiscal opcional na entrada de importa��o.
        /// </summary>
        private string codfiscalopcionalnfimportacao;
        [XmlElement(ElementName = "CODFISCALOPCIONALNFIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codfiscalopcionalnfimportacao
        {
            get { return  codfiscalopcionalnfimportacao; }
            set {  codfiscalopcionalnfimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCALOUTRASDESP
        /// Coment�rio: 
        /// </summary>
        private decimal codfiscaloutrasdesp;
        [XmlElement(ElementName = "CODFISCALOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfiscaloutrasdesp
        {
            get { return  codfiscaloutrasdesp; }
            set {  codfiscaloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODGLN
        /// Coment�rio: Global Localization Number
        /// </summary>
        private decimal codgln;
        [XmlElement(ElementName = "CODGLN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Codgln
        {
            get { return  codgln; }
            set {  codgln = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Coment�rio: 
        /// </summary>
        private string codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOFILIAL
        /// Coment�rio: C�digo do Grupo da Filial
        /// </summary>
        private decimal codgrupofilial;
        [XmlElement(ElementName = "CODGRUPOFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgrupofilial
        {
            get { return  codgrupofilial; }
            set {  codgrupofilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOLOJA
        /// Coment�rio: Grupo de Filiais classificadas como Lojas 
        /// </summary>
        private decimal codgrupoloja;
        [XmlElement(ElementName = "CODGRUPOLOJA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgrupoloja
        {
            get { return  codgrupoloja; }
            set {  codgrupoloja = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: 
        /// </summary>
        private string codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMD5_PAF
        /// Coment�rio: CODIGO MD5 DA ROTINA 2030
        /// </summary>
        private string codmd5_paf;
        [XmlElement(ElementName = "CODMD5_PAF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codmd5_Paf
        {
            get { return  codmd5_paf; }
            set {  codmd5_paf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMUN
        /// Coment�rio: 
        /// </summary>
        private decimal codmun;
        [XmlElement(ElementName = "CODMUN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codmun
        {
            get { return  codmun; }
            set {  codmun = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Coment�rio: 
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREGISTRO
        /// Coment�rio: 
        /// </summary>
        private string codregistro;
        [XmlElement(ElementName = "CODREGISTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codregistro
        {
            get { return  codregistro; }
            set {  codregistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSOCIO
        /// Coment�rio: 
        /// </summary>
        private decimal codsocio;
        [XmlElement(ElementName = "CODSOCIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codsocio
        {
            get { return  codsocio; }
            set {  codsocio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCEDERDESCISENCAOSTPF
        /// Coment�rio: Conceder desconto referente a isen��o de ST para pessoa f�sica.
        /// </summary>
        private string concederdescisencaostpf;
        [XmlElement(ElementName = "CONCEDERDESCISENCAOSTPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Concederdescisencaostpf
        {
            get { return  concederdescisencaostpf; }
            set {  concederdescisencaostpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONFERIRSOMENTEPEDACERTADOCX
        /// Coment�rio: Indica se conferi somente pedidos faturados acertados no caixa (rotinas 402 e 409).
        /// </summary>
        private string conferirsomentepedacertadocx;
        [XmlElement(ElementName = "CONFERIRSOMENTEPEDACERTADOCX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conferirsomentepedacertadocx
        {
            get { return  conferirsomentepedacertadocx; }
            set {  conferirsomentepedacertadocx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERAESTPENDSUGCOMPRA
        /// Coment�rio: Considera estq. Pendente na sugest�o de compra.
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
        /// Propriedade referente ao campo: CONSIDERAMONTAGEMGIROMERC
        /// Coment�rio: Indica que considera a montagem de produto no giro da mercadoria.
        /// </summary>
        private string consideramontagemgiromerc;
        [XmlElement(ElementName = "CONSIDERAMONTAGEMGIROMERC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideramontagemgiromerc
        {
            get { return  consideramontagemgiromerc; }
            set {  consideramontagemgiromerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERARCOMISSAOZERO
        /// Coment�rio: Campo para indicar se as comiss�es com valor zero ou nulo ser�o utilizadas para avalia��o. 
        /// </summary>
        private string considerarcomissaozero;
        [XmlElement(ElementName = "CONSIDERARCOMISSAOZERO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Considerarcomissaozero
        {
            get { return  considerarcomissaozero; }
            set {  considerarcomissaozero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERARICMSANTECIPCUSTO
        /// Coment�rio: 
        /// </summary>
        private string consideraricmsantecipcusto;
        [XmlElement(ElementName = "CONSIDERARICMSANTECIPCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideraricmsantecipcusto
        {
            get { return  consideraricmsantecipcusto; }
            set {  consideraricmsantecipcusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSOLIDADADOS504
        /// Coment�rio: Indica se a filial consolida dados na execu��o da 504.
        /// </summary>
        private string consolidadados504;
        [XmlElement(ElementName = "CONSOLIDADADOS504", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consolidadados504
        {
            get { return  consolidadados504; }
            set {  consolidadados504 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATO
        /// Coment�rio: 
        /// </summary>
        private string contato;
        [XmlElement(ElementName = "CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Contato
        {
            get { return  contato; }
            set {  contato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLAGARANTIASERVICO
        /// Coment�rio: Indica se controla garantia do servi�o.
        /// </summary>
        private string controlagarantiaservico;
        [XmlElement(ElementName = "CONTROLAGARANTIASERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlagarantiaservico
        {
            get { return  controlagarantiaservico; }
            set {  controlagarantiaservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLENFEPORROTA
        /// Coment�rio: Controlar NF-e Manifesto (tv 14) por rota
        /// </summary>
        private string controlenfeporrota;
        [XmlElement(ElementName = "CONTROLENFEPORROTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controlenfeporrota
        {
            get { return  controlenfeporrota; }
            set {  controlenfeporrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLENFEPORSERIE
        /// Coment�rio: Controle n�mero NF-e por S�rie.
        /// </summary>
        private string controlenfeporserie;
        [XmlElement(ElementName = "CONTROLENFEPORSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Controlenfeporserie
        {
            get { return  controlenfeporserie; }
            set {  controlenfeporserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CORTEAUTOMATICOPEDVENDAWMS
        /// Coment�rio: Indica que realiza corte autom�tico na importa��o de pedidos de venda com WMS.
        /// </summary>
        private string corteautomaticopedvendawms;
        [XmlElement(ElementName = "CORTEAUTOMATICOPEDVENDAWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Corteautomaticopedvendawms
        {
            get { return  corteautomaticopedvendawms; }
            set {  corteautomaticopedvendawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORA_PRIMEIRODOCUMENTO_ECF
        /// Coment�rio: Data Hora Primeiro Doc. ECF
        /// </summary>
        private string datahora_primeirodocumento_ecf;
        [XmlElement(ElementName = "DATAHORA_PRIMEIRODOCUMENTO_ECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,19)]
        public string Datahora_Primeirodocumento_Ecf
        {
            get { return  datahora_primeirodocumento_ecf; }
            set {  datahora_primeirodocumento_ecf = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: DEPFECHADO
        /// Coment�rio: Dep�sito fechado ou n�o
        /// </summary>
        private string depfechado;
        [XmlElement(ElementName = "DEPFECHADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Depfechado
        {
            get { return  depfechado; }
            set {  depfechado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTACARIMPOSTOSVENDATV13
        /// Coment�rio: Destaca imposto no TV13.
        /// </summary>
        private string destacarimpostosvendatv13;
        [XmlElement(ElementName = "DESTACARIMPOSTOSVENDATV13", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Destacarimpostosvendatv13
        {
            get { return  destacarimpostosvendatv13; }
            set {  destacarimpostosvendatv13 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTACARIMPOSTOSVENDATV14
        /// Coment�rio: Indica se ir� destacar impostos na venda manifesto TV14. 
        /// </summary>
        private string destacarimpostosvendatv14;
        [XmlElement(ElementName = "DESTACARIMPOSTOSVENDATV14", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Destacarimpostosvendatv14
        {
            get { return  destacarimpostosvendatv14; }
            set {  destacarimpostosvendatv14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEVFORNECESTOQUEAVARIA
        /// Coment�rio: Devolu��o de fornecedor somente com estoque de avaria.
        /// </summary>
        private string devfornecestoqueavaria;
        [XmlElement(ElementName = "DEVFORNECESTOQUEAVARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Devfornecestoqueavaria
        {
            get { return  devfornecestoqueavaria; }
            set {  devfornecestoqueavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASCURVATURA
        /// Coment�rio: Dias de Curvatura
        /// </summary>
        private decimal diascurvatura;
        [XmlElement(ElementName = "DIASCURVATURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Diascurvatura
        {
            get { return  diascurvatura; }
            set {  diascurvatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASPRAZOTRANSF
        /// Coment�rio: Dias prazo transfer�ncia Filial Retira
        /// </summary>
        private decimal diasprazotransf;
        [XmlElement(ElementName = "DIASPRAZOTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Diasprazotransf
        {
            get { return  diasprazotransf; }
            set {  diasprazotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAVENCICMSANTECIP
        /// Coment�rio: Indica o dia de vencimento do ICMS antecipado.
        /// </summary>
        private decimal diavencicmsantecip;
        [XmlElement(ElementName = "DIAVENCICMSANTECIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diavencicmsantecip
        {
            get { return  diavencicmsantecip; }
            set {  diavencicmsantecip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIREXPXMLSNGPC
        /// Coment�rio: Diret�rio de Exporta��o do XML SNGPC
        /// </summary>
        private string direxpxmlsngpc;
        [XmlElement(ElementName = "DIREXPXMLSNGPC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Direxpxmlsngpc
        {
            get { return  direxpxmlsngpc; }
            set {  direxpxmlsngpc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOMINIOSERV
        /// Coment�rio: Dom�nio do servidor de email NFE
        /// </summary>
        private string dominioserv;
        [XmlElement(ElementName = "DOMINIOSERV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Dominioserv
        {
            get { return  dominioserv; }
            set {  dominioserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTMATRICSNGPC
        /// Coment�rio: Data da Altera��o da Matr�cula do Usu�rio SNGPC
        /// </summary>
        private DateTime? dtaltmatricsngpc;
        [XmlElement(ElementName = "DTALTMATRICSNGPC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtaltmatricsngpc
        {
            get { return  dtaltmatricsngpc; }
            set {  dtaltmatricsngpc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Indica a data de inativa��o da filial.
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
        /// Propriedade referente ao campo: DTFIMATIVIDADE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfimatividade;
        [XmlElement(ElementName = "DTFIMATIVIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimatividade
        {
            get { return  dtfimatividade; }
            set {  dtfimatividade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINIATIVIDADE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtiniatividade;
        [XmlElement(ElementName = "DTINIATIVIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniatividade
        {
            get { return  dtiniatividade; }
            set {  dtiniatividade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREGISTRO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtregistro;
        [XmlElement(ElementName = "DTREGISTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtregistro
        {
            get { return  dtregistro; }
            set {  dtregistro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTATUALIZACAODRVINTER
        /// Coment�rio: Campo que armazena a �ltima data da atualiza��o de um servidor intermedi�rio.
        /// </summary>
        private DateTime? dtultatualizacaodrvinter;
        [XmlElement(ElementName = "DTULTATUALIZACAODRVINTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultatualizacaodrvinter
        {
            get { return  dtultatualizacaodrvinter; }
            set {  dtultatualizacaodrvinter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTCONSULTAMANIF
        /// Coment�rio: Data da ultima consulta das notas destinatario
        /// </summary>
        private DateTime? dtultconsultamanif;
        [XmlElement(ElementName = "DTULTCONSULTAMANIF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultconsultamanif
        {
            get { return  dtultconsultamanif; }
            set {  dtultconsultamanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTUTILIZACTE
        /// Coment�rio: Indica a data que a CT-e come�ou a ser utilizada na filial.
        /// </summary>
        private DateTime? dtutilizacte;
        [XmlElement(ElementName = "DTUTILIZACTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtutilizacte
        {
            get { return  dtutilizacte; }
            set {  dtutilizacte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTUTILIZANFE
        /// Coment�rio: Indica a data que a NF-e come�ou a ser utilizada na filial. 
        /// </summary>
        private DateTime? dtutilizanfe;
        [XmlElement(ElementName = "DTUTILIZANFE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtutilizanfe
        {
            get { return  dtutilizanfe; }
            set {  dtutilizanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EANEMISSOR
        /// Coment�rio: 
        /// </summary>
        private decimal eanemissor;
        [XmlElement(ElementName = "EANEMISSOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Eanemissor
        {
            get { return  eanemissor; }
            set {  eanemissor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Coment�rio: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILCOPIARESPOSTA
        /// Coment�rio: Email de copia para resposta do servidor NFE
        /// </summary>
        private string emailcopiaresposta;
        [XmlElement(ElementName = "EMAILCOPIARESPOSTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Emailcopiaresposta
        {
            get { return  emailcopiaresposta; }
            set {  emailcopiaresposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILREMETENTE
        /// Coment�rio: Email do remetente do servidor de email NFE
        /// </summary>
        private string emailremetente;
        [XmlElement(ElementName = "EMAILREMETENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Emailremetente
        {
            get { return  emailremetente; }
            set {  emailremetente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILRESPOSTA
        /// Coment�rio: Email para resposta do servidor NFE
        /// </summary>
        private string emailresposta;
        [XmlElement(ElementName = "EMAILRESPOSTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Emailresposta
        {
            get { return  emailresposta; }
            set {  emailresposta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMPRESAGRANDEPORTE
        /// Coment�rio: Define se a empresa � de grande porte.
        /// </summary>
        private string empresagrandeporte;
        [XmlElement(ElementName = "EMPRESAGRANDEPORTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Empresagrandeporte
        {
            get { return  empresagrandeporte; }
            set {  empresagrandeporte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Coment�rio: 
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECOCOMP
        /// Coment�rio: Endere�o Complementar ser� utilizado para envio do sped fiscal
        /// </summary>
        private string enderecocomp;
        [XmlElement(ElementName = "ENDERECOCOMP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Enderecocomp
        {
            get { return  enderecocomp; }
            set {  enderecocomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECOPROXY
        /// Coment�rio: Endere�o do Proxy NFE
        /// </summary>
        private string enderecoproxy;
        [XmlElement(ElementName = "ENDERECOPROXY", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Enderecoproxy
        {
            get { return  enderecoproxy; }
            set {  enderecoproxy = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDTRANSP
        /// Coment�rio: 
        /// </summary>
        private string endtransp;
        [XmlElement(ElementName = "ENDTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endtransp
        {
            get { return  endtransp; }
            set {  endtransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIACONTASPAGARNFE
        /// Coment�rio: Envia os dados de cobran�as(ENTRADA) para o SEFAZ.
        /// </summary>
        private string enviacontaspagarnfe;
        [XmlElement(ElementName = "ENVIACONTASPAGARNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviacontaspagarnfe
        {
            get { return  enviacontaspagarnfe; }
            set {  enviacontaspagarnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIACONTASRECEBERNFE
        /// Coment�rio: Envia dados de cobran�a(SA�DA) para o SEFAZ.
        /// </summary>
        private string enviacontasrecebernfe;
        [XmlElement(ElementName = "ENVIACONTASRECEBERNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviacontasrecebernfe
        {
            get { return  enviacontasrecebernfe; }
            set {  enviacontasrecebernfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTORNACUSTODEVFORNEC
        /// Coment�rio: Indica se estorna custo na devolu��o do fornecedor.
        /// </summary>
        private string estornacustodevfornec;
        [XmlElement(ElementName = "ESTORNACUSTODEVFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Estornacustodevfornec
        {
            get { return  estornacustodevfornec; }
            set {  estornacustodevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRIMPOSTOSFORANFIMPORTACAO
        /// Coment�rio: Exibir impostos Fora NF importa��o pedido compra.
        /// </summary>
        private string exibirimpostosforanfimportacao;
        [XmlElement(ElementName = "EXIBIRIMPOSTOSFORANFIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibirimpostosforanfimportacao
        {
            get { return  exibirimpostosforanfimportacao; }
            set {  exibirimpostosforanfimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIGIREMISSAOMAPABALCAO
        /// Coment�rio: Indica a obriga��o da emiss�o de mapa de separa��o na venda balc�o. 
        /// </summary>
        private string exigiremissaomapabalcao;
        [XmlElement(ElementName = "EXIGIREMISSAOMAPABALCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exigiremissaomapabalcao
        {
            get { return  exigiremissaomapabalcao; }
            set {  exigiremissaomapabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FANTASIA
        /// Coment�rio: 
        /// </summary>
        private string fantasia;
        [XmlElement(ElementName = "FANTASIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Fantasia
        {
            get { return  fantasia; }
            set {  fantasia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAX
        /// Coment�rio: 
        /// </summary>
        private string fax;
        [XmlElement(ElementName = "FAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Fax
        {
            get { return  fax; }
            set {  fax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIID
        /// Coment�rio: 
        /// </summary>
        private string fiid;
        [XmlElement(ElementName = "FIID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Fiid
        {
            get { return  fiid; }
            set {  fiid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERABASENORMALQUANDOST
        /// Coment�rio: Indica se ser� gerado no livro fiscal valores de base de calculo e ICMS normal quando o produto possuir substitui��o tribut�ria. |Campo texto de tamanho 1.
        /// </summary>
        private string gerabasenormalquandost;
        [XmlElement(ElementName = "GERABASENORMALQUANDOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerabasenormalquandost
        {
            get { return  gerabasenormalquandost; }
            set {  gerabasenormalquandost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAPEDIDOCOMITENSSEMEST
        /// Coment�rio: Indica se gerar pedidos das faltas.
        /// </summary>
        private string gerapedidocomitenssemest;
        [XmlElement(ElementName = "GERAPEDIDOCOMITENSSEMEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerapedidocomitenssemest
        {
            get { return  gerapedidocomitenssemest; }
            set {  gerapedidocomitenssemest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARNSU
        /// Coment�rio: Indica o se ser� gerado o NSU (n�mero sequencial �nico) para todas as notas fiscais emitidas (entradas e sa�das). Esta informa��o � referente a legisla��o do estado de Santa Catarina.
        /// </summary>
        private string gerarnsu;
        [XmlElement(ElementName = "GERARNSU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarnsu
        {
            get { return  gerarnsu; }
            set {  gerarnsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARNUMLOTEAUTOMATICPA
        /// Coment�rio: 
        /// </summary>
        private string gerarnumloteautomaticpa;
        [XmlElement(ElementName = "GERARNUMLOTEAUTOMATICPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarnumloteautomaticpa
        {
            get { return  gerarnumloteautomaticpa; }
            set {  gerarnumloteautomaticpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARPCHISTEST
        /// Coment�rio: Indica se a filial mantem historico do estoque.
        /// </summary>
        private string gerarpchistest;
        [XmlElement(ElementName = "GERARPCHISTEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarpchistest
        {
            get { return  gerarpchistest; }
            set {  gerarpchistest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARPEDCONSIGNACAOVASILHAME
        /// Coment�rio: Indica se ser� gerado pedido de consigna��o para os vasilhames aos produtos associados. 
        /// </summary>
        private string gerarpedconsignacaovasilhame;
        [XmlElement(ElementName = "GERARPEDCONSIGNACAOVASILHAME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarpedconsignacaovasilhame
        {
            get { return  gerarpedconsignacaovasilhame; }
            set {  gerarpedconsignacaovasilhame = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRAVARVALORDESCFIN
        /// Coment�rio: Gravar valor desconto financeiro
        /// </summary>
        private string gravarvalordescfin;
        [XmlElement(ElementName = "GRAVARVALORDESCFIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gravarvalordescfin
        {
            get { return  gravarvalordescfin; }
            set {  gravarvalordescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFINALDIGITACAOPED
        /// Coment�rio: Indica a data/hora final para digita��o de pedidos.
        /// </summary>
        private DateTime? horafinaldigitacaoped;
        [XmlElement(ElementName = "HORAFINALDIGITACAOPED", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Horafinaldigitacaoped
        {
            get { return  horafinaldigitacaoped; }
            set {  horafinaldigitacaoped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFINALIMPORTACAOPED
        /// Coment�rio: Indica a data/hora final para importa��o de pedidos.
        /// </summary>
        private DateTime? horafinalimportacaoped;
        [XmlElement(ElementName = "HORAFINALIMPORTACAOPED", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Horafinalimportacaoped
        {
            get { return  horafinalimportacaoped; }
            set {  horafinalimportacaoped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIALDIGITACAOPED
        /// Coment�rio: Indica a data/hora inicial para digita��o de pedidos.
        /// </summary>
        private DateTime? horainicialdigitacaoped;
        [XmlElement(ElementName = "HORAINICIALDIGITACAOPED", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Horainicialdigitacaoped
        {
            get { return  horainicialdigitacaoped; }
            set {  horainicialdigitacaoped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIALIMPORTACAOPED
        /// Coment�rio: Indica a data/hora inicial para importa��o de pedidos.
        /// </summary>
        private DateTime? horainicialimportacaoped;
        [XmlElement(ElementName = "HORAINICIALIMPORTACAOPED", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Horainicialimportacaoped
        {
            get { return  horainicialimportacaoped; }
            set {  horainicialimportacaoped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRFIMALMOCO
        /// Coment�rio: Indica a hora fim do almo�o.
        /// </summary>
        private DateTime? hrfimalmoco;
        [XmlElement(ElementName = "HRFIMALMOCO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hrfimalmoco
        {
            get { return  hrfimalmoco; }
            set {  hrfimalmoco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRFIMEXPEDIENTE
        /// Coment�rio: Indica a hora do fim de expediente.
        /// </summary>
        private DateTime? hrfimexpediente;
        [XmlElement(ElementName = "HRFIMEXPEDIENTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hrfimexpediente
        {
            get { return  hrfimexpediente; }
            set {  hrfimexpediente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRINICIOALMOCO
        /// Coment�rio: Indica a hora do inicio do almo�o.
        /// </summary>
        private DateTime? hrinicioalmoco;
        [XmlElement(ElementName = "HRINICIOALMOCO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hrinicioalmoco
        {
            get { return  hrinicioalmoco; }
            set {  hrinicioalmoco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRINICIOEXPEDIENTE
        /// Coment�rio: Indica a hora do inicio expediente.
        /// </summary>
        private DateTime? hrinicioexpediente;
        [XmlElement(ElementName = "HRINICIOEXPEDIENTE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Hrinicioexpediente
        {
            get { return  hrinicioexpediente; }
            set {  hrinicioexpediente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IE
        /// Coment�rio: 
        /// </summary>
        private string ie;
        [XmlElement(ElementName = "IE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ie
        {
            get { return  ie; }
            set {  ie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IESUBSTTRIB
        /// Coment�rio: 
        /// </summary>
        private string iesubsttrib;
        [XmlElement(ElementName = "IESUBSTTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Iesubsttrib
        {
            get { return  iesubsttrib; }
            set {  iesubsttrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IETRANSP
        /// Coment�rio: 
        /// </summary>
        private string ietransp;
        [XmlElement(ElementName = "IETRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ietransp
        {
            get { return  ietransp; }
            set {  ietransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IM
        /// Coment�rio: 
        /// </summary>
        private string im;
        [XmlElement(ElementName = "IM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Im
        {
            get { return  im; }
            set {  im = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPEDETIPO14_LIVROFISCAL
        /// Coment�rio: Impede gera��o tipo 14.
        /// </summary>
        private string impedetipo14_livrofiscal;
        [XmlElement(ElementName = "IMPEDETIPO14_LIVROFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Impedetipo14_Livrofiscal
        {
            get { return  impedetipo14_livrofiscal; }
            set {  impedetipo14_livrofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCLUIFRETEOUTRASDESPBASEST
        /// Coment�rio: Indica se o faturamento ir� recalcular a base de substitui��o tribut�ria dos itens para lan�ar outras despesas e frete.
        /// </summary>
        private string incluifreteoutrasdespbasest;
        [XmlElement(ElementName = "INCLUIFRETEOUTRASDESPBASEST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incluifreteoutrasdespbasest
        {
            get { return  incluifreteoutrasdespbasest; }
            set {  incluifreteoutrasdespbasest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INCLUIRITEMPCEMBALAGEM
        /// Coment�rio: 
        /// </summary>
        private string incluiritempcembalagem;
        [XmlElement(ElementName = "INCLUIRITEMPCEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Incluiritempcembalagem
        {
            get { return  incluiritempcembalagem; }
            set {  incluiritempcembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICECUSTOTRANSF
        /// Coment�rio: Indice a ser aplicado no custo da transfer�ncia.
        /// </summary>
        private decimal indicecustotransf;
        [XmlElement(ElementName = "INDICECUSTOTRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Indicecustotransf
        {
            get { return  indicecustotransf; }
            set {  indicecustotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDUSTRIA
        /// Coment�rio: 
        /// </summary>
        private string industria;
        [XmlElement(ElementName = "INDUSTRIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Industria
        {
            get { return  industria; }
            set {  industria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INFORMARPROFISSIONALVENDA
        /// Coment�rio: Informar o profissional na venda.
        /// </summary>
        private string informarprofissionalvenda;
        [XmlElement(ElementName = "INFORMARPROFISSIONALVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Informarprofissionalvenda
        {
            get { return  informarprofissionalvenda; }
            set {  informarprofissionalvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORAWMS
        /// Coment�rio: Indica o c�digo da empresa integradora de WMS.
        /// </summary>
        private decimal integradorawms;
        [XmlElement(ElementName = "INTEGRADORAWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Integradorawms
        {
            get { return  integradorawms; }
            set {  integradorawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IPISOMENTEVLCONT
        /// Coment�rio: Indica se ir� agregar valor do IPI somente no valor cont�bil na gera��o do Livro Fiscal.
        /// </summary>
        private string ipisomentevlcont;
        [XmlElement(ElementName = "IPISOMENTEVLCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ipisomentevlcont
        {
            get { return  ipisomentevlcont; }
            set {  ipisomentevlcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LANCARFRETEPESOAUTFAT
        /// Coment�rio: Lan�ar frete referente ao peso das mercadorias autom�ticamente no faturamento. 
        /// </summary>
        private string lancarfretepesoautfat;
        [XmlElement(ElementName = "LANCARFRETEPESOAUTFAT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Lancarfretepesoautfat
        {
            get { return  lancarfretepesoautfat; }
            set {  lancarfretepesoautfat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIBPEDCOMPRASEMDIVERG
        /// Coment�rio: Mensagem NF Imunidade Tribut�ria.
        /// </summary>
        private string libpedcomprasemdiverg;
        [XmlElement(ElementName = "LIBPEDCOMPRASEMDIVERG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Libpedcomprasemdiverg
        {
            get { return  libpedcomprasemdiverg; }
            set {  libpedcomprasemdiverg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMPARBASECALCENTRADA
        /// Coment�rio: 
        /// </summary>
        private string limparbasecalcentrada;
        [XmlElement(ElementName = "LIMPARBASECALCENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Limparbasecalcentrada
        {
            get { return  limparbasecalcentrada; }
            set {  limparbasecalcentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMRISKSCORING
        /// Coment�rio: Limite para bloqueio do cliente por Risk Scoring (SERASA).
        /// </summary>
        private decimal limriskscoring;
        [XmlElement(ElementName = "LIMRISKSCORING", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Limriskscoring
        {
            get { return  limriskscoring; }
            set {  limriskscoring = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULASNGPC
        /// Coment�rio: Matricula de usu�rio SNGPC
        /// </summary>
        private decimal matriculasngpc;
        [XmlElement(ElementName = "MATRICULASNGPC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matriculasngpc
        {
            get { return  matriculasngpc; }
            set {  matriculasngpc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULASNGPCANT
        /// Coment�rio: Matricula de usu�rio SNGPC Anterior
        /// </summary>
        private decimal matriculasngpcant;
        [XmlElement(ElementName = "MATRICULASNGPCANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matriculasngpcant
        {
            get { return  matriculasngpcant; }
            set {  matriculasngpcant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSNF
        /// Coment�rio: 
        /// </summary>
        private string mensnf;
        [XmlElement(ElementName = "MENSNF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mensnf
        {
            get { return  mensnf; }
            set {  mensnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSNFIMUNIDADETRIB
        /// Coment�rio: Mensagem NF Imunidade Tribut�ria.
        /// </summary>
        private string mensnfimunidadetrib;
        [XmlElement(ElementName = "MENSNFIMUNIDADETRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Mensnfimunidadetrib
        {
            get { return  mensnfimunidadetrib; }
            set {  mensnfimunidadetrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIXMAXIMO
        /// Coment�rio: Quantidade m�xima de mix que ser� utilizado na reposi��o de lojas
        /// </summary>
        private decimal mixmaximo;
        [XmlElement(ElementName = "MIXMAXIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Mixmaximo
        {
            get { return  mixmaximo; }
            set {  mixmaximo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MIXMINIMO
        /// Coment�rio: Quantidade m�nima de mix que ser� utilizado na reposi��o de lojas
        /// </summary>
        private decimal mixminimo;
        [XmlElement(ElementName = "MIXMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Mixminimo
        {
            get { return  mixminimo; }
            set {  mixminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MONTACARGAWINTHOR
        /// Coment�rio: Indica se o carregamento ser� montado no Winthor.
        /// </summary>
        private string montacargawinthor;
        [XmlElement(ElementName = "MONTACARGAWINTHOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Montacargawinthor
        {
            get { return  montacargawinthor; }
            set {  montacargawinthor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MONTANDO
        /// Coment�rio: 
        /// </summary>
        private string montando;
        [XmlElement(ElementName = "MONTANDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Montando
        {
            get { return  montando; }
            set {  montando = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MONTARKITAUTOMATICAMENTE
        /// Coment�rio: Indica se monta kit\cesta-b�sica autom�ticamente.
        /// </summary>
        private string montarkitautomaticamente;
        [XmlElement(ElementName = "MONTARKITAUTOMATICAMENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Montarkitautomaticamente
        {
            get { return  montarkitautomaticamente; }
            set {  montarkitautomaticamente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAOGERARCREDITOENTRADATRANSF
        /// Coment�rio: Indica que n�o gerar cr�dito de ICMS na entrada de transfer�ncia.
        /// </summary>
        private string naogerarcreditoentradatransf;
        [XmlElement(ElementName = "NAOGERARCREDITOENTRADATRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naogerarcreditoentradatransf
        {
            get { return  naogerarcreditoentradatransf; }
            set {  naogerarcreditoentradatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEBANCODADOSWMS
        /// Coment�rio: Indica o nome do banco de dados da integradora WMS.
        /// </summary>
        private string nomebancodadoswms;
        [XmlElement(ElementName = "NOMEBANCODADOSWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomebancodadoswms
        {
            get { return  nomebancodadoswms; }
            set {  nomebancodadoswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_PAF
        /// Coment�rio: NOME COMERCIAL DA ROTINA 2030
        /// </summary>
        private string nome_paf;
        [XmlElement(ElementName = "NOME_PAF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nome_Paf
        {
            get { return  nome_paf; }
            set {  nome_paf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPAIS
        /// Coment�rio: 
        /// </summary>
        private string nomepais;
        [XmlElement(ElementName = "NOMEPAIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomepais
        {
            get { return  nomepais; }
            set {  nomepais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEREMETENTE
        /// Coment�rio: Nome do remetente do servidor de email NFE
        /// </summary>
        private string nomeremetente;
        [XmlElement(ElementName = "NOMEREMETENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Nomeremetente
        {
            get { return  nomeremetente; }
            set {  nomeremetente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Coment�rio: N�mero Sequencial �nico
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
        /// Propriedade referente ao campo: NUMCONTRATOCORREIO
        /// Coment�rio: 
        /// </summary>
        private decimal numcontratocorreio;
        [XmlElement(ElementName = "NUMCONTRATOCORREIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcontratocorreio
        {
            get { return  numcontratocorreio; }
            set {  numcontratocorreio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXIMOLIBERARPEDIDO
        /// Coment�rio: Indica n�mero de dias m�ximo para liberar pedido.
        /// </summary>
        private decimal numdiasmaximoliberarpedido;
        [XmlElement(ElementName = "NUMDIASMAXIMOLIBERARPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdiasmaximoliberarpedido
        {
            get { return  numdiasmaximoliberarpedido; }
            set {  numdiasmaximoliberarpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASVENCFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal numdiasvencfrete;
        [XmlElement(ElementName = "NUMDIASVENCFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasvencfrete
        {
            get { return  numdiasvencfrete; }
            set {  numdiasvencfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO
        /// Coment�rio: 
        /// </summary>
        private decimal numero;
        [XmlElement(ElementName = "NUMERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numero
        {
            get { return  numero; }
            set {  numero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMERO2
        /// Coment�rio: 
        /// </summary>
        private string numero2;
        [XmlElement(ElementName = "NUMERO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numero2
        {
            get { return  numero2; }
            set {  numero2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMIDF
        /// Coment�rio: 
        /// </summary>
        private string numidf;
        [XmlElement(ElementName = "NUMIDF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numidf
        {
            get { return  numidf; }
            set {  numidf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMIDFDEVCLI
        /// Coment�rio: 
        /// </summary>
        private string numidfdevcli;
        [XmlElement(ElementName = "NUMIDFDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numidfdevcli
        {
            get { return  numidfdevcli; }
            set {  numidfdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMAXDIASRETRODTCOMPENSACAO
        /// Coment�rio: Informar o n�mero m�ximo de dias retroativos para data de compensa��o.
        /// </summary>
        private decimal nummaxdiasretrodtcompensacao;
        [XmlElement(ElementName = "NUMMAXDIASRETRODTCOMPENSACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Nummaxdiasretrodtcompensacao
        {
            get { return  nummaxdiasretrodtcompensacao; }
            set {  nummaxdiasretrodtcompensacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMAXITENSNFE
        /// Coment�rio: Indica o n�mero de itens na nota fiscal eletr�nica.
        /// </summary>
        private decimal nummaxitensnfe;
        [XmlElement(ElementName = "NUMMAXITENSNFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Nummaxitensnfe
        {
            get { return  nummaxitensnfe; }
            set {  nummaxitensnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPROXVEND
        /// Coment�rio: 
        /// </summary>
        private decimal numproxvend;
        [XmlElement(ElementName = "NUMPROXVEND", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numproxvend
        {
            get { return  numproxvend; }
            set {  numproxvend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMREGIAOBALCAOINTER
        /// Coment�rio: Indica a regi�o para venda balc�o interestadual.
        /// </summary>
        private decimal numregiaobalcaointer;
        [XmlElement(ElementName = "NUMREGIAOBALCAOINTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiaobalcaointer
        {
            get { return  numregiaobalcaointer; }
            set {  numregiaobalcaointer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAOPADRAO
        /// Coment�rio: 
        /// </summary>
        private decimal numregiaopadrao;
        [XmlElement(ElementName = "NUMREGIAOPADRAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiaopadrao
        {
            get { return  numregiaopadrao; }
            set {  numregiaopadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQENTR
        /// Coment�rio: 
        /// </summary>
        private decimal numseqentr;
        [XmlElement(ElementName = "NUMSEQENTR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numseqentr
        {
            get { return  numseqentr; }
            set {  numseqentr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBRIGACONSFINALDEV
        /// Coment�rio: Obriga a identifica��o do cons. final na devol. de cliente.
        /// </summary>
        private string obrigaconsfinaldev;
        [XmlElement(ElementName = "OBRIGACONSFINALDEV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Obrigaconsfinaldev
        {
            get { return  obrigaconsfinaldev; }
            set {  obrigaconsfinaldev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERADORLOGISTICO
        /// Coment�rio: Indica se a filial � do tipo Operador Log�stico. 
        /// </summary>
        private string operadorlogistico;
        [XmlElement(ElementName = "OPERADORLOGISTICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Operadorlogistico
        {
            get { return  operadorlogistico; }
            set {  operadorlogistico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPISENTOSICMSALTOCUSTO
        /// Coment�rio: 
        /// </summary>
        private string opisentosicmsaltocusto;
        [XmlElement(ElementName = "OPISENTOSICMSALTOCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Opisentosicmsaltocusto
        {
            get { return  opisentosicmsaltocusto; }
            set {  opisentosicmsaltocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPTANTESIMPLESNAC
        /// Coment�rio: Indica se e optante ao simples nacional.
        /// </summary>
        private string optantesimplesnac;
        [XmlElement(ElementName = "OPTANTESIMPLESNAC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Optantesimplesnac
        {
            get { return  optantesimplesnac; }
            set {  optantesimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEMAGRUPDESD
        /// Coment�rio: Indica os campos para desdobramento por agrupamento onde o padr�o(CODFILIAL, CODCLI, DTVENC,CODCOB)(PCPREST).
        /// </summary>
        private string ordemagrupdesd;
        [XmlElement(ElementName = "ORDEMAGRUPDESD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,900)]
        public string Ordemagrupdesd
        {
            get { return  ordemagrupdesd; }
            set {  ordemagrupdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAO
        /// Coment�rio: 
        /// </summary>
        private string orgao;
        [XmlElement(ElementName = "ORGAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Orgao
        {
            get { return  orgao; }
            set {  orgao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMCUSTOFILIALRETIRA
        /// Coment�rio: Indica a origem do custo para filial retira.
        /// </summary>
        private string origemcustofilialretira;
        [XmlElement(ElementName = "ORIGEMCUSTOFILIALRETIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemcustofilialretira
        {
            get { return  origemcustofilialretira; }
            set {  origemcustofilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMVENDANF
        /// Coment�rio: Indica a origem de venda para emiss�o da nota fiscal.
        /// </summary>
        private string origemvendanf;
        [XmlElement(ElementName = "ORIGEMVENDANF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemvendanf
        {
            get { return  origemvendanf; }
            set {  origemvendanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OSPRODMANUTOBRIG
        /// Coment�rio: Produto em manuten��o � obrigatorio na ordem de servi�o.
        /// </summary>
        private string osprodmanutobrig;
        [XmlElement(ElementName = "OSPRODMANUTOBRIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Osprodmanutobrig
        {
            get { return  osprodmanutobrig; }
            set {  osprodmanutobrig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDOUTRASDESP
        /// Coment�rio: Percentual de Redu��o da Base ICMS de Despesas Acess�rias.
        /// </summary>
        private decimal perbaseredoutrasdesp;
        [XmlElement(ElementName = "PERBASEREDOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredoutrasdesp
        {
            get { return  perbaseredoutrasdesp; }
            set {  perbaseredoutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERBASEREDOUTRASDESPPF
        /// Coment�rio: Percentual de redu��o da base de ICMS de outras desp. para PF.
        /// </summary>
        private decimal perbaseredoutrasdesppf;
        [XmlElement(ElementName = "PERBASEREDOUTRASDESPPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perbaseredoutrasdesppf
        {
            get { return  perbaseredoutrasdesppf; }
            set {  perbaseredoutrasdesppf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCIMOBALCAO
        /// Coment�rio: Indica o percentual de acrescimo na venda balc�o.
        /// </summary>
        private decimal percacrescimobalcao;
        [XmlElement(ElementName = "PERCACRESCIMOBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percacrescimobalcao
        {
            get { return  percacrescimobalcao; }
            set {  percacrescimobalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCALTERCUSTOENT
        /// Coment�rio: Indica o percentual de acr�scimo de Custo dos Produtos. 
        /// </summary>
        private decimal percaltercustoent;
        [XmlElement(ElementName = "PERCALTERCUSTOENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percaltercustoent
        {
            get { return  percaltercustoent; }
            set {  percaltercustoent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDECLINIOABC
        /// Coment�rio: Percentual de Declinio da Curva ABC
        /// </summary>
        private decimal percdeclinioabc;
        [XmlElement(ElementName = "PERCDECLINIOABC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percdeclinioabc
        {
            get { return  percdeclinioabc; }
            set {  percdeclinioabc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESPADM
        /// Coment�rio: 
        /// </summary>
        private decimal percdespadm;
        [XmlElement(ElementName = "PERCDESPADM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdespadm
        {
            get { return  percdespadm; }
            set {  percdespadm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCEVOLUCAOABC
        /// Coment�rio: Percentual de Evolu��o da Curva ABC
        /// </summary>
        private decimal percevolucaoabc;
        [XmlElement(ElementName = "PERCEVOLUCAOABC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percevolucaoabc
        {
            get { return  percevolucaoabc; }
            set {  percevolucaoabc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCICMSSIMPLESNAC
        /// Coment�rio: Indica o percentual de ICMS do simples nacional.
        /// </summary>
        private decimal percicmssimplesnac;
        [XmlElement(ElementName = "PERCICMSSIMPLESNAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percicmssimplesnac
        {
            get { return  percicmssimplesnac; }
            set {  percicmssimplesnac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXDIFPRODSIMIL
        /// Coment�rio: Indica o percentual m�ximo diferen�a produto similar.
        /// </summary>
        private decimal percmaxdifprodsimil;
        [XmlElement(ElementName = "PERCMAXDIFPRODSIMIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percmaxdifprodsimil
        {
            get { return  percmaxdifprodsimil; }
            set {  percmaxdifprodsimil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMINDIFPRODSIMIL
        /// Coment�rio: % MIn. Dif. P.Venda do prod. similar
        /// </summary>
        private decimal percmindifprodsimil;
        [XmlElement(ElementName = "PERCMINDIFPRODSIMIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percmindifprodsimil
        {
            get { return  percmindifprodsimil; }
            set {  percmindifprodsimil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMFILIALBROKER
        /// Coment�rio: Indica o percentual de comiss�o a ser paga pela ind�stria para uma filial que seja Broker.
        /// </summary>
        private decimal percomfilialbroker;
        [XmlElement(ElementName = "PERCOMFILIALBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomfilialbroker
        {
            get { return  percomfilialbroker; }
            set {  percomfilialbroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOTBROKER
        /// Coment�rio: Indica o % de comiss�o motorista Broker.
        /// </summary>
        private decimal percommotbroker;
        [XmlElement(ElementName = "PERCOMMOTBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percommotbroker
        {
            get { return  percommotbroker; }
            set {  percommotbroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMRCABROKER
        /// Coment�rio: Indica o % de comiss�o RCA Broker.
        /// </summary>
        private decimal percomrcabroker;
        [XmlElement(ElementName = "PERCOMRCABROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percomrcabroker
        {
            get { return  percomrcabroker; }
            set {  percomrcabroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPACLASSEA
        /// Coment�rio: Percentual minimo de participacao para o produto ser classificado na Classe A.
        /// </summary>
        private decimal percparticipaclassea;
        [XmlElement(ElementName = "PERCPARTICIPACLASSEA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipaclassea
        {
            get { return  percparticipaclassea; }
            set {  percparticipaclassea = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPACLASSEB
        /// Coment�rio: Percentual minimo de participacao para o produto ser classificado na Classe B.
        /// </summary>
        private decimal percparticipaclasseb;
        [XmlElement(ElementName = "PERCPARTICIPACLASSEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipaclasseb
        {
            get { return  percparticipaclasseb; }
            set {  percparticipaclasseb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPASUBCLASSEA1
        /// Coment�rio: % minimo de participacao para o produto ser classificado na Classe A1.
        /// </summary>
        private decimal percparticipasubclassea1;
        [XmlElement(ElementName = "PERCPARTICIPASUBCLASSEA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipasubclassea1
        {
            get { return  percparticipasubclassea1; }
            set {  percparticipasubclassea1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPASUBCLASSEA2
        /// Coment�rio: % minimo de participacao para o produto ser classificado na Classe A2.
        /// </summary>
        private decimal percparticipasubclassea2;
        [XmlElement(ElementName = "PERCPARTICIPASUBCLASSEA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipasubclassea2
        {
            get { return  percparticipasubclassea2; }
            set {  percparticipasubclassea2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPASUBCLASSEA3
        /// Coment�rio: % minimo de participacao para o produto ser classificado na Classe A3.
        /// </summary>
        private decimal percparticipasubclassea3;
        [XmlElement(ElementName = "PERCPARTICIPASUBCLASSEA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipasubclassea3
        {
            get { return  percparticipasubclassea3; }
            set {  percparticipasubclassea3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPASUBCLASSEB1
        /// Coment�rio: % minimo de participacao para o produto ser classificado na Classe B1.
        /// </summary>
        private decimal percparticipasubclasseb1;
        [XmlElement(ElementName = "PERCPARTICIPASUBCLASSEB1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipasubclasseb1
        {
            get { return  percparticipasubclasseb1; }
            set {  percparticipasubclasseb1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPASUBCLASSEB2
        /// Coment�rio: % minimo de participacao para o produto ser classificado na Classe B2.
        /// </summary>
        private decimal percparticipasubclasseb2;
        [XmlElement(ElementName = "PERCPARTICIPASUBCLASSEB2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipasubclasseb2
        {
            get { return  percparticipasubclasseb2; }
            set {  percparticipasubclasseb2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPASUBCLASSEB3
        /// Coment�rio: % minimo de participacao para o produto ser classificado na Classe B3.
        /// </summary>
        private decimal percparticipasubclasseb3;
        [XmlElement(ElementName = "PERCPARTICIPASUBCLASSEB3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipasubclasseb3
        {
            get { return  percparticipasubclasseb3; }
            set {  percparticipasubclasseb3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPASUBCLASSEC1
        /// Coment�rio:  % minimo de participacao para o produto ser classificado na Sub-Classe C1.
        /// </summary>
        private decimal percparticipasubclassec1;
        [XmlElement(ElementName = "PERCPARTICIPASUBCLASSEC1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipasubclassec1
        {
            get { return  percparticipasubclassec1; }
            set {  percparticipasubclassec1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPARTICIPASUBCLASSEC2
        /// Coment�rio:  % minimo de participacao para o produto ser classificado na Sub-Classe C2.
        /// </summary>
        private decimal percparticipasubclassec2;
        [XmlElement(ElementName = "PERCPARTICIPASUBCLASSEC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percparticipasubclassec2
        {
            get { return  percparticipasubclassec2; }
            set {  percparticipasubclassec2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETEBROKER
        /// Coment�rio: Indica o percentual de frete pago pela ind�stria para uma filial que seja Broker.
        /// </summary>
        private decimal perfretebroker;
        [XmlElement(ElementName = "PERFRETEBROKER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfretebroker
        {
            get { return  perfretebroker; }
            set {  perfretebroker = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETECONHEC
        /// Coment�rio: 
        /// </summary>
        private decimal perfreteconhec;
        [XmlElement(ElementName = "PERFRETECONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfreteconhec
        {
            get { return  perfreteconhec; }
            set {  perfreteconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERLIMVENDAPF
        /// Coment�rio: Percentual limite de venda para pessoa f�sica.
        /// </summary>
        private decimal perlimvendapf;
        [XmlElement(ElementName = "PERLIMVENDAPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perlimvendapf
        {
            get { return  perlimvendapf; }
            set {  perlimvendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEAGRUPARBOLETOS
        /// Coment�rio: Indica se ser� permitido agrupar t�tulos de um mesmo carregamento, cliente, vencimento e cobran�a, atrav�s da m�dulo 15. 
        /// </summary>
        private string permiteagruparboletos;
        [XmlElement(ElementName = "PERMITEAGRUPARBOLETOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteagruparboletos
        {
            get { return  permiteagruparboletos; }
            set {  permiteagruparboletos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITECANCELARNFENTWMS
        /// Coment�rio: Campo para indicar se ser� permito cancelar as notas fiscais de entrada j� exportadas para o WMS de integra��o.
        /// </summary>
        private string permitecancelarnfentwms;
        [XmlElement(ElementName = "PERMITECANCELARNFENTWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitecancelarnfentwms
        {
            get { return  permitecancelarnfentwms; }
            set {  permitecancelarnfentwms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITECREDICMCOMST
        /// Coment�rio: 
        /// </summary>
        private string permitecredicmcomst;
        [XmlElement(ElementName = "PERMITECREDICMCOMST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitecredicmcomst
        {
            get { return  permitecredicmcomst; }
            set {  permitecredicmcomst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEFATURAR
        /// Coment�rio: Indica se e permitido faturar or�amento(PCVAR339).
        /// </summary>
        private string permitefaturar;
        [XmlElement(ElementName = "PERMITEFATURAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitefaturar
        {
            get { return  permitefaturar; }
            set {  permitefaturar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIRDESDDIFPROF
        /// Coment�rio: Permitir desdobramento de t�tulos de diferentes profissionais.
        /// </summary>
        private string permitirdesddifprof;
        [XmlElement(ElementName = "PERMITIRDESDDIFPROF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitirdesddifprof
        {
            get { return  permitirdesddifprof; }
            set {  permitirdesddifprof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIRVENDAESTADUALPFCOMIE
        /// Coment�rio: Indica se � permitida a venda estadual para Pessoa F�sica, com Inscri��o Estadual.
        /// </summary>
        private string permitirvendaestadualpfcomie;
        [XmlElement(ElementName = "PERMITIRVENDAESTADUALPFCOMIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitirvendaestadualpfcomie
        {
            get { return  permitirvendaestadualpfcomie; }
            set {  permitirvendaestadualpfcomie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIRVENDAESTADUALPFSEMIE
        /// Coment�rio: Indica se � permitida a venda estadual para Pessoa F�sica, sem Inscri��o Estadual.
        /// </summary>
        private string permitirvendaestadualpfsemie;
        [XmlElement(ElementName = "PERMITIRVENDAESTADUALPFSEMIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitirvendaestadualpfsemie
        {
            get { return  permitirvendaestadualpfsemie; }
            set {  permitirvendaestadualpfsemie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITIRVENDAINTERESTADUALPF
        /// Coment�rio: Indica se � permitida a venda interestadual para Pessoa F�sica.
        /// </summary>
        private string permitirvendainterestadualpf;
        [XmlElement(ElementName = "PERMITIRVENDAINTERESTADUALPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitirvendainterestadualpf
        {
            get { return  permitirvendainterestadualpf; }
            set {  permitirvendainterestadualpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERVENDAPF
        /// Coment�rio: 
        /// </summary>
        private decimal pervendapf;
        [XmlElement(ElementName = "PERVENDAPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pervendapf
        {
            get { return  pervendapf; }
            set {  pervendapf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIMITEOS
        /// Coment�rio: Indica o peso limite para quebra de OS.
        /// </summary>
        private decimal pesolimiteos;
        [XmlElement(ElementName = "PESOLIMITEOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pesolimiteos
        {
            get { return  pesolimiteos; }
            set {  pesolimiteos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PONDCUSNOTATRANSF
        /// Coment�rio: Ponderar custo na transfer�ncia.
        /// </summary>
        private string pondcusnotatransf;
        [XmlElement(ElementName = "PONDCUSNOTATRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pondcusnotatransf
        {
            get { return  pondcusnotatransf; }
            set {  pondcusnotatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTAPROXY
        /// Coment�rio: Porta do Proxy NFE
        /// </summary>
        private decimal portaproxy;
        [XmlElement(ElementName = "PORTAPROXY", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Portaproxy
        {
            get { return  portaproxy; }
            set {  portaproxy = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTASERV
        /// Coment�rio: Porta do servidor NFE
        /// </summary>
        private decimal portaserv;
        [XmlElement(ElementName = "PORTASERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Portaserv
        {
            get { return  portaserv; }
            set {  portaserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOMAXIMPPEDPENDECF
        /// Coment�rio: Indica o prazo m�ximo para importa��o pedido pendente Auto-servi�o.
        /// </summary>
        private decimal prazomaximppedpendecf;
        [XmlElement(ElementName = "PRAZOMAXIMPPEDPENDECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazomaximppedpendecf
        {
            get { return  prazomaximppedpendecf; }
            set {  prazomaximppedpendecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECIFICAAUTOMATICO
        /// Coment�rio: Indica se precifica��o para as 7 colunas Varejo/Atacado na rotina 201 ser�o replicadas automaticamente. 
        /// </summary>
        private string precificaautomatico;
        [XmlElement(ElementName = "PRECIFICAAUTOMATICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Precificaautomatico
        {
            get { return  precificaautomatico; }
            set {  precificaautomatico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOPOREMBALAGEM
        /// Coment�rio: Indica o pre�o de venda pela embalagem (2015) nos programas de venda (2075, 316, 336, 382).
        /// </summary>
        private string precoporembalagem;
        [XmlElement(ElementName = "PRECOPOREMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Precoporembalagem
        {
            get { return  precoporembalagem; }
            set {  precoporembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRODPORETAPA
        /// Coment�rio: 
        /// </summary>
        private string prodporetapa;
        [XmlElement(ElementName = "PRODPORETAPA", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prodporetapa
        {
            get { return  prodporetapa; }
            set {  prodporetapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNSU
        /// Coment�rio: Indica o pr�ximo NSU (n�mero sequencial �nico) que dever ser gerado e impresso em todas as notas fiscais geradas (entrada ou sa�da). Esta informa��o � referente a legisla��o do estado de Santa Catarina.
        /// </summary>
        private decimal proxnsu;
        [XmlElement(ElementName = "PROXNSU", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnsu
        {
            get { return  proxnsu; }
            set {  proxnsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMAVERBACAO
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumaverbacao;
        [XmlElement(ElementName = "PROXNUMAVERBACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumaverbacao
        {
            get { return  proxnumaverbacao; }
            set {  proxnumaverbacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCARECF
        /// Coment�rio: Numerador de carregamento usado para as vendas ECF (PCAUX2075) se usado servidor intermedi�rio. 
        /// </summary>
        private decimal proxnumcarecf;
        [XmlElement(ElementName = "PROXNUMCARECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumcarecf
        {
            get { return  proxnumcarecf; }
            set {  proxnumcarecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCONHEC
        /// Coment�rio: Indica o pr�ximo n�mero do conhecimento de frete. 
        /// </summary>
        private decimal proxnumconhec;
        [XmlElement(ElementName = "PROXNUMCONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumconhec
        {
            get { return  proxnumconhec; }
            set {  proxnumconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMCTE
        /// Coment�rio: Pr�ximo N�mero de nota de Conhecimento de Frete eletr�nico
        /// </summary>
        private decimal proxnumcte;
        [XmlElement(ElementName = "PROXNUMCTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumcte
        {
            get { return  proxnumcte; }
            set {  proxnumcte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMENTMEX
        /// Coment�rio: Indica o pr�ximo n�mero sequencial �nico de entrada. Trata-se de um numerador independente para controle fiscal e sequencial das notas de compra (M�xico).
        /// </summary>
        private decimal proxnumentmex;
        [XmlElement(ElementName = "PROXNUMENTMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumentmex
        {
            get { return  proxnumentmex; }
            set {  proxnumentmex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMEROORCAMENTO
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumeroorcamento;
        [XmlElement(ElementName = "PROXNUMEROORCAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Proxnumeroorcamento
        {
            get { return  proxnumeroorcamento; }
            set {  proxnumeroorcamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMETAPA
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumetapa;
        [XmlElement(ElementName = "PROXNUMETAPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumetapa
        {
            get { return  proxnumetapa; }
            set {  proxnumetapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMLOTE
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumlote;
        [XmlElement(ElementName = "PROXNUMLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Proxnumlote
        {
            get { return  proxnumlote; }
            set {  proxnumlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMMDFE
        /// Coment�rio: Proximo numero de MDF-e
        /// </summary>
        private decimal proxnummdfe;
        [XmlElement(ElementName = "PROXNUMMDFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnummdfe
        {
            get { return  proxnummdfe; }
            set {  proxnummdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFDEVCLI
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumnfdevcli;
        [XmlElement(ElementName = "PROXNUMNFDEVCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnfdevcli
        {
            get { return  proxnumnfdevcli; }
            set {  proxnumnfdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFE
        /// Coment�rio: Pr�ximo N�mero da Nota Fiscal Eletr�nica. 
        /// </summary>
        private decimal proxnumnfe;
        [XmlElement(ElementName = "PROXNUMNFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnfe
        {
            get { return  proxnumnfe; }
            set {  proxnumnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFEDEVMANISFESTO
        /// Coment�rio: Contador de numero de nota fiscal eletr�nica para devolu��o de venda manifesto
        /// </summary>
        private decimal proxnumnfedevmanisfesto;
        [XmlElement(ElementName = "PROXNUMNFEDEVMANISFESTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfedevmanisfesto
        {
            get { return  proxnumnfedevmanisfesto; }
            set {  proxnumnfedevmanisfesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFEDEVMANISFESTOSCAN
        /// Coment�rio: Contador de numero de nota fiscal eletr�nica para devolu��o de venda manifesto Scan
        /// </summary>
        private decimal proxnumnfedevmanisfestoscan;
        [XmlElement(ElementName = "PROXNUMNFEDEVMANISFESTOSCAN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfedevmanisfestoscan
        {
            get { return  proxnumnfedevmanisfestoscan; }
            set {  proxnumnfedevmanisfestoscan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFEENTRADA
        /// Coment�rio: Pr�ximo n�mero de nota para o envio normal da NF-e; Opera��es de entrada..
        /// </summary>
        private decimal proxnumnfeentrada;
        [XmlElement(ElementName = "PROXNUMNFEENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfeentrada
        {
            get { return  proxnumnfeentrada; }
            set {  proxnumnfeentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFEIMPORTACAO
        /// Coment�rio: Pr�ximo n�mero nota para envio de notas fiscais de importa��o em ambiente normal
        /// </summary>
        private decimal proxnumnfeimportacao;
        [XmlElement(ElementName = "PROXNUMNFEIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfeimportacao
        {
            get { return  proxnumnfeimportacao; }
            set {  proxnumnfeimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFEREMMANISFESTO
        /// Coment�rio: Contador de numero de nota fiscal eletr�nica para remessa de venda manifesto
        /// </summary>
        private decimal proxnumnferemmanisfesto;
        [XmlElement(ElementName = "PROXNUMNFEREMMANISFESTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnferemmanisfesto
        {
            get { return  proxnumnferemmanisfesto; }
            set {  proxnumnferemmanisfesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFEREMMANISFESTOSCAN
        /// Coment�rio: Contador de numero de nota fiscal eletr�nica para remessa de venda manifesto Scan
        /// </summary>
        private decimal proxnumnferemmanisfestoscan;
        [XmlElement(ElementName = "PROXNUMNFEREMMANISFESTOSCAN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnferemmanisfestoscan
        {
            get { return  proxnumnferemmanisfestoscan; }
            set {  proxnumnferemmanisfestoscan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFESCAN
        /// Coment�rio: Pr�ximo n�mero de nota para o envio Scan da NF-e.
        /// </summary>
        private decimal proxnumnfescan;
        [XmlElement(ElementName = "PROXNUMNFESCAN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfescan
        {
            get { return  proxnumnfescan; }
            set {  proxnumnfescan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFESCANENTRADA
        /// Coment�rio: Pr�ximo n�mero de nota para o envio Scan da NF-e; Opera��es de entrada.
        /// </summary>
        private decimal proxnumnfescanentrada;
        [XmlElement(ElementName = "PROXNUMNFESCANENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfescanentrada
        {
            get { return  proxnumnfescanentrada; }
            set {  proxnumnfescanentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFESCANIMPORTACAO
        /// Coment�rio: Pr�ximo n�mero nota para envio de notas fiscais de importa��o em ambiente SCAN
        /// </summary>
        private decimal proxnumnfescanimportacao;
        [XmlElement(ElementName = "PROXNUMNFESCANIMPORTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Proxnumnfescanimportacao
        {
            get { return  proxnumnfescanimportacao; }
            set {  proxnumnfescanimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNFS
        /// Coment�rio: Pr�ximo numero para nota fiscal de servi�o.
        /// </summary>
        private decimal proxnumnfs;
        [XmlElement(ElementName = "PROXNUMNFS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnfs
        {
            get { return  proxnumnfs; }
            set {  proxnumnfs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNOTA
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumnota;
        [XmlElement(ElementName = "PROXNUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnota
        {
            get { return  proxnumnota; }
            set {  proxnumnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNOTACOBRANCA
        /// Coment�rio: Indica o pr�ximo n�mero nota de cobran�a.
        /// </summary>
        private decimal proxnumnotacobranca;
        [XmlElement(ElementName = "PROXNUMNOTACOBRANCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnotacobranca
        {
            get { return  proxnumnotacobranca; }
            set {  proxnumnotacobranca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNOTAD
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumnotad;
        [XmlElement(ElementName = "PROXNUMNOTAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnotad
        {
            get { return  proxnumnotad; }
            set {  proxnumnotad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNOTAECF
        /// Coment�rio: Numerador de notas fiscais Usado para as vendas ECF (PCAUX2075) e para a emiss�o de nota fiscal espelho se usado servidor intermedi�rio. 
        /// </summary>
        private decimal proxnumnotaecf;
        [XmlElement(ElementName = "PROXNUMNOTAECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnotaecf
        {
            get { return  proxnumnotaecf; }
            set {  proxnumnotaecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNOTAORIGVENDA
        /// Coment�rio: Campo para o pr�ximo n�mero de nota fiscal por origem de venda.
        /// </summary>
        private decimal proxnumnotaorigvenda;
        [XmlElement(ElementName = "PROXNUMNOTAORIGVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnotaorigvenda
        {
            get { return  proxnumnotaorigvenda; }
            set {  proxnumnotaorigvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMNOTATRANSF
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumnotatransf;
        [XmlElement(ElementName = "PROXNUMNOTATRANSF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumnotatransf
        {
            get { return  proxnumnotatransf; }
            set {  proxnumnotatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMORC
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumorc;
        [XmlElement(ElementName = "PROXNUMORC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumorc
        {
            get { return  proxnumorc; }
            set {  proxnumorc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMORCAFILIAL
        /// Coment�rio: Indica o pr�ximo n�mero de or�amento. 
        /// </summary>
        private decimal proxnumorcafilial;
        [XmlElement(ElementName = "PROXNUMORCAFILIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumorcafilial
        {
            get { return  proxnumorcafilial; }
            set {  proxnumorcafilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMOS
        /// Coment�rio: Pr�ximo n�mero de O.S.
        /// </summary>
        private decimal proxnumos;
        [XmlElement(ElementName = "PROXNUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Proxnumos
        {
            get { return  proxnumos; }
            set {  proxnumos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPREVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal proxnumprevenda;
        [XmlElement(ElementName = "PROXNUMPREVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumprevenda
        {
            get { return  proxnumprevenda; }
            set {  proxnumprevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSCONHEC
        /// Coment�rio: Indica o pr�ximo n�mero de transa��o para gera��o dos conhecimento de frete. 
        /// </summary>
        private decimal proxnumtransconhec;
        [XmlElement(ElementName = "PROXNUMTRANSCONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtransconhec
        {
            get { return  proxnumtransconhec; }
            set {  proxnumtransconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSECF
        /// Coment�rio: Numerador usado para movimenta��o de saldo caixa/banco para vales do ECF (PCAUX2075) na emiss�o de boleto banc�rio se usado servidor intermedi�rio. 
        /// </summary>
        private decimal proxnumtransecf;
        [XmlElement(ElementName = "PROXNUMTRANSECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtransecf
        {
            get { return  proxnumtransecf; }
            set {  proxnumtransecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMTRANSVENDAECF
        /// Coment�rio: Transa��o de venda usado para as vendas ECF (PCAUX2075) e para a emiss�o de nota fiscal espelho se usado servidor intermedi�rio. 
        /// </summary>
        private decimal proxnumtransvendaecf;
        [XmlElement(ElementName = "PROXNUMTRANSVENDAECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumtransvendaecf
        {
            get { return  proxnumtransvendaecf; }
            set {  proxnumtransvendaecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEMAXDIASVENCVERBAS
        /// Coment�rio: Quantidade m�xima de dias para o vencimento de novas verbas.
        /// </summary>
        private decimal qtdemaxdiasvencverbas;
        [XmlElement(ElementName = "QTDEMAXDIASVENCVERBAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtdemaxdiasvencverbas
        {
            get { return  qtdemaxdiasvencverbas; }
            set {  qtdemaxdiasvencverbas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDMAXITENSOS
        /// Coment�rio: Indica a quantidade m�xima de itens por OS.
        /// </summary>
        private decimal qtdmaxitensos;
        [XmlElement(ElementName = "QTDMAXITENSOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdmaxitensos
        {
            get { return  qtdmaxitensos; }
            set {  qtdmaxitensos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDMINITENSMODULOOS
        /// Coment�rio: Indica a quantidade minima de itens por m�dulo na quebra de OS.
        /// </summary>
        private decimal qtdminitensmoduloos;
        [XmlElement(ElementName = "QTDMINITENSMODULOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtdminitensmoduloos
        {
            get { return  qtdminitensmoduloos; }
            set {  qtdminitensmoduloos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMAXPEDIDO
        /// Coment�rio: Quantidade m�xima de itens do pedido de transfer�ncia
        /// </summary>
        private decimal qtmaxpedido;
        [XmlElement(ElementName = "QTMAXPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtmaxpedido
        {
            get { return  qtmaxpedido; }
            set {  qtmaxpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMULTIPLAINICIALECF
        /// Coment�rio: Indica o parametro para definir quantidade m�ltipla inicial.
        /// </summary>
        private decimal qtmultiplainicialecf;
        [XmlElement(ElementName = "QTMULTIPLAINICIALECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtmultiplainicialecf
        {
            get { return  qtmultiplainicialecf; }
            set {  qtmultiplainicialecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOSOCIAL
        /// Coment�rio: 
        /// </summary>
        private string razaosocial;
        [XmlElement(ElementName = "RAZAOSOCIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Razaosocial
        {
            get { return  razaosocial; }
            set {  razaosocial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAZAOTRANSP
        /// Coment�rio: 
        /// </summary>
        private string razaotransp;
        [XmlElement(ElementName = "RAZAOTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Razaotransp
        {
            get { return  razaotransp; }
            set {  razaotransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECALCDVPRODUTO
        /// Coment�rio: Indica se recalcula o DV do produto ao alterar o cadastro.
        /// </summary>
        private string recalcdvproduto;
        [XmlElement(ElementName = "RECALCDVPRODUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Recalcdvproduto
        {
            get { return  recalcdvproduto; }
            set {  recalcdvproduto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REDUZIRICMSPROPRIOTRANSF
        /// Coment�rio: Indica que reduzir o ICMS pr�prio na transfer�ncia.
        /// </summary>
        private string reduziricmspropriotransf;
        [XmlElement(ElementName = "REDUZIRICMSPROPRIOTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reduziricmspropriotransf
        {
            get { return  reduziricmspropriotransf; }
            set {  reduziricmspropriotransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGRAARREDONDAMENTOECF
        /// Coment�rio: Indica o tipo de arredondamento para a rotina 2075.
        /// </summary>
        private string regraarredondamentoecf;
        [XmlElement(ElementName = "REGRAARREDONDAMENTOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Regraarredondamentoecf
        {
            get { return  regraarredondamentoecf; }
            set {  regraarredondamentoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RETIRARDESCNABAIXA
        /// Coment�rio: Indica retira o desconto na baixa.
        /// </summary>
        private string retirardescnabaixa;
        [XmlElement(ElementName = "RETIRARDESCNABAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Retirardescnabaixa
        {
            get { return  retirardescnabaixa; }
            set {  retirardescnabaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: ROTINA QUE GRAVOU A INFORMACAO
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
        /// Propriedade referente ao campo: SENHABANCODADOSWMS
        /// Coment�rio: Indica a senha do banco de dados da integradora WMS.
        /// </summary>
        private string senhabancodadoswms;
        [XmlElement(ElementName = "SENHABANCODADOSWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Senhabancodadoswms
        {
            get { return  senhabancodadoswms; }
            set {  senhabancodadoswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHAPROXY
        /// Coment�rio: Senha do Proxy NFE
        /// </summary>
        private string senhaproxy;
        [XmlElement(ElementName = "SENHAPROXY", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Senhaproxy
        {
            get { return  senhaproxy; }
            set {  senhaproxy = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHASERV
        /// Coment�rio: Senha do servidor de email NFE
        /// </summary>
        private string senhaserv;
        [XmlElement(ElementName = "SENHASERV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Senhaserv
        {
            get { return  senhaserv; }
            set {  senhaserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIECTE
        /// Coment�rio: Pr�ximo N�mero de S�rie de Conhecimento de Frete eletr�nico
        /// </summary>
        private string seriecte;
        [XmlElement(ElementName = "SERIECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Seriecte
        {
            get { return  seriecte; }
            set {  seriecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIEMDFE
        /// Coment�rio: Serie MDF-e
        /// </summary>
        private string seriemdfe;
        [XmlElement(ElementName = "SERIEMDFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Seriemdfe
        {
            get { return  seriemdfe; }
            set {  seriemdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFE
        /// Coment�rio: N�mero de S�rie da Nota Fiscal Eletr�nica. 
        /// </summary>
        private string serienfe;
        [XmlElement(ElementName = "SERIENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfe
        {
            get { return  serienfe; }
            set {  serienfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFEDEVMANIFESTO
        /// Coment�rio: N�mero de S�rie de nota fiscal eletr�nica para devolu��o de venda manifesto
        /// </summary>
        private string serienfedevmanifesto;
        [XmlElement(ElementName = "SERIENFEDEVMANIFESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfedevmanifesto
        {
            get { return  serienfedevmanifesto; }
            set {  serienfedevmanifesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFEDEVMANIFESTOSCAN
        /// Coment�rio: N�mero de S�rie de nota fiscal eletr�nica para devolu��o de venda manifesto Scan
        /// </summary>
        private string serienfedevmanifestoscan;
        [XmlElement(ElementName = "SERIENFEDEVMANIFESTOSCAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfedevmanifestoscan
        {
            get { return  serienfedevmanifestoscan; }
            set {  serienfedevmanifestoscan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFEENTRADA
        /// Coment�rio: S�rie da nota para envio normal da NF-e; Opera��es de entrada.
        /// </summary>
        private string serienfeentrada;
        [XmlElement(ElementName = "SERIENFEENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfeentrada
        {
            get { return  serienfeentrada; }
            set {  serienfeentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFEIMPORTACAO
        /// Coment�rio: S�rie para envio de notas fiscal de importa��o em ambiente normal
        /// </summary>
        private string serienfeimportacao;
        [XmlElement(ElementName = "SERIENFEIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfeimportacao
        {
            get { return  serienfeimportacao; }
            set {  serienfeimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFEREMMANISFESTO
        /// Coment�rio: N�mero de S�rie de nota fiscal eletr�nica para remessa de venda manifesto
        /// </summary>
        private string serienferemmanisfesto;
        [XmlElement(ElementName = "SERIENFEREMMANISFESTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienferemmanisfesto
        {
            get { return  serienferemmanisfesto; }
            set {  serienferemmanisfesto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFEREMMANISFESTOSCAN
        /// Coment�rio: N�mero de S�rie de nota fiscal eletr�nica para remessa de venda manifesto Scan
        /// </summary>
        private string serienferemmanisfestoscan;
        [XmlElement(ElementName = "SERIENFEREMMANISFESTOSCAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienferemmanisfestoscan
        {
            get { return  serienferemmanisfestoscan; }
            set {  serienferemmanisfestoscan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFESCAN
        /// Coment�rio: S�rie da Nota Fiscal Eletr�nica e SCAN. 
        /// </summary>
        private string serienfescan;
        [XmlElement(ElementName = "SERIENFESCAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfescan
        {
            get { return  serienfescan; }
            set {  serienfescan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFESCANENTRADA
        /// Coment�rio: S�rie da nota para envio Scan da NF-e; Opera��es de entrada.
        /// </summary>
        private string serienfescanentrada;
        [XmlElement(ElementName = "SERIENFESCANENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfescanentrada
        {
            get { return  serienfescanentrada; }
            set {  serienfescanentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFESCANIMPORTACAO
        /// Coment�rio: S�rie para envio de notas fiscal de importa��o em ambiente SCAN
        /// </summary>
        private string serienfescanimportacao;
        [XmlElement(ElementName = "SERIENFESCANIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfescanimportacao
        {
            get { return  serienfescanimportacao; }
            set {  serienfescanimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENFS
        /// Coment�rio: S�rie para uso da nota fiscal de servi�o.
        /// </summary>
        private string serienfs;
        [XmlElement(ElementName = "SERIENFS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienfs
        {
            get { return  serienfs; }
            set {  serienfs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERVIDORSMTP
        /// Coment�rio: Endere�o do servidor SMTP da NFE
        /// </summary>
        private string servidorsmtp;
        [XmlElement(ElementName = "SERVIDORSMTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Servidorsmtp
        {
            get { return  servidorsmtp; }
            set {  servidorsmtp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTOPCIONALNFIMPORTACAO
        /// Coment�rio: Situa��o tribut�ria opcional na entrada de importa��o.
        /// </summary>
        private string sittributopcionalnfimportacao;
        [XmlElement(ElementName = "SITTRIBUTOPCIONALNFIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sittributopcionalnfimportacao
        {
            get { return  sittributopcionalnfimportacao; }
            set {  sittributopcionalnfimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMAICMSTRANSF
        /// Coment�rio: Indica se soma o ICMS na transfer�ncia.
        /// </summary>
        private string somaicmstransf;
        [XmlElement(ElementName = "SOMAICMSTRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somaicmstransf
        {
            get { return  somaicmstransf; }
            set {  somaicmstransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOMATARIFABANCDUPLIC
        /// Coment�rio: 
        /// </summary>
        private string somatarifabancduplic;
        [XmlElement(ElementName = "SOMATARIFABANCDUPLIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Somatarifabancduplic
        {
            get { return  somatarifabancduplic; }
            set {  somatarifabancduplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STSOMENTEVLCONT
        /// Coment�rio: Indica se utiliza ST.
        /// </summary>
        private string stsomentevlcont;
        [XmlElement(ElementName = "STSOMENTEVLCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Stsomentevlcont
        {
            get { return  stsomentevlcont; }
            set {  stsomentevlcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA0
        /// Coment�rio: 
        /// </summary>
        private decimal taxa0;
        [XmlElement(ElementName = "TAXA0", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa0
        {
            get { return  taxa0; }
            set {  taxa0 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA14
        /// Coment�rio: 
        /// </summary>
        private decimal taxa14;
        [XmlElement(ElementName = "TAXA14", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa14
        {
            get { return  taxa14; }
            set {  taxa14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA21
        /// Coment�rio: 
        /// </summary>
        private decimal taxa21;
        [XmlElement(ElementName = "TAXA21", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa21
        {
            get { return  taxa21; }
            set {  taxa21 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA28
        /// Coment�rio: 
        /// </summary>
        private decimal taxa28;
        [XmlElement(ElementName = "TAXA28", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa28
        {
            get { return  taxa28; }
            set {  taxa28 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA35
        /// Coment�rio: 
        /// </summary>
        private decimal taxa35;
        [XmlElement(ElementName = "TAXA35", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa35
        {
            get { return  taxa35; }
            set {  taxa35 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA42
        /// Coment�rio: 
        /// </summary>
        private decimal taxa42;
        [XmlElement(ElementName = "TAXA42", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa42
        {
            get { return  taxa42; }
            set {  taxa42 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXA7
        /// Coment�rio: 
        /// </summary>
        private decimal taxa7;
        [XmlElement(ElementName = "TAXA7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Taxa7
        {
            get { return  taxa7; }
            set {  taxa7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Coment�rio: 
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOSEPCAIXAOS
        /// Coment�rio: Indica o tempo de separa��o por caixa.
        /// </summary>
        private decimal temposepcaixaos;
        [XmlElement(ElementName = "TEMPOSEPCAIXAOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Temposepcaixaos
        {
            get { return  temposepcaixaos; }
            set {  temposepcaixaos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOSEPINICIALOS
        /// Coment�rio: Indica o tempo inicial de separa��o.
        /// </summary>
        private decimal temposepinicialos;
        [XmlElement(ElementName = "TEMPOSEPINICIALOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Temposepinicialos
        {
            get { return  temposepinicialos; }
            set {  temposepinicialos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPOSEPPRODOS
        /// Coment�rio: Indica o tempo de separa��o por produto.
        /// </summary>
        private decimal temposepprodos;
        [XmlElement(ElementName = "TEMPOSEPPRODOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Temposepprodos
        {
            get { return  temposepprodos; }
            set {  temposepprodos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAVALIACAOCOMISSAO
        /// Coment�rio: Campo para indicar o tipo de avalia��o da comiss�o para RCA. 
        /// </summary>
        private decimal tipoavaliacaocomissao;
        [XmlElement(ElementName = "TIPOAVALIACAOCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipoavaliacaocomissao
        {
            get { return  tipoavaliacaocomissao; }
            set {  tipoavaliacaocomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBROKER
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOCNPJ
        /// Coment�rio: Tipo de CNPJ da empresa se � M � Matriz ou F � Filial.
        /// </summary>
        private string tipocnpj;
        [XmlElement(ElementName = "TIPOCNPJ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocnpj
        {
            get { return  tipocnpj; }
            set {  tipocnpj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODANFE
        /// Coment�rio: Tipo de Impress�o do da NF-e: Retrato ou Paisagem. 
        /// </summary>
        private string tipodanfe;
        [XmlElement(ElementName = "TIPODANFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodanfe
        {
            get { return  tipodanfe; }
            set {  tipodanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEXPORTACAO
        /// Coment�rio: Campo para posibilitar a exporta��o de dados por arquivos na rotina 2001.
        /// </summary>
        private string tipoexportacao;
        [XmlElement(ElementName = "TIPOEXPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoexportacao
        {
            get { return  tipoexportacao; }
            set {  tipoexportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFILIAL
        /// Coment�rio: Informa se a filial � um CD ou uma loja  1=CD, 2=LOJA  Valor Default = "1"
        /// </summary>
        private string tipofilial;
        [XmlElement(ElementName = "TIPOFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofilial
        {
            get { return  tipofilial; }
            set {  tipofilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETEAUTO
        /// Coment�rio: Indica o tipo do c�lculo do Frente.
        /// </summary>
        private string tipofreteauto;
        [XmlElement(ElementName = "TIPOFRETEAUTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofreteauto
        {
            get { return  tipofreteauto; }
            set {  tipofreteauto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOIDENTIFICACAOECF
        /// Coment�rio: Identifica como vai ser a autentica��o do cart�o.
        /// </summary>
        private string tipoidentificacaoecf;
        [XmlElement(ElementName = "TIPOIDENTIFICACAOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoidentificacaoecf
        {
            get { return  tipoidentificacaoecf; }
            set {  tipoidentificacaoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMONTAGEM
        /// Coment�rio: Indica o tipo de montagem de carregamento (Rota ou Transportadora).
        /// </summary>
        private string tipomontagem;
        [XmlElement(ElementName = "TIPOMONTAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipomontagem
        {
            get { return  tipomontagem; }
            set {  tipomontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPONUMMAPA
        /// Coment�rio: Indica tipo de sequencia do NUMMAPA na rotina 1064, que pode ser Dia [D] ou M�s [M].
        /// </summary>
        private string tiponummapa;
        [XmlElement(ElementName = "TIPONUMMAPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiponummapa
        {
            get { return  tiponummapa; }
            set {  tiponummapa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPONUMNFENTRADA
        /// Coment�rio: Indica se ir� utilizar para a sequencia de n�mero de nota fiscal tipo descarga 4, a partir da NF Venda ou da NF Devolu��o de Cliente
        /// </summary>
        private string tiponumnfentrada;
        [XmlElement(ElementName = "TIPONUMNFENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiponumnfentrada
        {
            get { return  tiponumnfentrada; }
            set {  tiponumnfentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRECIFICACAO
        /// Coment�rio: Indica se a precifica��o na rotina 201 � por Varejo (Pre�o normal � o maior) ou se precifica por Atacado (Pre�o normal � o menor). Valores poss�veis "V" ou "A". 
        /// </summary>
        private string tipoprecificacao;
        [XmlElement(ElementName = "TIPOPRECIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprecificacao
        {
            get { return  tipoprecificacao; }
            set {  tipoprecificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSFEREVLSTBASESTNATRANSF
        /// Coment�rio: Indica se utiliza valor ST na transfer�ncia.
        /// </summary>
        private string transferevlstbasestnatransf;
        [XmlElement(ElementName = "TRANSFEREVLSTBASESTNATRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Transferevlstbasestnatransf
        {
            get { return  transferevlstbasestnatransf; }
            set {  transferevlstbasestnatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UF
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: UFTRANSP
        /// Coment�rio: 
        /// </summary>
        private string uftransp;
        [XmlElement(ElementName = "UFTRANSP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uftransp
        {
            get { return  uftransp; }
            set {  uftransp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USABRINDEECF
        /// Coment�rio: Indica se utiliza brinde na rotina 2075.
        /// </summary>
        private string usabrindeecf;
        [XmlElement(ElementName = "USABRINDEECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usabrindeecf
        {
            get { return  usabrindeecf; }
            set {  usabrindeecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACODBARRAEMBALAGEM
        /// Coment�rio: Indica o codigo do produto que ser� impresso no cupom fiscal da 2075.
        /// </summary>
        private string usacodbarraembalagem;
        [XmlElement(ElementName = "USACODBARRAEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacodbarraembalagem
        {
            get { return  usacodbarraembalagem; }
            set {  usacodbarraembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACODCLIVENDA
        /// Coment�rio: Indica se utiliza cliente faturamento.
        /// </summary>
        private string usacodclivenda;
        [XmlElement(ElementName = "USACODCLIVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacodclivenda
        {
            get { return  usacodclivenda; }
            set {  usacodclivenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONSULTACHEQUE
        /// Coment�rio: Indica se usa ou n�o consulta de cheques.
        /// </summary>
        private string usaconsultacheque;
        [XmlElement(ElementName = "USACONSULTACHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaconsultacheque
        {
            get { return  usaconsultacheque; }
            set {  usaconsultacheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONTABIL
        /// Coment�rio: Indica se utiliza o m�dulo cont�bil.
        /// </summary>
        private string usacontabil;
        [XmlElement(ElementName = "USACONTABIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacontabil
        {
            get { return  usacontabil; }
            set {  usacontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONTROLELOCALIZACAOVEICULO
        /// Coment�rio: Indica se ser� utilizado controle de localiza��o por ve�culo. 
        /// </summary>
        private string usacontrolelocalizacaoveiculo;
        [XmlElement(ElementName = "USACONTROLELOCALIZACAOVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacontrolelocalizacaoveiculo
        {
            get { return  usacontrolelocalizacaoveiculo; }
            set {  usacontrolelocalizacaoveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADADOSEMBALAGEMNFE
        /// Coment�rio: Indica se usa embalagem quando utiliza NFE.
        /// </summary>
        private string usadadosembalagemnfe;
        [XmlElement(ElementName = "USADADOSEMBALAGEMNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadadosembalagemnfe
        {
            get { return  usadadosembalagemnfe; }
            set {  usadadosembalagemnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADIAUTILFILIAL
        /// Coment�rio: Campo para armazenar o c�digo da filial para cada dia �til.
        /// </summary>
        private string usadiautilfilial;
        [XmlElement(ElementName = "USADIAUTILFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadiautilfilial
        {
            get { return  usadiautilfilial; }
            set {  usadiautilfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADISTRIB
        /// Coment�rio: 
        /// </summary>
        private string usadistrib;
        [XmlElement(ElementName = "USADISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadistrib
        {
            get { return  usadistrib; }
            set {  usadistrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAENDERECOFILIAL
        /// Coment�rio: 
        /// </summary>
        private string usaenderecofilial;
        [XmlElement(ElementName = "USAENDERECOFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaenderecofilial
        {
            get { return  usaenderecofilial; }
            set {  usaenderecofilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAESTOQUEDEPFECHADO
        /// Coment�rio: 
        /// </summary>
        private string usaestoquedepfechado;
        [XmlElement(ElementName = "USAESTOQUEDEPFECHADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaestoquedepfechado
        {
            get { return  usaestoquedepfechado; }
            set {  usaestoquedepfechado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAINTEGRACAOOPERLOG
        /// Coment�rio: Indica a integra��o com o operador log�stico.
        /// </summary>
        private string usaintegracaooperlog;
        [XmlElement(ElementName = "USAINTEGRACAOOPERLOG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaintegracaooperlog
        {
            get { return  usaintegracaooperlog; }
            set {  usaintegracaooperlog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAINTEGRACAOWMS
        /// Coment�rio: Indica se no processo de expedi��o usa integra��o com algum sistema WMS.
        /// </summary>
        private string usaintegracaowms;
        [XmlElement(ElementName = "USAINTEGRACAOWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaintegracaowms
        {
            get { return  usaintegracaowms; }
            set {  usaintegracaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAINVENTLOCAL
        /// Coment�rio: Utiliza invent�rio por local.
        /// </summary>
        private string usainventlocal;
        [XmlElement(ElementName = "USAINVENTLOCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usainventlocal
        {
            get { return  usainventlocal; }
            set {  usainventlocal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAMULTIPLOPORDESCONTO
        /// Coment�rio: Usa multiplo por desconto.
        /// </summary>
        private string usamultiplopordesconto;
        [XmlElement(ElementName = "USAMULTIPLOPORDESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usamultiplopordesconto
        {
            get { return  usamultiplopordesconto; }
            set {  usamultiplopordesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANUMNFDEVCLI
        /// Coment�rio: 
        /// </summary>
        private string usanumnfdevcli;
        [XmlElement(ElementName = "USANUMNFDEVCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanumnfdevcli
        {
            get { return  usanumnfdevcli; }
            set {  usanumnfdevcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USANUMNOTAECF
        /// Coment�rio: Indica se ser� utilizada numera��o diferenciada para as notas fiscais emitidas pelo ECF. � v�lida quando feito o uso de servidor intermedi�rio de ECF. 
        /// </summary>
        private string usanumnotaecf;
        [XmlElement(ElementName = "USANUMNOTAECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usanumnotaecf
        {
            get { return  usanumnotaecf; }
            set {  usanumnotaecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAORCAMENTOECF
        /// Coment�rio: Indica se utiliza or�amento frente de loja.
        /// </summary>
        private string usaorcamentoecf;
        [XmlElement(ElementName = "USAORCAMENTOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaorcamentoecf
        {
            get { return  usaorcamentoecf; }
            set {  usaorcamentoecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPOLITICADESCVALOR
        /// Coment�rio: Indica se usa pol�tica de desconto baseada no valor total do pedido.
        /// </summary>
        private string usapoliticadescvalor;
        [XmlElement(ElementName = "USAPOLITICADESCVALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapoliticadescvalor
        {
            get { return  usapoliticadescvalor; }
            set {  usapoliticadescvalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPRECOETIQPRODPESADO
        /// Coment�rio: Indica se obtem na rotina 2075 o pre�o de venda contido no codigo de barras dos produtos pesados. 
        /// </summary>
        private string usaprecoetiqprodpesado;
        [XmlElement(ElementName = "USAPRECOETIQPRODPESADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaprecoetiqprodpesado
        {
            get { return  usaprecoetiqprodpesado; }
            set {  usaprecoetiqprodpesado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPVENDAATACCONFQTMULTIPLA
        /// Coment�rio: . 
        /// </summary>
        private string usapvendaatacconfqtmultipla;
        [XmlElement(ElementName = "USAPVENDAATACCONFQTMULTIPLA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapvendaatacconfqtmultipla
        {
            get { return  usapvendaatacconfqtmultipla; }
            set {  usapvendaatacconfqtmultipla = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPVENDATRANSF
        /// Coment�rio: Indica se utiliza o pre�o de venda na transferencia.
        /// </summary>
        private string usapvendatransf;
        [XmlElement(ElementName = "USAPVENDATRANSF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usapvendatransf
        {
            get { return  usapvendatransf; }
            set {  usapvendatransf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAREGIAOFILIALVENDAESTADUAL
        /// Coment�rio: Indica se utiliza regi�o da filial para venda estadual.
        /// </summary>
        private string usaregiaofilialvendaestadual;
        [XmlElement(ElementName = "USAREGIAOFILIALVENDAESTADUAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaregiaofilialvendaestadual
        {
            get { return  usaregiaofilialvendaestadual; }
            set {  usaregiaofilialvendaestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAREGIAOFILIALVENDAINTEREST
        /// Coment�rio: Indica se utiliza regi�o da filial para venda Interestadual.
        /// </summary>
        private string usaregiaofilialvendainterest;
        [XmlElement(ElementName = "USAREGIAOFILIALVENDAINTEREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaregiaofilialvendainterest
        {
            get { return  usaregiaofilialvendainterest; }
            set {  usaregiaofilialvendainterest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USASERVINTERMEDIARIO
        /// Coment�rio: Indica o uso de servidor intermedi�rio no auto-servi�o (PCSIS2016), alterando o tratamento do PCAUX2075. 
        /// </summary>
        private string usaservintermediario;
        [XmlElement(ElementName = "USASERVINTERMEDIARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaservintermediario
        {
            get { return  usaservintermediario; }
            set {  usaservintermediario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATRANSPORTADOPADRAONFE
        /// Coment�rio: Indica se utiliza transportador pad�o quando utiliza NFE.
        /// </summary>
        private string usatransportadopadraonfe;
        [XmlElement(ElementName = "USATRANSPORTADOPADRAONFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatransportadopadraonfe
        {
            get { return  usatransportadopadraonfe; }
            set {  usatransportadopadraonfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAWMS
        /// Coment�rio: 
        /// </summary>
        private string usawms;
        [XmlElement(ElementName = "USAWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usawms
        {
            get { return  usawms; }
            set {  usawms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOBANCODADOSWMS
        /// Coment�rio: Indica o usu�rio do banco de dados da integradora WMS.
        /// </summary>
        private string usuariobancodadoswms;
        [XmlElement(ElementName = "USUARIOBANCODADOSWMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usuariobancodadoswms
        {
            get { return  usuariobancodadoswms; }
            set {  usuariobancodadoswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOPROXY
        /// Coment�rio: Usu�rio do Proxy NFE
        /// </summary>
        private string usuarioproxy;
        [XmlElement(ElementName = "USUARIOPROXY", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usuarioproxy
        {
            get { return  usuarioproxy; }
            set {  usuarioproxy = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOSERV
        /// Coment�rio: Usu�rio do servidor de email NFE
        /// </summary>
        private string usuarioserv;
        [XmlElement(ElementName = "USUARIOSERV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usuarioserv
        {
            get { return  usuarioserv; }
            set {  usuarioserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACONTROLEBIOMETRICO
        /// Coment�rio: Indica a utiliza controle biometrico.
        /// </summary>
        private string utilizacontrolebiometrico;
        [XmlElement(ElementName = "UTILIZACONTROLEBIOMETRICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacontrolebiometrico
        {
            get { return  utilizacontrolebiometrico; }
            set {  utilizacontrolebiometrico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACREDICMSESTCUSTOCONT
        /// Coment�rio: Utilizar cr�d. custo ICMS estoque no custo cont�bil.
        /// </summary>
        private string utilizacredicmsestcustocont;
        [XmlElement(ElementName = "UTILIZACREDICMSESTCUSTOCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacredicmsestcustocont
        {
            get { return  utilizacredicmsestcustocont; }
            set {  utilizacredicmsestcustocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZACTE
        /// Coment�rio: Indica se a filial utiliza o processo de Conhecimento de Transporte Eletr�nico.
        /// </summary>
        private string utilizacte;
        [XmlElement(ElementName = "UTILIZACTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizacte
        {
            get { return  utilizacte; }
            set {  utilizacte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZANFE
        /// Coment�rio: Indica se a filial utiliza o processo de Nota Fiscal Eletr�nica. 
        /// </summary>
        private string utilizanfe;
        [XmlElement(ElementName = "UTILIZANFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizanfe
        {
            get { return  utilizanfe; }
            set {  utilizanfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAORIGEMVENDANF
        /// Coment�rio: Utiliza numera��o diferenciada por origem de venda.
        /// </summary>
        private string utilizaorigemvendanf;
        [XmlElement(ElementName = "UTILIZAORIGEMVENDANF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaorigemvendanf
        {
            get { return  utilizaorigemvendanf; }
            set {  utilizaorigemvendanf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAPERCBASEREDOUTRASDESPPF
        /// Coment�rio: 
        /// </summary>
        private string utilizapercbaseredoutrasdesppf;
        [XmlElement(ElementName = "UTILIZAPERCBASEREDOUTRASDESPPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizapercbaseredoutrasdesppf
        {
            get { return  utilizapercbaseredoutrasdesppf; }
            set {  utilizapercbaseredoutrasdesppf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZASEQNFENT
        /// Coment�rio: Indica se utiliza sequencia de NF de entrada.
        /// </summary>
        private string utilizaseqnfent;
        [XmlElement(ElementName = "UTILIZASEQNFENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaseqnfent
        {
            get { return  utilizaseqnfent; }
            set {  utilizaseqnfent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAVENDAASSISTIDA
        /// Coment�rio: Indica se utiliza venda assistida.
        /// </summary>
        private string utilizavendaassistida;
        [XmlElement(ElementName = "UTILIZAVENDAASSISTIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizavendaassistida
        {
            get { return  utilizavendaassistida; }
            set {  utilizavendaassistida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAVENDAPOREMBALAGEM
        /// Coment�rio: Indica o uso de venda por embalagem nos programas de venda (316, 336, 382).
        /// </summary>
        private string utilizavendaporembalagem;
        [XmlElement(ElementName = "UTILIZAVENDAPOREMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizavendaporembalagem
        {
            get { return  utilizavendaporembalagem; }
            set {  utilizavendaporembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDAENDPICKINGPEDCOMPRA
        /// Coment�rio: Informa��o do endere�o de Picking do Produto (utilizado na rotina 209 ).
        /// </summary>
        private string validaendpickingpedcompra;
        [XmlElement(ElementName = "VALIDAENDPICKINGPEDCOMPRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validaendpickingpedcompra
        {
            get { return  validaendpickingpedcompra; }
            set {  validaendpickingpedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARDESCFLEXAUTOSERV
        /// Coment�rio: Par�metro para permitir aplicar desconto no item - desconto flexivel cadastrado na rotina 201.
        /// </summary>
        private string validardescflexautoserv;
        [XmlElement(ElementName = "VALIDARDESCFLEXAUTOSERV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validardescflexautoserv
        {
            get { return  validardescflexautoserv; }
            set {  validardescflexautoserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARENDAPANHAAUTOSERVICO
        /// Coment�rio: Campo para validar endere�o de apanha auto-servi�o.
        /// </summary>
        private string validarendapanhaautoservico;
        [XmlElement(ElementName = "VALIDARENDAPANHAAUTOSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarendapanhaautoservico
        {
            get { return  validarendapanhaautoservico; }
            set {  validarendapanhaautoservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARPRECOVENDATV20
        /// Coment�rio: Valida o pre�o de venda no pedido de consigna��o (TV20).
        /// </summary>
        private string validarprecovendatv20;
        [XmlElement(ElementName = "VALIDARPRECOVENDATV20", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarprecovendatv20
        {
            get { return  validarprecovendatv20; }
            set {  validarprecovendatv20 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARPRECOVENDATV8
        /// Coment�rio: Valida o pre�o de venda no pedido entrega fatura (TV8).
        /// </summary>
        private string validarprecovendatv8;
        [XmlElement(ElementName = "VALIDARPRECOVENDATV8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarprecovendatv8
        {
            get { return  validarprecovendatv8; }
            set {  validarprecovendatv8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDAVLMAXISENCAOSTPF
        /// Coment�rio: Habilita o par�metro par�metro (Vl. M�ximo para Isen��o de ST para Pessoas F�sicas).
        /// </summary>
        private string validavlmaxisencaostpf;
        [XmlElement(ElementName = "VALIDAVLMAXISENCAOSTPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validavlmaxisencaostpf
        {
            get { return  validavlmaxisencaostpf; }
            set {  validavlmaxisencaostpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCAPITAL
        /// Coment�rio: 
        /// </summary>
        private decimal valorcapital;
        [XmlElement(ElementName = "VALORCAPITAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorcapital
        {
            get { return  valorcapital; }
            set {  valorcapital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOWMS
        /// Coment�rio: Indica a vers�o do WMS que o cliente utiliza.
        /// </summary>
        private decimal versaowms;
        [XmlElement(ElementName = "VERSAOWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Versaowms
        {
            get { return  versaowms; }
            set {  versaowms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXISENCAOSTPF
        /// Coment�rio: Indica se trabalham com a op��o de mostrar pre�o de venda sem st.
        /// </summary>
        private decimal vlmaxisencaostpf;
        [XmlElement(ElementName = "VLMAXISENCAOSTPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmaxisencaostpf
        {
            get { return  vlmaxisencaostpf; }
            set {  vlmaxisencaostpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXTARIFABANC
        /// Coment�rio: 
        /// </summary>
        private decimal vlmaxtarifabanc;
        [XmlElement(ElementName = "VLMAXTARIFABANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmaxtarifabanc
        {
            get { return  vlmaxtarifabanc; }
            set {  vlmaxtarifabanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINTARIFABANC
        /// Coment�rio: 
        /// </summary>
        private decimal vlmintarifabanc;
        [XmlElement(ElementName = "VLMINTARIFABANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlmintarifabanc
        {
            get { return  vlmintarifabanc; }
            set {  vlmintarifabanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPALETEDESCARG
        /// Coment�rio: Valor palete descarga.
        /// </summary>
        private decimal vlpaletedescarg;
        [XmlElement(ElementName = "VLPALETEDESCARG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpaletedescarg
        {
            get { return  vlpaletedescarg; }
            set {  vlpaletedescarg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPESODESCARGA
        /// Coment�rio: Valor peso descarga.
        /// </summary>
        private decimal vlpesodescarga;
        [XmlElement(ElementName = "VLPESODESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpesodescarga
        {
            get { return  vlpesodescarga; }
            set {  vlpesodescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPESODESCARGAPAL
        /// Coment�rio: Valor peso descarga palete.
        /// </summary>
        private decimal vlpesodescargapal;
        [XmlElement(ElementName = "VLPESODESCARGAPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpesodescargapal
        {
            get { return  vlpesodescargapal; }
            set {  vlpesodescargapal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLREMONTEDESCARGA
        /// Coment�rio: Valor remonte descarga.
        /// </summary>
        private decimal vlremontedescarga;
        [XmlElement(ElementName = "VLREMONTEDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlremontedescarga
        {
            get { return  vlremontedescarga; }
            set {  vlremontedescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTARIFA
        /// Coment�rio: 
        /// </summary>
        private decimal vltarifa;
        [XmlElement(ElementName = "VLTARIFA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vltarifa
        {
            get { return  vltarifa; }
            set {  vltarifa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVOLDESCARGA
        /// Coment�rio: Valor volume descarga.
        /// </summary>
        private decimal vlvoldescarga;
        [XmlElement(ElementName = "VLVOLDESCARGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlvoldescarga
        {
            get { return  vlvoldescarga; }
            set {  vlvoldescarga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVOLUMEDESCARGAFD
        /// Coment�rio: Valor volume descarga FD.
        /// </summary>
        private decimal vlvolumedescargafd;
        [XmlElement(ElementName = "VLVOLUMEDESCARGAFD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlvolumedescargafd
        {
            get { return  vlvolumedescargafd; }
            set {  vlvolumedescargafd = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFilial>(where);
        }

        #endregion
    }
}
