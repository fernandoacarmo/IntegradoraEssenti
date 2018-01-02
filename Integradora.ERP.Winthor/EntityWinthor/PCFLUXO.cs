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
    /// Classe referente a tabela PCFluxo
    /// </summary>
    [XmlType("PCFLUXO")]
    public class PCFluxo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: INDICE
        /// Coment�rio: 
        /// </summary>
        private string indice;
        [XmlElement(ElementName = "INDICE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Indice
        {
            get { return  indice; }
            set {  indice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINADIMP
        /// Coment�rio: 
        /// </summary>
        private decimal percinadimp;
        [XmlElement(ElementName = "PERCINADIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percinadimp
        {
            get { return  percinadimp; }
            set {  percinadimp = value; }
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
        /// Propriedade referente ao campo: VALORCOMPRAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal valorcompraprev;
        [XmlElement(ElementName = "VALORCOMPRAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcompraprev
        {
            get { return  valorcompraprev; }
            set {  valorcompraprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCP1
        /// Coment�rio: 
        /// </summary>
        private decimal valorcp1;
        [XmlElement(ElementName = "VALORCP1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcp1
        {
            get { return  valorcp1; }
            set {  valorcp1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCP2
        /// Coment�rio: 
        /// </summary>
        private decimal valorcp2;
        [XmlElement(ElementName = "VALORCP2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcp2
        {
            get { return  valorcp2; }
            set {  valorcp2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCP3
        /// Coment�rio: 
        /// </summary>
        private decimal valorcp3;
        [XmlElement(ElementName = "VALORCP3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcp3
        {
            get { return  valorcp3; }
            set {  valorcp3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCP4
        /// Coment�rio: 
        /// </summary>
        private decimal valorcp4;
        [XmlElement(ElementName = "VALORCP4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcp4
        {
            get { return  valorcp4; }
            set {  valorcp4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCP5
        /// Coment�rio: 
        /// </summary>
        private decimal valorcp5;
        [XmlElement(ElementName = "VALORCP5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcp5
        {
            get { return  valorcp5; }
            set {  valorcp5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCR1
        /// Coment�rio: 
        /// </summary>
        private decimal valorcr1;
        [XmlElement(ElementName = "VALORCR1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcr1
        {
            get { return  valorcr1; }
            set {  valorcr1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCR2
        /// Coment�rio: 
        /// </summary>
        private decimal valorcr2;
        [XmlElement(ElementName = "VALORCR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcr2
        {
            get { return  valorcr2; }
            set {  valorcr2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCR3
        /// Coment�rio: 
        /// </summary>
        private decimal valorcr3;
        [XmlElement(ElementName = "VALORCR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcr3
        {
            get { return  valorcr3; }
            set {  valorcr3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCR4
        /// Coment�rio: 
        /// </summary>
        private decimal valorcr4;
        [XmlElement(ElementName = "VALORCR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcr4
        {
            get { return  valorcr4; }
            set {  valorcr4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCR5
        /// Coment�rio: 
        /// </summary>
        private decimal valorcr5;
        [XmlElement(ElementName = "VALORCR5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorcr5
        {
            get { return  valorcr5; }
            set {  valorcr5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORINADIMP
        /// Coment�rio: 
        /// </summary>
        private decimal valorinadimp;
        [XmlElement(ElementName = "VALORINADIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorinadimp
        {
            get { return  valorinadimp; }
            set {  valorinadimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTOTALCP
        /// Coment�rio: 
        /// </summary>
        private decimal valortotalcp;
        [XmlElement(ElementName = "VALORTOTALCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valortotalcp
        {
            get { return  valortotalcp; }
            set {  valortotalcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORTOTALCR
        /// Coment�rio: 
        /// </summary>
        private decimal valortotalcr;
        [XmlElement(ElementName = "VALORTOTALCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valortotalcr
        {
            get { return  valortotalcr; }
            set {  valortotalcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORVENDAPREV
        /// Coment�rio: 
        /// </summary>
        private decimal valorvendaprev;
        [XmlElement(ElementName = "VALORVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Valorvendaprev
        {
            get { return  valorvendaprev; }
            set {  valorvendaprev = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFluxo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFLUXO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFluxo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFluxo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFluxo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFluxo>(where);
        }

        #endregion
    }
}
