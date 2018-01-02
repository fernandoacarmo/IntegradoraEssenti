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
    /// Classe referente a tabela PCDestsittributipi
    /// </summary>
    [XmlType("PCDESTSITTRIBUTIPI")]
    public class PCDestsittributipi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODSITTRIBIPI
        /// Comentário: Código da Situação Tributária de IPI.
        /// </summary>
        private decimal codsittribipi;
        [XmlElement(ElementName = "CODSITTRIBIPI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Codsittribipi
        {
            get { return  codsittribipi; }
            set {  codsittribipi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESTVALORIPI
        /// Comentário: Destino do Valor do IPI.
        /// </summary>
        private string destvaloripi;
        [XmlElement(ElementName = "DESTVALORIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Destvaloripi
        {
            get { return  destvaloripi; }
            set {  destvaloripi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: FORMVALORIPI
        /// Comentário: Formação do Valor de IPI.
        /// </summary>
        private string formvaloripi;
        [XmlElement(ElementName = "FORMVALORIPI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Formvaloripi
        {
            get { return  formvaloripi; }
            set {  formvaloripi = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDestsittributipi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESTSITTRIBUTIPI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDestsittributipi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDestsittributipi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDestsittributipi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDestsittributipi>(where);
        }

        #endregion
    }
}
