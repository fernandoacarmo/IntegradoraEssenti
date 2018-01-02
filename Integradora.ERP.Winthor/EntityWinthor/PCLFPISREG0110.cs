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
    /// Classe referente a tabela PCLfpisreg0110
    /// </summary>
    [XmlType("PCLFPISREG0110")]
    public class PCLfpisreg0110 : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Código da Filial.
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
        /// Propriedade referente ao campo: CODINCTRIB
        /// Comentário: Código indicador da incidência tributária no período.
        /// </summary>
        private decimal codinctrib;
        [XmlElement(ElementName = "CODINCTRIB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Codinctrib
        {
            get { return  codinctrib; }
            set {  codinctrib = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTIPOCONT
        /// Comentário: Código indicador do Tipo de Contribuição Apurada.
        /// </summary>
        private decimal codtipocont;
        [XmlElement(ElementName = "CODTIPOCONT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Codtipocont
        {
            get { return  codtipocont; }
            set {  codtipocont = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAFIM
        /// Comentário: Data Final do Período Selecionado.
        /// </summary>
        private DateTime? datafim;
        [XmlElement(ElementName = "DATAFIM", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Datafim
        {
            get { return  datafim; }
            set {  datafim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAINI
        /// Comentário: Data Inicial do Período Selecionado.
        /// </summary>
        private DateTime? dataini;
        [XmlElement(ElementName = "DATAINI", DataType = "DATE", IsNullable = false)]
        [DataObjectField(true,false,false,7)]
        public DateTime? Dataini
        {
            get { return  dataini; }
            set {  dataini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDAPROCRED
        /// Comentário: Código indicador de método de apropriação de créditos comuns.
        /// </summary>
        private decimal indaprocred;
        [XmlElement(ElementName = "INDAPROCRED", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Indaprocred
        {
            get { return  indaprocred; }
            set {  indaprocred = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLfpisreg0110()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLFPISREG0110";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLfpisreg0110> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLfpisreg0110>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLfpisreg0110> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLfpisreg0110>(where);
        }

        #endregion
    }
}
