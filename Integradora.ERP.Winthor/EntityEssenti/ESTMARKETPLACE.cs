using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTMarketplace
    /// </summary>
    [XmlType("ESTMARKETPLACE")]
    public class ESTMarketplace : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioalt;
        [XmlElement(ElementName = "CODUSUARIOALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuarioalt
        {
            get { return  codusuarioalt; }
            set {  codusuarioalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOINC
        /// Coment�rio: 
        /// </summary>
        private decimal codusuarioinc;
        [XmlElement(ElementName = "CODUSUARIOINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuarioinc
        {
            get { return  codusuarioinc; }
            set {  codusuarioinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 6)]
        public decimal Codcli
        {
            get { return codcli; }
            set { codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAVENCTO
        /// Coment�rio: 
        /// </summary>
        private decimal diavencto;
        [XmlElement(ElementName = "DIAVENCTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Diavencto
        {
            get { return  diavencto; }
            set {  diavencto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANA
        /// Coment�rio: 
        /// </summary>
        private decimal diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal Diasemana
        {
            get { return diasemana; }
            set { diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMANANOMES
        /// Coment�rio: 
        /// </summary>
        private decimal semananomes;
        [XmlElement(ElementName = "SEMANANOMES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal Semananomes
        {
            get { return semananomes; }
            set { semananomes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRCDIFERENCAVLTOTAL
        /// Coment�rio: 
        /// </summary>
        private decimal prcdiferencavltotal;
        [XmlElement(ElementName = "PRCDIFERENCAVLTOTAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 22)]
        public decimal Prcdiferencavltotal
        {
            get { return prcdiferencavltotal; }
            set { prcdiferencavltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtalteracao
        {
            get { return  dtalteracao; }
            set {  dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARKETPLACE_ID
        /// Coment�rio: 
        /// </summary>
        private string marketplace_id;
        [XmlElement(ElementName = "MARKETPLACE_ID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Marketplace_Id
        {
            get { return  marketplace_id; }
            set {  marketplace_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPAGTO
        /// Coment�rio: 
        /// </summary>
        private string tipopagto;
        [XmlElement(ElementName = "TIPOPAGTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipopagto
        {
            get { return  tipopagto; }
            set {  tipopagto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTMarketplace()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTMARKETPLACE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTMarketplace> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTMarketplace.GetStringConnection());
            return ba.Listar<ESTMarketplace>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTMarketplace> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTMarketplace.GetStringConnection());
            return ba.Existe<ESTMarketplace>(where);
        }

        #endregion
    }
}
