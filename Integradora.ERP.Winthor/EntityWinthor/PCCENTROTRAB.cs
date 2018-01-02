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
    /// Classe referente a tabela PCCentrotrab
    /// </summary>
    [XmlType("PCCENTROTRAB")]
    public class PCCentrotrab : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCENTROTRAB
        /// Comentário: 
        /// </summary>
        private decimal codcentrotrab;
        [XmlElement(ElementName = "CODCENTROTRAB", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcentrotrab
        {
            get { return  codcentrotrab; }
            set {  codcentrotrab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: EFICIENCIAOPERACIONAL
        /// Comentário: 
        /// </summary>
        private decimal eficienciaoperacional;
        [XmlElement(ElementName = "EFICIENCIAOPERACIONAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Eficienciaoperacional
        {
            get { return  eficienciaoperacional; }
            set {  eficienciaoperacional = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORASPORTURNO
        /// Comentário: 
        /// </summary>
        private decimal horasporturno;
        [XmlElement(ElementName = "HORASPORTURNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Horasporturno
        {
            get { return  horasporturno; }
            set {  horasporturno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMDIASTRABSEMANA
        /// Comentário: 
        /// </summary>
        private decimal numdiastrabsemana;
        [XmlElement(ElementName = "NUMDIASTRABSEMANA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numdiastrabsemana
        {
            get { return  numdiastrabsemana; }
            set {  numdiastrabsemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMPESSOASTURNO
        /// Comentário: 
        /// </summary>
        private decimal numpessoasturno;
        [XmlElement(ElementName = "NUMPESSOASTURNO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numpessoasturno
        {
            get { return  numpessoasturno; }
            set {  numpessoasturno = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTURNODIA
        /// Comentário: 
        /// </summary>
        private decimal numturnodia;
        [XmlElement(ElementName = "NUMTURNODIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Numturnodia
        {
            get { return  numturnodia; }
            set {  numturnodia = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCentrotrab()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCENTROTRAB";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCentrotrab> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCentrotrab>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCentrotrab> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCentrotrab>(where);
        }

        #endregion
    }
}
