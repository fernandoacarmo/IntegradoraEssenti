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
    /// Classe referente a tabela PCRotinafavorita
    /// </summary>
    [XmlType("PCROTINAFAVORITA")]
    public class PCRotinafavorita : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFAVORITA
        /// Comentário: 
        /// </summary>
        private decimal codfavorita;
        [XmlElement(ElementName = "CODFAVORITA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,22)]
        public decimal Codfavorita
        {
            get { return  codfavorita; }
            set {  codfavorita = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODNIVELSUP
        /// Comentário: 
        /// </summary>
        private decimal codnivelsup;
        [XmlElement(ElementName = "CODNIVELSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,22)]
        public decimal Codnivelsup
        {
            get { return  codnivelsup; }
            set {  codnivelsup = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUARIO
        /// Comentário: 
        /// </summary>
        private decimal codusuario;
        [XmlElement(ElementName = "CODUSUARIO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codusuario
        {
            get { return  codusuario; }
            set {  codusuario = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMENIVEL
        /// Comentário: 
        /// </summary>
        private string nomenivel;
        [XmlElement(ElementName = "NOMENIVEL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,100)]
        public string Nomenivel
        {
            get { return  nomenivel; }
            set {  nomenivel = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCRotinafavorita()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTINAFAVORITA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCRotinafavorita> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRotinafavorita>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCRotinafavorita> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRotinafavorita>(where);
        }

        #endregion
    }
}
