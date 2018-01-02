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
    /// Classe referente a tabela PCTabela
    /// </summary>
    [XmlType("PCTABELA")]
    public class PCTabela : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APETABELA
        /// Comentário: 
        /// </summary>
        private string apetabela;
        [XmlElement(ElementName = "APETABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Apetabela
        {
            get { return  apetabela; }
            set {  apetabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTABELA
        /// Comentário: 
        /// </summary>
        private decimal codtabela;
        [XmlElement(ElementName = "CODTABELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codtabela
        {
            get { return  codtabela; }
            set {  codtabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTABELA
        /// Comentário: 
        /// </summary>
        private string destabela;
        [XmlElement(ElementName = "DESTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Destabela
        {
            get { return  destabela; }
            set {  destabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMTABELA
        /// Comentário: 
        /// </summary>
        private string nomtabela;
        [XmlElement(ElementName = "NOMTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Nomtabela
        {
            get { return  nomtabela; }
            set {  nomtabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTabela()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTABELA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTabela> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTabela>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTabela> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTabela>(where);
        }

        #endregion
    }
}
