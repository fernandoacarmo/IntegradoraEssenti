using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityAjuri
{
    /// <summary>
    /// Classe referente a tabela ESTDepartamento
    /// </summary>
    [XmlType("ESTDEPARTAMENTO")]
    public class ESTDepartamento : BaseAjuri
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODANTIGO
        /// Comentário: 
        /// </summary>
        private decimal codantigo;
        [XmlElement(ElementName = "CODANTIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codantigo
        {
            get { return  codantigo; }
            set {  codantigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codigo
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
        public ESTDepartamento()
        {
            Inicializar();
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTDEPARTAMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTDepartamento> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTDepartamento.GetStringConnection());
            return ba.Listar<ESTDepartamento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTDepartamento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTDepartamento.GetStringConnection());
            return ba.Existe<ESTDepartamento>(where);
        }

        #endregion
    }
}
