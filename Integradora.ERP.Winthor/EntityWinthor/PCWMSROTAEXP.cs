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
    /// Classe referente a tabela PCWmsrotaexp
    /// </summary>
    [XmlType("PCWMSROTAEXP")]
    public class PCWmsrotaexp : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODROTA
        /// Comentário: 
        /// </summary>
        private decimal codrota;
        [XmlElement(ElementName = "CODROTA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,4)]
        public decimal Codrota
        {
            get { return  codrota; }
            set {  codrota = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DESCRICAO
        /// Comentário: 
        /// </summary>
        private string descricao;
        [XmlElement(ElementName = "DESCRICAO", DataType = "VARCHAR2", IsNullable = false)]
        [DataObjectField(false,false,false,40)]
        public string Descricao
        {
            get { return  descricao; }
            set {  descricao = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIADOM
        /// Comentário: 
        /// </summary>
        private string diadom;
        [XmlElement(ElementName = "DIADOM", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diadom
        {
            get { return  diadom; }
            set {  diadom = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAQUA
        /// Comentário: 
        /// </summary>
        private string diaqua;
        [XmlElement(ElementName = "DIAQUA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diaqua
        {
            get { return  diaqua; }
            set {  diaqua = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIAQUI
        /// Comentário: 
        /// </summary>
        private string diaqui;
        [XmlElement(ElementName = "DIAQUI", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diaqui
        {
            get { return  diaqui; }
            set {  diaqui = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASAB
        /// Comentário: 
        /// </summary>
        private string diasab;
        [XmlElement(ElementName = "DIASAB", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diasab
        {
            get { return  diasab; }
            set {  diasab = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEG
        /// Comentário: 
        /// </summary>
        private string diaseg;
        [XmlElement(ElementName = "DIASEG", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diaseg
        {
            get { return  diaseg; }
            set {  diaseg = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIASEX
        /// Comentário: 
        /// </summary>
        private string diasex;
        [XmlElement(ElementName = "DIASEX", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diasex
        {
            get { return  diasex; }
            set {  diasex = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DIATER
        /// Comentário: 
        /// </summary>
        private string diater;
        [XmlElement(ElementName = "DIATER", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Diater
        {
            get { return  diater; }
            set {  diater = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTPROCESSAMENTO
        /// Comentário: 
        /// </summary>
        private DateTime? dtprocessamento;
        [XmlElement(ElementName = "DTPROCESSAMENTO", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtprocessamento
        {
            get { return  dtprocessamento; }
            set {  dtprocessamento = value; }
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
        /// Propriedade referente ao campo: SEMAFORO
        /// Comentário: 
        /// </summary>
        private decimal semaforo;
        [XmlElement(ElementName = "SEMAFORO", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,2)]
        public decimal Semaforo
        {
            get { return  semaforo; }
            set {  semaforo = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: SEQENTREGA
        /// Comentário: 
        /// </summary>
        private decimal seqentrega;
        [XmlElement(ElementName = "SEQENTREGA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public decimal Seqentrega
        {
            get { return  seqentrega; }
            set {  seqentrega = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCWmsrotaexp()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCWMSROTAEXP";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCWmsrotaexp> Listar(string where)
        {
            Persistencia ba = new Persistencia(PCWmsrotaexp.GetStringConnection());
            return ba.Listar<PCWmsrotaexp>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCWmsrotaexp> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(PCWmsrotaexp.GetStringConnection());
            return ba.Existe<PCWmsrotaexp>(where);
        }

        #endregion
    }
}
