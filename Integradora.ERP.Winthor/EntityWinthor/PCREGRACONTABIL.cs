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
    /// Classe referente a tabela PCRegracontabil
    /// </summary>
    [XmlType("PCREGRACONTABIL")]
    public class PCRegracontabil : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGRUPAMENTOREGRA
        /// Coment�rio: Indica como a regra ser� agrupada.
        /// </summary>
        private string agrupamentoregra;
        [XmlElement(ElementName = "AGRUPAMENTOREGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Agrupamentoregra
        {
            get { return  agrupamentoregra; }
            set {  agrupamentoregra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Coment�rio: Indica se ativa a regra ou n�o.
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BUSCARDADOSPELADATA
        /// Coment�rio: Define qual campo de data ser� utilizado para a busca dos dados da integra��o cont�bil
        /// </summary>
        private string buscardadospeladata;
        [XmlElement(ElementName = "BUSCARDADOSPELADATA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Buscardadospeladata
        {
            get { return  buscardadospeladata; }
            set {  buscardadospeladata = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTASINTETICARCA
        /// Coment�rio: C�digo da Conta Cont�bil Sint�tica do RCA
        /// </summary>
        private string codcontasinteticarca;
        [XmlElement(ElementName = "CODCONTASINTETICARCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codcontasinteticarca
        {
            get { return  codcontasinteticarca; }
            set {  codcontasinteticarca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFATOGERADOR
        /// Coment�rio: Indica o c�digo fato gerador.
        /// </summary>
        private decimal codfatogerador;
        [XmlElement(ElementName = "CODFATOGERADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codfatogerador
        {
            get { return  codfatogerador; }
            set {  codfatogerador = value; }
        }

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
        /// Propriedade referente ao campo: CODHISTORICO
        /// Coment�rio: Indica o c�digo do hist�rico.
        /// </summary>
        private decimal codhistorico;
        [XmlElement(ElementName = "CODHISTORICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codhistorico
        {
            get { return  codhistorico; }
            set {  codhistorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Coment�rio: Indica o c�digo do plano de contas.
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREGRA
        /// Coment�rio: Indica o c�digo controle.
        /// </summary>
        private decimal codregra;
        [XmlElement(ElementName = "CODREGRA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codregra
        {
            get { return  codregra; }
            set {  codregra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTABILIZAESTORNO
        /// Coment�rio: Informa se contabiliza os estornos de pagamentos ou n�o.
        /// </summary>
        private string contabilizaestorno;
        [XmlElement(ElementName = "CONTABILIZAESTORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contabilizaestorno
        {
            get { return  contabilizaestorno; }
            set {  contabilizaestorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOREGRA
        /// Coment�rio: Indica a descri��o da regra.
        /// </summary>
        private string descricaoregra;
        [XmlElement(ElementName = "DESCRICAOREGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Descricaoregra
        {
            get { return  descricaoregra; }
            set {  descricaoregra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIACONTABILIZACAO
        /// Coment�rio: Indica o dia da contabiliza��o.
        /// </summary>
        private string diacontabilizacao;
        [XmlElement(ElementName = "DIACONTABILIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diacontabilizacao
        {
            get { return  diacontabilizacao; }
            set {  diacontabilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCUMENTO
        /// Coment�rio: Indica o documento referente � movimenta��o cont�bil.
        /// </summary>
        private string documento;
        [XmlElement(ElementName = "DOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Documento
        {
            get { return  documento; }
            set {  documento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FILTROS
        /// Coment�rio: Indica os filtros para o SQL da regra.
        /// </summary>
        private string filtros;
        [XmlElement(ElementName = "FILTROS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Filtros
        {
            get { return  filtros; }
            set {  filtros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMADTCONTABILIZACAO
        /// Coment�rio: Indica a forma da data da contabiliza��o.
        /// </summary>
        private string formadtcontabilizacao;
        [XmlElement(ElementName = "FORMADTCONTABILIZACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Formadtcontabilizacao
        {
            get { return  formadtcontabilizacao; }
            set {  formadtcontabilizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTCOMPLREGRA
        /// Coment�rio: Indica o complemento do hist�rico.
        /// </summary>
        private string histcomplregra;
        [XmlElement(ElementName = "HISTCOMPLREGRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Histcomplregra
        {
            get { return  histcomplregra; }
            set {  histcomplregra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: Observa��o sobre a regra cont�bil
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCUSTO_MOVESTOQUE
        /// Coment�rio: Tipo do custo da movimenta��o de estoque
        /// </summary>
        private string tipocusto_movestoque;
        [XmlElement(ElementName = "TIPOCUSTO_MOVESTOQUE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocusto_Movestoque
        {
            get { return  tipocusto_movestoque; }
            set {  tipocusto_movestoque = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRegracontabil()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCREGRACONTABIL";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRegracontabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRegracontabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRegracontabil> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRegracontabil>(where);
        }

        #endregion
    }
}
