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
    /// Classe referente a tabela PCLfpisreg0112
    /// </summary>
    [XmlType("PCLFPISREG0112")]
    public class PCLfpisreg0112 : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Coment�rio: C�digo da Filial.
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
        /// Propriedade referente ao campo: DATAFIM
        /// Coment�rio: Data Final do Per�odo Selecionado.
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
        /// Coment�rio: Data Inicial do Per�odo Selecionado.
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
        /// Propriedade referente ao campo: INDST
        /// Coment�rio: Indicador de Situa��o Tribut�ria.
        /// </summary>
        private decimal indst;
        [XmlElement(ElementName = "INDST", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public decimal Indst
        {
            get { return  indst; }
            set {  indst = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERRECBRUCUM
        /// Coment�rio: Percentual do Rateio da Receita Bruta Cumulativa.
        /// </summary>
        private decimal perrecbrucum;
        [XmlElement(ElementName = "PERRECBRUCUM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Perrecbrucum
        {
            get { return  perrecbrucum; }
            set {  perrecbrucum = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERRECBRUEXP
        /// Coment�rio: Percentual do Rateio da Receita Bruta N�o Cumulativa - Exporta��o.
        /// </summary>
        private decimal perrecbruexp;
        [XmlElement(ElementName = "PERRECBRUEXP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Perrecbruexp
        {
            get { return  perrecbruexp; }
            set {  perrecbruexp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERRECBRUNTMI
        /// Coment�rio: Percentual do Rateio da Receita Bruta N�o-Cumulativa � N�o Tributada no Mercado Interno.
        /// </summary>
        private decimal perrecbruntmi;
        [XmlElement(ElementName = "PERRECBRUNTMI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Perrecbruntmi
        {
            get { return  perrecbruntmi; }
            set {  perrecbruntmi = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERRECBRUTRIBMI
        /// Coment�rio: Percentual do Rateio da Receita Bruta N�o-Cumulativa - Tributada no Mercado Interno.
        /// </summary>
        private decimal perrecbrutribmi;
        [XmlElement(ElementName = "PERRECBRUTRIBMI", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public decimal Perrecbrutribmi
        {
            get { return  perrecbrutribmi; }
            set {  perrecbrutribmi = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCLfpisreg0112()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLFPISREG0112";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCLfpisreg0112> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLfpisreg0112>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCLfpisreg0112> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLfpisreg0112>(where);
        }

        #endregion
    }
}
