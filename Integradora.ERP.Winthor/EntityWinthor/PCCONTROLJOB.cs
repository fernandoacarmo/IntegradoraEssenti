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
    /// Classe referente a tabela PCControljob
    /// </summary>
    [XmlType("PCCONTROLJOB")]
    public class PCControljob : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: INICIO
        /// Comentário: inicio do processo.
        /// </summary>
        private DateTime? inicio;
        [XmlElement(ElementName = "INICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Inicio
        {
            get { return  inicio; }
            set {  inicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPROCESSO
        /// Comentário: nome do processo.
        /// </summary>
        private string nomeprocesso;
        [XmlElement(ElementName = "NOMEPROCESSO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomeprocesso
        {
            get { return  nomeprocesso; }
            set {  nomeprocesso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARAMETROS
        /// Comentário: parametros.
        /// </summary>
        private string parametros;
        [XmlElement(ElementName = "PARAMETROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Parametros
        {
            get { return  parametros; }
            set {  parametros = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCControljob()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTROLJOB";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCControljob> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCControljob>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCControljob> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCControljob>(where);
        }

        #endregion
    }
}
