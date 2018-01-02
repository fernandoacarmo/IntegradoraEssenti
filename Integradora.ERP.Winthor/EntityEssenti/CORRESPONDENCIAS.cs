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
    /// Classe referente a tabela Correspondencias
    /// </summary>
    [XmlType("CORRESPONDENCIAS")]
    public class Correspondencias : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CORRESPONDENCIA_ID
        /// Comentário: 
        /// </summary>
        private decimal correspondencia_id;
        [XmlElement(ElementName = "CORRESPONDENCIA_ID", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Correspondencia_Id
        {
            get { return  correspondencia_id; }
            set {  correspondencia_id = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTINATARIO
        /// Comentário: 
        /// </summary>
        private string destinatario;
        [XmlElement(ElementName = "DESTINATARIO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,150)]
        public string Destinatario
        {
            get { return  destinatario; }
            set {  destinatario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENVIO
        /// Comentário: 
        /// </summary>
        private DateTime? dtenvio;
        [XmlElement(ElementName = "DTENVIO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtenvio
        {
            get { return  dtenvio; }
            set {  dtenvio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAO
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusao;
        [XmlElement(ElementName = "DTINCLUSAO", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtinclusao
        {
            get { return  dtinclusao; }
            set {  dtinclusao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EMAIL
        /// Comentário: 
        /// </summary>
        private string email;
        [XmlElement(ElementName = "EMAIL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,150)]
        public string Email
        {
            get { return  email; }
            set {  email = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM
        /// Comentário: 
        /// </summary>
        private string mensagem;
        [XmlElement(ElementName = "MENSAGEM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,3000)]
        public string Mensagem
        {
            get { return  mensagem; }
            set {  mensagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TITULO
        /// Comentário: 
        /// </summary>
        private string titulo;
        [XmlElement(ElementName = "TITULO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,150)]
        public string Titulo
        {
            get { return  titulo; }
            set {  titulo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public Correspondencias()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "CORRESPONDENCIAS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<Correspondencias> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<Correspondencias>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<Correspondencias> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<Correspondencias>(where);
        }

        #endregion
    }
}
