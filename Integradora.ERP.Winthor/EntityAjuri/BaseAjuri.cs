using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.EntityAjuri
{
    public class BaseAjuri : OracleTable
    {

        #region Atributos
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
        /// Propriedade referente ao campo: NUMAJURI
        /// Comentário: 
        /// </summary>
        private string numajuri;
        [XmlElement(ElementName = "NUMAJURI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 20)]
        public string Numajuri
        {
            get { return numajuri; }
            set { numajuri = value; }
        }
        
        /// <summary>
        /// Propriedade referente ao campo: OBSINTEGRACAO
        /// Comentário: 
        /// </summary>
        private string obsintegracao;
        [XmlElement(ElementName = "OBSINTEGRACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false, false, true, 4000)]
        public string Obsintegracao
        {
            get { return obsintegracao; }
            set { obsintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: 
        /// </summary>
        private decimal semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false, false, false, 2)]
        public decimal Semaforo
        {
            get { return semaforo; }
            set { semaforo = value; }
        }

        #endregion

        #region Métodos
        public BaseAjuri()
        {
            Inicializar();
        }
        public override string GetTableName()
        {
            return "BaseAjuri";
        }

        public void Inicializar()
        {
            Dtalteracao = DataHoraServidor();
            Dtinclusao = Dtalteracao;
            Semaforo = 0;
        }
        #endregion
    }
}
