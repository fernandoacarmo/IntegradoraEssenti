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
    /// Classe referente a tabela PCClientfingerid
    /// </summary>
    [XmlType("PCCLIENTFINGERID")]
    public class PCClientfingerid : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTATO
        /// Comentário: 
        /// </summary>
        private decimal codcontato;
        [XmlElement(ElementName = "CODCONTATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcontato
        {
            get { return  codcontato; }
            set {  codcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTER
        /// Comentário: 
        /// </summary>
        private DateTime? dtultalter;
        [XmlElement(ElementName = "DTULTALTER", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalter
        {
            get { return  dtultalter; }
            set {  dtultalter = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FINGERFIR
        /// Comentário: 
        /// </summary>
        private string fingerfir;
        [XmlElement(ElementName = "FINGERFIR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1000)]
        public string Fingerfir
        {
            get { return  fingerfir; }
            set {  fingerfir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FINGERID
        /// Comentário: 
        /// </summary>
        private decimal fingerid;
        [XmlElement(ElementName = "FINGERID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Fingerid
        {
            get { return  fingerid; }
            set {  fingerid = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCClientfingerid()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLIENTFINGERID";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCClientfingerid> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClientfingerid>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCClientfingerid> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCClientfingerid>(where);
        }

        #endregion
    }
}
