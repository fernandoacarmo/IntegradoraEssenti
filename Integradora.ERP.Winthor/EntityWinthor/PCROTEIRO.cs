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
    /// Classe referente a tabela PCRoteiro
    /// </summary>
    [XmlType("PCROTEIRO")]
    public class PCRoteiro : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Coment�rio: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEMANA
        /// Coment�rio: 
        /// </summary>
        private string diasemana;
        [XmlElement(ElementName = "DIASEMANA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Diasemana
        {
            get { return  diasemana; }
            set {  diasemana = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTABERTURA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtabertura;
        [XmlElement(ElementName = "DTABERTURA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtabertura
        {
            get { return  dtabertura; }
            set {  dtabertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTENCERRA
        /// Coment�rio: 
        /// </summary>
        private DateTime? dtencerra;
        [XmlElement(ElementName = "DTENCERRA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtencerra
        {
            get { return  dtencerra; }
            set {  dtencerra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRABERTURA
        /// Coment�rio: 
        /// </summary>
        private decimal hrabertura;
        [XmlElement(ElementName = "HRABERTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Hrabertura
        {
            get { return  hrabertura; }
            set {  hrabertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HRENCERRA
        /// Coment�rio: 
        /// </summary>
        private decimal hrencerra;
        [XmlElement(ElementName = "HRENCERRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Hrencerra
        {
            get { return  hrencerra; }
            set {  hrencerra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOABERTURA
        /// Coment�rio: 
        /// </summary>
        private decimal minutoabertura;
        [XmlElement(ElementName = "MINUTOABERTURA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoabertura
        {
            get { return  minutoabertura; }
            set {  minutoabertura = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MINUTOENCERRA
        /// Coment�rio: 
        /// </summary>
        private decimal minutoencerra;
        [XmlElement(ElementName = "MINUTOENCERRA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Minutoencerra
        {
            get { return  minutoencerra; }
            set {  minutoencerra = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: OBS
        /// Coment�rio: 
        /// </summary>
        private string obs;
        [XmlElement(ElementName = "OBS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Obs
        {
            get { return  obs; }
            set {  obs = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCRoteiro()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCROTEIRO";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCRoteiro> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCRoteiro>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCRoteiro> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCRoteiro>(where);
        }

        #endregion
    }
}
