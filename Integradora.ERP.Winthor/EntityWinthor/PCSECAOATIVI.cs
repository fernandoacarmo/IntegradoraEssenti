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
    /// Classe referente a tabela PCSecaoativi
    /// </summary>
    [XmlType("PCSECAOATIVI")]
    public class PCSecaoativi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Coment�rio: 
        /// </summary>
        private decimal codativ;
        [XmlElement(ElementName = "CODATIV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codativ
        {
            get { return  codativ; }
            set {  codativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Coment�rio: 
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCIMPORTACAO
        /// Coment�rio: 
        /// </summary>
        private decimal percdescimportacao;
        [XmlElement(ElementName = "PERCDESCIMPORTACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Percdescimportacao
        {
            get { return  percdescimportacao; }
            set {  percdescimportacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCSecaoativi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSECAOATIVI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCSecaoativi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCSecaoativi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCSecaoativi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCSecaoativi>(where);
        }

        #endregion
    }
}
