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
    /// Classe referente a tabela PCDesd
    /// </summary>
    [XmlType("PCDESD")]
    public class PCDesd : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLIDEST
        /// Comentário: 
        /// </summary>
        private decimal codclidest;
        [XmlElement(ElementName = "CODCLIDEST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codclidest
        {
            get { return  codclidest; }
            set {  codclidest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLIORIG
        /// Comentário: 
        /// </summary>
        private decimal codcliorig;
        [XmlElement(ElementName = "CODCLIORIG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcliorig
        {
            get { return  codcliorig; }
            set {  codcliorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCCXMOT
        /// Comentário: 
        /// </summary>
        private decimal codfunccxmot;
        [XmlElement(ElementName = "CODFUNCCXMOT", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,8)]
        public decimal Codfunccxmot
        {
            get { return  codfunccxmot; }
            set {  codfunccxmot = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODROTINA
        /// Comentário: Código da rotina onde o desdobramento foi efetuado. 
        /// </summary>
        private decimal codrotina;
        [XmlElement(ElementName = "CODROTINA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codrotina
        {
            get { return  codrotina; }
            set {  codrotina = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTLANC
        /// Comentário: 
        /// </summary>
        private DateTime? dtlanc;
        [XmlElement(ElementName = "DTLANC", DataType = "DATE", IsNullable = false)]
        [DataObjectField(false,false,false,7)]
        public DateTime? Dtlanc
        {
            get { return  dtlanc; }
            set {  dtlanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTULTALT
        /// Comentário: 
        /// </summary>
        private DateTime? dtultalt;
        [XmlElement(ElementName = "DTULTALT", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtultalt
        {
            get { return  dtultalt; }
            set {  dtultalt = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDADEST
        /// Comentário: 
        /// </summary>
        private decimal numtransvendadest;
        [XmlElement(ElementName = "NUMTRANSVENDADEST", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransvendadest
        {
            get { return  numtransvendadest; }
            set {  numtransvendadest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMTRANSVENDAORIG
        /// Comentário: 
        /// </summary>
        private decimal numtransvendaorig;
        [XmlElement(ElementName = "NUMTRANSVENDAORIG", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Numtransvendaorig
        {
            get { return  numtransvendaorig; }
            set {  numtransvendaorig = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTDEST
        /// Comentário: 
        /// </summary>
        private string prestdest;
        [XmlElement(ElementName = "PRESTDEST", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Prestdest
        {
            get { return  prestdest; }
            set {  prestdest = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PRESTORIG
        /// Comentário: 
        /// </summary>
        private string prestorig;
        [XmlElement(ElementName = "PRESTORIG", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public string Prestorig
        {
            get { return  prestorig; }
            set {  prestorig = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCDesd()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCDESD";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCDesd> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCDesd>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCDesd> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCDesd>(where);
        }

        #endregion
    }
}
