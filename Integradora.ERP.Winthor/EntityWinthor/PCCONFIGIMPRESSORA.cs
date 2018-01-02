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
    /// Classe referente a tabela PCConfigimpressora
    /// </summary>
    [XmlType("PCCONFIGIMPRESSORA")]
    public class PCConfigimpressora : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: NOMEIMPRESSORA
        /// Comentário: 
        /// </summary>
        private string nomeimpressora;
        [XmlElement(ElementName = "NOMEIMPRESSORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,200)]
        public string Nomeimpressora
        {
            get { return  nomeimpressora; }
            set {  nomeimpressora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RUA
        /// Comentário: 
        /// </summary>
        private decimal rua;
        [XmlElement(ElementName = "RUA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Rua
        {
            get { return  rua; }
            set {  rua = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCConfigimpressora()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCONFIGIMPRESSORA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCConfigimpressora> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCConfigimpressora>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCConfigimpressora> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCConfigimpressora>(where);
        }

        #endregion
    }
}
