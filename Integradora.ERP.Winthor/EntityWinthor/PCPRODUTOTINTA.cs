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
    /// Classe referente a tabela PCProdutotinta
    /// </summary>
    [XmlType("PCPRODUTOTINTA")]
    public class PCProdutotinta : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAPACIDADEVOLUMELATA
        /// Comentário: 
        /// </summary>
        private decimal capacidadevolumelata;
        [XmlElement(ElementName = "CAPACIDADEVOLUMELATA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Capacidadevolumelata
        {
            get { return  capacidadevolumelata; }
            set {  capacidadevolumelata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBASETIPO
        /// Comentário: CÓD. DO TIPO BASE DA TINTA
        /// </summary>
        private string codbasetipo;
        [XmlElement(ElementName = "CODBASETIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codbasetipo
        {
            get { return  codbasetipo; }
            set {  codbasetipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHA
        /// Comentário: 
        /// </summary>
        private string codlinha;
        [XmlElement(ElementName = "CODLINHA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codlinha
        {
            get { return  codlinha; }
            set {  codlinha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Comentário: 
        /// </summary>
        private decimal codmaquina;
        [XmlElement(ElementName = "CODMAQUINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmaquina
        {
            get { return  codmaquina; }
            set {  codmaquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODTINTA
        /// Comentário: 
        /// </summary>
        private string codprodtinta;
        [XmlElement(ElementName = "CODPRODTINTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codprodtinta
        {
            get { return  codprodtinta; }
            set {  codprodtinta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODWINTHOR
        /// Comentário: 
        /// </summary>
        private decimal codprodwinthor;
        [XmlElement(ElementName = "CODPRODWINTHOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodwinthor
        {
            get { return  codprodwinthor; }
            set {  codprodwinthor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTCOMP
        /// Comentário: 
        /// </summary>
        private string codtcomp;
        [XmlElement(ElementName = "CODTCOMP", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codtcomp
        {
            get { return  codtcomp; }
            set {  codtcomp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCPROD
        /// Comentário: 
        /// </summary>
        private string descprod;
        [XmlElement(ElementName = "DESCPROD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,70)]
        public string Descprod
        {
            get { return  descprod; }
            set {  descprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOESPECIFICO
        /// Comentário: 
        /// </summary>
        private decimal pesoespecifico;
        [XmlElement(ElementName = "PESOESPECIFICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pesoespecifico
        {
            get { return  pesoespecifico; }
            set {  pesoespecifico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCProdutotinta()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUTOTINTA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCProdutotinta> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdutotinta>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCProdutotinta> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdutotinta>(where);
        }

        #endregion
    }
}
