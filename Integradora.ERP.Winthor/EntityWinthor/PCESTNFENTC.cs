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
    /// Classe referente a tabela PCEstnfentc
    /// </summary>
    [XmlType("PCESTNFENTC")]
    public class PCEstnfentc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Coment�rio: 
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTENT
        /// Coment�rio: 
        /// </summary>
        private decimal qtent;
        [XmlElement(ElementName = "QTENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtent
        {
            get { return  qtent; }
            set {  qtent = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCEstnfentc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCESTNFENTC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEstnfentc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEstnfentc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCEstnfentc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEstnfentc>(where);
        }

        #endregion
    }
}
