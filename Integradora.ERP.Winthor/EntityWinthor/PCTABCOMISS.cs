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
    /// Classe referente a tabela PCTabcomiss
    /// </summary>
    [XmlType("PCTABCOMISS")]
    public class PCTabcomiss : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFAIXA
        /// Comentário: 
        /// </summary>
        private decimal codfaixa;
        [XmlElement(ElementName = "CODFAIXA", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codfaixa
        {
            get { return  codfaixa; }
            set {  codfaixa = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: INDICE
        /// Comentário: 
        /// </summary>
        private decimal indice;
        [XmlElement(ElementName = "INDICE", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,18)]
        public decimal Indice
        {
            get { return  indice; }
            set {  indice = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: LETRACOMISS
        /// Comentário: 
        /// </summary>
        private string letracomiss;
        [XmlElement(ElementName = "LETRACOMISS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public string Letracomiss
        {
            get { return  letracomiss; }
            set {  letracomiss = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCFIM
        /// Comentário: 
        /// </summary>
        private decimal percdescfim;
        [XmlElement(ElementName = "PERCDESCFIM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Percdescfim
        {
            get { return  percdescfim; }
            set {  percdescfim = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCDESCINI
        /// Comentário: 
        /// </summary>
        private decimal percdescini;
        [XmlElement(ElementName = "PERCDESCINI", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(false,false,false,10)]
        public decimal Percdescini
        {
            get { return  percdescini; }
            set {  percdescini = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMEXT
        /// Comentário: 
        /// </summary>
        private decimal percomext;
        [XmlElement(ElementName = "PERCOMEXT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomext
        {
            get { return  percomext; }
            set {  percomext = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMINT
        /// Comentário: 
        /// </summary>
        private decimal percomint;
        [XmlElement(ElementName = "PERCOMINT", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomint
        {
            get { return  percomint; }
            set {  percomint = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: PERCOMREP
        /// Comentário: 
        /// </summary>
        private decimal percomrep;
        [XmlElement(ElementName = "PERCOMREP", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public decimal Percomrep
        {
            get { return  percomrep; }
            set {  percomrep = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: TIPOAPLICCOMISS
        /// Comentário: 
        /// </summary>
        private string tipoapliccomiss;
        [XmlElement(ElementName = "TIPOAPLICCOMISS", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,1)]
        public string Tipoapliccomiss
        {
            get { return  tipoapliccomiss; }
            set {  tipoapliccomiss = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCTabcomiss()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCTABCOMISS";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCTabcomiss> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCTabcomiss>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCTabcomiss> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCTabcomiss>(where);
        }

        #endregion
    }
}
