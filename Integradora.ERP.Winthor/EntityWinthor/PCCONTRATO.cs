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
    /// Classe referente a tabela PCContrato
    /// </summary>
    [XmlType("PCCONTRATO")]
    public class PCContrato : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CLIENTEPRINCIPAL
        /// Comentário: Código do cliente principal de uma rede de clientes. Na digitação do pedido caso este campo esteja como [S], será verificado se o cliente informado ou o seu cliente principal é o mesmo informado no contrato.
        /// </summary>
        private string clienteprincipal;
        [XmlElement(ElementName = "CLIENTEPRINCIPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Clienteprincipal
        {
            get { return  clienteprincipal; }
            set {  clienteprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODCONTRATO
        /// Comentário: 
        /// </summary>
        private decimal codcontrato;
        [XmlElement(ElementName = "CODCONTRATO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcontrato
        {
            get { return  codcontrato; }
            set {  codcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Comentário: código do funcionário que realizou a exclusão do contrato. 
        /// </summary>
        private decimal codfuncexclusao;
        [XmlElement(ElementName = "CODFUNCEXCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncexclusao
        {
            get { return  codfuncexclusao; }
            set {  codfuncexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINCLUSAO
        /// Comentário: Código funcionário que incluiu o contrato
        /// </summary>
        private decimal codfuncinclusao;
        [XmlElement(ElementName = "CODFUNCINCLUSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncinclusao
        {
            get { return  codfuncinclusao; }
            set {  codfuncinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAG
        /// Comentário: Plano de Pagamento
        /// </summary>
        private decimal codplpag;
        [XmlElement(ElementName = "CODPLPAG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codplpag
        {
            get { return  codplpag; }
            set {  codplpag = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: RCA do contrato.
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSISTIRDADOSNAVENDA
        /// Comentário: Verificar se os dados do Contrato será concistido na venda.
        /// </summary>
        private string consistirdadosnavenda;
        [XmlElement(ElementName = "CONSISTIRDADOSNAVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consistirdadosnavenda
        {
            get { return  consistirdadosnavenda; }
            set {  consistirdadosnavenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCPRODUTOS
        /// Comentário: 
        /// </summary>
        private string descprodutos;
        [XmlElement(ElementName = "DESCPRODUTOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Descprodutos
        {
            get { return  descprodutos; }
            set {  descprodutos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONTRATO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcontrato;
        [XmlElement(ElementName = "DTCONTRATO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcontrato
        {
            get { return  dtcontrato; }
            set {  dtcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: Data da exclusão do contrato. 
        /// </summary>
        private DateTime? dtexclusao;
        [XmlElement(ElementName = "DTEXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexclusao
        {
            get { return  dtexclusao; }
            set {  dtexclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: Data de início de vigência
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
        /// Propriedade referente ao campo: DTLIMITEFAT
        /// Comentário: Data Limite para Faturamento
        /// </summary>
        private DateTime? dtlimitefat;
        [XmlElement(ElementName = "DTLIMITEFAT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlimitefat
        {
            get { return  dtlimitefat; }
            set {  dtlimitefat = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTTERMINO
        /// Comentário: Data de término de vigência
        /// </summary>
        private DateTime? dttermino;
        [XmlElement(ElementName = "DTTERMINO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dttermino
        {
            get { return  dttermino; }
            set {  dttermino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENCIMENTO
        /// Comentário: Data de vencimento do contrato.
        /// </summary>
        private DateTime? dtvencimento;
        [XmlElement(ElementName = "DTVENCIMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvencimento
        {
            get { return  dtvencimento; }
            set {  dtvencimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIFICACAO
        /// Comentário: 
        /// </summary>
        private string especificacao;
        [XmlElement(ElementName = "ESPECIFICACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,300)]
        public string Especificacao
        {
            get { return  especificacao; }
            set {  especificacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCOC
        /// Comentário: 
        /// </summary>
        private string numcoc;
        [XmlElement(ElementName = "NUMCOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcoc
        {
            get { return  numcoc; }
            set {  numcoc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTRATO
        /// Comentário: 
        /// </summary>
        private string numcontrato;
        [XmlElement(ElementName = "NUMCONTRATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcontrato
        {
            get { return  numcontrato; }
            set {  numcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEDITAL
        /// Comentário: 
        /// </summary>
        private string numedital;
        [XmlElement(ElementName = "NUMEDITAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Numedital
        {
            get { return  numedital; }
            set {  numedital = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLOTE
        /// Comentário: 
        /// </summary>
        private string numlote;
        [XmlElement(ElementName = "NUMLOTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numlote
        {
            get { return  numlote; }
            set {  numlote = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRAZOENTREGA
        /// Comentário: 
        /// </summary>
        private decimal prazoentrega;
        [XmlElement(ElementName = "PRAZOENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Prazoentrega
        {
            get { return  prazoentrega; }
            set {  prazoentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCONTRATO
        /// Comentário: 
        /// </summary>
        private decimal qtcontrato;
        [XmlElement(ElementName = "QTCONTRATO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,26)]
        public decimal Qtcontrato
        {
            get { return  qtcontrato; }
            set {  qtcontrato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: Status do Acordo de Preço
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
        /// Propriedade referente ao campo: SUREG
        /// Comentário: 
        /// </summary>
        private string sureg;
        [XmlElement(ElementName = "SUREG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Sureg
        {
            get { return  sureg; }
            set {  sureg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOACORDO
        /// Comentário: Tipo de Acordo de Preço
        /// </summary>
        private string tipoacordo;
        [XmlElement(ElementName = "TIPOACORDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoacordo
        {
            get { return  tipoacordo; }
            set {  tipoacordo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: 
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCContrato()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTRATO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCContrato> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContrato>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCContrato> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContrato>(where);
        }

        #endregion
    }
}
