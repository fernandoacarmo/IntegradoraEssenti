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
        /// Comentário: Ccontador de comprovante de débito e crédito.
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
        /// Comentário: Código da filial.
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
        /// Comentário: Contador de ordem de operação do cupom.
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
        /// Comentário: Data de emissão.
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
        /// Comentário: Símbolo referente ao doc.fiscal.
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
        /// Comentário: Exportado.
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
        /// Comentário: Contador geral de operação não fiscal.
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
        /// Comentário: Contador geral de relatório gerencial.
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
        /// Comentário: Hora final de emissão.
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
        /// Comentário: Letra indicativa de MF adicional.
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
        /// Comentário: Modelo do emissor de cupom fiscal.
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
        /// Comentário: Número do caixa.
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
        /// Comentário: Número do emissor de cupom fiscal.
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
        /// Comentário: Número do usuário do cupom fiscal.
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
        /// Comentário: Número de série do equipamento.
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
        /// Comentário: ROTINA QUE GRAVOU A INFORMACAO
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDocemitidos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDocemitidos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
