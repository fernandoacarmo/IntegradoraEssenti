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
    /// Classe referente a tabela PCDepreciacao
    /// </summary>
    [XmlType("PCDEPRECIACAO")]
    public class PCDepreciacao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: Indica o ano depreciado.
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BEMSALVO
        /// Comentário: Indica se o calculo foi salvo.
        /// </summary>
        private string bemsalvo;
        [XmlElement(ElementName = "BEMSALVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bemsalvo
        {
            get { return  bemsalvo; }
            set {  bemsalvo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Indica o código filial.
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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: Indica o código do bem.
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
        /// Propriedade referente ao campo: DATAULTDEPRECIACAO
        /// Comentário: Indica a data da ultima depreciação.
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
        /// Propriedade referente ao campo: MES
        /// Comentário: Indica o mês depreciado.
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANCTOCONTABIL
        /// Comentário: Indica número do lançamento.
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
        /// Propriedade referente ao campo: NUMLANCTOCONTABILATRIBUIDO
        /// Comentário: Núm. Lançamento contábil por Valor Atribuído
        /// </summary>
        private decimal numlanctocontabilatribuido;
        [XmlElement(ElementName = "NUMLANCTOCONTABILATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Numlanctocontabilatribuido
        {
            get { return  numlanctocontabilatribuido; }
            set {  numlanctocontabilatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLANCTOCONTABILCORRIGIDO
        /// Comentário: Núm. Lançamento contábil por Valor Corrigido
        /// </summary>
        private decimal numlanctocontabilcorrigido;
        [XmlElement(ElementName = "NUMLANCTOCONTABILCORRIGIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,38)]
        public decimal Numlanctocontabilcorrigido
        {
            get { return  numlanctocontabilcorrigido; }
            set {  numlanctocontabilcorrigido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSACAO
        /// Comentário: Indica o número da transação.
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
        /// Propriedade referente ao campo: QTDDIASDEPRECIADOS
        /// Comentário: Quantidade de dias depreciados.
        /// </summary>
        private decimal qtddiasdepreciados;
        [XmlElement(ElementName = "QTDDIASDEPRECIADOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtddiasdepreciados
        {
            get { return  qtddiasdepreciados; }
            set {  qtddiasdepreciados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQBENSPATRIMONIAIS
        /// Comentário: Sequência do bem individualizado.
        /// </summary>
        private decimal seqbenspatrimoniais;
        [XmlElement(ElementName = "SEQBENSPATRIMONIAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Seqbenspatrimoniais
        {
            get { return  seqbenspatrimoniais; }
            set {  seqbenspatrimoniais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQDEPRECIACAO
        /// Comentário: Indica a sequencial da depreciação.
        /// </summary>
        private decimal seqdepreciacao;
        [XmlElement(ElementName = "SEQDEPRECIACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Seqdepreciacao
        {
            get { return  seqdepreciacao; }
            set {  seqdepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCALCDEPRECIACAO
        /// Comentário: Tipo do cáculo de depreciação
        /// </summary>
        private string tipocalcdepreciacao;
        [XmlElement(ElementName = "TIPOCALCDEPRECIACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocalcdepreciacao
        {
            get { return  tipocalcdepreciacao; }
            set {  tipocalcdepreciacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOTRANSACAO
        /// Comentário: Indica o tipo da transação.
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
        /// Propriedade referente ao campo: VALORATRIBUIDOBEM
        /// Comentário: Indica o Valor Atribuído do bem
        /// </summary>
        private decimal valoratribuidobem;
        [XmlElement(ElementName = "VALORATRIBUIDOBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valoratribuidobem
        {
            get { return  valoratribuidobem; }
            set {  valoratribuidobem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORBEM
        /// Comentário: Indica o valor do bem.
        /// </summary>
        private decimal valorbem;
        [XmlElement(ElementName = "VALORBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorbem
        {
            get { return  valorbem; }
            set {  valorbem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCORRIGIDOBEM
        /// Comentário: Indica o Valor corrigido do bem
        /// </summary>
        private decimal valorcorrigidobem;
        [XmlElement(ElementName = "VALORCORRIGIDOBEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorcorrigidobem
        {
            get { return  valorcorrigidobem; }
            set {  valorcorrigidobem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECACUMULADA
        /// Comentário: Indica o valor da depreciação acumulado.
        /// </summary>
        private decimal vlrdeprecacumulada;
        [XmlElement(ElementName = "VLRDEPRECACUMULADA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrdeprecacumulada
        {
            get { return  vlrdeprecacumulada; }
            set {  vlrdeprecacumulada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECACUMULADAATRIBUIDO
        /// Comentário: Indica o valor da depreciação acumulado do valor atribuído.
        /// </summary>
        private decimal vlrdeprecacumuladaatribuido;
        [XmlElement(ElementName = "VLRDEPRECACUMULADAATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrdeprecacumuladaatribuido
        {
            get { return  vlrdeprecacumuladaatribuido; }
            set {  vlrdeprecacumuladaatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECACUMULADACORRIGIDO
        /// Comentário: Indica o valor da depreciação acumulado do valor corrigido.
        /// </summary>
        private decimal vlrdeprecacumuladacorrigido;
        [XmlElement(ElementName = "VLRDEPRECACUMULADACORRIGIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrdeprecacumuladacorrigido
        {
            get { return  vlrdeprecacumuladacorrigido; }
            set {  vlrdeprecacumuladacorrigido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECMES
        /// Comentário: Indica o valor depreciado do mês.
        /// </summary>
        private decimal vlrdeprecmes;
        [XmlElement(ElementName = "VLRDEPRECMES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrdeprecmes
        {
            get { return  vlrdeprecmes; }
            set {  vlrdeprecmes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECMESATRIBUIDO
        /// Comentário: Indica o valor depreciado do mês sobre o valor atribuído do bem.
        /// </summary>
        private decimal vlrdeprecmesatribuido;
        [XmlElement(ElementName = "VLRDEPRECMESATRIBUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrdeprecmesatribuido
        {
            get { return  vlrdeprecmesatribuido; }
            set {  vlrdeprecmesatribuido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEPRECMESCORRIGIDO
        /// Comentário: Indica o valor depreciado do mês sobre o valor corrigido do bem.
        /// </summary>
        private decimal vlrdeprecmescorrigido;
        [XmlElement(ElementName = "VLRDEPRECMESCORRIGIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlrdeprecmescorrigido
        {
            get { return  vlrdeprecmescorrigido; }
            set {  vlrdeprecmescorrigido = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDepreciacao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDEPRECIACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDepreciacao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDepreciacao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDepreciacao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDepreciacao>(where);
        }

        #endregion
    }
}
