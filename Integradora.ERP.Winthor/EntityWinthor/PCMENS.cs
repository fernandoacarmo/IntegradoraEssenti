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
    /// Classe referente a tabela PCMens
    /// </summary>
    [XmlType("PCMENS")]
    public class PCMens : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNCEMITE
        /// Comentário: 
        /// </summary>
        private decimal codfuncemite;
        [XmlElement(ElementName = "CODFUNCEMITE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Codfuncemite
        {
            get { return  codfuncemite; }
            set {  codfuncemite = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
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
        /// Propriedade referente ao campo: DATA
        /// Comentário: 
        /// </summary>
        private DateTime? data;
        [XmlElement(ElementName = "DATA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Data
        {
            get { return  data; }
            set {  data = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATACOMPLETA
        /// Comentário: Indica a data e hora da mensagem.|Campo do tipo data. 
        /// </summary>
        private DateTime? datacompleta;
        [XmlElement(ElementName = "DATACOMPLETA", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Datacompleta
        {
            get { return  datacompleta; }
            set {  datacompleta = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATAENVIOMENS
        /// Comentário: Data de envio da mensagem ao Rca
        /// </summary>
        private DateTime? dataenviomens;
        [XmlElement(ElementName = "DATAENVIOMENS", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dataenviomens
        {
            get { return  dataenviomens; }
            set {  dataenviomens = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: ENVIADO
        /// Comentário: 
        /// </summary>
        private string enviado;
        [XmlElement(ElementName = "ENVIADO", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Enviado
        {
            get { return  enviado; }
            set {  enviado = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS1
        /// Comentário: 
        /// </summary>
        private string mens1;
        [XmlElement(ElementName = "MENS1", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens1
        {
            get { return  mens1; }
            set {  mens1 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS2
        /// Comentário: 
        /// </summary>
        private string mens2;
        [XmlElement(ElementName = "MENS2", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens2
        {
            get { return  mens2; }
            set {  mens2 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS3
        /// Comentário: 
        /// </summary>
        private string mens3;
        [XmlElement(ElementName = "MENS3", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens3
        {
            get { return  mens3; }
            set {  mens3 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS4
        /// Comentário: 
        /// </summary>
        private string mens4;
        [XmlElement(ElementName = "MENS4", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens4
        {
            get { return  mens4; }
            set {  mens4 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS5
        /// Comentário: 
        /// </summary>
        private string mens5;
        [XmlElement(ElementName = "MENS5", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens5
        {
            get { return  mens5; }
            set {  mens5 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS6
        /// Comentário: 
        /// </summary>
        private string mens6;
        [XmlElement(ElementName = "MENS6", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens6
        {
            get { return  mens6; }
            set {  mens6 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS7
        /// Comentário: 
        /// </summary>
        private string mens7;
        [XmlElement(ElementName = "MENS7", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens7
        {
            get { return  mens7; }
            set {  mens7 = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: MENS8
        /// Comentário: 
        /// </summary>
        private string mens8;
        [XmlElement(ElementName = "MENS8", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,60)]
        public string Mens8
        {
            get { return  mens8; }
            set {  mens8 = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCMens()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCMENS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCMens> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCMens>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCMens> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCMens>(where);
        }

        #endregion
    }
}
