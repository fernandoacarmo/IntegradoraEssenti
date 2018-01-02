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
    /// Classe referente a tabela PCWmsconfintegracao
    /// </summary>
    [XmlType("PCWMSCONFINTEGRACAO")]
    public class PCWmsconfintegracao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCALTPARAM
        /// Comentário: 
        /// </summary>
        private decimal codfuncaltparam;
        [XmlElement(ElementName = "CODFUNCALTPARAM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Codfuncaltparam
        {
            get { return  codfuncaltparam; }
            set {  codfuncaltparam = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAOPARAM
        /// Comentário: 
        /// </summary>
        private string descricaoparam;
        [XmlElement(ElementName = "DESCRICAOPARAM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,25)]
        public string Descricaoparam
        {
            get { return  descricaoparam; }
            set {  descricaoparam = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTALTERACAOPARAM
        /// Comentário: 
        /// </summary>
        private DateTime? dtalteracaoparam;
        [XmlElement(ElementName = "DTALTERACAOPARAM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtalteracaoparam
        {
            get { return  dtalteracaoparam; }
            set {  dtalteracaoparam = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTINCLUSAOPARAM
        /// Comentário: 
        /// </summary>
        private DateTime? dtinclusaoparam;
        [XmlElement(ElementName = "DTINCLUSAOPARAM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtinclusaoparam
        {
            get { return  dtinclusaoparam; }
            set {  dtinclusaoparam = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMGER
        /// Comentário: 
        /// </summary>
        private decimal numger;
        [XmlElement(ElementName = "NUMGER", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numger
        {
            get { return  numger; }
            set {  numger = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOPARAM
        /// Comentário: 
        /// </summary>
        private string tipoparam;
        [XmlElement(ElementName = "TIPOPARAM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,25)]
        public string Tipoparam
        {
            get { return  tipoparam; }
            set {  tipoparam = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORERPPARAM
        /// Comentário: 
        /// </summary>
        private string valorerpparam;
        [XmlElement(ElementName = "VALORERPPARAM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,25)]
        public string Valorerpparam
        {
            get { return  valorerpparam; }
            set {  valorerpparam = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALORWMSPARAM
        /// Comentário: 
        /// </summary>
        private string valorwmsparam;
        [XmlElement(ElementName = "VALORWMSPARAM", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(true,false,false,25)]
        public string Valorwmsparam
        {
            get { return  valorwmsparam; }
            set {  valorwmsparam = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmsconfintegracao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSCONFINTEGRACAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmsconfintegracao> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsconfintegracao.GetStringConnection());
            return ba.Listar<PCWmsconfintegracao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmsconfintegracao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsconfintegracao.GetStringConnection());
            return ba.Existe<PCWmsconfintegracao>(where);
        }

        #endregion
    }
}
