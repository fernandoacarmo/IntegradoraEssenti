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
    /// Classe referente a tabela PCIntegradorafilial
    /// </summary>
    [XmlType("PCINTEGRADORAFILIAL")]
    public class PCIntegradorafilial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIALVAN
        /// Comentário: Código da Filial na VAN
        /// </summary>
        private string codfilialvan;
        [XmlElement(ElementName = "CODFILIALVAN", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codfilialvan
        {
            get { return  codfilialvan; }
            set {  codfilialvan = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIRBACKUP
        /// Comentário: Diretório onde serão gerados os Arquivos de Pedidos importados com sucesso
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
        /// Comentário: Diretório onde serão gerados os Arquivos de Pedidos importados com sucesso no FTP
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
        /// Comentário: Diretório de Geração dos Arquivos de Devolução
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
        /// Propriedade referente ao campo: DIRERRO
        /// Comentário: Diretório onde serão gerados os Arquivos de Pedido com erros
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
        /// Comentário: Diretório onde serão gerados os Arquivos de Pedido com erros no FTP
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
        /// Comentário: Diretório onde serão gerados os Arquivos de Espelho de NF
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
        /// Comentário: Diretório onde serão gerados os Arquivos de Espelho de NF no FTP
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
        /// Comentário: Diretório dos Arquivos de Pedidos
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
        /// Comentário: Diretório dos Arquivos de Pedidos no FTP
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
        /// Comentário: Diretório onde serão gerados os Arquivos de Retorno
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
        /// Comentário: Diretório onde serão gerados os Arquivos de Retorno no FTP
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
        /// Propriedade referente ao campo: HOST
        /// Comentário: Host FTP
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
        /// Propriedade referente ao campo: IDENTIFICADORFILIAL
        /// Comentário: Identificador Filial no Nome do Arquivo
        /// </summary>
        private string identificadorfilial;
        [XmlElement(ElementName = "IDENTIFICADORFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Identificadorfilial
        {
            get { return  identificadorfilial; }
            set {  identificadorfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INTEGRADORA
        /// Comentário: Código da Integradora
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
        /// Propriedade referente ao campo: PASSWORD
        /// Comentário: Senha FTP
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
        /// Comentário: Porta FTP
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
        /// Propriedade referente ao campo: USERNAME
        /// Comentário: Usuário FTP
        /// </summary>
        private string username;
        [XmlElement(ElementName = "USERNAME", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Username
        {
            get { return  username; }
            set {  username = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCIntegradorafilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINTEGRADORAFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCIntegradorafilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCIntegradorafilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCIntegradorafilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCIntegradorafilial>(where);
        }

        #endregion
    }
}
