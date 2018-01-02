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
    /// Classe referente a tabela PCDescontofidelidade
    /// </summary>
    [XmlType("PCDESCONTOFIDELIDADE")]
    public class PCDescontofidelidade : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APLICARAUTOMATICO
        /// Coment�rio: Aplicar desconto automaticamente.
        /// </summary>
        private string aplicarautomatico;
        [XmlElement(ElementName = "APLICARAUTOMATICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicarautomatico
        {
            get { return  aplicarautomatico; }
            set {  aplicarautomatico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIA
        /// Coment�rio: C�digo da categoria.
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
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLICONVENIO
        /// Coment�rio: C�digo do convenio.
        /// </summary>
        private decimal codcliconvenio;
        [XmlElement(ElementName = "CODCLICONVENIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcliconvenio
        {
            get { return  codcliconvenio; }
            set {  codcliconvenio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEPTO
        /// Coment�rio: C�digo do departamento.
        /// </summary>
        private decimal codepto;
        [XmlElement(ElementName = "CODEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codepto
        {
            get { return  codepto; }
            set {  codepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFIDELIDADE
        /// Coment�rio: C�digo sequencial do cadastro.
        /// </summary>
        private decimal codfidelidade;
        [XmlElement(ElementName = "CODFIDELIDADE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfidelidade
        {
            get { return  codfidelidade; }
            set {  codfidelidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial.
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: C�digo do fornecedor.
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Coment�rio: C�digo do funcion�rio que excluiu
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto.
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
        /// Coment�rio: C�digo se��o
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
        /// Propriedade referente ao campo: CODSECAO
        /// Coment�rio: C�digo da se��o
        /// </summary>
        private decimal codsecao;
        [XmlElement(ElementName = "CODSECAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsecao
        {
            get { return  codsecao; }
            set {  codsecao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUBCATEGORIA
        /// Coment�rio: C�digo da subcategoria.
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
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�digo do vendedor.
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Coment�rio: Data de exclus�o
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
        /// Propriedade referente ao campo: DTFINAL
        /// Coment�rio: Data final da vig�ncia da fidelidade.
        /// </summary>
        private DateTime? dtfinal;
        [XmlElement(ElementName = "DTFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfinal
        {
            get { return  dtfinal; }
            set {  dtfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIAL
        /// Coment�rio: Data inicial da vig�ncia da fidelidade.
        /// </summary>
        private DateTime? dtinicial;
        [XmlElement(ElementName = "DTINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicial
        {
            get { return  dtinicial; }
            set {  dtinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FISCALCAIXA
        /// Coment�rio: Somente o fiscal de caixa pode aplicar o desconto.
        /// </summary>
        private string fiscalcaixa;
        [XmlElement(ElementName = "FISCALCAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Fiscalcaixa
        {
            get { return  fiscalcaixa; }
            set {  fiscalcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCONTO
        /// Coment�rio: Percentual de desconto.
        /// </summary>
        private decimal percdesconto;
        [XmlElement(ElementName = "PERCDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdesconto
        {
            get { return  percdesconto; }
            set {  percdesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESCONTO
        /// Coment�rio: Valor do desconto.
        /// </summary>
        private decimal vldesconto;
        [XmlElement(ElementName = "VLDESCONTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vldesconto
        {
            get { return  vldesconto; }
            set {  vldesconto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCDescontofidelidade()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESCONTOFIDELIDADE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCDescontofidelidade> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDescontofidelidade>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCDescontofidelidade> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDescontofidelidade>(where);
        }

        #endregion
    }
}
