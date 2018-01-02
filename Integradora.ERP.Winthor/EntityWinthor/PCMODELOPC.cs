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
    /// Classe referente a tabela PCModelopc
    /// </summary>
    [XmlType("PCMODELOPC")]
    public class PCModelopc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: Indica o c�digo do cliente.
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
        /// Propriedade referente ao campo: CODCONTAGER
        /// Coment�rio: Relaciona o plano de contas cont�bil com o plano de contas gerencial. 
        /// </summary>
        private decimal codcontager;
        [XmlElement(ElementName = "CODCONTAGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontager
        {
            get { return  codcontager; }
            set {  codcontager = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA_PC
        /// Coment�rio: 
        /// </summary>
        private string codconta_pc;
        [XmlElement(ElementName = "CODCONTA_PC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Codconta_Pc
        {
            get { return  codconta_pc; }
            set {  codconta_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA_SPED
        /// Coment�rio: Indica o c�digo da conta do plano de contas referencial.
        /// </summary>
        private string codconta_sped;
        [XmlElement(ElementName = "CODCONTA_SPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codconta_Sped
        {
            get { return  codconta_sped; }
            set {  codconta_sped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: Indica se a Conta Cont�bil � Anal�tica de Fornecedor, e qual o Fornecedor ela referencia. 
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
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Coment�rio: 
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRCA
        /// Coment�rio: C�digo RCA vinculado � conta cont�bil
        /// </summary>
        private decimal codrca;
        [XmlElement(ElementName = "CODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codrca
        {
            get { return  codrca; }
            set {  codrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Coment�rio: 
        /// </summary>
        private string codreduzido_pc;
        [XmlElement(ElementName = "CODREDUZIDO_PC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,12)]
        public string Codreduzido_Pc
        {
            get { return  codreduzido_pc; }
            set {  codreduzido_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPORBALANCO
        /// Coment�rio: Indica as contas que v�o compor o balanco.
        /// </summary>
        private string comporbalanco;
        [XmlElement(ElementName = "COMPORBALANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comporbalanco
        {
            get { return  comporbalanco; }
            set {  comporbalanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPORDFC
        /// Coment�rio: Comp�e DFC.
        /// </summary>
        private string compordfc;
        [XmlElement(ElementName = "COMPORDFC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Compordfc
        {
            get { return  compordfc; }
            set {  compordfc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPORFCONT
        /// Coment�rio: Conta comp�e FCONT.
        /// </summary>
        private string comporfcont;
        [XmlElement(ElementName = "COMPORFCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comporfcont
        {
            get { return  comporfcont; }
            set {  comporfcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTARESULTADO
        /// Coment�rio: Indica a conta de resultado.
        /// </summary>
        private string contaresultado;
        [XmlElement(ElementName = "CONTARESULTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contaresultado
        {
            get { return  contaresultado; }
            set {  contaresultado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZA
        /// Coment�rio: 
        /// </summary>
        private string natureza;
        [XmlElement(ElementName = "NATUREZA", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Natureza
        {
            get { return  natureza; }
            set {  natureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZAGRUPO
        /// Coment�rio: 
        /// </summary>
        private string naturezagrupo;
        [XmlElement(ElementName = "NATUREZAGRUPO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Naturezagrupo
        {
            get { return  naturezagrupo; }
            set {  naturezagrupo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_CONTA
        /// Coment�rio: 
        /// </summary>
        private string nome_conta;
        [XmlElement(ElementName = "NOME_CONTA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,50)]
        public string Nome_Conta
        {
            get { return  nome_conta; }
            set {  nome_conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: Observa��o sobre a utiliza��o da conta.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECEBE_LANCTO
        /// Coment�rio: 
        /// </summary>
        private string recebe_lancto;
        [XmlElement(ElementName = "RECEBE_LANCTO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Recebe_Lancto
        {
            get { return  recebe_lancto; }
            set {  recebe_lancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTA
        /// Coment�rio: Indica o tipo de conta.
        /// </summary>
        private string tipoconta;
        [XmlElement(ElementName = "TIPOCONTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoconta
        {
            get { return  tipoconta; }
            set {  tipoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ULT_CODREDUZIDO
        /// Coment�rio: 
        /// </summary>
        private decimal ult_codreduzido;
        [XmlElement(ElementName = "ULT_CODREDUZIDO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Ult_Codreduzido
        {
            get { return  ult_codreduzido; }
            set {  ult_codreduzido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACENTROCUSTO
        /// Coment�rio: Determina se a conta usa Centro de Custo
        /// </summary>
        private string usacentrocusto;
        [XmlElement(ElementName = "USACENTROCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacentrocusto
        {
            get { return  usacentrocusto; }
            set {  usacentrocusto = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCModelopc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMODELOPC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCModelopc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCModelopc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCModelopc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCModelopc>(where);
        }

        #endregion
    }
}
