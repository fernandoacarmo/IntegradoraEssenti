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
    /// Classe referente a tabela PCServicoconsum
    /// </summary>
    [XmlType("PCSERVICOCONSUM")]
    public class PCServicoconsum : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRROENT
        /// Coment�rio: Bairro de entrega.
        /// </summary>
        private string bairroent;
        [XmlElement(ElementName = "BAIRROENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Bairroent
        {
            get { return  bairroent; }
            set {  bairroent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPENT
        /// Coment�rio: Cep de entrega.
        /// </summary>
        private string cepent;
        [XmlElement(ElementName = "CEPENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cepent
        {
            get { return  cepent; }
            set {  cepent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCENT
        /// Coment�rio: CGC Cliente.
        /// </summary>
        private string cgcent;
        [XmlElement(ElementName = "CGCENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgcent
        {
            get { return  cgcent; }
            set {  cgcent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLIENT
        /// Coment�rio: Cliente.
        /// </summary>
        private string client;
        [XmlElement(ElementName = "CLIENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Client
        {
            get { return  client; }
            set {  client = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Coment�rio: C�digo da cidade.
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CTLEMAIL
        /// Coment�rio: E-Mail.
        /// </summary>
        private string ctlemail;
        [XmlElement(ElementName = "CTLEMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Ctlemail
        {
            get { return  ctlemail; }
            set {  ctlemail = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CTLFAX
        /// Coment�rio: Fax.
        /// </summary>
        private string ctlfax;
        [XmlElement(ElementName = "CTLFAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ctlfax
        {
            get { return  ctlfax; }
            set {  ctlfax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPORTACAOSERVINT
        /// Coment�rio: Data de exporta��o.
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
        /// Propriedade referente ao campo: EMAIL
        /// Coment�rio: E-Mail.
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERENT
        /// Coment�rio: Endere�o de entrega.
        /// </summary>
        private string enderent;
        [XmlElement(ElementName = "ENDERENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Enderent
        {
            get { return  enderent; }
            set {  enderent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTENT
        /// Coment�rio: Estado de entrega.
        /// </summary>
        private string estent;
        [XmlElement(ElementName = "ESTENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estent
        {
            get { return  estent; }
            set {  estent = value; }
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
        /// Propriedade referente ao campo: IEENT
        /// Coment�rio: Inscri��o estadual.
        /// </summary>
        private string ieent;
        [XmlElement(ElementName = "IEENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Ieent
        {
            get { return  ieent; }
            set {  ieent = value; }
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
        /// Propriedade referente ao campo: LBLEMAIL
        /// Coment�rio: E-Mail.
        /// </summary>
        private string lblemail;
        [XmlElement(ElementName = "LBLEMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Lblemail
        {
            get { return  lblemail; }
            set {  lblemail = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LBLFAX
        /// Coment�rio: Fax.
        /// </summary>
        private string lblfax;
        [XmlElement(ElementName = "LBLFAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Lblfax
        {
            get { return  lblfax; }
            set {  lblfax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MUNICENT
        /// Coment�rio: Munic�pio de entrega.
        /// </summary>
        private string municent;
        [XmlElement(ElementName = "MUNICENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Municent
        {
            get { return  municent; }
            set {  municent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECONTATO
        /// Coment�rio: Nome contato.
        /// </summary>
        private string nomecontato;
        [XmlElement(ElementName = "NOMECONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomecontato
        {
            get { return  nomecontato; }
            set {  nomecontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOS
        /// Coment�rio: N�mero O.S.
        /// </summary>
        private decimal numos;
        [XmlElement(ElementName = "NUMOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Numos
        {
            get { return  numos; }
            set {  numos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Observa��o.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSCONTATO
        /// Coment�rio: Observa��o contato.
        /// </summary>
        private string obscontato;
        [XmlElement(ElementName = "OBSCONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,75)]
        public string Obscontato
        {
            get { return  obscontato; }
            set {  obscontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONECONTATO
        /// Coment�rio: Telefone de contato.
        /// </summary>
        private string telefonecontato;
        [XmlElement(ElementName = "TELEFONECONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telefonecontato
        {
            get { return  telefonecontato; }
            set {  telefonecontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELENT
        /// Coment�rio: Telefone de entrega.
        /// </summary>
        private string telent;
        [XmlElement(ElementName = "TELENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Telent
        {
            get { return  telent; }
            set {  telent = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCServicoconsum()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVICOCONSUM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCServicoconsum> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServicoconsum>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCServicoconsum> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServicoconsum>(where);
        }

        #endregion
    }
}
