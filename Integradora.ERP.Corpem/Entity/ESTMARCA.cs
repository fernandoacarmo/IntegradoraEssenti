using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.ERP.Corpem.Persistente;
using Integradora.ERP.Corpem.Inherited;

namespace Integradora.ERP.Corpem.Entity
{
    /// <summary>
    /// Classe referente a tabela ESTMarca
    /// </summary>
    [XmlType("ESTMARCA")]
    public class ESTMarca : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private Int32 codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public Int32 Codigo
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


        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTMarca()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTMARCA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTMarca> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTMarca.GetStringConnection());
            return ba.Listar<ESTMarca>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTMarca> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTMarca.GetStringConnection());
            return ba.Existe<ESTMarca>(where);
        }

        #endregion
    }
}
