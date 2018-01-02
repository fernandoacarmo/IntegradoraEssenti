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
    /// Classe referente a tabela PCEmpr
    /// </summary>
    [XmlType("PCEMPR")]
    public class PCEmpr : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ADMISSAO
        /// Comentário: 
        /// </summary>
        private DateTime? admissao;
        [XmlElement(ElementName = "ADMISSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Admissao
        {
            get { return  admissao; }
            set {  admissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AREAATUACAO
        /// Comentário: Indica a área de atuação do funciónario.
        /// </summary>
        private string areaatuacao;
        [XmlElement(ElementName = "AREAATUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Areaatuacao
        {
            get { return  areaatuacao; }
            set {  areaatuacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: AUTOCHEQUEBLOQVENDA
        /// Comentário: Autorizar cheque bloqueado venda
        /// </summary>
        private string autochequebloqvenda;
        [XmlElement(ElementName = "AUTOCHEQUEBLOQVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Autochequebloqvenda
        {
            get { return  autochequebloqvenda; }
            set {  autochequebloqvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CATEGORIACNH
        /// Comentário: 
        /// </summary>
        private string categoriacnh;
        [XmlElement(ElementName = "CATEGORIACNH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Categoriacnh
        {
            get { return  categoriacnh; }
            set {  categoriacnh = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CELULAR
        /// Comentário: 
        /// </summary>
        private string celular;
        [XmlElement(ElementName = "CELULAR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Celular
        {
            get { return  celular; }
            set {  celular = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: 
        /// </summary>
        private decimal cep;
        [XmlElement(ElementName = "CEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,9)]
        public decimal Cep
        {
            get { return  cep; }
            set {  cep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CHAPA_RM
        /// Comentário: Número chapa integração RM.
        /// </summary>
        private string chapa_rm;
        [XmlElement(ElementName = "CHAPA_RM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public string Chapa_Rm
        {
            get { return  chapa_rm; }
            set {  chapa_rm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cidade
        {
            get { return  cidade; }
            set {  cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CNH
        /// Comentário: 
        /// </summary>
        private string cnh;
        [XmlElement(ElementName = "CNH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cnh
        {
            get { return  cnh; }
            set {  cnh = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBARRA
        /// Comentário: 
        /// </summary>
        private string codbarra;
        [XmlElement(ElementName = "CODBARRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codbarra
        {
            get { return  codbarra; }
            set {  codbarra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIAPRECO
        /// Comentário: 
        /// </summary>
        private decimal codcategoriapreco;
        [XmlElement(ElementName = "CODCATEGORIAPRECO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Codcategoriapreco
        {
            get { return  codcategoriapreco; }
            set {  codcategoriapreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Comentário: Código da cidade.
        /// </summary>
        private decimal codcidade;
        [XmlElement(ElementName = "CODCIDADE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcidade
        {
            get { return  codcidade; }
            set {  codcidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONFERENTE
        /// Comentário: 
        /// </summary>
        private decimal codconferente;
        [XmlElement(ElementName = "CODCONFERENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codconferente
        {
            get { return  codconferente; }
            set {  codconferente = value; }
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODFUNCAO
        /// Comentário: 
        /// </summary>
        private decimal codfuncao;
        [XmlElement(ElementName = "CODFUNCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codfuncao
        {
            get { return  codfuncao; }
            set {  codfuncao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIDIOMA
        /// Comentário: 
        /// </summary>
        private string codidioma;
        [XmlElement(ElementName = "CODIDIOMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codidioma
        {
            get { return  codidioma; }
            set {  codidioma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOCENTROCUSTO
        /// Comentário: Código do centro de custo
        /// </summary>
        private string codigocentrocusto;
        [XmlElement(ElementName = "CODIGOCENTROCUSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Codigocentrocusto
        {
            get { return  codigocentrocusto; }
            set {  codigocentrocusto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODIGOPERFIL
        /// Comentário: Código do Perfil para WMS. 
        /// </summary>
        private decimal codigoperfil;
        [XmlElement(ElementName = "CODIGOPERFIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Codigoperfil
        {
            get { return  codigoperfil; }
            set {  codigoperfil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPERFIL
        /// Comentário: Código do Perfil
        /// </summary>
        private decimal codperfil;
        [XmlElement(ElementName = "CODPERFIL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codperfil
        {
            get { return  codperfil; }
            set {  codperfil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSETOR
        /// Comentário: 
        /// </summary>
        private decimal codsetor;
        [XmlElement(ElementName = "CODSETOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codsetor
        {
            get { return  codsetor; }
            set {  codsetor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODVEICULO
        /// Comentário: 
        /// </summary>
        private decimal codveiculo;
        [XmlElement(ElementName = "CODVEICULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codveiculo
        {
            get { return  codveiculo; }
            set {  codveiculo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOFIXA
        /// Comentário: Indica o valor de comissão fixa.
        /// </summary>
        private decimal comissaofixa;
        [XmlElement(ElementName = "COMISSAOFIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Comissaofixa
        {
            get { return  comissaofixa; }
            set {  comissaofixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMPLEMENTO
        /// Comentário: 
        /// </summary>
        private string complemento;
        [XmlElement(ElementName = "COMPLEMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Complemento
        {
            get { return  complemento; }
            set {  complemento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONCEDERABATIMENTO
        /// Comentário: Armazena se o funcionário tem permissão para conceder ou não abatimento nas vendas
        /// </summary>
        private string concederabatimento;
        [XmlElement(ElementName = "CONCEDERABATIMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Concederabatimento
        {
            get { return  concederabatimento; }
            set {  concederabatimento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CPF
        /// Comentário: 
        /// </summary>
        private string cpf;
        [XmlElement(ElementName = "CPF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cpf
        {
            get { return  cpf; }
            set {  cpf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CTPS
        /// Comentário: 
        /// </summary>
        private string ctps;
        [XmlElement(ElementName = "CTPS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ctps
        {
            get { return  ctps; }
            set {  ctps = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DDDTEL
        /// Comentário: 
        /// </summary>
        private decimal dddtel;
        [XmlElement(ElementName = "DDDTEL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Dddtel
        {
            get { return  dddtel; }
            set {  dddtel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASCOB
        /// Comentário: Indica o número de dias de atraso título p/ cobrança externa.
        /// </summary>
        private decimal diascob;
        [XmlElement(ElementName = "DIASCOB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Diascob
        {
            get { return  diascob; }
            set {  diascob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTDEMISSAO
        /// Comentário: Data de demissão.
        /// </summary>
        private DateTime? dtdemissao;
        [XmlElement(ElementName = "DTDEMISSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtdemissao
        {
            get { return  dtdemissao; }
            set {  dtdemissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DT_EXCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dt_exclusao;
        [XmlElement(ElementName = "DT_EXCLUSAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dt_Exclusao
        {
            get { return  dt_exclusao; }
            set {  dt_exclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTEXPIRASENHA
        /// Comentário: 
        /// </summary>
        private DateTime? dtexpirasenha;
        [XmlElement(ElementName = "DTEXPIRASENHA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtexpirasenha
        {
            get { return  dtexpirasenha; }
            set {  dtexpirasenha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTFIMLIMCREDCOMPRA
        /// Comentário: 
        /// </summary>
        private DateTime? dtfimlimcredcompra;
        [XmlElement(ElementName = "DTFIMLIMCREDCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtfimlimcredcompra
        {
            get { return  dtfimlimcredcompra; }
            set {  dtfimlimcredcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinicio;
        [XmlElement(ElementName = "DTINICIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinicio
        {
            get { return  dtinicio; }
            set {  dtinicio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINICIOLIMCREDCOMPRA
        /// Comentário: 
        /// </summary>
        private DateTime? dtiniciolimcredcompra;
        [XmlElement(ElementName = "DTINICIOLIMCREDCOMPRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtiniciolimcredcompra
        {
            get { return  dtiniciolimcredcompra; }
            set {  dtiniciolimcredcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTNASC
        /// Comentário: 
        /// </summary>
        private DateTime? dtnasc;
        [XmlElement(ElementName = "DTNASC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnasc
        {
            get { return  dtnasc; }
            set {  dtnasc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTVALIDADECNH
        /// Comentário: 
        /// </summary>
        private DateTime? dtvalidadecnh;
        [XmlElement(ElementName = "DTVALIDADECNH", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtvalidadecnh
        {
            get { return  dtvalidadecnh; }
            set {  dtvalidadecnh = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
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
        /// Comentário: 
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
        /// Propriedade referente ao campo: ENVIAFV
        /// Comentário: 
        /// </summary>
        private string enviafv;
        [XmlElement(ElementName = "ENVIAFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviafv
        {
            get { return  enviafv; }
            set {  enviafv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESTADO
        /// Comentário: 
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
        /// Propriedade referente ao campo: ESTADOCIVIL
        /// Comentário: 
        /// </summary>
        private string estadocivil;
        [XmlElement(ElementName = "ESTADOCIVIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Estadocivil
        {
            get { return  estadocivil; }
            set {  estadocivil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCOMISSAO
        /// Comentário: 
        /// </summary>
        private decimal fatorcomissao;
        [XmlElement(ElementName = "FATORCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Fatorcomissao
        {
            get { return  fatorcomissao; }
            set {  fatorcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIID
        /// Comentário: 
        /// </summary>
        private string fiid;
        [XmlElement(ElementName = "FIID", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Fiid
        {
            get { return  fiid; }
            set {  fiid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FONE
        /// Comentário: 
        /// </summary>
        private string fone;
        [XmlElement(ElementName = "FONE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Fone
        {
            get { return  fone; }
            set {  fone = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FUNCAO
        /// Comentário: 
        /// </summary>
        private string funcao;
        [XmlElement(ElementName = "FUNCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Funcao
        {
            get { return  funcao; }
            set {  funcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERACCCARD
        /// Comentário: 
        /// </summary>
        private string geracccard;
        [XmlElement(ElementName = "GERACCCARD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Geracccard
        {
            get { return  geracccard; }
            set {  geracccard = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOEMAIL
        /// Comentário: 
        /// </summary>
        private string grupoemail;
        [XmlElement(ElementName = "GRUPOEMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Grupoemail
        {
            get { return  grupoemail; }
            set {  grupoemail = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOOS
        /// Comentário: 
        /// </summary>
        private decimal grupoos;
        [XmlElement(ElementName = "GRUPOOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Grupoos
        {
            get { return  grupoos; }
            set {  grupoos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IPRF
        /// Comentário: 
        /// </summary>
        private string iprf;
        [XmlElement(ElementName = "IPRF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public string Iprf
        {
            get { return  iprf; }
            set {  iprf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LIMITEDESCONTO561
        /// Comentário: Indica o limite de desconto.
        /// </summary>
        private decimal limitedesconto561;
        [XmlElement(ElementName = "LIMITEDESCONTO561", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Limitedesconto561
        {
            get { return  limitedesconto561; }
            set {  limitedesconto561 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULA
        /// Comentário: 
        /// </summary>
        private decimal matricula;
        [XmlElement(ElementName = "MATRICULA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Matricula
        {
            get { return  matricula; }
            set {  matricula = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULACCCARD
        /// Comentário: 
        /// </summary>
        private decimal matriculacccard;
        [XmlElement(ElementName = "MATRICULACCCARD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Matriculacccard
        {
            get { return  matriculacccard; }
            set {  matriculacccard = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MATRICULAFOLHA
        /// Comentário: 
        /// </summary>
        private string matriculafolha;
        [XmlElement(ElementName = "MATRICULAFOLHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Matriculafolha
        {
            get { return  matriculafolha; }
            set {  matriculafolha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MAXTEMPOSECAOOCIOSA
        /// Comentário: Tempo máximo para o menu ficar aberto com usuário ocioso.
        /// </summary>
        private decimal maxtemposecaoociosa;
        [XmlElement(ElementName = "MAXTEMPOSECAOOCIOSA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Maxtemposecaoociosa
        {
            get { return  maxtemposecaoociosa; }
            set {  maxtemposecaoociosa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MEIOCOMUNICACAO
        /// Comentário: 
        /// </summary>
        private string meiocomunicacao;
        [XmlElement(ElementName = "MEIOCOMUNICACAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Meiocomunicacao
        {
            get { return  meiocomunicacao; }
            set {  meiocomunicacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MELPERCACRESCOTA
        /// Comentário: 
        /// </summary>
        private decimal melpercacrescota;
        [XmlElement(ElementName = "MELPERCACRESCOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Melpercacrescota
        {
            get { return  melpercacrescota; }
            set {  melpercacrescota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVOINATIVACAO
        /// Comentário: Motivo Inativação
        /// </summary>
        private string motivoinativacao;
        [XmlElement(ElementName = "MOTIVOINATIVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2000)]
        public string Motivoinativacao
        {
            get { return  motivoinativacao; }
            set {  motivoinativacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NACIONALIDADE
        /// Comentário: 
        /// </summary>
        private string nacionalidade;
        [XmlElement(ElementName = "NACIONALIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nacionalidade
        {
            get { return  nacionalidade; }
            set {  nacionalidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME
        /// Comentário: 
        /// </summary>
        private string nome;
        [XmlElement(ElementName = "NOME", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Nome
        {
            get { return  nome; }
            set {  nome = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEEMAIL
        /// Comentário: 
        /// </summary>
        private string nomeemail;
        [XmlElement(ElementName = "NOMEEMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomeemail
        {
            get { return  nomeemail; }
            set {  nomeemail = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOME_GUERRA
        /// Comentário: 
        /// </summary>
        private string nome_guerra;
        [XmlElement(ElementName = "NOME_GUERRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nome_Guerra
        {
            get { return  nome_guerra; }
            set {  nome_guerra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEMAE
        /// Comentário: 
        /// </summary>
        private string nomemae;
        [XmlElement(ElementName = "NOMEMAE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nomemae
        {
            get { return  nomemae; }
            set {  nomemae = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEPAI
        /// Comentário: 
        /// </summary>
        private string nomepai;
        [XmlElement(ElementName = "NOMEPAI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Nomepai
        {
            get { return  nomepai; }
            set {  nomepai = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMAGENCIA
        /// Comentário: 
        /// </summary>
        private decimal numagencia;
        [XmlElement(ElementName = "NUMAGENCIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numagencia
        {
            get { return  numagencia; }
            set {  numagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMBANCO
        /// Comentário: 
        /// </summary>
        private decimal numbanco;
        [XmlElement(ElementName = "NUMBANCO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numbanco
        {
            get { return  numbanco; }
            set {  numbanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXABALCAO
        /// Comentário: Número do Caixa Balcão. Usado na rotina 528 e 1432. 
        /// </summary>
        private decimal numcaixabalcao;
        [XmlElement(ElementName = "NUMCAIXABALCAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numcaixabalcao
        {
            get { return  numcaixabalcao; }
            set {  numcaixabalcao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCORRENTE
        /// Comentário: 
        /// </summary>
        private string numccorrente;
        [XmlElement(ElementName = "NUMCCORRENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numccorrente
        {
            get { return  numccorrente; }
            set {  numccorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCENTRALPA
        /// Comentário: 
        /// </summary>
        private decimal numcentralpa;
        [XmlElement(ElementName = "NUMCENTRALPA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcentralpa
        {
            get { return  numcentralpa; }
            set {  numcentralpa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCENTRALTEL
        /// Comentário: 
        /// </summary>
        private string numcentraltel;
        [XmlElement(ElementName = "NUMCENTRALTEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numcentraltel
        {
            get { return  numcentraltel; }
            set {  numcentraltel = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONEXOES
        /// Comentário: 
        /// </summary>
        private decimal numconexoes;
        [XmlElement(ElementName = "NUMCONEXOES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numconexoes
        {
            get { return  numconexoes; }
            set {  numconexoes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONEXOESATUAL
        /// Comentário: 
        /// </summary>
        private decimal numconexoesatual;
        [XmlElement(ElementName = "NUMCONEXOESATUAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numconexoesatual
        {
            get { return  numconexoesatual; }
            set {  numconexoesatual = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASMAXPRORROG
        /// Comentário: Numero máximo de dias para Prorrogação por usuário. Cadastrado na 528 e verificado na 1231.
        /// </summary>
        private decimal numdiasmaxprorrog;
        [XmlElement(ElementName = "NUMDIASMAXPRORROG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiasmaxprorrog
        {
            get { return  numdiasmaxprorrog; }
            set {  numdiasmaxprorrog = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASPAGTORETROATIVO
        /// Comentário: Número de Dias Máximo permitido ao usuário para pagamento retroativo de título através da rotina 1207. 
        /// </summary>
        private decimal numdiaspagtoretroativo;
        [XmlElement(ElementName = "NUMDIASPAGTORETROATIVO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdiaspagtoretroativo
        {
            get { return  numdiaspagtoretroativo; }
            set {  numdiaspagtoretroativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDVAGENCIA
        /// Comentário: 
        /// </summary>
        private string numdvagencia;
        [XmlElement(ElementName = "NUMDVAGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numdvagencia
        {
            get { return  numdvagencia; }
            set {  numdvagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDVCONTA
        /// Comentário: Indica o digito verificador da conta corrente.
        /// </summary>
        private string numdvconta;
        [XmlElement(ElementName = "NUMDVCONTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numdvconta
        {
            get { return  numdvconta; }
            set {  numdvconta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFILHOS
        /// Comentário: 
        /// </summary>
        private decimal numfilhos;
        [XmlElement(ElementName = "NUMFILHOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numfilhos
        {
            get { return  numfilhos; }
            set {  numfilhos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMIDENTIFICADORECF
        /// Comentário: Indica a numeração do funcionário para impressão de Cód. Barra
        /// </summary>
        private string numidentificadorecf;
        [XmlElement(ElementName = "NUMIDENTIFICADORECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Numidentificadorecf
        {
            get { return  numidentificadorecf; }
            set {  numidentificadorecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMINSS
        /// Comentário: Indica o número do INSS do motorista.
        /// </summary>
        private string numinss;
        [XmlElement(ElementName = "NUMINSS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Numinss
        {
            get { return  numinss; }
            set {  numinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Comentário: Observação do motorista.
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSERVACAO
        /// Comentário: 
        /// </summary>
        private string observacao;
        [XmlElement(ElementName = "OBSERVACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Observacao
        {
            get { return  observacao; }
            set {  observacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSINATIVO
        /// Comentário: 
        /// </summary>
        private string obsinativo;
        [XmlElement(ElementName = "OBSINATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Obsinativo
        {
            get { return  obsinativo; }
            set {  obsinativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAOEMISSORCNH
        /// Comentário: Campo referente ao Orgão emissor da CNH
        /// </summary>
        private string orgaoemissorcnh;
        [XmlElement(ElementName = "ORGAOEMISSORCNH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Orgaoemissorcnh
        {
            get { return  orgaoemissorcnh; }
            set {  orgaoemissorcnh = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORGAOEMISSORRG
        /// Comentário: 
        /// </summary>
        private string orgaoemissorrg;
        [XmlElement(ElementName = "ORGAOEMISSORRG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Orgaoemissorrg
        {
            get { return  orgaoemissorrg; }
            set {  orgaoemissorrg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: Indica o percentual máximo a ser aplicado.
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCEXCLIMCRED
        /// Comentário: 
        /// </summary>
        private decimal percexclimcred;
        [XmlElement(ElementName = "PERCEXCLIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percexclimcred
        {
            get { return  percexclimcred; }
            set {  percexclimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINSS
        /// Comentário: 
        /// </summary>
        private decimal percinss;
        [XmlElement(ElementName = "PERCINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percinss
        {
            get { return  percinss; }
            set {  percinss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXDESCTITULO
        /// Comentário: Percentual máximo de desconto de título
        /// </summary>
        private decimal percmaxdesctitulo;
        [XmlElement(ElementName = "PERCMAXDESCTITULO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmaxdesctitulo
        {
            get { return  percmaxdesctitulo; }
            set {  percmaxdesctitulo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMAXJUROSMORA
        /// Comentário: 
        /// </summary>
        private decimal percmaxjurosmora;
        [XmlElement(ElementName = "PERCMAXJUROSMORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percmaxjurosmora
        {
            get { return  percmaxjurosmora; }
            set {  percmaxjurosmora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMINJUROSMORA
        /// Comentário: 
        /// </summary>
        private decimal percminjurosmora;
        [XmlElement(ElementName = "PERCMINJUROSMORA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percminjurosmora
        {
            get { return  percminjurosmora; }
            set {  percminjurosmora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMOT
        /// Comentário: 
        /// </summary>
        private decimal percommot;
        [XmlElement(ElementName = "PERCOMMOT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percommot
        {
            get { return  percommot; }
            set {  percommot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCREDUZCOMISRCA
        /// Comentário: 
        /// </summary>
        private decimal percreduzcomisrca;
        [XmlElement(ElementName = "PERCREDUZCOMISRCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percreduzcomisrca
        {
            get { return  percreduzcomisrca; }
            set {  percreduzcomisrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCVT
        /// Comentário: 
        /// </summary>
        private decimal percvt;
        [XmlElement(ElementName = "PERCVT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percvt
        {
            get { return  percvt; }
            set {  percvt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTDESCBX
        /// Comentário: 
        /// </summary>
        private string permitealtdescbx;
        [XmlElement(ElementName = "PERMITEALTDESCBX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealtdescbx
        {
            get { return  permitealtdescbx; }
            set {  permitealtdescbx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEALTJUROSBX
        /// Comentário: 
        /// </summary>
        private string permitealtjurosbx;
        [XmlElement(ElementName = "PERMITEALTJUROSBX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitealtjurosbx
        {
            get { return  permitealtjurosbx; }
            set {  permitealtjurosbx = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEPERSONCAD
        /// Comentário: Informa se o usuário tem permissão para personalizar os cadastros.
        /// </summary>
        private string permitepersoncad;
        [XmlElement(ElementName = "PERMITEPERSONCAD", DataType = "CHAR", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permitepersoncad
        {
            get { return  permitepersoncad; }
            set {  permitepersoncad = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PIS
        /// Comentário: 
        /// </summary>
        private string pis;
        [XmlElement(ElementName = "PIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Pis
        {
            get { return  pis; }
            set {  pis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROFISSAO
        /// Comentário: 
        /// </summary>
        private string profissao;
        [XmlElement(ElementName = "PROFISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Profissao
        {
            get { return  profissao; }
            set {  profissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDEPENDENTES
        /// Comentário: Quantidade de dependentes do funcionário
        /// </summary>
        private decimal qtdependentes;
        [XmlElement(ElementName = "QTDEPENDENTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtdependentes
        {
            get { return  qtdependentes; }
            set {  qtdependentes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAMAL
        /// Comentário: Ramal do Operador
        /// </summary>
        private decimal ramal;
        [XmlElement(ElementName = "RAMAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Ramal
        {
            get { return  ramal; }
            set {  ramal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: REFERENCIAPESSOAL
        /// Comentário: 
        /// </summary>
        private string referenciapessoal;
        [XmlElement(ElementName = "REFERENCIAPESSOAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Referenciapessoal
        {
            get { return  referenciapessoal; }
            set {  referenciapessoal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESCISAO
        /// Comentário: 
        /// </summary>
        private DateTime? rescisao;
        [XmlElement(ElementName = "RESCISAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Rescisao
        {
            get { return  rescisao; }
            set {  rescisao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RESPLIBCADASTRO
        /// Comentário: RESPONSÁVEL OU NÃO PELA LIBERAÇÃO DO CADASTRAMENTO DE CONTATO/ SÓCIO DO CLIENTE
        /// </summary>
        private string resplibcadastro;
        [XmlElement(ElementName = "RESPLIBCADASTRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Resplibcadastro
        {
            get { return  resplibcadastro; }
            set {  resplibcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RG
        /// Comentário: 
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
        /// Propriedade referente ao campo: SENHABD
        /// Comentário: 
        /// </summary>
        private string senhabd;
        [XmlElement(ElementName = "SENHABD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Senhabd
        {
            get { return  senhabd; }
            set {  senhabd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHAHASH
        /// Comentário: Senha de acesso ao Winthor, utilizando nova forma de criptografia
        /// </summary>
        private string senhahash;
        [XmlElement(ElementName = "SENHAHASH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,32)]
        public string Senhahash
        {
            get { return  senhahash; }
            set {  senhahash = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIECTPS
        /// Comentário: 
        /// </summary>
        private string seriectps;
        [XmlElement(ElementName = "SERIECTPS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Seriectps
        {
            get { return  seriectps; }
            set {  seriectps = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEXO
        /// Comentário: 
        /// </summary>
        private string sexo;
        [XmlElement(ElementName = "SEXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sexo
        {
            get { return  sexo; }
            set {  sexo = value; }
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
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAGENTECOB
        /// Comentário: Definir o tipo de agente de cobrança entre interno e externo.
        /// </summary>
        private string tipoagentecob;
        [XmlElement(ElementName = "TIPOAGENTECOB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoagentecob
        {
            get { return  tipoagentecob; }
            set {  tipoagentecob = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOATENDE
        /// Comentário: 
        /// </summary>
        private string tipoatende;
        [XmlElement(ElementName = "TIPOATENDE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoatende
        {
            get { return  tipoatende; }
            set {  tipoatende = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOMISSAO
        /// Comentário: Indica o tipo de comissão ([P]-Percentual, [V]-Valor).
        /// </summary>
        private string tipocomissao;
        [XmlElement(ElementName = "TIPOCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocomissao
        {
            get { return  tipocomissao; }
            set {  tipocomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOENVIO
        /// Comentário: 
        /// </summary>
        private string tipoenvio;
        [XmlElement(ElementName = "TIPOENVIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoenvio
        {
            get { return  tipoenvio; }
            set {  tipoenvio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOLANCTOFINANCEIRO
        /// Comentário: 
        /// </summary>
        private string tipolanctofinanceiro;
        [XmlElement(ElementName = "TIPOLANCTOFINANCEIRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipolanctofinanceiro
        {
            get { return  tipolanctofinanceiro; }
            set {  tipolanctofinanceiro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOMOTORISTA
        /// Comentário: 
        /// </summary>
        private string tipomotorista;
        [XmlElement(ElementName = "TIPOMOTORISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipomotorista
        {
            get { return  tipomotorista; }
            set {  tipomotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVENDA
        /// Comentário: 
        /// </summary>
        private string tipovenda;
        [XmlElement(ElementName = "TIPOVENDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovenda
        {
            get { return  tipovenda; }
            set {  tipovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UFCNH
        /// Comentário: 
        /// </summary>
        private string ufcnh;
        [XmlElement(ElementName = "UFCNH", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Ufcnh
        {
            get { return  ufcnh; }
            set {  ufcnh = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USAAVISOAUTOMENU
        /// Comentário: Atualiza aviso automaticamente no menu.
        /// </summary>
        private string usaavisoautomenu;
        [XmlElement(ElementName = "USAAVISOAUTOMENU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usaavisoautomenu
        {
            get { return  usaavisoautomenu; }
            set {  usaavisoautomenu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USABIOMETRIAMENU
        /// Comentário: Indica se utiliza controle biometria login.
        /// </summary>
        private string usabiometriamenu;
        [XmlElement(ElementName = "USABIOMETRIAMENU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usabiometriamenu
        {
            get { return  usabiometriamenu; }
            set {  usabiometriamenu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACAIXAMOTORISTA
        /// Comentário: 
        /// </summary>
        private string usacaixamotorista;
        [XmlElement(ElementName = "USACAIXAMOTORISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacaixamotorista
        {
            get { return  usacaixamotorista; }
            set {  usacaixamotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARATEIOCOMISSAOOPERADOR
        /// Comentário: Incica se usa rateio de comissão com operador.
        /// </summary>
        private string usarateiocomissaooperador;
        [XmlElement(ElementName = "USARATEIOCOMISSAOOPERADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarateiocomissaooperador
        {
            get { return  usarateiocomissaooperador; }
            set {  usarateiocomissaooperador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USATABELACLIENTE
        /// Comentário: Utilizar Tabela de Preço por Cliente
        /// </summary>
        private string usatabelacliente;
        [XmlElement(ElementName = "USATABELACLIENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usatabelacliente
        {
            get { return  usatabelacliente; }
            set {  usatabelacliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOBD
        /// Comentário: 
        /// </summary>
        private string usuariobd;
        [XmlElement(ElementName = "USUARIOBD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Usuariobd
        {
            get { return  usuariobd; }
            set {  usuariobd = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOLOGADO
        /// Comentário: 
        /// </summary>
        private string usuariologado;
        [XmlElement(ElementName = "USUARIOLOGADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usuariologado
        {
            get { return  usuariologado; }
            set {  usuariologado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOLOGADORF
        /// Comentário: Informa se esta logado no RF
        /// </summary>
        private string usuariologadorf;
        [XmlElement(ElementName = "USUARIOLOGADORF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usuariologadorf
        {
            get { return  usuariologadorf; }
            set {  usuariologadorf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDAASSISTIDA
        /// Comentário: Indica que o usuário é de venda assistida (a rotina 316 irá pedir Usuário e senha ao iniciar o Pedido).
        /// </summary>
        private string vendaassistida;
        [XmlElement(ElementName = "VENDAASSISTIDA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendaassistida
        {
            get { return  vendaassistida; }
            set {  vendaassistida = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLADICIONAL
        /// Comentário: 
        /// </summary>
        private decimal vladicional;
        [XmlElement(ElementName = "VLADICIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vladicional
        {
            get { return  vladicional; }
            set {  vladicional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLAUMENTOLIMCRED
        /// Comentário: 
        /// </summary>
        private decimal vlaumentolimcred;
        [XmlElement(ElementName = "VLAUMENTOLIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlaumentolimcred
        {
            get { return  vlaumentolimcred; }
            set {  vlaumentolimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMISSENT
        /// Comentário: 
        /// </summary>
        private decimal vlcomissent;
        [XmlElement(ElementName = "VLCOMISSENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomissent
        {
            get { return  vlcomissent; }
            set {  vlcomissent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCOMISSTON
        /// Comentário: 
        /// </summary>
        private decimal vlcomisston;
        [XmlElement(ElementName = "VLCOMISSTON", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlcomisston
        {
            get { return  vlcomisston; }
            set {  vlcomisston = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEENTREGA
        /// Comentário: 
        /// </summary>
        private decimal vlfreteentrega;
        [XmlElement(ElementName = "VLFRETEENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlfreteentrega
        {
            get { return  vlfreteentrega; }
            set {  vlfreteentrega = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLIMCREDCOMPRA
        /// Comentário: 
        /// </summary>
        private decimal vllimcredcompra;
        [XmlElement(ElementName = "VLLIMCREDCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vllimcredcompra
        {
            get { return  vllimcredcompra; }
            set {  vllimcredcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLIMMAXPEDCOMPRA
        /// Comentário: Limite Máximo Liberação Pedido Compra
        /// </summary>
        private decimal vllimmaxpedcompra;
        [XmlElement(ElementName = "VLLIMMAXPEDCOMPRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vllimmaxpedcompra
        {
            get { return  vllimmaxpedcompra; }
            set {  vllimmaxpedcompra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXLIBPEDIDO
        /// Comentário: 
        /// </summary>
        private decimal vlmaxlibpedido;
        [XmlElement(ElementName = "VLMAXLIBPEDIDO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlmaxlibpedido
        {
            get { return  vlmaxlibpedido; }
            set {  vlmaxlibpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXLIMCREDCLI
        /// Comentário: Valor Máximo de Limite de Crédito do Cliente
        /// </summary>
        private decimal vlmaxlimcredcli;
        [XmlElement(ElementName = "VLMAXLIMCREDCLI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlmaxlimcredcli
        {
            get { return  vlmaxlimcredcli; }
            set {  vlmaxlimcredcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPENSAOALIMENTICIA
        /// Comentário: 
        /// </summary>
        private decimal vlpensaoalimenticia;
        [XmlElement(ElementName = "VLPENSAOALIMENTICIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlpensaoalimenticia
        {
            get { return  vlpensaoalimenticia; }
            set {  vlpensaoalimenticia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPLANOSAUDE
        /// Comentário: 
        /// </summary>
        private decimal vlplanosaude;
        [XmlElement(ElementName = "VLPLANOSAUDE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlplanosaude
        {
            get { return  vlplanosaude; }
            set {  vlplanosaude = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRLIMAPROVARSOLICITACAO
        /// Comentário: Vl. lim. de aprovação de solicitação
        /// </summary>
        private decimal vlrlimaprovarsolicitacao;
        [XmlElement(ElementName = "VLRLIMAPROVARSOLICITACAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlrlimaprovarsolicitacao
        {
            get { return  vlrlimaprovarsolicitacao; }
            set {  vlrlimaprovarsolicitacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLR_SALDOCAIXAMOTORISTA
        /// Comentário: 
        /// </summary>
        private decimal vlr_saldocaixamotorista;
        [XmlElement(ElementName = "VLR_SALDOCAIXAMOTORISTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Vlr_Saldocaixamotorista
        {
            get { return  vlr_saldocaixamotorista; }
            set {  vlr_saldocaixamotorista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALARIO
        /// Comentário: 
        /// </summary>
        private decimal vlsalario;
        [XmlElement(ElementName = "VLSALARIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlsalario
        {
            get { return  vlsalario; }
            set {  vlsalario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALCARTEIRA
        /// Comentário: 
        /// </summary>
        private decimal vlsalcarteira;
        [XmlElement(ElementName = "VLSALCARTEIRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlsalcarteira
        {
            get { return  vlsalcarteira; }
            set {  vlsalcarteira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALDOLIMALTCREDITO
        /// Comentário: 
        /// </summary>
        private decimal vlsaldolimaltcredito;
        [XmlElement(ElementName = "VLSALDOLIMALTCREDITO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Vlsaldolimaltcredito
        {
            get { return  vlsaldolimaltcredito; }
            set {  vlsaldolimaltcredito = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLSALFAMILIA
        /// Comentário: 
        /// </summary>
        private decimal vlsalfamilia;
        [XmlElement(ElementName = "VLSALFAMILIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlsalfamilia
        {
            get { return  vlsalfamilia; }
            set {  vlsalfamilia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVALES
        /// Comentário: 
        /// </summary>
        private decimal vlvales;
        [XmlElement(ElementName = "VLVALES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlvales
        {
            get { return  vlvales; }
            set {  vlvales = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEmpr()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCEMPR";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEmpr> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEmpr>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEmpr> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEmpr>(where);
        }

        #endregion
    }
}
