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
        /// Coment�rio: C�DIGO FILIAL.
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
        /// Coment�rio: C�DIGO DO FUNCION�RIO .
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
        /// Coment�rio: C�DIGO DO SUPERVISOR.
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
        /// Coment�rio: DATA DE GRAVACAO.
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
        /// Coment�rio: DATA E HORA DA ENTRADA.
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
        /// Coment�rio: DATA E HORA DA SA�DA.
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
        /// Coment�rio: Identifica se o registro foi exportado
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
        /// Coment�rio: GT FINAL DO CANCELAMENTO.
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
        /// Coment�rio: GT INICIAL DO CANCELAMENTO.
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
        /// Coment�rio: GT FINAL DO DESCONTO.
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
        /// Coment�rio: GT INICIAL DO DESCONTO.
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
        /// Coment�rio: GT FINAL DA VENDA.
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
        /// Coment�rio: GT INICIAL DA VENDA.
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
        /// Coment�rio: Hora final an�lise
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
        /// Coment�rio: Hora inicial an�lise
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
        /// Coment�rio: N�MERO DO CAIXA.
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
        /// Coment�rio: N�MERO DE SEQU�NCIA.
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
        /// Coment�rio: N�MERO DE SEQU�NCIA ENTRADA.
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
        /// Coment�rio: QTDE VEZES QUE ABRIU A GAVETA .
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
        /// Coment�rio: QTDE DE CLIENTES.
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
        /// Coment�rio: QTDE DE CUPONS CANCELADOS.
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
        /// Coment�rio: QTDE DE ITEM CANCELADO.
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
        /// Coment�rio: QTDE DE ITEM NA VENDA.
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
        /// Coment�rio: QTDE DE DIFEREN�A NOS ITENS DA VENDA.
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
        /// Coment�rio: QTDE DE LINHA NO CUPOM.
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
        /// Coment�rio: QTDE DA SANGRIA.
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
        /// Coment�rio: QTDE SANGRIA RECEBIMENTO BANCARIO.
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
        /// Coment�rio: Quantidade de suprimentos realizados durante o tempo que o caixa ficou aberto
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
        /// Coment�rio: Tempo total em que o caixa ficou aberto
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
        /// Coment�rio: Tempo total em que o caixa ficou inativo
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
        /// Coment�rio: QTDE DE PAUSA DO OPERADOR.
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
        /// Coment�rio: QTDE DE TEMPO TOTAL DE VENDA.
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
        /// Coment�rio: QTDE DE TEMPO VENDA ITEM.
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
        /// Coment�rio: QTDE DE VOLUMES DE PRODUTOS.
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
        /// Coment�rio: VALOR DO CANCELAMENTO.
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
        /// Coment�rio: VALOR DE DESCONTO.
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
        /// Coment�rio: VALOR DE ENCARGO.
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
        /// Coment�rio: VALOR DE RETIRADA DO CAIXA.
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
        /// Coment�rio: VALOR DE DIFERENCA NA FINALIZADORA.
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
        /// Coment�rio: VALOR DE FUNDO DE CAIXA.
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
        /// Coment�rio: VALOR DA SANGRIA.
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
        /// Coment�rio: VALOR SANGRIA AUTOMATICO.
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
        /// Coment�rio: VALOR DIFERENCA NA SANGRIA.
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
        /// Coment�rio: VALOR SANGRIA RECEBIMENTO BANCARIO.
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
        /// Coment�rio: Valor total dos suprimentos que foram realizados durante o tempo em que o caixa ficou aberto
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
        /// Coment�rio: VALOR DA VENDA.
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
        /// Coment�rio: VALOR DE DIFERENCA NA VENDA.
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAnalisepdv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAnalisepdv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
