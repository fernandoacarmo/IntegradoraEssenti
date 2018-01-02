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
    /// Classe referente a tabela PCMovselo
    /// </summary>
    [XmlType("PCMOVSELO")]
    public class PCMovselo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODGUIA
        /// Comentário: CODGUIA
        /// </summary>
        private string codguia;
        [XmlElement(ElementName = "CODGUIA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,14)]
        public string Codguia
        {
            get { return  codguia; }
            set {  codguia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSENT
        /// Comentário: NUMTRANSENT
        /// </summary>
        private decimal numtransent;
        [XmlElement(ElementName = "NUMTRANSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransent
        {
            get { return  numtransent; }
            set {  numtransent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSITEM
        /// Comentário: NUMTRANSITEM
        /// </summary>
        private decimal numtransitem;
        [XmlElement(ElementName = "NUMTRANSITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransitem
        {
            get { return  numtransitem; }
            set {  numtransitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: NUMTRANSVENDA
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTSAIDA
        /// Comentário: QTSAIDA
        /// </summary>
        private decimal qtsaida;
        [XmlElement(ElementName = "QTSAIDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtsaida
        {
            get { return  qtsaida; }
            set {  qtsaida = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMovselo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMOVSELO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMovselo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMovselo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMovselo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMovselo>(where);
        }

        #endregion
    }
}
