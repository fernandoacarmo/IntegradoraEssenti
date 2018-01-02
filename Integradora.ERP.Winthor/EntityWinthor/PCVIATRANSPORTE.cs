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
    /// Classe referente a tabela PCViatransporte
    /// </summary>
    [XmlType("PCVIATRANSPORTE")]
    public class PCViatransporte : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODSISCOMEX
        /// Comentário: Código SISCOMEX da Via de Transporte.
        /// </summary>
        private decimal codsiscomex;
        [XmlElement(ElementName = "CODSISCOMEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codsiscomex
        {
            get { return  codsiscomex; }
            set {  codsiscomex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVIA
        /// Comentário: Código da Via de Transporte.
        /// </summary>
        private decimal codvia;
        [XmlElement(ElementName = "CODVIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codvia
        {
            get { return  codvia; }
            set {  codvia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição da Via de Transporte.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
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
        public PCViatransporte()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVIATRANSPORTE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCViatransporte> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCViatransporte>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCViatransporte> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCViatransporte>(where);
        }

        #endregion
    }
}
