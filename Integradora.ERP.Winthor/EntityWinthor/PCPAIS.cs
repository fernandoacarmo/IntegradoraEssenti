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
    /// Classe referente a tabela PCPais
    /// </summary>
    [XmlType("PCPAIS")]
    public class PCPais : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODESTADUAL
        /// Coment�rio: C�digo estadual.
        /// </summary>
        private decimal codestadual;
        [XmlElement(ElementName = "CODESTADUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codestadual
        {
            get { return  codestadual; }
            set {  codestadual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPAIS
        /// Coment�rio: 
        /// </summary>
        private decimal codpais;
        [XmlElement(ElementName = "CODPAIS", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codpais
        {
            get { return  codpais; }
            set {  codpais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSISCOMEX
        /// Coment�rio: C�digo SISCOMEX do pa�s.
        /// </summary>
        private decimal codsiscomex;
        [XmlElement(ElementName = "CODSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codsiscomex
        {
            get { return  codsiscomex; }
            set {  codsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,60)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPais()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPAIS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPais> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPais>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPais> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPais>(where);
        }

        #endregion
    }
}
