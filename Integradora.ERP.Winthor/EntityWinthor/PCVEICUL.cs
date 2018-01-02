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
    /// Classe referente a tabela PCVeicul
    /// </summary>
    [XmlType("PCVEICUL")]
    public class PCVeicul : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALTURA
        /// Comentário: 
        /// </summary>
        private decimal altura;
        [XmlElement(ElementName = "ALTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Altura
        {
            get { return  altura; }
            set {  altura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ANTT
        /// Comentário: Agência nacional de transporte terrestres.
        /// </summary>
        private string antt;
        [XmlElement(ElementName = "ANTT", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Antt
        {
            get { return  antt; }
            set {  antt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCPFPROPRIETARIO
        /// Comentário: Indica o número do CNPJ/CPF do proprietário.
        /// </summary>
        private string cgccpfproprietario;
        [XmlElement(ElementName = "CGCCPFPROPRIETARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cgccpfproprietario
        {
            get { return  cgccpfproprietario; }
            set {  cgccpfproprietario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHASSI
        /// Comentário: Código do Chassi do veículo. 
        /// </summary>
        private string chassi;
        [XmlElement(ElementName = "CHASSI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Chassi
        {
            get { return  chassi; }
            set {  chassi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADEPLACAVEICULO
        /// Comentário: Cidade da placa do veículo.
        /// </summary>
        private string cidadeplacaveiculo;
        [XmlElement(ElementName = "CIDADEPLACAVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cidadeplacaveiculo
        {
            get { return  cidadeplacaveiculo; }
            set {  cidadeplacaveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Comentário: Cód. da transportadora vinculada ao veículo.
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
        /// Propriedade referente ao campo: CODFUNCALTSIT
        /// Comentário: 
        /// </summary>
        private decimal codfuncaltsit;
        [XmlElement(ElementName = "CODFUNCALTSIT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncaltsit
        {
            get { return  codfuncaltsit; }
            set {  codfuncaltsit = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGORNTRC
        /// Comentário: Registro Nacional de Transp.
        /// </summary>
        private string codigorntrc;
        [XmlElement(ElementName = "CODIGORNTRC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Codigorntrc
        {
            get { return  codigorntrc; }
            set {  codigorntrc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLOCALIZACAO
        /// Comentário: Indica a localização do veículo, que poderá ser alterado no cadastro, no registro de saída ou entrada de veículos. 
        /// </summary>
        private decimal codlocalizacao;
        [XmlElement(ElementName = "CODLOCALIZACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codlocalizacao
        {
            get { return  codlocalizacao; }
            set {  codlocalizacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTAPRINC
        /// Comentário: Indica o código da rota principal.
        /// </summary>
        private decimal codrotaprinc;
        [XmlElement(ElementName = "CODROTAPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrotaprinc
        {
            get { return  codrotaprinc; }
            set {  codrotaprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOVEICULO
        /// Comentário: Código do tipo de veiculo para Custo de Transporte
        /// </summary>
        private decimal codtipoveiculo;
        [XmlElement(ElementName = "CODTIPOVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Codtipoveiculo
        {
            get { return  codtipoveiculo; }
            set {  codtipoveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Comentário: 
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPRIMENTO
        /// Comentário: 
        /// </summary>
        private decimal comprimento;
        [XmlElement(ElementName = "COMPRIMENTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Comprimento
        {
            get { return  comprimento; }
            set {  comprimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COR
        /// Comentário: Descrição da Cor do veículo. 
        /// </summary>
        private string cor;
        [XmlElement(ElementName = "COR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cor
        {
            get { return  cor; }
            set {  cor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IEPROPRIETARIO
        /// Comentário: Inscrição Estadual do proprietario
        /// </summary>
        private string ieproprietario;
        [XmlElement(ElementName = "IEPROPRIETARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Ieproprietario
        {
            get { return  ieproprietario; }
            set {  ieproprietario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMATUAL
        /// Comentário: Quilometragem atual do veículo. 
        /// </summary>
        private decimal kmatual;
        [XmlElement(ElementName = "KMATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Kmatual
        {
            get { return  kmatual; }
            set {  kmatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: KMINICIAL
        /// Comentário: Quilometragem do veículo no momento da sua compra. Usado para ter noção da quantidade de quilômetros já rodados. 
        /// </summary>
        private decimal kminicial;
        [XmlElement(ElementName = "KMINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Kminicial
        {
            get { return  kminicial; }
            set {  kminicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LARGURA
        /// Comentário: 
        /// </summary>
        private decimal largura;
        [XmlElement(ElementName = "LARGURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Largura
        {
            get { return  largura; }
            set {  largura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARCA
        /// Comentário: 
        /// </summary>
        private string marca;
        [XmlElement(ElementName = "MARCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Marca
        {
            get { return  marca; }
            set {  marca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEDIAKM
        /// Comentário: Valor médio de quilômetros rodados pelo veículo. 
        /// </summary>
        private decimal mediakm;
        [XmlElement(ElementName = "MEDIAKM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Mediakm
        {
            get { return  mediakm; }
            set {  mediakm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPROPRIETARIO
        /// Comentário: Indica nome/razão social do proprietário.
        /// </summary>
        private string nomeproprietario;
        [XmlElement(ElementName = "NOMEPROPRIETARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Nomeproprietario
        {
            get { return  nomeproprietario; }
            set {  nomeproprietario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: Espaço para informar observações diversas sobre o veículo. 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,120)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOCARGAKG
        /// Comentário: 
        /// </summary>
        private decimal pesocargakg;
        [XmlElement(ElementName = "PESOCARGAKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pesocargakg
        {
            get { return  pesocargakg; }
            set {  pesocargakg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PESOCARGAKG2
        /// Comentário: 
        /// </summary>
        private decimal pesocargakg2;
        [XmlElement(ElementName = "PESOCARGAKG2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Pesocargakg2
        {
            get { return  pesocargakg2; }
            set {  pesocargakg2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PLACA
        /// Comentário: 
        /// </summary>
        private string placa;
        [XmlElement(ElementName = "PLACA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Placa
        {
            get { return  placa; }
            set {  placa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRIORIDADE
        /// Comentário: Indica prioridade de utilização.
        /// </summary>
        private decimal prioridade;
        [XmlElement(ElementName = "PRIORIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Prioridade
        {
            get { return  prioridade; }
            set {  prioridade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROPRIO
        /// Comentário: 
        /// </summary>
        private string proprio;
        [XmlElement(ElementName = "PROPRIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Proprio
        {
            get { return  proprio; }
            set {  proprio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTEIXOS
        /// Comentário: Quantidade de eixos existentes no veículo. 
        /// </summary>
        private decimal qteixos;
        [XmlElement(ElementName = "QTEIXOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qteixos
        {
            get { return  qteixos; }
            set {  qteixos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTLITROS
        /// Comentário: Capacidade de litros do tanque de combustível do veículo. 
        /// </summary>
        private decimal qtlitros;
        [XmlElement(ElementName = "QTLITROS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtlitros
        {
            get { return  qtlitros; }
            set {  qtlitros = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPALETE
        /// Comentário: 
        /// </summary>
        private decimal qtpalete;
        [XmlElement(ElementName = "QTPALETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtpalete
        {
            get { return  qtpalete; }
            set {  qtpalete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTRODAS
        /// Comentário: Quantidade de rodas do veículo. 
        /// </summary>
        private decimal qtrodas;
        [XmlElement(ElementName = "QTRODAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qtrodas
        {
            get { return  qtrodas; }
            set {  qtrodas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTTANQUES
        /// Comentário: Quantidade de tanques de combustível no veículo. 
        /// </summary>
        private decimal qttanques;
        [XmlElement(ElementName = "QTTANQUES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Qttanques
        {
            get { return  qttanques; }
            set {  qttanques = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RASTREADO
        /// Comentário: Campo (S ou N), para indicar se a rota possui rastreamento, caso esteja marcada (S), na montagem de carga ou faturamento
        /// </summary>
        private string rastreado;
        [XmlElement(ElementName = "RASTREADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Rastreado
        {
            get { return  rastreado; }
            set {  rastreado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RENAVAM
        /// Comentário: Renavam do veiculo
        /// </summary>
        private string renavam;
        [XmlElement(ElementName = "RENAVAM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public string Renavam
        {
            get { return  renavam; }
            set {  renavam = value; }
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
        /// Propriedade referente ao campo: TIPOCARROCERIA
        /// Comentário: Tipo da carroceria
        /// </summary>
        private string tipocarroceria;
        [XmlElement(ElementName = "TIPOCARROCERIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipocarroceria
        {
            get { return  tipocarroceria; }
            set {  tipocarroceria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPROPRIETARIO
        /// Comentário: Tipo do proprietario
        /// </summary>
        private decimal tipoproprietario;
        [XmlElement(ElementName = "TIPOPROPRIETARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Tipoproprietario
        {
            get { return  tipoproprietario; }
            set {  tipoproprietario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORODADO
        /// Comentário: Tipo de rodado
        /// </summary>
        private string tiporodado;
        [XmlElement(ElementName = "TIPORODADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tiporodado
        {
            get { return  tiporodado; }
            set {  tiporodado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVEICUEDI
        /// Comentário: Tipo de veiculo (EDI Fiscal)
        /// </summary>
        private decimal tipoveicuedi;
        [XmlElement(ElementName = "TIPOVEICUEDI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Tipoveicuedi
        {
            get { return  tipoveicuedi; }
            set {  tipoveicuedi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVEICULO
        /// Comentário: Tipo veiculo
        /// </summary>
        private string tipoveiculo;
        [XmlElement(ElementName = "TIPOVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoveiculo
        {
            get { return  tipoveiculo; }
            set {  tipoveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVEICULO2
        /// Comentário: Tipo veiculo
        /// </summary>
        private string tipoveiculo2;
        [XmlElement(ElementName = "TIPOVEICULO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoveiculo2
        {
            get { return  tipoveiculo2; }
            set {  tipoveiculo2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFPLACAVEICULO
        /// Comentário: UF da placa do veículo.
        /// </summary>
        private string ufplacaveiculo;
        [XmlElement(ElementName = "UFPLACAVEICULO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufplacaveiculo
        {
            get { return  ufplacaveiculo; }
            set {  ufplacaveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFPROPRIETARIO
        /// Comentário: UF do proprietario
        /// </summary>
        private string ufproprietario;
        [XmlElement(ElementName = "UFPROPRIETARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufproprietario
        {
            get { return  ufproprietario; }
            set {  ufproprietario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ULTVIAGEM
        /// Comentário: Número do Carregamento da última viagem feita pelo veículo. 
        /// </summary>
        private decimal ultviagem;
        [XmlElement(ElementName = "ULTVIAGEM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ultviagem
        {
            get { return  ultviagem; }
            set {  ultviagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORKG
        /// Comentário: Valor pago por kilo de produto.
        /// </summary>
        private decimal valorkg;
        [XmlElement(ElementName = "VALORKG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Valorkg
        {
            get { return  valorkg; }
            set {  valorkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORKMRODADO
        /// Comentário: 
        /// </summary>
        private decimal valorkmrodado;
        [XmlElement(ElementName = "VALORKMRODADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valorkmrodado
        {
            get { return  valorkmrodado; }
            set {  valorkmrodado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLDIARIA
        /// Comentário: 
        /// </summary>
        private decimal vldiaria;
        [XmlElement(ElementName = "VLDIARIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vldiaria
        {
            get { return  vldiaria; }
            set {  vldiaria = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFIXO
        /// Comentário: Vl. fixo de entrega.
        /// </summary>
        private decimal vlfixo;
        [XmlElement(ElementName = "VLFIXO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlfixo
        {
            get { return  vlfixo; }
            set {  vlfixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPED
        /// Comentário: Vl. de entrega por pedido.
        /// </summary>
        private decimal vlped;
        [XmlElement(ElementName = "VLPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlped
        {
            get { return  vlped; }
            set {  vlped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VOLUME
        /// Comentário: 
        /// </summary>
        private decimal volume;
        [XmlElement(ElementName = "VOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
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
        public PCVeicul()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCVEICUL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCVeicul> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCVeicul>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCVeicul> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCVeicul>(where);
        }

        #endregion
    }
}
