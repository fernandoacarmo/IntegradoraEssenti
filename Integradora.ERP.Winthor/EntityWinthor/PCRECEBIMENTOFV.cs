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
    /// Classe referente a tabela PCRecebimentofv
    /// </summary>
    [XmlType("PCRECEBIMENTOFV")]
    public class PCRecebimentofv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CANCELADO
        /// Comentário: INDICA SE O DESDOBRAMENTO FOI OU NÃO CANCELADO PELO RCA (S=SIM, N=NAO)
        /// </summary>
        private string cancelado;
        [XmlElement(ElementName = "CANCELADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Cancelado
        {
            get { return  cancelado; }
            set {  cancelado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCPFCH
        /// Comentário: Cgc/Cpf do emitente do cheque
        /// </summary>
        private string cgccpfch;
        [XmlElement(ElementName = "CGCCPFCH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgccpfch
        {
            get { return  cgccpfch; }
            set {  cgccpfch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Comentário: Codigo do banco
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
        /// Propriedade referente ao campo: CODBARRA
        /// Comentário: Codigo de barras
        /// </summary>
        private string codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Codigo do cliente
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOB
        /// Comentário: Codigo de cobrança do recebimento
        /// </summary>
        private string codcob;
        [XmlElement(ElementName = "CODCOB", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public string Codcob
        {
            get { return  codcob; }
            set {  codcob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Codigo da Filial
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
        /// Propriedade referente ao campo: CODFUNCINC
        /// Comentário: Codigo do Funcionario que incluiu o recebimento
        /// </summary>
        private decimal codfuncinc;
        [XmlElement(ElementName = "CODFUNCINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncinc
        {
            get { return  codfuncinc; }
            set {  codfuncinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: Codigo do RCA do pedido
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPENSACAOBCO
        /// Comentário: Banco Compensão do cheque
        /// </summary>
        private decimal compensacaobco;
        [XmlElement(ElementName = "COMPENSACAOBCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Compensacaobco
        {
            get { return  compensacaobco; }
            set {  compensacaobco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: Data de emissao do recebimento
        /// </summary>
        private DateTime? dtemissao;
        [XmlElement(ElementName = "DTEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtemissao
        {
            get { return  dtemissao; }
            set {  dtemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Data de inclsuao do recebimento
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Comentário: Data de vencimento do recebimento
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DUPLIC
        /// Comentário: Numero da nota do pedido
        /// </summary>
        private decimal duplic;
        [XmlElement(ElementName = "DUPLIC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Duplic
        {
            get { return  duplic; }
            set {  duplic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVAGENCIA
        /// Comentário: Digito verificador da agencia
        /// </summary>
        private decimal dvagencia;
        [XmlElement(ElementName = "DVAGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvagencia
        {
            get { return  dvagencia; }
            set {  dvagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCHEQUE
        /// Comentário: Digito verificador do cheque
        /// </summary>
        private decimal dvcheque;
        [XmlElement(ElementName = "DVCHEQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvcheque
        {
            get { return  dvcheque; }
            set {  dvcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DVCONTA
        /// Comentário: Digito verificador da conta
        /// </summary>
        private decimal dvconta;
        [XmlElement(ElementName = "DVCONTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Dvconta
        {
            get { return  dvconta; }
            set {  dvconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LINHADIG
        /// Comentário: 
        /// </summary>
        private string linhadig;
        [XmlElement(ElementName = "LINHADIG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,65)]
        public string Linhadig
        {
            get { return  linhadig; }
            set {  linhadig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOSSONUMBANCO
        /// Comentário: 
        /// </summary>
        private string nossonumbanco;
        [XmlElement(ElementName = "NOSSONUMBANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nossonumbanco
        {
            get { return  nossonumbanco; }
            set {  nossonumbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIA
        /// Comentário: Numero da agencia
        /// </summary>
        private decimal numagencia;
        [XmlElement(ElementName = "NUMAGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numagencia
        {
            get { return  numagencia; }
            set {  numagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Comentário: Numero do banco
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Comentário: Nùmero do Carregamento
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCHEQUE
        /// Comentário: Numero do Cheque
        /// </summary>
        private decimal numcheque;
        [XmlElement(ElementName = "NUMCHEQUE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcheque
        {
            get { return  numcheque; }
            set {  numcheque = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTACORRENTE
        /// Comentário: Numero da conta corrente
        /// </summary>
        private decimal numcontacorrente;
        [XmlElement(ElementName = "NUMCONTACORRENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numcontacorrente
        {
            get { return  numcontacorrente; }
            set {  numcontacorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDRCA
        /// Comentário: Numero do pedido do palm
        /// </summary>
        private decimal numpedrca;
        [XmlElement(ElementName = "NUMPEDRCA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpedrca
        {
            get { return  numpedrca; }
            set {  numpedrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMRECEBIMENTO
        /// Comentário: Numero do recebimento
        /// </summary>
        private decimal numrecebimento;
        [XmlElement(ElementName = "NUMRECEBIMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Numrecebimento
        {
            get { return  numrecebimento; }
            set {  numrecebimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Numtranvenda gerado pelo faturamento
        /// </summary>
        private decimal numtransvenda;
        [XmlElement(ElementName = "NUMTRANSVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransvenda
        {
            get { return  numtransvenda; }
            set {  numtransvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: observação
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO_PC
        /// Comentário: Observação da importação
        /// </summary>
        private string observacao_pc;
        [XmlElement(ElementName = "OBSERVACAO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao_Pc
        {
            get { return  observacao_pc; }
            set {  observacao_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: Observação 2
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PREST
        /// Comentário: Parcela do recebimento
        /// </summary>
        private string prest;
        [XmlElement(ElementName = "PREST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Prest
        {
            get { return  prest; }
            set {  prest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TXPERM
        /// Comentário: Sentido reversoJUROS RECEBIDOS PELO RCA
        /// </summary>
        private decimal txperm;
        [XmlElement(ElementName = "TXPERM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Txperm
        {
            get { return  txperm; }
            set {  txperm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Comentário: Valor do recebimento
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VERIFICADO
        /// Comentário: Controle de validação
        /// </summary>
        private decimal verificado;
        [XmlElement(ElementName = "VERIFICADO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Verificado
        {
            get { return  verificado; }
            set {  verificado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRecebimentofv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRECEBIMENTOFV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRecebimentofv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRecebimentofv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRecebimentofv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRecebimentofv>(where);
        }

        #endregion
    }
}
