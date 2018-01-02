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
    /// Classe referente a tabela PCManif
    /// </summary>
    [XmlType("PCMANIF")]
    public class PCManif : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CARGO
        /// Coment�rio: Cargo do contato na empresa do cliente.
        /// </summary>
        private string cargo;
        [XmlElement(ElementName = "CARGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cargo
        {
            get { return  cargo; }
            set {  cargo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODASSUNTO
        /// Coment�rio: C�digo do assunto (criado na rotina 1904) que a manifesta��o pertence.
        /// </summary>
        private decimal codassunto;
        [XmlElement(ElementName = "CODASSUNTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codassunto
        {
            get { return  codassunto; }
            set {  codassunto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: C�digo do cliente que registrou a manifesta��o.
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da filial para qual a manifesta��o est� sendo registrada.
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
        /// Propriedade referente ao campo: CODFUNCAB
        /// Coment�rio: C�digo do Operador que abriu a manifesta��o.
        /// </summary>
        private decimal codfuncab;
        [XmlElement(ElementName = "CODFUNCAB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncab
        {
            get { return  codfuncab; }
            set {  codfuncab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncco;
        [XmlElement(ElementName = "CODFUNCCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncco
        {
            get { return  codfuncco; }
            set {  codfuncco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCP
        /// Coment�rio: 
        /// </summary>
        private decimal codfunccp;
        [XmlElement(ElementName = "CODFUNCCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfunccp
        {
            get { return  codfunccp; }
            set {  codfunccp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDESTINATARIO
        /// Coment�rio: C�digo Destinat�rio.
        /// </summary>
        private decimal codfuncdestinatario;
        [XmlElement(ElementName = "CODFUNCDESTINATARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncdestinatario
        {
            get { return  codfuncdestinatario; }
            set {  codfuncdestinatario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCPR
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncpr;
        [XmlElement(ElementName = "CODFUNCPR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncpr
        {
            get { return  codfuncpr; }
            set {  codfuncpr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRB
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncrb;
        [XmlElement(ElementName = "CODFUNCRB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncrb
        {
            get { return  codfuncrb; }
            set {  codfuncrb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRE
        /// Coment�rio: C�digo do Operador que recebeu a manifesta��o.
        /// </summary>
        private decimal codfuncre;
        [XmlElement(ElementName = "CODFUNCRE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncre
        {
            get { return  codfuncre; }
            set {  codfuncre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCRT
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncrt;
        [XmlElement(ElementName = "CODFUNCRT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncrt
        {
            get { return  codfuncrt; }
            set {  codfuncrt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCSO
        /// Coment�rio: 
        /// </summary>
        private decimal codfuncso;
        [XmlElement(ElementName = "CODFUNCSO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncso
        {
            get { return  codfuncso; }
            set {  codfuncso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMOTORISTA
        /// Coment�rio: C�digo do motorista mencionado na manifesta��o.
        /// </summary>
        private decimal codmotorista;
        [XmlElement(ElementName = "CODMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmotorista
        {
            get { return  codmotorista; }
            set {  codmotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Coment�rio: C�digo do produto mencionado no momento da abertura da manifesta��o (hoje gravado na tabela PCMANIFPROD).Mantido para compatibilidade com vers�es anteriores.
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
        /// Propriedade referente ao campo: CODRCA
        /// Coment�rio: C�digo do vendedor mencionado na abertura da manifesta��o (n�o � obrigat�rio informa esse campo).
        /// </summary>
        private decimal codrca;
        [XmlElement(ElementName = "CODRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrca
        {
            get { return  codrca; }
            set {  codrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORCP
        /// Coment�rio: 
        /// </summary>
        private decimal codsetorcp;
        [XmlElement(ElementName = "CODSETORCP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorcp
        {
            get { return  codsetorcp; }
            set {  codsetorcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORENVIAR
        /// Coment�rio: 
        /// </summary>
        private decimal codsetorenviar;
        [XmlElement(ElementName = "CODSETORENVIAR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorenviar
        {
            get { return  codsetorenviar; }
            set {  codsetorenviar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETORRT
        /// Coment�rio: 
        /// </summary>
        private decimal codsetorrt;
        [XmlElement(ElementName = "CODSETORRT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsetorrt
        {
            get { return  codsetorrt; }
            set {  codsetorrt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTRANSPORTADOR
        /// Coment�rio: C�digo da transportadora mencionado na manifesta��o (n�o � obrigat�rio informa esse campo).
        /// </summary>
        private decimal codtransportador;
        [XmlElement(ElementName = "CODTRANSPORTADOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codtransportador
        {
            get { return  codtransportador; }
            set {  codtransportador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPORTAMENTO
        /// Coment�rio: Comportamento do manifestante no momento do registro da manifesta��o.
        /// </summary>
        private string comportamento;
        [XmlElement(ElementName = "COMPORTAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Comportamento
        {
            get { return  comportamento; }
            set {  comportamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMUNICADO
        /// Coment�rio: 
        /// </summary>
        private string comunicado;
        [XmlElement(ElementName = "COMUNICADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Comunicado
        {
            get { return  comunicado; }
            set {  comunicado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTATO
        /// Coment�rio: Nome do contato no cliente.
        /// </summary>
        private string contato;
        [XmlElement(ElementName = "CONTATO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Contato
        {
            get { return  contato; }
            set {  contato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTAB
        /// Coment�rio: Data de abertura da manifesta��o.
        /// </summary>
        private DateTime? dtab;
        [XmlElement(ElementName = "DTAB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtab
        {
            get { return  dtab; }
            set {  dtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtco;
        [XmlElement(ElementName = "DTCO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtco
        {
            get { return  dtco; }
            set {  dtco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCP
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtcp;
        [XmlElement(ElementName = "DTCP", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcp
        {
            get { return  dtcp; }
            set {  dtcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPIRA
        /// Coment�rio: Data em que a manifesta��o expirou. Os tempos para solu��o de uma manifesta��o s�o informados no cadastro de Assunto de Manifesta��o (rotina 1904).
        /// </summary>
        private DateTime? dtexpira;
        [XmlElement(ElementName = "DTEXPIRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexpira
        {
            get { return  dtexpira; }
            set {  dtexpira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPR
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtpr;
        [XmlElement(ElementName = "DTPR", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtpr
        {
            get { return  dtpr; }
            set {  dtpr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRB
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtrb;
        [XmlElement(ElementName = "DTRB", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtrb
        {
            get { return  dtrb; }
            set {  dtrb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRE
        /// Coment�rio: Data de recebimento da manifesta��o.
        /// </summary>
        private DateTime? dtre;
        [XmlElement(ElementName = "DTRE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtre
        {
            get { return  dtre; }
            set {  dtre = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTRT
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtrt;
        [XmlElement(ElementName = "DTRT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtrt
        {
            get { return  dtrt; }
            set {  dtrt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtso;
        [XmlElement(ElementName = "DTSO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtso
        {
            get { return  dtso; }
            set {  dtso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVENC
        /// Coment�rio: Data de Vencimento.
        /// </summary>
        private DateTime? dtvenc;
        [XmlElement(ElementName = "DTVENC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvenc
        {
            get { return  dtvenc; }
            set {  dtvenc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTERNO
        /// Coment�rio: Manifesta��o Interno.
        /// </summary>
        private string interno;
        [XmlElement(ElementName = "INTERNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Interno
        {
            get { return  interno; }
            set {  interno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MANIFESTACAO
        /// Coment�rio: Texto da manifesta��o.
        /// </summary>
        private string manifestacao;
        [XmlElement(ElementName = "MANIFESTACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Manifestacao
        {
            get { return  manifestacao; }
            set {  manifestacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEIO
        /// Coment�rio: Meio de comunica��o que o cliente usou para registrar a manifesta��o.
        /// </summary>
        private string meio;
        [XmlElement(ElementName = "MEIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Meio
        {
            get { return  meio; }
            set {  meio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEIOSOLUCAO
        /// Coment�rio: Meio de Solu��o.
        /// </summary>
        private string meiosolucao;
        [XmlElement(ElementName = "MEIOSOLUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Meiosolucao
        {
            get { return  meiosolucao; }
            set {  meiosolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMANIF
        /// Coment�rio: N�mero da manifesta��o.
        /// </summary>
        private decimal nummanif;
        [XmlElement(ElementName = "NUMMANIF", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Nummanif
        {
            get { return  nummanif; }
            set {  nummanif = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMMANIFCOPIA
        /// Coment�rio: 
        /// </summary>
        private decimal nummanifcopia;
        [XmlElement(ElementName = "NUMMANIFCOPIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Nummanifcopia
        {
            get { return  nummanifcopia; }
            set {  nummanifcopia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Coment�rio: N�mero da nota que gerou a manifesta��o (n�o � obrigat�rio informa esse campo).
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
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: Numero de sequ�ncia da manifesta��o.
        /// </summary>
        private decimal numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQCOPIA
        /// Coment�rio: 
        /// </summary>
        private decimal numseqcopia;
        [XmlElement(ElementName = "NUMSEQCOPIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numseqcopia
        {
            get { return  numseqcopia; }
            set {  numseqcopia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Coment�rio: Observa��o.
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROVIDENCIA
        /// Coment�rio: Nesse campo � informado a maneira que a manifesta��o dever� ser solucionada.
        /// </summary>
        private string providencia;
        [XmlElement(ElementName = "PROVIDENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Providencia
        {
            get { return  providencia; }
            set {  providencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REABERTA
        /// Coment�rio: 
        /// </summary>
        private string reaberta;
        [XmlElement(ElementName = "REABERTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Reaberta
        {
            get { return  reaberta; }
            set {  reaberta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RECEPTOR
        /// Coment�rio: 
        /// </summary>
        private string receptor;
        [XmlElement(ElementName = "RECEPTOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Receptor
        {
            get { return  receptor; }
            set {  receptor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SATISFEITO
        /// Coment�rio: 
        /// </summary>
        private string satisfeito;
        [XmlElement(ElementName = "SATISFEITO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Satisfeito
        {
            get { return  satisfeito; }
            set {  satisfeito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Situa��o da manifesta��o. Pode variar de acordo com o padr�o de Call Center informado na rotina 132.
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOLUCAO
        /// Coment�rio: Campo para informar a maneira que a manifesta��o foi solucionada.
        /// </summary>
        private string solucao;
        [XmlElement(ElementName = "SOLUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Solucao
        {
            get { return  solucao; }
            set {  solucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Coment�rio: Telefone do contato.
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TEMPODECORRIDO
        /// Coment�rio: 
        /// </summary>
        private decimal tempodecorrido;
        [XmlElement(ElementName = "TEMPODECORRIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Tempodecorrido
        {
            get { return  tempodecorrido; }
            set {  tempodecorrido = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCManif()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMANIF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCManif> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCManif>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCManif> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCManif>(where);
        }

        #endregion
    }
}
