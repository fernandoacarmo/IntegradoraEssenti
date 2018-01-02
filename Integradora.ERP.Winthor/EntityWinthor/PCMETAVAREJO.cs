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
    /// Classe referente a tabela PCMetavarejo
    /// </summary>
    [XmlType("PCMETAVAREJO")]
    public class PCMetavarejo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Comentário: Código categoria
        /// </summary>
        private decimal codcategoria;
        [XmlElement(ElementName = "CODCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codcategoria
        {
            get { return  codcategoria; }
            set {  codcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Comentário: Código departamento
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: CÓDIGO DA FILIAL
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCADASTRO
        /// Comentário: CÓDIGO FUNCIONÁRIO QUE CADASTROU
        /// </summary>
        private decimal codfunccadastro;
        [XmlElement(ElementName = "CODFUNCCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccadastro
        {
            get { return  codfunccadastro; }
            set {  codfunccadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Comentário: CÓDIGO DO FUNCIONÁRIO DA EXCLUSÃO
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCULTALT
        /// Comentário: CÓDIGO FUNCIONÁRIO QUE ALTEROU
        /// </summary>
        private decimal codfuncultalt;
        [XmlElement(ElementName = "CODFUNCULTALT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncultalt
        {
            get { return  codfuncultalt; }
            set {  codfuncultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: CÓDIGO DA META
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
        /// Propriedade referente ao campo: CODIGO2
        /// Comentário: CÓDIGO SECUNDARIO DA META
        /// </summary>
        private decimal codigo2;
        [XmlElement(ElementName = "CODIGO2", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codigo2
        {
            get { return  codigo2; }
            set {  codigo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO3
        /// Comentário: Código Seçao
        /// </summary>
        private decimal codigo3;
        [XmlElement(ElementName = "CODIGO3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codigo3
        {
            get { return  codigo3; }
            set {  codigo3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO4
        /// Comentário: Código Categoria
        /// </summary>
        private decimal codigo4;
        [XmlElement(ElementName = "CODIGO4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codigo4
        {
            get { return  codigo4; }
            set {  codigo4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO5
        /// Comentário: Código Sub Categoria
        /// </summary>
        private decimal codigo5;
        [XmlElement(ElementName = "CODIGO5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codigo5
        {
            get { return  codigo5; }
            set {  codigo5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO6
        /// Comentário: Código da Subcategoria
        /// </summary>
        private decimal codigo6;
        [XmlElement(ElementName = "CODIGO6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codigo6
        {
            get { return  codigo6; }
            set {  codigo6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSECAO
        /// Comentário: Código seção
        /// </summary>
        private decimal codsecao;
        [XmlElement(ElementName = "CODSECAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsecao
        {
            get { return  codsecao; }
            set {  codsecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIA
        /// Comentário: Código subcategoria
        /// </summary>
        private decimal codsubcategoria;
        [XmlElement(ElementName = "CODSUBCATEGORIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codsubcategoria
        {
            get { return  codsubcategoria; }
            set {  codsubcategoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA
        /// Comentário: COLUNA DE ALTERAÇÃO DA META
        /// </summary>
        private string coluna;
        [XmlElement(ElementName = "COLUNA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,32)]
        public string Coluna
        {
            get { return  coluna; }
            set {  coluna = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: DATA CADASTRO DA META
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: DATA DA EXCLUSÃO
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Comentário: DATA FINAL DA META
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: DATA INICIAL DA META
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALT
        /// Comentário: DATA DA ULTIMA ALTERAÇÃO
        /// </summary>
        private DateTime? dtultalt;
        [XmlElement(ElementName = "DTULTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalt
        {
            get { return  dtultalt; }
            set {  dtultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAFIM
        /// Comentário: FAIXA DE VALOR FINAL DA META
        /// </summary>
        private decimal faixafim;
        [XmlElement(ElementName = "FAIXAFIM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Faixafim
        {
            get { return  faixafim; }
            set {  faixafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAINI
        /// Comentário: FAIXA DE VALOR INICIAL DA META
        /// </summary>
        private decimal faixaini;
        [XmlElement(ElementName = "FAIXAINI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public decimal Faixaini
        {
            get { return  faixaini; }
            set {  faixaini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOS
        /// Comentário: QUANTIDADE DE PONTOS DA META
        /// </summary>
        private decimal qtpontos;
        [XmlElement(ElementName = "QTPONTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Qtpontos
        {
            get { return  qtpontos; }
            set {  qtpontos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMETA
        /// Comentário: TIPO DA META
        /// </summary>
        private string tipometa;
        [XmlElement(ElementName = "TIPOMETA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipometa
        {
            get { return  tipometa; }
            set {  tipometa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPREMIO
        /// Comentário: TIPO DO PREMIO DA META
        /// </summary>
        private string tipopremio;
        [XmlElement(ElementName = "TIPOPREMIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipopremio
        {
            get { return  tipopremio; }
            set {  tipopremio = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMetavarejo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETAVAREJO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMetavarejo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetavarejo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMetavarejo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetavarejo>(where);
        }

        #endregion
    }
}
