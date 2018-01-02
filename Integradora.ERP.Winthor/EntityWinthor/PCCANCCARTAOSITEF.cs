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
    /// Classe referente a tabela PCCanccartaositef
    /// </summary>
    [XmlType("PCCANCCARTAOSITEF")]
    public class PCCanccartaositef : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODFUNC
        /// Coment�rio: C�digo Funcion�rio
        /// </summary>
        private decimal codfunc;
        [XmlElement(ElementName = "CODFUNC", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codfunc
        {
            get { return  codfunc; }
            set {  codfunc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODSUPERV
        /// Coment�rio: C�digo Supervisor
        /// </summary>
        private decimal codsuperv;
        [XmlElement(ElementName = "CODSUPERV", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,6)]
        public decimal Codsuperv
        {
            get { return  codsuperv; }
            set {  codsuperv = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DATA
        /// Coment�rio: Data
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
        /// Propriedade referente ao campo: HORA
        /// Coment�rio: Hora
        /// </summary>
        private string hora;
        [XmlElement(ElementName = "HORA", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,8)]
        public string Hora
        {
            get { return  hora; }
            set {  hora = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NSU
        /// Coment�rio: NSU
        /// </summary>
        private string nsu;
        [XmlElement(ElementName = "NSU", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Nsu
        {
            get { return  nsu; }
            set {  nsu = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMSEQ
        /// Coment�rio: N�m. Sequ�ncia
        /// </summary>
        private string numseq;
        [XmlElement(ElementName = "NUMSEQ", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,15)]
        public string Numseq
        {
            get { return  numseq; }
            set {  numseq = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: VALOR
        /// Coment�rio: Valor
        /// </summary>
        private decimal valor;
        [XmlElement(ElementName = "VALOR", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Valor
        {
            get { return  valor; }
            set {  valor = value; }
        }

        #endregion

        #region M�todos
        /// <summary>
        /// M�todo create
        /// </summary>
        public PCCanccartaositef()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCCANCCARTAOSITEF";
        }

        /// <summary>
        /// Obter lista do objeto, com condi��o de pesquisa
        /// </summary>
        public static List<PCCanccartaositef> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCCanccartaositef>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condi��o de pesquisa
        /// </summary>
        public static List<PCCanccartaositef> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCCanccartaositef>(where);
        }

        #endregion
    }
}
