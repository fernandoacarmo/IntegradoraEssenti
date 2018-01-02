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
    /// Classe referente a tabela PCDocempresaseditaishab
    /// </summary>
    [XmlType("PCDOCEMPRESASEDITAISHAB")]
    public class PCDocempresaseditaishab : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODEDITAL
        /// Coment�rio: C�digo edital.
        /// </summary>
        private decimal codedital;
        [XmlElement(ElementName = "CODEDITAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Codedital
        {
            get { return  codedital; }
            set {  codedital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPODOCUMENTO
        /// Coment�rio: C�digo do tipo do documento.
        /// </summary>
        private decimal codtipodocumento;
        [XmlElement(ElementName = "CODTIPODOCUMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codtipodocumento
        {
            get { return  codtipodocumento; }
            set {  codtipodocumento = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDocempresaseditaishab()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDOCEMPRESASEDITAISHAB";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDocempresaseditaishab> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDocempresaseditaishab>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDocempresaseditaishab> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDocempresaseditaishab>(where);
        }

        #endregion
    }
}
