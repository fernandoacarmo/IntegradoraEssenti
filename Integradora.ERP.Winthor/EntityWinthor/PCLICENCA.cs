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
    /// Classe referente a tabela PCLicenca
    /// </summary>
    [XmlType("PCLICENCA")]
    public class PCLicenca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: EMAILRESPONSAVEL
        /// Coment�rio: E-mail do respons�vel pela chave no cliente
        /// </summary>
        private string emailresponsavel;
        [XmlElement(ElementName = "EMAILRESPONSAVEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Emailresponsavel
        {
            get { return  emailresponsavel; }
            set {  emailresponsavel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LICENCAID
        /// Coment�rio: Identifica��o do registro de licen�a
        /// </summary>
        private string licencaid;
        [XmlElement(ElementName = "LICENCAID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Licencaid
        {
            get { return  licencaid; }
            set {  licencaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Coment�rio: 
        /// </summary>
        private decimal modelo;
        [XmlElement(ElementName = "MODELO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Modelo
        {
            get { return  modelo; }
            set {  modelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELOVERSAO
        /// Coment�rio: Modelo de Versionamento de Rotinas
        /// </summary>
        private decimal modeloversao;
        [XmlElement(ElementName = "MODELOVERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Modeloversao
        {
            get { return  modeloversao; }
            set {  modeloversao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Status atual do cliente junto a PC
        /// </summary>
        private decimal status;
        [XmlElement(ElementName = "STATUS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAO
        /// Coment�rio: Vers�o do contrato
        /// </summary>
        private decimal versao;
        [XmlElement(ElementName = "VERSAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Versao
        {
            get { return  versao; }
            set {  versao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOPATCH
        /// Coment�rio: Vers�o do Patch de Corre��o
        /// </summary>
        private decimal versaopatch;
        [XmlElement(ElementName = "VERSAOPATCH", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Versaopatch
        {
            get { return  versaopatch; }
            set {  versaopatch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAOWINTHOR
        /// Coment�rio: Vers�o Atual do WinThor
        /// </summary>
        private decimal versaowinthor;
        [XmlElement(ElementName = "VERSAOWINTHOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Versaowinthor
        {
            get { return  versaowinthor; }
            set {  versaowinthor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLicenca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLICENCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLicenca> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLicenca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLicenca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLicenca>(where);
        }

        #endregion
    }
}
