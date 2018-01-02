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
    /// Classe referente a tabela ESTMarketplace_periodo
    /// </summary>
    [XmlType("ESTMARKETPLACE_PERIODO")]
    public class ESTMarketplace_periodo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIOALT
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: DIAFINAL
        /// Comentário: 
        /// </summary>
        private decimal diafinal;
        [XmlElement(ElementName = "DIAFINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Diafinal
        {
            get { return  diafinal; }
            set {  diafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAINICIO
        /// Comentário: 
        /// </summary>
        private decimal diainicio;
        [XmlElement(ElementName = "DIAINICIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Diainicio
        {
            get { return  diainicio; }
            set {  diainicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAVENCTO
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
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
        /// Comentário: 
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
        /// Comentário: 
        /// </summary>
        private string marketplace_id;
        [XmlElement(ElementName = "MARKETPLACE_ID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public string Marketplace_Id
        {
            get { return  marketplace_id; }
            set {  marketplace_id = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTMarketplace_periodo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTMARKETPLACE_PERIODO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTMarketplace_periodo> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTMarketplace_periodo.GetStringConnection());
            return ba.Listar<ESTMarketplace_periodo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTMarketplace_periodo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTMarketplace_periodo.GetStringConnection());
            return ba.Existe<ESTMarketplace_periodo>(where);
        }

        #endregion
    }
}
