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
    /// Classe referente a tabela PCInfextra
    /// </summary>
    [XmlType("PCINFEXTRA")]
    public class PCInfextra : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Sequencial do registro
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição Ingrediente
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE1
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente1;
        [XmlElement(ElementName = "INGREDIENTE1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente1
        {
            get { return  ingrediente1; }
            set {  ingrediente1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE10
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente10;
        [XmlElement(ElementName = "INGREDIENTE10", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente10
        {
            get { return  ingrediente10; }
            set {  ingrediente10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE11
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente11;
        [XmlElement(ElementName = "INGREDIENTE11", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente11
        {
            get { return  ingrediente11; }
            set {  ingrediente11 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE12
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente12;
        [XmlElement(ElementName = "INGREDIENTE12", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente12
        {
            get { return  ingrediente12; }
            set {  ingrediente12 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE13
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente13;
        [XmlElement(ElementName = "INGREDIENTE13", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente13
        {
            get { return  ingrediente13; }
            set {  ingrediente13 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE14
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente14;
        [XmlElement(ElementName = "INGREDIENTE14", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente14
        {
            get { return  ingrediente14; }
            set {  ingrediente14 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE15
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente15;
        [XmlElement(ElementName = "INGREDIENTE15", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente15
        {
            get { return  ingrediente15; }
            set {  ingrediente15 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE2
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente2;
        [XmlElement(ElementName = "INGREDIENTE2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente2
        {
            get { return  ingrediente2; }
            set {  ingrediente2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE3
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente3;
        [XmlElement(ElementName = "INGREDIENTE3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente3
        {
            get { return  ingrediente3; }
            set {  ingrediente3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE4
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente4;
        [XmlElement(ElementName = "INGREDIENTE4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente4
        {
            get { return  ingrediente4; }
            set {  ingrediente4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE5
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente5;
        [XmlElement(ElementName = "INGREDIENTE5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente5
        {
            get { return  ingrediente5; }
            set {  ingrediente5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE6
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente6;
        [XmlElement(ElementName = "INGREDIENTE6", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente6
        {
            get { return  ingrediente6; }
            set {  ingrediente6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE7
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente7;
        [XmlElement(ElementName = "INGREDIENTE7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente7
        {
            get { return  ingrediente7; }
            set {  ingrediente7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE8
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente8;
        [XmlElement(ElementName = "INGREDIENTE8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente8
        {
            get { return  ingrediente8; }
            set {  ingrediente8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INGREDIENTE9
        /// Comentário: Ingrediente pra compor produto
        /// </summary>
        private string ingrediente9;
        [XmlElement(ElementName = "INGREDIENTE9", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,56)]
        public string Ingrediente9
        {
            get { return  ingrediente9; }
            set {  ingrediente9 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInfextra()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINFEXTRA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInfextra> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInfextra>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInfextra> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInfextra>(where);
        }

        #endregion
    }
}
