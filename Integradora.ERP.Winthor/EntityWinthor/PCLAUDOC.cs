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
    /// Classe referente a tabela PCLaudoc
    /// </summary>
    [XmlType("PCLAUDOC")]
    public class PCLaudoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLANC
        /// Coment�rio: Funcion�rio respons�vel. 
        /// </summary>
        private decimal codfunclanc;
        [XmlElement(ElementName = "CODFUNCLANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunclanc
        {
            get { return  codfunclanc; }
            set {  codfunclanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do Produto. 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOPADRAO
        /// Coment�rio: Descri��o da an�lise. 
        /// </summary>
        private string descricaopadrao;
        [XmlElement(ElementName = "DESCRICAOPADRAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricaopadrao
        {
            get { return  descricaopadrao; }
            set {  descricaopadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Coment�rio: Data de cadastro do laudo. 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDLAUDO
        /// Coment�rio: Identifica��o do Laudo.
        /// </summary>
        private decimal idlaudo;
        [XmlElement(ElementName = "IDLAUDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Idlaudo
        {
            get { return  idlaudo; }
            set {  idlaudo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORPADRAO
        /// Coment�rio: Valor padr�o da an�lise. 
        /// </summary>
        private string valorpadrao;
        [XmlElement(ElementName = "VALORPADRAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Valorpadrao
        {
            get { return  valorpadrao; }
            set {  valorpadrao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERSAO
        /// Coment�rio: Vers�o das especifica��es. 
        /// </summary>
        private decimal versao;
        [XmlElement(ElementName = "VERSAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Versao
        {
            get { return  versao; }
            set {  versao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLaudoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLAUDOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLaudoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLaudoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLaudoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLaudoc>(where);
        }

        #endregion
    }
}
