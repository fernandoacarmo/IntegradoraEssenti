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
    /// Classe referente a tabela PCTipoestrutura
    /// </summary>
    [XmlType("PCTIPOESTRUTURA")]
    public class PCTipoestrutura : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: 
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA1
        /// Comentário: 
        /// </summary>
        private string coluna1;
        [XmlElement(ElementName = "COLUNA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Coluna1
        {
            get { return  coluna1; }
            set {  coluna1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA2
        /// Comentário: 
        /// </summary>
        private string coluna2;
        [XmlElement(ElementName = "COLUNA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Coluna2
        {
            get { return  coluna2; }
            set {  coluna2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA3
        /// Comentário: 
        /// </summary>
        private string coluna3;
        [XmlElement(ElementName = "COLUNA3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Coluna3
        {
            get { return  coluna3; }
            set {  coluna3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA4
        /// Comentário: 
        /// </summary>
        private string coluna4;
        [XmlElement(ElementName = "COLUNA4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Coluna4
        {
            get { return  coluna4; }
            set {  coluna4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA5
        /// Comentário: 
        /// </summary>
        private string coluna5;
        [XmlElement(ElementName = "COLUNA5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Coluna5
        {
            get { return  coluna5; }
            set {  coluna5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA6
        /// Comentário: 
        /// </summary>
        private string coluna6;
        [XmlElement(ElementName = "COLUNA6", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Coluna6
        {
            get { return  coluna6; }
            set {  coluna6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,15)]
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
        public PCTipoestrutura()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTIPOESTRUTURA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTipoestrutura> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTipoestrutura>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTipoestrutura> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTipoestrutura>(where);
        }

        #endregion
    }
}
