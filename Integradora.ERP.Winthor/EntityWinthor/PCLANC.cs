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
    /// Classe referente a tabela PCLanc
    /// </summary>
    [XmlType("PCLANC")]
    public class PCLanc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ADIANTAMENTO
        /// Comentário: Campo para identificar se o lançamento de contas a pagar é proveniente de um adiantamento - (Rotina 745).
        /// </summary>
        private string adiantamento;
        [XmlElement(ElementName = "ADIANTAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Adiantamento
        {
            get { return  adiantamento; }
            set {  adiantamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGENDAMENTO
        /// Comentário: Indica se o lançamento foi enviado para agendamento S ou N.
        /// </summary>
        private string agendamento;
        [XmlElement(ElementName = "AGENDAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Agendamento
        {
            get { return  agendamento; }
            set {  agendamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ASSINATURA
        /// Comentário: 
        /// </summary>
        private string assinatura;
        [XmlElement(ElementName = "ASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Assinatura
        {
            get { return  assinatura; }
            set {  assinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BOLETO
        /// Comentário: .
        /// </summary>
        private string boleto;
        [XmlElement(ElementName = "BOLETO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Boleto
        {
            get { return  boleto; }
            set {  boleto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOMPRADOR
        /// Comentário: Comprador do produto. Na rotina de 1301 - Entrada de Mercadoria será pesquisado o código comprador do pedido de compra e gravar nesse campo.
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
        /// Comentário: 
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNECPRINC
        /// Comentário: 
        /// </summary>
        private decimal codfornecprinc;
        [XmlElement(ElementName = "CODFORNECPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfornecprinc
        {
            get { return  codfornecprinc; }
            set {  codfornecprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAUTOR
        /// Comentário: 
        /// </summary>
        private decimal codfuncautor;
        [XmlElement(ElementName = "CODFUNCAUTOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncautor
        {
            get { return  codfuncautor; }
            set {  codfuncautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCBAIXA
        /// Comentário: 
        /// </summary>
        private decimal codfuncbaixa;
        [XmlElement(ElementName = "CODFUNCBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncbaixa
        {
            get { return  codfuncbaixa; }
            set {  codfuncbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCESTORNOBAIXA
        /// Comentário: 
        /// </summary>
        private decimal codfuncestornobaixa;
        [XmlElement(ElementName = "CODFUNCESTORNOBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncestornobaixa
        {
            get { return  codfuncestornobaixa; }
            set {  codfuncestornobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRECLASSIFIC
        /// Comentário: 
        /// </summary>
        private decimal codfuncreclassific;
        [XmlElement(ElementName = "CODFUNCRECLASSIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncreclassific
        {
            get { return  codfuncreclassific; }
            set {  codfuncreclassific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Comentário: Código do funcionário da última alteração do lançamento pela rotina 750.
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
        /// Propriedade referente ao campo: CODLANCAMENTORM
        /// Comentário: Código de lançamento RM
        /// </summary>
        private string codlancamentorm;
        [XmlElement(ElementName = "CODLANCAMENTORM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Codlancamentorm
        {
            get { return  codlancamentorm; }
            set {  codlancamentorm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROJETO
        /// Comentário: Código de Projeto. Cadastrado na 607 e informado na 749 e 631.
        /// </summary>
        private decimal codprojeto;
        [XmlElement(ElementName = "CODPROJETO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprojeto
        {
            get { return  codprojeto; }
            set {  codprojeto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRECEITA
        /// Comentário: Código da Receita para Lançamentos de Tributos
        /// </summary>
        private decimal codreceita;
        [XmlElement(ElementName = "CODRECEITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codreceita
        {
            get { return  codreceita; }
            set {  codreceita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINAALT
        /// Comentário: Rotina de alteração do contas a pagar
        /// </summary>
        private string codrotinaalt;
        [XmlElement(ElementName = "CODROTINAALT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codrotinaalt
        {
            get { return  codrotinaalt; }
            set {  codrotinaalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINABAIXA
        /// Comentário: 
        /// </summary>
        private decimal codrotinabaixa;
        [XmlElement(ElementName = "CODROTINABAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotinabaixa
        {
            get { return  codrotinabaixa; }
            set {  codrotinabaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINACAD
        /// Comentário: Rotina de cadastro do contas a pagar
        /// </summary>
        private string codrotinacad;
        [XmlElement(ElementName = "CODROTINACAD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codrotinacad
        {
            get { return  codrotinacad; }
            set {  codrotinacad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COTACAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: COTACAOBAIXA
        /// Comentário: 
        /// </summary>
        private decimal cotacaobaixa;
        [XmlElement(ElementName = "COTACAOBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Cotacaobaixa
        {
            get { return  cotacaobaixa; }
            set {  cotacaobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCONTOFIN
        /// Comentário: 
        /// </summary>
        private decimal descontofin;
        [XmlElement(ElementName = "DESCONTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Descontofin
        {
            get { return  descontofin; }
            set {  descontofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAGENDAMENTO
        /// Comentário: Data do agendamento.
        /// </summary>
        private DateTime? dtagendamento;
        [XmlElement(ElementName = "DTAGENDAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtagendamento
        {
            get { return  dtagendamento; }
            set {  dtagendamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTASSINATURA
        /// Comentário: 
        /// </summary>
        private DateTime? dtassinatura;
        [XmlElement(ElementName = "DTASSINATURA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtassinatura
        {
            get { return  dtassinatura; }
            set {  dtassinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAUTOR
        /// Comentário: 
        /// </summary>
        private DateTime? dtautor;
        [XmlElement(ElementName = "DTAUTOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtautor
        {
            get { return  dtautor; }
            set {  dtautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBLOQ
        /// Comentário: Data do bloqueio.
        /// </summary>
        private DateTime? dtbloq;
        [XmlElement(ElementName = "DTBLOQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbloq
        {
            get { return  dtbloq; }
            set {  dtbloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBORDER
        /// Comentário: 
        /// </summary>
        private DateTime? dtborder;
        [XmlElement(ElementName = "DTBORDER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtborder
        {
            get { return  dtborder; }
            set {  dtborder = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data cancelamento contas a pagar de entrada de NF.
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCHEQ
        /// Comentário: 
        /// </summary>
        private DateTime? dtcheq;
        [XmlElement(ElementName = "DTCHEQ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcheq
        {
            get { return  dtcheq; }
            set {  dtcheq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOMPETENCIA
        /// Comentário: Indica a data da competencia.
        /// </summary>
        private DateTime? dtcompetencia;
        [XmlElement(ElementName = "DTCOMPETENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcompetencia
        {
            get { return  dtcompetencia; }
            set {  dtcompetencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOTACAO
        /// Comentário: Campo para armazenar a data da cotação do pedido de compra.
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
        /// Propriedade referente ao campo: DTDESD
        /// Comentário: Indica a data de desdobramento dos títulos gerados.
        /// </summary>
        private DateTime? dtdesd;
        [XmlElement(ElementName = "DTDESD", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdesd
        {
            get { return  dtdesd; }
            set {  dtdesd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTESTORNOBAIXA
        /// Comentário: 
        /// </summary>
        private DateTime? dtestornobaixa;
        [XmlElement(ElementName = "DTESTORNOBAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtestornobaixa
        {
            get { return  dtestornobaixa; }
            set {  dtestornobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPRESSAO
        /// Comentário: Data de impressão do Cheque/Boleto.
        /// </summary>
        private DateTime? dtimpressao;
        [XmlElement(ElementName = "DTIMPRESSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimpressao
        {
            get { return  dtimpressao; }
            set {  dtimpressao = value; }
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
        /// Propriedade referente ao campo: DTMOEDA
        /// Comentário: 
        /// </summary>
        private string dtmoeda;
        [XmlElement(ElementName = "DTMOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dtmoeda
        {
            get { return  dtmoeda; }
            set {  dtmoeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGADIANTFOR
        /// Comentário: Data que o lancto. adiant. fornecedor foi pago (conciliado) pela 746.
        /// </summary>
        private DateTime? dtpagadiantfor;
        [XmlElement(ElementName = "DTPAGADIANTFOR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagadiantfor
        {
            get { return  dtpagadiantfor; }
            set {  dtpagadiantfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPAGTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtpagto;
        [XmlElement(ElementName = "DTPAGTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpagto
        {
            get { return  dtpagto; }
            set {  dtpagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPRORROG
        /// Comentário: 
        /// </summary>
        private DateTime? dtprorrog;
        [XmlElement(ElementName = "DTPRORROG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprorrog
        {
            get { return  dtprorrog; }
            set {  dtprorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRECLASSIFIC
        /// Comentário: 
        /// </summary>
        private DateTime? dtreclassific;
        [XmlElement(ElementName = "DTRECLASSIFIC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtreclassific
        {
            get { return  dtreclassific; }
            set {  dtreclassific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Comentário: Data da última alteração do lançamento pela rotina 750.
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
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DUPLIC
        /// Comentário: 
        /// </summary>
        private string duplic;
        [XmlElement(ElementName = "DUPLIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Duplic
        {
            get { return  duplic; }
            set {  duplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVAG
        /// Comentário: 
        /// </summary>
        private string dvag;
        [XmlElement(ElementName = "DVAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Dvag
        {
            get { return  dvag; }
            set {  dvag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMAPGTO
        /// Comentário: Forma de pagamento
        /// </summary>
        private string formapgto;
        [XmlElement(ElementName = "FORMAPGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Formapgto
        {
            get { return  formapgto; }
            set {  formapgto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORNECEDOR
        /// Comentário: Parceiro do lançamento.
        /// </summary>
        private string fornecedor;
        [XmlElement(ElementName = "FORNECEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Fornecedor
        {
            get { return  fornecedor; }
            set {  fornecedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_CODPRACA
        /// Comentário: Dados de Frota: praça que foi feito o abastecimento, conserto, troca de pneu, travessia de balsa, etc. (rotinas 631/749). 
        /// </summary>
        private decimal frota_codpraca;
        [XmlElement(ElementName = "FROTA_CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Frota_Codpraca
        {
            get { return  frota_codpraca; }
            set {  frota_codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_CODVEICULO
        /// Comentário: Dados de Frota: código do veículo. Necessário para infomar despesas que não são feitas em viagem, como pintura de baú (rotina 749).
        /// </summary>
        private decimal frota_codveiculo;
        [XmlElement(ElementName = "FROTA_CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Frota_Codveiculo
        {
            get { return  frota_codveiculo; }
            set {  frota_codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_COMISSAO
        /// Comentário: Dados de Frota: valor da comissão paga ao motorista (rotina 1206). 
        /// </summary>
        private decimal frota_comissao;
        [XmlElement(ElementName = "FROTA_COMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Frota_Comissao
        {
            get { return  frota_comissao; }
            set {  frota_comissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_DTABASTECE
        /// Comentário: Dados de Frota: data e horário do abastecimento. 
        /// </summary>
        private DateTime? frota_dtabastece;
        [XmlElement(ElementName = "FROTA_DTABASTECE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Frota_Dtabastece
        {
            get { return  frota_dtabastece; }
            set {  frota_dtabastece = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_KMABASTECE
        /// Comentário: Dados de Frota: quilometragem do abastecimento. 
        /// </summary>
        private decimal frota_kmabastece;
        [XmlElement(ElementName = "FROTA_KMABASTECE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Frota_Kmabastece
        {
            get { return  frota_kmabastece; }
            set {  frota_kmabastece = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_NUMCAR
        /// Comentário: Dados de Frota: carregamento (viagem) em que as despesas foram feitas (rotina 749).
        /// </summary>
        private decimal frota_numcar;
        [XmlElement(ElementName = "FROTA_NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Frota_Numcar
        {
            get { return  frota_numcar; }
            set {  frota_numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_PESO
        /// Comentário: Dados de Frota: quantidade de peso do frete.
        /// </summary>
        private decimal frota_peso;
        [XmlElement(ElementName = "FROTA_PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Frota_Peso
        {
            get { return  frota_peso; }
            set {  frota_peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FROTA_QTLITROS
        /// Comentário: Dados de Frota: quantidade de litros que foi abastecido (rotinas 631/749). 
        /// </summary>
        private decimal frota_qtlitros;
        [XmlElement(ElementName = "FROTA_QTLITROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Frota_Qtlitros
        {
            get { return  frota_qtlitros; }
            set {  frota_qtlitros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCBLOQ
        /// Comentário: Funcionário que realizou o bloqueio.
        /// </summary>
        private decimal funcbloq;
        [XmlElement(ElementName = "FUNCBLOQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Funcbloq
        {
            get { return  funcbloq; }
            set {  funcbloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,200)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO2
        /// Comentário: 
        /// </summary>
        private string historico2;
        [XmlElement(ElementName = "HISTORICO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Historico2
        {
            get { return  historico2; }
            set {  historico2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDCONTROLEEMBARQUE
        /// Comentário: Identificação do controle de embarque.
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
        /// Propriedade referente ao campo: INDICE
        /// Comentário: Indice de risco do título.
        /// </summary>
        private string indice;
        [XmlElement(ElementName = "INDICE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Indice
        {
            get { return  indice; }
            set {  indice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALIZACAO
        /// Comentário: 
        /// </summary>
        private string localizacao;
        [XmlElement(ElementName = "LOCALIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Localizacao
        {
            get { return  localizacao; }
            set {  localizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDA
        /// Comentário: 
        /// </summary>
        private string moeda;
        [XmlElement(ElementName = "MOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Moeda
        {
            get { return  moeda; }
            set {  moeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDAESTRANGEIRA
        /// Comentário: 
        /// </summary>
        private decimal moedaestrangeira;
        [XmlElement(ElementName = "MOEDAESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Moedaestrangeira
        {
            get { return  moedaestrangeira; }
            set {  moedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOEDAPARIDADE
        /// Comentário: Moeda da Paridade.
        /// </summary>
        private decimal moedaparidade;
        [XmlElement(ElementName = "MOEDAPARIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Moedaparidade
        {
            get { return  moedaparidade; }
            set {  moedaparidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NFSERVICO
        /// Comentário: Campo para indicar se o título gerado é referente a uma nota fiscal de serviço.
        /// </summary>
        private string nfservico;
        [XmlElement(ElementName = "NFSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Nfservico
        {
            get { return  nfservico; }
            set {  nfservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEFUNC
        /// Comentário: 
        /// </summary>
        private string nomefunc;
        [XmlElement(ElementName = "NOMEFUNC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomefunc
        {
            get { return  nomefunc; }
            set {  nomefunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGDESTDOC
        /// Comentário: 
        /// </summary>
        private decimal numagdestdoc;
        [XmlElement(ElementName = "NUMAGDESTDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numagdestdoc
        {
            get { return  numagdestdoc; }
            set {  numagdestdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGDESTDOC2
        /// Comentário: 
        /// </summary>
        private decimal numagdestdoc2;
        [XmlElement(ElementName = "NUMAGDESTDOC2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numagdestdoc2
        {
            get { return  numagdestdoc2; }
            set {  numagdestdoc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Comentário: 
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBCODESTDOC
        /// Comentário: 
        /// </summary>
        private decimal numbcodestdoc;
        [XmlElement(ElementName = "NUMBCODESTDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbcodestdoc
        {
            get { return  numbcodestdoc; }
            set {  numbcodestdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBORDERO
        /// Comentário: 
        /// </summary>
        private decimal numbordero;
        [XmlElement(ElementName = "NUMBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numbordero
        {
            get { return  numbordero; }
            set {  numbordero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCDESTDOC
        /// Comentário: 
        /// </summary>
        private decimal numccdestdoc;
        [XmlElement(ElementName = "NUMCCDESTDOC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numccdestdoc
        {
            get { return  numccdestdoc; }
            set {  numccdestdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Comentário: 
        /// </summary>
        private string numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE2
        /// Comentário: 
        /// </summary>
        private decimal numcheque2;
        [XmlElement(ElementName = "NUMCHEQUE2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcheque2
        {
            get { return  numcheque2; }
            set {  numcheque2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCODBARRA
        /// Comentário: 
        /// </summary>
        private string numcodbarra;
        [XmlElement(ElementName = "NUMCODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Numcodbarra
        {
            get { return  numcodbarra; }
            set {  numcodbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATOCAMBIO
        /// Comentário: Número do contrato de câmbio.
        /// </summary>
        private string numcontratocambio;
        [XmlElement(ElementName = "NUMCONTRATOCAMBIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcontratocambio
        {
            get { return  numcontratocambio; }
            set {  numcontratocambio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIIMPORTACAO
        /// Comentário: Campo utilizado para armazenar o número do documento de importação 
        /// </summary>
        private string numdiimportacao;
        [XmlElement(ElementName = "NUMDIIMPORTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Numdiimportacao
        {
            get { return  numdiimportacao; }
            set {  numdiimportacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDVDESTDOC
        /// Comentário: 
        /// </summary>
        private string numdvdestdoc;
        [XmlElement(ElementName = "NUMDVDESTDOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numdvdestdoc
        {
            get { return  numdvdestdoc; }
            set {  numdvdestdoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNEGOCIACAO
        /// Comentário: Numero da negociação de importação.
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
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTADEV
        /// Comentário: 
        /// </summary>
        private decimal numnotadev;
        [XmlElement(ElementName = "NUMNOTADEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnotadev
        {
            get { return  numnotadev; }
            set {  numnotadev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPARCELAMENTO
        /// Comentário: Número chave do parcelamento
        /// </summary>
        private decimal numparcelamento;
        [XmlElement(ElementName = "NUMPARCELAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numparcelamento
        {
            get { return  numparcelamento; }
            set {  numparcelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQBORDERO
        /// Comentário: 
        /// </summary>
        private decimal numseqbordero;
        [XmlElement(ElementName = "NUMSEQBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numseqbordero
        {
            get { return  numseqbordero; }
            set {  numseqbordero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQCONTRATOEMPRESTIMO
        /// Comentário: Número sequencial do contrato.
        /// </summary>
        private decimal numseqcontratoemprestimo;
        [XmlElement(ElementName = "NUMSEQCONTRATOEMPRESTIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseqcontratoemprestimo
        {
            get { return  numseqcontratoemprestimo; }
            set {  numseqcontratoemprestimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQPARCELAMENTO
        /// Comentário: Número sequencial de parcelamento utilizado para ordenação
        /// </summary>
        private decimal numseqparcelamento;
        [XmlElement(ElementName = "NUMSEQPARCELAMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseqparcelamento
        {
            get { return  numseqparcelamento; }
            set {  numseqparcelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTAB
        /// Comentário: 
        /// </summary>
        private decimal numtab;
        [XmlElement(ElementName = "NUMTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtab
        {
            get { return  numtab; }
            set {  numtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Comentário: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSADIANTFOR
        /// Comentário: 
        /// </summary>
        private decimal numtransadiantfor;
        [XmlElement(ElementName = "NUMTRANSADIANTFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransadiantfor
        {
            get { return  numtransadiantfor; }
            set {  numtransadiantfor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTNF
        /// Comentário: Número de transação da NF de entrada
        /// </summary>
        private decimal numtransentnf;
        [XmlElement(ElementName = "NUMTRANSENTNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentnf
        {
            get { return  numtransentnf; }
            set {  numtransentnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMVIA
        /// Comentário: 
        /// </summary>
        private decimal numvia;
        [XmlElement(ElementName = "NUMVIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numvia
        {
            get { return  numvia; }
            set {  numvia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASFICHACP
        /// Comentário: 
        /// </summary>
        private decimal numviasfichacp;
        [XmlElement(ElementName = "NUMVIASFICHACP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numviasfichacp
        {
            get { return  numviasfichacp; }
            set {  numviasfichacp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSBLOQ
        /// Comentário: Observação de bloqueio.
        /// </summary>
        private string obsbloq;
        [XmlElement(ElementName = "OBSBLOQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Obsbloq
        {
            get { return  obsbloq; }
            set {  obsbloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGTONOMEDOCLIENTE
        /// Comentário: Indica se o responsável pela pagamento da GNRE é o cliente.
        /// </summary>
        private string pagtonomedocliente;
        [XmlElement(ElementName = "PAGTONOMEDOCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagtonomedocliente
        {
            get { return  pagtonomedocliente; }
            set {  pagtonomedocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARCELA
        /// Comentário: Número de prestação
        /// </summary>
        private string parcela;
        [XmlElement(ElementName = "PARCELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Parcela
        {
            get { return  parcela; }
            set {  parcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFINREAL
        /// Comentário: Indica o percentual de desconto financeiro.
        /// </summary>
        private decimal percdescfinreal;
        [XmlElement(ElementName = "PERCDESCFINREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Percdescfinreal
        {
            get { return  percdescfinreal; }
            set {  percdescfinreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCRECEITABRUTA
        /// Comentário: Percentual da receita bruta utilizado no darf simples
        /// </summary>
        private decimal percreceitabruta;
        [XmlElement(ElementName = "PERCRECEITABRUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percreceitabruta
        {
            get { return  percreceitabruta; }
            set {  percreceitabruta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORTADORCHEQUE
        /// Comentário: 
        /// </summary>
        private string portadorcheque;
        [XmlElement(ElementName = "PORTADORCHEQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Portadorcheque
        {
            get { return  portadorcheque; }
            set {  portadorcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: Ligação com PCPREST.PREST.
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRORROG
        /// Comentário: 
        /// </summary>
        private decimal prorrog;
        [XmlElement(ElementName = "PRORROG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prorrog
        {
            get { return  prorrog; }
            set {  prorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM
        /// Comentário: 
        /// </summary>
        private decimal recnum;
        [XmlElement(ElementName = "RECNUM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Recnum
        {
            get { return  recnum; }
            set {  recnum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUMBAIXA
        /// Comentário: RecNum do lançamento principal da baixa.
        /// </summary>
        private decimal recnumbaixa;
        [XmlElement(ElementName = "RECNUMBAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnumbaixa
        {
            get { return  recnumbaixa; }
            set {  recnumbaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUMPRINC
        /// Comentário: Armazena em cada lançamento de rateio, o número do primeiro lançamento gerado. Agrupara lançamentos gerados que foram rateados em diversas contas diferentes.
        /// </summary>
        private decimal recnumprinc;
        [XmlElement(ElementName = "RECNUMPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnumprinc
        {
            get { return  recnumprinc; }
            set {  recnumprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAUTORIZACAO
        /// Comentário: Tipo de autorização do pagamento do borderô.
        /// </summary>
        private string tipoautorizacao;
        [XmlElement(ElementName = "TIPOAUTORIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoautorizacao
        {
            get { return  tipoautorizacao; }
            set {  tipoautorizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOLANC
        /// Comentário: 
        /// </summary>
        private string tipolanc;
        [XmlElement(ElementName = "TIPOLANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipolanc
        {
            get { return  tipolanc; }
            set {  tipolanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPAGTO
        /// Comentário: 
        /// </summary>
        private string tipopagto;
        [XmlElement(ElementName = "TIPOPAGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipopagto
        {
            get { return  tipopagto; }
            set {  tipopagto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPARCEIRO
        /// Comentário: 
        /// </summary>
        private string tipoparceiro;
        [XmlElement(ElementName = "TIPOPARCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoparceiro
        {
            get { return  tipoparceiro; }
            set {  tipoparceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXPERM
        /// Comentário: 
        /// </summary>
        private decimal txperm;
        [XmlElement(ElementName = "TXPERM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Txperm
        {
            get { return  txperm; }
            set {  txperm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDEV
        /// Comentário: 
        /// </summary>
        private decimal valordev;
        [XmlElement(ElementName = "VALORDEV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valordev
        {
            get { return  valordev; }
            set {  valordev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORMOEDAESTRANGEIRA
        /// Comentário: Campo para armazenar o valor do lançamento em moeda estrangeira.
        /// </summary>
        private decimal valormoedaestrangeira;
        [XmlElement(ElementName = "VALORMOEDAESTRANGEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valormoedaestrangeira
        {
            get { return  valormoedaestrangeira; }
            set {  valormoedaestrangeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOFINS
        /// Comentário: Valor do imposto COFINS.
        /// </summary>
        private decimal vlcofins;
        [XmlElement(ElementName = "VLCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcofins
        {
            get { return  vlcofins; }
            set {  vlcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCSRF
        /// Comentário: Grava o valor do CSRF da NF de serviço.
        /// </summary>
        private decimal vlcsrf;
        [XmlElement(ElementName = "VLCSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlcsrf
        {
            get { return  vlcsrf; }
            set {  vlcsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLINSS
        /// Comentário: Grava o valor do INSS da NF de serviço.
        /// </summary>
        private decimal vlinss;
        [XmlElement(ElementName = "VLINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlinss
        {
            get { return  vlinss; }
            set {  vlinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIRRF
        /// Comentário: 
        /// </summary>
        private decimal vlirrf;
        [XmlElement(ElementName = "VLIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlirrf
        {
            get { return  vlirrf; }
            set {  vlirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISS
        /// Comentário: Grava o valor do ISS da NF de serviço.
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
        /// Propriedade referente ao campo: VLOUTRAS
        /// Comentário: Outros valores.
        /// </summary>
        private decimal vloutras;
        [XmlElement(ElementName = "VLOUTRAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vloutras
        {
            get { return  vloutras; }
            set {  vloutras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPIS
        /// Comentário: Valor do imposto PIS.
        /// </summary>
        private decimal vlpis;
        [XmlElement(ElementName = "VLPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpis
        {
            get { return  vlpis; }
            set {  vlpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRPARIDADEMOEDA
        /// Comentário: Valor da Paridade da Moeda.
        /// </summary>
        private decimal vlrparidademoeda;
        [XmlElement(ElementName = "VLRPARIDADEMOEDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrparidademoeda
        {
            get { return  vlrparidademoeda; }
            set {  vlrparidademoeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRUTILIZADOADIANTFORNEC
        /// Comentário: 
        /// </summary>
        private decimal vlrutilizadoadiantfornec;
        [XmlElement(ElementName = "VLRUTILIZADOADIANTFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlrutilizadoadiantfornec
        {
            get { return  vlrutilizadoadiantfornec; }
            set {  vlrutilizadoadiantfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSESTSENAT
        /// Comentário: 
        /// </summary>
        private decimal vlsestsenat;
        [XmlElement(ElementName = "VLSESTSENAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlsestsenat
        {
            get { return  vlsestsenat; }
            set {  vlsestsenat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVARIACAOCAMBIAL
        /// Comentário: Valor da variação cambial.
        /// </summary>
        private decimal vlvariacaocambial;
        [XmlElement(ElementName = "VLVARIACAOCAMBIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvariacaocambial
        {
            get { return  vlvariacaocambial; }
            set {  vlvariacaocambial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VPAGO
        /// Comentário: 
        /// </summary>
        private decimal vpago;
        [XmlElement(ElementName = "VPAGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vpago
        {
            get { return  vpago; }
            set {  vpago = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VPAGOBORDERO
        /// Comentário: 
        /// </summary>
        private decimal vpagobordero;
        [XmlElement(ElementName = "VPAGOBORDERO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vpagobordero
        {
            get { return  vpagobordero; }
            set {  vpagobordero = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VRECEITABRUTA
        /// Comentário: Valor da Receita bruta utilizado no darf simples
        /// </summary>
        private decimal vreceitabruta;
        [XmlElement(ElementName = "VRECEITABRUTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vreceitabruta
        {
            get { return  vreceitabruta; }
            set {  vreceitabruta = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLanc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLANC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLanc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLanc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLanc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLanc>(where);
        }

        #endregion
    }
}
