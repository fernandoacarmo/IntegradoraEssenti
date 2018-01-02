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
    /// Classe referente a tabela PCListapresentec
    /// </summary>
    [XmlType("PCLISTAPRESENTEC")]
    public class PCListapresentec : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACEITAQTACIMAINFORMADA
        /// Coment�rio: Permite que seja vendido quandidade dos itens acima da quantidade informada pelo dono da lista
        /// </summary>
        private string aceitaqtacimainformada;
        [XmlElement(ElementName = "ACEITAQTACIMAINFORMADA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Aceitaqtacimainformada
        {
            get { return  aceitaqtacimainformada; }
            set {  aceitaqtacimainformada = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRROTITULAR
        /// Coment�rio: Bairro do Titular
        /// </summary>
        private string bairrotitular;
        [XmlElement(ElementName = "BAIRROTITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Bairrotitular
        {
            get { return  bairrotitular; }
            set {  bairrotitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CELULARTITULAR
        /// Coment�rio: Celular do Titular da Lista
        /// </summary>
        private string celulartitular;
        [XmlElement(ElementName = "CELULARTITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Celulartitular
        {
            get { return  celulartitular; }
            set {  celulartitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEPTITULAR
        /// Coment�rio: CEP do Titular da Lista
        /// </summary>
        private string ceptitular;
        [XmlElement(ElementName = "CEPTITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public string Ceptitular
        {
            get { return  ceptitular; }
            set {  ceptitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADEEVENTO
        /// Coment�rio: Cidade do Evento
        /// </summary>
        private string cidadeevento;
        [XmlElement(ElementName = "CIDADEEVENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Cidadeevento
        {
            get { return  cidadeevento; }
            set {  cidadeevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADETITULAR
        /// Coment�rio: Cidade do Titular da Lista
        /// </summary>
        private string cidadetitular;
        [XmlElement(ElementName = "CIDADETITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Cidadetitular
        {
            get { return  cidadetitular; }
            set {  cidadetitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: Codigo do Cliente Cadastrado
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
        /// Propriedade referente ao campo: CODCREDITO
        /// Coment�rio: Codigo do Cr�dito Gerado na PCCRECLI
        /// </summary>
        private decimal codcredito;
        [XmlElement(ElementName = "CODCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcredito
        {
            get { return  codcredito; }
            set {  codcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCADASTRO
        /// Coment�rio: Codigo do Funcion�rio que Cadastrou a Lista
        /// </summary>
        private decimal codfunccadastro;
        [XmlElement(ElementName = "CODFUNCCADASTRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfunccadastro
        {
            get { return  codfunccadastro; }
            set {  codfunccadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCINATIVACAO
        /// Coment�rio: Codigo do Funcion�rio que Inativou a Lista
        /// </summary>
        private decimal codfuncinativacao;
        [XmlElement(ElementName = "CODFUNCINATIVACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfuncinativacao
        {
            get { return  codfuncinativacao; }
            set {  codfuncinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLETITULAR
        /// Coment�rio: Complemento do Endere�o do Titular da Lista
        /// </summary>
        private string completitular;
        [XmlElement(ElementName = "COMPLETITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Completitular
        {
            get { return  completitular; }
            set {  completitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPFTITULAR
        /// Coment�rio: CPF do titular da Lista
        /// </summary>
        private string cpftitular;
        [XmlElement(ElementName = "CPFTITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,11)]
        public string Cpftitular
        {
            get { return  cpftitular; }
            set {  cpftitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAEVENTO
        /// Coment�rio: Data do evento
        /// </summary>
        private DateTime? dataevento;
        [XmlElement(ElementName = "DATAEVENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataevento
        {
            get { return  dataevento; }
            set {  dataevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Coment�rio: Data do Cadastro da Lista
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFECHAMENTO
        /// Coment�rio: Data do Encerramento da Lista
        /// </summary>
        private DateTime? dtfechamento;
        [XmlElement(ElementName = "DTFECHAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfechamento
        {
            get { return  dtfechamento; }
            set {  dtfechamento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINATIVACAO
        /// Coment�rio: Data de Inativa��o da Lista
        /// </summary>
        private DateTime? dtinativacao;
        [XmlElement(ElementName = "DTINATIVACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinativacao
        {
            get { return  dtinativacao; }
            set {  dtinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADE
        /// Coment�rio: Data de Validade da Lista
        /// </summary>
        private DateTime? dtvalidade;
        [XmlElement(ElementName = "DTVALIDADE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidade
        {
            get { return  dtvalidade; }
            set {  dtvalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILCOMPLE
        /// Coment�rio: EMAIL do 2� Titular da Lista
        /// </summary>
        private string emailcomple;
        [XmlElement(ElementName = "EMAILCOMPLE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Emailcomple
        {
            get { return  emailcomple; }
            set {  emailcomple = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAILTITULAR
        /// Coment�rio: Email do titular da lista
        /// </summary>
        private string emailtitular;
        [XmlElement(ElementName = "EMAILTITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Emailtitular
        {
            get { return  emailtitular; }
            set {  emailtitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENDERECOTITULAR
        /// Coment�rio: Endere�o do Titular da Lista
        /// </summary>
        private string enderecotitular;
        [XmlElement(ElementName = "ENDERECOTITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Enderecotitular
        {
            get { return  enderecotitular; }
            set {  enderecotitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LOCALEVENTO
        /// Coment�rio: Local do evento
        /// </summary>
        private string localevento;
        [XmlElement(ElementName = "LOCALEVENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Localevento
        {
            get { return  localevento; }
            set {  localevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM
        /// Coment�rio: Mensagem para o Titular da Lista
        /// </summary>
        private string mensagem;
        [XmlElement(ElementName = "MENSAGEM", DataType = "CLOB", IsNullable = true)]
        [DataObjectField(false,false,true,0)]
        public string Mensagem
        {
            get { return  mensagem; }
            set {  mensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOINATIVACAO
        /// Coment�rio: Motivo da Inativa��o da Lista
        /// </summary>
        private string motivoinativacao;
        [XmlElement(ElementName = "MOTIVOINATIVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4000)]
        public string Motivoinativacao
        {
            get { return  motivoinativacao; }
            set {  motivoinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMECOMPLE
        /// Coment�rio: Nome do 2� Titular da Lista
        /// </summary>
        private string nomecomple;
        [XmlElement(ElementName = "NOMECOMPLE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomecomple
        {
            get { return  nomecomple; }
            set {  nomecomple = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEMAECOMPLE
        /// Coment�rio: Nome da M�e do 2� Titular da Lista
        /// </summary>
        private string nomemaecomple;
        [XmlElement(ElementName = "NOMEMAECOMPLE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomemaecomple
        {
            get { return  nomemaecomple; }
            set {  nomemaecomple = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEMAETITULAR
        /// Coment�rio: Nome da M�e do Titular da Lista
        /// </summary>
        private string nomemaetitular;
        [XmlElement(ElementName = "NOMEMAETITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomemaetitular
        {
            get { return  nomemaetitular; }
            set {  nomemaetitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPAICOMPLE
        /// Coment�rio: Nome do Pai do 2� Titular da Lista
        /// </summary>
        private string nomepaicomple;
        [XmlElement(ElementName = "NOMEPAICOMPLE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomepaicomple
        {
            get { return  nomepaicomple; }
            set {  nomepaicomple = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPAITITULAR
        /// Coment�rio: Nome do Pai do Titular da Lista
        /// </summary>
        private string nomepaititular;
        [XmlElement(ElementName = "NOMEPAITITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomepaititular
        {
            get { return  nomepaititular; }
            set {  nomepaititular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMETITULAR
        /// Coment�rio: Nome do 1� titular da Lista
        /// </summary>
        private string nometitular;
        [XmlElement(ElementName = "NOMETITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nometitular
        {
            get { return  nometitular; }
            set {  nometitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMEROTITULAR
        /// Coment�rio: N�mero do Endere�o do Titular da Lista
        /// </summary>
        private string numerotitular;
        [XmlElement(ElementName = "NUMEROTITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numerotitular
        {
            get { return  numerotitular; }
            set {  numerotitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMLISTA
        /// Coment�rio: N�mero de Identifica��o da Lista
        /// </summary>
        private decimal numlista;
        [XmlElement(ElementName = "NUMLISTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numlista
        {
            get { return  numlista; }
            set {  numlista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOBRENOMECOMPLE
        /// Coment�rio: Sobrenome do 2� Titular da Lista
        /// </summary>
        private string sobrenomecomple;
        [XmlElement(ElementName = "SOBRENOMECOMPLE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Sobrenomecomple
        {
            get { return  sobrenomecomple; }
            set {  sobrenomecomple = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SOBRENOMETITULAR
        /// Coment�rio: Sobrenome do titular da lista
        /// </summary>
        private string sobrenometitular;
        [XmlElement(ElementName = "SOBRENOMETITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Sobrenometitular
        {
            get { return  sobrenometitular; }
            set {  sobrenometitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Coment�rio: Situa��o da Lista (Ativa ou Inativa)
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONETITULAR
        /// Coment�rio: Telefone do Titular da Lista
        /// </summary>
        private string telefonetitular;
        [XmlElement(ElementName = "TELEFONETITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Telefonetitular
        {
            get { return  telefonetitular; }
            set {  telefonetitular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOEVENTO
        /// Coment�rio: Tipo do Evento
        /// </summary>
        private string tipoevento;
        [XmlElement(ElementName = "TIPOEVENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipoevento
        {
            get { return  tipoevento; }
            set {  tipoevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFEVENTO
        /// Coment�rio: UF do evento
        /// </summary>
        private string ufevento;
        [XmlElement(ElementName = "UFEVENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufevento
        {
            get { return  ufevento; }
            set {  ufevento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFTITULAR
        /// Coment�rio: UF do Titular da Lista
        /// </summary>
        private string uftitular;
        [XmlElement(ElementName = "UFTITULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Uftitular
        {
            get { return  uftitular; }
            set {  uftitular = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCListapresentec()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLISTAPRESENTEC";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCListapresentec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCListapresentec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCListapresentec> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCListapresentec>(where);
        }

        #endregion
    }
}
