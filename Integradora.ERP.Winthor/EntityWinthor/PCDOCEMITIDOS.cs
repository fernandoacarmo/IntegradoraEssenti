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
    /// Classe referente a tabela PCDocemitidos
    /// </summary>
    [XmlType("PCDOCEMITIDOS")]
    public class PCDocemitidos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CDC
        /// Coment�rio: Ccontador de comprovante de d�bito e cr�dito.
        /// </summary>
        private decimal cdc;
        [XmlElement(ElementName = "CDC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Cdc
        {
            get { return  cdc; }
            set {  cdc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial.
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
        /// Propriedade referente ao campo: COO
        /// Coment�rio: Contador de ordem de opera��o do cupom.
        /// </summary>
        private decimal coo;
        [XmlElement(ElementName = "COO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coo
        {
            get { return  coo; }
            set {  coo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data de emiss�o.
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
        /// Propriedade referente ao campo: DENOMINACAO
        /// Coment�rio: S�mbolo referente ao doc.fiscal.
        /// </summary>
        private string denominacao;
        [XmlElement(ElementName = "DENOMINACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Denominacao
        {
            get { return  denominacao; }
            set {  denominacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTOU
        /// Coment�rio: Exportado.
        /// </summary>
        private string exportou;
        [XmlElement(ElementName = "EXPORTOU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportou
        {
            get { return  exportou; }
            set {  exportou = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GNF
        /// Coment�rio: Contador geral de opera��o n�o fiscal.
        /// </summary>
        private decimal gnf;
        [XmlElement(ElementName = "GNF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Gnf
        {
            get { return  gnf; }
            set {  gnf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRG
        /// Coment�rio: Contador geral de relat�rio gerencial.
        /// </summary>
        private decimal grg;
        [XmlElement(ElementName = "GRG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Grg
        {
            get { return  grg; }
            set {  grg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: Hora final de emiss�o.
        /// </summary>
        private string hora;
        [XmlElement(ElementName = "HORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MFADICIONAL
        /// Coment�rio: Letra indicativa de MF adicional.
        /// </summary>
        private string mfadicional;
        [XmlElement(ElementName = "MFADICIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Mfadicional
        {
            get { return  mfadicional; }
            set {  mfadicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELOECF
        /// Coment�rio: Modelo do emissor de cupom fiscal.
        /// </summary>
        private string modeloecf;
        [XmlElement(ElementName = "MODELOECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Modeloecf
        {
            get { return  modeloecf; }
            set {  modeloecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Coment�rio: N�mero do caixa.
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXAFISCAL
        /// Coment�rio: N�mero do emissor de cupom fiscal.
        /// </summary>
        private decimal numcaixafiscal;
        [XmlElement(ElementName = "NUMCAIXAFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixafiscal
        {
            get { return  numcaixafiscal; }
            set {  numcaixafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROUSUARIO
        /// Coment�rio: N�mero do usu�rio do cupom fiscal.
        /// </summary>
        private decimal numerousuario;
        [XmlElement(ElementName = "NUMEROUSUARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numerousuario
        {
            get { return  numerousuario; }
            set {  numerousuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Coment�rio: N�mero de s�rie do equipamento.
        /// </summary>
        private string numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: ROTINA QUE GRAVOU A INFORMACAO
        /// </summary>
        private string rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,48)]
        public string Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDocemitidos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDOCEMITIDOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDocemitidos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDocemitidos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDocemitidos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDocemitidos>(where);
        }

        #endregion
    }
}
