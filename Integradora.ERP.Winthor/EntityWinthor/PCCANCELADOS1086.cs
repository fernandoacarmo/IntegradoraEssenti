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
    /// Classe referente a tabela PCCancelados1086
    /// </summary>
    [XmlType("PCCANCELADOS1086")]
    public class PCCancelados1086 : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: AIDF
        /// Comentário: 
        /// </summary>
        private string aidf;
        [XmlElement(ElementName = "AIDF", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public string Aidf
        {
            get { return  aidf; }
            set {  aidf = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODCANC
        /// Comentário: 
        /// </summary>
        private decimal codcanc;
        [XmlElement(ElementName = "CODCANC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codcanc
        {
            get { return  codcanc; }
            set {  codcanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODFILIAL
        /// Comentário: Filial do documento cancelado (rotina 1086). 
        /// </summary>
        private string codfilial;
        [XmlElement(ElementName = "CODFILIAL", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Codfilial
        {
            get { return  codfilial; }
            set {  codfilial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACANC
        /// Comentário: 
        /// </summary>
        private DateTime? datacanc;
        [XmlElement(ElementName = "DATACANC", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacanc
        {
            get { return  datacanc; }
            set {  datacanc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DISPOSITIVO
        /// Comentário: 
        /// </summary>
        private string dispositivo;
        [XmlElement(ElementName = "DISPOSITIVO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Dispositivo
        {
            get { return  dispositivo; }
            set {  dispositivo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MODELO
        /// Comentário: 
        /// </summary>
        private string modelo;
        [XmlElement(ElementName = "MODELO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Modelo
        {
            get { return  modelo; }
            set {  modelo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMULARIO1
        /// Comentário: 
        /// </summary>
        private decimal numformulario1;
        [XmlElement(ElementName = "NUMFORMULARIO1", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numformulario1
        {
            get { return  numformulario1; }
            set {  numformulario1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMFORMULARIO2
        /// Comentário: 
        /// </summary>
        private decimal numformulario2;
        [XmlElement(ElementName = "NUMFORMULARIO2", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,20)]
        public decimal Numformulario2
        {
            get { return  numformulario2; }
            set {  numformulario2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMNOTA
        /// Comentário: 
        /// </summary>
        private decimal numnota;
        [XmlElement(ElementName = "NUMNOTA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Numnota
        {
            get { return  numnota; }
            set {  numnota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SERIE
        /// Comentário: 
        /// </summary>
        private string serie;
        [XmlElement(ElementName = "SERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,3)]
        public string Serie
        {
            get { return  serie; }
            set {  serie = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SITUACAO
        /// Comentário: 
        /// </summary>
        private string situacao;
        [XmlElement(ElementName = "SITUACAO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Situacao
        {
            get { return  situacao; }
            set {  situacao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SUBSERIE
        /// Comentário: 
        /// </summary>
        private string subserie;
        [XmlElement(ElementName = "SUBSERIE", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Subserie
        {
            get { return  subserie; }
            set {  subserie = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCCancelados1086()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCANCELADOS1086";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCCancelados1086> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCancelados1086>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCCancelados1086> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCancelados1086>(where);
        }

        #endregion
    }
}
