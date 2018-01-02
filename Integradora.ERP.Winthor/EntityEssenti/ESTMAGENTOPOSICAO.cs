using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using Integradora.Database.Oracle;
using Integradora.ERP.Winthor.Inherited;

namespace Integradora.ERP.Winthor.EntityEssenti
{
    /// <summary>
    /// Classe referente a tabela ESTMagentoposicao
    /// </summary>
    [XmlType("ESTMAGENTOPOSICAO")]
    public class ESTMagentoposicao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DTCADASTRO
        /// Comentário: 
        /// </summary>
        private DateTime? dtcadastro;
        [XmlElement(ElementName = "DTCADASTRO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtcadastro
        {
            get { return  dtcadastro; }
            set {  dtcadastro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM
        /// Comentário: 
        /// </summary>
        private string mensagem;
        [XmlElement(ElementName = "MENSAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,250)]
        public string Mensagem
        {
            get { return  mensagem; }
            set {  mensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOTIFICA
        /// Comentário: 
        /// </summary>
        private string notifica;
        [XmlElement(ElementName = "NOTIFICA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,1)]
        public string Notifica
        {
            get { return  notifica; }
            set {  notifica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,1)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: STATUS
        /// Comentário: 
        /// </summary>
        private string status;
        [XmlElement(ElementName = "STATUS", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,25)]
        public string Status
        {
            get { return  status; }
            set {  status = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public ESTMagentoposicao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "ESTMAGENTOPOSICAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<ESTMagentoposicao> Listar(string where)
        {
            Persistencia ba = new Persistencia(ESTMagentoposicao.GetStringConnection());
            return ba.Listar<ESTMagentoposicao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<ESTMagentoposicao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(ESTMagentoposicao.GetStringConnection());
            return ba.Existe<ESTMagentoposicao>(where);
        }

        #endregion
    }
}
