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
    /// Classe referente a tabela PCDescquant
    /// </summary>
    [XmlType("PCDESCQUANT")]
    public class PCDescquant : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: APENASPLPAGMAX
        /// Comentário: Utiliza politica de desconto somente no plano de pagamento.
        /// </summary>
        private string apenasplpagmax;
        [XmlElement(ElementName = "APENASPLPAGMAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Apenasplpagmax
        {
            get { return  apenasplpagmax; }
            set {  apenasplpagmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAFAMILIAPRODUTOS
        /// Comentário: Aplicar a familia de produtos pelo código do produto principal cadastrado na rotina 203.
        /// </summary>
        private string aplicafamiliaprodutos;
        [XmlElement(ElementName = "APLICAFAMILIAPRODUTOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicafamiliaprodutos
        {
            get { return  aplicafamiliaprodutos; }
            set {  aplicafamiliaprodutos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAOPERLOG
        /// Comentário: Aplicar no Operador Logistico
        /// </summary>
        private string aplicaoperlog;
        [XmlElement(ElementName = "APLICAOPERLOG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicaoperlog
        {
            get { return  aplicaoperlog; }
            set {  aplicaoperlog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: APLICAPEDELET
        /// Comentário: Aplicar no pedido Eletrônico
        /// </summary>
        private string aplicapedelet;
        [XmlElement(ElementName = "APLICAPEDELET", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aplicapedelet
        {
            get { return  aplicapedelet; }
            set {  aplicapedelet = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASECREDDEBRCA
        /// Comentário: Altera base para cálculo de débito/crédito de RCA
        /// </summary>
        private string basecreddebrca;
        [XmlElement(ElementName = "BASECREDDEBRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Basecreddebrca
        {
            get { return  basecreddebrca; }
            set {  basecreddebrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CLASSEVENDA
        /// Comentário: Classe de venda
        /// </summary>
        private string classevenda;
        [XmlElement(ElementName = "CLASSEVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Classevenda
        {
            get { return  classevenda; }
            set {  classevenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Comentário: Condição de Venda
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDESCONTO
        /// Comentário: Indica o código do desconto.
        /// </summary>
        private decimal coddesconto;
        [XmlElement(ElementName = "CODDESCONTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Coddesconto
        {
            get { return  coddesconto; }
            set {  coddesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código filial da empresa.
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
        /// Propriedade referente ao campo: CODGRUPOREST
        /// Comentário: Tipo de grupo (GR=Rca) (CL=Cliente)
        /// </summary>
        private decimal codgruporest;
        [XmlElement(ElementName = "CODGRUPOREST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codgruporest
        {
            get { return  codgruporest; }
            set {  codgruporest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHAPROD
        /// Comentário: Cód. Linha Produto
        /// </summary>
        private decimal codlinhaprod;
        [XmlElement(ElementName = "CODLINHAPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlinhaprod
        {
            get { return  codlinhaprod; }
            set {  codlinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPLPAGMAX
        /// Comentário: Indica o Plano de Pagamento máximo para desconto por volume. 
        /// </summary>
        private decimal codplpagmax;
        [XmlElement(ElementName = "CODPLPAGMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codplpagmax
        {
            get { return  codplpagmax; }
            set {  codplpagmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACA
        /// Comentário: 
        /// </summary>
        private decimal codpraca;
        [XmlElement(ElementName = "CODPRACA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpraca
        {
            get { return  codpraca; }
            set {  codpraca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROMOCAOMED
        /// Comentário: Cód. Promoção Med.
        /// </summary>
        private decimal codpromocaomed;
        [XmlElement(ElementName = "CODPROMOCAOMED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Codpromocaomed
        {
            get { return  codpromocaomed; }
            set {  codpromocaomed = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONSIDERACALCGIROMEDIC
        /// Comentário: Considerar calculo de giro para medicamento.
        /// </summary>
        private string consideracalcgiromedic;
        [XmlElement(ElementName = "CONSIDERACALCGIROMEDIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideracalcgiromedic
        {
            get { return  consideracalcgiromedic; }
            set {  consideracalcgiromedic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CREDITASOBREPTABELA
        /// Comentário: Indica se Credita RCA na venda com preço maior que o preço com desconto por volume automático. 
        /// </summary>
        private string creditasobreptabela;
        [XmlElement(ElementName = "CREDITASOBREPTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Creditasobreptabela
        {
            get { return  creditasobreptabela; }
            set {  creditasobreptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIM
        /// Comentário: 
        /// </summary>
        private DateTime? dtfim;
        [XmlElement(ElementName = "DTFIM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfim
        {
            get { return  dtfim; }
            set {  dtfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: 
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
        /// Propriedade referente ao campo: ENVIAFV
        /// Comentário: Indica se envia para o força de venda.
        /// </summary>
        private string enviafv;
        [XmlElement(ElementName = "ENVIAFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviafv
        {
            get { return  enviafv; }
            set {  enviafv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIMINTERVALO
        /// Comentário: 
        /// </summary>
        private decimal fimintervalo;
        [XmlElement(ElementName = "FIMINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Fimintervalo
        {
            get { return  fimintervalo; }
            set {  fimintervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INICIOINTERVALO
        /// Comentário: 
        /// </summary>
        private decimal iniciointervalo;
        [XmlElement(ElementName = "INICIOINTERVALO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Iniciointervalo
        {
            get { return  iniciointervalo; }
            set {  iniciointervalo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMREGIAO
        /// Comentário: 
        /// </summary>
        private decimal numregiao;
        [XmlElement(ElementName = "NUMREGIAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numregiao
        {
            get { return  numregiao; }
            set {  numregiao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: 
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFINVP
        /// Comentário: 
        /// </summary>
        private decimal percdescfinvp;
        [XmlElement(ElementName = "PERCDESCFINVP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescfinvp
        {
            get { return  percdescfinvp; }
            set {  percdescfinvp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFINVV
        /// Comentário: 
        /// </summary>
        private decimal percdescfinvv;
        [XmlElement(ElementName = "PERCDESCFINVV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescfinvv
        {
            get { return  percdescfinvv; }
            set {  percdescfinvv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCVP
        /// Comentário: 
        /// </summary>
        private decimal percdescvp;
        [XmlElement(ElementName = "PERCDESCVP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdescvp
        {
            get { return  percdescvp; }
            set {  percdescvp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCVRJ
        /// Comentário: 
        /// </summary>
        private decimal percdescvrj;
        [XmlElement(ElementName = "PERCDESCVRJ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percdescvrj
        {
            get { return  percdescvrj; }
            set {  percdescvrj = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMEXT
        /// Comentário: Per.Com. Vendedor Interno
        /// </summary>
        private decimal percomext;
        [XmlElement(ElementName = "PERCOMEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percomext
        {
            get { return  percomext; }
            set {  percomext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMINT
        /// Comentário: Per.Com. Vendedor Interno
        /// </summary>
        private decimal percommint;
        [XmlElement(ElementName = "PERCOMMINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percommint
        {
            get { return  percommint; }
            set {  percommint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMREP
        /// Comentário: Per.Com. Representante
        /// </summary>
        private decimal percomrep;
        [XmlElement(ElementName = "PERCOMREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percomrep
        {
            get { return  percomrep; }
            set {  percomrep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAX
        /// Comentário: 
        /// </summary>
        private decimal perdescmax;
        [XmlElement(ElementName = "PERDESCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Perdescmax
        {
            get { return  perdescmax; }
            set {  perdescmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRIORITARIA
        /// Comentário: Indica se esta campanha é exclusiva e prioritária. Caso exista mais de uma prioritária será utilizada a que tiver o maior percentual de desconto.
        /// </summary>
        private string prioritaria;
        [XmlElement(ElementName = "PRIORITARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prioritaria
        {
            get { return  prioritaria; }
            set {  prioritaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QUESTIONAUSOPRIORITARIA
        /// Comentário: Indica se será questionado o uso da política exclusiva e prioritária na inclusão do pedido de venda.
        /// </summary>
        private string questionausoprioritaria;
        [XmlElement(ElementName = "QUESTIONAUSOPRIORITARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Questionausoprioritaria
        {
            get { return  questionausoprioritaria; }
            set {  questionausoprioritaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESCONTO
        /// Comentário: Indica o tipo de desconto.
        /// </summary>
        private string tipodesconto;
        [XmlElement(ElementName = "TIPODESCONTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodesconto
        {
            get { return  tipodesconto; }
            set {  tipodesconto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFV
        /// Comentário: 
        /// </summary>
        private string tipofv;
        [XmlElement(ElementName = "TIPOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofv
        {
            get { return  tipofv; }
            set {  tipofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOGRUPOREST
        /// Comentário: Código do grupo
        /// </summary>
        private string tipogruporest;
        [XmlElement(ElementName = "TIPOGRUPOREST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipogruporest
        {
            get { return  tipogruporest; }
            set {  tipogruporest = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDescquant()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESCQUANT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDescquant> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDescquant>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDescquant> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDescquant>(where);
        }

        #endregion
    }
}
