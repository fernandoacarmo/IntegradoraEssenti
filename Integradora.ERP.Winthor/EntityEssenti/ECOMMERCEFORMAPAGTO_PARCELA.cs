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
    /// Classe referente a tabela Ecommerceformapagto_Parcela
    /// </summary>
    [XmlType("ECOMMERCEFORMAPAGTO_PARCELA")]
    public class Ecommerceformapagto_Parcela : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGONOECOMMERCE
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODUSUARIOCAD
        /// Comentário: 
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
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: ECOMMERCE
        /// Comentário: 
        /// </summary>
        private string ecommerce;
        [XmlElement(ElementName = "ECOMMERCE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Ecommerce
        {
            get { return  ecommerce; }
            set {  ecommerce = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPARCELA
        /// Comentário: 
        /// </summary>
        private decimal numparcela;
        [XmlElement(ElementName = "NUMPARCELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numparcela
        {
            get { return  numparcela; }
            set {  numparcela = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Ecommerceformapagto_Parcela()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ECOMMERCEFORMAPAGTO_PARCELA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Ecommerceformapagto_Parcela> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<Ecommerceformapagto_Parcela>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Ecommerceformapagto_Parcela> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<Ecommerceformapagto_Parcela>(where);
        }

        #endregion
    }
}
