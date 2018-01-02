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
    /// Classe referente a tabela PCVerba
    /// </summary>
    [XmlType("PCVERBA")]
    public class PCVerba : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: 
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA
        /// Coment�rio: 
        /// </summary>
        private decimal codconta;
        [XmlElement(ElementName = "CODCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codconta
        {
            get { return  codconta; }
            set {  codconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Coment�rio: 
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CODFUNCCANCEL
        /// Coment�rio: Indica a matr�cula do funcion�rio que realizou o cancelamento de verba.
        /// </summary>
        private decimal codfunccancel;
        [XmlElement(ElementName = "CODFUNCCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccancel
        {
            get { return  codfunccancel; }
            set {  codfunccancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCQUITACAO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncquitacao;
        [XmlElement(ElementName = "CODFUNCQUITACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncquitacao
        {
            get { return  codfuncquitacao; }
            set {  codfuncquitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALTER
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncultalter;
        [XmlElement(ElementName = "CODFUNCULTALTER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalter
        {
            get { return  codfuncultalter; }
            set {  codfuncultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPOAVARIA
        /// Coment�rio: Codigo do grupo de avaria a qual a verba esta vinculada
        /// </summary>
        private decimal codgrupoavaria;
        [XmlElement(ElementName = "CODGRUPOAVARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codgrupoavaria
        {
            get { return  codgrupoavaria; }
            set {  codgrupoavaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Coment�rio: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOVERBA
        /// Coment�rio: Indica o c�digo do tipo da verba.
        /// </summary>
        private decimal codtipoverba;
        [XmlElement(ElementName = "CODTIPOVERBA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codtipoverba
        {
            get { return  codtipoverba; }
            set {  codtipoverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPFREPFORNEC
        /// Coment�rio: 
        /// </summary>
        private string cpfrepfornec;
        [XmlElement(ElementName = "CPFREPFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cpfrepfornec
        {
            get { return  cpfrepfornec; }
            set {  cpfrepfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAEDICAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dataedicao;
        [XmlElement(ElementName = "DATAEDICAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataedicao
        {
            get { return  dataedicao; }
            set {  dataedicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DINHEIRO
        /// Coment�rio: 
        /// </summary>
        private decimal dinheiro;
        [XmlElement(ElementName = "DINHEIRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Dinheiro
        {
            get { return  dinheiro; }
            set {  dinheiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAPURACAO
        /// Coment�rio: Indica a data de apura��o da verba rebaixa CMV.
        /// </summary>
        private DateTime? dtapuracao;
        [XmlElement(ElementName = "DTAPURACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtapuracao
        {
            get { return  dtapuracao; }
            set {  dtapuracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAPURACAOFINAL
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtapuracaofinal;
        [XmlElement(ElementName = "DTAPURACAOFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtapuracaofinal
        {
            get { return  dtapuracaofinal; }
            set {  dtapuracaofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAPURACAOINICIO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtapuracaoinicio;
        [XmlElement(ElementName = "DTAPURACAOINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtapuracaoinicio
        {
            get { return  dtapuracaoinicio; }
            set {  dtapuracaoinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Indica a data de casdastro.
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Coment�rio: Indica a data de de cancelamento da verba.
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTQUITACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtquitacao;
        [XmlElement(ElementName = "DTQUITACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtquitacao
        {
            get { return  dtquitacao; }
            set {  dtquitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultalteracao;
        [XmlElement(ElementName = "DTULTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalteracao
        {
            get { return  dtultalteracao; }
            set {  dtultalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTPAGTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtultpagto;
        [XmlElement(ElementName = "DTULTPAGTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultpagto
        {
            get { return  dtultpagto; }
            set {  dtultpagto = value; }
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
        /// Propriedade referente ao campo: FORMAPGTO
        /// Coment�rio: 
        /// </summary>
        private string formapgto;
        [XmlElement(ElementName = "FORMAPGTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Formapgto
        {
            get { return  formapgto; }
            set {  formapgto = value; }
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
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
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
        /// Propriedade referente ao campo: NUMTRANSENTDEVFORNEC
        /// Coment�rio: 
        /// </summary>
        private decimal numtransentdevfornec;
        [XmlElement(ElementName = "NUMTRANSENTDEVFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransentdevfornec
        {
            get { return  numtransentdevfornec; }
            set {  numtransentdevfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBA
        /// Coment�rio: 
        /// </summary>
        private decimal numverba;
        [XmlElement(ElementName = "NUMVERBA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numverba
        {
            get { return  numverba; }
            set {  numverba = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVERBAPROMOCAO
        /// Coment�rio: 
        /// </summary>
        private decimal numverbapromocao;
        [XmlElement(ElementName = "NUMVERBAPROMOCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numverbapromocao
        {
            get { return  numverbapromocao; }
            set {  numverbapromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVIAS
        /// Coment�rio: N�mero de vezes que foi emitida a autoriza��o aplica��o de verba.
        /// </summary>
        private decimal numvias;
        [XmlElement(ElementName = "NUMVIAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numvias
        {
            get { return  numvias; }
            set {  numvias = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEM
        /// Coment�rio: 
        /// </summary>
        private string origem;
        [XmlElement(ElementName = "ORIGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origem
        {
            get { return  origem; }
            set {  origem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OUTROS
        /// Coment�rio: 
        /// </summary>
        private string outros;
        [XmlElement(ElementName = "OUTROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Outros
        {
            get { return  outros; }
            set {  outros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROGRAMAQUITACAO
        /// Coment�rio: 
        /// </summary>
        private decimal programaquitacao;
        [XmlElement(ElementName = "PROGRAMAQUITACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Programaquitacao
        {
            get { return  programaquitacao; }
            set {  programaquitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIA
        /// Coment�rio: 
        /// </summary>
        private string referencia;
        [XmlElement(ElementName = "REFERENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Referencia
        {
            get { return  referencia; }
            set {  referencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIA1
        /// Coment�rio: 
        /// </summary>
        private string referencia1;
        [XmlElement(ElementName = "REFERENCIA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Referencia1
        {
            get { return  referencia1; }
            set {  referencia1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RGREPFORNEC
        /// Coment�rio: 
        /// </summary>
        private string rgrepfornec;
        [XmlElement(ElementName = "RGREPFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Rgrepfornec
        {
            get { return  rgrepfornec; }
            set {  rgrepfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTINALANC
        /// Coment�rio: Indica o n�mero da rotina que alterou o registro.
        /// </summary>
        private decimal rotinalanc;
        [XmlElement(ElementName = "ROTINALANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Rotinalanc
        {
            get { return  rotinalanc; }
            set {  rotinalanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUPERVFORNEC
        /// Coment�rio: 
        /// </summary>
        private string supervfornec;
        [XmlElement(ElementName = "SUPERVFORNEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Supervfornec
        {
            get { return  supervfornec; }
            set {  supervfornec = value; }
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
        /// Propriedade referente ao campo: TIPOQUITACAO
        /// Coment�rio: 
        /// </summary>
        private string tipoquitacao;
        [XmlElement(ElementName = "TIPOQUITACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Tipoquitacao
        {
            get { return  tipoquitacao; }
            set {  tipoquitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILNUMPED1
        /// Coment�rio: 
        /// </summary>
        private decimal vilnumped1;
        [XmlElement(ElementName = "VILNUMPED1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Vilnumped1
        {
            get { return  vilnumped1; }
            set {  vilnumped1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILNUMPED2
        /// Coment�rio: 
        /// </summary>
        private decimal vilnumped2;
        [XmlElement(ElementName = "VILNUMPED2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Vilnumped2
        {
            get { return  vilnumped2; }
            set {  vilnumped2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILNUMPED3
        /// Coment�rio: 
        /// </summary>
        private decimal vilnumped3;
        [XmlElement(ElementName = "VILNUMPED3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Vilnumped3
        {
            get { return  vilnumped3; }
            set {  vilnumped3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILNUMPED4
        /// Coment�rio: 
        /// </summary>
        private decimal vilnumped4;
        [XmlElement(ElementName = "VILNUMPED4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Vilnumped4
        {
            get { return  vilnumped4; }
            set {  vilnumped4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VILNUMPED5
        /// Coment�rio: 
        /// </summary>
        private decimal vilnumped5;
        [XmlElement(ElementName = "VILNUMPED5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Vilnumped5
        {
            get { return  vilnumped5; }
            set {  vilnumped5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VPAGO
        /// Coment�rio: 
        /// </summary>
        private decimal vpago;
        [XmlElement(ElementName = "VPAGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vpago
        {
            get { return  vpago; }
            set {  vpago = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCVerba()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVERBA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCVerba> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVerba>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCVerba> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVerba>(where);
        }

        #endregion
    }
}
