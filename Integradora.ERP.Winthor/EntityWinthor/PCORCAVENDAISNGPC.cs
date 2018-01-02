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
    /// Classe referente a tabela PCOrcavendaisngpc
    /// </summary>
    [XmlType("PCORCAVENDAISNGPC")]
    public class PCOrcavendaisngpc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�DIGO PRODUTO.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPODOCUM
        /// Coment�rio: C�DIGO TIPO DE DOCUMENTO DO COMPRADOR.
        /// </summary>
        private decimal codtipodocum;
        [XmlElement(ElementName = "CODTIPODOCUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codtipodocum
        {
            get { return  codtipodocum; }
            set {  codtipodocum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPFCOMPR
        /// Coment�rio: CPF DO COMPRADOR.
        /// </summary>
        private string cpfcompr;
        [XmlElement(ElementName = "CPFCOMPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cpfcompr
        {
            get { return  cpfcompr; }
            set {  cpfcompr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPRESCRICAO
        /// Coment�rio: DATA DA PRESCRI��O.
        /// </summary>
        private DateTime? dtprescricao;
        [XmlElement(ElementName = "DTPRESCRICAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprescricao
        {
            get { return  dtprescricao; }
            set {  dtprescricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECOMPR
        /// Coment�rio: NOME COMPRADOR.
        /// </summary>
        private string nomecompr;
        [XmlElement(ElementName = "NOMECOMPR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomecompr
        {
            get { return  nomecompr; }
            set {  nomecompr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDOCUM
        /// Coment�rio: N�MERO DO DOCUMENTO DO COMPRADOR.
        /// </summary>
        private string numdocum;
        [XmlElement(ElementName = "NUMDOCUM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numdocum
        {
            get { return  numdocum; }
            set {  numdocum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTIFMED
        /// Coment�rio: N�MERO DA NOTIFICA��O DE MEDICAMENTO.
        /// </summary>
        private string numnotifmed;
        [XmlElement(ElementName = "NUMNOTIFMED", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Numnotifmed
        {
            get { return  numnotifmed; }
            set {  numnotifmed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMORCA
        /// Coment�rio: N�MERO OR�AMENTO.
        /// </summary>
        private decimal numorca;
        [XmlElement(ElementName = "NUMORCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numorca
        {
            get { return  numorca; }
            set {  numorca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGPROF
        /// Coment�rio: N�MERO DO REGISTRO PROFISSIONAL DO PRESCRITOR.
        /// </summary>
        private string numregprof;
        [XmlElement(ElementName = "NUMREGPROF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numregprof
        {
            get { return  numregprof; }
            set {  numregprof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: N�MERO SEQUENCIA.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: RELACIONAMENTO COM A PCNFSAID.
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
        /// Propriedade referente ao campo: QTHORAS
        /// Coment�rio: QUANTIDADE DE HORAS A REPETIR A POSOLOGIA.
        /// </summary>
        private decimal qthoras;
        [XmlElement(ElementName = "QTHORAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qthoras
        {
            get { return  qthoras; }
            set {  qthoras = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPOSOLOGIA
        /// Coment�rio: QUANTIDADE POSOLOGIA NA RECEITA M�DICA.
        /// </summary>
        private decimal qtposologia;
        [XmlElement(ElementName = "QTPOSOLOGIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtposologia
        {
            get { return  qtposologia; }
            set {  qtposologia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONSPROF
        /// Coment�rio: CONSELHO PROFISSIONAL DO PRESCRITOR.
        /// </summary>
        private string tipoconsprof;
        [XmlElement(ElementName = "TIPOCONSPROF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Tipoconsprof
        {
            get { return  tipoconsprof; }
            set {  tipoconsprof = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOORGAOEXP
        /// Coment�rio: ORG�O EXPEDIDOR DO DOCUMENTO DO COMPRADOR.
        /// </summary>
        private string tipoorgaoexp;
        [XmlElement(ElementName = "TIPOORGAOEXP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Tipoorgaoexp
        {
            get { return  tipoorgaoexp; }
            set {  tipoorgaoexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRANSACAO
        /// Coment�rio: TIPO DA TRANSA��O SNGPC.
        /// </summary>
        private string tipotransacao;
        [XmlElement(ElementName = "TIPOTRANSACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipotransacao
        {
            get { return  tipotransacao; }
            set {  tipotransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFDOCUM
        /// Coment�rio: UF EMISS�O DO DOCUMENTO COMPRADOR.
        /// </summary>
        private string ufdocum;
        [XmlElement(ElementName = "UFDOCUM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufdocum
        {
            get { return  ufdocum; }
            set {  ufdocum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADE
        /// Coment�rio: RELACIONAMENTO COM PCUNIDADE.
        /// </summary>
        private string unidade;
        [XmlElement(ElementName = "UNIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidade
        {
            get { return  unidade; }
            set {  unidade = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOrcavendaisngpc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORCAVENDAISNGPC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOrcavendaisngpc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrcavendaisngpc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOrcavendaisngpc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrcavendaisngpc>(where);
        }

        #endregion
    }
}
