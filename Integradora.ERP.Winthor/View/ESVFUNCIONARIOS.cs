using Integradora.Biblioteca.Interfaces;
using Integradora.Biblioteca.Tools;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.EntityAjuri;
using Integradora.ERP.Winthor.Inherited;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Integradora.ERP.Winthor.View
{
    /// <summary>
    /// Classe referente a tabela Esvfuncionarios
    /// </summary>
    [XmlType("ESVFUNCIONARIOS")]
    public class Esvfuncionarios : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCIONARIO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncionario;
        [XmlElement(ElementName = "CODFUNCIONARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codfuncionario
        {
            get { return  codfuncionario; }
            set {  codfuncionario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCIONARIO
        /// Coment�rio: 
        /// </summary>
        private string funcionario;
        [XmlElement(ElementName = "FUNCIONARIO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Funcionario
        {
            get { return  funcionario; }
            set {  funcionario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Coment�rio: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public Esvfuncionarios()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVFUNCIONARIOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<Esvfuncionarios> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvfuncionarios.GetStringConnection());
            return ba.Listar<Esvfuncionarios>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<Esvfuncionarios> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvfuncionarios.GetStringConnection());
            return ba.Existe<Esvfuncionarios>(where);
        }

        #endregion
    }
}
