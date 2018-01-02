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
    /// Classe referente a tabela PCParamestrelas
    /// </summary>
    [XmlType("PCPARAMESTRELAS")]
    public class PCParamestrelas : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: QTESTRELAS
        /// Coment�rio: 
        /// </summary>
        private decimal qtestrelas;
        [XmlElement(ElementName = "QTESTRELAS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Qtestrelas
        {
            get { return  qtestrelas; }
            set {  qtestrelas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VRFINAL
        /// Coment�rio: 
        /// </summary>
        private decimal vrfinal;
        [XmlElement(ElementName = "VRFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vrfinal
        {
            get { return  vrfinal; }
            set {  vrfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VRINICIAL
        /// Coment�rio: 
        /// </summary>
        private decimal vrinicial;
        [XmlElement(ElementName = "VRINICIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public decimal Vrinicial
        {
            get { return  vrinicial; }
            set {  vrinicial = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCParamestrelas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPARAMESTRELAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCParamestrelas> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCParamestrelas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCParamestrelas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCParamestrelas>(where);
        }

        #endregion
    }
}
