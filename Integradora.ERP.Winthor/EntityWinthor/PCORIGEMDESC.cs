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
        /// Coment�rio: Indica se a pol�tica de desconto altera o  pre�o de tabela
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
        /// Coment�rio: Indica se o percentual de desconto �  descontado ou n�o do saldo Flex do RCA
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
        /// Coment�rio: C�digo de barras auxiliar
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
        /// Coment�rio: C�digo do registro da pol�tica de desconto  validado para movimenta��o do Flex do RCA
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
        /// Coment�rio: C�digo do registro da pol�tica de desconto  validado
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
        /// Coment�rio: C�digo do Produto
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
        /// Coment�rio: Rotina utilizada para validar o pre�o base   de venda para movimenta��o do Flex do RCA
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
        /// Coment�rio: Rotina utilizada para lan�amento da  pol�tica de desconto
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
        /// Coment�rio: Indica se a diferen�a do pre�o de tabela e o pre�o com o desconto � creditado no  Flex do RCA
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
        /// Coment�rio: Data em que o registro foi inserido na   tabela
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
        /// Coment�rio: N�mero do pedido no Winthor
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
        /// Coment�rio: Sequ�ncia de inser��o
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
        /// Coment�rio: Origem do pedido, se 'T' Telemarketing, se  'F' For�a de vendas, se 'W' Web, etc.
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
        /// Coment�rio: Se o pre�o do produto � por embalagem "S"    ou pela 201 "N"
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
        /// Coment�rio: Percentual de acr�scimo Pessoa F�sica /  Jur�dica Isenta aplicado ao pre�o de  tabela
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
        /// Coment�rio: Percentual de desconto aplicado no Flex  do RCA
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
        /// Coment�rio: Percentual de desconto aplicado por Ramo  de Atividade
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
        /// Coment�rio: Percentual de desconto aplicado no item
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
        /// Coment�rio: Se o pre�o sofreu altera��o de taxa do  plano de pagamento
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
        /// Coment�rio: Indica se o ptabela gravado � pre�o fixo
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
        /// Coment�rio: Indica se a pol�tica de desconto validado estava ou n�o parametrizada como Priorit�ria
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
        /// Coment�rio: Indica se a pol�tica de desconto validado estava ou n�o parametrizada como Priorit�ria Geral
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
        /// Coment�rio: Pre�o de tabela encontrado e utilizado  como base para valida��o de pre�o
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
        /// Coment�rio: Se o tipo de desconto � Autom�tico "A" ou Flex�vel "F"
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
        /// Coment�rio: Indica se o par�metro 2618 da rotina 132  estava marcado "S" ou "N"
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCOrigemdesc> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOrigemdesc>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
