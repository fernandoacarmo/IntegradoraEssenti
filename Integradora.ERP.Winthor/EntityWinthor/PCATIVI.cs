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
    /// Classe referente a tabela PCAtivi
    /// </summary>
    [XmlType("PCATIVI")]
    public class PCAtivi : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ATACADISTA
        /// Coment�rio: Campo para identifica��o se o ramo de atividade � atacadista ou n�o..
        /// </summary>
        private string atacadista;
        [XmlElement(ElementName = "ATACADISTA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Atacadista
        {
            get { return  atacadista; }
            set {  atacadista = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATIV
        /// Coment�rio: C�digo atividade.
        /// </summary>
        private decimal codativ;
        [XmlElement(ElementName = "CODATIV", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codativ
        {
            get { return  codativ; }
            set {  codativ = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODATIVPRINC
        /// Coment�rio: Indica o c�digo do ramo de atividade principal..
        /// </summary>
        private decimal codativprinc;
        [XmlElement(ElementName = "CODATIVPRINC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codativprinc
        {
            get { return  codativprinc; }
            set {  codativprinc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIABAUDU
        /// Coment�rio: C�digo Categoria BAUDU.
        /// </summary>
        private string codcategoriabaudu;
        [XmlElement(ElementName = "CODCATEGORIABAUDU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Codcategoriabaudu
        {
            get { return  codcategoriabaudu; }
            set {  codcategoriabaudu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCATEGORIAKRAFT
        /// Coment�rio: C�digo categoria KRAFT.
        /// </summary>
        private decimal codcategoriakraft;
        [XmlElement(ElementName = "CODCATEGORIAKRAFT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Codcategoriakraft
        {
            get { return  codcategoriakraft; }
            set {  codcategoriakraft = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCP
        /// Coment�rio: C�digo CP.
        /// </summary>
        private string codcp;
        [XmlElement(ElementName = "CODCP", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Codcp
        {
            get { return  codcp; }
            set {  codcp = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODRAMONESTLE
        /// Coment�rio: C�digo ramo Nestle.
        /// </summary>
        private decimal codramonestle;
        [XmlElement(ElementName = "CODRAMONESTLE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codramonestle
        {
            get { return  codramonestle; }
            set {  codramonestle = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: COR
        /// Coment�rio: Cor.
        /// </summary>
        private string cor;
        [XmlElement(ElementName = "COR", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Cor
        {
            get { return  cor; }
            set {  cor = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESC
        /// Coment�rio: Percentual de desconto.
        /// </summary>
        private decimal percdesc;
        [XmlElement(ElementName = "PERCDESC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,5)]
        public decimal Percdesc
        {
            get { return  percdesc; }
            set {  percdesc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: RAMO
        /// Coment�rio: Ramo.
        /// </summary>
        private string ramo;
        [XmlElement(ElementName = "RAMO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Ramo
        {
            get { return  ramo; }
            set {  ramo = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCAtivi()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCATIVI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCAtivi> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCAtivi>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCAtivi> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCAtivi>(where);
        }

        #endregion
    }
}
