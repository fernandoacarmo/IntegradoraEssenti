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
    /// Classe referente a tabela PCComrca
    /// </summary>
    [XmlType("PCCOMRCA")]
    public class PCComrca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOMISSAOAGRUPADA
        /// Coment�rio: Id da comiss�o agrupada
        /// </summary>
        private decimal codcomissaoagrupada;
        [XmlElement(ElementName = "CODCOMISSAOAGRUPADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcomissaoagrupada
        {
            get { return  codcomissaoagrupada; }
            set {  codcomissaoagrupada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAGERENCIAL
        /// Coment�rio: C�digo da conta gerencial.
        /// </summary>
        private decimal codcontagerencial;
        [XmlElement(ElementName = "CODCONTAGERENCIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontagerencial
        {
            get { return  codcontagerencial; }
            set {  codcontagerencial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALT
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncalt;
        [XmlElement(ElementName = "CODFUNCALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncalt
        {
            get { return  codfuncalt; }
            set {  codfuncalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Coment�rio: Indica o c�digo da rotina que a comiss�o foi gerada.
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Coment�rio: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOAGRUPADA
        /// Coment�rio: Identifica se � para usar comiss�o agrupada
        /// </summary>
        private string comissaoagrupada;
        [XmlElement(ElementName = "COMISSAOAGRUPADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comissaoagrupada
        {
            get { return  comissaoagrupada; }
            set {  comissaoagrupada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOEXPORTADA
        /// Coment�rio: Comiss�o exportada.
        /// </summary>
        private string comissaoexportada;
        [XmlElement(ElementName = "COMISSAOEXPORTADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comissaoexportada
        {
            get { return  comissaoexportada; }
            set {  comissaoexportada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTROLADORM
        /// Coment�rio: Controlado pelo RM.
        /// </summary>
        private string controladorm;
        [XmlElement(ElementName = "CONTROLADORM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Controladorm
        {
            get { return  controladorm; }
            set {  controladorm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIOCOMISSAOLIQUIDEZ
        /// Coment�rio: Crit�rio de apura��o da comiss�o por liquidez
        /// </summary>
        private string criteriocomissaoliquidez;
        [XmlElement(ElementName = "CRITERIOCOMISSAOLIQUIDEZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Criteriocomissaoliquidez
        {
            get { return  criteriocomissaoliquidez; }
            set {  criteriocomissaoliquidez = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFIM
        /// Coment�rio: 
        /// </summary>
        private DateTime? datafim;
        [XmlElement(ElementName = "DATAFIM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datafim
        {
            get { return  datafim; }
            set {  datafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIO
        /// Coment�rio: 
        /// </summary>
        private DateTime? datainicio;
        [XmlElement(ElementName = "DATAINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datainicio
        {
            get { return  datainicio; }
            set {  datainicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCOMPETENCIAFOLHA
        /// Coment�rio: Data compet�ncia folha.
        /// </summary>
        private DateTime? dtcompetenciafolha;
        [XmlElement(ElementName = "DTCOMPETENCIAFOLHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcompetenciafolha
        {
            get { return  dtcompetenciafolha; }
            set {  dtcompetenciafolha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtfecha;
        [XmlElement(ElementName = "DTFECHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecha
        {
            get { return  dtfecha; }
            set {  dtfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANS
        /// Coment�rio: 
        /// </summary>
        private decimal numtrans;
        [XmlElement(ElementName = "NUMTRANS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numtrans
        {
            get { return  numtrans; }
            set {  numtrans = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMISSAORATEADA
        /// Coment�rio: Campo corresponde ao percentual da comiss�o rateada por RCA/Operador.
        /// </summary>
        private decimal perccomissaorateada;
        [XmlElement(ElementName = "PERCCOMISSAORATEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perccomissaorateada
        {
            get { return  perccomissaorateada; }
            set {  perccomissaorateada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOM
        /// Coment�rio: 
        /// </summary>
        private decimal percom;
        [XmlElement(ElementName = "PERCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percom
        {
            get { return  percom; }
            set {  percom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMORIG
        /// Coment�rio: 
        /// </summary>
        private decimal percomorig;
        [XmlElement(ElementName = "PERCOMORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percomorig
        {
            get { return  percomorig; }
            set {  percomorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMPAG
        /// Coment�rio: 
        /// </summary>
        private decimal percompag;
        [XmlElement(ElementName = "PERCOMPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percompag
        {
            get { return  percompag; }
            set {  percompag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERPAGCOM
        /// Coment�rio: 
        /// </summary>
        private decimal perpagcom;
        [XmlElement(ElementName = "PERPAGCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perpagcom
        {
            get { return  perpagcom; }
            set {  perpagcom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTNF
        /// Coment�rio: 
        /// </summary>
        private decimal qtnf;
        [XmlElement(ElementName = "QTNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtnf
        {
            get { return  qtnf; }
            set {  qtnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM_PCCORREN
        /// Coment�rio: Campo corresponde ao n�mero do vale lan�ado ao realizar o fechamento da comiss�o.
        /// </summary>
        private decimal recnum_pccorren;
        [XmlElement(ElementName = "RECNUM_PCCORREN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnum_Pccorren
        {
            get { return  recnum_pccorren; }
            set {  recnum_pccorren = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM_PCCORREN_ADIANT
        /// Coment�rio: Este campo corresponde ao n�mero do vale lan�ado.
        /// </summary>
        private decimal recnum_pccorren_adiant;
        [XmlElement(ElementName = "RECNUM_PCCORREN_ADIANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnum_Pccorren_Adiant
        {
            get { return  recnum_pccorren_adiant; }
            set {  recnum_pccorren_adiant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM_PCLANC
        /// Coment�rio: Campo corresponde ao n�mero do contas a pagar lan�ado ao realizar o fechamento da comiss�o.
        /// </summary>
        private decimal recnum_pclanc;
        [XmlElement(ElementName = "RECNUM_PCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnum_Pclanc
        {
            get { return  recnum_pclanc; }
            set {  recnum_pclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: TIPOCOMISSAORATEADA
        /// Coment�rio: Campo corresponde a qual percentual de rateio foi considerado, o informado na tela ou o cadastrado para o RCA.
        /// </summary>
        private decimal tipocomissaorateada;
        [XmlElement(ElementName = "TIPOCOMISSAORATEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipocomissaorateada
        {
            get { return  tipocomissaorateada; }
            set {  tipocomissaorateada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFUNCCOMISSAORATEADA
        /// Coment�rio: Campo corresponde a qual tipo de funcionario a comiss�o corresponde RCA ou Operador.
        /// </summary>
        private string tipofunccomissaorateada;
        [XmlElement(ElementName = "TIPOFUNCCOMISSAORATEADA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Tipofunccomissaorateada
        {
            get { return  tipofunccomissaorateada; }
            set {  tipofunccomissaorateada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPERIODO
        /// Coment�rio: Indica o tipo de per�odo informado na 1266: Faturamento ou Fechamento.
        /// </summary>
        private string tipoperiodo;
        [XmlElement(ElementName = "TIPOPERIODO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Tipoperiodo
        {
            get { return  tipoperiodo; }
            set {  tipoperiodo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPREPCOMISSAO
        /// Coment�rio: Tipo de comissao L - liquidez   F - faturamento
        /// </summary>
        private string tipoprepcomissao;
        [XmlElement(ElementName = "TIPOPREPCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprepcomissao
        {
            get { return  tipoprepcomissao; }
            set {  tipoprepcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALORCOMISSAO
        /// Coment�rio: Este campo corresponde ao tipo de valor recebido ultilizado no c�lculo para gerar a comiss�o.
        /// </summary>
        private string tipovalorcomissao;
        [XmlElement(ElementName = "TIPOVALORCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipovalorcomissao
        {
            get { return  tipovalorcomissao; }
            set {  tipovalorcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCOFINS
        /// Coment�rio: Valor do COFINS sobre a comiss�o.
        /// </summary>
        private decimal valorcofins;
        [XmlElement(ElementName = "VALORCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorcofins
        {
            get { return  valorcofins; }
            set {  valorcofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCSRF
        /// Coment�rio: Valor do CSRF sobre a comiss�o.
        /// </summary>
        private decimal valorcsrf;
        [XmlElement(ElementName = "VALORCSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorcsrf
        {
            get { return  valorcsrf; }
            set {  valorcsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORINSS
        /// Coment�rio: Valor do imposto INSS sobre a comiss�o.
        /// </summary>
        private decimal valorinss;
        [XmlElement(ElementName = "VALORINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorinss
        {
            get { return  valorinss; }
            set {  valorinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORIRRF
        /// Coment�rio: Valor do imposto de renda sobre a comiss�o.
        /// </summary>
        private decimal valorirrf;
        [XmlElement(ElementName = "VALORIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorirrf
        {
            get { return  valorirrf; }
            set {  valorirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORISS
        /// Coment�rio: Valor do imposto ISS sobre a comiss�o.
        /// </summary>
        private decimal valoriss;
        [XmlElement(ElementName = "VALORISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valoriss
        {
            get { return  valoriss; }
            set {  valoriss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPIS
        /// Coment�rio: Valor do PIS sobre a comiss�o.
        /// </summary>
        private decimal valorpis;
        [XmlElement(ElementName = "VALORPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorpis
        {
            get { return  valorpis; }
            set {  valorpis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTOTIMPOSTOS
        /// Coment�rio: Soma dos impostos para o c�lculo de comiss�o de venda.
        /// </summary>
        private decimal valortotimpostos;
        [XmlElement(ElementName = "VALORTOTIMPOSTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valortotimpostos
        {
            get { return  valortotimpostos; }
            set {  valortotimpostos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMISORIG
        /// Coment�rio: 
        /// </summary>
        private decimal vlcomisorig;
        [XmlElement(ElementName = "VLCOMISORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcomisorig
        {
            get { return  vlcomisorig; }
            set {  vlcomisorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMISSAO
        /// Coment�rio: 
        /// </summary>
        private decimal vlcomissao;
        [XmlElement(ElementName = "VLCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcomissao
        {
            get { return  vlcomissao; }
            set {  vlcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDEVOLUCAO
        /// Coment�rio: 
        /// </summary>
        private decimal vldevolucao;
        [XmlElement(ElementName = "VLDEVOLUCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldevolucao
        {
            get { return  vldevolucao; }
            set {  vldevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLESTORNODEVOL
        /// Coment�rio: 
        /// </summary>
        private decimal vlestornodevol;
        [XmlElement(ElementName = "VLESTORNODEVOL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlestornodevol
        {
            get { return  vlestornodevol; }
            set {  vlestornodevol = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVALE
        /// Coment�rio: 
        /// </summary>
        private decimal vlvale;
        [XmlElement(ElementName = "VLVALE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvale
        {
            get { return  vlvale; }
            set {  vlvale = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVALECONSIDERADOBC
        /// Coment�rio: Valor de vales considerados na base de c�lculo do imposto.
        /// </summary>
        private decimal vlvaleconsideradobc;
        [XmlElement(ElementName = "VLVALECONSIDERADOBC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvaleconsideradobc
        {
            get { return  vlvaleconsideradobc; }
            set {  vlvaleconsideradobc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVALOR
        /// Coment�rio: 
        /// </summary>
        private decimal vlvalor;
        [XmlElement(ElementName = "VLVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvalor
        {
            get { return  vlvalor; }
            set {  vlvalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal vlvenda;
        [XmlElement(ElementName = "VLVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvenda
        {
            get { return  vlvenda; }
            set {  vlvenda = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCComrca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMRCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCComrca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComrca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCComrca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComrca>(where);
        }

        #endregion
    }
}
