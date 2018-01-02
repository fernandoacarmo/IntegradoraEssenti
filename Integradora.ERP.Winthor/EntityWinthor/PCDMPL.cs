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
    /// Classe referente a tabela PCDmpl
    /// </summary>
    [XmlType("PCDMPL")]
    public class PCDmpl : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODDMPL
        /// Comentário: Código
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

        /// <summary>
        /// Propriedade referente ao campo: DLPA
        /// Comentário: Estrutura é DLPA
        /// </summary>
        private string dlpa;
        [XmlElement(ElementName = "DLPA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dlpa
        {
            get { return  dlpa; }
            set {  dlpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORNEGATIVOEXIBIR
        /// Comentário: Exibir valor negativo
        /// </summary>
        private string valornegativoexibir;
        [XmlElement(ElementName = "VALORNEGATIVOEXIBIR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Valornegativoexibir
        {
            get { return  valornegativoexibir; }
            set {  valornegativoexibir = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDmpl()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDMPL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDmpl> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDmpl>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDmpl> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDmpl>(where);
        }

        #endregion
    }
}
