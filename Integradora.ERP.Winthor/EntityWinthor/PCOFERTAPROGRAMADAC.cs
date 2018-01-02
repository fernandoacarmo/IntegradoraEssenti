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
    /// Classe referente a tabela PCOfertaprogramadac
    /// </summary>
    [XmlType("PCOFERTAPROGRAMADAC")]
    public class PCOfertaprogramadac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial.
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
        /// Propriedade referente ao campo: CODFUNCCANCEL
        /// Coment�rio: C�digo Funcion�rio Cancelamento.
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
        /// Propriedade referente ao campo: CODFUNCORIG
        /// Coment�rio: C�digo Funcion�rio Origem.
        /// </summary>
        private decimal codfuncorig;
        [XmlElement(ElementName = "CODFUNCORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncorig
        {
            get { return  codfuncorig; }
            set {  codfuncorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALT
        /// Coment�rio: C�digo Funcion�rio da �ltima altera��o.
        /// </summary>
        private decimal codfuncultalt;
        [XmlElement(ElementName = "CODFUNCULTALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalt
        {
            get { return  codfuncultalt; }
            set {  codfuncultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOFERTA
        /// Coment�rio: C�digo da Oferta.
        /// </summary>
        private decimal codoferta;
        [XmlElement(ElementName = "CODOFERTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codoferta
        {
            get { return  codoferta; }
            set {  codoferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOOFERTA
        /// Coment�rio: C�digo do tipo da oferta
        /// </summary>
        private decimal codtipooferta;
        [XmlElement(ElementName = "CODTIPOOFERTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtipooferta
        {
            get { return  codtipooferta; }
            set {  codtipooferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCOFERTA
        /// Coment�rio: Descri��o da Oferta.
        /// </summary>
        private string descoferta;
        [XmlElement(ElementName = "DESCOFERTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descoferta
        {
            get { return  descoferta; }
            set {  descoferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Coment�rio: Data Cancelamento.
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
        /// Propriedade referente ao campo: DTFINAL
        /// Coment�rio: Data Final.
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIAL
        /// Coment�rio: Data Inicial.
        /// </summary>
        private DateTime? dtinicial;
        [XmlElement(ElementName = "DTINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicial
        {
            get { return  dtinicial; }
            set {  dtinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTORIG
        /// Coment�rio: Data Origem.
        /// </summary>
        private DateTime? dtorig;
        [XmlElement(ElementName = "DTORIG", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtorig
        {
            get { return  dtorig; }
            set {  dtorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTOFERTA
        /// Coment�rio: Data �ltima altera��do na oferta.
        /// </summary>
        private DateTime? dtultaltoferta;
        [XmlElement(ElementName = "DTULTALTOFERTA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultaltoferta
        {
            get { return  dtultaltoferta; }
            set {  dtultaltoferta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFINAL
        /// Coment�rio: Hora final oferta
        /// </summary>
        private DateTime? horafinal;
        [XmlElement(ElementName = "HORAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Horafinal
        {
            get { return  horafinal; }
            set {  horafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIAL
        /// Coment�rio: Hora inicio oferta
        /// </summary>
        private DateTime? horainicial;
        [XmlElement(ElementName = "HORAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Horainicial
        {
            get { return  horainicial; }
            set {  horainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOCANCEL
        /// Coment�rio: Motivo Cancelamento.
        /// </summary>
        private string motivocancel;
        [XmlElement(ElementName = "MOTIVOCANCEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Motivocancel
        {
            get { return  motivocancel; }
            set {  motivocancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDACONVENIO
        /// Coment�rio: Verificar se � valido para conv�nio
        /// </summary>
        private string validaconvenio;
        [XmlElement(ElementName = "VALIDACONVENIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validaconvenio
        {
            get { return  validaconvenio; }
            set {  validaconvenio = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCOfertaprogramadac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOFERTAPROGRAMADAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOfertaprogramadac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOfertaprogramadac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCOfertaprogramadac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOfertaprogramadac>(where);
        }

        #endregion
    }
}
