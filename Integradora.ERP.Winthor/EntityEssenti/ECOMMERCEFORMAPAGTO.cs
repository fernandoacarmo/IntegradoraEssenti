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
    /// Classe referente a tabela Ecommerceformapagto
    /// </summary>
    [XmlType("ECOMMERCEFORMAPAGTO")]
    public class Ecommerceformapagto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Coment�rio: 
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGONOECOMMERCE
        /// Coment�rio: 
        /// </summary>
        private string codigonoecommerce;
        [XmlElement(ElementName = "CODIGONOECOMMERCE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Codigonoecommerce
        {
            get { return  codigonoecommerce; }
            set {  codigonoecommerce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Coment�rio: 
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
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
        /// Propriedade referente ao campo: CODUSUARIOCAD
        /// Coment�rio: 
        /// </summary>
        private decimal codusuariocad;
        [XmlElement(ElementName = "CODUSUARIOCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codusuariocad
        {
            get { return  codusuariocad; }
            set {  codusuariocad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAONOECOMMERCE
        /// Coment�rio: 
        /// </summary>
        private string descricaonoecommerce;
        [XmlElement(ElementName = "DESCRICAONOECOMMERCE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Descricaonoecommerce
        {
            get { return  descricaonoecommerce; }
            set {  descricaonoecommerce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
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
        /// Propriedade referente ao campo: ECOMMERCE
        /// Coment�rio: 
        /// </summary>
        private string ecommerce;
        [XmlElement(ElementName = "ECOMMERCE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Ecommerce
        {
            get { return  ecommerce; }
            set {  ecommerce = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Ecommerceformapagto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ECOMMERCEFORMAPAGTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Ecommerceformapagto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<Ecommerceformapagto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Ecommerceformapagto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<Ecommerceformapagto>(where);
        }

        #endregion
    }
}
