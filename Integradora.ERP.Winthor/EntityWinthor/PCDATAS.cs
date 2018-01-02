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
    /// Classe referente a tabela PCDatas
    /// </summary>
    [XmlType("PCDATAS")]
    public class PCDatas : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AUXTMP
        /// Comentário: 
        /// </summary>
        private decimal auxtmp;
        [XmlElement(ElementName = "AUXTMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Auxtmp
        {
            get { return  auxtmp; }
            set {  auxtmp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAUTIL
        /// Comentário: 
        /// </summary>
        private string diautil;
        [XmlElement(ElementName = "DIAUTIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diautil
        {
            get { return  diautil; }
            set {  diautil = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDatas()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDATAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDatas> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDatas>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDatas> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDatas>(where);
        }

        #endregion
    }
}
