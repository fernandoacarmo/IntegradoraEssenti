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
    /// Classe referente a tabela ESTLogpreco_ecommerce
    /// </summary>
    [XmlType("ESTLOGPRECO_ECOMMERCE")]
    public class ESTLogpreco_ecommerce : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTREPLICACAO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtreplicacao;
        [XmlElement(ElementName = "DTREPLICACAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtreplicacao
        {
            get { return  dtreplicacao; }
            set {  dtreplicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PVENDA
        /// Coment�rio: 
        /// </summary>
        private decimal pvenda;
        [XmlElement(ElementName = "PVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,22)]
        public decimal Pvenda
        {
            get { return  pvenda; }
            set {  pvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REGISTRO
        /// Coment�rio: 
        /// </summary>
        private string registro;
        [XmlElement(ElementName = "REGISTRO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,60)]
        public string Registro
        {
            get { return  registro; }
            set {  registro = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public ESTLogpreco_ecommerce()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTLOGPRECO_ECOMMERCE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<ESTLogpreco_ecommerce> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTLogpreco_ecommerce.GetStringConnection());
            return ba.Listar<ESTLogpreco_ecommerce>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<ESTLogpreco_ecommerce> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTLogpreco_ecommerce.GetStringConnection());
            return ba.Existe<ESTLogpreco_ecommerce>(where);
        }

        #endregion
    }
}
