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
    /// Classe referente a tabela PCEncerramento
    /// </summary>
    [XmlType("PCENCERRAMENTO")]
    public class PCEncerramento : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Comentário: 
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODENCERRAMENTO
        /// Comentário: 
        /// </summary>
        private decimal codencerramento;
        [XmlElement(ElementName = "CODENCERRAMENTO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,38)]
        public decimal Codencerramento
        {
            get { return  codencerramento; }
            set {  codencerramento = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFINAL
        /// Comentário: 
        /// </summary>
        private DateTime? datafinal;
        [XmlElement(ElementName = "DATAFINAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datafinal
        {
            get { return  datafinal; }
            set {  datafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINICIAL
        /// Comentário: 
        /// </summary>
        private DateTime? datainicial;
        [XmlElement(ElementName = "DATAINICIAL", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datainicial
        {
            get { return  datainicial; }
            set {  datainicial = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCEncerramento()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCENCERRAMENTO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCEncerramento> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCEncerramento>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCEncerramento> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCEncerramento>(where);
        }

        #endregion
    }
}
