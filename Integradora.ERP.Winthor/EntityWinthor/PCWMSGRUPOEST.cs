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
    /// Classe referente a tabela PCWmsgrupoest
    /// </summary>
    [XmlType("PCWMSGRUPOEST")]
    public class PCWmsgrupoest : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMINHOIMPRESSORA
        /// Comentário: 
        /// </summary>
        private string caminhoimpressora;
        [XmlElement(ElementName = "CAMINHOIMPRESSORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Caminhoimpressora
        {
            get { return  caminhoimpressora; }
            set {  caminhoimpressora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
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
        [DataObjectField(false,false,true,20)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDENAR
        /// Comentário: 
        /// </summary>
        private string ordenar;
        [XmlElement(ElementName = "ORDENAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ordenar
        {
            get { return  ordenar; }
            set {  ordenar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDENARLADOIMPAR
        /// Comentário: 
        /// </summary>
        private string ordenarladoimpar;
        [XmlElement(ElementName = "ORDENARLADOIMPAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ordenarladoimpar
        {
            get { return  ordenarladoimpar; }
            set {  ordenarladoimpar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDENARLADOPAR
        /// Comentário: 
        /// </summary>
        private string ordenarladopar;
        [XmlElement(ElementName = "ORDENARLADOPAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ordenarladopar
        {
            get { return  ordenarladopar; }
            set {  ordenarladopar = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmsgrupoest()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSGRUPOEST";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmsgrupoest> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsgrupoest.GetStringConnection());
            return ba.Listar<PCWmsgrupoest>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmsgrupoest> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsgrupoest.GetStringConnection());
            return ba.Existe<PCWmsgrupoest>(where);
        }

        #endregion
    }
}
