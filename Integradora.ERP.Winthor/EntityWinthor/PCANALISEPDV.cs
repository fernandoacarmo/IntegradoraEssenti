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
    /// Classe referente a tabela PCAnalisepdv
    /// </summary>
    [XmlType("PCANALISEPDV")]
    public class PCAnalisepdv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: CÓDIGO FILIAL.
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
        /// Propriedade referente ao campo: CODFUNCCAIXA
        /// Comentário: CÓDIGO DO FUNCIONÁRIO .
        /// </summary>
        private decimal codfunccaixa;
        [XmlElement(ElementName = "CODFUNCCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Codfunccaixa
        {
            get { return  codfunccaixa; }
            set {  codfunccaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSUPERV
        /// Comentário: CÓDIGO DO SUPERVISOR.
        /// </summary>
        private decimal codfuncsuperv;
        [XmlElement(ElementName = "CODFUNCSUPERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncsuperv
        {
            get { return  codfuncsuperv; }
            set {  codfuncsuperv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: DATA DE GRAVACAO.
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHRENTRADA
        /// Comentário: DATA E HORA DA ENTRADA.
        /// </summary>
        private DateTime? dthrentrada;
        [XmlElement(ElementName = "DTHRENTRADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthrentrada
        {
            get { return  dthrentrada; }
            set {  dthrentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTHRSAIDA
        /// Comentário: DATA E HORA DA SAÍDA.
        /// </summary>
        private DateTime? dthrsaida;
        [XmlElement(ElementName = "DTHRSAIDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dthrsaida
        {
            get { return  dthrsaida; }
            set {  dthrsaida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTADO
        /// Comentário: Identifica se o registro foi exportado
        /// </summary>
        private string exportado;
        [XmlElement(ElementName = "EXPORTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportado
        {
            get { return  exportado; }
            set {  exportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTCANCELFINAL
        /// Comentário: GT FINAL DO CANCELAMENTO.
        /// </summary>
        private decimal gtcancelfinal;
        [XmlElement(ElementName = "GTCANCELFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Gtcancelfinal
        {
            get { return  gtcancelfinal; }
            set {  gtcancelfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTCANCELINICIAL
        /// Comentário: GT INICIAL DO CANCELAMENTO.
        /// </summary>
        private decimal gtcancelinicial;
        [XmlElement(ElementName = "GTCANCELINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Gtcancelinicial
        {
            get { return  gtcancelinicial; }
            set {  gtcancelinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTDESCFINAL
        /// Comentário: GT FINAL DO DESCONTO.
        /// </summary>
        private decimal gtdescfinal;
        [XmlElement(ElementName = "GTDESCFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Gtdescfinal
        {
            get { return  gtdescfinal; }
            set {  gtdescfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTDESCINICIAL
        /// Comentário: GT INICIAL DO DESCONTO.
        /// </summary>
        private decimal gtdescinicial;
        [XmlElement(ElementName = "GTDESCINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Gtdescinicial
        {
            get { return  gtdescinicial; }
            set {  gtdescinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTVENDAFINAL
        /// Comentário: GT FINAL DA VENDA.
        /// </summary>
        private decimal gtvendafinal;
        [XmlElement(ElementName = "GTVENDAFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Gtvendafinal
        {
            get { return  gtvendafinal; }
            set {  gtvendafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GTVENDAINICIAL
        /// Comentário: GT INICIAL DA VENDA.
        /// </summary>
        private decimal gtvendainicial;
        [XmlElement(ElementName = "GTVENDAINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Gtvendainicial
        {
            get { return  gtvendainicial; }
            set {  gtvendainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRFINAL
        /// Comentário: Hora final análise
        /// </summary>
        private string hrfinal;
        [XmlElement(ElementName = "HRFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Hrfinal
        {
            get { return  hrfinal; }
            set {  hrfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRINICIAL
        /// Comentário: Hora inicial análise
        /// </summary>
        private string hrinicial;
        [XmlElement(ElementName = "HRINICIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Hrinicial
        {
            get { return  hrinicial; }
            set {  hrinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: NÚMERO DO CAIXA.
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Comentário: NÚMERO DE SEQUÊNCIA.
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
        /// Propriedade referente ao campo: NUMSEQENTRADA
        /// Comentário: NÚMERO DE SEQUÊNCIA ENTRADA.
        /// </summary>
        private decimal numseqentrada;
        [XmlElement(ElementName = "NUMSEQENTRADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numseqentrada
        {
            get { return  numseqentrada; }
            set {  numseqentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEABERTURAGAVETA
        /// Comentário: QTDE VEZES QUE ABRIU A GAVETA .
        /// </summary>
        private decimal qtdeaberturagaveta;
        [XmlElement(ElementName = "QTDEABERTURAGAVETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Qtdeaberturagaveta
        {
            get { return  qtdeaberturagaveta; }
            set {  qtdeaberturagaveta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDECLIENTES
        /// Comentário: QTDE DE CLIENTES.
        /// </summary>
        private decimal qtdeclientes;
        [XmlElement(ElementName = "QTDECLIENTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdeclientes
        {
            get { return  qtdeclientes; }
            set {  qtdeclientes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDECUPONSCANCEL
        /// Comentário: QTDE DE CUPONS CANCELADOS.
        /// </summary>
        private decimal qtdecuponscancel;
        [XmlElement(ElementName = "QTDECUPONSCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdecuponscancel
        {
            get { return  qtdecuponscancel; }
            set {  qtdecuponscancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEITEMCANCEL
        /// Comentário: QTDE DE ITEM CANCELADO.
        /// </summary>
        private decimal qtdeitemcancel;
        [XmlElement(ElementName = "QTDEITEMCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Qtdeitemcancel
        {
            get { return  qtdeitemcancel; }
            set {  qtdeitemcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEITEMVENDA
        /// Comentário: QTDE DE ITEM NA VENDA.
        /// </summary>
        private decimal qtdeitemvenda;
        [XmlElement(ElementName = "QTDEITEMVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Qtdeitemvenda
        {
            get { return  qtdeitemvenda; }
            set {  qtdeitemvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEITEMVENDADIFERENCA
        /// Comentário: QTDE DE DIFERENÇA NOS ITENS DA VENDA.
        /// </summary>
        private decimal qtdeitemvendadiferenca;
        [XmlElement(ElementName = "QTDEITEMVENDADIFERENCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Qtdeitemvendadiferenca
        {
            get { return  qtdeitemvendadiferenca; }
            set {  qtdeitemvendadiferenca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDELINHASCUPOM
        /// Comentário: QTDE DE LINHA NO CUPOM.
        /// </summary>
        private decimal qtdelinhascupom;
        [XmlElement(ElementName = "QTDELINHASCUPOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdelinhascupom
        {
            get { return  qtdelinhascupom; }
            set {  qtdelinhascupom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESANGRIA
        /// Comentário: QTDE DA SANGRIA.
        /// </summary>
        private decimal qtdesangria;
        [XmlElement(ElementName = "QTDESANGRIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Qtdesangria
        {
            get { return  qtdesangria; }
            set {  qtdesangria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESANGRIARECEBTOBANC
        /// Comentário: QTDE SANGRIA RECEBIMENTO BANCARIO.
        /// </summary>
        private decimal qtdesangriarecebtobanc;
        [XmlElement(ElementName = "QTDESANGRIARECEBTOBANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdesangriarecebtobanc
        {
            get { return  qtdesangriarecebtobanc; }
            set {  qtdesangriarecebtobanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDESUPRIMENTO
        /// Comentário: Quantidade de suprimentos realizados durante o tempo que o caixa ficou aberto
        /// </summary>
        private decimal qtdesuprimento;
        [XmlElement(ElementName = "QTDESUPRIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Qtdesuprimento
        {
            get { return  qtdesuprimento; }
            set {  qtdesuprimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETEMPOCAIXAABERTO
        /// Comentário: Tempo total em que o caixa ficou aberto
        /// </summary>
        private decimal qtdetempocaixaaberto;
        [XmlElement(ElementName = "QTDETEMPOCAIXAABERTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdetempocaixaaberto
        {
            get { return  qtdetempocaixaaberto; }
            set {  qtdetempocaixaaberto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETEMPOINATIVO
        /// Comentário: Tempo total em que o caixa ficou inativo
        /// </summary>
        private decimal qtdetempoinativo;
        [XmlElement(ElementName = "QTDETEMPOINATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdetempoinativo
        {
            get { return  qtdetempoinativo; }
            set {  qtdetempoinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETEMPOPAUSA
        /// Comentário: QTDE DE PAUSA DO OPERADOR.
        /// </summary>
        private decimal qtdetempopausa;
        [XmlElement(ElementName = "QTDETEMPOPAUSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdetempopausa
        {
            get { return  qtdetempopausa; }
            set {  qtdetempopausa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETEMPOTOTALVENDA
        /// Comentário: QTDE DE TEMPO TOTAL DE VENDA.
        /// </summary>
        private decimal qtdetempototalvenda;
        [XmlElement(ElementName = "QTDETEMPOTOTALVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdetempototalvenda
        {
            get { return  qtdetempototalvenda; }
            set {  qtdetempototalvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDETEMPOVENDAITEM
        /// Comentário: QTDE DE TEMPO VENDA ITEM.
        /// </summary>
        private decimal qtdetempovendaitem;
        [XmlElement(ElementName = "QTDETEMPOVENDAITEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdetempovendaitem
        {
            get { return  qtdetempovendaitem; }
            set {  qtdetempovendaitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEVOLUMESPRODUTOS
        /// Comentário: QTDE DE VOLUMES DE PRODUTOS.
        /// </summary>
        private decimal qtdevolumesprodutos;
        [XmlElement(ElementName = "QTDEVOLUMESPRODUTOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Qtdevolumesprodutos
        {
            get { return  qtdevolumesprodutos; }
            set {  qtdevolumesprodutos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCANCEL
        /// Comentário: VALOR DO CANCELAMENTO.
        /// </summary>
        private decimal valorcancel;
        [XmlElement(ElementName = "VALORCANCEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorcancel
        {
            get { return  valorcancel; }
            set {  valorcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORDESC
        /// Comentário: VALOR DE DESCONTO.
        /// </summary>
        private decimal valordesc;
        [XmlElement(ElementName = "VALORDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valordesc
        {
            get { return  valordesc; }
            set {  valordesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORENCARGO
        /// Comentário: VALOR DE ENCARGO.
        /// </summary>
        private decimal valorencargo;
        [XmlElement(ElementName = "VALORENCARGO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorencargo
        {
            get { return  valorencargo; }
            set {  valorencargo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORENTRADANUMERARIO
        /// Comentário: VALOR DE RETIRADA DO CAIXA.
        /// </summary>
        private decimal valorentradanumerario;
        [XmlElement(ElementName = "VALORENTRADANUMERARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorentradanumerario
        {
            get { return  valorentradanumerario; }
            set {  valorentradanumerario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFINALIZDIFERENCA
        /// Comentário: VALOR DE DIFERENCA NA FINALIZADORA.
        /// </summary>
        private decimal valorfinalizdiferenca;
        [XmlElement(ElementName = "VALORFINALIZDIFERENCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorfinalizdiferenca
        {
            get { return  valorfinalizdiferenca; }
            set {  valorfinalizdiferenca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORFUNDOTROCO
        /// Comentário: VALOR DE FUNDO DE CAIXA.
        /// </summary>
        private decimal valorfundotroco;
        [XmlElement(ElementName = "VALORFUNDOTROCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorfundotroco
        {
            get { return  valorfundotroco; }
            set {  valorfundotroco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORSANGRIA
        /// Comentário: VALOR DA SANGRIA.
        /// </summary>
        private decimal valorsangria;
        [XmlElement(ElementName = "VALORSANGRIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorsangria
        {
            get { return  valorsangria; }
            set {  valorsangria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORSANGRIAAUTO
        /// Comentário: VALOR SANGRIA AUTOMATICO.
        /// </summary>
        private decimal valorsangriaauto;
        [XmlElement(ElementName = "VALORSANGRIAAUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorsangriaauto
        {
            get { return  valorsangriaauto; }
            set {  valorsangriaauto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORSANGRIADIFERENCA
        /// Comentário: VALOR DIFERENCA NA SANGRIA.
        /// </summary>
        private decimal valorsangriadiferenca;
        [XmlElement(ElementName = "VALORSANGRIADIFERENCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorsangriadiferenca
        {
            get { return  valorsangriadiferenca; }
            set {  valorsangriadiferenca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORSANGRIARECEBTOBANC
        /// Comentário: VALOR SANGRIA RECEBIMENTO BANCARIO.
        /// </summary>
        private decimal valorsangriarecebtobanc;
        [XmlElement(ElementName = "VALORSANGRIARECEBTOBANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorsangriarecebtobanc
        {
            get { return  valorsangriarecebtobanc; }
            set {  valorsangriarecebtobanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORSUPRIMENTO
        /// Comentário: Valor total dos suprimentos que foram realizados durante o tempo em que o caixa ficou aberto
        /// </summary>
        private decimal valorsuprimento;
        [XmlElement(ElementName = "VALORSUPRIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorsuprimento
        {
            get { return  valorsuprimento; }
            set {  valorsuprimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORVENDA
        /// Comentário: VALOR DA VENDA.
        /// </summary>
        private decimal valorvenda;
        [XmlElement(ElementName = "VALORVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorvenda
        {
            get { return  valorvenda; }
            set {  valorvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORVENDADIFERENCA
        /// Comentário: VALOR DE DIFERENCA NA VENDA.
        /// </summary>
        private decimal valorvendadiferenca;
        [XmlElement(ElementName = "VALORVENDADIFERENCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public decimal Valorvendadiferenca
        {
            get { return  valorvendadiferenca; }
            set {  valorvendadiferenca = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCAnalisepdv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCANALISEPDV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCAnalisepdv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAnalisepdv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCAnalisepdv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAnalisepdv>(where);
        }

        #endregion
    }
}
