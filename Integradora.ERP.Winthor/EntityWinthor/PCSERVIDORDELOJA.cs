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
    /// Classe referente a tabela PCServidordeloja
    /// </summary>
    [XmlType("PCSERVIDORDELOJA")]
    public class PCServidordeloja : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial.
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
        /// Propriedade referente ao campo: ENDERECO
        /// Comentário: Endereço do banco de dados central.
        /// </summary>
        private string endereco;
        [XmlElement(ElementName = "ENDERECO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Endereco
        {
            get { return  endereco; }
            set {  endereco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRCAIXASBLOQUEADOS
        /// Comentário: 
        /// </summary>
        private string exibircaixasbloqueados;
        [XmlElement(ElementName = "EXIBIRCAIXASBLOQUEADOS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibircaixasbloqueados
        {
            get { return  exibircaixasbloqueados; }
            set {  exibircaixasbloqueados = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EXIBIRCAIXASMONITORAMENTO
        /// Comentário: Indica se exibe ou não os caixas da filial no monitoramentos de caixas.
        /// </summary>
        private string exibircaixasmonitoramento;
        [XmlElement(ElementName = "EXIBIRCAIXASMONITORAMENTO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Exibircaixasmonitoramento
        {
            get { return  exibircaixasmonitoramento; }
            set {  exibircaixasmonitoramento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEDOSERVICO
        /// Comentário: Nome do serviço do banco de dados central.
        /// </summary>
        private string nomedoservico;
        [XmlElement(ElementName = "NOMEDOSERVICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Nomedoservico
        {
            get { return  nomedoservico; }
            set {  nomedoservico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTUALCRITICO
        /// Comentário: Percentual de registros não recebidos que indica que o caixa está em estado crítico ou não.
        /// </summary>
        private decimal percentualcritico;
        [XmlElement(ElementName = "PERCENTUALCRITICO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public decimal Percentualcritico
        {
            get { return  percentualcritico; }
            set {  percentualcritico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SENHABANCO
        /// Comentário: Senha do banco de dados central.
        /// </summary>
        private string senhabanco;
        [XmlElement(ElementName = "SENHABANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Senhabanco
        {
            get { return  senhabanco; }
            set {  senhabanco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPODESERVIDOR
        /// Comentário: Indica o tipo de servidor para a filial.
        /// </summary>
        private string tipodeservidor;
        [XmlElement(ElementName = "TIPODESERVIDOR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipodeservidor
        {
            get { return  tipodeservidor; }
            set {  tipodeservidor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: USUARIOBANCO
        /// Comentário: Usuário do banco de dados central.
        /// </summary>
        private string usuariobanco;
        [XmlElement(ElementName = "USUARIOBANCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
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
        public PCServidordeloja()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCSERVIDORDELOJA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCServidordeloja> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCServidordeloja>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCServidordeloja> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCServidordeloja>(where);
        }

        #endregion
    }
}
