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
    /// Classe referente a tabela PCClassificmerc
    /// </summary>
    [XmlType("PCCLASSIFICMERC")]
    public class PCClassificmerc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Comentário: Categoria vinculada a classificacao.
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLASSIFICMERC
        /// Comentário: Chave primaria para a tabela.
        /// </summary>
        private decimal codclassificmerc;
        [XmlElement(ElementName = "CODCLASSIFICMERC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codclassificmerc
        {
            get { return  codclassificmerc; }
            set {  codclassificmerc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDEPTO
        /// Comentário: Departamento vinculado a classificacao.
        /// </summary>
        private decimal coddepto;
        [XmlElement(ElementName = "CODDEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Coddepto
        {
            get { return  coddepto; }
            set {  coddepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Representa para qual filial sera válido a regra.
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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Produto vinculado a classificacao.
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSEC
        /// Comentário: Seção vinculada a classificacao.
        /// </summary>
        private decimal codsec;
        [XmlElement(ElementName = "CODSEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsec
        {
            get { return  codsec; }
            set {  codsec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODST
        /// Comentário: Codigo da Situacao tributaria.
        /// </summary>
        private decimal codst;
        [XmlElement(ElementName = "CODST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codst
        {
            get { return  codst; }
            set {  codst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIA
        /// Comentário: Sub Categoria vinculada a classificacao.
        /// </summary>
        private decimal codsubcategoria;
        [XmlElement(ElementName = "CODSUBCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsubcategoria
        {
            get { return  codsubcategoria; }
            set {  codsubcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMATAC
        /// Comentário: Margem para sugerir preço de atacado.
        /// </summary>
        private decimal margematac;
        [XmlElement(ElementName = "MARGEMATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Margematac
        {
            get { return  margematac; }
            set {  margematac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMMINATAC
        /// Comentário: Margem minima para sugerir preco de atacado.
        /// </summary>
        private decimal margemminatac;
        [XmlElement(ElementName = "MARGEMMINATAC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Margemminatac
        {
            get { return  margemminatac; }
            set {  margemminatac = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMMINVAREJO
        /// Comentário: Margem minima para sugerir preco varejo.
        /// </summary>
        private decimal margemminvarejo;
        [XmlElement(ElementName = "MARGEMMINVAREJO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Margemminvarejo
        {
            get { return  margemminvarejo; }
            set {  margemminvarejo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMVAREJO
        /// Comentário: Margem para sugerir preço de varejo.
        /// </summary>
        private decimal margemvarejo;
        [XmlElement(ElementName = "MARGEMVAREJO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Margemvarejo
        {
            get { return  margemvarejo; }
            set {  margemvarejo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCClassificmerc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLASSIFICMERC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCClassificmerc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClassificmerc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCClassificmerc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCClassificmerc>(where);
        }

        #endregion
    }
}
