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
    /// Classe referente a tabela PCEstendereco
    /// </summary>
    [XmlType("PCESTENDERECO")]
    public class PCEstendereco : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODENDERECO
        /// Coment�rio: 
        /// </summary>
        private decimal codendereco;
        [XmlElement(ElementName = "CODENDERECO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codendereco
        {
            get { return  codendereco; }
            set {  codendereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOUMA
        /// Coment�rio: 
        /// </summary>
        private decimal codigouma;
        [XmlElement(ElementName = "CODIGOUMA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Codigouma
        {
            get { return  codigouma; }
            set {  codigouma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: DTENTRADA
        /// Coment�rio: Indica a data de entrada.
        /// </summary>
        private DateTime? dtentrada;
        [XmlElement(ElementName = "DTENTRADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentrada
        {
            get { return  dtentrada; }
            set {  dtentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFABRICACAO
        /// Coment�rio: Data de fabrica��o do produto.
        /// </summary>
        private DateTime? dtfabricacao;
        [XmlElement(ElementName = "DTFABRICACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfabricacao
        {
            get { return  dtfabricacao; }
            set {  dtfabricacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTINVENT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultinvent;
        [XmlElement(ElementName = "DTULTINVENT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultinvent
        {
            get { return  dtultinvent; }
            set {  dtultinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVAL
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtval;
        [XmlElement(ElementName = "DTVAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtval
        {
            get { return  dtval; }
            set {  dtval = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOVPENDENTE
        /// Coment�rio: 
        /// </summary>
        private string movpendente;
        [XmlElement(ElementName = "MOVPENDENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Movpendente
        {
            get { return  movpendente; }
            set {  movpendente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Coment�rio: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QT
        /// Coment�rio: 
        /// </summary>
        private decimal qt;
        [XmlElement(ElementName = "QT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qt
        {
            get { return  qt; }
            set {  qt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTBLOQUEADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtbloqueada;
        [XmlElement(ElementName = "QTBLOQUEADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtbloqueada
        {
            get { return  qtbloqueada; }
            set {  qtbloqueada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCANCEL
        /// Coment�rio: 
        /// </summary>
        private DateTime? qtcancel;
        [XmlElement(ElementName = "QTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Qtcancel
        {
            get { return  qtcancel; }
            set {  qtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTESTANT
        /// Coment�rio: 
        /// </summary>
        private decimal qtestant;
        [XmlElement(ElementName = "QTESTANT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtestant
        {
            get { return  qtestant; }
            set {  qtestant = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDENTRADA
        /// Coment�rio: 
        /// </summary>
        private decimal qtpendentrada;
        [XmlElement(ElementName = "QTPENDENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpendentrada
        {
            get { return  qtpendentrada; }
            set {  qtpendentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPENDSAIDA
        /// Coment�rio: 
        /// </summary>
        private decimal qtpendsaida;
        [XmlElement(ElementName = "QTPENDSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtpendsaida
        {
            get { return  qtpendsaida; }
            set {  qtpendsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRESERV
        /// Coment�rio: 
        /// </summary>
        private decimal qtreserv;
        [XmlElement(ElementName = "QTRESERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtreserv
        {
            get { return  qtreserv; }
            set {  qtreserv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTULTINVENT
        /// Coment�rio: 
        /// </summary>
        private decimal qtultinvent;
        [XmlElement(ElementName = "QTULTINVENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Qtultinvent
        {
            get { return  qtultinvent; }
            set {  qtultinvent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TESTE
        /// Coment�rio: Data de fabrica��o do produto.
        /// </summary>
        private string teste;
        [XmlElement(ElementName = "TESTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Teste
        {
            get { return  teste; }
            set {  teste = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEstendereco()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTENDERECO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEstendereco> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstendereco>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEstendereco> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstendereco>(where);
        }

        #endregion
    }
}
