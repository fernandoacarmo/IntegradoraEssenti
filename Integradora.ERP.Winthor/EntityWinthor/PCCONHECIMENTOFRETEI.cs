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
    /// Classe referente a tabela PCConhecimentofretei
    /// </summary>
    [XmlType("PCCONHECIMENTOFRETEI")]
    public class PCConhecimentofretei : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BCST
        /// Comentário: Valor da Base de Cálculo Substituição Tributária
        /// </summary>
        private decimal bcst;
        [XmlElement(ElementName = "BCST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Bcst
        {
            get { return  bcst; }
            set {  bcst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVECTE
        /// Comentário: Chave de Acesso da DACTE
        /// </summary>
        private string chavecte;
        [XmlElement(ElementName = "CHAVECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Chavecte
        {
            get { return  chavecte; }
            set {  chavecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAVENFE
        /// Comentário: Chave de Acesso da DANFE
        /// </summary>
        private string chavenfe;
        [XmlElement(ElementName = "CHAVENFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,44)]
        public string Chavenfe
        {
            get { return  chavenfe; }
            set {  chavenfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFISCAL
        /// Comentário: CFOP da nota
        /// </summary>
        private decimal codfiscal;
        [XmlElement(ElementName = "CODFISCAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfiscal
        {
            get { return  codfiscal; }
            set {  codfiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCMERCADORIA
        /// Comentário: Descrição das mercadorias na Nota
        /// </summary>
        private string descmercadoria;
        [XmlElement(ElementName = "DESCMERCADORIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Descmercadoria
        {
            get { return  descmercadoria; }
            set {  descmercadoria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEMISSAO
        /// Comentário: Data de emissão da nota fiscal
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
        /// Propriedade referente ao campo: ESPECIE
        /// Comentário: Espécie da nota fiscal do conhecimento. |Campo do tipo caracter, de tamanho 2.
        /// </summary>
        private string especie;
        [XmlElement(ElementName = "ESPECIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Especie
        {
            get { return  especie; }
            set {  especie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERARVIAGEM
        /// Comentário: gerar viagem myfrota
        /// </summary>
        private string gerarviagem;
        [XmlElement(ElementName = "GERARVIAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerarviagem
        {
            get { return  gerarviagem; }
            set {  gerarviagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDMYFROTAVIAGEM
        /// Comentário: Numero identificador da viagem no myfrota
        /// </summary>
        private decimal idmyfrotaviagem;
        [XmlElement(ElementName = "IDMYFROTAVIAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Idmyfrotaviagem
        {
            get { return  idmyfrotaviagem; }
            set {  idmyfrotaviagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NATUREZA
        /// Comentário: Natureza da carga. |Campo do tipo caracter, de tamanho 40.
        /// </summary>
        private string natureza;
        [XmlElement(ElementName = "NATUREZA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Natureza
        {
            get { return  natureza; }
            set {  natureza = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDAR
        /// Comentário: Número do DAR-1/AUT
        /// </summary>
        private decimal numdar;
        [XmlElement(ElementName = "NUMDAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Numdar
        {
            get { return  numdar; }
            set {  numdar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: Número da nota fiscal do conhecimento de frete. |Campo do tipo numérico, de tamanho 6.
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSCONHEC
        /// Comentário: Número da transação do conhecimento do frete.  Usado para ligação com o cabeçalho do conhecimento de frete. |Campo do tipo numérico, de tamanho 10.
        /// </summary>
        private decimal numtransconhec;
        [XmlElement(ElementName = "NUMTRANSCONHEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numtransconhec
        {
            get { return  numtransconhec; }
            set {  numtransconhec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSITEM
        /// Comentário: Campo para chave primaria da tabela
        /// </summary>
        private decimal numtransitem;
        [XmlElement(ElementName = "NUMTRANSITEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,18)]
        public decimal Numtransitem
        {
            get { return  numtransitem; }
            set {  numtransitem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESO
        /// Comentário: Peso total da Nota Fiscal. |Campo do tipo numérico, de tamanho 12, com 6 decimais.
        /// </summary>
        private decimal peso;
        [XmlElement(ElementName = "PESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Peso
        {
            get { return  peso; }
            set {  peso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTITENS
        /// Comentário: Quantidade de itens da nota fiscal. |Campo do tipo numérico, de tamanho 9.
        /// </summary>
        private decimal qtitens;
        [XmlElement(ElementName = "QTITENS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Qtitens
        {
            get { return  qtitens; }
            set {  qtitens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLITRAGEM
        /// Comentário: Quantidade de Litragem
        /// </summary>
        private decimal qtlitragem;
        [XmlElement(ElementName = "QTLITRAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtlitragem
        {
            get { return  qtlitragem; }
            set {  qtlitragem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTMETROSCUBICOS
        /// Comentário: Quantidade de metros cubicos
        /// </summary>
        private decimal qtmetroscubicos;
        [XmlElement(ElementName = "QTMETROSCUBICOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Qtmetroscubicos
        {
            get { return  qtmetroscubicos; }
            set {  qtmetroscubicos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ST
        /// Comentário: Valor do ICMS Subst. Tributária
        /// </summary>
        private decimal st;
        [XmlElement(ElementName = "ST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal St
        {
            get { return  st; }
            set {  st = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFRETE
        /// Comentário: Tipo do Frete
        /// </summary>
        private decimal tipofrete;
        [XmlElement(ElementName = "TIPOFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipofrete
        {
            get { return  tipofrete; }
            set {  tipofrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMEDIDACTE
        /// Comentário: Armazena o tipo de medida utilizado
        /// </summary>
        private string tipomedidacte;
        [XmlElement(ElementName = "TIPOMEDIDACTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Tipomedidacte
        {
            get { return  tipomedidacte; }
            set {  tipomedidacte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPDOCUMENTO
        /// Comentário: Tipo do Documento
        /// </summary>
        private string tpdocumento;
        [XmlElement(ElementName = "TPDOCUMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tpdocumento
        {
            get { return  tpdocumento; }
            set {  tpdocumento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UNIDADECTE
        /// Comentário: Armazena a unidade de medida do CTE
        /// </summary>
        private string unidadecte;
        [XmlElement(ElementName = "UNIDADECTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Unidadecte
        {
            get { return  unidadecte; }
            set {  unidadecte = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLBASE
        /// Comentário: Valor da Base de Cálculo do ICMS
        /// </summary>
        private decimal vlbase;
        [XmlElement(ElementName = "VLBASE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlbase
        {
            get { return  vlbase; }
            set {  vlbase = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Comentário: Valor do Frete
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Comentário: Valor do ICMS
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLIPI
        /// Comentário: Valor de IPI
        /// </summary>
        private decimal vlipi;
        [XmlElement(ElementName = "VLIPI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlipi
        {
            get { return  vlipi; }
            set {  vlipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLOUTRASDESP
        /// Comentário: Valor de Outras Despesas Acessórias
        /// </summary>
        private decimal vloutrasdesp;
        [XmlElement(ElementName = "VLOUTRASDESP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vloutrasdesp
        {
            get { return  vloutrasdesp; }
            set {  vloutrasdesp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSEGURO
        /// Comentário: Valor do Seguro
        /// </summary>
        private decimal vlseguro;
        [XmlElement(ElementName = "VLSEGURO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlseguro
        {
            get { return  vlseguro; }
            set {  vlseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTAL
        /// Comentário: Valor total das mercadorias da nota fiscal. |Campo do tipo numérico, de tamanho 18, com 6 decimais.
        /// </summary>
        private decimal vltotal;
        [XmlElement(ElementName = "VLTOTAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotal
        {
            get { return  vltotal; }
            set {  vltotal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Comentário: Volume total da Nota Fiscal. |Campo do tipo numérico, de tamanho 12, com 6 decimais.
        /// </summary>
        private decimal volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Volume
        {
            get { return  volume; }
            set {  volume = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConhecimentofretei()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONHECIMENTOFRETEI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConhecimentofretei> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConhecimentofretei>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConhecimentofretei> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConhecimentofretei>(where);
        }

        #endregion
    }
}
