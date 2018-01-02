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
    /// Classe referente a tabela PCLancintermediaria
    /// </summary>
    [XmlType("PCLANCINTERMEDIARIA")]
    public class PCLancintermediaria : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CFOP
        /// Comentário: Indica o CFOP do lançamento.
        /// </summary>
        private decimal cfop;
        [XmlElement(ElementName = "CFOP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Cfop
        {
            get { return  cfop; }
            set {  cfop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Indica o código do banco do lançamento.
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código Filial.
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
        /// Propriedade referente ao campo: CODMOEDA
        /// Comentário: Indica o código da moeda do lançamento.
        /// </summary>
        private string codmoeda;
        [XmlElement(ElementName = "CODMOEDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codmoeda
        {
            get { return  codmoeda; }
            set {  codmoeda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLANOCONTA
        /// Comentário: Indica o código plano de contas.
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
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Comentário: Indica o código reduzido PC.
        /// </summary>
        private string codreduzido_pc;
        [XmlElement(ElementName = "CODREDUZIDO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Codreduzido_Pc
        {
            get { return  codreduzido_pc; }
            set {  codreduzido_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREGRA
        /// Comentário: Indica o código da regra.
        /// </summary>
        private decimal codregra;
        [XmlElement(ElementName = "CODREGRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codregra
        {
            get { return  codregra; }
            set {  codregra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTABILIZAR
        /// Comentário: Indica se o lançamento deve ser contabilizado
        /// </summary>
        private string contabilizar;
        [XmlElement(ElementName = "CONTABILIZAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contabilizar
        {
            get { return  contabilizar; }
            set {  contabilizar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAALTERACAO
        /// Comentário: Indica a data da alteração.
        /// </summary>
        private DateTime? dataalteracao;
        [XmlElement(ElementName = "DATAALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataalteracao
        {
            get { return  dataalteracao; }
            set {  dataalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINTEGRACAO
        /// Comentário: Indica a data de integração.
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
        /// Propriedade referente ao campo: DATAINTEGRACAOAUTO
        /// Comentário: Campo mostra a data que o lançamento foi integrado automaticamente.
        /// </summary>
        private DateTime? dataintegracaoauto;
        [XmlElement(ElementName = "DATAINTEGRACAOAUTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataintegracaoauto
        {
            get { return  dataintegracaoauto; }
            set {  dataintegracaoauto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATALANCTO
        /// Comentário: Indica a data do lançamento.
        /// </summary>
        private DateTime? datalancto;
        [XmlElement(ElementName = "DATALANCTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datalancto
        {
            get { return  datalancto; }
            set {  datalancto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOCUMENTO
        /// Comentário: Indica o documento.
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
        /// Propriedade referente ao campo: HISTORICO_COMPL
        /// Comentário: Indica o histórico complementar.
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
        /// Propriedade referente ao campo: INCONSISTENCIA
        /// Comentário: Indica a inconsistência.
        /// </summary>
        private string inconsistencia;
        [XmlElement(ElementName = "INCONSISTENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Inconsistencia
        {
            get { return  inconsistencia; }
            set {  inconsistencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZA
        /// Comentário: Indica a natureza.
        /// </summary>
        private string natureza;
        [XmlElement(ElementName = "NATUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Natureza
        {
            get { return  natureza; }
            set {  natureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANCTOCONTABIL
        /// Comentário: Indica o número lançamento contábil.
        /// </summary>
        private decimal numlanctocontabil;
        [XmlElement(ElementName = "NUMLANCTOCONTABIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Numlanctocontabil
        {
            get { return  numlanctocontabil; }
            set {  numlanctocontabil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTECONT
        /// Comentário: Indica o número do lote.
        /// </summary>
        private decimal numlotecont;
        [XmlElement(ElementName = "NUMLOTECONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Numlotecont
        {
            get { return  numlotecont; }
            set {  numlotecont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Indica a sequência.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSCENTROCUSTO
        /// Comentário: Núm. Trans. Centro custo
        /// </summary>
        private decimal numtranscentrocusto;
        [XmlElement(ElementName = "NUMTRANSCENTROCUSTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numtranscentrocusto
        {
            get { return  numtranscentrocusto; }
            set {  numtranscentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSLANCTO
        /// Comentário: Número transação.
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
        /// Propriedade referente ao campo: NUMTRANSOPERACAO
        /// Comentário: Indica o número da operação.
        /// </summary>
        private decimal numtransoperacao;
        [XmlElement(ElementName = "NUMTRANSOPERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Numtransoperacao
        {
            get { return  numtransoperacao; }
            set {  numtransoperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERACAO
        /// Comentário: Indica a operação.
        /// </summary>
        private string operacao;
        [XmlElement(ElementName = "OPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Operacao
        {
            get { return  operacao; }
            set {  operacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Indica o status.
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOALTERACAO
        /// Comentário: Indica o usuário da alteração.
        /// </summary>
        private string usuarioalteracao;
        [XmlElement(ElementName = "USUARIOALTERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Usuarioalteracao
        {
            get { return  usuarioalteracao; }
            set {  usuarioalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Indica o valor.
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
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
        public PCLancintermediaria()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLANCINTERMEDIARIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLancintermediaria> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLancintermediaria>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLancintermediaria> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLancintermediaria>(where);
        }

        #endregion
    }
}
