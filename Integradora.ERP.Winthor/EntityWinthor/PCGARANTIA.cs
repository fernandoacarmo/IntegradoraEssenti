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
    /// Classe referente a tabela PCGarantia
    /// </summary>
    [XmlType("PCGARANTIA")]
    public class PCGarantia : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAGARANTIA
        /// Coment�rio: Aceita Garantia
        /// </summary>
        private string aceitagarantia;
        [XmlElement(ElementName = "ACEITAGARANTIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitagarantia
        {
            get { return  aceitagarantia; }
            set {  aceitagarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AGUARDALAUDO
        /// Coment�rio: Aguarda Laudo
        /// </summary>
        private string aguardalaudo;
        [XmlElement(ElementName = "AGUARDALAUDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aguardalaudo
        {
            get { return  aguardalaudo; }
            set {  aguardalaudo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: Cliente envolvido na garantia.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALDEV
        /// Coment�rio: C�digo de Filial de Devolu��o
        /// </summary>
        private string codfilialdev;
        [XmlElement(ElementName = "CODFILIALDEV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialdev
        {
            get { return  codfilialdev; }
            set {  codfilialdev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do Fornecedor do Produto que Entrou no Processo de Garantia
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
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Produto envolvido na garantia.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENCERRAMENTO
        /// Coment�rio: Data de encerramento da garantia.
        /// </summary>
        private DateTime? dataencerramento;
        [XmlElement(ElementName = "DATAENCERRAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataencerramento
        {
            get { return  dataencerramento; }
            set {  dataencerramento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALANC
        /// Coment�rio: Data de lan�amento do registro.
        /// </summary>
        private DateTime? datalanc;
        [XmlElement(ElementName = "DATALANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datalanc
        {
            get { return  datalanc; }
            set {  datalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Data de exclus�o da garantia.
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
        /// Propriedade referente ao campo: NUMBONUS
        /// Coment�rio: N�mero do B�nus
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
        /// Propriedade referente ao campo: NUMCREDITO
        /// Coment�rio: N�mero de cr�dito gerado pela pe�a nova
        /// </summary>
        private decimal numcredito;
        [XmlElement(ElementName = "NUMCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcredito
        {
            get { return  numcredito; }
            set {  numcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGARANTIA
        /// Coment�rio: N�mero da garantia
        /// </summary>
        private decimal numgarantia;
        [XmlElement(ElementName = "NUMGARANTIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numgarantia
        {
            get { return  numgarantia; }
            set {  numgarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREMESSA
        /// Coment�rio: N�mero de remessa.
        /// </summary>
        private decimal numremessa;
        [XmlElement(ElementName = "NUMREMESSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numremessa
        {
            get { return  numremessa; }
            set {  numremessa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIE
        /// Coment�rio: N�mero de serie que identifica cada pe�a
        /// </summary>
        private string numserie;
        [XmlElement(ElementName = "NUMSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numserie
        {
            get { return  numserie; }
            set {  numserie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTDOCLIENTE
        /// Coment�rio: N�mero de transa��o de entrada p/Garantia do cliente
        /// </summary>
        private decimal numtransentdocliente;
        [XmlElement(ElementName = "NUMTRANSENTDOCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentdocliente
        {
            get { return  numtransentdocliente; }
            set {  numtransentdocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENTDOFORNEC
        /// Coment�rio: N�mero de transa��o de entrada ao Fornecedor
        /// </summary>
        private decimal numtransentdofornec;
        [XmlElement(ElementName = "NUMTRANSENTDOFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentdofornec
        {
            get { return  numtransentdofornec; }
            set {  numtransentdofornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSITEM
        /// Coment�rio: Chave estrangeira NUMTRANSITEM da PCMOV.
        /// </summary>
        private decimal numtransitem;
        [XmlElement(ElementName = "NUMTRANSITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransitem
        {
            get { return  numtransitem; }
            set {  numtransitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAAOCLIENTE
        /// Coment�rio: N�mero de transa��o de Venda ao cliente�
        /// </summary>
        private decimal numtransvendaaocliente;
        [XmlElement(ElementName = "NUMTRANSVENDAAOCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaaocliente
        {
            get { return  numtransvendaaocliente; }
            set {  numtransvendaaocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAFORNEC
        /// Coment�rio: N�mero de transa��o de sa�da ao Fornecedor
        /// </summary>
        private decimal numtransvendafornec;
        [XmlElement(ElementName = "NUMTRANSVENDAFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendafornec
        {
            get { return  numtransvendafornec; }
            set {  numtransvendafornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAPAGGARANTIA
        /// Coment�rio: N�mero de transa��o de sa�da para atender garantia ao cliente (1322 - Sa�da Simples remessa)
        /// </summary>
        private decimal numtransvendapaggarantia;
        [XmlElement(ElementName = "NUMTRANSVENDAPAGGARANTIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendapaggarantia
        {
            get { return  numtransvendapaggarantia; }
            set {  numtransvendapaggarantia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAPRODDEFEITUOSO
        /// Coment�rio: N�mero de transa��o de sa�da para devolver produto velho ou defeituoso ( 1322 - sa�da simples remessa)
        /// </summary>
        private decimal numtransvendaproddefeituoso;
        [XmlElement(ElementName = "NUMTRANSVENDAPRODDEFEITUOSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvendaproddefeituoso
        {
            get { return  numtransvendaproddefeituoso; }
            set {  numtransvendaproddefeituoso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��es.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PAGOUCLIENTE
        /// Coment�rio: Status. S/N
        /// </summary>
        private string pagoucliente;
        [XmlElement(ElementName = "PAGOUCLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pagoucliente
        {
            get { return  pagoucliente; }
            set {  pagoucliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESULTADOLAUDO
        /// Coment�rio: Resultado Laudo
        /// </summary>
        private string resultadolaudo;
        [XmlElement(ElementName = "RESULTADOLAUDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Resultadolaudo
        {
            get { return  resultadolaudo; }
            set {  resultadolaudo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Status
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUSANTERIOR
        /// Coment�rio: Status Anterior
        /// </summary>
        private string statusanterior;
        [XmlElement(ElementName = "STATUSANTERIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Statusanterior
        {
            get { return  statusanterior; }
            set {  statusanterior = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCGarantia()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGARANTIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCGarantia> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGarantia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCGarantia> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGarantia>(where);
        }

        #endregion
    }
}
