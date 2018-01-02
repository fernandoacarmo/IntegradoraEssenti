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
    /// Classe referente a tabela PCPlpag
    /// </summary>
    [XmlType("PCPLPAG")]
    public class PCPlpag : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPE
        /// Comentário: 
        /// </summary>
        private decimal codequipe;
        [XmlElement(ElementName = "CODEQUIPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codequipe
        {
            get { return  codequipe; }
            set {  codequipe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica qual filial o plano de pagamento poderá ser usado. É opcional, logo, se estiver vazio, pode ser utilizado em todas as filiais. 
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
        /// Propriedade referente ao campo: CODFUNC
        /// Comentário: Grava o código do funcionário
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
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGKRAFT
        /// Comentário: 
        /// </summary>
        private string codplpagkraft;
        [XmlElement(ElementName = "CODPLPAGKRAFT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codplpagkraft
        {
            get { return  codplpagkraft; }
            set {  codplpagkraft = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRESTRICAO
        /// Comentário: 
        /// </summary>
        private decimal codrestricao;
        [XmlElement(ElementName = "CODRESTRICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codrestricao
        {
            get { return  codrestricao; }
            set {  codrestricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCENTLIMCREDCLI
        /// Comentário: Não Descontar a Entrada no Limite de Credito do Cliente
        /// </summary>
        private string descentlimcredcli;
        [XmlElement(ElementName = "DESCENTLIMCREDCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Descentlimcredcli
        {
            get { return  descentlimcredcli; }
            set {  descentlimcredcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Indica a descrição. 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO2
        /// Comentário: Indica a descrição.
        /// </summary>
        private string descricao2;
        [XmlElement(ElementName = "DESCRICAO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,45)]
        public string Descricao2
        {
            get { return  descricao2; }
            set {  descricao2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAFIXO
        /// Comentário: Dia fixo para parcelamento
        /// </summary>
        private decimal diafixo;
        [XmlElement(ElementName = "DIAFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diafixo
        {
            get { return  diafixo; }
            set {  diafixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASCARENCIA
        /// Comentário: Dias de carência
        /// </summary>
        private decimal diascarencia;
        [XmlElement(ElementName = "DIASCARENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Diascarencia
        {
            get { return  diascarencia; }
            set {  diascarencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASMAXPARCELA
        /// Comentário: Dias máximos entre as parcelas variáveis
        /// </summary>
        private decimal diasmaxparcela;
        [XmlElement(ElementName = "DIASMAXPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Diasmaxparcela
        {
            get { return  diasmaxparcela; }
            set {  diasmaxparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASMINPARCELA
        /// Comentário: Dias minimos entre as parcelas variáveis
        /// </summary>
        private decimal diasminparcela;
        [XmlElement(ElementName = "DIASMINPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Diasminparcela
        {
            get { return  diasminparcela; }
            set {  diasminparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC1
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc1;
        [XmlElement(ElementName = "DTVENC1", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc1
        {
            get { return  dtvenc1; }
            set {  dtvenc1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC2
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc2;
        [XmlElement(ElementName = "DTVENC2", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc2
        {
            get { return  dtvenc2; }
            set {  dtvenc2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC3
        /// Comentário: 
        /// </summary>
        private DateTime? dtvenc3;
        [XmlElement(ElementName = "DTVENC3", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc3
        {
            get { return  dtvenc3; }
            set {  dtvenc3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENTRADA
        /// Comentário: 
        /// </summary>
        private string entrada;
        [XmlElement(ElementName = "ENTRADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Entrada
        {
            get { return  entrada; }
            set {  entrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIAPLANOFV
        /// Comentário: 
        /// </summary>
        private string enviaplanofv;
        [XmlElement(ElementName = "ENVIAPLANOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviaplanofv
        {
            get { return  enviaplanofv; }
            set {  enviaplanofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMAPARCELAMENTO
        /// Comentário: 
        /// </summary>
        private string formaparcelamento;
        [XmlElement(ElementName = "FORMAPARCELAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Formaparcelamento
        {
            get { return  formaparcelamento; }
            set {  formaparcelamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LETRAPLPAG
        /// Comentário: 
        /// </summary>
        private string letraplpag;
        [XmlElement(ElementName = "LETRAPLPAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Letraplpag
        {
            get { return  letraplpag; }
            set {  letraplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMMIN
        /// Comentário: 
        /// </summary>
        private decimal margemmin;
        [XmlElement(ElementName = "MARGEMMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Margemmin
        {
            get { return  margemmin; }
            set {  margemmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NAODESCENTLIMCREDCLI
        /// Comentário: Não Descontar a Entrada no Limite de Credito do Cliente
        /// </summary>
        private string naodescentlimcredcli;
        [XmlElement(ElementName = "NAODESCENTLIMCREDCLI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Naodescentlimcredcli
        {
            get { return  naodescentlimcredcli; }
            set {  naodescentlimcredcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIAS
        /// Comentário: 
        /// </summary>
        private decimal numdias;
        [XmlElement(ElementName = "NUMDIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdias
        {
            get { return  numdias; }
            set {  numdias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASATRASOFIM
        /// Comentário: Intervalo final de numero de dias de atraso médio para alteração do plano de pagamento do cliente de forma automática.
        /// </summary>
        private decimal numdiasatrasofim;
        [XmlElement(ElementName = "NUMDIASATRASOFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasatrasofim
        {
            get { return  numdiasatrasofim; }
            set {  numdiasatrasofim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASATRASOINI
        /// Comentário: Intervalo Inicial de numero de dias de atraso médio para alteração do plano de pagamento do cliente de forma automática.
        /// </summary>
        private decimal numdiasatrasoini;
        [XmlElement(ElementName = "NUMDIASATRASOINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasatrasoini
        {
            get { return  numdiasatrasoini; }
            set {  numdiasatrasoini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASCARENCIA
        /// Comentário: 
        /// </summary>
        private decimal numdiascarencia;
        [XmlElement(ElementName = "NUMDIASCARENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiascarencia
        {
            get { return  numdiascarencia; }
            set {  numdiascarencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASCARTAO
        /// Comentário: 
        /// </summary>
        private decimal numdiascartao;
        [XmlElement(ElementName = "NUMDIASCARTAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiascartao
        {
            get { return  numdiascartao; }
            set {  numdiascartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROPARCELASDIAFIXO
        /// Comentário: Qtde de parcelas para o plano dia fixo
        /// </summary>
        private decimal numeroparcelasdiafixo;
        [XmlElement(ElementName = "NUMEROPARCELASDIAFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numeroparcelasdiafixo
        {
            get { return  numeroparcelasdiafixo; }
            set {  numeroparcelasdiafixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMITENSMINIMO
        /// Comentário: 
        /// </summary>
        private decimal numitensminimo;
        [XmlElement(ElementName = "NUMITENSMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numitensminimo
        {
            get { return  numitensminimo; }
            set {  numitensminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPARCELAS
        /// Comentário: 
        /// </summary>
        private decimal numparcelas;
        [XmlElement(ElementName = "NUMPARCELAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numparcelas
        {
            get { return  numparcelas; }
            set {  numparcelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPR
        /// Comentário: 
        /// </summary>
        private decimal numpr;
        [XmlElement(ElementName = "NUMPR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numpr
        {
            get { return  numpr; }
            set {  numpr = value; }
        }
        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSPLPAG
        /// Comentário: 
        /// </summary>
        private string obsplpag;
        [XmlElement(ElementName = "OBSPLPAG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obsplpag
        {
            get { return  obsplpag; }
            set {  obsplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OFERTA
        /// Comentário: 
        /// </summary>
        private string oferta;
        [XmlElement(ElementName = "OFERTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Oferta
        {
            get { return  oferta; }
            set {  oferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERTXFIM
        /// Comentário: 
        /// </summary>
        private decimal pertxfim;
        [XmlElement(ElementName = "PERTXFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pertxfim
        {
            get { return  pertxfim; }
            set {  pertxfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERTXFIMPALM
        /// Comentário: 
        /// </summary>
        private decimal pertxfimpalm;
        [XmlElement(ElementName = "PERTXFIMPALM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pertxfimpalm
        {
            get { return  pertxfimpalm; }
            set {  pertxfimpalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOPONDERADO
        /// Comentário: 
        /// </summary>
        private string prazoponderado;
        [XmlElement(ElementName = "PRAZOPONDERADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prazoponderado
        {
            get { return  prazoponderado; }
            set {  prazoponderado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO1
        /// Comentário: 
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
        /// Propriedade referente ao campo: PRAZO10
        /// Comentário: 
        /// </summary>
        private decimal prazo10;
        [XmlElement(ElementName = "PRAZO10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo10
        {
            get { return  prazo10; }
            set {  prazo10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO11
        /// Comentário: 
        /// </summary>
        private decimal prazo11;
        [XmlElement(ElementName = "PRAZO11", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo11
        {
            get { return  prazo11; }
            set {  prazo11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO12
        /// Comentário: 
        /// </summary>
        private decimal prazo12;
        [XmlElement(ElementName = "PRAZO12", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo12
        {
            get { return  prazo12; }
            set {  prazo12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO2
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: PRAZO7
        /// Comentário: 
        /// </summary>
        private decimal prazo7;
        [XmlElement(ElementName = "PRAZO7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo7
        {
            get { return  prazo7; }
            set {  prazo7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO8
        /// Comentário: 
        /// </summary>
        private decimal prazo8;
        [XmlElement(ElementName = "PRAZO8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo8
        {
            get { return  prazo8; }
            set {  prazo8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZO9
        /// Comentário: 
        /// </summary>
        private decimal prazo9;
        [XmlElement(ElementName = "PRAZO9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazo9
        {
            get { return  prazo9; }
            set {  prazo9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Status do plano de pagamento.
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENTRADA
        /// Comentário: 
        /// </summary>
        private decimal tipoentrada;
        [XmlElement(ElementName = "TIPOENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipoentrada
        {
            get { return  tipoentrada; }
            set {  tipoentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRAZO
        /// Comentário: 
        /// </summary>
        private string tipoprazo;
        [XmlElement(ElementName = "TIPOPRAZO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprazo
        {
            get { return  tipoprazo; }
            set {  tipoprazo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORESTRICAO
        /// Comentário: 
        /// </summary>
        private string tiporestricao;
        [XmlElement(ElementName = "TIPORESTRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tiporestricao
        {
            get { return  tiporestricao; }
            set {  tiporestricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Comentário: 
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
        /// Propriedade referente ao campo: TXFATOR
        /// Comentário: Indica o fator da taxa.
        /// </summary>
        private decimal txfator;
        [XmlElement(ElementName = "TXFATOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Txfator
        {
            get { return  txfator; }
            set {  txfator = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCFINANCEIRO
        /// Comentário: Indica se utiliza desconto financeiro.
        /// </summary>
        private string usadescfinanceiro;
        [XmlElement(ElementName = "USADESCFINANCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadescfinanceiro
        {
            get { return  usadescfinanceiro; }
            set {  usadescfinanceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADESCLINHAPROD
        /// Comentário: 
        /// </summary>
        private string usadesclinhaprod;
        [XmlElement(ElementName = "USADESCLINHAPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadesclinhaprod
        {
            get { return  usadesclinhaprod; }
            set {  usadesclinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAMULTIFILIAL
        /// Comentário: Usa multi filial.
        /// </summary>
        private string usamultifilial;
        [XmlElement(ElementName = "USAMULTIFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usamultifilial
        {
            get { return  usamultifilial; }
            set {  usamultifilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPLPAGAUTOSERVICO
        /// Comentário: 
        /// </summary>
        private string usaplpagautoservico;
        [XmlElement(ElementName = "USAPLPAGAUTOSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaplpagautoservico
        {
            get { return  usaplpagautoservico; }
            set {  usaplpagautoservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAPRAZOADICIONALPCCLIENT
        /// Comentário: Indica se usa prazo adicional do cadastro do cliente. 
        /// </summary>
        private string usaprazoadicionalpcclient;
        [XmlElement(ElementName = "USAPRAZOADICIONALPCCLIENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaprazoadicionalpcclient
        {
            get { return  usaprazoadicionalpcclient; }
            set {  usaprazoadicionalpcclient = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDABK
        /// Comentário: 
        /// </summary>
        private string vendabk;
        [XmlElement(ElementName = "VENDABK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendabk
        {
            get { return  vendabk; }
            set {  vendabk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINPARCELA
        /// Comentário: Valor Minimo das parcelas do pedido
        /// </summary>
        private decimal vlminparcela;
        [XmlElement(ElementName = "VLMINPARCELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlminparcela
        {
            get { return  vlminparcela; }
            set {  vlminparcela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINPEDIDO
        /// Comentário: 
        /// </summary>
        private decimal vlminpedido;
        [XmlElement(ElementName = "VLMINPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlminpedido
        {
            get { return  vlminpedido; }
            set {  vlminpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTXCARNE
        /// Comentário: Indica o valor taxa carne.
        /// </summary>
        private decimal vltxcarne;
        [XmlElement(ElementName = "VLTXCARNE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vltxcarne
        {
            get { return  vltxcarne; }
            set {  vltxcarne = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPlpag()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPLPAG";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPlpag> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPlpag>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPlpag> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPlpag>(where);
        }

        #endregion
    }
}
