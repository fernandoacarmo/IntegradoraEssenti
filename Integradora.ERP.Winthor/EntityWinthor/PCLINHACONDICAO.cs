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
    /// Classe referente a tabela PCLinhacondicao
    /// </summary>
    [XmlType("PCLINHACONDICAO")]
    public class PCLinhacondicao : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: BSMNIVELVENDA
        /// Comentário: 
        /// </summary>
        private decimal bsmnivelvenda;
        [XmlElement(ElementName = "BSMNIVELVENDA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Bsmnivelvenda
        {
            get { return  bsmnivelvenda; }
            set {  bsmnivelvenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCONDICAOVENDA
        /// Comentário: 
        /// </summary>
        private decimal codcondicaovenda;
        [XmlElement(ElementName = "CODCONDICAOVENDA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcondicaovenda
        {
            get { return  codcondicaovenda; }
            set {  codcondicaovenda = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODLINHAPROD
        /// Comentário: 
        /// </summary>
        private decimal codlinhaprod;
        [XmlElement(ElementName = "CODLINHAPROD", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codlinhaprod
        {
            get { return  codlinhaprod; }
            set {  codlinhaprod = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCBONIFIC
        /// Comentário: 
        /// </summary>
        private decimal percbonific;
        [XmlElement(ElementName = "PERCBONIFIC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percbonific
        {
            get { return  percbonific; }
            set {  percbonific = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCCOMISS
        /// Comentário: 
        /// </summary>
        private decimal perccomiss;
        [XmlElement(ElementName = "PERCCOMISS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Perccomiss
        {
            get { return  perccomiss; }
            set {  perccomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCCOM
        /// Comentário: 
        /// </summary>
        private decimal percdesccom;
        [XmlElement(ElementName = "PERCDESCCOM", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdesccom
        {
            get { return  percdesccom; }
            set {  percdesccom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFIN
        /// Comentário: 
        /// </summary>
        private decimal percdescfin;
        [XmlElement(ElementName = "PERCDESCFIN", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescfin
        {
            get { return  percdescfin; }
            set {  percdescfin = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFLEX
        /// Comentário: 
        /// </summary>
        private decimal percdescflex;
        [XmlElement(ElementName = "PERCDESCFLEX", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percdescflex
        {
            get { return  percdescflex; }
            set {  percdescflex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMSUP
        /// Comentário: 
        /// </summary>
        private decimal percomsup;
        [XmlElement(ElementName = "PERCOMSUP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomsup
        {
            get { return  percomsup; }
            set {  percomsup = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCLinhacondicao()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCLINHACONDICAO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCLinhacondicao> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCLinhacondicao>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCLinhacondicao> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCLinhacondicao>(where);
        }

        #endregion
    }
}
