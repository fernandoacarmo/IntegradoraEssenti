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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Gera ICMS. 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMTRANSPISCOFINS
        /// Comentário: Número de transação de PIS/COFINS.
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
        /// Propriedade referente ao campo: PERCISS
        /// Comentário: Percentual de ISS de serviço de transporte
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
        /// Comentário: % de dedução do ICMS do frete FOB no cálculo do custo.
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
        /// Comentário: Código de Situação Tributária de Saída/Entrada
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
        /// Comentário: Código de Situação Tributária de Saída/Entrada
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: Valor Contábil para efeito de Cálculo do ICMS
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
        /// Comentário: 
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
        /// Comentário: Valor do ICMS Diferido.
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
        /// Comentário: 
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
        /// Comentário: Valor de IVA informado para NFs de consumo/imobilizado (quando a NF não tem itens). 
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCNfbase> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCNfbase>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
