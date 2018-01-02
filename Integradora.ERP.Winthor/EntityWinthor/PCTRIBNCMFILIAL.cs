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
    /// Classe referente a tabela PCTribncmfilial
    /// </summary>
    [XmlType("PCTRIBNCMFILIAL")]
    public class PCTribncmfilial : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: CODIGO FILIAL
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
        /// Propriedade referente ao campo: CODNCM
        /// Comentário: CODIGO NCM
        /// </summary>
        private string codncm;
        [XmlElement(ElementName = "CODNCM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,15)]
        public string Codncm
        {
            get { return  codncm; }
            set {  codncm = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTFISICA
        /// Comentário: PERCENTUAL PESSOA FISICA
        /// </summary>
        private decimal percentfisica;
        [XmlElement(ElementName = "PERCENTFISICA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percentfisica
        {
            get { return  percentfisica; }
            set {  percentfisica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTFISICAIMPORTADO
        /// Comentário: % de Pessoa Física para produtos Importados
        /// </summary>
        private decimal percentfisicaimportado;
        [XmlElement(ElementName = "PERCENTFISICAIMPORTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percentfisicaimportado
        {
            get { return  percentfisicaimportado; }
            set {  percentfisicaimportado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTJURIDICA
        /// Comentário: PERCENTUAL PESSOA JURIDICA
        /// </summary>
        private decimal percentjuridica;
        [XmlElement(ElementName = "PERCENTJURIDICA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percentjuridica
        {
            get { return  percentjuridica; }
            set {  percentjuridica = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCENTJURIDICAIMPORTADO
        /// Comentário: % de Pessoa Juridica para produtos importados
        /// </summary>
        private decimal percentjuridicaimportado;
        [XmlElement(ElementName = "PERCENTJURIDICAIMPORTADO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public decimal Percentjuridicaimportado
        {
            get { return  percentjuridicaimportado; }
            set {  percentjuridicaimportado = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTribncmfilial()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTRIBNCMFILIAL";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTribncmfilial> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTribncmfilial>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTribncmfilial> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTribncmfilial>(where);
        }

        #endregion
    }
}
