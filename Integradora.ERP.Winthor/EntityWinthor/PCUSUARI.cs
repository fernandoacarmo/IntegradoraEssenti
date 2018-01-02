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
    /// Classe referente a tabela PCUsuari
    /// </summary>
    [XmlType("PCUSUARI")]
    public class PCUsuari : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AREAATUACAO
        /// Comentário: 
        /// </summary>
        private string areaatuacao;
        [XmlElement(ElementName = "AREAATUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Areaatuacao
        {
            get { return  areaatuacao; }
            set {  areaatuacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BAIRRO
        /// Comentário: 
        /// </summary>
        private string bairro;
        [XmlElement(ElementName = "BAIRRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Bairro
        {
            get { return  bairro; }
            set {  bairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BIP
        /// Comentário: 
        /// </summary>
        private string bip;
        [XmlElement(ElementName = "BIP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Bip
        {
            get { return  bip; }
            set {  bip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQCOMIS
        /// Comentário: 
        /// </summary>
        private string bloqcomis;
        [XmlElement(ElementName = "BLOQCOMIS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqcomis
        {
            get { return  bloqcomis; }
            set {  bloqcomis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQUEIO
        /// Comentário: 
        /// </summary>
        private string bloqueio;
        [XmlElement(ElementName = "BLOQUEIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqueio
        {
            get { return  bloqueio; }
            set {  bloqueio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: BLOQVENDATLMK
        /// Comentário: 
        /// </summary>
        private string bloqvendatlmk;
        [XmlElement(ElementName = "BLOQVENDATLMK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Bloqvendatlmk
        {
            get { return  bloqvendatlmk; }
            set {  bloqvendatlmk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CCORRENTE
        /// Comentário: 
        /// </summary>
        private string ccorrente;
        [XmlElement(ElementName = "CCORRENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ccorrente
        {
            get { return  ccorrente; }
            set {  ccorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CEP
        /// Comentário: 
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
        /// Propriedade referente ao campo: CGC
        /// Comentário: 
        /// </summary>
        private string cgc;
        [XmlElement(ElementName = "CGC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cgc
        {
            get { return  cgc; }
            set {  cgc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CI
        /// Comentário: 
        /// </summary>
        private string ci;
        [XmlElement(ElementName = "CI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Ci
        {
            get { return  ci; }
            set {  ci = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CIDADE
        /// Comentário: 
        /// </summary>
        private string cidade;
        [XmlElement(ElementName = "CIDADE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Cidade
        {
            get { return  cidade; }
            set {  cidade = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODBAIRRO
        /// Comentário: código do bairro
        /// </summary>
        private decimal codbairro;
        [XmlElement(ElementName = "CODBAIRRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codbairro
        {
            get { return  codbairro; }
            set {  codbairro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCIDADE
        /// Comentário: Código da cidade
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
        /// Propriedade referente ao campo: CODCOMOCLIENTE
        /// Comentário: 
        /// </summary>
        private decimal codcomocliente;
        [XmlElement(ElementName = "CODCOMOCLIENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcomocliente
        {
            get { return  codcomocliente; }
            set {  codcomocliente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAB
        /// Comentário: Conta Contábil
        /// </summary>
        private string codcontab;
        [XmlElement(ElementName = "CODCONTAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Codcontab
        {
            get { return  codcontab; }
            set {  codcontab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACOFINS
        /// Comentário: Código da conta COFINS.
        /// </summary>
        private decimal codcontacofins;
        [XmlElement(ElementName = "CODCONTACOFINS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacofins
        {
            get { return  codcontacofins; }
            set {  codcontacofins = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTACSRF
        /// Comentário: Código da conta SRF
        /// </summary>
        private decimal codcontacsrf;
        [XmlElement(ElementName = "CODCONTACSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontacsrf
        {
            get { return  codcontacsrf; }
            set {  codcontacsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAINSS
        /// Comentário: Código da conta INSS.
        /// </summary>
        private decimal codcontainss;
        [XmlElement(ElementName = "CODCONTAINSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontainss
        {
            get { return  codcontainss; }
            set {  codcontainss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAIRRF
        /// Comentário: Código da conta IRRF.
        /// </summary>
        private decimal codcontairrf;
        [XmlElement(ElementName = "CODCONTAIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontairrf
        {
            get { return  codcontairrf; }
            set {  codcontairrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAISS
        /// Comentário: Código da conta ISS.
        /// </summary>
        private decimal codcontaiss;
        [XmlElement(ElementName = "CODCONTAISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontaiss
        {
            get { return  codcontaiss; }
            set {  codcontaiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTAPIS
        /// Comentário: Código da conta PIS.
        /// </summary>
        private decimal codcontapis;
        [XmlElement(ElementName = "CODCONTAPIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontapis
        {
            get { return  codcontapis; }
            set {  codcontapis = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONTASRF
        /// Comentário: Código da conta SRF.
        /// </summary>
        private decimal codcontasrf;
        [XmlElement(ElementName = "CODCONTASRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codcontasrf
        {
            get { return  codcontasrf; }
            set {  codcontasrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODDISTRIB
        /// Comentário: 
        /// </summary>
        private string coddistrib;
        [XmlElement(ElementName = "CODDISTRIB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Coddistrib
        {
            get { return  coddistrib; }
            set {  coddistrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODEQUIPE
        /// Comentário: 
        /// </summary>
        private decimal codequipe;
        [XmlElement(ElementName = "CODEQUIPE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codequipe
        {
            get { return  codequipe; }
            set {  codequipe = value; }
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
        /// Propriedade referente ao campo: CODMONITOR
        /// Comentário: Indica o código do monitor de venda.
        /// </summary>
        private decimal codmonitor;
        [XmlElement(ElementName = "CODMONITOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codmonitor
        {
            get { return  codmonitor; }
            set {  codmonitor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERACAO
        /// Comentário: 
        /// </summary>
        private string codoperacao;
        [XmlElement(ElementName = "CODOPERACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Codoperacao
        {
            get { return  codoperacao; }
            set {  codoperacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPRACAPRINCIPAL
        /// Comentário: Indica o código da praça principal.
        /// </summary>
        private decimal codpracaprincipal;
        [XmlElement(ElementName = "CODPRACAPRINCIPAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codpracaprincipal
        {
            get { return  codpracaprincipal; }
            set {  codpracaprincipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTA
        /// Comentário: Código da rota do RCA.
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERVISOR
        /// Comentário: 
        /// </summary>
        private decimal codsupervisor;
        [XmlElement(ElementName = "CODSUPERVISOR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codsupervisor
        {
            get { return  codsupervisor; }
            set {  codsupervisor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COMISSAOFIXA
        /// Comentário: Indica o valor da comissão fixa para o RCA.
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
        /// Propriedade referente ao campo: COMISSAOSERVICOPRESTADO
        /// Comentário: Comissão RCA serviço prestado.
        /// </summary>
        private decimal comissaoservicoprestado;
        [XmlElement(ElementName = "COMISSAOSERVICOPRESTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Comissaoservicoprestado
        {
            get { return  comissaoservicoprestado; }
            set {  comissaoservicoprestado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONJUGE
        /// Comentário: 
        /// </summary>
        private string conjuge;
        [XmlElement(ElementName = "CONJUGE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Conjuge
        {
            get { return  conjuge; }
            set {  conjuge = value; }
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
        /// Propriedade referente ao campo: CPFAUX
        /// Comentário: Campo auxiliar para armazenar o cpf sem formatação.
        /// </summary>
        private string cpfaux;
        [XmlElement(ElementName = "CPFAUX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Cpfaux
        {
            get { return  cpfaux; }
            set {  cpfaux = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRENVIOFTP
        /// Comentário: 
        /// </summary>
        private string direnvioftp;
        [XmlElement(ElementName = "DIRENVIOFTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Direnvioftp
        {
            get { return  direnvioftp; }
            set {  direnvioftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRETORIOASSINATURA
        /// Comentário: Diretório da Assinatura digitalizada do RCA
        /// </summary>
        private string diretorioassinatura;
        [XmlElement(ElementName = "DIRETORIOASSINATURA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Diretorioassinatura
        {
            get { return  diretorioassinatura; }
            set {  diretorioassinatura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRRECEPCAOFTP
        /// Comentário: 
        /// </summary>
        private string dirrecepcaoftp;
        [XmlElement(ElementName = "DIRRECEPCAOFTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Dirrecepcaoftp
        {
            get { return  dirrecepcaoftp; }
            set {  dirrecepcaoftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENTREGADOC
        /// Comentário: 
        /// </summary>
        private DateTime? dtentregadoc;
        [XmlElement(ElementName = "DTENTREGADOC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtentregadoc
        {
            get { return  dtentregadoc; }
            set {  dtentregadoc = value; }
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
        /// Propriedade referente ao campo: DTINFORMATIZA
        /// Comentário: 
        /// </summary>
        private DateTime? dtinformatiza;
        [XmlElement(ElementName = "DTINFORMATIZA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinformatiza
        {
            get { return  dtinformatiza; }
            set {  dtinformatiza = value; }
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
        /// Propriedade referente ao campo: DTLIMENTREGADOC
        /// Comentário: 
        /// </summary>
        private DateTime? dtlimentregadoc;
        [XmlElement(ElementName = "DTLIMENTREGADOC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtlimentregadoc
        {
            get { return  dtlimentregadoc; }
            set {  dtlimentregadoc = value; }
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
        /// Propriedade referente ao campo: DTNASCONJUGE
        /// Comentário: 
        /// </summary>
        private DateTime? dtnasconjuge;
        [XmlElement(ElementName = "DTNASCONJUGE", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtnasconjuge
        {
            get { return  dtnasconjuge; }
            set {  dtnasconjuge = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTTERMINO
        /// Comentário: 
        /// </summary>
        private DateTime? dttermino;
        [XmlElement(ElementName = "DTTERMINO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dttermino
        {
            get { return  dttermino; }
            set {  dttermino = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALTERACAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtultalteracao;
        [XmlElement(ElementName = "DTULTALTERACAO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalteracao
        {
            get { return  dtultalteracao; }
            set {  dtultalteracao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTPAGCONSELHO
        /// Comentário: 
        /// </summary>
        private DateTime? dtultpagconselho;
        [XmlElement(ElementName = "DTULTPAGCONSELHO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultpagconselho
        {
            get { return  dtultpagconselho; }
            set {  dtultpagconselho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTVENDA
        /// Comentário: 
        /// </summary>
        private DateTime? dtultvenda;
        [XmlElement(ElementName = "DTULTVENDA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultvenda
        {
            get { return  dtultvenda; }
            set {  dtultvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL2
        /// Comentário: 
        /// </summary>
        private string email2;
        [XmlElement(ElementName = "EMAIL2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Email2
        {
            get { return  email2; }
            set {  email2 = value; }
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
        /// Propriedade referente ao campo: ENDERECO2
        /// Comentário: 
        /// </summary>
        private string endereco2;
        [XmlElement(ElementName = "ENDERECO2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Endereco2
        {
            get { return  endereco2; }
            set {  endereco2 = value; }
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
        /// Propriedade referente ao campo: EXPORTADADOS
        /// Comentário: 
        /// </summary>
        private string exportadados;
        [XmlElement(ElementName = "EXPORTADADOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportadados
        {
            get { return  exportadados; }
            set {  exportadados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTARCOMISSAOFOLHARM
        /// Comentário: Exporta comissão do RCA para folha.
        /// </summary>
        private string exportarcomissaofolharm;
        [XmlElement(ElementName = "EXPORTARCOMISSAOFOLHARM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportarcomissaofolharm
        {
            get { return  exportarcomissaofolharm; }
            set {  exportarcomissaofolharm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTARECF
        /// Comentário: Exportar RCA Auto Serviço.
        /// </summary>
        private string exportarecf;
        [XmlElement(ElementName = "EXPORTARECF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportarecf
        {
            get { return  exportarecf; }
            set {  exportarecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTARPARAFORCAVENDAS
        /// Comentário: Exportar para força de vendas
        /// </summary>
        private string exportarparaforcavendas;
        [XmlElement(ElementName = "EXPORTARPARAFORCAVENDAS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportarparaforcavendas
        {
            get { return  exportarparaforcavendas; }
            set {  exportarparaforcavendas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FATORCOMISLIQ
        /// Comentário: Fator para acréscimo do valor da comissão por liquidez da rot.1266.
        /// </summary>
        private decimal fatorcomisliq;
        [XmlElement(ElementName = "FATORCOMISLIQ", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Fatorcomisliq
        {
            get { return  fatorcomisliq; }
            set {  fatorcomisliq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FAX
        /// Comentário: 
        /// </summary>
        private string fax;
        [XmlElement(ElementName = "FAX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Fax
        {
            get { return  fax; }
            set {  fax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FIRMA
        /// Comentário: 
        /// </summary>
        private string firma;
        [XmlElement(ElementName = "FIRMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Firma
        {
            get { return  firma; }
            set {  firma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFIMCONEXAOPALM
        /// Comentário: 
        /// </summary>
        private decimal horafimconexaopalm;
        [XmlElement(ElementName = "HORAFIMCONEXAOPALM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafimconexaopalm
        {
            get { return  horafimconexaopalm; }
            set {  horafimconexaopalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICONEXAOPALM
        /// Comentário: 
        /// </summary>
        private decimal horainiconexaopalm;
        [XmlElement(ElementName = "HORAINICONEXAOPALM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horainiconexaopalm
        {
            get { return  horainiconexaopalm; }
            set {  horainiconexaopalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICECPFECHCOMISSAO
        /// Comentário: Indica o valor do índice para este RCA no lançamento de Contas a Pagar 
        /// </summary>
        private string indicecpfechcomissao;
        [XmlElement(ElementName = "INDICECPFECHCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Indicecpfechcomissao
        {
            get { return  indicecpfechcomissao; }
            set {  indicecpfechcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICERATEIOCOMISSAO
        /// Comentário: Indice de rateio de comissão. 
        /// </summary>
        private decimal indicerateiocomissao;
        [XmlElement(ElementName = "INDICERATEIOCOMISSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Indicerateiocomissao
        {
            get { return  indicerateiocomissao; }
            set {  indicerateiocomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSCMUNICIPAL
        /// Comentário: 
        /// </summary>
        private string inscmunicipal;
        [XmlElement(ElementName = "INSCMUNICIPAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Inscmunicipal
        {
            get { return  inscmunicipal; }
            set {  inscmunicipal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INSS
        /// Comentário: 
        /// </summary>
        private decimal inss;
        [XmlElement(ElementName = "INSS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Inss
        {
            get { return  inss; }
            set {  inss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MASKPREPOSTO
        /// Comentário: 
        /// </summary>
        private string maskpreposto;
        [XmlElement(ElementName = "MASKPREPOSTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Maskpreposto
        {
            get { return  maskpreposto; }
            set {  maskpreposto = value; }
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
        /// Propriedade referente ao campo: MENS1
        /// Comentário: 
        /// </summary>
        private string mens1;
        [XmlElement(ElementName = "MENS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens1
        {
            get { return  mens1; }
            set {  mens1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS2
        /// Comentário: 
        /// </summary>
        private string mens2;
        [XmlElement(ElementName = "MENS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens2
        {
            get { return  mens2; }
            set {  mens2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS3
        /// Comentário: 
        /// </summary>
        private string mens3;
        [XmlElement(ElementName = "MENS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens3
        {
            get { return  mens3; }
            set {  mens3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS4
        /// Comentário: 
        /// </summary>
        private string mens4;
        [XmlElement(ElementName = "MENS4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens4
        {
            get { return  mens4; }
            set {  mens4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOFIMCONEXAOPALM
        /// Comentário: 
        /// </summary>
        private decimal minutofimconexaopalm;
        [XmlElement(ElementName = "MINUTOFIMCONEXAOPALM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutofimconexaopalm
        {
            get { return  minutofimconexaopalm; }
            set {  minutofimconexaopalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOINICONEXAOPALM
        /// Comentário: 
        /// </summary>
        private decimal minutoiniconexaopalm;
        [XmlElement(ElementName = "MINUTOINICONEXAOPALM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoiniconexaopalm
        {
            get { return  minutoiniconexaopalm; }
            set {  minutoiniconexaopalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELOPALM
        /// Comentário: Armazena o Modelo do Palm em poder do RCA
        /// </summary>
        private string modelopalm;
        [XmlElement(ElementName = "MODELOPALM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Modelopalm
        {
            get { return  modelopalm; }
            set {  modelopalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MOTIVO
        /// Comentário: 
        /// </summary>
        private string motivo;
        [XmlElement(ElementName = "MOTIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Motivo
        {
            get { return  motivo; }
            set {  motivo = value; }
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
        /// Propriedade referente ao campo: NUMAGENCIAPOUP
        /// Comentário: 
        /// </summary>
        private decimal numagenciapoup;
        [XmlElement(ElementName = "NUMAGENCIAPOUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numagenciapoup
        {
            get { return  numagenciapoup; }
            set {  numagenciapoup = value; }
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
        /// Propriedade referente ao campo: NUMBANCOPOUP
        /// Comentário: 
        /// </summary>
        private decimal numbancopoup;
        [XmlElement(ElementName = "NUMBANCOPOUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numbancopoup
        {
            get { return  numbancopoup; }
            set {  numbancopoup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCORRENTE
        /// Comentário: 
        /// </summary>
        private decimal numccorrente;
        [XmlElement(ElementName = "NUMCCORRENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numccorrente
        {
            get { return  numccorrente; }
            set {  numccorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCORRENTEALFA
        /// Comentário: Numero conta corrente alfa numérico.
        /// </summary>
        private string numccorrentealfa;
        [XmlElement(ElementName = "NUMCCORRENTEALFA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numccorrentealfa
        {
            get { return  numccorrentealfa; }
            set {  numccorrentealfa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCCORRENTEPOUP
        /// Comentário: 
        /// </summary>
        private decimal numccorrentepoup;
        [XmlElement(ElementName = "NUMCCORRENTEPOUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numccorrentepoup
        {
            get { return  numccorrentepoup; }
            set {  numccorrentepoup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCLIPOS
        /// Comentário: Indice a meta de clientes para positivação. 
        /// </summary>
        private decimal numclipos;
        [XmlElement(ElementName = "NUMCLIPOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numclipos
        {
            get { return  numclipos; }
            set {  numclipos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONSELHO
        /// Comentário: 
        /// </summary>
        private string numconselho;
        [XmlElement(ElementName = "NUMCONSELHO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numconselho
        {
            get { return  numconselho; }
            set {  numconselho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDEP
        /// Comentário: 
        /// </summary>
        private decimal numdep;
        [XmlElement(ElementName = "NUMDEP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Numdep
        {
            get { return  numdep; }
            set {  numdep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDEPENDENTES
        /// Comentário: Número de dependentes.
        /// </summary>
        private decimal numdependentes;
        [XmlElement(ElementName = "NUMDEPENDENTES", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Numdependentes
        {
            get { return  numdependentes; }
            set {  numdependentes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDVAGENCIA
        /// Comentário: 
        /// </summary>
        private string numdvagencia;
        [XmlElement(ElementName = "NUMDVAGENCIA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Numdvagencia
        {
            get { return  numdvagencia; }
            set {  numdvagencia = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDVAGENCIAPOUP
        /// Comentário: 
        /// </summary>
        private string numdvagenciapoup;
        [XmlElement(ElementName = "NUMDVAGENCIAPOUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Numdvagenciapoup
        {
            get { return  numdvagenciapoup; }
            set {  numdvagenciapoup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDVCCORRENTE
        /// Comentário: 
        /// </summary>
        private string numdvccorrente;
        [XmlElement(ElementName = "NUMDVCCORRENTE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numdvccorrente
        {
            get { return  numdvccorrente; }
            set {  numdvccorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDVCCORRENTEPOUP
        /// Comentário: 
        /// </summary>
        private string numdvccorrentepoup;
        [XmlElement(ElementName = "NUMDVCCORRENTEPOUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Numdvccorrentepoup
        {
            get { return  numdvccorrentepoup; }
            set {  numdvccorrentepoup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMFINAL
        /// Comentário: Nro do formulário da nf final
        /// </summary>
        private decimal numformfinal;
        [XmlElement(ElementName = "NUMFORMFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numformfinal
        {
            get { return  numformfinal; }
            set {  numformfinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMINICIAL
        /// Comentário: Nro do formulário da nf inicial
        /// </summary>
        private decimal numforminicial;
        [XmlElement(ElementName = "NUMFORMINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numforminicial
        {
            get { return  numforminicial; }
            set {  numforminicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTABLOCO1
        /// Comentário: 
        /// </summary>
        private string numnotabloco1;
        [XmlElement(ElementName = "NUMNOTABLOCO1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Numnotabloco1
        {
            get { return  numnotabloco1; }
            set {  numnotabloco1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPEDECF
        /// Comentário: 
        /// </summary>
        private decimal numpedecf;
        [XmlElement(ElementName = "NUMPEDECF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numpedecf
        {
            get { return  numpedecf; }
            set {  numpedecf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSELOFINAL
        /// Comentário: Nro do selo final
        /// </summary>
        private string numselofinal;
        [XmlElement(ElementName = "NUMSELOFINAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numselofinal
        {
            get { return  numselofinal; }
            set {  numselofinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSELOINICIAL
        /// Comentário: Nro do selo inicial
        /// </summary>
        private string numseloinicial;
        [XmlElement(ElementName = "NUMSELOINICIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Numseloinicial
        {
            get { return  numseloinicial; }
            set {  numseloinicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP
        /// Comentário: 
        /// </summary>
        private decimal numserieequip;
        [XmlElement(ElementName = "NUMSERIEEQUIP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numserieequip
        {
            get { return  numserieequip; }
            set {  numserieequip = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSERIEEQUIP2
        /// Comentário: 
        /// </summary>
        private string numserieequip2;
        [XmlElement(ElementName = "NUMSERIEEQUIP2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numserieequip2
        {
            get { return  numserieequip2; }
            set {  numserieequip2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSBLOQ
        /// Comentário: 
        /// </summary>
        private string obsbloq;
        [XmlElement(ElementName = "OBSBLOQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Obsbloq
        {
            get { return  obsbloq; }
            set {  obsbloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSFORCAVENDAS1
        /// Comentário: Observações referente ao Palm em poder do RCA
        /// </summary>
        private string obsforcavendas1;
        [XmlElement(ElementName = "OBSFORCAVENDAS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsforcavendas1
        {
            get { return  obsforcavendas1; }
            set {  obsforcavendas1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSFORCAVENDAS2
        /// Comentário: Observações referente ao Palm em poder do RCA
        /// </summary>
        private string obsforcavendas2;
        [XmlElement(ElementName = "OBSFORCAVENDAS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsforcavendas2
        {
            get { return  obsforcavendas2; }
            set {  obsforcavendas2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSFORCAVENDAS3
        /// Comentário: Observações referente ao Palm em poder do RCA
        /// </summary>
        private string obsforcavendas3;
        [XmlElement(ElementName = "OBSFORCAVENDAS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsforcavendas3
        {
            get { return  obsforcavendas3; }
            set {  obsforcavendas3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBSFORCAVENDAS4
        /// Comentário: Observações referente ao Palm em poder do RCA
        /// </summary>
        private string obsforcavendas4;
        [XmlElement(ElementName = "OBSFORCAVENDAS4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obsforcavendas4
        {
            get { return  obsforcavendas4; }
            set {  obsforcavendas4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS1
        /// Comentário: 
        /// </summary>
        private string obs1;
        [XmlElement(ElementName = "OBS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs1
        {
            get { return  obs1; }
            set {  obs1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS2
        /// Comentário: 
        /// </summary>
        private string obs2;
        [XmlElement(ElementName = "OBS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Obs2
        {
            get { return  obs2; }
            set {  obs2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESCIMOVENDA
        /// Comentário: 
        /// </summary>
        private decimal percacrescimovenda;
        [XmlElement(ElementName = "PERCACRESCIMOVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percacrescimovenda
        {
            get { return  percacrescimovenda; }
            set {  percacrescimovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCACRESFV
        /// Comentário: 
        /// </summary>
        private decimal percacresfv;
        [XmlElement(ElementName = "PERCACRESFV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percacresfv
        {
            get { return  percacresfv; }
            set {  percacresfv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOFINSNFSERVICO
        /// Comentário: Percentual de COFINS.
        /// </summary>
        private decimal perccofinsnfservico;
        [XmlElement(ElementName = "PERCCOFINSNFSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Perccofinsnfservico
        {
            get { return  perccofinsnfservico; }
            set {  perccofinsnfservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCSRF
        /// Comentário: Percentual de CRSF.
        /// </summary>
        private decimal perccsrf;
        [XmlElement(ElementName = "PERCCSRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perccsrf
        {
            get { return  perccsrf; }
            set {  perccsrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENT
        /// Comentário: 
        /// </summary>
        private decimal percent;
        [XmlElement(ElementName = "PERCENT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percent
        {
            get { return  percent; }
            set {  percent = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENT2
        /// Comentário: 
        /// </summary>
        private decimal percent2;
        [XmlElement(ElementName = "PERCENT2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percent2
        {
            get { return  percent2; }
            set {  percent2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCINSS
        /// Comentário: Percentual de Inss.
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
        /// Propriedade referente ao campo: PERCIRRF
        /// Comentário: Percentual de IRRF.
        /// </summary>
        private decimal percirrf;
        [XmlElement(ElementName = "PERCIRRF", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percirrf
        {
            get { return  percirrf; }
            set {  percirrf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCISS
        /// Comentário: Percentual de ISS.
        /// </summary>
        private decimal perciss;
        [XmlElement(ElementName = "PERCISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Perciss
        {
            get { return  perciss; }
            set {  perciss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCMETADEPTO
        /// Comentário: 
        /// </summary>
        private decimal percmetadepto;
        [XmlElement(ElementName = "PERCMETADEPTO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Percmetadepto
        {
            get { return  percmetadepto; }
            set {  percmetadepto = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMMETA
        /// Comentário: Indica o percentual de comissão por meta. 
        /// </summary>
        private decimal percommeta;
        [XmlElement(ElementName = "PERCOMMETA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Percommeta
        {
            get { return  percommeta; }
            set {  percommeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCPISNFSERVICO
        /// Comentário: Percentual de PIS.
        /// </summary>
        private decimal percpisnfservico;
        [XmlElement(ElementName = "PERCPISNFSERVICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Percpisnfservico
        {
            get { return  percpisnfservico; }
            set {  percpisnfservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERDESCMAX
        /// Comentário: 
        /// </summary>
        private decimal perdescmax;
        [XmlElement(ElementName = "PERDESCMAX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Perdescmax
        {
            get { return  perdescmax; }
            set {  perdescmax = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMAXVENDA
        /// Comentário: . 
        /// </summary>
        private decimal permaxvenda;
        [XmlElement(ElementName = "PERMAXVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Permaxvenda
        {
            get { return  permaxvenda; }
            set {  permaxvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMETA
        /// Comentário: 
        /// </summary>
        private decimal permeta;
        [XmlElement(ElementName = "PERMETA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Permeta
        {
            get { return  permeta; }
            set {  permeta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMETAMETRO
        /// Comentário: 
        /// </summary>
        private decimal permetametro;
        [XmlElement(ElementName = "PERMETAMETRO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Permetametro
        {
            get { return  permetametro; }
            set {  permetametro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERMITEADIANTCOMISSAO
        /// Comentário: Indica se o RCA poderá receber adiantamento de comissão, através da rotina 1266. 
        /// </summary>
        private string permiteadiantcomissao;
        [XmlElement(ElementName = "PERMITEADIANTCOMISSAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Permiteadiantcomissao
        {
            get { return  permiteadiantcomissao; }
            set {  permiteadiantcomissao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRACA1
        /// Comentário: 
        /// </summary>
        private string praca1;
        [XmlElement(ElementName = "PRACA1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Praca1
        {
            get { return  praca1; }
            set {  praca1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRACA2
        /// Comentário: 
        /// </summary>
        private string praca2;
        [XmlElement(ElementName = "PRACA2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,80)]
        public string Praca2
        {
            get { return  praca2; }
            set {  praca2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXCODCLIPALM
        /// Comentário: 
        /// </summary>
        private decimal proxcodclipalm;
        [XmlElement(ElementName = "PROXCODCLIPALM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Proxcodclipalm
        {
            get { return  proxcodclipalm; }
            set {  proxcodclipalm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMFORM
        /// Comentário: Próximo número do formulário
        /// </summary>
        private decimal proxnumform;
        [XmlElement(ElementName = "PROXNUMFORM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumform
        {
            get { return  proxnumform; }
            set {  proxnumform = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPED
        /// Comentário: 
        /// </summary>
        private decimal proxnumped;
        [XmlElement(ElementName = "PROXNUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,14)]
        public decimal Proxnumped
        {
            get { return  proxnumped; }
            set {  proxnumped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPEDFORCA
        /// Comentário: 
        /// </summary>
        private decimal proxnumpedforca;
        [XmlElement(ElementName = "PROXNUMPEDFORCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumpedforca
        {
            get { return  proxnumpedforca; }
            set {  proxnumpedforca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMPEDWEB
        /// Comentário: 
        /// </summary>
        private decimal proxnumpedweb;
        [XmlElement(ElementName = "PROXNUMPEDWEB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumpedweb
        {
            get { return  proxnumpedweb; }
            set {  proxnumpedweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXNUMSELO
        /// Comentário: Próximo número do selo
        /// </summary>
        private decimal proxnumselo;
        [XmlElement(ElementName = "PROXNUMSELO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Proxnumselo
        {
            get { return  proxnumselo; }
            set {  proxnumselo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTITENSPEDPREV
        /// Comentário: 
        /// </summary>
        private decimal qtitenspedprev;
        [XmlElement(ElementName = "QTITENSPEDPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtitenspedprev
        {
            get { return  qtitenspedprev; }
            set {  qtitenspedprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPEDPREV
        /// Comentário: 
        /// </summary>
        private decimal qtpedprev;
        [XmlElement(ElementName = "QTPEDPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Qtpedprev
        {
            get { return  qtpedprev; }
            set {  qtpedprev = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ROTAMASTERFOODS
        /// Comentário: 
        /// </summary>
        private string rotamasterfoods;
        [XmlElement(ElementName = "ROTAMASTERFOODS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Rotamasterfoods
        {
            get { return  rotamasterfoods; }
            set {  rotamasterfoods = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHA
        /// Comentário: 
        /// </summary>
        private string senha;
        [XmlElement(ElementName = "SENHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Senha
        {
            get { return  senha; }
            set {  senha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHADIALUP
        /// Comentário: 
        /// </summary>
        private string senhadialup;
        [XmlElement(ElementName = "SENHADIALUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public string Senhadialup
        {
            get { return  senhadialup; }
            set {  senhadialup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHAFTP
        /// Comentário: 
        /// </summary>
        private string senhaftp;
        [XmlElement(ElementName = "SENHAFTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Senhaftp
        {
            get { return  senhaftp; }
            set {  senhaftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHALOGIN
        /// Comentário: 
        /// </summary>
        private string senhalogin;
        [XmlElement(ElementName = "SENHALOGIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Senhalogin
        {
            get { return  senhalogin; }
            set {  senhalogin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHAPOP
        /// Comentário: 
        /// </summary>
        private string senhapop;
        [XmlElement(ElementName = "SENHAPOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Senhapop
        {
            get { return  senhapop; }
            set {  senhapop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIENF
        /// Comentário: Série da Nota Fiscal
        /// </summary>
        private string serienf;
        [XmlElement(ElementName = "SERIENF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serienf
        {
            get { return  serienf; }
            set {  serienf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERVFTP
        /// Comentário: 
        /// </summary>
        private string servftp;
        [XmlElement(ElementName = "SERVFTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Servftp
        {
            get { return  servftp; }
            set {  servftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERVPOP
        /// Comentário: 
        /// </summary>
        private string servpop;
        [XmlElement(ElementName = "SERVPOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Servpop
        {
            get { return  servpop; }
            set {  servpop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERVSMTP
        /// Comentário: 
        /// </summary>
        private string servsmtp;
        [XmlElement(ElementName = "SERVSMTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Servsmtp
        {
            get { return  servsmtp; }
            set {  servsmtp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SIMPLESNACIONAL
        /// Comentário: Optante pelo regime de impostos simples nacional
        /// </summary>
        private string simplesnacional;
        [XmlElement(ElementName = "SIMPLESNACIONAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Simplesnacional
        {
            get { return  simplesnacional; }
            set {  simplesnacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE1
        /// Comentário: 
        /// </summary>
        private string telefone1;
        [XmlElement(ElementName = "TELEFONE1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telefone1
        {
            get { return  telefone1; }
            set {  telefone1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELEFONE2
        /// Comentário: 
        /// </summary>
        private string telefone2;
        [XmlElement(ElementName = "TELEFONE2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,13)]
        public string Telefone2
        {
            get { return  telefone2; }
            set {  telefone2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TELPROVEDOR
        /// Comentário: 
        /// </summary>
        private string telprovedor;
        [XmlElement(ElementName = "TELPROVEDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Telprovedor
        {
            get { return  telprovedor; }
            set {  telprovedor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOCOMISSAO
        /// Comentário: 
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
        /// Propriedade referente ao campo: TIPOFIRMA
        /// Comentário: 
        /// </summary>
        private string tipofirma;
        [XmlElement(ElementName = "TIPOFIRMA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipofirma
        {
            get { return  tipofirma; }
            set {  tipofirma = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPESSOA
        /// Comentário: Indica o tipo do RCA: Pessoa Física ou Pessoa Jurídica. 
        /// </summary>
        private string tipopessoa;
        [XmlElement(ElementName = "TIPOPESSOA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipopessoa
        {
            get { return  tipopessoa; }
            set {  tipopessoa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVEND
        /// Comentário: 
        /// </summary>
        private string tipovend;
        [XmlElement(ElementName = "TIPOVEND", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipovend
        {
            get { return  tipovend; }
            set {  tipovend = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ULTNUMPED
        /// Comentário: 
        /// </summary>
        private decimal ultnumped;
        [XmlElement(ElementName = "ULTNUMPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Ultnumped
        {
            get { return  ultnumped; }
            set {  ultnumped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACOBRANCACARTAO
        /// Comentário: Usa cobrança cartão.
        /// </summary>
        private string usacobrancacartao;
        [XmlElement(ElementName = "USACOBRANCACARTAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacobrancacartao
        {
            get { return  usacobrancacartao; }
            set {  usacobrancacartao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USACONTROLEFORMSELOSEFAZ
        /// Comentário: Utiliza o selo da sefaz
        /// </summary>
        private string usacontroleformselosefaz;
        [XmlElement(ElementName = "USACONTROLEFORMSELOSEFAZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usacontroleformselosefaz
        {
            get { return  usacontroleformselosefaz; }
            set {  usacontroleformselosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USADEBCREDRCA
        /// Comentário: 
        /// </summary>
        private string usadebcredrca;
        [XmlElement(ElementName = "USADEBCREDRCA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usadebcredrca
        {
            get { return  usadebcredrca; }
            set {  usadebcredrca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USARRCAOPERADOR
        /// Comentário: Usar RCA do operador da venda. 
        /// </summary>
        private string usarrcaoperador;
        [XmlElement(ElementName = "USARRCAOPERADOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Usarrcaoperador
        {
            get { return  usarrcaoperador; }
            set {  usarrcaoperador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USURDIALUP
        /// Comentário: 
        /// </summary>
        private string usurdialup;
        [XmlElement(ElementName = "USURDIALUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usurdialup
        {
            get { return  usurdialup; }
            set {  usurdialup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USURDIRFV
        /// Comentário: 
        /// </summary>
        private string usurdirfv;
        [XmlElement(ElementName = "USURDIRFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Usurdirfv
        {
            get { return  usurdirfv; }
            set {  usurdirfv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USURFTP
        /// Comentário: 
        /// </summary>
        private string usurftp;
        [XmlElement(ElementName = "USURFTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usurftp
        {
            get { return  usurftp; }
            set {  usurftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USURLOGIN
        /// Comentário: 
        /// </summary>
        private string usurlogin;
        [XmlElement(ElementName = "USURLOGIN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usurlogin
        {
            get { return  usurlogin; }
            set {  usurlogin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USURPOP
        /// Comentário: 
        /// </summary>
        private string usurpop;
        [XmlElement(ElementName = "USURPOP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Usurpop
        {
            get { return  usurpop; }
            set {  usurpop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZASELOSEFAZ
        /// Comentário: Utiliza controle de formulário sefaz
        /// </summary>
        private string utilizaselosefaz;
        [XmlElement(ElementName = "UTILIZASELOSEFAZ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaselosefaz
        {
            get { return  utilizaselosefaz; }
            set {  utilizaselosefaz = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALIDARACRESCDESCPRECOFIXO
        /// Comentário: Validar acréscimo desconto preço fixo.
        /// </summary>
        private string validaracrescdescprecofixo;
        [XmlElement(ElementName = "VALIDARACRESCDESCPRECOFIXO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Validaracrescdescprecofixo
        {
            get { return  validaracrescdescprecofixo; }
            set {  validaracrescdescprecofixo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VENDEDORQK
        /// Comentário: 
        /// </summary>
        private string vendedorqk;
        [XmlElement(ElementName = "VENDEDORQK", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Vendedorqk
        {
            get { return  vendedorqk; }
            set {  vendedorqk = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VISUALIZARPRODDEPTOSEC
        /// Comentário: Visualizar produtos do departamento/secão
        /// </summary>
        private string visualizarproddeptosec;
        [XmlElement(ElementName = "VISUALIZARPRODDEPTOSEC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Visualizarproddeptosec
        {
            get { return  visualizarproddeptosec; }
            set {  visualizarproddeptosec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLCORRENTE
        /// Comentário: 
        /// </summary>
        private decimal vlcorrente;
        [XmlElement(ElementName = "VLCORRENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vlcorrente
        {
            get { return  vlcorrente; }
            set {  vlcorrente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLLIMCRED
        /// Comentário: 
        /// </summary>
        private decimal vllimcred;
        [XmlElement(ElementName = "VLLIMCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Vllimcred
        {
            get { return  vllimcred; }
            set {  vllimcred = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLMAXTROCA
        /// Comentário: Indica o valor máximo para troca.
        /// </summary>
        private decimal vlmaxtroca;
        [XmlElement(ElementName = "VLMAXTROCA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Vlmaxtroca
        {
            get { return  vlmaxtroca; }
            set {  vlmaxtroca = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAMINPED
        /// Comentário: 
        /// </summary>
        private decimal vlvendaminped;
        [XmlElement(ElementName = "VLVENDAMINPED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvendaminped
        {
            get { return  vlvendaminped; }
            set {  vlvendaminped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLVENDAPREV
        /// Comentário: 
        /// </summary>
        private decimal vlvendaprev;
        [XmlElement(ElementName = "VLVENDAPREV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,12)]
        public decimal Vlvendaprev
        {
            get { return  vlvendaprev; }
            set {  vlvendaprev = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCUsuari()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCUSUARI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCUsuari> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCUsuari>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCUsuari> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCUsuari>(where);
        }

        #endregion
    }
}
