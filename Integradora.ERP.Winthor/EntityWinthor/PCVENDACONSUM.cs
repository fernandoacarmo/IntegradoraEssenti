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
    /// Classe referente a tabela PCVendaconsum
    /// </summary>
    [XmlType("PCVENDACONSUM")]
    public class PCVendaconsum : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BAIRROENT
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CLIENTE
        /// Coment�rio: 
        /// </summary>
        private string cliente;
        [XmlElement(ElementName = "CLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Cliente
        {
            get { return  cliente; }
            set {  cliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Coment�rio: Campo ncess�rio para relacionamento na tabela PCCIDADE, afim de obter a normaliza��o de CIDADE, ESTADO e COD.IBGE.
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
        /// Propriedade referente ao campo: DTNASC
        /// Coment�rio: Caso haja bebida alcoolica na venda ser� necess�rio informar a data de nascimento do cliente.
        /// </summary>
        private DateTime? dtnasc;
        [XmlElement(ElementName = "DTNASC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnasc
        {
            get { return  dtnasc; }
            set {  dtnasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: MUNICENT
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: NUMEROENT
        /// Coment�rio: N�mero de entrega
        /// </summary>
        private string numeroent;
        [XmlElement(ElementName = "NUMEROENT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Numeroent
        {
            get { return  numeroent; }
            set {  numeroent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: 
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: RG
        /// Coment�rio: Caso haja bebida alcoolica na venda ser� necess�rio infomar o RG do cliente.
        /// </summary>
        private string rg;
        [XmlElement(ElementName = "RG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rg
        {
            get { return  rg; }
            set {  rg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONECONTATO
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        public PCVendaconsum()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVENDACONSUM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCVendaconsum> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVendaconsum>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCVendaconsum> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVendaconsum>(where);
        }

        #endregion
    }
}
