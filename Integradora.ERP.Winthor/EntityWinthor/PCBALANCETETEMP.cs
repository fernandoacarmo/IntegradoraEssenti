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
    /// Classe referente a tabela PCBalancetetemp
    /// </summary>
    [XmlType("PCBALANCETETEMP")]
    public class PCBalancetetemp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCONTA_PC
        /// Comentário: 
        /// </summary>
        private string codconta_pc;
        [XmlElement(ElementName = "CODCONTA_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Codconta_Pc
        {
            get { return  codconta_pc; }
            set {  codconta_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODREDUZIDO_PC
        /// Comentário: 
        /// </summary>
        private string codreduzido_pc;
        [XmlElement(ElementName = "CODREDUZIDO_PC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codreduzido_Pc
        {
            get { return  codreduzido_pc; }
            set {  codreduzido_pc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOANTERIORCR
        /// Comentário: 
        /// </summary>
        private decimal saldoanteriorcr;
        [XmlElement(ElementName = "SALDOANTERIORCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoanteriorcr
        {
            get { return  saldoanteriorcr; }
            set {  saldoanteriorcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOANTERIORDB
        /// Comentário: 
        /// </summary>
        private decimal saldoanteriordb;
        [XmlElement(ElementName = "SALDOANTERIORDB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldoanteriordb
        {
            get { return  saldoanteriordb; }
            set {  saldoanteriordb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOFINALCR
        /// Comentário: 
        /// </summary>
        private decimal saldofinalcr;
        [XmlElement(ElementName = "SALDOFINALCR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldofinalcr
        {
            get { return  saldofinalcr; }
            set {  saldofinalcr = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SALDOFINALDB
        /// Comentário: 
        /// </summary>
        private decimal saldofinaldb;
        [XmlElement(ElementName = "SALDOFINALDB", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Saldofinaldb
        {
            get { return  saldofinaldb; }
            set {  saldofinaldb = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRCREDITOS
        /// Comentário: 
        /// </summary>
        private decimal vlrcreditos;
        [XmlElement(ElementName = "VLRCREDITOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlrcreditos
        {
            get { return  vlrcreditos; }
            set {  vlrcreditos = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLRDEBITOS
        /// Comentário: 
        /// </summary>
        private decimal vlrdebitos;
        [XmlElement(ElementName = "VLRDEBITOS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Vlrdebitos
        {
            get { return  vlrdebitos; }
            set {  vlrdebitos = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCBalancetetemp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCBALANCETETEMP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCBalancetetemp> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCBalancetetemp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCBalancetetemp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCBalancetetemp>(where);
        }

        #endregion
    }
}
