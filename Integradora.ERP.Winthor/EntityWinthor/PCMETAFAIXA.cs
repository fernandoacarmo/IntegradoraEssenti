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
    /// Classe referente a tabela PCMetafaixa
    /// </summary>
    [XmlType("PCMETAFAIXA")]
    public class PCMetafaixa : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: Indica o c�digo da filial.
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGO
        /// Coment�rio:  Indica o c�digo da meta relacionada.
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
        /// Coment�rio: Indica o segundo c�digo da meta relacionada.
        /// </summary>
        private decimal codigo2;
        [XmlElement(ElementName = "CODIGO2", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codigo2
        {
            get { return  codigo2; }
            set {  codigo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNA
        /// Coment�rio: Indica o nome da coluna de meta a que se refere esta pontua��o.
        /// </summary>
        private string coluna;
        [XmlElement(ElementName = "COLUNA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,32)]
        public string Coluna
        {
            get { return  coluna; }
            set {  coluna = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Coment�rio: Indica a data de final do per�odo de vig�ncia da pontua��o.
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Coment�rio: Indica a data de in�cio do per�odo de vig�ncia da pontua��o.
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAFIM
        /// Coment�rio: Indica o % de final desta faixa de pontua��o da meta.
        /// </summary>
        private decimal faixafim;
        [XmlElement(ElementName = "FAIXAFIM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public decimal Faixafim
        {
            get { return  faixafim; }
            set {  faixafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAIXAINI
        /// Coment�rio: Indica o % de in�cio desta faixa de pontua��o da meta.
        /// </summary>
        private decimal faixaini;
        [XmlElement(ElementName = "FAIXAINI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public decimal Faixaini
        {
            get { return  faixaini; }
            set {  faixaini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPONTOS
        /// Coment�rio: Indica a quantidade de pontos ao atingir a meta nesta faixa de pontua��o.
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
        /// Coment�rio: Indica o tipo de meta.
        /// </summary>
        private string tipometa;
        [XmlElement(ElementName = "TIPOMETA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Tipometa
        {
            get { return  tipometa; }
            set {  tipometa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPREMIO
        /// Coment�rio: Indica o tipo de premia��o.
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

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCMetafaixa()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMETAFAIXA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCMetafaixa> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMetafaixa>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCMetafaixa> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMetafaixa>(where);
        }

        #endregion
    }
}
