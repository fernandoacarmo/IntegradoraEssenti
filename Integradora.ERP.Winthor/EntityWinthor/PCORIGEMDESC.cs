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
    /// Classe referente a tabela PCOrigemdesc
    /// </summary>
    [XmlType("PCORIGEMDESC")]
    public class PCOrigemdesc : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTERAPTABELA
        /// Comentário: Indica se a política de desconto altera o  preço de tabela
        /// </summary>
        private string alteraptabela;
        [XmlElement(ElementName = "ALTERAPTABELA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Alteraptabela
        {
            get { return  alteraptabela; }
            set {  alteraptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BASEDEBCREDRCA
        /// Comentário: Indica se o percentual de desconto é  descontado ou não do saldo Flex do RCA
        /// </summary>
        private string basedebcredrca;
        [XmlElement(ElementName = "BASEDEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Basedebcredrca
        {
            get { return  basedebcredrca; }
            set {  basedebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODAUXILIAR
        /// Comentário: Código de barras auxiliar
        /// </summary>
        private decimal codauxiliar;
        [XmlElement(ElementName = "CODAUXILIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codauxiliar
        {
            get { return  codauxiliar; }
            set {  codauxiliar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPOLITICABASERCA
        /// Comentário: Código do registro da política de desconto  validado para movimentação do Flex do RCA
        /// </summary>
        private decimal codpoliticabaserca;
        [XmlElement(ElementName = "CODPOLITICABASERCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codpoliticabaserca
        {
            get { return  codpoliticabaserca; }
            set {  codpoliticabaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPOLITICADESC
        /// Comentário: Código do registro da política de desconto  validado
        /// </summary>
        private decimal codpoliticadesc;
        [XmlElement(ElementName = "CODPOLITICADESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codpoliticadesc
        {
            get { return  codpoliticadesc; }
            set {  codpoliticadesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do Produto
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
        /// Propriedade referente ao campo: CODROTINABASERCA
        /// Comentário: Rotina utilizada para validar o preço base   de venda para movimentação do Flex do RCA
        /// </summary>
        private string codrotinabaserca;
        [XmlElement(ElementName = "CODROTINABASERCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codrotinabaserca
        {
            get { return  codrotinabaserca; }
            set {  codrotinabaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINADESC
        /// Comentário: Rotina utilizada para lançamento da  política de desconto
        /// </summary>
        private string codrotinadesc;
        [XmlElement(ElementName = "CODROTINADESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codrotinadesc
        {
            get { return  codrotinadesc; }
            set {  codrotinadesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CREDITASOBREPOLITICABASERCA
        /// Comentário: Indica se a diferença do preço de tabela e o preço com o desconto é creditado no  Flex do RCA
        /// </summary>
        private string creditasobrepoliticabaserca;
        [XmlElement(ElementName = "CREDITASOBREPOLITICABASERCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Creditasobrepoliticabaserca
        {
            get { return  creditasobrepoliticabaserca; }
            set {  creditasobrepoliticabaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: Data em que o registro foi inserido na   tabela
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
        /// Propriedade referente ao campo: NUMPED
        /// Comentário: Número do pedido no Winthor
        /// </summary>
        private decimal numped;
        [XmlElement(ElementName = "NUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numped
        {
            get { return  numped; }
            set {  numped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: Sequência de inserção
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPED
        /// Comentário: Origem do pedido, se 'T' Telemarketing, se  'F' Força de vendas, se 'W' Web, etc.
        /// </summary>
        private string origemped;
        [XmlElement(ElementName = "ORIGEMPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origemped
        {
            get { return  origemped; }
            set {  origemped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PEMBALAGEM
        /// Comentário: Se o preço do produto é por embalagem "S"    ou pela 201 "N"
        /// </summary>
        private string pembalagem;
        [XmlElement(ElementName = "PEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Pembalagem
        {
            get { return  pembalagem; }
            set {  pembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERACRESPF
        /// Comentário: Percentual de acréscimo Pessoa Física /  Jurídica Isenta aplicado ao preço de  tabela
        /// </summary>
        private decimal peracrespf;
        [XmlElement(ElementName = "PERACRESPF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Peracrespf
        {
            get { return  peracrespf; }
            set {  peracrespf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBASERCA
        /// Comentário: Percentual de desconto aplicado no Flex  do RCA
        /// </summary>
        private decimal percbaserca;
        [XmlElement(ElementName = "PERCBASERCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Percbaserca
        {
            get { return  percbaserca; }
            set {  percbaserca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCPCATIVI
        /// Comentário: Percentual de desconto aplicado por Ramo  de Atividade
        /// </summary>
        private decimal percdescpcativi;
        [XmlElement(ElementName = "PERCDESCPCATIVI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percdescpcativi
        {
            get { return  percdescpcativi; }
            set {  percdescpcativi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESC
        /// Comentário: Percentual de desconto aplicado no item
        /// </summary>
        private decimal perdesc;
        [XmlElement(ElementName = "PERDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Perdesc
        {
            get { return  perdesc; }
            set {  perdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERTXFIM
        /// Comentário: Se o preço sofreu alteração de taxa do  plano de pagamento
        /// </summary>
        private decimal pertxfim;
        [XmlElement(ElementName = "PERTXFIM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pertxfim
        {
            get { return  pertxfim; }
            set {  pertxfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRECOFIXO
        /// Comentário: Indica se o ptabela gravado é preço fixo
        /// </summary>
        private string precofixo;
        [XmlElement(ElementName = "PRECOFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Precofixo
        {
            get { return  precofixo; }
            set {  precofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRIORITARIA
        /// Comentário: Indica se a política de desconto validado estava ou não parametrizada como Prioritária
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
        /// Propriedade referente ao campo: PRIORITARIAGERAL
        /// Comentário: Indica se a política de desconto validado estava ou não parametrizada como Prioritária Geral
        /// </summary>
        private string prioritariageral;
        [XmlElement(ElementName = "PRIORITARIAGERAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Prioritariageral
        {
            get { return  prioritariageral; }
            set {  prioritariageral = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PTABELA
        /// Comentário: Preço de tabela encontrado e utilizado  como base para validação de preço
        /// </summary>
        private decimal ptabela;
        [XmlElement(ElementName = "PTABELA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Ptabela
        {
            get { return  ptabela; }
            set {  ptabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESC
        /// Comentário: Se o tipo de desconto é Automático "A" ou Flexível "F"
        /// </summary>
        private string tipodesc;
        [XmlElement(ElementName = "TIPODESC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipodesc
        {
            get { return  tipodesc; }
            set {  tipodesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARPOLITICASDESCCLIBLOQ
        /// Comentário: Indica se o parâmetro 2618 da rotina 132  estava marcado "S" ou "N"
        /// </summary>
        private string validarpoliticasdescclibloq;
        [XmlElement(ElementName = "VALIDARPOLITICASDESCCLIBLOQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validarpoliticasdescclibloq
        {
            get { return  validarpoliticasdescclibloq; }
            set {  validarpoliticasdescclibloq = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOrigemdesc()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCORIGEMDESC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOrigemdesc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrigemdesc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOrigemdesc> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOrigemdesc>(where);
        }

        #endregion
    }
}
