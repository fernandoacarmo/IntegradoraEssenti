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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a �rea de atua��o do funci�nario.
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
        /// Coment�rio: Autorizar cheque bloqueado venda
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero chapa integra��o RM.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo da cidade.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: C�digo do centro de custo
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
        /// Coment�rio: C�digo do Perfil para WMS. 
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
        /// Coment�rio: C�digo do Perfil
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o valor de comiss�o fixa.
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
        /// Coment�rio: 
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
        /// Coment�rio: Armazena se o funcion�rio tem permiss�o para conceder ou n�o abatimento nas vendas
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o n�mero de dias de atraso t�tulo p/ cobran�a externa.
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
        /// Coment�rio: Data de demiss�o.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ENVIAFV
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ESTADOCIVIL
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o limite de desconto.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Tempo m�ximo para o menu ficar aberto com usu�rio ocioso.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Motivo Inativa��o
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: N�mero do Caixa Balc�o. Usado na rotina 528 e 1432. 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Numero m�ximo de dias para Prorroga��o por usu�rio. Cadastrado na 528 e verificado na 1231.
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
        /// Coment�rio: N�mero de Dias M�ximo permitido ao usu�rio para pagamento retroativo de t�tulo atrav�s da rotina 1207. 
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o digito verificador da conta corrente.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica a numera��o do funcion�rio para impress�o de C�d. Barra
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
        /// Coment�rio: Indica o n�mero do INSS do motorista.
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
        /// Coment�rio: Observa��o do motorista.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Campo referente ao Org�o emissor da CNH
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o percentual m�ximo a ser aplicado.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Percentual m�ximo de desconto de t�tulo
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Informa se o usu�rio tem permiss�o para personalizar os cadastros.
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Quantidade de dependentes do funcion�rio
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
        /// Coment�rio: Ramal do Operador
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: RESPONS�VEL OU N�O PELA LIBERA��O DO CADASTRAMENTO DE CONTATO/ S�CIO DO CLIENTE
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Senha de acesso ao Winthor, utilizando nova forma de criptografia
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Definir o tipo de agente de cobran�a entre interno e externo.
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
        /// Coment�rio: 
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
        /// Coment�rio: Indica o tipo de comiss�o ([P]-Percentual, [V]-Valor).
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Atualiza aviso automaticamente no menu.
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
        /// Coment�rio: Indica se utiliza controle biometria login.
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
        /// Coment�rio: 
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
        /// Coment�rio: Incica se usa rateio de comiss�o com operador.
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
        /// Coment�rio: Utilizar Tabela de Pre�o por Cliente
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Informa se esta logado no RF
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
        /// Coment�rio: Indica que o usu�rio � de venda assistida (a rotina 316 ir� pedir Usu�rio e senha ao iniciar o Pedido).
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Limite M�ximo Libera��o Pedido Compra
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
        /// Coment�rio: 
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
        /// Coment�rio: Valor M�ximo de Limite de Cr�dito do Cliente
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: Vl. lim. de aprova��o de solicita��o
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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
        /// Coment�rio: 
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

        #region M�todos
        /// <summary>
        /// M�todo create
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
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCEmpr> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEmpr>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
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
