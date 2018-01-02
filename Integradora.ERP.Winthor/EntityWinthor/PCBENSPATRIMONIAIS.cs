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
    /// Classe referente a tabela PCBenspatrimoniais
    /// </summary>
    [XmlType("PCBENSPATRIMONIAIS")]
    public class PCBenspatrimoniais : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código filial do bem.
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
        /// Propriedade referente ao campo: CODFORNEC
        /// Comentário: Código do Fornecedor
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
        /// Propriedade referente ao campo: CODLOCALIZACAOBEM
        /// Comentário: Código da localização do bem.
        /// </summary>
        private decimal codlocalizacaobem;
        [XmlElement(ElementName = "CODLOCALIZACAOBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codlocalizacaobem
        {
            get { return  codlocalizacaobem; }
            set {  codlocalizacaobem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Código do bem patrimonial.
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
        /// Propriedade referente ao campo: CODPRODIMOPRI
        /// Comentário: Código de produto do bem imobilizado principal.
        /// </summary>
        private decimal codprodimopri;
        [XmlElement(ElementName = "CODPRODIMOPRI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codprodimopri
        {
            get { return  codprodimopri; }
            set {  codprodimopri = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRESPONSAVELBEM
        /// Comentário: Código do responsável pelo bem.
        /// </summary>
        private decimal codresponsavelbem;
        [XmlElement(ElementName = "CODRESPONSAVELBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codresponsavelbem
        {
            get { return  codresponsavelbem; }
            set {  codresponsavelbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTABILIZABEM
        /// Comentário: Contabiliza bem no módulo contábil.
        /// </summary>
        private string contabilizabem;
        [XmlElement(ElementName = "CONTABILIZABEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Contabilizabem
        {
            get { return  contabilizabem; }
            set {  contabilizabem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATABAIXA
        /// Comentário: Data da baixa do bem.
        /// </summary>
        private DateTime? databaixa;
        [XmlElement(ElementName = "DATABAIXA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Databaixa
        {
            get { return  databaixa; }
            set {  databaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENTRADA
        /// Comentário: Data de entrada do bem.
        /// </summary>
        private DateTime? dataentrada;
        [XmlElement(ElementName = "DATAENTRADA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataentrada
        {
            get { return  dataentrada; }
            set {  dataentrada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAULTDEPRECIACAO
        /// Comentário: Data da última depreciação do bem.
        /// </summary>
        private DateTime? dataultdepreciacao;
        [XmlElement(ElementName = "DATAULTDEPRECIACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataultdepreciacao
        {
            get { return  dataultdepreciacao; }
            set {  dataultdepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCCOMPLEMENTAR
        /// Comentário: Descrição complementar para entrada do bem.
        /// </summary>
        private string desccomplementar;
        [XmlElement(ElementName = "DESCCOMPLEMENTAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1500)]
        public string Desccomplementar
        {
            get { return  desccomplementar; }
            set {  desccomplementar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCANCEL
        /// Comentário: Data de cancelamento
        /// </summary>
        private DateTime? dtcancel;
        [XmlElement(ElementName = "DTCANCEL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcancel
        {
            get { return  dtcancel; }
            set {  dtcancel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTTERMINOCIAP
        /// Comentário: Data de término do CIAP
        /// </summary>
        private DateTime? dtterminociap;
        [XmlElement(ElementName = "DTTERMINOCIAP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtterminociap
        {
            get { return  dtterminociap; }
            set {  dtterminociap = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Número da nota de entrada do bem.
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPATRIMONIO
        /// Comentário: Número do patrimônio do bem.
        /// </summary>
        private string numpatrimonio;
        [XmlElement(ElementName = "NUMPATRIMONIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numpatrimonio
        {
            get { return  numpatrimonio; }
            set {  numpatrimonio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: Número de transação do bem.
        /// </summary>
        private decimal numtransacao;
        [XmlElement(ElementName = "NUMTRANSACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numtransacao
        {
            get { return  numtransacao; }
            set {  numtransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDA
        /// Comentário: Número da Transação
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
        /// Propriedade referente ao campo: SEQUENCIA
        /// Comentário: Sequência de lançamento patrimonial.
        /// </summary>
        private decimal sequencia;
        [XmlElement(ElementName = "SEQUENCIA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Sequencia
        {
            get { return  sequencia; }
            set {  sequencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXADEPRECIACAO
        /// Comentário: Taxa de depreciação do bem.
        /// </summary>
        private decimal taxadepreciacao;
        [XmlElement(ElementName = "TAXADEPRECIACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Taxadepreciacao
        {
            get { return  taxadepreciacao; }
            set {  taxadepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXADEPRECIACAOATRIBUIDO
        /// Comentário: Taxa de Depreciação do Valor Atribuído
        /// </summary>
        private decimal taxadepreciacaoatribuido;
        [XmlElement(ElementName = "TAXADEPRECIACAOATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Taxadepreciacaoatribuido
        {
            get { return  taxadepreciacaoatribuido; }
            set {  taxadepreciacaoatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAXADEPRECIACAOCORRIGIDO
        /// Comentário: Taxa de Depreciação do Valor Corrigido
        /// </summary>
        private decimal taxadepreciacaocorrigido;
        [XmlElement(ElementName = "TAXADEPRECIACAOCORRIGIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Taxadepreciacaocorrigido
        {
            get { return  taxadepreciacaocorrigido; }
            set {  taxadepreciacaocorrigido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOBAIXA
        /// Comentário: Tipo da baixa do bem.
        /// </summary>
        private string tipobaixa;
        [XmlElement(ElementName = "TIPOBAIXA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipobaixa
        {
            get { return  tipobaixa; }
            set {  tipobaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRANSACAO
        /// Comentário: Tipo de transação que foi dado entrada.
        /// </summary>
        private string tipotransacao;
        [XmlElement(ElementName = "TIPOTRANSACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipotransacao
        {
            get { return  tipotransacao; }
            set {  tipotransacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBEMATRIBUIDO
        /// Comentário: Valor do Bem Atribuído
        /// </summary>
        private decimal vlbematribuido;
        [XmlElement(ElementName = "VLBEMATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,26)]
        public decimal Vlbematribuido
        {
            get { return  vlbematribuido; }
            set {  vlbematribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCORRIGIDO
        /// Comentário: Valor de ST da nota fiscal
        /// </summary>
        private decimal vlcorrigido;
        [XmlElement(ElementName = "VLCORRIGIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,26)]
        public decimal Vlcorrigido
        {
            get { return  vlcorrigido; }
            set {  vlcorrigido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRATUALBEM
        /// Comentário: Valor atual do bem.
        /// </summary>
        private decimal vlratualbem;
        [XmlElement(ElementName = "VLRATUALBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,26)]
        public decimal Vlratualbem
        {
            get { return  vlratualbem; }
            set {  vlratualbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECACUMULADA
        /// Comentário: Valor depreciação acumulada do bem.
        /// </summary>
        private decimal vlrdeprecacumulada;
        [XmlElement(ElementName = "VLRDEPRECACUMULADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlrdeprecacumulada
        {
            get { return  vlrdeprecacumulada; }
            set {  vlrdeprecacumulada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECACUMULADAATRIBUIDO
        /// Comentário: Valor Depreciação Acumulada Atribuído
        /// </summary>
        private decimal vlrdeprecacumuladaatribuido;
        [XmlElement(ElementName = "VLRDEPRECACUMULADAATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlrdeprecacumuladaatribuido
        {
            get { return  vlrdeprecacumuladaatribuido; }
            set {  vlrdeprecacumuladaatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECACUMULADACORRIGIDO
        /// Comentário: 
        /// </summary>
        private decimal vlrdeprecacumuladacorrigido;
        [XmlElement(ElementName = "VLRDEPRECACUMULADACORRIGIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlrdeprecacumuladacorrigido
        {
            get { return  vlrdeprecacumuladacorrigido; }
            set {  vlrdeprecacumuladacorrigido = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBenspatrimoniais()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBENSPATRIMONIAIS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBenspatrimoniais> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBenspatrimoniais>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBenspatrimoniais> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBenspatrimoniais>(where);
        }

        #endregion
    }
}
