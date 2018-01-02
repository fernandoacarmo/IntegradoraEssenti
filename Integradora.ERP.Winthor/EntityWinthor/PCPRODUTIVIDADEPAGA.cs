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
    /// Classe referente a tabela PCProdutividadepaga
    /// </summary>
    [XmlType("PCPRODUTIVIDADEPAGA")]
    public class PCProdutividadepaga : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: Referencia do ano de produtividade.
        /// </summary>
        private string ano;
        [XmlElement(ElementName = "ANO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial
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
        /// Propriedade referente ao campo: CODFUNCSEP
        /// Coment�rio: C�d. Do fornecedor.
        /// </summary>
        private decimal codfuncsep;
        [XmlElement(ElementName = "CODFUNCSEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncsep
        {
            get { return  codfuncsep; }
            set {  codfuncsep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMETAVALOR
        /// Coment�rio: C�digo relacionado � meta escolhida
        /// </summary>
        private decimal codmetavalor;
        [XmlElement(ElementName = "CODMETAVALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codmetavalor
        {
            get { return  codmetavalor; }
            set {  codmetavalor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRODUTIVIDADEPAGA
        /// Coment�rio: C�d. Da produtividade paga.
        /// </summary>
        private decimal codprodutividadepaga;
        [XmlElement(ElementName = "CODPRODUTIVIDADEPAGA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprodutividadepaga
        {
            get { return  codprodutividadepaga; }
            set {  codprodutividadepaga = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Coment�rio: Referencia do m�s de produtividade.
        /// </summary>
        private string mes;
        [XmlElement(ElementName = "MES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METAAPAGAR
        /// Coment�rio: Valor a pagar da meta cumprida.
        /// </summary>
        private decimal metaapagar;
        [XmlElement(ElementName = "METAAPAGAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Metaapagar
        {
            get { return  metaapagar; }
            set {  metaapagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METAFINAL
        /// Coment�rio: O maior valor da meta que se espera a ser cumprida.
        /// </summary>
        private decimal metafinal;
        [XmlElement(ElementName = "METAFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Metafinal
        {
            get { return  metafinal; }
            set {  metafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METAINICIAL
        /// Coment�rio: Valor minimo da meta a ser cumprida.
        /// </summary>
        private decimal metainicial;
        [XmlElement(ElementName = "METAINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Metainicial
        {
            get { return  metainicial; }
            set {  metainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: METAREALIZADA
        /// Coment�rio: Meta realizada pelo separador.
        /// </summary>
        private decimal metarealizada;
        [XmlElement(ElementName = "METAREALIZADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Metarealizada
        {
            get { return  metarealizada; }
            set {  metarealizada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECNUM
        /// Coment�rio: Numero que faz referencia ao contas a pagar gerado.
        /// </summary>
        private decimal recnum;
        [XmlElement(ElementName = "RECNUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Recnum
        {
            get { return  recnum; }
            set {  recnum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPRODUTIVIDADE
        /// Coment�rio: Referencia do itpo de produtividade.
        /// </summary>
        private string tipoprodutividade;
        [XmlElement(ElementName = "TIPOPRODUTIVIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoprodutividade
        {
            get { return  tipoprodutividade; }
            set {  tipoprodutividade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAPAGAR
        /// Coment�rio: Valor real a ser paga para o separador.
        /// </summary>
        private decimal vlapagar;
        [XmlElement(ElementName = "VLAPAGAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Vlapagar
        {
            get { return  vlapagar; }
            set {  vlapagar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLORIGINAL
        /// Coment�rio: Valor a ser pago para o separador.
        /// </summary>
        private decimal vloriginal;
        [XmlElement(ElementName = "VLORIGINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Vloriginal
        {
            get { return  vloriginal; }
            set {  vloriginal = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCProdutividadepaga()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPRODUTIVIDADEPAGA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCProdutividadepaga> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCProdutividadepaga>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCProdutividadepaga> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCProdutividadepaga>(where);
        }

        #endregion
    }
}
