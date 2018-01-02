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
    /// Classe referente a tabela PCFvendai
    /// </summary>
    [XmlType("PCFVENDAI")]
    public class PCFvendai : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CAMPO
        /// Comentário: 
        /// </summary>
        private string campo;
        [XmlElement(ElementName = "CAMPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,30)]
        public string Campo
        {
            get { return  campo; }
            set {  campo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODARQ
        /// Comentário: 
        /// </summary>
        private decimal codarq;
        [XmlElement(ElementName = "CODARQ", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codarq
        {
            get { return  codarq; }
            set {  codarq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCAMPO
        /// Comentário: 
        /// </summary>
        private decimal codcampo;
        [XmlElement(ElementName = "CODCAMPO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,6)]
        public decimal Codcampo
        {
            get { return  codcampo; }
            set {  codcampo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: QTCASASDEC
        /// Comentário: 
        /// </summary>
        private decimal qtcasasdec;
        [XmlElement(ElementName = "QTCASASDEC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Qtcasasdec
        {
            get { return  qtcasasdec; }
            set {  qtcasasdec = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUGERIDO
        /// Comentário: Informa se o item foi sugerido
        /// </summary>
        private string sugerido;
        [XmlElement(ElementName = "SUGERIDO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Sugerido
        {
            get { return  sugerido; }
            set {  sugerido = value; }
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
        /// Propriedade referente ao campo: TIPO
        /// Comentário: 
        /// </summary>
        private string tipo;
        [XmlElement(ElementName = "TIPO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Tipo
        {
            get { return  tipo; }
            set {  tipo = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCFvendai()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCFVENDAI";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCFvendai> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCFvendai>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCFvendai> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCFvendai>(where);
        }

        #endregion
    }
}
