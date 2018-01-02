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
    /// Classe referente a tabela Esvparametros
    /// </summary>
    [XmlType("ESVPARAMETROS")]
    public class Esvparametros : OracleView
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DIRETORIO
        /// Comentário: 
        /// </summary>
        private string diretorio;
        [XmlElement(ElementName = "DIRETORIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Diretorio
        {
            get { return  diretorio; }
            set {  diretorio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCUSTO
        /// Comentário: 
        /// </summary>
        private decimal tipocusto;
        [XmlElement(ElementName = "TIPOCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Tipocusto
        {
            get { return  tipocusto; }
            set {  tipocusto = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Esvparametros()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetViewName()
        {
            return "ESVPARAMETROS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Esvparametros> Listar(string where)
        {
            Persistencia ba = new Persistencia(Esvparametros.GetStringConnection());
            return ba.Listar<Esvparametros>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Esvparametros> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(Esvparametros.GetStringConnection());
            return ba.Existe<Esvparametros>(where);
        }

        #endregion
    }
}
