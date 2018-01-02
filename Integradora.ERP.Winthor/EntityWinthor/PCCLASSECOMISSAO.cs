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
    /// Classe referente a tabela PCClassecomissao
    /// </summary>
    [XmlType("PCCLASSECOMISSAO")]
    public class PCClassecomissao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: IDENTIFICADOR
        /// Comentário: Identificador da Classe. 
        /// </summary>
        private string identificador;
        [XmlElement(ElementName = "IDENTIFICADOR", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Identificador
        {
            get { return  identificador; }
            set {  identificador = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMEXT
        /// Comentário: Percentual de Comissão para Vendedor Externo. 
        /// </summary>
        private decimal pcomext;
        [XmlElement(ElementName = "PCOMEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcomext
        {
            get { return  pcomext; }
            set {  pcomext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMINT
        /// Comentário: Percentual de Comissão para Vendedor Interno. 
        /// </summary>
        private decimal pcomint;
        [XmlElement(ElementName = "PCOMINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcomint
        {
            get { return  pcomint; }
            set {  pcomint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PCOMREP
        /// Comentário: Percentual de Comissão para Representante. 
        /// </summary>
        private decimal pcomrep;
        [XmlElement(ElementName = "PCOMREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Pcomrep
        {
            get { return  pcomrep; }
            set {  pcomrep = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCClassecomissao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCLASSECOMISSAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCClassecomissao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCClassecomissao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCClassecomissao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCClassecomissao>(where);
        }

        #endregion
    }
}
