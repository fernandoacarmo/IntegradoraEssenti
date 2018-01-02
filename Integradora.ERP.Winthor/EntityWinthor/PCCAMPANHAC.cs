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
    /// Classe referente a tabela PCCampanhac
    /// </summary>
    [XmlType("PCCAMPANHAC")]
    public class PCCampanhac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial ao qual a campanha de venda pertence.
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
        /// Coment�rio: Indica o c�digo do fornecedor da campanha de vendas.
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
        /// Propriedade referente ao campo: CODFUNCCAD
        /// Coment�rio: Indiaca o c�digo do funcion�rio que realizou o cadastramento da campanha de vendas.
        /// </summary>
        private decimal codfunccad;
        [XmlElement(ElementName = "CODFUNCCAD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccad
        {
            get { return  codfunccad; }
            set {  codfunccad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCFECHA
        /// Coment�rio: Indica o c�digo do funcion�rio que realizou a apura��o e fechamento da campanha de vendas.
        /// </summary>
        private decimal codfuncfecha;
        [XmlElement(ElementName = "CODFUNCFECHA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncfecha
        {
            get { return  codfuncfecha; }
            set {  codfuncfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio: Indica o c�digo da campanha de venda.
        /// </summary>
        private decimal codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Indica a descri��o da campanha de venda.
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
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Indiaca a data de cadastro da campanha de vendas.
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
        /// Propriedade referente ao campo: DTFECHA
        /// Coment�rio: Indica a data de apura��o e fechamento da campanha de vendas.
        /// </summary>
        private DateTime? dtfecha;
        [XmlElement(ElementName = "DTFECHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfecha
        {
            get { return  dtfecha; }
            set {  dtfecha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: Indica a vig�ncia final da campanha de vendas.
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Indica a vig�ncia inicial da campanha de vendas.
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREMPERC
        /// Coment�rio: Indica o percentual de premia��o a ser aplicado sobre o total da venda.
        /// </summary>
        private decimal premperc;
        [XmlElement(ElementName = "PREMPERC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Premperc
        {
            get { return  premperc; }
            set {  premperc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREMVALOR
        /// Coment�rio: Indica o valor da premia��o da campanha de vendas.
        /// </summary>
        private decimal premvalor;
        [XmlElement(ElementName = "PREMVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Premvalor
        {
            get { return  premvalor; }
            set {  premvalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Indica a situa��o da campanha. Os valores poss�veis ser�o [A]Ativa e [I]Inativa.
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCAMPANHA
        /// Coment�rio: Indica o tipo da campanha de vendas: [P]Produto ou [F]Fornecedor.
        /// </summary>
        private string tipocampanha;
        [XmlElement(ElementName = "TIPOCAMPANHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocampanha
        {
            get { return  tipocampanha; }
            set {  tipocampanha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPREMIACAO
        /// Coment�rio: Indica o tipo da premia��o: [UN]�nica, [PR]Proporcional e [UM]M�ltiplo.
        /// </summary>
        private string tipopremiacao;
        [XmlElement(ElementName = "TIPOPREMIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipopremiacao
        {
            get { return  tipopremiacao; }
            set {  tipopremiacao = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCampanhac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCAMPANHAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCampanhac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCampanhac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCampanhac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCampanhac>(where);
        }

        #endregion
    }
}
