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
    /// Classe referente a tabela PCMetaoscomodparticip
    /// </summary>
    [XmlType("PCMETAOSCOMODPARTICIP")]
    public class PCMetaoscomodparticip : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPARTICIP
        /// Coment�rio: Campo para armazenar o c�digo do participante meta.
        /// </summary>
        private decimal codparticip;
        [XmlElement(ElementName = "CODPARTICIP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codparticip
        {
            get { return  codparticip; }
            set {  codparticip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMETA
        /// Coment�rio: Campo para armazenar o c�digo da meta
        /// </summary>
        private decimal nummeta;
        [XmlElement(ElementName = "NUMMETA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Nummeta
        {
            get { return  nummeta; }
            set {  nummeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPARTCIP
        /// Coment�rio: Campo para armazenar o tipo de participante
        /// </summary>
        private decimal tipopartcip;
        [XmlElement(ElementName = "TIPOPARTCIP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public decimal Tipopartcip
        {
            get { return  tipopartcip; }
            set {  tipopartcip = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMetaoscomodparticip()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETAOSCOMODPARTICIP";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMetaoscomodparticip> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetaoscomodparticip>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMetaoscomodparticip> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetaoscomodparticip>(where);
        }

        #endregion
    }
}
