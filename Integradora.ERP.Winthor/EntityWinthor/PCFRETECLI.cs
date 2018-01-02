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
    /// Classe referente a tabela PCFretecli
    /// </summary>
    [XmlType("PCFRETECLI")]
    public class PCFretecli : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: ALIQICMS
        /// Coment�rio: 
        /// </summary>
        private decimal aliqicms;
        [XmlElement(ElementName = "ALIQICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Aliqicms
        {
            get { return  aliqicms; }
            set {  aliqicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Coment�rio: 
        /// </summary>
        private decimal codcli;
        [XmlElement(ElementName = "CODCLI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codcli
        {
            get { return  codcli; }
            set {  codcli = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFORNEC
        /// Coment�rio: 
        /// </summary>
        private decimal codfornec;
        [XmlElement(ElementName = "CODFORNEC", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,6)]
        public decimal Codfornec
        {
            get { return  codfornec; }
            set {  codfornec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCAR
        /// Coment�rio: 
        /// </summary>
        private decimal numcar;
        [XmlElement(ElementName = "NUMCAR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,10)]
        public decimal Numcar
        {
            get { return  numcar; }
            set {  numcar = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFLUVIAL
        /// Coment�rio: 
        /// </summary>
        private decimal vlfluvial;
        [XmlElement(ElementName = "VLFLUVIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfluvial
        {
            get { return  vlfluvial; }
            set {  vlfluvial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal vlfrete;
        [XmlElement(ElementName = "VLFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfrete
        {
            get { return  vlfrete; }
            set {  vlfrete = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLFRETEKGEXCEDENTE
        /// Coment�rio: 
        /// </summary>
        private decimal vlfretekgexcedente;
        [XmlElement(ElementName = "VLFRETEKGEXCEDENTE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlfretekgexcedente
        {
            get { return  vlfretekgexcedente; }
            set {  vlfretekgexcedente = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLGRIS
        /// Coment�rio: 
        /// </summary>
        private decimal vlgris;
        [XmlElement(ElementName = "VLGRIS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlgris
        {
            get { return  vlgris; }
            set {  vlgris = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLICMS
        /// Coment�rio: 
        /// </summary>
        private decimal vlicms;
        [XmlElement(ElementName = "VLICMS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlicms
        {
            get { return  vlicms; }
            set {  vlicms = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLPEDAGIO
        /// Coment�rio: 
        /// </summary>
        private decimal vlpedagio;
        [XmlElement(ElementName = "VLPEDAGIO", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vlpedagio
        {
            get { return  vlpedagio; }
            set {  vlpedagio = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTAS
        /// Coment�rio: 
        /// </summary>
        private decimal vltas;
        [XmlElement(ElementName = "VLTAS", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltas
        {
            get { return  vltas; }
            set {  vltas = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VLTOTALFRETE
        /// Coment�rio: 
        /// </summary>
        private decimal vltotalfrete;
        [XmlElement(ElementName = "VLTOTALFRETE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Vltotalfrete
        {
            get { return  vltotalfrete; }
            set {  vltotalfrete = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCFretecli()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFRETECLI";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCFretecli> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFretecli>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCFretecli> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFretecli>(where);
        }

        #endregion
    }
}
