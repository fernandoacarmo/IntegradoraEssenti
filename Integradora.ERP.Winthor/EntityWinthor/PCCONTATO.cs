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
    /// Classe referente a tabela PCContato
    /// </summary>
    [XmlType("PCCONTATO")]
    public class PCContato : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AGENCIA
        /// Coment�rio: Ag�ncia
        /// </summary>
        private string agencia;
        [XmlElement(ElementName = "AGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Agencia
        {
            get { return  agencia; }
            set {  agencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTORCH
        /// Coment�rio: 
        /// </summary>
        private string autorch;
        [XmlElement(ElementName = "AUTORCH", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Autorch
        {
            get { return  autorch; }
            set {  autorch = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTORIZADO
        /// Coment�rio: Contato autorizado
        /// </summary>
        private string autorizado;
        [XmlElement(ElementName = "AUTORIZADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autorizado
        {
            get { return  autorizado; }
            set {  autorizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Coment�rio: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CARGO
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: CELULAR
        /// Coment�rio: 
        /// </summary>
        private string celular;
        [XmlElement(ElementName = "CELULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Celular
        {
            get { return  celular; }
            set {  celular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Coment�rio: 
        /// </summary>
        private string cep;
        [XmlElement(ElementName = "CEP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCPF
        /// Coment�rio: 
        /// </summary>
        private string cgccpf;
        [XmlElement(ElementName = "CGCCPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Cgccpf
        {
            get { return  cgccpf; }
            set {  cgccpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CGCCPFAUX
        /// Coment�rio: Indica CNPJ/CPF sem mascara.
        /// </summary>
        private string cgccpfaux;
        [XmlElement(ElementName = "CGCCPFAUX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Cgccpfaux
        {
            get { return  cgccpfaux; }
            set {  cgccpfaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Coment�rio: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cidade
        {
            get { return  cidade; }
            set {  cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBANCO
        /// Coment�rio: C�digo do banco
        /// </summary>
        private decimal codbanco;
        [XmlElement(ElementName = "CODBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codbanco
        {
            get { return  codbanco; }
            set {  codbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTATO
        /// Coment�rio: 
        /// </summary>
        private decimal codcontato;
        [XmlElement(ElementName = "CODCONTATO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcontato
        {
            get { return  codcontato; }
            set {  codcontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCBLOQUEIO
        /// Coment�rio: C�d. funcion�rio de bloqueio
        /// </summary>
        private decimal codfuncbloqueio;
        [XmlElement(ElementName = "CODFUNCBLOQUEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncbloqueio
        {
            get { return  codfuncbloqueio; }
            set {  codfuncbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCDESBLOQUEIO
        /// Coment�rio: C�d. funcion�rio de desbloqueio
        /// </summary>
        private decimal codfuncdesbloqueio;
        [XmlElement(ElementName = "CODFUNCDESBLOQUEIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncdesbloqueio
        {
            get { return  codfuncdesbloqueio; }
            set {  codfuncdesbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTA
        /// Coment�rio: Conta corrente
        /// </summary>
        private string conta;
        [XmlElement(ElementName = "CONTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Conta
        {
            get { return  conta; }
            set {  conta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DEPTO
        /// Coment�rio: 
        /// </summary>
        private string depto;
        [XmlElement(ElementName = "DEPTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Depto
        {
            get { return  depto; }
            set {  depto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DOC
        /// Coment�rio: 
        /// </summary>
        private string doc;
        [XmlElement(ElementName = "DOC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Doc
        {
            get { return  doc; }
            set {  doc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTBLOQUEIO
        /// Coment�rio: Data de bloqueio
        /// </summary>
        private DateTime? dtbloqueio;
        [XmlElement(ElementName = "DTBLOQUEIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtbloqueio
        {
            get { return  dtbloqueio; }
            set {  dtbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDESBLOQUEIO
        /// Coment�rio: Data de desbloqueio
        /// </summary>
        private DateTime? dtdesbloqueio;
        [XmlElement(ElementName = "DTDESBLOQUEIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdesbloqueio
        {
            get { return  dtdesbloqueio; }
            set {  dtdesbloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNASCCONJUGE
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtnascconjuge;
        [XmlElement(ElementName = "DTNASCCONJUGE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnascconjuge
        {
            get { return  dtnascconjuge; }
            set {  dtnascconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNASCIMENTO
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtnascimento;
        [XmlElement(ElementName = "DTNASCIMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnascimento
        {
            get { return  dtnascimento; }
            set {  dtnascimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTSOCIEDADE
        /// Coment�rio: Data de entrada do socio no contrato social.
        /// </summary>
        private DateTime? dtsociedade;
        [XmlElement(ElementName = "DTSOCIEDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtsociedade
        {
            get { return  dtsociedade; }
            set {  dtsociedade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Coment�rio: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECO
        /// Coment�rio: 
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Coment�rio: 
        /// </summary>
        private string estado;
        [XmlElement(ElementName = "ESTADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Estado
        {
            get { return  estado; }
            set {  estado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOBBIE
        /// Coment�rio: 
        /// </summary>
        private string hobbie;
        [XmlElement(ElementName = "HOBBIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Hobbie
        {
            get { return  hobbie; }
            set {  hobbie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVONAOAUTORIZADO
        /// Coment�rio: Motivo de n�o ser autorizado
        /// </summary>
        private string motivonaoautorizado;
        [XmlElement(ElementName = "MOTIVONAOAUTORIZADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Motivonaoautorizado
        {
            get { return  motivonaoautorizado; }
            set {  motivonaoautorizado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECONJUGE
        /// Coment�rio: 
        /// </summary>
        private string nomeconjuge;
        [XmlElement(ElementName = "NOMECONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomeconjuge
        {
            get { return  nomeconjuge; }
            set {  nomeconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECONTATO
        /// Coment�rio: 
        /// </summary>
        private string nomecontato;
        [XmlElement(ElementName = "NOMECONTATO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nomecontato
        {
            get { return  nomecontato; }
            set {  nomecontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: Indica a observa��o do contrato.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PARTICIPSOCIO
        /// Coment�rio: 
        /// </summary>
        private decimal participsocio;
        [XmlElement(ElementName = "PARTICIPSOCIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Participsocio
        {
            get { return  participsocio; }
            set {  participsocio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RG
        /// Coment�rio: Registro geral para contato procurador.
        /// </summary>
        private string rg;
        [XmlElement(ElementName = "RG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rg
        {
            get { return  rg; }
            set {  rg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE
        /// Coment�rio: 
        /// </summary>
        private string telefone;
        [XmlElement(ElementName = "TELEFONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public string Telefone
        {
            get { return  telefone; }
            set {  telefone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIME
        /// Coment�rio: 
        /// </summary>
        private string time;
        [XmlElement(ElementName = "TIME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Time
        {
            get { return  time; }
            set {  time = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCONTATO
        /// Coment�rio: 
        /// </summary>
        private string tipocontato;
        [XmlElement(ElementName = "TIPOCONTATO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Tipocontato
        {
            get { return  tipocontato; }
            set {  tipocontato = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: WAGEMAIL2
        /// Coment�rio: Email|Campo de e-mail secund�rio, especifico para rotinas do Call Center PC Sistemas, cadastrada pela PCWAG9801.Campo string com 80 caracteres.
        /// </summary>
        private string wagemail2;
        [XmlElement(ElementName = "WAGEMAIL2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Wagemail2
        {
            get { return  wagemail2; }
            set {  wagemail2 = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCContato()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONTATO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCContato> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCContato>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCContato> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCContato>(where);
        }

        #endregion
    }
}
