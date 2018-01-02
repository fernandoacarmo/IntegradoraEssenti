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
    /// Classe referente a tabela PCAutorios
    /// </summary>
    [XmlType("PCAUTORIOS")]
    public class PCAutorios : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCAO
        /// Comentário: 
        /// </summary>
        private decimal codfuncao;
        [XmlElement(ElementName = "CODFUNCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfuncao
        {
            get { return  codfuncao; }
            set {  codfuncao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOPERFIL
        /// Comentário: 
        /// </summary>
        private decimal codigoperfil;
        [XmlElement(ElementName = "CODIGOPERFIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codigoperfil
        {
            get { return  codigoperfil; }
            set {  codigoperfil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOOS
        /// Comentário: 
        /// </summary>
        private decimal codtipoos;
        [XmlElement(ElementName = "CODTIPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codtipoos
        {
            get { return  codtipoos; }
            set {  codtipoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: Indica a matricula do funcionario.
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAutorios()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCAUTORIOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAutorios> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAutorios>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAutorios> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAutorios>(where);
        }

        #endregion
    }
}
