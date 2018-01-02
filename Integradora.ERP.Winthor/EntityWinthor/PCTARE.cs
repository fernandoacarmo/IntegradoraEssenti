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
    /// Classe referente a tabela PCTare
    /// </summary>
    [XmlType("PCTARE")]
    public class PCTare : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALI
        /// Comentário: 
        /// </summary>
        private decimal ali;
        [XmlElement(ElementName = "ALI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Ali
        {
            get { return  ali; }
            set {  ali = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ALT
        /// Comentário: 
        /// </summary>
        private decimal alt;
        [XmlElement(ElementName = "ALT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Alt
        {
            get { return  alt; }
            set {  alt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLT
        /// Comentário: 
        /// </summary>
        private string clt;
        [XmlElement(ElementName = "CLT", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Clt
        {
            get { return  clt; }
            set {  clt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOC
        /// Comentário: 
        /// </summary>
        private string loc;
        [XmlElement(ElementName = "LOC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Loc
        {
            get { return  loc; }
            set {  loc = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTare()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTARE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTare> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTare>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTare> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTare>(where);
        }

        #endregion
    }
}
