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
    /// Classe referente a tabela PCLancamento
    /// </summary>
    [XmlType("PCLANCAMENTO")]
    public class PCLancamento : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: 
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFILIALIMPORT
        /// Comentário: Filial de Importação pela 2123. Lançamentos Contábeis. 
        /// </summary>
        private string codfilialimport;
        [XmlElement(ElementName = "CODFILIALIMPORT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilialimport
        {
            get { return  codfilialimport; }
            set {  codfilialimport = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTERACAO
        /// Comentário: 
        /// </summary>
        private decimal codfuncalteracao;
        [XmlElement(ElementName = "CODFUNCALTERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncalteracao
        {
            get { return  codfuncalteracao; }
            set {  codfuncalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINTEGRACAO
        /// Comentário: Cód. Funcionário integração.
        /// </summary>
        private decimal codfuncintegracao;
        [XmlElement(ElementName = "CODFUNCINTEGRACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncintegracao
        {
            get { return  codfuncintegracao; }
            set {  codfuncintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODHISTORICO
        /// Comentário: Indica o código do histórico.
        /// </summary>
        private decimal codhistorico;
        [XmlElement(ElementName = "CODHISTORICO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codhistorico
        {
            get { return  codhistorico; }
            set {  codhistorico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLOGINTEGRACAO
        /// Comentário: 
        /// </summary>
        private decimal codlogintegracao;
        [XmlElement(ElementName = "CODLOGINTEGRACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Codlogintegracao
        {
            get { return  codlogintegracao; }
            set {  codlogintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Comentário: 
        /// </summary>
        private decimal codplanoconta;
        [XmlElement(ElementName = "CODPLANOCONTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Codplanoconta
        {
            get { return  codplanoconta; }
            set {  codplanoconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Comentário: 
        /// </summary>
        private string codreduzido_pc;
        [XmlElement(ElementName = "CODREDUZIDO_PC", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,12)]
        public string Codreduzido_Pc
        {
            get { return  codreduzido_pc; }
            set {  codreduzido_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREGRAINTEGRACAO
        /// Comentário: Código da Regra originado da integração com a 2130.
        /// </summary>
        private decimal codregraintegracao;
        [XmlElement(ElementName = "CODREGRAINTEGRACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codregraintegracao
        {
            get { return  codregraintegracao; }
            set {  codregraintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPORFCONT
        /// Comentário: Lançamento compõe FCONT.
        /// </summary>
        private string comporfcont;
        [XmlElement(ElementName = "COMPORFCONT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Comporfcont
        {
            get { return  comporfcont; }
            set {  comporfcont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCILIADO
        /// Comentário: Indica se o lançamento esta ou não conciliado.
        /// </summary>
        private string conciliado;
        [XmlElement(ElementName = "CONCILIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Conciliado
        {
            get { return  conciliado; }
            set {  conciliado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINTEGRACAO
        /// Comentário: Data integração.
        /// </summary>
        private DateTime? dataintegracao;
        [XmlElement(ElementName = "DATAINTEGRACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataintegracao
        {
            get { return  dataintegracao; }
            set {  dataintegracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCUMENTO
        /// Comentário: 
        /// </summary>
        private string documento;
        [XmlElement(ElementName = "DOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Documento
        {
            get { return  documento; }
            set {  documento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHRALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dthralteracao;
        [XmlElement(ElementName = "DTHRALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthralteracao
        {
            get { return  dthralteracao; }
            set {  dthralteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENCERRADO
        /// Comentário: 
        /// </summary>
        private string encerrado;
        [XmlElement(ElementName = "ENCERRADO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Encerrado
        {
            get { return  encerrado; }
            set {  encerrado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXCLUIDO
        /// Comentário: 
        /// </summary>
        private string excluido;
        [XmlElement(ElementName = "EXCLUIDO", DataType = "CHAR", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Excluido
        {
            get { return  excluido; }
            set {  excluido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HISTORICO_COMPL
        /// Comentário: 
        /// </summary>
        private string historico_compl;
        [XmlElement(ElementName = "HISTORICO_COMPL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Historico_Compl
        {
            get { return  historico_compl; }
            set {  historico_compl = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTE
        /// Comentário: 
        /// </summary>
        private string lote;
        [XmlElement(ElementName = "LOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public string Lote
        {
            get { return  lote; }
            set {  lote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Comentário: 
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MULTIFILIAL
        /// Comentário: Lançamento em multi-filiais.
        /// </summary>
        private string multifilial;
        [XmlElement(ElementName = "MULTIFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Multifilial
        {
            get { return  multifilial; }
            set {  multifilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZA
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMLANCTO
        /// Comentário: 
        /// </summary>
        private decimal numlancto;
        [XmlElement(ElementName = "NUMLANCTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,38)]
        public decimal Numlancto
        {
            get { return  numlancto; }
            set {  numlancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: 
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSLANCTO
        /// Comentário: 
        /// </summary>
        private decimal numtranslancto;
        [XmlElement(ElementName = "NUMTRANSLANCTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,38)]
        public decimal Numtranslancto
        {
            get { return  numtranslancto; }
            set {  numtranslancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO_LANCAMENTO
        /// Comentário: Indica o tipo de lançamento realizado. 
        /// </summary>
        private string tipo_lancamento;
        [XmlElement(ElementName = "TIPO_LANCAMENTO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tipo_Lancamento
        {
            get { return  tipo_lancamento; }
            set {  tipo_lancamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: 
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,22)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLancamento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLANCAMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLancamento> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLancamento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLancamento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLancamento>(where);
        }

        #endregion
    }
}
