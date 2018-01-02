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
    /// Classe referente a tabela PCPedidadosveiculos
    /// </summary>
    [XmlType("PCPEDIDADOSVEICULOS")]
    public class PCPedidadosveiculos : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANOFAB
        /// Coment�rio: Ano Fabrica��o
        /// </summary>
        private decimal anofab;
        [XmlElement(ElementName = "ANOFAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Anofab
        {
            get { return  anofab; }
            set {  anofab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANOMOD
        /// Coment�rio: Ano Modelo
        /// </summary>
        private decimal anomod;
        [XmlElement(ElementName = "ANOMOD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Anomod
        {
            get { return  anomod; }
            set {  anomod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHASSI
        /// Coment�rio: Chassi do Ve�culo
        /// </summary>
        private string chassi;
        [XmlElement(ElementName = "CHASSI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,17)]
        public string Chassi
        {
            get { return  chassi; }
            set {  chassi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CILINDRADAS
        /// Coment�rio: Cilindradas do Motor
        /// </summary>
        private string cilindradas;
        [XmlElement(ElementName = "CILINDRADAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Cilindradas
        {
            get { return  cilindradas; }
            set {  cilindradas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CMT
        /// Coment�rio: Capacidade Maxima de Tra��o
        /// </summary>
        private decimal cmt;
        [XmlElement(ElementName = "CMT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Cmt
        {
            get { return  cmt; }
            set {  cmt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCOR
        /// Coment�rio: C�digo da Cor
        /// </summary>
        private decimal codcor;
        [XmlElement(ElementName = "CODCOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codcor
        {
            get { return  codcor; }
            set {  codcor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCORDENATRAM
        /// Coment�rio: C�digo cor Denatram
        /// </summary>
        private decimal codcordenatram;
        [XmlElement(ElementName = "CODCORDENATRAM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codcordenatram
        {
            get { return  codcordenatram; }
            set {  codcordenatram = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMODELO
        /// Coment�rio: C�digo Marca Modelo
        /// </summary>
        private string codmodelo;
        [XmlElement(ElementName = "CODMODELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Codmodelo
        {
            get { return  codmodelo; }
            set {  codmodelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto
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
        /// Propriedade referente ao campo: CONDVEICULO
        /// Coment�rio: Condi��o Ve�culo
        /// </summary>
        private string condveiculo;
        [XmlElement(ElementName = "CONDVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Condveiculo
        {
            get { return  condveiculo; }
            set {  condveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCCOR
        /// Coment�rio: Descri��o da Cor
        /// </summary>
        private string desccor;
        [XmlElement(ElementName = "DESCCOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Desccor
        {
            get { return  desccor; }
            set {  desccor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISTANCIAEIXO
        /// Coment�rio: Dist�ncia entre eixos
        /// </summary>
        private decimal distanciaeixo;
        [XmlElement(ElementName = "DISTANCIAEIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Distanciaeixo
        {
            get { return  distanciaeixo; }
            set {  distanciaeixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIEVEICULO
        /// Coment�rio: Esp�cie ve�culo
        /// </summary>
        private string especieveiculo;
        [XmlElement(ElementName = "ESPECIEVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Especieveiculo
        {
            get { return  especieveiculo; }
            set {  especieveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOTACAO
        /// Coment�rio: Lota��o
        /// </summary>
        private decimal lotacao;
        [XmlElement(ElementName = "LOTACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Lotacao
        {
            get { return  lotacao; }
            set {  lotacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMOTOR
        /// Coment�rio: N�mero do Motor
        /// </summary>
        private string nummotor;
        [XmlElement(ElementName = "NUMMOTOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,21)]
        public string Nummotor
        {
            get { return  nummotor; }
            set {  nummotor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPED
        /// Coment�rio: N�mero do pedido
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
        /// Coment�rio: N�mero da sequencia do produto
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
        /// Propriedade referente ao campo: PESOBRUTO
        /// Coment�rio: Peso Bruto
        /// </summary>
        private decimal pesobruto;
        [XmlElement(ElementName = "PESOBRUTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesobruto
        {
            get { return  pesobruto; }
            set {  pesobruto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOLIQUIDO
        /// Coment�rio: Peso Liquido
        /// </summary>
        private decimal pesoliquido;
        [XmlElement(ElementName = "PESOLIQUIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Pesoliquido
        {
            get { return  pesoliquido; }
            set {  pesoliquido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POTMOTOR
        /// Coment�rio: Pot�ncia Motor
        /// </summary>
        private string potmotor;
        [XmlElement(ElementName = "POTMOTOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Potmotor
        {
            get { return  potmotor; }
            set {  potmotor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Coment�rio: S�rie
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPCOMBUSTIVEL
        /// Coment�rio: Tipo de Comnust�vel
        /// </summary>
        private string tpcombustivel;
        [XmlElement(ElementName = "TPCOMBUSTIVEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tpcombustivel
        {
            get { return  tpcombustivel; }
            set {  tpcombustivel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPOPERACAO
        /// Coment�rio: Tipo da Opera��o
        /// </summary>
        private decimal tpoperacao;
        [XmlElement(ElementName = "TPOPERACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tpoperacao
        {
            get { return  tpoperacao; }
            set {  tpoperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPPINTURA
        /// Coment�rio: Tipo de Pintura
        /// </summary>
        private decimal tppintura;
        [XmlElement(ElementName = "TPPINTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tppintura
        {
            get { return  tppintura; }
            set {  tppintura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPRESTRICAO
        /// Coment�rio: Tipo de restri��o
        /// </summary>
        private decimal tprestricao;
        [XmlElement(ElementName = "TPRESTRICAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tprestricao
        {
            get { return  tprestricao; }
            set {  tprestricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TPVEICULO
        /// Coment�rio: Tipo de ve�culo
        /// </summary>
        private string tpveiculo;
        [XmlElement(ElementName = "TPVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tpveiculo
        {
            get { return  tpveiculo; }
            set {  tpveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VIN
        /// Coment�rio: VIN(chassi) remarcado
        /// </summary>
        private string vin;
        [XmlElement(ElementName = "VIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vin
        {
            get { return  vin; }
            set {  vin = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCPedidadosveiculos()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPEDIDADOSVEICULOS";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCPedidadosveiculos> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPedidadosveiculos>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCPedidadosveiculos> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPedidadosveiculos>(where);
        }

        #endregion
    }
}
