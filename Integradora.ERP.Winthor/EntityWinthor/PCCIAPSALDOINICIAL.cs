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
    /// Classe referente a tabela PCCiapsaldoinicial
    /// </summary>
    [XmlType("PCCIAPSALDOINICIAL")]
    public class PCCiapsaldoinicial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial.
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo Fornecedor.
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
        /// Propriedade referente ao campo: CODLOCALIZACAOBEM
        /// Coment�rio: C�digo localiza��o do bem.
        /// </summary>
        private decimal codlocalizacaobem;
        [XmlElement(ElementName = "CODLOCALIZACAOBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlocalizacaobem
        {
            get { return  codlocalizacaobem; }
            set {  codlocalizacaobem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: Indica o c�digo do produto.
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
        /// Propriedade referente ao campo: CODRESPONSAVELBEM
        /// Coment�rio: C�digo respons�vel pelo bem.
        /// </summary>
        private decimal codresponsavelbem;
        [XmlElement(ElementName = "CODRESPONSAVELBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codresponsavelbem
        {
            get { return  codresponsavelbem; }
            set {  codresponsavelbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSALDO
        /// Coment�rio: Indica o c�digo saldo inicial.
        /// </summary>
        private decimal codsaldo;
        [XmlElement(ElementName = "CODSALDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codsaldo
        {
            get { return  codsaldo; }
            set {  codsaldo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Indica o data da entrada.
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
        /// Propriedade referente ao campo: DATABAIXA
        /// Coment�rio: Indica a data da baixa.
        /// </summary>
        private DateTime? databaixa;
        [XmlElement(ElementName = "DATABAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Databaixa
        {
            get { return  databaixa; }
            set {  databaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAULTDEPRECIACAO
        /// Coment�rio: Data da �ltima deprecia��o.
        /// </summary>
        private DateTime? dataultdepreciacao;
        [XmlElement(ElementName = "DATAULTDEPRECIACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataultdepreciacao
        {
            get { return  dataultdepreciacao; }
            set {  dataultdepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTTERMINOCIAP
        /// Coment�rio: Indica a data termino CIAP.
        /// </summary>
        private DateTime? dtterminociap;
        [XmlElement(ElementName = "DTTERMINOCIAP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtterminociap
        {
            get { return  dtterminociap; }
            set {  dtterminociap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: Indica o n�mero da nota.
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPATRIMONIO
        /// Coment�rio: Indica o n�mero do patrimonio.
        /// </summary>
        private string numpatrimonio;
        [XmlElement(ElementName = "NUMPATRIMONIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numpatrimonio
        {
            get { return  numpatrimonio; }
            set {  numpatrimonio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: Indica o n�mero da transa��o de venda.
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
        /// Propriedade referente ao campo: QTDTRANSFERIDA
        /// Coment�rio: Quantidade transferida do bem.
        /// </summary>
        private decimal qtdtransferida;
        [XmlElement(ElementName = "QTDTRANSFERIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdtransferida
        {
            get { return  qtdtransferida; }
            set {  qtdtransferida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXADEPRECIACAO
        /// Coment�rio: Indica a taxa de deprecia��o.
        /// </summary>
        private decimal taxadepreciacao;
        [XmlElement(ElementName = "TAXADEPRECIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Taxadepreciacao
        {
            get { return  taxadepreciacao; }
            set {  taxadepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBAIXA
        /// Coment�rio: Indica o tipo da baixa.
        /// </summary>
        private string tipobaixa;
        [XmlElement(ElementName = "TIPOBAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipobaixa
        {
            get { return  tipobaixa; }
            set {  tipobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCREDITO
        /// Coment�rio: Indica o valor do cr�dito CIAP.
        /// </summary>
        private decimal vlcredito;
        [XmlElement(ElementName = "VLCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcredito
        {
            get { return  vlcredito; }
            set {  vlcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRATUALBEM
        /// Coment�rio: Indica o valor atual do bem.
        /// </summary>
        private decimal vlratualbem;
        [XmlElement(ElementName = "VLRATUALBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vlratualbem
        {
            get { return  vlratualbem; }
            set {  vlratualbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECACUMULADA
        /// Coment�rio: Indica o valor da deprecia��o acumulada.
        /// </summary>
        private decimal vlrdeprecacumulada;
        [XmlElement(ElementName = "VLRDEPRECACUMULADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,24)]
        public decimal Vlrdeprecacumulada
        {
            get { return  vlrdeprecacumulada; }
            set {  vlrdeprecacumulada = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCiapsaldoinicial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCIAPSALDOINICIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCiapsaldoinicial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCiapsaldoinicial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCiapsaldoinicial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCiapsaldoinicial>(where);
        }

        #endregion
    }
}
