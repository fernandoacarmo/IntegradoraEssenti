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
    /// Classe referente a tabela PCRiscoacondicionamento
    /// </summary>
    [XmlType("PCRISCOACONDICIONAMENTO")]
    public class PCRiscoacondicionamento : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODONU
        /// Comentário: Indica o código ONU.
        /// </summary>
        private string codonu;
        [XmlElement(ElementName = "CODONU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codonu
        {
            get { return  codonu; }
            set {  codonu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPO
        /// Comentário: 
        /// </summary>
        private string codtipo;
        [XmlElement(ElementName = "CODTIPO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public string Codtipo
        {
            get { return  codtipo; }
            set {  codtipo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPOEMBALAGEM
        /// Comentário: Indica o grupo de embalagem.
        /// </summary>
        private string grupoembalagem;
        [XmlElement(ElementName = "GRUPOEMBALAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Grupoembalagem
        {
            get { return  grupoembalagem; }
            set {  grupoembalagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: GRUPORISCO
        /// Comentário: Indica o grupo de risco.
        /// </summary>
        private string gruporisco;
        [XmlElement(ElementName = "GRUPORISCO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Gruporisco
        {
            get { return  gruporisco; }
            set {  gruporisco = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENSAGEM
        /// Comentário: 
        /// </summary>
        private string mensagem;
        [XmlElement(ElementName = "MENSAGEM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Mensagem
        {
            get { return  mensagem; }
            set {  mensagem = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRiscoacondicionamento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRISCOACONDICIONAMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRiscoacondicionamento> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRiscoacondicionamento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRiscoacondicionamento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRiscoacondicionamento>(where);
        }

        #endregion
    }
}
