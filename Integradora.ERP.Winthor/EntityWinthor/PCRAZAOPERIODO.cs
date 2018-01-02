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
    /// Classe referente a tabela PCRazaoperiodo
    /// </summary>
    [XmlType("PCRAZAOPERIODO")]
    public class PCRazaoperiodo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ANO
        /// Coment�rio: 
        /// </summary>
        private decimal ano;
        [XmlElement(ElementName = "ANO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Ano
        {
            get { return  ano; }
            set {  ano = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: 
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
        /// Propriedade referente ao campo: ENCERRADO
        /// Coment�rio: 
        /// </summary>
        private string encerrado;
        [XmlElement(ElementName = "ENCERRADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Encerrado
        {
            get { return  encerrado; }
            set {  encerrado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MES
        /// Coment�rio: 
        /// </summary>
        private decimal mes;
        [XmlElement(ElementName = "MES", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,2)]
        public decimal Mes
        {
            get { return  mes; }
            set {  mes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERIODO
        /// Coment�rio: 
        /// </summary>
        private string periodo;
        [XmlElement(ElementName = "PERIODO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,40)]
        public string Periodo
        {
            get { return  periodo; }
            set {  periodo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRazaoperiodo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCRAZAOPERIODO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRazaoperiodo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRazaoperiodo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRazaoperiodo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRazaoperiodo>(where);
        }

        #endregion
    }
}
