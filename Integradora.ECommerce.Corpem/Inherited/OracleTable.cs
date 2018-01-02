using Integradora.Database.Oracle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ECommerce.Corpem.Inherited
{
    public abstract class OracleTable : OracleObjeto
    {
        public OracleTable()
        {
        }
        public abstract string GetTableName();

        /// <summary>
        /// Propriedade referente ao campo: OID
        /// Comentário: ROWID do Oracle, mas por motivos do mesmo não vir no select, deve ser utilizado um apelido
        /// </summary>
        private string oid;
        [XmlElement(ElementName = "OID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, true, 40)]
        public string OID
        {
            get { return oid; }
            set { oid = value; }
        }
   }
}
