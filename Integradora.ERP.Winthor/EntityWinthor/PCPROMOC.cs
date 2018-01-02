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
    /// Classe referente a tabela PCPromoc
    /// </summary>
    [XmlType("PCPROMOC")]
    public class PCPromoc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APLICARCAMPANHAFAMILIA
        /// Comentário: 
        /// </summary>
        private string aplicarcampanhafamilia;
        [XmlElement(ElementName = "APLICARCAMPANHAFAMILIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicarcampanhafamilia
        {
            get { return  aplicarcampanhafamilia; }
            set {  aplicarcampanhafamilia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAO
        /// Comentário: 
        /// </summary>
        private decimal codpromocao;
        [XmlElement(ElementName = "CODPROMOCAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codpromocao
        {
            get { return  codpromocao; }
            set {  codpromocao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METODOLOGIA
        /// Comentário: 
        /// </summary>
        private string metodologia;
        [XmlElement(ElementName = "METODOLOGIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,500)]
        public string Metodologia
        {
            get { return  metodologia; }
            set {  metodologia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIPONTOSMETA
        /// Comentário: 
        /// </summary>
        private string multipontosmeta;
        [XmlElement(ElementName = "MULTIPONTOSMETA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Multipontosmeta
        {
            get { return  multipontosmeta; }
            set {  multipontosmeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMIXMIN
        /// Comentário: Quantidade minima de itens do MIX incluído.
        /// </summary>
        private decimal qtmixmin;
        [XmlElement(ElementName = "QTMIXMIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtmixmin
        {
            get { return  qtmixmin; }
            set {  qtmixmin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOSNOVOSCLIENTES
        /// Comentário: 
        /// </summary>
        private decimal qtpontosnovosclientes;
        [XmlElement(ElementName = "QTPONTOSNOVOSCLIENTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtpontosnovosclientes
        {
            get { return  qtpontosnovosclientes; }
            set {  qtpontosnovosclientes = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPromoc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPROMOC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPromoc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPromoc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPromoc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPromoc>(where);
        }

        #endregion
    }
}
