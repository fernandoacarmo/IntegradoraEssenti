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
    /// Classe referente a tabela PCLacreedi
    /// </summary>
    [XmlType("PCLACREEDI")]
    public class PCLacreedi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: NUMCARGAEDI
        /// Comentário: Número da Carga p/ EDI
        /// </summary>
        private decimal numcargaedi;
        [XmlElement(ElementName = "NUMCARGAEDI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcargaedi
        {
            get { return  numcargaedi; }
            set {  numcargaedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLACRE
        /// Comentário: Número Lacre
        /// </summary>
        private decimal numlacre;
        [XmlElement(ElementName = "NUMLACRE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,9)]
        public decimal Numlacre
        {
            get { return  numlacre; }
            set {  numlacre = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLacreedi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLACREEDI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLacreedi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLacreedi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLacreedi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLacreedi>(where);
        }

        #endregion
    }
}
