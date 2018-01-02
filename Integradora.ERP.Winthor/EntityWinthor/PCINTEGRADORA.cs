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
    /// Classe referente a tabela PCIntegradora
    /// </summary>
    [XmlType("PCINTEGRADORA")]
    public class PCIntegradora : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: C�digo do Usu�rio
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
        /// Propriedade referente ao campo: CONSIDERACALCGIROMEDIC
        /// Coment�rio: Considera no C�lculo do Giro
        /// </summary>
        private string consideracalcgiromedic;
        [XmlElement(ElementName = "CONSIDERACALCGIROMEDIC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Consideracalcgiromedic
        {
            get { return  consideracalcgiromedic; }
            set {  consideracalcgiromedic = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Coment�rio: Descri��o
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRBACKUP
        /// Coment�rio: Diret�rio onde ser�o gerados os Arquivos de Pedidos importados com sucesso
        /// </summary>
        private string dirbackup;
        [XmlElement(ElementName = "DIRBACKUP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirbackup
        {
            get { return  dirbackup; }
            set {  dirbackup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRBACKUP_FTP
        /// Coment�rio: Diret�rio onde ser�o gerados os Arquivos de Pedidos importados com sucesso no FTP
        /// </summary>
        private string dirbackup_ftp;
        [XmlElement(ElementName = "DIRBACKUP_FTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirbackup_Ftp
        {
            get { return  dirbackup_ftp; }
            set {  dirbackup_ftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRDEVOLUCAO
        /// Coment�rio: Diret�rio de Gera��o dos Arquivos de Devolu��o
        /// </summary>
        private string dirdevolucao;
        [XmlElement(ElementName = "DIRDEVOLUCAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirdevolucao
        {
            get { return  dirdevolucao; }
            set {  dirdevolucao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRDICIONARIO
        /// Coment�rio: Diret�rio de Gera��o dos Dicion�rios
        /// </summary>
        private string dirdicionario;
        [XmlElement(ElementName = "DIRDICIONARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirdicionario
        {
            get { return  dirdicionario; }
            set {  dirdicionario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRERRO
        /// Coment�rio: Diret�rio onde ser�o gerados os Arquivos de Pedido com erros
        /// </summary>
        private string direrro;
        [XmlElement(ElementName = "DIRERRO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Direrro
        {
            get { return  direrro; }
            set {  direrro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRERRO_FTP
        /// Coment�rio: Diret�rio onde ser�o gerados os Arquivos de Pedido com erros no FTP
        /// </summary>
        private string direrro_ftp;
        [XmlElement(ElementName = "DIRERRO_FTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Direrro_Ftp
        {
            get { return  direrro_ftp; }
            set {  direrro_ftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRNOTAFISCAL
        /// Coment�rio: Diret�rio onde ser�o gerados os Arquivos de Espelho de NF
        /// </summary>
        private string dirnotafiscal;
        [XmlElement(ElementName = "DIRNOTAFISCAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirnotafiscal
        {
            get { return  dirnotafiscal; }
            set {  dirnotafiscal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRNOTAFISCAL_FTP
        /// Coment�rio: Diret�rio onde ser�o gerados os Arquivos de Espelho de NF no FTP
        /// </summary>
        private string dirnotafiscal_ftp;
        [XmlElement(ElementName = "DIRNOTAFISCAL_FTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirnotafiscal_Ftp
        {
            get { return  dirnotafiscal_ftp; }
            set {  dirnotafiscal_ftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRPEDIDO
        /// Coment�rio: Diret�rio dos Arquivos de Pedidos
        /// </summary>
        private string dirpedido;
        [XmlElement(ElementName = "DIRPEDIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirpedido
        {
            get { return  dirpedido; }
            set {  dirpedido = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRPEDIDO_FTP
        /// Coment�rio: Diret�rio dos Arquivos de Pedidos no FTP
        /// </summary>
        private string dirpedido_ftp;
        [XmlElement(ElementName = "DIRPEDIDO_FTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirpedido_Ftp
        {
            get { return  dirpedido_ftp; }
            set {  dirpedido_ftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRRETORNO
        /// Coment�rio: Diret�rio onde ser�o gerados os Arquivos de Retorno
        /// </summary>
        private string dirretorno;
        [XmlElement(ElementName = "DIRRETORNO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirretorno
        {
            get { return  dirretorno; }
            set {  dirretorno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRRETORNO_FTP
        /// Coment�rio: Diret�rio onde ser�o gerados os Arquivos de Retorno no FTP
        /// </summary>
        private string dirretorno_ftp;
        [XmlElement(ElementName = "DIRRETORNO_FTP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Dirretorno_Ftp
        {
            get { return  dirretorno_ftp; }
            set {  dirretorno_ftp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXPORTAXMLNFE
        /// Coment�rio: Exporta XML NF-e (S/N).
        /// </summary>
        private string exportaxmlnfe;
        [XmlElement(ElementName = "EXPORTAXMLNFE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exportaxmlnfe
        {
            get { return  exportaxmlnfe; }
            set {  exportaxmlnfe = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GERAPEDBLOQ
        /// Coment�rio: Gera Pedidos com Status Bloqueado
        /// </summary>
        private string gerapedbloq;
        [XmlElement(ElementName = "GERAPEDBLOQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Gerapedbloq
        {
            get { return  gerapedbloq; }
            set {  gerapedbloq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HOST
        /// Coment�rio: Host FTP
        /// </summary>
        private string host;
        [XmlElement(ElementName = "HOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Host
        {
            get { return  host; }
            set {  host = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Coment�rio: C�digo da Integradora
        /// </summary>
        private decimal integradora;
        [XmlElement(ElementName = "INTEGRADORA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Integradora
        {
            get { return  integradora; }
            set {  integradora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LAYOUT
        /// Coment�rio: C�digo do Layout
        /// </summary>
        private decimal layout;
        [XmlElement(ElementName = "LAYOUT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Layout
        {
            get { return  layout; }
            set {  layout = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORIGEMPRECO
        /// Coment�rio: Origem do Pre�o.
        /// </summary>
        private string origempreco;
        [XmlElement(ElementName = "ORIGEMPRECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Origempreco
        {
            get { return  origempreco; }
            set {  origempreco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PASSWORD
        /// Coment�rio: Senha FTP
        /// </summary>
        private string password;
        [XmlElement(ElementName = "PASSWORD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Password
        {
            get { return  password; }
            set {  password = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PORT
        /// Coment�rio: Porta FTP
        /// </summary>
        private decimal port;
        [XmlElement(ElementName = "PORT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Port
        {
            get { return  port; }
            set {  port = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXY_HOST
        /// Coment�rio: Host FTP Proxy
        /// </summary>
        private string proxy_host;
        [XmlElement(ElementName = "PROXY_HOST", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Proxy_Host
        {
            get { return  proxy_host; }
            set {  proxy_host = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXY_PASSWORD
        /// Coment�rio: Senha FTP Proxy
        /// </summary>
        private string proxy_password;
        [XmlElement(ElementName = "PROXY_PASSWORD", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Proxy_Password
        {
            get { return  proxy_password; }
            set {  proxy_password = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXY_PORT
        /// Coment�rio: Porta FTP Proxy
        /// </summary>
        private decimal proxy_port;
        [XmlElement(ElementName = "PROXY_PORT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Proxy_Port
        {
            get { return  proxy_port; }
            set {  proxy_port = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PROXY_USERNAME
        /// Coment�rio: Usu�rio FTP Proxy
        /// </summary>
        private string proxy_username;
        [XmlElement(ElementName = "PROXY_USERNAME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Proxy_Username
        {
            get { return  proxy_username; }
            set {  proxy_username = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQARQRET
        /// Coment�rio: Sequ�ncia de Arquivo de Retorno
        /// </summary>
        private decimal seqarqret;
        [XmlElement(ElementName = "SEQARQRET", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Seqarqret
        {
            get { return  seqarqret; }
            set {  seqarqret = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQVERSAO
        /// Coment�rio: Seq. Controle de Vers�o.
        /// </summary>
        private decimal seqversao;
        [XmlElement(ElementName = "SEQVERSAO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seqversao
        {
            get { return  seqversao; }
            set {  seqversao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Coment�rio: Situa��o (A - Ativo; I - Inativo)
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
        /// Propriedade referente ao campo: TIPOCAPTACAOPED
        /// Coment�rio: Tipo de Capta��o dos Pedidos
        /// </summary>
        private string tipocaptacaoped;
        [XmlElement(ElementName = "TIPOCAPTACAOPED", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipocaptacaoped
        {
            get { return  tipocaptacaoped; }
            set {  tipocaptacaoped = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOFV
        /// Coment�rio: Tipo de For�a de Vendas (FV - Palm; OL - Operador Log�stico; PE - Pedido Eletr�nico)
        /// </summary>
        private string tipofv;
        [XmlElement(ElementName = "TIPOFV", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipofv
        {
            get { return  tipofv; }
            set {  tipofv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOSELECAOCONDICAO
        /// Coment�rio: Tipo de Sele��o da Condi��o de Venda (A - Apontador da Condi��o; P - Prazo; C - Condi��o do Cliente)
        /// </summary>
        private string tiposelecaocondicao;
        [XmlElement(ElementName = "TIPOSELECAOCONDICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tiposelecaocondicao
        {
            get { return  tiposelecaocondicao; }
            set {  tiposelecaocondicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDADESCEDIMAIOR
        /// Coment�rio: Tipo de Valida��o do Desconto EDI a Maior (S - Sem Valida��o;   C - Conceder Desc. Condi��o; E - Conceder Desc. EDI; R - Rejeitar Item)
        /// </summary>
        private string tipovalidadescedimaior;
        [XmlElement(ElementName = "TIPOVALIDADESCEDIMAIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidadescedimaior
        {
            get { return  tipovalidadescedimaior; }
            set {  tipovalidadescedimaior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDADESCEDIMENOR
        /// Coment�rio: Tipo de Valida��o do Desconto EDI a Menor (S - Sem Valida��o;   C - Conceder Desc. Condi��o; E - Conceder Desc. EDI; R - Rejeitar Item)
        /// </summary>
        private string tipovalidadescedimenor;
        [XmlElement(ElementName = "TIPOVALIDADESCEDIMENOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidadescedimenor
        {
            get { return  tipovalidadescedimenor; }
            set {  tipovalidadescedimenor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDAPRECOEDIMAIOR
        /// Coment�rio: Tipo de Valida��o doPre�o EDI a Maior (S - Sem Valida��o;   C - Conceder Desc. Condi��o; E - Conceder Desc. EDI; R - Rejeitar Item)
        /// </summary>
        private string tipovalidaprecoedimaior;
        [XmlElement(ElementName = "TIPOVALIDAPRECOEDIMAIOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidaprecoedimaior
        {
            get { return  tipovalidaprecoedimaior; }
            set {  tipovalidaprecoedimaior = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOVALIDAPRECOEDIMENOR
        /// Coment�rio: Tipo de Valida��o do Pre�o EDI a Menor (S - Sem Valida��o;   C - Conceder Desc. Condi��o; E - Conceder Desc. EDI; R - Rejeitar Item)
        /// </summary>
        private string tipovalidaprecoedimenor;
        [XmlElement(ElementName = "TIPOVALIDAPRECOEDIMENOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipovalidaprecoedimenor
        {
            get { return  tipovalidaprecoedimenor; }
            set {  tipovalidaprecoedimenor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USERNAME
        /// Coment�rio: Usu�rio FTP
        /// </summary>
        private string username;
        [XmlElement(ElementName = "USERNAME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Username
        {
            get { return  username; }
            set {  username = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: UTILIZAREGRADESC100
        /// Coment�rio: Identificador se utiliza desconto 100% (S - Sim; N - N�o)
        /// </summary>
        private string utilizaregradesc100;
        [XmlElement(ElementName = "UTILIZAREGRADESC100", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Utilizaregradesc100
        {
            get { return  utilizaregradesc100; }
            set {  utilizaregradesc100 = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCIntegradora()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINTEGRADORA";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCIntegradora> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIntegradora>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCIntegradora> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIntegradora>(where);
        }

        #endregion
    }
}
