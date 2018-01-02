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
    /// Classe referente a tabela PCProdutnestle
    /// </summary>
    [XmlType("PCPRODUTNESTLE")]
    public class PCProdutnestle : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR2
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar2;
        [XmlElement(ElementName = "CODAUXILIAR2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar2
        {
            get { return  codauxiliar2; }
            set {  codauxiliar2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR3
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar3;
        [XmlElement(ElementName = "CODAUXILIAR3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar3
        {
            get { return  codauxiliar3; }
            set {  codauxiliar3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR4
        /// Comentário: 
        /// </summary>
        private decimal codauxiliar4;
        [XmlElement(ElementName = "CODAUXILIAR4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Codauxiliar4
        {
            get { return  codauxiliar4; }
            set {  codauxiliar4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFAMILIANESTLE
        /// Comentário: 
        /// </summary>
        private decimal codfamilianestle;
        [XmlElement(ElementName = "CODFAMILIANESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfamilianestle
        {
            get { return  codfamilianestle; }
            set {  codfamilianestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPONESTLE
        /// Comentário: 
        /// </summary>
        private decimal codgruponestle;
        [XmlElement(ElementName = "CODGRUPONESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codgruponestle
        {
            get { return  codgruponestle; }
            set {  codgruponestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private string codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBGRUPONESTLE
        /// Comentário: 
        /// </summary>
        private decimal codsubgruponestle;
        [XmlElement(ElementName = "CODSUBGRUPONESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codsubgruponestle
        {
            get { return  codsubgruponestle; }
            set {  codsubgruponestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORQTUNITCX
        /// Comentário: Indica o fator de conversão da quantidade master.
        /// </summary>
        private decimal fatorqtunitcx;
        [XmlElement(ElementName = "FATORQTUNITCX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Fatorqtunitcx
        {
            get { return  fatorqtunitcx; }
            set {  fatorqtunitcx = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdutnestle()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUTNESTLE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdutnestle> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdutnestle>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdutnestle> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdutnestle>(where);
        }

        #endregion
    }
}
