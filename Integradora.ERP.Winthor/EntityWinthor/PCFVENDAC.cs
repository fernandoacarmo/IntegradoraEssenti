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
    /// Classe referente a tabela PCFvendac
    /// </summary>
    [XmlType("PCFVENDAC")]
    public class PCFvendac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ARGUMENTOBUSCA
        /// Comentário: 
        /// </summary>
        private string argumentobusca;
        [XmlElement(ElementName = "ARGUMENTOBUSCA", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Argumentobusca
        {
            get { return  argumentobusca; }
            set {  argumentobusca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODARQ
        /// Comentário: 
        /// </summary>
        private decimal codarq;
        [XmlElement(ElementName = "CODARQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codarq
        {
            get { return  codarq; }
            set {  codarq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNFV
        /// Comentário: 
        /// </summary>
        private decimal codfornfv;
        [XmlElement(ElementName = "CODFORNFV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornfv
        {
            get { return  codfornfv; }
            set {  codfornfv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPAUTOMATICA
        /// Comentário: 
        /// </summary>
        private string expautomatica;
        [XmlElement(ElementName = "EXPAUTOMATICA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Expautomatica
        {
            get { return  expautomatica; }
            set {  expautomatica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMATONOMEARQ
        /// Comentário: 
        /// </summary>
        private string formatonomearq;
        [XmlElement(ElementName = "FORMATONOMEARQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Formatonomearq
        {
            get { return  formatonomearq; }
            set {  formatonomearq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEARQ
        /// Comentário: 
        /// </summary>
        private string nomearq;
        [XmlElement(ElementName = "NOMEARQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomearq
        {
            get { return  nomearq; }
            set {  nomearq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOARGUMENTO
        /// Comentário: 
        /// </summary>
        private string tipoargumento;
        [XmlElement(ElementName = "TIPOARGUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Tipoargumento
        {
            get { return  tipoargumento; }
            set {  tipoargumento = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFvendac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFVENDAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFvendac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFvendac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFvendac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFvendac>(where);
        }

        #endregion
    }
}
