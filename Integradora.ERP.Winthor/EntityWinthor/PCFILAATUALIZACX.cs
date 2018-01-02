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
    /// Classe referente a tabela PCFilaatualizacx
    /// </summary>
    [XmlType("PCFILAATUALIZACX")]
    public class PCFilaatualizacx : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ID
        /// Comentário: 
        /// </summary>
        private decimal id;
        [XmlElement(ElementName = "ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,22)]
        public decimal Id
        {
            get { return  id; }
            set {  id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDRATUALIZADO
        /// Comentário: 
        /// </summary>
        private string indratualizado;
        [XmlElement(ElementName = "INDRATUALIZADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Indratualizado
        {
            get { return  indratualizado; }
            set {  indratualizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMETABELA
        /// Comentário: 
        /// </summary>
        private string nometabela;
        [XmlElement(ElementName = "NOMETABELA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,30)]
        public string Nometabela
        {
            get { return  nometabela; }
            set {  nometabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: 
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORSEQ
        /// Comentário: 
        /// </summary>
        private decimal valorseq;
        [XmlElement(ElementName = "VALORSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Valorseq
        {
            get { return  valorseq; }
            set {  valorseq = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFilaatualizacx()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFILAATUALIZACX";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFilaatualizacx> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFilaatualizacx>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFilaatualizacx> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFilaatualizacx>(where);
        }

        #endregion
    }
}
