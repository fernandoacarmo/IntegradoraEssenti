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
    /// Classe referente a tabela PCPcpidia
    /// </summary>
    [XmlType("PCPCPIDIA")]
    public class PCPcpidia : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMOP
        /// Comentário: 
        /// </summary>
        private decimal numop;
        [XmlElement(ElementName = "NUMOP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numop
        {
            get { return  numop; }
            set {  numop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPCP
        /// Comentário: 
        /// </summary>
        private decimal numpcp;
        [XmlElement(ElementName = "NUMPCP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numpcp
        {
            get { return  numpcp; }
            set {  numpcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSUBOP
        /// Comentário: 
        /// </summary>
        private decimal numsubop;
        [XmlElement(ElementName = "NUMSUBOP", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Numsubop
        {
            get { return  numsubop; }
            set {  numsubop = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: POSICAO
        /// Comentário: 
        /// </summary>
        private string posicao;
        [XmlElement(ElementName = "POSICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Posicao
        {
            get { return  posicao; }
            set {  posicao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIR
        /// Comentário: 
        /// </summary>
        private decimal qtproduzir;
        [XmlElement(ElementName = "QTPRODUZIR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtproduzir
        {
            get { return  qtproduzir; }
            set {  qtproduzir = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTPRODUZIRORIG
        /// Comentário: 
        /// </summary>
        private decimal qtproduzirorig;
        [XmlElement(ElementName = "QTPRODUZIRORIG", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtproduzirorig
        {
            get { return  qtproduzirorig; }
            set {  qtproduzirorig = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCPcpidia()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCPCPIDIA";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCPcpidia> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCPcpidia>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCPcpidia> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCPcpidia>(where);
        }

        #endregion
    }
}
