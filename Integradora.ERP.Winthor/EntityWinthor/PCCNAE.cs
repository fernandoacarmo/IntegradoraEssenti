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
    /// Classe referente a tabela PCCnae
    /// </summary>
    [XmlType("PCCNAE")]
    public class PCCnae : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODATIV1
        /// Coment�rio: C�digo Atividade. 
        /// </summary>
        private decimal codativ1;
        [XmlElement(ElementName = "CODATIV1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codativ1
        {
            get { return  codativ1; }
            set {  codativ1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCNAE
        /// Coment�rio: C�digo Nacional Atividade Econ�mica. 
        /// </summary>
        private string codcnae;
        [XmlElement(ElementName = "CODCNAE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,60)]
        public string Codcnae
        {
            get { return  codcnae; }
            set {  codcnae = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCCNAE
        /// Coment�rio: Descri��o Nacional Atividade Econ�mica. 
        /// </summary>
        private string desccnae;
        [XmlElement(ElementName = "DESCCNAE", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,250)]
        public string Desccnae
        {
            get { return  desccnae; }
            set {  desccnae = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MARGEMMVA
        /// Coment�rio: Margem de lucro
        /// </summary>
        private decimal margemmva;
        [XmlElement(ElementName = "MARGEMMVA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Margemmva
        {
            get { return  margemmva; }
            set {  margemmva = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCARGATRIBMEDIA
        /// Coment�rio: Percentual de carga tribut�ria m�dia
        /// </summary>
        private decimal percargatribmedia;
        [XmlElement(ElementName = "PERCARGATRIBMEDIA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percargatribmedia
        {
            get { return  percargatribmedia; }
            set {  percargatribmedia = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCnae()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCNAE";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCnae> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCnae>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCnae> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCnae>(where);
        }

        #endregion
    }
}
