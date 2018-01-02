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
    /// Classe referente a tabela PCCentrotrabmanut
    /// </summary>
    [XmlType("PCCENTROTRABMANUT")]
    public class PCCentrotrabmanut : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCENTROTRAB
        /// Comentário: 
        /// </summary>
        private decimal codcentrotrab;
        [XmlElement(ElementName = "CODCENTROTRAB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcentrotrab
        {
            get { return  codcentrotrab; }
            set {  codcentrotrab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAMANUT
        /// Comentário: 
        /// </summary>
        private DateTime? datamanut;
        [XmlElement(ElementName = "DATAMANUT", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datamanut
        {
            get { return  datamanut; }
            set {  datamanut = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: 
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPO
        /// Comentário: 
        /// </summary>
        private decimal tempo;
        [XmlElement(ElementName = "TEMPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Tempo
        {
            get { return  tempo; }
            set {  tempo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCentrotrabmanut()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCENTROTRABMANUT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCentrotrabmanut> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCentrotrabmanut>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCentrotrabmanut> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCentrotrabmanut>(where);
        }

        #endregion
    }
}
