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
        /// Comentário: Permite que seja vendido quandidade dos itens acima da quantidade informada pelo dono da lista
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
        /// Comentário: Bairro do Titular
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
        /// Comentário: Celular do Titular da Lista
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
        /// Comentário: CEP do Titular da Lista
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
        /// Comentário: Cidade do Evento
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
        /// Comentário: Cidade do Titular da Lista
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
        /// Comentário: Codigo do Cliente Cadastrado
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
        /// Comentário: Codigo do Crédito Gerado na PCCRECLI
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
        /// Comentário: Codigo do Funcionário que Cadastrou a Lista
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
        /// Comentário: Codigo do Funcionário que Inativou a Lista
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
        /// Comentário: Complemento do Endereço do Titular da Lista
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
        /// Comentário: CPF do titular da Lista
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
        /// Comentário: Data do evento
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
        /// Comentário: Data do Cadastro da Lista
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
        /// Comentário: Data do Encerramento da Lista
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
        /// Comentário: Data de Inativação da Lista
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
        /// Comentário: Data de Validade da Lista
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
        /// Comentário: EMAIL do 2º Titular da Lista
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
        /// Comentário: Email do titular da lista
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
        /// Comentário: Endereço do Titular da Lista
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
        /// Comentário: Local do evento
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
        /// Comentário: Mensagem para o Titular da Lista
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
        /// Comentário: Motivo da Inativação da Lista
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
        /// Comentário: Nome do 2º Titular da Lista
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
        /// Comentário: Nome da Mãe do 2º Titular da Lista
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
        /// Comentário: Nome da Mãe do Titular da Lista
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
        /// Comentário: Nome do Pai do 2º Titular da Lista
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
        /// Comentário: Nome do Pai do Titular da Lista
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
        /// Comentário: Nome do 1º titular da Lista
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
        /// Comentário: Número do Endereço do Titular da Lista
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
        /// Comentário: Número de Identificação da Lista
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
        /// Comentário: Sobrenome do 2º Titular da Lista
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
        /// Comentário: Sobrenome do titular da lista
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
        /// Comentário: Situação da Lista (Ativa ou Inativa)
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
        /// Comentário: Telefone do Titular da Lista
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
        /// Comentário: Tipo do Evento
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
        /// Comentário: UF do evento
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
        /// Comentário: UF do Titular da Lista
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

        #region Métodos
        /// <summary>
        /// Método create
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
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCListapresentec> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCListapresentec>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
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
