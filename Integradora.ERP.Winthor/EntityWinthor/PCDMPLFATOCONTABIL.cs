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
    /// Classe referente a tabela PCDmplfatocontabil
    /// </summary>
    [XmlType("PCDMPLFATOCONTABIL")]
    public class PCDmplfatocontabil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Comentário: Ativo
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDMPL
        /// Comentário: Código DMPL
        /// </summary>
        private decimal coddmpl;
        [XmlElement(ElementName = "CODDMPL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Coddmpl
        {
            get { return  coddmpl; }
            set {  coddmpl = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFATOCONTABIL
        /// Comentário: Código Fato Contábil
        /// </summary>
        private string codfatocontabil;
        [XmlElement(ElementName = "CODFATOCONTABIL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public string Codfatocontabil
        {
            get { return  codfatocontabil; }
            set {  codfatocontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDmplfatocontabil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDMPLFATOCONTABIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDmplfatocontabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDmplfatocontabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDmplfatocontabil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDmplfatocontabil>(where);
        }

        #endregion
    }
}
