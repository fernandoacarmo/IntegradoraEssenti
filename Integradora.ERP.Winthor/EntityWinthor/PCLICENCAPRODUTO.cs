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
    /// Classe referente a tabela PCLicencaproduto
    /// </summary>
    [XmlType("PCLICENCAPRODUTO")]
    public class PCLicencaproduto : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ACESSOTOTAL
        /// Comentário: Se esta licença permite acesso a qualquer módulo
        /// </summary>
        private string acessototal;
        [XmlElement(ElementName = "ACESSOTOTAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Acessototal
        {
            get { return  acessototal; }
            set {  acessototal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODPERFIL
        /// Comentário: Código do perfil
        /// </summary>
        private decimal codperfil;
        [XmlElement(ElementName = "CODPERFIL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codperfil
        {
            get { return  codperfil; }
            set {  codperfil = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFINAL
        /// Comentário: Data final permitido para o acesso
        /// </summary>
        private DateTime? datafinal;
        [XmlElement(ElementName = "DATAFINAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datafinal
        {
            get { return  datafinal; }
            set {  datafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIAL
        /// Comentário: Data inícial permitido para o acesso
        /// </summary>
        private DateTime? datainicial;
        [XmlElement(ElementName = "DATAINICIAL", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Datainicial
        {
            get { return  datainicial; }
            set {  datainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMAVALIDACAO
        /// Comentário: Forma que será validado
        /// </summary>
        private decimal formavalidacao;
        [XmlElement(ElementName = "FORMAVALIDACAO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public decimal Formavalidacao
        {
            get { return  formavalidacao; }
            set {  formavalidacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICADOR
        /// Comentário: Identificador permitido
        /// </summary>
        private string identificador;
        [XmlElement(ElementName = "IDENTIFICADOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Identificador
        {
            get { return  identificador; }
            set {  identificador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LICENCAID
        /// Comentário: Identificador da licença
        /// </summary>
        private string licencaid;
        [XmlElement(ElementName = "LICENCAID", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,100)]
        public string Licencaid
        {
            get { return  licencaid; }
            set {  licencaid = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ORDEM
        /// Comentário: Ordem do registro no cadastro
        /// </summary>
        private decimal ordem;
        [XmlElement(ElementName = "ORDEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Ordem
        {
            get { return  ordem; }
            set {  ordem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TOTALUSUARIO
        /// Comentário: Quantidade máxima de usuário conectados ao mesmo tempo
        /// </summary>
        private decimal totalusuario;
        [XmlElement(ElementName = "TOTALUSUARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,5)]
        public decimal Totalusuario
        {
            get { return  totalusuario; }
            set {  totalusuario = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLicencaproduto()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLICENCAPRODUTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLicencaproduto> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLicencaproduto>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLicencaproduto> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLicencaproduto>(where);
        }

        #endregion
    }
}
