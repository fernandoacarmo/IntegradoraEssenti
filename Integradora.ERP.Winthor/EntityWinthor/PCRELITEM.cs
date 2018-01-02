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
    /// Classe referente a tabela PCRelitem
    /// </summary>
    [XmlType("PCRELITEM")]
    public class PCRelitem : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODGRUPO
        /// Coment�rio: C�digo do Grupo.
        /// </summary>
        private decimal codgrupo;
        [XmlElement(ElementName = "CODGRUPO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codgrupo
        {
            get { return  codgrupo; }
            set {  codgrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODITEM
        /// Coment�rio: C�digo do Item.
        /// </summary>
        private decimal coditem;
        [XmlElement(ElementName = "CODITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Coditem
        {
            get { return  coditem; }
            set {  coditem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIO_ALIQUOTA
        /// Coment�rio: Crit�rio Aliquota
        /// </summary>
        private string criterio_aliquota;
        [XmlElement(ElementName = "CRITERIO_ALIQUOTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Criterio_Aliquota
        {
            get { return  criterio_aliquota; }
            set {  criterio_aliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIO_CFOP
        /// Coment�rio: Crit�rio CFOP
        /// </summary>
        private string criterio_cfop;
        [XmlElement(ElementName = "CRITERIO_CFOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Criterio_Cfop
        {
            get { return  criterio_cfop; }
            set {  criterio_cfop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIO_ESPECIE
        /// Coment�rio: Crit�rio Esp�cie
        /// </summary>
        private string criterio_especie;
        [XmlElement(ElementName = "CRITERIO_ESPECIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Criterio_Especie
        {
            get { return  criterio_especie; }
            set {  criterio_especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIO_OPERACAO
        /// Coment�rio: Crit�rio Opera��o
        /// </summary>
        private string criterio_operacao;
        [XmlElement(ElementName = "CRITERIO_OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Criterio_Operacao
        {
            get { return  criterio_operacao; }
            set {  criterio_operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIO_SERIE
        /// Coment�rio: Indica o crit�rio s�rie
        /// </summary>
        private string criterio_serie;
        [XmlElement(ElementName = "CRITERIO_SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Criterio_Serie
        {
            get { return  criterio_serie; }
            set {  criterio_serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CRITERIO_TIPOPESSOA
        /// Coment�rio: Crit�rio Tipo Pessoa
        /// </summary>
        private string criterio_tipopessoa;
        [XmlElement(ElementName = "CRITERIO_TIPOPESSOA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Criterio_Tipopessoa
        {
            get { return  criterio_tipopessoa; }
            set {  criterio_tipopessoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o.
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPRESSAO_VLBASE
        /// Coment�rio: Indica o campo que guarda a express�o da base de calculo.
        /// </summary>
        private string expressao_vlbase;
        [XmlElement(ElementName = "EXPRESSAO_VLBASE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Expressao_Vlbase
        {
            get { return  expressao_vlbase; }
            set {  expressao_vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPRESSAO_VLCONTABIL
        /// Coment�rio: Indica o campo que guarda a express�o do valor cont�bil.
        /// </summary>
        private string expressao_vlcontabil;
        [XmlElement(ElementName = "EXPRESSAO_VLCONTABIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Expressao_Vlcontabil
        {
            get { return  expressao_vlcontabil; }
            set {  expressao_vlcontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPRESSAO_VLICMS
        /// Coment�rio: Indica o campo que guarda a express�o de ICMS.
        /// </summary>
        private string expressao_vlicms;
        [XmlElement(ElementName = "EXPRESSAO_VLICMS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Expressao_Vlicms
        {
            get { return  expressao_vlicms; }
            set {  expressao_vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LISTA_ALIQUOTA
        /// Coment�rio: Lista de Al�quotas.
        /// </summary>
        private string lista_aliquota;
        [XmlElement(ElementName = "LISTA_ALIQUOTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Lista_Aliquota
        {
            get { return  lista_aliquota; }
            set {  lista_aliquota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LISTA_CFOP
        /// Coment�rio: Lista de CFOPs
        /// </summary>
        private string lista_cfop;
        [XmlElement(ElementName = "LISTA_CFOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Lista_Cfop
        {
            get { return  lista_cfop; }
            set {  lista_cfop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NEGATIVO
        /// Coment�rio: Indica se converte o valor em negativo.
        /// </summary>
        private string negativo;
        [XmlElement(ElementName = "NEGATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Negativo
        {
            get { return  negativo; }
            set {  negativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Coment�rio: Ordem do Item.
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOVIMENTO
        /// Coment�rio: Tipo Movimento.
        /// </summary>
        private string tipomovimento;
        [XmlElement(ElementName = "TIPOMOVIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipomovimento
        {
            get { return  tipomovimento; }
            set {  tipomovimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASEMANUAL
        /// Coment�rio: Vl.Base Manual.
        /// </summary>
        private decimal vlbasemanual;
        [XmlElement(ElementName = "VLBASEMANUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlbasemanual
        {
            get { return  vlbasemanual; }
            set {  vlbasemanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCONTABILMANUAL
        /// Coment�rio: Vl.Cont�bil Manual.
        /// </summary>
        private decimal vlcontabilmanual;
        [XmlElement(ElementName = "VLCONTABILMANUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlcontabilmanual
        {
            get { return  vlcontabilmanual; }
            set {  vlcontabilmanual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMSMANUAL
        /// Coment�rio: Vl.ICMS Manual.
        /// </summary>
        private decimal vlicmsmanual;
        [XmlElement(ElementName = "VLICMSMANUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlicmsmanual
        {
            get { return  vlicmsmanual; }
            set {  vlicmsmanual = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRelitem()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRELITEM";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRelitem> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRelitem>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRelitem> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRelitem>(where);
        }

        #endregion
    }
}
