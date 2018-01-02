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
    /// Classe referente a tabela PCCaixasfaturamentoautoserv
    /// </summary>
    [XmlType("PCCAIXASFATURAMENTOAUTOSERV")]
    public class PCCaixasfaturamentoautoserv : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATIVO
        /// Comentário: Situação do caixa dentro do ambiente de faturamento.
        /// </summary>
        private string ativo;
        [XmlElement(ElementName = "ATIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Ativo
        {
            get { return  ativo; }
            set {  ativo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: Descrição do caixa.
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
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: Endereço do caixa.
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMESERVICOBANCO
        /// Comentário: 
        /// </summary>
        private string nomeservicobanco;
        [XmlElement(ElementName = "NOMESERVICOBANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomeservicobanco
        {
            get { return  nomeservicobanco; }
            set {  nomeservicobanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAIXA
        /// Comentário: Número do caixa.
        /// </summary>
        private decimal numcaixa;
        [XmlElement(ElementName = "NUMCAIXA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numcaixa
        {
            get { return  numcaixa; }
            set {  numcaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHA
        /// Comentário: Senha do banco de dados.
        /// </summary>
        private string senha;
        [XmlElement(ElementName = "SENHA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Senha
        {
            get { return  senha; }
            set {  senha = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHABANCO
        /// Comentário: 
        /// </summary>
        private string senhabanco;
        [XmlElement(ElementName = "SENHABANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Senhabanco
        {
            get { return  senhabanco; }
            set {  senhabanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHAVNC
        /// Comentário: Senha do VNC.
        /// </summary>
        private string senhavnc;
        [XmlElement(ElementName = "SENHAVNC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Senhavnc
        {
            get { return  senhavnc; }
            set {  senhavnc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIO
        /// Comentário: Usuário do banco de dados.
        /// </summary>
        private string usuario;
        [XmlElement(ElementName = "USUARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Usuario
        {
            get { return  usuario; }
            set {  usuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOBANCO
        /// Comentário: 
        /// </summary>
        private string usuariobanco;
        [XmlElement(ElementName = "USUARIOBANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Usuariobanco
        {
            get { return  usuariobanco; }
            set {  usuariobanco = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCaixasfaturamentoautoserv()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCAIXASFATURAMENTOAUTOSERV";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCaixasfaturamentoautoserv> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCaixasfaturamentoautoserv>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCaixasfaturamentoautoserv> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCaixasfaturamentoautoserv>(where);
        }

        #endregion
    }
}
