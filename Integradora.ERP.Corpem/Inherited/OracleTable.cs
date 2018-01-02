using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Corpem.Inherited
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

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false, false, false, 7)]
        public DateTime? Dtinclusao
        {
            get { return dtinclusao; }
            set { dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracao;
        [XmlElement(ElementName = "DTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false, false, true, 7)]
        public DateTime? Dtalteracao
        {
            get { return dtalteracao; }
            set { dtalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: 
        /// </summary>
        private string semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public string Semaforo
        {
            get { return semaforo; }
            set { semaforo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO
        /// Comentário: Campo de observação das integração
        /// </summary>
        private string obsintegracao;   
        [XmlElement(ElementName = "OBSINTEGRACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false, false, true, 4000)]
        public string Obsintegracao
        {
            get { return obsintegracao; }
            set { obsintegracao = value; }
        }
   }
}
