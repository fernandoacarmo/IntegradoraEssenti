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
    /// Classe referente a tabela PCPerfilusuariowms
    /// </summary>
    [XmlType("PCPERFILUSUARIOWMS")]
    public class PCPerfilusuariowms : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGOPERFIL
        /// Comentário: 
        /// </summary>
        private decimal codigoperfil;
        [XmlElement(ElementName = "CODIGOPERFIL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,20)]
        public decimal Codigoperfil
        {
            get { return  codigoperfil; }
            set {  codigoperfil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOPERFIL
        /// Comentário: 
        /// </summary>
        private string descricaoperfil;
        [XmlElement(ElementName = "DESCRICAOPERFIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricaoperfil
        {
            get { return  descricaoperfil; }
            set {  descricaoperfil = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPerfilusuariowms()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPERFILUSUARIOWMS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPerfilusuariowms> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPerfilusuariowms>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPerfilusuariowms> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPerfilusuariowms>(where);
        }

        #endregion
    }
}
