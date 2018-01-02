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
    /// Classe referente a tabela PCInventdig
    /// </summary>
    [XmlType("PCINVENTDIG")]
    public class PCInventdig : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODPROD
        /// Comentário: 
        /// </summary>
        private decimal codprod;
        [XmlElement(ElementName = "CODPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codprod
        {
            get { return  codprod; }
            set {  codprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CONTAGEM
        /// Comentário: 
        /// </summary>
        private decimal contagem;
        [XmlElement(ElementName = "CONTAGEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,3)]
        public decimal Contagem
        {
            get { return  contagem; }
            set {  contagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
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
        /// Propriedade referente ao campo: NUMTAB
        /// Comentário: 
        /// </summary>
        private decimal numtab;
        [XmlElement(ElementName = "NUMTAB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Numtab
        {
            get { return  numtab; }
            set {  numtab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIGITADA1
        /// Comentário: 
        /// </summary>
        private decimal qtdigitada1;
        [XmlElement(ElementName = "QTDIGITADA1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdigitada1
        {
            get { return  qtdigitada1; }
            set {  qtdigitada1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIGITADA2
        /// Comentário: 
        /// </summary>
        private decimal qtdigitada2;
        [XmlElement(ElementName = "QTDIGITADA2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdigitada2
        {
            get { return  qtdigitada2; }
            set {  qtdigitada2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIGITADA3
        /// Comentário: 
        /// </summary>
        private decimal qtdigitada3;
        [XmlElement(ElementName = "QTDIGITADA3", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdigitada3
        {
            get { return  qtdigitada3; }
            set {  qtdigitada3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTDIGITADA4
        /// Comentário: 
        /// </summary>
        private decimal qtdigitada4;
        [XmlElement(ElementName = "QTDIGITADA4", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,16)]
        public decimal Qtdigitada4
        {
            get { return  qtdigitada4; }
            set {  qtdigitada4 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCInventdig()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCINVENTDIG";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCInventdig> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCInventdig>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCInventdig> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCInventdig>(where);
        }

        #endregion
    }
}
