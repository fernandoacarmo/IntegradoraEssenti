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
    /// Classe referente a tabela PCPreco
    /// </summary>
    [XmlType("PCPRECO")]
    public class PCPreco : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
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
        /// Propriedade referente ao campo: CODOFERTA
        /// Comentário: Número da oferta
        /// </summary>
        private decimal codoferta;
        [XmlElement(ElementName = "CODOFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codoferta
        {
            get { return  codoferta; }
            set {  codoferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOFIN
        /// Comentário: 
        /// </summary>
        private decimal custofin;
        [XmlElement(ElementName = "CUSTOFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custofin
        {
            get { return  custofin; }
            set {  custofin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPRECIFIC
        /// Comentário: Custo utilizado na precificação.
        /// </summary>
        private decimal custoprecific;
        [XmlElement(ElementName = "CUSTOPRECIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoprecific
        {
            get { return  custoprecific; }
            set {  custoprecific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPRECIFICANT
        /// Comentário: Custo utilizado na precificação anterior.
        /// </summary>
        private decimal custoprecificant;
        [XmlElement(ElementName = "CUSTOPRECIFICANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoprecificant
        {
            get { return  custoprecificant; }
            set {  custoprecificant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPRECIFICTAB
        /// Comentário: Custo utilizado na precificação tab.
        /// </summary>
        private decimal custoprecifictab;
        [XmlElement(ElementName = "CUSTOPRECIFICTAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoprecifictab
        {
            get { return  custoprecifictab; }
            set {  custoprecifictab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOPRECIFICTABANT
        /// Comentário: Custo utilizado na precificação tab anterior.
        /// </summary>
        private decimal custoprecifictabant;
        [XmlElement(ElementName = "CUSTOPRECIFICTABANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoprecifictabant
        {
            get { return  custoprecifictabant; }
            set {  custoprecifictabant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CUSTOREAL
        /// Comentário: 
        /// </summary>
        private decimal custoreal;
        [XmlElement(ElementName = "CUSTOREAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Custoreal
        {
            get { return  custoreal; }
            set {  custoreal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAALTER
        /// Comentário: 
        /// </summary>
        private DateTime? dataalter;
        [XmlElement(ElementName = "DATAALTER", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dataalter
        {
            get { return  dataalter; }
            set {  dataalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data de exclusão da oferta
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
        /// Propriedade referente ao campo: DTOFERTAATACFIM
        /// Comentário: Indica a data de oferta atacado final. 
        /// </summary>
        private DateTime? dtofertaatacfim;
        [XmlElement(ElementName = "DTOFERTAATACFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertaatacfim
        {
            get { return  dtofertaatacfim; }
            set {  dtofertaatacfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAATACINI
        /// Comentário: Indica a data de oferta atacado inicial. 
        /// </summary>
        private DateTime? dtofertaatacini;
        [XmlElement(ElementName = "DTOFERTAATACINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertaatacini
        {
            get { return  dtofertaatacini; }
            set {  dtofertaatacini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAFIM
        /// Comentário: Indica a data de oferta final. 
        /// </summary>
        private DateTime? dtofertafim;
        [XmlElement(ElementName = "DTOFERTAFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertafim
        {
            get { return  dtofertafim; }
            set {  dtofertafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAINI
        /// Comentário: Indica a data de oferta inicial. 
        /// </summary>
        private DateTime? dtofertaini;
        [XmlElement(ElementName = "DTOFERTAINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertaini
        {
            get { return  dtofertaini; }
            set {  dtofertaini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAWEBFIM
        /// Comentário: Data fim oferta web
        /// </summary>
        private DateTime? dtofertawebfim;
        [XmlElement(ElementName = "DTOFERTAWEBFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertawebfim
        {
            get { return  dtofertawebfim; }
            set {  dtofertawebfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTOFERTAWEBINI
        /// Comentário: Data inicio oferta web
        /// </summary>
        private DateTime? dtofertawebini;
        [XmlElement(ElementName = "DTOFERTAWEBINI", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtofertawebini
        {
            get { return  dtofertawebini; }
            set {  dtofertawebini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAQUINA
        /// Comentário: Nome da máquina
        /// </summary>
        private string maquina;
        [XmlElement(ElementName = "MAQUINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Maquina
        {
            get { return  maquina; }
            set {  maquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMIDEALANT
        /// Comentário: Valor da Margem Ideal Anterior. 
        /// </summary>
        private decimal margemidealant;
        [XmlElement(ElementName = "MARGEMIDEALANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Margemidealant
        {
            get { return  margemidealant; }
            set {  margemidealant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMIDEALATACANT
        /// Comentário: Gravar margem Ideal Anterior. 
        /// </summary>
        private decimal margemidealatacant;
        [XmlElement(ElementName = "MARGEMIDEALATACANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Margemidealatacant
        {
            get { return  margemidealatacant; }
            set {  margemidealatacant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMIDEALATUAL
        /// Comentário: Valor da Margem Ideal Atual. 
        /// </summary>
        private decimal margemidealatual;
        [XmlElement(ElementName = "MARGEMIDEALATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Margemidealatual
        {
            get { return  margemidealatual; }
            set {  margemidealatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMIDEALATUALATAC
        /// Comentário: Gravar margem Ideal. 
        /// </summary>
        private decimal margemidealatualatac;
        [XmlElement(ElementName = "MARGEMIDEALATUALATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Margemidealatualatac
        {
            get { return  margemidealatualatac; }
            set {  margemidealatualatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: 
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
        /// Propriedade referente ao campo: MOTIVOOFERTA
        /// Comentário: Motivo da oferta
        /// </summary>
        private string motivooferta;
        [XmlElement(ElementName = "MOTIVOOFERTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Motivooferta
        {
            get { return  motivooferta; }
            set {  motivooferta = value; }
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
        /// Propriedade referente ao campo: OBS
        /// Comentário: Motivo da Precificação abaixo da Margem Atual
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMGARANTIDA
        /// Comentário: % COMISSAO GARANTIDA
        /// </summary>
        private decimal perccomgarantida;
        [XmlElement(ElementName = "PERCCOMGARANTIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perccomgarantida
        {
            get { return  perccomgarantida; }
            set {  perccomgarantida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMGARANTIDAANT
        /// Comentário: % COMISSAO GARANTIDA ANTERIOR
        /// </summary>
        private decimal perccomgarantidaant;
        [XmlElement(ElementName = "PERCCOMGARANTIDAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perccomgarantidaant
        {
            get { return  perccomgarantidaant; }
            set {  perccomgarantidaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCAUTOR
        /// Comentário: 
        /// </summary>
        private decimal perdescautor;
        [XmlElement(ElementName = "PERDESCAUTOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdescautor
        {
            get { return  perdescautor; }
            set {  perdescautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCAUTORANT
        /// Comentário: 
        /// </summary>
        private decimal perdescautorant;
        [XmlElement(ElementName = "PERDESCAUTORANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perdescautorant
        {
            get { return  perdescautorant; }
            set {  perdescautorant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFOB
        /// Comentário: Percentual de desconto do frete fob.
        /// </summary>
        private decimal perdescfob;
        [XmlElement(ElementName = "PERDESCFOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescfob
        {
            get { return  perdescfob; }
            set {  perdescfob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCFOBANT
        /// Comentário: Percentual de desconto do frete fob anterior.
        /// </summary>
        private decimal perdescfobant;
        [XmlElement(ElementName = "PERDESCFOBANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescfobant
        {
            get { return  perdescfobant; }
            set {  perdescfobant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAX
        /// Comentário: 
        /// </summary>
        private decimal perdescmax;
        [XmlElement(ElementName = "PERDESCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmax
        {
            get { return  perdescmax; }
            set {  perdescmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXANT
        /// Comentário: 
        /// </summary>
        private decimal perdescmaxant;
        [XmlElement(ElementName = "PERDESCMAXANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxant
        {
            get { return  perdescmaxant; }
            set {  perdescmaxant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXAVISTA
        /// Comentário: % DESCONTO MÁXIMO VENDA AVISTA
        /// </summary>
        private decimal perdescmaxavista;
        [XmlElement(ElementName = "PERDESCMAXAVISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxavista
        {
            get { return  perdescmaxavista; }
            set {  perdescmaxavista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXAVISTAANT
        /// Comentário: % DESCONTO MÁXIMO VENDA AVISTA ANTERIOR
        /// </summary>
        private decimal perdescmaxavistaant;
        [XmlElement(ElementName = "PERDESCMAXAVISTAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxavistaant
        {
            get { return  perdescmaxavistaant; }
            set {  perdescmaxavistaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXIDEAL
        /// Comentário: % DESCONTO MAXIMO IDEAL VENDA
        /// </summary>
        private decimal perdescmaxideal;
        [XmlElement(ElementName = "PERDESCMAXIDEAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxideal
        {
            get { return  perdescmaxideal; }
            set {  perdescmaxideal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXIDEALANT
        /// Comentário: % DESCONTO MAXIMO IDEAL VENDA ANTERIOR
        /// </summary>
        private decimal perdescmaxidealant;
        [XmlElement(ElementName = "PERDESCMAXIDEALANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxidealant
        {
            get { return  perdescmaxidealant; }
            set {  perdescmaxidealant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXPOSSIVEL
        /// Comentário: % DESCONTO MÁXIMO POSSÍVEL
        /// </summary>
        private decimal perdescmaxpossivel;
        [XmlElement(ElementName = "PERDESCMAXPOSSIVEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxpossivel
        {
            get { return  perdescmaxpossivel; }
            set {  perdescmaxpossivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXPOSSIVELANT
        /// Comentário: % DESCONTO MÁXIMO POSSÍVEL ANTERIOR
        /// </summary>
        private decimal perdescmaxpossivelant;
        [XmlElement(ElementName = "PERDESCMAXPOSSIVELANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxpossivelant
        {
            get { return  perdescmaxpossivelant; }
            set {  perdescmaxpossivelant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXTABBALCAO
        /// Comentário: % desconto futuro balcão
        /// </summary>
        private decimal perdescmaxtabbalcao;
        [XmlElement(ElementName = "PERDESCMAXTABBALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxtabbalcao
        {
            get { return  perdescmaxtabbalcao; }
            set {  perdescmaxtabbalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAXTABBALCAOANT
        /// Comentário: % desconto futuro balcão anterior
        /// </summary>
        private decimal perdescmaxtabbalcaoant;
        [XmlElement(ElementName = "PERDESCMAXTABBALCAOANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmaxtabbalcaoant
        {
            get { return  perdescmaxtabbalcaoant; }
            set {  perdescmaxtabbalcaoant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTA
        /// Comentário: 
        /// </summary>
        private decimal poferta;
        [XmlElement(ElementName = "POFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Poferta
        {
            get { return  poferta; }
            set {  poferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTAANT
        /// Comentário: 
        /// </summary>
        private decimal pofertaant;
        [XmlElement(ElementName = "POFERTAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pofertaant
        {
            get { return  pofertaant; }
            set {  pofertaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTAATAC
        /// Comentário: Indica o preço de oferta por atacado. 
        /// </summary>
        private decimal pofertaatac;
        [XmlElement(ElementName = "POFERTAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pofertaatac
        {
            get { return  pofertaatac; }
            set {  pofertaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTAATACANT
        /// Comentário: Indica o preço de oferta por atacado anterior. 
        /// </summary>
        private decimal pofertaatacant;
        [XmlElement(ElementName = "POFERTAATACANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pofertaatacant
        {
            get { return  pofertaatacant; }
            set {  pofertaatacant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTAWEB
        /// Comentário: Preço oferta web
        /// </summary>
        private decimal pofertaweb;
        [XmlElement(ElementName = "POFERTAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pofertaweb
        {
            get { return  pofertaweb; }
            set {  pofertaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POFERTAWEBANT
        /// Comentário: Preço oferta web anterior
        /// </summary>
        private decimal pofertawebant;
        [XmlElement(ElementName = "POFERTAWEBANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pofertawebant
        {
            get { return  pofertawebant; }
            set {  pofertawebant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROGRAMA
        /// Comentário: Programa responsavel pela alteração
        /// </summary>
        private string programa;
        [XmlElement(ElementName = "PROGRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Programa
        {
            get { return  programa; }
            set {  programa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: Simulação do preço futuro de venda/atual. 
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAANT
        /// Comentário: Simulação do preço futuro de venda/anterior. 
        /// </summary>
        private decimal ptabelaant;
        [XmlElement(ElementName = "PTABELAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaant
        {
            get { return  ptabelaant; }
            set {  ptabelaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATAC
        /// Comentário: Preço futuro atacado
        /// </summary>
        private decimal ptabelaatac;
        [XmlElement(ElementName = "PTABELAATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatac
        {
            get { return  ptabelaatac; }
            set {  ptabelaatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAATACANT
        /// Comentário: Preço futuro atacado anterior
        /// </summary>
        private decimal ptabelaatacant;
        [XmlElement(ElementName = "PTABELAATACANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaatacant
        {
            get { return  ptabelaatacant; }
            set {  ptabelaatacant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAWEB
        /// Comentário: Preço futuro web
        /// </summary>
        private decimal ptabelaweb;
        [XmlElement(ElementName = "PTABELAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelaweb
        {
            get { return  ptabelaweb; }
            set {  ptabelaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELAWEBANT
        /// Comentário: Preço futuro web anterior
        /// </summary>
        private decimal ptabelawebant;
        [XmlElement(ElementName = "PTABELAWEBANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabelawebant
        {
            get { return  ptabelawebant; }
            set {  ptabelawebant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA1
        /// Comentário: Preço tabela 1
        /// </summary>
        private decimal ptabela1;
        [XmlElement(ElementName = "PTABELA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela1
        {
            get { return  ptabela1; }
            set {  ptabela1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA1ANT
        /// Comentário: Preço tabela anterior 1
        /// </summary>
        private decimal ptabela1ant;
        [XmlElement(ElementName = "PTABELA1ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela1ant
        {
            get { return  ptabela1ant; }
            set {  ptabela1ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA2
        /// Comentário: Preço tabela 2
        /// </summary>
        private decimal ptabela2;
        [XmlElement(ElementName = "PTABELA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela2
        {
            get { return  ptabela2; }
            set {  ptabela2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA2ANT
        /// Comentário: Preço tabela anterior 2
        /// </summary>
        private decimal ptabela2ant;
        [XmlElement(ElementName = "PTABELA2ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela2ant
        {
            get { return  ptabela2ant; }
            set {  ptabela2ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA3
        /// Comentário: Preço tabela 3
        /// </summary>
        private decimal ptabela3;
        [XmlElement(ElementName = "PTABELA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela3
        {
            get { return  ptabela3; }
            set {  ptabela3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA3ANT
        /// Comentário: Preço tabela anterior 3
        /// </summary>
        private decimal ptabela3ant;
        [XmlElement(ElementName = "PTABELA3ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela3ant
        {
            get { return  ptabela3ant; }
            set {  ptabela3ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA4
        /// Comentário: Preço tabela 4
        /// </summary>
        private decimal ptabela4;
        [XmlElement(ElementName = "PTABELA4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela4
        {
            get { return  ptabela4; }
            set {  ptabela4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA4ANT
        /// Comentário: Preço tabela anterior 4
        /// </summary>
        private decimal ptabela4ant;
        [XmlElement(ElementName = "PTABELA4ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela4ant
        {
            get { return  ptabela4ant; }
            set {  ptabela4ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA5
        /// Comentário: Preço tabela 5
        /// </summary>
        private decimal ptabela5;
        [XmlElement(ElementName = "PTABELA5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela5
        {
            get { return  ptabela5; }
            set {  ptabela5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA5ANT
        /// Comentário: Preço tabela anterior 5
        /// </summary>
        private decimal ptabela5ant;
        [XmlElement(ElementName = "PTABELA5ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela5ant
        {
            get { return  ptabela5ant; }
            set {  ptabela5ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA6
        /// Comentário: Preço tabela 6
        /// </summary>
        private decimal ptabela6;
        [XmlElement(ElementName = "PTABELA6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela6
        {
            get { return  ptabela6; }
            set {  ptabela6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA6ANT
        /// Comentário: Preço tabela anterior 6
        /// </summary>
        private decimal ptabela6ant;
        [XmlElement(ElementName = "PTABELA6ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela6ant
        {
            get { return  ptabela6ant; }
            set {  ptabela6ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA7
        /// Comentário: Preço tabela 7
        /// </summary>
        private decimal ptabela7;
        [XmlElement(ElementName = "PTABELA7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela7
        {
            get { return  ptabela7; }
            set {  ptabela7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA7ANT
        /// Comentário: Preço tabela anterior 7
        /// </summary>
        private decimal ptabela7ant;
        [XmlElement(ElementName = "PTABELA7ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela7ant
        {
            get { return  ptabela7ant; }
            set {  ptabela7ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAANT
        /// Comentário: 
        /// </summary>
        private decimal pvendaant;
        [XmlElement(ElementName = "PVENDAANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaant
        {
            get { return  pvendaant; }
            set {  pvendaant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAATAC
        /// Comentário: Indica o preço de venda por atacado. 
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
        /// Propriedade referente ao campo: PVENDAATACANT
        /// Comentário: Indica preço da venda por atacado anterior. 
        /// </summary>
        private decimal pvendaatacant;
        [XmlElement(ElementName = "PVENDAATACANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Pvendaatacant
        {
            get { return  pvendaatacant; }
            set {  pvendaatacant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAWEB
        /// Comentário: Preço venda web
        /// </summary>
        private decimal pvendaweb;
        [XmlElement(ElementName = "PVENDAWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendaweb
        {
            get { return  pvendaweb; }
            set {  pvendaweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDAWEBANT
        /// Comentário: Preço venda web anterior
        /// </summary>
        private decimal pvendawebant;
        [XmlElement(ElementName = "PVENDAWEBANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvendawebant
        {
            get { return  pvendawebant; }
            set {  pvendawebant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA1
        /// Comentário: Preço venda 1
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
        /// Propriedade referente ao campo: PVENDA1ANT
        /// Comentário: Preço venda anterior 1
        /// </summary>
        private decimal pvenda1ant;
        [XmlElement(ElementName = "PVENDA1ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda1ant
        {
            get { return  pvenda1ant; }
            set {  pvenda1ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA2
        /// Comentário: Preço venda 2
        /// </summary>
        private decimal pvenda2;
        [XmlElement(ElementName = "PVENDA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda2
        {
            get { return  pvenda2; }
            set {  pvenda2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA2ANT
        /// Comentário: Preço venda anterior 2
        /// </summary>
        private decimal pvenda2ant;
        [XmlElement(ElementName = "PVENDA2ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda2ant
        {
            get { return  pvenda2ant; }
            set {  pvenda2ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA3
        /// Comentário: Preço venda 3
        /// </summary>
        private decimal pvenda3;
        [XmlElement(ElementName = "PVENDA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda3
        {
            get { return  pvenda3; }
            set {  pvenda3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA3ANT
        /// Comentário: Preço venda anterior 3
        /// </summary>
        private decimal pvenda3ant;
        [XmlElement(ElementName = "PVENDA3ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda3ant
        {
            get { return  pvenda3ant; }
            set {  pvenda3ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA4
        /// Comentário: Preço venda 4
        /// </summary>
        private decimal pvenda4;
        [XmlElement(ElementName = "PVENDA4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda4
        {
            get { return  pvenda4; }
            set {  pvenda4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA4ANT
        /// Comentário: Preço venda anterior 4
        /// </summary>
        private decimal pvenda4ant;
        [XmlElement(ElementName = "PVENDA4ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda4ant
        {
            get { return  pvenda4ant; }
            set {  pvenda4ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA5
        /// Comentário: Preço venda 5
        /// </summary>
        private decimal pvenda5;
        [XmlElement(ElementName = "PVENDA5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda5
        {
            get { return  pvenda5; }
            set {  pvenda5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA5ANT
        /// Comentário: Preço venda anterior 5
        /// </summary>
        private decimal pvenda5ant;
        [XmlElement(ElementName = "PVENDA5ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda5ant
        {
            get { return  pvenda5ant; }
            set {  pvenda5ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA6
        /// Comentário: Preço venda 6
        /// </summary>
        private decimal pvenda6;
        [XmlElement(ElementName = "PVENDA6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda6
        {
            get { return  pvenda6; }
            set {  pvenda6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA6ANT
        /// Comentário: Preço venda anterior 6
        /// </summary>
        private decimal pvenda6ant;
        [XmlElement(ElementName = "PVENDA6ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda6ant
        {
            get { return  pvenda6ant; }
            set {  pvenda6ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA7
        /// Comentário: Preço venda 7
        /// </summary>
        private decimal pvenda7;
        [XmlElement(ElementName = "PVENDA7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda7
        {
            get { return  pvenda7; }
            set {  pvenda7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA7ANT
        /// Comentário: Preço venda anterior 7
        /// </summary>
        private decimal pvenda7ant;
        [XmlElement(ElementName = "PVENDA7ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pvenda7ant
        {
            get { return  pvenda7ant; }
            set {  pvenda7ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESCAUTOR
        /// Comentário: 
        /// </summary>
        private decimal qtdescautor;
        [XmlElement(ElementName = "QTDESCAUTOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdescautor
        {
            get { return  qtdescautor; }
            set {  qtdescautor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESCAUTORANT
        /// Comentário: 
        /// </summary>
        private decimal qtdescautorant;
        [XmlElement(ElementName = "QTDESCAUTORANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtdescautorant
        {
            get { return  qtdescautorant; }
            set {  qtdescautorant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINATACANTERIOR
        /// Comentário: Quantidade mínima de atacado anterior. 
        /// </summary>
        private decimal qtminatacanterior;
        [XmlElement(ElementName = "QTMINATACANTERIOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtminatacanterior
        {
            get { return  qtminatacanterior; }
            set {  qtminatacanterior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMINATACATUAL
        /// Comentário: Quantidade mínima de atacado atual. 
        /// </summary>
        private decimal qtminatacatual;
        [XmlElement(ElementName = "QTMINATACATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Qtminatacatual
        {
            get { return  qtminatacatual; }
            set {  qtminatacatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINA
        /// Comentário: 
        /// </summary>
        private string rotina;
        [XmlElement(ElementName = "ROTINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Rotina
        {
            get { return  rotina; }
            set {  rotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOREDE
        /// Comentário: Grava usuário da rede
        /// </summary>
        private string usuariorede;
        [XmlElement(ElementName = "USUARIOREDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usuariorede
        {
            get { return  usuariorede; }
            set {  usuariorede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLULTENTMES
        /// Comentário: Média do valor da última entrada
        /// </summary>
        private decimal vlultentmes;
        [XmlElement(ElementName = "VLULTENTMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlultentmes
        {
            get { return  vlultentmes; }
            set {  vlultentmes = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPreco()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRECO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPreco> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPreco>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPreco> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPreco>(where);
        }

        #endregion
    }
}
