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
    /// Classe referente a tabela PCLimitecompradiaent
    /// </summary>
    [XmlType("PCLIMITECOMPRADIAENT")]
    public class PCLimitecompradiaent : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da filial
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: Data do Limite
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDELIMITE
        /// Comentário: Qtde do Limite diário
        /// </summary>
        private decimal qtdelimite;
        [XmlElement(ElementName = "QTDELIMITE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtdelimite
        {
            get { return  qtdelimite; }
            set {  qtdelimite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDELIMITEPESO
        /// Comentário: Quantidade limite compra Peso
        /// </summary>
        private decimal qtdelimitepeso;
        [XmlElement(ElementName = "QTDELIMITEPESO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtdelimitepeso
        {
            get { return  qtdelimitepeso; }
            set {  qtdelimitepeso = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDELIMITEVOLUME
        /// Comentário: Quantidade limite compra volume
        /// </summary>
        private decimal qtdelimitevolume;
        [XmlElement(ElementName = "QTDELIMITEVOLUME", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Qtdelimitevolume
        {
            get { return  qtdelimitevolume; }
            set {  qtdelimitevolume = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLimitecompradiaent()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLIMITECOMPRADIAENT";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLimitecompradiaent> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLimitecompradiaent>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLimitecompradiaent> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLimitecompradiaent>(where);
        }

        #endregion
    }
}
