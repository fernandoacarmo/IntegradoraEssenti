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
    /// Classe referente a tabela PCOperadoracartao
    /// </summary>
    [XmlType("PCOPERADORACARTAO")]
    public class PCOperadoracartao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODBANDEIRA
        /// Comentário: Codigo da Bandeira.
        /// </summary>
        private decimal codbandeira;
        [XmlElement(ElementName = "CODBANDEIRA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codbandeira
        {
            get { return  codbandeira; }
            set {  codbandeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: Indica o código do cliente.
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
        /// Propriedade referente ao campo: CODIGO
        /// Comentário: Campo para armazenar o código da operadora de cartão.
        /// </summary>
        private string codigo;
        [XmlElement(ElementName = "CODIGO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public string Codigo
        {
            get { return  codigo; }
            set {  codigo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLAYOUTIMP
        /// Comentário: Campo para armazenar o código do layout a ser utilizado para importação de arquivos para conciliação.
        /// </summary>
        private decimal codlayoutimp;
        [XmlElement(ElementName = "CODLAYOUTIMP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codlayoutimp
        {
            get { return  codlayoutimp; }
            set {  codlayoutimp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODOPERSITEFWEB
        /// Comentário: Indica o código da operadora SITEFWEB.
        /// </summary>
        private string codopersitefweb;
        [XmlElement(ElementName = "CODOPERSITEFWEB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codopersitefweb
        {
            get { return  codopersitefweb; }
            set {  codopersitefweb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMEBANDEIRA
        /// Comentário: Nome da Bandeira.
        /// </summary>
        private string nomebandeira;
        [XmlElement(ElementName = "NOMEBANDEIRA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomebandeira
        {
            get { return  nomebandeira; }
            set {  nomebandeira = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OPERADORA
        /// Comentário: Campo para armazenar o nome da operadora de cartão.
        /// </summary>
        private string operadora;
        [XmlElement(ElementName = "OPERADORA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,100)]
        public string Operadora
        {
            get { return  operadora; }
            set {  operadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Comentário: Campo para armazenar o percentual de desconto referente à comissão da operadora e o aluguel da maquineta.
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBCODIGO
        /// Comentário: Sub Código da Operadora
        /// </summary>
        private string subcodigo;
        [XmlElement(ElementName = "SUBCODIGO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Subcodigo
        {
            get { return  subcodigo; }
            set {  subcodigo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCOperadoracartao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCOPERADORACARTAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCOperadoracartao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCOperadoracartao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCOperadoracartao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCOperadoracartao>(where);
        }

        #endregion
    }
}
