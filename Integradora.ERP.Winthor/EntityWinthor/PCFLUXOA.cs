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
    /// Classe referente a tabela PCFluxoa
    /// </summary>
    [XmlType("PCFLUXOA")]
    public class PCFluxoa : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLIFOR
        /// Coment�rio: 
        /// </summary>
        private decimal codclifor;
        [XmlElement(ElementName = "CODCLIFOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codclifor
        {
            get { return  codclifor; }
            set {  codclifor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: 
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAEMISSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataemissao;
        [XmlElement(ElementName = "DATAEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataemissao
        {
            get { return  dataemissao; }
            set {  dataemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFINAL
        /// Coment�rio: 
        /// </summary>
        private DateTime? datafinal;
        [XmlElement(ElementName = "DATAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafinal
        {
            get { return  datafinal; }
            set {  datafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIAL
        /// Coment�rio: 
        /// </summary>
        private DateTime? datainicial;
        [XmlElement(ElementName = "DATAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datainicial
        {
            get { return  datainicial; }
            set {  datainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Coment�rio: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICE
        /// Coment�rio: 
        /// </summary>
        private string indice;
        [XmlElement(ElementName = "INDICE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indice
        {
            get { return  indice; }
            set {  indice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECLIFOR
        /// Coment�rio: 
        /// </summary>
        private string nomeclifor;
        [XmlElement(ElementName = "NOMECLIFOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomeclifor
        {
            get { return  nomeclifor; }
            set {  nomeclifor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANC
        /// Coment�rio: 
        /// </summary>
        private decimal numlanc;
        [XmlElement(ElementName = "NUMLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numlanc
        {
            get { return  numlanc; }
            set {  numlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: PCFLUXOA
        /// Coment�rio: 
        /// </summary>
        private decimal pcfluxoa;
        [XmlElement(ElementName = "PCFLUXOA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pcfluxoa
        {
            get { return  pcfluxoa; }
            set {  pcfluxoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOACUM
        /// Coment�rio: 
        /// </summary>
        private decimal saldoacum;
        [XmlElement(ElementName = "SALDOACUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Saldoacum
        {
            get { return  saldoacum; }
            set {  saldoacum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDODIA
        /// Coment�rio: 
        /// </summary>
        private decimal saldodia;
        [XmlElement(ElementName = "SALDODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Saldodia
        {
            get { return  saldodia; }
            set {  saldodia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOINI
        /// Coment�rio: 
        /// </summary>
        private decimal saldoini;
        [XmlElement(ElementName = "SALDOINI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Saldoini
        {
            get { return  saldoini; }
            set {  saldoini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOB
        /// Coment�rio: 
        /// </summary>
        private string tipocob;
        [XmlElement(ElementName = "TIPOCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Tipocob
        {
            get { return  tipocob; }
            set {  tipocob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPAG
        /// Coment�rio: 
        /// </summary>
        private decimal valorpag;
        [XmlElement(ElementName = "VALORPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorpag
        {
            get { return  valorpag; }
            set {  valorpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORREC
        /// Coment�rio: 
        /// </summary>
        private decimal valorrec;
        [XmlElement(ElementName = "VALORREC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorrec
        {
            get { return  valorrec; }
            set {  valorrec = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFluxoa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFLUXOA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFluxoa> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFluxoa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFluxoa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFluxoa>(where);
        }

        #endregion
    }
}
