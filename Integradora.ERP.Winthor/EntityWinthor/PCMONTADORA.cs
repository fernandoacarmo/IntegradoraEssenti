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
    /// Classe referente a tabela PCMontadora
    /// </summary>
    [XmlType("PCMONTADORA")]
    public class PCMontadora : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODMAQUINA
        /// Comentário: 
        /// </summary>
        private decimal codmaquina;
        [XmlElement(ElementName = "CODMAQUINA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codmaquina
        {
            get { return  codmaquina; }
            set {  codmaquina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODMONTADORA
        /// Comentário: 
        /// </summary>
        private string codmontadora;
        [XmlElement(ElementName = "CODMONTADORA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,40)]
        public string Codmontadora
        {
            get { return  codmontadora; }
            set {  codmontadora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCMONTADORA
        /// Comentário: 
        /// </summary>
        private string descmontadora;
        [XmlElement(ElementName = "DESCMONTADORA", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,70)]
        public string Descmontadora
        {
            get { return  descmontadora; }
            set {  descmontadora = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMontadora()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMONTADORA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMontadora> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMontadora>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMontadora> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMontadora>(where);
        }

        #endregion
    }
}
