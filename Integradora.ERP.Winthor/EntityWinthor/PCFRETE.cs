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
    /// Classe referente a tabela PCFrete
    /// </summary>
    [XmlType("PCFRETE")]
    public class PCFrete : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS
        /// Comentário: 
        /// </summary>
        private decimal aliqicms;
        [XmlElement(ElementName = "ALIQICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms
        {
            get { return  aliqicms; }
            set {  aliqicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: CÓDIGO DA FILIAL
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
        /// Comentário: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFRETE
        /// Comentário: 
        /// </summary>
        private decimal codfrete;
        [XmlElement(ElementName = "CODFRETE", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Codfrete
        {
            get { return  codfrete; }
            set {  codfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEXCLUSAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODPRACADESTINO
        /// Comentário: 
        /// </summary>
        private decimal codpracadestino;
        [XmlElement(ElementName = "CODPRACADESTINO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpracadestino
        {
            get { return  codpracadestino; }
            set {  codpracadestino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACAORIGEM
        /// Comentário: 
        /// </summary>
        private decimal codpracaorigem;
        [XmlElement(ElementName = "CODPRACAORIGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpracaorigem
        {
            get { return  codpracaorigem; }
            set {  codpracaorigem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COLUNAFRETE
        /// Comentário: COLUNA DO FRETE
        /// </summary>
        private string colunafrete;
        [XmlElement(ElementName = "COLUNAFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Colunafrete
        {
            get { return  colunafrete; }
            set {  colunafrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXCLUSAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: KMDISTANCIA
        /// Comentário: KM da distância entre origem e destino
        /// </summary>
        private decimal kmdistancia;
        [XmlElement(ElementName = "KMDISTANCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Kmdistancia
        {
            get { return  kmdistancia; }
            set {  kmdistancia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE1
        /// Comentário: Percentual do Frete 1
        /// </summary>
        private decimal percfrete1;
        [XmlElement(ElementName = "PERCFRETE1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete1
        {
            get { return  percfrete1; }
            set {  percfrete1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE10
        /// Comentário: Percentual do Frete 10
        /// </summary>
        private decimal percfrete10;
        [XmlElement(ElementName = "PERCFRETE10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete10
        {
            get { return  percfrete10; }
            set {  percfrete10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE2
        /// Comentário: Percentual do Frete 2
        /// </summary>
        private decimal percfrete2;
        [XmlElement(ElementName = "PERCFRETE2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete2
        {
            get { return  percfrete2; }
            set {  percfrete2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE3
        /// Comentário: Percentual do Frete 3
        /// </summary>
        private decimal percfrete3;
        [XmlElement(ElementName = "PERCFRETE3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete3
        {
            get { return  percfrete3; }
            set {  percfrete3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE4
        /// Comentário: Percentual do Frete 4
        /// </summary>
        private decimal percfrete4;
        [XmlElement(ElementName = "PERCFRETE4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete4
        {
            get { return  percfrete4; }
            set {  percfrete4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE5
        /// Comentário: Percentual do Frete 5
        /// </summary>
        private decimal percfrete5;
        [XmlElement(ElementName = "PERCFRETE5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete5
        {
            get { return  percfrete5; }
            set {  percfrete5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE6
        /// Comentário: Percentual do Frete 6
        /// </summary>
        private decimal percfrete6;
        [XmlElement(ElementName = "PERCFRETE6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete6
        {
            get { return  percfrete6; }
            set {  percfrete6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE7
        /// Comentário: Percentual do Frete 7
        /// </summary>
        private decimal percfrete7;
        [XmlElement(ElementName = "PERCFRETE7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete7
        {
            get { return  percfrete7; }
            set {  percfrete7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE8
        /// Comentário: Percentual do Frete 8
        /// </summary>
        private decimal percfrete8;
        [XmlElement(ElementName = "PERCFRETE8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete8
        {
            get { return  percfrete8; }
            set {  percfrete8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCFRETE9
        /// Comentário: Percentual do Frete 9
        /// </summary>
        private decimal percfrete9;
        [XmlElement(ElementName = "PERCFRETE9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Percfrete9
        {
            get { return  percfrete9; }
            set {  percfrete9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERFRETE
        /// Comentário: 
        /// </summary>
        private decimal perfrete;
        [XmlElement(ElementName = "PERFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perfrete
        {
            get { return  perfrete; }
            set {  perfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERGRIS
        /// Comentário: 
        /// </summary>
        private decimal pergris;
        [XmlElement(ElementName = "PERGRIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Pergris
        {
            get { return  pergris; }
            set {  pergris = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERSEGURO
        /// Comentário: PERCENTUAL DO SEGURO
        /// </summary>
        private decimal perseguro;
        [XmlElement(ElementName = "PERSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Perseguro
        {
            get { return  perseguro; }
            set {  perseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Comentário: Tipo do frete a considerar.
        /// </summary>
        private string tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TRANSPPRIORITARIA
        /// Comentário: DEFINE PRIORIDADE DA TRANSPORTADORA
        /// </summary>
        private string transpprioritaria;
        [XmlElement(ElementName = "TRANSPPRIORITARIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Transpprioritaria
        {
            get { return  transpprioritaria; }
            set {  transpprioritaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORCOMISSAOFRETE
        /// Comentário: Indica o valor da comissão paga a esta entrega.
        /// </summary>
        private decimal valorcomissaofrete;
        [XmlElement(ElementName = "VALORCOMISSAOFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Valorcomissaofrete
        {
            get { return  valorcomissaofrete; }
            set {  valorcomissaofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCUBAGEM
        /// Comentário: VALOR POR METRO CÚBICO
        /// </summary>
        private decimal vlcubagem;
        [XmlElement(ElementName = "VLCUBAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlcubagem
        {
            get { return  vlcubagem; }
            set {  vlcubagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDESPACHO
        /// Comentário: VALOR DE DESPACHO
        /// </summary>
        private decimal vldespacho;
        [XmlElement(ElementName = "VLDESPACHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vldespacho
        {
            get { return  vldespacho; }
            set {  vldespacho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFAIXAPEDAGIOKG
        /// Comentário: FAIXA DE PEDÁGIO POR KG.
        /// </summary>
        private decimal vlfaixapedagiokg;
        [XmlElement(ElementName = "VLFAIXAPEDAGIOKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfaixapedagiokg
        {
            get { return  vlfaixapedagiokg; }
            set {  vlfaixapedagiokg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEKGEXCEDENTE
        /// Comentário: 
        /// </summary>
        private decimal vlfretekgexcedente;
        [XmlElement(ElementName = "VLFRETEKGEXCEDENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfretekgexcedente
        {
            get { return  vlfretekgexcedente; }
            set {  vlfretekgexcedente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE1
        /// Comentário: Valor Frete 1
        /// </summary>
        private decimal vlfrete1;
        [XmlElement(ElementName = "VLFRETE1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete1
        {
            get { return  vlfrete1; }
            set {  vlfrete1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE10
        /// Comentário: Valor Frete 10
        /// </summary>
        private decimal vlfrete10;
        [XmlElement(ElementName = "VLFRETE10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete10
        {
            get { return  vlfrete10; }
            set {  vlfrete10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE2
        /// Comentário: Valor Frete 2
        /// </summary>
        private decimal vlfrete2;
        [XmlElement(ElementName = "VLFRETE2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete2
        {
            get { return  vlfrete2; }
            set {  vlfrete2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE3
        /// Comentário: Valor Frete 3
        /// </summary>
        private decimal vlfrete3;
        [XmlElement(ElementName = "VLFRETE3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete3
        {
            get { return  vlfrete3; }
            set {  vlfrete3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE4
        /// Comentário: Valor Frete 4
        /// </summary>
        private decimal vlfrete4;
        [XmlElement(ElementName = "VLFRETE4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete4
        {
            get { return  vlfrete4; }
            set {  vlfrete4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE5
        /// Comentário: Valor Frete 5
        /// </summary>
        private decimal vlfrete5;
        [XmlElement(ElementName = "VLFRETE5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete5
        {
            get { return  vlfrete5; }
            set {  vlfrete5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE6
        /// Comentário: Valor Frete 6
        /// </summary>
        private decimal vlfrete6;
        [XmlElement(ElementName = "VLFRETE6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete6
        {
            get { return  vlfrete6; }
            set {  vlfrete6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE7
        /// Comentário: Valor Frete 7
        /// </summary>
        private decimal vlfrete7;
        [XmlElement(ElementName = "VLFRETE7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete7
        {
            get { return  vlfrete7; }
            set {  vlfrete7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE8
        /// Comentário: Valor Frete 8
        /// </summary>
        private decimal vlfrete8;
        [XmlElement(ElementName = "VLFRETE8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete8
        {
            get { return  vlfrete8; }
            set {  vlfrete8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE9
        /// Comentário: Valor Frete 9
        /// </summary>
        private decimal vlfrete9;
        [XmlElement(ElementName = "VLFRETE9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfrete9
        {
            get { return  vlfrete9; }
            set {  vlfrete9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKG
        /// Comentário: VALOR POR KG.
        /// </summary>
        private decimal vlkg;
        [XmlElement(ElementName = "VLKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkg
        {
            get { return  vlkg; }
            set {  vlkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE1
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete1;
        [XmlElement(ElementName = "VLKGFRETE1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete1
        {
            get { return  vlkgfrete1; }
            set {  vlkgfrete1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE10
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete10;
        [XmlElement(ElementName = "VLKGFRETE10", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete10
        {
            get { return  vlkgfrete10; }
            set {  vlkgfrete10 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE2
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete2;
        [XmlElement(ElementName = "VLKGFRETE2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete2
        {
            get { return  vlkgfrete2; }
            set {  vlkgfrete2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE3
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete3;
        [XmlElement(ElementName = "VLKGFRETE3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete3
        {
            get { return  vlkgfrete3; }
            set {  vlkgfrete3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE4
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete4;
        [XmlElement(ElementName = "VLKGFRETE4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete4
        {
            get { return  vlkgfrete4; }
            set {  vlkgfrete4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE5
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete5;
        [XmlElement(ElementName = "VLKGFRETE5", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete5
        {
            get { return  vlkgfrete5; }
            set {  vlkgfrete5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE6
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete6;
        [XmlElement(ElementName = "VLKGFRETE6", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete6
        {
            get { return  vlkgfrete6; }
            set {  vlkgfrete6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE7
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete7;
        [XmlElement(ElementName = "VLKGFRETE7", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete7
        {
            get { return  vlkgfrete7; }
            set {  vlkgfrete7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE8
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete8;
        [XmlElement(ElementName = "VLKGFRETE8", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete8
        {
            get { return  vlkgfrete8; }
            set {  vlkgfrete8 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLKGFRETE9
        /// Comentário: VALOR FRETE POR KG
        /// </summary>
        private decimal vlkgfrete9;
        [XmlElement(ElementName = "VLKGFRETE9", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlkgfrete9
        {
            get { return  vlkgfrete9; }
            set {  vlkgfrete9 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMINIMO
        /// Comentário: 
        /// </summary>
        private decimal vlminimo;
        [XmlElement(ElementName = "VLMINIMO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlminimo
        {
            get { return  vlminimo; }
            set {  vlminimo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPALETE
        /// Comentário: VALOR POR PALETE
        /// </summary>
        private decimal vlpalete;
        [XmlElement(ElementName = "VLPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpalete
        {
            get { return  vlpalete; }
            set {  vlpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPEDAGIO
        /// Comentário: 
        /// </summary>
        private decimal vlpedagio;
        [XmlElement(ElementName = "VLPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlpedagio
        {
            get { return  vlpedagio; }
            set {  vlpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPERGRIS
        /// Comentário: 
        /// </summary>
        private decimal vlpergris;
        [XmlElement(ElementName = "VLPERGRIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Vlpergris
        {
            get { return  vlpergris; }
            set {  vlpergris = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTAS
        /// Comentário: 
        /// </summary>
        private decimal vltas;
        [XmlElement(ElementName = "VLTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltas
        {
            get { return  vltas; }
            set {  vltas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTDE
        /// Comentário: VALOR DA TAXA DE DIFILCUDADE DE ENTREGA
        /// </summary>
        private decimal vltde;
        [XmlElement(ElementName = "VLTDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vltde
        {
            get { return  vltde; }
            set {  vltde = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ZONAFLUVIAL
        /// Comentário: 
        /// </summary>
        private string zonafluvial;
        [XmlElement(ElementName = "ZONAFLUVIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Zonafluvial
        {
            get { return  zonafluvial; }
            set {  zonafluvial = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFrete()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFRETE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFrete> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFrete>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFrete> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFrete>(where);
        }

        #endregion
    }
}
