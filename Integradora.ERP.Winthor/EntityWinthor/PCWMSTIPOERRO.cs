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
    /// Classe referente a tabela PCWmstipoerro
    /// </summary>
    [XmlType("PCWMSTIPOERRO")]
    public class PCWmstipoerro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
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
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOACERTO
        /// Comentário: 
        /// </summary>
        private decimal pesoacerto;
        [XmlElement(ElementName = "PESOACERTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pesoacerto
        {
            get { return  pesoacerto; }
            set {  pesoacerto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOERRO
        /// Comentário: 
        /// </summary>
        private decimal pesoerro;
        [XmlElement(ElementName = "PESOERRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pesoerro
        {
            get { return  pesoerro; }
            set {  pesoerro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOOS
        /// Comentário: 
        /// </summary>
        private string tipoos;
        [XmlElement(ElementName = "TIPOOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoos
        {
            get { return  tipoos; }
            set {  tipoos = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmstipoerro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSTIPOERRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmstipoerro> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmstipoerro.GetStringConnection());
            return ba.Listar<PCWmstipoerro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmstipoerro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmstipoerro.GetStringConnection());
            return ba.Existe<PCWmstipoerro>(where);
        }

        #endregion
    }
}
