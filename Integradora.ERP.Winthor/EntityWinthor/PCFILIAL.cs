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
        /// Comentário: Indica se aceita venda a vista para cliente bloqueado.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Valor da Alíquota de Frete Estadual, parametrizado na rotina 535 - Cadastro de Filial, na pasta Outros.|Atender a legislação de frete para clientes, isentos e tributados.
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
        /// Comentário: Altera pedido retornado pelo WMS.
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
        /// Comentário: Indica se alterar BK para CH automáticamente.
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
        /// Comentário: Indica o ambiente da NF-e.
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
        /// Comentário: Indica se aplica % de acréscimo no preço de atacado para não contribuinte.
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
        /// Comentário: Indica se aplica % de acréscimo no preço de varejo para não contribuinte.
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
        /// Comentário: Indica se aproveita despesa acessoria.
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
        /// Comentário: Indica se aproveita Frete.
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
        /// Comentário: Indica se aproveita IPI.
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
        /// Comentário: 
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
        /// Comentário: Arredonda o valor do campo PCEST.QTGIRODIA ao fazer o cálculo da recomposição de estoque. (S)im ou (N)ao.
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
        /// Comentário: Indica se arredonda ou não o valor dos intens na NF saida.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Atualiza custos da ultima entrada na transferência.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica se desdobramento de títulos (402, 1210) será permitido com títulos/notas de emitentes diferentes. 
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
        /// Comentário: Indica se bloqueia estoque na entrada de devolução de cliente. 
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
        /// Comentário: Bloqueia estoque na transferência entre filiais.
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
        /// Comentário: Indicar se pedido de venda sera bloqueado se o valor for inferior ao mínimo.
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
        /// Comentário: Indica se irá bloquear o cliente na importação do arquivo SERASA.
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
        /// Comentário: Indica se as vendas para pessoa física deverão ou não ser permitidas.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Calcula est. disponível com qtde mínima Auto-Serviço. 
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
        /// Comentário: Indica se o % de Pis irá abater o valor do frete, e com isso afetar os custos, exceto o custo contábil.
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
        /// Comentário: Indica se o % de Pis irá abater o valor do frete, afetando o custo contábil.
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
        /// Comentário: Indica se irá calcular comissão sobre preço de venda a vista. 
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
        /// Comentário: Indica se calcula IPI na venda.
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
        /// Comentário: Cancela nota fiscal de devolução a cliente com WMS.
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
        /// Comentário: Cancela nota fiscal de entrada com WMS.
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
        /// Comentário: Cancela nota fiscal de venda a cliente com WMS.
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
        /// Comentário: Cancela pedido retornado pelo WMS.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o CGC do operador logístico.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Definir se o crédito ao cliente vai ser lançado de forma padrão com situação igual a pendente.
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
        /// Comentário: CNPJ EMPRESA DESENVOLVEDORA
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o código da conta para geração de crédito a fornecedor.
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
        /// Comentário: 
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
        /// Comentário: Campo para armazenar o código da conta para lançamento de receita ou despesa realizado na entrada de mercadoria de importação.
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
        /// Comentário: Código da Conta que será creditado valor referente ao acréscimo de mercadoria.
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
        /// Comentário: Indica o código da conta para recargas.
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
        /// Comentário: Indica o código da conta de venda entrega futura.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o código do layout da nota de cobrança.
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
        /// Comentário: Indica o código do documento layout) por origem de venda.
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
        /// Comentário: Código do Documento para Nota Fiscal de Serviço. 
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
        /// Comentário: 
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
        /// Comentário: Indica a simples remessa do auto serviço.
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
        /// Comentário: Indicação do layout de nota fiscal de serviçõ a ser usado na rotina 1446. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Código fiscal opcional na entrada de importação.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Global Localization Number
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
        /// Comentário: 
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
        /// Comentário: Código do Grupo da Filial
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
        /// Comentário: Grupo de Filiais classificadas como Lojas 
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
        /// Comentário: 
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
        /// Comentário: CODIGO MD5 DA ROTINA 2030
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Conceder desconto referente a isenção de ST para pessoa física.
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
        /// Comentário: Indica se conferi somente pedidos faturados acertados no caixa (rotinas 402 e 409).
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
        /// Comentário: Considera estq. Pendente na sugestão de compra.
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
        /// Comentário: Indica que considera a montagem de produto no giro da mercadoria.
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
        /// Comentário: Campo para indicar se as comissões com valor zero ou nulo serão utilizadas para avaliação. 
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
        /// Comentário: 
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
        /// Comentário: Indica se a filial consolida dados na execução da 504.
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
        /// Comentário: 
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
        /// Comentário: Indica se controla garantia do serviço.
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
        /// Comentário: Controlar NF-e Manifesto (tv 14) por rota
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
        /// Comentário: Controle número NF-e por Série.
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
        /// Comentário: Indica que realiza corte automático na importação de pedidos de venda com WMS.
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
        /// Comentário: Data Hora Primeiro Doc. ECF
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
        /// Comentário: Depósito fechado ou não
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
        /// Comentário: Destaca imposto no TV13.
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
        /// Comentário: Indica se irá destacar impostos na venda manifesto TV14. 
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
        /// Comentário: Devolução de fornecedor somente com estoque de avaria.
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
        /// Comentário: Dias de Curvatura
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
        /// Comentário: Dias prazo transferência Filial Retira
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
        /// Comentário: Indica o dia de vencimento do ICMS antecipado.
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
        /// Comentário: Diretório de Exportação do XML SNGPC
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
        /// Comentário: Domínio do servidor de email NFE
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
        /// Comentário: Data da Alteração da Matrícula do Usuário SNGPC
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
        /// Comentário: Indica a data de inativação da filial.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Campo que armazena a última data da atualização de um servidor intermediário.
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
        /// Comentário: Data da ultima consulta das notas destinatario
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
        /// Comentário: Indica a data que a CT-e começou a ser utilizada na filial.
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
        /// Comentário: Indica a data que a NF-e começou a ser utilizada na filial. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Email de copia para resposta do servidor NFE
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
        /// Comentário: Email do remetente do servidor de email NFE
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
        /// Comentário: Email para resposta do servidor NFE
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
        /// Comentário: Define se a empresa é de grande porte.
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
        /// Comentário: 
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
        /// Comentário: Endereço Complementar será utilizado para envio do sped fiscal
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
        /// Comentário: Endereço do Proxy NFE
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
        /// Comentário: 
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
        /// Comentário: Envia os dados de cobranças(ENTRADA) para o SEFAZ.
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
        /// Comentário: Envia dados de cobrança(SAÍDA) para o SEFAZ.
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
        /// Comentário: Indica se estorna custo na devolução do fornecedor.
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
        /// Comentário: Exibir impostos Fora NF importação pedido compra.
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
        /// Comentário: Indica a obrigação da emissão de mapa de separação na venda balcão. 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica se será gerado no livro fiscal valores de base de calculo e ICMS normal quando o produto possuir substituição tributária. |Campo texto de tamanho 1.
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
        /// Comentário: Indica se gerar pedidos das faltas.
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
        /// Comentário: Indica o se será gerado o NSU (número sequencial único) para todas as notas fiscais emitidas (entradas e saídas). Esta informação é referente a legislação do estado de Santa Catarina.
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
        /// Comentário: 
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
        /// Comentário: Indica se a filial mantem historico do estoque.
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
        /// Comentário: Indica se será gerado pedido de consignação para os vasilhames aos produtos associados. 
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
        /// Comentário: Gravar valor desconto financeiro
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
        /// Comentário: Indica a data/hora final para digitação de pedidos.
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
        /// Comentário: Indica a data/hora final para importação de pedidos.
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
        /// Comentário: Indica a data/hora inicial para digitação de pedidos.
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
        /// Comentário: Indica a data/hora inicial para importação de pedidos.
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
        /// Comentário: Indica a hora fim do almoço.
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
        /// Comentário: Indica a hora do fim de expediente.
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
        /// Comentário: Indica a hora do inicio do almoço.
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
        /// Comentário: Indica a hora do inicio expediente.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Impede geração tipo 14.
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
        /// Comentário: Indica se o faturamento irá recalcular a base de substituição tributária dos itens para lançar outras despesas e frete.
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
        /// Comentário: 
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
        /// Comentário: Indice a ser aplicado no custo da transferência.
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
        /// Comentário: 
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
        /// Comentário: Informar o profissional na venda.
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
        /// Comentário: Indica o código da empresa integradora de WMS.
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
        /// Comentário: Indica se irá agregar valor do IPI somente no valor contábil na geração do Livro Fiscal.
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
        /// Comentário: Lançar frete referente ao peso das mercadorias automáticamente no faturamento. 
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
        /// Comentário: Mensagem NF Imunidade Tributária.
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
        /// Comentário: 
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
        /// Comentário: Limite para bloqueio do cliente por Risk Scoring (SERASA).
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
        /// Comentário: Matricula de usuário SNGPC
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
        /// Comentário: Matricula de usuário SNGPC Anterior
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
        /// Comentário: 
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
        /// Comentário: Mensagem NF Imunidade Tributária.
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
        /// Comentário: Quantidade máxima de mix que será utilizado na reposição de lojas
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
        /// Comentário: Quantidade mínima de mix que será utilizado na reposição de lojas
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
        /// Comentário: Indica se o carregamento será montado no Winthor.
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
        /// Comentário: 
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
        /// Comentário: Indica se monta kit\cesta-básica automáticamente.
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
        /// Comentário: Indica que não gerar crédito de ICMS na entrada de transferência.
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
        /// Comentário: Indica o nome do banco de dados da integradora WMS.
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
        /// Comentário: NOME COMERCIAL DA ROTINA 2030
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
        /// Comentário: 
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
        /// Comentário: Nome do remetente do servidor de email NFE
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
        /// Comentário: Número Sequencial Único
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
        /// Comentário: 
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
        /// Comentário: Indica número de dias máximo para liberar pedido.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Informar o número máximo de dias retroativos para data de compensação.
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
        /// Comentário: Indica o número de itens na nota fiscal eletrônica.
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMREGIAOBALCAOINTER
        /// Comentário: Indica a região para venda balcão interestadual.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Obriga a identificação do cons. final na devol. de cliente.
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
        /// Comentário: Indica se a filial é do tipo Operador Logístico. 
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
        /// Comentário: 
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
        /// Comentário: Indica se e optante ao simples nacional.
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
        /// Comentário: Indica os campos para desdobramento por agrupamento onde o padrão(CODFILIAL, CODCLI, DTVENC,CODCOB)(PCPREST).
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
        /// Comentário: 
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
        /// Comentário: Indica a origem do custo para filial retira.
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
        /// Comentário: Indica a origem de venda para emissão da nota fiscal.
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
        /// Comentário: Produto em manutenção é obrigatorio na ordem de serviço.
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
        /// Comentário: Percentual de Redução da Base ICMS de Despesas Acessórias.
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
        /// Comentário: Percentual de redução da base de ICMS de outras desp. para PF.
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
        /// Comentário: Indica o percentual de acrescimo na venda balcão.
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
        /// Comentário: Indica o percentual de acréscimo de Custo dos Produtos. 
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
        /// Comentário: Percentual de Declinio da Curva ABC
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
        /// Comentário: 
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
        /// Comentário: Percentual de Evolução da Curva ABC
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
        /// Comentário: Indica o percentual de ICMS do simples nacional.
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
        /// Comentário: Indica o percentual máximo diferença produto similar.
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
        /// Comentário: % MIn. Dif. P.Venda do prod. similar
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
        /// Comentário: Indica o percentual de comissão a ser paga pela indústria para uma filial que seja Broker.
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
        /// Comentário: Indica o % de comissão motorista Broker.
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
        /// Comentário: Indica o % de comissão RCA Broker.
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
        /// Comentário: Percentual minimo de participacao para o produto ser classificado na Classe A.
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
        /// Comentário: Percentual minimo de participacao para o produto ser classificado na Classe B.
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
        /// Comentário: % minimo de participacao para o produto ser classificado na Classe A1.
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
        /// Comentário: % minimo de participacao para o produto ser classificado na Classe A2.
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
        /// Comentário: % minimo de participacao para o produto ser classificado na Classe A3.
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
        /// Comentário: % minimo de participacao para o produto ser classificado na Classe B1.
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
        /// Comentário: % minimo de participacao para o produto ser classificado na Classe B2.
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
        /// Comentário: % minimo de participacao para o produto ser classificado na Classe B3.
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
        /// Comentário:  % minimo de participacao para o produto ser classificado na Sub-Classe C1.
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
        /// Comentário:  % minimo de participacao para o produto ser classificado na Sub-Classe C2.
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
        /// Comentário: Indica o percentual de frete pago pela indústria para uma filial que seja Broker.
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
        /// Comentário: 
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
        /// Comentário: Percentual limite de venda para pessoa física.
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
        /// Comentário: Indica se será permitido agrupar títulos de um mesmo carregamento, cliente, vencimento e cobrança, através da módulo 15. 
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
        /// Comentário: Campo para indicar se será permito cancelar as notas fiscais de entrada já exportadas para o WMS de integração.
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
        /// Comentário: 
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
        /// Comentário: Indica se e permitido faturar orçamento(PCVAR339).
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
        /// Comentário: Permitir desdobramento de títulos de diferentes profissionais.
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
        /// Comentário: Indica se é permitida a venda estadual para Pessoa Física, com Inscrição Estadual.
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
        /// Comentário: Indica se é permitida a venda estadual para Pessoa Física, sem Inscrição Estadual.
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
        /// Comentário: Indica se é permitida a venda interestadual para Pessoa Física.
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
        /// Comentário: 
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
        /// Comentário: Indica o peso limite para quebra de OS.
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
        /// Comentário: Ponderar custo na transferência.
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
        /// Comentário: Porta do Proxy NFE
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
        /// Comentário: Porta do servidor NFE
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
        /// Comentário: Indica o prazo máximo para importação pedido pendente Auto-serviço.
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
        /// Comentário: Indica se precificação para as 7 colunas Varejo/Atacado na rotina 201 serão replicadas automaticamente. 
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
        /// Comentário: Indica o preço de venda pela embalagem (2015) nos programas de venda (2075, 316, 336, 382).
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
        /// Comentário: 
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
        /// Comentário: Indica o próximo NSU (número sequencial único) que dever ser gerado e impresso em todas as notas fiscais geradas (entrada ou saída). Esta informação é referente a legislação do estado de Santa Catarina.
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
        /// Comentário: 
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
        /// Comentário: Numerador de carregamento usado para as vendas ECF (PCAUX2075) se usado servidor intermediário. 
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
        /// Comentário: Indica o próximo número do conhecimento de frete. 
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
        /// Comentário: Próximo Número de nota de Conhecimento de Frete eletrônico
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
        /// Comentário: Indica o próximo número sequencial único de entrada. Trata-se de um numerador independente para controle fiscal e sequencial das notas de compra (México).
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Proximo numero de MDF-e
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
        /// Comentário: 
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
        /// Comentário: Próximo Número da Nota Fiscal Eletrônica. 
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
        /// Comentário: Contador de numero de nota fiscal eletrônica para devolução de venda manifesto
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
        /// Comentário: Contador de numero de nota fiscal eletrônica para devolução de venda manifesto Scan
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
        /// Comentário: Próximo número de nota para o envio normal da NF-e; Operações de entrada..
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
        /// Comentário: Próximo número nota para envio de notas fiscais de importação em ambiente normal
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
        /// Comentário: Contador de numero de nota fiscal eletrônica para remessa de venda manifesto
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
        /// Comentário: Contador de numero de nota fiscal eletrônica para remessa de venda manifesto Scan
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
        /// Comentário: Próximo número de nota para o envio Scan da NF-e.
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
        /// Comentário: Próximo número de nota para o envio Scan da NF-e; Operações de entrada.
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
        /// Comentário: Próximo número nota para envio de notas fiscais de importação em ambiente SCAN
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
        /// Comentário: Próximo numero para nota fiscal de serviço.
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
        /// Comentário: 
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
        /// Comentário: Indica o próximo número nota de cobrança.
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
        /// Comentário: 
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
        /// Comentário: Numerador de notas fiscais Usado para as vendas ECF (PCAUX2075) e para a emissão de nota fiscal espelho se usado servidor intermediário. 
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
        /// Comentário: Campo para o próximo número de nota fiscal por origem de venda.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o próximo número de orçamento. 
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
        /// Comentário: Próximo número de O.S.
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
        /// Comentário: 
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
        /// Comentário: Indica o próximo número de transação para geração dos conhecimento de frete. 
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
        /// Comentário: Numerador usado para movimentação de saldo caixa/banco para vales do ECF (PCAUX2075) na emissão de boleto bancário se usado servidor intermediário. 
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
        /// Comentário: Transação de venda usado para as vendas ECF (PCAUX2075) e para a emissão de nota fiscal espelho se usado servidor intermediário. 
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
        /// Comentário: Quantidade máxima de dias para o vencimento de novas verbas.
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
        /// Comentário: Indica a quantidade máxima de itens por OS.
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
        /// Comentário: Indica a quantidade minima de itens por módulo na quebra de OS.
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
        /// Comentário: Quantidade máxima de itens do pedido de transferência
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
        /// Comentário: Indica o parametro para definir quantidade múltipla inicial.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica se recalcula o DV do produto ao alterar o cadastro.
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
        /// Comentário: Indica que reduzir o ICMS próprio na transferência.
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
        /// Comentário: Indica o tipo de arredondamento para a rotina 2075.
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
        /// Comentário: Indica retira o desconto na baixa.
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
        /// Comentário: ROTINA QUE GRAVOU A INFORMACAO
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
        /// Comentário: Indica a senha do banco de dados da integradora WMS.
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
        /// Comentário: Senha do Proxy NFE
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
        /// Comentário: Senha do servidor de email NFE
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
        /// Comentário: Próximo Número de Série de Conhecimento de Frete eletrônico
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
        /// Comentário: Serie MDF-e
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
        /// Comentário: Número de Série da Nota Fiscal Eletrônica. 
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
        /// Comentário: Número de Série de nota fiscal eletrônica para devolução de venda manifesto
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
        /// Comentário: Número de Série de nota fiscal eletrônica para devolução de venda manifesto Scan
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
        /// Comentário: Série da nota para envio normal da NF-e; Operações de entrada.
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
        /// Comentário: Série para envio de notas fiscal de importação em ambiente normal
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
        /// Comentário: Número de Série de nota fiscal eletrônica para remessa de venda manifesto
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
        /// Comentário: Número de Série de nota fiscal eletrônica para remessa de venda manifesto Scan
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
        /// Comentário: Série da Nota Fiscal Eletrônica e SCAN. 
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
        /// Comentário: Série da nota para envio Scan da NF-e; Operações de entrada.
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
        /// Comentário: Série para envio de notas fiscal de importação em ambiente SCAN
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
        /// Comentário: Série para uso da nota fiscal de serviço.
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
        /// Comentário: Endereço do servidor SMTP da NFE
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
        /// Comentário: Situação tributária opcional na entrada de importação.
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
        /// Comentário: Indica se soma o ICMS na transferência.
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
        /// Comentário: 
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
        /// Comentário: Indica se utiliza ST.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica o tempo de separação por caixa.
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
        /// Comentário: Indica o tempo inicial de separação.
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
        /// Comentário: Indica o tempo de separação por produto.
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
        /// Comentário: Campo para indicar o tipo de avaliação da comissão para RCA. 
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
        /// Comentário: 
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
        /// Comentário: Tipo de CNPJ da empresa se é M ¿ Matriz ou F ¿ Filial.
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
        /// Comentário: Tipo de Impressão do da NF-e: Retrato ou Paisagem. 
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
        /// Comentário: Campo para posibilitar a exportação de dados por arquivos na rotina 2001.
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
        /// Comentário: Informa se a filial é um CD ou uma loja  1=CD, 2=LOJA  Valor Default = "1"
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
        /// Comentário: Indica o tipo do cálculo do Frente.
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
        /// Comentário: Identifica como vai ser a autenticação do cartão.
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
        /// Comentário: Indica o tipo de montagem de carregamento (Rota ou Transportadora).
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
        /// Comentário: Indica tipo de sequencia do NUMMAPA na rotina 1064, que pode ser Dia [D] ou Mês [M].
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
        /// Comentário: Indica se irá utilizar para a sequencia de número de nota fiscal tipo descarga 4, a partir da NF Venda ou da NF Devolução de Cliente
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
        /// Comentário: Indica se a precificação na rotina 201 é por Varejo (Preço normal é o maior) ou se precifica por Atacado (Preço normal é o menor). Valores possíveis "V" ou "A". 
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
        /// Comentário: Indica se utiliza valor ST na transferência.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica se utiliza brinde na rotina 2075.
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
        /// Comentário: Indica o codigo do produto que será impresso no cupom fiscal da 2075.
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
        /// Comentário: Indica se utiliza cliente faturamento.
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
        /// Comentário: Indica se usa ou não consulta de cheques.
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
        /// Comentário: Indica se utiliza o módulo contábil.
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
        /// Comentário: Indica se será utilizado controle de localização por veículo. 
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
        /// Comentário: Indica se usa embalagem quando utiliza NFE.
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
        /// Comentário: Campo para armazenar o código da filial para cada dia útil.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Indica a integração com o operador logístico.
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
        /// Comentário: Indica se no processo de expedição usa integração com algum sistema WMS.
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
        /// Comentário: Utiliza inventário por local.
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
        /// Comentário: Usa multiplo por desconto.
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
        /// Comentário: 
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
        /// Comentário: Indica se será utilizada numeração diferenciada para as notas fiscais emitidas pelo ECF. É válida quando feito o uso de servidor intermediário de ECF. 
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
        /// Comentário: Indica se utiliza orçamento frente de loja.
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
        /// Comentário: Indica se usa política de desconto baseada no valor total do pedido.
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
        /// Comentário: Indica se obtem na rotina 2075 o preço de venda contido no codigo de barras dos produtos pesados. 
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
        /// Comentário: . 
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
        /// Comentário: Indica se utiliza o preço de venda na transferencia.
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
        /// Comentário: Indica se utiliza região da filial para venda estadual.
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
        /// Comentário: Indica se utiliza região da filial para venda Interestadual.
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
        /// Comentário: Indica o uso de servidor intermediário no auto-serviço (PCSIS2016), alterando o tratamento do PCAUX2075. 
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
        /// Comentário: Indica se utiliza transportador padão quando utiliza NFE.
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
        /// Comentário: 
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
        /// Comentário: Indica o usuário do banco de dados da integradora WMS.
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
        /// Comentário: Usuário do Proxy NFE
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
        /// Comentário: Usuário do servidor de email NFE
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
        /// Comentário: Indica a utiliza controle biometrico.
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
        /// Comentário: Utilizar créd. custo ICMS estoque no custo contábil.
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
        /// Comentário: Indica se a filial utiliza o processo de Conhecimento de Transporte Eletrônico.
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
        /// Comentário: Indica se a filial utiliza o processo de Nota Fiscal Eletrônica. 
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
        /// Comentário: Utiliza numeração diferenciada por origem de venda.
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
        /// Comentário: 
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
        /// Comentário: Indica se utiliza sequencia de NF de entrada.
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
        /// Comentário: Indica se utiliza venda assistida.
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
        /// Comentário: Indica o uso de venda por embalagem nos programas de venda (316, 336, 382).
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
        /// Comentário: Informação do endereço de Picking do Produto (utilizado na rotina 209 ).
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
        /// Comentário: Parâmetro para permitir aplicar desconto no item - desconto flexivel cadastrado na rotina 201.
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
        /// Comentário: Campo para validar endereço de apanha auto-serviço.
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
        /// Comentário: Valida o preço de venda no pedido de consignação (TV20).
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
        /// Comentário: Valida o preço de venda no pedido entrega fatura (TV8).
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
        /// Comentário: Habilita o parâmetro parâmetro (Vl. Máximo para Isenção de ST para Pessoas Físicas).
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
        /// Comentário: 
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
        /// Comentário: Indica a versão do WMS que o cliente utiliza.
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
        /// Comentário: Indica se trabalham com a opção de mostrar preço de venda sem st.
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Valor palete descarga.
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
        /// Comentário: Valor peso descarga.
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
        /// Comentário: Valor peso descarga palete.
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
        /// Comentário: Valor remonte descarga.
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
        /// Comentário: 
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
        /// Comentário: Valor volume descarga.
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
        /// Comentário: Valor volume descarga FD.
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
