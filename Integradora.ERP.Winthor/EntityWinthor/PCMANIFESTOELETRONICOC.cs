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
    /// Classe referente a tabela PCManifestoeletronicoc
    /// </summary>
    [XmlType("PCMANIFESTOELETRONICOC")]
    public class PCManifestoeletronicoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTEMDFE
        /// Coment�rio: AMBIENTE DO MANIFESTO
        /// </summary>
        private string ambientemdfe;
        [XmlElement(ElementName = "AMBIENTEMDFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ambientemdfe
        {
            get { return  ambientemdfe; }
            set {  ambientemdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVEMDFE
        /// Coment�rio: CHAVE DE ACESSO DO MANIFESTO
        /// </summary>
        private string chavemdfe;
        [XmlElement(ElementName = "CHAVEMDFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Chavemdfe
        {
            get { return  chavemdfe; }
            set {  chavemdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADEENCERR
        /// Coment�rio: CODIGO DA CIDADE DE ENCERRAMENTO
        /// </summary>
        private decimal codcidadeencerr;
        [XmlElement(ElementName = "CODCIDADEENCERR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidadeencerr
        {
            get { return  codcidadeencerr; }
            set {  codcidadeencerr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: CODIGO DA FILIAL DO MANIFESTO
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
        /// Propriedade referente ao campo: CODFUNCCANC
        /// Coment�rio: CODIGO DO FUNCIONARIO QUE CANCELOU O MDF-E
        /// </summary>
        private decimal codfunccanc;
        [XmlElement(ElementName = "CODFUNCCANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccanc
        {
            get { return  codfunccanc; }
            set {  codfunccanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCENCER
        /// Coment�rio: CODIGO DO FUNCIONARIO QUE ENCERROU O MDF-E
        /// </summary>
        private decimal codfuncencer;
        [XmlElement(ElementName = "CODFUNCENCER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncencer
        {
            get { return  codfuncencer; }
            set {  codfuncencer = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCGER
        /// Coment�rio: CODIGO DO FUNCIONARIO QUE GEROU O MDF-E
        /// </summary>
        private decimal codfuncger;
        [XmlElement(ElementName = "CODFUNCGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncger
        {
            get { return  codfuncger; }
            set {  codfuncger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: CODIGO DO MOTORISTA DO MDF-E
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
        /// Propriedade referente ao campo: CODVEICULO
        /// Coment�rio: CODIGO DO VEICULO DO MDF-E
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
        /// Propriedade referente ao campo: CODVEICULO2
        /// Coment�rio: CODIGO DO SEGUNDO VEICULO DO MDF-E
        /// </summary>
        private decimal codveiculo2;
        [XmlElement(ElementName = "CODVEICULO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codveiculo2
        {
            get { return  codveiculo2; }
            set {  codveiculo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO3
        /// Coment�rio: CODIGO DO TERCEIRO VEICULO DO MDF-E
        /// </summary>
        private decimal codveiculo3;
        [XmlElement(ElementName = "CODVEICULO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codveiculo3
        {
            get { return  codveiculo3; }
            set {  codveiculo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORAAUTORSEFAZ
        /// Coment�rio: DATA E HORA DE AUTORIZA��O NA SEFAZ
        /// </summary>
        private DateTime? datahoraautorsefaz;
        [XmlElement(ElementName = "DATAHORAAUTORSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahoraautorsefaz
        {
            get { return  datahoraautorsefaz; }
            set {  datahoraautorsefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORAEVENTO
        /// Coment�rio: DATA E HORA DO EVENTO
        /// </summary>
        private DateTime? datahoraevento;
        [XmlElement(ElementName = "DATAHORAEVENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahoraevento
        {
            get { return  datahoraevento; }
            set {  datahoraevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAHORAGERACAO
        /// Coment�rio: DATA DO MANIFESTO
        /// </summary>
        private DateTime? datahorageracao;
        [XmlElement(ElementName = "DATAHORAGERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datahorageracao
        {
            get { return  datahorageracao; }
            set {  datahorageracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EVENTO
        /// Coment�rio: EVENTO GERADO PARA O MDF-E (E - ENCERRADO, C - CANCELADO)
        /// </summary>
        private string evento;
        [XmlElement(ElementName = "EVENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Evento
        {
            get { return  evento; }
            set {  evento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: JUSTIFICATIVACANCEL
        /// Coment�rio: JUSTIFICATIVA DE CANCELAMENTO
        /// </summary>
        private string justificativacancel;
        [XmlElement(ElementName = "JUSTIFICATIVACANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,256)]
        public string Justificativacancel
        {
            get { return  justificativacancel; }
            set {  justificativacancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: JUSTIFICATIVACONTING
        /// Coment�rio: JUSTIFICATIVA DA CONTINGENCIA
        /// </summary>
        private string justificativaconting;
        [XmlElement(ElementName = "JUSTIFICATIVACONTING", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,256)]
        public string Justificativaconting
        {
            get { return  justificativaconting; }
            set {  justificativaconting = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODALIDADETRANSPORTE
        /// Coment�rio: MODALIDADE DE TRANSPORTE NO MANIFESTO
        /// </summary>
        private string modalidadetransporte;
        [XmlElement(ElementName = "MODALIDADETRANSPORTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Modalidadetransporte
        {
            get { return  modalidadetransporte; }
            set {  modalidadetransporte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: NUMERO DO LOTE DO MANIFESTO
        /// </summary>
        private decimal numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMDFE
        /// Coment�rio: NUMERO DO MANIFESTO
        /// </summary>
        private decimal nummdfe;
        [XmlElement(ElementName = "NUMMDFE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Nummdfe
        {
            get { return  nummdfe; }
            set {  nummdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTENTATIVAENVIO
        /// Coment�rio: NUMERO DE TENTATIVAS DE ENVIO
        /// </summary>
        private decimal numtentativaenvio;
        [XmlElement(ElementName = "NUMTENTATIVAENVIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numtentativaenvio
        {
            get { return  numtentativaenvio; }
            set {  numtentativaenvio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Coment�rio: NUMERO DE TRANSA��O DO MANIFESTO
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIASIMPRESSAO
        /// Coment�rio: Quantidade de impress�o do MDF-e
        /// </summary>
        private decimal numviasimpressao;
        [XmlElement(ElementName = "NUMVIASIMPRESSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numviasimpressao
        {
            get { return  numviasimpressao; }
            set {  numviasimpressao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o do MDF-e
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOEVENTO
        /// Coment�rio: PROTOCOLO DO EVENTO
        /// </summary>
        private string protocoloevento;
        [XmlElement(ElementName = "PROTOCOLOEVENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Protocoloevento
        {
            get { return  protocoloevento; }
            set {  protocoloevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLOMDFE
        /// Coment�rio: NUMERO DE PROTOCOLO DO MANIFESTO
        /// </summary>
        private string protocolomdfe;
        [XmlElement(ElementName = "PROTOCOLOMDFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Protocolomdfe
        {
            get { return  protocolomdfe; }
            set {  protocolomdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECIBOMDFE
        /// Coment�rio: NUMERO DO RECIBO MDF-E
        /// </summary>
        private string recibomdfe;
        [XmlElement(ElementName = "RECIBOMDFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Recibomdfe
        {
            get { return  recibomdfe; }
            set {  recibomdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Coment�rio: SERIE DO MANIFESTO
        /// </summary>
        private decimal serie;
        [XmlElement(ElementName = "SERIE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAOMDFE
        /// Coment�rio: SITUACAO DO MANIFESTO
        /// </summary>
        private decimal situacaomdfe;
        [XmlElement(ElementName = "SITUACAOMDFE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Situacaomdfe
        {
            get { return  situacaomdfe; }
            set {  situacaomdfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMISSAO
        /// Coment�rio: TIPO DE EMISSAO DO MANIFESTO
        /// </summary>
        private decimal tipoemissao;
        [XmlElement(ElementName = "TIPOEMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipoemissao
        {
            get { return  tipoemissao; }
            set {  tipoemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEMITENTE
        /// Coment�rio: Tipo de Emitente
        /// </summary>
        private decimal tipoemitente;
        [XmlElement(ElementName = "TIPOEMITENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipoemitente
        {
            get { return  tipoemitente; }
            set {  tipoemitente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFFIM
        /// Coment�rio: UF FINAL DO MANIFESTO
        /// </summary>
        private string uffim;
        [XmlElement(ElementName = "UFFIM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uffim
        {
            get { return  uffim; }
            set {  uffim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFINICIO
        /// Coment�rio: UF DE INICIO DO MANIFESTO
        /// </summary>
        private string ufinicio;
        [XmlElement(ElementName = "UFINICIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufinicio
        {
            get { return  ufinicio; }
            set {  ufinicio = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCManifestoeletronicoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMANIFESTOELETRONICOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCManifestoeletronicoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCManifestoeletronicoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCManifestoeletronicoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCManifestoeletronicoc>(where);
        }

        #endregion
    }
}
