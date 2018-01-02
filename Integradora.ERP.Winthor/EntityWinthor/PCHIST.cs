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
    /// Classe referente a tabela PCHist
    /// </summary>
    [XmlType("PCHIST")]
    public class PCHist : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CMSUSAREMUNERACAO
        /// Comentário: 
        /// </summary>
        private string cmsusaremuneracao;
        [XmlElement(ElementName = "CMSUSAREMUNERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cmsusaremuneracao
        {
            get { return  cmsusaremuneracao; }
            set {  cmsusaremuneracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHIST
        /// Comentário: 
        /// </summary>
        private decimal codhist;
        [XmlElement(ElementName = "CODHIST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codhist
        {
            get { return  codhist; }
            set {  codhist = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTA
        /// Comentário: Indica se os clientes bloqueados com este histórico serão ou não exportados para o força de vendas. 
        /// </summary>
        private string exporta;
        [XmlElement(ElementName = "EXPORTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exporta
        {
            get { return  exporta; }
            set {  exporta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO
        /// Comentário: 
        /// </summary>
        private string historico;
        [XmlElement(ElementName = "HISTORICO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Historico
        {
            get { return  historico; }
            set {  historico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCHist()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCHIST";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCHist> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCHist>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCHist> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCHist>(where);
        }

        #endregion
    }
}
