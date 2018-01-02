using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.ERP.Corpem.Inherited;
using Integradora.ERP.Corpem.Persistente;

namespace Integradora.ERP.Corpem.Entity
{
    /// <summary>
    /// Classe referente a tabela ESTNcm
    /// </summary>
    [XmlType("ESTNCM")]
    public class ESTNcm : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAPITULO
        /// Comentário: 
        /// </summary>
        private Int16 capitulo;
        [XmlElement(ElementName = "CAPITULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public Int16 Capitulo
        {
            get { return  capitulo; }
            set {  capitulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private string codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NCM
        /// Comentário: 
        /// </summary>
        private Int64 ncm;
        [XmlElement(ElementName = "NCM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public Int64 Ncm
        {
            get { return  ncm; }
            set {  ncm = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTNcm()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTNCM";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTNcm> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTNcm.GetStringConnection());
            return ba.Listar<ESTNcm>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTNcm> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTNcm.GetStringConnection());
            return ba.Existe<ESTNcm>(where);
        }

        #endregion
    }
}
