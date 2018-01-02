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
    /// Classe referente a tabela PCGondolac
    /// </summary>
    [XmlType("PCGONDOLAC")]
    public class PCGondolac : OracleTable
    {
        #region Atributos

        /// <summary>
        /// Propriedade referente ao campo: CODCLI
        /// Comentário: 
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
        /// Propriedade referente ao campo: CODCONC
        /// Comentário: 
        /// </summary>
        private string codconc;
        [XmlElement(ElementName = "CODCONC", DataType = "VARCHAR2", IsNullable = true)]
        [DataObjectField(false,false,true,4)]
        public string Codconc
        {
            get { return  codconc; }
            set {  codconc = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: CODUSUR
        /// Comentário: 
        /// </summary>
        private decimal codusur;
        [XmlElement(ElementName = "CODUSUR", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,4)]
        public decimal Codusur
        {
            get { return  codusur; }
            set {  codusur = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: DTCONTAGEM
        /// Comentário: 
        /// </summary>
        private DateTime? dtcontagem;
        [XmlElement(ElementName = "DTCONTAGEM", DataType = "DATE", IsNullable = true)]
        [DataObjectField(false,false,true,7)]
        public DateTime? Dtcontagem
        {
            get { return  dtcontagem; }
            set {  dtcontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAFINAL
        /// Comentário: 
        /// </summary>
        private decimal horafinal;
        [XmlElement(ElementName = "HORAFINAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horafinal
        {
            get { return  horafinal; }
            set {  horafinal = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: HORAINICIAL
        /// Comentário: 
        /// </summary>
        private decimal horainicial;
        [XmlElement(ElementName = "HORAINICIAL", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,2)]
        public decimal Horainicial
        {
            get { return  horainicial; }
            set {  horainicial = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMCONTAGEM
        /// Comentário: 
        /// </summary>
        private decimal numcontagem;
        [XmlElement(ElementName = "NUMCONTAGEM", DataType = "NUMBER", IsNullable = false)]
        [DataObjectField(true,false,false,8)]
        public decimal Numcontagem
        {
            get { return  numcontagem; }
            set {  numcontagem = value; }
        }

        /// <summary>
        /// Propriedade referente ao campo: NUMVISITA
        /// Comentário: Numero da visita
        /// </summary>
        private decimal numvisita;
        [XmlElement(ElementName = "NUMVISITA", DataType = "NUMBER", IsNullable = true)]
        [DataObjectField(false,false,true,10)]
        public decimal Numvisita
        {
            get { return  numvisita; }
            set {  numvisita = value; }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Método create
        /// </summary>
        public PCGondolac()
        {
        }

        /// <summary>
        /// Obter nome da tabela
        /// </summary>
        public override string GetTableName()
        {
            return "PCGONDOLAC";
        }

        /// <summary>
        /// Obter lista do objeto, com condição de pesquisa
        /// </summary>
        public static List<PCGondolac> Listar(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Listar<PCGondolac>(where);
        }

        /// <summary>
        /// Obter lista do objeto, sem condição de pesquisa
        /// </summary>
        public static List<PCGondolac> Listar()
        {
            return Listar("1=1");
        }

        /// <summary>
        /// Verificar se o registro existe
        /// </summary>
        public static bool Existe(string where)
        {
            Persistencia ba = new Persistencia(GetStringConnection());
            return ba.Existe<PCGondolac>(where);
        }

        #endregion
    }
}
