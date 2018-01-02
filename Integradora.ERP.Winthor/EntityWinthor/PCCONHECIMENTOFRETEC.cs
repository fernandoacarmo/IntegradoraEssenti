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
    /// Classe referente a tabela PCConhecimentofretec
    /// </summary>
    [XmlType("PCCONHECIMENTOFRETEC")]
    public class PCConhecimentofretec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BASEICMS
        /// Coment�rio: Valor de base de ICMS. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal baseicms;
        [XmlElement(ElementName = "BASEICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Baseicms
        {
            get { return  baseicms; }
            set {  baseicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONSIGNATARIO
        /// Coment�rio: C�digo do consignat�rio do conhecimento de frete (transportadora). |Campo do tipo num�rico, de tamanho 6.
        /// </summary>
        private decimal codconsignatario;
        [XmlElement(ElementName = "CODCONSIGNATARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codconsignatario
        {
            get { return  codconsignatario; }
            set {  codconsignatario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESTINATARIO
        /// Coment�rio: C�digo do destinat�rio do conhecimento de frete. |Campo do tipo num�rico, de tamanho 6.
        /// </summary>
        private decimal coddestinatario;
        [XmlElement(ElementName = "CODDESTINATARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddestinatario
        {
            get { return  coddestinatario; }
            set {  coddestinatario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial. |Campo do tipo caracter, de tamanho 2.
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
        /// Propriedade referente ao campo: CODFISCAL
        /// Coment�rio: C�digo fiscal do conhecimento. |Campo do tipo num�rico, de tamanho 8.
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFRETE
        /// Coment�rio: C�digo do frete (rota de entrega) do conhecimento de frete. |Campo do tipo num�rico, de tamanho 6.
        /// </summary>
        private decimal codfrete;
        [XmlElement(ElementName = "CODFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfrete
        {
            get { return  codfrete; }
            set {  codfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Coment�rio: C�digo do funcion�rio que realizou a exclus�o do conhecimento.|Campo do tipo num�rico, de tamanho 6.
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFATUR
        /// Coment�rio: C�digo do funcion�rio que realizou o faturamento do conhecimento.|Campo do tipo num�rico, de tamanho 6.
        /// </summary>
        private decimal codfuncfatur;
        [XmlElement(ElementName = "CODFUNCFATUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncfatur
        {
            get { return  codfuncfatur; }
            set {  codfuncfatur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: C�digo do motorista do conhecimento de frete. |Campo do tipo num�rico, de tamanho 8.
        /// </summary>
        private decimal codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREMETENTE
        /// Coment�rio: C�digo do remetente do conhecimento de frete. |Campo do tipo num�rico, de tamanho 6.
        /// </summary>
        private decimal codremetente;
        [XmlElement(ElementName = "CODREMETENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codremetente
        {
            get { return  codremetente; }
            set {  codremetente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Coment�rio: C�digo do ve�culo do conhecimento de frete. |Campo do tipo num�rico, de tamanho 4.
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Coment�rio: Data de emiss�o do conhecimento. |Campo do tipo data
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
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Data e hora de exclus�o do conhecimento. |Campo do tipo data.
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
        /// Propriedade referente ao campo: DTFATUR
        /// Coment�rio: Data e hora de faturamento do conhecimento. |Campo do tipo data.
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
        /// Propriedade referente ao campo: DTFATURAMENTO
        /// Coment�rio: Data de faturamento do conhecimento. |Campo do tipo data.
        /// </summary>
        private DateTime? dtfaturamento;
        [XmlElement(ElementName = "DTFATURAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfaturamento
        {
            get { return  dtfaturamento; }
            set {  dtfaturamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIE
        /// Coment�rio: Esp�cie da Carga. |Campo do tipo caracter, de tamanho 2.
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONHEC
        /// Coment�rio: N�mero do conhecimento de frete. N�mero sequencial, buscado do cadastro de filial. |Campo do tipo num�rico, de tamanho 6.
        /// </summary>
        private decimal numconhec;
        [XmlElement(ElementName = "NUMCONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numconhec
        {
            get { return  numconhec; }
            set {  numconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORDEMCOLETA
        /// Coment�rio: N�mero da Ordem de coleta. N�mero sequencial, buscado do cadastro de filial. |Campo do tipo num�rico, de tamanho 8.
        /// </summary>
        private decimal numordemcoleta;
        [XmlElement(ElementName = "NUMORDEMCOLETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numordemcoleta
        {
            get { return  numordemcoleta; }
            set {  numordemcoleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSCONHEC
        /// Coment�rio: N�mero da transa��o do conhecimento do frete. N�mero sequencial, buscado do cadastro de filial. |Campo do tipo num�rico, de tamanho 10.
        /// </summary>
        private decimal numtransconhec;
        [XmlElement(ElementName = "NUMTRANSCONHEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransconhec
        {
            get { return  numtransconhec; }
            set {  numtransconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o para emitir no conhecimento de frete. |Campo do tipo caracter, de tamanho 100.
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
        /// Propriedade referente ao campo: PERCICM
        /// Coment�rio: Valor dp percentual de ICMS. |Campo do tipo num�rico, de tamanho 10, com 2 decimais.
        /// </summary>
        private decimal percicm;
        [XmlElement(ElementName = "PERCICM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percicm
        {
            get { return  percicm; }
            set {  percicm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOTOTAL
        /// Coment�rio: Peso total do conhecimento. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal pesototal;
        [XmlElement(ElementName = "PESOTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesototal
        {
            get { return  pesototal; }
            set {  pesototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Coment�rio: S�rie do Conhecinento. |Campo do tipo caracter, de tamanho 2.
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Coment�rio: Tipo de frete CIF (pago pelo remetente) ou FOB (pago pelo destinat�rio). |Campo do tipo caracter, de tamanho 3.
        /// </summary>
        private string tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPACHO
        /// Coment�rio: Valor de despesa de despacho. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vldespacho;
        [XmlElement(ElementName = "VLDESPACHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vldespacho
        {
            get { return  vldespacho; }
            set {  vldespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Coment�rio: Valor do frete. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLTR
        /// Coment�rio: Valor de despesa de LTR. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vlltr;
        [XmlElement(ElementName = "VLLTR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlltr
        {
            get { return  vlltr; }
            set {  vlltr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTROS
        /// Coment�rio: Valor de despesa de outras despesas. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vloutros;
        [XmlElement(ElementName = "VLOUTROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vloutros
        {
            get { return  vloutros; }
            set {  vloutros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPEDAGIO
        /// Coment�rio: Valor de despesa do ped�gio. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vlpedagio;
        [XmlElement(ElementName = "VLPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpedagio
        {
            get { return  vlpedagio; }
            set {  vlpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSECCAT
        /// Coment�rio: Valor de despesa com escolta. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vlseccat;
        [XmlElement(ElementName = "VLSECCAT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlseccat
        {
            get { return  vlseccat; }
            set {  vlseccat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Coment�rio: Valor de despesa de seguro da carga. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALCONHEC
        /// Coment�rio: Valor do conhecimento de frete. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vltotalconhec;
        [XmlElement(ElementName = "VLTOTALCONHEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotalconhec
        {
            get { return  vltotalconhec; }
            set {  vltotalconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUMETOTAL
        /// Coment�rio: Volume total do conhecimento. |Campo do tipo num�rico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal volumetotal;
        [XmlElement(ElementName = "VOLUMETOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Volumetotal
        {
            get { return  volumetotal; }
            set {  volumetotal = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCConhecimentofretec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONHECIMENTOFRETEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCConhecimentofretec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConhecimentofretec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCConhecimentofretec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConhecimentofretec>(where);
        }

        #endregion
    }
}
