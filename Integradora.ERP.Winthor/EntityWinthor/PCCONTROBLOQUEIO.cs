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
    /// Classe referente a tabela PCControbloqueio
    /// </summary>
    [XmlType("PCCONTROBLOQUEIO")]
    public class PCControbloqueio : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCLIBBLOQ
        /// Comentário: 
        /// </summary>
        private decimal codfunclibbloq;
        [XmlElement(ElementName = "CODFUNCLIBBLOQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunclibbloq
        {
            get { return  codfunclibbloq; }
            set {  codfunclibbloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTBLOQUEIO
        /// Comentário: 
        /// </summary>
        private decimal codmotbloqueio;
        [XmlElement(ElementName = "CODMOTBLOQUEIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codmotbloqueio
        {
            get { return  codmotbloqueio; }
            set {  codmotbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTMOTBLOQUEIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtmotbloqueio;
        [XmlElement(ElementName = "DTMOTBLOQUEIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtmotbloqueio
        {
            get { return  dtmotbloqueio; }
            set {  dtmotbloqueio = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCControbloqueio()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTROBLOQUEIO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCControbloqueio> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCControbloqueio>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCControbloqueio> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCControbloqueio>(where);
        }

        #endregion
    }
}
