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
    /// Classe referente a tabela PCTabfrete
    /// </summary>
    [XmlType("PCTABFRETE")]
    public class PCTabfrete : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: DISTANCIAFINAL
        /// Comentário: 
        /// </summary>
        private decimal distanciafinal;
        [XmlElement(ElementName = "DISTANCIAFINAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Distanciafinal
        {
            get { return  distanciafinal; }
            set {  distanciafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISTANCIAINICIAL
        /// Comentário: 
        /// </summary>
        private decimal distanciainicial;
        [XmlElement(ElementName = "DISTANCIAINICIAL", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Distanciainicial
        {
            get { return  distanciainicial; }
            set {  distanciainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCSEGURO
        /// Comentário: 
        /// </summary>
        private decimal percseguro;
        [XmlElement(ElementName = "PERCSEGURO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Percseguro
        {
            get { return  percseguro; }
            set {  percseguro = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPORODADO
        /// Comentário: 
        /// </summary>
        private string tiporodado;
        [XmlElement(ElementName = "TIPORODADO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Tiporodado
        {
            get { return  tiporodado; }
            set {  tiporodado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORKG
        /// Comentário: 
        /// </summary>
        private decimal valorkg;
        [XmlElement(ElementName = "VALORKG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Valorkg
        {
            get { return  valorkg; }
            set {  valorkg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORKM
        /// Comentário: 
        /// </summary>
        private decimal valorkm;
        [XmlElement(ElementName = "VALORKM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Valorkm
        {
            get { return  valorkm; }
            set {  valorkm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORM3
        /// Comentário: 
        /// </summary>
        private decimal valorm3;
        [XmlElement(ElementName = "VALORM3", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,18)]
        public decimal Valorm3
        {
            get { return  valorm3; }
            set {  valorm3 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTabfrete()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTABFRETE";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTabfrete> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTabfrete>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTabfrete> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTabfrete>(where);
        }

        #endregion
    }
}
