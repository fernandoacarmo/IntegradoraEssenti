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
    /// Classe referente a tabela PCComplementonfce
    /// </summary>
    [XmlType("PCCOMPLEMENTONFCE")]
    public class PCComplementonfce : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AMBIENTE
        /// Coment�rio: Ambiente emiss�o NFCe
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
        /// Propriedade referente ao campo: CHAVENFCE
        /// Coment�rio: Chave NFCe
        /// </summary>
        private string chavenfce;
        [XmlElement(ElementName = "CHAVENFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Chavenfce
        {
            get { return  chavenfce; }
            set {  chavenfce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Codigo Filial
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
        /// Propriedade referente ao campo: CODSTATUS
        /// Coment�rio: Codigo Status
        /// </summary>
        private decimal codstatus;
        [XmlElement(ElementName = "CODSTATUS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codstatus
        {
            get { return  codstatus; }
            set {  codstatus = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data
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
        /// Propriedade referente ao campo: DTHORAAUTORIZACAOSEFAZ
        /// Coment�rio: Data e hora de autorizacao
        /// </summary>
        private DateTime? dthoraautorizacaosefaz;
        [XmlElement(ElementName = "DTHORAAUTORIZACAOSEFAZ", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthoraautorizacaosefaz
        {
            get { return  dthoraautorizacaosefaz; }
            set {  dthoraautorizacaosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Coment�rio: Exportado
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM
        /// Coment�rio: Mensagem NFCe
        /// </summary>
        private string mensagem;
        [XmlElement(ElementName = "MENSAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Mensagem
        {
            get { return  mensagem; }
            set {  mensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: Numero do Caixa
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXAFISCAL
        /// Coment�rio: Num de Serie e Caixa Fiscal
        /// </summary>
        private decimal numcaixafiscal;
        [XmlElement(ElementName = "NUMCAIXAFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numcaixafiscal
        {
            get { return  numcaixafiscal; }
            set {  numcaixafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: Numero da Nota
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Coment�rio: Numerador ECF
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Coment�rio: Operacao do complemento
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROTOCOLONFCE
        /// Coment�rio: Protocolo autorizacao
        /// </summary>
        private string protocolonfce;
        [XmlElement(ElementName = "PROTOCOLONFCE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Protocolonfce
        {
            get { return  protocolonfce; }
            set {  protocolonfce = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCComplementonfce()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCOMPLEMENTONFCE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCComplementonfce> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCComplementonfce>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCComplementonfce> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCComplementonfce>(where);
        }

        #endregion
    }
}
