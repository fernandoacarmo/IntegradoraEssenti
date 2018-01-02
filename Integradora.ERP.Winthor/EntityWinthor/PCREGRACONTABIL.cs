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
        /// Comentário: Indica como a regra será agrupada.
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
        /// Comentário: Indica se ativa a regra ou não.
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
        /// Comentário: Define qual campo de data será utilizado para a busca dos dados da integração contábil
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
        /// Comentário: Código da Conta Contábil Sintética do RCA
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
        /// Comentário: Indica o código fato gerador.
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
        /// Comentário: Indica o código da filial.
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
        /// Comentário: Indica o código do histórico.
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
        /// Comentário: Indica o código do plano de contas.
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
        /// Comentário: Indica o código controle.
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
        /// Comentário: Informa se contabiliza os estornos de pagamentos ou não.
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
        /// Comentário: Indica a descrição da regra.
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
        /// Comentário: Indica o dia da contabilização.
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
        /// Comentário: Indica o documento referente á movimentação contábil.
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
        /// Comentário: Indica os filtros para o SQL da regra.
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
        /// Comentário: Indica a forma da data da contabilização.
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
        /// Comentário: Indica o complemento do histórico.
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
        /// Comentário: Observação sobre a regra contábil
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
        /// Comentário: Tipo do custo da movimentação de estoque
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRegracontabil> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRegracontabil>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
