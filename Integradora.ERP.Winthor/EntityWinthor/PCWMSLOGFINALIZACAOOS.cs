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
    /// Classe referente a tabela PCWmslogfinalizacaoos
    /// </summary>
    [XmlType("PCWMSLOGFINALIZACAOOS")]
    public class PCWmslogfinalizacaoos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APLICACAO
        /// Comentário: 
        /// </summary>
        private string aplicacao;
        [XmlElement(ElementName = "APLICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Aplicacao
        {
            get { return  aplicacao; }
            set {  aplicacao = value; }
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
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
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
        /// Propriedade referente ao campo: MAQUINA
        /// Comentário: 
        /// </summary>
        private string maquina;
        [XmlElement(ElementName = "MAQUINA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Maquina
        {
            get { return  maquina; }
            set {  maquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAQUINA_REDE
        /// Comentário: 
        /// </summary>
        private string maquina_rede;
        [XmlElement(ElementName = "MAQUINA_REDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Maquina_Rede
        {
            get { return  maquina_rede; }
            set {  maquina_rede = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal numbonus;
        [XmlElement(ElementName = "NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numbonus
        {
            get { return  numbonus; }
            set {  numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Comentário: 
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMTRANSWMS
        /// Comentário: 
        /// </summary>
        private decimal numtranswms;
        [XmlElement(ElementName = "NUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranswms
        {
            get { return  numtranswms; }
            set {  numtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
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
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: 
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_BOX
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_box;
        [XmlElement(ElementName = "PCCROSSDOCKING_BOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pccrossdocking_Box
        {
            get { return  pccrossdocking_box; }
            set {  pccrossdocking_box = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_CODCLI
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_codcli;
        [XmlElement(ElementName = "PCCROSSDOCKING_CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pccrossdocking_Codcli
        {
            get { return  pccrossdocking_codcli; }
            set {  pccrossdocking_codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_codendereco;
        [XmlElement(ElementName = "PCCROSSDOCKING_CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pccrossdocking_Codendereco
        {
            get { return  pccrossdocking_codendereco; }
            set {  pccrossdocking_codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_CODFUNCGER
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_codfuncger;
        [XmlElement(ElementName = "PCCROSSDOCKING_CODFUNCGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pccrossdocking_Codfuncger
        {
            get { return  pccrossdocking_codfuncger; }
            set {  pccrossdocking_codfuncger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_codprod;
        [XmlElement(ElementName = "PCCROSSDOCKING_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pccrossdocking_Codprod
        {
            get { return  pccrossdocking_codprod; }
            set {  pccrossdocking_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_DATA
        /// Comentário: 
        /// </summary>
        private DateTime? pccrossdocking_data;
        [XmlElement(ElementName = "PCCROSSDOCKING_DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pccrossdocking_Data
        {
            get { return  pccrossdocking_data; }
            set {  pccrossdocking_data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_DESPACHADO
        /// Comentário: 
        /// </summary>
        private string pccrossdocking_despachado;
        [XmlElement(ElementName = "PCCROSSDOCKING_DESPACHADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pccrossdocking_Despachado
        {
            get { return  pccrossdocking_despachado; }
            set {  pccrossdocking_despachado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_DTFIMOS
        /// Comentário: 
        /// </summary>
        private DateTime? pccrossdocking_dtfimos;
        [XmlElement(ElementName = "PCCROSSDOCKING_DTFIMOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pccrossdocking_Dtfimos
        {
            get { return  pccrossdocking_dtfimos; }
            set {  pccrossdocking_dtfimos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_numbonus;
        [XmlElement(ElementName = "PCCROSSDOCKING_NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pccrossdocking_Numbonus
        {
            get { return  pccrossdocking_numbonus; }
            set {  pccrossdocking_numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pccrossdocking_numlote;
        [XmlElement(ElementName = "PCCROSSDOCKING_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pccrossdocking_Numlote
        {
            get { return  pccrossdocking_numlote; }
            set {  pccrossdocking_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_numtransvenda;
        [XmlElement(ElementName = "PCCROSSDOCKING_NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pccrossdocking_Numtransvenda
        {
            get { return  pccrossdocking_numtransvenda; }
            set {  pccrossdocking_numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_QT
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_qt;
        [XmlElement(ElementName = "PCCROSSDOCKING_QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pccrossdocking_Qt
        {
            get { return  pccrossdocking_qt; }
            set {  pccrossdocking_qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCCROSSDOCKING_QT_ANT
        /// Comentário: 
        /// </summary>
        private decimal pccrossdocking_qt_ant;
        [XmlElement(ElementName = "PCCROSSDOCKING_QT_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pccrossdocking_Qt_Ant
        {
            get { return  pccrossdocking_qt_ant; }
            set {  pccrossdocking_qt_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_BLOQUEIO
        /// Comentário: 
        /// </summary>
        private string pcendereco_bloqueio;
        [XmlElement(ElementName = "PCENDERECO_BLOQUEIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcendereco_Bloqueio
        {
            get { return  pcendereco_bloqueio; }
            set {  pcendereco_bloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal pcendereco_codendereco;
        [XmlElement(ElementName = "PCENDERECO_CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcendereco_Codendereco
        {
            get { return  pcendereco_codendereco; }
            set {  pcendereco_codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_CODESTRUTURA
        /// Comentário: 
        /// </summary>
        private decimal pcendereco_codestrutura;
        [XmlElement(ElementName = "PCENDERECO_CODESTRUTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pcendereco_Codestrutura
        {
            get { return  pcendereco_codestrutura; }
            set {  pcendereco_codestrutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_CODFILIAL
        /// Comentário: 
        /// </summary>
        private string pcendereco_codfilial;
        [XmlElement(ElementName = "PCENDERECO_CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcendereco_Codfilial
        {
            get { return  pcendereco_codfilial; }
            set {  pcendereco_codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_NUMINVENT
        /// Comentário: 
        /// </summary>
        private decimal pcendereco_numinvent;
        [XmlElement(ElementName = "PCENDERECO_NUMINVENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcendereco_Numinvent
        {
            get { return  pcendereco_numinvent; }
            set {  pcendereco_numinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_QTBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal pcendereco_qtbloqueada;
        [XmlElement(ElementName = "PCENDERECO_QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcendereco_Qtbloqueada
        {
            get { return  pcendereco_qtbloqueada; }
            set {  pcendereco_qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_SITUACAO
        /// Comentário: 
        /// </summary>
        private string pcendereco_situacao;
        [XmlElement(ElementName = "PCENDERECO_SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcendereco_Situacao
        {
            get { return  pcendereco_situacao; }
            set {  pcendereco_situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_STATUS
        /// Comentário: 
        /// </summary>
        private string pcendereco_status;
        [XmlElement(ElementName = "PCENDERECO_STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcendereco_Status
        {
            get { return  pcendereco_status; }
            set {  pcendereco_status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_TIPOENDER
        /// Comentário: 
        /// </summary>
        private string pcendereco_tipoender;
        [XmlElement(ElementName = "PCENDERECO_TIPOENDER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcendereco_Tipoender
        {
            get { return  pcendereco_tipoender; }
            set {  pcendereco_tipoender = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCENDERECO_TIPOPAL
        /// Comentário: 
        /// </summary>
        private decimal pcendereco_tipopal;
        [XmlElement(ElementName = "PCENDERECO_TIPOPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pcendereco_Tipopal
        {
            get { return  pcendereco_tipopal; }
            set {  pcendereco_tipopal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_CODFILIAL
        /// Comentário: 
        /// </summary>
        private string pcest_codfilial;
        [XmlElement(ElementName = "PCEST_CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcest_Codfilial
        {
            get { return  pcest_codfilial; }
            set {  pcest_codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcest_codprod;
        [XmlElement(ElementName = "PCEST_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcest_Codprod
        {
            get { return  pcest_codprod; }
            set {  pcest_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecobloq_codendereco;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcestenderecobloq_Codendereco
        {
            get { return  pcestenderecobloq_codendereco; }
            set {  pcestenderecobloq_codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_CODFILIAL
        /// Comentário: 
        /// </summary>
        private string pcestenderecobloq_codfilial;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcestenderecobloq_Codfilial
        {
            get { return  pcestenderecobloq_codfilial; }
            set {  pcestenderecobloq_codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_CODOPER
        /// Comentário: 
        /// </summary>
        private string pcestenderecobloq_codoper;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_CODOPER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcestenderecobloq_Codoper
        {
            get { return  pcestenderecobloq_codoper; }
            set {  pcestenderecobloq_codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecobloq_codprod;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcestenderecobloq_Codprod
        {
            get { return  pcestenderecobloq_codprod; }
            set {  pcestenderecobloq_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pcestenderecobloq_numlote;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Pcestenderecobloq_Numlote
        {
            get { return  pcestenderecobloq_numlote; }
            set {  pcestenderecobloq_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_NUMLOTE_ANT
        /// Comentário: 
        /// </summary>
        private string pcestenderecobloq_numlote_ant;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_NUMLOTE_ANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Pcestenderecobloq_Numlote_Ant
        {
            get { return  pcestenderecobloq_numlote_ant; }
            set {  pcestenderecobloq_numlote_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_NUMOS
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecobloq_numos;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcestenderecobloq_Numos
        {
            get { return  pcestenderecobloq_numos; }
            set {  pcestenderecobloq_numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_QT
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecobloq_qt;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestenderecobloq_Qt
        {
            get { return  pcestenderecobloq_qt; }
            set {  pcestenderecobloq_qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOBLOQ_QT_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecobloq_qt_ant;
        [XmlElement(ElementName = "PCESTENDERECOBLOQ_QT_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestenderecobloq_Qt_Ant
        {
            get { return  pcestenderecobloq_qt_ant; }
            set {  pcestenderecobloq_qt_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_codendereco;
        [XmlElement(ElementName = "PCESTENDERECO_CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcestendereco_Codendereco
        {
            get { return  pcestendereco_codendereco; }
            set {  pcestendereco_codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_CODIGOUMA
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_codigouma;
        [XmlElement(ElementName = "PCESTENDERECO_CODIGOUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pcestendereco_Codigouma
        {
            get { return  pcestendereco_codigouma; }
            set {  pcestendereco_codigouma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_codprod;
        [XmlElement(ElementName = "PCESTENDERECO_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcestendereco_Codprod
        {
            get { return  pcestendereco_codprod; }
            set {  pcestendereco_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_DTENTRADA
        /// Comentário: 
        /// </summary>
        private DateTime? pcestendereco_dtentrada;
        [XmlElement(ElementName = "PCESTENDERECO_DTENTRADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcestendereco_Dtentrada
        {
            get { return  pcestendereco_dtentrada; }
            set {  pcestendereco_dtentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_DTENTRADA_ANT
        /// Comentário: 
        /// </summary>
        private DateTime? pcestendereco_dtentrada_ant;
        [XmlElement(ElementName = "PCESTENDERECO_DTENTRADA_ANT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcestendereco_Dtentrada_Ant
        {
            get { return  pcestendereco_dtentrada_ant; }
            set {  pcestendereco_dtentrada_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_DTVAL
        /// Comentário: 
        /// </summary>
        private DateTime? pcestendereco_dtval;
        [XmlElement(ElementName = "PCESTENDERECO_DTVAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcestendereco_Dtval
        {
            get { return  pcestendereco_dtval; }
            set {  pcestendereco_dtval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_DTVAL_ANT
        /// Comentário: 
        /// </summary>
        private DateTime? pcestendereco_dtval_ant;
        [XmlElement(ElementName = "PCESTENDERECO_DTVAL_ANT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcestendereco_Dtval_Ant
        {
            get { return  pcestendereco_dtval_ant; }
            set {  pcestendereco_dtval_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecoi_codendereco;
        [XmlElement(ElementName = "PCESTENDERECOI_CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pcestenderecoi_Codendereco
        {
            get { return  pcestenderecoi_codendereco; }
            set {  pcestenderecoi_codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecoi_codprod;
        [XmlElement(ElementName = "PCESTENDERECOI_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pcestenderecoi_Codprod
        {
            get { return  pcestenderecoi_codprod; }
            set {  pcestenderecoi_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_CODUMA
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecoi_coduma;
        [XmlElement(ElementName = "PCESTENDERECOI_CODUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pcestenderecoi_Coduma
        {
            get { return  pcestenderecoi_coduma; }
            set {  pcestenderecoi_coduma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_DTVAL
        /// Comentário: 
        /// </summary>
        private DateTime? pcestenderecoi_dtval;
        [XmlElement(ElementName = "PCESTENDERECOI_DTVAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcestenderecoi_Dtval
        {
            get { return  pcestenderecoi_dtval; }
            set {  pcestenderecoi_dtval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_DTVAL_ANT
        /// Comentário: 
        /// </summary>
        private DateTime? pcestenderecoi_dtval_ant;
        [XmlElement(ElementName = "PCESTENDERECOI_DTVAL_ANT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcestenderecoi_Dtval_Ant
        {
            get { return  pcestenderecoi_dtval_ant; }
            set {  pcestenderecoi_dtval_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pcestenderecoi_numlote;
        [XmlElement(ElementName = "PCESTENDERECOI_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Pcestenderecoi_Numlote
        {
            get { return  pcestenderecoi_numlote; }
            set {  pcestenderecoi_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_NUMLOTE_ANT
        /// Comentário: 
        /// </summary>
        private string pcestenderecoi_numlote_ant;
        [XmlElement(ElementName = "PCESTENDERECOI_NUMLOTE_ANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Pcestenderecoi_Numlote_Ant
        {
            get { return  pcestenderecoi_numlote_ant; }
            set {  pcestenderecoi_numlote_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_QT
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecoi_qt;
        [XmlElement(ElementName = "PCESTENDERECOI_QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestenderecoi_Qt
        {
            get { return  pcestenderecoi_qt; }
            set {  pcestenderecoi_qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECOI_QT_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcestenderecoi_qt_ant;
        [XmlElement(ElementName = "PCESTENDERECOI_QT_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestenderecoi_Qt_Ant
        {
            get { return  pcestenderecoi_qt_ant; }
            set {  pcestenderecoi_qt_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pcestendereco_numlote;
        [XmlElement(ElementName = "PCESTENDERECO_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pcestendereco_Numlote
        {
            get { return  pcestendereco_numlote; }
            set {  pcestendereco_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_NUMLOTE_ANT
        /// Comentário: 
        /// </summary>
        private string pcestendereco_numlote_ant;
        [XmlElement(ElementName = "PCESTENDERECO_NUMLOTE_ANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pcestendereco_Numlote_Ant
        {
            get { return  pcestendereco_numlote_ant; }
            set {  pcestendereco_numlote_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QT
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qt;
        [XmlElement(ElementName = "PCESTENDERECO_QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qt
        {
            get { return  pcestendereco_qt; }
            set {  pcestendereco_qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QT_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qt_ant;
        [XmlElement(ElementName = "PCESTENDERECO_QT_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qt_Ant
        {
            get { return  pcestendereco_qt_ant; }
            set {  pcestendereco_qt_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QTBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qtbloqueada;
        [XmlElement(ElementName = "PCESTENDERECO_QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qtbloqueada
        {
            get { return  pcestendereco_qtbloqueada; }
            set {  pcestendereco_qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QTBLOQUEADA_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qtbloqueada_ant;
        [XmlElement(ElementName = "PCESTENDERECO_QTBLOQUEADA_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qtbloqueada_Ant
        {
            get { return  pcestendereco_qtbloqueada_ant; }
            set {  pcestendereco_qtbloqueada_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QTPENDENT_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qtpendent_ant;
        [XmlElement(ElementName = "PCESTENDERECO_QTPENDENT_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qtpendent_Ant
        {
            get { return  pcestendereco_qtpendent_ant; }
            set {  pcestendereco_qtpendent_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QTPENDENTRADA
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qtpendentrada;
        [XmlElement(ElementName = "PCESTENDERECO_QTPENDENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qtpendentrada
        {
            get { return  pcestendereco_qtpendentrada; }
            set {  pcestendereco_qtpendentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QTPENDSAIDA
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qtpendsaida;
        [XmlElement(ElementName = "PCESTENDERECO_QTPENDSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qtpendsaida
        {
            get { return  pcestendereco_qtpendsaida; }
            set {  pcestendereco_qtpendsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QTPENDSAIDA_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qtpendsaida_ant;
        [XmlElement(ElementName = "PCESTENDERECO_QTPENDSAIDA_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qtpendsaida_Ant
        {
            get { return  pcestendereco_qtpendsaida_ant; }
            set {  pcestendereco_qtpendsaida_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QTRESERV
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qtreserv;
        [XmlElement(ElementName = "PCESTENDERECO_QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qtreserv
        {
            get { return  pcestendereco_qtreserv; }
            set {  pcestendereco_qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCESTENDERECO_QTRESERV_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcestendereco_qtreserv_ant;
        [XmlElement(ElementName = "PCESTENDERECO_QTRESERV_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcestendereco_Qtreserv_Ant
        {
            get { return  pcestendereco_qtreserv_ant; }
            set {  pcestendereco_qtreserv_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtbloqueada;
        [XmlElement(ElementName = "PCEST_QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcest_Qtbloqueada
        {
            get { return  pcest_qtbloqueada; }
            set {  pcest_qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTBLOQUEADA_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtbloqueada_ant;
        [XmlElement(ElementName = "PCEST_QTBLOQUEADA_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcest_Qtbloqueada_Ant
        {
            get { return  pcest_qtbloqueada_ant; }
            set {  pcest_qtbloqueada_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTEST
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtest;
        [XmlElement(ElementName = "PCEST_QTEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Pcest_Qtest
        {
            get { return  pcest_qtest; }
            set {  pcest_qtest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTEST_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtest_ant;
        [XmlElement(ElementName = "PCEST_QTEST_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Pcest_Qtest_Ant
        {
            get { return  pcest_qtest_ant; }
            set {  pcest_qtest_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTESTGER
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtestger;
        [XmlElement(ElementName = "PCEST_QTESTGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Pcest_Qtestger
        {
            get { return  pcest_qtestger; }
            set {  pcest_qtestger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTESTGER_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtestger_ant;
        [XmlElement(ElementName = "PCEST_QTESTGER_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Pcest_Qtestger_Ant
        {
            get { return  pcest_qtestger_ant; }
            set {  pcest_qtestger_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTINDENIZ
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtindeniz;
        [XmlElement(ElementName = "PCEST_QTINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcest_Qtindeniz
        {
            get { return  pcest_qtindeniz; }
            set {  pcest_qtindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTINDENIZ_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtindeniz_ant;
        [XmlElement(ElementName = "PCEST_QTINDENIZ_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcest_Qtindeniz_Ant
        {
            get { return  pcest_qtindeniz_ant; }
            set {  pcest_qtindeniz_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTRESERV
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtreserv;
        [XmlElement(ElementName = "PCEST_QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Pcest_Qtreserv
        {
            get { return  pcest_qtreserv; }
            set {  pcest_qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCEST_QTRESERV_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcest_qtreserv_ant;
        [XmlElement(ElementName = "PCEST_QTRESERV_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Pcest_Qtreserv_Ant
        {
            get { return  pcest_qtreserv_ant; }
            set {  pcest_qtreserv_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_CODFILIAL
        /// Comentário: 
        /// </summary>
        private string pclote_codfilial;
        [XmlElement(ElementName = "PCLOTE_CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pclote_Codfilial
        {
            get { return  pclote_codfilial; }
            set {  pclote_codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pclote_codprod;
        [XmlElement(ElementName = "PCLOTE_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pclote_Codprod
        {
            get { return  pclote_codprod; }
            set {  pclote_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_DTVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? pclote_dtvalidade;
        [XmlElement(ElementName = "PCLOTE_DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pclote_Dtvalidade
        {
            get { return  pclote_dtvalidade; }
            set {  pclote_dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_DTVALIDADE_ANT
        /// Comentário: 
        /// </summary>
        private DateTime? pclote_dtvalidade_ant;
        [XmlElement(ElementName = "PCLOTE_DTVALIDADE_ANT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pclote_Dtvalidade_Ant
        {
            get { return  pclote_dtvalidade_ant; }
            set {  pclote_dtvalidade_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pclote_numlote;
        [XmlElement(ElementName = "PCLOTE_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pclote_Numlote
        {
            get { return  pclote_numlote; }
            set {  pclote_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_QT
        /// Comentário: 
        /// </summary>
        private decimal pclote_qt;
        [XmlElement(ElementName = "PCLOTE_QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Pclote_Qt
        {
            get { return  pclote_qt; }
            set {  pclote_qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_QT_ANT
        /// Comentário: 
        /// </summary>
        private decimal pclote_qt_ant;
        [XmlElement(ElementName = "PCLOTE_QT_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Pclote_Qt_Ant
        {
            get { return  pclote_qt_ant; }
            set {  pclote_qt_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_QTBLOQUEADA
        /// Comentário: 
        /// </summary>
        private decimal pclote_qtbloqueada;
        [XmlElement(ElementName = "PCLOTE_QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Pclote_Qtbloqueada
        {
            get { return  pclote_qtbloqueada; }
            set {  pclote_qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_QTBLOQUEADA_ANT
        /// Comentário: 
        /// </summary>
        private decimal pclote_qtbloqueada_ant;
        [XmlElement(ElementName = "PCLOTE_QTBLOQUEADA_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Pclote_Qtbloqueada_Ant
        {
            get { return  pclote_qtbloqueada_ant; }
            set {  pclote_qtbloqueada_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_QTINDENIZ
        /// Comentário: 
        /// </summary>
        private decimal pclote_qtindeniz;
        [XmlElement(ElementName = "PCLOTE_QTINDENIZ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Pclote_Qtindeniz
        {
            get { return  pclote_qtindeniz; }
            set {  pclote_qtindeniz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_QTINDENIZ_ANT
        /// Comentário: 
        /// </summary>
        private decimal pclote_qtindeniz_ant;
        [XmlElement(ElementName = "PCLOTE_QTINDENIZ_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Pclote_Qtindeniz_Ant
        {
            get { return  pclote_qtindeniz_ant; }
            set {  pclote_qtindeniz_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_QTRESERV
        /// Comentário: 
        /// </summary>
        private decimal pclote_qtreserv;
        [XmlElement(ElementName = "PCLOTE_QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Pclote_Qtreserv
        {
            get { return  pclote_qtreserv; }
            set {  pclote_qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCLOTE_QTRESERV_ANT
        /// Comentário: 
        /// </summary>
        private decimal pclote_qtreserv_ant;
        [XmlElement(ElementName = "PCLOTE_QTRESERV_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public decimal Pclote_Qtreserv_Ant
        {
            get { return  pclote_qtreserv_ant; }
            set {  pclote_qtreserv_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODBOX
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codbox;
        [XmlElement(ElementName = "PCMOVENDPEND_CODBOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pcmovendpend_Codbox
        {
            get { return  pcmovendpend_codbox; }
            set {  pcmovendpend_codbox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codendereco;
        [XmlElement(ElementName = "PCMOVENDPEND_CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Codendereco
        {
            get { return  pcmovendpend_codendereco; }
            set {  pcmovendpend_codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODENDERECOORIG
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codenderecoorig;
        [XmlElement(ElementName = "PCMOVENDPEND_CODENDERECOORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Codenderecoorig
        {
            get { return  pcmovendpend_codenderecoorig; }
            set {  pcmovendpend_codenderecoorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODFILIAL
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_codfilial;
        [XmlElement(ElementName = "PCMOVENDPEND_CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcmovendpend_Codfilial
        {
            get { return  pcmovendpend_codfilial; }
            set {  pcmovendpend_codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODFUNCCOFERENTE
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codfunccoferente;
        [XmlElement(ElementName = "PCMOVENDPEND_CODFUNCCOFERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcmovendpend_Codfunccoferente
        {
            get { return  pcmovendpend_codfunccoferente; }
            set {  pcmovendpend_codfunccoferente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODFUNCCONF
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codfuncconf;
        [XmlElement(ElementName = "PCMOVENDPEND_CODFUNCCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcmovendpend_Codfuncconf
        {
            get { return  pcmovendpend_codfuncconf; }
            set {  pcmovendpend_codfuncconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODFUNCEMBALADOR
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codfuncembalador;
        [XmlElement(ElementName = "PCMOVENDPEND_CODFUNCEMBALADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcmovendpend_Codfuncembalador
        {
            get { return  pcmovendpend_codfuncembalador; }
            set {  pcmovendpend_codfuncembalador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODFUNCOS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codfuncos;
        [XmlElement(ElementName = "PCMOVENDPEND_CODFUNCOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcmovendpend_Codfuncos
        {
            get { return  pcmovendpend_codfuncos; }
            set {  pcmovendpend_codfuncos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODFUNCOSFIM
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codfuncosfim;
        [XmlElement(ElementName = "PCMOVENDPEND_CODFUNCOSFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcmovendpend_Codfuncosfim
        {
            get { return  pcmovendpend_codfuncosfim; }
            set {  pcmovendpend_codfuncosfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODIGOUMA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codigouma;
        [XmlElement(ElementName = "PCMOVENDPEND_CODIGOUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pcmovendpend_Codigouma
        {
            get { return  pcmovendpend_codigouma; }
            set {  pcmovendpend_codigouma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODMODSEP
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codmodsep;
        [XmlElement(ElementName = "PCMOVENDPEND_CODMODSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pcmovendpend_Codmodsep
        {
            get { return  pcmovendpend_codmodsep; }
            set {  pcmovendpend_codmodsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODOPER
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_codoper;
        [XmlElement(ElementName = "PCMOVENDPEND_CODOPER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcmovendpend_Codoper
        {
            get { return  pcmovendpend_codoper; }
            set {  pcmovendpend_codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codpraca;
        [XmlElement(ElementName = "PCMOVENDPEND_CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pcmovendpend_Codpraca
        {
            get { return  pcmovendpend_codpraca; }
            set {  pcmovendpend_codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codprod;
        [XmlElement(ElementName = "PCMOVENDPEND_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcmovendpend_Codprod
        {
            get { return  pcmovendpend_codprod; }
            set {  pcmovendpend_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_CODROTINA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_codrotina;
        [XmlElement(ElementName = "PCMOVENDPEND_CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcmovendpend_Codrotina
        {
            get { return  pcmovendpend_codrotina; }
            set {  pcmovendpend_codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_CODFILIAL
        /// Comentário: 
        /// </summary>
        private string pcmovendpendconflote_codfilial;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcmovendpendconflote_Codfilial
        {
            get { return  pcmovendpendconflote_codfilial; }
            set {  pcmovendpendconflote_codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_CODOPER
        /// Comentário: 
        /// </summary>
        private string pcmovendpendconflote_codoper;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_CODOPER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcmovendpendconflote_Codoper
        {
            get { return  pcmovendpendconflote_codoper; }
            set {  pcmovendpendconflote_codoper = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpendconflote_codprod;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcmovendpendconflote_Codprod
        {
            get { return  pcmovendpendconflote_codprod; }
            set {  pcmovendpendconflote_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pcmovendpendconflote_numlote;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pcmovendpendconflote_Numlote
        {
            get { return  pcmovendpendconflote_numlote; }
            set {  pcmovendpendconflote_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_NUMOS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpendconflote_numos;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpendconflote_Numos
        {
            get { return  pcmovendpendconflote_numos; }
            set {  pcmovendpendconflote_numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_QT
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpendconflote_qt;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpendconflote_Qt
        {
            get { return  pcmovendpendconflote_qt; }
            set {  pcmovendpendconflote_qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_QTORIG
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpendconflote_qtorig;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_QTORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpendconflote_Qtorig
        {
            get { return  pcmovendpendconflote_qtorig; }
            set {  pcmovendpendconflote_qtorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_QTPECAS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpendconflote_qtpecas;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcmovendpendconflote_Qtpecas
        {
            get { return  pcmovendpendconflote_qtpecas; }
            set {  pcmovendpendconflote_qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPENDCONFLOTE_TIPOOS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpendconflote_tipoos;
        [XmlElement(ElementName = "PCMOVENDPENDCONFLOTE_TIPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pcmovendpendconflote_Tipoos
        {
            get { return  pcmovendpendconflote_tipoos; }
            set {  pcmovendpendconflote_tipoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DATACONF
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dataconf;
        [XmlElement(ElementName = "PCMOVENDPEND_DATACONF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dataconf
        {
            get { return  pcmovendpend_dataconf; }
            set {  pcmovendpend_dataconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DATAGERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_datageracao;
        [XmlElement(ElementName = "PCMOVENDPEND_DATAGERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Datageracao
        {
            get { return  pcmovendpend_datageracao; }
            set {  pcmovendpend_datageracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTFABRICACAO
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtfabricacao;
        [XmlElement(ElementName = "PCMOVENDPEND_DTFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtfabricacao
        {
            get { return  pcmovendpend_dtfabricacao; }
            set {  pcmovendpend_dtfabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTFIMCONFERENCIA
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtfimconferencia;
        [XmlElement(ElementName = "PCMOVENDPEND_DTFIMCONFERENCIA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtfimconferencia
        {
            get { return  pcmovendpend_dtfimconferencia; }
            set {  pcmovendpend_dtfimconferencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTFIMOS
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtfimos;
        [XmlElement(ElementName = "PCMOVENDPEND_DTFIMOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtfimos
        {
            get { return  pcmovendpend_dtfimos; }
            set {  pcmovendpend_dtfimos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTFIMOSFILA
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtfimosfila;
        [XmlElement(ElementName = "PCMOVENDPEND_DTFIMOSFILA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtfimosfila
        {
            get { return  pcmovendpend_dtfimosfila; }
            set {  pcmovendpend_dtfimosfila = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTFIMSEPARACAO
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtfimseparacao;
        [XmlElement(ElementName = "PCMOVENDPEND_DTFIMSEPARACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtfimseparacao
        {
            get { return  pcmovendpend_dtfimseparacao; }
            set {  pcmovendpend_dtfimseparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTINICIOCONF
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtinicioconf;
        [XmlElement(ElementName = "PCMOVENDPEND_DTINICIOCONF", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtinicioconf
        {
            get { return  pcmovendpend_dtinicioconf; }
            set {  pcmovendpend_dtinicioconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTINICIOOS
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtinicioos;
        [XmlElement(ElementName = "PCMOVENDPEND_DTINICIOOS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtinicioos
        {
            get { return  pcmovendpend_dtinicioos; }
            set {  pcmovendpend_dtinicioos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTINTEGRACAO
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtintegracao;
        [XmlElement(ElementName = "PCMOVENDPEND_DTINTEGRACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtintegracao
        {
            get { return  pcmovendpend_dtintegracao; }
            set {  pcmovendpend_dtintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_DTVALIDADE
        /// Comentário: 
        /// </summary>
        private DateTime? pcmovendpend_dtvalidade;
        [XmlElement(ElementName = "PCMOVENDPEND_DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Pcmovendpend_Dtvalidade
        {
            get { return  pcmovendpend_dtvalidade; }
            set {  pcmovendpend_dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_ITEMSEPARADO
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_itemseparado;
        [XmlElement(ElementName = "PCMOVENDPEND_ITEMSEPARADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcmovendpend_Itemseparado
        {
            get { return  pcmovendpend_itemseparado; }
            set {  pcmovendpend_itemseparado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMAGRUPADOR
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numagrupador;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMAGRUPADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Numagrupador
        {
            get { return  pcmovendpend_numagrupador; }
            set {  pcmovendpend_numagrupador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMBONUS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numbonus;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMBONUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcmovendpend_Numbonus
        {
            get { return  pcmovendpend_numbonus; }
            set {  pcmovendpend_numbonus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMBOX
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numbox;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMBOX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pcmovendpend_Numbox
        {
            get { return  pcmovendpend_numbox; }
            set {  pcmovendpend_numbox = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numcar;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcmovendpend_Numcar
        {
            get { return  pcmovendpend_numcar; }
            set {  pcmovendpend_numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_numlote;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pcmovendpend_Numlote
        {
            get { return  pcmovendpend_numlote; }
            set {  pcmovendpend_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMLOTE_ANT
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_numlote_ant;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMLOTE_ANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pcmovendpend_Numlote_Ant
        {
            get { return  pcmovendpend_numlote_ant; }
            set {  pcmovendpend_numlote_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMOS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numos;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Numos
        {
            get { return  pcmovendpend_numos; }
            set {  pcmovendpend_numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMPED
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numped;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Numped
        {
            get { return  pcmovendpend_numped; }
            set {  pcmovendpend_numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numseq;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Numseq
        {
            get { return  pcmovendpend_numseq; }
            set {  pcmovendpend_numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMSEQENTREGA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numseqentrega;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMSEQENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Numseqentrega
        {
            get { return  pcmovendpend_numseqentrega; }
            set {  pcmovendpend_numseqentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMSEQMONTAGEM
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numseqmontagem;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMSEQMONTAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pcmovendpend_Numseqmontagem
        {
            get { return  pcmovendpend_numseqmontagem; }
            set {  pcmovendpend_numseqmontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMSEQSEPARACAO
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numseqseparacao;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMSEQSEPARACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pcmovendpend_Numseqseparacao
        {
            get { return  pcmovendpend_numseqseparacao; }
            set {  pcmovendpend_numseqseparacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMTRANSENT
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numtransent;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Numtransent
        {
            get { return  pcmovendpend_numtransent; }
            set {  pcmovendpend_numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMTRANSVENDA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numtransvenda;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Numtransvenda
        {
            get { return  pcmovendpend_numtransvenda; }
            set {  pcmovendpend_numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMTRANSWMS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numtranswms;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMTRANSWMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Numtranswms
        {
            get { return  pcmovendpend_numtranswms; }
            set {  pcmovendpend_numtranswms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMTRANSWMSORIG
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numtranswmsorig;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMTRANSWMSORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Numtranswmsorig
        {
            get { return  pcmovendpend_numtranswmsorig; }
            set {  pcmovendpend_numtranswmsorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMVOL
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numvol;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Numvol
        {
            get { return  pcmovendpend_numvol; }
            set {  pcmovendpend_numvol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMVOLAGRUPADOR
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numvolagrupador;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMVOLAGRUPADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pcmovendpend_Numvolagrupador
        {
            get { return  pcmovendpend_numvolagrupador; }
            set {  pcmovendpend_numvolagrupador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_NUMVOLPED
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_numvolped;
        [XmlElement(ElementName = "PCMOVENDPEND_NUMVOLPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pcmovendpend_Numvolped
        {
            get { return  pcmovendpend_numvolped; }
            set {  pcmovendpend_numvolped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_OBS
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_obs;
        [XmlElement(ElementName = "PCMOVENDPEND_OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Pcmovendpend_Obs
        {
            get { return  pcmovendpend_obs; }
            set {  pcmovendpend_obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_POSICAO
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_posicao;
        [XmlElement(ElementName = "PCMOVENDPEND_POSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcmovendpend_Posicao
        {
            get { return  pcmovendpend_posicao; }
            set {  pcmovendpend_posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_PULASEQCONF
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_pulaseqconf;
        [XmlElement(ElementName = "PCMOVENDPEND_PULASEQCONF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcmovendpend_Pulaseqconf
        {
            get { return  pcmovendpend_pulaseqconf; }
            set {  pcmovendpend_pulaseqconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QT
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qt;
        [XmlElement(ElementName = "PCMOVENDPEND_QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Qt
        {
            get { return  pcmovendpend_qt; }
            set {  pcmovendpend_qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QT_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qt_ant;
        [XmlElement(ElementName = "PCMOVENDPEND_QT_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Qt_Ant
        {
            get { return  pcmovendpend_qt_ant; }
            set {  pcmovendpend_qt_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTANTEST
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtantest;
        [XmlElement(ElementName = "PCMOVENDPEND_QTANTEST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pcmovendpend_Qtantest
        {
            get { return  pcmovendpend_qtantest; }
            set {  pcmovendpend_qtantest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTCONFERIDA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtconferida;
        [XmlElement(ElementName = "PCMOVENDPEND_QTCONFERIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcmovendpend_Qtconferida
        {
            get { return  pcmovendpend_qtconferida; }
            set {  pcmovendpend_qtconferida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTCX
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtcx;
        [XmlElement(ElementName = "PCMOVENDPEND_QTCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pcmovendpend_Qtcx
        {
            get { return  pcmovendpend_qtcx; }
            set {  pcmovendpend_qtcx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTCXORIG
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtcxorig;
        [XmlElement(ElementName = "PCMOVENDPEND_QTCXORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pcmovendpend_Qtcxorig
        {
            get { return  pcmovendpend_qtcxorig; }
            set {  pcmovendpend_qtcxorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTDEFALTAINF
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtdefaltainf;
        [XmlElement(ElementName = "PCMOVENDPEND_QTDEFALTAINF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Qtdefaltainf
        {
            get { return  pcmovendpend_qtdefaltainf; }
            set {  pcmovendpend_qtdefaltainf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTORIG
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtorig;
        [XmlElement(ElementName = "PCMOVENDPEND_QTORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Qtorig
        {
            get { return  pcmovendpend_qtorig; }
            set {  pcmovendpend_qtorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTPECAS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtpecas;
        [XmlElement(ElementName = "PCMOVENDPEND_QTPECAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Qtpecas
        {
            get { return  pcmovendpend_qtpecas; }
            set {  pcmovendpend_qtpecas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTPECASORIG
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtpecasorig;
        [XmlElement(ElementName = "PCMOVENDPEND_QTPECASORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Pcmovendpend_Qtpecasorig
        {
            get { return  pcmovendpend_qtpecasorig; }
            set {  pcmovendpend_qtpecasorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTRESERVADA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtreservada;
        [XmlElement(ElementName = "PCMOVENDPEND_QTRESERVADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Qtreservada
        {
            get { return  pcmovendpend_qtreservada; }
            set {  pcmovendpend_qtreservada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTRESERVADA_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtreservada_ant;
        [XmlElement(ElementName = "PCMOVENDPEND_QTRESERVADA_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Qtreservada_Ant
        {
            get { return  pcmovendpend_qtreservada_ant; }
            set {  pcmovendpend_qtreservada_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_QTSEPARADA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_qtseparada;
        [XmlElement(ElementName = "PCMOVENDPEND_QTSEPARADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcmovendpend_Qtseparada
        {
            get { return  pcmovendpend_qtseparada; }
            set {  pcmovendpend_qtseparada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_SEQCONF
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_seqconf;
        [XmlElement(ElementName = "PCMOVENDPEND_SEQCONF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcmovendpend_Seqconf
        {
            get { return  pcmovendpend_seqconf; }
            set {  pcmovendpend_seqconf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_SEQPALETE
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_seqpalete;
        [XmlElement(ElementName = "PCMOVENDPEND_SEQPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcmovendpend_Seqpalete
        {
            get { return  pcmovendpend_seqpalete; }
            set {  pcmovendpend_seqpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_SEQUMA
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_sequma;
        [XmlElement(ElementName = "PCMOVENDPEND_SEQUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Pcmovendpend_Sequma
        {
            get { return  pcmovendpend_sequma; }
            set {  pcmovendpend_sequma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_TIPOENDERECAMENTO
        /// Comentário: 
        /// </summary>
        private string pcmovendpend_tipoenderecamento;
        [XmlElement(ElementName = "PCMOVENDPEND_TIPOENDERECAMENTO", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcmovendpend_Tipoenderecamento
        {
            get { return  pcmovendpend_tipoenderecamento; }
            set {  pcmovendpend_tipoenderecamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCMOVENDPEND_TIPOOS
        /// Comentário: 
        /// </summary>
        private decimal pcmovendpend_tipoos;
        [XmlElement(ElementName = "PCMOVENDPEND_TIPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Pcmovendpend_Tipoos
        {
            get { return  pcmovendpend_tipoos; }
            set {  pcmovendpend_tipoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPARAMETROWMS_CODFILIAL
        /// Comentário: 
        /// </summary>
        private string pcparametrowms_codfilial;
        [XmlElement(ElementName = "PCPARAMETROWMS_CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcparametrowms_Codfilial
        {
            get { return  pcparametrowms_codfilial; }
            set {  pcparametrowms_codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPARAMETROWMS_DESCRICAO
        /// Comentário: 
        /// </summary>
        private string pcparametrowms_descricao;
        [XmlElement(ElementName = "PCPARAMETROWMS_DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Pcparametrowms_Descricao
        {
            get { return  pcparametrowms_descricao; }
            set {  pcparametrowms_descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPARAMETROWMS_NOME
        /// Comentário: 
        /// </summary>
        private string pcparametrowms_nome;
        [XmlElement(ElementName = "PCPARAMETROWMS_NOME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Pcparametrowms_Nome
        {
            get { return  pcparametrowms_nome; }
            set {  pcparametrowms_nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPARAMETROWMS_VALOR
        /// Comentário: 
        /// </summary>
        private string pcparametrowms_valor;
        [XmlElement(ElementName = "PCPARAMETROWMS_VALOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Pcparametrowms_Valor
        {
            get { return  pcparametrowms_valor; }
            set {  pcparametrowms_valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPARAMETROWMS_VALOR_ANT
        /// Comentário: 
        /// </summary>
        private string pcparametrowms_valor_ant;
        [XmlElement(ElementName = "PCPARAMETROWMS_VALOR_ANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Pcparametrowms_Valor_Ant
        {
            get { return  pcparametrowms_valor_ant; }
            set {  pcparametrowms_valor_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_CODCLI
        /// Comentário: 
        /// </summary>
        private decimal pcpedi_codcli;
        [XmlElement(ElementName = "PCPEDI_CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcpedi_Codcli
        {
            get { return  pcpedi_codcli; }
            set {  pcpedi_codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_CODFILIALRETIRA
        /// Comentário: 
        /// </summary>
        private string pcpedi_codfilialretira;
        [XmlElement(ElementName = "PCPEDI_CODFILIALRETIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcpedi_Codfilialretira
        {
            get { return  pcpedi_codfilialretira; }
            set {  pcpedi_codfilialretira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcpedi_codprod;
        [XmlElement(ElementName = "PCPEDI_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcpedi_Codprod
        {
            get { return  pcpedi_codprod; }
            set {  pcpedi_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_NUMCAR
        /// Comentário: 
        /// </summary>
        private decimal pcpedi_numcar;
        [XmlElement(ElementName = "PCPEDI_NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcpedi_Numcar
        {
            get { return  pcpedi_numcar; }
            set {  pcpedi_numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pcpedi_numlote;
        [XmlElement(ElementName = "PCPEDI_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pcpedi_Numlote
        {
            get { return  pcpedi_numlote; }
            set {  pcpedi_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_NUMLOTE_ANT
        /// Comentário: 
        /// </summary>
        private string pcpedi_numlote_ant;
        [XmlElement(ElementName = "PCPEDI_NUMLOTE_ANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Pcpedi_Numlote_Ant
        {
            get { return  pcpedi_numlote_ant; }
            set {  pcpedi_numlote_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_NUMPED
        /// Comentário: 
        /// </summary>
        private decimal pcpedi_numped;
        [XmlElement(ElementName = "PCPEDI_NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcpedi_Numped
        {
            get { return  pcpedi_numped; }
            set {  pcpedi_numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_POSICAO
        /// Comentário: 
        /// </summary>
        private string pcpedi_posicao;
        [XmlElement(ElementName = "PCPEDI_POSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcpedi_Posicao
        {
            get { return  pcpedi_posicao; }
            set {  pcpedi_posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_PVENDA
        /// Comentário: 
        /// </summary>
        private decimal pcpedi_pvenda;
        [XmlElement(ElementName = "PCPEDI_PVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pcpedi_Pvenda
        {
            get { return  pcpedi_pvenda; }
            set {  pcpedi_pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_QT
        /// Comentário: 
        /// </summary>
        private decimal pcpedi_qt;
        [XmlElement(ElementName = "PCPEDI_QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcpedi_Qt
        {
            get { return  pcpedi_qt; }
            set {  pcpedi_qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPEDI_QT_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcpedi_qt_ant;
        [XmlElement(ElementName = "PCPEDI_QT_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Pcpedi_Qt_Ant
        {
            get { return  pcpedi_qt_ant; }
            set {  pcpedi_qt_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_CAPACIDADE
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_capacidade;
        [XmlElement(ElementName = "PCPRODUTPICKING_CAPACIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcprodutpicking_Capacidade
        {
            get { return  pcprodutpicking_capacidade; }
            set {  pcprodutpicking_capacidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_CAPACIDADE_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_capacidade_ant;
        [XmlElement(ElementName = "PCPRODUTPICKING_CAPACIDADE_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcprodutpicking_Capacidade_Ant
        {
            get { return  pcprodutpicking_capacidade_ant; }
            set {  pcprodutpicking_capacidade_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_CODENDERECO
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_codendereco;
        [XmlElement(ElementName = "PCPRODUTPICKING_CODENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pcprodutpicking_Codendereco
        {
            get { return  pcprodutpicking_codendereco; }
            set {  pcprodutpicking_codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_CODFILIAL
        /// Comentário: 
        /// </summary>
        private string pcprodutpicking_codfilial;
        [XmlElement(ElementName = "PCPRODUTPICKING_CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Pcprodutpicking_Codfilial
        {
            get { return  pcprodutpicking_codfilial; }
            set {  pcprodutpicking_codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_codprod;
        [XmlElement(ElementName = "PCPRODUTPICKING_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcprodutpicking_Codprod
        {
            get { return  pcprodutpicking_codprod; }
            set {  pcprodutpicking_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_CODPROD_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_codprod_ant;
        [XmlElement(ElementName = "PCPRODUTPICKING_CODPROD_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcprodutpicking_Codprod_Ant
        {
            get { return  pcprodutpicking_codprod_ant; }
            set {  pcprodutpicking_codprod_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_PONTOREP_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_pontorep_ant;
        [XmlElement(ElementName = "PCPRODUTPICKING_PONTOREP_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcprodutpicking_Pontorep_Ant
        {
            get { return  pcprodutpicking_pontorep_ant; }
            set {  pcprodutpicking_pontorep_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_PONTOREPOSICAO
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_pontoreposicao;
        [XmlElement(ElementName = "PCPRODUTPICKING_PONTOREPOSICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcprodutpicking_Pontoreposicao
        {
            get { return  pcprodutpicking_pontoreposicao; }
            set {  pcprodutpicking_pontoreposicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_TIPO
        /// Comentário: 
        /// </summary>
        private string pcprodutpicking_tipo;
        [XmlElement(ElementName = "PCPRODUTPICKING_TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcprodutpicking_Tipo
        {
            get { return  pcprodutpicking_tipo; }
            set {  pcprodutpicking_tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_TIPO_ANT
        /// Comentário: 
        /// </summary>
        private string pcprodutpicking_tipo_ant;
        [XmlElement(ElementName = "PCPRODUTPICKING_TIPO_ANT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pcprodutpicking_Tipo_Ant
        {
            get { return  pcprodutpicking_tipo_ant; }
            set {  pcprodutpicking_tipo_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_TIPOEND_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_tipoend_ant;
        [XmlElement(ElementName = "PCPRODUTPICKING_TIPOEND_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pcprodutpicking_Tipoend_Ant
        {
            get { return  pcprodutpicking_tipoend_ant; }
            set {  pcprodutpicking_tipoend_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_TIPOENDERECO
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_tipoendereco;
        [XmlElement(ElementName = "PCPRODUTPICKING_TIPOENDERECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Pcprodutpicking_Tipoendereco
        {
            get { return  pcprodutpicking_tipoendereco; }
            set {  pcprodutpicking_tipoendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_TIPOEST_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_tipoest_ant;
        [XmlElement(ElementName = "PCPRODUTPICKING_TIPOEST_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Pcprodutpicking_Tipoest_Ant
        {
            get { return  pcprodutpicking_tipoest_ant; }
            set {  pcprodutpicking_tipoest_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCPRODUTPICKING_TIPOESTRUTURA
        /// Comentário: 
        /// </summary>
        private decimal pcprodutpicking_tipoestrutura;
        [XmlElement(ElementName = "PCPRODUTPICKING_TIPOESTRUTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Pcprodutpicking_Tipoestrutura
        {
            get { return  pcprodutpicking_tipoestrutura; }
            set {  pcprodutpicking_tipoestrutura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCVOLUMEOSI_CODPROD
        /// Comentário: 
        /// </summary>
        private decimal pcvolumeosi_codprod;
        [XmlElement(ElementName = "PCVOLUMEOSI_CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pcvolumeosi_Codprod
        {
            get { return  pcvolumeosi_codprod; }
            set {  pcvolumeosi_codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCVOLUMEOSI_NUMLOTE
        /// Comentário: 
        /// </summary>
        private string pcvolumeosi_numlote;
        [XmlElement(ElementName = "PCVOLUMEOSI_NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Pcvolumeosi_Numlote
        {
            get { return  pcvolumeosi_numlote; }
            set {  pcvolumeosi_numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCVOLUMEOSI_NUMOS
        /// Comentário: 
        /// </summary>
        private decimal pcvolumeosi_numos;
        [XmlElement(ElementName = "PCVOLUMEOSI_NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pcvolumeosi_Numos
        {
            get { return  pcvolumeosi_numos; }
            set {  pcvolumeosi_numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCVOLUMEOSI_NUMVOL
        /// Comentário: 
        /// </summary>
        private decimal pcvolumeosi_numvol;
        [XmlElement(ElementName = "PCVOLUMEOSI_NUMVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcvolumeosi_Numvol
        {
            get { return  pcvolumeosi_numvol; }
            set {  pcvolumeosi_numvol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCVOLUMEOSI_NUMVOL_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcvolumeosi_numvol_ant;
        [XmlElement(ElementName = "PCVOLUMEOSI_NUMVOL_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcvolumeosi_Numvol_Ant
        {
            get { return  pcvolumeosi_numvol_ant; }
            set {  pcvolumeosi_numvol_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCVOLUMEOSI_QTSEPARADA
        /// Comentário: 
        /// </summary>
        private decimal pcvolumeosi_qtseparada;
        [XmlElement(ElementName = "PCVOLUMEOSI_QTSEPARADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pcvolumeosi_Qtseparada
        {
            get { return  pcvolumeosi_qtseparada; }
            set {  pcvolumeosi_qtseparada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCVOLUMEOSI_QTSEPARADA_ANT
        /// Comentário: 
        /// </summary>
        private decimal pcvolumeosi_qtseparada_ant;
        [XmlElement(ElementName = "PCVOLUMEOSI_QTSEPARADA_ANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Pcvolumeosi_Qtseparada_Ant
        {
            get { return  pcvolumeosi_qtseparada_ant; }
            set {  pcvolumeosi_qtseparada_ant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROGRAMA
        /// Comentário: 
        /// </summary>
        private string programa;
        [XmlElement(ElementName = "PROGRAMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Programa
        {
            get { return  programa; }
            set {  programa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQUENCIA
        /// Comentário: 
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TABELA
        /// Comentário: 
        /// </summary>
        private string tabela;
        [XmlElement(ElementName = "TABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Tabela
        {
            get { return  tabela; }
            set {  tabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRIGGER_DISPARADA
        /// Comentário: 
        /// </summary>
        private string trigger_disparada;
        [XmlElement(ElementName = "TRIGGER_DISPARADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Trigger_Disparada
        {
            get { return  trigger_disparada; }
            set {  trigger_disparada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO_DB
        /// Comentário: 
        /// </summary>
        private string usuario_db;
        [XmlElement(ElementName = "USUARIO_DB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Usuario_Db
        {
            get { return  usuario_db; }
            set {  usuario_db = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO_OS
        /// Comentário: 
        /// </summary>
        private string usuario_os;
        [XmlElement(ElementName = "USUARIO_OS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Usuario_Os
        {
            get { return  usuario_os; }
            set {  usuario_os = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmslogfinalizacaoos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSLOGFINALIZACAOOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmslogfinalizacaoos> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmslogfinalizacaoos.GetStringConnection());
            return ba.Listar<PCWmslogfinalizacaoos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmslogfinalizacaoos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmslogfinalizacaoos.GetStringConnection());
            return ba.Existe<PCWmslogfinalizacaoos>(where);
        }

        #endregion
    }
}
