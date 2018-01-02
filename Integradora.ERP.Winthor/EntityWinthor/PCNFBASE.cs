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
    /// Classe referente a tabela PCNfbase
    /// </summary>
    [XmlType("PCNFBASE")]
    public class PCNfbase : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQUOTA
        /// Coment�rio: 
        /// </summary>
        private decimal aliquota;
        [XmlElement(ElementName = "ALIQUOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Aliquota
        {
            get { return  aliquota; }
            set {  aliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIMDIFALIQUOTA
        /// Coment�rio: 
        /// </summary>
        private decimal cimdifaliquota;
        [XmlElement(ElementName = "CIMDIFALIQUOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Cimdifaliquota
        {
            get { return  cimdifaliquota; }
            set {  cimdifaliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIMVLICMSDEVIDOST
        /// Coment�rio: 
        /// </summary>
        private decimal cimvlicmsdevidost;
        [XmlElement(ElementName = "CIMVLICMSDEVIDOST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Cimvlicmsdevidost
        {
            get { return  cimvlicmsdevidost; }
            set {  cimvlicmsdevidost = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIMVLICMSNAOAPROV
        /// Coment�rio: 
        /// </summary>
        private decimal cimvlicmsnaoaprov;
        [XmlElement(ElementName = "CIMVLICMSNAOAPROV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Cimvlicmsnaoaprov
        {
            get { return  cimvlicmsnaoaprov; }
            set {  cimvlicmsnaoaprov = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONT
        /// Coment�rio: 
        /// </summary>
        private decimal codcont;
        [XmlElement(ElementName = "CODCONT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Codcont
        {
            get { return  codcont; }
            set {  codcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtexportacaoservint;
        [XmlElement(ElementName = "DTEXPORTACAOSERVINT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexportacaoservint
        {
            get { return  dtexportacaoservint; }
            set {  dtexportacaoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTIMPORTACAOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtimportacaoservprinc;
        [XmlElement(ElementName = "DTIMPORTACAOSERVPRINC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtimportacaoservprinc
        {
            get { return  dtimportacaoservprinc; }
            set {  dtimportacaoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADOSERVINT
        /// Coment�rio: 
        /// </summary>
        private string exportadoservint;
        [XmlElement(ElementName = "EXPORTADOSERVINT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadoservint
        {
            get { return  exportadoservint; }
            set {  exportadoservint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAICMSLIVROFISCAL
        /// Coment�rio: Gera ICMS. 
        /// </summary>
        private string geraicmslivrofiscal;
        [XmlElement(ElementName = "GERAICMSLIVROFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geraicmslivrofiscal
        {
            get { return  geraicmslivrofiscal; }
            set {  geraicmslivrofiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IMPORTADOSERVPRINC
        /// Coment�rio: 
        /// </summary>
        private string importadoservprinc;
        [XmlElement(ElementName = "IMPORTADOSERVPRINC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Importadoservprinc
        {
            get { return  importadoservprinc; }
            set {  importadoservprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMTRANSPISCOFINS
        /// Coment�rio: N�mero de transa��o de PIS/COFINS.
        /// </summary>
        private decimal numtranspiscofins;
        [XmlElement(ElementName = "NUMTRANSPISCOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtranspiscofins
        {
            get { return  numtranspiscofins; }
            set {  numtranspiscofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PERCISS
        /// Coment�rio: Percentual de ISS de servi�o de transporte
        /// </summary>
        private decimal perciss;
        [XmlElement(ElementName = "PERCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perciss
        {
            get { return  perciss; }
            set {  perciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDICMSCUSTO
        /// Coment�rio: % de dedu��o do ICMS do frete FOB no c�lculo do custo.
        /// </summary>
        private decimal percredicmscusto;
        [XmlElement(ElementName = "PERCREDICMSCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percredicmscusto
        {
            get { return  percredicmscusto; }
            set {  percredicmscusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUT
        /// Coment�rio: C�digo de Situa��o Tribut�ria de Sa�da/Entrada
        /// </summary>
        private string sittribut;
        [XmlElement(ElementName = "SITTRIBUT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittribut
        {
            get { return  sittribut; }
            set {  sittribut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITTRIBUTIPI
        /// Coment�rio: C�digo de Situa��o Tribut�ria de Sa�da/Entrada
        /// </summary>
        private string sittributipi;
        [XmlElement(ElementName = "SITTRIBUTIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Sittributipi
        {
            get { return  sittributipi; }
            set {  sittributipi = value; }
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
        /// Propriedade referente ao campo: VLBASE
        /// Coment�rio: 
        /// </summary>
        private decimal vlbase;
        [XmlElement(ElementName = "VLBASE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Vlbase
        {
            get { return  vlbase; }
            set {  vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASENF
        /// Coment�rio: 
        /// </summary>
        private decimal vlbasenf;
        [XmlElement(ElementName = "VLBASENF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlbasenf
        {
            get { return  vlbasenf; }
            set {  vlbasenf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCONTABIL
        /// Coment�rio: Valor Cont�bil para efeito de C�lculo do ICMS
        /// </summary>
        private decimal vlcontabil;
        [XmlElement(ElementName = "VLCONTABIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcontabil
        {
            get { return  vlcontabil; }
            set {  vlcontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Coment�rio: 
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSDIFERIDO
        /// Coment�rio: Valor do ICMS Diferido.
        /// </summary>
        private decimal vlicmsdiferido;
        [XmlElement(ElementName = "VLICMSDIFERIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicmsdiferido
        {
            get { return  vlicmsdiferido; }
            set {  vlicmsdiferido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLISENTAS
        /// Coment�rio: 
        /// </summary>
        private decimal vlisentas;
        [XmlElement(ElementName = "VLISENTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlisentas
        {
            get { return  vlisentas; }
            set {  vlisentas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMEXIVA
        /// Coment�rio: Valor de IVA informado para NFs de consumo/imobilizado (quando a NF n�o tem itens). 
        /// </summary>
        private decimal vlmexiva;
        [XmlElement(ElementName = "VLMEXIVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlmexiva
        {
            get { return  vlmexiva; }
            set {  vlmexiva = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCNfbase()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCNFBASE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCNfbase> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfbase>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCNfbase> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCNfbase>(where);
        }

        #endregion
    }
}
