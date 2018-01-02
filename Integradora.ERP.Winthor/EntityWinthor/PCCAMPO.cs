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
    /// Classe referente a tabela PCCampo
    /// </summary>
    [XmlType("PCCAMPO")]
    public class PCCampo : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMPOCHAVE
        /// Comentário: 
        /// </summary>
        private string campochave;
        [XmlElement(ElementName = "CAMPOCHAVE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Campochave
        {
            get { return  campochave; }
            set {  campochave = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCAMPO
        /// Comentário: 
        /// </summary>
        private decimal codcampo;
        [XmlElement(ElementName = "CODCAMPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codcampo
        {
            get { return  codcampo; }
            set {  codcampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODTABELA
        /// Comentário: 
        /// </summary>
        private decimal codtabela;
        [XmlElement(ElementName = "CODTABELA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codtabela
        {
            get { return  codtabela; }
            set {  codtabela = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DECIMAIS
        /// Comentário: 
        /// </summary>
        private decimal decimais;
        [XmlElement(ElementName = "DECIMAIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Decimais
        {
            get { return  decimais; }
            set {  decimais = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCAMPO
        /// Comentário: 
        /// </summary>
        private string descampo;
        [XmlElement(ElementName = "DESCAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,50)]
        public string Descampo
        {
            get { return  descampo; }
            set {  descampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DETALHES
        /// Comentário: 
        /// </summary>
        private string detalhes;
        [XmlElement(ElementName = "DETALHES", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1000)]
        public string Detalhes
        {
            get { return  detalhes; }
            set {  detalhes = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ESPECIFICO
        /// Comentário: 
        /// </summary>
        private string especifico;
        [XmlElement(ElementName = "ESPECIFICO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public string Especifico
        {
            get { return  especifico; }
            set {  especifico = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NOMCAMPO
        /// Comentário: 
        /// </summary>
        private string nomcampo;
        [XmlElement(ElementName = "NOMCAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Nomcampo
        {
            get { return  nomcampo; }
            set {  nomcampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TAMANHO
        /// Comentário: 
        /// </summary>
        private decimal tamanho;
        [XmlElement(ElementName = "TAMANHO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Tamanho
        {
            get { return  tamanho; }
            set {  tamanho = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPCAMPO
        /// Comentário: 
        /// </summary>
        private string tipcampo;
        [XmlElement(ElementName = "TIPCAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public string Tipcampo
        {
            get { return  tipcampo; }
            set {  tipcampo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCampo()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCAMPO";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCampo> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCampo>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCampo> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCampo>(where);
        }

        #endregion
    }
}
